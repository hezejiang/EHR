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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtModuleID.Text))
			{
				strErr+="模块ID格式错误！\\n";	
			}
			if(this.txtPermissionName.Text.Trim().Length==0)
			{
				strErr+="权限名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPermissionValue.Text))
			{
				strErr+="权限值格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ModuleID=int.Parse(this.txtModuleID.Text);
			string PermissionName=this.txtPermissionName.Text;
			int PermissionValue=int.Parse(this.txtPermissionValue.Text);

			Maticsoft.Model.sys_ModuleExtPermission model=new Maticsoft.Model.sys_ModuleExtPermission();
			model.ModuleID=ModuleID;
			model.PermissionName=PermissionName;
			model.PermissionValue=PermissionValue;

			Maticsoft.BLL.sys_ModuleExtPermission bll=new Maticsoft.BLL.sys_ModuleExtPermission();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
