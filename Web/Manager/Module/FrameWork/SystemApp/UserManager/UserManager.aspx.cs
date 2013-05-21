using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.UserManager
{
    public partial class UserManager : System.Web.UI.Page
    {
        public string U_PhotoUrl_Js = "";
        public string MaxImgUrl = "";
        int UserID = (int)Common.sink("UserID", MethodType.Get, 50, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            FrameWorkPermission.CheckPagePermission(CMD);
            if (!Page.IsPostBack)
            {
                BindRoleID();
                OnStart();
            }
        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        private void OnStart()
        {
            sys_UserTable ut = BusinessFacade.sys_UserDisp(UserID);
            OnStartData(ut);
            if (CMD == "List")
            {
                DispTr.Visible = true;
                HeadMenuButtonItem bi1 = new HeadMenuButtonItem();
                bi1.ButtonPopedom = PopedomType.Edit;
                bi1.ButtonName = "�û�";
                bi1.ButtonUrl = string.Format("?CMD=Edit&UserID={0}", UserID);
                HeadMenuWebControls1.ButtonList.Add(bi1);


                Hidden_Input();
                PostButton.Visible = false;

            }
            else if (CMD == "New")
            {
                SetUserGroup();
                Hidden_Disp();
            }
            else if (CMD == "Edit")
            {
                CheckUserNewEditDelete();
                Hidden_Disp();
                HeadMenuButtonItem bi5 = new HeadMenuButtonItem();
                bi5.ButtonIcon = "back.gif";
                bi5.ButtonPopedom = PopedomType.List;
                bi5.ButtonName = "����";
                bi5.ButtonUrl = string.Format("?CMD=List&UserID={0}", UserID);
                HeadMenuWebControls1.ButtonList.Add(bi5);

                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "�û�";
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&UserID={0}')", UserID);
                HeadMenuWebControls1.ButtonList.Add(bi2);
                U_LoginName.Visible = false;
                U_LoginName_Value.Visible = true;


            }
            else if (CMD == "Delete")
            {
                CheckUserNewEditDelete();
                //Admin�ʺŲ��ܱ�ɾ��
                if ((ut.UserID != 1))
                {
                    if (ut.U_Type == 0 && UserData.GetUserDate.U_Type == 1)
                    {
                        EventMessage.MessageBox(1, "������Ч", "��ͨ�û��޷�ɾ�������û�����!", Icon_Type.Error, Common.GetHomeBaseUrl("default.aspx"));
                    }
                    //ut.DB_Option_Action_ = "Delete";
                    //BusinessFacade.sys_UserInsertUpdate(ut);
                    //�����û�ɾ����ʶ
                    BusinessFacade.Update_Table_Fileds("sys_User", "U_Status=2", string.Format("UserID={0}", UserID));
                    ArrayList lst = BusinessFacade.sys_UserRolesDisp(UserID);
                    foreach (sys_UserRolesTable var in lst)
                    {
                        var.DB_Option_Action_ = "Delete";
                        BusinessFacade.sys_UserRolesInsertUpdate(var);
                    }


                    if (ut.U_PhotoUrl != "")
                    {
                        FileUpLoadCommon.DeleteFile(string.Format("{0}{1}{2}", Common.UpLoadDir, "UserPhoto/", ut.U_PhotoUrl));
                        FileUpLoadCommon.DeleteFile(string.Format("{0}{1}s_{2}", Common.UpLoadDir, "UserPhoto/", ut.U_PhotoUrl));
                    }
                    //�ӻ������Ƴ��û�
                    UserData.MoveUserCache(UserID);
                    //�������б����Ƴ�
                    FrameWorkOnline.Instance().OnlineRemove(ut.U_LoginName.ToLower());
                }
                EventMessage.MessageBox(1, "�����ɹ�", string.Format("{1}ID({0})�ɹ�!", UserID, "ɾ���û�"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));

            }

        }

        /// <summary>
        /// ����û��Ƿ��������/�޸�/ɾ���û�����
        /// </summary>
        private void CheckUserNewEditDelete()
        {
            if (!BusinessFacade.sys_UserCheckManagerUser(UserID))
            {
                EventMessage.MessageBox(1, "����ʧ��", string.Format("����ʺ�({0})��Ȩ����ǰ�û�,�����㲻�ǳ����û�/����Ա���ߵ�ǰ�û�û�����ò���.�����û����Թ��������û�,����Աֻ�ܹ������ŵ��û�����!", UserData.GetUserDate.U_LoginName), Icon_Type.Alert, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// ����Ĭ���û�����
        /// </summary>
        private void SetUserGroup()
        {
            U_GroupID.Value = UserData.GetUserDate.U_GroupID.ToString();
            U_GroupID_Txt.Value = BusinessFacade.sys_GroupDisp(UserData.GetUserDate.U_GroupID).G_CName;

        }

        /// <summary>
        /// ���������
        /// </summary>
        private void Hidden_Input()
        {
            U_LoginName.Visible = false;
            U_Password.Visible = false;
            U_Type.Visible = false;
            U_Status.Visible = false;
            U_UserNO.Visible = false;
            U_CName.Visible = false;
            U_EName.Visible = false;
            U_GroupID_Span.Visible = false;
            U_Sex.Visible = false;
            U_BirthDay.Visible = false;
            FieldWebControls1.Visible = false;
            U_IDCard.Visible = false;
            U_HomeTel.Visible = false;
            U_MobileNo.Visible = false;
            U_CompanyMail.Visible = false;
            U_Email.Visible = false;
            U_Extension.Visible = false;
            U_WorkStartDate.Visible = false;
            U_Remark.Visible = false;
            U_PhotoUrl.Visible = false;
            MultiListBox1.Visible = false;
        }

        /// <summary>
        /// �ݲ���ʾ��
        /// </summary>
        private void Hidden_Disp()
        {
            U_LoginName_Value.Visible = false;
            U_Password_Value.Visible = false;
            U_Type_Value.Visible = false;
            U_Status_Value.Visible = false;
            U_UserNO_Value.Visible = false;
            U_CName_Value.Visible = false;
            U_EName_Value.Visible = false;
            U_GroupID_Value.Visible = false;
            U_Sex_Value.Visible = false;
            U_BirthDay_Value.Visible = false;
            U_Title_Value.Visible = false;
            U_IDCard_Value.Visible = false;
            U_HomeTel_Value.Visible = false;
            U_MobileNo_Value.Visible = false;
            U_CompanyMail_Value.Visible = false;
            U_Email_Value.Visible = false;
            U_Extension_Value.Visible = false;
            U_WorkStartDate_Value.Visible = false;
            U_Remark_Value.Visible = false;
            //U_PhotoUrl_Value.Visible = false;
            Roles_Value.Visible = false;
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <param name="ut"></param>
        private void OnStartData(sys_UserTable ut)
        {
            #region "��ʾ����"
            U_LoginName_Value.Text = ut.U_LoginName;
            U_Password_Value.Text = "******";
            U_Type_Value.Text = BusinessFacade.sys_UserType(ut.U_Type);
            U_Status_Value.Text = ut.U_Status == 0 ? "����" : "��ֹ";
            U_UserNO_Value.Text = ut.U_UserNO;
            U_CName_Value.Text = ut.U_CName;
            U_EName_Value.Text = ut.U_EName;
            U_GroupID_Value.Text = BusinessFacade.sys_GroupDisp(ut.U_GroupID).G_CName;
            U_Sex_Value.Text = ut.U_Sex == 0 ? "Ů" : "��";
            U_BirthDay_Value.Text = Common.ConvertDate(ut.U_BirthDay);
            U_Title_Value.Text = BusinessFacade.sys_FieldValueDisp(ut.U_Title).V_Text;
            U_IDCard_Value.Text = ut.U_IDCard;
            U_HomeTel_Value.Text = ut.U_HomeTel;
            U_MobileNo_Value.Text = ut.U_MobileNo;
            U_CompanyMail_Value.Text = ut.U_CompanyMail;
            U_Email_Value.Text = ut.U_Email;
            U_Extension_Value.Text = ut.U_Extension;
            U_WorkStartDate_Value.Text = Common.ConvertDate(ut.U_WorkStartDate);
            U_Remark_Value.Text = ut.U_Remark;
            if ((ut.U_PhotoUrl + "").Trim() != "")
            {
                U_PhotoUrl_Value.ImageUrl = Common.BuildDownFileUrl("UserPhoto/s_" + ut.U_PhotoUrl);
                MaxImgUrl = Common.BuildDownFileUrl("UserPhoto/" + ut.U_PhotoUrl);

            }
            else
                U_PhotoUrl_Value.Visible = false;
            U_LastIP_Value.Text = Common.GetIPLookUrl(ut.U_LastIP);
            U_LastDateTime_Value.Text = ut.U_LastDateTime.ToString();
            #endregion

            #region "��������"
            U_LoginName.Text = ut.U_LoginName;
            U_Password.Attributes["value"] = ut.U_Password;
            ListItem li = U_Type.Items.FindByValue(ut.U_Type.ToString());
            if (li != null)
                li.Selected = true;
            ListItem li1 = U_Status.Items.FindByValue(ut.U_Status.ToString());
            if (li1 != null)
                li1.Selected = true;
            U_UserNO.Text = ut.U_UserNO;
            U_CName.Text = ut.U_CName;
            U_EName.Text = ut.U_EName;
            U_GroupID.Value = ut.U_GroupID.ToString();
            U_GroupID_Txt.Value = BusinessFacade.sys_GroupDisp(ut.U_GroupID).G_CName;
            ListItem li2 = U_Sex.Items.FindByValue(ut.U_Sex.ToString());
            if (li2 != null)
                li2.Selected = true;
            U_BirthDay.Text = Common.ConvertDate(ut.U_BirthDay);
            FieldWebControls1.Field_Value = ut.U_Title.ToString();
            U_IDCard.Text = ut.U_IDCard;
            U_HomeTel.Text = ut.U_HomeTel;
            U_MobileNo.Text = ut.U_MobileNo;
            U_CompanyMail.Text = ut.U_CompanyMail;
            U_Email.Text = ut.U_Email;
            U_Extension.Text = ut.U_Extension;
            U_WorkStartDate.Text = Common.ConvertDate(ut.U_WorkStartDate);
            U_Remark.Text = ut.U_Remark;
            //if ((ut.U_PhotoUrl + "").Trim() != "")
            //{
            //    U_PhotoUrl_Value.ImageUrl = Common.BuildDownFileUrl("UserPhoto/s_" + ut.U_PhotoUrl);

            //}
            //else
            //    U_PhotoUrl_Value.Visible = false;
            #endregion
        }

        /// <summary>
        /// �󶨽�ɫ����
        /// </summary>
        private void BindRoleID()
        {
            QueryParam qp = new QueryParam();
            int RecordCount = 0;
            //ArrayList lst = BusinessFacade.sys_RolesList(qp, out RecordCount);
            ArrayList lst = BusinessFacade.sys_RolesListUser(qp, out RecordCount);
            
            MultiListBox1.FirstListBox.DataSource = lst;
            MultiListBox1.DataBind();

            lst = BusinessFacade.sys_UserRolesDisp(UserID);
            if (lst.Count != 0)
            {
                foreach (sys_UserRolesTable var in lst)
                {

                    ListItem li = new ListItem();
                    li = MultiListBox1.FirstListBox.Items.FindByValue(var.R_RoleID.ToString());
                    if (li != null)
                    {
                        MultiListBox1.FirstListBox.Items.Remove(li);
                        MultiListBox1.SecondListBox.Items.Add(li);
                    }
                    Roles_Value.Text = Roles_Value.Text + BusinessFacade.sys_RolesDisp(var.R_RoleID).R_RoleName + "<br>";
                }
            }
        }

        private string UpPhoto()
        {
            FileUpLoadCommon fc = new FileUpLoadCommon(Common.UpLoadDir + "UserPhoto/", false);
            fc.SaveFile(U_PhotoUrl, true);
            return fc.newFileName;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string U_Password_Txt = (string)Common.sink(U_Password.UniqueID, MethodType.Post, 32, 1, DataType.Str);
            int U_Type_Txt = (int)Common.sink(U_Type.UniqueID, MethodType.Post, 20, 1, DataType.Int);
            int U_Status_Txt = (int)Common.sink(U_Status.UniqueID, MethodType.Post, 20, 1, DataType.Int);
            string U_UserNO_Txt = (string)Common.sink(U_UserNO.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string U_CName_Txt = (string)Common.sink(U_CName.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string U_EName_Txt = (string)Common.sink(U_EName.UniqueID, MethodType.Post, 50, 0, DataType.Str);
            int U_GroupID_Txt = (int)Common.sink(U_GroupID.UniqueID, MethodType.Post, 50, 0, DataType.Int);
            int U_Sex_Txt = (int)Common.sink(U_Sex.UniqueID, MethodType.Post, 50, 1, DataType.Int);
            DateTime U_BirthDay_Txt = (DateTime)Common.sink(U_BirthDay.UniqueID, MethodType.Post, 50, 0, DataType.Dat);
            int U_Title_Txt = (int)Common.sink("U_Title", MethodType.Post, 50, 0, DataType.Int);
            string U_IDCard_Txt = (string)Common.sink(U_IDCard.UniqueID, MethodType.Post, 30, 0, DataType.Str);
            string U_HomeTel_Txt = (string)Common.sink(U_HomeTel.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string U_MobileNo_Txt = (string)Common.sink(U_MobileNo.UniqueID, MethodType.Post, 15, 0, DataType.Str);
            string U_CompanyMail_Txt = (string)Common.sink(U_CompanyMail.UniqueID, MethodType.Post, 100, 0, DataType.Email);
            string U_Email_Txt = (string)Common.sink(U_Email.UniqueID, MethodType.Post, 100, 0, DataType.Email);
            string U_Extension_Txt = (string)Common.sink(U_Extension.UniqueID, MethodType.Post, 10, 0, DataType.Str);
            DateTime U_WorkStartDate_Txt = (DateTime)Common.sink(U_WorkStartDate.UniqueID, MethodType.Post, 50, 0, DataType.Dat);
            string U_Remark_Txt = (string)Common.sink(U_Remark.UniqueID, MethodType.Post, 2000, 0, DataType.Str);

            PopedomType pt = PopedomType.New;
            string All_Title_Txt = "����";
            sys_UserTable ut = BusinessFacade.sys_UserDisp(UserID);

            if (CMD == "New")
            {
                string U_LoginName_Txt = (string)Common.sink(U_LoginName.UniqueID, MethodType.Post, 20, 1, DataType.Str);
                ut.U_Password = Common.md5(U_Password_Txt, 32);
                ut.U_LoginName = U_LoginName_Txt;
                ut.U_LastDateTime = DateTime.Now;
                ut.U_LastIP = Common.GetIPAddress();
                ut.U_DateTime = DateTime.Now;
                ut.DB_Option_Action_ = "Insert";
            }
            else if (CMD == "Edit")
            {
                //ֻ�� ��������Ա �� ����Ա �����޸�����
                if (BusinessFacade.sys_UserCheckManager())
                {
                    //��������Ա���ܱ��޸�����
                    if (ut.UserID != 1)
                    {
                        if (U_Password_Txt != ut.U_Password)
                        {
                            ut.U_Password = Common.md5(U_Password_Txt, 32);
                        }
                    }
                }
                pt = PopedomType.Edit;
                All_Title_Txt = "�޸�";
                ut.DB_Option_Action_ = "Update";
                if (ut.U_Type == 0 && UserData.GetUserDate.U_Type == 1)
                {
                    EventMessage.MessageBox(1, "������Ч", "��ͨ�û���Ч�޸ĳ����û�����!", Icon_Type.Error, Common.GetHomeBaseUrl("default.aspx"));
                }
            }
            else
            {
                EventMessage.MessageBox(2, "CMDֵ��Ч", "��Ч��������!", Icon_Type.Error, Common.GetHomeBaseUrl("default.aspx"));
            }

            ut.U_BirthDay = U_BirthDay_Txt;
            ut.U_CName = U_CName_Txt;
            ut.U_CompanyMail = U_CompanyMail_Txt;
            ut.U_Email = U_Email_Txt;
            ut.U_EName = U_EName_Txt;
            ut.U_Extension = U_Extension_Txt;
            ut.U_GroupID = U_GroupID_Txt;
            ut.U_HomeTel = U_HomeTel_Txt;
            ut.U_IDCard = U_IDCard_Txt;
            ut.U_MobileNo = U_MobileNo_Txt;
            ut.U_Remark = U_Remark_Txt;

            ut.U_Sex = U_Sex_Txt;
            //��������Ա���ܱ��޸�״̬
            if (ut.UserID != 1)
            {
                //�����ǳ����û��͹���Ա�����޸Ľ�ֹ��½
                if (BusinessFacade.sys_UserCheckManager())
                    ut.U_Status = U_Status_Txt;
            }
            ut.U_Title = U_Title_Txt;

            //����admin�ʺ�ֻ��Ϊ�����û�
            if (ut.UserID == 1)
                ut.U_Type = 0;
            else
            {
                //ֻ�г�������Ա�������ӳ�������Ա�͹���Ա
                if (UserData.GetUserDate.U_Type == 0)
                    ut.U_Type = U_Type_Txt;
            }
            ut.U_UserNO = U_UserNO_Txt;
            ut.U_WorkStartDate = U_WorkStartDate_Txt;
            string GetU_PhotoName = UpPhoto();
            if (GetU_PhotoName != "")
            {
                FileUpLoadCommon.DeleteFile(string.Format("{0}{1}{2}", Common.UpLoadDir, "UserPhoto/", ut.U_PhotoUrl));
                FileUpLoadCommon.DeleteFile(string.Format("{0}{1}s_{2}", Common.UpLoadDir, "UserPhoto/", ut.U_PhotoUrl));
                ut.U_PhotoUrl = GetU_PhotoName;
            }


            if (BusinessFacade.sys_UserTableCheckPK(ut, pt))
                EventMessage.MessageBox(1, "����ʧ��", string.Format("������ͬ��ֵ({0})!", ut.U_LoginName), Icon_Type.Alert, Common.GetHomeBaseUrl("default.aspx"));
            int rInt = BusinessFacade.sys_UserInsertUpdate(ut);
            //ֻ�� ��������Ա �� ����Ա �����޸Ľ�ɫ����
            if (BusinessFacade.sys_UserCheckManager())
            {
                //��������Ա���ܱ��޸�����
                if (ut.UserID != 1)
                {
                    if (ut.DB_Option_Action_ == "Insert")
                        SaveRoles(rInt);
                    else
                        SaveRoles(UserID);
                }
            }
            UserData.MoveUserCache(UserID);
            EventMessage.MessageBox(1, "�����ɹ�", string.Format("{1}ID({0})�ɹ�!", ut.U_LoginName, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));

        }

        /// <summary>
        /// �����û���ɫ��Ϣ
        /// </summary>
        private void SaveRoles(int UserID)
        {
            

            UserData.Move_UserPermissionCache(UserID);
            ArrayList lst = BusinessFacade.sys_UserRolesDisp(UserID);
            foreach (sys_UserRolesTable var in lst)
            {
                if (BusinessFacade.sys_Roles_CheckUser(var.R_RoleID))
                {
                    var.DB_Option_Action_ = "Delete";
                    BusinessFacade.sys_UserRolesInsertUpdate(var);
                }
            }

            sys_UserRolesTable urt = new sys_UserRolesTable();
            urt.DB_Option_Action_ = "Insert";
            urt.R_UserID = UserID;
            foreach (ListItem var in MultiListBox1.SecondListBox.Items)
            {
                urt.R_RoleID = Convert.ToInt32(var.Value);
                if (BusinessFacade.sys_Roles_CheckUser(urt.R_RoleID))
                {                   
                    BusinessFacade.sys_UserRolesInsertUpdate(urt);
                }
            }
        }
    }
}