/**  版本信息模板在安装目录下，可自行修改。
* record_DeathRegistration.cs
*
* 功 能： N/A
* 类 名： record_DeathRegistration
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/22 2:26:58   N/A    初版
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
		private string _d_reason="";
		private int _d_userid=0;
		private DateTime _d_regdate;
		private int _d_reguserid;
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
		/// 死亡原因
		/// </summary>
		public string D_Reason
		{
			set{ _d_reason=value;}
			get{return _d_reason;}
		}
		/// <summary>
		/// 死者Userid
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
		/// <summary>
		/// 
		/// </summary>
		public int D_RegUserID
		{
			set{ _d_reguserid=value;}
			get{return _d_reguserid;}
		}
		#endregion Model

	}
}

