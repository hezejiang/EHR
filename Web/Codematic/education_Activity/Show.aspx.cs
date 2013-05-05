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
namespace Maticsoft.Web.education_Activity
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
					int ActivityID=(Convert.ToInt32(strid));
					ShowInfo(ActivityID);
				}
			}
		}
		
	private void ShowInfo(int ActivityID)
	{
		Maticsoft.BLL.education_Activity bll=new Maticsoft.BLL.education_Activity();
		Maticsoft.Model.education_Activity model=bll.GetModel(ActivityID);
		this.lblActivityID.Text=model.ActivityID.ToString();
		this.lblA_DateTime.Text=model.A_DateTime.ToString();
		this.lblA_Location.Text=model.A_Location;
		this.lblA_Form.Text=model.A_Form;
		this.lblA_Object.Text=model.A_Object.ToString();
		this.lblA_Crowd.Text=model.A_Crowd;
		this.lblA_Duration.Text=model.A_Duration.ToString();
		this.lblA_Organizers.Text=model.A_Organizers;
		this.lblA_Partners.Text=model.A_Partners;
		this.lblA_Missionary.Text=model.A_Missionary;
		this.lblA_Number.Text=model.A_Number.ToString();
		this.lblA_Theme.Text=model.A_Theme;

	}


    }
}
