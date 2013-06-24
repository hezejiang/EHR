﻿/**  版本信息模板在安装目录下，可自行修改。
* education_Document.cs
*
* 功 能： N/A
* 类 名： education_Document
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/23 11:23:34   N/A    初版
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
	/// education_Document:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class education_Document
	{
		public education_Document()
		{}
		#region Model
		private int _documentid;
		private string _d_name;
		private string _d_url;
		private int _d_userid;
		private DateTime _d_datetime;
		private int _d_committee;
		/// <summary>
		/// 健康知识文档ID
		/// </summary>
		public int DocumentID
		{
			set{ _documentid=value;}
			get{return _documentid;}
		}
		/// <summary>
		/// 健康知识文档名称
		/// </summary>
		public string D_Name
		{
			set{ _d_name=value;}
			get{return _d_name;}
		}
		/// <summary>
		/// 健康知识文档地址，最大不超过2038个字符（IE）
		/// </summary>
		public string D_Url
		{
			set{ _d_url=value;}
			get{return _d_url;}
		}
		/// <summary>
		/// 上传者
		/// </summary>
		public int D_UserID
		{
			set{ _d_userid=value;}
			get{return _d_userid;}
		}
		/// <summary>
		/// 上传日期
		/// </summary>
		public DateTime D_DateTime
		{
			set{ _d_datetime=value;}
			get{return _d_datetime;}
		}
		/// <summary>
		/// 居委会ID
		/// </summary>
		public int D_Committee
		{
			set{ _d_committee=value;}
			get{return _d_committee;}
		}
		#endregion Model

	}
}

