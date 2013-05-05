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
		#endregion Model

	}
}

