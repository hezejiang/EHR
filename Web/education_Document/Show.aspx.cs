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
namespace Maticsoft.Web.education_Document
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
					int DocumentID=(Convert.ToInt32(strid));
					ShowInfo(DocumentID);
				}
			}
		}
		
	private void ShowInfo(int DocumentID)
	{
		Maticsoft.BLL.education_Document bll=new Maticsoft.BLL.education_Document();
		Maticsoft.Model.education_Document model=bll.GetModel(DocumentID);
		this.lblDocumentID.Text=model.DocumentID.ToString();
		this.lblD_Name.Text=model.D_Name;
		this.lblD_Url.Text=model.D_Url;

	}


    }
}
