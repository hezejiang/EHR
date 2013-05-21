/**  版本信息模板在安装目录下，可自行修改。
* extend_Environment.cs
*
* 功 能： N/A
* 类 名： extend_Environment
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
	/// extend_Environment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class extend_Environment
	{
		public extend_Environment()
		{}
		#region Model
		private int _environmentid;
		private int _e_kind;
		private int _e_type;
		private int _e_userid;
		/// <summary>
		/// 
		/// </summary>
		public int EnvironmentID
		{
			set{ _environmentid=value;}
			get{return _environmentid;}
		}
		/// <summary>
		/// 种类：1 厨房排风设施，2 燃料类型，3 饮水，4 厕所，5 禽畜栏
		/// </summary>
		public int E_Kind
		{
			set{ _e_kind=value;}
			get{return _e_kind;}
		}
		/// <summary>
		/// 类型，和E_Kind一起才能确定：1-1 无，1-2 油烟机,1-3 换气扇，1-4 烟囱；2-1 液化气，2-2 煤气，2-3 天然气，2-4 沼气，2-5 柴火，2-6 其他；3-1 自来水，3-2 经净化过滤的水，3-3 井水，3-4 河湖水，3-5 糖水，3-6 其他；4-1 卫生厕所，4-2 一格或两格粪池式，4-3 马桶，4-4 露天粪坑，4-5 简易棚厕； 5-1 单设，5-2 室内，5-3 室外；
		/// </summary>
		public int E_Type
		{
			set{ _e_type=value;}
			get{return _e_type;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int E_UserID
		{
			set{ _e_userid=value;}
			get{return _e_userid;}
		}
		#endregion Model

	}
}

