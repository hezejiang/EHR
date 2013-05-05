using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_Field
	/// </summary>
	public partial class sys_Field:Isys_Field
	{
		public sys_Field()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FieldID", "sys_Field"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FieldID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_Field");
			strSql.Append(" where FieldID=@FieldID");
			SqlParameter[] parameters = {
					new SqlParameter("@FieldID", SqlDbType.Int,4)
			};
			parameters[0].Value = FieldID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_Field model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_Field(");
			strSql.Append("F_Key,F_CName,F_Remark)");
			strSql.Append(" values (");
			strSql.Append("@F_Key,@F_CName,@F_Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Key", SqlDbType.VarChar,50),
					new SqlParameter("@F_CName", SqlDbType.NVarChar,50),
					new SqlParameter("@F_Remark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.F_Key;
			parameters[1].Value = model.F_CName;
			parameters[2].Value = model.F_Remark;

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
		public bool Update(Maticsoft.Model.sys_Field model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_Field set ");
			strSql.Append("F_Key=@F_Key,");
			strSql.Append("F_CName=@F_CName,");
			strSql.Append("F_Remark=@F_Remark");
			strSql.Append(" where FieldID=@FieldID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Key", SqlDbType.VarChar,50),
					new SqlParameter("@F_CName", SqlDbType.NVarChar,50),
					new SqlParameter("@F_Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@FieldID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_Key;
			parameters[1].Value = model.F_CName;
			parameters[2].Value = model.F_Remark;
			parameters[3].Value = model.FieldID;

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
		public bool Delete(int FieldID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Field ");
			strSql.Append(" where FieldID=@FieldID");
			SqlParameter[] parameters = {
					new SqlParameter("@FieldID", SqlDbType.Int,4)
			};
			parameters[0].Value = FieldID;

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
		public bool DeleteList(string FieldIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Field ");
			strSql.Append(" where FieldID in ("+FieldIDlist + ")  ");
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
		public Maticsoft.Model.sys_Field GetModel(int FieldID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FieldID,F_Key,F_CName,F_Remark from sys_Field ");
			strSql.Append(" where FieldID=@FieldID");
			SqlParameter[] parameters = {
					new SqlParameter("@FieldID", SqlDbType.Int,4)
			};
			parameters[0].Value = FieldID;

			Maticsoft.Model.sys_Field model=new Maticsoft.Model.sys_Field();
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
		public Maticsoft.Model.sys_Field DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_Field model=new Maticsoft.Model.sys_Field();
			if (row != null)
			{
				if(row["FieldID"]!=null && row["FieldID"].ToString()!="")
				{
					model.FieldID=int.Parse(row["FieldID"].ToString());
				}
				if(row["F_Key"]!=null)
				{
					model.F_Key=row["F_Key"].ToString();
				}
				if(row["F_CName"]!=null)
				{
					model.F_CName=row["F_CName"].ToString();
				}
				if(row["F_Remark"]!=null)
				{
					model.F_Remark=row["F_Remark"].ToString();
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
			strSql.Append("select FieldID,F_Key,F_CName,F_Remark ");
			strSql.Append(" FROM sys_Field ");
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
			strSql.Append(" FieldID,F_Key,F_CName,F_Remark ");
			strSql.Append(" FROM sys_Field ");
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
			strSql.Append("select count(1) FROM sys_Field ");
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
				strSql.Append("order by T.FieldID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_Field T ");
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
			parameters[0].Value = "sys_Field";
			parameters[1].Value = "FieldID";
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

