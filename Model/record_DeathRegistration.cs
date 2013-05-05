using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_DeathRegistration:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_DeathRegistration
	{
		public record_DeathRegistration()
		{}
		#region Model
		private int _deathid;
		private DateTime _d_datetime;
		private string _d_location;
		private int? _d_icd10id=0;
		private string _d_note="";
		private int _d_userid=0;
		private DateTime _d_regdate;
		/// <summary>
		/// 
		/// </summary>
		public int DeathID
		{
			set{ _deathid=value;}
			get{return _deathid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime D_DateTime
		{
			set{ _d_datetime=value;}
			get{return _d_datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string D_Location
		{
			set{ _d_location=value;}
			get{return _d_location;}
		}
		/// <summary>
		/// 疾病icd10编码
		/// </summary>
		public int? D_Icd10ID
		{
			set{ _d_icd10id=value;}
			get{return _d_icd10id;}
		}
		/// <summary>
		/// 死亡说明
		/// </summary>
		public string D_Note
		{
			set{ _d_note=value;}
			get{return _d_note;}
		}
		/// <summary>
		/// 登记人,与sys_User表的UserID关联
		/// </summary>
		public int D_UserID
		{
			set{ _d_userid=value;}
			get{return _d_userid;}
		}
		/// <summary>
		/// 登记日期
		/// </summary>
		public DateTime D_RegDate
		{
			set{ _d_regdate=value;}
			get{return _d_regdate;}
		}
		#endregion Model

	}
}

