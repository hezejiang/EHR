using System;
using System.Reflection;
using System.Configuration;
namespace Maticsoft.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess 
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

        #region CreateSysManage
        public static Maticsoft.IDAL.ISysManage CreateSysManage()
		{
			//方式1			
			//return (Maticsoft.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//方式2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (Maticsoft.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
		/// <summary>
		/// 创建AR_Announcement数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IAR_Announcement CreateAR_Announcement()
		{

			string ClassNamespace = AssemblyPath +".AR_Announcement";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IAR_Announcement)objType;
		}


		/// <summary>
		/// 创建AR_Report数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IAR_Report CreateAR_Report()
		{

			string ClassNamespace = AssemblyPath +".AR_Report";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IAR_Report)objType;
		}


		/// <summary>
		/// 创建education_Activity数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Ieducation_Activity Createeducation_Activity()
		{

			string ClassNamespace = AssemblyPath +".education_Activity";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Ieducation_Activity)objType;
		}


		/// <summary>
		/// 创建education_Document数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Ieducation_Document Createeducation_Document()
		{

			string ClassNamespace = AssemblyPath +".education_Document";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Ieducation_Document)objType;
		}


		/// <summary>
		/// 创建education_Prescription数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Ieducation_Prescription Createeducation_Prescription()
		{

			string ClassNamespace = AssemblyPath +".education_Prescription";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Ieducation_Prescription)objType;
		}


		/// <summary>
		/// 创建Nation数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.INation CreateNation()
		{

			string ClassNamespace = AssemblyPath +".Nation";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.INation)objType;
		}


		/// <summary>
		/// 创建record_Consultation数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_Consultation Createrecord_Consultation()
		{

			string ClassNamespace = AssemblyPath +".record_Consultation";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_Consultation)objType;
		}


		/// <summary>
		/// 创建record_DeathRegistration数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_DeathRegistration Createrecord_DeathRegistration()
		{

			string ClassNamespace = AssemblyPath +".record_DeathRegistration";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_DeathRegistration)objType;
		}


		/// <summary>
		/// 创建record_FamilyBaseInfo数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_FamilyBaseInfo Createrecord_FamilyBaseInfo()
		{

			string ClassNamespace = AssemblyPath +".record_FamilyBaseInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_FamilyBaseInfo)objType;
		}


		/// <summary>
		/// 创建record_FimaryProblem数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_FimaryProblem Createrecord_FimaryProblem()
		{

			string ClassNamespace = AssemblyPath +".record_FimaryProblem";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_FimaryProblem)objType;
		}


		/// <summary>
		/// 创建record_FollowUp数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_FollowUp Createrecord_FollowUp()
		{

			string ClassNamespace = AssemblyPath +".record_FollowUp";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_FollowUp)objType;
		}


		/// <summary>
		/// 创建record_HealthCheck数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_HealthCheck Createrecord_HealthCheck()
		{

			string ClassNamespace = AssemblyPath +".record_HealthCheck";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_HealthCheck)objType;
		}


		/// <summary>
		/// 创建record_Medication数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_Medication Createrecord_Medication()
		{

			string ClassNamespace = AssemblyPath +".record_Medication";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_Medication)objType;
		}


		/// <summary>
		/// 创建record_MedicationTime数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_MedicationTime Createrecord_MedicationTime()
		{

			string ClassNamespace = AssemblyPath +".record_MedicationTime";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_MedicationTime)objType;
		}


		/// <summary>
		/// 创建record_UserBaseInfo数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Irecord_UserBaseInfo Createrecord_UserBaseInfo()
		{

			string ClassNamespace = AssemblyPath +".record_UserBaseInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Irecord_UserBaseInfo)objType;
		}


		/// <summary>
		/// 创建supervision_Info数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Isupervision_Info Createsupervision_Info()
		{

			string ClassNamespace = AssemblyPath +".supervision_Info";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isupervision_Info)objType;
		}


		/// <summary>
		/// 创建supervision_Inspect数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.Isupervision_Inspect Createsupervision_Inspect()
		{

			string ClassNamespace = AssemblyPath +".supervision_Inspect";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isupervision_Inspect)objType;
		}


		/// <summary>
		/// 创建sys_Applications数据层接口。应用表
		/// </summary>
		public static Maticsoft.IDAL.Isys_Applications Createsys_Applications()
		{

			string ClassNamespace = AssemblyPath +".sys_Applications";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_Applications)objType;
		}


		/// <summary>
		/// 创建sys_Event数据层接口。系统日记表
		/// </summary>
		public static Maticsoft.IDAL.Isys_Event Createsys_Event()
		{

			string ClassNamespace = AssemblyPath +".sys_Event";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_Event)objType;
		}


		/// <summary>
		/// 创建sys_Field数据层接口。系统应用字段
		/// </summary>
		public static Maticsoft.IDAL.Isys_Field Createsys_Field()
		{

			string ClassNamespace = AssemblyPath +".sys_Field";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_Field)objType;
		}


		/// <summary>
		/// 创建sys_FieldValue数据层接口。应用字段值
		/// </summary>
		public static Maticsoft.IDAL.Isys_FieldValue Createsys_FieldValue()
		{

			string ClassNamespace = AssemblyPath +".sys_FieldValue";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_FieldValue)objType;
		}


		/// <summary>
		/// 创建sys_Group数据层接口。部门
		/// </summary>
		public static Maticsoft.IDAL.Isys_Group Createsys_Group()
		{

			string ClassNamespace = AssemblyPath +".sys_Group";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_Group)objType;
		}


		/// <summary>
		/// 创建sys_Module数据层接口。功能模块
		/// </summary>
		public static Maticsoft.IDAL.Isys_Module Createsys_Module()
		{

			string ClassNamespace = AssemblyPath +".sys_Module";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_Module)objType;
		}


		/// <summary>
		/// 创建sys_ModuleExtPermission数据层接口。模块扩展权限
		/// </summary>
		public static Maticsoft.IDAL.Isys_ModuleExtPermission Createsys_ModuleExtPermission()
		{

			string ClassNamespace = AssemblyPath +".sys_ModuleExtPermission";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_ModuleExtPermission)objType;
		}


		/// <summary>
		/// 创建sys_Online数据层接口。在线用户表
		/// </summary>
		public static Maticsoft.IDAL.Isys_Online Createsys_Online()
		{

			string ClassNamespace = AssemblyPath +".sys_Online";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_Online)objType;
		}


		/// <summary>
		/// 创建sys_RoleApplication数据层接口。角色应用表
		/// </summary>
		public static Maticsoft.IDAL.Isys_RoleApplication Createsys_RoleApplication()
		{

			string ClassNamespace = AssemblyPath +".sys_RoleApplication";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_RoleApplication)objType;
		}


		/// <summary>
		/// 创建sys_RolePermission数据层接口。角色应用权限表
		/// </summary>
		public static Maticsoft.IDAL.Isys_RolePermission Createsys_RolePermission()
		{

			string ClassNamespace = AssemblyPath +".sys_RolePermission";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_RolePermission)objType;
		}


		/// <summary>
		/// 创建sys_Roles数据层接口。角色表
		/// </summary>
		public static Maticsoft.IDAL.Isys_Roles Createsys_Roles()
		{

			string ClassNamespace = AssemblyPath +".sys_Roles";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_Roles)objType;
		}


		/// <summary>
		/// 创建sys_SystemInfo数据层接口。系统信息表
		/// </summary>
		public static Maticsoft.IDAL.Isys_SystemInfo Createsys_SystemInfo()
		{

			string ClassNamespace = AssemblyPath +".sys_SystemInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_SystemInfo)objType;
		}


		/// <summary>
		/// 创建sys_User数据层接口。用户表
		/// </summary>
		public static Maticsoft.IDAL.Isys_User Createsys_User()
		{

			string ClassNamespace = AssemblyPath +".sys_User";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_User)objType;
		}


		/// <summary>
		/// 创建sys_UserRoles数据层接口。用户角色表
		/// </summary>
		public static Maticsoft.IDAL.Isys_UserRoles Createsys_UserRoles()
		{

			string ClassNamespace = AssemblyPath +".sys_UserRoles";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.Isys_UserRoles)objType;
		}

}
}