/*
    Copyright (C) 2009 supesoft.com,All Rights Reserved						    
    File:																		
		    sys_Module_Cache.cs	                                           			
    Description:																
		     ϵͳģ�黺��												    
    Author:																		
		    Lzppcc														        
		    Lzppcc@hotmail.com													
		    http://www.supesoft.com	
            QQ:6276841
    Finish DateTime:															
		    2009��7��26��														
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
    delegate void sysModuleCacheDelegate(sys_ModuleTable moduledata);
    /// <summary>
    /// ϵͳģ�黺��
    /// </summary>
    public class sys_Module_Cache
    {
        readonly static string keytree = string.Format("Table-{0}-{1}-{2}", "sys_Module", "Cache", "tree");
        readonly static string keytopModule = string.Format("Table-{0}-{1}-{2}", "sys_Module", "Cache", "topModule");
        readonly static string keymodule = string.Format("Table-{0}-{1}", "sys_Module", "Cache");
        /// <summary>
        /// ��ʼ��Ĭ�ϼ�������ģ��
        /// </summary>
        public static void Init_sys_Module_Cache()
        {
            FrameWorkCache.Instance().Insert(keytree, new Dictionary<int, List<sys_ModuleTable>>());
            FrameWorkCache.Instance().Insert(keytopModule, new Dictionary<int, List<sys_ModuleTable>>());
            FrameWorkCache.Instance().Insert(keymodule, new Dictionary<int, sys_ModuleTable>());
            LoadsysModuleId(setModuleCache, setTopModuleCache, setModuleTreeCache,false);
        }

        /// <summary>
        /// ���¼��ػ���
        /// </summary>
        public static void ReLoadCache()
        {
            LoadsysModuleId(setModuleCache, setTopModuleCache, setModuleTreeCache,false);
        }

        /// <summary>
        /// ��ȡϵͳģ��
        /// </summary>
        /// <param name="moduledelegate">���в˵���ȡ���洦��</param>
        /// <param name="topmoduledelegate">һ���˵���ȡ���洦��</param>
        /// <param name="treemoduledelegate">�����˵���ȡ��</param>
        /// <param name="isDelegate">�Ƿ��첽��ȡ����</param>
        static void LoadsysModuleId(sysModuleCacheDelegate moduledelegate, sysModuleCacheDelegate topmoduledelegate, sysModuleCacheDelegate treemoduledelegate,bool isDelegate)
        {
            Sys_moduleCache.Clear();
            Sys_moduletopCache.Clear();
            Sys_moduleTreeCache.Clear();
            init_moduletopCache();

            int rint = 0;
            QueryParam qp = new QueryParam();
            qp.Orderfld = " M_Applicationid,M_OrderLevel ";
            qp.OrderType = 0;
            qp.Where = " Where M_Close=0 ";
            qp.PageIndex = 1;
            qp.PageSize = int.MaxValue;
            ArrayList lst = BusinessFacade.sys_ModuleList(qp, out rint);

            foreach (sys_ModuleTable var in lst)
            {
                if (isDelegate)
                {
                    moduledelegate(var);
                }
                else
                {
                    setModuleCache(var);
                }
            }

            foreach (sys_ModuleTable var in lst)
            {
                if (isDelegate)
                {
                    topmoduledelegate(var);
                    treemoduledelegate(var);
                }
                else
                {
                    setTopModuleCache(var);
                    setModuleTreeCache(var);
                }
            }

        }

        /// <summary>
        /// ��ʼ��Ӧ��
        /// </summary>
        static void init_moduletopCache()
        {
            QueryParam qp = new QueryParam();
            qp.OrderType = 0;
            qp.Orderfld = "A_Order";
            int RecordCount = 0;
            ArrayList lst = BusinessFacade.sys_ApplicationsList(qp, out RecordCount);
            foreach (sys_ApplicationsTable var in lst)
            {
                List<sys_ModuleTable> mod = new List<sys_ModuleTable>();
                Sys_moduletopCache.Add(var.ApplicationID, mod);
            }

        }

        /// <summary>
        /// ����ģ�黺��
        /// </summary>
        /// <param name="m">����ģ��</param>
        static void setModuleCache(sys_ModuleTable m)
        {
            Sys_moduleCache.Add(m.ModuleID, m); //��ʼ��ģ�黺��
            Sys_moduleTreeCache.Add(m.ModuleID, new List<sys_ModuleTable>()); //��ʼ����״ģ�黺��
        }

        /// <summary>
        /// ����ģ����ģ����
        /// </summary>
        /// <param name="m">ģ��ʵ����</param>
        static void setModuleTreeCache(sys_ModuleTable m)
        {
            if (m.M_ParentID != 0)
            {
                if (Sys_moduleTreeCache.ContainsKey(m.M_ParentID))
                {
                    Sys_moduleTreeCache[m.M_ParentID].Add(m);
                }
            }
        }

        /// <summary>
        /// ����һ��ģ�黺��
        /// </summary>
        /// <param name="m"></param>
        static void setTopModuleCache(sys_ModuleTable m)
        {
            //����һ���˵�
            if (m.M_ParentID == 0)
            {
                if (Sys_moduletopCache.ContainsKey(m.M_ApplicationID))
                {
                    Sys_moduletopCache[m.M_ApplicationID].Add(m);
                }
                //else
                //{
                //    List<sys_ModuleTable> mod = new List<sys_ModuleTable>();
                //    mod.Add(m);
                //    Sys_moduletopCache.Add(m.M_ApplicationID, mod);
                //}
            }
        }


        /// <summary>
        /// ���ģ�黺��
        /// </summary>
        public static Dictionary<int, List<sys_ModuleTable>> Sys_moduleTreeCache
        {
            get
            {
                object o;
                if (FrameWorkCache.Instance().TryGetValue(keytree, out o))
                {
                    return (Dictionary<int, List<sys_ModuleTable>>)o;
                }
                else
                {
                    Init_sys_Module_Cache();
                    return (Dictionary<int, List<sys_ModuleTable>>)(FrameWorkCache.Instance()[keytree]);
                }
            }
        }

        /// <summary>
        /// ���һ��ģ��˵�
        /// </summary>
        public static Dictionary<int, List<sys_ModuleTable>> Sys_moduletopCache
        {
            get
            {
                object o;
                if (FrameWorkCache.Instance().TryGetValue(keytopModule, out o))
                {
                    return (Dictionary<int, List<sys_ModuleTable>>)o;
                }
                else
                {
                    Init_sys_Module_Cache();
                    return (Dictionary<int, List<sys_ModuleTable>>)(FrameWorkCache.Instance()[keytopModule]);
                }

            }
        }

        /// <summary>
        /// �������ģ���б�
        /// </summary>
        public static Dictionary<int, sys_ModuleTable> Sys_moduleCache
        {
            get
            {
                object o;
                if (FrameWorkCache.Instance().TryGetValue(keymodule, out o))
                {
                    return (Dictionary<int, sys_ModuleTable>)o;
                }
                else
                {
                    Init_sys_Module_Cache();
                    return (Dictionary<int, sys_ModuleTable>)(FrameWorkCache.Instance()[keymodule]);
                }
            }
        }
    }
}
