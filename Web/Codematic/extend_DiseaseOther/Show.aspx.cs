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
namespace Maticsoft.Web.extend_DiseaseOther
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
					int DiseaseOtherID=(Convert.ToInt32(strid));
					ShowInfo(DiseaseOtherID);
				}
			}
		}
		
	private void ShowInfo(int DiseaseOtherID)
	{
		Maticsoft.BLL.extend_DiseaseOther bll=new Maticsoft.BLL.extend_DiseaseOther();
		Maticsoft.Model.extend_DiseaseOther model=bll.GetModel(DiseaseOtherID);
		this.lblDiseaseOtherID.Text=model.DiseaseOtherID.ToString();
		this.lblDO_Type.Text=model.DO_Type.ToString();
		this.lblDO_Date.Text=model.DO_Date.ToString();
		this.lblDO_Name.Text=model.DO_Name;
		this.lblDO_UserID.Text=model.DO_UserID.ToString();

	}


    }
}
