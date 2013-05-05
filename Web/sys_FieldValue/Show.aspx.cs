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
namespace Maticsoft.Web.sys_FieldValue
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
					int ValueID=(Convert.ToInt32(strid));
					ShowInfo(ValueID);
				}
			}
		}
		
	private void ShowInfo(int ValueID)
	{
		Maticsoft.BLL.sys_FieldValue bll=new Maticsoft.BLL.sys_FieldValue();
		Maticsoft.Model.sys_FieldValue model=bll.GetModel(ValueID);
		this.lblValueID.Text=model.ValueID.ToString();
		this.lblV_F_Key.Text=model.V_F_Key;
		this.lblV_Text.Text=model.V_Text;
		this.lblV_Code.Text=model.V_Code;
		this.lblV_ShowOrder.Text=model.V_ShowOrder.ToString();

	}


    }
}
