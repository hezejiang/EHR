using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthRecords.FollowUp
{
    public partial class InfoManager : System.Web.UI.Page
    {
        int FollowUpID = (int)Common.sink("FollowUpID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "特定随访工作计划";
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
                bi2.ButtonName = "计划";
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&ActivityID={0}')", FollowUpID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.record_FollowUp bll = new Maticsoft.BLL.record_FollowUp();
                Maticsoft.Model.record_FollowUp model = bll.GetModel(FollowUpID);
                bll.Delete(model.FollowUpID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", FollowUpID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.record_FollowUp record_FollowUp_bll = new Maticsoft.BLL.record_FollowUp();
            Maticsoft.Model.record_FollowUp record_FollowUp_model = record_FollowUp_bll.GetModel(FollowUpID);
            if (record_FollowUp_model != null)
            {
                F_PatientID.Value = record_FollowUp_model.F_PatientID +"";
                Maticsoft.BLL.sys_User sys_User_bll = new Maticsoft.BLL.sys_User();
                F_PatientID_input.Text = sys_User_bll.GetModel(record_FollowUp_model.F_PatientID).U_CName;
                F_Type.SelectedValue = record_FollowUp_model.F_Type + "";
                F_Date.Text = record_FollowUp_model.F_Date.ToShortDateString();
                F_Status.SelectedValue = record_FollowUp_model.F_Status + "";
            }
        }

        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.record_FollowUp record_FollowUp_bll = new Maticsoft.BLL.record_FollowUp();
            Maticsoft.Model.record_FollowUp record_FollowUp_model = record_FollowUp_bll.GetModel(FollowUpID);
            if (record_FollowUp_model == null)
            {
                record_FollowUp_model = new Maticsoft.Model.record_FollowUp();
            }

            record_FollowUp_model.F_PatientID = (int)Common.sink(this.F_PatientID.UniqueID, MethodType.Post, 255, 0, DataType.Int);
            record_FollowUp_model.F_Type = Convert.ToInt32(F_Type.SelectedValue);
            record_FollowUp_model.F_Date = (DateTime)Common.sink(this.F_Date.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            record_FollowUp_model.F_Status = Convert.ToInt32(F_Status.SelectedValue);

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    record_FollowUp_model.FollowUpID = record_FollowUp_bll.Add(record_FollowUp_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    record_FollowUp_bll.Update(record_FollowUp_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            //以下方法的第4个参数需要更改
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", record_FollowUp_model.FollowUpID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}