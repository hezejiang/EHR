using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_Event
	/// </summary>
	public partial class sys_Event:Isys_Event
	{
		public sys_Event()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EventID", "sys_Event"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EventID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_Event");
			strSql.Append(" where EventID=@EventID");
			SqlParameter[] parameters = {
					new SqlParameter("@EventID", SqlDbType.Int,4)
			};
			parameters[0].Value = EventID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_Event model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_Event(");
			strSql.Append("E_U_LoginName,E_UserID,E_DateTime,E_ApplicationID,E_A_AppName,E_M_Name,E_M_PageCode,E_From,E_Type,E_IP,E_Record)");
			strSql.Append(" values (");
			strSql.Append("@E_U_LoginName,@E_UserID,@E_DateTime,@E_ApplicationID,@E_A_AppName,@E_M_Name,@E_M_PageCode,@E_From,@E_Type,@E_IP,@E_Record)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@E_U_LoginName", SqlDbType.NVarChar,20),
					new SqlParameter("@E_UserID", SqlDbType.Int,4),
					new SqlParameter("@E_DateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@E_A_AppName", SqlDbType.NVarChar,50),
					new SqlParameter("@E_M_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_M_PageCode", SqlDbType.VarChar,6),
					new SqlParameter("@E_From", SqlDbType.NVarChar,500),
					new SqlParameter("@E_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@E_IP", SqlDbType.VarChar,15),
					new SqlParameter("@E_Record", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.E_U_LoginName;
			parameters[1].Value = model.E_UserID;
			parameters[2].Value = model.E_DateTime;
			parameters[3].Value = model.E_ApplicationID;
			parameters[4].Value = model.E_A_AppName;
			parameters[5].Value = model.E_M_Name;
			parameters[6].Value = model.E_M_PageCode;
			parameters[7].Value = model.E_From;
			parameters[8].Value = model.E_Type;
			parameters[9].Value = model.E_IP;
			parameters[10].Value = model.E_Record;

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
		public bool Update(Maticsoft.Model.sys_Event model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_Event set ");
			strSql.Append("E_U_LoginName=@E_U_LoginName,");
			strSql.Append("E_UserID=@E_UserID,");
			strSql.Append("E_DateTime=@E_DateTime,");
			strSql.Append("E_ApplicationID=@E_ApplicationID,");
			strSql.Append("E_A_AppName=@E_A_AppName,");
			strSql.Append("E_M_Name=@E_M_Name,");
			strSql.Append("E_M_PageCode=@E_M_PageCode,");
			strSql.Append("E_From=@E_From,");
			strSql.Append("E_Type=@E_Type,");
			strSql.Append("E_IP=@E_IP,");
			strSql.Append("E_Record=@E_Record");
			strSql.Append(" where EventID=@EventID");
			SqlParameter[] parameters = {
					new SqlParameter("@E_U_LoginName", SqlDbType.NVarChar,20),
					new SqlParameter("@E_UserID", SqlDbType.Int,4),
					new SqlParameter("@E_DateTime", SqlDbType.DateTime),
					new SqlParameter("@E_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@E_A_AppName", SqlDbType.NVarChar,50),
					new SqlParameter("@E_M_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@E_M_PageCode", SqlDbType.VarChar,6),
					new SqlParameter("@E_From", SqlDbType.NVarChar,500),
					new SqlParameter("@E_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@E_IP", SqlDbType.VarChar,15),
					new SqlParameter("@E_Record", SqlDbType.NVarChar,500),
					new SqlParameter("@EventID", SqlDbType.Int,4)};
			parameters[0].Value = model.E_U_LoginName;
			parameters[1].Value = model.E_UserID;
			parameters[2].Value = model.E_DateTime;
			parameters[3].Value = model.E_ApplicationID;
			parameters[4].Value = model.E_A_AppName;
			parameters[5].Value = model.E_M_Name;
			parameters[6].Value = model.E_M_PageCode;
			parameters[7].Value = model.E_From;
			parameters[8].Value = model.E_Type;
			parameters[9].Value = model.E_IP;
			parameters[10].Value = model.E_Record;
			parameters[11].Value = model.EventID;

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
		public bool Delete(int EventID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Event ");
			strSql.Append(" where EventID=@EventID");
			SqlParameter[] parameters = {
					new SqlParameter("@EventID", SqlDbType.Int,4)
			};
			parameters[0].Value = EventID;

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
		public bool DeleteList(string EventIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Event ");
			strSql.Append(" where EventID in ("+EventIDlist + ")  ");
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
		public Maticsoft.Model.sys_Event GetModel(int EventID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EventID,E_U_LoginName,E_UserID,E_DateTime,E_ApplicationID,E_A_AppName,E_M_Name,E_M_PageCode,E_From,E_Type,E_IP,E_Record from sys_Event ");
			strSql.Append(" where EventID=@EventID");
			SqlParameter[] parameters = {
					new SqlParameter("@EventID", SqlDbType.Int,4)
			};
			parameters[0].Value = EventID;

			Maticsoft.Model.sys_Event model=new Maticsoft.Model.sys_Event();
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
		public Maticsoft.Model.sys_Event DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_Event model=new Maticsoft.Model.sys_Event();
			if (row != null)
			{
				if(row["EventID"]!=null && row["EventID"].ToString()!="")
				{
					model.EventID=int.Parse(row["EventID"].ToString());
				}
				if(row["E_U_LoginName"]!=null)
				{
					model.E_U_LoginName=row["E_U_LoginName"].ToString();
				}
				if(row["E_UserID"]!=null && row["E_UserID"].ToString()!="")
				{
					model.E_UserID=int.Parse(row["E_UserID"].ToString());
				}
				if(row["E_DateTime"]!=null && row["E_DateTime"].ToString()!="")
				{
					model.E_DateTime=DateTime.Parse(row["E_DateTime"].ToString());
				}
				if(row["E_ApplicationID"]!=null && row["E_ApplicationID"].ToString()!="")
				{
					model.E_ApplicationID=int.Parse(row["E_ApplicationID"].ToString());
				}
				if(row["E_A_AppName"]!=null)
				{
					model.E_A_AppName=row["E_A_AppName"].ToString();
				}
				if(row["E_M_Name"]!=null)
				{
					model.E_M_Name=row["E_M_Name"].ToString();
				}
				if(row["E_M_PageCode"]!=null)
				{
					model.E_M_PageCode=row["E_M_PageCode"].ToString();
				}
				if(row["E_From"]!=null)
				{
					model.E_From=row["E_From"].ToString();
				}
				if(row["E_Type"]!=null && row["E_Type"].ToString()!="")
				{
					model.E_Type=int.Parse(row["E_Type"].ToString());
				}
				if(row["E_IP"]!=null)
				{
					model.E_IP=row["E_IP"].ToString();
				}
				if(row["E_Record"]!=null)
				{
					model.E_Record=row["E_Record"].ToString();
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
			strSql.Append("select EventID,E_U_LoginName,E_UserID,E_DateTime,E_ApplicationID,E_A_AppName,E_M_Name,E_M_PageCode,E_From,E_Type,E_IP,E_Record ");
			strSql.Append(" FROM sys_Event ");
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
			strSql.Append(" EventID,E_U_LoginName,E_UserID,E_DateTime,E_ApplicationID,E_A_AppName,E_M_Name,E_M_PageCode,E_From,E_Type,E_IP,E_Record ");
			strSql.Append(" FROM sys_Event ");
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
			strSql.Append("select count(1) FROM sys_Event ");
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
				strSql.Append("order by T.EventID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_Event T ");
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
			parameters[0].Value = "sys_Event";
			parameters[1].Value = "EventID";
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

