﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.record_FollowUp
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.record_FollowUp bll=new Maticsoft.BLL.record_FollowUp();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FollowUpID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(FollowUpID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}