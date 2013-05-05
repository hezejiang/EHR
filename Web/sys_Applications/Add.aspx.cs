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
namespace Maticsoft.Web.sys_Applications
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtA_AppName.Text.Trim().Length==0)
			{
				strErr+="应用名称不能为空！\\n";	
			}
			if(this.txtA_AppDescription.Text.Trim().Length==0)
			{
				strErr+="应用介绍不能为空！\\n";	
			}
			if(this.txtA_AppUrl.Text.Trim().Length==0)
			{
				strErr+="应用Url地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_Order.Text))
			{
				strErr+="应用排序格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string A_AppName=this.txtA_AppName.Text;
			string A_AppDescription=this.txtA_AppDescription.Text;
			string A_AppUrl=this.txtA_AppUrl.Text;
			int A_Order=int.Parse(this.txtA_Order.Text);

			Maticsoft.Model.sys_Applications model=new Maticsoft.Model.sys_Applications();
			model.A_AppName=A_AppName;
			model.A_AppDescription=A_AppDescription;
			model.A_AppUrl=A_AppUrl;
			model.A_Order=A_Order;

			Maticsoft.BLL.sys_Applications bll=new Maticsoft.BLL.sys_Applications();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
