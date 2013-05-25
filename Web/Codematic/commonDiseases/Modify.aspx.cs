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
namespace Maticsoft.Web.commonDiseases
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CommonDiseaseID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(CommonDiseaseID);
				}
			}
		}
			
	private void ShowInfo(int CommonDiseaseID)
	{
		Maticsoft.BLL.commonDiseases bll=new Maticsoft.BLL.commonDiseases();
		Maticsoft.Model.commonDiseases model=bll.GetModel(CommonDiseaseID);
		this.lblCommonDiseaseID.Text=model.CommonDiseaseID.ToString();
		this.txtCD_Name.Text=model.CD_Name;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCD_Name.Text.Trim().Length==0)
			{
				strErr+="常见疾病名称不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CommonDiseaseID=int.Parse(this.lblCommonDiseaseID.Text);
			string CD_Name=this.txtCD_Name.Text;


			Maticsoft.Model.commonDiseases model=new Maticsoft.Model.commonDiseases();
			model.CommonDiseaseID=CommonDiseaseID;
			model.CD_Name=CD_Name;

			Maticsoft.BLL.commonDiseases bll=new Maticsoft.BLL.commonDiseases();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
