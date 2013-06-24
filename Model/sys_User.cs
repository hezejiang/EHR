/**  版本信息模板在安装目录下，可自行修改。
* sys_User.cs
*
* 功 能： N/A
* 类 名： sys_User
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/22 16:58:57   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 用户表
	/// </summary>
	[Serializable]
	public partial class sys_User
	{
		public sys_User()
		{}
		#region Model
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
		private string _u_accesstoken="";
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
		/// 部门ID号与sys_Group表中GroupID关联，管理员管理的部门
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
		/// 
		/// </summary>
		public string U_AccessToken
		{
			set{ _u_accesstoken=value;}
			get{return _u_accesstoken;}
		}
		#endregion Model

	}
}

