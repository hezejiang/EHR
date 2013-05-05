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
namespace Maticsoft.Web.education_Prescription
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
					int PrescriptionID=(Convert.ToInt32(strid));
					ShowInfo(PrescriptionID);
				}
			}
		}
		
	private void ShowInfo(int PrescriptionID)
	{
		Maticsoft.BLL.education_Prescription bll=new Maticsoft.BLL.education_Prescription();
		Maticsoft.Model.education_Prescription model=bll.GetModel(PrescriptionID);
		this.lblPrescriptionID.Text=model.PrescriptionID.ToString();
		this.lblP_Object.Text=model.P_Object.ToString();
		this.lblP_Name.Text=model.P_Name;
		this.lblP_Content.Text=model.P_Content;
		this.lblP_Doctor.Text=model.P_Doctor.ToString();
		this.lblP_Date.Text=model.P_Date.ToString();

	}


    }
}
