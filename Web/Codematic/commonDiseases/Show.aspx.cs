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
namespace Maticsoft.Web.commonDiseases
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
					int CommonDiseaseID=(Convert.ToInt32(strid));
					ShowInfo(CommonDiseaseID);
				}
			}
		}
		
	private void ShowInfo(int CommonDiseaseID)
	{
		Maticsoft.BLL.commonDiseases bll=new Maticsoft.BLL.commonDiseases();
		Maticsoft.Model.commonDiseases model=bll.GetModel(CommonDiseaseID);
		this.lblCommonDiseaseID.Text=model.CommonDiseaseID.ToString();
		this.lblCD_Name.Text=model.CD_Name;

	}


    }
}
