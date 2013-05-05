using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_FieldValue
	/// </summary>
	public partial class sys_FieldValue:Isys_FieldValue
	{
		public sys_FieldValue()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ValueID", "sys_FieldValue"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ValueID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_FieldValue");
			strSql.Append(" where ValueID=@ValueID");
			SqlParameter[] parameters = {
					new SqlParameter("@ValueID", SqlDbType.Int,4)
			};
			parameters[0].Value = ValueID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_FieldValue model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_FieldValue(");
			strSql.Append("V_F_Key,V_Text,V_Code,V_ShowOrder)");
			strSql.Append(" values (");
			strSql.Append("@V_F_Key,@V_Text,@V_Code,@V_ShowOrder)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@V_F_Key", SqlDbType.VarChar,50),
					new SqlParameter("@V_Text", SqlDbType.NVarChar,100),
					new SqlParameter("@V_Code", SqlDbType.VarChar,100),
					new SqlParameter("@V_ShowOrder", SqlDbType.Int,4)};
			parameters[0].Value = model.V_F_Key;
			parameters[1].Value = model.V_Text;
			parameters[2].Value = model.V_Code;
			parameters[3].Value = model.V_ShowOrder;

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
		public bool Update(Maticsoft.Model.sys_FieldValue model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_FieldValue set ");
			strSql.Append("V_F_Key=@V_F_Key,");
			strSql.Append("V_Text=@V_Text,");
			strSql.Append("V_Code=@V_Code,");
			strSql.Append("V_ShowOrder=@V_ShowOrder");
			strSql.Append(" where ValueID=@ValueID");
			SqlParameter[] parameters = {
					new SqlParameter("@V_F_Key", SqlDbType.VarChar,50),
					new SqlParameter("@V_Text", SqlDbType.NVarChar,100),
					new SqlParameter("@V_Code", SqlDbType.VarChar,100),
					new SqlParameter("@V_ShowOrder", SqlDbType.Int,4),
					new SqlParameter("@ValueID", SqlDbType.Int,4)};
			parameters[0].Value = model.V_F_Key;
			parameters[1].Value = model.V_Text;
			parameters[2].Value = model.V_Code;
			parameters[3].Value = model.V_ShowOrder;
			parameters[4].Value = model.ValueID;

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
		public bool Delete(int ValueID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_FieldValue ");
			strSql.Append(" where ValueID=@ValueID");
			SqlParameter[] parameters = {
					new SqlParameter("@ValueID", SqlDbType.Int,4)
			};
			parameters[0].Value = ValueID;

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
		public bool DeleteList(string ValueIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_FieldValue ");
			strSql.Append(" where ValueID in ("+ValueIDlist + ")  ");
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
		public Maticsoft.Model.sys_FieldValue GetModel(int ValueID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ValueID,V_F_Key,V_Text,V_Code,V_ShowOrder from sys_FieldValue ");
			strSql.Append(" where ValueID=@ValueID");
			SqlParameter[] parameters = {
					new SqlParameter("@ValueID", SqlDbType.Int,4)
			};
			parameters[0].Value = ValueID;

			Maticsoft.Model.sys_FieldValue model=new Maticsoft.Model.sys_FieldValue();
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
		public Maticsoft.Model.sys_FieldValue DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_FieldValue model=new Maticsoft.Model.sys_FieldValue();
			if (row != null)
			{
				if(row["ValueID"]!=null && row["ValueID"].ToString()!="")
				{
					model.ValueID=int.Parse(row["ValueID"].ToString());
				}
				if(row["V_F_Key"]!=null)
				{
					model.V_F_Key=row["V_F_Key"].ToString();
				}
				if(row["V_Text"]!=null)
				{
					model.V_Text=row["V_Text"].ToString();
				}
				if(row["V_Code"]!=null)
				{
					model.V_Code=row["V_Code"].ToString();
				}
				if(row["V_ShowOrder"]!=null && row["V_ShowOrder"].ToString()!="")
				{
					model.V_ShowOrder=int.Parse(row["V_ShowOrder"].ToString());
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
			strSql.Append("select ValueID,V_F_Key,V_Text,V_Code,V_ShowOrder ");
			strSql.Append(" FROM sys_FieldValue ");
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
			strSql.Append(" ValueID,V_F_Key,V_Text,V_Code,V_ShowOrder ");
			strSql.Append(" FROM sys_FieldValue ");
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
			strSql.Append("select count(1) FROM sys_FieldValue ");
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
				strSql.Append("order by T.ValueID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_FieldValue T ");
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
			parameters[0].Value = "sys_FieldValue";
			parameters[1].Value = "ValueID";
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

