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
namespace Maticsoft.Web.supervision_Inspect
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
					int InspectID=(Convert.ToInt32(strid));
					ShowInfo(InspectID);
				}
			}
		}
		
	private void ShowInfo(int InspectID)
	{
		Maticsoft.BLL.supervision_Inspect bll=new Maticsoft.BLL.supervision_Inspect();
		Maticsoft.Model.supervision_Inspect model=bll.GetModel(InspectID);
		this.lblInspectID.Text=model.InspectID.ToString();
		this.lblI_Location.Text=model.I_Location;
		this.lblI_Type.Text=model.I_Type.ToString();
		this.lblI_Date.Text=model.I_Date.ToString();
		this.lblI_UserID.Text=model.I_UserID.ToString();
		this.lblI_Conent.Text=model.I_Conent;
		this.lblI_MainProblem.Text=model.I_MainProblem;
		this.lblI_Note.Text=model.I_Note;

	}


    }
}
