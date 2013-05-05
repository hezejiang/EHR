﻿using System;
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
namespace Maticsoft.Web.sys_FieldValue
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ValueID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ValueID);
				}
			}
		}
			
	private void ShowInfo(int ValueID)
	{
		Maticsoft.BLL.sys_FieldValue bll=new Maticsoft.BLL.sys_FieldValue();
		Maticsoft.Model.sys_FieldValue model=bll.GetModel(ValueID);
		this.lblValueID.Text=model.ValueID.ToString();
		this.txtV_F_Key.Text=model.V_F_Key;
		this.txtV_Text.Text=model.V_Text;
		this.txtV_Code.Text=model.V_Code;
		this.txtV_ShowOrder.Text=model.V_ShowOrder.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtV_F_Key.Text.Trim().Length==0)
			{
				strErr+="与sys_Field表中F_K不能为空！\\n";	
			}
			if(this.txtV_Text.Text.Trim().Length==0)
			{
				strErr+="中文说明不能为空！\\n";	
			}
			if(this.txtV_Code.Text.Trim().Length==0)
			{
				strErr+="编码不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtV_ShowOrder.Text))
			{
				strErr+="同级显示顺序格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ValueID=int.Parse(this.lblValueID.Text);
			string V_F_Key=this.txtV_F_Key.Text;
			string V_Text=this.txtV_Text.Text;
			string V_Code=this.txtV_Code.Text;
			int V_ShowOrder=int.Parse(this.txtV_ShowOrder.Text);


			Maticsoft.Model.sys_FieldValue model=new Maticsoft.Model.sys_FieldValue();
			model.ValueID=ValueID;
			model.V_F_Key=V_F_Key;
			model.V_Text=V_Text;
			model.V_Code=V_Code;
			model.V_ShowOrder=V_ShowOrder;

			Maticsoft.BLL.sys_FieldValue bll=new Maticsoft.BLL.sys_FieldValue();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
