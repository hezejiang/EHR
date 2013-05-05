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
namespace Maticsoft.Web.record_UserBaseInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtU_Hometown.Text.Trim().Length==0)
			{
				strErr+="户籍地址不能为空！\\n";	
			}
			if(this.txtU_CurrentAddress.Text.Trim().Length==0)
			{
				strErr+="现住址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_FilingUnits.Text))
			{
				strErr+="建档单位（居委会或者是医院部门格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_FilingUserID.Text))
			{
				strErr+="建档人格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_ResponsibilityUserID.Text))
			{
				strErr+="责任医生格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_Committee.Text))
			{
				strErr+="居(村)委会格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtU_FlingTime.Text))
			{
				strErr+="建档日期格式错误！\\n";	
			}
			if(this.txtU_WorkingUnits.Text.Trim().Length==0)
			{
				strErr+="工作单位不能为空！\\n";	
			}
			if(this.txtU_WorkingContactName.Text.Trim().Length==0)
			{
				strErr+="职位联系人姓名不能为空！\\n";	
			}
			if(this.txtU_WorkingContactTel.Text.Trim().Length==0)
			{
				strErr+="职位联系人电话不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_BloodType.Text))
			{
				strErr+="血型 1:A型格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_NationID.Text))
			{
				strErr+="民族格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_MarriageStatus.Text))
			{
				strErr+="婚姻状态 1:未婚格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_PermanentType.Text))
			{
				strErr+="常住类型 1:户籍格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_Education.Text))
			{
				strErr+="文化程度 1:文盲及半文盲格式错误！\\n";	
			}
			if(this.txtU_PaymentType.Text.Trim().Length==0)
			{
				strErr+="付费类型(可多选不能为空！\\n";	
			}
			if(this.txtU_SocialNO.Text.Trim().Length==0)
			{
				strErr+="社保号不能为空！\\n";	
			}
			if(this.txtU_MedicalNO.Text.Trim().Length==0)
			{
				strErr+="医保号不能为空！\\n";	
			}
			if(this.txtU_FamilyCode.Text.Trim().Length==0)
			{
				strErr+="家庭编号不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_RelationShip.Text))
			{
				strErr+="与户主关系 1:父亲 2:母亲格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtU_Status.Text))
			{
				strErr+="档案状态格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string U_Hometown=this.txtU_Hometown.Text;
			string U_CurrentAddress=this.txtU_CurrentAddress.Text;
			int U_FilingUnits=int.Parse(this.txtU_FilingUnits.Text);
			int U_FilingUserID=int.Parse(this.txtU_FilingUserID.Text);
			int U_ResponsibilityUserID=int.Parse(this.txtU_ResponsibilityUserID.Text);
			int U_Committee=int.Parse(this.txtU_Committee.Text);
			DateTime U_FlingTime=DateTime.Parse(this.txtU_FlingTime.Text);
			string U_WorkingUnits=this.txtU_WorkingUnits.Text;
			string U_WorkingContactName=this.txtU_WorkingContactName.Text;
			string U_WorkingContactTel=this.txtU_WorkingContactTel.Text;
			int U_BloodType=int.Parse(this.txtU_BloodType.Text);
			int U_NationID=int.Parse(this.txtU_NationID.Text);
			int U_MarriageStatus=int.Parse(this.txtU_MarriageStatus.Text);
			int U_PermanentType=int.Parse(this.txtU_PermanentType.Text);
			int U_Education=int.Parse(this.txtU_Education.Text);
			string U_PaymentType=this.txtU_PaymentType.Text;
			string U_SocialNO=this.txtU_SocialNO.Text;
			string U_MedicalNO=this.txtU_MedicalNO.Text;
			string U_FamilyCode=this.txtU_FamilyCode.Text;
			int U_RelationShip=int.Parse(this.txtU_RelationShip.Text);
			int U_Status=int.Parse(this.txtU_Status.Text);

			Maticsoft.Model.record_UserBaseInfo model=new Maticsoft.Model.record_UserBaseInfo();
			model.U_Hometown=U_Hometown;
			model.U_CurrentAddress=U_CurrentAddress;
			model.U_FilingUnits=U_FilingUnits;
			model.U_FilingUserID=U_FilingUserID;
			model.U_ResponsibilityUserID=U_ResponsibilityUserID;
			model.U_Committee=U_Committee;
			model.U_FlingTime=U_FlingTime;
			model.U_WorkingUnits=U_WorkingUnits;
			model.U_WorkingContactName=U_WorkingContactName;
			model.U_WorkingContactTel=U_WorkingContactTel;
			model.U_BloodType=U_BloodType;
			model.U_NationID=U_NationID;
			model.U_MarriageStatus=U_MarriageStatus;
			model.U_PermanentType=U_PermanentType;
			model.U_Education=U_Education;
			model.U_PaymentType=U_PaymentType;
			model.U_SocialNO=U_SocialNO;
			model.U_MedicalNO=U_MedicalNO;
			model.U_FamilyCode=U_FamilyCode;
			model.U_RelationShip=U_RelationShip;
			model.U_Status=U_Status;

			Maticsoft.BLL.record_UserBaseInfo bll=new Maticsoft.BLL.record_UserBaseInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
