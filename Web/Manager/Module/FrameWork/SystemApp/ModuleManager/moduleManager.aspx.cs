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

namespace FrameWork.web.Module.FrameWork.ModuleManager
{
    public partial class moduleManager : System.Web.UI.Page
    {
        public int S_ID;
        private string S_ID_Name;
        private int ModuleID;
        private string CMD;
        public string OrderByListItems_UniqueID;
        public int PermissionListCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            S_ID = (int)Common.sink("S_ID", MethodType.Get, 255, 1, DataType.Int);
            ModuleID = (int)Common.sink("ModuleID", MethodType.Get, 255, 1, DataType.Int);

            int ExtPermissionID = (int)Common.sink("ExtPermissionID", MethodType.Get, 11, 0, DataType.Int);
            if (ExtPermissionID != 0)
            {
                DeleteExtPermissionID(ExtPermissionID);
            }

            S_ID_Name = BusinessFacade.sys_ApplicationsDisp(S_ID).A_AppName;
            CMD = (string)Common.sink("CMD", MethodType.Get, 255, 0, DataType.Str);
            OrderByListItems_UniqueID = OrderByListItems.UniqueID.Replace("$", "_");
            Button2.OnClientClick = string.Format("selectAll({0})", OrderByListItems_UniqueID);
            SetMenu();


            if (!Page.IsPostBack)
            {
                FrameWorkPermission.CheckPagePermission(CMD);
                OnStart();
                //�ж��Ƿ�������Ȩ��
                if (!FrameWorkPermission.CheckButtonPermission(PopedomType.Orderby))
                    TabOptionItem3.Visible = false;
            }




        }


        private void SetMenu()
        {
            PermissionModuleName.Text = Title_Txt.Text = string.Format("{0}><a href='ModuleList.aspx?S_ID={3}&AppName={1}'>{1}</a>{2}", "<a href='List.aspx'>Ӧ���б�</a>", S_ID_Name, BusinessFacade.GetModuleTitle(ModuleID), S_ID);
            TabOptionItem1.Tab_Name = "Ӧ��ģ�����-" + S_ID_Name + "->�������";
            HeadMenuWebControls1.HeadOPTxt = S_ID_Name;

            HeadMenuButtonItem m1 = new HeadMenuButtonItem();
            m1.ButtonPopedom = PopedomType.List;
            m1.ButtonName = S_ID_Name + "ģ���б�";
            m1.ButtonIcon = "list.gif";
            m1.ButtonUrl = string.Format("ModuleList.aspx?S_ID={0}&AppName={1}", S_ID, S_ID_Name);
            HeadMenuWebControls1.ButtonList.Add(m1);

            //�ж��Ƿ�����������ģ�鰴ť
            if (CMD != "New" && ModuleID != 0)//&& SMT.M_OrderLevel.Substring(2, 2) == "00")
            {

                HeadMenuButtonItem m2 = new HeadMenuButtonItem();
                m2.ButtonName = "ģ��";
                m2.ButtonPopedom = PopedomType.New;
                m2.ButtonUrl = string.Format("?CMD=New&ModuleID={0}&S_ID={1}", ModuleID, S_ID);
                HeadMenuWebControls1.ButtonList.Add(m2);
            }

            //�ж��Ƿ����ӷ��ذ�ť
            if (!string.IsNullOrEmpty(CMD))
            {
                HeadMenuButtonItem m5 = new HeadMenuButtonItem();
                m5.ButtonIcon = "back.gif";
                m5.ButtonName = "����";
                m5.ButtonPopedom = PopedomType.List;
                m5.ButtonUrl = string.Format("?ModuleID={0}&S_ID={1}", ModuleID, S_ID);
                HeadMenuWebControls1.ButtonList.Add(m5);
            }
        }

        private void OnStart()
        {
            if (FrameWorkMenuTree.GetModuleLevel(ModuleID) >= 3)
            {
                MessageLit.Text = "<font color=red>����ģ�鳬��3��,ֻ�е��˵���ʽΪ\"�༶�˵�\"����������ʾ����!</font>";
            }

            if (CMD == string.Empty)
            {
                //TabOptionWebControls1.SelectIndex = 1;
                TabOptionItem3.Visible = true;
            }

            //�������
            sys_ModuleTable SMT = new sys_ModuleTable();
            SMT = BusinessFacade.sys_ModuleDisp(ModuleID);
            this.M_ApplicationID_Txt.Text = S_ID_Name;
            if (ModuleID == 0)
                this.M_PageCode.Text = SMT.M_PageCode;
            if (CMD == "New" && ModuleID != 0)
            {
                this.M_ParentID_Txt.Text = SMT.M_CName + "(" + SMT.M_PageCode + ")";
            }
            else
            {
                this.M_ParentID_Txt.Text = SMT.M_ParentID == 0 ? "��" : BusinessFacade.sys_ModuleDisp(SMT.M_ParentID).M_CName;
            }
            this.M_PageCode_Txt.Text = SMT.M_PageCode;
            this.M_CName_Txt.Text = SMT.M_CName;
            this.M_Directory_Txt.Text = SMT.M_Directory;
            this.M_IsSystem_Txt.Text = SMT.M_IsSystem == 0 ? "��" : "��";
            this.M_Close_Txt.Text = SMT.M_Close == 0 ? "��" : "��";
            this.M_Icon_Txt.Text = SMT.M_Icon;

            if (CMD == "Edit")
            {
                this.M_PageCode.Text = SMT.M_PageCode;
                this.M_CName.Text = SMT.M_CName;
                this.M_Directory.Text = SMT.M_Directory;
                this.M_Icon.Text = SMT.M_Icon;
                ListItem ditem1 = this.M_IsSystem.Items.FindByValue(SMT.M_IsSystem.ToString());
                if (ditem1 != null)
                    ditem1.Selected = true;
                ListItem ditem2 = this.M_Close.Items.FindByValue(SMT.M_Close.ToString());
                if (ditem2 != null)
                    ditem2.Selected = true;
            }

            //����ģ��
            QueryParam qp = new QueryParam();
            qp.Orderfld = " M_Applicationid,M_OrderLevel ";
            qp.OrderType = 0;
            qp.Where = string.Format("Where M_ParentID={0} and M_Applicationid={1}", ModuleID, S_ID);
            int RecordCount = 0;
            ArrayList lst = BusinessFacade.sys_ModuleList(qp, out RecordCount);
            GridView1.DataSource = lst;
            GridView1.DataBind();

            //������
            OrderByListItems.DataSource = lst;
            OrderByListItems.DataTextField = "M_CName";
            OrderByListItems.DataValueField = "ModuleID";
            OrderByListItems.DataBind();
            if (lst.Count > 0)
                OrderByListItems.Rows = lst.Count;

            //�ж��Ƿ���������
            if (CMD == "New" || CMD == "Edit")
                HiddenDisp();
            else
            {
                HiddenInput();
                SubmitTr.Visible = false;
            }



            //if (ModuleID !=0 && SMT.M_OrderLevel.Substring(2, 2) != "00")
            //{
            //    TabOptionWebControls1.SelectIndex = 0;
            //    TabOptionItem2.Visible = false;
            //    TabOptionItem3.Visible = false;

            //    if (CMD!="New" && CMD!="Edit")
            //        TabOptionItem4.Visible = true;

            //    BindPermissionList();
            //    if (CMD == "Edit")
            //    {
            //        HeadMenuButtonItem m5 = new HeadMenuButtonItem();
            //        m5.ButtonIcon = "back.gif";
            //        m5.ButtonName = "����";
            //        m5.ButtonPopedom = PopedomType.List;
            //        m5.ButtonUrl = string.Format("?ModuleID={0}&S_ID={1}", ModuleID, S_ID);
            //        HeadMenuWebControls1.ButtonList.Add(m5);
            //    }
            //}




            //�����޸İ�ť
            if (ModuleID != 0 && CMD == "")
            {
                HeadMenuButtonItem m3 = new HeadMenuButtonItem();
                m3.ButtonName = "ģ��";
                m3.ButtonPopedom = PopedomType.Edit;
                m3.ButtonUrl = string.Format("?CMD=Edit&ModuleID={0}&S_ID={1}", ModuleID, S_ID);
                HeadMenuWebControls1.ButtonList.Add(m3);

                
                //if (FrameWorkMenuTree.CheckModuleLastLevel(ModuleID))
                if (BusinessFacade.GetSuBCount(ModuleID)==0)
                {
                    HeadMenuButtonItem m6 = new HeadMenuButtonItem();
                    m6.ButtonName = "�趨ģ����չȨ��";
                    m6.ButtonIcon = "b.gif";
                    m6.ButtonPopedom = PopedomType.Edit;
                    m6.ButtonUrl = string.Format("?CMD=ExtPermission&ModuleID={0}&S_ID={1}", ModuleID, S_ID);
                    HeadMenuWebControls1.ButtonList.Add(m6);
                }
            }

            //����ɾ����ť
            if (CMD == "Edit")
            {
                HeadMenuButtonItem m4 = new HeadMenuButtonItem();
                m4.ButtonPopedom = PopedomType.Delete;
                m4.ButtonUrl = string.Format("DelData('?CMD=Delete&S_ID={0}&ModuleID={1}')", S_ID, ModuleID);
                m4.ButtonUrlType = UrlType.JavaScript;
                HeadMenuWebControls1.ButtonList.Add(m4);
            }

            //�ж��Ƿ�ִ��ɾ��
            if (CMD == "Delete")
            {
                SMT.DB_Option_Action_ = "Delete";
                if (SMT.M_IsSystem != 1)
                {
                    BusinessFacade.DeleteModule(ModuleID);

                }
                sys_Module_Cache.ReLoadCache(); //���¼���ģ�黺��
                EventMessage.MessageBox(1, "�����ɹ�", "ɾ����¼ID:(" + ModuleID + ")�ɹ���", Icon_Type.OK, Common.GetHomeBaseUrl(string.Format("ModuleList.aspx?S_ID={0}&AppName={1}", S_ID, S_ID_Name)));
            }

            //Button1.Attributes.Add("Onclick", "javascript:return checkForm(aspnetForm);");



            if (CMD == "ExtPermission")
            {
                TabOptionItem2.Visible = false;
                TabOptionItem4.Visible = true;
                TabOptionWebControls1.SelectIndex = 3;
                BindPermissionList();
            }
        }


        private void HiddenDisp()
        {
            this.M_PageCode_Txt.Visible = false;
            this.M_CName_Txt.Visible = false;
            this.M_Directory_Txt.Visible = false;
            this.M_IsSystem_Txt.Visible = false;
            this.M_Close_Txt.Visible = false;
            this.M_Icon_Txt.Visible = false;
        }

        private void HiddenInput()
        {
            this.M_PageCode.Visible = false;
            this.M_CName.Visible = false;
            this.M_Directory.Visible = false;
            this.M_IsSystem.Visible = false;
            this.M_Close.Visible = false;
            this.M_Icon.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sys_ModuleTable smt = new sys_ModuleTable();
            smt = BusinessFacade.sys_ModuleDisp(ModuleID);
            string OldPageCode = smt.M_PageCode;
            smt.M_ApplicationID = S_ID;
            smt.M_Close = (int)Common.sink(this.M_Close.UniqueID, MethodType.Post, 255, 1, DataType.Int);
            smt.M_CName = (string)Common.sink(this.M_CName.UniqueID, MethodType.Post, 50, 1, DataType.Str);
            smt.M_Directory = (string)Common.sink(this.M_Directory.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            smt.M_Icon = (string)Common.sink(this.M_Icon.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            //smt.M_IsSystem = (int) Common.sink(this.M_IsSystem.UniqueID,MethodType.Post,255,1,DataType.Int);
            smt.M_PageCode = (string)Common.sink(this.M_PageCode.UniqueID, MethodType.Post, 6, 1, DataType.CharAndNum);
            if (CMD == "New")
            {
                if (BusinessFacade.sys_Module_CheckPK(smt.M_ApplicationID, smt.M_PageCode, 0))
                    EventMessage.MessageBox(1, "�����������", string.Format("������ͬ��ģ�����({0})", smt.M_PageCode)
                                           , Icon_Type.Error, "history.back()", UrlType.JavaScript);

                QueryParam qp = new QueryParam();
                qp.Orderfld = "M_OrderLevel";
                qp.PageIndex = 1;
                qp.PageSize = 1;
                qp.Where = string.Format("Where M_ParentID={0} and M_Applicationid={1}", ModuleID, S_ID);
                int RecordCount = 0;
                ArrayList lst = BusinessFacade.sys_ModuleList(qp, out RecordCount);
                if (ModuleID == 0)
                {
                    if (RecordCount != 0)
                        RecordCount = Convert.ToInt32(((sys_ModuleTable)lst[0]).M_OrderLevel.Substring(0, 2)) + 1;
                    smt.M_OrderLevel = Common.FillZero(RecordCount.ToString(), 2) + "00";
                }
                else
                {
                    if (RecordCount != 0)
                        RecordCount = Convert.ToInt32(((sys_ModuleTable)lst[0]).M_OrderLevel.Substring(2, 2));
                    RecordCount++;
                    smt.M_OrderLevel = smt.M_OrderLevel.Substring(0, 2) + Common.FillZero(RecordCount.ToString(), 2);
                }
                smt.M_ParentID = ModuleID;
                smt.DB_Option_Action_ = "Insert";
            }
            else if (CMD == "Edit")
            {
                if (BusinessFacade.sys_Module_CheckPK(smt.M_ApplicationID, smt.M_PageCode, ModuleID))
                    EventMessage.MessageBox(1, "�����������", string.Format("������ͬ��ģ�����({0})", smt.M_PageCode)
                                           , Icon_Type.Error, "history.back()", UrlType.JavaScript);
                smt.DB_Option_Action_ = "Update";
            }
            smt.ModuleID = ModuleID;
            if (smt.M_IsSystem != 1)
                BusinessFacade.sys_ModuleInsertUpdate(smt);
            if (!string.IsNullOrEmpty(OldPageCode) && OldPageCode != smt.M_PageCode)
            {
                //�������PageCode�����û���Ȩ��.
                BusinessFacade.sys_RolePermission_DeleteForm(smt.M_ApplicationID, OldPageCode);
            }
            sys_Module_Cache.ReLoadCache(); //���¼���ģ�黺��
            EventMessage.MessageBox(1, "�����ɹ�", string.Format("����/�޸�ģ��ID({0})�ɹ�!", ModuleID), Icon_Type.OK, Common.GetHomeBaseUrl(string.Format("ModuleManager.aspx?ModuleID={0}&S_ID={1}", ModuleID, S_ID)));


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FrameWorkPermission.CheckPermissionVoid(PopedomType.Orderby);
            string ItemsList = (string)Common.sink(OrderByListItems.UniqueID, MethodType.Post, 100000, 1, DataType.Str);
            if (ItemsList.Length > 0)
            {
                string[] ItemsLists = ItemsList.Split(',');
                for (int i = 0; i < ItemsLists.Length; i++)
                {

                    if (Common.GetDBType == "Oracle")
                        BusinessFacade.Update_Table_Fileds("sys_Module", string.Format("M_OrderLevel=substr(M_OrderLevel,1,2) || '{0}'", Common.FillZero((i + 1).ToString(), 2)), string.Format("ModuleID={0}", ItemsLists[i]));
                    else
                        BusinessFacade.Update_Table_Fileds("sys_Module", string.Format("M_OrderLevel=left(M_OrderLevel,2)+'{0}'", Common.FillZero((i + 1).ToString(), 2)), string.Format("ModuleID={0}", ItemsLists[i]));
                }
            }
            sys_Module_Cache.ReLoadCache(); //���¼���ģ�黺��
            EventMessage.MessageBox(1, "�����ɹ�", string.Format("������ģ��ɹ�!"), Icon_Type.OK, Common.GetHomeBaseUrl(string.Format("ModuleManager.aspx?ModuleID={0}&S_ID={1}", ModuleID, S_ID)));
        }


        public string GetStatus(int ID)
        {
            return BusinessFacade.GetStatus(ID);
        }

        [PopedomTypeAttaible(PopedomType.New)]
        [System.Security.Permissions.PrincipalPermission(System.Security.Permissions.SecurityAction.Demand, Role = "OR")]
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!FrameWorkMenuTree.CheckModuleLastLevel(ModuleID))
                return;
            string PermissionName_Value = (string)Common.sink(PermissionName.UniqueID, MethodType.Post, 100, 1, DataType.Str);
            sys_ModuleExtPermissionTable st = new sys_ModuleExtPermissionTable();
            st.DB_Option_Action_ = "Insert";
            st.ModuleID = ModuleID;
            st.PermissionName = PermissionName_Value;
            st.PermissionValue = BusinessFacade.sys_ModuleExtPermissionGetLastPermissionValue(ModuleID);
            if (st.PermissionValue == 0)
                EventMessage.MessageBox(1, "����ʧ��", string.Format("�����Զ���Ȩ��ʧ��,Ȩ��ֵ�Ѿ��ﵽ���ֵ,�޷�������!"), Icon_Type.Alert, Common.GetHomeBaseUrl(string.Format("ModuleManager.aspx?cmd=ExtPermission&S_ID={0}&ModuleID={1}", S_ID, ModuleID)));
            int returnint = BusinessFacade.sys_ModuleExtPermissionInsertUpdate(st);

            if (returnint < 0)
            {
                EventMessage.MessageBox(1, "����ʧ��", string.Format("�����Զ���Ȩ��ʧ��!"), Icon_Type.Error, Common.GetHomeBaseUrl(string.Format("ModuleManager.aspx?cmd=ExtPermission&S_ID={0}&ModuleID={1}", S_ID, ModuleID)));
            }
            sys_ModuleExtPermission_Cache.ReLoadCache();
            TabOptionWebControls1.SelectIndex = 3;
            BindPermissionList();
        }

        /// <summary>
        /// �󶨵�ǰģ���Զ���Ȩ��
        /// </summary>
        protected void BindPermissionList()
        {
            //int recordcount = 0;
            QueryParam qp = new QueryParam();
            qp.Where = string.Format("Where ModuleID={0}", ModuleID);
            qp.Orderfld = "PermissionValue";
            qp.OrderType = 0;
            qp.PageIndex = 1;
            qp.PageSize = int.MaxValue;
            ArrayList lst = BusinessFacade.sys_ModuleExtPermissionList(qp, out PermissionListCount);
            Repeater1.DataSource = lst;
            Repeater1.DataBind();
        }


        public string GetDeleteurl(int i, int extPermissionID)
        {
            if (i == PermissionListCount && FrameWorkPermission.CheckButtonPermission(PopedomType.Delete))
            {
                return string.Format("<a href='javascript:;' onclick=\"javascript:DelData('ModuleManager.aspx?S_ID={0}&ModuleID={1}&ExtPermissionID={2}');\">ɾ��</a>", S_ID, ModuleID, extPermissionID);
            }
            else
                return "";
        }

        /// <summary>
        /// ɾ����չȨ��ID
        /// </summary>
        /// <param name="extPermissionID">��չȨ��ID</param>
        [PopedomTypeAttaible(PopedomType.Delete)]
        [System.Security.Permissions.PrincipalPermission(System.Security.Permissions.SecurityAction.Demand, Role = "OR")]
        protected void DeleteExtPermissionID(int extPermissionID)
        {
            if (!FrameWorkMenuTree.CheckModuleLastLevel(ModuleID))
                return;
            sys_ModuleExtPermissionTable se = new sys_ModuleExtPermissionTable();
            se.DB_Option_Action_ = "Delete";
            se.ExtPermissionID = extPermissionID;
            BusinessFacade.sys_ModuleExtPermissionInsertUpdate(se);
            sys_ModuleExtPermission_Cache.ReLoadCache();
            EventMessage.MessageBox(1, "�����ɹ�", "ɾ����չȨ�޳ɹ�!", Icon_Type.OK, Common.GetHomeBaseUrl(string.Format("ModuleManager.aspx?cmd=ExtPermission&S_ID={0}&ModuleID={1}", S_ID, ModuleID)));
        }
    }
}