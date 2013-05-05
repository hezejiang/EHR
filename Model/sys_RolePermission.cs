using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 角色应用权限表
	/// </summary>
	[Serializable]
	public partial class sys_RolePermission
	{
		public sys_RolePermission()
		{}
		#region Model
		private int _permissionid;
		private int _p_roleid;
		private int _p_applicationid;
		private string _p_pagecode;
		private int? _p_value;
		/// <summary>
		/// 角色应用权限自动ID
		/// </summary>
		public int PermissionID
		{
			set{ _permissionid=value;}
			get{return _permissionid;}
		}
		/// <summary>
		/// 角色ID与sys_Roles表中RoleID相
		/// </summary>
		public int P_RoleID
		{
			set{ _p_roleid=value;}
			get{return _p_roleid;}
		}
		/// <summary>
		/// 角色所属应用ID与sys_Applicatio
		/// </summary>
		public int P_ApplicationID
		{
			set{ _p_applicationid=value;}
			get{return _p_applicationid;}
		}
		/// <summary>
		/// 角色应用中页面权限代码
		/// </summary>
		public string P_PageCode
		{
			set{ _p_pagecode=value;}
			get{return _p_pagecode;}
		}
		/// <summary>
		/// 权限值
		/// </summary>
		public int? P_Value
		{
			set{ _p_value=value;}
			get{return _p_value;}
		}
		#endregion Model

	}
}

