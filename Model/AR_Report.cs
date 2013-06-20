/**  版本信息模板在安装目录下，可自行修改。
* AR_Report.cs
*
* 功 能： N/A
* 类 名： AR_Report
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/8 16:24:23   N/A    初版
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
		private DateTime _r_datetime;
		private int _r_responsibilityuserid;
		private int _r_type;
		private int _r_status;
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
		public DateTime R_DateTime
		{
			set{ _r_datetime=value;}
			get{return _r_datetime;}
		}
		/// <summary>
		/// 责任人
		/// </summary>
		public int R_ResponsibilityUserID
		{
			set{ _r_responsibilityuserid=value;}
			get{return _r_responsibilityuserid;}
		}
		/// <summary>
		/// 类型，1:迁出嵌入档案管理；2:传染病及突发事件
		/// </summary>
		public int R_Type
		{
			set{ _r_type=value;}
			get{return _r_type;}
		}
		/// <summary>
		/// 状态，1:未处理；2:已处理
		/// </summary>
		public int R_Status
		{
			set{ _r_status=value;}
			get{return _r_status;}
		}
		#endregion Model

	}
}

