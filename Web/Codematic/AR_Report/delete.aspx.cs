using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.AR_Report
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.AR_Report bll=new Maticsoft.BLL.AR_Report();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ReportID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(ReportID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}