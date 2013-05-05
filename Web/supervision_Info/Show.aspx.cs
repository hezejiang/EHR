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
namespace Maticsoft.Web.supervision_Info
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
					int InfoID=(Convert.ToInt32(strid));
					ShowInfo(InfoID);
				}
			}
		}
		
	private void ShowInfo(int InfoID)
	{
		Maticsoft.BLL.supervision_Info bll=new Maticsoft.BLL.supervision_Info();
		Maticsoft.Model.supervision_Info model=bll.GetModel(InfoID);
		this.lblInfoID.Text=model.InfoID.ToString();
		this.lblI_FindDate.Text=model.I_FindDate.ToString();
		this.lblI_Type.Text=model.I_Type.ToString();
		this.lblI_Content.Text=model.I_Content;
		this.lblI_ReportDate.Text=model.I_ReportDate.ToString();
		this.lblI_ReportUserID.Text=model.I_ReportUserID.ToString();

	}


    }
}
