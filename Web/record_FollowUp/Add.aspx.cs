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
namespace Maticsoft.Web.record_FollowUp
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtF_PatientID.Text))
			{
				strErr+="病人ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Type.Text))
			{
				strErr+="随访类型格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtF_Date.Text))
			{
				strErr+="下次随访日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Status.Text))
			{
				strErr+="随访状态 1：为完成格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int F_PatientID=int.Parse(this.txtF_PatientID.Text);
			int F_Type=int.Parse(this.txtF_Type.Text);
			DateTime F_Date=DateTime.Parse(this.txtF_Date.Text);
			int F_Status=int.Parse(this.txtF_Status.Text);

			Maticsoft.Model.record_FollowUp model=new Maticsoft.Model.record_FollowUp();
			model.F_PatientID=F_PatientID;
			model.F_Type=F_Type;
			model.F_Date=F_Date;
			model.F_Status=F_Status;

			Maticsoft.BLL.record_FollowUp bll=new Maticsoft.BLL.record_FollowUp();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
