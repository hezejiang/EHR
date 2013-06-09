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
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            sys_UserTable ut = BusinessFacade.sys_UserDisp(UserID);
            OnStartData(ut);
            if (CMD == "List")
            {
                HeadMenuButtonItem bi1 = new HeadMenuButtonItem();
                bi1.ButtonPopedom = PopedomType.Edit;
                bi1.ButtonName = "用户";
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
                bi5.ButtonName = "返回";
                bi5.ButtonUrl = string.Format("?CMD=List&UserID={0}", UserID);
                HeadMenuWebControls1.ButtonList.Add(bi5);

                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonName = "用户";
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&UserID={0}')", UserID);
                HeadMenuWebControls1.ButtonList.Add(bi2);
                U_LoginName.Visible = false;
                U_LoginName_Value.Visible = true;


            }
            else if (CMD == "Delete")
            {
                CheckUserNewEditDelete();
                //Admin帐号不能被删除
                if ((ut.UserID != 1))
                {
                    if (ut.U_Type == 0 && UserData.GetUserDate.U_Type == 1)
                    {
                        EventMessage.MessageBox(1, "操作无效", "普通用户无法删除超级用户资料!", Icon_Type.Error, Common.GetHomeBaseUrl("default.aspx"));
                    }
                    //ut.DB_Option_Action_ = "Delete";
                    //BusinessFacade.sys_UserInsertUpdate(ut);
                    //设置用户删除标识
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
                    //从缓存中移除用户
                    UserData.MoveUserCache(UserID);
                    //从在线列表中移除
                    FrameWorkOnline.Instance().OnlineRemove(ut.U_LoginName.ToLower());
                }
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", UserID, "删除用户"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));

            }

        }

        /// <summary>
        /// 检测用户是否可以新增/修改/删除用户资料
        /// </summary>
        private void CheckUserNewEditDelete()
        {
            if (!BusinessFacade.sys_UserCheckManagerUser(UserID))
            {
                EventMessage.MessageBox(1, "操作失败", string.Format("你的帐号({0})无权管理当前用户,可能你不是超级用户/管理员或者当前用户没有设置部门.超级用户可以管理所有用户,管理员只能管理本部门的用户资料!", UserData.GetUserDate.U_LoginName), Icon_Type.Alert, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 设置默认用户部门
        /// </summary>
        private void SetUserGroup()
        {
            U_GroupID.Value = UserData.GetUserDate.U_GroupID.ToString();
            U_GroupID_Txt.Value = BusinessFacade.sys_GroupDisp(UserData.GetUserDate.U_GroupID).G_CName;

        }

        /// <summary>
        /// 隐藏输入框
        /// </summary>
        private void Hidden_Input()
        {
            U_LoginName.Visible = false;
            U_Password.Visible = false;
            U_Type.Visible = false;
            U_Status.Visible = false;
            U_GroupID_Span.Visible = false;
            MultiListBox1.Visible = false;
        }

        /// <summary>
        /// 陷藏显示框
        /// </summary>
        private void Hidden_Disp()
        {
            U_LoginName_Value.Visible = false;
            U_Password_Value.Visible = false;
            U_Type_Value.Visible = false;
            U_Status_Value.Visible = false;
            U_GroupID_Value.Visible = false;
            //U_PhotoUrl_Value.Visible = false;
            Roles_Value.Visible = false;
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="ut"></param>
        private void OnStartData(sys_UserTable ut)
        {
            #region "显示数据"
            U_LoginName_Value.Text = ut.U_LoginName;
            U_Password_Value.Text = "******";
            U_Type_Value.Text = BusinessFacade.sys_UserType(ut.U_Type);
            if (UserData.GetUserDate.U_Type == 0)
            {
                U_Type.Items[1].Enabled = true;
                U_Type.Items[2].Enabled = true;
            }
            else if (UserData.GetUserDate.U_Type == 1)
            {
                U_Type.Items[1].Enabled = true;
            }
            U_Status_Value.Text = ut.U_Status == 0 ? "正常" : "禁止";
            U_GroupID_Value.Text = BusinessFacade.sys_GroupDisp(ut.U_GroupID).G_CName;
            #endregion

            #region "输入数据"
            U_LoginName.Text = ut.U_LoginName;
            U_Password.Attributes["value"] = ut.U_Password;
            ListItem li = U_Type.Items.FindByValue(ut.U_Type.ToString());
            if (li != null)
                li.Selected = true;
            ListItem li1 = U_Status.Items.FindByValue(ut.U_Status.ToString());
            if (li1 != null)
                li1.Selected = true;
            U_GroupID.Value = ut.U_GroupID.ToString();
            U_GroupID_Txt.Value = BusinessFacade.sys_GroupDisp(ut.U_GroupID).G_CName;
            
            #endregion
        }

        /// <summary>
        /// 绑定角色资料
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string U_Password_Txt = (string)Common.sink(U_Password.UniqueID, MethodType.Post, 32, 1, DataType.Str);
            int U_Type_Txt = (int)Common.sink(U_Type.UniqueID, MethodType.Post, 20, 1, DataType.Int);
            int U_Status_Txt = (int)Common.sink(U_Status.UniqueID, MethodType.Post, 20, 1, DataType.Int);
            int U_GroupID_Txt = (int)Common.sink(U_GroupID.UniqueID, MethodType.Post, 50, 0, DataType.Int);
            int U_Title_Txt = (int)Common.sink("U_Title", MethodType.Post, 50, 0, DataType.Int);

            PopedomType pt = PopedomType.New;
            string All_Title_Txt = "增加";
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
                //只有 超级管理员 和 管理员 才能修改密码
                if (BusinessFacade.sys_UserCheckManager())
                {
                    //超级管理员不能被修改密码
                    if (ut.UserID != 1)
                    {
                        if (U_Password_Txt != ut.U_Password)
                        {
                            ut.U_Password = Common.md5(U_Password_Txt, 32);
                        }
                    }
                }
                pt = PopedomType.Edit;
                All_Title_Txt = "修改";
                ut.DB_Option_Action_ = "Update";
                if (ut.U_Type == 0 && UserData.GetUserDate.U_Type == 1)
                {
                    EventMessage.MessageBox(1, "操作无效", "普通用户无效修改超级用户资料!", Icon_Type.Error, Common.GetHomeBaseUrl("default.aspx"));
                }
            }
            else
            {
                EventMessage.MessageBox(2, "CMD值无效", "无效操作命令!", Icon_Type.Error, Common.GetHomeBaseUrl("default.aspx"));
            }

            ut.U_GroupID = U_GroupID_Txt;

            //超级管理员不能被修改状态
            if (ut.UserID != 1)
            {
                //必需是超级用户和管理员才能修改禁止登陆
                if (BusinessFacade.sys_UserCheckManager())
                    ut.U_Status = U_Status_Txt;
            }
            ut.U_Title = U_Title_Txt;

            //限制admin帐号只能为超级用户
            if (ut.UserID == 1)
                ut.U_Type = 0;
            else
            {
                //只有超级管理员(管理员)才能增加超级管理员(管理员)
                if (UserData.GetUserDate.U_Type != 1)
                    ut.U_Type = U_Type_Txt;
            }

            if (BusinessFacade.sys_UserTableCheckPK(ut, pt))
                EventMessage.MessageBox(1, "操作失败", string.Format("存在相同的值({0})!", ut.U_LoginName), Icon_Type.Alert, Common.GetHomeBaseUrl("default.aspx"));
            int rInt = BusinessFacade.sys_UserInsertUpdate(ut);
            //只有 超级管理员 和 管理员 才能修改角色资料
            if (BusinessFacade.sys_UserCheckManager())
            {
                //超级管理员不能被修改密码
                if (ut.UserID != 1)
                {
                    if (ut.DB_Option_Action_ == "Insert")
                        SaveRoles(rInt);
                    else
                        SaveRoles(UserID);
                }
            }
            UserData.MoveUserCache(UserID);
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", ut.U_LoginName, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));

        }

        /// <summary>
        /// 保存用户角色信息
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