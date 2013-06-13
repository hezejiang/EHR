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
    public partial class extend_UserDisease : Iextend_UserDisease
	{
        public extend_UserDisease()
		{}
		#region  BasicMethod

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.extend_UserDisease GetModel(int DiseaseHistoryID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 from extend_DiseaseHistory join record_UserBaseInfo on extend_DiseaseHistory.DH_UserID=record_UserBaseInfo.UserID ");
            strSql.Append(" where DiseaseHistoryID=@DiseaseHistoryID");
            SqlParameter[] parameters = {
					new SqlParameter("@DiseaseHistoryID", SqlDbType.Int,4)
			};
            parameters[0].Value = DiseaseHistoryID;

            Maticsoft.Model.extend_UserDisease model = new Maticsoft.Model.extend_UserDisease();
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
        public Maticsoft.Model.extend_UserDisease DataRowToModel(DataRow row)
        {
            Maticsoft.Model.extend_UserDisease model = new Maticsoft.Model.extend_UserDisease();
            if (row != null)
            {
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.DiseaseHistoryID = int.Parse(row["UserID"].ToString());
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

                if (row["DiseaseHistoryID"] != null && row["DiseaseHistoryID"].ToString() != "")
                {
                    model.DiseaseHistoryID = int.Parse(row["DiseaseHistoryID"].ToString());
                }
                if (row["DH_Type"] != null && row["DH_Type"].ToString() != "")
                {
                    model.DH_Type = int.Parse(row["DH_Type"].ToString());
                }
                if (row["DH_DiagnosisDate"] != null && row["DH_DiagnosisDate"].ToString() != "")
                {
                    model.DH_DiagnosisDate = DateTime.Parse(row["DH_DiagnosisDate"].ToString());
                }
                if (row["DH_Note"] != null)
                {
                    model.DH_Note = row["DH_Note"].ToString();
                }
                if (row["DH_UserID"] != null && row["DH_UserID"].ToString() != "")
                {
                    model.DH_UserID = int.Parse(row["DH_UserID"].ToString());
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
            strSql.Append(" FROM extend_DiseaseHistory join record_UserBaseInfo on extend_DiseaseHistory.DH_UserID=record_UserBaseInfo.UserID ");
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
            strSql.Append(" FROM extend_DiseaseHistory join record_UserBaseInfo on extend_DiseaseHistory.DH_UserID=record_UserBaseInfo.UserID ");
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
            strSql.Append("select count(1) FROM extend_DiseaseHistory join record_UserBaseInfo on extend_DiseaseHistory.DH_UserID=record_UserBaseInfo.UserID ");
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
				strSql.Append("order by T.DiseaseHistoryID desc");
			}
			strSql.Append(")AS Row, T.*  from extend_DiseaseHistory T ");
			
            strSql.Append(" ) TT join record_UserBaseInfo TTT on TT.DH_UserID=TTT.UserID ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
                strSql.AppendFormat(" and TT.Row between {0} and {1}", startIndex, endIndex);
            }
            else
            {
                strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            }
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
			parameters[1].Value = "DiseaseHistoryID";
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

