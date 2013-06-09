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
        //获取通过Get方式传递过来的键对应的值，可复制后改成你所负责模块的"*ID"
        int PrescriptionID = (int)Common.sink("PrescriptionID", MethodType.Get, 255, 0, DataType.Int);
        //CMD一般有如下几个值：List,New,Edit,Delete,Order；这里直接复制，不需更改
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "健康教育处方"; //这里要改成模块对应的内容
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
                bi2.ButtonName = "健康教育处方";  //需要改
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&PrescriptionID={0}')", PrescriptionID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                //这是操作数据库的核心代码，工作原理是：首先要明确现在所操作的模块对应着数据库中的哪张表，然后创建这个表所对应的的逻辑处理层(bll)对象，如这里操作的表是supervision_Info，则要新建所对应的Maticsoft.BLL.supervision_Info对象
                Maticsoft.BLL.education_Prescription bll = new Maticsoft.BLL.education_Prescription();
                //这是数据库实体类对象（简单来说就对应着这个表的一条记录），因为这里操作的表是supervision_Info，则对应的model是Maticsoft.Model.supervision_Info，然后通过上一行new的bll对象去执行数据库操作（这里使用的方法是GetModel，当然还有其他的方法，根据需要使用不同的方法），返回对应实体类对象
                Maticsoft.Model.education_Prescription model = bll.GetModel(PrescriptionID);
                //bll执行删除操作，参数是这个实体类的ID值
                bll.Delete(model.PrescriptionID);
                //以下方法的第4、5个参数需要更改
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", PrescriptionID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            //这两句和71、73作用一样
            Maticsoft.BLL.education_Prescription bll = new Maticsoft.BLL.education_Prescription();
            Maticsoft.Model.education_Prescription model = bll.GetModel(PrescriptionID);

            //以下几行需要更改
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
        /// 根据信息类型返回对应的信息名称（这个方法是在有下拉框的时候需要）
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

            //获取客户端通过Post方式传递过来的值的（需要更改）
            education_Prescription_model.P_Date = (DateTime)Common.sink(this.P_Date.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            education_Prescription_model.P_Content = (string)Common.sink(this.P_Content.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            education_Prescription_model.P_Object = Convert.ToInt32(this.P_Object.Value);
            education_Prescription_model.P_Doctor = Convert.ToInt32(this.P_Doctor.Value);

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    education_Prescription_bll.Add(education_Prescription_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    education_Prescription_bll.Update(education_Prescription_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            //以下方法的第4个参数需要更改
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", PrescriptionID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }}
    }
