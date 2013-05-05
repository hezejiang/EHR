using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_FimaryProblem
	/// </summary>
	public partial class record_FimaryProblem:Irecord_FimaryProblem
	{
		public record_FimaryProblem()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.record_FimaryProblem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_FimaryProblem(");
			strSql.Append("F_FimaryCode,F_RecordTime,F_StartTime,F_endTime,F_OverviewProblem,F_DetailProblem,F_FillingUserID)");
			strSql.Append(" values (");
			strSql.Append("@F_FimaryCode,@F_RecordTime,@F_StartTime,@F_endTime,@F_OverviewProblem,@F_DetailProblem,@F_FillingUserID)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_FimaryCode", SqlDbType.VarChar,30),
					new SqlParameter("@F_RecordTime", SqlDbType.DateTime),
					new SqlParameter("@F_StartTime", SqlDbType.DateTime),
					new SqlParameter("@F_endTime", SqlDbType.DateTime),
					new SqlParameter("@F_OverviewProblem", SqlDbType.NVarChar,255),
					new SqlParameter("@F_DetailProblem", SqlDbType.Text),
					new SqlParameter("@F_FillingUserID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_FimaryCode;
			parameters[1].Value = model.F_RecordTime;
			parameters[2].Value = model.F_StartTime;
			parameters[3].Value = model.F_endTime;
			parameters[4].Value = model.F_OverviewProblem;
			parameters[5].Value = model.F_DetailProblem;
			parameters[6].Value = model.F_FillingUserID;

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
		public bool Update(Maticsoft.Model.record_FimaryProblem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_FimaryProblem set ");
			strSql.Append("F_FimaryCode=@F_FimaryCode,");
			strSql.Append("F_RecordTime=@F_RecordTime,");
			strSql.Append("F_StartTime=@F_StartTime,");
			strSql.Append("F_endTime=@F_endTime,");
			strSql.Append("F_OverviewProblem=@F_OverviewProblem,");
			strSql.Append("F_DetailProblem=@F_DetailProblem,");
			strSql.Append("F_FillingUserID=@F_FillingUserID");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_FimaryCode", SqlDbType.VarChar,30),
					new SqlParameter("@F_RecordTime", SqlDbType.DateTime),
					new SqlParameter("@F_StartTime", SqlDbType.DateTime),
					new SqlParameter("@F_endTime", SqlDbType.DateTime),
					new SqlParameter("@F_OverviewProblem", SqlDbType.NVarChar,255),
					new SqlParameter("@F_DetailProblem", SqlDbType.Text),
					new SqlParameter("@F_FillingUserID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_FimaryCode;
			parameters[1].Value = model.F_RecordTime;
			parameters[2].Value = model.F_StartTime;
			parameters[3].Value = model.F_endTime;
			parameters[4].Value = model.F_OverviewProblem;
			parameters[5].Value = model.F_DetailProblem;
			parameters[6].Value = model.F_FillingUserID;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_FimaryProblem ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public Maticsoft.Model.record_FimaryProblem GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_FimaryCode,F_RecordTime,F_StartTime,F_endTime,F_OverviewProblem,F_DetailProblem,F_FillingUserID from record_FimaryProblem ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.record_FimaryProblem model=new Maticsoft.Model.record_FimaryProblem();
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
		public Maticsoft.Model.record_FimaryProblem DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_FimaryProblem model=new Maticsoft.Model.record_FimaryProblem();
			if (row != null)
			{
				if(row["F_FimaryCode"]!=null)
				{
					model.F_FimaryCode=row["F_FimaryCode"].ToString();
				}
				if(row["F_RecordTime"]!=null && row["F_RecordTime"].ToString()!="")
				{
					model.F_RecordTime=DateTime.Parse(row["F_RecordTime"].ToString());
				}
				if(row["F_StartTime"]!=null && row["F_StartTime"].ToString()!="")
				{
					model.F_StartTime=DateTime.Parse(row["F_StartTime"].ToString());
				}
				if(row["F_endTime"]!=null && row["F_endTime"].ToString()!="")
				{
					model.F_endTime=DateTime.Parse(row["F_endTime"].ToString());
				}
				if(row["F_OverviewProblem"]!=null)
				{
					model.F_OverviewProblem=row["F_OverviewProblem"].ToString();
				}
				if(row["F_DetailProblem"]!=null)
				{
					model.F_DetailProblem=row["F_DetailProblem"].ToString();
				}
				if(row["F_FillingUserID"]!=null && row["F_FillingUserID"].ToString()!="")
				{
					model.F_FillingUserID=int.Parse(row["F_FillingUserID"].ToString());
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
			strSql.Append("select F_FimaryCode,F_RecordTime,F_StartTime,F_endTime,F_OverviewProblem,F_DetailProblem,F_FillingUserID ");
			strSql.Append(" FROM record_FimaryProblem ");
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
			strSql.Append(" F_FimaryCode,F_RecordTime,F_StartTime,F_endTime,F_OverviewProblem,F_DetailProblem,F_FillingUserID ");
			strSql.Append(" FROM record_FimaryProblem ");
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
			strSql.Append("select count(1) FROM record_FimaryProblem ");
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
				strSql.Append("order by T.FimaryID desc");
			}
			strSql.Append(")AS Row, T.*  from record_FimaryProblem T ");
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
			parameters[0].Value = "record_FimaryProblem";
			parameters[1].Value = "FimaryID";
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

