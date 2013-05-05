using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_Module
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_Module bll=new Maticsoft.BLL.sys_Module();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ModuleID=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(ModuleID);
				}
			}

        }
    }
}