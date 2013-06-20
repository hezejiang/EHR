/**  版本信息模板在安装目录下，可自行修改。
* AR_Announcement.cs
*
* 功 能： N/A
* 类 名： AR_Announcement
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/20 22:01:01   N/A    初版
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
	/// 数据访问类:AR_Announcement
	/// </summary>
	public partial class AR_Announcement:IAR_Announcement
	{
		public AR_Announcement()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AnnouncementID", "AR_Announcement"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AnnouncementID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AR_Announcement");
			strSql.Append(" where AnnouncementID=@AnnouncementID");
			SqlParameter[] parameters = {
					new SqlParameter("@AnnouncementID", SqlDbType.Int,4)
			};
			parameters[0].Value = AnnouncementID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.AR_Announcement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AR_Announcement(");
			strSql.Append("A_Title,A_Content,A_DateTime,A_ResponsibilityUserID,A_Type,A_GroupID)");
			strSql.Append(" values (");
			strSql.Append("@A_Title,@A_Content,@A_DateTime,@A_ResponsibilityUserID,@A_Type,@A_GroupID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@A_Title", SqlDbType.NVarChar,255),
					new SqlParameter("@A_Content", SqlDbType.Text),
					new SqlParameter("@A_DateTime", SqlDbType.DateTime),
					new SqlParameter("@A_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@A_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@A_GroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.A_Title;
			parameters[1].Value = model.A_Content;
			parameters[2].Value = model.A_DateTime;
			parameters[3].Value = model.A_ResponsibilityUserID;
			parameters[4].Value = model.A_Type;
			parameters[5].Value = model.A_GroupID;

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
		public bool Update(Maticsoft.Model.AR_Announcement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AR_Announcement set ");
			strSql.Append("A_Title=@A_Title,");
			strSql.Append("A_Content=@A_Content,");
			strSql.Append("A_DateTime=@A_DateTime,");
			strSql.Append("A_ResponsibilityUserID=@A_ResponsibilityUserID,");
			strSql.Append("A_Type=@A_Type,");
			strSql.Append("A_GroupID=@A_GroupID");
			strSql.Append(" where AnnouncementID=@AnnouncementID");
			SqlParameter[] parameters = {
					new SqlParameter("@A_Title", SqlDbType.NVarChar,255),
					new SqlParameter("@A_Content", SqlDbType.Text),
					new SqlParameter("@A_DateTime", SqlDbType.DateTime),
					new SqlParameter("@A_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@A_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@A_GroupID", SqlDbType.Int,4),
					new SqlParameter("@AnnouncementID", SqlDbType.Int,4)};
			parameters[0].Value = model.A_Title;
			parameters[1].Value = model.A_Content;
			parameters[2].Value = model.A_DateTime;
			parameters[3].Value = model.A_ResponsibilityUserID;
			parameters[4].Value = model.A_Type;
			parameters[5].Value = model.A_GroupID;
			parameters[6].Value = model.AnnouncementID;

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
		public bool Delete(int AnnouncementID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AR_Announcement ");
			strSql.Append(" where AnnouncementID=@AnnouncementID");
			SqlParameter[] parameters = {
					new SqlParameter("@AnnouncementID", SqlDbType.Int,4)
			};
			parameters[0].Value = AnnouncementID;

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
		public bool DeleteList(string AnnouncementIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AR_Announcement ");
			strSql.Append(" where AnnouncementID in ("+AnnouncementIDlist + ")  ");
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
		public Maticsoft.Model.AR_Announcement GetModel(int AnnouncementID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AnnouncementID,A_Title,A_Content,A_DateTime,A_ResponsibilityUserID,A_Type,A_GroupID from AR_Announcement ");
			strSql.Append(" where AnnouncementID=@AnnouncementID");
			SqlParameter[] parameters = {
					new SqlParameter("@AnnouncementID", SqlDbType.Int,4)
			};
			parameters[0].Value = AnnouncementID;

			Maticsoft.Model.AR_Announcement model=new Maticsoft.Model.AR_Announcement();
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
		public Maticsoft.Model.AR_Announcement DataRowToModel(DataRow row)
		{
			Maticsoft.Model.AR_Announcement model=new Maticsoft.Model.AR_Announcement();
			if (row != null)
			{
				if(row["AnnouncementID"]!=null && row["AnnouncementID"].ToString()!="")
				{
					model.AnnouncementID=int.Parse(row["AnnouncementID"].ToString());
				}
				if(row["A_Title"]!=null)
				{
					model.A_Title=row["A_Title"].ToString();
				}
				if(row["A_Content"]!=null)
				{
					model.A_Content=row["A_Content"].ToString();
				}
				if(row["A_DateTime"]!=null && row["A_DateTime"].ToString()!="")
				{
					model.A_DateTime=DateTime.Parse(row["A_DateTime"].ToString());
				}
				if(row["A_ResponsibilityUserID"]!=null && row["A_ResponsibilityUserID"].ToString()!="")
				{
					model.A_ResponsibilityUserID=int.Parse(row["A_ResponsibilityUserID"].ToString());
				}
				if(row["A_Type"]!=null && row["A_Type"].ToString()!="")
				{
					model.A_Type=int.Parse(row["A_Type"].ToString());
				}
				if(row["A_GroupID"]!=null && row["A_GroupID"].ToString()!="")
				{
					model.A_GroupID=int.Parse(row["A_GroupID"].ToString());
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
			strSql.Append("select AnnouncementID,A_Title,A_Content,A_DateTime,A_ResponsibilityUserID,A_Type,A_GroupID ");
			strSql.Append(" FROM AR_Announcement ");
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
			strSql.Append(" AnnouncementID,A_Title,A_Content,A_DateTime,A_ResponsibilityUserID,A_Type,A_GroupID ");
			strSql.Append(" FROM AR_Announcement ");
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
			strSql.Append("select count(1) FROM AR_Announcement ");
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
				strSql.Append("order by T.AnnouncementID desc");
			}
			strSql.Append(")AS Row, T.*  from AR_Announcement T ");
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
			parameters[0].Value = "AR_Announcement";
			parameters[1].Value = "AnnouncementID";
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

