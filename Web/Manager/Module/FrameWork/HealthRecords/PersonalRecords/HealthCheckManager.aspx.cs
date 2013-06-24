using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthRecords.PersonalRecords
{
    public partial class HealthCheckManager : System.Web.UI.Page
    {
        int HealthID = (int)Common.sink("HealthID", MethodType.Get, 255, 0, DataType.Int);
        int UserID = (int)Common.sink("UserID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "体检记录";
        string All_Title_Txt = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            FrameWorkPermission.CheckPagePermission(CMD);
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
            if(UserID == 0 && HealthID != 0){
                Maticsoft.BLL.record_HealthCheck bll = new Maticsoft.BLL.record_HealthCheck();
                Maticsoft.Model.record_HealthCheck model = bll.GetModel(HealthID);
                UserID = model.H_UserID;
            }
            bi0.ButtonUrl = string.Format("HealthCheckList.aspx?UserID={0}", UserID);
            HeadMenuWebControls1.ButtonList.Add(bi0);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            if (CMD == "New")
            {
                this.H_UserID_Txt.Text = getUserModelById(UserID).U_IDCard;
                this.H_CheckTime.Text = DateTime.Now.ToShortDateString();
            }
            else if (CMD == "Edit")
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "体检记录"; 
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&HealthID={0}')", HealthID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.record_HealthCheck bll = new Maticsoft.BLL.record_HealthCheck();
                Maticsoft.Model.record_HealthCheck model = bll.GetModel(HealthID);
                bll.Delete(model.HealthID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", HealthID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("HealthCheckList.aspx?UserID=" + UserID));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.record_HealthCheck bll = new Maticsoft.BLL.record_HealthCheck();
            Maticsoft.Model.record_HealthCheck model = bll.GetModel(HealthID);

            this.H_BodyTemperature.Text = model.H_BodyTemperature.ToString();
            this.H_PulseRate.Text = model.H_PulseRate.ToString();
            this.H_RespiratoryRate.Text = model.H_RespiratoryRate.ToString();
            this.H_LeftDiastolic.Text = model.H_LeftDiastolic.ToString();
            this.H_LeftSystolic.Text = model.H_LeftSystolic.ToString();
            this.H_RightDiastolic.Text = model.H_RightDiastolic.ToString();
            this.H_RightSystolic.Text = model.H_RightSystolic.ToString();
            this.H_Height.Text = model.H_Height.ToString();
            this.H_Weight.Text = model.H_Weight.ToString();
            this.H_Result.Text = model.H_Result.ToString();
            this.H_Suggestion.Text = model.H_Suggestion.ToString();
            this.H_CheckTime.Text = model.H_CheckTime.ToShortDateString();
            Maticsoft.Model.sys_User user_model = getUserModelById(model.H_UserID);
            this.H_UserID_Txt.Text = user_model.U_IDCard;
        }

        /// <summary>
        /// 通过用户id得到用户信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Maticsoft.Model.sys_User getUserModelById(int userID)
        {
            Maticsoft.BLL.sys_User bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User model = bll.GetModel(userID);
            return model;
        }

        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.record_HealthCheck bll = new Maticsoft.BLL.record_HealthCheck();
            Maticsoft.Model.record_HealthCheck model = bll.GetModel(HealthID);
            if (model == null)
            {
                model = new Maticsoft.Model.record_HealthCheck();
                model.H_UserID = UserID;
            }

            model.H_BodyTemperature = Convert.ToDecimal(Common.sink(this.H_BodyTemperature.UniqueID, MethodType.Post, 0, 0, DataType.Double));
            model.H_PulseRate = (int)Common.sink(this.H_PulseRate.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_RespiratoryRate = (int)Common.sink(this.H_RespiratoryRate.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_LeftDiastolic = (int)Common.sink(this.H_LeftDiastolic.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_LeftSystolic = (int)Common.sink(this.H_LeftSystolic.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_RightDiastolic = (int)Common.sink(this.H_RightDiastolic.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_RightSystolic = (int)Common.sink(this.H_RightSystolic.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_Weight = (int)Common.sink(this.H_Weight.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_Height =(int) Common.sink(this.H_Height.UniqueID, MethodType.Post, 0, 0, DataType.Int);
            model.H_Result = (string)Common.sink(this.H_Result.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            model.H_Suggestion = (string)Common.sink(this.H_Suggestion.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            model.H_CheckTime = (DateTime)Common.sink(this.H_CheckTime.UniqueID, MethodType.Post, 0, 0, DataType.Dat);
            model.H_CheckUserID = UserData.GetUserDate.UserID;

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    model.HealthID = bll.Add(model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    bll.Update(model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", model.HealthID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("HealthCheckList.aspx?UserID=" + model.H_UserID));
        }
    }
}