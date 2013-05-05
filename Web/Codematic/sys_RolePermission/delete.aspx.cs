using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_RolePermission
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_RolePermission bll=new Maticsoft.BLL.sys_RolePermission();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int PermissionID=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(PermissionID);
				}
			}

        }
    }
}