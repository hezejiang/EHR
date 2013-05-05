using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Nation
	/// </summary>
	public partial class Nation:INation
	{
		public Nation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("NationID", "Nation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NationID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Nation");
			strSql.Append(" where NationID=@NationID");
			SqlParameter[] parameters = {
					new SqlParameter("@NationID", SqlDbType.Int,4)
			};
			parameters[0].Value = NationID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Nation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Nation(");
			strSql.Append("N_Name)");
			strSql.Append(" values (");
			strSql.Append("@N_Name)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@N_Name", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.N_Name;

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
		public bool Update(Maticsoft.Model.Nation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Nation set ");
			strSql.Append("N_Name=@N_Name");
			strSql.Append(" where NationID=@NationID");
			SqlParameter[] parameters = {
					new SqlParameter("@N_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@NationID", SqlDbType.Int,4)};
			parameters[0].Value = model.N_Name;
			parameters[1].Value = model.NationID;

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
		public bool Delete(int NationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Nation ");
			strSql.Append(" where NationID=@NationID");
			SqlParameter[] parameters = {
					new SqlParameter("@NationID", SqlDbType.Int,4)
			};
			parameters[0].Value = NationID;

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
		public bool DeleteList(string NationIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Nation ");
			strSql.Append(" where NationID in ("+NationIDlist + ")  ");
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
		public Maticsoft.Model.Nation GetModel(int NationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NationID,N_Name from Nation ");
			strSql.Append(" where NationID=@NationID");
			SqlParameter[] parameters = {
					new SqlParameter("@NationID", SqlDbType.Int,4)
			};
			parameters[0].Value = NationID;

			Maticsoft.Model.Nation model=new Maticsoft.Model.Nation();
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
		public Maticsoft.Model.Nation DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Nation model=new Maticsoft.Model.Nation();
			if (row != null)
			{
				if(row["NationID"]!=null && row["NationID"].ToString()!="")
				{
					model.NationID=int.Parse(row["NationID"].ToString());
				}
				if(row["N_Name"]!=null)
				{
					model.N_Name=row["N_Name"].ToString();
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
			strSql.Append("select NationID,N_Name ");
			strSql.Append(" FROM Nation ");
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
			strSql.Append(" NationID,N_Name ");
			strSql.Append(" FROM Nation ");
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
			strSql.Append("select count(1) FROM Nation ");
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
				strSql.Append("order by T.NationID desc");
			}
			strSql.Append(")AS Row, T.*  from Nation T ");
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
			parameters[0].Value = "Nation";
			parameters[1].Value = "NationID";
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

