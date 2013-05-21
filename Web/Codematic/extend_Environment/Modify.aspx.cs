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
namespace Maticsoft.Web.extend_Environment
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int EnvironmentID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(EnvironmentID);
				}
			}
		}
			
	private void ShowInfo(int EnvironmentID)
	{
		Maticsoft.BLL.extend_Environment bll=new Maticsoft.BLL.extend_Environment();
		Maticsoft.Model.extend_Environment model=bll.GetModel(EnvironmentID);
		this.lblEnvironmentID.Text=model.EnvironmentID.ToString();
		this.txtE_Kind.Text=model.E_Kind.ToString();
		this.txtE_Type.Text=model.E_Type.ToString();
		this.txtE_UserID.Text=model.E_UserID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtE_Kind.Text))
			{
				strErr+="种类：1 厨房排风设施格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtE_Type.Text))
			{
				strErr+="类型格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtE_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int EnvironmentID=int.Parse(this.lblEnvironmentID.Text);
			int E_Kind=int.Parse(this.txtE_Kind.Text);
			int E_Type=int.Parse(this.txtE_Type.Text);
			int E_UserID=int.Parse(this.txtE_UserID.Text);


			Maticsoft.Model.extend_Environment model=new Maticsoft.Model.extend_Environment();
			model.EnvironmentID=EnvironmentID;
			model.E_Kind=E_Kind;
			model.E_Type=E_Type;
			model.E_UserID=E_UserID;

			Maticsoft.BLL.extend_Environment bll=new Maticsoft.BLL.extend_Environment();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
