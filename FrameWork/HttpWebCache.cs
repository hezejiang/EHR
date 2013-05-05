/************************************************************************************
 *      Copyright (C) 2008 supesoft.com,All Rights Reserved						    *
 *      File:																		*
 *				HttpWebCache.cs                                              			*
 *      Description:																*
 *				 Asp.Net Web����                 								    *
 *      Author:																		*
 *				Lzppcc														        *
 *				Lzppcc@hotmail.com													*
 *				http://www.supesoft.com												*
 *      Finish DateTime:															*
 *				2008��5��2��														*
 *      History:																	*
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Caching;
namespace FrameWork
{
    /// <summary>
    /// Asp.Net Web����
    /// </summary>
    public class HttpWebCache:IFrameWorkCache
    {
        /// <summary>
        /// WebCache
        /// </summary>
        private Cache _Cache = HttpRuntime.Cache;

        /// <summary>
        /// ����ֵ
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="o">ֵ</param>
        public void Insert(string key, object o)
        {
            _Cache.Insert(key, o);
        }

        /// <summary>
        /// �Ƴ�ֵ
        /// </summary>
        /// <param name="key">key</param>
        public void Remove(string key)
        {
            _Cache.Remove(key);
        }

        /// <summary>
        /// ���ֵ
        /// </summary>
        /// <param name="key">��ֵ</param>
        /// <returns>����ֵ</returns>
        public object this[string key]
        {
            get {
                return _Cache[key];
            }
        }

        /// <summary>
        /// ���ʹ�û�������
        /// </summary>
        public int Count
        {
            get {
                return _Cache.Count;
            }
        }

        /// <summary>
        /// ���ʣ�໺���С
        /// </summary>
        public string Remains
        {
            get {
                return string.Format("{0}M",_Cache.EffectivePrivateBytesLimit / 1024 / 1024);
            }
        }

        /// <summary>
        /// ����key���ֵ
        /// </summary>
        /// <param name="key"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool TryGetValue(string key, out object o)
        { 
            o=_Cache[key];
            return ContainsKey(key);
        }

        /// <summary>
        /// ����Ƿ���ڵ�ǰkey
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����/������</returns>
        public bool ContainsKey(string key)
        {
            if (_Cache[key] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
