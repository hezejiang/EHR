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
namespace Maticsoft.Web.sys_SystemInfo
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
					int SystemID=(Convert.ToInt32(strid));
					ShowInfo(SystemID);
				}
			}
		}
		
	private void ShowInfo(int SystemID)
	{
		Maticsoft.BLL.sys_SystemInfo bll=new Maticsoft.BLL.sys_SystemInfo();
		Maticsoft.Model.sys_SystemInfo model=bll.GetModel(SystemID);
		this.lblSystemID.Text=model.SystemID.ToString();
		this.lblS_Name.Text=model.S_Name;
		this.lblS_Version.Text=model.S_Version;
		this.lblS_SystemConfigData.Text=model.S_SystemConfigData.ToString();
		this.lblS_Licensed.Text=model.S_Licensed;

	}


    }
}
