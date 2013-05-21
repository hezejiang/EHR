using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 用户表
	/// </summary>
	[Serializable]
	public partial class sys_UserInfo
	{
        public sys_UserInfo()
		{}
		#region Model
        //sys_User表
		private int _userid;
		private string _u_loginname;
		private string _u_password;
		private string _u_cname;
		private string _u_ename;
		private int _u_groupid;
		private string _u_email;
		private int _u_type=1;
		private int _u_status=1;
		private string _u_licence;
		private string _u_mac;
		private string _u_remark;
		private string _u_idcard;
		private int _u_sex;
		private DateTime _u_birthday;
		private string _u_mobileno;
		private string _u_userno;
		private DateTime _u_workstartdate;
		private DateTime _u_workenddate;
		private string _u_companymail;
		private int _u_title;
		private string _u_extension;
		private string _u_hometel;
		private string _u_photourl;
		private DateTime _u_datetime;
		private string _u_lastip;
		private DateTime _u_lastdatetime;
		private string _u_extendfield;
		private string _u_logintype;
		private int _u_hospitalgroupid=0;
        //record_UserBaseInfo表
        private string _u_hometown;
        private string _u_currentaddress;
        private int _u_filingunits;
        private int _u_filinguserid;
        private int _u_responsibilityuserid;
        private int _u_committee;
        private DateTime _u_flingtime;
        private string _u_workingunits = "";
        private string _u_workingcontactname = "";
        private string _u_workingcontacttel = "";
        private int _u_bloodtype = 0;
        private int _u_nationid;
        private int _u_marriagestatus = 0;
        private int _u_permanenttype = 0;
        private int _u_education = 0;
        private string _u_paymenttype = "";
        private string _u_socialno = "";
        private string _u_medicalno;
        private string _u_familycode = "0";
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
		/// 登陆名
		/// </summary>
		public string U_LoginName
		{
			set{ _u_loginname=value;}
			get{return _u_loginname;}
		}
		/// <summary>
		/// 密码md5加密字符
		/// </summary>
		public string U_Password
		{
			set{ _u_password=value;}
			get{return _u_password;}
		}
		/// <summary>
		/// 中文姓名
		/// </summary>
		public string U_CName
		{
			set{ _u_cname=value;}
			get{return _u_cname;}
		}
		/// <summary>
		/// 英文名
		/// </summary>
		public string U_EName
		{
			set{ _u_ename=value;}
			get{return _u_ename;}
		}
		/// <summary>
		/// 部门ID号与sys_Group表中GroupID关联，这里是选择所在居委会
		/// </summary>
		public int U_GroupID
		{
			set{ _u_groupid=value;}
			get{return _u_groupid;}
		}
		/// <summary>
		/// 电子邮件
		/// </summary>
		public string U_Email
		{
			set{ _u_email=value;}
			get{return _u_email;}
		}
		/// <summary>
		/// 用户类型0:超级用户1:普通用户
		/// </summary>
		public int U_Type
		{
			set{ _u_type=value;}
			get{return _u_type;}
		}
		/// <summary>
		/// 当前状态0:正常 1:禁止登陆 2:删除
		/// </summary>
		public int U_Status
		{
			set{ _u_status=value;}
			get{return _u_status;}
		}
		/// <summary>
		/// 用户序列号
		/// </summary>
		public string U_Licence
		{
			set{ _u_licence=value;}
			get{return _u_licence;}
		}
		/// <summary>
		/// 锁定机器硬件地址
		/// </summary>
		public string U_Mac
		{
			set{ _u_mac=value;}
			get{return _u_mac;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string U_Remark
		{
			set{ _u_remark=value;}
			get{return _u_remark;}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string U_IDCard
		{
			set{ _u_idcard=value;}
			get{return _u_idcard;}
		}
		/// <summary>
		/// 性别1:男0:女
		/// </summary>
		public int U_Sex
		{
			set{ _u_sex=value;}
			get{return _u_sex;}
		}
		/// <summary>
		/// 出生日期
		/// </summary>
		public DateTime U_BirthDay
		{
			set{ _u_birthday=value;}
			get{return _u_birthday;}
		}
		/// <summary>
		/// 手机号
		/// </summary>
		public string U_MobileNo
		{
			set{ _u_mobileno=value;}
			get{return _u_mobileno;}
		}
		/// <summary>
		/// 员工编号
		/// </summary>
		public string U_UserNO
		{
			set{ _u_userno=value;}
			get{return _u_userno;}
		}
		/// <summary>
		/// 到职日期
		/// </summary>
		public DateTime U_WorkStartDate
		{
			set{ _u_workstartdate=value;}
			get{return _u_workstartdate;}
		}
		/// <summary>
		/// 离职日期
		/// </summary>
		public DateTime U_WorkEndDate
		{
			set{ _u_workenddate=value;}
			get{return _u_workenddate;}
		}
		/// <summary>
		/// 公司邮件地址
		/// </summary>
		public string U_CompanyMail
		{
			set{ _u_companymail=value;}
			get{return _u_companymail;}
		}
		/// <summary>
		/// 职称与应用字段关联
		/// </summary>
		public int U_Title
		{
			set{ _u_title=value;}
			get{return _u_title;}
		}
		/// <summary>
		/// 分机号
		/// </summary>
		public string U_Extension
		{
			set{ _u_extension=value;}
			get{return _u_extension;}
		}
		/// <summary>
		/// 家中电话
		/// </summary>
		public string U_HomeTel
		{
			set{ _u_hometel=value;}
			get{return _u_hometel;}
		}
		/// <summary>
		/// 用户照片网址
		/// </summary>
		public string U_PhotoUrl
		{
			set{ _u_photourl=value;}
			get{return _u_photourl;}
		}
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime U_DateTime
		{
			set{ _u_datetime=value;}
			get{return _u_datetime;}
		}
		/// <summary>
		/// 最后访问IP
		/// </summary>
		public string U_LastIP
		{
			set{ _u_lastip=value;}
			get{return _u_lastip;}
		}
		/// <summary>
		/// 最后访问时间
		/// </summary>
		public DateTime U_LastDateTime
		{
			set{ _u_lastdatetime=value;}
			get{return _u_lastdatetime;}
		}
		/// <summary>
		/// 扩展字段
		/// </summary>
		public string U_ExtendField
		{
			set{ _u_extendfield=value;}
			get{return _u_extendfield;}
		}
		/// <summary>
		/// 登入类型(为空系统认证,其它值为其它认证)
		/// </summary>
		public string U_LoginType
		{
			set{ _u_logintype=value;}
			get{return _u_logintype;}
		}
		/// <summary>
		/// 医院部门ID号与sys_Group表中GroupID关联，这里是选择所在医院部门，默认为0，即表示该用户是非医院工作人员
		/// </summary>
		public int U_HospitalGroupID
		{
			set{ _u_hospitalgroupid=value;}
			get{return _u_hospitalgroupid;}
		}

        /// <summary>
        /// 户籍地址
        /// </summary>
        public string U_Hometown
        {
            set { _u_hometown = value; }
            get { return _u_hometown; }
        }
        /// <summary>
        /// 现住址
        /// </summary>
        public string U_CurrentAddress
        {
            set { _u_currentaddress = value; }
            get { return _u_currentaddress; }
        }
        /// <summary>
        /// 建档单位（居委会或者是医院部门）
        /// </summary>
        public int U_FilingUnits
        {
            set { _u_filingunits = value; }
            get { return _u_filingunits; }
        }
        /// <summary>
        /// 建档人，与sys_User表中的UerID关联
        /// </summary>
        public int U_FilingUserID
        {
            set { _u_filinguserid = value; }
            get { return _u_filinguserid; }
        }
        /// <summary>
        /// 责任医生，与sys_User表中的UerID关联
        /// </summary>
        public int U_ResponsibilityUserID
        {
            set { _u_responsibilityuserid = value; }
            get { return _u_responsibilityuserid; }
        }
        /// <summary>
        /// 居(村)委会
        /// </summary>
        public int U_Committee
        {
            set { _u_committee = value; }
            get { return _u_committee; }
        }
        /// <summary>
        /// 建档日期
        /// </summary>
        public DateTime U_FlingTime
        {
            set { _u_flingtime = value; }
            get { return _u_flingtime; }
        }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string U_WorkingUnits
        {
            set { _u_workingunits = value; }
            get { return _u_workingunits; }
        }
        /// <summary>
        /// 职位联系人姓名
        /// </summary>
        public string U_WorkingContactName
        {
            set { _u_workingcontactname = value; }
            get { return _u_workingcontactname; }
        }
        /// <summary>
        /// 职位联系人电话
        /// </summary>
        public string U_WorkingContactTel
        {
            set { _u_workingcontacttel = value; }
            get { return _u_workingcontacttel; }
        }
        /// <summary>
        /// 血型 1:A型，2:B型，3:AB型，4:O型，0:不详
        /// </summary>
        public int U_BloodType
        {
            set { _u_bloodtype = value; }
            get { return _u_bloodtype; }
        }
        /// <summary>
        /// 民族，对应民族表NationID
        /// </summary>
        public int U_NationID
        {
            set { _u_nationid = value; }
            get { return _u_nationid; }
        }
        /// <summary>
        /// 婚姻状态 1:未婚，2:已婚，3:丧偶，4:离婚
        /// </summary>
        public int U_MarriageStatus
        {
            set { _u_marriagestatus = value; }
            get { return _u_marriagestatus; }
        }
        /// <summary>
        /// 常住类型 1:户籍，2:非户籍
        /// </summary>
        public int U_PermanentType
        {
            set { _u_permanenttype = value; }
            get { return _u_permanenttype; }
        }
        /// <summary>
        /// 文化程度 1:文盲及半文盲，2:小学，3:中学，4:高中/技校/中专，5:大学专科，6:大学本科，7:研究生及以上，8:不详
        /// </summary>
        public int U_Education
        {
            set { _u_education = value; }
            get { return _u_education; }
        }
        /// <summary>
        /// 付费类型(可多选，以逗号隔开) 1:城镇职工基本医疗保险，2:城镇居民基本医疗保险，3:贫困扶助，4:新型农村合作医疗，5:商业医疗保险，6:全公费，7:全自费，8:其他
        /// </summary>
        public string U_PaymentType
        {
            set { _u_paymenttype = value; }
            get { return _u_paymenttype; }
        }
        /// <summary>
        /// 社保号
        /// </summary>
        public string U_SocialNO
        {
            set { _u_socialno = value; }
            get { return _u_socialno; }
        }
        /// <summary>
        /// 医保号
        /// </summary>
        public string U_MedicalNO
        {
            set { _u_medicalno = value; }
            get { return _u_medicalno; }
        }
        /// <summary>
        /// 家庭编号，与家庭健康档案F_FamilyCode相对应
        /// </summary>
        public string U_FamilyCode
        {
            set { _u_familycode = value; }
            get { return _u_familycode; }
        }
        /// <summary>
        /// 与户主关系 1:父亲 2:母亲 3:儿子 4:儿媳 5:女儿 6:女婿
        /// </summary>
        public int U_RelationShip
        {
            set { _u_relationship = value; }
            get { return _u_relationship; }
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

