using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_ModuleExtPermission
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_ModuleExtPermission bll=new Maticsoft.BLL.sys_ModuleExtPermission();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ExtPermissionID=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(ExtPermissionID);
				}
			}

        }
    }
}