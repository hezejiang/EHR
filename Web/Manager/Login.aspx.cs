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


namespace FrameWork.web
{
    public partial class Login : System.Web.UI.Page
    {
        public string FrameName;
        public string FrameNameVer;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //��������û�
                FrameWorkOnline.Instance().ClearOnlineUserTimeOut();
            }

            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Response.Redirect("default.aspx");
            }
            FrameName = FrameSystemInfo.GetSystemInfoTable.S_Name;
            FrameNameVer = FrameSystemInfo.GetSystemInfoTable.S_Version;

            //Button1.Attributes.Add("Onclick", "javascript:return checkForm(ctl00);");
            string CMD = (string)Common.sink("CMD", MethodType.Get, 255, 0, DataType.Str);
            if (CMD == "OutOnline")
            {
                string U_LoginName = (string)Common.sink("U_LoginName", MethodType.Get, 20, 1, DataType.Str);
                string U_Password = (string)Common.sink("U_Password", MethodType.Get, 50, 1, DataType.Str);
                string OPCode = (string)Common.sink("OPCode", MethodType.Get, 4, 4, DataType.Str);

                MessageBox MBx = new MessageBox();
                MBx.M_Type = 2;
                MBx.M_Title = "ǿ�����ߣ�";
                MBx.M_IconType = Icon_Type.Error;
                MBx.M_Body = "ǿ������ʧ��.��֤����Ч����ȷ�����������֤����Ч��";


                if (Session["CheckCode"] == null || OPCode.ToLower() != Session["CheckCode"].ToString())
                {
                    MBx.M_ButtonList.Add(new sys_NavigationUrl("����", "login.aspx", "�����ť����������֤�룡", UrlType.Href, true));
                }
                else
                {
                    QueryParam qp = new QueryParam();
                    qp.Where = string.Format(" Where U_StatUs=0 and  U_LoginName='{0}' and U_Password='{1}'", Common.inSQL(U_LoginName), Common.inSQL(Common.md5(U_Password,32)));
                    int iInt = 0;
                    ArrayList lst = BusinessFacade.sys_UserList(qp, out iInt);
                    if (iInt > 0)
                    {
                        //FrameWorkPermission.UserOnlineList.RemoveUserName(U_LoginName.ToLower());
                        string sessionid = (string)Common.sink("SessionID", MethodType.Get, 24, 0, DataType.Str);
                        FrameWorkOnline.Instance().OnlineRemove(sessionid);
                        MBx.M_IconType = Icon_Type.OK;
                        MBx.M_Body = string.Format("ǿ���ʺ�{0}���߳ɹ���", U_LoginName);
                        //д��ǿ���ʺ�������־
                        EventMessage.EventWriteDB(2, MBx.M_Body, ((sys_UserTable)lst[0]).UserID);
                        LoginUser(U_LoginName, U_Password, OPCode, UserKey);
                        //MBx.M_ButtonList.Add(new sys_NavigationUrl("����", "login.aspx", "", UrlType.Href, true));
                        //�����û�Ϊ��½״̬

                    }
                    else
                    {
                        MBx.M_Body = "ǿ������ʧ��.�û���/������Ч��";
                        MBx.M_ButtonList.Add(new sys_NavigationUrl("����", "login.aspx", "", UrlType.Href, true));
                    }

                }
                Session["CheckCode"] = Common.RndNum(4);
                EventMessage.MessageBox(MBx);


            }

            if (!DispCode)
            {
                Logincode_op.Src = "images/Logon/Logon_7no.gif";
                inputcode_op.Visible = false;
            }


        }

        /// <summary>
        /// �Ƿ���ʾ��֤��(����6��,������֤��)
        /// </summary>
        private bool DispCode
        {
            get {
                if (FrameWorkLogin.GetLoginUserError(UserKey) > 5)
                    return true;
                else
                    return false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginUser(sLoginName, sLoginPass, sCode_op,UserKey);
        }

        /// <summary>
        /// ���е�½����
        /// </summary>
        /// <param name="sLoginName">�û���</param>
        /// <param name="sLoginPass">����</param>
        /// <param name="sCode_op">��֤��</param>
        /// <param name="UserKey">�û�key</param>
        private void LoginUser(string sLoginName, string sLoginPass, string sCode_op, string UserKey)
        {
            MessageBox MBx = new MessageBox();
            MBx.M_Type = 2;
            MBx.M_Title = "��½����";
            MBx.M_IconType = Icon_Type.Error;
            MBx.M_Body = "��֤����Ч����ȷ�����������֤����Ч��";

            if (DispCode && (Session["CheckCode"] == null || sCode_op != Session["CheckCode"].ToString()))
            {
                MBx.M_WriteToDB = false;
                MBx.M_ButtonList.Add(new sys_NavigationUrl("����", "login.aspx", "�����ť����������֤�룡", UrlType.Href, true));
            }
            else if (!FrameWorkLogin.CheckDisableLoginUser(UserKey))
            {
                MBx.M_Body = string.Format("��ǰIP:{0}��½�������({1})����ϵͳ����,�Ѿ���ֹ��½.����ϵ����Ա��", Common.GetIPAddress(), FrameSystemInfo.GetSystemInfoTable.S_SystemConfigData.C_LoginErrorMaxNum);
                MBx.M_ButtonList.Add(new sys_NavigationUrl("����", "login.aspx", "�����ť���أ�", UrlType.Href, true));

            }
            else if (new FrameWorkLogin().CheckLogin(sLoginName, sLoginPass, UserKey))
            {
                MBx.M_IconType = Icon_Type.OK;
                MBx.M_Title = "��½�ɹ���";
                MBx.M_Body = string.Format("��ӭ��{0}���ɹ����롣����IPΪ��{1}��", sLoginName, Common.GetIPAddress());
                MBx.M_WriteToDB = false;
                MBx.M_ButtonList.Add(new sys_NavigationUrl("ȷ��", "default.aspx", "�����ť��½��", UrlType.Href, true));
                FrameWorkLogin.MoveErrorLoginUser(UserKey);
                //д������־
                EventMessage.EventWriteDB(2, MBx.M_Body, UserData.Get_sys_UserTable(sLoginName).UserID);
            }
            else
            {
                MBx.M_Body = string.Format("�û���/����({0}/{1})����", sLoginName, sLoginPass);
                MBx.M_ButtonList.Add(new sys_NavigationUrl("����", "login.aspx", "�����ť�������룡", UrlType.Href, true));
            }
            Session["CheckCode"] = Common.RndNum(4);
            EventMessage.MessageBox(MBx);
        }

        /// <summary>
        /// ����û���½Key(����IP)
        /// </summary>
        string UserKey
        {
            get
            {
                return Common.GetIPAddress().Replace(".", "_");
            }
        }
        string sLoginName
        {
            get
            {
                return this.LoginName.Text.Trim();
            }
        }
        /// <summary>
        /// 32λ�û�����md5
        /// </summary>
        string sLoginPass
        {
            get
            {
                return this.LoginPass.Text.Trim();
            }
        }
        string sCode_op
        {
            get
            {
                return this.code_op.Text.Trim();
            }
        }

    }
}
