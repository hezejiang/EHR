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
namespace Maticsoft.Web.sys_Online
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtO_SessionID.Text.Trim().Length==0)
			{
				strErr+="用户SessionID不能为空！\\n";	
			}
			if(this.txtO_UserName.Text.Trim().Length==0)
			{
				strErr+="用户名不能为空！\\n";	
			}
			if(this.txtO_Ip.Text.Trim().Length==0)
			{
				strErr+="用户IP地址不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtO_LoginTime.Text))
			{
				strErr+="登陆时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtO_LastTime.Text))
			{
				strErr+="最后访问时间格式错误！\\n";	
			}
			if(this.txtO_LastUrl.Text.Trim().Length==0)
			{
				strErr+="最后请求网站不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string O_SessionID=this.txtO_SessionID.Text;
			string O_UserName=this.txtO_UserName.Text;
			string O_Ip=this.txtO_Ip.Text;
			DateTime O_LoginTime=DateTime.Parse(this.txtO_LoginTime.Text);
			DateTime O_LastTime=DateTime.Parse(this.txtO_LastTime.Text);
			string O_LastUrl=this.txtO_LastUrl.Text;

			Maticsoft.Model.sys_Online model=new Maticsoft.Model.sys_Online();
			model.O_SessionID=O_SessionID;
			model.O_UserName=O_UserName;
			model.O_Ip=O_Ip;
			model.O_LoginTime=O_LoginTime;
			model.O_LastTime=O_LastTime;
			model.O_LastUrl=O_LastUrl;

			Maticsoft.BLL.sys_Online bll=new Maticsoft.BLL.sys_Online();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
