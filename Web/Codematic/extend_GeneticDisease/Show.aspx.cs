using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.extend_GeneticDisease
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int GeneticDiseaseID=(Convert.ToInt32(strid));
					ShowInfo(GeneticDiseaseID);
				}
			}
		}
		
	private void ShowInfo(int GeneticDiseaseID)
	{
		Maticsoft.BLL.extend_GeneticDisease bll=new Maticsoft.BLL.extend_GeneticDisease();
		Maticsoft.Model.extend_GeneticDisease model=bll.GetModel(GeneticDiseaseID);
		this.lblGeneticDiseaseID.Text=model.GeneticDiseaseID.ToString();
		this.lblGD_Name.Text=model.GD_Name;
		this.lblGD_UserID.Text=model.GD_UserID.ToString();

	}


    }
}
