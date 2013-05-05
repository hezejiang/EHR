using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_SystemInfo
	/// </summary>
	public partial class sys_SystemInfo:Isys_SystemInfo
	{
		public sys_SystemInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SystemID", "sys_SystemInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SystemID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_SystemInfo");
			strSql.Append(" where SystemID=@SystemID");
			SqlParameter[] parameters = {
					new SqlParameter("@SystemID", SqlDbType.Int,4)
			};
			parameters[0].Value = SystemID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_SystemInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_SystemInfo(");
			strSql.Append("S_Name,S_Version,S_SystemConfigData,S_Licensed)");
			strSql.Append(" values (");
			strSql.Append("@S_Name,@S_Version,@S_SystemConfigData,@S_Licensed)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@S_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@S_Version", SqlDbType.NVarChar,50),
					new SqlParameter("@S_SystemConfigData", SqlDbType.Image),
					new SqlParameter("@S_Licensed", SqlDbType.VarChar,50)};
			parameters[0].Value = model.S_Name;
			parameters[1].Value = model.S_Version;
			parameters[2].Value = model.S_SystemConfigData;
			parameters[3].Value = model.S_Licensed;

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
		public bool Update(Maticsoft.Model.sys_SystemInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_SystemInfo set ");
			strSql.Append("S_Name=@S_Name,");
			strSql.Append("S_Version=@S_Version,");
			strSql.Append("S_SystemConfigData=@S_SystemConfigData,");
			strSql.Append("S_Licensed=@S_Licensed");
			strSql.Append(" where SystemID=@SystemID");
			SqlParameter[] parameters = {
					new SqlParameter("@S_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@S_Version", SqlDbType.NVarChar,50),
					new SqlParameter("@S_SystemConfigData", SqlDbType.Image),
					new SqlParameter("@S_Licensed", SqlDbType.VarChar,50),
					new SqlParameter("@SystemID", SqlDbType.Int,4)};
			parameters[0].Value = model.S_Name;
			parameters[1].Value = model.S_Version;
			parameters[2].Value = model.S_SystemConfigData;
			parameters[3].Value = model.S_Licensed;
			parameters[4].Value = model.SystemID;

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
		public bool Delete(int SystemID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_SystemInfo ");
			strSql.Append(" where SystemID=@SystemID");
			SqlParameter[] parameters = {
					new SqlParameter("@SystemID", SqlDbType.Int,4)
			};
			parameters[0].Value = SystemID;

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
		public bool DeleteList(string SystemIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_SystemInfo ");
			strSql.Append(" where SystemID in ("+SystemIDlist + ")  ");
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
		public Maticsoft.Model.sys_SystemInfo GetModel(int SystemID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SystemID,S_Name,S_Version,S_SystemConfigData,S_Licensed from sys_SystemInfo ");
			strSql.Append(" where SystemID=@SystemID");
			SqlParameter[] parameters = {
					new SqlParameter("@SystemID", SqlDbType.Int,4)
			};
			parameters[0].Value = SystemID;

			Maticsoft.Model.sys_SystemInfo model=new Maticsoft.Model.sys_SystemInfo();
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
		public Maticsoft.Model.sys_SystemInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_SystemInfo model=new Maticsoft.Model.sys_SystemInfo();
			if (row != null)
			{
				if(row["SystemID"]!=null && row["SystemID"].ToString()!="")
				{
					model.SystemID=int.Parse(row["SystemID"].ToString());
				}
				if(row["S_Name"]!=null)
				{
					model.S_Name=row["S_Name"].ToString();
				}
				if(row["S_Version"]!=null)
				{
					model.S_Version=row["S_Version"].ToString();
				}
				if(row["S_SystemConfigData"]!=null && row["S_SystemConfigData"].ToString()!="")
				{
					model.S_SystemConfigData=(byte[])row["S_SystemConfigData"];
				}
				if(row["S_Licensed"]!=null)
				{
					model.S_Licensed=row["S_Licensed"].ToString();
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
			strSql.Append("select SystemID,S_Name,S_Version,S_SystemConfigData,S_Licensed ");
			strSql.Append(" FROM sys_SystemInfo ");
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
			strSql.Append(" SystemID,S_Name,S_Version,S_SystemConfigData,S_Licensed ");
			strSql.Append(" FROM sys_SystemInfo ");
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
			strSql.Append("select count(1) FROM sys_SystemInfo ");
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
				strSql.Append("order by T.SystemID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_SystemInfo T ");
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
			parameters[0].Value = "sys_SystemInfo";
			parameters[1].Value = "SystemID";
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

