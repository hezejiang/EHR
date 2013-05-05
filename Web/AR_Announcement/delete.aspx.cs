using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.AR_Announcement
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.AR_Announcement bll=new Maticsoft.BLL.AR_Announcement();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int AnnouncementID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(AnnouncementID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}