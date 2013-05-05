using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.GroupManager
{
    public partial class Move : System.Web.UI.Page
    {
        public string TableSink = Common.TableSink;
        public int GroupID = (int)Common.sink("GroupID", MethodType.Get, 255, 1, DataType.Int);
        int ToGroupID = (int)Common.sink("ToGroupID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 255, 0, DataType.Str);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CMD == "Move")
            {
                FrameWorkPermission.CheckPermissionVoid(PopedomType.Edit);
                MoveCat();
            }
            else {
                OutJs();
            }
            
        }
        private void MoveCat()
        {
            
            sys_GroupTable GT = BusinessFacade.sys_GroupDisp(GroupID);
            sys_GroupTable GTTo = BusinessFacade.sys_GroupDisp(ToGroupID);
            int G_ParentID = GT.G_ParentID;

            //�����ƶ����ุ�����ӷ�����
            BusinessFacade.Update_Table_Fileds("sys_Group", "G_ChildCount=G_ChildCount-1", string.Format("GroupID={0}", G_ParentID));

            //�����ƶ�����
            GT.G_ParentID = ToGroupID;
            GT.DB_Option_Action_ = "Update";
            GT.G_ShowOrder = GTTo.G_ChildCount + 1;
            BusinessFacade.sys_GroupInsertUpdate(GT);



            //�����ƶ�������
            if (GTTo.GroupID != 0)
            {
                GTTo.G_ChildCount++;
                GTTo.DB_Option_Action_ = "Update";
                BusinessFacade.sys_GroupInsertUpdate(GTTo);
            }

            //�����ƶ�������
            BusinessFacade.sys_Group_By(ToGroupID);

            //�����ƶ����༰�ӷ������
            string Sub_GroupID = BusinessFacade.GetGroupCatID(GroupID);
            string[] Sub_GroupIDArray = Sub_GroupID.Split(',');
            for (int i = 0; i < Sub_GroupIDArray.Length; i++)
            {
                BusinessFacade.Update_Table_Fileds("sys_Group", string.Format("G_Level=G_Level+{0}+1-{1}",GTTo.G_Level,GT.G_Level), string.Format("GroupID={0}", Sub_GroupIDArray[i]));
            }

            //����ǰ�ƶ�����ĸ�������ӷ���
            BusinessFacade.sys_Group_By(G_ParentID);

            EventMessage.MessageBox(1, "�����ɹ�", string.Format("�ƶ�����({0})�ɹ�!", GT.G_CName), Icon_Type.OK, Common.GetHomeBaseUrl(string.Format("GroupList.aspx?GroupID={0}", ToGroupID)),Common.BuildJs  );


        }

        private void OutJs()
        {
            int TotalRecord = 0;
            string strLink = "";
            int intCount = 0;
            
            QueryParam qp = new QueryParam();
            qp.Where = string.Format("Where G_Delete=0 and GroupID not in({0})",BusinessFacade.GetGroupCatID(GroupID));
            qp.Orderfld = "G_Level,G_ShowOrder";
            qp.OrderType = 0;
            ArrayList lst = BusinessFacade.sys_GroupList(qp, out TotalRecord);
            StringBuilder strSB = new StringBuilder();

            strSB.Append("<script language='JavaScript'>\n");
            //strSB.Append("Fold_id='';\n");

            strSB.Append("treeRoot = gFld(\"mainbody\", \"�����б�\", \"\",\"0\")\n");

            foreach (sys_GroupTable x in lst)
            {
                intCount = intCount + 1;
                strLink = x.GroupID.ToString();
                if (x.G_Level == 1)
                {
                    if (x.G_ChildCount == 0)
                    {

                        strSB.AppendFormat("insDoc(treeRoot,gLnk(\"mainbody\",\"{0}\",\"\",\"{1}\"))\n", Common.ReplaceJs(x.G_CName), strLink);
                    }
                    else
                    {
                        strSB.AppendFormat("N{0}=insFld(treeRoot,gFld(\"mainbody\",\"{1}\",\"\",\"{2}\"))\n", x.GroupID, Common.ReplaceJs(x.G_CName), strLink);
                    }
                }
                else
                {
                    if (x.G_ChildCount == 0)
                    {
                        strSB.AppendFormat("insDoc(N{0},gLnk(\"mainbody\",\"{1}\",\"\",\"{2}\"))\n", x.G_ParentID, Common.ReplaceJs(x.G_CName), strLink);
                    }
                    else
                    {
                        strSB.AppendFormat("N{0}=insFld(N{1},gFld(\"mainbody\",\"{2}\",\"\",\"{3}\"))\n", x.GroupID, x.G_ParentID, Common.ReplaceJs(x.G_CName), strLink);
                    }
                }

            }

            strSB.Append("	initializeDocument();\n");
            strSB.Append("</script>\n");
            ShowScript.Text = strSB.ToString();

        }
    }
}
