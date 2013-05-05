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
namespace Maticsoft.Web.sys_RoleApplication
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtA_RoleID.Text))
			{
				strErr+="角色ID与sys_Roles中格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_ApplicationID.Text))
			{
				strErr+="应用ID与sys_Applic格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int A_RoleID=int.Parse(this.txtA_RoleID.Text);
			int A_ApplicationID=int.Parse(this.txtA_ApplicationID.Text);

			Maticsoft.Model.sys_RoleApplication model=new Maticsoft.Model.sys_RoleApplication();
			model.A_RoleID=A_RoleID;
			model.A_ApplicationID=A_ApplicationID;

			Maticsoft.BLL.sys_RoleApplication bll=new Maticsoft.BLL.sys_RoleApplication();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
