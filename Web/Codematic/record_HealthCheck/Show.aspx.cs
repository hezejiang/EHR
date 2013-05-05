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
namespace Maticsoft.Web.record_HealthCheck
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
					int HealthID=(Convert.ToInt32(strid));
					ShowInfo(HealthID);
				}
			}
		}
		
	private void ShowInfo(int HealthID)
	{
		Maticsoft.BLL.record_HealthCheck bll=new Maticsoft.BLL.record_HealthCheck();
		Maticsoft.Model.record_HealthCheck model=bll.GetModel(HealthID);
		this.lblHealthID.Text=model.HealthID.ToString();
		this.lblH_BodyTemperature.Text=model.H_BodyTemperature.ToString();
		this.lblH_PulseRate.Text=model.H_PulseRate.ToString();
		this.lblH_RespiratoryRate.Text=model.H_RespiratoryRate.ToString();
		this.lblH_LeftDiastolic.Text=model.H_LeftDiastolic.ToString();
		this.lblH_LeftSystolic.Text=model.H_LeftSystolic.ToString();
		this.lblH_RightDiastolic.Text=model.H_RightDiastolic.ToString();
		this.lblH_RightSystolic.Text=model.H_RightSystolic.ToString();
		this.lblH_Height.Text=model.H_Height.ToString();
		this.lblH_Weight.Text=model.H_Weight.ToString();
		this.lblH_Result.Text=model.H_Result;
		this.lblH_Suggestion.Text=model.H_Suggestion;
		this.lblH_CheckTime.Text=model.H_CheckTime.ToString();
		this.lblH_MedicalInstitutions.Text=model.H_MedicalInstitutions.ToString();
		this.lblH_CheckUserID.Text=model.H_CheckUserID.ToString();

	}


    }
}
