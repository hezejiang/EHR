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
namespace Maticsoft.Web.record_Medication
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
					int MedicationID=(Convert.ToInt32(strid));
					ShowInfo(MedicationID);
				}
			}
		}
		
	private void ShowInfo(int MedicationID)
	{
		Maticsoft.BLL.record_Medication bll=new Maticsoft.BLL.record_Medication();
		Maticsoft.Model.record_Medication model=bll.GetModel(MedicationID);
		this.lblMedicationID.Text=model.MedicationID.ToString();
		this.lblM_ConsultationID.Text=model.M_ConsultationID.ToString();
		this.lblM_StartDate.Text=model.M_StartDate.ToString();
		this.lblM_Status.Text=model.M_Status.ToString();

	}


    }
}
