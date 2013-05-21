using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.extend_DiseaseOther
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.extend_DiseaseOther bll=new Maticsoft.BLL.extend_DiseaseOther();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DiseaseOtherID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(DiseaseOtherID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}