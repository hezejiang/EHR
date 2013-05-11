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

namespace FrameWork.web.Module.FrameWork.HealthSupervision.Info
{
    public partial class SelectUser : System.Web.UI.Page
    {
        public string TableSink = Common.TableSink;
        protected void Page_Load(object sender, EventArgs e)
        {
            OutJs();
        }

        private void OutJs()
        {
            int GroupID = (int)Common.sink("GroupID", MethodType.Get, 255, 0, DataType.Int);
            int TotalRecord = 0;
            string strLink = "";
            int intCount = 0;
            QueryParam qp = new QueryParam();
            qp.Where = "Where G_Delete=0 and U_GroupID=" +　GroupID;
            qp.OrderType = 0;
            ArrayList userList = BusinessFacade.sys_UserList(qp, out TotalRecord);
            StringBuilder strSB = new StringBuilder();

            strSB.Append("<script language='JavaScript'>\n");
            strSB.Append("Fold_id='';\n");

            strSB.Append("treeRoot = gFld(\"mainbody\", \"用户列表\", \"0\",\"0\")\n");

            foreach (sys_UserTable x in userList)
            {
                intCount = intCount + 1;
                //strLink = "GroupList.aspx?GroupID=" + x.GroupID.ToString();
                strLink = x.U_GroupID.ToString();
                strSB.AppendFormat("N{0}=insFld(N{1},gFld(\"mainbody\",\"{2}\",\"\",{3}))\n", x.UserID, 0, Common.ReplaceJs(x.U_CName), strLink);
            }

            strSB.Append("	initializeDocument();\n");
            strSB.Append("</script>\n");
            ShowScript.Text = strSB.ToString();
        }
    }
}
