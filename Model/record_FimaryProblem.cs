using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// record_FimaryProblem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class record_FimaryProblem
	{
		public record_FimaryProblem()
		{}
		#region Model
		private string _f_fimarycode;
		private DateTime _f_recordtime;
		private DateTime _f_starttime;
		private DateTime? _f_endtime;
		private string _f_overviewproblem;
		private string _f_detailproblem;
		private int _f_fillinguserid;
		/// <summary>
		/// 家庭编号，与record_FamilybaseInfo中的F_FimaryCode关联
		/// </summary>
		public string F_FimaryCode
		{
			set{ _f_fimarycode=value;}
			get{return _f_fimarycode;}
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

