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
namespace Maticsoft.Web.sys_RoleApplication
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int A_RoleID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					A_RoleID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int A_ApplicationID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					A_ApplicationID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(A_RoleID,A_ApplicationID);
			}
		}
		
	private void ShowInfo(int A_RoleID,int A_ApplicationID)
	{
		Maticsoft.BLL.sys_RoleApplication bll=new Maticsoft.BLL.sys_RoleApplication();
		Maticsoft.Model.sys_RoleApplication model=bll.GetModel(A_RoleID,A_ApplicationID);
		this.lblA_RoleID.Text=model.A_RoleID.ToString();
		this.lblA_ApplicationID.Text=model.A_ApplicationID.ToString();

	}


    }
}
