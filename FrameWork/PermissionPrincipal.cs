/************************************************************************************
 *      Copyright (C) 2008 supesoft.com,All Rights Reserved						    *
 *      File:																		*
 *				PermissionPrincipal.cs                                    			*
 *      Description:																*
 *				 ����Ȩ�޼����֤��							    *
 *      Author:																		*
 *				Lzppcc														        *
 *				Lzppcc@hotmail.com													*
 *				http://www.supesoft.com												*
 *      Finish DateTime:															*
 *				2008��5��12��														*
 *      History:																	*
 ***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using System.Diagnostics;
using FrameWork.Components;

namespace FrameWork
{
    /// <summary>
    /// ��������Ȩ�޼����
    /// </summary>
    public class PermissionPrincipal:IPrincipal
    {
        private IIdentity _identity;
        private string[] _roles;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="_IID"></param>
        public PermissionPrincipal(IIdentity _IID)
        {
            _identity = _IID;
            _roles = new string[1]{"check"};
        }

        /// <summary>
        /// ����ɫ����
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool IsInRole(string role)
        {
            return Check_PopedomTypeAttaible();
        }
        /// <summary>
        /// �û���ʶ
        /// </summary>
        public IIdentity Identity
        {
            get
            {
                return _identity;
            }
        }


        private bool Check_PopedomTypeAttaible()
        {
            //System.Web.HttpResponse rp = System.Web.HttpContext.Current.Response;
            //rp.Write("ִ�з�������!");
            //rp.Write(System.Reflection.MethodBase.GetCurrentMethod().Name);
            //rp.Write("<br>");
            StackTrace stack = new StackTrace();

            foreach (StackFrame sframe in stack.GetFrames())
            {
                //rp.Write(sframe.GetMethod().Name);
                //rp.Write("<br>");
                foreach (PopedomTypeAttaible var in sframe.GetMethod().GetCustomAttributes(typeof(PopedomTypeAttaible), true))
                {
                    //rp.Write(var.PType.ToString());
                    //rp.Write("<br>");
                    //rp.Write("��Ȩ��!");
                    //rp.End();
                    //return false;
                    FrameWorkPermission.CheckPermissionVoid(var.PType);
                }
                //rp.Write("------");
                //rp.Write("<br>");
            }
            //rp.End();
            return true;
        }
    }

    /// <summary>
    /// Ȩ�޷�������
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class PopedomTypeAttaible : Attribute
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="PT"></param>
        public PopedomTypeAttaible(PopedomType PT)
        {
            _PType = PT;
        }

        /// <summary>
        /// Ȩ������
        /// </summary>
        private PopedomType _PType;
        /// <summary>
        /// Ȩ������
        /// </summary>
        public PopedomType PType
        {
            get {
                return _PType;
            }
        }
        
    }
}
