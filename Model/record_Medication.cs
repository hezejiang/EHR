using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_Medication:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_Medication
	{
		public record_Medication()
		{}
		#region Model
		private int _medicationid=0;
		private int _m_consultationid;
		private DateTime _m_startdate;
		private int _m_status;
		/// <summary>
		/// 用药ID
		/// </summary>
		public int MedicationID
		{
			set{ _medicationid=value;}
			get{return _medicationid;}
		}
		/// <summary>
		/// 会诊流水号，与record_Consultation表相关联
		/// </summary>
		public int M_ConsultationID
		{
			set{ _m_consultationid=value;}
			get{return _m_consultationid;}
		}
		/// <summary>
		/// 用药开始日期
		/// </summary>
		public DateTime M_StartDate
		{
			set{ _m_startdate=value;}
			get{return _m_startdate;}
		}
		/// <summary>
		/// 用药状态，1：正在服用，2：已服用完（病人服用完药之后将该提醒取消并同步就说明服用完毕）
		/// </summary>
		public int M_Status
		{
			set{ _m_status=value;}
			get{return _m_status;}
		}
		#endregion Model

	}
}

