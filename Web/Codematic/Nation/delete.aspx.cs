using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Nation
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.Nation bll=new Maticsoft.BLL.Nation();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NationID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(NationID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}