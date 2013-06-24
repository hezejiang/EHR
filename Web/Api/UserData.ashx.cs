using System;
using System.Collections.Generic;
using System.Web;

namespace Maticsoft.Web.Api
{
    /// <summary>
    /// UserData 的摘要说明
    /// </summary>
    public class UserData : IHttpHandler
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
                    Maticsoft.BLL.Nation nation_bll = new BLL.Nation();
                    Maticsoft.Model.Nation nation_model = nation_bll.GetModel(sys_UserInfo_model.U_NationID);
                    string nation_Str = nation_model.N_Name;
                    string U_BloodType_Str = getU_BloodType(sys_UserInfo_model.U_BloodType);
                    string U_Education_Str = getU_Education(sys_UserInfo_model.U_Education);
                    string U_PermanentType_Str = getU_PermanentType(sys_UserInfo_model.U_PermanentType);
                    string U_PaymentType_Str = getU_PaymentType(Convert.ToInt32(sys_UserInfo_model.U_PaymentType));
                    string U_RelationShip_Str = getU_RelationShip(sys_UserInfo_model.U_RelationShip);

                    HttpContext.Current.Response.Write("{'status':'200','result':{'UserID':'" + sys_UserInfo_model.UserID + "','U_IDCard':'" + sys_UserInfo_model.U_IDCard + "','U_CName':'" + sys_UserInfo_model.U_CName + "','U_Hometown':'" + sys_UserInfo_model.U_Hometown + "','U_NationID':'" + nation_Str + "','U_BloodType':'" + U_BloodType_Str + "','U_MobileNo':'" + sys_UserInfo_model.U_MobileNo + "','U_Education':'" + U_Education_Str + "','U_CurrentAddress':'" + sys_UserInfo_model.U_CurrentAddress + "','U_WorkingUnits':'" + sys_UserInfo_model.U_WorkingUnits + "','U_WorkingContactName':'" + sys_UserInfo_model.U_WorkingContactName + "','U_WorkingContactTel':'" + sys_UserInfo_model.U_WorkingContactTel + "','U_PaymentType':'" + U_PaymentType_Str + "','U_MedicalNO':'" + sys_UserInfo_model.U_MobileNo + "','U_SocialNO':'" + sys_UserInfo_model.U_SocialNO + "','U_FamilyCode':'" + sys_UserInfo_model.U_FamilyCode + "','U_RelationShip':'" + U_RelationShip_Str + "','U_ResponsibilityUserID':'" + getUserModelById(sys_UserInfo_model.U_ResponsibilityUserID).U_CName + "','U_FilingUnits':'" + getGroupModelById(sys_UserInfo_model.U_Committee).G_CName + "','U_FilingUserID':'" + getUserModelById(sys_UserInfo_model.U_FilingUserID).U_CName + "'}}");
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

        public string getU_BloodType(int code)
        {
            string result = "";
            switch (code)
            {
                case 1:
                    result = "A型";
                    break;
                case 2:
                    result = "B型";
                    break;
                case 3:
                    result = "AB型";
                    break;
                case 4:
                    result = "O型";
                    break;
                default:
                    result = "不详";
                    break;
            }
            return result;
        }

        public string getU_Education(int code)
        {
            string result = "";
            switch (code)
            {
                case 1:
                    result = "文盲及半文盲";
                    break;
                case 2:
                    result = "小学";
                    break;
                case 3:
                    result = "中学";
                    break;
                case 4:
                    result = "高中/技校/中专";
                    break;
                case 5:
                    result = "大学专科";
                    break;
                case 6:
                    result = "大学本科";
                    break;
                case 7:
                    result = "研究生及以上";
                    break;
                default:
                    result = "不详";
                    break;
            }
            return result;
        }

        public string getU_PermanentType(int code)
        {
            string result = "";
            switch (code)
            {
                case 1:
                    result = "户籍";
                    break;
                case 2:
                    result = "非户籍";
                    break;
            }
            return result;
        }

        public string getU_PaymentType(int code)
        {
            string result = "";
            switch (code)
            {
                case 1:
                    result = "城镇职工基本医疗保险";
                    break;
                case 2:
                    result = "城镇居民基本医疗保险";
                    break;
                case 3:
                    result = "贫困扶助";
                    break;
                case 4:
                    result = "新型农村合作医疗";
                    break;
                case 5:
                    result = "商业医疗保险";
                    break;
                case 6:
                    result = "全公费";
                    break;
                case 7:
                    result = "全自费";
                    break;
                default:
                    result = "其他";
                    break;
            }
            return result;
        }

        public string getU_RelationShip(int code)
        {
            string result = "";
            switch (code)
            {
                case 0:
                    result = "户主";
                    break;
                case 1:
                    result = "父亲";
                    break;
                case 2:
                    result = "母亲";
                    break;
                case 3:
                    result = "儿子";
                    break;
                case 4:
                    result = "儿媳";
                    break;
                case 5:
                    result = "女儿";
                    break;
                case 6:
                    result = "女婿";
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