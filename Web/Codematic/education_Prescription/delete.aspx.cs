using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.education_Prescription
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.education_Prescription bll=new Maticsoft.BLL.education_Prescription();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int PrescriptionID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(PrescriptionID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}