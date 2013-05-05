using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_Group
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_Group bll=new Maticsoft.BLL.sys_Group();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int GroupID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(GroupID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}