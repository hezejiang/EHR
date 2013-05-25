using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.PersonalRecords
{
    public partial class InfoManager : System.Web.UI.Page
    {
        int UserID = (int)Common.sink("UserID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "健康档案";
        string All_Title_Txt = "";
        private List<Maticsoft.Model.commonDiseases> commonDiseases_list;

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
            HeadMenuButtonItem bi1 = new HeadMenuButtonItem();
            bi1.ButtonIcon = "back.gif";
            bi1.ButtonName = "健康体检记录";
            bi1.ButtonPopedom = PopedomType.List;
            bi1.ButtonUrl = string.Format("default.aspx");
            HeadMenuWebControls1.ButtonList.Add(bi1);

            HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
            bi2.ButtonIcon = "back.gif";
            bi2.ButtonName = "会诊记录";
            bi2.ButtonPopedom = PopedomType.List;
            bi2.ButtonUrl = string.Format("default.aspx");
            HeadMenuWebControls1.ButtonList.Add(bi2);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            Maticsoft.BLL.Nation nation_bll = new Maticsoft.BLL.Nation();
            this.U_NationID.DataSource = nation_bll.GetAllList();
            this.U_NationID.DataValueField = "NationID";
            this.U_NationID.DataTextField = "N_Name";
            this.U_NationID.DataBind();

            if (CMD == "New")
            {
            }
            else if (CMD == "Edit")
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "健康档案";
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&UserID={0}')", UserID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.sys_User sysUser_bll = new Maticsoft.BLL.sys_User();
                Maticsoft.Model.sys_User sysUser_model = sysUser_bll.GetModel(UserID);

                Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
                Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(UserID);

                sysUser_bll.Delete(UserID);
                record_UserBaseInfo_bll.Delete(UserID);
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", UserID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.sys_User sysUser_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User sysUser_model = sysUser_bll.GetModel(UserID);

            Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
            Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(UserID);

            this.U_IDCard.Text = sysUser_model.U_IDCard;
            this.U_CName.Text = sysUser_model.U_CName;
            this.U_Hometown.Text = record_UserBaseInfo_model.U_Hometown;
            this.U_CurrentAddress.Text = record_UserBaseInfo_model.U_CurrentAddress;
            this.U_Sex.SelectedValue = sysUser_model.U_Sex + "";

            Maticsoft.BLL.Nation nation_bll = new Maticsoft.BLL.Nation();
            Maticsoft.Model.Nation nation_model = nation_bll.GetModel(record_UserBaseInfo_model.U_NationID);
            this.U_NationID.SelectedValue = nation_model.NationID + "";

            this.U_MarriageStatus.SelectedValue = record_UserBaseInfo_model.U_MarriageStatus + "";
            this.U_BloodType.SelectedValue = record_UserBaseInfo_model.U_BloodType + "";
            this.U_MobileNo.Text = sysUser_model.U_MobileNo;

            Maticsoft.BLL.sys_Group sysGroup_bll = new Maticsoft.BLL.sys_Group();
            Maticsoft.Model.sys_Group sysGroup_model = sysGroup_bll.GetModel(record_UserBaseInfo_model.U_Committee);
            this.U_Committee_input.Value = sysGroup_model.G_CName;
            this.U_Committee.Value = record_UserBaseInfo_model.U_Committee + "";

            this.U_PermanentType.SelectedValue = record_UserBaseInfo_model.U_PermanentType + "";
            this.U_Education.SelectedValue = record_UserBaseInfo_model.U_Education + "";
            this.U_WorkingUnits.Text = record_UserBaseInfo_model.U_WorkingUnits;
            this.U_WorkingContactName.Text = record_UserBaseInfo_model.U_WorkingContactName;
            this.U_WorkingContactTel.Text = record_UserBaseInfo_model.U_WorkingContactTel;

            this.U_PaymentType.Text = record_UserBaseInfo_model.U_PaymentType;
            this.U_SocialNO.Text = record_UserBaseInfo_model.U_SocialNO;
            this.U_MedicalNO.Text = record_UserBaseInfo_model.U_MedicalNO;
            this.U_FamilyCode.Value= record_UserBaseInfo_model.U_FamilyCode;
            this.U_RelationShip.SelectedValue = record_UserBaseInfo_model.U_RelationShip + "";
            this.U_AuditStatus.SelectedValue = record_UserBaseInfo_model.U_RelationShip + "";

            this.U_ResponsibilityUserID_input.Value = getUserModelById(record_UserBaseInfo_model.U_ResponsibilityUserID).U_CName;
            this.U_ResponsibilityUserID.Value = record_UserBaseInfo_model.U_ResponsibilityUserID + "";

            sysGroup_model = sysGroup_bll.GetModel(record_UserBaseInfo_model.U_FilingUnits);
            this.U_FilingUnits_input.Value = sysGroup_model.G_CName;
            this.U_FilingUnits.Value = record_UserBaseInfo_model.U_FilingUnits + "";

            this.U_FilingUserID_input.Value = getUserModelById(record_UserBaseInfo_model.U_FilingUserID).U_CName;
            this.U_FilingUserID.Value = record_UserBaseInfo_model.U_FilingUserID + "";

            Maticsoft.BLL.commonDiseases commonDiseases_bll = new Maticsoft.BLL.commonDiseases();
            commonDiseases_list = commonDiseases_bll.GetModelList("CommonDiseaseID < 11");
            DiseaseHistory_repeater.DataSource = commonDiseases_list;
            DiseaseHistory_repeater.DataBind();

            fatherDisease_repeater.DataSource = commonDiseases_list;
            fatherDisease_repeater.DataBind();
        }

        /// <summary>
        /// 通过用户id得到用户信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Maticsoft.Model.sys_User getUserModelById(int userID)
        {
            Maticsoft.BLL.sys_User bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User model = bll.GetModel(userID);
            return model;
        }

        /// <summary>
        /// 根据婚姻状态码返回对应的名称
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getMarriageStatusNameByType(int status)
        {
            string name = "";
            switch (status)
            {
                case 1:
                    name = "未婚";
                break;
                case 2:
                    name = "已婚";
                break;
                case 3:
                    name = "丧偶";
                break;
                case 4:
                    name = "离婚";
                break;
            }
            return name;
        }

        /// <summary>
        /// 根据血液状态码返回对应的名称
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getBloodTypeNameByType(int status)
        {
            string name = "";
            switch (status)
            {
                case 1:
                    name = "A型";
                    break;
                case 2:
                    name = "B型";
                    break;
                case 3:
                    name = "AB型";
                    break;
                case 4:
                    name = "O型";
                    break;
                default:
                    name = "不详";
                    break;
            }
            return name;
        }

        /// <summary>
        /// 根据常住类型状态码返回对应的名称
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getPermanentTypeNameByType(int status)
        {
            string name = "";
            switch (status)
            {
                case 1:
                    name = "户籍";
                    break;
                case 2:
                    name = "非户籍";
                    break;
            }
            return name;
        }

        /// <summary>
        /// 根据文化程度类型状态码返回对应的名称
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getEducationNameByType(int status)
        {
            string name = "";
            switch (status)
            {
                case 1:
                    name = "文盲及半文盲";
                    break;
                case 2:
                    name = "小学";
                    break;
                case 3:
                    name = "中学";
                    break;
                case 4:
                    name = "高中/技校/中专";
                    break;
                case 5:
                    name = "大学专科";
                    break;
                case 6:
                    name = "大学本科";
                    break;
                case 7:
                    name = "研究生及以上";
                    break;
                default:
                    name = "不详";
                    break;
            }
            return name;
        }

        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.sys_User sysUser_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User sysUser_model = sysUser_bll.GetModel(UserID);

            Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
            Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(UserID);
            if (sysUser_model == null)
            {
                sysUser_model = new Maticsoft.Model.sys_User();
            }
            if (record_UserBaseInfo_model == null)
            {
                record_UserBaseInfo_model = new Maticsoft.Model.record_UserBaseInfo();
            }

            sysUser_model.U_IDCard = (string)Common.sink(this.U_IDCard.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            sysUser_model.U_CName = (string)Common.sink(this.U_CName.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_Hometown = (string)Common.sink(this.U_Hometown.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_CurrentAddress = (string)Common.sink(this.U_CurrentAddress.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            sysUser_model.U_Sex = Convert.ToInt32(this.U_Sex.SelectedValue);
            record_UserBaseInfo_model.U_NationID = Convert.ToInt32(this.U_NationID.SelectedValue);
            record_UserBaseInfo_model.U_MarriageStatus = Convert.ToInt32(this.U_MarriageStatus.SelectedValue);
            record_UserBaseInfo_model.U_BloodType = Convert.ToInt32(this.U_BloodType.SelectedValue);
            sysUser_model.U_MobileNo = (string)Common.sink(this.U_MobileNo.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_Committee = Convert.ToInt32(Common.sink(this.U_Committee.UniqueID, MethodType.Post, 0, 0, DataType.Str));
            record_UserBaseInfo_model.U_PermanentType = Convert.ToInt32(this.U_PermanentType.SelectedValue);
            record_UserBaseInfo_model.U_Education = Convert.ToInt32(this.U_Education.SelectedValue);
            record_UserBaseInfo_model.U_WorkingUnits = (string)Common.sink(this.U_WorkingUnits.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_WorkingContactName = (string)Common.sink(this.U_WorkingContactName.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_WorkingContactTel = (string)Common.sink(this.U_WorkingContactTel.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_PaymentType = this.U_PaymentType.SelectedValue;  //这里要改为多选
            record_UserBaseInfo_model.U_SocialNO = (string)Common.sink(this.U_SocialNO.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_MedicalNO = (string)Common.sink(this.U_MedicalNO.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_FamilyCode = (string)Common.sink(this.U_FamilyCode.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            record_UserBaseInfo_model.U_RelationShip = Convert.ToInt32(this.U_RelationShip.SelectedValue);
            record_UserBaseInfo_model.U_ResponsibilityUserID = Convert.ToInt32(Common.sink(this.U_ResponsibilityUserID.UniqueID, MethodType.Post, 0, 0, DataType.Str));
            record_UserBaseInfo_model.U_AuditStatus = Convert.ToInt32(this.U_AuditStatus.SelectedValue);
            record_UserBaseInfo_model.U_FilingUnits = Convert.ToInt32(Common.sink(this.U_FilingUnits.UniqueID, MethodType.Post, 0, 0, DataType.Str));
            record_UserBaseInfo_model.U_FilingUserID = Convert.ToInt32(Common.sink(this.U_FilingUserID.UniqueID, MethodType.Post, 0, 0, DataType.Str));

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    //如果是增加操作，就调用Add方法
                    sysUser_model.U_Password = Common.md5(sysUser_model.U_IDCard, 32);  //初始密码为身份证号
                    string year=sysUser_model.U_IDCard.Substring(6,4);
                    string month=sysUser_model.U_IDCard.Substring(10,2);
                    string date=sysUser_model.U_IDCard.Substring(12,2);
                    string result = year + "-" + month + "-" + date;
                    sysUser_model.U_LoginName = sysUser_model.U_IDCard;
                    sysUser_model.U_BirthDay = Convert.ToDateTime(result);
                    sysUser_model.U_DateTime = sysUser_model.U_LastDateTime = sysUser_model.U_WorkStartDate = sysUser_model.U_WorkEndDate = DateTime.Now;
                    sysUser_model.U_LastIP = Common.GetIPAddress();
                    sysUser_model.U_Type = 1;
                    sysUser_model.U_Status = 0;
                    record_UserBaseInfo_model.UserID = sysUser_bll.Add(sysUser_model);
                    record_UserBaseInfo_model.U_FlingTime = DateTime.Now;
                    record_UserBaseInfo_bll.Add(record_UserBaseInfo_model);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    sysUser_bll.Update(sysUser_model);
                    record_UserBaseInfo_bll.Update(record_UserBaseInfo_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", UserID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}