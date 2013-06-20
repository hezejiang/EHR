using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 应用表
	/// </summary>
	[Serializable]
	public partial class sys_Applications
	{
		public sys_Applications()
		{}
		#region Model
		private int _applicationid;
		private string _a_appname;
		private string _a_appdescription;
		private string _a_appurl;
		private int _a_order;
		/// <summary>
		/// 自动ID 1:为系统管理应用
		/// </summary>
		public int ApplicationID
		{
			set{ _applicationid=value;}
			get{return _applicationid;}
		}
		/// <summary>
		/// 应用名称
		/// </summary>
		public string A_AppName
		{
			set{ _a_appname=value;}
			get{return _a_appname;}
		}
		/// <summary>
		/// 应用介绍
		/// </summary>
		public string A_AppDescription
		{
			set{ _a_appdescription=value;}
			get{return _a_appdescription;}
		}
		/// <summary>
		/// 应用Url地址
		/// </summary>
		public string A_AppUrl
		{
			set{ _a_appurl=value;}
			get{return _a_appurl;}
		}
		/// <summary>
		/// 应用排序
		/// </summary>
		public int A_Order
		{
			set{ _a_order=value;}
			get{return _a_order;}
		}
		#endregion Model

	}
}

