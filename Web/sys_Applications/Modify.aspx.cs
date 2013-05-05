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
namespace Maticsoft.Web.sys_Applications
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ApplicationID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ApplicationID);
				}
			}
		}
			
	private void ShowInfo(int ApplicationID)
	{
		Maticsoft.BLL.sys_Applications bll=new Maticsoft.BLL.sys_Applications();
		Maticsoft.Model.sys_Applications model=bll.GetModel(ApplicationID);
		this.lblApplicationID.Text=model.ApplicationID.ToString();
		this.txtA_AppName.Text=model.A_AppName;
		this.txtA_AppDescription.Text=model.A_AppDescription;
		this.txtA_AppUrl.Text=model.A_AppUrl;
		this.txtA_Order.Text=model.A_Order.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtA_AppName.Text.Trim().Length==0)
			{
				strErr+="应用名称不能为空！\\n";	
			}
			if(this.txtA_AppDescription.Text.Trim().Length==0)
			{
				strErr+="应用介绍不能为空！\\n";	
			}
			if(this.txtA_AppUrl.Text.Trim().Length==0)
			{
				strErr+="应用Url地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_Order.Text))
			{
				strErr+="应用排序格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ApplicationID=int.Parse(this.lblApplicationID.Text);
			string A_AppName=this.txtA_AppName.Text;
			string A_AppDescription=this.txtA_AppDescription.Text;
			string A_AppUrl=this.txtA_AppUrl.Text;
			int A_Order=int.Parse(this.txtA_Order.Text);


			Maticsoft.Model.sys_Applications model=new Maticsoft.Model.sys_Applications();
			model.ApplicationID=ApplicationID;
			model.A_AppName=A_AppName;
			model.A_AppDescription=A_AppDescription;
			model.A_AppUrl=A_AppUrl;
			model.A_Order=A_Order;

			Maticsoft.BLL.sys_Applications bll=new Maticsoft.BLL.sys_Applications();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
