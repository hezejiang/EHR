using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_User
	/// </summary>
	public partial class sys_UserInfo:Isys_UserInfo
	{
        public sys_UserInfo()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.sys_UserInfo GetModel(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 from sys_User join record_UserBaseInfo on sys_User.UserID=record_UserBaseInfo.UserID ");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;

            Maticsoft.Model.sys_UserInfo model = new Maticsoft.Model.sys_UserInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.sys_UserInfo DataRowToModel(DataRow row)
        {
            Maticsoft.Model.sys_UserInfo model = new Maticsoft.Model.sys_UserInfo();
            if (row != null)
            {
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
                }
                if (row["U_LoginName"] != null)
                {
                    model.U_LoginName = row["U_LoginName"].ToString();
                }
                if (row["U_Password"] != null)
                {
                    model.U_Password = row["U_Password"].ToString();
                }
                if (row["U_CName"] != null)
                {
                    model.U_CName = row["U_CName"].ToString();
                }
                if (row["U_EName"] != null)
                {
                    model.U_EName = row["U_EName"].ToString();
                }
                if (row["U_GroupID"] != null && row["U_GroupID"].ToString() != "")
                {
                    model.U_GroupID = int.Parse(row["U_GroupID"].ToString());
                }
                if (row["U_Email"] != null)
                {
                    model.U_Email = row["U_Email"].ToString();
                }
                if (row["U_Type"] != null && row["U_Type"].ToString() != "")
                {
                    model.U_Type = int.Parse(row["U_Type"].ToString());
                }
                if (row["U_Status"] != null && row["U_Status"].ToString() != "")
                {
                    model.U_Status = int.Parse(row["U_Status"].ToString());
                }
                if (row["U_Licence"] != null)
                {
                    model.U_Licence = row["U_Licence"].ToString();
                }
                if (row["U_Mac"] != null)
                {
                    model.U_Mac = row["U_Mac"].ToString();
                }
                if (row["U_Remark"] != null)
                {
                    model.U_Remark = row["U_Remark"].ToString();
                }
                if (row["U_IDCard"] != null)
                {
                    model.U_IDCard = row["U_IDCard"].ToString();
                }
                if (row["U_Sex"] != null && row["U_Sex"].ToString() != "")
                {
                    model.U_Sex = int.Parse(row["U_Sex"].ToString());
                }
                if (row["U_BirthDay"] != null && row["U_BirthDay"].ToString() != "")
                {
                    model.U_BirthDay = DateTime.Parse(row["U_BirthDay"].ToString());
                }
                if (row["U_MobileNo"] != null)
                {
                    model.U_MobileNo = row["U_MobileNo"].ToString();
                }
                if (row["U_UserNO"] != null)
                {
                    model.U_UserNO = row["U_UserNO"].ToString();
                }
                if (row["U_WorkStartDate"] != null && row["U_WorkStartDate"].ToString() != "")
                {
                    model.U_WorkStartDate = DateTime.Parse(row["U_WorkStartDate"].ToString());
                }
                if (row["U_WorkEndDate"] != null && row["U_WorkEndDate"].ToString() != "")
                {
                    model.U_WorkEndDate = DateTime.Parse(row["U_WorkEndDate"].ToString());
                }
                if (row["U_CompanyMail"] != null)
                {
                    model.U_CompanyMail = row["U_CompanyMail"].ToString();
                }
                if (row["U_Title"] != null && row["U_Title"].ToString() != "")
                {
                    model.U_Title = int.Parse(row["U_Title"].ToString());
                }
                if (row["U_Extension"] != null)
                {
                    model.U_Extension = row["U_Extension"].ToString();
                }
                if (row["U_HomeTel"] != null)
                {
                    model.U_HomeTel = row["U_HomeTel"].ToString();
                }
                if (row["U_PhotoUrl"] != null)
                {
                    model.U_PhotoUrl = row["U_PhotoUrl"].ToString();
                }
                if (row["U_DateTime"] != null && row["U_DateTime"].ToString() != "")
                {
                    model.U_DateTime = DateTime.Parse(row["U_DateTime"].ToString());
                }
                if (row["U_LastIP"] != null)
                {
                    model.U_LastIP = row["U_LastIP"].ToString();
                }
                if (row["U_LastDateTime"] != null && row["U_LastDateTime"].ToString() != "")
                {
                    model.U_LastDateTime = DateTime.Parse(row["U_LastDateTime"].ToString());
                }
                if (row["U_ExtendField"] != null)
                {
                    model.U_ExtendField = row["U_ExtendField"].ToString();
                }
                if (row["U_LoginType"] != null)
                {
                    model.U_LoginType = row["U_LoginType"].ToString();
                }
                if (row["U_HospitalGroupID"] != null && row["U_HospitalGroupID"].ToString() != "")
                {
                    model.U_HospitalGroupID = int.Parse(row["U_HospitalGroupID"].ToString());
                }
                
                if (row["U_Hometown"] != null)
                {
                    model.U_Hometown = row["U_Hometown"].ToString();
                }
                if (row["U_CurrentAddress"] != null)
                {
                    model.U_CurrentAddress = row["U_CurrentAddress"].ToString();
                }
                if (row["U_FilingUnits"] != null && row["U_FilingUnits"].ToString() != "")
                {
                    model.U_FilingUnits = int.Parse(row["U_FilingUnits"].ToString());
                }
                if (row["U_FilingUserID"] != null && row["U_FilingUserID"].ToString() != "")
                {
                    model.U_FilingUserID = int.Parse(row["U_FilingUserID"].ToString());
                }
                if (row["U_ResponsibilityUserID"] != null && row["U_ResponsibilityUserID"].ToString() != "")
                {
                    model.U_ResponsibilityUserID = int.Parse(row["U_ResponsibilityUserID"].ToString());
                }
                if (row["U_Committee"] != null && row["U_Committee"].ToString() != "")
                {
                    model.U_Committee = int.Parse(row["U_Committee"].ToString());
                }
                if (row["U_FlingTime"] != null && row["U_FlingTime"].ToString() != "")
                {
                    model.U_FlingTime = DateTime.Parse(row["U_FlingTime"].ToString());
                }
                if (row["U_WorkingUnits"] != null)
                {
                    model.U_WorkingUnits = row["U_WorkingUnits"].ToString();
                }
                if (row["U_WorkingContactName"] != null)
                {
                    model.U_WorkingContactName = row["U_WorkingContactName"].ToString();
                }
                if (row["U_WorkingContactTel"] != null)
                {
                    model.U_WorkingContactTel = row["U_WorkingContactTel"].ToString();
                }
                if (row["U_BloodType"] != null && row["U_BloodType"].ToString() != "")
                {
                    model.U_BloodType = int.Parse(row["U_BloodType"].ToString());
                }
                if (row["U_NationID"] != null && row["U_NationID"].ToString() != "")
                {
                    model.U_NationID = int.Parse(row["U_NationID"].ToString());
                }
                if (row["U_MarriageStatus"] != null && row["U_MarriageStatus"].ToString() != "")
                {
                    model.U_MarriageStatus = int.Parse(row["U_MarriageStatus"].ToString());
                }
                if (row["U_PermanentType"] != null && row["U_PermanentType"].ToString() != "")
                {
                    model.U_PermanentType = int.Parse(row["U_PermanentType"].ToString());
                }
                if (row["U_Education"] != null && row["U_Education"].ToString() != "")
                {
                    model.U_Education = int.Parse(row["U_Education"].ToString());
                }
                if (row["U_PaymentType"] != null)
                {
                    model.U_PaymentType = row["U_PaymentType"].ToString();
                }
                if (row["U_SocialNO"] != null)
                {
                    model.U_SocialNO = row["U_SocialNO"].ToString();
                }
                if (row["U_MedicalNO"] != null)
                {
                    model.U_MedicalNO = row["U_MedicalNO"].ToString();
                }
                if (row["U_FamilyCode"] != null)
                {
                    model.U_FamilyCode = row["U_FamilyCode"].ToString();
                }
                if (row["U_RelationShip"] != null && row["U_RelationShip"].ToString() != "")
                {
                    model.U_RelationShip = int.Parse(row["U_RelationShip"].ToString());
                }
                if (row["U_auditStatus"] != null && row["U_auditStatus"].ToString() != "")
                {
                    model.U_AuditStatus = int.Parse(row["U_auditStatus"].ToString());
                }
            }
            return model;
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select *");
            strSql.Append(" FROM sys_User join record_UserBaseInfo on sys_User.UserID=record_UserBaseInfo.UserID ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
            strSql.Append(" FROM sys_User join record_UserBaseInfo on sys_User.UserID=record_UserBaseInfo.UserID ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) FROM sys_User join record_UserBaseInfo on sys_User.UserID=record_UserBaseInfo.UserID ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_User T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
            strSql.Append(" ) TT join record_UserBaseInfo TTT on TT.UserID=TTT.UserID ");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "sys_User";
			parameters[1].Value = "UserID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

