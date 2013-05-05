using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_Module
	/// </summary>
	public partial class sys_Module:Isys_Module
	{
		public sys_Module()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("M_ApplicationID", "sys_Module"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int M_ApplicationID,string M_PageCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_Module");
			strSql.Append(" where M_ApplicationID=@M_ApplicationID and M_PageCode=@M_PageCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@M_PageCode", SqlDbType.VarChar,100)			};
			parameters[0].Value = M_ApplicationID;
			parameters[1].Value = M_PageCode;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_Module model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_Module(");
			strSql.Append("M_ApplicationID,M_ParentID,M_PageCode,M_CName,M_Directory,M_OrderLevel,M_IsSystem,M_Close,M_Icon,M_Info)");
			strSql.Append(" values (");
			strSql.Append("@M_ApplicationID,@M_ParentID,@M_PageCode,@M_CName,@M_Directory,@M_OrderLevel,@M_IsSystem,@M_Close,@M_Icon,@M_Info)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@M_ParentID", SqlDbType.Int,4),
					new SqlParameter("@M_PageCode", SqlDbType.VarChar,100),
					new SqlParameter("@M_CName", SqlDbType.NVarChar,50),
					new SqlParameter("@M_Directory", SqlDbType.NVarChar,255),
					new SqlParameter("@M_OrderLevel", SqlDbType.VarChar,4),
					new SqlParameter("@M_IsSystem", SqlDbType.TinyInt,1),
					new SqlParameter("@M_Close", SqlDbType.TinyInt,1),
					new SqlParameter("@M_Icon", SqlDbType.VarChar,255),
					new SqlParameter("@M_Info", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.M_ApplicationID;
			parameters[1].Value = model.M_ParentID;
			parameters[2].Value = model.M_PageCode;
			parameters[3].Value = model.M_CName;
			parameters[4].Value = model.M_Directory;
			parameters[5].Value = model.M_OrderLevel;
			parameters[6].Value = model.M_IsSystem;
			parameters[7].Value = model.M_Close;
			parameters[8].Value = model.M_Icon;
			parameters[9].Value = model.M_Info;

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
		public bool Update(Maticsoft.Model.sys_Module model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_Module set ");
			strSql.Append("M_ParentID=@M_ParentID,");
			strSql.Append("M_CName=@M_CName,");
			strSql.Append("M_Directory=@M_Directory,");
			strSql.Append("M_OrderLevel=@M_OrderLevel,");
			strSql.Append("M_IsSystem=@M_IsSystem,");
			strSql.Append("M_Close=@M_Close,");
			strSql.Append("M_Icon=@M_Icon,");
			strSql.Append("M_Info=@M_Info");
			strSql.Append(" where ModuleID=@ModuleID");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ParentID", SqlDbType.Int,4),
					new SqlParameter("@M_CName", SqlDbType.NVarChar,50),
					new SqlParameter("@M_Directory", SqlDbType.NVarChar,255),
					new SqlParameter("@M_OrderLevel", SqlDbType.VarChar,4),
					new SqlParameter("@M_IsSystem", SqlDbType.TinyInt,1),
					new SqlParameter("@M_Close", SqlDbType.TinyInt,1),
					new SqlParameter("@M_Icon", SqlDbType.VarChar,255),
					new SqlParameter("@M_Info", SqlDbType.NVarChar,500),
					new SqlParameter("@ModuleID", SqlDbType.Int,4),
					new SqlParameter("@M_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@M_PageCode", SqlDbType.VarChar,100)};
			parameters[0].Value = model.M_ParentID;
			parameters[1].Value = model.M_CName;
			parameters[2].Value = model.M_Directory;
			parameters[3].Value = model.M_OrderLevel;
			parameters[4].Value = model.M_IsSystem;
			parameters[5].Value = model.M_Close;
			parameters[6].Value = model.M_Icon;
			parameters[7].Value = model.M_Info;
			parameters[8].Value = model.ModuleID;
			parameters[9].Value = model.M_ApplicationID;
			parameters[10].Value = model.M_PageCode;

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
		public bool Delete(int ModuleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Module ");
			strSql.Append(" where ModuleID=@ModuleID");
			SqlParameter[] parameters = {
					new SqlParameter("@ModuleID", SqlDbType.Int,4)
			};
			parameters[0].Value = ModuleID;

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
		public bool Delete(int M_ApplicationID,string M_PageCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Module ");
			strSql.Append(" where M_ApplicationID=@M_ApplicationID and M_PageCode=@M_PageCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ApplicationID", SqlDbType.Int,4),
					new SqlParameter("@M_PageCode", SqlDbType.VarChar,100)			};
			parameters[0].Value = M_ApplicationID;
			parameters[1].Value = M_PageCode;

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
		public bool DeleteList(string ModuleIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Module ");
			strSql.Append(" where ModuleID in ("+ModuleIDlist + ")  ");
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
		public Maticsoft.Model.sys_Module GetModel(int ModuleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ModuleID,M_ApplicationID,M_ParentID,M_PageCode,M_CName,M_Directory,M_OrderLevel,M_IsSystem,M_Close,M_Icon,M_Info from sys_Module ");
			strSql.Append(" where ModuleID=@ModuleID");
			SqlParameter[] parameters = {
					new SqlParameter("@ModuleID", SqlDbType.Int,4)
			};
			parameters[0].Value = ModuleID;

			Maticsoft.Model.sys_Module model=new Maticsoft.Model.sys_Module();
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
		public Maticsoft.Model.sys_Module DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_Module model=new Maticsoft.Model.sys_Module();
			if (row != null)
			{
				if(row["ModuleID"]!=null && row["ModuleID"].ToString()!="")
				{
					model.ModuleID=int.Parse(row["ModuleID"].ToString());
				}
				if(row["M_ApplicationID"]!=null && row["M_ApplicationID"].ToString()!="")
				{
					model.M_ApplicationID=int.Parse(row["M_ApplicationID"].ToString());
				}
				if(row["M_ParentID"]!=null && row["M_ParentID"].ToString()!="")
				{
					model.M_ParentID=int.Parse(row["M_ParentID"].ToString());
				}
				if(row["M_PageCode"]!=null)
				{
					model.M_PageCode=row["M_PageCode"].ToString();
				}
				if(row["M_CName"]!=null)
				{
					model.M_CName=row["M_CName"].ToString();
				}
				if(row["M_Directory"]!=null)
				{
					model.M_Directory=row["M_Directory"].ToString();
				}
				if(row["M_OrderLevel"]!=null)
				{
					model.M_OrderLevel=row["M_OrderLevel"].ToString();
				}
				if(row["M_IsSystem"]!=null && row["M_IsSystem"].ToString()!="")
				{
					model.M_IsSystem=int.Parse(row["M_IsSystem"].ToString());
				}
				if(row["M_Close"]!=null && row["M_Close"].ToString()!="")
				{
					model.M_Close=int.Parse(row["M_Close"].ToString());
				}
				if(row["M_Icon"]!=null)
				{
					model.M_Icon=row["M_Icon"].ToString();
				}
				if(row["M_Info"]!=null)
				{
					model.M_Info=row["M_Info"].ToString();
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
			strSql.Append("select ModuleID,M_ApplicationID,M_ParentID,M_PageCode,M_CName,M_Directory,M_OrderLevel,M_IsSystem,M_Close,M_Icon,M_Info ");
			strSql.Append(" FROM sys_Module ");
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
			strSql.Append(" ModuleID,M_ApplicationID,M_ParentID,M_PageCode,M_CName,M_Directory,M_OrderLevel,M_IsSystem,M_Close,M_Icon,M_Info ");
			strSql.Append(" FROM sys_Module ");
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
			strSql.Append("select count(1) FROM sys_Module ");
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
				strSql.Append("order by T.ModuleID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_Module T ");
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
			parameters[0].Value = "sys_Module";
			parameters[1].Value = "ModuleID";
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

