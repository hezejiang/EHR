using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_RolePermission
	/// </summary>
	public partial class sys_RolePermission:Isys_RolePermission
	{
		public sys_RolePermission()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("P_RoleID", "sys_RolePermission"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int P_RoleID,int P_ApplicationID,string P_PageCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_RolePermission");
			strSql.Append(" where P_RoleID=@P_RoleID and P_ApplicationID=@P_ApplicationID and P_PageCode=@P_PageCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@P_RoleID", SqlDbType.Int,4),
					new SqlParameter("@P_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@P_PageCode", SqlDbType.VarChar,20)			};
			parameters[0].Value = P_RoleID;
			parameters[1].Value = P_ApplicationID;
			parameters[2].Value = P_PageCode;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_RolePermission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_RolePermission(");
			strSql.Append("P_RoleID,P_ApplicationID,P_PageCode,P_Value)");
			strSql.Append(" values (");
			strSql.Append("@P_RoleID,@P_ApplicationID,@P_PageCode,@P_Value)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@P_RoleID", SqlDbType.Int,4),
					new SqlParameter("@P_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@P_PageCode", SqlDbType.VarChar,20),
					new SqlParameter("@P_Value", SqlDbType.Int,4)};
			parameters[0].Value = model.P_RoleID;
			parameters[1].Value = model.P_ApplicationID;
			parameters[2].Value = model.P_PageCode;
			parameters[3].Value = model.P_Value;

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
		public bool Update(Maticsoft.Model.sys_RolePermission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_RolePermission set ");
			strSql.Append("P_Value=@P_Value");
			strSql.Append(" where PermissionID=@PermissionID");
			SqlParameter[] parameters = {
					new SqlParameter("@P_Value", SqlDbType.Int,4),
					new SqlParameter("@PermissionID", SqlDbType.Int,4),
					new SqlParameter("@P_RoleID", SqlDbType.Int,4),
					new SqlParameter("@P_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@P_PageCode", SqlDbType.VarChar,20)};
			parameters[0].Value = model.P_Value;
			parameters[1].Value = model.PermissionID;
			parameters[2].Value = model.P_RoleID;
			parameters[3].Value = model.P_ApplicationID;
			parameters[4].Value = model.P_PageCode;

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
		public bool Delete(int PermissionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_RolePermission ");
			strSql.Append(" where PermissionID=@PermissionID");
			SqlParameter[] parameters = {
					new SqlParameter("@PermissionID", SqlDbType.Int,4)
			};
			parameters[0].Value = PermissionID;

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
		public bool Delete(int P_RoleID,int P_ApplicationID,string P_PageCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_RolePermission ");
			strSql.Append(" where P_RoleID=@P_RoleID and P_ApplicationID=@P_ApplicationID and P_PageCode=@P_PageCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@P_RoleID", SqlDbType.Int,4),
					new SqlParameter("@P_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@P_PageCode", SqlDbType.VarChar,20)			};
			parameters[0].Value = P_RoleID;
			parameters[1].Value = P_ApplicationID;
			parameters[2].Value = P_PageCode;

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
		public bool DeleteList(string PermissionIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_RolePermission ");
			strSql.Append(" where PermissionID in ("+PermissionIDlist + ")  ");
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
		public Maticsoft.Model.sys_RolePermission GetModel(int PermissionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PermissionID,P_RoleID,P_ApplicationID,P_PageCode,P_Value from sys_RolePermission ");
			strSql.Append(" where PermissionID=@PermissionID");
			SqlParameter[] parameters = {
					new SqlParameter("@PermissionID", SqlDbType.Int,4)
			};
			parameters[0].Value = PermissionID;

			Maticsoft.Model.sys_RolePermission model=new Maticsoft.Model.sys_RolePermission();
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
		public Maticsoft.Model.sys_RolePermission DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_RolePermission model=new Maticsoft.Model.sys_RolePermission();
			if (row != null)
			{
				if(row["PermissionID"]!=null && row["PermissionID"].ToString()!="")
				{
					model.PermissionID=int.Parse(row["PermissionID"].ToString());
				}
				if(row["P_RoleID"]!=null && row["P_RoleID"].ToString()!="")
				{
					model.P_RoleID=int.Parse(row["P_RoleID"].ToString());
				}
				if(row["P_ApplicationID"]!=null && row["P_ApplicationID"].ToString()!="")
				{
					model.P_ApplicationID=int.Parse(row["P_ApplicationID"].ToString());
				}
				if(row["P_PageCode"]!=null)
				{
					model.P_PageCode=row["P_PageCode"].ToString();
				}
				if(row["P_Value"]!=null && row["P_Value"].ToString()!="")
				{
					model.P_Value=int.Parse(row["P_Value"].ToString());
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
			strSql.Append("select PermissionID,P_RoleID,P_ApplicationID,P_PageCode,P_Value ");
			strSql.Append(" FROM sys_RolePermission ");
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
			strSql.Append(" PermissionID,P_RoleID,P_ApplicationID,P_PageCode,P_Value ");
			strSql.Append(" FROM sys_RolePermission ");
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
			strSql.Append("select count(1) FROM sys_RolePermission ");
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
				strSql.Append("order by T.PermissionID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_RolePermission T ");
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
			parameters[0].Value = "sys_RolePermission";
			parameters[1].Value = "PermissionID";
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

