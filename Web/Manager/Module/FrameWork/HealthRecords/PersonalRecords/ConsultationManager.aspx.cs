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
    public partial class ConsultationManager : System.Web.UI.Page
    {
        int ConsultationID = (int)Common.sink("ConsultationID", MethodType.Get, 255, 0, DataType.Int);
        int UserID = (int)Common.sink("UserID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "会诊记录";
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
            if(UserID == 0 && ConsultationID != 0){
                Maticsoft.BLL.record_Consultation bll = new Maticsoft.BLL.record_Consultation();
                Maticsoft.Model.record_Consultation model = bll.GetModel(ConsultationID);
                UserID = model.C_UserID;
            }
            bi0.ButtonUrl = string.Format("ConsultationList.aspx?UserID={0}", UserID);
            HeadMenuWebControls1.ButtonList.Add(bi0);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            if (CMD == "New")
            {
                this.C_UserID_Txt.Text = getUserModelById(UserID).U_IDCard;
                this.C_Time.Text = DateTime.Now.ToShortDateString();
            }
            else if (CMD == "Edit")
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "会诊记录"; 
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&ConsultationID={0}')", ConsultationID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.record_Consultation bll = new Maticsoft.BLL.record_Consultation();
                Maticsoft.Model.record_Consultation model = bll.GetModel(ConsultationID);
                bll.Delete(model.ConsultationID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", ConsultationID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("ConsultationList.aspx?UserID=" + UserID));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.record_Consultation bll = new Maticsoft.BLL.record_Consultation();
            Maticsoft.Model.record_Consultation model = bll.GetModel(ConsultationID);

            this.C_Cause.Text = model.C_Cause;
            this.C_Comments.Text = model.C_Comments;
            this.C_Time.Text = model.C_Time.ToShortDateString();
            Maticsoft.Model.sys_User user_model = getUserModelById(model.C_UserID);
            this.C_UserID_Txt.Text = user_model.U_IDCard;
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
            Maticsoft.BLL.record_Consultation bll = new Maticsoft.BLL.record_Consultation();
            Maticsoft.Model.record_Consultation model = bll.GetModel(ConsultationID);
            if (model == null)
            {
                model = new Maticsoft.Model.record_Consultation();
                model.C_UserID = UserID;
            }
            
            model.C_Cause = (string)Common.sink(this.C_Cause.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            model.C_Comments = (string)Common.sink(this.C_Comments.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            model.C_Time = (DateTime)Common.sink(this.C_Time.UniqueID, MethodType.Post, 0, 0, DataType.Dat);
            model.C_Dortor = UserData.GetUserDate.UserID; //当前登录的医生id
            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    model.C_UserID = bll.Add(model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    bll.Update(model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", ConsultationID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("ConsultationList.aspx?UserID=" + model.C_UserID));
        }
    }
}