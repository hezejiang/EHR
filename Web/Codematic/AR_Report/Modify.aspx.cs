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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ReportID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ReportID);
				}
			}
		}
			
	private void ShowInfo(int ReportID)
	{
		Maticsoft.BLL.AR_Report bll=new Maticsoft.BLL.AR_Report();
		Maticsoft.Model.AR_Report model=bll.GetModel(ReportID);
		this.lblReportID.Text=model.ReportID.ToString();
		this.txtR_Title.Text=model.R_Title;
		this.txtR_Content.Text=model.R_Content;
		this.txtR_DateTime.Text=model.R_DateTime.ToString();
		this.txtR_ResponsibilityUserID.Text=model.R_ResponsibilityUserID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int ReportID=int.Parse(this.lblReportID.Text);
			string R_Title=this.txtR_Title.Text;
			string R_Content=this.txtR_Content.Text;
			DateTime R_DateTime=DateTime.Parse(this.txtR_DateTime.Text);
			int R_ResponsibilityUserID=int.Parse(this.txtR_ResponsibilityUserID.Text);


			Maticsoft.Model.AR_Report model=new Maticsoft.Model.AR_Report();
			model.ReportID=ReportID;
			model.R_Title=R_Title;
			model.R_Content=R_Content;
			model.R_DateTime=R_DateTime;
			model.R_ResponsibilityUserID=R_ResponsibilityUserID;

			Maticsoft.BLL.AR_Report bll=new Maticsoft.BLL.AR_Report();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
