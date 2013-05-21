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
namespace Maticsoft.Web.extend_DiseaseHistory
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
					int DiseaseHistoryID=(Convert.ToInt32(strid));
					ShowInfo(DiseaseHistoryID);
				}
			}
		}
		
	private void ShowInfo(int DiseaseHistoryID)
	{
		Maticsoft.BLL.extend_DiseaseHistory bll=new Maticsoft.BLL.extend_DiseaseHistory();
		Maticsoft.Model.extend_DiseaseHistory model=bll.GetModel(DiseaseHistoryID);
		this.lblDiseaseHistoryID.Text=model.DiseaseHistoryID.ToString();
		this.lblDH_Type.Text=model.DH_Type.ToString();
		this.lblDH_DiagnosisDate.Text=model.DH_DiagnosisDate.ToString();
		this.lblDH_Note.Text=model.DH_Note;
		this.lblDH_UserID.Text=model.DH_UserID.ToString();

	}


    }
}
