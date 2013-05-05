using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.supervision_Inspect
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.supervision_Inspect bll=new Maticsoft.BLL.supervision_Inspect();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int InspectID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(InspectID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}