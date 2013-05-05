using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// education_Prescription:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class education_Prescription
	{
		public education_Prescription()
		{}
		#region Model
		private int _prescriptionid;
		private decimal _p_object;
		private string _p_name;
		private string _p_content="";
		private int _p_doctor;
		private DateTime _p_date;
		/// <summary>
		/// 健康处方ID
		/// </summary>
		public int PrescriptionID
		{
			set{ _prescriptionid=value;}
			get{return _prescriptionid;}
		}
		/// <summary>
		/// 健康处方对象，与sys_User表的UserID关联
		/// </summary>
		public decimal P_Object
		{
			set{ _p_object=value;}
			get{return _p_object;}
		}
		/// <summary>
		/// 处方名称
		/// </summary>
		public string P_Name
		{
			set{ _p_name=value;}
			get{return _p_name;}
		}
		/// <summary>
		/// 处方内容
		/// </summary>
		public string P_Content
		{
			set{ _p_content=value;}
			get{return _p_content;}
		}
		/// <summary>
		/// 处方医生，，与sys_User表的UserID关联
		/// </summary>
		public int P_Doctor
		{
			set{ _p_doctor=value;}
			get{return _p_doctor;}
		}
		/// <summary>
		/// 处方日期
		/// </summary>
		public DateTime P_Date
		{
			set{ _p_date=value;}
			get{return _p_date;}
		}
		#endregion Model

	}
}

