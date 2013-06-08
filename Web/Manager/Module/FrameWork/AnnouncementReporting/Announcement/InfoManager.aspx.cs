using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.AnnouncementReporting.Announcement
{
    public partial class InfoManager : System.Web.UI.Page
    {
        int AnnouncementID = (int)Common.sink("AnnouncementID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "公告"; 
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
                bi2.ButtonName = "活动"; 
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&AnnouncementID={0}')", AnnouncementID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.AR_Announcement bll = new Maticsoft.BLL.AR_Announcement();
                Maticsoft.Model.AR_Announcement model = bll.GetModel(AnnouncementID);
                bll.Delete(model.AnnouncementID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", AnnouncementID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.AR_Announcement AR_Announcement_bll = new Maticsoft.BLL.AR_Announcement();
            Maticsoft.Model.AR_Announcement AR_Announcement_model = AR_Announcement_bll.GetModel(AnnouncementID);
            if (AR_Announcement_model != null)
            {
                A_Type.SelectedValue = AR_Announcement_model.A_Type + "";
                A_Title.Text = AR_Announcement_model.A_Title;
                A_Content.Text = AR_Announcement_model.A_Content;
            }
        }

        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.AR_Announcement AR_Announcement_bll = new Maticsoft.BLL.AR_Announcement();
            Maticsoft.Model.AR_Announcement AR_Announcement_model = AR_Announcement_bll.GetModel(AnnouncementID);
            if (AR_Announcement_model == null)
            {
                AR_Announcement_model = new Maticsoft.Model.AR_Announcement();
            }

            AR_Announcement_model.A_Type = Convert.ToInt32(A_Type.SelectedValue);
            AR_Announcement_model.A_Title = A_Title.Text;
            AR_Announcement_model.A_Content = A_Content.Text;
            AR_Announcement_model.A_DateTime = DateTime.Now;
            AR_Announcement_model.A_ResponsibilityUserID = UserData.GetUserDate.UserID;  //获取当前用户ID

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    AR_Announcement_model.AnnouncementID = AR_Announcement_bll.Add(AR_Announcement_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    AR_Announcement_bll.Update(AR_Announcement_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            //以下方法的第4个参数需要更改
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", AR_Announcement_model.AnnouncementID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}