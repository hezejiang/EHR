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
namespace Maticsoft.Web.Nation
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
					int NationID=(Convert.ToInt32(strid));
					ShowInfo(NationID);
				}
			}
		}
		
	private void ShowInfo(int NationID)
	{
		Maticsoft.BLL.Nation bll=new Maticsoft.BLL.Nation();
		Maticsoft.Model.Nation model=bll.GetModel(NationID);
		this.lblNationID.Text=model.NationID.ToString();
		this.lblN_Name.Text=model.N_Name;

	}


    }
}
