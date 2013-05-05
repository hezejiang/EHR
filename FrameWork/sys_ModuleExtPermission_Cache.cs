/*
    Copyright (C) 2009 supesoft.com,All Rights Reserved						    
    File:																		
		    sys_ModuleExtPermission_Cache.cs	                                           			
    Description:																
		     ��չȨ�ޱ�ṹ������												    
    Author:																		
		    Lzppcc														        
		    Lzppcc@hotmail.com													
		    http://www.supesoft.com	
            QQ:6276841
    Finish DateTime:															
		    2009��7��25��														
    History:																	
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FrameWork.Components;
using FrameWork.Data;

namespace FrameWork
{
    delegate void sysModuleExtCacheDelegate(sys_ModuleExtPermissionTable extData);
    /// <summary>
    /// ��չȨ�ޱ�ṹ������
    /// </summary>
    public class sys_ModuleExtPermission_Cache
    {
        readonly static string key = string.Format("Table-{0}-{1}", "sys_ModuleExtPermission", "Cache");
        readonly static string KeyModule = string.Format("Table-{0}-{1}", "sys_ModuleExtPermission", "CacheModule");
        /// <summary>
        /// ��ʼ������
        /// </summary>
        static sys_ModuleExtPermission_Cache()
        {

            FrameWorkCache.Instance().Insert(key, new Dictionary<int, sys_ModuleExtPermissionTable>());
            FrameWorkCache.Instance().Insert(KeyModule, new Dictionary<int, List<sys_ModuleExtPermissionTable>>());
            Load_ModuleExtCache(set_ModuleExtCache);
        }

        /// <summary>
        /// ��ȡģ����չȨ��
        /// </summary>
        /// <param name="moduleExtdelegate"></param>
        static void Load_ModuleExtCache(sysModuleExtCacheDelegate moduleExtdelegate)
        {
            sys_ModuleExtCache.Clear();
            sys_ModuleExtListCache.Clear();

            int rCount = 0;
            ArrayList lst = BusinessFacade.sys_ModuleExtPermissionList(new QueryParam(), out rCount);
            if (lst.Count > 0)
            {
                foreach (sys_ModuleExtPermissionTable var in lst)
                {
                    moduleExtdelegate(var);
                }
            }
        }

        /// <summary>
        /// ����ģ��id��ȡ��չȨ���б�
        /// </summary>
        /// <param name="moduleid">ģ��id</param>
        /// <returns>Ȩ���б�</returns>
        public static List<sys_ModuleExtPermissionTable> sys_ModuleExtPermissionList_Cache(int moduleid)
        {
            if (sys_ModuleExtListCache.ContainsKey(moduleid))
            {
                return sys_ModuleExtListCache[moduleid];
            }
            return new List<sys_ModuleExtPermissionTable>();
        }


        /// <summary>
        /// ���¼��ػ���
        /// </summary>
        public static void ReLoadCache()
        {

            Load_ModuleExtCache(set_ModuleExtCache);
        }

        /// <summary>
        /// ������չģ�黺��
        /// </summary>
        /// <param name="sm"></param>
        static void set_ModuleExtCache(sys_ModuleExtPermissionTable sm)
        {
            sys_ModuleExtCache.Add(sm.ExtPermissionID, sm);
            if (sys_ModuleExtListCache.ContainsKey(sm.ModuleID))
            {
                sys_ModuleExtListCache[sm.ModuleID].Add(sm);
            }
            else
            {
                List<sys_ModuleExtPermissionTable> lst = new List<sys_ModuleExtPermissionTable>();
                lst.Add(sm);
                sys_ModuleExtListCache.Add(sm.ModuleID, lst);
            }
        }


        static Dictionary<int, sys_ModuleExtPermissionTable> sys_ModuleExtCache
        {
            get
            {
                return (Dictionary<int, sys_ModuleExtPermissionTable>)FrameWorkCache.Instance()[key];
            }
        }

        static Dictionary<int, List<sys_ModuleExtPermissionTable>> sys_ModuleExtListCache
        {
            get
            {
                return (Dictionary<int, List<sys_ModuleExtPermissionTable>>)FrameWorkCache.Instance()[KeyModule];
            }
        }
    }
}
