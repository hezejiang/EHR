using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 模块扩展权限
	/// </summary>
	[Serializable]
	public partial class sys_ModuleExtPermission
	{
		public sys_ModuleExtPermission()
		{}
		#region Model
		private int _extpermissionid;
		private int _moduleid;
		private string _permissionname;
		private int _permissionvalue;
		/// <summary>
		/// 扩展权限ID
		/// </summary>
		public int ExtPermissionID
		{
			set{ _extpermissionid=value;}
			get{return _extpermissionid;}
		}
		/// <summary>
		/// 模块ID
		/// </summary>
		public int ModuleID
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		/// <summary>
		/// 权限名称
		/// </summary>
		public string PermissionName
		{
			set{ _permissionname=value;}
			get{return _permissionname;}
		}
		/// <summary>
		/// 权限值
		/// </summary>
		public int PermissionValue
		{
			set{ _permissionvalue=value;}
			get{return _permissionvalue;}
		}
		#endregion Model

	}
}

