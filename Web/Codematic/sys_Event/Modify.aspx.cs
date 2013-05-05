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
namespace Maticsoft.Web.sys_Event
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int EventID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(EventID);
				}
			}
		}
			
	private void ShowInfo(int EventID)
	{
		Maticsoft.BLL.sys_Event bll=new Maticsoft.BLL.sys_Event();
		Maticsoft.Model.sys_Event model=bll.GetModel(EventID);
		this.lblEventID.Text=model.EventID.ToString();
		this.txtE_U_LoginName.Text=model.E_U_LoginName;
		this.txtE_UserID.Text=model.E_UserID.ToString();
		this.txtE_DateTime.Text=model.E_DateTime.ToString();
		this.txtE_ApplicationID.Text=model.E_ApplicationID.ToString();
		this.txtE_A_AppName.Text=model.E_A_AppName;
		this.txtE_M_Name.Text=model.E_M_Name;
		this.txtE_M_PageCode.Text=model.E_M_PageCode;
		this.txtE_From.Text=model.E_From;
		this.txtE_Type.Text=model.E_Type.ToString();
		this.txtE_IP.Text=model.E_IP;
		this.txtE_Record.Text=model.E_Record;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtE_U_LoginName.Text.Trim().Length==0)
			{
				strErr+="用户名不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtE_UserID.Text))
			{
				strErr+="操作时用户ID与sys_Use格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtE_DateTime.Text))
			{
				strErr+="事件发生的日期及时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtE_ApplicationID.Text))
			{
				strErr+="所属应用程序ID与sys_Ap格式错误！\\n";	
			}
			if(this.txtE_A_AppName.Text.Trim().Length==0)
			{
				strErr+="所属应用名称不能为空！\\n";	
			}
			if(this.txtE_M_Name.Text.Trim().Length==0)
			{
				strErr+="PageCode模块名称与sy不能为空！\\n";	
			}
			if(this.txtE_M_PageCode.Text.Trim().Length==0)
			{
				strErr+="发生事件时模块名称不能为空！\\n";	
			}
			if(this.txtE_From.Text.Trim().Length==0)
			{
				strErr+="来源不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtE_Type.Text))
			{
				strErr+="日记类型,1:操作日记2:安全格式错误！\\n";	
			}
			if(this.txtE_IP.Text.Trim().Length==0)
			{
				strErr+="客户端IP地址不能为空！\\n";	
			}
			if(this.txtE_Record.Text.Trim().Length==0)
			{
				strErr+="详细描述不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int EventID=int.Parse(this.lblEventID.Text);
			string E_U_LoginName=this.txtE_U_LoginName.Text;
			int E_UserID=int.Parse(this.txtE_UserID.Text);
			DateTime E_DateTime=DateTime.Parse(this.txtE_DateTime.Text);
			int E_ApplicationID=int.Parse(this.txtE_ApplicationID.Text);
			string E_A_AppName=this.txtE_A_AppName.Text;
			string E_M_Name=this.txtE_M_Name.Text;
			string E_M_PageCode=this.txtE_M_PageCode.Text;
			string E_From=this.txtE_From.Text;
			int E_Type=int.Parse(this.txtE_Type.Text);
			string E_IP=this.txtE_IP.Text;
			string E_Record=this.txtE_Record.Text;


			Maticsoft.Model.sys_Event model=new Maticsoft.Model.sys_Event();
			model.EventID=EventID;
			model.E_U_LoginName=E_U_LoginName;
			model.E_UserID=E_UserID;
			model.E_DateTime=E_DateTime;
			model.E_ApplicationID=E_ApplicationID;
			model.E_A_AppName=E_A_AppName;
			model.E_M_Name=E_M_Name;
			model.E_M_PageCode=E_M_PageCode;
			model.E_From=E_From;
			model.E_Type=E_Type;
			model.E_IP=E_IP;
			model.E_Record=E_Record;

			Maticsoft.BLL.sys_Event bll=new Maticsoft.BLL.sys_Event();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
