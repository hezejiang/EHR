/**  版本信息模板在安装目录下，可自行修改。
* extend_GeneticDisease.cs
*
* 功 能： N/A
* 类 名： extend_GeneticDisease
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:03   N/A    初版
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
	/// 数据访问类:extend_GeneticDisease
	/// </summary>
	public partial class extend_GeneticDisease:Iextend_GeneticDisease
	{
		public extend_GeneticDisease()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("GeneticDiseaseID", "extend_GeneticDisease"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GeneticDiseaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from extend_GeneticDisease");
			strSql.Append(" where GeneticDiseaseID=@GeneticDiseaseID");
			SqlParameter[] parameters = {
					new SqlParameter("@GeneticDiseaseID", SqlDbType.Int,4)
			};
			parameters[0].Value = GeneticDiseaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.extend_GeneticDisease model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into extend_GeneticDisease(");
			strSql.Append("GD_Name,GD_UserID)");
			strSql.Append(" values (");
			strSql.Append("@GD_Name,@GD_UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GD_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@GD_UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.GD_Name;
			parameters[1].Value = model.GD_UserID;

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
		public bool Update(Maticsoft.Model.extend_GeneticDisease model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update extend_GeneticDisease set ");
			strSql.Append("GD_Name=@GD_Name,");
			strSql.Append("GD_UserID=@GD_UserID");
			strSql.Append(" where GeneticDiseaseID=@GeneticDiseaseID");
			SqlParameter[] parameters = {
					new SqlParameter("@GD_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@GD_UserID", SqlDbType.Int,4),
					new SqlParameter("@GeneticDiseaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.GD_Name;
			parameters[1].Value = model.GD_UserID;
			parameters[2].Value = model.GeneticDiseaseID;

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
		public bool Delete(int GeneticDiseaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_GeneticDisease ");
			strSql.Append(" where GeneticDiseaseID=@GeneticDiseaseID");
			SqlParameter[] parameters = {
					new SqlParameter("@GeneticDiseaseID", SqlDbType.Int,4)
			};
			parameters[0].Value = GeneticDiseaseID;

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
		public bool DeleteList(string GeneticDiseaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_GeneticDisease ");
			strSql.Append(" where GeneticDiseaseID in ("+GeneticDiseaseIDlist + ")  ");
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
		public Maticsoft.Model.extend_GeneticDisease GetModel(int GeneticDiseaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GeneticDiseaseID,GD_Name,GD_UserID from extend_GeneticDisease ");
			strSql.Append(" where GeneticDiseaseID=@GeneticDiseaseID");
			SqlParameter[] parameters = {
					new SqlParameter("@GeneticDiseaseID", SqlDbType.Int,4)
			};
			parameters[0].Value = GeneticDiseaseID;

			Maticsoft.Model.extend_GeneticDisease model=new Maticsoft.Model.extend_GeneticDisease();
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
		public Maticsoft.Model.extend_GeneticDisease DataRowToModel(DataRow row)
		{
			Maticsoft.Model.extend_GeneticDisease model=new Maticsoft.Model.extend_GeneticDisease();
			if (row != null)
			{
				if(row["GeneticDiseaseID"]!=null && row["GeneticDiseaseID"].ToString()!="")
				{
					model.GeneticDiseaseID=int.Parse(row["GeneticDiseaseID"].ToString());
				}
				if(row["GD_Name"]!=null)
				{
					model.GD_Name=row["GD_Name"].ToString();
				}
				if(row["GD_UserID"]!=null && row["GD_UserID"].ToString()!="")
				{
					model.GD_UserID=int.Parse(row["GD_UserID"].ToString());
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
			strSql.Append("select GeneticDiseaseID,GD_Name,GD_UserID ");
			strSql.Append(" FROM extend_GeneticDisease ");
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
			strSql.Append(" GeneticDiseaseID,GD_Name,GD_UserID ");
			strSql.Append(" FROM extend_GeneticDisease ");
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
			strSql.Append("select count(1) FROM extend_GeneticDisease ");
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
				strSql.Append("order by T.GeneticDiseaseID desc");
			}
			strSql.Append(")AS Row, T.*  from extend_GeneticDisease T ");
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
			parameters[0].Value = "extend_GeneticDisease";
			parameters[1].Value = "GeneticDiseaseID";
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

