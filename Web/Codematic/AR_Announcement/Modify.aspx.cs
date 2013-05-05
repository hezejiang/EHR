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
namespace Maticsoft.Web.AR_Announcement
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int AnnouncementID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(AnnouncementID);
				}
			}
		}
			
	private void ShowInfo(int AnnouncementID)
	{
		Maticsoft.BLL.AR_Announcement bll=new Maticsoft.BLL.AR_Announcement();
		Maticsoft.Model.AR_Announcement model=bll.GetModel(AnnouncementID);
		this.lblAnnouncementID.Text=model.AnnouncementID.ToString();
		this.txtA_Title.Text=model.A_Title;
		this.txtA_Content.Text=model.A_Content;
		this.txtA_DateTime.Text=model.A_DateTime.ToString();
		this.txtA_ResponsibilityUserID.Text=model.A_ResponsibilityUserID.ToString();
		this.txtA_Type.Text=model.A_Type.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtA_Title.Text.Trim().Length==0)
			{
				strErr+="公告标题不能为空！\\n";	
			}
			if(this.txtA_Content.Text.Trim().Length==0)
			{
				strErr+="公告内容不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtA_DateTime.Text))
			{
				strErr+="公告时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_ResponsibilityUserID.Text))
			{
				strErr+="责任人格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtA_Type.Text))
			{
				strErr+="公告类型格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int AnnouncementID=int.Parse(this.lblAnnouncementID.Text);
			string A_Title=this.txtA_Title.Text;
			string A_Content=this.txtA_Content.Text;
			DateTime A_DateTime=DateTime.Parse(this.txtA_DateTime.Text);
			int A_ResponsibilityUserID=int.Parse(this.txtA_ResponsibilityUserID.Text);
			int A_Type=int.Parse(this.txtA_Type.Text);


			Maticsoft.Model.AR_Announcement model=new Maticsoft.Model.AR_Announcement();
			model.AnnouncementID=AnnouncementID;
			model.A_Title=A_Title;
			model.A_Content=A_Content;
			model.A_DateTime=A_DateTime;
			model.A_ResponsibilityUserID=A_ResponsibilityUserID;
			model.A_Type=A_Type;

			Maticsoft.BLL.AR_Announcement bll=new Maticsoft.BLL.AR_Announcement();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
