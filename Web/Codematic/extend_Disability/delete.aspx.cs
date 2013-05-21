using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.extend_Disability
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.extend_Disability bll=new Maticsoft.BLL.extend_Disability();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DisabilityID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(DisabilityID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}