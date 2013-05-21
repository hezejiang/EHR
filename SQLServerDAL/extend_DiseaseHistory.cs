/**  版本信息模板在安装目录下，可自行修改。
* extend_DiseaseHistory.cs
*
* 功 能： N/A
* 类 名： extend_DiseaseHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:01   N/A    初版
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
	/// 数据访问类:extend_DiseaseHistory
	/// </summary>
	public partial class extend_DiseaseHistory:Iextend_DiseaseHistory
	{
		public extend_DiseaseHistory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DiseaseHistoryID", "extend_DiseaseHistory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DiseaseHistoryID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from extend_DiseaseHistory");
			strSql.Append(" where DiseaseHistoryID=@DiseaseHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@DiseaseHistoryID", SqlDbType.Int,4)
			};
			parameters[0].Value = DiseaseHistoryID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.extend_DiseaseHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into extend_DiseaseHistory(");
			strSql.Append("DH_Type,DH_DiagnosisDate,DH_Note,DH_UserID)");
			strSql.Append(" values (");
			strSql.Append("@DH_Type,@DH_DiagnosisDate,@DH_Note,@DH_UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DH_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@DH_DiagnosisDate", SqlDbType.Date,3),
					new SqlParameter("@DH_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@DH_UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.DH_Type;
			parameters[1].Value = model.DH_DiagnosisDate;
			parameters[2].Value = model.DH_Note;
			parameters[3].Value = model.DH_UserID;

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
		public bool Update(Maticsoft.Model.extend_DiseaseHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update extend_DiseaseHistory set ");
			strSql.Append("DH_Type=@DH_Type,");
			strSql.Append("DH_DiagnosisDate=@DH_DiagnosisDate,");
			strSql.Append("DH_Note=@DH_Note,");
			strSql.Append("DH_UserID=@DH_UserID");
			strSql.Append(" where DiseaseHistoryID=@DiseaseHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@DH_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@DH_DiagnosisDate", SqlDbType.Date,3),
					new SqlParameter("@DH_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@DH_UserID", SqlDbType.Int,4),
					new SqlParameter("@DiseaseHistoryID", SqlDbType.Int,4)};
			parameters[0].Value = model.DH_Type;
			parameters[1].Value = model.DH_DiagnosisDate;
			parameters[2].Value = model.DH_Note;
			parameters[3].Value = model.DH_UserID;
			parameters[4].Value = model.DiseaseHistoryID;

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
		public bool Delete(int DiseaseHistoryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_DiseaseHistory ");
			strSql.Append(" where DiseaseHistoryID=@DiseaseHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@DiseaseHistoryID", SqlDbType.Int,4)
			};
			parameters[0].Value = DiseaseHistoryID;

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
		public bool DeleteList(string DiseaseHistoryIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_DiseaseHistory ");
			strSql.Append(" where DiseaseHistoryID in ("+DiseaseHistoryIDlist + ")  ");
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
		public Maticsoft.Model.extend_DiseaseHistory GetModel(int DiseaseHistoryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DiseaseHistoryID,DH_Type,DH_DiagnosisDate,DH_Note,DH_UserID from extend_DiseaseHistory ");
			strSql.Append(" where DiseaseHistoryID=@DiseaseHistoryID");
			SqlParameter[] parameters = {
					new SqlParameter("@DiseaseHistoryID", SqlDbType.Int,4)
			};
			parameters[0].Value = DiseaseHistoryID;

			Maticsoft.Model.extend_DiseaseHistory model=new Maticsoft.Model.extend_DiseaseHistory();
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
		public Maticsoft.Model.extend_DiseaseHistory DataRowToModel(DataRow row)
		{
			Maticsoft.Model.extend_DiseaseHistory model=new Maticsoft.Model.extend_DiseaseHistory();
			if (row != null)
			{
				if(row["DiseaseHistoryID"]!=null && row["DiseaseHistoryID"].ToString()!="")
				{
					model.DiseaseHistoryID=int.Parse(row["DiseaseHistoryID"].ToString());
				}
				if(row["DH_Type"]!=null && row["DH_Type"].ToString()!="")
				{
					model.DH_Type=int.Parse(row["DH_Type"].ToString());
				}
				if(row["DH_DiagnosisDate"]!=null && row["DH_DiagnosisDate"].ToString()!="")
				{
					model.DH_DiagnosisDate=DateTime.Parse(row["DH_DiagnosisDate"].ToString());
				}
				if(row["DH_Note"]!=null)
				{
					model.DH_Note=row["DH_Note"].ToString();
				}
				if(row["DH_UserID"]!=null && row["DH_UserID"].ToString()!="")
				{
					model.DH_UserID=int.Parse(row["DH_UserID"].ToString());
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
			strSql.Append("select DiseaseHistoryID,DH_Type,DH_DiagnosisDate,DH_Note,DH_UserID ");
			strSql.Append(" FROM extend_DiseaseHistory ");
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
			strSql.Append(" DiseaseHistoryID,DH_Type,DH_DiagnosisDate,DH_Note,DH_UserID ");
			strSql.Append(" FROM extend_DiseaseHistory ");
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
			strSql.Append("select count(1) FROM extend_DiseaseHistory ");
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
			parameters[0].Value = "extend_DiseaseHistory";
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

