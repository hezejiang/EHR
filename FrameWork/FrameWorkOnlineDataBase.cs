/*
       Copyright (C) 2008 supesoft.com,All Rights Reserved						    
       File:																		
 				FrameWorkOnlineDataBase.cs                                              			*
       Description:																
 				 �����û����ݿ⴦����
       Author:																													
 				http://www.supesoft.com												
       Finish DateTime:															
 				2008��10��12��														
       History:																	
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using FrameWork.Components;

namespace FrameWork
{
    /// <summary>
    /// �����û����ݿ⴦����
    /// </summary>
    public class FrameWorkOnlineDataBase : IFrameWorkOnline
    {
        //��ʱ��
        Timer _ClearTimeOutUser;

        //����(10����)
        private int runtime = 60000 * Common.OnlineMinute;
        /// <summary>
        /// ���캯��
        /// </summary>
        public FrameWorkOnlineDataBase()
        {
            _ClearTimeOutUser = new Timer(new TimerCallback(statTimer_Elapsed), null, 0, runtime);
        }

        /// <summary>
        /// ��ʱ����ɾ������
        /// </summary>
        /// <param name="o"></param>
        private void statTimer_Elapsed(object o)
        {
            if (_ClearTimeOutUser != null)
            {
                _ClearTimeOutUser.Change(Timeout.Infinite, runtime);
                ClearOnlineUserTimeOut();
                _ClearTimeOutUser.Change(runtime, runtime);

            }
            else
            {
                _ClearTimeOutUser = new Timer(new TimerCallback(statTimer_Elapsed), null, 0, runtime);
            }
        }

        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="username">�û���</param>
        public void InsertOnlineUser(string username)
        {
            BusinessFacade.RemoveMemberOnline(Common.GetSessionID);
            BusinessFacade.InsertMemberOnline(username, Common.GetSessionID);
        }

        /// <summary>
        /// ����û��Ƿ�����
        /// </summary>
        /// <param name="username">�û���</param>
        /// <returns>��/��</returns>
        public bool OnlineCheck(string username)
        {
            if (BusinessFacade.sys_OnlineDisp(username).OnlineID == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// �����û�������ʱ��
        /// </summary>
        /// <param name="username">�û���</param>
        public void OnlineAccess(string username)
        {
            sys_OnlineTable online = BusinessFacade.sys_OnlineDisp(username);
            online.O_LastTime = DateTime.Now;
            online.O_LastUrl = Common.GetScriptUrl;
            online.DB_Option_Action_ = "Update";
            BusinessFacade.sys_OnlineInsertUpdate(online);
        }
        /// <summary>
        /// �Ƴ������û�
        /// </summary>
        /// <param name="username">�û���</param>
        public void OnlineRemove(string username)
        {
            sys_OnlineTable online = BusinessFacade.sys_OnlineDisp(username);
            online.DB_Option_Action_ = "Delete";
            BusinessFacade.sys_OnlineInsertUpdate(online);
        }
        /// <summary>
        /// ��������û���Ϣ
        /// </summary>
        /// <param name="username">�û���</param>
        /// <returns></returns>
        public OnlineUser<string> GetOnlineMember(string username)
        {
            sys_OnlineTable online = BusinessFacade.sys_OnlineDisp(username);
            OnlineUser<string> ou = new OnlineUser<string>();
            ou.U_Guid = online.O_SessionID;
            ou.U_LastIP = online.O_Ip;
            ou.U_LastTime = online.O_LastTime;
            ou.U_LastUrl = online.O_LastUrl;
            ou.U_Name = online.O_UserName;
            ou.U_StartTime = online.O_LoginTime;
            TimeSpan ts = ou.U_LastTime - ou.U_StartTime;
            ou.U_OnlineSeconds = ts.TotalSeconds;
            ou.U_Type = true;

            return ou;
        }

        /// <summary>
        /// �����ʱ�����û�
        /// </summary>
        public void ClearOnlineUserTimeOut()
        {
            QueryParam qp = new QueryParam();
            if (Common.GetDBType == "Access")
            {
                qp.Where = string.Format("Where O_LastTime<=#{0}#", Common.FormatDateToString(DateTime.Now.AddMinutes((Common.OnlineMinute * -1))));
            }
            else if (Common.GetDBType == "Oracle")
            {
                qp.Where = string.Format("Where O_LastTime<=to_date('{0}','yyyy-mm-dd HH24:MI:SS')", Common.FormatDateToString(DateTime.Now.AddMinutes((Common.OnlineMinute * -1))));
            }
            else
            {
                qp.Where = string.Format("Where O_LastTime<='{0}'", Common.FormatDateToString(DateTime.Now.AddMinutes((Common.OnlineMinute * -1))));
            }
            qp.PageSize = int.MaxValue;
            int rInt = 0;
            ArrayList lst = BusinessFacade.sys_OnlineList(qp, out rInt);
            if (rInt > 0)
            {
                foreach (sys_OnlineTable var in lst)
                {
                    var.DB_Option_Action_ = "Delete";
                    BusinessFacade.sys_OnlineInsertUpdate(var);
                }
            }
        }
        /// <summary>
        /// ��������û�����
        /// </summary>
        public int GetOnlineUserNum
        {
            get
            {
                int rInt = 0;
                BusinessFacade.sys_OnlineList(new QueryParam(), out rInt);
                return rInt;
            }
        }
        /// <summary>
        /// ��������û�����
        /// </summary>
        /// <param name="pageindex">ҳ��</param>
        /// <param name="pagesize">ҳ��С</param>
        /// <param name="totalnum">��¼����</param>
        /// <returns>�б���</returns>
        public List<OnlineUser<string>> GetOnlineList(int pageindex, int pagesize, out int totalnum)
        {
            List<OnlineUser<string>> lst = new List<OnlineUser<string>>();
            QueryParam qp = new QueryParam();
            qp.PageIndex = pageindex;
            qp.PageSize = pagesize;
            int RecordCount = 0;
            ArrayList lst1 = BusinessFacade.sys_OnlineList(qp, out RecordCount);
            foreach (sys_OnlineTable var in lst1)
            {
                OnlineUser<string> ou = new OnlineUser<string>();
                ou.U_Guid = var.O_SessionID;
                ou.U_LastIP = var.O_Ip;
                ou.U_LastTime = var.O_LastTime;
                ou.U_LastUrl = var.O_LastUrl;
                ou.U_Name = var.O_UserName;
                ou.U_StartTime = var.O_LoginTime;
                TimeSpan ts = ou.U_LastTime - ou.U_StartTime;
                ou.U_OnlineSeconds = ts.TotalSeconds;
                ou.U_Type = true;
                lst.Add(ou);
            }
            totalnum = RecordCount;
            return lst;
        }


        /// <summary>
        /// ��⵱ǰ�û��Ƿ�����
        /// </summary>
        /// <param name="username">�û���</param>
        /// <param name="sessionid">�û�Ψһ��ʶ</param>
        /// <returns>��/��</returns>
        public bool CheckUserInOnline(string username, string sessionid)
        {
            if (BusinessFacade.sys_OnlineDisp(username,sessionid).OnlineID == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// ɾ�������û�
        /// </summary>
        /// <param name="username">�û���</param>
        /// <param name="sessionid">�û�sessionid</param>
        public void OnlineRemove(string username, string sessionid)
        {
            sys_OnlineTable so =  BusinessFacade.sys_OnlineDisp(username, sessionid);
            so.DB_Option_Action_ = "Delete";
            BusinessFacade.sys_OnlineInsertUpdate(so);
        }
    }
}
