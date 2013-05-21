/**  版本信息模板在安装目录下，可自行修改。
* extend_DiseaseOther.cs
*
* 功 能： N/A
* 类 名： extend_DiseaseOther
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:02   N/A    初版
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
	/// extend_DiseaseOther:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class extend_DiseaseOther
	{
		public extend_DiseaseOther()
		{}
		#region Model
		private int _diseaseotherid;
		private int _do_type;
		private DateTime _do_date;
		private string _do_name;
		private int _do_userid;
		/// <summary>
		/// 
		/// </summary>
		public int DiseaseOtherID
		{
			set{ _diseaseotherid=value;}
			get{return _diseaseotherid;}
		}
		/// <summary>
		/// 类型，1 手上, 2 外伤, 3 输血
		/// </summary>
		public int DO_Type
		{
			set{ _do_type=value;}
			get{return _do_type;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime DO_Date
		{
			set{ _do_date=value;}
			get{return _do_date;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string DO_Name
		{
			set{ _do_name=value;}
			get{return _do_name;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int DO_UserID
		{
			set{ _do_userid=value;}
			get{return _do_userid;}
		}
		#endregion Model

	}
}

