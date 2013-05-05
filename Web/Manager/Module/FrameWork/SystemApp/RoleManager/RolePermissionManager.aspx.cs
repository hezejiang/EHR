using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Diagnostics;
using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.RoleManager
{
    public partial class RolePermissionManager : System.Web.UI.Page
    {
        int RoleID = (int)Common.sink("RoleID", MethodType.Get, 255, 1, DataType.Int);
        int ApplicationID = (int)Common.sink("ApplicationID", MethodType.Get, 255, 1, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 255, 1, DataType.Str);
        protected void Page_Load(object sender, EventArgs e)
        {
            //Stopwatch st = new Stopwatch();
            //st.Start();
            GetRoleUserID = BusinessFacade.sys_RolesDisp(RoleID).R_UserID;
            FrameWorkPermission.CheckPagePermission(CMD);
            BusinessFacade.sys_UserCheckManagerVoid();
            BusinessFacade.sys_Roles_CheckUserVoid(RoleID);
            BindButton();
            if (!Page.IsPostBack)
            {
                OnStart();
                OnDisp();
            }
            //Response.Write((double)st.ElapsedMilliseconds / 1000);
        }


        /// <summary>
        /// ��õ�ǰ��ɫ�����û�ID
        /// </summary>
        private int GetRoleUserID;
        
        private void OnStart()
        {
            sys_RolesTable srt = BusinessFacade.sys_RolesDisp(RoleID);
            RoleName_Txt.Text = srt.R_RoleName;
            AppName_Txt.Text = BusinessFacade.sys_ApplicationsDisp(ApplicationID).A_AppName;
            RoleUser_Txt.Text = BusinessFacade.sys_UserDisp(srt.R_UserID).U_LoginName;
        }

        /// <summary>
        /// ������
        /// </summary>
        private void OnDisp()
        {
            QueryParam qp = new QueryParam();
            qp.Orderfld = " M_Applicationid,M_OrderLevel ";
            qp.OrderType = 0;
            qp.Where = string.Format("Where M_Close=0 and M_ParentID=0 and M_ApplicationID ={0}", ApplicationID);
            int RecordCount = 0;
            ArrayList lst = BusinessFacade.sys_ModuleList(qp, out RecordCount);
            Module_Main.DataSource = lst;
            Module_Main.DataBind();
        }

        private void BindButton()
        {
            HeadMenuButtonItem item0 = new HeadMenuButtonItem();
            item0.ButtonName = "��ɫ����";
            item0.ButtonIcon = "look.gif";
            item0.ButtonPopedom = PopedomType.List;
            item0.ButtonUrl = string.Format("RoleManager.aspx?RoleID={0}&CMD=Look", RoleID);
            HeadMenuWebControls1.ButtonList.Add(item0);
            if (CMD == "Look")
            {
                HeadMenuButtonItem item1 = new HeadMenuButtonItem();
                item1.ButtonName = "��ɫȨ��";
                item1.ButtonPopedom = PopedomType.Edit;
                item1.ButtonUrl = string.Format("?RoleID={0}&ApplicationID={1}&CMD=Edit", RoleID, ApplicationID);
                HeadMenuWebControls1.ButtonList.Add(item1);
            }
            if (CMD == "Edit")
            {
                ButtonTr_End.Visible = true;
                HeadMenuButtonItem item2 = new HeadMenuButtonItem();
                item2.ButtonName = "����";
                item2.ButtonIcon = "back.gif";
                item2.ButtonPopedom = PopedomType.List;
                item2.ButtonUrl = "history.back(-1);";
                item2.ButtonUrlType = UrlType.JavaScript;
                HeadMenuWebControls1.ButtonList.Add(item2);
            }
        }

        #region "�������¼�"
        protected void Module_Main_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            sys_ModuleTable s_Mt = (sys_ModuleTable)e.Item.DataItem;
            //QueryParam qp = new QueryParam();
            //qp.Orderfld = " M_OrderLevel ";
            //qp.OrderType = 0;
            //qp.Where = string.Format("Where M_Close=0 and M_ParentID ={0}", s_Mt.ModuleID);
            //int RecordCount = 0;
            //ArrayList lst = BusinessFacade.sys_ModuleList(qp, out RecordCount);
            List<sys_ModuleTable> lst = FrameWorkMenuTree.GetModuleAllLastIDs(s_Mt.ModuleID);
            if (lst.Count > 0)
            {
                Repeater Module_Sub = (Repeater)e.Item.FindControl("Module_Sub");
                Module_Sub.DataSource = lst;
                Module_Sub.DataBind();
            }
        }

        /// <summary>
        /// ���ģ���Ȩ�޼���
        /// </summary>
        /// <param name="moduleID">ģ��ID</param>
        /// <returns>����ģ��Ȩ���б�</returns>
        public List<sys_PermissionItem> GetPermissionList(int moduleID)
        {
            List<sys_PermissionItem> lst = new List<sys_PermissionItem>();
            lst.Add(new sys_PermissionItem("�鿴", 2, false));
            lst.Add(new sys_PermissionItem("����", 4, false));
            lst.Add(new sys_PermissionItem("�޸�", 8, false));
            lst.Add(new sys_PermissionItem("ɾ��", 16, false));
            lst.Add(new sys_PermissionItem("����", 32, false));
            lst.Add(new sys_PermissionItem("��ӡ", 64, false));
            lst.Add(new sys_PermissionItem("����A", 128, false));
            lst.Add(new sys_PermissionItem("����B", 256, false));
            /*
            int recordcount = 0;
            QueryParam qp = new QueryParam();
            qp.OrderType = 0;
            qp.Where = string.Format(" Where ModuleID={0}", moduleID);
             */
            List<sys_ModuleExtPermissionTable> ExtPermissionlst = sys_ModuleExtPermission_Cache.sys_ModuleExtPermissionList_Cache(moduleID); //BusinessFacade.sys_ModuleExtPermissionList(qp, out recordcount);
            if (ExtPermissionlst.Count > 0)
            {
                foreach (sys_ModuleExtPermissionTable var in ExtPermissionlst)
                {
                    lst.Add(new sys_PermissionItem(var.PermissionName, var.PermissionValue, false));
                }
            }
            return lst;
        }


        /// <summary>
        /// ���Ȩ����ʾ�ı�
        /// </summary>
        /// <param name="pagecode">ģ��Pagecode</param>
        /// <param name="permissionName">Ȩ������</param>
        /// <param name="permissionValue">Ȩ��ֵ</param>
        /// <param name="allow">�Ƿ�����</param>
        /// <returns>��ʾ�ı�</returns>
        public void FormatPermission(List<sys_PermissionItem> lst, string pagecode, int userpermissionValue)
        {


            string rightString = "";
            string wrongString = "";
            string dispString = "";
            string SelectTxt = "";
            string DisableCheckbox = "";

            foreach (sys_PermissionItem var in lst)
            {
                rightString = string.Format("<img src='{0}' align='absbottom'>{1}({2})", ResolveClientUrl("~/Manager/images/allow.gif"), var.PermissionName, var.PermissionValue);
                wrongString = string.Format("<img src='{0}'  align='absbottom'>{1}({2})", ResolveClientUrl("~/Manager/images/disable.gif"), var.PermissionName, var.PermissionValue);
                dispString = "";
                SelectTxt = "";
                DisableCheckbox = "";

                var.Allow = (userpermissionValue & var.PermissionValue) == var.PermissionValue;


                //�жϵ�ǰ��ɫ�����û��Ƿ����е�ǰȨ��
                if (!UserData.CheckPageCode(GetRoleUserID, ApplicationID, pagecode, var.PermissionValue))
                {
                    DisableCheckbox = "disabled";
                }
                else
                {
                    DisableCheckbox = "";
                }
                if (var.Allow)
                {
                    dispString = rightString;
                    SelectTxt = "checked";
                }
                else
                {
                    dispString = wrongString;
                    SelectTxt = "";
                }
                if (CMD == "Edit")
                {
                    dispString = string.Format("<input type=checkbox id='PageCode{0}' name='PageCode{0}' value='{1}'  {2} {3}>{4}", pagecode, var.PermissionValue, SelectTxt, DisableCheckbox, var.PermissionName);
                }
                var.DispTxt = dispString;
            }
        }

        protected void Module_Sub_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            sys_ModuleTable s_Mt = (sys_ModuleTable)e.Item.DataItem;
            //��õ�ǰ�趨��ɫȨ��
            sys_RolePermissionTable s_Rp = BusinessFacade.sys_RolePermissionDisp(RoleID, ApplicationID, s_Mt.M_PageCode);

            DataList dlist = (DataList)e.Item.FindControl("PermissionList");
            if (dlist != null)
            {

                List<sys_PermissionItem> lst = GetPermissionList(s_Mt.ModuleID);
                FormatPermission(lst, s_Mt.M_PageCode, s_Rp.P_Value);
                dlist.DataSource = lst;
                dlist.DataBind();
            }

            #region "ԭ�д���"
            /*
            string rightString = string.Format("<img src='{0}'>",ResolveClientUrl("~/Manager/images/right.gif"));
            string wrongString = string.Format("<img src='{0}'>",ResolveClientUrl("~/Manager/images/wrong.gif"));
            string dispString = "";
            string SelectTxt = "";
            string DisableCheckbox = "";
            int TempStep = 1;
            for (int i = 0; i < 8; i++)
            {
                TempStep = TempStep + TempStep;
                Literal li = (Literal)e.Item.FindControl(string.Format("Lab{0}_Txt",TempStep));
                if (li != null)
                {
                    //�жϵ�ǰ��ɫ�����û��Ƿ����е�ǰȨ��
                    if (!UserData.CheckPageCode(Common.Get_UserID, ApplicationID, s_Mt.M_PageCode, TempStep))
                    {
                        DisableCheckbox = "disabled";
                    }
                    else
                    {
                        DisableCheckbox = "";
                    }
                    if ((s_Rp.P_Value & TempStep) == TempStep)
                    {
                        dispString = rightString;
                        SelectTxt = "checked";
                    }
                    else
                    {
                        dispString = wrongString;
                        SelectTxt = "";
                    }
                    if (CMD == "Edit")
                    {
                        dispString = string.Format("<input type=checkbox id='PageCode{0}' name='PageCode{0}' value='{1}'  {2} {3}>", s_Mt.M_PageCode, TempStep, SelectTxt, DisableCheckbox);
                    }
                    li.Text = dispString;
                }
            }
            */
            #endregion

        }
        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            BusinessFacade.sys_RolePermission_Move(RoleID, ApplicationID);
            string TempPageCodeString = "";
            string[] ArrayInt;
            int PageCodeValue = 0;
            sys_RolePermissionTable s_Rt = new sys_RolePermissionTable();
            s_Rt.DB_Option_Action_ = "Insert";
            s_Rt.P_ApplicationID = ApplicationID;
            s_Rt.P_RoleID = RoleID;
            foreach (string var in Request.Form)
            {
                if (var.Length > 8)
                {

                    TempPageCodeString = var.Substring(0, 8);
                    if (TempPageCodeString == "PageCode")
                    {
                        PageCodeValue = 0;
                        TempPageCodeString = var.Substring(8, var.Length - 8);
                        ArrayInt = Request.Form[var].Split(',');
                        for (int i = 0; i < ArrayInt.Length; i++)
                        {
                            //�жϵ�ǰ�û��Ƿ����е�ǰȨ��
                            if (UserData.CheckPageCode(GetRoleUserID, ApplicationID, TempPageCodeString, Convert.ToInt32(ArrayInt[i])))
                            {
                                PageCodeValue = PageCodeValue + Convert.ToInt32(ArrayInt[i]);
                            }
                        }
                        s_Rt.P_PageCode = TempPageCodeString;
                        s_Rt.P_Value = PageCodeValue;
                        BusinessFacade.sys_RolePermissionInsertUpdate(s_Rt);

                    }

                }
            }
            UserData.Move_RoleUserPermissionCache(RoleID);

            UpdateRolesUserToRulesPermission(RoleID, ApplicationID);

            EventMessage.MessageBox(1, "�����ɹ�", string.Format("�޸Ľ�ɫ({0})Ӧ��({1})Ȩ�޳ɹ���", RoleID, ApplicationID), Icon_Type.OK, Common.GetHomeBaseUrl(string.Format("RolePermissionManager.aspx?RoleID={0}&ApplicationID={1}&CMD=Look", RoleID, ApplicationID)));

        }

        /// <summary>
        /// �޸Ľ�ɫ����û������Ľ�ɫȨ��
        /// </summary>
        /// <param name="roleid">�޸Ľ�ɫȨ��</param>
        /// <param name="applicationid">Ӧ��ID</param>
        protected void UpdateRolesUserToRulesPermission(int roleid, int applicationid)
        {

            ArrayList lst = BusinessFacade.sys_UserRolesList(roleid);
            foreach (sys_UserRolesTable var in lst)
            {
                foreach (sys_RolesTable varroles in BusinessFacade.sys_RolesList(var.R_UserID))
                {
                    UpdateUserRolesPermission(var.R_UserID, varroles.RoleID, applicationid);
                }
            }

        }

        /// <summary>
        /// �����û�������ɫȨ��
        /// </summary>
        /// <param name="userid">�û�ID</param>
        /// <param name="roleid">��ɫId</param>
        /// <param name="applicationid">Ӧ��ID</param>
        protected void UpdateUserRolesPermission(int userid, int roleid, int applicationid)
        {
            ArrayList lst = BusinessFacade.sys_RolePermission_GetList(applicationid, roleid);
            int Temp_P_Value = 0;
            foreach (sys_RolePermissionTable var in lst)
            {
                Temp_P_Value = 0;
                for (int i = 2; i <= var.P_Value; )
                {
                    if ((var.P_Value & i) == i)
                    {
                        if (UserData.CheckPageCode(userid, applicationid, var.P_PageCode, i))
                        {
                            Temp_P_Value = Temp_P_Value + i;
                        }
                    }
                    i = i * 2;
                }
                var.P_Value = Temp_P_Value;
                var.DB_Option_Action_ = "Update";
                BusinessFacade.sys_RolePermissionInsertUpdate(var);
                UserData.Move_RoleUserPermissionCache(roleid);
            }
        }
    }
}
