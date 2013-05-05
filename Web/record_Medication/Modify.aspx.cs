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
namespace Maticsoft.Web.record_Medication
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MedicationID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MedicationID);
				}
			}
		}
			
	private void ShowInfo(int MedicationID)
	{
		Maticsoft.BLL.record_Medication bll=new Maticsoft.BLL.record_Medication();
		Maticsoft.Model.record_Medication model=bll.GetModel(MedicationID);
		this.lblMedicationID.Text=model.MedicationID.ToString();
		this.txtM_ConsultationID.Text=model.M_ConsultationID.ToString();
		this.txtM_StartDate.Text=model.M_StartDate.ToString();
		this.txtM_Status.Text=model.M_Status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtM_ConsultationID.Text))
			{
				strErr+="会诊流水号格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtM_StartDate.Text))
			{
				strErr+="用药开始日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtM_Status.Text))
			{
				strErr+="用药状态格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MedicationID=int.Parse(this.lblMedicationID.Text);
			int M_ConsultationID=int.Parse(this.txtM_ConsultationID.Text);
			DateTime M_StartDate=DateTime.Parse(this.txtM_StartDate.Text);
			int M_Status=int.Parse(this.txtM_Status.Text);


			Maticsoft.Model.record_Medication model=new Maticsoft.Model.record_Medication();
			model.MedicationID=MedicationID;
			model.M_ConsultationID=M_ConsultationID;
			model.M_StartDate=M_StartDate;
			model.M_Status=M_Status;

			Maticsoft.BLL.record_Medication bll=new Maticsoft.BLL.record_Medication();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
