using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_Applications
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_Applications bll=new Maticsoft.BLL.sys_Applications();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ApplicationID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(ApplicationID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}