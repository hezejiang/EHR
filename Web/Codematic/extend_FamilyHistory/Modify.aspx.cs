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
namespace Maticsoft.Web.extend_FamilyHistory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FamilyHistoryID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FamilyHistoryID);
				}
			}
		}
			
	private void ShowInfo(int FamilyHistoryID)
	{
		Maticsoft.BLL.extend_FamilyHistory bll=new Maticsoft.BLL.extend_FamilyHistory();
		Maticsoft.Model.extend_FamilyHistory model=bll.GetModel(FamilyHistoryID);
		this.lblFamilyHistoryID.Text=model.FamilyHistoryID.ToString();
		this.txtFH_Type.Text=model.FH_Type.ToString();
		this.txtFH_Who.Text=model.FH_Who.ToString();
		this.txtFH_Note.Text=model.FH_Note;
		this.txtFH_UserID.Text=model.FH_UserID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtFH_Type.Text))
			{
				strErr+="疾病名称：1 高血压, 2 糖格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFH_Who.Text))
			{
				strErr+="家庭成员角色：1父亲、2母亲、格式错误！\\n";	
			}
			if(this.txtFH_Note.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFH_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FamilyHistoryID=int.Parse(this.lblFamilyHistoryID.Text);
			int FH_Type=int.Parse(this.txtFH_Type.Text);
			int FH_Who=int.Parse(this.txtFH_Who.Text);
			string FH_Note=this.txtFH_Note.Text;
			int FH_UserID=int.Parse(this.txtFH_UserID.Text);


			Maticsoft.Model.extend_FamilyHistory model=new Maticsoft.Model.extend_FamilyHistory();
			model.FamilyHistoryID=FamilyHistoryID;
			model.FH_Type=FH_Type;
			model.FH_Who=FH_Who;
			model.FH_Note=FH_Note;
			model.FH_UserID=FH_UserID;

			Maticsoft.BLL.extend_FamilyHistory bll=new Maticsoft.BLL.extend_FamilyHistory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
