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
namespace Maticsoft.Web.record_DeathRegistration
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DeathID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(DeathID);
				}
			}
		}
			
	private void ShowInfo(int DeathID)
	{
		Maticsoft.BLL.record_DeathRegistration bll=new Maticsoft.BLL.record_DeathRegistration();
		Maticsoft.Model.record_DeathRegistration model=bll.GetModel(DeathID);
		this.lblDeathID.Text=model.DeathID.ToString();
		this.txtD_DateTime.Text=model.D_DateTime.ToString();
		this.txtD_Location.Text=model.D_Location;
		this.txtD_Icd10ID.Text=model.D_Icd10ID.ToString();
		this.txtD_Note.Text=model.D_Note;
		this.txtD_UserID.Text=model.D_UserID.ToString();
		this.txtD_RegDate.Text=model.D_RegDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtD_DateTime.Text))
			{
				strErr+="D_DateTime格式错误！\\n";	
			}
			if(this.txtD_Location.Text.Trim().Length==0)
			{
				strErr+="D_Location不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtD_Icd10ID.Text))
			{
				strErr+="疾病icd10编码格式错误！\\n";	
			}
			if(this.txtD_Note.Text.Trim().Length==0)
			{
				strErr+="死亡说明不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtD_UserID.Text))
			{
				strErr+="登记人,与sys_User表的格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtD_RegDate.Text))
			{
				strErr+="登记日期格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int DeathID=int.Parse(this.lblDeathID.Text);
			DateTime D_DateTime=DateTime.Parse(this.txtD_DateTime.Text);
			string D_Location=this.txtD_Location.Text;
			int D_Icd10ID=int.Parse(this.txtD_Icd10ID.Text);
			string D_Note=this.txtD_Note.Text;
			int D_UserID=int.Parse(this.txtD_UserID.Text);
			DateTime D_RegDate=DateTime.Parse(this.txtD_RegDate.Text);


			Maticsoft.Model.record_DeathRegistration model=new Maticsoft.Model.record_DeathRegistration();
			model.DeathID=DeathID;
			model.D_DateTime=D_DateTime;
			model.D_Location=D_Location;
			model.D_Icd10ID=D_Icd10ID;
			model.D_Note=D_Note;
			model.D_UserID=D_UserID;
			model.D_RegDate=D_RegDate;

			Maticsoft.BLL.record_DeathRegistration bll=new Maticsoft.BLL.record_DeathRegistration();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
