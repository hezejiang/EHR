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
namespace Maticsoft.Web.sys_Roles
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
					int RoleID=(Convert.ToInt32(strid));
					ShowInfo(RoleID);
				}
			}
		}
		
	private void ShowInfo(int RoleID)
	{
		Maticsoft.BLL.sys_Roles bll=new Maticsoft.BLL.sys_Roles();
		Maticsoft.Model.sys_Roles model=bll.GetModel(RoleID);
		this.lblRoleID.Text=model.RoleID.ToString();
		this.lblR_UserID.Text=model.R_UserID.ToString();
		this.lblR_RoleName.Text=model.R_RoleName;
		this.lblR_Description.Text=model.R_Description;

	}


    }
}
