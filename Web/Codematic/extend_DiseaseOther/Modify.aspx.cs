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
namespace Maticsoft.Web.extend_DiseaseOther
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DiseaseOtherID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(DiseaseOtherID);
				}
			}
		}
			
	private void ShowInfo(int DiseaseOtherID)
	{
		Maticsoft.BLL.extend_DiseaseOther bll=new Maticsoft.BLL.extend_DiseaseOther();
		Maticsoft.Model.extend_DiseaseOther model=bll.GetModel(DiseaseOtherID);
		this.lblDiseaseOtherID.Text=model.DiseaseOtherID.ToString();
		this.txtDO_Type.Text=model.DO_Type.ToString();
		this.txtDO_Date.Text=model.DO_Date.ToString();
		this.txtDO_Name.Text=model.DO_Name;
		this.txtDO_UserID.Text=model.DO_UserID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtDO_Type.Text))
			{
				strErr+="类型格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDO_Date.Text))
			{
				strErr+="日期格式错误！\\n";	
			}
			if(this.txtDO_Name.Text.Trim().Length==0)
			{
				strErr+="名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDO_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int DiseaseOtherID=int.Parse(this.lblDiseaseOtherID.Text);
			int DO_Type=int.Parse(this.txtDO_Type.Text);
			DateTime DO_Date=DateTime.Parse(this.txtDO_Date.Text);
			string DO_Name=this.txtDO_Name.Text;
			int DO_UserID=int.Parse(this.txtDO_UserID.Text);


			Maticsoft.Model.extend_DiseaseOther model=new Maticsoft.Model.extend_DiseaseOther();
			model.DiseaseOtherID=DiseaseOtherID;
			model.DO_Type=DO_Type;
			model.DO_Date=DO_Date;
			model.DO_Name=DO_Name;
			model.DO_UserID=DO_UserID;

			Maticsoft.BLL.extend_DiseaseOther bll=new Maticsoft.BLL.extend_DiseaseOther();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
