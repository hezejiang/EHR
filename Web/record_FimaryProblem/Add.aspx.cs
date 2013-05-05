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
namespace Maticsoft.Web.record_FimaryProblem
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtF_FimaryCode.Text.Trim().Length==0)
			{
				strErr+="家庭编号不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtF_RecordTime.Text))
			{
				strErr+="记录时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtF_StartTime.Text))
			{
				strErr+="发生时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtF_endTime.Text))
			{
				strErr+="结束时间格式错误！\\n";	
			}
			if(this.txtF_OverviewProblem.Text.Trim().Length==0)
			{
				strErr+="问题概述不能为空！\\n";	
			}
			if(this.txtF_DetailProblem.Text.Trim().Length==0)
			{
				strErr+="问题详述不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_FillingUserID.Text))
			{
				strErr+="建档医生格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string F_FimaryCode=this.txtF_FimaryCode.Text;
			DateTime F_RecordTime=DateTime.Parse(this.txtF_RecordTime.Text);
			DateTime F_StartTime=DateTime.Parse(this.txtF_StartTime.Text);
			DateTime F_endTime=DateTime.Parse(this.txtF_endTime.Text);
			string F_OverviewProblem=this.txtF_OverviewProblem.Text;
			string F_DetailProblem=this.txtF_DetailProblem.Text;
			int F_FillingUserID=int.Parse(this.txtF_FillingUserID.Text);

			Maticsoft.Model.record_FimaryProblem model=new Maticsoft.Model.record_FimaryProblem();
			model.F_FimaryCode=F_FimaryCode;
			model.F_RecordTime=F_RecordTime;
			model.F_StartTime=F_StartTime;
			model.F_endTime=F_endTime;
			model.F_OverviewProblem=F_OverviewProblem;
			model.F_DetailProblem=F_DetailProblem;
			model.F_FillingUserID=F_FillingUserID;

			Maticsoft.BLL.record_FimaryProblem bll=new Maticsoft.BLL.record_FimaryProblem();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
