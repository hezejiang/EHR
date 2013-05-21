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
namespace Maticsoft.Web.extend_GeneticDisease
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int GeneticDiseaseID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(GeneticDiseaseID);
				}
			}
		}
			
	private void ShowInfo(int GeneticDiseaseID)
	{
		Maticsoft.BLL.extend_GeneticDisease bll=new Maticsoft.BLL.extend_GeneticDisease();
		Maticsoft.Model.extend_GeneticDisease model=bll.GetModel(GeneticDiseaseID);
		this.lblGeneticDiseaseID.Text=model.GeneticDiseaseID.ToString();
		this.txtGD_Name.Text=model.GD_Name;
		this.txtGD_UserID.Text=model.GD_UserID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtGD_Name.Text.Trim().Length==0)
			{
				strErr+="遗传病名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtGD_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int GeneticDiseaseID=int.Parse(this.lblGeneticDiseaseID.Text);
			string GD_Name=this.txtGD_Name.Text;
			int GD_UserID=int.Parse(this.txtGD_UserID.Text);


			Maticsoft.Model.extend_GeneticDisease model=new Maticsoft.Model.extend_GeneticDisease();
			model.GeneticDiseaseID=GeneticDiseaseID;
			model.GD_Name=GD_Name;
			model.GD_UserID=GD_UserID;

			Maticsoft.BLL.extend_GeneticDisease bll=new Maticsoft.BLL.extend_GeneticDisease();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
