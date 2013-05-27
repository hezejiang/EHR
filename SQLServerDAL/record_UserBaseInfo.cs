using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_UserBaseInfo
	/// </summary>
	public partial class record_UserBaseInfo:Irecord_UserBaseInfo
	{
		public record_UserBaseInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserID", "record_UserBaseInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_UserBaseInfo");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.record_UserBaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_UserBaseInfo(");
            strSql.Append("UserID,U_Hometown,U_CurrentAddress,U_FilingUnits,U_FilingUserID,U_ResponsibilityUserID,U_Committee,U_FlingTime,U_WorkingUnits,U_WorkingContactName,U_WorkingContactTel,U_BloodType,U_NationID,U_MarriageStatus,U_PermanentType,U_Education,U_PaymentType,U_SocialNO,U_MedicalNO,U_FamilyCode,U_RelationShip,U_auditStatus,U_Note)");
			strSql.Append(" values (");
            strSql.Append("@UserID,@U_Hometown,@U_CurrentAddress,@U_FilingUnits,@U_FilingUserID,@U_ResponsibilityUserID,@U_Committee,@U_FlingTime,@U_WorkingUnits,@U_WorkingContactName,@U_WorkingContactTel,@U_BloodType,@U_NationID,@U_MarriageStatus,@U_PermanentType,@U_Education,@U_PaymentType,@U_SocialNO,@U_MedicalNO,@U_FamilyCode,@U_RelationShip,@U_auditStatus,@U_Note)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@U_Hometown", SqlDbType.NVarChar,255),
					new SqlParameter("@U_CurrentAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@U_FilingUnits", SqlDbType.Int,4),
					new SqlParameter("@U_FilingUserID", SqlDbType.Int,4),
					new SqlParameter("@U_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@U_Committee", SqlDbType.Int,4),
					new SqlParameter("@U_FlingTime", SqlDbType.DateTime),
					new SqlParameter("@U_WorkingUnits", SqlDbType.NVarChar,255),
					new SqlParameter("@U_WorkingContactName", SqlDbType.NVarChar,20),
					new SqlParameter("@U_WorkingContactTel", SqlDbType.VarChar,20),
					new SqlParameter("@U_BloodType", SqlDbType.TinyInt,1),
					new SqlParameter("@U_NationID", SqlDbType.TinyInt,1),
					new SqlParameter("@U_MarriageStatus", SqlDbType.TinyInt,1),
					new SqlParameter("@U_PermanentType", SqlDbType.TinyInt,1),
					new SqlParameter("@U_Education", SqlDbType.TinyInt,1),
					new SqlParameter("@U_PaymentType", SqlDbType.VarChar,20),
					new SqlParameter("@U_SocialNO", SqlDbType.VarChar,30),
					new SqlParameter("@U_MedicalNO", SqlDbType.VarChar,10),
					new SqlParameter("@U_FamilyCode", SqlDbType.VarChar,22),
					new SqlParameter("@U_RelationShip", SqlDbType.TinyInt,1),
					new SqlParameter("@U_auditStatus", SqlDbType.TinyInt,1),
                    new SqlParameter("@U_Note", SqlDbType.Text),
                    new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.U_Hometown;
			parameters[1].Value = model.U_CurrentAddress;
			parameters[2].Value = model.U_FilingUnits;
			parameters[3].Value = model.U_FilingUserID;
			parameters[4].Value = model.U_ResponsibilityUserID;
			parameters[5].Value = model.U_Committee;
			parameters[6].Value = model.U_FlingTime;
			parameters[7].Value = model.U_WorkingUnits;
			parameters[8].Value = model.U_WorkingContactName;
			parameters[9].Value = model.U_WorkingContactTel;
			parameters[10].Value = model.U_BloodType;
			parameters[11].Value = model.U_NationID;
			parameters[12].Value = model.U_MarriageStatus;
			parameters[13].Value = model.U_PermanentType;
			parameters[14].Value = model.U_Education;
			parameters[15].Value = model.U_PaymentType;
			parameters[16].Value = model.U_SocialNO;
			parameters[17].Value = model.U_MedicalNO;
			parameters[18].Value = model.U_FamilyCode;
			parameters[19].Value = model.U_RelationShip;
			parameters[20].Value = model.U_AuditStatus;
            parameters[21].Value = model.U_Note;
            parameters[22].Value = model.UserID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.record_UserBaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_UserBaseInfo set ");
			strSql.Append("U_Hometown=@U_Hometown,");
			strSql.Append("U_CurrentAddress=@U_CurrentAddress,");
			strSql.Append("U_FilingUnits=@U_FilingUnits,");
			strSql.Append("U_FilingUserID=@U_FilingUserID,");
			strSql.Append("U_ResponsibilityUserID=@U_ResponsibilityUserID,");
			strSql.Append("U_Committee=@U_Committee,");
			strSql.Append("U_FlingTime=@U_FlingTime,");
			strSql.Append("U_WorkingUnits=@U_WorkingUnits,");
			strSql.Append("U_WorkingContactName=@U_WorkingContactName,");
			strSql.Append("U_WorkingContactTel=@U_WorkingContactTel,");
			strSql.Append("U_BloodType=@U_BloodType,");
			strSql.Append("U_NationID=@U_NationID,");
			strSql.Append("U_MarriageStatus=@U_MarriageStatus,");
			strSql.Append("U_PermanentType=@U_PermanentType,");
			strSql.Append("U_Education=@U_Education,");
			strSql.Append("U_PaymentType=@U_PaymentType,");
			strSql.Append("U_SocialNO=@U_SocialNO,");
			strSql.Append("U_MedicalNO=@U_MedicalNO,");
			strSql.Append("U_FamilyCode=@U_FamilyCode,");
			strSql.Append("U_RelationShip=@U_RelationShip,");
			strSql.Append("U_auditStatus=@U_auditStatus,");
            strSql.Append("U_Note=@U_Note");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@U_Hometown", SqlDbType.NVarChar,255),
					new SqlParameter("@U_CurrentAddress", SqlDbType.NVarChar,255),
					new SqlParameter("@U_FilingUnits", SqlDbType.Int,4),
					new SqlParameter("@U_FilingUserID", SqlDbType.Int,4),
					new SqlParameter("@U_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@U_Committee", SqlDbType.Int,4),
					new SqlParameter("@U_FlingTime", SqlDbType.DateTime),
					new SqlParameter("@U_WorkingUnits", SqlDbType.NVarChar,255),
					new SqlParameter("@U_WorkingContactName", SqlDbType.NVarChar,20),
					new SqlParameter("@U_WorkingContactTel", SqlDbType.VarChar,20),
					new SqlParameter("@U_BloodType", SqlDbType.TinyInt,1),
					new SqlParameter("@U_NationID", SqlDbType.TinyInt,1),
					new SqlParameter("@U_MarriageStatus", SqlDbType.TinyInt,1),
					new SqlParameter("@U_PermanentType", SqlDbType.TinyInt,1),
					new SqlParameter("@U_Education", SqlDbType.TinyInt,1),
					new SqlParameter("@U_PaymentType", SqlDbType.VarChar,20),
					new SqlParameter("@U_SocialNO", SqlDbType.VarChar,30),
					new SqlParameter("@U_MedicalNO", SqlDbType.VarChar,10),
					new SqlParameter("@U_FamilyCode", SqlDbType.VarChar,22),
					new SqlParameter("@U_RelationShip", SqlDbType.TinyInt,1),
					new SqlParameter("@U_auditStatus", SqlDbType.TinyInt,1),
                    new SqlParameter("@U_Note", SqlDbType.Text),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.U_Hometown;
			parameters[1].Value = model.U_CurrentAddress;
			parameters[2].Value = model.U_FilingUnits;
			parameters[3].Value = model.U_FilingUserID;
			parameters[4].Value = model.U_ResponsibilityUserID;
			parameters[5].Value = model.U_Committee;
			parameters[6].Value = model.U_FlingTime;
			parameters[7].Value = model.U_WorkingUnits;
			parameters[8].Value = model.U_WorkingContactName;
			parameters[9].Value = model.U_WorkingContactTel;
			parameters[10].Value = model.U_BloodType;
			parameters[11].Value = model.U_NationID;
			parameters[12].Value = model.U_MarriageStatus;
			parameters[13].Value = model.U_PermanentType;
			parameters[14].Value = model.U_Education;
			parameters[15].Value = model.U_PaymentType;
			parameters[16].Value = model.U_SocialNO;
			parameters[17].Value = model.U_MedicalNO;
			parameters[18].Value = model.U_FamilyCode;
			parameters[19].Value = model.U_RelationShip;
			parameters[20].Value = model.U_AuditStatus;
            parameters[21].Value = model.U_Note;
            parameters[22].Value = model.UserID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_UserBaseInfo ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_UserBaseInfo ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.record_UserBaseInfo GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,U_Hometown,U_CurrentAddress,U_FilingUnits,U_FilingUserID,U_ResponsibilityUserID,U_Committee,U_FlingTime,U_WorkingUnits,U_WorkingContactName,U_WorkingContactTel,U_BloodType,U_NationID,U_MarriageStatus,U_PermanentType,U_Education,U_PaymentType,U_SocialNO,U_MedicalNO,U_FamilyCode,U_RelationShip,U_auditStatus,U_Note from record_UserBaseInfo ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			Maticsoft.Model.record_UserBaseInfo model=new Maticsoft.Model.record_UserBaseInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Maticsoft.Model.record_UserBaseInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_UserBaseInfo model=new Maticsoft.Model.record_UserBaseInfo();
			if (row != null)
			{
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["U_Hometown"]!=null)
				{
					model.U_Hometown=row["U_Hometown"].ToString();
				}
				if(row["U_CurrentAddress"]!=null)
				{
					model.U_CurrentAddress=row["U_CurrentAddress"].ToString();
				}
				if(row["U_FilingUnits"]!=null && row["U_FilingUnits"].ToString()!="")
				{
					model.U_FilingUnits=int.Parse(row["U_FilingUnits"].ToString());
				}
				if(row["U_FilingUserID"]!=null && row["U_FilingUserID"].ToString()!="")
				{
					model.U_FilingUserID=int.Parse(row["U_FilingUserID"].ToString());
				}
				if(row["U_ResponsibilityUserID"]!=null && row["U_ResponsibilityUserID"].ToString()!="")
				{
					model.U_ResponsibilityUserID=int.Parse(row["U_ResponsibilityUserID"].ToString());
				}
				if(row["U_Committee"]!=null && row["U_Committee"].ToString()!="")
				{
					model.U_Committee=int.Parse(row["U_Committee"].ToString());
				}
				if(row["U_FlingTime"]!=null && row["U_FlingTime"].ToString()!="")
				{
					model.U_FlingTime=DateTime.Parse(row["U_FlingTime"].ToString());
				}
				if(row["U_WorkingUnits"]!=null)
				{
					model.U_WorkingUnits=row["U_WorkingUnits"].ToString();
				}
				if(row["U_WorkingContactName"]!=null)
				{
					model.U_WorkingContactName=row["U_WorkingContactName"].ToString();
				}
				if(row["U_WorkingContactTel"]!=null)
				{
					model.U_WorkingContactTel=row["U_WorkingContactTel"].ToString();
				}
				if(row["U_BloodType"]!=null && row["U_BloodType"].ToString()!="")
				{
					model.U_BloodType=int.Parse(row["U_BloodType"].ToString());
				}
				if(row["U_NationID"]!=null && row["U_NationID"].ToString()!="")
				{
					model.U_NationID=int.Parse(row["U_NationID"].ToString());
				}
				if(row["U_MarriageStatus"]!=null && row["U_MarriageStatus"].ToString()!="")
				{
					model.U_MarriageStatus=int.Parse(row["U_MarriageStatus"].ToString());
				}
				if(row["U_PermanentType"]!=null && row["U_PermanentType"].ToString()!="")
				{
					model.U_PermanentType=int.Parse(row["U_PermanentType"].ToString());
				}
				if(row["U_Education"]!=null && row["U_Education"].ToString()!="")
				{
					model.U_Education=int.Parse(row["U_Education"].ToString());
				}
				if(row["U_PaymentType"]!=null)
				{
					model.U_PaymentType=row["U_PaymentType"].ToString();
				}
				if(row["U_SocialNO"]!=null)
				{
					model.U_SocialNO=row["U_SocialNO"].ToString();
				}
				if(row["U_MedicalNO"]!=null)
				{
					model.U_MedicalNO=row["U_MedicalNO"].ToString();
				}
				if(row["U_FamilyCode"]!=null)
				{
					model.U_FamilyCode=row["U_FamilyCode"].ToString();
				}
				if(row["U_RelationShip"]!=null && row["U_RelationShip"].ToString()!="")
				{
					model.U_RelationShip=int.Parse(row["U_RelationShip"].ToString());
				}
				if(row["U_auditStatus"]!=null && row["U_auditStatus"].ToString()!="")
				{
					model.U_AuditStatus=int.Parse(row["U_auditStatus"].ToString());
				}
                if (row["U_Note"] != null)
                {
                    model.U_Note = row["U_Note"].ToString();
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
			strSql.Append("select UserID,U_Hometown,U_CurrentAddress,U_FilingUnits,U_FilingUserID,U_ResponsibilityUserID,U_Committee,U_FlingTime,U_WorkingUnits,U_WorkingContactName,U_WorkingContactTel,U_BloodType,U_NationID,U_MarriageStatus,U_PermanentType,U_Education,U_PaymentType,U_SocialNO,U_MedicalNO,U_FamilyCode,U_RelationShip,U_auditStatus,U_Note ");
			strSql.Append(" FROM record_UserBaseInfo ");
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
            strSql.Append(" UserID,U_Hometown,U_CurrentAddress,U_FilingUnits,U_FilingUserID,U_ResponsibilityUserID,U_Committee,U_FlingTime,U_WorkingUnits,U_WorkingContactName,U_WorkingContactTel,U_BloodType,U_NationID,U_MarriageStatus,U_PermanentType,U_Education,U_PaymentType,U_SocialNO,U_MedicalNO,U_FamilyCode,U_RelationShip,U_auditStatus,U_Note ");
			strSql.Append(" FROM record_UserBaseInfo ");
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
			strSql.Append("select count(1) FROM record_UserBaseInfo ");
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
			strSql.Append(")AS Row, T.*  from record_UserBaseInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
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
			parameters[0].Value = "record_UserBaseInfo";
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

