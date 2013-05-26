using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;
using Maticsoft.Common;
using LitJson;
using System.IO;

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

            HeadMenuButtonItem bi3 = new HeadMenuButtonItem();
            bi2.ButtonPopedom = PopedomType.Delete;
            bi2.ButtonName = "健康档案";
            bi2.ButtonUrlType = UrlType.JavaScript;
            bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&UserID={0}')", UserID);
            HeadMenuWebControls1.ButtonList.Add(bi3);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            bindDroplist();

            if (CMD == "New")
            {
            }
            else if (CMD == "Edit")
            {
                BindButton();
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

            //扩展信息
            //疾病史
            Maticsoft.BLL.extend_DiseaseHistory extend_DiseaseHistory_bll = new Maticsoft.BLL.extend_DiseaseHistory();
            List<Maticsoft.Model.extend_DiseaseHistory> extend_DiseaseHistory_models = extend_DiseaseHistory_bll.GetModelList("DH_UserID = " + UserID);
            DiseaseHistory_data.Value = "[";
            if (extend_DiseaseHistory_models.Count > 0)
            {
                for (int i = 0; i < extend_DiseaseHistory_models.Count; i++)
                {
                    if (extend_DiseaseHistory_models[i].DH_Type != 11)
                    {
                        DiseaseHistory_data.Value = DiseaseHistory_data.Value + "{'type':" + extend_DiseaseHistory_models[i].DH_Type + ",'date':" + TimeParser.UNIX_TIMESTAMP(extend_DiseaseHistory_models[i].DH_DiagnosisDate) + "},";  //以json的方式
                    }
                    else //其他
                    {
                        DH_Type_11.Checked = true;
                        DH_Type_11_note.Value = extend_DiseaseHistory_models[i].DH_Note;
                        DH_DiagnosisDate_11.Value = extend_DiseaseHistory_models[i].DH_DiagnosisDate.ToShortDateString();
                    }
                }
                DiseaseHistory_data.Value = DiseaseHistory_data.Value.Remove(DiseaseHistory_data.Value.Length - 1);
            }
            else
            {
                DH_Type_0.Checked = true;
            }
            DiseaseHistory_data.Value = DiseaseHistory_data.Value + "]";

            //遗传病史
            Maticsoft.BLL.extend_GeneticDisease extend_GeneticDisease_bll = new Maticsoft.BLL.extend_GeneticDisease();
            Maticsoft.Model.extend_GeneticDisease extend_GeneticDisease_model = extend_GeneticDisease_bll.GetModel("GD_UserID=" + UserID);
            if (extend_GeneticDisease_model == null)
            {
                GeneticDisease_none.Checked = true;
            }
            else
            {
                GeneticDisease_check.Checked = true;
                GD_Name.Value = extend_GeneticDisease_model.GD_Name;
            }

            //残疾情况
            Maticsoft.BLL.extend_Disability extend_Disability_bll = new Maticsoft.BLL.extend_Disability();
            List<Maticsoft.Model.extend_Disability> extend_Disability_models = extend_Disability_bll.GetModelList("D_UserID=" + UserID);
            for (int i = 0; i < extend_Disability_models.Count; i++)
            {
                int D_Type = extend_Disability_models[i].D_Type;
                DisabilityList.Items[D_Type - 1].Selected = true;
                if (D_Type == 7)
                    D_Note.Value = extend_Disability_models[i].D_Note;
            }

            //家族史
            Maticsoft.BLL.extend_FamilyHistory extend_FamilyHistory_bll = new Maticsoft.BLL.extend_FamilyHistory();
            //父亲
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_father_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 1);
            fatherDisease_data.Value = "[";
            if (extend_FamilyHistory_father_models.Count > 0)
            {
                for (int i = 0; i < extend_FamilyHistory_father_models.Count; i++)
                {
                    if (extend_FamilyHistory_father_models[i].FH_Type != 11)
                    {
                        fatherDisease_data.Value = fatherDisease_data.Value + "{'type':" + extend_FamilyHistory_father_models[i].FH_Type + "},";  //以json的方式
                    }
                    else //其他
                    {
                        father_FH_Type11.Checked = true;
                        father_note.Value = extend_FamilyHistory_father_models[i].FH_Note;
                    }
                }
                fatherDisease_data.Value = fatherDisease_data.Value.Remove(fatherDisease_data.Value.Length - 1);
            }
            fatherDisease_data.Value = fatherDisease_data.Value + "]";

            //母亲
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_mather_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 2);
            matherDisease_data.Value = "[";
            if (extend_FamilyHistory_mather_models.Count > 0)
            {
                for (int i = 0; i < extend_FamilyHistory_mather_models.Count; i++)
                {
                    if (extend_FamilyHistory_mather_models[i].FH_Type != 11)
                    {
                        matherDisease_data.Value = matherDisease_data.Value + "{'type':" + extend_FamilyHistory_mather_models[i].FH_Type + "},";  //以json的方式
                    }
                    else //其他
                    {
                        mather_FH_Type11.Checked = true;
                        mather_note.Value = extend_FamilyHistory_mather_models[i].FH_Note;
                    }
                }
                matherDisease_data.Value = matherDisease_data.Value.Remove(matherDisease_data.Value.Length - 1);
            }
            matherDisease_data.Value = matherDisease_data.Value + "]";

            //兄弟姐妹
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_brothers_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 3);
            brothersDisease_data.Value = "[";
            if (extend_FamilyHistory_brothers_models.Count > 0)
            {
                for (int i = 0; i < extend_FamilyHistory_brothers_models.Count; i++)
                {
                    if (extend_FamilyHistory_brothers_models[i].FH_Type != 11)
                    {
                        brothersDisease_data.Value = brothersDisease_data.Value + "{'type':" + extend_FamilyHistory_brothers_models[i].FH_Type + "},";  //以json的方式
                    }
                    else //其他
                    {
                        brothers_FH_Type11.Checked = true;
                        brothers_note.Value = extend_FamilyHistory_brothers_models[i].FH_Note;
                    }
                }
                brothersDisease_data.Value = brothersDisease_data.Value.Remove(brothersDisease_data.Value.Length - 1);
            }
            brothersDisease_data.Value = brothersDisease_data.Value + "]";

            //子女
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_children_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 4);
            childrenDisease_data.Value = "[";
            if (extend_FamilyHistory_children_models.Count > 0)
            {  
                for (int i = 0; i < extend_FamilyHistory_children_models.Count; i++)
                {
                    if (extend_FamilyHistory_children_models[i].FH_Type != 11)
                    {
                        childrenDisease_data.Value = childrenDisease_data.Value + "{'type':" + extend_FamilyHistory_children_models[i].FH_Type + "},";  //以json的方式
                    }
                    else //其他
                    {
                        children_FH_Type11.Checked = true;
                        children_note.Value = extend_FamilyHistory_children_models[i].FH_Note;
                    }
                }
                childrenDisease_data.Value = childrenDisease_data.Value.Remove(childrenDisease_data.Value.Length - 1);
            }
            childrenDisease_data.Value = childrenDisease_data.Value + "]";

            //生活环境
            Maticsoft.BLL.extend_Environment extend_Environment = new Maticsoft.BLL.extend_Environment();
            //厨房排风设施
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind1_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 1));
            for (int i = 0; i < extend_Environment_kind1_models.Count; i++)
            {
                E_Kind1.Items[extend_Environment_kind1_models[i].E_Type - 1].Selected = true;
            }
            //燃料类型
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind2_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 2));
            for (int i = 0; i < extend_Environment_kind2_models.Count; i++)
            {
                E_Kind2.Items[extend_Environment_kind2_models[i].E_Type - 1].Selected = true;
            }
            //饮水
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind3_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 3));
            for (int i = 0; i < extend_Environment_kind3_models.Count; i++)
            {
                E_Kind3.Items[extend_Environment_kind3_models[i].E_Type - 1].Selected = true;
            }
            //厕所
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind4_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 4));
            for (int i = 0; i < extend_Environment_kind4_models.Count; i++)
            {
                E_Kind4.Items[extend_Environment_kind4_models[i].E_Type - 1].Selected = true;
            }
            //禽畜栏
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind5_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 5));
            for (int i = 0; i < extend_Environment_kind5_models.Count; i++)
            {
                E_Kind5.Items[extend_Environment_kind5_models[i].E_Type - 1].Selected = true;
            }
        }
        /// <summary>
        /// 绑定下拉列表
        /// </summary>
        public void bindDroplist()
        {
            Maticsoft.BLL.Nation nation_bll = new Maticsoft.BLL.Nation();
            this.U_NationID.DataSource = nation_bll.GetAllList();
            this.U_NationID.DataValueField = "NationID";
            this.U_NationID.DataTextField = "N_Name";
            this.U_NationID.DataBind();

            Maticsoft.BLL.commonDiseases commonDiseases_bll = new Maticsoft.BLL.commonDiseases();
            commonDiseases_list = commonDiseases_bll.GetModelList("CommonDiseaseID < 11");
            DiseaseHistory_repeater.DataSource = commonDiseases_list;
            DiseaseHistory_repeater.DataBind();

            fatherDisease_repeater.DataSource = commonDiseases_list;
            fatherDisease_repeater.DataBind();

            matherDisease_repeater.DataSource = commonDiseases_list;
            matherDisease_repeater.DataBind();

            brothersDisease_repeater.DataSource = commonDiseases_list;
            brothersDisease_repeater.DataBind();

            childrenDisease_repeater.DataSource = commonDiseases_list;
            childrenDisease_repeater.DataBind();
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

        protected void extendBtn_Click(object sender, EventArgs e)
        {
            //扩展信息

            //疾病史
            Maticsoft.BLL.extend_DiseaseHistory extend_DiseaseHistory_bll = new Maticsoft.BLL.extend_DiseaseHistory();
            List<Maticsoft.Model.extend_DiseaseHistory> extend_DiseaseHistory_old_models = extend_DiseaseHistory_bll.GetModelList("DH_UserID = " + UserID);

            List<int> DiseaseHistoryIDs = new List<int>();
            JsonData jsonData = JsonMapper.ToObject(DiseaseHistory_data.Value);
            foreach (JsonData item in jsonData)
            {
                int DH_Type = (int)item["type"];
                Maticsoft.Model.extend_DiseaseHistory extend_DiseaseHistory_model = extend_DiseaseHistory_bll.GetModel(string.Format("DH_Type={0} and DH_UserID={1}", DH_Type, UserID));
                if (extend_DiseaseHistory_model == null)
                {
                    extend_DiseaseHistory_model = new Maticsoft.Model.extend_DiseaseHistory();
                    extend_DiseaseHistory_model.DiseaseHistoryID = 0;
                }
                extend_DiseaseHistory_model.DH_Type = DH_Type;
                extend_DiseaseHistory_model.DH_UserID = UserID;
                extend_DiseaseHistory_model.DH_DiagnosisDate = Convert.ToDateTime(item["date"].ToString());
                if (DH_Type == 11)
                    extend_DiseaseHistory_model.DH_Note = Request.Form["DH_Type_11_note"];
                if (extend_DiseaseHistory_model.DiseaseHistoryID == 0)
                    extend_DiseaseHistory_model.DiseaseHistoryID = extend_DiseaseHistory_bll.Add(extend_DiseaseHistory_model);
                else
                    extend_DiseaseHistory_bll.Update(extend_DiseaseHistory_model);
                DiseaseHistoryIDs.Add(extend_DiseaseHistory_model.DiseaseHistoryID);
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_DiseaseHistory_old_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < DiseaseHistoryIDs.Count; j++)
                {
                    if (extend_DiseaseHistory_old_models[i].DiseaseHistoryID == DiseaseHistoryIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_DiseaseHistory_bll.Delete(extend_DiseaseHistory_old_models[i].DiseaseHistoryID);
                }
            }

            //遗传病史
            Maticsoft.BLL.extend_GeneticDisease extend_GeneticDisease_bll = new Maticsoft.BLL.extend_GeneticDisease();
            Maticsoft.Model.extend_GeneticDisease extend_GeneticDisease_model = extend_GeneticDisease_bll.GetModel("GD_UserID=" + UserID);
            if (GeneticDisease_check.Checked)
            {
                if (extend_GeneticDisease_model == null)
                {
                    extend_GeneticDisease_model = new Maticsoft.Model.extend_GeneticDisease();
                    extend_GeneticDisease_model.GeneticDiseaseID = 0;
                }
                extend_GeneticDisease_model.GD_Name = GD_Name.Value;
                extend_GeneticDisease_model.GD_UserID = UserID;
                if (extend_GeneticDisease_model.GeneticDiseaseID == 0)
                    extend_GeneticDisease_bll.Add(extend_GeneticDisease_model);
                else
                    extend_GeneticDisease_bll.Update(extend_GeneticDisease_model);
            }
            else
            {
                if (extend_GeneticDisease_model != null)
                    extend_GeneticDisease_bll.Delete(extend_GeneticDisease_model.GeneticDiseaseID);
            }

            //残疾情况
            Maticsoft.BLL.extend_Disability extend_Disability_bll = new Maticsoft.BLL.extend_Disability();
            List<Maticsoft.Model.extend_Disability> extend_Disability_old_models = extend_Disability_bll.GetModelList("D_UserID=" + UserID);
            List<int> DisabilityIDs = new List<int>();
            for (int i = 0; i < DisabilityList.Items.Count; i++)
            {
                Maticsoft.Model.extend_Disability extend_Disability_model = null;
                if (DisabilityList.Items[i].Selected)
                {
                    extend_Disability_model = extend_Disability_bll.GetModel(string.Format("D_Type={0} and D_UserID={1}", DisabilityList.Items[i].Value, UserID));
                    if (extend_Disability_model == null)
                    {
                        extend_Disability_model = new Maticsoft.Model.extend_Disability();
                        extend_Disability_model.DisabilityID = 0;
                    }
                    extend_Disability_model.D_Type = Convert.ToInt32(DisabilityList.Items[i].Value);
                    extend_Disability_model.D_UserID = UserID;
                    if (DisabilityList.Items[i].Value == "7")
                        extend_Disability_model.D_Note = D_Note.Value;
                    if (extend_Disability_model.DisabilityID == 0)
                        extend_Disability_model.DisabilityID = extend_Disability_bll.Add(extend_Disability_model);
                    else
                        extend_Disability_bll.Update(extend_Disability_model);
                    DisabilityIDs.Add(extend_Disability_model.DisabilityID);
                }
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_Disability_old_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < DisabilityIDs.Count; j++)
                {
                    if (extend_Disability_old_models[i].DisabilityID == DiseaseHistoryIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_Disability_bll.Delete(extend_Disability_old_models[i].DisabilityID);
                }
            }

            //家族史
            Maticsoft.BLL.extend_FamilyHistory extend_FamilyHistory_bll = new Maticsoft.BLL.extend_FamilyHistory();
            //父亲
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_father_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 1);


            //母亲
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_mather_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 2);


            //兄弟姐妹
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_brothers_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 3);


            //子女
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_children_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 4);


            //生活环境
            Maticsoft.BLL.extend_Environment extend_Environment = new Maticsoft.BLL.extend_Environment();
            //厨房排风设施
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind1_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 1));

            //燃料类型
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind2_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 2));

            //饮水
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind3_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 3));

            //厕所
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind4_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 4));

            //禽畜栏
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind5_models = extend_Environment.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 5));

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";

                    break;
                case "Edit":
                    CMD_Txt = "修改";

                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", UserID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}