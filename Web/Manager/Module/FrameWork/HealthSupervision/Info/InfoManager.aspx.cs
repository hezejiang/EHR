using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthSupervision.Info
{
    public partial class InfoManager : System.Web.UI.Page
    {
        //获取通过Get方式传递过来的键对应的值，可复制后改成你所负责模块的"*ID"
        int InfoID = (int)Common.sink("InfoID", MethodType.Get, 255, 0, DataType.Int);
        //CMD一般有如下几个值：List,New,Edit,Delete,Order；这里直接复制，不需更改
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
                HiddenDisp();
            }
            else if (CMD == "Edit")
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "信息";  //需要改
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&InfoID={0}')", InfoID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                HiddenDisp();
                InputData();
            }
            else if (CMD == "Delete")
            {
                //这是操作数据库的核心代码，工作原理是：首先要明确现在所操作的模块对应着数据库中的哪张表，然后创建这个表所对应的的逻辑处理层(bll)对象，如这里操作的表是supervision_Info，则要新建所对应的Maticsoft.BLL.supervision_Info对象
                Maticsoft.BLL.supervision_Info bll = new Maticsoft.BLL.supervision_Info();
                //这是数据库实体类对象（简单来说就对应着这个表的一条记录），因为这里操作的表是supervision_Info，则对应的model是Maticsoft.Model.supervision_Info，然后通过上一行new的bll对象去执行数据库操作（这里使用的方法是GetModel，当然还有其他的方法，根据需要使用不同的方法），返回对应实体类对象
                Maticsoft.Model.supervision_Info model = bll.GetModel(InfoID);
                //bll执行删除操作，参数是这个实体类的ID值
                bll.Delete(model.InfoID);
                //以下方法的第4、5个参数需要更改
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", InfoID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            //这两句和73、75作用一样
            Maticsoft.BLL.supervision_Info bll = new Maticsoft.BLL.supervision_Info();
            Maticsoft.Model.supervision_Info model = bll.GetModel(InfoID);

            //以下几行需要更改
            this.I_FindDate.Text = this.I_FindDate_Txt.Text = model.I_FindDate.ToShortDateString();
            this.I_Type.SelectedValue = model.I_Type+"";
            this.I_Type_Txt.Text = getSuperisionNameByType(model.I_Type);
            this.I_Content.Text = this.I_Content_Txt.Text = model.I_Content;
            this.I_ReportDate.Text = this.I_ReportDate.Text = model.I_ReportDate.ToShortDateString();
            Maticsoft.BLL.sys_User user_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User user_model = user_bll.GetModel(model.I_ReportUserID);
            this.I_ReportUserID.Value = user_model.UserID + "";
            this.I_ReportUserID_TextBox.Text = user_model.U_CName;
        }

        /// <summary>
        /// 根据信息类型返回对应的信息名称（这个方法是在有下拉框的时候需要）
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
        /// 隐藏Label（需要更改）
        /// </summary>
        private void HiddenDisp()
        {
            this.I_FindDate_Txt.Visible = false;
            this.I_Type_Txt.Visible = false;
            this.I_Content_Txt.Visible = false;
            this.I_ReportDate_Txt.Visible = false;
        }

        /// <summary>
        /// 隐藏输入框（需要更改）
        /// </summary>
        private void HiddenInput()
        {
            this.I_FindDate.Visible = false;
            this.I_Type.Visible = false;
            this.I_Content.Visible = false;
            this.I_ReportDate.Visible = false;
            this.SubmitTr.Visible = false;
        }
        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.supervision_Info supervision = new Maticsoft.BLL.supervision_Info();
            Maticsoft.Model.supervision_Info supervision_Info = supervision.GetModel(InfoID);
            if (supervision_Info == null)
            {
                supervision_Info = new Maticsoft.Model.supervision_Info();
            }

            //获取客户端通过Post方式传递过来的值的（需要更改）
            supervision_Info.I_FindDate = (DateTime)Common.sink(this.I_FindDate.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            supervision_Info.I_Type = Convert.ToInt32(this.I_Type.SelectedValue);
            supervision_Info.I_Content = (string)Common.sink(this.I_Content.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            supervision_Info.I_ReportDate = (DateTime)Common.sink(this.I_ReportDate.UniqueID, MethodType.Post, 0, 0, DataType.Dat);
            supervision_Info.I_ReportUserID = Convert.ToInt32(this.I_ReportUserID.Value);

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    supervision.Add(supervision_Info);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    //如果是修改操作，就调用Update方法
                    supervision.Update(supervision_Info);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            //以下方法的第4个参数需要更改
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", InfoID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}