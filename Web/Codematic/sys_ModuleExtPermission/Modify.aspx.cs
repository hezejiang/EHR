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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.sys_ModuleExtPermission
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ExtPermissionID=(Convert.ToInt32(Request.Params["id"]));
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
		this.txtPermissionName.Text=model.PermissionName;
		this.lblPermissionValue.Text=model.PermissionValue.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPermissionName.Text.Trim().Length==0)
			{
				strErr+="权限名称不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ExtPermissionID=int.Parse(this.lblExtPermissionID.Text);
			int ModuleID=int.Parse(this.lblModuleID.Text);
			string PermissionName=this.txtPermissionName.Text;
			int PermissionValue=int.Parse(this.lblPermissionValue.Text);


			Maticsoft.Model.sys_ModuleExtPermission model=new Maticsoft.Model.sys_ModuleExtPermission();
			model.ExtPermissionID=ExtPermissionID;
			model.ModuleID=ModuleID;
			model.PermissionName=PermissionName;
			model.PermissionValue=PermissionValue;

			Maticsoft.BLL.sys_ModuleExtPermission bll=new Maticsoft.BLL.sys_ModuleExtPermission();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
