using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_Consultation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_Consultation
	{
		public record_Consultation()
		{}
		#region Model
		private int _consultationid;
		private int _c_userid;
		private string _c_cause="";
		private string _c_comments="";
		private string _c_institutiondoctor="";
		private DateTime _c_time;
		/// <summary>
		/// 会诊流水号
		/// </summary>
		public int ConsultationID
		{
			set{ _consultationid=value;}
			get{return _consultationid;}
		}
		/// <summary>
		/// 用户ID，与sys_User表的UserID关联
		/// </summary>
		public int C_UserID
		{
			set{ _c_userid=value;}
			get{return _c_userid;}
		}
		/// <summary>
		/// 会诊原因
		/// </summary>
		public string C_Cause
		{
			set{ _c_cause=value;}
			get{return _c_cause;}
		}
		/// <summary>
		/// 会诊意见
		/// </summary>
		public string C_Comments
		{
			set{ _c_comments=value;}
			get{return _c_comments;}
		}
		/// <summary>
		/// 会诊医生及其所在机构名称
		/// </summary>
		public string C_InstitutionDoctor
		{
			set{ _c_institutiondoctor=value;}
			get{return _c_institutiondoctor;}
		}
		/// <summary>
		/// 会诊日期
		/// </summary>
		public DateTime C_Time
		{
			set{ _c_time=value;}
			get{return _c_time;}
		}
		#endregion Model

	}
}

