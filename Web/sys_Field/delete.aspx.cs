using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_Field
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_Field bll=new Maticsoft.BLL.sys_Field();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FieldID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(FieldID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}