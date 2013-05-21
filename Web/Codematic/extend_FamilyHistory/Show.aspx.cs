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
namespace Maticsoft.Web.extend_FamilyHistory
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
					int FamilyHistoryID=(Convert.ToInt32(strid));
					ShowInfo(FamilyHistoryID);
				}
			}
		}
		
	private void ShowInfo(int FamilyHistoryID)
	{
		Maticsoft.BLL.extend_FamilyHistory bll=new Maticsoft.BLL.extend_FamilyHistory();
		Maticsoft.Model.extend_FamilyHistory model=bll.GetModel(FamilyHistoryID);
		this.lblFamilyHistoryID.Text=model.FamilyHistoryID.ToString();
		this.lblFH_Type.Text=model.FH_Type.ToString();
		this.lblFH_Who.Text=model.FH_Who.ToString();
		this.lblFH_Note.Text=model.FH_Note;
		this.lblFH_UserID.Text=model.FH_UserID.ToString();

	}


    }
}
