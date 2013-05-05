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
namespace Maticsoft.Web.sys_User
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
		Maticsoft.BLL.sys_User bll=new Maticsoft.BLL.sys_User();
		Maticsoft.Model.sys_User model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID.ToString();
		this.lblU_LoginName.Text=model.U_LoginName;
		this.lblU_Password.Text=model.U_Password;
		this.lblU_CName.Text=model.U_CName;
		this.lblU_EName.Text=model.U_EName;
		this.lblU_GroupID.Text=model.U_GroupID.ToString();
		this.lblU_Email.Text=model.U_Email;
		this.lblU_Type.Text=model.U_Type.ToString();
		this.lblU_Status.Text=model.U_Status.ToString();
		this.lblU_Licence.Text=model.U_Licence;
		this.lblU_Mac.Text=model.U_Mac;
		this.lblU_Remark.Text=model.U_Remark;
		this.lblU_IDCard.Text=model.U_IDCard;
		this.lblU_Sex.Text=model.U_Sex.ToString();
		this.lblU_BirthDay.Text=model.U_BirthDay.ToString();
		this.lblU_MobileNo.Text=model.U_MobileNo;
		this.lblU_UserNO.Text=model.U_UserNO;
		this.lblU_WorkStartDate.Text=model.U_WorkStartDate.ToString();
		this.lblU_WorkEndDate.Text=model.U_WorkEndDate.ToString();
		this.lblU_CompanyMail.Text=model.U_CompanyMail;
		this.lblU_Title.Text=model.U_Title.ToString();
		this.lblU_Extension.Text=model.U_Extension;
		this.lblU_HomeTel.Text=model.U_HomeTel;
		this.lblU_PhotoUrl.Text=model.U_PhotoUrl;
		this.lblU_DateTime.Text=model.U_DateTime.ToString();
		this.lblU_LastIP.Text=model.U_LastIP;
		this.lblU_LastDateTime.Text=model.U_LastDateTime.ToString();
		this.lblU_ExtendField.Text=model.U_ExtendField;
		this.lblU_LoginType.Text=model.U_LoginType;
		this.lblU_HospitalGroupID.Text=model.U_HospitalGroupID.ToString();

	}


    }
}
