using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_Roles
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_Roles bll=new Maticsoft.BLL.sys_Roles();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int RoleID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(RoleID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}