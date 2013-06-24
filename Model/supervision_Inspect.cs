/**  版本信息模板在安装目录下，可自行修改。
* supervision_Inspect.cs
*
* 功 能： N/A
* 类 名： supervision_Inspect
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/24 2:40:44   N/A    初版
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
	/// supervision_Inspect:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class supervision_Inspect
	{
		public supervision_Inspect()
		{}
		#region Model
		private int _inspectid;
		private string _i_location;
		private int _i_type;
		private DateTime _i_date;
		private int _i_userid;
		private string _i_content;
		private string _i_mainproblem;
		private string _i_note="";
		private int? _i_infoid;
		/// <summary>
		/// 卫生监管巡查ID
		/// </summary>
		public int InspectID
		{
			set{ _inspectid=value;}
			get{return _inspectid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string I_Location
		{
			set{ _i_location=value;}
			get{return _i_location;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int I_Type
		{
			set{ _i_type=value;}
			get{return _i_type;}
		}
		/// <summary>
		/// 巡查时间
		/// </summary>
		public DateTime I_Date
		{
			set{ _i_date=value;}
			get{return _i_date;}
		}
		/// <summary>
		/// 巡查人
		/// </summary>
		public int I_UserID
		{
			set{ _i_userid=value;}
			get{return _i_userid;}
		}
		/// <summary>
		/// 寻常内容
		/// </summary>
		public string I_Content
		{
			set{ _i_content=value;}
			get{return _i_content;}
		}
		/// <summary>
		/// 发现的主要问题
		/// </summary>
		public string I_MainProblem
		{
			set{ _i_mainproblem=value;}
			get{return _i_mainproblem;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string I_Note
		{
			set{ _i_note=value;}
			get{return _i_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? I_InfoID
		{
			set{ _i_infoid=value;}
			get{return _i_infoid;}
		}
		#endregion Model

	}
}

