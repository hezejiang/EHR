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
namespace Maticsoft.Web.record_FamilyBaseInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtF_FimaryCode.Text.Trim().Length==0)
			{
				strErr+="家庭档案编号不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_UserID.Text))
			{
				strErr+="户主格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_GroupID.Text))
			{
				strErr+="村(居)委会ID格式错误！\\n";	
			}
			if(this.txtF_FimaryTel.Text.Trim().Length==0)
			{
				strErr+="F_FimaryTel不能为空！\\n";	
			}
			if(this.txtF_FimrayAddress.Text.Trim().Length==0)
			{
				strErr+="家庭地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_HouseType.Text))
			{
				strErr+="房屋类型 1:砖瓦平房格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtF_HouseArea.Text))
			{
				strErr+="居住面积格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Ventilation.Text))
			{
				strErr+="通风 1:好格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Humidity.Text))
			{
				strErr+="湿度 1:潮湿格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Warm.Text))
			{
				strErr+="保暖 1:好格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Lighting.Text))
			{
				strErr+="采光 1:好格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Sanitation.Text))
			{
				strErr+="卫生 1:清洁格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Kitchen.Text))
			{
				strErr+="厨房 1:合用格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Fuel.Text))
			{
				strErr+="使用燃料 1：液化气格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_Water.Text))
			{
				strErr+="饮水来源 1：自来水格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_WasteDisposal.Text))
			{
				strErr+="垃圾处理 1：垃圾处理格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_LivestockBar.Text))
			{
				strErr+="禽畜栏 1：单设格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_ToiletType.Text))
			{
				strErr+="厕所类型 1：家庭卫生厕所：三格式粪池式格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_ResponsibilityUserID.Text))
			{
				strErr+="责任人格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtF_FillingUserID.Text))
			{
				strErr+="建档人格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string F_FimaryCode=this.txtF_FimaryCode.Text;
			int F_UserID=int.Parse(this.txtF_UserID.Text);
			int F_GroupID=int.Parse(this.txtF_GroupID.Text);
			string F_FimaryTel=this.txtF_FimaryTel.Text;
			string F_FimrayAddress=this.txtF_FimrayAddress.Text;
			int F_HouseType=int.Parse(this.txtF_HouseType.Text);
			decimal F_HouseArea=decimal.Parse(this.txtF_HouseArea.Text);
			int F_Ventilation=int.Parse(this.txtF_Ventilation.Text);
			int F_Humidity=int.Parse(this.txtF_Humidity.Text);
			int F_Warm=int.Parse(this.txtF_Warm.Text);
			int F_Lighting=int.Parse(this.txtF_Lighting.Text);
			int F_Sanitation=int.Parse(this.txtF_Sanitation.Text);
			int F_Kitchen=int.Parse(this.txtF_Kitchen.Text);
			int F_Fuel=int.Parse(this.txtF_Fuel.Text);
			int F_Water=int.Parse(this.txtF_Water.Text);
			int F_WasteDisposal=int.Parse(this.txtF_WasteDisposal.Text);
			int F_LivestockBar=int.Parse(this.txtF_LivestockBar.Text);
			int F_ToiletType=int.Parse(this.txtF_ToiletType.Text);
			int F_ResponsibilityUserID=int.Parse(this.txtF_ResponsibilityUserID.Text);
			int F_FillingUserID=int.Parse(this.txtF_FillingUserID.Text);

			Maticsoft.Model.record_FamilyBaseInfo model=new Maticsoft.Model.record_FamilyBaseInfo();
			model.F_FimaryCode=F_FimaryCode;
			model.F_UserID=F_UserID;
			model.F_GroupID=F_GroupID;
			model.F_FimaryTel=F_FimaryTel;
			model.F_FimrayAddress=F_FimrayAddress;
			model.F_HouseType=F_HouseType;
			model.F_HouseArea=F_HouseArea;
			model.F_Ventilation=F_Ventilation;
			model.F_Humidity=F_Humidity;
			model.F_Warm=F_Warm;
			model.F_Lighting=F_Lighting;
			model.F_Sanitation=F_Sanitation;
			model.F_Kitchen=F_Kitchen;
			model.F_Fuel=F_Fuel;
			model.F_Water=F_Water;
			model.F_WasteDisposal=F_WasteDisposal;
			model.F_LivestockBar=F_LivestockBar;
			model.F_ToiletType=F_ToiletType;
			model.F_ResponsibilityUserID=F_ResponsibilityUserID;
			model.F_FillingUserID=F_FillingUserID;

			Maticsoft.BLL.record_FamilyBaseInfo bll=new Maticsoft.BLL.record_FamilyBaseInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
