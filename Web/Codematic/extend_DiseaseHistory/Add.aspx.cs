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
namespace Maticsoft.Web.extend_DiseaseHistory
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtDH_Type.Text))
			{
				strErr+="疾病名称：1 高血压, 2 糖格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDH_DiagnosisDate.Text))
			{
				strErr+="确诊日期格式错误！\\n";	
			}
			if(this.txtDH_Note.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDH_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int DH_Type=int.Parse(this.txtDH_Type.Text);
			DateTime DH_DiagnosisDate=DateTime.Parse(this.txtDH_DiagnosisDate.Text);
			string DH_Note=this.txtDH_Note.Text;
			int DH_UserID=int.Parse(this.txtDH_UserID.Text);

			Maticsoft.Model.extend_DiseaseHistory model=new Maticsoft.Model.extend_DiseaseHistory();
			model.DH_Type=DH_Type;
			model.DH_DiagnosisDate=DH_DiagnosisDate;
			model.DH_Note=DH_Note;
			model.DH_UserID=DH_UserID;

			Maticsoft.BLL.extend_DiseaseHistory bll=new Maticsoft.BLL.extend_DiseaseHistory();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
