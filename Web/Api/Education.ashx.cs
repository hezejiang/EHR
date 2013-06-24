using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using LitJson;
using Maticsoft.Common;

namespace Maticsoft.Web.Api
{
    /// <summary>
    /// Education 的摘要说明
    /// </summary>
    public class Education : IHttpHandler
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
                    Maticsoft.BLL.education_Activity education_Activity_bll = new BLL.education_Activity();
                    Maticsoft.Model.education_Activity model = new Model.education_Activity();
                    List<Maticsoft.Model.education_Activity> education_Activity_models = education_Activity_bll.GetModelList(string.Format("A_Object={0}", sys_UserInfo_model.U_Committee));
                    for (int i = 0; i < education_Activity_models.Count; i++)
                    {
                        if (i != 0)
                            sb.Append(",");
                        model = education_Activity_models[i];
                        string jsonData = "{'ActivityID':'0','A_DateTime':'" + TimeParser.UNIX_TIMESTAMP(model.A_DateTime) + "','A_Location':'" + model.A_Location + "','A_Form':'" + model.A_Form + "','A_Object':'" + getUserModelById(model.A_Object).U_CName + "','A_Crowd':'" + model.A_Crowd + "','A_Duration':'" + model.A_Duration + "','A_Organizers':'" + model.A_Organizers + "','A_Partners':'" + model.A_Partners + "','A_Missionary':'" + model.A_Missionary + "','A_Number':'" + model.A_Number + "','A_Theme':'" + model.A_Theme + "'}";
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

        /// <summary>
        /// 通过部门id得到部门信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Maticsoft.Model.sys_Group getGroupModelById(int GroupID)
        {
            Maticsoft.BLL.sys_Group bll = new Maticsoft.BLL.sys_Group();
            Maticsoft.Model.sys_Group model = bll.GetModel(GroupID);
            return model;
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