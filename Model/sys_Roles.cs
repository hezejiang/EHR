using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class sys_Roles
	{
		public sys_Roles()
		{}
		#region Model
		private int _roleid;
		private int _r_userid;
		private string _r_rolename;
		private string _r_description;
		/// <summary>
		/// 角色ID自动ID
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 角角所属用户ID
		/// </summary>
		public int R_UserID
		{
			set{ _r_userid=value;}
			get{return _r_userid;}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string R_RoleName
		{
			set{ _r_rolename=value;}
			get{return _r_rolename;}
		}
		/// <summary>
		/// 角色介绍
		/// </summary>
		public string R_Description
		{
			set{ _r_description=value;}
			get{return _r_description;}
		}
		#endregion Model

	}
}

