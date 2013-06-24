using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using LitJson;
using Maticsoft.Common;

namespace Maticsoft.Web.Api
{
    /// <summary>
    /// Announcement 的摘要说明
    /// </summary>
    public class Announcement : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string accessToken = context.Request["accessToken"];
            if (accessToken != null)
            {
                BLL.sys_UserInfo sys_UserInfo_bll = new BLL.sys_UserInfo();
                Model.sys_UserInfo sys_UserInfo_model = null;
                List<Model.sys_UserInfo> sys_UserInfo_models = sys_UserInfo_bll.GetModelList("U_AccessToken='" + accessToken + "'");
                if (sys_UserInfo_models.Count > 0)
                {
                    sys_UserInfo_model = sys_UserInfo_models[0];
                }
                if (sys_UserInfo_model == null)
                {
                    HttpContext.Current.Response.Write("{'status':'10003','msg':'accessToken无效'}");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    Maticsoft.BLL.AR_Announcement AR_Announcement_bll = new BLL.AR_Announcement();
                    List<Maticsoft.Model.AR_Announcement> AR_Announcement_models = AR_Announcement_bll.GetModelList(string.Format("A_GroupID={0}", sys_UserInfo_model.U_Committee));
                    Maticsoft.Model.AR_Announcement model = new Model.AR_Announcement();
                    for (int i = 0; i < AR_Announcement_models.Count; i++)
                    {
                        if (i != 0)
                            sb.Append(",");
                        model = AR_Announcement_models[i];
                        string jsonData = "{'AnnouncementID':'" + model.AnnouncementID + "','A_Title':'" + model.A_Title + "','A_Content':'" + model.A_Content + "','A_DateTime':'" + TimeParser.UNIX_TIMESTAMP(model.A_DateTime) + "','A_ResponsibilityUserID':'" + getUserModelById(model.A_ResponsibilityUserID).U_CName + "','A_Type':'" + getA_Type(model.A_Type) + "'}";
                        sb.Append(jsonData);
                    }
                    HttpContext.Current.Response.Write("{'status':'200','result':[" + sb.ToString() + "]}");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("{'status':'10003','msg':'accessToken无效'}");
            }
        }

        /// <summary>
        /// 通过用户id得到用户信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Maticsoft.Model.sys_User getUserModelById(int userID)
        {
            Maticsoft.BLL.sys_User bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User model = bll.GetModel(userID);
            return model;
        }

        public string getA_Type(int code)
        {
            string result = "";
            switch (code)
            {
                case 1:
                    result = "普通公告";
                    break;
                case 2:
                    result = "紧急公告";
                    break;
            }
            return result;
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