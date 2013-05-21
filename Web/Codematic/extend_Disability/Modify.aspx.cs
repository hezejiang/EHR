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
namespace Maticsoft.Web.extend_Disability
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DisabilityID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(DisabilityID);
				}
			}
		}
			
	private void ShowInfo(int DisabilityID)
	{
		Maticsoft.BLL.extend_Disability bll=new Maticsoft.BLL.extend_Disability();
		Maticsoft.Model.extend_Disability model=bll.GetModel(DisabilityID);
		this.lblDisabilityID.Text=model.DisabilityID.ToString();
		this.txtD_Type.Text=model.D_Type.ToString();
		this.txtD_Note.Text=model.D_Note;
		this.txtD_UserID.Text=model.D_UserID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtD_Type.Text))
			{
				strErr+="残疾类型：0无格式错误！\\n";	
			}
			if(this.txtD_Note.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtD_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int DisabilityID=int.Parse(this.lblDisabilityID.Text);
			int D_Type=int.Parse(this.txtD_Type.Text);
			string D_Note=this.txtD_Note.Text;
			int D_UserID=int.Parse(this.txtD_UserID.Text);


			Maticsoft.Model.extend_Disability model=new Maticsoft.Model.extend_Disability();
			model.DisabilityID=DisabilityID;
			model.D_Type=D_Type;
			model.D_Note=D_Note;
			model.D_UserID=D_UserID;

			Maticsoft.BLL.extend_Disability bll=new Maticsoft.BLL.extend_Disability();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
