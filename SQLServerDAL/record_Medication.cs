using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_Medication
	/// </summary>
	public partial class record_Medication:Irecord_Medication
	{
		public record_Medication()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MedicationID", "record_Medication"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MedicationID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_Medication");
			strSql.Append(" where MedicationID=@MedicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MedicationID", SqlDbType.Int,4)			};
			parameters[0].Value = MedicationID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.record_Medication model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_Medication(");
			strSql.Append("MedicationID,M_ConsultationID,M_StartDate,M_Status)");
			strSql.Append(" values (");
			strSql.Append("@MedicationID,@M_ConsultationID,@M_StartDate,@M_Status)");
			SqlParameter[] parameters = {
					new SqlParameter("@MedicationID", SqlDbType.Int,4),
					new SqlParameter("@M_ConsultationID", SqlDbType.Int,4),
					new SqlParameter("@M_StartDate", SqlDbType.DateTime),
					new SqlParameter("@M_Status", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.MedicationID;
			parameters[1].Value = model.M_ConsultationID;
			parameters[2].Value = model.M_StartDate;
			parameters[3].Value = model.M_Status;

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
		public bool Update(Maticsoft.Model.record_Medication model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_Medication set ");
			strSql.Append("M_ConsultationID=@M_ConsultationID,");
			strSql.Append("M_StartDate=@M_StartDate,");
			strSql.Append("M_Status=@M_Status");
			strSql.Append(" where MedicationID=@MedicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@M_ConsultationID", SqlDbType.Int,4),
					new SqlParameter("@M_StartDate", SqlDbType.DateTime),
					new SqlParameter("@M_Status", SqlDbType.TinyInt,1),
					new SqlParameter("@MedicationID", SqlDbType.Int,4)};
			parameters[0].Value = model.M_ConsultationID;
			parameters[1].Value = model.M_StartDate;
			parameters[2].Value = model.M_Status;
			parameters[3].Value = model.MedicationID;

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
		public bool Delete(int MedicationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_Medication ");
			strSql.Append(" where MedicationID=@MedicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MedicationID", SqlDbType.Int,4)			};
			parameters[0].Value = MedicationID;

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
		public bool DeleteList(string MedicationIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_Medication ");
			strSql.Append(" where MedicationID in ("+MedicationIDlist + ")  ");
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
		public Maticsoft.Model.record_Medication GetModel(int MedicationID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MedicationID,M_ConsultationID,M_StartDate,M_Status from record_Medication ");
			strSql.Append(" where MedicationID=@MedicationID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MedicationID", SqlDbType.Int,4)			};
			parameters[0].Value = MedicationID;

			Maticsoft.Model.record_Medication model=new Maticsoft.Model.record_Medication();
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
		public Maticsoft.Model.record_Medication DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_Medication model=new Maticsoft.Model.record_Medication();
			if (row != null)
			{
				if(row["MedicationID"]!=null && row["MedicationID"].ToString()!="")
				{
					model.MedicationID=int.Parse(row["MedicationID"].ToString());
				}
				if(row["M_ConsultationID"]!=null && row["M_ConsultationID"].ToString()!="")
				{
					model.M_ConsultationID=int.Parse(row["M_ConsultationID"].ToString());
				}
				if(row["M_StartDate"]!=null && row["M_StartDate"].ToString()!="")
				{
					model.M_StartDate=DateTime.Parse(row["M_StartDate"].ToString());
				}
				if(row["M_Status"]!=null && row["M_Status"].ToString()!="")
				{
					model.M_Status=int.Parse(row["M_Status"].ToString());
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
			strSql.Append("select MedicationID,M_ConsultationID,M_StartDate,M_Status ");
			strSql.Append(" FROM record_Medication ");
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
			strSql.Append(" MedicationID,M_ConsultationID,M_StartDate,M_Status ");
			strSql.Append(" FROM record_Medication ");
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
			strSql.Append("select count(1) FROM record_Medication ");
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
				strSql.Append("order by T.MedicationID desc");
			}
			strSql.Append(")AS Row, T.*  from record_Medication T ");
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
			parameters[0].Value = "record_Medication";
			parameters[1].Value = "MedicationID";
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

