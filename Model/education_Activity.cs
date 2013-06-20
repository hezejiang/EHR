using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// education_Activity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class education_Activity
	{
		public education_Activity()
		{}
		#region Model
		private int _activityid;
		private DateTime _a_datetime;
		private string _a_location;
		private string _a_form;
		private int _a_object;
		private string _a_crowd;
		private int _a_duration=0;
		private string _a_organizers;
		private string _a_partners="";
		private string _a_missionary="";
		private int _a_number=0;
		private string _a_theme;
		/// <summary>
		/// 健康教育活动ID
		/// </summary>
		public int ActivityID
		{
			set{ _activityid=value;}
			get{return _activityid;}
		}
		/// <summary>
		/// 活动时间
		/// </summary>
		public DateTime A_DateTime
		{
			set{ _a_datetime=value;}
			get{return _a_datetime;}
		}
		/// <summary>
		/// 活动地点
		/// </summary>
		public string A_Location
		{
			set{ _a_location=value;}
			get{return _a_location;}
		}
		/// <summary>
		/// 活动形式
		/// </summary>
		public string A_Form
		{
			set{ _a_form=value;}
			get{return _a_form;}
		}
		/// <summary>
		/// 居委会ID，与sys_Group表的GroupID关联
		/// </summary>
		public int A_Object
		{
			set{ _a_object=value;}
			get{return _a_object;}
		}
		/// <summary>
		/// 参与人群
		/// </summary>
		public string A_Crowd
		{
			set{ _a_crowd=value;}
			get{return _a_crowd;}
		}
		/// <summary>
		/// 持续时间（min）
		/// </summary>
		public int A_Duration
		{
			set{ _a_duration=value;}
			get{return _a_duration;}
		}
		/// <summary>
		/// 主办单位
		/// </summary>
		public string A_Organizers
		{
			set{ _a_organizers=value;}
			get{return _a_organizers;}
		}
		/// <summary>
		/// 合作伙伴
		/// </summary>
		public string A_Partners
		{
			set{ _a_partners=value;}
			get{return _a_partners;}
		}
		/// <summary>
		/// 宣教人
		/// </summary>
		public string A_Missionary
		{
			set{ _a_missionary=value;}
			get{return _a_missionary;}
		}
		/// <summary>
		/// 参与人数
		/// </summary>
		public int A_Number
		{
			set{ _a_number=value;}
			get{return _a_number;}
		}
		/// <summary>
		/// 活动主题
		/// </summary>
		public string A_Theme
		{
			set{ _a_theme=value;}
			get{return _a_theme;}
		}
		#endregion Model

	}
}

