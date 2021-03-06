﻿using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
using Maticsoft.DALFactory;
using Maticsoft.IDAL;
using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace Maticsoft.BLL
{
	/// <summary>
	/// 部门
	/// </summary>
	public partial class sys_Group
	{
		private readonly Isys_Group dal=DataAccess.Createsys_Group();
		public sys_Group()
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
		public bool Exists(int GroupID)
		{
			return dal.Exists(GroupID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.sys_Group model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.sys_Group model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int GroupID)
		{
			
			return dal.Delete(GroupID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string GroupIDlist )
		{
			return dal.DeleteList(GroupIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.sys_Group GetModel(int GroupID)
		{
			
			return dal.GetModel(GroupID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.sys_Group GetModelByCache(int GroupID)
		{
			
			string CacheKey = "sys_GroupModel-" + GroupID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(GroupID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.sys_Group)objModel;
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
		public List<Maticsoft.Model.sys_Group> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.sys_Group> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.sys_Group> modelList = new List<Maticsoft.Model.sys_Group>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.sys_Group model;
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
        public List<Maticsoft.Model.sys_Group> GetLowerLevel(int GroupID, Boolean isDriect)
        {
            return dal.GetLowerLevel(GroupID, isDriect);
        }

        public string GetLowerLevelString(int GroupID, Boolean isDriect)
        {
            List<Maticsoft.Model.sys_Group> list = GetLowerLevel(GroupID, isDriect);
            string GroupIDs = "";
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    GroupIDs = GroupIDs + ((Maticsoft.Model.sys_Group)list[i]).GroupID + ",";
                }
                GroupIDs = GroupIDs.Substring(0, GroupIDs.Length - 1);
            }
            return GroupIDs;
        }

        public string GetLowerLevelString_withSelf(int GroupID, Boolean isDriect)
        {
            List<Maticsoft.Model.sys_Group> list = GetLowerLevel(GroupID, isDriect);
            string GroupIDs = "";
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    GroupIDs = GroupIDs + ((Maticsoft.Model.sys_Group)list[i]).GroupID + ",";
                }
                GroupIDs = GroupIDs.Substring(0, GroupIDs.Length - 1);
            }
            Maticsoft.Model.sys_Group sys_Group_model = GetModel(GroupID);
            if (GroupIDs != "")
                GroupIDs = GroupIDs + "," + sys_Group_model.GroupID;
            else
                GroupIDs = sys_Group_model.GroupID + "";
            return GroupIDs;
        }

        public string GetHigherLevelString_withSelf(int GroupID, Boolean isDriect)
        {
            List<Maticsoft.Model.sys_Group> list = dal.GetHigherLevel(GroupID, isDriect);
            string GroupIDs = "";
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    GroupIDs = GroupIDs + ((Maticsoft.Model.sys_Group)list[i]).GroupID + ",";
                }
                GroupIDs = GroupIDs.Substring(0, GroupIDs.Length - 1);
            }
            Maticsoft.Model.sys_Group sys_Group_model = GetModel(GroupID);
            if (GroupIDs != "")
                GroupIDs = GroupIDs + "," + sys_Group_model.GroupID;
            else
                GroupIDs = sys_Group_model.GroupID + "";
            return GroupIDs;
        }

        public List<Maticsoft.Model.sys_Group> GetHigherLevel_withSelf(ArrayList lst, Boolean isDriect)
        {
            List<Maticsoft.Model.sys_Group> list_all = new List<Maticsoft.Model.sys_Group>();
            foreach (sys_GroupTable x in lst)
            {
                Maticsoft.Model.sys_Group sys_Group_model = new Maticsoft.Model.sys_Group();
                sys_Group_model.GroupID = x.GroupID;
                sys_Group_model.G_CName = x.G_CName;
                sys_Group_model.G_ParentID = x.G_ParentID;
                sys_Group_model.G_ShowOrder = x.G_ShowOrder;
                sys_Group_model.G_Level = x.G_Level;
                sys_Group_model.G_ChildCount = x.G_ChildCount;
                sys_Group_model.G_Delete = x.G_Delete;
                sys_Group_model.G_Type = x.G_Type;
                sys_Group_model.G_Code = x.G_Code;
                list_all.Add(sys_Group_model);
                List<Maticsoft.Model.sys_Group> list = dal.GetHigherLevel(x.G_ParentID, isDriect);
                for (int i = 0; i < list.Count; i++)
                {
                    if (!list_all.Contains(list[i]))
                    {
                        list_all.Add(list[i]);
                    }
                }
            }
            return list_all;
        }
		#endregion  ExtensionMethod
	}
}

