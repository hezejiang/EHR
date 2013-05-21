using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_UserBaseInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_UserBaseInfo
	{
		public record_UserBaseInfo()
		{}
		#region Model
		private int _userid;
		private string _u_hometown;
		private string _u_currentaddress;
		private int _u_filingunits;
		private int _u_filinguserid;
		private int _u_responsibilityuserid;
		private int _u_committee;
		private DateTime _u_flingtime;
		private string _u_workingunits="";
		private string _u_workingcontactname="";
		private string _u_workingcontacttel="";
		private int _u_bloodtype=0;
		private int _u_nationid;
		private int _u_marriagestatus=0;
		private int _u_permanenttype=0;
		private int _u_education=0;
		private string _u_paymenttype="";
		private string _u_socialno="";
		private string _u_medicalno;
		private string _u_familycode= "0";
		private int _u_relationship;
        private int _u_auditstatus;
		/// <summary>
		/// 用户ID号
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 户籍地址
		/// </summary>
		public string U_Hometown
		{
			set{ _u_hometown=value;}
			get{return _u_hometown;}
		}
		/// <summary>
		/// 现住址
		/// </summary>
		public string U_CurrentAddress
		{
			set{ _u_currentaddress=value;}
			get{return _u_currentaddress;}
		}
		/// <summary>
		/// 建档单位（居委会或者是医院部门）
		/// </summary>
		public int U_FilingUnits
		{
			set{ _u_filingunits=value;}
			get{return _u_filingunits;}
		}
		/// <summary>
		/// 建档人，与sys_User表中的UerID关联
		/// </summary>
		public int U_FilingUserID
		{
			set{ _u_filinguserid=value;}
			get{return _u_filinguserid;}
		}
		/// <summary>
		/// 责任医生，与sys_User表中的UerID关联
		/// </summary>
		public int U_ResponsibilityUserID
		{
			set{ _u_responsibilityuserid=value;}
			get{return _u_responsibilityuserid;}
		}
		/// <summary>
		/// 居(村)委会
		/// </summary>
		public int U_Committee
		{
			set{ _u_committee=value;}
			get{return _u_committee;}
		}
		/// <summary>
		/// 建档日期
		/// </summary>
		public DateTime U_FlingTime
		{
			set{ _u_flingtime=value;}
			get{return _u_flingtime;}
		}
		/// <summary>
		/// 工作单位
		/// </summary>
		public string U_WorkingUnits
		{
			set{ _u_workingunits=value;}
			get{return _u_workingunits;}
		}
		/// <summary>
		/// 职位联系人姓名
		/// </summary>
		public string U_WorkingContactName
		{
			set{ _u_workingcontactname=value;}
			get{return _u_workingcontactname;}
		}
		/// <summary>
		/// 职位联系人电话
		/// </summary>
		public string U_WorkingContactTel
		{
			set{ _u_workingcontacttel=value;}
			get{return _u_workingcontacttel;}
		}
		/// <summary>
		/// 血型 1:A型，2:B型，3:AB型，4:O型，0:不详
		/// </summary>
		public int U_BloodType
		{
			set{ _u_bloodtype=value;}
			get{return _u_bloodtype;}
		}
		/// <summary>
		/// 民族，对应民族表NationID
		/// </summary>
		public int U_NationID
		{
			set{ _u_nationid=value;}
			get{return _u_nationid;}
		}
		/// <summary>
		/// 婚姻状态 1:未婚，2:已婚，3:丧偶，4:离婚
		/// </summary>
		public int U_MarriageStatus
		{
			set{ _u_marriagestatus=value;}
			get{return _u_marriagestatus;}
		}
		/// <summary>
		/// 常住类型 1:户籍，2:非户籍
		/// </summary>
		public int U_PermanentType
		{
			set{ _u_permanenttype=value;}
			get{return _u_permanenttype;}
		}
		/// <summary>
		/// 文化程度 1:文盲及半文盲，2:小学，3:中学，4:高中/技校/中专，5:大学专科，6:大学本科，7:研究生及以上，8:不详
		/// </summary>
		public int U_Education
		{
			set{ _u_education=value;}
			get{return _u_education;}
		}
		/// <summary>
		/// 付费类型(可多选，以逗号隔开) 1:城镇职工基本医疗保险，2:城镇居民基本医疗保险，3:贫困扶助，4:新型农村合作医疗，5:商业医疗保险，6:全公费，7:全自费，8:其他
		/// </summary>
		public string U_PaymentType
		{
			set{ _u_paymenttype=value;}
			get{return _u_paymenttype;}
		}
		/// <summary>
		/// 社保号
		/// </summary>
		public string U_SocialNO
		{
			set{ _u_socialno=value;}
			get{return _u_socialno;}
		}
		/// <summary>
		/// 医保号
		/// </summary>
		public string U_MedicalNO
		{
			set{ _u_medicalno=value;}
			get{return _u_medicalno;}
		}
		/// <summary>
		/// 家庭编号，与家庭健康档案F_FamilyCode相对应
		/// </summary>
		public string U_FamilyCode
		{
			set{ _u_familycode=value;}
			get{return _u_familycode;}
		}
		/// <summary>
		/// 与户主关系 1:父亲 2:母亲 3:儿子 4:儿媳 5:女儿 6:女婿
		/// </summary>
		public int U_RelationShip
		{
			set{ _u_relationship=value;}
			get{return _u_relationship;}
		}
		/// <summary>
		/// 档案状态，1：正常，2：审核中（迁出迁入需要审核）
		/// </summary>
        public int U_AuditStatus
		{
            set { _u_auditstatus = value; }
            get { return _u_auditstatus; }
		}
		#endregion Model

	}
}

