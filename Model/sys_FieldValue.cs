using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 应用字段值
	/// </summary>
	[Serializable]
	public partial class sys_FieldValue
	{
		public sys_FieldValue()
		{}
		#region Model
		private int _valueid;
		private string _v_f_key;
		private string _v_text;
		private string _v_code;
		private int _v_showorder=0;
		/// <summary>
		/// 索引ID号
		/// </summary>
		public int ValueID
		{
			set{ _valueid=value;}
			get{return _valueid;}
		}
		/// <summary>
		/// 与sys_Field表中F_Key字段关联
		/// </summary>
		public string V_F_Key
		{
			set{ _v_f_key=value;}
			get{return _v_f_key;}
		}
		/// <summary>
		/// 中文说明
		/// </summary>
		public string V_Text
		{
			set{ _v_text=value;}
			get{return _v_text;}
		}
		/// <summary>
		/// 编码
		/// </summary>
		public string V_Code
		{
			set{ _v_code=value;}
			get{return _v_code;}
		}
		/// <summary>
		/// 同级显示顺序
		/// </summary>
		public int V_ShowOrder
		{
			set{ _v_showorder=value;}
			get{return _v_showorder;}
		}
		#endregion Model

	}
}

