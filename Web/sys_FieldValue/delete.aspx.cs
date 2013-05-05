using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.sys_FieldValue
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.sys_FieldValue bll=new Maticsoft.BLL.sys_FieldValue();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ValueID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(ValueID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}