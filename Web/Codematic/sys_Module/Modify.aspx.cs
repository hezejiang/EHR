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
namespace Maticsoft.Web.sys_Module
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ModuleID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ModuleID);
				}
			}
		}
			
	private void ShowInfo(int ModuleID)
	{
		Maticsoft.BLL.sys_Module bll=new Maticsoft.BLL.sys_Module();
		Maticsoft.Model.sys_Module model=bll.GetModel(ModuleID);
		this.lblModuleID.Text=model.ModuleID.ToString();
		this.lblM_ApplicationID.Text=model.M_ApplicationID.ToString();
		this.txtM_ParentID.Text=model.M_ParentID.ToString();
		this.lblM_PageCode.Text=model.M_PageCode;
		this.txtM_CName.Text=model.M_CName;
		this.txtM_Directory.Text=model.M_Directory;
		this.txtM_OrderLevel.Text=model.M_OrderLevel;
		this.txtM_IsSystem.Text=model.M_IsSystem.ToString();
		this.txtM_Close.Text=model.M_Close.ToString();
		this.txtM_Icon.Text=model.M_Icon;
		this.txtM_Info.Text=model.M_Info;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtM_ParentID.Text))
			{
				strErr+="所属父级模块ID与Module格式错误！\\n";	
			}
			if(this.txtM_CName.Text.Trim().Length==0)
			{
				strErr+="模块/栏目名称当ParentI不能为空！\\n";	
			}
			if(this.txtM_Directory.Text.Trim().Length==0)
			{
				strErr+="模块/栏目???录名不能为空！\\n";	
			}
			if(this.txtM_OrderLevel.Text.Trim().Length==0)
			{
				strErr+="当前所在排序级别支持双层99级不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtM_IsSystem.Text))
			{
				strErr+="是否为系统模块1:是0:否如为格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtM_Close.Text))
			{
				strErr+="是否关闭1:是0:否格式错误！\\n";	
			}
			if(this.txtM_Icon.Text.Trim().Length==0)
			{
				strErr+="模块Icon不能为空！\\n";	
			}
			if(this.txtM_Info.Text.Trim().Length==0)
			{
				strErr+="模块说明不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ModuleID=int.Parse(this.lblModuleID.Text);
			int M_ApplicationID=int.Parse(this.lblM_ApplicationID.Text);
			int M_ParentID=int.Parse(this.txtM_ParentID.Text);
			string M_PageCode=this.lblM_PageCode.Text;
			string M_CName=this.txtM_CName.Text;
			string M_Directory=this.txtM_Directory.Text;
			string M_OrderLevel=this.txtM_OrderLevel.Text;
			int M_IsSystem=int.Parse(this.txtM_IsSystem.Text);
			int M_Close=int.Parse(this.txtM_Close.Text);
			string M_Icon=this.txtM_Icon.Text;
			string M_Info=this.txtM_Info.Text;


			Maticsoft.Model.sys_Module model=new Maticsoft.Model.sys_Module();
			model.ModuleID=ModuleID;
			model.M_ApplicationID=M_ApplicationID;
			model.M_ParentID=M_ParentID;
			model.M_PageCode=M_PageCode;
			model.M_CName=M_CName;
			model.M_Directory=M_Directory;
			model.M_OrderLevel=M_OrderLevel;
			model.M_IsSystem=M_IsSystem;
			model.M_Close=M_Close;
			model.M_Icon=M_Icon;
			model.M_Info=M_Info;

			Maticsoft.BLL.sys_Module bll=new Maticsoft.BLL.sys_Module();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
