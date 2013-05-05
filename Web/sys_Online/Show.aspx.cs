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
namespace Maticsoft.Web.sys_Online
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
					int OnlineID=(Convert.ToInt32(strid));
					ShowInfo(OnlineID);
				}
			}
		}
		
	private void ShowInfo(int OnlineID)
	{
		Maticsoft.BLL.sys_Online bll=new Maticsoft.BLL.sys_Online();
		Maticsoft.Model.sys_Online model=bll.GetModel(OnlineID);
		this.lblOnlineID.Text=model.OnlineID.ToString();
		this.lblO_SessionID.Text=model.O_SessionID;
		this.lblO_UserName.Text=model.O_UserName;
		this.lblO_Ip.Text=model.O_Ip;
		this.lblO_LoginTime.Text=model.O_LoginTime.ToString();
		this.lblO_LastTime.Text=model.O_LastTime.ToString();
		this.lblO_LastUrl.Text=model.O_LastUrl;

	}


    }
}
