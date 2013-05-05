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
namespace Maticsoft.Web.sys_Roles
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int RoleID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(RoleID);
				}
			}
		}
			
	private void ShowInfo(int RoleID)
	{
		Maticsoft.BLL.sys_Roles bll=new Maticsoft.BLL.sys_Roles();
		Maticsoft.Model.sys_Roles model=bll.GetModel(RoleID);
		this.lblRoleID.Text=model.RoleID.ToString();
		this.txtR_UserID.Text=model.R_UserID.ToString();
		this.txtR_RoleName.Text=model.R_RoleName;
		this.txtR_Description.Text=model.R_Description;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtR_UserID.Text))
			{
				strErr+="角角所属用户ID格式错误！\\n";	
			}
			if(this.txtR_RoleName.Text.Trim().Length==0)
			{
				strErr+="角色名称不能为空！\\n";	
			}
			if(this.txtR_Description.Text.Trim().Length==0)
			{
				strErr+="角色介绍不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int RoleID=int.Parse(this.lblRoleID.Text);
			int R_UserID=int.Parse(this.txtR_UserID.Text);
			string R_RoleName=this.txtR_RoleName.Text;
			string R_Description=this.txtR_Description.Text;


			Maticsoft.Model.sys_Roles model=new Maticsoft.Model.sys_Roles();
			model.RoleID=RoleID;
			model.R_UserID=R_UserID;
			model.R_RoleName=R_RoleName;
			model.R_Description=R_Description;

			Maticsoft.BLL.sys_Roles bll=new Maticsoft.BLL.sys_Roles();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
