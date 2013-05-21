using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.extend_GeneticDisease
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.extend_GeneticDisease bll=new Maticsoft.BLL.extend_GeneticDisease();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int GeneticDiseaseID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(GeneticDiseaseID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}