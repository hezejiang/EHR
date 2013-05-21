/**  版本信息模板在安装目录下，可自行修改。
* extend_FamilyHistory.cs
*
* 功 能： N/A
* 类 名： extend_FamilyHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:02   N/A    初版
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
	/// 数据访问类:extend_FamilyHistory
	/// </summary>
	public partial class extend_FamilyHistory:Iextend_FamilyHistory
	{
		public extend_FamilyHistory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FamilyHistoryID", "extend_FamilyHistory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FamilyHistoryID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from extend_FamilyHistory");
			strSql.Append(" where FamilyHistoryID=@FamilyHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@FamilyHistoryID", SqlDbType.Int,4)
			};
			parameters[0].Value = FamilyHistoryID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.extend_FamilyHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into extend_FamilyHistory(");
			strSql.Append("FH_Type,FH_Who,FH_Note,FH_UserID)");
			strSql.Append(" values (");
			strSql.Append("@FH_Type,@FH_Who,@FH_Note,@FH_UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FH_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@FH_Who", SqlDbType.TinyInt,1),
					new SqlParameter("@FH_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@FH_UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.FH_Type;
			parameters[1].Value = model.FH_Who;
			parameters[2].Value = model.FH_Note;
			parameters[3].Value = model.FH_UserID;

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
		public bool Update(Maticsoft.Model.extend_FamilyHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update extend_FamilyHistory set ");
			strSql.Append("FH_Type=@FH_Type,");
			strSql.Append("FH_Who=@FH_Who,");
			strSql.Append("FH_Note=@FH_Note,");
			strSql.Append("FH_UserID=@FH_UserID");
			strSql.Append(" where FamilyHistoryID=@FamilyHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@FH_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@FH_Who", SqlDbType.TinyInt,1),
					new SqlParameter("@FH_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@FH_UserID", SqlDbType.Int,4),
					new SqlParameter("@FamilyHistoryID", SqlDbType.Int,4)};
			parameters[0].Value = model.FH_Type;
			parameters[1].Value = model.FH_Who;
			parameters[2].Value = model.FH_Note;
			parameters[3].Value = model.FH_UserID;
			parameters[4].Value = model.FamilyHistoryID;

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
		public bool Delete(int FamilyHistoryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_FamilyHistory ");
			strSql.Append(" where FamilyHistoryID=@FamilyHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@FamilyHistoryID", SqlDbType.Int,4)
			};
			parameters[0].Value = FamilyHistoryID;

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
		public bool DeleteList(string FamilyHistoryIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_FamilyHistory ");
			strSql.Append(" where FamilyHistoryID in ("+FamilyHistoryIDlist + ")  ");
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
		public Maticsoft.Model.extend_FamilyHistory GetModel(int FamilyHistoryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FamilyHistoryID,FH_Type,FH_Who,FH_Note,FH_UserID from extend_FamilyHistory ");
			strSql.Append(" where FamilyHistoryID=@FamilyHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@FamilyHistoryID", SqlDbType.Int,4)
			};
			parameters[0].Value = FamilyHistoryID;

			Maticsoft.Model.extend_FamilyHistory model=new Maticsoft.Model.extend_FamilyHistory();
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
		public Maticsoft.Model.extend_FamilyHistory DataRowToModel(DataRow row)
		{
			Maticsoft.Model.extend_FamilyHistory model=new Maticsoft.Model.extend_FamilyHistory();
			if (row != null)
			{
				if(row["FamilyHistoryID"]!=null && row["FamilyHistoryID"].ToString()!="")
				{
					model.FamilyHistoryID=int.Parse(row["FamilyHistoryID"].ToString());
				}
				if(row["FH_Type"]!=null && row["FH_Type"].ToString()!="")
				{
					model.FH_Type=int.Parse(row["FH_Type"].ToString());
				}
				if(row["FH_Who"]!=null && row["FH_Who"].ToString()!="")
				{
					model.FH_Who=int.Parse(row["FH_Who"].ToString());
				}
				if(row["FH_Note"]!=null)
				{
					model.FH_Note=row["FH_Note"].ToString();
				}
				if(row["FH_UserID"]!=null && row["FH_UserID"].ToString()!="")
				{
					model.FH_UserID=int.Parse(row["FH_UserID"].ToString());
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
			strSql.Append("select FamilyHistoryID,FH_Type,FH_Who,FH_Note,FH_UserID ");
			strSql.Append(" FROM extend_FamilyHistory ");
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
			strSql.Append(" FamilyHistoryID,FH_Type,FH_Who,FH_Note,FH_UserID ");
			strSql.Append(" FROM extend_FamilyHistory ");
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
			strSql.Append("select count(1) FROM extend_FamilyHistory ");
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
				strSql.Append("order by T.FamilyHistoryID desc");
			}
			strSql.Append(")AS Row, T.*  from extend_FamilyHistory T ");
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
			parameters[0].Value = "extend_FamilyHistory";
			parameters[1].Value = "FamilyHistoryID";
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

