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
namespace Maticsoft.Web.record_MedicationTime
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
					int MedicationTimeID=(Convert.ToInt32(strid));
					ShowInfo(MedicationTimeID);
				}
			}
		}
		
	private void ShowInfo(int MedicationTimeID)
	{
		Maticsoft.BLL.record_MedicationTime bll=new Maticsoft.BLL.record_MedicationTime();
		Maticsoft.Model.record_MedicationTime model=bll.GetModel(MedicationTimeID);
		this.lblMedicationTimeID.Text=model.MedicationTimeID.ToString();
		this.lblM_Time.Text=model.M_Time;
		this.lblMedicationID.Text=model.MedicationID.ToString();

	}


    }
}
