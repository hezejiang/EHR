using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.extend_FamilyHistory
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.extend_FamilyHistory bll=new Maticsoft.BLL.extend_FamilyHistory();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FamilyHistoryID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(FamilyHistoryID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}