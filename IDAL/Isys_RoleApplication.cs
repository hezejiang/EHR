using System;
using System.Data;
namespace Maticsoft.IDAL
{
	/// <summary>
	/// 接口层角色应用表
	/// </summary>
	public interface Isys_RoleApplication
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int A_RoleID,int A_ApplicationID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(Maticsoft.Model.sys_RoleApplication model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Maticsoft.Model.sys_RoleApplication model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int A_RoleID,int A_ApplicationID);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Maticsoft.Model.sys_RoleApplication GetModel(int A_RoleID,int A_ApplicationID);
		Maticsoft.Model.sys_RoleApplication DataRowToModel(DataRow row);
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

		#endregion  MethodEx
	} 
}
