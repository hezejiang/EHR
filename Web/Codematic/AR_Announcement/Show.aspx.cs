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
namespace Maticsoft.Web.AR_Announcement
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
					int AnnouncementID=(Convert.ToInt32(strid));
					ShowInfo(AnnouncementID);
				}
			}
		}
		
	private void ShowInfo(int AnnouncementID)
	{
		Maticsoft.BLL.AR_Announcement bll=new Maticsoft.BLL.AR_Announcement();
		Maticsoft.Model.AR_Announcement model=bll.GetModel(AnnouncementID);
		this.lblAnnouncementID.Text=model.AnnouncementID.ToString();
		this.lblA_Title.Text=model.A_Title;
		this.lblA_Content.Text=model.A_Content;
		this.lblA_DateTime.Text=model.A_DateTime.ToString();
		this.lblA_ResponsibilityUserID.Text=model.A_ResponsibilityUserID.ToString();
		this.lblA_Type.Text=model.A_Type.ToString();

	}


    }
}
