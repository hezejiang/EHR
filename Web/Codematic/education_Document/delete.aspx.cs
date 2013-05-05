using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.education_Document
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.education_Document bll=new Maticsoft.BLL.education_Document();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DocumentID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(DocumentID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}