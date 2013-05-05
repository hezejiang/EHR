using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_ModuleExtPermission
	/// </summary>
	public partial class sys_ModuleExtPermission:Isys_ModuleExtPermission
	{
		public sys_ModuleExtPermission()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ModuleID", "sys_ModuleExtPermission"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ModuleID,int PermissionValue)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_ModuleExtPermission");
			strSql.Append(" where ModuleID=@ModuleID and PermissionValue=@PermissionValue ");
			SqlParameter[] parameters = {
					new SqlParameter("@ModuleID", SqlDbType.Int,4),
					new SqlParameter("@PermissionValue", SqlDbType.Int,4)			};
			parameters[0].Value = ModuleID;
			parameters[1].Value = PermissionValue;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_ModuleExtPermission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_ModuleExtPermission(");
			strSql.Append("ModuleID,PermissionName,PermissionValue)");
			strSql.Append(" values (");
			strSql.Append("@ModuleID,@PermissionName,@PermissionValue)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ModuleID", SqlDbType.Int,4),
					new SqlParameter("@PermissionName", SqlDbType.NVarChar,100),
					new SqlParameter("@PermissionValue", SqlDbType.Int,4)};
			parameters[0].Value = model.ModuleID;
			parameters[1].Value = model.PermissionName;
			parameters[2].Value = model.PermissionValue;

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
		public bool Update(Maticsoft.Model.sys_ModuleExtPermission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_ModuleExtPermission set ");
			strSql.Append("PermissionName=@PermissionName");
			strSql.Append(" where ExtPermissionID=@ExtPermissionID");
			SqlParameter[] parameters = {
					new SqlParameter("@PermissionName", SqlDbType.NVarChar,100),
					new SqlParameter("@ExtPermissionID", SqlDbType.Int,4),
					new SqlParameter("@ModuleID", SqlDbType.Int,4),
					new SqlParameter("@PermissionValue", SqlDbType.Int,4)};
			parameters[0].Value = model.PermissionName;
			parameters[1].Value = model.ExtPermissionID;
			parameters[2].Value = model.ModuleID;
			parameters[3].Value = model.PermissionValue;

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
		public bool Delete(int ExtPermissionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_ModuleExtPermission ");
			strSql.Append(" where ExtPermissionID=@ExtPermissionID");
			SqlParameter[] parameters = {
					new SqlParameter("@ExtPermissionID", SqlDbType.Int,4)
			};
			parameters[0].Value = ExtPermissionID;

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
		public bool Delete(int ModuleID,int PermissionValue)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_ModuleExtPermission ");
			strSql.Append(" where ModuleID=@ModuleID and PermissionValue=@PermissionValue ");
			SqlParameter[] parameters = {
					new SqlParameter("@ModuleID", SqlDbType.Int,4),
					new SqlParameter("@PermissionValue", SqlDbType.Int,4)			};
			parameters[0].Value = ModuleID;
			parameters[1].Value = PermissionValue;

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
		public bool DeleteList(string ExtPermissionIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_ModuleExtPermission ");
			strSql.Append(" where ExtPermissionID in ("+ExtPermissionIDlist + ")  ");
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
		public Maticsoft.Model.sys_ModuleExtPermission GetModel(int ExtPermissionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ExtPermissionID,ModuleID,PermissionName,PermissionValue from sys_ModuleExtPermission ");
			strSql.Append(" where ExtPermissionID=@ExtPermissionID");
			SqlParameter[] parameters = {
					new SqlParameter("@ExtPermissionID", SqlDbType.Int,4)
			};
			parameters[0].Value = ExtPermissionID;

			Maticsoft.Model.sys_ModuleExtPermission model=new Maticsoft.Model.sys_ModuleExtPermission();
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
		public Maticsoft.Model.sys_ModuleExtPermission DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_ModuleExtPermission model=new Maticsoft.Model.sys_ModuleExtPermission();
			if (row != null)
			{
				if(row["ExtPermissionID"]!=null && row["ExtPermissionID"].ToString()!="")
				{
					model.ExtPermissionID=int.Parse(row["ExtPermissionID"].ToString());
				}
				if(row["ModuleID"]!=null && row["ModuleID"].ToString()!="")
				{
					model.ModuleID=int.Parse(row["ModuleID"].ToString());
				}
				if(row["PermissionName"]!=null)
				{
					model.PermissionName=row["PermissionName"].ToString();
				}
				if(row["PermissionValue"]!=null && row["PermissionValue"].ToString()!="")
				{
					model.PermissionValue=int.Parse(row["PermissionValue"].ToString());
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
			strSql.Append("select ExtPermissionID,ModuleID,PermissionName,PermissionValue ");
			strSql.Append(" FROM sys_ModuleExtPermission ");
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
			strSql.Append(" ExtPermissionID,ModuleID,PermissionName,PermissionValue ");
			strSql.Append(" FROM sys_ModuleExtPermission ");
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
			strSql.Append("select count(1) FROM sys_ModuleExtPermission ");
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
				strSql.Append("order by T.ExtPermissionID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_ModuleExtPermission T ");
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
			parameters[0].Value = "sys_ModuleExtPermission";
			parameters[1].Value = "ExtPermissionID";
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

