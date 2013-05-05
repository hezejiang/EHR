/*
    Copyright (C) 2008 supesoft.com,All Rights Reserved
    File:
		    sys_ModuleExtPermissionTable.cs
    Description:
		     ģ����չȨ��ʵ����
    Author:
		    Lzppcc
		    Lzppcc@hotmail.com
		    http://www.supesoft.com
    Finish DateTime:
	    2008��11��23��
    History:
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork.Components
{
    /// <summary>
    /// ģ����չȨ��ʵ����
    /// </summary>
    public class sys_ModuleExtPermissionTable
    {


        #region "Private Variables"
        private string _DB_Option_Action_;  // �������� Insert:���� Update:�޸� Delete:ɾ�� 
        private int _ExtPermissionID = 0;  // ��չȨ��ID
        private int _ModuleID = 0;  // ģ��ID
        private string _PermissionName;  // Ȩ������
        private int _PermissionValue = 0;  // Ȩ��ֵ
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
        /// ��չȨ��ID
        /// </summary>
        public int ExtPermissionID
        {
            set { this._ExtPermissionID = value; }
            get { return this._ExtPermissionID; }
        }

        /// <summary>
        /// ģ��ID
        /// </summary>
        public int ModuleID
        {
            set { this._ModuleID = value; }
            get { return this._ModuleID; }
        }

        /// <summary>
        /// Ȩ������
        /// </summary>
        public string PermissionName
        {
            set { this._PermissionName = value; }
            get { return this._PermissionName; }
        }

        /// <summary>
        /// Ȩ��ֵ
        /// </summary>
        public int PermissionValue
        {
            set { this._PermissionValue = value; }
            get { return this._PermissionValue; }
        }

        #endregion
	
	
    }
}
