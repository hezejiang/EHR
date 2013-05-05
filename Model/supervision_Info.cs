﻿using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// supervision_Info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class supervision_Info
	{
		public supervision_Info()
		{}
		#region Model
		private int _infoid;
		private DateTime _i_finddate;
		private int _i_type;
		private string _i_content="";
		private DateTime _i_reportdate;
		private int _i_reportuserid;
		/// <summary>
		/// 卫生监督信息ID
		/// </summary>
		public int InfoID
		{
			set{ _infoid=value;}
			get{return _infoid;}
		}
		/// <summary>
		/// 发现时间
		/// </summary>
		public DateTime I_FindDate
		{
			set{ _i_finddate=value;}
			get{return _i_finddate;}
		}
		/// <summary>
		/// 信息类别，1：食品安全，2：饮用水卫生，3：职业病安全，4：学校卫生，5：非法行医（采供血）
		/// </summary>
		public int I_Type
		{
			set{ _i_type=value;}
			get{return _i_type;}
		}
		/// <summary>
		/// 信息内容
		/// </summary>
		public string I_Content
		{
			set{ _i_content=value;}
			get{return _i_content;}
		}
		/// <summary>
		/// 报告时间
		/// </summary>
		public DateTime I_ReportDate
		{
			set{ _i_reportdate=value;}
			get{return _i_reportdate;}
		}
		/// <summary>
		/// 报告人
		/// </summary>
		public int I_ReportUserID
		{
			set{ _i_reportuserid=value;}
			get{return _i_reportuserid;}
		}
		#endregion Model

	}
}

