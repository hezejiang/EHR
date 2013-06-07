using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_FollowUp
	/// </summary>
	public partial class record_FollowUp:Irecord_FollowUp
	{
		public record_FollowUp()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FollowUpID", "record_FollowUp"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FollowUpID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_FollowUp");
			strSql.Append(" where FollowUpID=@FollowUpID");
			SqlParameter[] parameters = {
					new SqlParameter("@FollowUpID", SqlDbType.Int,4)
			};
			parameters[0].Value = FollowUpID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.record_FollowUp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_FollowUp(");
			strSql.Append("F_PatientID,F_Type,F_Date,F_Status)");
			strSql.Append(" values (");
			strSql.Append("@F_PatientID,@F_Type,@F_Date,@F_Status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_PatientID", SqlDbType.Int,4),
					new SqlParameter("@F_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Date", SqlDbType.DateTime),
					new SqlParameter("@F_Status", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.F_PatientID;
			parameters[1].Value = model.F_Type;
			parameters[2].Value = model.F_Date;
			parameters[3].Value = model.F_Status;

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
		public bool Update(Maticsoft.Model.record_FollowUp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_FollowUp set ");
			strSql.Append("F_PatientID=@F_PatientID,");
			strSql.Append("F_Type=@F_Type,");
			strSql.Append("F_Date=@F_Date,");
			strSql.Append("F_Status=@F_Status");
			strSql.Append(" where FollowUpID=@FollowUpID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_PatientID", SqlDbType.Int,4),
					new SqlParameter("@F_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Date", SqlDbType.DateTime),
					new SqlParameter("@F_Status", SqlDbType.TinyInt,1),
					new SqlParameter("@FollowUpID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_PatientID;
			parameters[1].Value = model.F_Type;
			parameters[2].Value = model.F_Date;
			parameters[3].Value = model.F_Status;
			parameters[4].Value = model.FollowUpID;

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
		public bool Delete(int FollowUpID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_FollowUp ");
			strSql.Append(" where FollowUpID=@FollowUpID");
			SqlParameter[] parameters = {
					new SqlParameter("@FollowUpID", SqlDbType.Int,4)
			};
			parameters[0].Value = FollowUpID;

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
		public bool DeleteList(string FollowUpIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_FollowUp ");
			strSql.Append(" where FollowUpID in ("+FollowUpIDlist + ")  ");
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
		public Maticsoft.Model.record_FollowUp GetModel(int FollowUpID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 * from record_FollowUp TT  join record_UserBaseInfo TTT on TT.F_PatientID=TTT.UserID join sys_User TTTT on TT.F_PatientID=TTTT.UserID ");
			strSql.Append(" where FollowUpID=@FollowUpID");
			SqlParameter[] parameters = {
					new SqlParameter("@FollowUpID", SqlDbType.Int,4)
			};
			parameters[0].Value = FollowUpID;

			Maticsoft.Model.record_FollowUp model=new Maticsoft.Model.record_FollowUp();
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
		public Maticsoft.Model.record_FollowUp DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_FollowUp model=new Maticsoft.Model.record_FollowUp();
			if (row != null)
			{
				if(row["FollowUpID"]!=null && row["FollowUpID"].ToString()!="")
				{
					model.FollowUpID=int.Parse(row["FollowUpID"].ToString());
				}
				if(row["F_PatientID"]!=null && row["F_PatientID"].ToString()!="")
				{
					model.F_PatientID=int.Parse(row["F_PatientID"].ToString());
				}
				if(row["F_Type"]!=null && row["F_Type"].ToString()!="")
				{
					model.F_Type=int.Parse(row["F_Type"].ToString());
				}
				if(row["F_Date"]!=null && row["F_Date"].ToString()!="")
				{
					model.F_Date=DateTime.Parse(row["F_Date"].ToString());
				}
				if(row["F_Status"]!=null && row["F_Status"].ToString()!="")
				{
					model.F_Status=int.Parse(row["F_Status"].ToString());
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
			strSql.Append("select FollowUpID,F_PatientID,F_Type,F_Date,F_Status ");
			strSql.Append(" FROM record_FollowUp ");
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
			strSql.Append(" FollowUpID,F_PatientID,F_Type,F_Date,F_Status ");
			strSql.Append(" FROM record_FollowUp ");
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
            strSql.Append("select count(1) FROM record_FollowUp TT join record_UserBaseInfo TTT on TT.F_PatientID=TTT.UserID join sys_User TTTT on TT.F_PatientID=TTTT.UserID ");
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
				strSql.Append("order by T.FollowUpID desc");
			}
			strSql.Append(")AS Row, T.*  from record_FollowUp T ");
            strSql.Append(" ) TT join record_UserBaseInfo TTT on TT.F_PatientID=TTT.UserID join sys_User TTTT on TT.F_PatientID=TTTT.UserID ");
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
			parameters[0].Value = "record_FollowUp";
			parameters[1].Value = "FollowUpID";
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

