/**  版本信息模板在安装目录下，可自行修改。
* record_Consultation.cs
*
* 功 能： N/A
* 类 名： record_Consultation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/5/28 18:55:23   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_Consultation
	/// </summary>
	public partial class record_Consultation:Irecord_Consultation
	{
		public record_Consultation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ConsultationID", "record_Consultation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ConsultationID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_Consultation");
			strSql.Append(" where ConsultationID=@ConsultationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsultationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ConsultationID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.record_Consultation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_Consultation(");
			strSql.Append("C_UserID,C_Cause,C_Comments,C_Time,C_Dortor)");
			strSql.Append(" values (");
			strSql.Append("@C_UserID,@C_Cause,@C_Comments,@C_Time,@C_Dortor)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@C_UserID", SqlDbType.Int,4),
					new SqlParameter("@C_Cause", SqlDbType.Text),
					new SqlParameter("@C_Comments", SqlDbType.Text),
					new SqlParameter("@C_Time", SqlDbType.DateTime),
					new SqlParameter("@C_Dortor", SqlDbType.Int,4)};
			parameters[0].Value = model.C_UserID;
			parameters[1].Value = model.C_Cause;
			parameters[2].Value = model.C_Comments;
			parameters[3].Value = model.C_Time;
			parameters[4].Value = model.C_Dortor;

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
		public bool Update(Maticsoft.Model.record_Consultation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_Consultation set ");
			strSql.Append("C_UserID=@C_UserID,");
			strSql.Append("C_Cause=@C_Cause,");
			strSql.Append("C_Comments=@C_Comments,");
			strSql.Append("C_Time=@C_Time,");
			strSql.Append("C_Dortor=@C_Dortor");
			strSql.Append(" where ConsultationID=@ConsultationID");
			SqlParameter[] parameters = {
					new SqlParameter("@C_UserID", SqlDbType.Int,4),
					new SqlParameter("@C_Cause", SqlDbType.Text),
					new SqlParameter("@C_Comments", SqlDbType.Text),
					new SqlParameter("@C_Time", SqlDbType.DateTime),
					new SqlParameter("@C_Dortor", SqlDbType.Int,4),
					new SqlParameter("@ConsultationID", SqlDbType.Int,4)};
			parameters[0].Value = model.C_UserID;
			parameters[1].Value = model.C_Cause;
			parameters[2].Value = model.C_Comments;
			parameters[3].Value = model.C_Time;
			parameters[4].Value = model.C_Dortor;
			parameters[5].Value = model.ConsultationID;

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
		public bool Delete(int ConsultationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_Consultation ");
			strSql.Append(" where ConsultationID=@ConsultationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsultationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ConsultationID;

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
		public bool DeleteList(string ConsultationIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_Consultation ");
			strSql.Append(" where ConsultationID in ("+ConsultationIDlist + ")  ");
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
		public Maticsoft.Model.record_Consultation GetModel(int ConsultationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ConsultationID,C_UserID,C_Cause,C_Comments,C_Time,C_Dortor from record_Consultation ");
			strSql.Append(" where ConsultationID=@ConsultationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsultationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ConsultationID;

			Maticsoft.Model.record_Consultation model=new Maticsoft.Model.record_Consultation();
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
		public Maticsoft.Model.record_Consultation DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_Consultation model=new Maticsoft.Model.record_Consultation();
			if (row != null)
			{
				if(row["ConsultationID"]!=null && row["ConsultationID"].ToString()!="")
				{
					model.ConsultationID=int.Parse(row["ConsultationID"].ToString());
				}
				if(row["C_UserID"]!=null && row["C_UserID"].ToString()!="")
				{
					model.C_UserID=int.Parse(row["C_UserID"].ToString());
				}
				if(row["C_Cause"]!=null)
				{
					model.C_Cause=row["C_Cause"].ToString();
				}
				if(row["C_Comments"]!=null)
				{
					model.C_Comments=row["C_Comments"].ToString();
				}
				if(row["C_Time"]!=null && row["C_Time"].ToString()!="")
				{
					model.C_Time=DateTime.Parse(row["C_Time"].ToString());
				}
				if(row["C_Dortor"]!=null && row["C_Dortor"].ToString()!="")
				{
					model.C_Dortor=int.Parse(row["C_Dortor"].ToString());
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
			strSql.Append("select ConsultationID,C_UserID,C_Cause,C_Comments,C_Time,C_Dortor ");
			strSql.Append(" FROM record_Consultation ");
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
			strSql.Append(" ConsultationID,C_UserID,C_Cause,C_Comments,C_Time,C_Dortor ");
			strSql.Append(" FROM record_Consultation ");
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
			strSql.Append("select count(1) FROM record_Consultation ");
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
				strSql.Append("order by T.ConsultationID desc");
			}
			strSql.Append(")AS Row, T.*  from record_Consultation T ");
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
			parameters[0].Value = "record_Consultation";
			parameters[1].Value = "ConsultationID";
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

