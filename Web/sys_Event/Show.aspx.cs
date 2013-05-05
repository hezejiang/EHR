using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.sys_Event
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int EventID=(Convert.ToInt32(strid));
					ShowInfo(EventID);
				}
			}
		}
		
	private void ShowInfo(int EventID)
	{
		Maticsoft.BLL.sys_Event bll=new Maticsoft.BLL.sys_Event();
		Maticsoft.Model.sys_Event model=bll.GetModel(EventID);
		this.lblEventID.Text=model.EventID.ToString();
		this.lblE_U_LoginName.Text=model.E_U_LoginName;
		this.lblE_UserID.Text=model.E_UserID.ToString();
		this.lblE_DateTime.Text=model.E_DateTime.ToString();
		this.lblE_ApplicationID.Text=model.E_ApplicationID.ToString();
		this.lblE_A_AppName.Text=model.E_A_AppName;
		this.lblE_M_Name.Text=model.E_M_Name;
		this.lblE_M_PageCode.Text=model.E_M_PageCode;
		this.lblE_From.Text=model.E_From;
		this.lblE_Type.Text=model.E_Type.ToString();
		this.lblE_IP.Text=model.E_IP;
		this.lblE_Record.Text=model.E_Record;

	}


    }
}
