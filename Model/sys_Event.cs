using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 系统日记表
	/// </summary>
	[Serializable]
	public partial class sys_Event
	{
		public sys_Event()
		{}
		#region Model
		private int _eventid;
		private string _e_u_loginname;
		private int? _e_userid;
		private DateTime _e_datetime= DateTime.Now;
		private int? _e_applicationid;
		private string _e_a_appname;
		private string _e_m_name;
		private string _e_m_pagecode;
		private string _e_from;
		private int _e_type=1;
		private string _e_ip;
		private string _e_record;
		/// <summary>
		/// 事件ID号
		/// </summary>
		public int EventID
		{
			set{ _eventid=value;}
			get{return _eventid;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string E_U_LoginName
		{
			set{ _e_u_loginname=value;}
			get{return _e_u_loginname;}
		}
		/// <summary>
		/// 操作时用户ID与sys_Users中UserID
		/// </summary>
		public int? E_UserID
		{
			set{ _e_userid=value;}
			get{return _e_userid;}
		}
		/// <summary>
		/// 事件发生的日期及时间
		/// </summary>
		public DateTime E_DateTime
		{
			set{ _e_datetime=value;}
			get{return _e_datetime;}
		}
		/// <summary>
		/// 所属应用程序ID与sys_Applicatio
		/// </summary>
		public int? E_ApplicationID
		{
			set{ _e_applicationid=value;}
			get{return _e_applicationid;}
		}
		/// <summary>
		/// 所属应用名称
		/// </summary>
		public string E_A_AppName
		{
			set{ _e_a_appname=value;}
			get{return _e_a_appname;}
		}
		/// <summary>
		/// PageCode模块名称与sys_Module相同
		/// </summary>
		public string E_M_Name
		{
			set{ _e_m_name=value;}
			get{return _e_m_name;}
		}
		/// <summary>
		/// 发生事件时模块名称
		/// </summary>
		public string E_M_PageCode
		{
			set{ _e_m_pagecode=value;}
			get{return _e_m_pagecode;}
		}
		/// <summary>
		/// 来源
		/// </summary>
		public string E_From
		{
			set{ _e_from=value;}
			get{return _e_from;}
		}
		/// <summary>
		/// 日记类型,1:操作日记2:安全日志3
		/// </summary>
		public int E_Type
		{
			set{ _e_type=value;}
			get{return _e_type;}
		}
		/// <summary>
		/// 客户端IP地址
		/// </summary>
		public string E_IP
		{
			set{ _e_ip=value;}
			get{return _e_ip;}
		}
		/// <summary>
		/// 详细描述
		/// </summary>
		public string E_Record
		{
			set{ _e_record=value;}
			get{return _e_record;}
		}
		#endregion Model

	}
}

