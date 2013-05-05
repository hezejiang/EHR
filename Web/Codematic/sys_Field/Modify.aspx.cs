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
namespace Maticsoft.Web.sys_Field
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FieldID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FieldID);
				}
			}
		}
			
	private void ShowInfo(int FieldID)
	{
		Maticsoft.BLL.sys_Field bll=new Maticsoft.BLL.sys_Field();
		Maticsoft.Model.sys_Field model=bll.GetModel(FieldID);
		this.lblFieldID.Text=model.FieldID.ToString();
		this.txtF_Key.Text=model.F_Key;
		this.txtF_CName.Text=model.F_CName;
		this.txtF_Remark.Text=model.F_Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtF_Key.Text.Trim().Length==0)
			{
				strErr+="应用字段关键字不能为空！\\n";	
			}
			if(this.txtF_CName.Text.Trim().Length==0)
			{
				strErr+="应用字段中文说明不能为空！\\n";	
			}
			if(this.txtF_Remark.Text.Trim().Length==0)
			{
				strErr+="描述说明不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FieldID=int.Parse(this.lblFieldID.Text);
			string F_Key=this.txtF_Key.Text;
			string F_CName=this.txtF_CName.Text;
			string F_Remark=this.txtF_Remark.Text;


			Maticsoft.Model.sys_Field model=new Maticsoft.Model.sys_Field();
			model.FieldID=FieldID;
			model.F_Key=F_Key;
			model.F_CName=F_CName;
			model.F_Remark=F_Remark;

			Maticsoft.BLL.sys_Field bll=new Maticsoft.BLL.sys_Field();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
