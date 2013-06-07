/**  版本信息模板在安装目录下，可自行修改。
* record_Consultation.cs
*
* 功 能： N/A
* 类 名： record_Consultation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/5/28 18:55:22   N/A    初版
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
		private DateTime _c_time;
		private int _c_dortor;
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
		/// 会诊日期
		/// </summary>
		public DateTime C_Time
		{
			set{ _c_time=value;}
			get{return _c_time;}
		}
		/// <summary>
		/// 会诊医生
		/// </summary>
		public int C_Dortor
		{
			set{ _c_dortor=value;}
			get{return _c_dortor;}
		}
		#endregion Model

	}
}

