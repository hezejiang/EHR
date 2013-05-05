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
namespace Maticsoft.Web.sys_User
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UserID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UserID);
				}
			}
		}
			
	private void ShowInfo(int UserID)
	{
		Maticsoft.BLL.sys_User bll=new Maticsoft.BLL.sys_User();
		Maticsoft.Model.sys_User model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID.ToString();
		this.txtU_LoginName.Text=model.U_LoginName;
		this.txtU_Password.Text=model.U_Password;
		this.txtU_CName.Text=model.U_CName;
		this.txtU_EName.Text=model.U_EName;
		this.txtU_GroupID.Text=model.U_GroupID.ToString();
		this.txtU_Email.Text=model.U_Email;
		this.txtU_Type.Text=model.U_Type.ToString();
		this.txtU_Status.Text=model.U_Status.ToString();
		this.txtU_Licence.Text=model.U_Licence;
		this.txtU_Mac.Text=model.U_Mac;
		this.txtU_Remark.Text=model.U_Remark;
		this.txtU_IDCard.Text=model.U_IDCard;
		this.txtU_Sex.Text=model.U_Sex.ToString();
		this.txtU_BirthDay.Text=model.U_BirthDay.ToString();
		this.txtU_MobileNo.Text=model.U_MobileNo;
		this.txtU_UserNO.Text=model.U_UserNO;
		this.txtU_WorkStartDate.Text=model.U_WorkStartDate.ToString();
		this.txtU_WorkEndDate.Text=model.U_WorkEndDate.ToString();
		this.txtU_CompanyMail.Text=model.U_CompanyMail;
		this.txtU_Title.Text=model.U_Title.ToString();
		this.txtU_Extension.Text=model.U_Extension;
		this.txtU_HomeTel.Text=model.U_HomeTel;
		this.txtU_PhotoUrl.Text=model.U_PhotoUrl;
		this.txtU_DateTime.Text=model.U_DateTime.ToString();
		this.txtU_LastIP.Text=model.U_LastIP;
		this.txtU_LastDateTime.Text=model.U_LastDateTime.ToString();
		this.txtU_ExtendField.Text=model.U_ExtendField;
		this.txtU_LoginType.Text=model.U_LoginType;
		this.txtU_HospitalGroupID.Text=model.U_HospitalGroupID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtU_LoginName.Text.Trim().Length==0)
			{
				strErr+="登陆名不能为空！\\n";	
			}
			if(this.txtU_Password.Text.Trim().Length==0)
			{
				strErr+="密码md5加密字符不能为空！\\n";	
			}
			if(this.txtU_CName.Text.Trim().Length==0)
			{
				strErr+="中文姓名不能为空！\\n";	
			}
			if(this.txtU_EName.Text.Trim().Length==0)
			{
				strErr+="英文名不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_GroupID.Text))
			{
				strErr+="部门ID号与sys_Group表中GroupID关联格式错误！\\n";	
			}
			if(this.txtU_Email.Text.Trim().Length==0)
			{
				strErr+="电子邮件不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_Type.Text))
			{
				strErr+="用户类型0:超级用户1:普通用格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_Status.Text))
			{
				strErr+="当前状态0:正常 1:禁止登陆格式错误！\\n";	
			}
			if(this.txtU_Licence.Text.Trim().Length==0)
			{
				strErr+="用户序列号不能为空！\\n";	
			}
			if(this.txtU_Mac.Text.Trim().Length==0)
			{
				strErr+="锁定机器硬件地址不能为空！\\n";	
			}
			if(this.txtU_Remark.Text.Trim().Length==0)
			{
				strErr+="备注说明不能为空！\\n";	
			}
			if(this.txtU_IDCard.Text.Trim().Length==0)
			{
				strErr+="身份证号码不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_Sex.Text))
			{
				strErr+="性别1:男0:女格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtU_BirthDay.Text))
			{
				strErr+="出生日期格式错误！\\n";	
			}
			if(this.txtU_MobileNo.Text.Trim().Length==0)
			{
				strErr+="手机号不能为空！\\n";	
			}
			if(this.txtU_UserNO.Text.Trim().Length==0)
			{
				strErr+="员工编号不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtU_WorkStartDate.Text))
			{
				strErr+="到职日期格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtU_WorkEndDate.Text))
			{
				strErr+="离职日期格式错误！\\n";	
			}
			if(this.txtU_CompanyMail.Text.Trim().Length==0)
			{
				strErr+="公司邮件地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_Title.Text))
			{
				strErr+="职称与应用字段关联格式错误！\\n";	
			}
			if(this.txtU_Extension.Text.Trim().Length==0)
			{
				strErr+="分机号不能为空！\\n";	
			}
			if(this.txtU_HomeTel.Text.Trim().Length==0)
			{
				strErr+="家中电话不能为空！\\n";	
			}
			if(this.txtU_PhotoUrl.Text.Trim().Length==0)
			{
				strErr+="用户照片网址不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtU_DateTime.Text))
			{
				strErr+="操作时间格式错误！\\n";	
			}
			if(this.txtU_LastIP.Text.Trim().Length==0)
			{
				strErr+="最后访问IP不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtU_LastDateTime.Text))
			{
				strErr+="最后访问时间格式错误！\\n";	
			}
			if(this.txtU_ExtendField.Text.Trim().Length==0)
			{
				strErr+="扩展字段不能为空！\\n";	
			}
			if(this.txtU_LoginType.Text.Trim().Length==0)
			{
				strErr+="登入类型(为空系统认证,其它值不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_HospitalGroupID.Text))
			{
				strErr+="医院部门ID号与sys_Group表中GroupID关联格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserID=int.Parse(this.lblUserID.Text);
			string U_LoginName=this.txtU_LoginName.Text;
			string U_Password=this.txtU_Password.Text;
			string U_CName=this.txtU_CName.Text;
			string U_EName=this.txtU_EName.Text;
			int U_GroupID=int.Parse(this.txtU_GroupID.Text);
			string U_Email=this.txtU_Email.Text;
			int U_Type=int.Parse(this.txtU_Type.Text);
			int U_Status=int.Parse(this.txtU_Status.Text);
			string U_Licence=this.txtU_Licence.Text;
			string U_Mac=this.txtU_Mac.Text;
			string U_Remark=this.txtU_Remark.Text;
			string U_IDCard=this.txtU_IDCard.Text;
			int U_Sex=int.Parse(this.txtU_Sex.Text);
			DateTime U_BirthDay=DateTime.Parse(this.txtU_BirthDay.Text);
			string U_MobileNo=this.txtU_MobileNo.Text;
			string U_UserNO=this.txtU_UserNO.Text;
			DateTime U_WorkStartDate=DateTime.Parse(this.txtU_WorkStartDate.Text);
			DateTime U_WorkEndDate=DateTime.Parse(this.txtU_WorkEndDate.Text);
			string U_CompanyMail=this.txtU_CompanyMail.Text;
			int U_Title=int.Parse(this.txtU_Title.Text);
			string U_Extension=this.txtU_Extension.Text;
			string U_HomeTel=this.txtU_HomeTel.Text;
			string U_PhotoUrl=this.txtU_PhotoUrl.Text;
			DateTime U_DateTime=DateTime.Parse(this.txtU_DateTime.Text);
			string U_LastIP=this.txtU_LastIP.Text;
			DateTime U_LastDateTime=DateTime.Parse(this.txtU_LastDateTime.Text);
			string U_ExtendField=this.txtU_ExtendField.Text;
			string U_LoginType=this.txtU_LoginType.Text;
			int U_HospitalGroupID=int.Parse(this.txtU_HospitalGroupID.Text);


			Maticsoft.Model.sys_User model=new Maticsoft.Model.sys_User();
			model.UserID=UserID;
			model.U_LoginName=U_LoginName;
			model.U_Password=U_Password;
			model.U_CName=U_CName;
			model.U_EName=U_EName;
			model.U_GroupID=U_GroupID;
			model.U_Email=U_Email;
			model.U_Type=U_Type;
			model.U_Status=U_Status;
			model.U_Licence=U_Licence;
			model.U_Mac=U_Mac;
			model.U_Remark=U_Remark;
			model.U_IDCard=U_IDCard;
			model.U_Sex=U_Sex;
			model.U_BirthDay=U_BirthDay;
			model.U_MobileNo=U_MobileNo;
			model.U_UserNO=U_UserNO;
			model.U_WorkStartDate=U_WorkStartDate;
			model.U_WorkEndDate=U_WorkEndDate;
			model.U_CompanyMail=U_CompanyMail;
			model.U_Title=U_Title;
			model.U_Extension=U_Extension;
			model.U_HomeTel=U_HomeTel;
			model.U_PhotoUrl=U_PhotoUrl;
			model.U_DateTime=U_DateTime;
			model.U_LastIP=U_LastIP;
			model.U_LastDateTime=U_LastDateTime;
			model.U_ExtendField=U_ExtendField;
			model.U_LoginType=U_LoginType;
			model.U_HospitalGroupID=U_HospitalGroupID;

			Maticsoft.BLL.sys_User bll=new Maticsoft.BLL.sys_User();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
