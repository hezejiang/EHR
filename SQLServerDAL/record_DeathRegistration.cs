using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_DeathRegistration
	/// </summary>
	public partial class record_DeathRegistration:Irecord_DeathRegistration
	{
		public record_DeathRegistration()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DeathID", "record_DeathRegistration"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DeathID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_DeathRegistration");
			strSql.Append(" where DeathID=@DeathID");
			SqlParameter[] parameters = {
					new SqlParameter("@DeathID", SqlDbType.Int,4)
			};
			parameters[0].Value = DeathID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.record_DeathRegistration model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_DeathRegistration(");
			strSql.Append("D_DateTime,D_Location,D_Icd10ID,D_Note,D_UserID,D_RegDate)");
			strSql.Append(" values (");
			strSql.Append("@D_DateTime,@D_Location,@D_Icd10ID,@D_Note,@D_UserID,@D_RegDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@D_DateTime", SqlDbType.DateTime),
					new SqlParameter("@D_Location", SqlDbType.NVarChar,50),
					new SqlParameter("@D_Icd10ID", SqlDbType.Int,4),
					new SqlParameter("@D_Note", SqlDbType.Text),
					new SqlParameter("@D_UserID", SqlDbType.Int,4),
					new SqlParameter("@D_RegDate", SqlDbType.DateTime)};
			parameters[0].Value = model.D_DateTime;
			parameters[1].Value = model.D_Location;
			parameters[2].Value = model.D_Icd10ID;
			parameters[3].Value = model.D_Note;
			parameters[4].Value = model.D_UserID;
			parameters[5].Value = model.D_RegDate;

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
		public bool Update(Maticsoft.Model.record_DeathRegistration model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_DeathRegistration set ");
			strSql.Append("D_DateTime=@D_DateTime,");
			strSql.Append("D_Location=@D_Location,");
			strSql.Append("D_Icd10ID=@D_Icd10ID,");
			strSql.Append("D_Note=@D_Note,");
			strSql.Append("D_UserID=@D_UserID,");
			strSql.Append("D_RegDate=@D_RegDate");
			strSql.Append(" where DeathID=@DeathID");
			SqlParameter[] parameters = {
					new SqlParameter("@D_DateTime", SqlDbType.DateTime),
					new SqlParameter("@D_Location", SqlDbType.NVarChar,50),
					new SqlParameter("@D_Icd10ID", SqlDbType.Int,4),
					new SqlParameter("@D_Note", SqlDbType.Text),
					new SqlParameter("@D_UserID", SqlDbType.Int,4),
					new SqlParameter("@D_RegDate", SqlDbType.DateTime),
					new SqlParameter("@DeathID", SqlDbType.Int,4)};
			parameters[0].Value = model.D_DateTime;
			parameters[1].Value = model.D_Location;
			parameters[2].Value = model.D_Icd10ID;
			parameters[3].Value = model.D_Note;
			parameters[4].Value = model.D_UserID;
			parameters[5].Value = model.D_RegDate;
			parameters[6].Value = model.DeathID;

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
		public bool Delete(int DeathID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_DeathRegistration ");
			strSql.Append(" where DeathID=@DeathID");
			SqlParameter[] parameters = {
					new SqlParameter("@DeathID", SqlDbType.Int,4)
			};
			parameters[0].Value = DeathID;

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
		public bool DeleteList(string DeathIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_DeathRegistration ");
			strSql.Append(" where DeathID in ("+DeathIDlist + ")  ");
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
		public Maticsoft.Model.record_DeathRegistration GetModel(int DeathID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DeathID,D_DateTime,D_Location,D_Icd10ID,D_Note,D_UserID,D_RegDate from record_DeathRegistration ");
			strSql.Append(" where DeathID=@DeathID");
			SqlParameter[] parameters = {
					new SqlParameter("@DeathID", SqlDbType.Int,4)
			};
			parameters[0].Value = DeathID;

			Maticsoft.Model.record_DeathRegistration model=new Maticsoft.Model.record_DeathRegistration();
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
		public Maticsoft.Model.record_DeathRegistration DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_DeathRegistration model=new Maticsoft.Model.record_DeathRegistration();
			if (row != null)
			{
				if(row["DeathID"]!=null && row["DeathID"].ToString()!="")
				{
					model.DeathID=int.Parse(row["DeathID"].ToString());
				}
				if(row["D_DateTime"]!=null && row["D_DateTime"].ToString()!="")
				{
					model.D_DateTime=DateTime.Parse(row["D_DateTime"].ToString());
				}
				if(row["D_Location"]!=null)
				{
					model.D_Location=row["D_Location"].ToString();
				}
				if(row["D_Icd10ID"]!=null && row["D_Icd10ID"].ToString()!="")
				{
					model.D_Icd10ID=int.Parse(row["D_Icd10ID"].ToString());
				}
				if(row["D_Note"]!=null)
				{
					model.D_Note=row["D_Note"].ToString();
				}
				if(row["D_UserID"]!=null && row["D_UserID"].ToString()!="")
				{
					model.D_UserID=int.Parse(row["D_UserID"].ToString());
				}
				if(row["D_RegDate"]!=null && row["D_RegDate"].ToString()!="")
				{
					model.D_RegDate=DateTime.Parse(row["D_RegDate"].ToString());
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
			strSql.Append("select DeathID,D_DateTime,D_Location,D_Icd10ID,D_Note,D_UserID,D_RegDate ");
			strSql.Append(" FROM record_DeathRegistration ");
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
			strSql.Append(" DeathID,D_DateTime,D_Location,D_Icd10ID,D_Note,D_UserID,D_RegDate ");
			strSql.Append(" FROM record_DeathRegistration ");
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
			strSql.Append("select count(1) FROM record_DeathRegistration ");
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
				strSql.Append("order by T.DeathID desc");
			}
			strSql.Append(")AS Row, T.*  from record_DeathRegistration T ");
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
			parameters[0].Value = "record_DeathRegistration";
			parameters[1].Value = "DeathID";
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

