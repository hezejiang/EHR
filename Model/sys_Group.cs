using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 部门
	/// </summary>
	[Serializable]
	public partial class sys_Group
	{
		public sys_Group()
		{}
		#region Model
		private int _groupid;
		private string _g_cname;
		private int _g_parentid=0;
		private int _g_showorder=0;
		private int _g_level;
		private int _g_childcount;
		private int _g_delete;
		private int _g_type=0;
		private string _g_code="";
		/// <summary>
		/// 分类ID号
		/// </summary>
		public int GroupID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 分类中文说明
		/// </summary>
		public string G_CName
		{
			set{ _g_cname=value;}
			get{return _g_cname;}
		}
		/// <summary>
		/// 上级分类ID0:为最高级
		/// </summary>
		public int G_ParentID
		{
			set{ _g_parentid=value;}
			get{return _g_parentid;}
		}
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int G_ShowOrder
		{
			set{ _g_showorder=value;}
			get{return _g_showorder;}
		}
		/// <summary>
		/// 当前分类所在层数
		/// </summary>
		public int G_Level
		{
			set{ _g_level=value;}
			get{return _g_level;}
		}
		/// <summary>
		/// 当分类子分类数
		/// </summary>
		public int G_ChildCount
		{
			set{ _g_childcount=value;}
			get{return _g_childcount;}
		}
		/// <summary>
		/// 是否删除1:是0:否
		/// </summary>
		public int G_Delete
		{
			set{ _g_delete=value;}
			get{return _g_delete;}
		}
		/// <summary>
		/// 部门类型，0表示非医院部门，1表示医院部门
		/// </summary>
		public int G_Type
		{
			set{ _g_type=value;}
			get{return _g_type;}
		}
		/// <summary>
		/// 行政代码
		/// </summary>
		public string G_Code
		{
			set{ _g_code=value;}
			get{return _g_code;}
		}
		#endregion Model

	}
}

