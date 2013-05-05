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
		private string _i_conent;
		private string _i_mainproblem;
		private string _i_note="";
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
		public string I_Conent
		{
			set{ _i_conent=value;}
			get{return _i_conent;}
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
		#endregion Model

	}
}

