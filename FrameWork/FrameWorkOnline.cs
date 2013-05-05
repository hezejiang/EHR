/*
       Copyright (C) 2008 supesoft.com,All Rights Reserved						    
       File:																		
 				FrameWorkOnline.cs                                              			*
       Description:																
 				 �����û���
       Author:																													
 				http://www.supesoft.com												
       Finish DateTime:															
 				2008��10��12��														
       History:																	
*/
using System;
using System.Collections.Generic;
using System.Text;

using FrameWork.Components;

namespace FrameWork
{
    /// <summary>
    /// �����û���
    /// </summary>
    public class FrameWorkOnline
    {
        private static IFrameWorkOnline _Online = null;

        /// <summary>
        /// ���캯��
        /// </summary>
        static FrameWorkOnline()
        {
            IFrameWorkOnline online;
            if (Common.GetOnlineCountType == OnlineCountType.DataBase)
            {
                online = new FrameWorkOnlineDataBase();
            }
            else
            {
                online = new FrameWorkOnlineCache();
            }
            _Online = online;
        }

        /// <summary>
        /// �����û��ӿ�
        /// </summary>
        /// <returns>IFrameWorkOnlineʵ����</returns>
        public static IFrameWorkOnline Instance()
        {
            return _Online;
        }
    }
}
