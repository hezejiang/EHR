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
namespace Maticsoft.Web.extend_Disability
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtD_Type.Text))
			{
				strErr+="残疾类型：0无格式错误！\\n";	
			}
			if(this.txtD_Note.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtD_UserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int D_Type=int.Parse(this.txtD_Type.Text);
			string D_Note=this.txtD_Note.Text;
			int D_UserID=int.Parse(this.txtD_UserID.Text);

			Maticsoft.Model.extend_Disability model=new Maticsoft.Model.extend_Disability();
			model.D_Type=D_Type;
			model.D_Note=D_Note;
			model.D_UserID=D_UserID;

			Maticsoft.BLL.extend_Disability bll=new Maticsoft.BLL.extend_Disability();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
