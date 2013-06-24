using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.AnnouncementReporting.Reporting.Emergencies
{
    public partial class InfoManager : System.Web.UI.Page
    {
        int ReportID = (int)Common.sink("ReportID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "报告";
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
                Button1.Visible = true;
                Button2.Visible = false;
            }
            else if (CMD == "Edit")
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "活动";
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&ReportID={0}')", ReportID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.AR_Report bll = new Maticsoft.BLL.AR_Report();
                Maticsoft.Model.AR_Report model = bll.GetModel(ReportID);
                bll.Delete(model.ReportID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", ReportID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.AR_Report AR_Report_bll = new Maticsoft.BLL.AR_Report();
            Maticsoft.Model.AR_Report AR_Report_model = AR_Report_bll.GetModel(ReportID);
            if (AR_Report_model != null)
            {
                R_Title.Text = AR_Report_model.R_Title;
                R_Content.Text = AR_Report_model.R_Content;
            }
            if (UserData.GetUserDate.UserID != AR_Report_model.ReportID)
            {
                Button1.Visible = false;
                Button2.Visible = true;
            }
            else
            {
                Button1.Visible = true;
                Button2.Visible = false;
            }
        }

        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.AR_Report AR_Report_bll = new Maticsoft.BLL.AR_Report();
            Maticsoft.Model.AR_Report AR_Report_model = AR_Report_bll.GetModel(ReportID);
            if (AR_Report_model == null)
            {
                AR_Report_model = new Maticsoft.Model.AR_Report();
            }

            AR_Report_model.R_Type = 2;
            AR_Report_model.R_Title = R_Title.Text;
            AR_Report_model.R_Content = R_Content.Text;
            AR_Report_model.R_DateTime = DateTime.Now;
            AR_Report_model.R_ResponsibilityUserID = UserData.GetUserDate.UserID;  //获取当前用户ID
            AR_Report_model.R_GroupID = UserData.GetUserDate.U_GroupID;
            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    AR_Report_model.ReportID = AR_Report_bll.Add(AR_Report_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    AR_Report_bll.Update(AR_Report_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", AR_Report_model.ReportID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.AR_Report AR_Report_bll = new Maticsoft.BLL.AR_Report();
            Maticsoft.Model.AR_Report AR_Report_model = AR_Report_bll.GetModel(ReportID);
            AR_Report_model.R_ResponsibilityUserID = UserData.GetUserDate.UserID; //更改责任人
            AR_Report_model.R_GroupID = UserData.GetUserDate.U_GroupID; //更改报告部门
            CMD_Txt = "增加";
            AR_Report_model.ReportID = AR_Report_bll.Add(AR_Report_model);
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", AR_Report_model.ReportID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}