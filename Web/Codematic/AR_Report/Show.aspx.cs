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
namespace Maticsoft.Web.AR_Report
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
					int ReportID=(Convert.ToInt32(strid));
					ShowInfo(ReportID);
				}
			}
		}
		
	private void ShowInfo(int ReportID)
	{
		Maticsoft.BLL.AR_Report bll=new Maticsoft.BLL.AR_Report();
		Maticsoft.Model.AR_Report model=bll.GetModel(ReportID);
		this.lblReportID.Text=model.ReportID.ToString();
		this.lblR_Title.Text=model.R_Title;
		this.lblR_Content.Text=model.R_Content;
		this.lblR_DateTime.Text=model.R_DateTime.ToString();
		this.lblR_ResponsibilityUserID.Text=model.R_ResponsibilityUserID.ToString();

	}


    }
}
