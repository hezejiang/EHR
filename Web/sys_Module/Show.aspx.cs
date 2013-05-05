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
namespace Maticsoft.Web.sys_Module
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
					int ModuleID=(Convert.ToInt32(strid));
					ShowInfo(ModuleID);
				}
			}
		}
		
	private void ShowInfo(int ModuleID)
	{
		Maticsoft.BLL.sys_Module bll=new Maticsoft.BLL.sys_Module();
		Maticsoft.Model.sys_Module model=bll.GetModel(ModuleID);
		this.lblModuleID.Text=model.ModuleID.ToString();
		this.lblM_ApplicationID.Text=model.M_ApplicationID.ToString();
		this.lblM_ParentID.Text=model.M_ParentID.ToString();
		this.lblM_PageCode.Text=model.M_PageCode;
		this.lblM_CName.Text=model.M_CName;
		this.lblM_Directory.Text=model.M_Directory;
		this.lblM_OrderLevel.Text=model.M_OrderLevel;
		this.lblM_IsSystem.Text=model.M_IsSystem.ToString();
		this.lblM_Close.Text=model.M_Close.ToString();
		this.lblM_Icon.Text=model.M_Icon;
		this.lblM_Info.Text=model.M_Info;

	}


    }
}
