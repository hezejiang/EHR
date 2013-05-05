using System;
using System.Data;
namespace Maticsoft.IDAL
{
	/// <summary>
	/// 接口层角色应用权限表
	/// </summary>
	public interface Isys_RolePermission
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int P_RoleID,int P_ApplicationID,string P_PageCode);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Maticsoft.Model.sys_RolePermission model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Maticsoft.Model.sys_RolePermission model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int PermissionID);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int P_RoleID,int P_ApplicationID,string P_PageCode);
		bool DeleteList(string PermissionIDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Maticsoft.Model.sys_RolePermission GetModel(int PermissionID);
		Maticsoft.Model.sys_RolePermission DataRowToModel(DataRow row);
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
