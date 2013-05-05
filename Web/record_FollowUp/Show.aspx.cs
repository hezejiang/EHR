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
namespace Maticsoft.Web.record_FollowUp
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
					int FollowUpID=(Convert.ToInt32(strid));
					ShowInfo(FollowUpID);
				}
			}
		}
		
	private void ShowInfo(int FollowUpID)
	{
		Maticsoft.BLL.record_FollowUp bll=new Maticsoft.BLL.record_FollowUp();
		Maticsoft.Model.record_FollowUp model=bll.GetModel(FollowUpID);
		this.lblFollowUpID.Text=model.FollowUpID.ToString();
		this.lblF_PatientID.Text=model.F_PatientID.ToString();
		this.lblF_Type.Text=model.F_Type.ToString();
		this.lblF_Date.Text=model.F_Date.ToString();
		this.lblF_Status.Text=model.F_Status.ToString();

	}


    }
}
