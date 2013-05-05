using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_User
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_User bll=new Maticsoft.BLL.sys_User();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UserID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(UserID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}