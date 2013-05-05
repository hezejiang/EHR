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
namespace Maticsoft.Web.record_Consultation
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ConsultationID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ConsultationID);
				}
			}
		}
			
	private void ShowInfo(int ConsultationID)
	{
		Maticsoft.BLL.record_Consultation bll=new Maticsoft.BLL.record_Consultation();
		Maticsoft.Model.record_Consultation model=bll.GetModel(ConsultationID);
		this.lblConsultationID.Text=model.ConsultationID.ToString();
		this.txtC_UserID.Text=model.C_UserID.ToString();
		this.txtC_Cause.Text=model.C_Cause;
		this.txtC_Comments.Text=model.C_Comments;
		this.txtC_InstitutionDoctor.Text=model.C_InstitutionDoctor;
		this.txtC_Time.Text=model.C_Time.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtC_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(this.txtC_Cause.Text.Trim().Length==0)
			{
				strErr+="会诊原因不能为空！\\n";	
			}
			if(this.txtC_Comments.Text.Trim().Length==0)
			{
				strErr+="会诊意见不能为空！\\n";	
			}
			if(this.txtC_InstitutionDoctor.Text.Trim().Length==0)
			{
				strErr+="会诊医生及其所在机构名称不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtC_Time.Text))
			{
				strErr+="会诊日期格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ConsultationID=int.Parse(this.lblConsultationID.Text);
			int C_UserID=int.Parse(this.txtC_UserID.Text);
			string C_Cause=this.txtC_Cause.Text;
			string C_Comments=this.txtC_Comments.Text;
			string C_InstitutionDoctor=this.txtC_InstitutionDoctor.Text;
			DateTime C_Time=DateTime.Parse(this.txtC_Time.Text);


			Maticsoft.Model.record_Consultation model=new Maticsoft.Model.record_Consultation();
			model.ConsultationID=ConsultationID;
			model.C_UserID=C_UserID;
			model.C_Cause=C_Cause;
			model.C_Comments=C_Comments;
			model.C_InstitutionDoctor=C_InstitutionDoctor;
			model.C_Time=C_Time;

			Maticsoft.BLL.record_Consultation bll=new Maticsoft.BLL.record_Consultation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
