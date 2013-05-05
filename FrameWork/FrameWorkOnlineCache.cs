/*
       Copyright (C) 2008 supesoft.com,All Rights Reserved						    
       File:																		
 				FrameWorkOnlineCache.cs                                              			*
       Description:																
 				 �����û����洦����
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

using FrameWork.Components;

namespace FrameWork
{
    /// <summary>
    /// �����û����洦����
    /// </summary>
    public class FrameWorkOnlineCache:IFrameWorkOnline
    {

        /// <summary>
        /// ɾ�������û�
        /// </summary>
        /// <param name="username">�û���</param>
        /// <param name="sessionid">�û�sessionid</param>
        public void OnlineRemove(string username, string sessionid)
        {
            UserOnlineList.Remove(sessionid);
        }

        /// <summary>
        /// ��⵱ǰ�û��Ƿ�����
        /// </summary>
        /// <param name="username">�û���</param>
        /// <param name="sessionid">�û�Ψһ��ʶ</param>
        /// <returns>��/��</returns>
        public bool CheckUserInOnline(string username, string sessionid)
        {
            return UserOnlineList.CheckKeyOnline(sessionid);
        }

        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="username">�û���</param>
        public void InsertOnlineUser(string username)
        {
            UserOnlineList.Remove(Common.GetSessionID);
            OnlineUser<string> us = new OnlineUser<string>();
            us.U_Guid = Common.GetSessionID;
            us.U_Name = username;
            us.U_Type = true;
            us.U_LastUrl = Common.GetScriptUrl;
            UserOnlineList.InsertUser(us.U_Guid, us);
        }

        /// <summary>
        /// �����б�
        /// </summary>
        private CacheOnline<string, OnlineUser<string>> UserOnlineList
        {
            get {
                object o = FrameWorkCache.Instance()["FrameWorkCache_OnlineList"];
                if (o == null)
                {
                    CacheOnline<string, OnlineUser<string>> _OnlineCache = new CacheOnline<string, OnlineUser<string>>(Common.OnlineMinute);
                    FrameWorkCache.Instance().Insert("FrameWorkCache_OnlineList", _OnlineCache);
                    return _OnlineCache;
                }
                else
                {
                    return o as CacheOnline<string, OnlineUser<string>>;
                }
            }
        }

        /// <summary>
        /// ����û��Ƿ�����
        /// </summary>
        /// <param name="username">�û���</param>
        /// <returns>��/��</returns>
        public bool OnlineCheck(string username)
        {
            return UserOnlineList.CheckMemberOnline(username.ToLower());
        }
        /// <summary>
        /// �����û�������ʱ��
        /// </summary>
        /// <param name="username">�û���</param>
        public void OnlineAccess(string username)
        {
            UserOnlineList.Access(Common.GetSessionID, Common.GetScriptUrl);
        }
        /// <summary>
        /// �Ƴ������û�
        /// </summary>
        /// <param name="username">�û���</param>
        public void OnlineRemove(string username)
        {
            UserOnlineList.RemoveUserName(username);
        }
        /// <summary>
        /// ��������û���Ϣ
        /// </summary>
        /// <param name="username">�û���</param>
        /// <returns></returns>
        public OnlineUser<string> GetOnlineMember(string username)
        {
            return UserOnlineList.GetValue(username);
        }

        /// <summary>
        /// �����ʱ�����û�
        /// </summary>
        public void ClearOnlineUserTimeOut()
        {
            
        }
        /// <summary>
        /// ��������û�����
        /// </summary>
        public int GetOnlineUserNum
        {
            get
            {
                return UserOnlineList.MemberCount;
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
            totalnum = UserOnlineList.MemberCount;
            for (int i = (pageindex-1)*pagesize; i < pagesize*pagesize; i++)
            {
                if (i >= UserOnlineList.GetList.Count)
                    break;
                lst.Add(UserOnlineList.GetList[i]);
            }
            return lst;
        }

    }
}
