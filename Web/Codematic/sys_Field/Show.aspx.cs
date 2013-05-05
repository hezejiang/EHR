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
namespace Maticsoft.Web.sys_Field
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
					int FieldID=(Convert.ToInt32(strid));
					ShowInfo(FieldID);
				}
			}
		}
		
	private void ShowInfo(int FieldID)
	{
		Maticsoft.BLL.sys_Field bll=new Maticsoft.BLL.sys_Field();
		Maticsoft.Model.sys_Field model=bll.GetModel(FieldID);
		this.lblFieldID.Text=model.FieldID.ToString();
		this.lblF_Key.Text=model.F_Key;
		this.lblF_CName.Text=model.F_CName;
		this.lblF_Remark.Text=model.F_Remark;

	}


    }
}
