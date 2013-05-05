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
		/// 公告类型，1：普通公告，2：重大疫情公告
		/// </summary>
		public int A_Type
		{
			set{ _a_type=value;}
			get{return _a_type;}
		}
		#endregion Model

	}
}

