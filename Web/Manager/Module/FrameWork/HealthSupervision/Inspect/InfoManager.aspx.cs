using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthSupervision.Inspect
{
    public partial class InspectManager : System.Web.UI.Page
    {
        int InspectID = (int)Common.sink("InspectID", MethodType.Get, 255, 0, DataType.Int);
        int InfoID = (int)Common.sink("InfoID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "信息"; //这里要改成模块对应的内容
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
                bi2.ButtonName = "巡查";  //需要改
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&InspectID={0}')", InspectID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.supervision_Inspect bll = new Maticsoft.BLL.supervision_Inspect();
                Maticsoft.Model.supervision_Inspect model = bll.GetModel(InspectID);
                bll.Delete(model.InspectID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", InspectID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.supervision_Inspect bll = new Maticsoft.BLL.supervision_Inspect();
            Maticsoft.Model.supervision_Inspect model = bll.GetModel(InspectID);
            I_Date.Text = model.I_Date.ToShortDateString();
            I_Type.SelectedValue = model.I_Type+"";
            I_Content.Text = model.I_Content;
            Maticsoft.BLL.sys_User user_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User user_model = user_bll.GetModel(model.I_UserID);
            I_UserID.Value = user_model.UserID + "";
            I_UserID_input.Text = user_model.U_CName;
        }

        /// <summary>
        /// 根据信息类型返回对应的信息名称
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getSuperisionNameByType(int superision_type){
            string superision_name = "";
            switch (superision_type)
            {
                case 1:
                    superision_name = "食品安全";
                break;
                case 2:
                    superision_name = "饮用水卫生";
                break;
                case 3:
                    superision_name = "职业病安全";
                break;
                case 4:
                    superision_name = "学校卫生";
                break;
                case 5:
                    superision_name = "非法行医（采供血）";
                break;
            }
            return superision_name;
        }
        
        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.supervision_Inspect supervision_bll = new Maticsoft.BLL.supervision_Inspect();
            Maticsoft.Model.supervision_Inspect supervision_Inspect_model = supervision_bll.GetModel(InspectID);
            if (supervision_Inspect_model == null)
            {
                supervision_Inspect_model = new Maticsoft.Model.supervision_Inspect();
            }

            //获取客户端通过Post方式传递过来的值的
            supervision_Inspect_model.I_Date = (DateTime)Common.sink(this.I_Date.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            supervision_Inspect_model.I_Type = Convert.ToInt32(this.I_Type.SelectedValue);
            supervision_Inspect_model.I_Content = (string)Common.sink(this.I_Content.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            supervision_Inspect_model.I_Location = (string)Common.sink(this.I_Location.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            supervision_Inspect_model.I_MainProblem = (string)Common.sink(this.I_MainProblem.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            supervision_Inspect_model.I_UserID = Convert.ToInt32(this.I_UserID.Value);

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    supervision_Inspect_model.I_InfoID = InfoID;
                    //如果是增加操作，就调用Add方法
                    supervision_Inspect_model.InspectID = supervision_bll.Add(supervision_Inspect_model);
                    if (supervision_Inspect_model.InspectID > 0)
                    {
                        Maticsoft.BLL.supervision_Info supervision_Info_bll = new Maticsoft.BLL.supervision_Info();
                        Maticsoft.Model.supervision_Info supervision_Info_model = supervision_Info_bll.GetModel(InfoID);
                        supervision_Info_model.I_Status = 2;
                        supervision_Info_bll.Update(supervision_Info_model);
                    }
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    supervision_bll.Update(supervision_Inspect_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", supervision_Inspect_model.InspectID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
         }
       }
    }
