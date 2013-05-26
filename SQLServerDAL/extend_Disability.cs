/**  版本信息模板在安装目录下，可自行修改。
* extend_Disability.cs
*
* 功 能： N/A
* 类 名： extend_Disability
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
	/// 数据访问类:extend_Disability
	/// </summary>
	public partial class extend_Disability:Iextend_Disability
	{
		public extend_Disability()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DisabilityID", "extend_Disability"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DisabilityID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from extend_Disability");
			strSql.Append(" where DisabilityID=@DisabilityID");
			SqlParameter[] parameters = {
					new SqlParameter("@DisabilityID", SqlDbType.Int,4)
			};
			parameters[0].Value = DisabilityID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.extend_Disability model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into extend_Disability(");
			strSql.Append("D_Type,D_Note,D_UserID)");
			strSql.Append(" values (");
			strSql.Append("@D_Type,@D_Note,@D_UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@D_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@D_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@D_UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.D_Type;
			parameters[1].Value = model.D_Note;
			parameters[2].Value = model.D_UserID;

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
		public bool Update(Maticsoft.Model.extend_Disability model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update extend_Disability set ");
			strSql.Append("D_Type=@D_Type,");
			strSql.Append("D_Note=@D_Note,");
			strSql.Append("D_UserID=@D_UserID");
			strSql.Append(" where DisabilityID=@DisabilityID");
			SqlParameter[] parameters = {
					new SqlParameter("@D_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@D_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@D_UserID", SqlDbType.Int,4),
					new SqlParameter("@DisabilityID", SqlDbType.Int,4)};
			parameters[0].Value = model.D_Type;
			parameters[1].Value = model.D_Note;
			parameters[2].Value = model.D_UserID;
			parameters[3].Value = model.DisabilityID;

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
		public bool Delete(int DisabilityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_Disability ");
			strSql.Append(" where DisabilityID=@DisabilityID");
			SqlParameter[] parameters = {
					new SqlParameter("@DisabilityID", SqlDbType.Int,4)
			};
			parameters[0].Value = DisabilityID;

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
		public bool DeleteList(string DisabilityIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extend_Disability ");
			strSql.Append(" where DisabilityID in ("+DisabilityIDlist + ")  ");
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
		public Maticsoft.Model.extend_Disability GetModel(int DisabilityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DisabilityID,D_Type,D_Note,D_UserID from extend_Disability ");
			strSql.Append(" where DisabilityID=@DisabilityID");
			SqlParameter[] parameters = {
					new SqlParameter("@DisabilityID", SqlDbType.Int,4)
			};
			parameters[0].Value = DisabilityID;

			Maticsoft.Model.extend_Disability model=new Maticsoft.Model.extend_Disability();
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
        public Maticsoft.Model.extend_Disability GetModel(string strWhere)
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
		public Maticsoft.Model.extend_Disability DataRowToModel(DataRow row)
		{
			Maticsoft.Model.extend_Disability model=new Maticsoft.Model.extend_Disability();
			if (row != null)
			{
				if(row["DisabilityID"]!=null && row["DisabilityID"].ToString()!="")
				{
					model.DisabilityID=int.Parse(row["DisabilityID"].ToString());
				}
				if(row["D_Type"]!=null && row["D_Type"].ToString()!="")
				{
					model.D_Type=int.Parse(row["D_Type"].ToString());
				}
				if(row["D_Note"]!=null)
				{
					model.D_Note=row["D_Note"].ToString();
				}
				if(row["D_UserID"]!=null && row["D_UserID"].ToString()!="")
				{
					model.D_UserID=int.Parse(row["D_UserID"].ToString());
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
			strSql.Append("select DisabilityID,D_Type,D_Note,D_UserID ");
			strSql.Append(" FROM extend_Disability ");
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
			strSql.Append(" DisabilityID,D_Type,D_Note,D_UserID ");
			strSql.Append(" FROM extend_Disability ");
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
			strSql.Append("select count(1) FROM extend_Disability ");
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
				strSql.Append("order by T.DisabilityID desc");
			}
			strSql.Append(")AS Row, T.*  from extend_Disability T ");
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
			parameters[0].Value = "extend_Disability";
			parameters[1].Value = "DisabilityID";
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

