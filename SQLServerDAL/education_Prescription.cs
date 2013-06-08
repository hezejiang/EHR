using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:education_Prescription
	/// </summary>
	public partial class education_Prescription:Ieducation_Prescription
	{
		public education_Prescription()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PrescriptionID", "education_Prescription"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PrescriptionID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from education_Prescription");
			strSql.Append(" where PrescriptionID=@PrescriptionID");
			SqlParameter[] parameters = {
					new SqlParameter("@PrescriptionID", SqlDbType.Int,4)
			};
			parameters[0].Value = PrescriptionID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.education_Prescription model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into education_Prescription(");
			strSql.Append("P_Object,P_Name,P_Content,P_Doctor,P_Date)");
			strSql.Append(" values (");
			strSql.Append("@P_Object,@P_Name,@P_Content,@P_Doctor,@P_Date)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@P_Object", SqlDbType.Int,8),
					new SqlParameter("@P_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@P_Content", SqlDbType.Text),
					new SqlParameter("@P_Doctor", SqlDbType.Int,4),
					new SqlParameter("@P_Date", SqlDbType.DateTime)};
			parameters[0].Value = model.P_Object;
			parameters[1].Value = model.P_Name;
			parameters[2].Value = model.P_Content;
			parameters[3].Value = model.P_Doctor;
			parameters[4].Value = model.P_Date;

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
		public bool Update(Maticsoft.Model.education_Prescription model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update education_Prescription set ");
			strSql.Append("P_Object=@P_Object,");
			strSql.Append("P_Name=@P_Name,");
			strSql.Append("P_Content=@P_Content,");
			strSql.Append("P_Doctor=@P_Doctor,");
			strSql.Append("P_Date=@P_Date");
			strSql.Append(" where PrescriptionID=@PrescriptionID");
			SqlParameter[] parameters = {
					new SqlParameter("@P_Object", SqlDbType.Int,8),
					new SqlParameter("@P_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@P_Content", SqlDbType.Text),
					new SqlParameter("@P_Doctor", SqlDbType.Int,4),
					new SqlParameter("@P_Date", SqlDbType.DateTime),
					new SqlParameter("@PrescriptionID", SqlDbType.Int,4)};
			parameters[0].Value = model.P_Object;
			parameters[1].Value = model.P_Name;
			parameters[2].Value = model.P_Content;
			parameters[3].Value = model.P_Doctor;
			parameters[4].Value = model.P_Date;
			parameters[5].Value = model.PrescriptionID;

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
		public bool Delete(int PrescriptionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from education_Prescription ");
			strSql.Append(" where PrescriptionID=@PrescriptionID");
			SqlParameter[] parameters = {
					new SqlParameter("@PrescriptionID", SqlDbType.Int,4)
			};
			parameters[0].Value = PrescriptionID;

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
		public bool DeleteList(string PrescriptionIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from education_Prescription ");
			strSql.Append(" where PrescriptionID in ("+PrescriptionIDlist + ")  ");
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
		public Maticsoft.Model.education_Prescription GetModel(int PrescriptionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PrescriptionID,P_Object,P_Name,P_Content,P_Doctor,P_Date from education_Prescription ");
			strSql.Append(" where PrescriptionID=@PrescriptionID");
			SqlParameter[] parameters = {
					new SqlParameter("@PrescriptionID", SqlDbType.Int,4)
			};
			parameters[0].Value = PrescriptionID;

			Maticsoft.Model.education_Prescription model=new Maticsoft.Model.education_Prescription();
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
		public Maticsoft.Model.education_Prescription DataRowToModel(DataRow row)
		{
			Maticsoft.Model.education_Prescription model=new Maticsoft.Model.education_Prescription();
			if (row != null)
			{
				if(row["PrescriptionID"]!=null && row["PrescriptionID"].ToString()!="")
				{
					model.PrescriptionID=int.Parse(row["PrescriptionID"].ToString());
				}
				if(row["P_Object"]!=null && row["P_Object"].ToString()!="")
				{
					model.P_Object=int.Parse(row["P_Object"].ToString());
				}
				if(row["P_Name"]!=null)
				{
					model.P_Name=row["P_Name"].ToString();
				}
				if(row["P_Content"]!=null)
				{
					model.P_Content=row["P_Content"].ToString();
				}
				if(row["P_Doctor"]!=null && row["P_Doctor"].ToString()!="")
				{
					model.P_Doctor=int.Parse(row["P_Doctor"].ToString());
				}
				if(row["P_Date"]!=null && row["P_Date"].ToString()!="")
				{
					model.P_Date=DateTime.Parse(row["P_Date"].ToString());
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
			strSql.Append("select PrescriptionID,P_Object,P_Name,P_Content,P_Doctor,P_Date ");
			strSql.Append(" FROM education_Prescription ");
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
			strSql.Append(" PrescriptionID,P_Object,P_Name,P_Content,P_Doctor,P_Date ");
			strSql.Append(" FROM education_Prescription ");
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
			strSql.Append("select count(1) FROM education_Prescription ");
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
				strSql.Append("order by T.PrescriptionID desc");
			}
			strSql.Append(")AS Row, T.*  from education_Prescription T ");
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
			parameters[0].Value = "education_Prescription";
			parameters[1].Value = "PrescriptionID";
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

