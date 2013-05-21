/**  版本信息模板在安装目录下，可自行修改。
* extend_DiseaseHistory.cs
*
* 功 能： N/A
* 类 名： extend_DiseaseHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:01   N/A    初版
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
	/// extend_DiseaseHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class extend_DiseaseHistory
	{
		public extend_DiseaseHistory()
		{}
		#region Model
		private int _diseasehistoryid;
		private int _dh_type;
		private DateTime _dh_diagnosisdate;
		private string _dh_note="";
		private int _dh_userid;
		/// <summary>
		/// 疾病史ID
		/// </summary>
		public int DiseaseHistoryID
		{
			set{ _diseasehistoryid=value;}
			get{return _diseasehistoryid;}
		}
		/// <summary>
		/// 疾病名称：1 高血压, 2 糖尿病, 3冠心病, 4慢性阻塞性肺疾病, 5恶性肿瘤,6脑卒中, 7中性精神疾病, 8结核病, 9肝炎, 10其他法定传染病+备注, 11其他+备注
		/// </summary>
		public int DH_Type
		{
			set{ _dh_type=value;}
			get{return _dh_type;}
		}
		/// <summary>
		/// 确诊日期
		/// </summary>
		public DateTime DH_DiagnosisDate
		{
			set{ _dh_diagnosisdate=value;}
			get{return _dh_diagnosisdate;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string DH_Note
		{
			set{ _dh_note=value;}
			get{return _dh_note;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int DH_UserID
		{
			set{ _dh_userid=value;}
			get{return _dh_userid;}
		}
		#endregion Model

	}
}

