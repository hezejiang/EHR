using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthRecords.FamilyRecords
{
    public partial class InfoManager : System.Web.UI.Page
    {
        //获取通过Get方式传递过来的键对应的值，可复制后改成你所负责模块的"*ID"
        int FamilyID = (int)Common.sink("FamilyID", MethodType.Get, 255, 0, DataType.Int);
        //CMD一般有如下几个值：List,New,Edit,Delete,Order；这里直接复制，不需更改
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "家庭健康档案"; 
        string All_Title_Txt = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //检查权限，直接复制即可
            FrameWorkPermission.CheckPagePermission(CMD);
            //绑定返回按钮，直接复制即可
            BindButton();
            if (!Page.IsPostBack)
            {
                OnStart();
            }
        }

        /// <summary>
        /// 绑定返回按钮(直接复制)
        /// </summary>
        private void BindButton()
        {
            HeadMenuButtonItem bi0 = new HeadMenuButtonItem();
            bi0.ButtonIcon = "back.gif";
            bi0.ButtonName = "返回";
            bi0.ButtonPopedom = PopedomType.List;
            bi0.ButtonUrl = string.Format("default.aspx");
            HeadMenuWebControls1.ButtonList.Add(bi0);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            if (CMD == "New")
            {
            }
            else if (CMD == "Edit")
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "家庭健康档案";  //需要改
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&FamilyID={0}')", FamilyID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                //这是操作数据库的核心代码，工作原理是：首先要明确现在所操作的模块对应着数据库中的哪张表，然后创建这个表所对应的的逻辑处理层(bll)对象，如这里操作的表是record_FamilyBaseInfo，则要新建所对应的Maticsoft.BLL.record_FamilyBaseInfo对象
                Maticsoft.BLL.record_FamilyBaseInfo bll = new Maticsoft.BLL.record_FamilyBaseInfo();
                //这是数据库实体类对象（简单来说就对应着这个表的一条记录），因为这里操作的表是record_FamilyBaseInfo，则对应的model是Maticsoft.Model.record_FamilyBaseInfo，然后通过上一行new的bll对象去执行数据库操作（这里使用的方法是GetModel，当然还有其他的方法，根据需要使用不同的方法），返回对应实体类对象
                Maticsoft.Model.record_FamilyBaseInfo model = bll.GetModel(FamilyID);
                //bll执行删除操作，参数是这个实体类的ID值
                bll.Delete(model.FamilyID);
                Maticsoft.BLL.record_FamilyProblem record_FamilyProblem_bll = new Maticsoft.BLL.record_FamilyProblem();
                record_FamilyProblem_bll.Delete(model.FamilyID);
                //以下方法的第4、5个参数需要更改
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", FamilyID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.record_FamilyBaseInfo bll = new Maticsoft.BLL.record_FamilyBaseInfo();
            Maticsoft.Model.record_FamilyBaseInfo model = bll.GetModel(FamilyID);
            F_FamilyTel.Text = model.F_FamilyTel.ToString();
            F_HouseType.SelectedValue = model.F_HouseType + "";
            F_FamilyAddress.Text = model.F_FamilyAddress;
            F_FamilyCode.Text = model.F_FamilyCode;
            F_HouseArea.Text = model.F_HouseArea.ToString();
            F_Ventilation.SelectedValue = model.F_Ventilation + "";
            F_Humidity.SelectedValue = model.F_Humidity + "";
            F_Warm.SelectedValue = model.F_Warm + "";
            F_Lighting.SelectedValue = model.F_Lighting + "";
            F_Sanitation.SelectedValue = model.F_Sanitation + "";
            F_Kitchen.SelectedValue = model.F_Kitchen + "";
            F_Fuel.SelectedValue = model.F_Fuel + "";
            F_Water.SelectedValue = model.F_Water + "";
            F_WasteDisposal.SelectedValue = model.F_WasteDisposal + "";
            F_LivestockBar.SelectedValue = model.F_LivestockBar + "";
            F_ToiletType.SelectedValue = model.F_ToiletType + "";
            Maticsoft.BLL.sys_User user_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User user_model = user_bll.GetModel(model.F_UserID);
            F_UserID.Value = user_model.UserID + "";
            F_UserID_input.Value = user_model.U_CName;
            Maticsoft.Model.sys_User user_model1 = user_bll.GetModel(model.F_ResponsibilityUserID);
            F_ResponsibilityUserID.Value = user_model1.UserID + "";
            F_ResponsibilityUserID_input.Value = user_model1.U_CName;
            Maticsoft.Model.sys_User user_model2 = user_bll.GetModel(model.F_FillingUserID);
            F_FillingUserID.Value = user_model2.UserID + "";
            F_FillingUserID_input.Value = user_model2.U_CName;
            Maticsoft.BLL.record_FamilyProblem record_FamilyProblem_bll = new Maticsoft.BLL.record_FamilyProblem();
            Maticsoft.Model.record_FamilyProblem record_FamilyProblem_model = record_FamilyProblem_bll.GetModel(model.FamilyID);
            if (record_FamilyProblem_model != null)
            {
                F_RecordTime.Text = record_FamilyProblem_model.F_RecordTime.ToString();
                F_StartTime.Text = record_FamilyProblem_model.F_StartTime.ToString();
                F_endTime.Text = record_FamilyProblem_model.F_endTime.ToString();
                F_OverviewProblem.Text = record_FamilyProblem_model.F_OverviewProblem.ToString();
                F_DetailProblem.Text = record_FamilyProblem_model.F_DetailProblem.ToString();
                Maticsoft.BLL.sys_User fillinguser_bll = new Maticsoft.BLL.sys_User();
                Maticsoft.Model.sys_User fillinguser_model = fillinguser_bll.GetModel(model.F_FillingUserID);
                F_FillingUserID.Value = user_model.UserID + "";
                F_FillingUserID_input.Value = user_model.U_CName;
            }
        }
        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.record_FamilyBaseInfo record_FamilyBaseInfo_bll = new Maticsoft.BLL.record_FamilyBaseInfo();
            Maticsoft.Model.record_FamilyBaseInfo record_FamilyBaseInfo_model = record_FamilyBaseInfo_bll.GetModel(FamilyID);
           
            if (record_FamilyBaseInfo_model == null)
            {
                record_FamilyBaseInfo_model = new Maticsoft.Model.record_FamilyBaseInfo();
            }

            //获取客户端通过Post方式传递过来的值的（需要更改）
            record_FamilyBaseInfo_model.F_FamilyTel = (string)Common.sink(this.F_FamilyTel.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            record_FamilyBaseInfo_model.F_FamilyAddress = (string)Common.sink(this.F_FamilyAddress.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            record_FamilyBaseInfo_model.F_HouseArea = Convert.ToInt32(Common.sink(this.F_HouseArea.UniqueID, MethodType.Post, 255, 0, DataType.Int));
            record_FamilyBaseInfo_model.F_HouseType = Convert.ToInt32(this.F_HouseType.SelectedValue);
            record_FamilyBaseInfo_model.F_Ventilation = Convert.ToInt32(this.F_Ventilation.SelectedValue);
            record_FamilyBaseInfo_model.F_Humidity = Convert.ToInt32(this.F_Humidity.SelectedValue);
            record_FamilyBaseInfo_model.F_Warm = Convert.ToInt32(this.F_Warm.SelectedValue);
            record_FamilyBaseInfo_model.F_Lighting = Convert.ToInt32(this.F_Lighting.SelectedValue);
            record_FamilyBaseInfo_model.F_Sanitation = Convert.ToInt32(this.F_Sanitation.SelectedValue);
            record_FamilyBaseInfo_model.F_Kitchen = Convert.ToInt32(this.F_Kitchen.SelectedValue);
            record_FamilyBaseInfo_model.F_Fuel = Convert.ToInt32(this.F_Fuel.SelectedValue);
            record_FamilyBaseInfo_model.F_Water = Convert.ToInt32(this.F_Water.SelectedValue);
            record_FamilyBaseInfo_model.F_WasteDisposal = Convert.ToInt32(this.F_WasteDisposal.SelectedValue);
            record_FamilyBaseInfo_model.F_LivestockBar = Convert.ToInt32(this.F_LivestockBar.SelectedValue);
            record_FamilyBaseInfo_model.F_ToiletType = Convert.ToInt32(this.F_ToiletType.SelectedValue);
            record_FamilyBaseInfo_model.F_ResponsibilityUserID = Convert.ToInt32(this.F_ResponsibilityUserID.Value);
            record_FamilyBaseInfo_model.F_FillingUserID = Convert.ToInt32(this.F_FillingUserID.Value);
            record_FamilyBaseInfo_model.F_UserID = Convert.ToInt32(this.F_UserID.Value);
            
            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    record_FamilyBaseInfo_model.FamilyID = record_FamilyBaseInfo_bll.Add(record_FamilyBaseInfo_model);
                    Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
                    Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(record_FamilyBaseInfo_model.F_UserID);
                    Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
                    Maticsoft.Model.sys_Group sys_Group_model = sys_Group_bll.GetModel(record_UserBaseInfo_model.U_Committee);
                    string familyCode = sys_Group_model.G_Code + record_FamilyBaseInfo_model.FamilyID + "";
                    record_FamilyBaseInfo_model.F_FamilyCode = familyCode;
                    record_FamilyBaseInfo_bll.Update(record_FamilyBaseInfo_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    record_FamilyBaseInfo_bll.Update(record_FamilyBaseInfo_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            //以下方法的第4个参数需要更改
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", record_FamilyBaseInfo_model.FamilyID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.record_FamilyProblem record_FamilyProblem_bll = new Maticsoft.BLL.record_FamilyProblem();
            Maticsoft.Model.record_FamilyProblem record_FamilyProblem_model = record_FamilyProblem_bll.GetModel(FamilyID);
            if (record_FamilyProblem_model == null)
            {
                record_FamilyProblem_model = new Maticsoft.Model.record_FamilyProblem();
            }
            record_FamilyProblem_model.F_RecordTime = (DateTime)Common.sink(this.F_RecordTime.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            record_FamilyProblem_model.F_StartTime = (DateTime)Common.sink(this.F_StartTime.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            record_FamilyProblem_model.F_endTime = (DateTime)Common.sink(this.F_endTime.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            record_FamilyProblem_model.F_OverviewProblem = (string)Common.sink(this.F_OverviewProblem.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            record_FamilyProblem_model.F_DetailProblem = (string)Common.sink(this.F_DetailProblem.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            record_FamilyProblem_model.F_FillingUserID = Convert.ToInt32(this.F_FillingUserID.Value);
            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    record_FamilyProblem_bll.Add(record_FamilyProblem_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    record_FamilyProblem_bll.Update(record_FamilyProblem_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            //以下方法的第4个参数需要更改
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", record_FamilyProblem_model.F_FamilyID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}