using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using LitJson;
using Maticsoft.Common;

namespace Maticsoft.Web.Api
{
    /// <summary>
    /// Document 的摘要说明
    /// </summary>
    public class Document : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string accessToken = context.Request["accessToken"];
            if (accessToken != null)
            {
                BLL.sys_UserInfo sys_UserInfo_bll = new BLL.sys_UserInfo();
                Model.sys_UserInfo sys_UserInfo_model = null;
                List<Model.sys_UserInfo> sys_UserInfo_models = sys_UserInfo_bll.GetModelList("U_AccessToken='" + accessToken +"'");
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
                    Maticsoft.BLL.education_Document education_Document_bll =  new BLL.education_Document();
                    Maticsoft.Model.education_Document model = new Model.education_Document();
                    List<Maticsoft.Model.education_Document> education_Document_models = education_Document_bll.GetModelList(string.Format("D_Committee={0}",sys_UserInfo_model.U_Committee));
                    for (int i = 0; i < education_Document_models.Count; i++)
			        {
                        if(i!=0)
                            sb.Append(",");
                        model = education_Document_models[i];
                        string jsonData = "{'DocumentID':'" + model.DocumentID + "','D_Name':'" + model.D_Name + "','D_Url':'" + model.D_Url + "','D_UserID':'" + getUserModelById(model.D_UserID).U_CName + "','D_DateTime':'" + TimeParser.UNIX_TIMESTAMP(model.D_DateTime) + "'}";
                        sb.Append(jsonData);
                    }
                    HttpContext.Current.Response.Write("{'status':'200','result':["+sb.ToString()+"]}");
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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}