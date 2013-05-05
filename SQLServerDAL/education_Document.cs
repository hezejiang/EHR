﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:education_Document
	/// </summary>
	public partial class education_Document:Ieducation_Document
	{
		public education_Document()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DocumentID", "education_Document"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DocumentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from education_Document");
			strSql.Append(" where DocumentID=@DocumentID");
			SqlParameter[] parameters = {
					new SqlParameter("@DocumentID", SqlDbType.Int,4)
			};
			parameters[0].Value = DocumentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.education_Document model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into education_Document(");
			strSql.Append("D_Name,D_Url)");
			strSql.Append(" values (");
			strSql.Append("@D_Name,@D_Url)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@D_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@D_Url", SqlDbType.VarChar,2038)};
			parameters[0].Value = model.D_Name;
			parameters[1].Value = model.D_Url;

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
		public bool Update(Maticsoft.Model.education_Document model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update education_Document set ");
			strSql.Append("D_Name=@D_Name,");
			strSql.Append("D_Url=@D_Url");
			strSql.Append(" where DocumentID=@DocumentID");
			SqlParameter[] parameters = {
					new SqlParameter("@D_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@D_Url", SqlDbType.VarChar,2038),
					new SqlParameter("@DocumentID", SqlDbType.Int,4)};
			parameters[0].Value = model.D_Name;
			parameters[1].Value = model.D_Url;
			parameters[2].Value = model.DocumentID;

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
		public bool Delete(int DocumentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from education_Document ");
			strSql.Append(" where DocumentID=@DocumentID");
			SqlParameter[] parameters = {
					new SqlParameter("@DocumentID", SqlDbType.Int,4)
			};
			parameters[0].Value = DocumentID;

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
		public bool DeleteList(string DocumentIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from education_Document ");
			strSql.Append(" where DocumentID in ("+DocumentIDlist + ")  ");
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
		public Maticsoft.Model.education_Document GetModel(int DocumentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DocumentID,D_Name,D_Url from education_Document ");
			strSql.Append(" where DocumentID=@DocumentID");
			SqlParameter[] parameters = {
					new SqlParameter("@DocumentID", SqlDbType.Int,4)
			};
			parameters[0].Value = DocumentID;

			Maticsoft.Model.education_Document model=new Maticsoft.Model.education_Document();
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
		public Maticsoft.Model.education_Document DataRowToModel(DataRow row)
		{
			Maticsoft.Model.education_Document model=new Maticsoft.Model.education_Document();
			if (row != null)
			{
				if(row["DocumentID"]!=null && row["DocumentID"].ToString()!="")
				{
					model.DocumentID=int.Parse(row["DocumentID"].ToString());
				}
				if(row["D_Name"]!=null)
				{
					model.D_Name=row["D_Name"].ToString();
				}
				if(row["D_Url"]!=null)
				{
					model.D_Url=row["D_Url"].ToString();
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
			strSql.Append("select DocumentID,D_Name,D_Url ");
			strSql.Append(" FROM education_Document ");
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
			strSql.Append(" DocumentID,D_Name,D_Url ");
			strSql.Append(" FROM education_Document ");
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
			strSql.Append("select count(1) FROM education_Document ");
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
				strSql.Append("order by T.DocumentID desc");
			}
			strSql.Append(")AS Row, T.*  from education_Document T ");
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
			parameters[0].Value = "education_Document";
			parameters[1].Value = "DocumentID";
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

