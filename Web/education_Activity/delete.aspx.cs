using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.education_Activity
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.education_Activity bll=new Maticsoft.BLL.education_Activity();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ActivityID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(ActivityID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}