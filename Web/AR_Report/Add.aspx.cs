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
namespace Maticsoft.Web.AR_Report
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtR_Title.Text.Trim().Length==0)
			{
				strErr+="报告标题不能为空！\\n";	
			}
			if(this.txtR_Content.Text.Trim().Length==0)
			{
				strErr+="报告内容不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtR_DateTime.Text))
			{
				strErr+="报告时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtR_ResponsibilityUserID.Text))
			{
				strErr+="责任人格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string R_Title=this.txtR_Title.Text;
			string R_Content=this.txtR_Content.Text;
			DateTime R_DateTime=DateTime.Parse(this.txtR_DateTime.Text);
			int R_ResponsibilityUserID=int.Parse(this.txtR_ResponsibilityUserID.Text);

			Maticsoft.Model.AR_Report model=new Maticsoft.Model.AR_Report();
			model.R_Title=R_Title;
			model.R_Content=R_Content;
			model.R_DateTime=R_DateTime;
			model.R_ResponsibilityUserID=R_ResponsibilityUserID;

			Maticsoft.BLL.AR_Report bll=new Maticsoft.BLL.AR_Report();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
