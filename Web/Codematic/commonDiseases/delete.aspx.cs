using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.commonDiseases
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.commonDiseases bll=new Maticsoft.BLL.commonDiseases();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CommonDiseaseID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(CommonDiseaseID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}