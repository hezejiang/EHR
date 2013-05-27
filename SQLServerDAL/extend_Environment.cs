/**  版本信息模板在安装目录下，可自行修改。
* extend_Environment.cs
*
* 功 能： N/A
* 类 名： extend_Environment
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
	/// 数据访问类:extend_Environment
	/// </summary>
	public partial class extend_Environment:Iextend_Environment
	{
		public extend_Environment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EnvironmentID", "extend_Environment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EnvironmentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from extend_Environment");
			strSql.Append(" where EnvironmentID=@EnvironmentID");
			SqlParameter[] parameters = {
					new SqlParameter("@EnvironmentID", SqlDbType.Int,4)
			};
			parameters[0].Value = EnvironmentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.extend_Environment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into extend_Environment(");
			strSql.Append("E_Kind,E_Type,E_UserID)");
			strSql.Append(" values (");
			strSql.Append("@E_Kind,@E_Type,@E_UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@E_Kind", SqlDbType.TinyInt,1),
					new SqlParameter("@E_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@E_UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_Kind;
			parameters[1].Value = model.E_Type;
			parameters[2].Value = model.E_UserID;

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
		public bool Update(Maticsoft.Model.extend_Environment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update extend_Environment set ");
			strSql.Append("E_Kind=@E_Kind,");
			strSql.Append("E_Type=@E_Type,");
			strSql.Append("E_UserID=@E_UserID");
			strSql.Append(" where EnvironmentID=@EnvironmentID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_Kind", SqlDbType.TinyInt,1),
					new SqlParameter("@E_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@E_UserID", SqlDbType.Int,4),
					new SqlParameter("@EnvironmentID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_Kind;
			parameters[1].Value = model.E_Type;
			parameters[2].Value = model.E_UserID;
			parameters[3].Value = model.EnvironmentID;

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
		public bool Delete(int EnvironmentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_Environment ");
			strSql.Append(" where EnvironmentID=@EnvironmentID");
			SqlParameter[] parameters = {
					new SqlParameter("@EnvironmentID", SqlDbType.Int,4)
			};
			parameters[0].Value = EnvironmentID;

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
		public bool DeleteList(string EnvironmentIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_Environment ");
			strSql.Append(" where EnvironmentID in ("+EnvironmentIDlist + ")  ");
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
		public Maticsoft.Model.extend_Environment GetModel(int EnvironmentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EnvironmentID,E_Kind,E_Type,E_UserID from extend_Environment ");
			strSql.Append(" where EnvironmentID=@EnvironmentID");
			SqlParameter[] parameters = {
					new SqlParameter("@EnvironmentID", SqlDbType.Int,4)
			};
			parameters[0].Value = EnvironmentID;

			Maticsoft.Model.extend_Environment model=new Maticsoft.Model.extend_Environment();
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
        public Maticsoft.Model.extend_Environment GetModel(string  strWhere)
        {
            DataSet ds = GetList(strWhere);
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
		public Maticsoft.Model.extend_Environment DataRowToModel(DataRow row)
		{
			Maticsoft.Model.extend_Environment model=new Maticsoft.Model.extend_Environment();
			if (row != null)
			{
				if(row["EnvironmentID"]!=null && row["EnvironmentID"].ToString()!="")
				{
					model.EnvironmentID=int.Parse(row["EnvironmentID"].ToString());
				}
				if(row["E_Kind"]!=null && row["E_Kind"].ToString()!="")
				{
					model.E_Kind=int.Parse(row["E_Kind"].ToString());
				}
				if(row["E_Type"]!=null && row["E_Type"].ToString()!="")
				{
					model.E_Type=int.Parse(row["E_Type"].ToString());
				}
				if(row["E_UserID"]!=null && row["E_UserID"].ToString()!="")
				{
					model.E_UserID=int.Parse(row["E_UserID"].ToString());
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
			strSql.Append("select EnvironmentID,E_Kind,E_Type,E_UserID ");
			strSql.Append(" FROM extend_Environment ");
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
			strSql.Append(" EnvironmentID,E_Kind,E_Type,E_UserID ");
			strSql.Append(" FROM extend_Environment ");
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
			strSql.Append("select count(1) FROM extend_Environment ");
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
				strSql.Append("order by T.EnvironmentID desc");
			}
			strSql.Append(")AS Row, T.*  from extend_Environment T ");
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
			parameters[0].Value = "extend_Environment";
			parameters[1].Value = "EnvironmentID";
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

