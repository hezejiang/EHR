using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.extend_Environment
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.extend_Environment bll=new Maticsoft.BLL.extend_Environment();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int EnvironmentID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(EnvironmentID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}