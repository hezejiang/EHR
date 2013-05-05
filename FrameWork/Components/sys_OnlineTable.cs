/************************************************************************************
 *      Copyright (C) 2008 supesoft.com,All Rights Reserved						    *
 *      File:																		*
 *				sys_OnlineTable.cs                               		        	*
 *      Description:																*
 *				 ��ť����           		           							    *
 *      Author:																		*
 *				Lzppcc														        *
 *				Lzppcc@hotmail.com													*
 *				http://www.supesoft.com												*
 *      Finish DateTime:															*
 *				2008��3��22��														*
 *      History:																	*
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork.Components
{
    /// <summary>
    /// ������Աʵ����
    /// </summary>
	public class sys_OnlineTable
	{


        #region "Private Variables"
        private string _DB_Option_Action_;  // �������� Insert:���� Update:�޸� Delete:ɾ�� 
        private int _OnlineID = 0;  // �Զ�ID
        private string _O_SessionID; //�û�SessionID
        private string _O_UserName;  // �û���
        private string _O_Ip; //�û�IP��ַ
        private DateTime _O_LoginTime = DateTime.MaxValue; // ��½ʱ��
        private DateTime _O_LastTime = DateTime.MaxValue; // ������ʱ��
        private string _O_LastUrl;  // ���������վ
        #endregion

        #region "Public Variables"
        /// <summary>
        /// �������� Insert:���� Update:�޸� Delete:ɾ�� 
        /// </summary>
        public string DB_Option_Action_
        {
            set { this._DB_Option_Action_ = value; }
            get { return this._DB_Option_Action_; }
        }

        /// <summary>
        /// �Զ�ID
        /// </summary>
        public int OnlineID
        {
            set { this._OnlineID = value; }
            get { return this._OnlineID; }
        }

        /// <summary>
        /// �û�SessionID
        /// </summary>
        public string O_SessionID
        {
            set { this._O_SessionID = value; }
            get { return this._O_SessionID; }
        }

        /// <summary>
        /// �û���
        /// </summary>
        public string O_UserName
        {
            set { this._O_UserName = value; }
            get { return this._O_UserName; }
        }

        /// <summary>
        /// �û�IP��ַ
        /// </summary>
        public string O_Ip
        {
            set { this._O_Ip = value; }
            get { return this._O_Ip; }
        }

        /// <summary>
        /// ��½ʱ��
        /// </summary>
        public DateTime O_LoginTime
        {
            set { this._O_LoginTime = value; }
            get { return this._O_LoginTime; }
        }

        /// <summary>
        /// ������ʱ��
        /// </summary>
        public DateTime O_LastTime
        {
            set { this._O_LastTime = value; }
            get { return this._O_LastTime; }
        }

        /// <summary>
        /// ���������վ
        /// </summary>
        public string O_LastUrl
        {
            set { this._O_LastUrl = value; }
            get { return this._O_LastUrl; }
        }

        #endregion
	
	
		
	}
}
