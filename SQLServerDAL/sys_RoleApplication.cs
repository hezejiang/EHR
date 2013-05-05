using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_RoleApplication
	/// </summary>
	public partial class sys_RoleApplication:Isys_RoleApplication
	{
		public sys_RoleApplication()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("A_RoleID", "sys_RoleApplication"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int A_RoleID,int A_ApplicationID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_RoleApplication");
			strSql.Append(" where A_RoleID=@A_RoleID and A_ApplicationID=@A_ApplicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@A_RoleID", SqlDbType.Int,4),
					new SqlParameter("@A_ApplicationID", SqlDbType.Int,4)			};
			parameters[0].Value = A_RoleID;
			parameters[1].Value = A_ApplicationID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.sys_RoleApplication model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_RoleApplication(");
			strSql.Append("A_RoleID,A_ApplicationID)");
			strSql.Append(" values (");
			strSql.Append("@A_RoleID,@A_ApplicationID)");
			SqlParameter[] parameters = {
					new SqlParameter("@A_RoleID", SqlDbType.Int,4),
					new SqlParameter("@A_ApplicationID", SqlDbType.Int,4)};
			parameters[0].Value = model.A_RoleID;
			parameters[1].Value = model.A_ApplicationID;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.sys_RoleApplication model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_RoleApplication set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("A_RoleID=@A_RoleID,");
			strSql.Append("A_ApplicationID=@A_ApplicationID");
			strSql.Append(" where A_RoleID=@A_RoleID and A_ApplicationID=@A_ApplicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@A_RoleID", SqlDbType.Int,4),
					new SqlParameter("@A_ApplicationID", SqlDbType.Int,4)};
			parameters[0].Value = model.A_RoleID;
			parameters[1].Value = model.A_ApplicationID;

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
		public bool Delete(int A_RoleID,int A_ApplicationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_RoleApplication ");
			strSql.Append(" where A_RoleID=@A_RoleID and A_ApplicationID=@A_ApplicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@A_RoleID", SqlDbType.Int,4),
					new SqlParameter("@A_ApplicationID", SqlDbType.Int,4)			};
			parameters[0].Value = A_RoleID;
			parameters[1].Value = A_ApplicationID;

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.sys_RoleApplication GetModel(int A_RoleID,int A_ApplicationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 A_RoleID,A_ApplicationID from sys_RoleApplication ");
			strSql.Append(" where A_RoleID=@A_RoleID and A_ApplicationID=@A_ApplicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@A_RoleID", SqlDbType.Int,4),
					new SqlParameter("@A_ApplicationID", SqlDbType.Int,4)			};
			parameters[0].Value = A_RoleID;
			parameters[1].Value = A_ApplicationID;

			Maticsoft.Model.sys_RoleApplication model=new Maticsoft.Model.sys_RoleApplication();
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
		public Maticsoft.Model.sys_RoleApplication DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_RoleApplication model=new Maticsoft.Model.sys_RoleApplication();
			if (row != null)
			{
				if(row["A_RoleID"]!=null && row["A_RoleID"].ToString()!="")
				{
					model.A_RoleID=int.Parse(row["A_RoleID"].ToString());
				}
				if(row["A_ApplicationID"]!=null && row["A_ApplicationID"].ToString()!="")
				{
					model.A_ApplicationID=int.Parse(row["A_ApplicationID"].ToString());
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
			strSql.Append("select A_RoleID,A_ApplicationID ");
			strSql.Append(" FROM sys_RoleApplication ");
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
			strSql.Append(" A_RoleID,A_ApplicationID ");
			strSql.Append(" FROM sys_RoleApplication ");
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
			strSql.Append("select count(1) FROM sys_RoleApplication ");
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
				strSql.Append("order by T.A_ApplicationID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_RoleApplication T ");
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
			parameters[0].Value = "sys_RoleApplication";
			parameters[1].Value = "A_ApplicationID";
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

