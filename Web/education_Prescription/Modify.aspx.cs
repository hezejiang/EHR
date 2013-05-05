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
namespace Maticsoft.Web.education_Prescription
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int PrescriptionID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(PrescriptionID);
				}
			}
		}
			
	private void ShowInfo(int PrescriptionID)
	{
		Maticsoft.BLL.education_Prescription bll=new Maticsoft.BLL.education_Prescription();
		Maticsoft.Model.education_Prescription model=bll.GetModel(PrescriptionID);
		this.lblPrescriptionID.Text=model.PrescriptionID.ToString();
		this.txtP_Object.Text=model.P_Object.ToString();
		this.txtP_Name.Text=model.P_Name;
		this.txtP_Content.Text=model.P_Content;
		this.txtP_Doctor.Text=model.P_Doctor.ToString();
		this.txtP_Date.Text=model.P_Date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtP_Object.Text))
			{
				strErr+="健康处方对象格式错误！\\n";	
			}
			if(this.txtP_Name.Text.Trim().Length==0)
			{
				strErr+="处方名称不能为空！\\n";	
			}
			if(this.txtP_Content.Text.Trim().Length==0)
			{
				strErr+="处方内容不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtP_Doctor.Text))
			{
				strErr+="处方医生格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtP_Date.Text))
			{
				strErr+="处方日期格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int PrescriptionID=int.Parse(this.lblPrescriptionID.Text);
			decimal P_Object=decimal.Parse(this.txtP_Object.Text);
			string P_Name=this.txtP_Name.Text;
			string P_Content=this.txtP_Content.Text;
			int P_Doctor=int.Parse(this.txtP_Doctor.Text);
			DateTime P_Date=DateTime.Parse(this.txtP_Date.Text);


			Maticsoft.Model.education_Prescription model=new Maticsoft.Model.education_Prescription();
			model.PrescriptionID=PrescriptionID;
			model.P_Object=P_Object;
			model.P_Name=P_Name;
			model.P_Content=P_Content;
			model.P_Doctor=P_Doctor;
			model.P_Date=P_Date;

			Maticsoft.BLL.education_Prescription bll=new Maticsoft.BLL.education_Prescription();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
