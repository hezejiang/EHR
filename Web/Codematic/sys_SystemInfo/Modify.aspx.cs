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
namespace Maticsoft.Web.sys_SystemInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SystemID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(SystemID);
				}
			}
		}
			
	private void ShowInfo(int SystemID)
	{
		Maticsoft.BLL.sys_SystemInfo bll=new Maticsoft.BLL.sys_SystemInfo();
		Maticsoft.Model.sys_SystemInfo model=bll.GetModel(SystemID);
		this.lblSystemID.Text=model.SystemID.ToString();
		this.txtS_Name.Text=model.S_Name;
		this.txtS_Version.Text=model.S_Version;
		this.txtS_SystemConfigData.Text=model.S_SystemConfigData.ToString();
		this.txtS_Licensed.Text=model.S_Licensed;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtS_Name.Text.Trim().Length==0)
			{
				strErr+="系统名称不能为空！\\n";	
			}
			if(this.txtS_Version.Text.Trim().Length==0)
			{
				strErr+="版本号不能为空！\\n";	
			}
			if(this.txtS_Licensed.Text.Trim().Length==0)
			{
				strErr+="序列号不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SystemID=int.Parse(this.lblSystemID.Text);
			string S_Name=this.txtS_Name.Text;
			string S_Version=this.txtS_Version.Text;
			byte[] S_SystemConfigData= new UnicodeEncoding().GetBytes(this.txtS_SystemConfigData.Text);
			string S_Licensed=this.txtS_Licensed.Text;


			Maticsoft.Model.sys_SystemInfo model=new Maticsoft.Model.sys_SystemInfo();
			model.SystemID=SystemID;
			model.S_Name=S_Name;
			model.S_Version=S_Version;
			model.S_SystemConfigData=S_SystemConfigData;
			model.S_Licensed=S_Licensed;

			Maticsoft.BLL.sys_SystemInfo bll=new Maticsoft.BLL.sys_SystemInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
