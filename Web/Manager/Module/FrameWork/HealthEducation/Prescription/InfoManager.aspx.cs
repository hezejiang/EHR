using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.Web.Manager.Module.FrameWork.HealthEducation.Prescription
{
 public partial class InfoManager : System.Web.UI.Page
    {
        int PrescriptionID = (int)Common.sink("PrescriptionID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "健康教育处方";
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
                bi2.ButtonName = "健康教育处方"; 
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&PrescriptionID={0}')", PrescriptionID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.education_Prescription bll = new Maticsoft.BLL.education_Prescription();
                Maticsoft.Model.education_Prescription model = bll.GetModel(PrescriptionID);
                bll.Delete(model.PrescriptionID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", PrescriptionID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.education_Prescription bll = new Maticsoft.BLL.education_Prescription();
            Maticsoft.Model.education_Prescription model = bll.GetModel(PrescriptionID);

            P_Date.Text = model.P_Date.ToShortDateString();
            P_Content.Text = model.P_Content;
            P_Name.Text = model.P_Name;

            Maticsoft.BLL.sys_User user_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User user_model1 = user_bll.GetModel(model.P_Object);
            P_Object.Value = user_model1.UserID + "";
            P_Object_input.Text = user_model1.U_CName;
            
            Maticsoft.Model.sys_User user_model2 = user_bll.GetModel(model.P_Doctor);
            P_Doctor.Value = user_model2.UserID + "";
            P_Doctor_input.Text = user_model2.U_CName;
        }

        /// <summary>
        /// 根据信息类型返回对应的信息名称
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>

        
        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.education_Prescription education_Prescription_bll = new Maticsoft.BLL.education_Prescription();
            Maticsoft.Model.education_Prescription education_Prescription_model = education_Prescription_bll.GetModel(PrescriptionID);
            if (education_Prescription_model == null)
            {
                education_Prescription_model = new Maticsoft.Model.education_Prescription();
            }

            //获取客户端通过Post方式传递过来的值的
            education_Prescription_model.P_Date = (DateTime)Common.sink(this.P_Date.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            education_Prescription_model.P_Content = (string)Common.sink(this.P_Content.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            education_Prescription_model.P_Object = Convert.ToInt32(this.P_Object.Value);
            education_Prescription_model.P_Doctor = Convert.ToInt32(this.P_Doctor.Value);
            education_Prescription_model.P_Name = P_Name.Text;

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //增加操作调用Add方法
                    PrescriptionID = education_Prescription_bll.Add(education_Prescription_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //是修改操作调用Update方法
                    education_Prescription_bll.Update(education_Prescription_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", PrescriptionID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }}
    }
