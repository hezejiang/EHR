using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// AR_Report:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AR_Report
	{
		public AR_Report()
		{}
		#region Model
		private int _reportid;
		private string _r_title;
		private string _r_content="";
		private DateTime? _r_datetime;
		private int? _r_responsibilityuserid;
		/// <summary>
		/// 报告ID
		/// </summary>
		public int ReportID
		{
			set{ _reportid=value;}
			get{return _reportid;}
		}
		/// <summary>
		/// 报告标题
		/// </summary>
		public string R_Title
		{
			set{ _r_title=value;}
			get{return _r_title;}
		}
		/// <summary>
		/// 报告内容
		/// </summary>
		public string R_Content
		{
			set{ _r_content=value;}
			get{return _r_content;}
		}
		/// <summary>
		/// 报告时间
		/// </summary>
		public DateTime? R_DateTime
		{
			set{ _r_datetime=value;}
			get{return _r_datetime;}
		}
		/// <summary>
		/// 责任人
		/// </summary>
		public int? R_ResponsibilityUserID
		{
			set{ _r_responsibilityuserid=value;}
			get{return _r_responsibilityuserid;}
		}
		#endregion Model

	}
}

