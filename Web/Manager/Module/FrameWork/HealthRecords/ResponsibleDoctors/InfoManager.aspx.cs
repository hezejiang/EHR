using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FrameWork.Components;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;
using Maticsoft.Common;

namespace FrameWork.web.Module.FrameWork.HealthRecords.ResponsibleDoctors
{
    public partial class InfoManager : System.Web.UI.Page
    {
        public int UserID = (int)Common.sink("UserID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "更改";
        string App_Txt = "责任医生";
        string All_Title_Txt = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            FrameWorkPermission.CheckPagePermission(CMD);

            if (!Page.IsPostBack)
            {
                OnStart();
            }
        }

        /// <summary>
        /// 绑定其他按钮
        /// </summary>
        private void BindButton()
        {
            HeadMenuButtonItem bi1 = new HeadMenuButtonItem();
            bi1.ButtonIcon = "back.gif";
            bi1.ButtonName = "返回";
            bi1.ButtonPopedom = PopedomType.List;
            bi1.ButtonUrl = string.Format("default.aspx");
            HeadMenuWebControls1.ButtonList.Add(bi1);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            if (CMD == "Edit")
            {
                BindButton();

                Maticsoft.BLL.sys_User sys_User_bll = new Maticsoft.BLL.sys_User();
                Maticsoft.Model.sys_User sys_User_model = sys_User_bll.GetModel(UserID);
                Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
                Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(UserID);
                U_IDCard.Text = sys_User_model.U_IDCard;
                U_CName.Text = sys_User_model.U_CName;
                U_ResponsibilityUserID.Text = sys_User_bll.GetModel(record_UserBaseInfo_model.U_ResponsibilityUserID).U_CName;
            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
            Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(UserID);
            record_UserBaseInfo_model.U_ResponsibilityUserID = Convert.ToInt32(U_ResponsibilityUserID_New.Value);
            record_UserBaseInfo_bll.Update(record_UserBaseInfo_model);
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", UserID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}
