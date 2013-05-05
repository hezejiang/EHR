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
namespace Maticsoft.Web.record_FamilyBaseInfo
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
					int FimaryID=(Convert.ToInt32(strid));
					ShowInfo(FimaryID);
				}
			}
		}
		
	private void ShowInfo(int FimaryID)
	{
		Maticsoft.BLL.record_FamilyBaseInfo bll=new Maticsoft.BLL.record_FamilyBaseInfo();
		Maticsoft.Model.record_FamilyBaseInfo model=bll.GetModel(FimaryID);
		this.lblFimaryID.Text=model.FimaryID.ToString();
		this.lblF_FimaryCode.Text=model.F_FimaryCode;
		this.lblF_UserID.Text=model.F_UserID.ToString();
		this.lblF_GroupID.Text=model.F_GroupID.ToString();
		this.lblF_FimaryTel.Text=model.F_FimaryTel;
		this.lblF_FimrayAddress.Text=model.F_FimrayAddress;
		this.lblF_HouseType.Text=model.F_HouseType.ToString();
		this.lblF_HouseArea.Text=model.F_HouseArea.ToString();
		this.lblF_Ventilation.Text=model.F_Ventilation.ToString();
		this.lblF_Humidity.Text=model.F_Humidity.ToString();
		this.lblF_Warm.Text=model.F_Warm.ToString();
		this.lblF_Lighting.Text=model.F_Lighting.ToString();
		this.lblF_Sanitation.Text=model.F_Sanitation.ToString();
		this.lblF_Kitchen.Text=model.F_Kitchen.ToString();
		this.lblF_Fuel.Text=model.F_Fuel.ToString();
		this.lblF_Water.Text=model.F_Water.ToString();
		this.lblF_WasteDisposal.Text=model.F_WasteDisposal.ToString();
		this.lblF_LivestockBar.Text=model.F_LivestockBar.ToString();
		this.lblF_ToiletType.Text=model.F_ToiletType.ToString();
		this.lblF_ResponsibilityUserID.Text=model.F_ResponsibilityUserID.ToString();
		this.lblF_FillingUserID.Text=model.F_FillingUserID.ToString();

	}


    }
}
