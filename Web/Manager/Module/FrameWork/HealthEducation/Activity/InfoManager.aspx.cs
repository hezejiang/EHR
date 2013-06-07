using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthEducation.Activity
{
    public partial class InfoManager : System.Web.UI.Page
    {
        int ActivityID = (int)Common.sink("ActivityID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "健康教育活动"; 
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
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&ActivityID={0}')", ActivityID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.education_Activity bll = new Maticsoft.BLL.education_Activity();
                Maticsoft.Model.education_Activity model = bll.GetModel(ActivityID);
                bll.Delete(model.ActivityID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", ActivityID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.education_Activity education_Activity_bll = new Maticsoft.BLL.education_Activity();
            Maticsoft.Model.education_Activity education_Activity_model = education_Activity_bll.GetModel(ActivityID);
            if (education_Activity_model != null)
            {
                A_DateTime.Text = education_Activity_model.A_DateTime.ToShortDateString();
                A_Location.Text = education_Activity_model.A_Location;
                Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
                Maticsoft.Model.sys_Group sys_Group_model = sys_Group_bll.GetModel(education_Activity_model.A_Object);
                A_Object.Value = education_Activity_model.A_Object + "";
                A_Object_input.Text = sys_Group_model.G_CName;
                A_Crowd.Text = education_Activity_model.A_Crowd;
                A_Form.Text = education_Activity_model.A_Form;
                A_Duration.Text = education_Activity_model.A_Duration + "";
                A_Organizers.Text = education_Activity_model.A_Organizers;
                A_Partners.Text = education_Activity_model.A_Partners;
                A_Missionary.Text = education_Activity_model.A_Missionary;
                A_Number.Text = education_Activity_model.A_Number + "";
                A_Theme.Text = education_Activity_model.A_Theme;
            }
        }

        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.education_Activity education_Activity_bll = new Maticsoft.BLL.education_Activity();
            Maticsoft.Model.education_Activity education_Activity_model = education_Activity_bll.GetModel(ActivityID);
            if (education_Activity_model == null)
            {
                education_Activity_model = new Maticsoft.Model.education_Activity();
            }

            education_Activity_model.A_DateTime = (DateTime)Common.sink(this.A_DateTime.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            education_Activity_model.A_Location = A_Location.Text;
            education_Activity_model.A_Object = (int)Common.sink(this.A_Object.UniqueID, MethodType.Post, 255, 0, DataType.Int);
            education_Activity_model.A_Crowd = A_Crowd.Text;
            education_Activity_model.A_Form = A_Form.Text;
            education_Activity_model.A_Duration = (int)Common.sink(this.A_Duration.UniqueID, MethodType.Post, 255, 0, DataType.Int);
            education_Activity_model.A_Organizers = A_Organizers.Text;
            education_Activity_model.A_Partners = A_Partners.Text;
            education_Activity_model.A_Missionary = A_Missionary.Text;
            education_Activity_model.A_Number = (int)Common.sink(this.A_Number.UniqueID, MethodType.Post, 255, 0, DataType.Int);
            education_Activity_model.A_Theme = A_Theme.Text;

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    education_Activity_model.ActivityID = education_Activity_bll.Add(education_Activity_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    education_Activity_bll.Update(education_Activity_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            //以下方法的第4个参数需要更改
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", education_Activity_model.ActivityID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}