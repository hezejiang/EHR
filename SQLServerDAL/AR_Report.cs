/**  版本信息模板在安装目录下，可自行修改。
* AR_Report.cs
*
* 功 能： N/A
* 类 名： AR_Report
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/20 21:58:53   N/A    初版
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
	/// 数据访问类:AR_Report
	/// </summary>
	public partial class AR_Report:IAR_Report
	{
		public AR_Report()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ReportID", "AR_Report"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ReportID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AR_Report");
			strSql.Append(" where ReportID=@ReportID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportID", SqlDbType.Int,4)
			};
			parameters[0].Value = ReportID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.AR_Report model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AR_Report(");
			strSql.Append("R_Title,R_Content,R_DateTime,R_ResponsibilityUserID,R_Type,R_Status,R_GroupID)");
			strSql.Append(" values (");
			strSql.Append("@R_Title,@R_Content,@R_DateTime,@R_ResponsibilityUserID,@R_Type,@R_Status,@R_GroupID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@R_Title", SqlDbType.NVarChar,255),
					new SqlParameter("@R_Content", SqlDbType.Text),
					new SqlParameter("@R_DateTime", SqlDbType.DateTime),
					new SqlParameter("@R_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@R_Type", SqlDbType.Int,4),
					new SqlParameter("@R_Status", SqlDbType.Int,4),
					new SqlParameter("@R_GroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.R_Title;
			parameters[1].Value = model.R_Content;
			parameters[2].Value = model.R_DateTime;
			parameters[3].Value = model.R_ResponsibilityUserID;
			parameters[4].Value = model.R_Type;
			parameters[5].Value = model.R_Status;
			parameters[6].Value = model.R_GroupID;

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
		public bool Update(Maticsoft.Model.AR_Report model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AR_Report set ");
			strSql.Append("R_Title=@R_Title,");
			strSql.Append("R_Content=@R_Content,");
			strSql.Append("R_DateTime=@R_DateTime,");
			strSql.Append("R_ResponsibilityUserID=@R_ResponsibilityUserID,");
			strSql.Append("R_Type=@R_Type,");
			strSql.Append("R_Status=@R_Status,");
			strSql.Append("R_GroupID=@R_GroupID");
			strSql.Append(" where ReportID=@ReportID");
			SqlParameter[] parameters = {
					new SqlParameter("@R_Title", SqlDbType.NVarChar,255),
					new SqlParameter("@R_Content", SqlDbType.Text),
					new SqlParameter("@R_DateTime", SqlDbType.DateTime),
					new SqlParameter("@R_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@R_Type", SqlDbType.Int,4),
					new SqlParameter("@R_Status", SqlDbType.Int,4),
					new SqlParameter("@R_GroupID", SqlDbType.Int,4),
					new SqlParameter("@ReportID", SqlDbType.Int,4)};
			parameters[0].Value = model.R_Title;
			parameters[1].Value = model.R_Content;
			parameters[2].Value = model.R_DateTime;
			parameters[3].Value = model.R_ResponsibilityUserID;
			parameters[4].Value = model.R_Type;
			parameters[5].Value = model.R_Status;
			parameters[6].Value = model.R_GroupID;
			parameters[7].Value = model.ReportID;

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
		public bool Delete(int ReportID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AR_Report ");
			strSql.Append(" where ReportID=@ReportID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportID", SqlDbType.Int,4)
			};
			parameters[0].Value = ReportID;

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
		public bool DeleteList(string ReportIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AR_Report ");
			strSql.Append(" where ReportID in ("+ReportIDlist + ")  ");
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
		public Maticsoft.Model.AR_Report GetModel(int ReportID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ReportID,R_Title,R_Content,R_DateTime,R_ResponsibilityUserID,R_Type,R_Status,R_GroupID from AR_Report ");
			strSql.Append(" where ReportID=@ReportID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportID", SqlDbType.Int,4)
			};
			parameters[0].Value = ReportID;

			Maticsoft.Model.AR_Report model=new Maticsoft.Model.AR_Report();
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
		public Maticsoft.Model.AR_Report DataRowToModel(DataRow row)
		{
			Maticsoft.Model.AR_Report model=new Maticsoft.Model.AR_Report();
			if (row != null)
			{
				if(row["ReportID"]!=null && row["ReportID"].ToString()!="")
				{
					model.ReportID=int.Parse(row["ReportID"].ToString());
				}
				if(row["R_Title"]!=null)
				{
					model.R_Title=row["R_Title"].ToString();
				}
				if(row["R_Content"]!=null)
				{
					model.R_Content=row["R_Content"].ToString();
				}
				if(row["R_DateTime"]!=null && row["R_DateTime"].ToString()!="")
				{
					model.R_DateTime=DateTime.Parse(row["R_DateTime"].ToString());
				}
				if(row["R_ResponsibilityUserID"]!=null && row["R_ResponsibilityUserID"].ToString()!="")
				{
					model.R_ResponsibilityUserID=int.Parse(row["R_ResponsibilityUserID"].ToString());
				}
				if(row["R_Type"]!=null && row["R_Type"].ToString()!="")
				{
					model.R_Type=int.Parse(row["R_Type"].ToString());
				}
				if(row["R_Status"]!=null && row["R_Status"].ToString()!="")
				{
					model.R_Status=int.Parse(row["R_Status"].ToString());
				}
				if(row["R_GroupID"]!=null && row["R_GroupID"].ToString()!="")
				{
					model.R_GroupID=int.Parse(row["R_GroupID"].ToString());
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
			strSql.Append("select ReportID,R_Title,R_Content,R_DateTime,R_ResponsibilityUserID,R_Type,R_Status,R_GroupID ");
			strSql.Append(" FROM AR_Report ");
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
			strSql.Append(" ReportID,R_Title,R_Content,R_DateTime,R_ResponsibilityUserID,R_Type,R_Status,R_GroupID ");
			strSql.Append(" FROM AR_Report ");
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
			strSql.Append("select count(1) FROM AR_Report ");
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
				strSql.Append("order by T.ReportID desc");
			}
			strSql.Append(")AS Row, T.*  from AR_Report T ");
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
			parameters[0].Value = "AR_Report";
			parameters[1].Value = "ReportID";
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

