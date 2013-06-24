using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_HealthCheck
	/// </summary>
	public partial class record_HealthCheck:Irecord_HealthCheck
	{
		public record_HealthCheck()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("HealthID", "record_HealthCheck"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int HealthID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_HealthCheck");
			strSql.Append(" where HealthID=@HealthID");
			SqlParameter[] parameters = {
					new SqlParameter("@HealthID", SqlDbType.Int,4)
			};
			parameters[0].Value = HealthID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.record_HealthCheck model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_HealthCheck(");
			strSql.Append("H_BodyTemperature,H_PulseRate,H_RespiratoryRate,H_LeftDiastolic,H_LeftSystolic,H_RightDiastolic,H_RightSystolic,H_Height,H_Weight,H_Result,H_Suggestion,H_CheckTime,H_MedicalInstitutions,H_CheckUserID,H_UserID)");
			strSql.Append(" values (");
            strSql.Append("@H_BodyTemperature,@H_PulseRate,@H_RespiratoryRate,@H_LeftDiastolic,@H_LeftSystolic,@H_RightDiastolic,@H_RightSystolic,@H_Height,@H_Weight,@H_Result,@H_Suggestion,@H_CheckTime,@H_MedicalInstitutions,@H_CheckUserID,@H_UserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@H_BodyTemperature", SqlDbType.Float,8),
					new SqlParameter("@H_PulseRate", SqlDbType.TinyInt,1),
					new SqlParameter("@H_RespiratoryRate", SqlDbType.TinyInt,1),
					new SqlParameter("@H_LeftDiastolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_LeftSystolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_RightDiastolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_RightSystolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_Height", SqlDbType.TinyInt,1),
					new SqlParameter("@H_Weight", SqlDbType.TinyInt,1),
					new SqlParameter("@H_Result", SqlDbType.Text),
					new SqlParameter("@H_Suggestion", SqlDbType.Text),
					new SqlParameter("@H_CheckTime", SqlDbType.DateTime),
					new SqlParameter("@H_MedicalInstitutions", SqlDbType.Int,4),
					new SqlParameter("@H_CheckUserID", SqlDbType.Int,4),
                    new SqlParameter("@H_UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.H_BodyTemperature;
			parameters[1].Value = model.H_PulseRate;
			parameters[2].Value = model.H_RespiratoryRate;
			parameters[3].Value = model.H_LeftDiastolic;
			parameters[4].Value = model.H_LeftSystolic;
			parameters[5].Value = model.H_RightDiastolic;
			parameters[6].Value = model.H_RightSystolic;
			parameters[7].Value = model.H_Height;
			parameters[8].Value = model.H_Weight;
			parameters[9].Value = model.H_Result;
			parameters[10].Value = model.H_Suggestion;
			parameters[11].Value = model.H_CheckTime;
			parameters[12].Value = model.H_MedicalInstitutions;
			parameters[13].Value = model.H_CheckUserID;
            parameters[14].Value = model.H_UserID;
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
		public bool Update(Maticsoft.Model.record_HealthCheck model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_HealthCheck set ");
			strSql.Append("H_BodyTemperature=@H_BodyTemperature,");
			strSql.Append("H_PulseRate=@H_PulseRate,");
			strSql.Append("H_RespiratoryRate=@H_RespiratoryRate,");
			strSql.Append("H_LeftDiastolic=@H_LeftDiastolic,");
			strSql.Append("H_LeftSystolic=@H_LeftSystolic,");
			strSql.Append("H_RightDiastolic=@H_RightDiastolic,");
			strSql.Append("H_RightSystolic=@H_RightSystolic,");
			strSql.Append("H_Height=@H_Height,");
			strSql.Append("H_Weight=@H_Weight,");
			strSql.Append("H_Result=@H_Result,");
			strSql.Append("H_Suggestion=@H_Suggestion,");
			strSql.Append("H_CheckTime=@H_CheckTime,");
			strSql.Append("H_MedicalInstitutions=@H_MedicalInstitutions,");
			strSql.Append("H_CheckUserID=@H_CheckUserID,");
            strSql.Append("H_UserID=@H_UserID");
			strSql.Append(" where HealthID=@HealthID");
			SqlParameter[] parameters = {
					new SqlParameter("@H_BodyTemperature", SqlDbType.Float,8),
					new SqlParameter("@H_PulseRate", SqlDbType.TinyInt,1),
					new SqlParameter("@H_RespiratoryRate", SqlDbType.TinyInt,1),
					new SqlParameter("@H_LeftDiastolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_LeftSystolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_RightDiastolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_RightSystolic", SqlDbType.TinyInt,1),
					new SqlParameter("@H_Height", SqlDbType.TinyInt,1),
					new SqlParameter("@H_Weight", SqlDbType.TinyInt,1),
					new SqlParameter("@H_Result", SqlDbType.Text),
					new SqlParameter("@H_Suggestion", SqlDbType.Text),
					new SqlParameter("@H_CheckTime", SqlDbType.DateTime),
					new SqlParameter("@H_MedicalInstitutions", SqlDbType.Int,4),
					new SqlParameter("@H_CheckUserID", SqlDbType.Int,4),
                    new SqlParameter("@H_UserID", SqlDbType.Int,4),
					new SqlParameter("@HealthID", SqlDbType.Int,4)};
			parameters[0].Value = model.H_BodyTemperature;
			parameters[1].Value = model.H_PulseRate;
			parameters[2].Value = model.H_RespiratoryRate;
			parameters[3].Value = model.H_LeftDiastolic;
			parameters[4].Value = model.H_LeftSystolic;
			parameters[5].Value = model.H_RightDiastolic;
			parameters[6].Value = model.H_RightSystolic;
			parameters[7].Value = model.H_Height;
			parameters[8].Value = model.H_Weight;
			parameters[9].Value = model.H_Result;
			parameters[10].Value = model.H_Suggestion;
			parameters[11].Value = model.H_CheckTime;
			parameters[12].Value = model.H_MedicalInstitutions;
			parameters[13].Value = model.H_CheckUserID;
            parameters[14].Value = model.H_UserID;
			parameters[15].Value = model.HealthID;

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
		public bool Delete(int HealthID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_HealthCheck ");
			strSql.Append(" where HealthID=@HealthID");
			SqlParameter[] parameters = {
					new SqlParameter("@HealthID", SqlDbType.Int,4)
			};
			parameters[0].Value = HealthID;

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
		public bool DeleteList(string HealthIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_HealthCheck ");
			strSql.Append(" where HealthID in ("+HealthIDlist + ")  ");
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
		public Maticsoft.Model.record_HealthCheck GetModel(int HealthID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 HealthID,H_BodyTemperature,H_PulseRate,H_RespiratoryRate,H_LeftDiastolic,H_LeftSystolic,H_RightDiastolic,H_RightSystolic,H_Height,H_Weight,H_Result,H_Suggestion,H_CheckTime,H_MedicalInstitutions,H_CheckUserID,H_UserID from record_HealthCheck ");
			strSql.Append(" where HealthID=@HealthID");
			SqlParameter[] parameters = {
					new SqlParameter("@HealthID", SqlDbType.Int,4)
			};
			parameters[0].Value = HealthID;

			Maticsoft.Model.record_HealthCheck model=new Maticsoft.Model.record_HealthCheck();
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
		public Maticsoft.Model.record_HealthCheck DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_HealthCheck model=new Maticsoft.Model.record_HealthCheck();
			if (row != null)
			{
				if(row["HealthID"]!=null && row["HealthID"].ToString()!="")
				{
					model.HealthID=int.Parse(row["HealthID"].ToString());
				}
				if(row["H_BodyTemperature"]!=null && row["H_BodyTemperature"].ToString()!="")
				{
					model.H_BodyTemperature=decimal.Parse(row["H_BodyTemperature"].ToString());
				}
				if(row["H_PulseRate"]!=null && row["H_PulseRate"].ToString()!="")
				{
					model.H_PulseRate=int.Parse(row["H_PulseRate"].ToString());
				}
				if(row["H_RespiratoryRate"]!=null && row["H_RespiratoryRate"].ToString()!="")
				{
					model.H_RespiratoryRate=int.Parse(row["H_RespiratoryRate"].ToString());
				}
				if(row["H_LeftDiastolic"]!=null && row["H_LeftDiastolic"].ToString()!="")
				{
					model.H_LeftDiastolic=int.Parse(row["H_LeftDiastolic"].ToString());
				}
				if(row["H_LeftSystolic"]!=null && row["H_LeftSystolic"].ToString()!="")
				{
					model.H_LeftSystolic=int.Parse(row["H_LeftSystolic"].ToString());
				}
				if(row["H_RightDiastolic"]!=null && row["H_RightDiastolic"].ToString()!="")
				{
					model.H_RightDiastolic=int.Parse(row["H_RightDiastolic"].ToString());
				}
				if(row["H_RightSystolic"]!=null && row["H_RightSystolic"].ToString()!="")
				{
					model.H_RightSystolic=int.Parse(row["H_RightSystolic"].ToString());
				}
				if(row["H_Height"]!=null && row["H_Height"].ToString()!="")
				{
					model.H_Height=int.Parse(row["H_Height"].ToString());
				}
				if(row["H_Weight"]!=null && row["H_Weight"].ToString()!="")
				{
					model.H_Weight=int.Parse(row["H_Weight"].ToString());
				}
				if(row["H_Result"]!=null)
				{
					model.H_Result=row["H_Result"].ToString();
				}
				if(row["H_Suggestion"]!=null)
				{
					model.H_Suggestion=row["H_Suggestion"].ToString();
				}
				if(row["H_CheckTime"]!=null && row["H_CheckTime"].ToString()!="")
				{
					model.H_CheckTime=DateTime.Parse(row["H_CheckTime"].ToString());
				}
				if(row["H_MedicalInstitutions"]!=null && row["H_MedicalInstitutions"].ToString()!="")
				{
					model.H_MedicalInstitutions=int.Parse(row["H_MedicalInstitutions"].ToString());
				}
				if(row["H_CheckUserID"]!=null && row["H_CheckUserID"].ToString()!="")
				{
					model.H_CheckUserID=int.Parse(row["H_CheckUserID"].ToString());
				}
                if (row["H_UserID"] != null && row["H_UserID"].ToString() != "")
                {
                    model.H_UserID = int.Parse(row["H_UserID"].ToString());
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
			strSql.Append("select HealthID,H_BodyTemperature,H_PulseRate,H_RespiratoryRate,H_LeftDiastolic,H_LeftSystolic,H_RightDiastolic,H_RightSystolic,H_Height,H_Weight,H_Result,H_Suggestion,H_CheckTime,H_MedicalInstitutions,H_CheckUserID ");
			strSql.Append(" FROM record_HealthCheck ");
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
            strSql.Append(" HealthID,H_BodyTemperature,H_PulseRate,H_RespiratoryRate,H_LeftDiastolic,H_LeftSystolic,H_RightDiastolic,H_RightSystolic,H_Height,H_Weight,H_Result,H_Suggestion,H_CheckTime,H_MedicalInstitutions,H_CheckUserID,H_UserID ");
			strSql.Append(" FROM record_HealthCheck ");
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
			strSql.Append("select count(1) FROM record_HealthCheck ");
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
				strSql.Append("order by T.HealthID desc");
			}
			strSql.Append(")AS Row, T.*  from record_HealthCheck T ");
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
			parameters[0].Value = "record_HealthCheck";
			parameters[1].Value = "HealthID";
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

