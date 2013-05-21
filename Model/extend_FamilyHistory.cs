/**  版本信息模板在安装目录下，可自行修改。
* extend_FamilyHistory.cs
*
* 功 能： N/A
* 类 名： extend_FamilyHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-05-21 23:13:02   N/A    初版
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
	/// extend_FamilyHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class extend_FamilyHistory
	{
		public extend_FamilyHistory()
		{}
		#region Model
		private int _familyhistoryid;
		private int _fh_type;
		private int _fh_who;
		private string _fh_note="";
		private int _fh_userid;
		/// <summary>
		/// 家族史ID
		/// </summary>
		public int FamilyHistoryID
		{
			set{ _familyhistoryid=value;}
			get{return _familyhistoryid;}
		}
		/// <summary>
		/// 疾病名称：1 高血压, 2 糖尿病, 3冠心病, 4慢性阻塞性肺疾病, 5恶性肿瘤,6脑卒中, 7中性精神疾病, 8结核病, 9肝炎, 10先天畸形, 11其他+备注
		/// </summary>
		public int FH_Type
		{
			set{ _fh_type=value;}
			get{return _fh_type;}
		}
		/// <summary>
		/// 家庭成员角色：1父亲、2母亲、3兄弟姐妹、4儿女
		/// </summary>
		public int FH_Who
		{
			set{ _fh_who=value;}
			get{return _fh_who;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string FH_Note
		{
			set{ _fh_note=value;}
			get{return _fh_note;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int FH_UserID
		{
			set{ _fh_userid=value;}
			get{return _fh_userid;}
		}
		#endregion Model

	}
}

