using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_Online
	/// </summary>
	public partial class sys_Online:Isys_Online
	{
		public sys_Online()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string O_SessionID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_Online");
			strSql.Append(" where O_SessionID=@O_SessionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@O_SessionID", SqlDbType.VarChar,24)			};
			parameters[0].Value = O_SessionID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_Online model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_Online(");
			strSql.Append("O_SessionID,O_UserName,O_Ip,O_LoginTime,O_LastTime,O_LastUrl)");
			strSql.Append(" values (");
			strSql.Append("@O_SessionID,@O_UserName,@O_Ip,@O_LoginTime,@O_LastTime,@O_LastUrl)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@O_SessionID", SqlDbType.VarChar,24),
					new SqlParameter("@O_UserName", SqlDbType.NVarChar,20),
					new SqlParameter("@O_Ip", SqlDbType.VarChar,15),
					new SqlParameter("@O_LoginTime", SqlDbType.DateTime),
					new SqlParameter("@O_LastTime", SqlDbType.DateTime),
					new SqlParameter("@O_LastUrl", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.O_SessionID;
			parameters[1].Value = model.O_UserName;
			parameters[2].Value = model.O_Ip;
			parameters[3].Value = model.O_LoginTime;
			parameters[4].Value = model.O_LastTime;
			parameters[5].Value = model.O_LastUrl;

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
		public bool Update(Maticsoft.Model.sys_Online model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_Online set ");
			strSql.Append("O_UserName=@O_UserName,");
			strSql.Append("O_Ip=@O_Ip,");
			strSql.Append("O_LoginTime=@O_LoginTime,");
			strSql.Append("O_LastTime=@O_LastTime,");
			strSql.Append("O_LastUrl=@O_LastUrl");
			strSql.Append(" where OnlineID=@OnlineID");
			SqlParameter[] parameters = {
					new SqlParameter("@O_UserName", SqlDbType.NVarChar,20),
					new SqlParameter("@O_Ip", SqlDbType.VarChar,15),
					new SqlParameter("@O_LoginTime", SqlDbType.DateTime),
					new SqlParameter("@O_LastTime", SqlDbType.DateTime),
					new SqlParameter("@O_LastUrl", SqlDbType.NVarChar,500),
					new SqlParameter("@OnlineID", SqlDbType.Int,4),
					new SqlParameter("@O_SessionID", SqlDbType.VarChar,24)};
			parameters[0].Value = model.O_UserName;
			parameters[1].Value = model.O_Ip;
			parameters[2].Value = model.O_LoginTime;
			parameters[3].Value = model.O_LastTime;
			parameters[4].Value = model.O_LastUrl;
			parameters[5].Value = model.OnlineID;
			parameters[6].Value = model.O_SessionID;

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
		public bool Delete(int OnlineID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Online ");
			strSql.Append(" where OnlineID=@OnlineID");
			SqlParameter[] parameters = {
					new SqlParameter("@OnlineID", SqlDbType.Int,4)
			};
			parameters[0].Value = OnlineID;

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
		public bool Delete(string O_SessionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Online ");
			strSql.Append(" where O_SessionID=@O_SessionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@O_SessionID", SqlDbType.VarChar,24)			};
			parameters[0].Value = O_SessionID;

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
		public bool DeleteList(string OnlineIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Online ");
			strSql.Append(" where OnlineID in ("+OnlineIDlist + ")  ");
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
		public Maticsoft.Model.sys_Online GetModel(int OnlineID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OnlineID,O_SessionID,O_UserName,O_Ip,O_LoginTime,O_LastTime,O_LastUrl from sys_Online ");
			strSql.Append(" where OnlineID=@OnlineID");
			SqlParameter[] parameters = {
					new SqlParameter("@OnlineID", SqlDbType.Int,4)
			};
			parameters[0].Value = OnlineID;

			Maticsoft.Model.sys_Online model=new Maticsoft.Model.sys_Online();
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
		public Maticsoft.Model.sys_Online DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_Online model=new Maticsoft.Model.sys_Online();
			if (row != null)
			{
				if(row["OnlineID"]!=null && row["OnlineID"].ToString()!="")
				{
					model.OnlineID=int.Parse(row["OnlineID"].ToString());
				}
				if(row["O_SessionID"]!=null)
				{
					model.O_SessionID=row["O_SessionID"].ToString();
				}
				if(row["O_UserName"]!=null)
				{
					model.O_UserName=row["O_UserName"].ToString();
				}
				if(row["O_Ip"]!=null)
				{
					model.O_Ip=row["O_Ip"].ToString();
				}
				if(row["O_LoginTime"]!=null && row["O_LoginTime"].ToString()!="")
				{
					model.O_LoginTime=DateTime.Parse(row["O_LoginTime"].ToString());
				}
				if(row["O_LastTime"]!=null && row["O_LastTime"].ToString()!="")
				{
					model.O_LastTime=DateTime.Parse(row["O_LastTime"].ToString());
				}
				if(row["O_LastUrl"]!=null)
				{
					model.O_LastUrl=row["O_LastUrl"].ToString();
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
			strSql.Append("select OnlineID,O_SessionID,O_UserName,O_Ip,O_LoginTime,O_LastTime,O_LastUrl ");
			strSql.Append(" FROM sys_Online ");
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
			strSql.Append(" OnlineID,O_SessionID,O_UserName,O_Ip,O_LoginTime,O_LastTime,O_LastUrl ");
			strSql.Append(" FROM sys_Online ");
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
			strSql.Append("select count(1) FROM sys_Online ");
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
				strSql.Append("order by T.OnlineID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_Online T ");
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
			parameters[0].Value = "sys_Online";
			parameters[1].Value = "OnlineID";
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

