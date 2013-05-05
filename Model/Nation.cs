using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Nation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Nation
	{
		public Nation()
		{}
		#region Model
		private int _nationid;
		private string _n_name;
		/// <summary>
		/// 民族ID
		/// </summary>
		public int NationID
		{
			set{ _nationid=value;}
			get{return _nationid;}
		}
		/// <summary>
		/// 民族名
		/// </summary>
		public string N_Name
		{
			set{ _n_name=value;}
			get{return _n_name;}
		}
		#endregion Model

	}
}

