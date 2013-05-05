using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_MedicationTime
	/// </summary>
	public partial class record_MedicationTime:Irecord_MedicationTime
	{
		public record_MedicationTime()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MedicationTimeID", "record_MedicationTime"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MedicationTimeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_MedicationTime");
			strSql.Append(" where MedicationTimeID=@MedicationTimeID");
			SqlParameter[] parameters = {
					new SqlParameter("@MedicationTimeID", SqlDbType.Int,4)
			};
			parameters[0].Value = MedicationTimeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.record_MedicationTime model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_MedicationTime(");
			strSql.Append("M_Time,MedicationID)");
			strSql.Append(" values (");
			strSql.Append("@M_Time,@MedicationID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@M_Time", SqlDbType.VarChar,20),
					new SqlParameter("@MedicationID", SqlDbType.Int,4)};
			parameters[0].Value = model.M_Time;
			parameters[1].Value = model.MedicationID;

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
		public bool Update(Maticsoft.Model.record_MedicationTime model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_MedicationTime set ");
			strSql.Append("M_Time=@M_Time,");
			strSql.Append("MedicationID=@MedicationID");
			strSql.Append(" where MedicationTimeID=@MedicationTimeID");
			SqlParameter[] parameters = {
					new SqlParameter("@M_Time", SqlDbType.VarChar,20),
					new SqlParameter("@MedicationID", SqlDbType.Int,4),
					new SqlParameter("@MedicationTimeID", SqlDbType.Int,4)};
			parameters[0].Value = model.M_Time;
			parameters[1].Value = model.MedicationID;
			parameters[2].Value = model.MedicationTimeID;

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
		public bool Delete(int MedicationTimeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_MedicationTime ");
			strSql.Append(" where MedicationTimeID=@MedicationTimeID");
			SqlParameter[] parameters = {
					new SqlParameter("@MedicationTimeID", SqlDbType.Int,4)
			};
			parameters[0].Value = MedicationTimeID;

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
		public bool DeleteList(string MedicationTimeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_MedicationTime ");
			strSql.Append(" where MedicationTimeID in ("+MedicationTimeIDlist + ")  ");
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
		public Maticsoft.Model.record_MedicationTime GetModel(int MedicationTimeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MedicationTimeID,M_Time,MedicationID from record_MedicationTime ");
			strSql.Append(" where MedicationTimeID=@MedicationTimeID");
			SqlParameter[] parameters = {
					new SqlParameter("@MedicationTimeID", SqlDbType.Int,4)
			};
			parameters[0].Value = MedicationTimeID;

			Maticsoft.Model.record_MedicationTime model=new Maticsoft.Model.record_MedicationTime();
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
		public Maticsoft.Model.record_MedicationTime DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_MedicationTime model=new Maticsoft.Model.record_MedicationTime();
			if (row != null)
			{
				if(row["MedicationTimeID"]!=null && row["MedicationTimeID"].ToString()!="")
				{
					model.MedicationTimeID=int.Parse(row["MedicationTimeID"].ToString());
				}
				if(row["M_Time"]!=null)
				{
					model.M_Time=row["M_Time"].ToString();
				}
				if(row["MedicationID"]!=null && row["MedicationID"].ToString()!="")
				{
					model.MedicationID=int.Parse(row["MedicationID"].ToString());
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
			strSql.Append("select MedicationTimeID,M_Time,MedicationID ");
			strSql.Append(" FROM record_MedicationTime ");
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
			strSql.Append(" MedicationTimeID,M_Time,MedicationID ");
			strSql.Append(" FROM record_MedicationTime ");
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
			strSql.Append("select count(1) FROM record_MedicationTime ");
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
				strSql.Append("order by T.MedicationTimeID desc");
			}
			strSql.Append(")AS Row, T.*  from record_MedicationTime T ");
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
			parameters[0].Value = "record_MedicationTime";
			parameters[1].Value = "MedicationTimeID";
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

