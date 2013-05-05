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
namespace Maticsoft.Web.education_Activity
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ActivityID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ActivityID);
				}
			}
		}
			
	private void ShowInfo(int ActivityID)
	{
		Maticsoft.BLL.education_Activity bll=new Maticsoft.BLL.education_Activity();
		Maticsoft.Model.education_Activity model=bll.GetModel(ActivityID);
		this.lblActivityID.Text=model.ActivityID.ToString();
		this.txtA_DateTime.Text=model.A_DateTime.ToString();
		this.txtA_Location.Text=model.A_Location;
		this.txtA_Form.Text=model.A_Form;
		this.txtA_Object.Text=model.A_Object.ToString();
		this.txtA_Crowd.Text=model.A_Crowd;
		this.txtA_Duration.Text=model.A_Duration.ToString();
		this.txtA_Organizers.Text=model.A_Organizers;
		this.txtA_Partners.Text=model.A_Partners;
		this.txtA_Missionary.Text=model.A_Missionary;
		this.txtA_Number.Text=model.A_Number.ToString();
		this.txtA_Theme.Text=model.A_Theme;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtA_DateTime.Text))
			{
				strErr+="活动时间格式错误！\\n";	
			}
			if(this.txtA_Location.Text.Trim().Length==0)
			{
				strErr+="活动地点不能为空！\\n";	
			}
			if(this.txtA_Form.Text.Trim().Length==0)
			{
				strErr+="活动形式不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_Object.Text))
			{
				strErr+="居委会ID格式错误！\\n";	
			}
			if(this.txtA_Crowd.Text.Trim().Length==0)
			{
				strErr+="参与人群不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_Duration.Text))
			{
				strErr+="持续时间（min）格式错误！\\n";	
			}
			if(this.txtA_Organizers.Text.Trim().Length==0)
			{
				strErr+="主办单位不能为空！\\n";	
			}
			if(this.txtA_Partners.Text.Trim().Length==0)
			{
				strErr+="合作伙伴不能为空！\\n";	
			}
			if(this.txtA_Missionary.Text.Trim().Length==0)
			{
				strErr+="宣教人不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_Number.Text))
			{
				strErr+="参与人数格式错误！\\n";	
			}
			if(this.txtA_Theme.Text.Trim().Length==0)
			{
				strErr+="活动主题不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ActivityID=int.Parse(this.lblActivityID.Text);
			DateTime A_DateTime=DateTime.Parse(this.txtA_DateTime.Text);
			string A_Location=this.txtA_Location.Text;
			string A_Form=this.txtA_Form.Text;
			int A_Object=int.Parse(this.txtA_Object.Text);
			string A_Crowd=this.txtA_Crowd.Text;
			int A_Duration=int.Parse(this.txtA_Duration.Text);
			string A_Organizers=this.txtA_Organizers.Text;
			string A_Partners=this.txtA_Partners.Text;
			string A_Missionary=this.txtA_Missionary.Text;
			int A_Number=int.Parse(this.txtA_Number.Text);
			string A_Theme=this.txtA_Theme.Text;


			Maticsoft.Model.education_Activity model=new Maticsoft.Model.education_Activity();
			model.ActivityID=ActivityID;
			model.A_DateTime=A_DateTime;
			model.A_Location=A_Location;
			model.A_Form=A_Form;
			model.A_Object=A_Object;
			model.A_Crowd=A_Crowd;
			model.A_Duration=A_Duration;
			model.A_Organizers=A_Organizers;
			model.A_Partners=A_Partners;
			model.A_Missionary=A_Missionary;
			model.A_Number=A_Number;
			model.A_Theme=A_Theme;

			Maticsoft.BLL.education_Activity bll=new Maticsoft.BLL.education_Activity();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
