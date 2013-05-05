using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 在线用户表
	/// </summary>
	[Serializable]
	public partial class sys_Online
	{
		public sys_Online()
		{}
		#region Model
		private int _onlineid;
		private string _o_sessionid;
		private string _o_username;
		private string _o_ip;
		private DateTime _o_logintime;
		private DateTime _o_lasttime;
		private string _o_lasturl;
		/// <summary>
		/// 自动ID
		/// </summary>
		public int OnlineID
		{
			set{ _onlineid=value;}
			get{return _onlineid;}
		}
		/// <summary>
		/// 用户SessionID
		/// </summary>
		public string O_SessionID
		{
			set{ _o_sessionid=value;}
			get{return _o_sessionid;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string O_UserName
		{
			set{ _o_username=value;}
			get{return _o_username;}
		}
		/// <summary>
		/// 用户IP地址
		/// </summary>
		public string O_Ip
		{
			set{ _o_ip=value;}
			get{return _o_ip;}
		}
		/// <summary>
		/// 登陆时间
		/// </summary>
		public DateTime O_LoginTime
		{
			set{ _o_logintime=value;}
			get{return _o_logintime;}
		}
		/// <summary>
		/// 最后访问时间
		/// </summary>
		public DateTime O_LastTime
		{
			set{ _o_lasttime=value;}
			get{return _o_lasttime;}
		}
		/// <summary>
		/// 最后请求网站
		/// </summary>
		public string O_LastUrl
		{
			set{ _o_lasturl=value;}
			get{return _o_lasturl;}
		}
		#endregion Model

	}
}

