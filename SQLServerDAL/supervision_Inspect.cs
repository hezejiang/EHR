using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:supervision_Inspect
	/// </summary>
	public partial class supervision_Inspect:Isupervision_Inspect
	{
		public supervision_Inspect()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InspectID", "supervision_Inspect"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InspectID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from supervision_Inspect");
			strSql.Append(" where InspectID=@InspectID");
			SqlParameter[] parameters = {
					new SqlParameter("@InspectID", SqlDbType.Int,4)
			};
			parameters[0].Value = InspectID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.supervision_Inspect model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into supervision_Inspect(");
			strSql.Append("I_Location,I_Type,I_Date,I_UserID,I_Content,I_MainProblem,I_Note)");
			strSql.Append(" values (");
			strSql.Append("@I_Location,@I_Type,@I_Date,@I_UserID,@I_Content,@I_MainProblem,@I_Note)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@I_Location", SqlDbType.NVarChar,100),
					new SqlParameter("@I_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@I_Date", SqlDbType.DateTime),
					new SqlParameter("@I_UserID", SqlDbType.Int,4),
					new SqlParameter("@I_Content", SqlDbType.Text),
					new SqlParameter("@I_MainProblem", SqlDbType.Text),
					new SqlParameter("@I_Note", SqlDbType.Text)};
			parameters[0].Value = model.I_Location;
			parameters[1].Value = model.I_Type;
			parameters[2].Value = model.I_Date;
			parameters[3].Value = model.I_UserID;
			parameters[4].Value = model.I_Content;
			parameters[5].Value = model.I_MainProblem;
			parameters[6].Value = model.I_Note;

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
		public bool Update(Maticsoft.Model.supervision_Inspect model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update supervision_Inspect set ");
			strSql.Append("I_Location=@I_Location,");
			strSql.Append("I_Type=@I_Type,");
			strSql.Append("I_Date=@I_Date,");
			strSql.Append("I_UserID=@I_UserID,");
			strSql.Append("I_Content=@I_Content,");
			strSql.Append("I_MainProblem=@I_MainProblem,");
			strSql.Append("I_Note=@I_Note");
			strSql.Append(" where InspectID=@InspectID");
			SqlParameter[] parameters = {
					new SqlParameter("@I_Location", SqlDbType.NVarChar,100),
					new SqlParameter("@I_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@I_Date", SqlDbType.DateTime),
					new SqlParameter("@I_UserID", SqlDbType.Int,4),
					new SqlParameter("@I_Content", SqlDbType.Text),
					new SqlParameter("@I_MainProblem", SqlDbType.Text),
					new SqlParameter("@I_Note", SqlDbType.Text),
					new SqlParameter("@InspectID", SqlDbType.Int,4)};
			parameters[0].Value = model.I_Location;
			parameters[1].Value = model.I_Type;
			parameters[2].Value = model.I_Date;
			parameters[3].Value = model.I_UserID;
			parameters[4].Value = model.I_Content;
			parameters[5].Value = model.I_MainProblem;
			parameters[6].Value = model.I_Note;
			parameters[7].Value = model.InspectID;

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
		public bool Delete(int InspectID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from supervision_Inspect ");
			strSql.Append(" where InspectID=@InspectID");
			SqlParameter[] parameters = {
					new SqlParameter("@InspectID", SqlDbType.Int,4)
			};
			parameters[0].Value = InspectID;

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
		public bool DeleteList(string InspectIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from supervision_Inspect ");
			strSql.Append(" where InspectID in ("+InspectIDlist + ")  ");
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
		public Maticsoft.Model.supervision_Inspect GetModel(int InspectID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InspectID,I_Location,I_Type,I_Date,I_UserID,I_Content,I_MainProblem,I_Note from supervision_Inspect ");
			strSql.Append(" where InspectID=@InspectID");
			SqlParameter[] parameters = {
					new SqlParameter("@InspectID", SqlDbType.Int,4)
			};
			parameters[0].Value = InspectID;

			Maticsoft.Model.supervision_Inspect model=new Maticsoft.Model.supervision_Inspect();
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
		public Maticsoft.Model.supervision_Inspect DataRowToModel(DataRow row)
		{
			Maticsoft.Model.supervision_Inspect model=new Maticsoft.Model.supervision_Inspect();
			if (row != null)
			{
				if(row["InspectID"]!=null && row["InspectID"].ToString()!="")
				{
					model.InspectID=int.Parse(row["InspectID"].ToString());
				}
				if(row["I_Location"]!=null)
				{
					model.I_Location=row["I_Location"].ToString();
				}
				if(row["I_Type"]!=null && row["I_Type"].ToString()!="")
				{
					model.I_Type=int.Parse(row["I_Type"].ToString());
				}
				if(row["I_Date"]!=null && row["I_Date"].ToString()!="")
				{
					model.I_Date=DateTime.Parse(row["I_Date"].ToString());
				}
				if(row["I_UserID"]!=null && row["I_UserID"].ToString()!="")
				{
					model.I_UserID=int.Parse(row["I_UserID"].ToString());
				}
				if(row["I_Content"]!=null)
				{
					model.I_Content=row["I_Content"].ToString();
				}
				if(row["I_MainProblem"]!=null)
				{
					model.I_MainProblem=row["I_MainProblem"].ToString();
				}
				if(row["I_Note"]!=null)
				{
					model.I_Note=row["I_Note"].ToString();
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
			strSql.Append("select InspectID,I_Location,I_Type,I_Date,I_UserID,I_Content,I_MainProblem,I_Note ");
			strSql.Append(" FROM supervision_Inspect ");
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
			strSql.Append(" InspectID,I_Location,I_Type,I_Date,I_UserID,I_Content,I_MainProblem,I_Note ");
			strSql.Append(" FROM supervision_Inspect ");
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
			strSql.Append("select count(1) FROM supervision_Inspect ");
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
				strSql.Append("order by T.InspectID desc");
			}
			strSql.Append(")AS Row, T.*  from supervision_Inspect T ");
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
			parameters[0].Value = "supervision_Inspect";
			parameters[1].Value = "InspectID";
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

