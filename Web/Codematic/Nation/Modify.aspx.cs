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
namespace Maticsoft.Web.Nation
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NationID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(NationID);
				}
			}
		}
			
	private void ShowInfo(int NationID)
	{
		Maticsoft.BLL.Nation bll=new Maticsoft.BLL.Nation();
		Maticsoft.Model.Nation model=bll.GetModel(NationID);
		this.lblNationID.Text=model.NationID.ToString();
		this.txtN_Name.Text=model.N_Name;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtN_Name.Text.Trim().Length==0)
			{
				strErr+="民族名不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int NationID=int.Parse(this.lblNationID.Text);
			string N_Name=this.txtN_Name.Text;


			Maticsoft.Model.Nation model=new Maticsoft.Model.Nation();
			model.NationID=NationID;
			model.N_Name=N_Name;

			Maticsoft.BLL.Nation bll=new Maticsoft.BLL.Nation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
