using System;
using System.Data;
namespace Maticsoft.IDAL
{
	/// <summary>
	/// 接口层在线用户表
	/// </summary>
	public interface Isys_Online
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(string O_SessionID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Maticsoft.Model.sys_Online model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Maticsoft.Model.sys_Online model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int OnlineID);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(string O_SessionID);
		bool DeleteList(string OnlineIDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Maticsoft.Model.sys_Online GetModel(int OnlineID);
		Maticsoft.Model.sys_Online DataRowToModel(DataRow row);
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
