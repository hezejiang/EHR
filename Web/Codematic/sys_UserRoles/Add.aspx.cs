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
namespace Maticsoft.Web.sys_UserRoles
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtR_UserID.Text))
			{
				strErr+="用户ID与sys_User表中格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtR_RoleID.Text))
			{
				strErr+="用户所属角色ID与Sys_Ro格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int R_UserID=int.Parse(this.txtR_UserID.Text);
			int R_RoleID=int.Parse(this.txtR_RoleID.Text);

			Maticsoft.Model.sys_UserRoles model=new Maticsoft.Model.sys_UserRoles();
			model.R_UserID=R_UserID;
			model.R_RoleID=R_RoleID;

			Maticsoft.BLL.sys_UserRoles bll=new Maticsoft.BLL.sys_UserRoles();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
