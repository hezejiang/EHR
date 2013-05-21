/**  版本信息模板在安装目录下，可自行修改。
* extend_GeneticDisease.cs
*
* 功 能： N/A
* 类 名： extend_GeneticDisease
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:03   N/A    初版
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
	/// extend_GeneticDisease:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class extend_GeneticDisease
	{
		public extend_GeneticDisease()
		{}
		#region Model
		private int _geneticdiseaseid;
		private string _gd_name;
		private int _gd_userid;
		/// <summary>
		/// 遗传病ID
		/// </summary>
		public int GeneticDiseaseID
		{
			set{ _geneticdiseaseid=value;}
			get{return _geneticdiseaseid;}
		}
		/// <summary>
		/// 遗传病名称
		/// </summary>
		public string GD_Name
		{
			set{ _gd_name=value;}
			get{return _gd_name;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int GD_UserID
		{
			set{ _gd_userid=value;}
			get{return _gd_userid;}
		}
		#endregion Model

	}
}

