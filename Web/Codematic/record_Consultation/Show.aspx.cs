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
namespace Maticsoft.Web.record_Consultation
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
					int ConsultationID=(Convert.ToInt32(strid));
					ShowInfo(ConsultationID);
				}
			}
		}
		
	private void ShowInfo(int ConsultationID)
	{
		Maticsoft.BLL.record_Consultation bll=new Maticsoft.BLL.record_Consultation();
		Maticsoft.Model.record_Consultation model=bll.GetModel(ConsultationID);
		this.lblConsultationID.Text=model.ConsultationID.ToString();
		this.lblC_UserID.Text=model.C_UserID.ToString();
		this.lblC_Cause.Text=model.C_Cause;
		this.lblC_Comments.Text=model.C_Comments;
		this.lblC_InstitutionDoctor.Text=model.C_InstitutionDoctor;
		this.lblC_Time.Text=model.C_Time.ToString();

	}


    }
}
