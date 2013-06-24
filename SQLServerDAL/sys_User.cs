/**  版本信息模板在安装目录下，可自行修改。
* sys_User.cs
*
* 功 能： N/A
* 类 名： sys_User
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/22 16:58:58   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_User
	/// </summary>
	public partial class sys_User:Isys_User
	{
		public sys_User()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserID", "sys_User"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_User");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.sys_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_User(");
			strSql.Append("U_LoginName,U_Password,U_CName,U_EName,U_GroupID,U_Email,U_Type,U_Status,U_Licence,U_Mac,U_Remark,U_IDCard,U_Sex,U_BirthDay,U_MobileNo,U_UserNO,U_WorkStartDate,U_WorkEndDate,U_CompanyMail,U_Title,U_Extension,U_HomeTel,U_PhotoUrl,U_DateTime,U_LastIP,U_LastDateTime,U_ExtendField,U_LoginType,U_HospitalGroupID,U_AccessToken)");
			strSql.Append(" values (");
			strSql.Append("@U_LoginName,@U_Password,@U_CName,@U_EName,@U_GroupID,@U_Email,@U_Type,@U_Status,@U_Licence,@U_Mac,@U_Remark,@U_IDCard,@U_Sex,@U_BirthDay,@U_MobileNo,@U_UserNO,@U_WorkStartDate,@U_WorkEndDate,@U_CompanyMail,@U_Title,@U_Extension,@U_HomeTel,@U_PhotoUrl,@U_DateTime,@U_LastIP,@U_LastDateTime,@U_ExtendField,@U_LoginType,@U_HospitalGroupID,@U_AccessToken)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@U_LoginName", SqlDbType.NVarChar,20),
					new SqlParameter("@U_Password", SqlDbType.VarChar,32),
					new SqlParameter("@U_CName", SqlDbType.NVarChar,20),
					new SqlParameter("@U_EName", SqlDbType.VarChar,50),
					new SqlParameter("@U_GroupID", SqlDbType.Int,4),
					new SqlParameter("@U_Email", SqlDbType.VarChar,100),
					new SqlParameter("@U_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@U_Status", SqlDbType.TinyInt,1),
					new SqlParameter("@U_Licence", SqlDbType.VarChar,30),
					new SqlParameter("@U_Mac", SqlDbType.VarChar,50),
					new SqlParameter("@U_Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@U_IDCard", SqlDbType.VarChar,30),
					new SqlParameter("@U_Sex", SqlDbType.TinyInt,1),
					new SqlParameter("@U_BirthDay", SqlDbType.DateTime),
					new SqlParameter("@U_MobileNo", SqlDbType.VarChar,15),
					new SqlParameter("@U_UserNO", SqlDbType.VarChar,20),
					new SqlParameter("@U_WorkStartDate", SqlDbType.DateTime),
					new SqlParameter("@U_WorkEndDate", SqlDbType.DateTime),
					new SqlParameter("@U_CompanyMail", SqlDbType.VarChar,255),
					new SqlParameter("@U_Title", SqlDbType.Int,4),
					new SqlParameter("@U_Extension", SqlDbType.VarChar,10),
					new SqlParameter("@U_HomeTel", SqlDbType.VarChar,20),
					new SqlParameter("@U_PhotoUrl", SqlDbType.NVarChar,255),
					new SqlParameter("@U_DateTime", SqlDbType.DateTime),
					new SqlParameter("@U_LastIP", SqlDbType.VarChar,15),
					new SqlParameter("@U_LastDateTime", SqlDbType.DateTime),
					new SqlParameter("@U_ExtendField", SqlDbType.NText),
					new SqlParameter("@U_LoginType", SqlDbType.VarChar,255),
					new SqlParameter("@U_HospitalGroupID", SqlDbType.Int,4),
					new SqlParameter("@U_AccessToken", SqlDbType.VarChar,30)};
			parameters[0].Value = model.U_LoginName;
			parameters[1].Value = model.U_Password;
			parameters[2].Value = model.U_CName;
			parameters[3].Value = model.U_EName;
			parameters[4].Value = model.U_GroupID;
			parameters[5].Value = model.U_Email;
			parameters[6].Value = model.U_Type;
			parameters[7].Value = model.U_Status;
			parameters[8].Value = model.U_Licence;
			parameters[9].Value = model.U_Mac;
			parameters[10].Value = model.U_Remark;
			parameters[11].Value = model.U_IDCard;
			parameters[12].Value = model.U_Sex;
			parameters[13].Value = model.U_BirthDay;
			parameters[14].Value = model.U_MobileNo;
			parameters[15].Value = model.U_UserNO;
			parameters[16].Value = model.U_WorkStartDate;
			parameters[17].Value = model.U_WorkEndDate;
			parameters[18].Value = model.U_CompanyMail;
			parameters[19].Value = model.U_Title;
			parameters[20].Value = model.U_Extension;
			parameters[21].Value = model.U_HomeTel;
			parameters[22].Value = model.U_PhotoUrl;
			parameters[23].Value = model.U_DateTime;
			parameters[24].Value = model.U_LastIP;
			parameters[25].Value = model.U_LastDateTime;
			parameters[26].Value = model.U_ExtendField;
			parameters[27].Value = model.U_LoginType;
			parameters[28].Value = model.U_HospitalGroupID;
			parameters[29].Value = model.U_AccessToken;

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
		public bool Update(Maticsoft.Model.sys_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_User set ");
			strSql.Append("U_LoginName=@U_LoginName,");
			strSql.Append("U_Password=@U_Password,");
			strSql.Append("U_CName=@U_CName,");
			strSql.Append("U_EName=@U_EName,");
			strSql.Append("U_GroupID=@U_GroupID,");
			strSql.Append("U_Email=@U_Email,");
			strSql.Append("U_Type=@U_Type,");
			strSql.Append("U_Status=@U_Status,");
			strSql.Append("U_Licence=@U_Licence,");
			strSql.Append("U_Mac=@U_Mac,");
			strSql.Append("U_Remark=@U_Remark,");
			strSql.Append("U_IDCard=@U_IDCard,");
			strSql.Append("U_Sex=@U_Sex,");
			strSql.Append("U_BirthDay=@U_BirthDay,");
			strSql.Append("U_MobileNo=@U_MobileNo,");
			strSql.Append("U_UserNO=@U_UserNO,");
			strSql.Append("U_WorkStartDate=@U_WorkStartDate,");
			strSql.Append("U_WorkEndDate=@U_WorkEndDate,");
			strSql.Append("U_CompanyMail=@U_CompanyMail,");
			strSql.Append("U_Title=@U_Title,");
			strSql.Append("U_Extension=@U_Extension,");
			strSql.Append("U_HomeTel=@U_HomeTel,");
			strSql.Append("U_PhotoUrl=@U_PhotoUrl,");
			strSql.Append("U_DateTime=@U_DateTime,");
			strSql.Append("U_LastIP=@U_LastIP,");
			strSql.Append("U_LastDateTime=@U_LastDateTime,");
			strSql.Append("U_ExtendField=@U_ExtendField,");
			strSql.Append("U_LoginType=@U_LoginType,");
			strSql.Append("U_HospitalGroupID=@U_HospitalGroupID,");
			strSql.Append("U_AccessToken=@U_AccessToken");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@U_LoginName", SqlDbType.NVarChar,20),
					new SqlParameter("@U_Password", SqlDbType.VarChar,32),
					new SqlParameter("@U_CName", SqlDbType.NVarChar,20),
					new SqlParameter("@U_EName", SqlDbType.VarChar,50),
					new SqlParameter("@U_GroupID", SqlDbType.Int,4),
					new SqlParameter("@U_Email", SqlDbType.VarChar,100),
					new SqlParameter("@U_Type", SqlDbType.TinyInt,1),
					new SqlParameter("@U_Status", SqlDbType.TinyInt,1),
					new SqlParameter("@U_Licence", SqlDbType.VarChar,30),
					new SqlParameter("@U_Mac", SqlDbType.VarChar,50),
					new SqlParameter("@U_Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@U_IDCard", SqlDbType.VarChar,30),
					new SqlParameter("@U_Sex", SqlDbType.TinyInt,1),
					new SqlParameter("@U_BirthDay", SqlDbType.DateTime),
					new SqlParameter("@U_MobileNo", SqlDbType.VarChar,15),
					new SqlParameter("@U_UserNO", SqlDbType.VarChar,20),
					new SqlParameter("@U_WorkStartDate", SqlDbType.DateTime),
					new SqlParameter("@U_WorkEndDate", SqlDbType.DateTime),
					new SqlParameter("@U_CompanyMail", SqlDbType.VarChar,255),
					new SqlParameter("@U_Title", SqlDbType.Int,4),
					new SqlParameter("@U_Extension", SqlDbType.VarChar,10),
					new SqlParameter("@U_HomeTel", SqlDbType.VarChar,20),
					new SqlParameter("@U_PhotoUrl", SqlDbType.NVarChar,255),
					new SqlParameter("@U_DateTime", SqlDbType.DateTime),
					new SqlParameter("@U_LastIP", SqlDbType.VarChar,15),
					new SqlParameter("@U_LastDateTime", SqlDbType.DateTime),
					new SqlParameter("@U_ExtendField", SqlDbType.NText),
					new SqlParameter("@U_LoginType", SqlDbType.VarChar,255),
					new SqlParameter("@U_HospitalGroupID", SqlDbType.Int,4),
					new SqlParameter("@U_AccessToken", SqlDbType.VarChar,30),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.U_LoginName;
			parameters[1].Value = model.U_Password;
			parameters[2].Value = model.U_CName;
			parameters[3].Value = model.U_EName;
			parameters[4].Value = model.U_GroupID;
			parameters[5].Value = model.U_Email;
			parameters[6].Value = model.U_Type;
			parameters[7].Value = model.U_Status;
			parameters[8].Value = model.U_Licence;
			parameters[9].Value = model.U_Mac;
			parameters[10].Value = model.U_Remark;
			parameters[11].Value = model.U_IDCard;
			parameters[12].Value = model.U_Sex;
			parameters[13].Value = model.U_BirthDay;
			parameters[14].Value = model.U_MobileNo;
			parameters[15].Value = model.U_UserNO;
			parameters[16].Value = model.U_WorkStartDate;
			parameters[17].Value = model.U_WorkEndDate;
			parameters[18].Value = model.U_CompanyMail;
			parameters[19].Value = model.U_Title;
			parameters[20].Value = model.U_Extension;
			parameters[21].Value = model.U_HomeTel;
			parameters[22].Value = model.U_PhotoUrl;
			parameters[23].Value = model.U_DateTime;
			parameters[24].Value = model.U_LastIP;
			parameters[25].Value = model.U_LastDateTime;
			parameters[26].Value = model.U_ExtendField;
			parameters[27].Value = model.U_LoginType;
			parameters[28].Value = model.U_HospitalGroupID;
			parameters[29].Value = model.U_AccessToken;
			parameters[30].Value = model.UserID;

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
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_User ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

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
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_User ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
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
		public Maticsoft.Model.sys_User GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,U_LoginName,U_Password,U_CName,U_EName,U_GroupID,U_Email,U_Type,U_Status,U_Licence,U_Mac,U_Remark,U_IDCard,U_Sex,U_BirthDay,U_MobileNo,U_UserNO,U_WorkStartDate,U_WorkEndDate,U_CompanyMail,U_Title,U_Extension,U_HomeTel,U_PhotoUrl,U_DateTime,U_LastIP,U_LastDateTime,U_ExtendField,U_LoginType,U_HospitalGroupID,U_AccessToken from sys_User ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			Maticsoft.Model.sys_User model=new Maticsoft.Model.sys_User();
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
        public Maticsoft.Model.sys_User GetModel(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            if (ds.Tables[0].Rows.Count > 0)
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
		public Maticsoft.Model.sys_User DataRowToModel(DataRow row)
		{
			Maticsoft.Model.sys_User model=new Maticsoft.Model.sys_User();
			if (row != null)
			{
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["U_LoginName"]!=null)
				{
					model.U_LoginName=row["U_LoginName"].ToString();
				}
				if(row["U_Password"]!=null)
				{
					model.U_Password=row["U_Password"].ToString();
				}
				if(row["U_CName"]!=null)
				{
					model.U_CName=row["U_CName"].ToString();
				}
				if(row["U_EName"]!=null)
				{
					model.U_EName=row["U_EName"].ToString();
				}
				if(row["U_GroupID"]!=null && row["U_GroupID"].ToString()!="")
				{
					model.U_GroupID=int.Parse(row["U_GroupID"].ToString());
				}
				if(row["U_Email"]!=null)
				{
					model.U_Email=row["U_Email"].ToString();
				}
				if(row["U_Type"]!=null && row["U_Type"].ToString()!="")
				{
					model.U_Type=int.Parse(row["U_Type"].ToString());
				}
				if(row["U_Status"]!=null && row["U_Status"].ToString()!="")
				{
					model.U_Status=int.Parse(row["U_Status"].ToString());
				}
				if(row["U_Licence"]!=null)
				{
					model.U_Licence=row["U_Licence"].ToString();
				}
				if(row["U_Mac"]!=null)
				{
					model.U_Mac=row["U_Mac"].ToString();
				}
				if(row["U_Remark"]!=null)
				{
					model.U_Remark=row["U_Remark"].ToString();
				}
				if(row["U_IDCard"]!=null)
				{
					model.U_IDCard=row["U_IDCard"].ToString();
				}
				if(row["U_Sex"]!=null && row["U_Sex"].ToString()!="")
				{
					model.U_Sex=int.Parse(row["U_Sex"].ToString());
				}
				if(row["U_BirthDay"]!=null && row["U_BirthDay"].ToString()!="")
				{
					model.U_BirthDay=DateTime.Parse(row["U_BirthDay"].ToString());
				}
				if(row["U_MobileNo"]!=null)
				{
					model.U_MobileNo=row["U_MobileNo"].ToString();
				}
				if(row["U_UserNO"]!=null)
				{
					model.U_UserNO=row["U_UserNO"].ToString();
				}
				if(row["U_WorkStartDate"]!=null && row["U_WorkStartDate"].ToString()!="")
				{
					model.U_WorkStartDate=DateTime.Parse(row["U_WorkStartDate"].ToString());
				}
				if(row["U_WorkEndDate"]!=null && row["U_WorkEndDate"].ToString()!="")
				{
					model.U_WorkEndDate=DateTime.Parse(row["U_WorkEndDate"].ToString());
				}
				if(row["U_CompanyMail"]!=null)
				{
					model.U_CompanyMail=row["U_CompanyMail"].ToString();
				}
				if(row["U_Title"]!=null && row["U_Title"].ToString()!="")
				{
					model.U_Title=int.Parse(row["U_Title"].ToString());
				}
				if(row["U_Extension"]!=null)
				{
					model.U_Extension=row["U_Extension"].ToString();
				}
				if(row["U_HomeTel"]!=null)
				{
					model.U_HomeTel=row["U_HomeTel"].ToString();
				}
				if(row["U_PhotoUrl"]!=null)
				{
					model.U_PhotoUrl=row["U_PhotoUrl"].ToString();
				}
				if(row["U_DateTime"]!=null && row["U_DateTime"].ToString()!="")
				{
					model.U_DateTime=DateTime.Parse(row["U_DateTime"].ToString());
				}
				if(row["U_LastIP"]!=null)
				{
					model.U_LastIP=row["U_LastIP"].ToString();
				}
				if(row["U_LastDateTime"]!=null && row["U_LastDateTime"].ToString()!="")
				{
					model.U_LastDateTime=DateTime.Parse(row["U_LastDateTime"].ToString());
				}
				if(row["U_ExtendField"]!=null)
				{
					model.U_ExtendField=row["U_ExtendField"].ToString();
				}
				if(row["U_LoginType"]!=null)
				{
					model.U_LoginType=row["U_LoginType"].ToString();
				}
				if(row["U_HospitalGroupID"]!=null && row["U_HospitalGroupID"].ToString()!="")
				{
					model.U_HospitalGroupID=int.Parse(row["U_HospitalGroupID"].ToString());
				}
				if(row["U_AccessToken"]!=null)
				{
					model.U_AccessToken=row["U_AccessToken"].ToString();
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
			strSql.Append("select UserID,U_LoginName,U_Password,U_CName,U_EName,U_GroupID,U_Email,U_Type,U_Status,U_Licence,U_Mac,U_Remark,U_IDCard,U_Sex,U_BirthDay,U_MobileNo,U_UserNO,U_WorkStartDate,U_WorkEndDate,U_CompanyMail,U_Title,U_Extension,U_HomeTel,U_PhotoUrl,U_DateTime,U_LastIP,U_LastDateTime,U_ExtendField,U_LoginType,U_HospitalGroupID,U_AccessToken ");
			strSql.Append(" FROM sys_User ");
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
			strSql.Append(" UserID,U_LoginName,U_Password,U_CName,U_EName,U_GroupID,U_Email,U_Type,U_Status,U_Licence,U_Mac,U_Remark,U_IDCard,U_Sex,U_BirthDay,U_MobileNo,U_UserNO,U_WorkStartDate,U_WorkEndDate,U_CompanyMail,U_Title,U_Extension,U_HomeTel,U_PhotoUrl,U_DateTime,U_LastIP,U_LastDateTime,U_ExtendField,U_LoginType,U_HospitalGroupID,U_AccessToken ");
			strSql.Append(" FROM sys_User ");
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
			strSql.Append("select count(1) FROM sys_User ");
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
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_User T ");
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
			parameters[0].Value = "sys_User";
			parameters[1].Value = "UserID";
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

