using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 系统应用字段
	/// </summary>
	[Serializable]
	public partial class sys_Field
	{
		public sys_Field()
		{}
		#region Model
		private int _fieldid;
		private string _f_key;
		private string _f_cname;
		private string _f_remark;
		/// <summary>
		/// 应用字段ID号
		/// </summary>
		public int FieldID
		{
			set{ _fieldid=value;}
			get{return _fieldid;}
		}
		/// <summary>
		/// 应用字段关键字
		/// </summary>
		public string F_Key
		{
			set{ _f_key=value;}
			get{return _f_key;}
		}
		/// <summary>
		/// 应用字段中文说明
		/// </summary>
		public string F_CName
		{
			set{ _f_cname=value;}
			get{return _f_cname;}
		}
		/// <summary>
		/// 描述说明
		/// </summary>
		public string F_Remark
		{
			set{ _f_remark=value;}
			get{return _f_remark;}
		}
		#endregion Model

	}
}

