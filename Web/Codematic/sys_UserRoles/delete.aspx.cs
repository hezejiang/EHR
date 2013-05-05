using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_UserRoles
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_UserRoles bll=new Maticsoft.BLL.sys_UserRoles();
				int R_UserID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					R_UserID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int R_RoleID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					R_RoleID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：删除页面,请检查确认传递过来的参数是否正确
				// bll.Delete(R_UserID,R_RoleID);
			}

        }
    }
}