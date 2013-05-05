using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_MedicationTime:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_MedicationTime
	{
		public record_MedicationTime()
		{}
		#region Model
		private int _medicationtimeid;
		private string _m_time;
		private int _medicationid;
		/// <summary>
		/// 用药时间ID
		/// </summary>
		public int MedicationTimeID
		{
			set{ _medicationtimeid=value;}
			get{return _medicationtimeid;}
		}
		/// <summary>
		/// 服药时间点（24小时制，如：15:30:00）
		/// </summary>
		public string M_Time
		{
			set{ _m_time=value;}
			get{return _m_time;}
		}
		/// <summary>
		/// 与record_Medication表MedicationID相关联
		/// </summary>
		public int MedicationID
		{
			set{ _medicationid=value;}
			get{return _medicationid;}
		}
		#endregion Model

	}
}

