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
namespace Maticsoft.Web.extend_Environment
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
					int EnvironmentID=(Convert.ToInt32(strid));
					ShowInfo(EnvironmentID);
				}
			}
		}
		
	private void ShowInfo(int EnvironmentID)
	{
		Maticsoft.BLL.extend_Environment bll=new Maticsoft.BLL.extend_Environment();
		Maticsoft.Model.extend_Environment model=bll.GetModel(EnvironmentID);
		this.lblEnvironmentID.Text=model.EnvironmentID.ToString();
		this.lblE_Kind.Text=model.E_Kind.ToString();
		this.lblE_Type.Text=model.E_Type.ToString();
		this.lblE_UserID.Text=model.E_UserID.ToString();

	}


    }
}
