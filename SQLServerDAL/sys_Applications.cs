using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_Applications
	/// </summary>
	public partial class sys_Applications:Isys_Applications
	{
		public sys_Applications()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ApplicationID", "sys_Applications"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ApplicationID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_Applications");
			strSql.Append(" where ApplicationID=@ApplicationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ApplicationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ApplicationID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_Applications model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_Applications(");
			strSql.Append("A_AppName,A_AppDescription,A_AppUrl,A_Order)");
			strSql.Append(" values (");
			strSql.Append("@A_AppName,@A_AppDescription,@A_AppUrl,@A_Order)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@A_AppName", SqlDbType.NVarChar,50),
					new SqlParameter("@A_AppDescription", SqlDbType.NVarChar,200),
					new SqlParameter("@A_AppUrl", SqlDbType.VarChar,50),
					new SqlParameter("@A_Order", SqlDbType.Int,4)};
			parameters[0].Value = model.A_AppName;
			parameters[1].Value = model.A_AppDescription;
			parameters[2].Value = model.A_AppUrl;
			parameters[3].Value = model.A_Order;

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
		public bool Update(Maticsoft.Model.sys_Applications model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_Applications set ");
			strSql.Append("A_AppName=@A_AppName,");
			strSql.Append("A_AppDescription=@A_AppDescription,");
			strSql.Append("A_AppUrl=@A_AppUrl,");
			strSql.Append("A_Order=@A_Order");
			strSql.Append(" where ApplicationID=@ApplicationID");
			SqlParameter[] parameters = {
					new SqlParameter("@A_AppName", SqlDbType.NVarChar,50),
					new SqlParameter("@A_AppDescription", SqlDbType.NVarChar,200),
					new SqlParameter("@A_AppUrl", SqlDbType.VarChar,50),
					new SqlParameter("@A_Order", SqlDbType.Int,4),
					new SqlParameter("@ApplicationID", SqlDbType.Int,4)};
			parameters[0].Value = model.A_AppName;
			parameters[1].Value = model.A_AppDescription;
			parameters[2].Value = model.A_AppUrl;
			parameters[3].Value = model.A_Order;
			parameters[4].Value = model.ApplicationID;

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
		public bool Delete(int ApplicationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Applications ");
			strSql.Append(" where ApplicationID=@ApplicationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ApplicationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ApplicationID;

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
		public bool DeleteList(string ApplicationIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Applications ");
			strSql.Append(" where ApplicationID in ("+ApplicationIDlist + ")  ");
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
		public Maticsoft.Model.sys_Applications GetModel(int ApplicationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ApplicationID,A_AppName,A_AppDescription,A_AppUrl,A_Order from sys_Applications ");
			strSql.Append(" where ApplicationID=@ApplicationID");
			SqlParameter[] parameters = {
					new SqlParameter("@ApplicationID", SqlDbType.Int,4)
			};
			parameters[0].Value = ApplicationID;

			Maticsoft.Model.sys_Applications model=new Maticsoft.Model.sys_Applications();
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
		public Maticsoft.Model.sys_Applications DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_Applications model=new Maticsoft.Model.sys_Applications();
			if (row != null)
			{
				if(row["ApplicationID"]!=null && row["ApplicationID"].ToString()!="")
				{
					model.ApplicationID=int.Parse(row["ApplicationID"].ToString());
				}
				if(row["A_AppName"]!=null)
				{
					model.A_AppName=row["A_AppName"].ToString();
				}
				if(row["A_AppDescription"]!=null)
				{
					model.A_AppDescription=row["A_AppDescription"].ToString();
				}
				if(row["A_AppUrl"]!=null)
				{
					model.A_AppUrl=row["A_AppUrl"].ToString();
				}
				if(row["A_Order"]!=null && row["A_Order"].ToString()!="")
				{
					model.A_Order=int.Parse(row["A_Order"].ToString());
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
			strSql.Append("select ApplicationID,A_AppName,A_AppDescription,A_AppUrl,A_Order ");
			strSql.Append(" FROM sys_Applications ");
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
			strSql.Append(" ApplicationID,A_AppName,A_AppDescription,A_AppUrl,A_Order ");
			strSql.Append(" FROM sys_Applications ");
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
			strSql.Append("select count(1) FROM sys_Applications ");
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
				strSql.Append("order by T.ApplicationID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_Applications T ");
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
			parameters[0].Value = "sys_Applications";
			parameters[1].Value = "ApplicationID";
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

