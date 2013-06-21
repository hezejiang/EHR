using System;
using System.Data;
using System.Collections.Generic;

namespace Maticsoft.IDAL
{
	/// <summary>
	/// 接口层部门
	/// </summary>
	public interface Isys_Group
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int GroupID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Maticsoft.Model.sys_Group model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Maticsoft.Model.sys_Group model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int GroupID);
		bool DeleteList(string GroupIDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Maticsoft.Model.sys_Group GetModel(int GroupID);
		Maticsoft.Model.sys_Group DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx
        List<Maticsoft.Model.sys_Group> GetLowerLevel(int GroupID, Boolean isDriect);
        List<Maticsoft.Model.sys_Group> GetHigherLevel(int G_ParentID, Boolean isDriect);
		#endregion  MethodEx
	} 
}
