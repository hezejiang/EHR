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
namespace Maticsoft.Web.sys_RolePermission
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int PermissionID=(Convert.ToInt32(Request.Params["id"]));
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
		this.txtP_Value.Text=model.P_Value.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtP_Value.Text))
			{
				strErr+="权限值格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int PermissionID=int.Parse(this.lblPermissionID.Text);
			int P_RoleID=int.Parse(this.lblP_RoleID.Text);
			int P_ApplicationID=int.Parse(this.lblP_ApplicationID.Text);
			string P_PageCode=this.lblP_PageCode.Text;
			int P_Value=int.Parse(this.txtP_Value.Text);


			Maticsoft.Model.sys_RolePermission model=new Maticsoft.Model.sys_RolePermission();
			model.PermissionID=PermissionID;
			model.P_RoleID=P_RoleID;
			model.P_ApplicationID=P_ApplicationID;
			model.P_PageCode=P_PageCode;
			model.P_Value=P_Value;

			Maticsoft.BLL.sys_RolePermission bll=new Maticsoft.BLL.sys_RolePermission();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
