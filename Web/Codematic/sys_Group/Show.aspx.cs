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
namespace Maticsoft.Web.sys_Group
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
					int GroupID=(Convert.ToInt32(strid));
					ShowInfo(GroupID);
				}
			}
		}
		
	private void ShowInfo(int GroupID)
	{
		Maticsoft.BLL.sys_Group bll=new Maticsoft.BLL.sys_Group();
		Maticsoft.Model.sys_Group model=bll.GetModel(GroupID);
		this.lblGroupID.Text=model.GroupID.ToString();
		this.lblG_CName.Text=model.G_CName;
		this.lblG_ParentID.Text=model.G_ParentID.ToString();
		this.lblG_ShowOrder.Text=model.G_ShowOrder.ToString();
		this.lblG_Level.Text=model.G_Level.ToString();
		this.lblG_ChildCount.Text=model.G_ChildCount.ToString();
		this.lblG_Delete.Text=model.G_Delete.ToString();
		this.lblG_Type.Text=model.G_Type.ToString();
		this.lblG_Code.Text=model.G_Code;

	}


    }
}
