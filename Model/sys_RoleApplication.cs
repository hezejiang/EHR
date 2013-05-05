using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 角色应用表
	/// </summary>
	[Serializable]
	public partial class sys_RoleApplication
	{
		public sys_RoleApplication()
		{}
		#region Model
		private int _a_roleid;
		private int _a_applicationid;
		/// <summary>
		/// 角色ID与sys_Roles中RoleID相关
		/// </summary>
		public int A_RoleID
		{
			set{ _a_roleid=value;}
			get{return _a_roleid;}
		}
		/// <summary>
		/// 应用ID与sys_Applications中Appl
		/// </summary>
		public int A_ApplicationID
		{
			set{ _a_applicationid=value;}
			get{return _a_applicationid;}
		}
		#endregion Model

	}
}

