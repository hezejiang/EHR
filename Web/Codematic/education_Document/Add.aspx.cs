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
namespace Maticsoft.Web.education_Document
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtD_Name.Text.Trim().Length==0)
			{
				strErr+="健康知识文档名称不能为空！\\n";	
			}
			if(this.txtD_Url.Text.Trim().Length==0)
			{
				strErr+="健康知识文档地址不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string D_Name=this.txtD_Name.Text;
			string D_Url=this.txtD_Url.Text;

			Maticsoft.Model.education_Document model=new Maticsoft.Model.education_Document();
			model.D_Name=D_Name;
			model.D_Url=D_Url;

			Maticsoft.BLL.education_Document bll=new Maticsoft.BLL.education_Document();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
