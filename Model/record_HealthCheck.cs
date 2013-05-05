using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_HealthCheck:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_HealthCheck
	{
		public record_HealthCheck()
		{}
		#region Model
		private int _healthid;
		private decimal? _h_bodytemperature=0M;
		private int? _h_pulserate=0;
		private int? _h_respiratoryrate=0;
		private int? _h_leftdiastolic=0;
		private int? _h_leftsystolic=0;
		private int? _h_rightdiastolic=0;
		private int? _h_rightsystolic=0;
		private int? _h_height=0;
		private int? _h_weight=0;
		private string _h_result="";
		private string _h_suggestion="";
		private DateTime _h_checktime;
		private int _h_medicalinstitutions;
		private int _h_checkuserid;
		/// <summary>
		/// 健康体检ID
		/// </summary>
		public int HealthID
		{
			set{ _healthid=value;}
			get{return _healthid;}
		}
		/// <summary>
		/// 体温
		/// </summary>
		public decimal? H_BodyTemperature
		{
			set{ _h_bodytemperature=value;}
			get{return _h_bodytemperature;}
		}
		/// <summary>
		/// 脉率（次/min）
		/// </summary>
		public int? H_PulseRate
		{
			set{ _h_pulserate=value;}
			get{return _h_pulserate;}
		}
		/// <summary>
		/// 呼吸频率（次/min）
		/// </summary>
		public int? H_RespiratoryRate
		{
			set{ _h_respiratoryrate=value;}
			get{return _h_respiratoryrate;}
		}
		/// <summary>
		/// 左侧舒张压(mmHg)
		/// </summary>
		public int? H_LeftDiastolic
		{
			set{ _h_leftdiastolic=value;}
			get{return _h_leftdiastolic;}
		}
		/// <summary>
		/// 左侧收缩压(mmHg)
		/// </summary>
		public int? H_LeftSystolic
		{
			set{ _h_leftsystolic=value;}
			get{return _h_leftsystolic;}
		}
		/// <summary>
		/// 右侧舒张压(mmHg)
		/// </summary>
		public int? H_RightDiastolic
		{
			set{ _h_rightdiastolic=value;}
			get{return _h_rightdiastolic;}
		}
		/// <summary>
		/// 右侧收缩压(mmHg)
		/// </summary>
		public int? H_RightSystolic
		{
			set{ _h_rightsystolic=value;}
			get{return _h_rightsystolic;}
		}
		/// <summary>
		/// 身高（cm）
		/// </summary>
		public int? H_Height
		{
			set{ _h_height=value;}
			get{return _h_height;}
		}
		/// <summary>
		/// 体重（kg）
		/// </summary>
		public int? H_Weight
		{
			set{ _h_weight=value;}
			get{return _h_weight;}
		}
		/// <summary>
		/// 体检结果
		/// </summary>
		public string H_Result
		{
			set{ _h_result=value;}
			get{return _h_result;}
		}
		/// <summary>
		/// 体检建议
		/// </summary>
		public string H_Suggestion
		{
			set{ _h_suggestion=value;}
			get{return _h_suggestion;}
		}
		/// <summary>
		/// 体检时间
		/// </summary>
		public DateTime H_CheckTime
		{
			set{ _h_checktime=value;}
			get{return _h_checktime;}
		}
		/// <summary>
		/// 体检机构，与sys_Group表中的GroupID关联
		/// </summary>
		public int H_MedicalInstitutions
		{
			set{ _h_medicalinstitutions=value;}
			get{return _h_medicalinstitutions;}
		}
		/// <summary>
		/// 体检医生，与sys_User表中的UserID相关联
		/// </summary>
		public int H_CheckUserID
		{
			set{ _h_checkuserid=value;}
			get{return _h_checkuserid;}
		}
		#endregion Model

	}
}

