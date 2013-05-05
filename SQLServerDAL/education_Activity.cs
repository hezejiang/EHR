using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:education_Activity
	/// </summary>
	public partial class education_Activity:Ieducation_Activity
	{
		public education_Activity()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ActivityID", "education_Activity"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ActivityID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from education_Activity");
			strSql.Append(" where ActivityID=@ActivityID");
			SqlParameter[] parameters = {
					new SqlParameter("@ActivityID", SqlDbType.Int,4)
			};
			parameters[0].Value = ActivityID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.education_Activity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into education_Activity(");
			strSql.Append("A_DateTime,A_Location,A_Form,A_Object,A_Crowd,A_Duration,A_Organizers,A_Partners,A_Missionary,A_Number,A_Theme)");
			strSql.Append(" values (");
			strSql.Append("@A_DateTime,@A_Location,@A_Form,@A_Object,@A_Crowd,@A_Duration,@A_Organizers,@A_Partners,@A_Missionary,@A_Number,@A_Theme)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@A_DateTime", SqlDbType.DateTime),
					new SqlParameter("@A_Location", SqlDbType.NVarChar,100),
					new SqlParameter("@A_Form", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Object", SqlDbType.Int,4),
					new SqlParameter("@A_Crowd", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Duration", SqlDbType.Int,4),
					new SqlParameter("@A_Organizers", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Partners", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Missionary", SqlDbType.NVarChar,20),
					new SqlParameter("@A_Number", SqlDbType.Int,4),
					new SqlParameter("@A_Theme", SqlDbType.Text)};
			parameters[0].Value = model.A_DateTime;
			parameters[1].Value = model.A_Location;
			parameters[2].Value = model.A_Form;
			parameters[3].Value = model.A_Object;
			parameters[4].Value = model.A_Crowd;
			parameters[5].Value = model.A_Duration;
			parameters[6].Value = model.A_Organizers;
			parameters[7].Value = model.A_Partners;
			parameters[8].Value = model.A_Missionary;
			parameters[9].Value = model.A_Number;
			parameters[10].Value = model.A_Theme;

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
		public bool Update(Maticsoft.Model.education_Activity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update education_Activity set ");
			strSql.Append("A_DateTime=@A_DateTime,");
			strSql.Append("A_Location=@A_Location,");
			strSql.Append("A_Form=@A_Form,");
			strSql.Append("A_Object=@A_Object,");
			strSql.Append("A_Crowd=@A_Crowd,");
			strSql.Append("A_Duration=@A_Duration,");
			strSql.Append("A_Organizers=@A_Organizers,");
			strSql.Append("A_Partners=@A_Partners,");
			strSql.Append("A_Missionary=@A_Missionary,");
			strSql.Append("A_Number=@A_Number,");
			strSql.Append("A_Theme=@A_Theme");
			strSql.Append(" where ActivityID=@ActivityID");
			SqlParameter[] parameters = {
					new SqlParameter("@A_DateTime", SqlDbType.DateTime),
					new SqlParameter("@A_Location", SqlDbType.NVarChar,100),
					new SqlParameter("@A_Form", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Object", SqlDbType.Int,4),
					new SqlParameter("@A_Crowd", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Duration", SqlDbType.Int,4),
					new SqlParameter("@A_Organizers", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Partners", SqlDbType.NVarChar,50),
					new SqlParameter("@A_Missionary", SqlDbType.NVarChar,20),
					new SqlParameter("@A_Number", SqlDbType.Int,4),
					new SqlParameter("@A_Theme", SqlDbType.Text),
					new SqlParameter("@ActivityID", SqlDbType.Int,4)};
			parameters[0].Value = model.A_DateTime;
			parameters[1].Value = model.A_Location;
			parameters[2].Value = model.A_Form;
			parameters[3].Value = model.A_Object;
			parameters[4].Value = model.A_Crowd;
			parameters[5].Value = model.A_Duration;
			parameters[6].Value = model.A_Organizers;
			parameters[7].Value = model.A_Partners;
			parameters[8].Value = model.A_Missionary;
			parameters[9].Value = model.A_Number;
			parameters[10].Value = model.A_Theme;
			parameters[11].Value = model.ActivityID;

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
		public bool Delete(int ActivityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from education_Activity ");
			strSql.Append(" where ActivityID=@ActivityID");
			SqlParameter[] parameters = {
					new SqlParameter("@ActivityID", SqlDbType.Int,4)
			};
			parameters[0].Value = ActivityID;

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
		public bool DeleteList(string ActivityIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from education_Activity ");
			strSql.Append(" where ActivityID in ("+ActivityIDlist + ")  ");
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
		public Maticsoft.Model.education_Activity GetModel(int ActivityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ActivityID,A_DateTime,A_Location,A_Form,A_Object,A_Crowd,A_Duration,A_Organizers,A_Partners,A_Missionary,A_Number,A_Theme from education_Activity ");
			strSql.Append(" where ActivityID=@ActivityID");
			SqlParameter[] parameters = {
					new SqlParameter("@ActivityID", SqlDbType.Int,4)
			};
			parameters[0].Value = ActivityID;

			Maticsoft.Model.education_Activity model=new Maticsoft.Model.education_Activity();
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
		public Maticsoft.Model.education_Activity DataRowToModel(DataRow row)
		{
			Maticsoft.Model.education_Activity model=new Maticsoft.Model.education_Activity();
			if (row != null)
			{
				if(row["ActivityID"]!=null && row["ActivityID"].ToString()!="")
				{
					model.ActivityID=int.Parse(row["ActivityID"].ToString());
				}
				if(row["A_DateTime"]!=null && row["A_DateTime"].ToString()!="")
				{
					model.A_DateTime=DateTime.Parse(row["A_DateTime"].ToString());
				}
				if(row["A_Location"]!=null)
				{
					model.A_Location=row["A_Location"].ToString();
				}
				if(row["A_Form"]!=null)
				{
					model.A_Form=row["A_Form"].ToString();
				}
				if(row["A_Object"]!=null && row["A_Object"].ToString()!="")
				{
					model.A_Object=int.Parse(row["A_Object"].ToString());
				}
				if(row["A_Crowd"]!=null)
				{
					model.A_Crowd=row["A_Crowd"].ToString();
				}
				if(row["A_Duration"]!=null && row["A_Duration"].ToString()!="")
				{
					model.A_Duration=int.Parse(row["A_Duration"].ToString());
				}
				if(row["A_Organizers"]!=null)
				{
					model.A_Organizers=row["A_Organizers"].ToString();
				}
				if(row["A_Partners"]!=null)
				{
					model.A_Partners=row["A_Partners"].ToString();
				}
				if(row["A_Missionary"]!=null)
				{
					model.A_Missionary=row["A_Missionary"].ToString();
				}
				if(row["A_Number"]!=null && row["A_Number"].ToString()!="")
				{
					model.A_Number=int.Parse(row["A_Number"].ToString());
				}
				if(row["A_Theme"]!=null)
				{
					model.A_Theme=row["A_Theme"].ToString();
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
			strSql.Append("select ActivityID,A_DateTime,A_Location,A_Form,A_Object,A_Crowd,A_Duration,A_Organizers,A_Partners,A_Missionary,A_Number,A_Theme ");
			strSql.Append(" FROM education_Activity ");
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
			strSql.Append(" ActivityID,A_DateTime,A_Location,A_Form,A_Object,A_Crowd,A_Duration,A_Organizers,A_Partners,A_Missionary,A_Number,A_Theme ");
			strSql.Append(" FROM education_Activity ");
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
			strSql.Append("select count(1) FROM education_Activity ");
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
				strSql.Append("order by T.ActivityID desc");
			}
			strSql.Append(")AS Row, T.*  from education_Activity T ");
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
			parameters[0].Value = "education_Activity";
			parameters[1].Value = "ActivityID";
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

