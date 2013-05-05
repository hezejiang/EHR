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
namespace Maticsoft.Web.sys_ModuleExtPermission
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
					int ExtPermissionID=(Convert.ToInt32(strid));
					ShowInfo(ExtPermissionID);
				}
			}
		}
		
	private void ShowInfo(int ExtPermissionID)
	{
		Maticsoft.BLL.sys_ModuleExtPermission bll=new Maticsoft.BLL.sys_ModuleExtPermission();
		Maticsoft.Model.sys_ModuleExtPermission model=bll.GetModel(ExtPermissionID);
		this.lblExtPermissionID.Text=model.ExtPermissionID.ToString();
		this.lblModuleID.Text=model.ModuleID.ToString();
		this.lblPermissionName.Text=model.PermissionName;
		this.lblPermissionValue.Text=model.PermissionValue.ToString();

	}


    }
}
