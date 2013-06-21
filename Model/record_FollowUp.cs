/**  版本信息模板在安装目录下，可自行修改。
* record_FollowUp.cs
*
* 功 能： N/A
* 类 名： record_FollowUp
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/20 23:38:32   N/A    初版
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
	/// record_FollowUp:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_FollowUp
	{
		public record_FollowUp()
		{}
		#region Model
		private int _followupid;
		private int _f_patientid=0;
		private int _f_type;
		private DateTime _f_date;
		private int _f_status=0;
		private int _f_doctor;
		/// <summary>
		/// 工作ID
		/// </summary>
		public int FollowUpID
		{
			set{ _followupid=value;}
			get{return _followupid;}
		}
		/// <summary>
		/// 病人ID，与sys_User中的UserID相关联
		/// </summary>
		public int F_PatientID
		{
			set{ _f_patientid=value;}
			get{return _f_patientid;}
		}
		/// <summary>
		/// 随访类型，1：高血压，2：糖尿病患者，3：儿童防疫，4：老年人保健
		/// </summary>
		public int F_Type
		{
			set{ _f_type=value;}
			get{return _f_type;}
		}
		/// <summary>
		/// 下次随访日期
		/// </summary>
		public DateTime F_Date
		{
			set{ _f_date=value;}
			get{return _f_date;}
		}
		/// <summary>
		/// 随访状态 1：未完成，2：已完成，3：已到期
		/// </summary>
		public int F_Status
		{
			set{ _f_status=value;}
			get{return _f_status;}
		}
		/// <summary>
		/// 随访医生
		/// </summary>
		public int F_Doctor
		{
			set{ _f_doctor=value;}
			get{return _f_doctor;}
		}
		#endregion Model

	}
}

