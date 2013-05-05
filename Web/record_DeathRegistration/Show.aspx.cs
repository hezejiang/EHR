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
namespace Maticsoft.Web.record_DeathRegistration
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
					int DeathID=(Convert.ToInt32(strid));
					ShowInfo(DeathID);
				}
			}
		}
		
	private void ShowInfo(int DeathID)
	{
		Maticsoft.BLL.record_DeathRegistration bll=new Maticsoft.BLL.record_DeathRegistration();
		Maticsoft.Model.record_DeathRegistration model=bll.GetModel(DeathID);
		this.lblDeathID.Text=model.DeathID.ToString();
		this.lblD_DateTime.Text=model.D_DateTime.ToString();
		this.lblD_Location.Text=model.D_Location;
		this.lblD_Icd10ID.Text=model.D_Icd10ID.ToString();
		this.lblD_Note.Text=model.D_Note;
		this.lblD_UserID.Text=model.D_UserID.ToString();
		this.lblD_RegDate.Text=model.D_RegDate.ToString();

	}


    }
}
