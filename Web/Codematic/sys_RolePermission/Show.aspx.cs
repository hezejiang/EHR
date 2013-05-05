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
namespace Maticsoft.Web.sys_RolePermission
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
					int PermissionID=(Convert.ToInt32(strid));
					ShowInfo(PermissionID);
				}
			}
		}
		
	private void ShowInfo(int PermissionID)
	{
		Maticsoft.BLL.sys_RolePermission bll=new Maticsoft.BLL.sys_RolePermission();
		Maticsoft.Model.sys_RolePermission model=bll.GetModel(PermissionID);
		this.lblPermissionID.Text=model.PermissionID.ToString();
		this.lblP_RoleID.Text=model.P_RoleID.ToString();
		this.lblP_ApplicationID.Text=model.P_ApplicationID.ToString();
		this.lblP_PageCode.Text=model.P_PageCode;
		this.lblP_Value.Text=model.P_Value.ToString();

	}


    }
}
