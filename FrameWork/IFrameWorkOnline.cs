/************************************************************************************
 *      Copyright (C) 2008 supesoft.com,All Rights Reserved						    *
 *      File:																		*
 *				IFrameWorkOnline.cs                                              			*
 *      Description:																*
 *				 �����û����ݽӿ�                 								    *
 *      Author:																		*
 *				http://www.supesoft.com												*
 *      Finish DateTime:															*
 *				2008��10��12��														*
 *      History:																	*
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork
{
    /// <summary>
    /// �����û��ӿ�
    /// </summary>
    public interface IFrameWorkOnline
    {
        /// <summary>
        /// ��⵱ǰ�û��Ƿ�����
        /// </summary>
        /// <param name="username">�û���</param>
        /// <param name="sessionid">�û�Ψһ��ʶ</param>
        /// <returns>��/��</returns>
        bool CheckUserInOnline(string username, string sessionid);

        /// <summary>
        /// ɾ�������û�
        /// </summary>
        /// <param name="username">�û���</param>
        /// <param name="sessionid">�û�sessionid</param>
        void OnlineRemove(string username, string sessionid);

        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="username">�û���</param>
        void InsertOnlineUser(string username);
        /// <summary>
        /// ����û����Ƿ�����
        /// </summary>
        /// <param name="username">�û���</param>
        /// <returns>��/��</returns>
        bool OnlineCheck(string username);
        /// <summary>
        /// �����û�������ʱ��
        /// </summary>
        /// <param name="username">�û���</param>
        void OnlineAccess(string username);
        /// <summary>
        /// �Ƴ������û�
        /// </summary>
        /// <param name="username">�û���</param>
        void OnlineRemove(string username);
        /// <summary>
        /// ��������û���Ϣ
        /// </summary>
        /// <param name="username">�û���</param>
        /// <returns></returns>
        OnlineUser<string> GetOnlineMember(string username);
        /// <summary>
        /// �����ʱ�����û�
        /// </summary>
        void ClearOnlineUserTimeOut();
        /// <summary>
        /// ��������û�����
        /// </summary>
        int GetOnlineUserNum { get;}
        /// <summary>
        /// ��������û�����
        /// </summary>
        /// <param name="pageindex">ҳ��</param>
        /// <param name="pagesize">ҳ��С</param>
        /// <param name="totalnum">��¼����</param>
        /// <returns>�б���</returns>
        List<OnlineUser<string>> GetOnlineList(int pageindex, int pagesize, out int totalnum);
    }
}
