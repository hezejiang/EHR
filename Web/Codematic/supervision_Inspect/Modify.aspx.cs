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
namespace Maticsoft.Web.supervision_Inspect
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int InspectID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(InspectID);
				}
			}
		}
			
	private void ShowInfo(int InspectID)
	{
		Maticsoft.BLL.supervision_Inspect bll=new Maticsoft.BLL.supervision_Inspect();
		Maticsoft.Model.supervision_Inspect model=bll.GetModel(InspectID);
		this.lblInspectID.Text=model.InspectID.ToString();
		this.txtI_Location.Text=model.I_Location;
		this.txtI_Type.Text=model.I_Type.ToString();
		this.txtI_Date.Text=model.I_Date.ToString();
		this.txtI_UserID.Text=model.I_UserID.ToString();
		this.txtI_Conent.Text=model.I_Conent;
		this.txtI_MainProblem.Text=model.I_MainProblem;
		this.txtI_Note.Text=model.I_Note;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtI_Location.Text.Trim().Length==0)
			{
				strErr+="I_Location不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtI_Type.Text))
			{
				strErr+="I_Type格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtI_Date.Text))
			{
				strErr+="巡查时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtI_UserID.Text))
			{
				strErr+="巡查人格式错误！\\n";	
			}
			if(this.txtI_Conent.Text.Trim().Length==0)
			{
				strErr+="寻常内容不能为空！\\n";	
			}
			if(this.txtI_MainProblem.Text.Trim().Length==0)
			{
				strErr+="发现的主要问题不能为空！\\n";	
			}
			if(this.txtI_Note.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int InspectID=int.Parse(this.lblInspectID.Text);
			string I_Location=this.txtI_Location.Text;
			int I_Type=int.Parse(this.txtI_Type.Text);
			DateTime I_Date=DateTime.Parse(this.txtI_Date.Text);
			int I_UserID=int.Parse(this.txtI_UserID.Text);
			string I_Conent=this.txtI_Conent.Text;
			string I_MainProblem=this.txtI_MainProblem.Text;
			string I_Note=this.txtI_Note.Text;


			Maticsoft.Model.supervision_Inspect model=new Maticsoft.Model.supervision_Inspect();
			model.InspectID=InspectID;
			model.I_Location=I_Location;
			model.I_Type=I_Type;
			model.I_Date=I_Date;
			model.I_UserID=I_UserID;
			model.I_Conent=I_Conent;
			model.I_MainProblem=I_MainProblem;
			model.I_Note=I_Note;

			Maticsoft.BLL.supervision_Inspect bll=new Maticsoft.BLL.supervision_Inspect();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
