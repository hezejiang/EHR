using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 功能模块
	/// </summary>
	[Serializable]
	public partial class sys_Module
	{
		public sys_Module()
		{}
		#region Model
		private int _moduleid;
		private int _m_applicationid;
		private int _m_parentid;
		private string _m_pagecode;
		private string _m_cname;
		private string _m_directory;
		private string _m_orderlevel;
		private int? _m_issystem;
		private int? _m_close;
		private string _m_icon;
		private string _m_info;
		/// <summary>
		/// 功能模块ID号
		/// </summary>
		public int ModuleID
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		/// <summary>
		/// 所属应用程序ID
		/// </summary>
		public int M_ApplicationID
		{
			set{ _m_applicationid=value;}
			get{return _m_applicationid;}
		}
		/// <summary>
		/// 所属父级模块ID与ModuleID关联,0为顶级
		/// </summary>
		public int M_ParentID
		{
			set{ _m_parentid=value;}
			get{return _m_parentid;}
		}
		/// <summary>
		/// 模块编码Parent为0,则为S00(xx),否则为S00M00(xx)
		/// </summary>
		public string M_PageCode
		{
			set{ _m_pagecode=value;}
			get{return _m_pagecode;}
		}
		/// <summary>
		/// 模块/栏目名称当ParentID为0为模块名称
		/// </summary>
		public string M_CName
		{
			set{ _m_cname=value;}
			get{return _m_cname;}
		}
		/// <summary>
		/// 模块/栏目???录名
		/// </summary>
		public string M_Directory
		{
			set{ _m_directory=value;}
			get{return _m_directory;}
		}
		/// <summary>
		/// 当前所在排序级别支持双层99级菜单
		/// </summary>
		public string M_OrderLevel
		{
			set{ _m_orderlevel=value;}
			get{return _m_orderlevel;}
		}
		/// <summary>
		/// 是否为系统模块1:是0:否如为系统则无法修改
		/// </summary>
		public int? M_IsSystem
		{
			set{ _m_issystem=value;}
			get{return _m_issystem;}
		}
		/// <summary>
		/// 是否关闭1:是0:否
		/// </summary>
		public int? M_Close
		{
			set{ _m_close=value;}
			get{return _m_close;}
		}
		/// <summary>
		/// 模块Icon
		/// </summary>
		public string M_Icon
		{
			set{ _m_icon=value;}
			get{return _m_icon;}
		}
		/// <summary>
		/// 模块说明
		/// </summary>
		public string M_Info
		{
			set{ _m_info=value;}
			get{return _m_info;}
		}
		#endregion Model

	}
}

