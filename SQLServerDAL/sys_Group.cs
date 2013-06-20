using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
using System.Collections.Generic;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_Group
	/// </summary>
	public partial class sys_Group:Isys_Group
	{
		public sys_Group()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("GroupID", "sys_Group"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_Group");
			strSql.Append(" where GroupID=@GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4)
			};
			parameters[0].Value = GroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_Group(");
			strSql.Append("G_CName,G_ParentID,G_ShowOrder,G_Level,G_ChildCount,G_Delete,G_Type,G_Code)");
			strSql.Append(" values (");
			strSql.Append("@G_CName,@G_ParentID,@G_ShowOrder,@G_Level,@G_ChildCount,@G_Delete,@G_Type,@G_Code)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@G_CName", SqlDbType.NVarChar,50),
					new SqlParameter("@G_ParentID", SqlDbType.Int,4),
					new SqlParameter("@G_ShowOrder", SqlDbType.Int,4),
					new SqlParameter("@G_Level", SqlDbType.Int,4),
					new SqlParameter("@G_ChildCount", SqlDbType.Int,4),
					new SqlParameter("@G_Delete", SqlDbType.TinyInt,1),
					new SqlParameter("@G_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@G_Code", SqlDbType.VarChar,20)};
			parameters[0].Value = model.G_CName;
			parameters[1].Value = model.G_ParentID;
			parameters[2].Value = model.G_ShowOrder;
			parameters[3].Value = model.G_Level;
			parameters[4].Value = model.G_ChildCount;
			parameters[5].Value = model.G_Delete;
			parameters[6].Value = model.G_Type;
			parameters[7].Value = model.G_Code;

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
		public bool Update(Maticsoft.Model.sys_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_Group set ");
			strSql.Append("G_CName=@G_CName,");
			strSql.Append("G_ParentID=@G_ParentID,");
			strSql.Append("G_ShowOrder=@G_ShowOrder,");
			strSql.Append("G_Level=@G_Level,");
			strSql.Append("G_ChildCount=@G_ChildCount,");
			strSql.Append("G_Delete=@G_Delete,");
			strSql.Append("G_Type=@G_Type,");
			strSql.Append("G_Code=@G_Code");
			strSql.Append(" where GroupID=@GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@G_CName", SqlDbType.NVarChar,50),
					new SqlParameter("@G_ParentID", SqlDbType.Int,4),
					new SqlParameter("@G_ShowOrder", SqlDbType.Int,4),
					new SqlParameter("@G_Level", SqlDbType.Int,4),
					new SqlParameter("@G_ChildCount", SqlDbType.Int,4),
					new SqlParameter("@G_Delete", SqlDbType.TinyInt,1),
					new SqlParameter("@G_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@G_Code", SqlDbType.VarChar,20),
					new SqlParameter("@GroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.G_CName;
			parameters[1].Value = model.G_ParentID;
			parameters[2].Value = model.G_ShowOrder;
			parameters[3].Value = model.G_Level;
			parameters[4].Value = model.G_ChildCount;
			parameters[5].Value = model.G_Delete;
			parameters[6].Value = model.G_Type;
			parameters[7].Value = model.G_Code;
			parameters[8].Value = model.GroupID;

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
		public bool Delete(int GroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Group ");
			strSql.Append(" where GroupID=@GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4)
			};
			parameters[0].Value = GroupID;

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
		public bool DeleteList(string GroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_Group ");
			strSql.Append(" where GroupID in ("+GroupIDlist + ")  ");
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
		public Maticsoft.Model.sys_Group GetModel(int GroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GroupID,G_CName,G_ParentID,G_ShowOrder,G_Level,G_ChildCount,G_Delete,G_Type,G_Code from sys_Group ");
			strSql.Append(" where GroupID=@GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4)
			};
			parameters[0].Value = GroupID;

			Maticsoft.Model.sys_Group model=new Maticsoft.Model.sys_Group();
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
		public Maticsoft.Model.sys_Group DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_Group model=new Maticsoft.Model.sys_Group();
			if (row != null)
			{
				if(row["GroupID"]!=null && row["GroupID"].ToString()!="")
				{
					model.GroupID=int.Parse(row["GroupID"].ToString());
				}
				if(row["G_CName"]!=null)
				{
					model.G_CName=row["G_CName"].ToString();
				}
				if(row["G_ParentID"]!=null && row["G_ParentID"].ToString()!="")
				{
					model.G_ParentID=int.Parse(row["G_ParentID"].ToString());
				}
				if(row["G_ShowOrder"]!=null && row["G_ShowOrder"].ToString()!="")
				{
					model.G_ShowOrder=int.Parse(row["G_ShowOrder"].ToString());
				}
				if(row["G_Level"]!=null && row["G_Level"].ToString()!="")
				{
					model.G_Level=int.Parse(row["G_Level"].ToString());
				}
				if(row["G_ChildCount"]!=null && row["G_ChildCount"].ToString()!="")
				{
					model.G_ChildCount=int.Parse(row["G_ChildCount"].ToString());
				}
				if(row["G_Delete"]!=null && row["G_Delete"].ToString()!="")
				{
					model.G_Delete=int.Parse(row["G_Delete"].ToString());
				}
				if(row["G_Type"]!=null && row["G_Type"].ToString()!="")
				{
					model.G_Type=int.Parse(row["G_Type"].ToString());
				}
				if(row["G_Code"]!=null)
				{
					model.G_Code=row["G_Code"].ToString();
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
			strSql.Append("select GroupID,G_CName,G_ParentID,G_ShowOrder,G_Level,G_ChildCount,G_Delete,G_Type,G_Code ");
			strSql.Append(" FROM sys_Group ");
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
			strSql.Append(" GroupID,G_CName,G_ParentID,G_ShowOrder,G_Level,G_ChildCount,G_Delete,G_Type,G_Code ");
			strSql.Append(" FROM sys_Group ");
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
			strSql.Append("select count(1) FROM sys_Group ");
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
				strSql.Append("order by T.GroupID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_Group T ");
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
			parameters[0].Value = "sys_Group";
			parameters[1].Value = "GroupID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

        public List<Maticsoft.Model.sys_Group> GetLowerLevel(int GroupID, Boolean isDriect)
        {
            List<Maticsoft.Model.sys_Group> list = new List<Maticsoft.Model.sys_Group>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from sys_Group");
            strSql.Append(" where G_ParentID=@G_ParentID");
            SqlParameter[] parameters = {
					new SqlParameter("@G_ParentID", SqlDbType.Int,4)
			};
            parameters[0].Value = GroupID;

            Maticsoft.Model.sys_Group model = new Maticsoft.Model.sys_Group();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                model = (Maticsoft.Model.sys_Group)DataRowToModel(dt.Rows[i]);
                list.Add(model);
                if (!isDriect)
                {
                    list.AddRange(GetLowerLevel(model.GroupID, isDriect));
                }
            }
            return list;
        }

        public List<Maticsoft.Model.sys_Group> GetHigherLevel(int G_ParentID, Boolean isDriect)
        {
            List<Maticsoft.Model.sys_Group> list = new List<Maticsoft.Model.sys_Group>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from sys_Group");
            strSql.Append(" where GroupID=@GroupID");
            SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4)
			};
            parameters[0].Value = G_ParentID;

            Maticsoft.Model.sys_Group model = new Maticsoft.Model.sys_Group();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                model = (Maticsoft.Model.sys_Group)DataRowToModel(dt.Rows[i]);
                list.Add(model);
                if (!isDriect)
                {
                    list.AddRange(GetHigherLevel(model.G_ParentID, isDriect));
                }
            }
            return list;
        }
		#endregion  ExtensionMethod
	}
}

