using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
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

namespace FrameWork.web.Module.FrameWork.CommonModule
{
    public partial class SelectGroup : System.Web.UI.Page
    {
        public string TableSink = Common.TableSink;
        private sys_UserTable currentUser = UserData.GetUserDate; //当前登录用户

        protected void Page_Load(object sender, EventArgs e)
        {
            OutJs();
        }

        private void OutJs()
        {
            int GroupID = currentUser.U_GroupID;
            int G_Type = 0;
            /*if (UserData.Get_sys_UserTable(currentUser.UserID).U_Type == 0) //判断用户是否为超级用户
                G_Level = 1;*/
            
            int TotalRecord = 0;
            string strLink = "";
            int intCount = 0;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            string GroupIDs  = sys_Group_bll.GetLowerLevelString(GroupID);
            Maticsoft.Model.sys_Group sys_Group_model = sys_Group_bll.GetModel(GroupID);
            if (GroupIDs != "")
                GroupIDs = GroupIDs + "," + sys_Group_model.GroupID;
            else
                GroupIDs = sys_Group_model.GroupID + "";
            QueryParam qp = new QueryParam();
            if (GroupIDs != "")
            {
                qp.Where = string.Format("Where G_Delete={0} and G_Type={1} and GroupID in({2})", 0, G_Type, GroupIDs);
            }
            else
            {
                qp.Where = string.Format("Where G_Delete={0} and G_Type={1}", 0, G_Type);
            }
            qp.Orderfld = "G_Level,G_ShowOrder";
            qp.OrderType = 0;
            ArrayList lst = BusinessFacade.sys_GroupList(qp, out TotalRecord);
            
            StringBuilder strSB = new StringBuilder();

            strSB.Append("<script language='JavaScript'>\n");
            strSB.Append("Fold_id='';\n");

            strSB.Append("treeRoot = gFld(\"mainbody\", \"部门列表\", \"0\",\"0\")\n");

            foreach (sys_GroupTable x in lst)
            {
                intCount = intCount + 1;
                //strLink = "GroupList.aspx?GroupID=" + x.GroupID.ToString();
                strLink = x.GroupID.ToString();
                if (x.G_Level == sys_Group_model.G_Level)
                {
                    if (x.G_ChildCount == 0)
                    {
                        strSB.AppendFormat("insDoc(treeRoot,gLnk(\"mainbody\",\"{0}\",\"\",{1}))\n", Common.ReplaceJs(x.G_CName), strLink);
                    }
                    else
                    {
                        strSB.AppendFormat("N{0}=insFld(treeRoot,gFld(\"mainbody\",\"{1}\",\"\",{2}))\n", x.GroupID, Common.ReplaceJs(x.G_CName), strLink);
                    }
                }
                else
                {
                    if (x.G_ChildCount == 0)
                    {
                        strSB.AppendFormat("insDoc(N{0},gLnk(\"mainbody\",\"{1}\",\"\",{2}))\n", x.G_ParentID, Common.ReplaceJs(x.G_CName), strLink);
                    }
                    else
                    {
                        strSB.AppendFormat("N{0}=insFld(N{1},gFld(\"mainbody\",\"{2}\",\"\",{3}))\n", x.GroupID, x.G_ParentID, Common.ReplaceJs(x.G_CName), strLink);
                    }
                }

            }

            strSB.Append("	initializeDocument();\n");
            strSB.Append("</script>\n");
            ShowScript.Text = strSB.ToString();
        }
    }
}
