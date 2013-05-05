using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:record_FamilyBaseInfo
	/// </summary>
	public partial class record_FamilyBaseInfo:Irecord_FamilyBaseInfo
	{
		public record_FamilyBaseInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FimaryID", "record_FamilyBaseInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FimaryID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from record_FamilyBaseInfo");
			strSql.Append(" where FimaryID=@FimaryID");
			SqlParameter[] parameters = {
					new SqlParameter("@FimaryID", SqlDbType.Int,4)
			};
			parameters[0].Value = FimaryID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.record_FamilyBaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into record_FamilyBaseInfo(");
			strSql.Append("F_FimaryCode,F_UserID,F_GroupID,F_FimaryTel,F_FimrayAddress,F_HouseType,F_HouseArea,F_Ventilation,F_Humidity,F_Warm,F_Lighting,F_Sanitation,F_Kitchen,F_Fuel,F_Water,F_WasteDisposal,F_LivestockBar,F_ToiletType,F_ResponsibilityUserID,F_FillingUserID)");
			strSql.Append(" values (");
			strSql.Append("@F_FimaryCode,@F_UserID,@F_GroupID,@F_FimaryTel,@F_FimrayAddress,@F_HouseType,@F_HouseArea,@F_Ventilation,@F_Humidity,@F_Warm,@F_Lighting,@F_Sanitation,@F_Kitchen,@F_Fuel,@F_Water,@F_WasteDisposal,@F_LivestockBar,@F_ToiletType,@F_ResponsibilityUserID,@F_FillingUserID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_FimaryCode", SqlDbType.VarChar,30),
					new SqlParameter("@F_UserID", SqlDbType.Int,4),
					new SqlParameter("@F_GroupID", SqlDbType.Int,4),
					new SqlParameter("@F_FimaryTel", SqlDbType.VarChar,20),
					new SqlParameter("@F_FimrayAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@F_HouseType", SqlDbType.TinyInt,1),
					new SqlParameter("@F_HouseArea", SqlDbType.Float,8),
					new SqlParameter("@F_Ventilation", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Humidity", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Warm", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Lighting", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Sanitation", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Kitchen", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Fuel", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Water", SqlDbType.TinyInt,1),
					new SqlParameter("@F_WasteDisposal", SqlDbType.TinyInt,1),
					new SqlParameter("@F_LivestockBar", SqlDbType.TinyInt,1),
					new SqlParameter("@F_ToiletType", SqlDbType.TinyInt,1),
					new SqlParameter("@F_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@F_FillingUserID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_FimaryCode;
			parameters[1].Value = model.F_UserID;
			parameters[2].Value = model.F_GroupID;
			parameters[3].Value = model.F_FimaryTel;
			parameters[4].Value = model.F_FimrayAddress;
			parameters[5].Value = model.F_HouseType;
			parameters[6].Value = model.F_HouseArea;
			parameters[7].Value = model.F_Ventilation;
			parameters[8].Value = model.F_Humidity;
			parameters[9].Value = model.F_Warm;
			parameters[10].Value = model.F_Lighting;
			parameters[11].Value = model.F_Sanitation;
			parameters[12].Value = model.F_Kitchen;
			parameters[13].Value = model.F_Fuel;
			parameters[14].Value = model.F_Water;
			parameters[15].Value = model.F_WasteDisposal;
			parameters[16].Value = model.F_LivestockBar;
			parameters[17].Value = model.F_ToiletType;
			parameters[18].Value = model.F_ResponsibilityUserID;
			parameters[19].Value = model.F_FillingUserID;

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
		public bool Update(Maticsoft.Model.record_FamilyBaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update record_FamilyBaseInfo set ");
			strSql.Append("F_FimaryCode=@F_FimaryCode,");
			strSql.Append("F_UserID=@F_UserID,");
			strSql.Append("F_GroupID=@F_GroupID,");
			strSql.Append("F_FimaryTel=@F_FimaryTel,");
			strSql.Append("F_FimrayAddress=@F_FimrayAddress,");
			strSql.Append("F_HouseType=@F_HouseType,");
			strSql.Append("F_HouseArea=@F_HouseArea,");
			strSql.Append("F_Ventilation=@F_Ventilation,");
			strSql.Append("F_Humidity=@F_Humidity,");
			strSql.Append("F_Warm=@F_Warm,");
			strSql.Append("F_Lighting=@F_Lighting,");
			strSql.Append("F_Sanitation=@F_Sanitation,");
			strSql.Append("F_Kitchen=@F_Kitchen,");
			strSql.Append("F_Fuel=@F_Fuel,");
			strSql.Append("F_Water=@F_Water,");
			strSql.Append("F_WasteDisposal=@F_WasteDisposal,");
			strSql.Append("F_LivestockBar=@F_LivestockBar,");
			strSql.Append("F_ToiletType=@F_ToiletType,");
			strSql.Append("F_ResponsibilityUserID=@F_ResponsibilityUserID,");
			strSql.Append("F_FillingUserID=@F_FillingUserID");
			strSql.Append(" where FimaryID=@FimaryID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_FimaryCode", SqlDbType.VarChar,30),
					new SqlParameter("@F_UserID", SqlDbType.Int,4),
					new SqlParameter("@F_GroupID", SqlDbType.Int,4),
					new SqlParameter("@F_FimaryTel", SqlDbType.VarChar,20),
					new SqlParameter("@F_FimrayAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@F_HouseType", SqlDbType.TinyInt,1),
					new SqlParameter("@F_HouseArea", SqlDbType.Float,8),
					new SqlParameter("@F_Ventilation", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Humidity", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Warm", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Lighting", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Sanitation", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Kitchen", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Fuel", SqlDbType.TinyInt,1),
					new SqlParameter("@F_Water", SqlDbType.TinyInt,1),
					new SqlParameter("@F_WasteDisposal", SqlDbType.TinyInt,1),
					new SqlParameter("@F_LivestockBar", SqlDbType.TinyInt,1),
					new SqlParameter("@F_ToiletType", SqlDbType.TinyInt,1),
					new SqlParameter("@F_ResponsibilityUserID", SqlDbType.Int,4),
					new SqlParameter("@F_FillingUserID", SqlDbType.Int,4),
					new SqlParameter("@FimaryID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_FimaryCode;
			parameters[1].Value = model.F_UserID;
			parameters[2].Value = model.F_GroupID;
			parameters[3].Value = model.F_FimaryTel;
			parameters[4].Value = model.F_FimrayAddress;
			parameters[5].Value = model.F_HouseType;
			parameters[6].Value = model.F_HouseArea;
			parameters[7].Value = model.F_Ventilation;
			parameters[8].Value = model.F_Humidity;
			parameters[9].Value = model.F_Warm;
			parameters[10].Value = model.F_Lighting;
			parameters[11].Value = model.F_Sanitation;
			parameters[12].Value = model.F_Kitchen;
			parameters[13].Value = model.F_Fuel;
			parameters[14].Value = model.F_Water;
			parameters[15].Value = model.F_WasteDisposal;
			parameters[16].Value = model.F_LivestockBar;
			parameters[17].Value = model.F_ToiletType;
			parameters[18].Value = model.F_ResponsibilityUserID;
			parameters[19].Value = model.F_FillingUserID;
			parameters[20].Value = model.FimaryID;

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
		public bool Delete(int FimaryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_FamilyBaseInfo ");
			strSql.Append(" where FimaryID=@FimaryID");
			SqlParameter[] parameters = {
					new SqlParameter("@FimaryID", SqlDbType.Int,4)
			};
			parameters[0].Value = FimaryID;

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
		public bool DeleteList(string FimaryIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from record_FamilyBaseInfo ");
			strSql.Append(" where FimaryID in ("+FimaryIDlist + ")  ");
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
		public Maticsoft.Model.record_FamilyBaseInfo GetModel(int FimaryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FimaryID,F_FimaryCode,F_UserID,F_GroupID,F_FimaryTel,F_FimrayAddress,F_HouseType,F_HouseArea,F_Ventilation,F_Humidity,F_Warm,F_Lighting,F_Sanitation,F_Kitchen,F_Fuel,F_Water,F_WasteDisposal,F_LivestockBar,F_ToiletType,F_ResponsibilityUserID,F_FillingUserID from record_FamilyBaseInfo ");
			strSql.Append(" where FimaryID=@FimaryID");
			SqlParameter[] parameters = {
					new SqlParameter("@FimaryID", SqlDbType.Int,4)
			};
			parameters[0].Value = FimaryID;

			Maticsoft.Model.record_FamilyBaseInfo model=new Maticsoft.Model.record_FamilyBaseInfo();
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
		public Maticsoft.Model.record_FamilyBaseInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.record_FamilyBaseInfo model=new Maticsoft.Model.record_FamilyBaseInfo();
			if (row != null)
			{
				if(row["FimaryID"]!=null && row["FimaryID"].ToString()!="")
				{
					model.FimaryID=int.Parse(row["FimaryID"].ToString());
				}
				if(row["F_FimaryCode"]!=null)
				{
					model.F_FimaryCode=row["F_FimaryCode"].ToString();
				}
				if(row["F_UserID"]!=null && row["F_UserID"].ToString()!="")
				{
					model.F_UserID=int.Parse(row["F_UserID"].ToString());
				}
				if(row["F_GroupID"]!=null && row["F_GroupID"].ToString()!="")
				{
					model.F_GroupID=int.Parse(row["F_GroupID"].ToString());
				}
				if(row["F_FimaryTel"]!=null)
				{
					model.F_FimaryTel=row["F_FimaryTel"].ToString();
				}
				if(row["F_FimrayAddress"]!=null)
				{
					model.F_FimrayAddress=row["F_FimrayAddress"].ToString();
				}
				if(row["F_HouseType"]!=null && row["F_HouseType"].ToString()!="")
				{
					model.F_HouseType=int.Parse(row["F_HouseType"].ToString());
				}
				if(row["F_HouseArea"]!=null && row["F_HouseArea"].ToString()!="")
				{
					model.F_HouseArea=decimal.Parse(row["F_HouseArea"].ToString());
				}
				if(row["F_Ventilation"]!=null && row["F_Ventilation"].ToString()!="")
				{
					model.F_Ventilation=int.Parse(row["F_Ventilation"].ToString());
				}
				if(row["F_Humidity"]!=null && row["F_Humidity"].ToString()!="")
				{
					model.F_Humidity=int.Parse(row["F_Humidity"].ToString());
				}
				if(row["F_Warm"]!=null && row["F_Warm"].ToString()!="")
				{
					model.F_Warm=int.Parse(row["F_Warm"].ToString());
				}
				if(row["F_Lighting"]!=null && row["F_Lighting"].ToString()!="")
				{
					model.F_Lighting=int.Parse(row["F_Lighting"].ToString());
				}
				if(row["F_Sanitation"]!=null && row["F_Sanitation"].ToString()!="")
				{
					model.F_Sanitation=int.Parse(row["F_Sanitation"].ToString());
				}
				if(row["F_Kitchen"]!=null && row["F_Kitchen"].ToString()!="")
				{
					model.F_Kitchen=int.Parse(row["F_Kitchen"].ToString());
				}
				if(row["F_Fuel"]!=null && row["F_Fuel"].ToString()!="")
				{
					model.F_Fuel=int.Parse(row["F_Fuel"].ToString());
				}
				if(row["F_Water"]!=null && row["F_Water"].ToString()!="")
				{
					model.F_Water=int.Parse(row["F_Water"].ToString());
				}
				if(row["F_WasteDisposal"]!=null && row["F_WasteDisposal"].ToString()!="")
				{
					model.F_WasteDisposal=int.Parse(row["F_WasteDisposal"].ToString());
				}
				if(row["F_LivestockBar"]!=null && row["F_LivestockBar"].ToString()!="")
				{
					model.F_LivestockBar=int.Parse(row["F_LivestockBar"].ToString());
				}
				if(row["F_ToiletType"]!=null && row["F_ToiletType"].ToString()!="")
				{
					model.F_ToiletType=int.Parse(row["F_ToiletType"].ToString());
				}
				if(row["F_ResponsibilityUserID"]!=null && row["F_ResponsibilityUserID"].ToString()!="")
				{
					model.F_ResponsibilityUserID=int.Parse(row["F_ResponsibilityUserID"].ToString());
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
			strSql.Append("select FimaryID,F_FimaryCode,F_UserID,F_GroupID,F_FimaryTel,F_FimrayAddress,F_HouseType,F_HouseArea,F_Ventilation,F_Humidity,F_Warm,F_Lighting,F_Sanitation,F_Kitchen,F_Fuel,F_Water,F_WasteDisposal,F_LivestockBar,F_ToiletType,F_ResponsibilityUserID,F_FillingUserID ");
			strSql.Append(" FROM record_FamilyBaseInfo ");
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
			strSql.Append(" FimaryID,F_FimaryCode,F_UserID,F_GroupID,F_FimaryTel,F_FimrayAddress,F_HouseType,F_HouseArea,F_Ventilation,F_Humidity,F_Warm,F_Lighting,F_Sanitation,F_Kitchen,F_Fuel,F_Water,F_WasteDisposal,F_LivestockBar,F_ToiletType,F_ResponsibilityUserID,F_FillingUserID ");
			strSql.Append(" FROM record_FamilyBaseInfo ");
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
			strSql.Append("select count(1) FROM record_FamilyBaseInfo ");
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
			strSql.Append(")AS Row, T.*  from record_FamilyBaseInfo T ");
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
			parameters[0].Value = "record_FamilyBaseInfo";
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

