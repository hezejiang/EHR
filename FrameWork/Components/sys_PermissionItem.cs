/************************************************************************************
 *      Copyright (C) 2008 supesoft.com,All Rights Reserved						    *
 *      File:																		*
 *				sys_PermissionItem.cs                               		        	*
 *      Description:																*
 *				 Ȩ��Item           		           							    *
 *      Author:																		*
 *				Lzppcc														        *
 *				Lzppcc@hotmail.com													*
 *				http://www.supesoft.com												*
 *      Finish DateTime:															*
 *				2008��11��28��														*
 *      History:																	*
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork.Components
{
    /// <summary>
    /// Ȩ��Itemʵ����
    /// </summary>
    public class sys_PermissionItem
    {

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name"></param>
        /// <param name="namevalue"></param>
        /// <param name="allowvalue"></param>
        public sys_PermissionItem(string name,int namevalue,bool allowvalue)
        {
            _Allow = allowvalue;
            _PermissionName = name;
            _PermissionValue = namevalue;
        }

        private string _PermissionName;

        /// <summary>
        /// Ȩ������
        /// </summary>
        public string PermissionName
        {
            get { return _PermissionName; }
            set { _PermissionName = value; }
        }

        private int _PermissionValue;

        /// <summary>
        /// Ȩ��ֵ
        /// </summary>
        public int PermissionValue
        {
            get { return _PermissionValue; }
            set { _PermissionValue = value; }
        }
                
        private bool _Allow;

        /// <summary>
        /// �Ƿ�����ǰȨ��
        /// </summary>
        public bool Allow
        {
            get { return _Allow; }
            set { _Allow = value; }
        }

        private string _DispTxt;

        /// <summary>
        /// ������ʾ�ı�
        /// </summary>
        public string DispTxt
        {
            get { return _DispTxt; }
            set { _DispTxt = value; }
        }

    }
}
