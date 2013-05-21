using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.extend_DiseaseHistory
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.extend_DiseaseHistory bll=new Maticsoft.BLL.extend_DiseaseHistory();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DiseaseHistoryID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(DiseaseHistoryID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}