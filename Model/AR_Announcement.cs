/**  版本信息模板在安装目录下，可自行修改。
* AR_Announcement.cs
*
* 功 能： N/A
* 类 名： AR_Announcement
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/6/20 22:01:01   N/A    初版
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
	/// AR_Announcement:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AR_Announcement
	{
		public AR_Announcement()
		{}
		#region Model
		private int _announcementid;
		private string _a_title="";
		private string _a_content="";
		private DateTime _a_datetime;
		private int _a_responsibilityuserid;
		private int _a_type;
		private int _a_groupid;
		/// <summary>
		/// 公告ID
		/// </summary>
		public int AnnouncementID
		{
			set{ _announcementid=value;}
			get{return _announcementid;}
		}
		/// <summary>
		/// 公告标题
		/// </summary>
		public string A_Title
		{
			set{ _a_title=value;}
			get{return _a_title;}
		}
		/// <summary>
		/// 公告内容
		/// </summary>
		public string A_Content
		{
			set{ _a_content=value;}
			get{return _a_content;}
		}
		/// <summary>
		/// 公告时间
		/// </summary>
		public DateTime A_DateTime
		{
			set{ _a_datetime=value;}
			get{return _a_datetime;}
		}
		/// <summary>
		/// 责任人
		/// </summary>
		public int A_ResponsibilityUserID
		{
			set{ _a_responsibilityuserid=value;}
			get{return _a_responsibilityuserid;}
		}
		/// <summary>
		/// 公告类型，1：普通公告，2：紧急公告
		/// </summary>
		public int A_Type
		{
			set{ _a_type=value;}
			get{return _a_type;}
		}
		/// <summary>
		/// 公告部门
		/// </summary>
		public int A_GroupID
		{
			set{ _a_groupid=value;}
			get{return _a_groupid;}
		}
		#endregion Model

	}
}

