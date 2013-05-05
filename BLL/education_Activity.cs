﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
using Maticsoft.DALFactory;
using Maticsoft.IDAL;
namespace Maticsoft.BLL
{
	/// <summary>
	/// education_Activity
	/// </summary>
	public partial class education_Activity
	{
		private readonly Ieducation_Activity dal=DataAccess.Createeducation_Activity();
		public education_Activity()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ActivityID)
		{
			return dal.Exists(ActivityID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.education_Activity model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.education_Activity model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ActivityID)
		{
			
			return dal.Delete(ActivityID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ActivityIDlist )
		{
			return dal.DeleteList(ActivityIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.education_Activity GetModel(int ActivityID)
		{
			
			return dal.GetModel(ActivityID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.education_Activity GetModelByCache(int ActivityID)
		{
			
			string CacheKey = "education_ActivityModel-" + ActivityID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ActivityID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.education_Activity)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.education_Activity> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.education_Activity> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.education_Activity> modelList = new List<Maticsoft.Model.education_Activity>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.education_Activity model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

