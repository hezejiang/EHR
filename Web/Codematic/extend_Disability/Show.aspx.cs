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
namespace Maticsoft.Web.extend_Disability
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
					int DisabilityID=(Convert.ToInt32(strid));
					ShowInfo(DisabilityID);
				}
			}
		}
		
	private void ShowInfo(int DisabilityID)
	{
		Maticsoft.BLL.extend_Disability bll=new Maticsoft.BLL.extend_Disability();
		Maticsoft.Model.extend_Disability model=bll.GetModel(DisabilityID);
		this.lblDisabilityID.Text=model.DisabilityID.ToString();
		this.lblD_Type.Text=model.D_Type.ToString();
		this.lblD_Note.Text=model.D_Note;
		this.lblD_UserID.Text=model.D_UserID.ToString();

	}


    }
}
