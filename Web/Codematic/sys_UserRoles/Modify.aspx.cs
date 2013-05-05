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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.sys_UserRoles
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int R_UserID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					R_UserID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int R_RoleID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					R_RoleID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(R_UserID,R_RoleID);
			}
		}
			
	private void ShowInfo(int R_UserID,int R_RoleID)
	{
		Maticsoft.BLL.sys_UserRoles bll=new Maticsoft.BLL.sys_UserRoles();
		Maticsoft.Model.sys_UserRoles model=bll.GetModel(R_UserID,R_RoleID);
		this.lblR_UserID.Text=model.R_UserID.ToString();
		this.lblR_RoleID.Text=model.R_RoleID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int R_UserID=int.Parse(this.lblR_UserID.Text);
			int R_RoleID=int.Parse(this.lblR_RoleID.Text);


			Maticsoft.Model.sys_UserRoles model=new Maticsoft.Model.sys_UserRoles();
			model.R_UserID=R_UserID;
			model.R_RoleID=R_RoleID;

			Maticsoft.BLL.sys_UserRoles bll=new Maticsoft.BLL.sys_UserRoles();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
