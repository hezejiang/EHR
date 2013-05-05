using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 用户角色表
	/// </summary>
	[Serializable]
	public partial class sys_UserRoles
	{
		public sys_UserRoles()
		{}
		#region Model
		private int _r_userid;
		private int _r_roleid;
		/// <summary>
		/// 用户ID与sys_User表中UserID相关
		/// </summary>
		public int R_UserID
		{
			set{ _r_userid=value;}
			get{return _r_userid;}
		}
		/// <summary>
		/// 用户所属角色ID与Sys_Roles关联
		/// </summary>
		public int R_RoleID
		{
			set{ _r_roleid=value;}
			get{return _r_roleid;}
		}
		#endregion Model

	}
}

