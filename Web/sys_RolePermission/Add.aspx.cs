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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtP_RoleID.Text))
			{
				strErr+="角色ID与sys_Roles表格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtP_ApplicationID.Text))
			{
				strErr+="角色所属应用ID与sys_Ap格式错误！\\n";	
			}
			if(this.txtP_PageCode.Text.Trim().Length==0)
			{
				strErr+="角色应用中页面权限代码不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtP_Value.Text))
			{
				strErr+="权限值格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int P_RoleID=int.Parse(this.txtP_RoleID.Text);
			int P_ApplicationID=int.Parse(this.txtP_ApplicationID.Text);
			string P_PageCode=this.txtP_PageCode.Text;
			int P_Value=int.Parse(this.txtP_Value.Text);

			Maticsoft.Model.sys_RolePermission model=new Maticsoft.Model.sys_RolePermission();
			model.P_RoleID=P_RoleID;
			model.P_ApplicationID=P_ApplicationID;
			model.P_PageCode=P_PageCode;
			model.P_Value=P_Value;

			Maticsoft.BLL.sys_RolePermission bll=new Maticsoft.BLL.sys_RolePermission();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
