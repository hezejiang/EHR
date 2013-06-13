using System;
using System.Data;
namespace Maticsoft.IDAL
{
	/// <summary>
	/// 接口层用户表
	/// </summary>
    public interface Iextend_UserDisease
	{
		#region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Maticsoft.Model.extend_UserDisease GetModel(int UserID);
        Maticsoft.Model.extend_UserDisease DataRowToModel(DataRow row);
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
