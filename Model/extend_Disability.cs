/**  版本信息模板在安装目录下，可自行修改。
* extend_Disability.cs
*
* 功 能： N/A
* 类 名： extend_Disability
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:00   N/A    初版
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
	/// extend_Disability:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class extend_Disability
	{
		public extend_Disability()
		{}
		#region Model
		private int _disabilityid;
		private int _d_type;
		private string _d_note="";
		private int _d_userid;
		/// <summary>
		/// 残疾情况ID
		/// </summary>
		public int DisabilityID
		{
			set{ _disabilityid=value;}
			get{return _disabilityid;}
		}
		/// <summary>
		/// 残疾类型：0无，1视力残疾，2听力残疾，3言语残疾，4体残疾，5智力残疾，6精神残疾，7其他+备注
		/// </summary>
		public int D_Type
		{
			set{ _d_type=value;}
			get{return _d_type;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string D_Note
		{
			set{ _d_note=value;}
			get{return _d_note;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int D_UserID
		{
			set{ _d_userid=value;}
			get{return _d_userid;}
		}
		#endregion Model

	}
}

