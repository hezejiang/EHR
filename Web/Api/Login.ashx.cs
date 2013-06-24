using System;
using System.Collections.Generic;
using System.Web;

namespace Maticsoft.Web.Api
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string U_LoginName = context.Request["LoginName"];
            string U_Password = context.Request["Password"];
            if (U_Password != null && U_Password != null)
            {
                Maticsoft.BLL.sys_User sys_User_bll = new BLL.sys_User();
                U_Password = FrameWork.Common.md5(U_Password, 32);
                string accessToken = sys_User_bll.Login(U_LoginName, U_Password);
                if (accessToken == "")
                {
                    HttpContext.Current.Response.Write("{'status':'10002','msg':'用户名密码不匹配'}");
                }
                else
                {
                    HttpContext.Current.Response.Write("{'status':'200','accessToken':'" + accessToken + "'}");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("{'status':'10001','accessToken':'用户名和密码不能为空'}");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}