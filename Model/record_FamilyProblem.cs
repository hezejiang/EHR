/**  版本信息模板在安装目录下，可自行修改。
* record_FamilyProblem.cs
*
* 功 能： N/A
* 类 名： record_FamilyProblem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/19 17:06:24   N/A    初版
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
	/// record_FamilyProblem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_FamilyProblem
	{
		public record_FamilyProblem()
		{}
		#region Model
		private int _f_familyid;
		private DateTime _f_recordtime;
		private DateTime _f_starttime;
		private DateTime? _f_endtime;
		private string _f_overviewproblem;
		private string _f_detailproblem;
		private int _f_fillinguserid;
		/// <summary>
		/// 家庭编号，与record_FamilybaseInfo中的F_FamilyCode关联
		/// </summary>
		public int F_FamilyID
		{
			set{ _f_familyid=value;}
			get{return _f_familyid;}
		}
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime F_RecordTime
		{
			set{ _f_recordtime=value;}
			get{return _f_recordtime;}
		}
		/// <summary>
		/// 发生时间
		/// </summary>
		public DateTime F_StartTime
		{
			set{ _f_starttime=value;}
			get{return _f_starttime;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime? F_endTime
		{
			set{ _f_endtime=value;}
			get{return _f_endtime;}
		}
		/// <summary>
		/// 问题概述
		/// </summary>
		public string F_OverviewProblem
		{
			set{ _f_overviewproblem=value;}
			get{return _f_overviewproblem;}
		}
		/// <summary>
		/// 问题详述
		/// </summary>
		public string F_DetailProblem
		{
			set{ _f_detailproblem=value;}
			get{return _f_detailproblem;}
		}
		/// <summary>
		/// 建档医生
		/// </summary>
		public int F_FillingUserID
		{
			set{ _f_fillinguserid=value;}
			get{return _f_fillinguserid;}
		}
		#endregion Model

	}
}

