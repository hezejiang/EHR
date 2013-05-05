using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:supervision_Info
	/// </summary>
	public partial class supervision_Info:Isupervision_Info
	{
		public supervision_Info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InfoID", "supervision_Info"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InfoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from supervision_Info");
			strSql.Append(" where InfoID=@InfoID");
			SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)
			};
			parameters[0].Value = InfoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.supervision_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into supervision_Info(");
			strSql.Append("I_FindDate,I_Type,I_Content,I_ReportDate,I_ReportUserID)");
			strSql.Append(" values (");
			strSql.Append("@I_FindDate,@I_Type,@I_Content,@I_ReportDate,@I_ReportUserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@I_FindDate", SqlDbType.DateTime),
					new SqlParameter("@I_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@I_Content", SqlDbType.Text),
					new SqlParameter("@I_ReportDate", SqlDbType.DateTime),
					new SqlParameter("@I_ReportUserID", SqlDbType.Int,4)};
			parameters[0].Value = model.I_FindDate;
			parameters[1].Value = model.I_Type;
			parameters[2].Value = model.I_Content;
			parameters[3].Value = model.I_ReportDate;
			parameters[4].Value = model.I_ReportUserID;

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
		public bool Update(Maticsoft.Model.supervision_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update supervision_Info set ");
			strSql.Append("I_FindDate=@I_FindDate,");
			strSql.Append("I_Type=@I_Type,");
			strSql.Append("I_Content=@I_Content,");
			strSql.Append("I_ReportDate=@I_ReportDate,");
			strSql.Append("I_ReportUserID=@I_ReportUserID");
			strSql.Append(" where InfoID=@InfoID");
			SqlParameter[] parameters = {
					new SqlParameter("@I_FindDate", SqlDbType.DateTime),
					new SqlParameter("@I_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@I_Content", SqlDbType.Text),
					new SqlParameter("@I_ReportDate", SqlDbType.DateTime),
					new SqlParameter("@I_ReportUserID", SqlDbType.Int,4),
					new SqlParameter("@InfoID", SqlDbType.Int,4)};
			parameters[0].Value = model.I_FindDate;
			parameters[1].Value = model.I_Type;
			parameters[2].Value = model.I_Content;
			parameters[3].Value = model.I_ReportDate;
			parameters[4].Value = model.I_ReportUserID;
			parameters[5].Value = model.InfoID;

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
		public bool Delete(int InfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from supervision_Info ");
			strSql.Append(" where InfoID=@InfoID");
			SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)
			};
			parameters[0].Value = InfoID;

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
		public bool DeleteList(string InfoIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from supervision_Info ");
			strSql.Append(" where InfoID in ("+InfoIDlist + ")  ");
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
		public Maticsoft.Model.supervision_Info GetModel(int InfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InfoID,I_FindDate,I_Type,I_Content,I_ReportDate,I_ReportUserID from supervision_Info ");
			strSql.Append(" where InfoID=@InfoID");
			SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)
			};
			parameters[0].Value = InfoID;

			Maticsoft.Model.supervision_Info model=new Maticsoft.Model.supervision_Info();
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
		public Maticsoft.Model.supervision_Info DataRowToModel(DataRow row)
		{
			Maticsoft.Model.supervision_Info model=new Maticsoft.Model.supervision_Info();
			if (row != null)
			{
				if(row["InfoID"]!=null && row["InfoID"].ToString()!="")
				{
					model.InfoID=int.Parse(row["InfoID"].ToString());
				}
				if(row["I_FindDate"]!=null && row["I_FindDate"].ToString()!="")
				{
					model.I_FindDate=DateTime.Parse(row["I_FindDate"].ToString());
				}
				if(row["I_Type"]!=null && row["I_Type"].ToString()!="")
				{
					model.I_Type=int.Parse(row["I_Type"].ToString());
				}
				if(row["I_Content"]!=null)
				{
					model.I_Content=row["I_Content"].ToString();
				}
				if(row["I_ReportDate"]!=null && row["I_ReportDate"].ToString()!="")
				{
					model.I_ReportDate=DateTime.Parse(row["I_ReportDate"].ToString());
				}
				if(row["I_ReportUserID"]!=null && row["I_ReportUserID"].ToString()!="")
				{
					model.I_ReportUserID=int.Parse(row["I_ReportUserID"].ToString());
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
			strSql.Append("select InfoID,I_FindDate,I_Type,I_Content,I_ReportDate,I_ReportUserID ");
			strSql.Append(" FROM supervision_Info ");
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
			strSql.Append(" InfoID,I_FindDate,I_Type,I_Content,I_ReportDate,I_ReportUserID ");
			strSql.Append(" FROM supervision_Info ");
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
			strSql.Append("select count(1) FROM supervision_Info ");
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
				strSql.Append("order by T.InfoID desc");
			}
			strSql.Append(")AS Row, T.*  from supervision_Info T ");
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
			parameters[0].Value = "supervision_Info";
			parameters[1].Value = "InfoID";
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

