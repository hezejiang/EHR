using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthRecords.DeathRegistration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int DeathID = (int)Common.sink("DeathID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "死亡信息"; 
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
                bi2.ButtonName = "死亡信息"; 
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&DeathID={0}')", DeathID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.record_DeathRegistration bll = new Maticsoft.BLL.record_DeathRegistration();
                Maticsoft.Model.record_DeathRegistration model = bll.GetModel(DeathID);
                bll.Delete(model.DeathID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", DeathID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.record_DeathRegistration bll = new Maticsoft.BLL.record_DeathRegistration();
            Maticsoft.Model.record_DeathRegistration model = bll.GetModel(DeathID);

            D_DateTime.Text = model.D_DateTime.ToShortDateString();
            D_Reason.Text = model.D_Reason;
            D_Location.Text = model.D_Location;
            D_RegDate.Text = model.D_RegDate.ToShortDateString();
            Maticsoft.BLL.sys_User user_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User user_model = user_bll.GetModel(model.D_UserID);
            D_UserID.Value = user_model.UserID + "";
            D_UserID_input.Value = user_model.U_CName;
            user_model = user_bll.GetModel(model.D_RegUserID);
            D_RegUserID.Value = user_model.UserID + "";
            D_RegUserID_input.Value = user_model.U_CName;
        }

       
        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.record_DeathRegistration supervision_bll = new Maticsoft.BLL.record_DeathRegistration();
            Maticsoft.Model.record_DeathRegistration record_DeathRegistration_model = supervision_bll.GetModel(DeathID);
            if (record_DeathRegistration_model == null)
            {
                record_DeathRegistration_model = new Maticsoft.Model.record_DeathRegistration();
            }

            //获取客户端通过Post方式传递过来的值的
            record_DeathRegistration_model.D_DateTime = (DateTime)Common.sink(this.D_DateTime.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            record_DeathRegistration_model.D_Reason = (string)Common.sink(this.D_Reason.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_DeathRegistration_model.D_Location = (string)Common.sink(this.D_Location.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_DeathRegistration_model.D_RegDate = (DateTime)Common.sink(this.D_RegDate.UniqueID, MethodType.Post, 0, 0, DataType.Dat);
            record_DeathRegistration_model.D_UserID = Convert.ToInt32(this.D_UserID.Value);
            record_DeathRegistration_model.D_RegUserID = Convert.ToInt32(this.D_RegUserID.Value);

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //增加操作调用Add方法
                    record_DeathRegistration_model.DeathID = supervision_bll.Add(record_DeathRegistration_model);
                    if(record_DeathRegistration_model.DeathID > 0)
                    {
                        Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
                        Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(record_DeathRegistration_model.D_UserID);
                        record_UserBaseInfo_model.U_AuditStatus = 3;
                        record_UserBaseInfo_bll.Update(record_UserBaseInfo_model);
                    }
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //修改操作调用Update方法
                    supervision_bll.Update(record_DeathRegistration_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", record_DeathRegistration_model.DeathID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}