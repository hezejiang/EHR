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
namespace Maticsoft.Web.sys_SystemInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtS_Name.Text.Trim().Length==0)
			{
				strErr+="系统名称不能为空！\\n";	
			}
			if(this.txtS_Version.Text.Trim().Length==0)
			{
				strErr+="版本号不能为空！\\n";	
			}
			if(this.txtS_Licensed.Text.Trim().Length==0)
			{
				strErr+="序列号不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string S_Name=this.txtS_Name.Text;
			string S_Version=this.txtS_Version.Text;
			byte[] S_SystemConfigData= new UnicodeEncoding().GetBytes(this.txtS_SystemConfigData.Text);
			string S_Licensed=this.txtS_Licensed.Text;

			Maticsoft.Model.sys_SystemInfo model=new Maticsoft.Model.sys_SystemInfo();
			model.S_Name=S_Name;
			model.S_Version=S_Version;
			model.S_SystemConfigData=S_SystemConfigData;
			model.S_Licensed=S_Licensed;

			Maticsoft.BLL.sys_SystemInfo bll=new Maticsoft.BLL.sys_SystemInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
