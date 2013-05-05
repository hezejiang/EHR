using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_Online
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_Online bll=new Maticsoft.BLL.sys_Online();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int OnlineID=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(OnlineID);
				}
			}

        }
    }
}