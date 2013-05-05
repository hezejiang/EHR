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
namespace Maticsoft.Web.supervision_Info
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int InfoID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(InfoID);
				}
			}
		}
			
	private void ShowInfo(int InfoID)
	{
		Maticsoft.BLL.supervision_Info bll=new Maticsoft.BLL.supervision_Info();
		Maticsoft.Model.supervision_Info model=bll.GetModel(InfoID);
		this.lblInfoID.Text=model.InfoID.ToString();
		this.txtI_FindDate.Text=model.I_FindDate.ToString();
		this.txtI_Type.Text=model.I_Type.ToString();
		this.txtI_Content.Text=model.I_Content;
		this.txtI_ReportDate.Text=model.I_ReportDate.ToString();
		this.txtI_ReportUserID.Text=model.I_ReportUserID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtI_FindDate.Text))
			{
				strErr+="发现时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtI_Type.Text))
			{
				strErr+="信息类别格式错误！\\n";	
			}
			if(this.txtI_Content.Text.Trim().Length==0)
			{
				strErr+="信息内容不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtI_ReportDate.Text))
			{
				strErr+="报告时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtI_ReportUserID.Text))
			{
				strErr+="报告人格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int InfoID=int.Parse(this.lblInfoID.Text);
			DateTime I_FindDate=DateTime.Parse(this.txtI_FindDate.Text);
			int I_Type=int.Parse(this.txtI_Type.Text);
			string I_Content=this.txtI_Content.Text;
			DateTime I_ReportDate=DateTime.Parse(this.txtI_ReportDate.Text);
			int I_ReportUserID=int.Parse(this.txtI_ReportUserID.Text);


			Maticsoft.Model.supervision_Info model=new Maticsoft.Model.supervision_Info();
			model.InfoID=InfoID;
			model.I_FindDate=I_FindDate;
			model.I_Type=I_Type;
			model.I_Content=I_Content;
			model.I_ReportDate=I_ReportDate;
			model.I_ReportUserID=I_ReportUserID;

			Maticsoft.BLL.supervision_Info bll=new Maticsoft.BLL.supervision_Info();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
