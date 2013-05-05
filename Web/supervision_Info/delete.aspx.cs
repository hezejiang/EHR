using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.supervision_Info
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.supervision_Info bll=new Maticsoft.BLL.supervision_Info();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int InfoID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(InfoID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}