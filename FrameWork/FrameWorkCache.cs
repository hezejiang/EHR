/*
       Copyright (C) 2008 supesoft.com,All Rights Reserved						    
       File:																		
 				FrameWorkOnline.cs                                              			*
       Description:																
 				FrameWork������
       Author:																													
 				http://www.supesoft.com												
       Finish DateTime:															
 				2008��10��12��														
       History:																	
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork
{
    /// <summary>
    /// FrameWork������
    /// </summary>
    public class FrameWorkCache
    {
        private static IFrameWorkCache _FrameWorkCache = null;

        static FrameWorkCache()
        {
            _FrameWorkCache = (IFrameWorkCache)Activator.CreateInstance(Common.GetCachenamespace, Common.GetCacheclassName).Unwrap();
        }

        /// <summary>
        /// �����û��ӿ�
        /// </summary>
        /// <returns>IFrameWorkOnlineʵ����</returns>
        public static IFrameWorkCache Instance()
        {
            return _FrameWorkCache;
        }
    }
}
