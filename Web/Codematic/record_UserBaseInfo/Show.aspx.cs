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
namespace Maticsoft.Web.record_UserBaseInfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int UserID=(Convert.ToInt32(strid));
					ShowInfo(UserID);
				}
			}
		}
		
	private void ShowInfo(int UserID)
	{
		Maticsoft.BLL.record_UserBaseInfo bll=new Maticsoft.BLL.record_UserBaseInfo();
		Maticsoft.Model.record_UserBaseInfo model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID.ToString();
		this.lblU_Hometown.Text=model.U_Hometown;
		this.lblU_CurrentAddress.Text=model.U_CurrentAddress;
		this.lblU_FilingUnits.Text=model.U_FilingUnits.ToString();
		this.lblU_FilingUserID.Text=model.U_FilingUserID.ToString();
		this.lblU_ResponsibilityUserID.Text=model.U_ResponsibilityUserID.ToString();
		this.lblU_Committee.Text=model.U_Committee.ToString();
		this.lblU_FlingTime.Text=model.U_FlingTime.ToString();
		this.lblU_WorkingUnits.Text=model.U_WorkingUnits;
		this.lblU_WorkingContactName.Text=model.U_WorkingContactName;
		this.lblU_WorkingContactTel.Text=model.U_WorkingContactTel;
		this.lblU_BloodType.Text=model.U_BloodType.ToString();
		this.lblU_NationID.Text=model.U_NationID.ToString();
		this.lblU_MarriageStatus.Text=model.U_MarriageStatus.ToString();
		this.lblU_PermanentType.Text=model.U_PermanentType.ToString();
		this.lblU_Education.Text=model.U_Education.ToString();
		this.lblU_PaymentType.Text=model.U_PaymentType;
		this.lblU_SocialNO.Text=model.U_SocialNO;
		this.lblU_MedicalNO.Text=model.U_MedicalNO;
		this.lblU_FamilyCode.Text=model.U_FamilyCode;
		this.lblU_RelationShip.Text=model.U_RelationShip.ToString();
		this.lblU_Status.Text=model.U_AuditStatus.ToString();

	}


    }
}
