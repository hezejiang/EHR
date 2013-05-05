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
namespace Maticsoft.Web.sys_Group
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int GroupID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(GroupID);
				}
			}
		}
			
	private void ShowInfo(int GroupID)
	{
		Maticsoft.BLL.sys_Group bll=new Maticsoft.BLL.sys_Group();
		Maticsoft.Model.sys_Group model=bll.GetModel(GroupID);
		this.lblGroupID.Text=model.GroupID.ToString();
		this.txtG_CName.Text=model.G_CName;
		this.txtG_ParentID.Text=model.G_ParentID.ToString();
		this.txtG_ShowOrder.Text=model.G_ShowOrder.ToString();
		this.txtG_Level.Text=model.G_Level.ToString();
		this.txtG_ChildCount.Text=model.G_ChildCount.ToString();
		this.txtG_Delete.Text=model.G_Delete.ToString();
		this.txtG_Type.Text=model.G_Type.ToString();
		this.txtG_Code.Text=model.G_Code;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtG_CName.Text.Trim().Length==0)
			{
				strErr+="分类中文说明不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtG_ParentID.Text))
			{
				strErr+="上级分类ID0:为最高级格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtG_ShowOrder.Text))
			{
				strErr+="显示顺序格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtG_Level.Text))
			{
				strErr+="当前分类所在层数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtG_ChildCount.Text))
			{
				strErr+="当???分类子分类数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtG_Delete.Text))
			{
				strErr+="是否删除1:是0:否格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtG_Type.Text))
			{
				strErr+="部门类型格式错误！\\n";	
			}
			if(this.txtG_Code.Text.Trim().Length==0)
			{
				strErr+="行政代码不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int GroupID=int.Parse(this.lblGroupID.Text);
			string G_CName=this.txtG_CName.Text;
			int G_ParentID=int.Parse(this.txtG_ParentID.Text);
			int G_ShowOrder=int.Parse(this.txtG_ShowOrder.Text);
			int G_Level=int.Parse(this.txtG_Level.Text);
			int G_ChildCount=int.Parse(this.txtG_ChildCount.Text);
			int G_Delete=int.Parse(this.txtG_Delete.Text);
			int G_Type=int.Parse(this.txtG_Type.Text);
			string G_Code=this.txtG_Code.Text;


			Maticsoft.Model.sys_Group model=new Maticsoft.Model.sys_Group();
			model.GroupID=GroupID;
			model.G_CName=G_CName;
			model.G_ParentID=G_ParentID;
			model.G_ShowOrder=G_ShowOrder;
			model.G_Level=G_Level;
			model.G_ChildCount=G_ChildCount;
			model.G_Delete=G_Delete;
			model.G_Type=G_Type;
			model.G_Code=G_Code;

			Maticsoft.BLL.sys_Group bll=new Maticsoft.BLL.sys_Group();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
