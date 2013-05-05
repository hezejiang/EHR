using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 系统信息表
	/// </summary>
	[Serializable]
	public partial class sys_SystemInfo
	{
		public sys_SystemInfo()
		{}
		#region Model
		private int _systemid;
		private string _s_name;
		private string _s_version;
		private byte[] _s_systemconfigdata;
		private string _s_licensed;
		/// <summary>
		/// 自动ID
		/// </summary>
		public int SystemID
		{
			set{ _systemid=value;}
			get{return _systemid;}
		}
		/// <summary>
		/// 系统名称
		/// </summary>
		public string S_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 版本号
		/// </summary>
		public string S_Version
		{
			set{ _s_version=value;}
			get{return _s_version;}
		}
		/// <summary>
		/// 系统配置信息
		/// </summary>
		public byte[] S_SystemConfigData
		{
			set{ _s_systemconfigdata=value;}
			get{return _s_systemconfigdata;}
		}
		/// <summary>
		/// 序列号
		/// </summary>
		public string S_Licensed
		{
			set{ _s_licensed=value;}
			get{return _s_licensed;}
		}
		#endregion Model

	}
}

