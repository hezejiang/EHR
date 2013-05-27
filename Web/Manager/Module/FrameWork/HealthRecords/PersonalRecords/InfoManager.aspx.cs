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
        public int UserID = (int)Common.sink("UserID", MethodType.Get, 255, 0, DataType.Int);
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
            bi3.ButtonPopedom = PopedomType.Delete;
            bi3.ButtonName = "健康档案";
            bi3.ButtonUrlType = UrlType.JavaScript;
            bi3.ButtonUrl = string.Format("DelData('?CMD=Delete&UserID={0}')", UserID);
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
                sysUser_bll.Delete(UserID);

                Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
                Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(UserID);
                record_UserBaseInfo_bll.Delete(UserID);

                Maticsoft.BLL.extend_DiseaseHistory extend_DiseaseHistory_bll = new Maticsoft.BLL.extend_DiseaseHistory();
                List<Maticsoft.Model.extend_DiseaseHistory> extend_DiseaseHistory_models = extend_DiseaseHistory_bll.GetModelList("DH_UserID = " + UserID);
                for (int i = 0; i < extend_DiseaseHistory_models.Count; i++)
                {
                    extend_DiseaseHistory_bll.Delete(extend_DiseaseHistory_models[i].DiseaseHistoryID);
                }

                Maticsoft.BLL.extend_GeneticDisease extend_GeneticDisease_bll = new Maticsoft.BLL.extend_GeneticDisease();
                Maticsoft.Model.extend_GeneticDisease extend_GeneticDisease_model = extend_GeneticDisease_bll.GetModel("GD_UserID=" + UserID);
                if (extend_GeneticDisease_model != null)
                {
                    extend_GeneticDisease_bll.Delete(extend_GeneticDisease_model.GeneticDiseaseID);
                }

                Maticsoft.BLL.extend_Disability extend_Disability_bll = new Maticsoft.BLL.extend_Disability();
                List<Maticsoft.Model.extend_Disability> extend_Disability_models = extend_Disability_bll.GetModelList("D_UserID=" + UserID);
                for (int i = 0; i < extend_DiseaseHistory_models.Count; i++)
                {
                    extend_Disability_bll.Delete(extend_Disability_models[i].DisabilityID);
                }

                Maticsoft.BLL.extend_FamilyHistory extend_FamilyHistory_bll = new Maticsoft.BLL.extend_FamilyHistory();

                List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_father_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 1);
                for (int i = 0; i < extend_FamilyHistory_father_models.Count; i++)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_father_models[i].FamilyHistoryID);
                }

                List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_mather_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 2);
                for (int i = 0; i < extend_FamilyHistory_mather_models.Count; i++)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_mather_models[i].FamilyHistoryID);
                }

                List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_bothers_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 3);
                for (int i = 0; i < extend_FamilyHistory_bothers_models.Count; i++)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_bothers_models[i].FamilyHistoryID);
                }

                List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_children_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 4);
                for (int i = 0; i < extend_FamilyHistory_children_models.Count; i++)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_children_models[i].FamilyHistoryID);
                }

                //生活环境
                Maticsoft.BLL.extend_Environment extend_Environment_bll = new Maticsoft.BLL.extend_Environment();
                //厨房排风设施
                List<Maticsoft.Model.extend_Environment> extend_Environment_kind1_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 1));
                for (int i = 0; i < extend_Environment_kind1_models.Count; i++)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind1_models[i].EnvironmentID);
                }
                //燃料类型
                List<Maticsoft.Model.extend_Environment> extend_Environment_kind2_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 2));
                for (int i = 0; i < extend_Environment_kind2_models.Count; i++)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind2_models[i].EnvironmentID);
                }
                //饮水
                List<Maticsoft.Model.extend_Environment> extend_Environment_kind3_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 3));
                for (int i = 0; i < extend_Environment_kind3_models.Count; i++)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind3_models[i].EnvironmentID);
                }
                //厕所
                List<Maticsoft.Model.extend_Environment> extend_Environment_kind4_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 4));
                for (int i = 0; i < extend_Environment_kind4_models.Count; i++)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind4_models[i].EnvironmentID);
                }
                //禽畜栏
                List<Maticsoft.Model.extend_Environment> extend_Environment_kind5_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 5));
                for (int i = 0; i < extend_Environment_kind5_models.Count; i++)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind5_models[i].EnvironmentID);
                }

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
                    DiseaseHistory_data.Value = DiseaseHistory_data.Value + "{'type':" + extend_DiseaseHistory_models[i].DH_Type + ",'date':" + TimeParser.UNIX_TIMESTAMP(extend_DiseaseHistory_models[i].DH_DiagnosisDate) + "},";  //以json的方式
                    if (extend_DiseaseHistory_models[i].DH_Type == 11)
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
                DisabilityList.Items[D_Type].Selected = true;
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
                    fatherDisease_data.Value = fatherDisease_data.Value + "{'type':" + extend_FamilyHistory_father_models[i].FH_Type + "},";  //以json的方式
                    if (extend_FamilyHistory_father_models[i].FH_Type == 11)
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
                    matherDisease_data.Value = matherDisease_data.Value + "{'type':" + extend_FamilyHistory_mather_models[i].FH_Type + "},";  //以json的方式
                    if (extend_FamilyHistory_mather_models[i].FH_Type == 11)
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
                    brothersDisease_data.Value = brothersDisease_data.Value + "{'type':" + extend_FamilyHistory_brothers_models[i].FH_Type + "},";  //以json的方式
                    if (extend_FamilyHistory_brothers_models[i].FH_Type == 11)
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
                    childrenDisease_data.Value = childrenDisease_data.Value + "{'type':" + extend_FamilyHistory_children_models[i].FH_Type + "},";  //以json的方式
                    if (extend_FamilyHistory_children_models[i].FH_Type == 11)
                    {
                        children_FH_Type11.Checked = true;
                        children_note.Value = extend_FamilyHistory_children_models[i].FH_Note;
                    }
                }
                childrenDisease_data.Value = childrenDisease_data.Value.Remove(childrenDisease_data.Value.Length - 1);
            }
            childrenDisease_data.Value = childrenDisease_data.Value + "]";

            //生活环境
            Maticsoft.BLL.extend_Environment extend_Environment_bll = new Maticsoft.BLL.extend_Environment();
            //厨房排风设施
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind1_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 1));
            for (int i = 0; i < extend_Environment_kind1_models.Count; i++)
            {
                E_Kind1.Items[extend_Environment_kind1_models[i].E_Type - 1].Selected = true;
            }
            //燃料类型
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind2_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 2));
            for (int i = 0; i < extend_Environment_kind2_models.Count; i++)
            {
                E_Kind2.Items[extend_Environment_kind2_models[i].E_Type - 1].Selected = true;
            }
            //饮水
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind3_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 3));
            for (int i = 0; i < extend_Environment_kind3_models.Count; i++)
            {
                E_Kind3.Items[extend_Environment_kind3_models[i].E_Type - 1].Selected = true;
            }
            //厕所
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind4_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 4));
            for (int i = 0; i < extend_Environment_kind4_models.Count; i++)
            {
                E_Kind4.Items[extend_Environment_kind4_models[i].E_Type - 1].Selected = true;
            }
            //禽畜栏
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind5_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, 5));
            for (int i = 0; i < extend_Environment_kind5_models.Count; i++)
            {
                E_Kind5.Items[extend_Environment_kind5_models[i].E_Type - 1].Selected = true;
            }

            //备注
            U_Note.Value = record_UserBaseInfo_model.U_Note;
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
                long time = (long)item["date"];
                extend_DiseaseHistory_model.DH_DiagnosisDate = TimeParser.FROM_UNIXTIME(time);
                if (DH_Type == 11)
                    extend_DiseaseHistory_model.DH_Note = DH_Type_11_note.Value;
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
                    if (extend_Disability_old_models[i].DisabilityID == DisabilityIDs[j])
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
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_father_old_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 1);
            List<int> FamilyHistoryIDs = new List<int>();
            jsonData = JsonMapper.ToObject(fatherDisease_data.Value);
            foreach (JsonData item in jsonData)
            {
                int FH_Type = (int)item["type"];
                Maticsoft.Model.extend_FamilyHistory extend_FamilyHistory_model = extend_FamilyHistory_bll.GetModel(string.Format("FH_Type={0} and FH_UserID={1} and FH_Who={2}", FH_Type, UserID, 1));
                if (extend_FamilyHistory_model == null)
                {
                    extend_FamilyHistory_model = new Maticsoft.Model.extend_FamilyHistory();
                    extend_FamilyHistory_model.FamilyHistoryID = 0;
                }
                extend_FamilyHistory_model.FH_Type = FH_Type;
                extend_FamilyHistory_model.FH_Who = 1;
                extend_FamilyHistory_model.FH_UserID = UserID;
                if (FH_Type == 11)
                    extend_FamilyHistory_model.FH_Note = father_note.Value;
                if (extend_FamilyHistory_model.FamilyHistoryID == 0)
                    extend_FamilyHistory_model.FamilyHistoryID = extend_FamilyHistory_bll.Add(extend_FamilyHistory_model);
                else
                    extend_FamilyHistory_bll.Update(extend_FamilyHistory_model);
                FamilyHistoryIDs.Add(extend_FamilyHistory_model.FamilyHistoryID);
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_FamilyHistory_father_old_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < FamilyHistoryIDs.Count; j++)
                {
                    if (extend_FamilyHistory_father_old_models[i].FamilyHistoryID == FamilyHistoryIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_father_old_models[i].FamilyHistoryID);
                }
            }

            //母亲
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_mather_old_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 2);
            FamilyHistoryIDs = new List<int>();
            jsonData = JsonMapper.ToObject(matherDisease_data.Value);
            foreach (JsonData item in jsonData)
            {
                int FH_Type = (int)item["type"];
                Maticsoft.Model.extend_FamilyHistory extend_FamilyHistory_model = extend_FamilyHistory_bll.GetModel(string.Format("FH_Type={0} and FH_UserID={1} and FH_Who={2}", FH_Type, UserID, 2));
                if (extend_FamilyHistory_model == null)
                {
                    extend_FamilyHistory_model = new Maticsoft.Model.extend_FamilyHistory();
                    extend_FamilyHistory_model.FamilyHistoryID = 0;
                }
                extend_FamilyHistory_model.FH_Type = FH_Type;
                extend_FamilyHistory_model.FH_Who = 2;
                extend_FamilyHistory_model.FH_UserID = UserID;
                if (FH_Type == 11)
                    extend_FamilyHistory_model.FH_Note = mather_note.Value;
                if (extend_FamilyHistory_model.FamilyHistoryID == 0)
                    extend_FamilyHistory_model.FamilyHistoryID = extend_FamilyHistory_bll.Add(extend_FamilyHistory_model);
                else
                    extend_FamilyHistory_bll.Update(extend_FamilyHistory_model);
                FamilyHistoryIDs.Add(extend_FamilyHistory_model.FamilyHistoryID);
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_FamilyHistory_mather_old_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < FamilyHistoryIDs.Count; j++)
                {
                    if (extend_FamilyHistory_mather_old_models[i].FamilyHistoryID == FamilyHistoryIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_mather_old_models[i].FamilyHistoryID);
                }
            }

            //兄弟姐妹
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_brothers_old_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 3);
            FamilyHistoryIDs = new List<int>();
            jsonData = JsonMapper.ToObject(brothersDisease_data.Value);
            foreach (JsonData item in jsonData)
            {
                int FH_Type = (int)item["type"];
                Maticsoft.Model.extend_FamilyHistory extend_FamilyHistory_model = extend_FamilyHistory_bll.GetModel(string.Format("FH_Type={0} and FH_UserID={1} and FH_Who={2}", FH_Type, UserID, 3));
                if (extend_FamilyHistory_model == null)
                {
                    extend_FamilyHistory_model = new Maticsoft.Model.extend_FamilyHistory();
                    extend_FamilyHistory_model.FamilyHistoryID = 0;
                }
                extend_FamilyHistory_model.FH_Type = FH_Type;
                extend_FamilyHistory_model.FH_Who = 3;
                extend_FamilyHistory_model.FH_UserID = UserID;
                if (FH_Type == 11)
                    extend_FamilyHistory_model.FH_Note = brothers_note.Value;
                if (extend_FamilyHistory_model.FamilyHistoryID == 0)
                    extend_FamilyHistory_model.FamilyHistoryID = extend_FamilyHistory_bll.Add(extend_FamilyHistory_model);
                else
                    extend_FamilyHistory_bll.Update(extend_FamilyHistory_model);
                FamilyHistoryIDs.Add(extend_FamilyHistory_model.FamilyHistoryID);
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_FamilyHistory_brothers_old_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < FamilyHistoryIDs.Count; j++)
                {
                    if (extend_FamilyHistory_brothers_old_models[i].FamilyHistoryID == FamilyHistoryIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_brothers_old_models[i].FamilyHistoryID);
                }
            }

            //子女
            List<Maticsoft.Model.extend_FamilyHistory> extend_FamilyHistory_children_old_models = extend_FamilyHistory_bll.GetModelList("FH_Who = " + 4);
            FamilyHistoryIDs = new List<int>();
            jsonData = JsonMapper.ToObject(childrenDisease_data.Value);
            foreach (JsonData item in jsonData)
            {
                int FH_Type = (int)item["type"];
                Maticsoft.Model.extend_FamilyHistory extend_FamilyHistory_model = extend_FamilyHistory_bll.GetModel(string.Format("FH_Type={0} and FH_UserID={1} and FH_Who={2}", FH_Type, UserID, 4));
                if (extend_FamilyHistory_model == null)
                {
                    extend_FamilyHistory_model = new Maticsoft.Model.extend_FamilyHistory();
                    extend_FamilyHistory_model.FamilyHistoryID = 0;
                }
                extend_FamilyHistory_model.FH_Type = FH_Type;
                extend_FamilyHistory_model.FH_Who = 4;
                extend_FamilyHistory_model.FH_UserID = UserID;
                if (FH_Type == 11)
                    extend_FamilyHistory_model.FH_Note = children_note.Value;
                if (extend_FamilyHistory_model.FamilyHistoryID == 0)
                    extend_FamilyHistory_model.FamilyHistoryID = extend_FamilyHistory_bll.Add(extend_FamilyHistory_model);
                else
                    extend_FamilyHistory_bll.Update(extend_FamilyHistory_model);
                FamilyHistoryIDs.Add(extend_FamilyHistory_model.FamilyHistoryID);
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_FamilyHistory_children_old_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < FamilyHistoryIDs.Count; j++)
                {
                    if (extend_FamilyHistory_children_old_models[i].FamilyHistoryID == FamilyHistoryIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_FamilyHistory_bll.Delete(extend_FamilyHistory_children_old_models[i].FamilyHistoryID);
                }
            }

            //生活环境
            Maticsoft.BLL.extend_Environment extend_Environment_bll = new Maticsoft.BLL.extend_Environment();
            //厨房排风设施
            int kind1 = 1;
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind1_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, kind1));
            List<int> kindIDs = new List<int>();
            for (int i = 0; i < E_Kind1.Items.Count; i++)
            {
                Maticsoft.Model.extend_Environment extend_Environment_model = null;
                if (E_Kind1.Items[i].Selected)
                {
                    extend_Environment_model = extend_Environment_bll.GetModel(string.Format("E_Kind = {0} and E_Type={1} and E_UserID={2}", kind1, E_Kind1.Items[i].Value, UserID));
                    if (extend_Environment_model == null)
                    {
                        extend_Environment_model = new Maticsoft.Model.extend_Environment();
                        extend_Environment_model.EnvironmentID = 0;
                    }
                    extend_Environment_model.E_Kind = kind1;
                    extend_Environment_model.E_Type = Convert.ToInt32(E_Kind1.Items[i].Value);
                    extend_Environment_model.E_UserID = UserID;
                    if (extend_Environment_model.EnvironmentID == 0)
                        extend_Environment_model.EnvironmentID = extend_Environment_bll.Add(extend_Environment_model);
                    else
                        extend_Environment_bll.Update(extend_Environment_model);
                    kindIDs.Add(extend_Environment_model.EnvironmentID);
                }
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_Environment_kind1_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < kindIDs.Count; j++)
                {
                    if (extend_Environment_kind1_models[i].EnvironmentID == kindIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind1_models[i].EnvironmentID);
                }
            }

            //燃料类型
            int kind2 = 2;
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind2_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, kind2));
            kindIDs = new List<int>();
            for (int i = 0; i < E_Kind2.Items.Count; i++)
            {
                Maticsoft.Model.extend_Environment extend_Environment_model = null;
                if (E_Kind2.Items[i].Selected)
                {
                    extend_Environment_model = extend_Environment_bll.GetModel(string.Format("E_Kind = {0} and E_Type={1} and E_UserID={2}", kind2, E_Kind2.Items[i].Value, UserID));
                    if (extend_Environment_model == null)
                    {
                        extend_Environment_model = new Maticsoft.Model.extend_Environment();
                        extend_Environment_model.EnvironmentID = 0;
                    }
                    extend_Environment_model.E_Kind = kind2;
                    extend_Environment_model.E_Type = Convert.ToInt32(E_Kind2.Items[i].Value);
                    extend_Environment_model.E_UserID = UserID;
                    if (extend_Environment_model.EnvironmentID == 0)
                        extend_Environment_model.EnvironmentID = extend_Environment_bll.Add(extend_Environment_model);
                    else
                        extend_Environment_bll.Update(extend_Environment_model);
                    kindIDs.Add(extend_Environment_model.EnvironmentID);
                }
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_Environment_kind2_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < kindIDs.Count; j++)
                {
                    if (extend_Environment_kind2_models[i].EnvironmentID == kindIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind2_models[i].EnvironmentID);
                }
            }

            //饮水
            int kind3 = 3;
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind3_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, kind3));
            kindIDs = new List<int>();
            for (int i = 0; i < E_Kind3.Items.Count; i++)
            {
                Maticsoft.Model.extend_Environment extend_Environment_model = null;
                if (E_Kind3.Items[i].Selected)
                {
                    extend_Environment_model = extend_Environment_bll.GetModel(string.Format("E_Kind = {0} and E_Type={1} and E_UserID={2}", kind3, E_Kind3.Items[i].Value, UserID));
                    if (extend_Environment_model == null)
                    {
                        extend_Environment_model = new Maticsoft.Model.extend_Environment();
                        extend_Environment_model.EnvironmentID = 0;
                    }
                    extend_Environment_model.E_Kind = kind3;
                    extend_Environment_model.E_Type = Convert.ToInt32(E_Kind3.Items[i].Value);
                    extend_Environment_model.E_UserID = UserID;
                    if (extend_Environment_model.EnvironmentID == 0)
                        extend_Environment_model.EnvironmentID = extend_Environment_bll.Add(extend_Environment_model);
                    else
                        extend_Environment_bll.Update(extend_Environment_model);
                    kindIDs.Add(extend_Environment_model.EnvironmentID);
                }
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_Environment_kind3_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < kindIDs.Count; j++)
                {
                    if (extend_Environment_kind3_models[i].EnvironmentID == kindIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind3_models[i].EnvironmentID);
                }
            }

            //厕所
            int kind4 = 4;
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind4_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, kind4));
            kindIDs = new List<int>();
            for (int i = 0; i < E_Kind4.Items.Count; i++)
            {
                Maticsoft.Model.extend_Environment extend_Environment_model = null;
                if (E_Kind4.Items[i].Selected)
                {
                    extend_Environment_model = extend_Environment_bll.GetModel(string.Format("E_Kind = {0} and E_Type={1} and E_UserID={2}", kind4, E_Kind4.Items[i].Value, UserID));
                    if (extend_Environment_model == null)
                    {
                        extend_Environment_model = new Maticsoft.Model.extend_Environment();
                        extend_Environment_model.EnvironmentID = 0;
                    }
                    extend_Environment_model.E_Kind = kind4;
                    extend_Environment_model.E_Type = Convert.ToInt32(E_Kind4.Items[i].Value);
                    extend_Environment_model.E_UserID = UserID;
                    if (extend_Environment_model.EnvironmentID == 0)
                        extend_Environment_model.EnvironmentID = extend_Environment_bll.Add(extend_Environment_model);
                    else
                        extend_Environment_bll.Update(extend_Environment_model);
                    kindIDs.Add(extend_Environment_model.EnvironmentID);
                }
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_Environment_kind4_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < kindIDs.Count; j++)
                {
                    if (extend_Environment_kind4_models[i].EnvironmentID == kindIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind4_models[i].EnvironmentID);
                }
            }

            //禽畜栏
            int kind5 = 5;
            List<Maticsoft.Model.extend_Environment> extend_Environment_kind5_models = extend_Environment_bll.GetModelList(string.Format("E_UserID = {0} and E_Kind={1}", UserID, kind5));
            kindIDs = new List<int>();
            for (int i = 0; i < E_Kind5.Items.Count; i++)
            {
                Maticsoft.Model.extend_Environment extend_Environment_model = null;
                if (E_Kind5.Items[i].Selected)
                {
                    extend_Environment_model = extend_Environment_bll.GetModel(string.Format("E_Kind = {0} and E_Type={1} and E_UserID={2}", kind5, E_Kind5.Items[i].Value, UserID));
                    if (extend_Environment_model == null)
                    {
                        extend_Environment_model = new Maticsoft.Model.extend_Environment();
                        extend_Environment_model.EnvironmentID = 0;
                    }
                    extend_Environment_model.E_Kind = kind5;
                    extend_Environment_model.E_Type = Convert.ToInt32(E_Kind5.Items[i].Value);
                    extend_Environment_model.E_UserID = UserID;
                    if (extend_Environment_model.EnvironmentID == 0)
                        extend_Environment_model.EnvironmentID = extend_Environment_bll.Add(extend_Environment_model);
                    else
                        extend_Environment_bll.Update(extend_Environment_model);
                    kindIDs.Add(extend_Environment_model.EnvironmentID);
                }
            }
            //如果是取消的则要删除
            for (int i = 0; i < extend_Environment_kind5_models.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < kindIDs.Count; j++)
                {
                    if (extend_Environment_kind5_models[i].EnvironmentID == kindIDs[j])
                        flag = true;
                }
                if (!flag)
                {
                    extend_Environment_bll.Delete(extend_Environment_kind5_models[i].EnvironmentID);
                }
            }

            Maticsoft.BLL.record_UserBaseInfo record_UserBaseInfo_bll = new Maticsoft.BLL.record_UserBaseInfo();
            Maticsoft.Model.record_UserBaseInfo record_UserBaseInfo_model = record_UserBaseInfo_bll.GetModel(UserID);
            if (record_UserBaseInfo_model != null)
            {
                record_UserBaseInfo_model.U_Note = U_Note.Value;
                record_UserBaseInfo_bll.Update(record_UserBaseInfo_model);
            }
            
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", UserID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}