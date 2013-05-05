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
namespace Maticsoft.Web.record_MedicationTime
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtM_Time.Text.Trim().Length==0)
			{
				strErr+="服药时间点（24小时制不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMedicationID.Text))
			{
				strErr+="与record_Medicat格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string M_Time=this.txtM_Time.Text;
			int MedicationID=int.Parse(this.txtMedicationID.Text);

			Maticsoft.Model.record_MedicationTime model=new Maticsoft.Model.record_MedicationTime();
			model.M_Time=M_Time;
			model.MedicationID=MedicationID;

			Maticsoft.BLL.record_MedicationTime bll=new Maticsoft.BLL.record_MedicationTime();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
