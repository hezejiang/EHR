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
namespace Maticsoft.Web.sys_Applications
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
					int ApplicationID=(Convert.ToInt32(strid));
					ShowInfo(ApplicationID);
				}
			}
		}
		
	private void ShowInfo(int ApplicationID)
	{
		Maticsoft.BLL.sys_Applications bll=new Maticsoft.BLL.sys_Applications();
		Maticsoft.Model.sys_Applications model=bll.GetModel(ApplicationID);
		this.lblApplicationID.Text=model.ApplicationID.ToString();
		this.lblA_AppName.Text=model.A_AppName;
		this.lblA_AppDescription.Text=model.A_AppDescription;
		this.lblA_AppUrl.Text=model.A_AppUrl;
		this.lblA_Order.Text=model.A_Order.ToString();

	}


    }
}
