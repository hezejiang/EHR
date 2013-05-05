/************************************************************************************
 *      Copyright (C) 2008 supesoft.com,All Rights Reserved					 
 *      File:																 
 *				OracleDataProvider.cs                     	                 
 *      Description:															 
 *				 Oracle���ݿ������    	   							         
 *      Author:																 
 *				Lzppcc														 
 *				Lzppcc@hotmail.com											 
 *				http://www.supesoft.com										 
 *      Finish DateTime:														 
 *				2008-2-7 16:24:10													 
 *      History:																 
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.OracleClient;

using FrameWork.Components;


namespace FrameWork.Data
{
    /// <summary>
    /// Oracle���ݿ������
    /// </summary>
    public class OracleDataProvider : DataProvider
    {
        #region "OracleDataProvider"
        private string ConnString = string.Empty;

        /// <summary>
        /// ���캯��
        /// </summary>
        public OracleDataProvider()
        {
            ConnString = Common.GetConnString;
        }

        /// <summary>
        /// �������ݿ�����
        /// </summary>
        /// <returns></returns>
        private OracleConnection GetSqlConnection()
        {
            try
            {
                return new OracleConnection(ConnString);
            }
            catch
            {
                throw new Exception("û���ṩ���ݎ������ַ�����");
            }
        }
        #endregion

        #region "sys_Group - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_Group
        /// </summary>
        /// <param name="fam">sys_GroupTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_GroupInsertUpdate(sys_GroupTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_Group(GroupID,G_CName,G_ParentID,G_ShowOrder,G_Level,G_ChildCount,G_Delete)VALUES(SEQ_sys_Group_ID.NEXTVAL,:G_CName,:G_ParentID,:G_ShowOrder,:G_Level,:G_ChildCount,:G_Delete)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("G_CName", OracleType.NVarChar).Value = fam.G_CName + ""; //��������˵��	
                    cmd.Parameters.Add("G_ParentID", OracleType.Int32).Value = fam.G_ParentID; //�ϼ�����ID0:Ϊ��߼�	
                    cmd.Parameters.Add("G_ShowOrder", OracleType.Int32).Value = fam.G_ShowOrder; //��ʾ˳��	
                    cmd.Parameters.Add("G_Level", OracleType.Int32).Value = fam.G_Level; //��ǰ�������ڲ���	
                    cmd.Parameters.Add("G_ChildCount", OracleType.Int32).Value = fam.G_ChildCount; //��ǰ�����ӷ�����
                    cmd.Parameters.Add("G_Delete", OracleType.SByte).Value = fam.G_Delete; //�Ƿ�ɾ��1:��0:��
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_Group SET	G_CName = :G_CName,G_ParentID = :G_ParentID,G_ShowOrder = :G_ShowOrder,G_Level = :G_Level,G_ChildCount = :G_ChildCount,G_Delete = :G_Delete WHERE (GroupID = :GroupID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("G_CName", OracleType.NVarChar).Value = fam.G_CName + ""; //��������˵��	
                    cmd.Parameters.Add("G_ParentID", OracleType.Int32).Value = fam.G_ParentID; //�ϼ�����ID0:Ϊ��߼�	
                    cmd.Parameters.Add("G_ShowOrder", OracleType.Int32).Value = fam.G_ShowOrder; //��ʾ˳��	
                    cmd.Parameters.Add("G_Level", OracleType.Int32).Value = fam.G_Level; //��ǰ�������ڲ���	
                    cmd.Parameters.Add("G_ChildCount", OracleType.Int32).Value = fam.G_ChildCount; //��ǰ�����ӷ�����
                    cmd.Parameters.Add("G_Delete", OracleType.SByte).Value = fam.G_Delete; //�Ƿ�ɾ��1:��0:��
                    cmd.Parameters.Add("GroupID", OracleType.Int32).Value = fam.GroupID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_Group  WHERE (GroupID = :GroupID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("GroupID", OracleType.Int32).Value = fam.GroupID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_Group_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_GroupTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_GroupTableʵ�����ArrayList����</returns>
        public override ArrayList sys_GroupList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_Group);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_Module - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_Module
        /// </summary>
        /// <param name="fam">sys_ModuleTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_ModuleInsertUpdate(sys_ModuleTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_Module(ModuleID,M_ApplicationID,M_ParentID,M_PageCode,M_CName,M_Directory,M_OrderLevel,M_IsSystem,M_Close,M_Icon)VALUES(SEQ_sys_Module_ID.NEXTVAL,:M_ApplicationID,:M_ParentID,:M_PageCode,:M_CName,:M_Directory,:M_OrderLevel,:M_IsSystem,:M_Close,:M_Icon)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("M_ApplicationID", OracleType.Int32).Value = fam.M_ApplicationID; //����Ӧ�ó���ID	
                    cmd.Parameters.Add("M_ParentID", OracleType.Int32).Value = fam.M_ParentID; //��������ģ��ID��ModuleID����,0Ϊ����	
                    cmd.Parameters.Add("M_PageCode", OracleType.VarChar).Value = fam.M_PageCode + ""; //ģ�����ParentΪ0,��ΪS00(xx),����ΪS00M00(xx)
                    cmd.Parameters.Add("M_CName", OracleType.NVarChar).Value = fam.M_CName + ""; //ģ��/��Ŀ���Ƶ�ParentIDΪ0Ϊģ������
                    cmd.Parameters.Add("M_Directory", OracleType.NVarChar).Value = fam.M_Directory + ""; //ģ��/��ĿĿ¼��	
                    cmd.Parameters.Add("M_OrderLevel", OracleType.VarChar).Value = fam.M_OrderLevel + ""; //��ǰ�������򼶱�֧��˫��99���˵�
                    cmd.Parameters.Add("M_IsSystem", OracleType.SByte).Value = fam.M_IsSystem; //�Ƿ�Ϊϵͳģ��1:��0:����Ϊϵͳ���޷��޸�
                    cmd.Parameters.Add("M_Close", OracleType.SByte).Value = fam.M_Close; //�Ƿ�ر�1:��0:��
                    cmd.Parameters.Add("M_Icon", OracleType.NVarChar).Value = fam.M_Icon + ""; //Ĭ����ʾͼ��
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_Module SET	M_ApplicationID = :M_ApplicationID,M_ParentID = :M_ParentID,M_PageCode = :M_PageCode,M_CName = :M_CName,M_Directory = :M_Directory,M_OrderLevel = :M_OrderLevel,M_IsSystem = :M_IsSystem,M_Close = :M_Close,M_Icon = :M_Icon WHERE (ModuleID = :ModuleID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("M_ApplicationID", OracleType.Int32).Value = fam.M_ApplicationID; //����Ӧ�ó���ID	
                    cmd.Parameters.Add("M_ParentID", OracleType.Int32).Value = fam.M_ParentID; //��������ģ��ID��ModuleID����,0Ϊ����	
                    cmd.Parameters.Add("M_PageCode", OracleType.VarChar).Value = fam.M_PageCode + ""; //ģ�����ParentΪ0,��ΪS00(xx),����ΪS00M00(xx)
                    cmd.Parameters.Add("M_CName", OracleType.NVarChar).Value = fam.M_CName + ""; //ģ��/��Ŀ���Ƶ�ParentIDΪ0Ϊģ������
                    cmd.Parameters.Add("M_Directory", OracleType.NVarChar).Value = fam.M_Directory + ""; //ģ��/��ĿĿ¼��	
                    cmd.Parameters.Add("M_OrderLevel", OracleType.VarChar).Value = fam.M_OrderLevel + ""; //��ǰ�������򼶱�֧��˫��99���˵�
                    cmd.Parameters.Add("M_IsSystem", OracleType.SByte).Value = fam.M_IsSystem; //�Ƿ�Ϊϵͳģ��1:��0:����Ϊϵͳ���޷��޸�
                    cmd.Parameters.Add("M_Close", OracleType.SByte).Value = fam.M_Close; //�Ƿ�ر�1:��0:��
                    cmd.Parameters.Add("M_Icon", OracleType.NVarChar).Value = fam.M_Icon + ""; //Ĭ����ʾͼ��
                    cmd.Parameters.Add("ModuleID", OracleType.Int32).Value = fam.ModuleID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_Module  WHERE (ModuleID = :ModuleID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("ModuleID", OracleType.Int32).Value = fam.ModuleID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_Module_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_ModuleTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_ModuleTableʵ�����ArrayList����</returns>
        public override ArrayList sys_ModuleList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_Module);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_RoleApplication - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_RoleApplication
        /// </summary>
        /// <param name="fam">sys_RoleApplicationTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_RoleApplicationInsertUpdate(sys_RoleApplicationTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_RoleApplication(A_RoleID,A_ApplicationID)VALUES(:A_RoleID,:A_ApplicationID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("A_RoleID", OracleType.Int32).Value = fam.A_RoleID; //��ɫID��sys_Roles��RoleID���	
                    cmd.Parameters.Add("A_ApplicationID", OracleType.Int32).Value = fam.A_ApplicationID; //Ӧ��ID��sys_Applications��Appl
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_RoleApplication SET	A_RoleID = :A_RoleID,A_ApplicationID = :A_ApplicationID WHERE (A_RoleID= :A_RoleID and A_ApplicationID = :A_ApplicationID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("A_RoleID", OracleType.Int32).Value = fam.A_RoleID; //��ɫID��sys_Roles��RoleID���	
                    cmd.Parameters.Add("A_ApplicationID", OracleType.Int32).Value = fam.A_ApplicationID; //Ӧ��ID��sys_Applications��Appl
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_RoleApplication  WHERE (A_RoleID= :A_RoleID and A_ApplicationID = :A_ApplicationID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("A_RoleID", OracleType.Int32).Value = fam.A_RoleID; //��ɫID��sys_Roles��RoleID���	
                    cmd.Parameters.Add("A_ApplicationID", OracleType.Int32).Value = fam.A_ApplicationID; //Ӧ��ID��sys_Applications��Appl
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_RoleApplicationTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_RoleApplicationTableʵ�����ArrayList����</returns>
        public override ArrayList sys_RoleApplicationList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_RoleApplication);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_RolePermission - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_RolePermission
        /// </summary>
        /// <param name="fam">sys_RolePermissionTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_RolePermissionInsertUpdate(sys_RolePermissionTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_RolePermission(PermissionID,P_RoleID,P_ApplicationID,P_PageCode,P_Value)VALUES(SEQ_sys_RolePermission_ID.NEXTVAL,:P_RoleID,:P_ApplicationID,:P_PageCode,:P_Value)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("P_RoleID", OracleType.Int32).Value = fam.P_RoleID; //��ɫID��sys_Roles����RoleID��	
                    cmd.Parameters.Add("P_ApplicationID", OracleType.Int32).Value = fam.P_ApplicationID; //��ɫ����Ӧ��ID��sys_Applicatio	
                    cmd.Parameters.Add("P_PageCode", OracleType.VarChar).Value = fam.P_PageCode + ""; //��ɫӦ����ҳ��Ȩ�޴���	
                    cmd.Parameters.Add("P_Value", OracleType.Int32).Value = fam.P_Value; //Ȩ��ֵ
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_RolePermission SET	P_RoleID = :P_RoleID,P_ApplicationID = :P_ApplicationID,P_PageCode = :P_PageCode,P_Value = :P_Value WHERE (PermissionID = :PermissionID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("P_RoleID", OracleType.Int32).Value = fam.P_RoleID; //��ɫID��sys_Roles����RoleID��	
                    cmd.Parameters.Add("P_ApplicationID", OracleType.Int32).Value = fam.P_ApplicationID; //��ɫ����Ӧ��ID��sys_Applicatio	
                    cmd.Parameters.Add("P_PageCode", OracleType.VarChar).Value = fam.P_PageCode + ""; //��ɫӦ����ҳ��Ȩ�޴���	
                    cmd.Parameters.Add("P_Value", OracleType.Int32).Value = fam.P_Value; //Ȩ��ֵ
                    cmd.Parameters.Add("PermissionID", OracleType.Int32).Value = fam.PermissionID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_RolePermission  WHERE (PermissionID = :PermissionID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("PermissionID", OracleType.Int32).Value = fam.PermissionID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_RolePermission_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_RolePermissionTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_RolePermissionTableʵ�����ArrayList����</returns>
        public override ArrayList sys_RolePermissionList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_RolePermission);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion


        #region "sys_Roles - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_Roles
        /// </summary>
        /// <param name="fam">sys_RolesTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_RolesInsertUpdate(sys_RolesTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_Roles(RoleID,R_UserID,R_RoleName,R_Description)VALUES(SEQ_sys_Roles_ID.NEXTVAL,:R_UserID,:R_RoleName,:R_Description)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("R_UserID", OracleType.Int32).Value = fam.R_UserID; //�ǽ������û�ID
                    cmd.Parameters.Add("R_RoleName", OracleType.NVarChar).Value = fam.R_RoleName + ""; //��ɫ����
                    cmd.Parameters.Add("R_Description", OracleType.NVarChar).Value = fam.R_Description + ""; //��ɫ����
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_Roles SET	R_UserID = :R_UserID,R_RoleName = :R_RoleName,R_Description = :R_Description WHERE (RoleID = :RoleID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("R_UserID", OracleType.Int32).Value = fam.R_UserID; //�ǽ������û�ID
                    cmd.Parameters.Add("R_RoleName", OracleType.NVarChar).Value = fam.R_RoleName + ""; //��ɫ����
                    cmd.Parameters.Add("R_Description", OracleType.NVarChar).Value = fam.R_Description + ""; //��ɫ����
                    cmd.Parameters.Add("RoleID", OracleType.Int32).Value = fam.RoleID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_Roles  WHERE (RoleID = :RoleID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("RoleID", OracleType.Int32).Value = fam.RoleID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_Roles_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_RolesTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_RolesTableʵ�����ArrayList����</returns>
        public override ArrayList sys_RolesList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_Roles);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion		


        #region "sys_SystemInfo - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_SystemInfo
        /// </summary>
        /// <param name="fam">sys_SystemInfoTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_SystemInfoInsertUpdate(sys_SystemInfoTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_SystemInfo(SystemID,S_Name,S_Version,S_SystemConfigData,S_Licensed)VALUES(SEQ_sys_SystemInfo_ID.NEXTVAL,:S_Name,:S_Version,:S_SystemConfigData,:S_Licensed)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("S_Name", OracleType.NVarChar).Value = fam.S_Name + ""; //ϵͳ����
                    cmd.Parameters.Add("S_Version", OracleType.NVarChar).Value = fam.S_Version + ""; //�汾��
                    cmd.Parameters.Add("S_SystemConfigData", OracleType.LongRaw).Value = FrameSystemInfo.Serializable_sys_ConfigDataTable(fam.S_SystemConfigData);  //ϵͳ������Ϣ	
                    cmd.Parameters.Add("S_Licensed", OracleType.VarChar).Value = fam.S_Licensed + ""; //���к�
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_SystemInfo SET	S_Name = :S_Name,S_Version = :S_Version,S_SystemConfigData = :S_SystemConfigData,S_Licensed = :S_Licensed WHERE (SystemID = :SystemID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("S_Name", OracleType.NVarChar).Value = fam.S_Name + ""; //ϵͳ����
                    cmd.Parameters.Add("S_Version", OracleType.NVarChar).Value = fam.S_Version + ""; //�汾��
                    cmd.Parameters.Add("S_SystemConfigData", OracleType.LongRaw).Value = FrameSystemInfo.Serializable_sys_ConfigDataTable(fam.S_SystemConfigData);  //ϵͳ������Ϣ	
                    cmd.Parameters.Add("S_Licensed", OracleType.VarChar).Value = fam.S_Licensed + ""; //���к�
                    cmd.Parameters.Add("SystemID", OracleType.Int32).Value = fam.SystemID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_SystemInfo  WHERE (SystemID = :SystemID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("SystemID", OracleType.Int32).Value = fam.SystemID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_SystemInfo_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_SystemInfoTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_SystemInfoTableʵ�����ArrayList����</returns>
        public override ArrayList sys_SystemInfoList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_SystemInfo);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion
        
        #region "sys_User - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_User
        /// </summary>
        /// <param name="fam">sys_UserTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_UserInsertUpdate(sys_UserTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_User(UserID,U_LoginName,U_Password,U_CName,U_EName,U_GroupID,U_Email,U_Type,U_Status,U_Licence,U_Mac,U_Remark,U_IDCard,U_Sex,U_BirthDay,U_MobileNo,U_UserNO,U_WorkStartDate,U_WorkEndDate,U_CompanyMail,U_Title,U_Extension,U_HomeTel,U_PhotoUrl,U_DateTime,U_LastIP,U_LastDateTime,U_ExtendField)VALUES(SEQ_sys_User_ID.NEXTVAL,:U_LoginName,:U_Password,:U_CName,:U_EName,:U_GroupID,:U_Email,:U_Type,:U_Status,:U_Licence,:U_Mac,:U_Remark,:U_IDCard,:U_Sex,:U_BirthDay,:U_MobileNo,:U_UserNO,:U_WorkStartDate,:U_WorkEndDate,:U_CompanyMail,:U_Title,:U_Extension,:U_HomeTel,:U_PhotoUrl,:U_DateTime,:U_LastIP,:U_LastDateTime,:U_ExtendField)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("U_LoginName", OracleType.NVarChar).Value = fam.U_LoginName + ""; //��½��	
                    cmd.Parameters.Add("U_Password", OracleType.VarChar).Value = fam.U_Password + ""; //����md5�����ַ�
                    cmd.Parameters.Add("U_CName", OracleType.NVarChar).Value = fam.U_CName + ""; //��������	
                    cmd.Parameters.Add("U_EName", OracleType.VarChar).Value = fam.U_EName + ""; //Ӣ����	
                    cmd.Parameters.Add("U_GroupID", OracleType.Int32).Value = fam.U_GroupID; //����ID����sys_Group����GroupID����	
                    cmd.Parameters.Add("U_Email", OracleType.VarChar).Value = fam.U_Email + ""; //�����ʼ�
                    cmd.Parameters.Add("U_Type", OracleType.SByte).Value = fam.U_Type; //�û�����0:�����û�1:��ͨ�û�
                    cmd.Parameters.Add("U_Status", OracleType.SByte).Value = fam.U_Status; //��ǰ״̬0:���� 1:��ֹ��½ 2:ɾ��	
                    cmd.Parameters.Add("U_Licence", OracleType.VarChar).Value = fam.U_Licence + ""; //�û����к�	
                    cmd.Parameters.Add("U_Mac", OracleType.VarChar).Value = fam.U_Mac + ""; //��������Ӳ����ַ
                    cmd.Parameters.Add("U_Remark", OracleType.NVarChar).Value = fam.U_Remark + ""; //��ע˵��	
                    cmd.Parameters.Add("U_IDCard", OracleType.VarChar).Value = fam.U_IDCard + ""; //���֤����
                    cmd.Parameters.Add("U_Sex", OracleType.SByte).Value = fam.U_Sex; //�Ա�1:��0:Ů	
                    if (fam.U_BirthDay.HasValue)
                        cmd.Parameters.Add("U_BirthDay", OracleType.DateTime).Value = fam.U_BirthDay; //��������	
                    else
                        cmd.Parameters.Add("U_BirthDay", OracleType.DateTime).Value = DBNull.Value; //��������	
                    cmd.Parameters.Add("U_MobileNo", OracleType.VarChar).Value = fam.U_MobileNo + ""; //�ֻ���	
                    cmd.Parameters.Add("U_UserNO", OracleType.VarChar).Value = fam.U_UserNO + ""; //Ա�����	
                    if (fam.U_WorkStartDate.HasValue)
                        cmd.Parameters.Add("U_WorkStartDate", OracleType.DateTime).Value = fam.U_WorkStartDate; //��ְ����	
                    else
                        cmd.Parameters.Add("U_WorkStartDate", OracleType.DateTime).Value = DBNull.Value; //��ְ����	
                    if (fam.U_WorkEndDate.HasValue)
                        cmd.Parameters.Add("U_WorkEndDate", OracleType.DateTime).Value = fam.U_WorkEndDate; //��ְ����	
                    else
                        cmd.Parameters.Add("U_WorkEndDate", OracleType.DateTime).Value = DBNull.Value; //��ְ����	
                    cmd.Parameters.Add("U_CompanyMail", OracleType.VarChar).Value = fam.U_CompanyMail + ""; //��˾�ʼ���ַ	
                    cmd.Parameters.Add("U_Title", OracleType.Int32).Value = fam.U_Title; //ְ����Ӧ���ֶι���	
                    cmd.Parameters.Add("U_Extension", OracleType.VarChar).Value = fam.U_Extension + ""; //�ֻ���	
                    cmd.Parameters.Add("U_HomeTel", OracleType.VarChar).Value = fam.U_HomeTel + ""; //���е绰
                    cmd.Parameters.Add("U_PhotoUrl", OracleType.NVarChar).Value = fam.U_PhotoUrl + ""; //�û���Ƭ��ַ	
                    cmd.Parameters.Add("U_DateTime", OracleType.DateTime).Value = fam.U_DateTime; //����ʱ��	
                    cmd.Parameters.Add("U_LastIP", OracleType.VarChar).Value = fam.U_LastIP + ""; //������IP	
                    cmd.Parameters.Add("U_LastDateTime", OracleType.DateTime).Value = fam.U_LastDateTime; //������ʱ��
                    cmd.Parameters.Add("U_ExtendField", OracleType.VarChar).Value = fam.U_ExtendField + "";  //��չ�ֶ�
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_User SET	U_LoginName = :U_LoginName,U_Password = :U_Password,U_CName = :U_CName,U_EName = :U_EName,U_GroupID = :U_GroupID,U_Email = :U_Email,U_Type = :U_Type,U_Status = :U_Status,U_Licence = :U_Licence,U_Mac = :U_Mac,U_Remark = :U_Remark,U_IDCard = :U_IDCard,U_Sex = :U_Sex,U_BirthDay = :U_BirthDay,U_MobileNo = :U_MobileNo,U_UserNO = :U_UserNO,U_WorkStartDate = :U_WorkStartDate,U_WorkEndDate = :U_WorkEndDate,U_CompanyMail = :U_CompanyMail,U_Title = :U_Title,U_Extension = :U_Extension,U_HomeTel = :U_HomeTel,U_PhotoUrl = :U_PhotoUrl,U_DateTime = :U_DateTime,U_LastIP = :U_LastIP,U_LastDateTime = :U_LastDateTime,U_ExtendField = :U_ExtendField WHERE (UserID = :UserID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("U_LoginName", OracleType.NVarChar).Value = fam.U_LoginName + ""; //��½��	
                    cmd.Parameters.Add("U_Password", OracleType.VarChar).Value = fam.U_Password + ""; //����md5�����ַ�
                    cmd.Parameters.Add("U_CName", OracleType.NVarChar).Value = fam.U_CName + ""; //��������	
                    cmd.Parameters.Add("U_EName", OracleType.VarChar).Value = fam.U_EName + ""; //Ӣ����	
                    cmd.Parameters.Add("U_GroupID", OracleType.Int32).Value = fam.U_GroupID; //����ID����sys_Group����GroupID����	
                    cmd.Parameters.Add("U_Email", OracleType.VarChar).Value = fam.U_Email + ""; //�����ʼ�
                    cmd.Parameters.Add("U_Type", OracleType.SByte).Value = fam.U_Type; //�û�����0:�����û�1:��ͨ�û�
                    cmd.Parameters.Add("U_Status", OracleType.SByte).Value = fam.U_Status; //��ǰ״̬0:���� 1:��ֹ��½ 2:ɾ��	
                    cmd.Parameters.Add("U_Licence", OracleType.VarChar).Value = fam.U_Licence + ""; //�û����к�	
                    cmd.Parameters.Add("U_Mac", OracleType.VarChar).Value = fam.U_Mac + ""; //��������Ӳ����ַ
                    cmd.Parameters.Add("U_Remark", OracleType.NVarChar).Value = fam.U_Remark + ""; //��ע˵��	
                    cmd.Parameters.Add("U_IDCard", OracleType.VarChar).Value = fam.U_IDCard + ""; //���֤����
                    cmd.Parameters.Add("U_Sex", OracleType.SByte).Value = fam.U_Sex; //�Ա�1:��0:Ů	
                    if (fam.U_BirthDay.HasValue)
                        cmd.Parameters.Add("U_BirthDay", OracleType.DateTime).Value = fam.U_BirthDay; //��������	
                    else
                        cmd.Parameters.Add("U_BirthDay", OracleType.DateTime).Value = DBNull.Value; //��������	
                    cmd.Parameters.Add("U_MobileNo", OracleType.VarChar).Value = fam.U_MobileNo + ""; //�ֻ���	
                    cmd.Parameters.Add("U_UserNO", OracleType.VarChar).Value = fam.U_UserNO + ""; //Ա�����	
                    if (fam.U_WorkStartDate.HasValue)
                        cmd.Parameters.Add("U_WorkStartDate", OracleType.DateTime).Value = fam.U_WorkStartDate; //��ְ����	
                    else
                        cmd.Parameters.Add("U_WorkStartDate", OracleType.DateTime).Value = DBNull.Value; //��ְ����	
                    if (fam.U_WorkEndDate.HasValue)
                        cmd.Parameters.Add("U_WorkEndDate", OracleType.DateTime).Value = fam.U_WorkEndDate; //��ְ����	
                    else
                        cmd.Parameters.Add("U_WorkEndDate", OracleType.DateTime).Value = DBNull.Value; //��ְ����	
                    cmd.Parameters.Add("U_CompanyMail", OracleType.VarChar).Value = fam.U_CompanyMail + ""; //��˾�ʼ���ַ	
                    cmd.Parameters.Add("U_Title", OracleType.Int32).Value = fam.U_Title; //ְ����Ӧ���ֶι���	
                    cmd.Parameters.Add("U_Extension", OracleType.VarChar).Value = fam.U_Extension + ""; //�ֻ���	
                    cmd.Parameters.Add("U_HomeTel", OracleType.VarChar).Value = fam.U_HomeTel + ""; //���е绰
                    cmd.Parameters.Add("U_PhotoUrl", OracleType.NVarChar).Value = fam.U_PhotoUrl + ""; //�û���Ƭ��ַ	
                    cmd.Parameters.Add("U_DateTime", OracleType.DateTime).Value = fam.U_DateTime; //����ʱ��	
                    cmd.Parameters.Add("U_LastIP", OracleType.VarChar).Value = fam.U_LastIP + ""; //������IP	
                    cmd.Parameters.Add("U_LastDateTime", OracleType.DateTime).Value = fam.U_LastDateTime; //������ʱ��
                    cmd.Parameters.Add("U_ExtendField", OracleType.VarChar).Value = fam.U_ExtendField + "";  //��չ�ֶ�
                    cmd.Parameters.Add("UserID", OracleType.Int32).Value = fam.UserID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_User  WHERE (UserID = :UserID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("UserID", OracleType.Int32).Value = fam.UserID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_User_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_UserTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_UserTableʵ�����ArrayList����</returns>
        public override ArrayList sys_UserList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_User);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_UserRoles - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_UserRoles
        /// </summary>
        /// <param name="fam">sys_UserRolesTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_UserRolesInsertUpdate(sys_UserRolesTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_UserRoles(R_UserID,R_RoleID)VALUES(:R_UserID,:R_RoleID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("R_UserID", OracleType.Int32).Value = fam.R_UserID; //�û�ID��sys_User����UserID���	
                    cmd.Parameters.Add("R_RoleID", OracleType.Int32).Value = fam.R_RoleID; //�û�������ɫID��Sys_Roles����
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_UserRoles SET	R_UserID = :R_UserID,R_RoleID = :R_RoleID WHERE (  R_UserID = :R_UserID and R_RoleID = :R_RoleID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("R_UserID", OracleType.Int32).Value = fam.R_UserID; //�û�ID��sys_User����UserID���	
                    cmd.Parameters.Add("R_RoleID", OracleType.Int32).Value = fam.R_RoleID; //�û�������ɫID��Sys_Roles����

                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_UserRoles  WHERE ( R_UserID = :R_UserID and R_RoleID = :R_RoleID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("R_UserID", OracleType.Int32).Value = fam.R_UserID; //�û�ID��sys_User����UserID���	
                    cmd.Parameters.Add("R_RoleID", OracleType.Int32).Value = fam.R_RoleID; //�û�������ɫID��Sys_Roles����
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_UserRolesTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_UserRolesTableʵ�����ArrayList����</returns>
        public override ArrayList sys_UserRolesList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_UserRoles);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_Applications - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_Applications
        /// </summary>
        /// <param name="fam">sys_ApplicationsTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_ApplicationsInsertUpdate(sys_ApplicationsTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_Applications(ApplicationID,A_AppName,A_AppDescription,A_AppUrl,A_Order)VALUES(SEQ_sys_Applications_ID.NEXTVAL,:A_AppName,:A_AppDescription,:A_AppUrl,:A_Order)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("A_Order", OracleType.Int32).Value = fam.A_Order;
                    cmd.Parameters.Add("A_AppName", OracleType.NVarChar).Value = fam.A_AppName + ""; //Ӧ������
                    cmd.Parameters.Add("A_AppDescription", OracleType.NVarChar).Value = fam.A_AppDescription + ""; //Ӧ�ý���	
                    cmd.Parameters.Add("A_AppUrl", OracleType.VarChar).Value = fam.A_AppUrl + ""; //Ӧ��Url��ַ
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_Applications SET	A_Order = :A_Order,A_AppName = :A_AppName,A_AppDescription = :A_AppDescription,A_AppUrl = :A_AppUrl WHERE (ApplicationID = :ApplicationID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("A_Order", OracleType.Int32).Value = fam.A_Order;
                    cmd.Parameters.Add("A_AppName", OracleType.NVarChar).Value = fam.A_AppName + ""; //Ӧ������
                    cmd.Parameters.Add("A_AppDescription", OracleType.NVarChar).Value = fam.A_AppDescription + ""; //Ӧ�ý���	
                    cmd.Parameters.Add("A_AppUrl", OracleType.VarChar).Value = fam.A_AppUrl + ""; //Ӧ��Url��ַ
                    cmd.Parameters.Add("ApplicationID", OracleType.Int32).Value = fam.ApplicationID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_Applications  WHERE (ApplicationID = :ApplicationID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("ApplicationID", OracleType.Int32).Value = fam.ApplicationID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_Applications_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_ApplicationsTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_ApplicationsTableʵ�����ArrayList����</returns>
        public override ArrayList sys_ApplicationsList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_Applications);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_Event - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_Event
        /// </summary>
        /// <param name="fam">sys_EventTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_EventInsertUpdate(sys_EventTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_Event(EventID,E_U_LoginName,E_UserID,E_DateTime,E_ApplicationID,E_A_AppName,E_M_Name,E_M_PageCode,E_From,E_Type,E_IP,E_Record)VALUES(SEQ_sys_Event_ID.NEXTVAL,:E_U_LoginName,:E_UserID,:E_DateTime,:E_ApplicationID,:E_A_AppName,:E_M_Name,:E_M_PageCode,:E_From,:E_Type,:E_IP,:E_Record)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("E_U_LoginName", OracleType.NVarChar).Value = fam.E_U_LoginName + ""; //�û���	
                    cmd.Parameters.Add("E_UserID", OracleType.Int32).Value = fam.E_UserID; //����ʱ�û�ID��sys_Users��UserID	
                    cmd.Parameters.Add("E_DateTime", OracleType.DateTime).Value = fam.E_DateTime; //�¼����������ڼ�ʱ��	
                    cmd.Parameters.Add("E_ApplicationID", OracleType.Int32).Value = fam.E_ApplicationID; //����Ӧ�ó���ID��sys_Applicatio
                    cmd.Parameters.Add("E_A_AppName", OracleType.NVarChar).Value = fam.E_A_AppName + ""; //����Ӧ������
                    cmd.Parameters.Add("E_M_Name", OracleType.NVarChar).Value = fam.E_M_Name + ""; //PageCodeģ��������sys_Module��ͬ	
                    cmd.Parameters.Add("E_M_PageCode", OracleType.VarChar).Value = fam.E_M_PageCode + ""; //�����¼�ʱģ������
                    cmd.Parameters.Add("E_From", OracleType.NVarChar).Value = fam.E_From + ""; //��Դ
                    cmd.Parameters.Add("E_Type", OracleType.SByte).Value = fam.E_Type; //�ռ�����,1:�����ռ�2:��ȫ��־3	
                    cmd.Parameters.Add("E_IP", OracleType.VarChar).Value = fam.E_IP + ""; //�ͻ���IP��ַ
                    cmd.Parameters.Add("E_Record", OracleType.NVarChar).Value = fam.E_Record + ""; //��ϸ����
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_Event SET	E_U_LoginName = :E_U_LoginName,E_UserID = :E_UserID,E_DateTime = :E_DateTime,E_ApplicationID = :E_ApplicationID,E_A_AppName = :E_A_AppName,E_M_Name = :E_M_Name,E_M_PageCode = :E_M_PageCode,E_From = :E_From,E_Type = :E_Type,E_IP = :E_IP,E_Record = :E_Record WHERE (EventID = :EventID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("E_U_LoginName", OracleType.NVarChar).Value = fam.E_U_LoginName + ""; //�û���	
                    cmd.Parameters.Add("E_UserID", OracleType.Int32).Value = fam.E_UserID; //����ʱ�û�ID��sys_Users��UserID	
                    cmd.Parameters.Add("E_DateTime", OracleType.DateTime).Value = fam.E_DateTime; //�¼����������ڼ�ʱ��	
                    cmd.Parameters.Add("E_ApplicationID", OracleType.Int32).Value = fam.E_ApplicationID; //����Ӧ�ó���ID��sys_Applicatio
                    cmd.Parameters.Add("E_A_AppName", OracleType.NVarChar).Value = fam.E_A_AppName + ""; //����Ӧ������
                    cmd.Parameters.Add("E_M_Name", OracleType.NVarChar).Value = fam.E_M_Name + ""; //PageCodeģ��������sys_Module��ͬ	
                    cmd.Parameters.Add("E_M_PageCode", OracleType.VarChar).Value = fam.E_M_PageCode + ""; //�����¼�ʱģ������
                    cmd.Parameters.Add("E_From", OracleType.NVarChar).Value = fam.E_From + ""; //��Դ
                    cmd.Parameters.Add("E_Type", OracleType.SByte).Value = fam.E_Type; //�ռ�����,1:�����ռ�2:��ȫ��־3	
                    cmd.Parameters.Add("E_IP", OracleType.VarChar).Value = fam.E_IP + ""; //�ͻ���IP��ַ
                    cmd.Parameters.Add("E_Record", OracleType.NVarChar).Value = fam.E_Record + ""; //��ϸ����
                    cmd.Parameters.Add("EventID", OracleType.Int32).Value = fam.EventID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_Event  WHERE (EventID = :EventID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("EventID", OracleType.Int32).Value = fam.EventID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_Event_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_EventTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_EventTableʵ�����ArrayList����</returns>
        public override ArrayList sys_EventList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_Event);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        /// <summary>
        /// ��ձ�sys_Event�е���������
        /// </summary>
        public override void sys_EventClearData()
        {
            using (OracleConnection Conn = GetSqlConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "truncate table sys_Event";
                Conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Dispose();
                Conn.Close();
            }
        }

        #endregion

        #region "sys_Field - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_Field
        /// </summary>
        /// <param name="fam">sys_FieldTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_FieldInsertUpdate(sys_FieldTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_Field(FieldID,F_Key,F_CName,F_Remark)VALUES(SEQ_sys_Field_ID.NEXTVAL,:F_Key,:F_CName,:F_Remark)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("F_Key", OracleType.VarChar).Value = fam.F_Key + ""; //Ӧ���ֶιؼ���
                    cmd.Parameters.Add("F_CName", OracleType.NVarChar).Value = fam.F_CName + ""; //Ӧ���ֶ�����˵��
                    cmd.Parameters.Add("F_Remark", OracleType.NVarChar).Value = fam.F_Remark + ""; //����˵��
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_Field SET	F_Key = :F_Key,F_CName = :F_CName,F_Remark = :F_Remark WHERE (FieldID = :FieldID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("F_Key", OracleType.VarChar).Value = fam.F_Key + ""; //Ӧ���ֶιؼ���
                    cmd.Parameters.Add("F_CName", OracleType.NVarChar).Value = fam.F_CName + ""; //Ӧ���ֶ�����˵��
                    cmd.Parameters.Add("F_Remark", OracleType.NVarChar).Value = fam.F_Remark + ""; //����˵��
                    cmd.Parameters.Add("FieldID", OracleType.Int32).Value = fam.FieldID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_Field  WHERE (FieldID = :FieldID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("FieldID", OracleType.Int32).Value = fam.FieldID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_Field_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_FieldTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_FieldTableʵ�����ArrayList����</returns>
        public override ArrayList sys_FieldList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_Field);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_FieldValue - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_FieldValue
        /// </summary>
        /// <param name="fam">sys_FieldValueTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_FieldValueInsertUpdate(sys_FieldValueTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_FieldValue(ValueID,V_F_Key,V_Text,V_Code,V_ShowOrder)VALUES(SEQ_sys_FieldValue_ID.NEXTVAL,:V_F_Key,:V_Text,:V_Code,:V_ShowOrder)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("V_F_Key", OracleType.VarChar).Value = fam.V_F_Key + ""; //��sys_Field����F_Key�ֶι���
                    cmd.Parameters.Add("V_Text", OracleType.NVarChar).Value = fam.V_Text + ""; //����˵��	
                    cmd.Parameters.Add("V_Code", OracleType.NVarChar).Value = fam.V_Code + ""; //����	
                    cmd.Parameters.Add("V_ShowOrder", OracleType.Int32).Value = fam.V_ShowOrder; //ͬ����ʾ˳��
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_FieldValue SET	V_F_Key = :V_F_Key,V_Text = :V_Text,V_Code = :V_Code,V_ShowOrder = :V_ShowOrder WHERE (ValueID = :ValueID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("V_F_Key", OracleType.VarChar).Value = fam.V_F_Key + ""; //��sys_Field����F_Key�ֶι���
                    cmd.Parameters.Add("V_Text", OracleType.NVarChar).Value = fam.V_Text + ""; //����˵��	
                    cmd.Parameters.Add("V_Code", OracleType.NVarChar).Value = fam.V_Code + ""; //����	
                    cmd.Parameters.Add("V_ShowOrder", OracleType.Int32).Value = fam.V_ShowOrder; //ͬ����ʾ˳��
                    cmd.Parameters.Add("ValueID", OracleType.Int32).Value = fam.ValueID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_FieldValue  WHERE (ValueID = :ValueID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("ValueID", OracleType.Int32).Value = fam.ValueID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_FieldValue_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_FieldValueTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_FieldValueTableʵ�����ArrayList����</returns>
        public override ArrayList sys_FieldValueList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_FieldValue);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion

        #region "sys_Online - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_Online
        /// </summary>
        /// <param name="fam">sys_OnlineTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_OnlineInsertUpdate(sys_OnlineTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_Online(OnlineID,O_SessionID,O_UserName,O_Ip,O_LoginTime,O_LastTime,O_LastUrl)VALUES(SEQ_sys_Online_ID.NEXTVAL,:O_SessionID,:O_UserName,:O_Ip,:O_LoginTime,:O_LastTime,:O_LastUrl)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("O_SessionID", OracleType.VarChar).Value = fam.O_SessionID + ""; //�û�SessionID
                    cmd.Parameters.Add("O_UserName", OracleType.NVarChar).Value = fam.O_UserName + ""; //�û���	
                    cmd.Parameters.Add("O_Ip", OracleType.VarChar).Value = fam.O_Ip + ""; //�û�IP��ַ	
                    cmd.Parameters.Add("O_LoginTime", OracleType.DateTime).Value = fam.O_LoginTime; //��½ʱ��	
                    cmd.Parameters.Add("O_LastTime", OracleType.DateTime).Value = fam.O_LastTime; //������ʱ��
                    cmd.Parameters.Add("O_LastUrl", OracleType.NVarChar).Value = fam.O_LastUrl + ""; //���������վ
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_Online SET	O_SessionID = :O_SessionID,O_UserName = :O_UserName,O_Ip = :O_Ip,O_LoginTime = :O_LoginTime,O_LastTime = :O_LastTime,O_LastUrl = :O_LastUrl WHERE (OnlineID = :OnlineID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("O_SessionID", OracleType.VarChar).Value = fam.O_SessionID + ""; //�û�SessionID
                    cmd.Parameters.Add("O_UserName", OracleType.NVarChar).Value = fam.O_UserName + ""; //�û���	
                    cmd.Parameters.Add("O_Ip", OracleType.VarChar).Value = fam.O_Ip + ""; //�û�IP��ַ	
                    cmd.Parameters.Add("O_LoginTime", OracleType.DateTime).Value = fam.O_LoginTime; //��½ʱ��	
                    cmd.Parameters.Add("O_LastTime", OracleType.DateTime).Value = fam.O_LastTime; //������ʱ��
                    cmd.Parameters.Add("O_LastUrl", OracleType.NVarChar).Value = fam.O_LastUrl + ""; //���������վ
                    cmd.Parameters.Add("OnlineID", OracleType.Int32).Value = fam.OnlineID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_Online  WHERE (OnlineID = :OnlineID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("OnlineID", OracleType.Int32).Value = fam.OnlineID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_Online_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_OnlineTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_OnlineTableʵ�����ArrayList����</returns>
        public override ArrayList sys_OnlineList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_Online);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion		

        #region "sys_ModuleExtPermission - OracleDataProvider"
        /// <summary>
        /// ����/ɾ��/�޸� sys_ModuleExtPermission
        /// </summary>
        /// <param name="fam">sys_ModuleExtPermissionTableʵ����</param>
        /// <returns>����0������</returns>
        public override int sys_ModuleExtPermissionInsertUpdate(sys_ModuleExtPermissionTable fam)
        {
            int rInt = 0;

            using (OracleConnection Conn = GetSqlConnection())
            {
                string CommTxt;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Conn;
                if (fam.DB_Option_Action_ == "Insert")
                {
                    CommTxt = "Insert into 	sys_ModuleExtPermission(ExtPermissionID,ModuleID,PermissionName,PermissionValue)VALUES(SEQ_sys_ModuleExtPermission_ID.NEXTVAL,:ModuleID,:PermissionName,:PermissionValue)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("ModuleID", OracleType.Int32).Value = fam.ModuleID; //ģ��ID
                    cmd.Parameters.Add("PermissionName", OracleType.NVarChar).Value = fam.PermissionName + ""; //Ȩ������	
                    cmd.Parameters.Add("PermissionValue", OracleType.Int32).Value = fam.PermissionValue; //Ȩ��ֵ
                }
                else if (fam.DB_Option_Action_ == "Update")
                {

                    CommTxt = "UPDATE sys_ModuleExtPermission SET	ModuleID = :ModuleID,PermissionName = :PermissionName,PermissionValue = :PermissionValue WHERE (ExtPermissionID = :ExtPermissionID)";
                    cmd.CommandText = CommTxt;

                    cmd.Parameters.Add("ModuleID", OracleType.Int32).Value = fam.ModuleID; //ģ��ID
                    cmd.Parameters.Add("PermissionName", OracleType.NVarChar).Value = fam.PermissionName + ""; //Ȩ������	
                    cmd.Parameters.Add("PermissionValue", OracleType.Int32).Value = fam.PermissionValue; //Ȩ��ֵ
                    cmd.Parameters.Add("ExtPermissionID", OracleType.Int32).Value = fam.ExtPermissionID;
                }
                else if (fam.DB_Option_Action_ == "Delete")
                {
                    CommTxt = "Delete from  sys_ModuleExtPermission  WHERE (ExtPermissionID = :ExtPermissionID)";
                    cmd.CommandText = CommTxt;
                    cmd.Parameters.Add("ExtPermissionID", OracleType.Int32).Value = fam.ExtPermissionID;
                }
                else
                    throw new ApplicationException("�޷�ʶ��Ĳ�������!");
                Conn.Open();
                OracleTransaction Tran = Conn.BeginTransaction();
                cmd.Transaction = Tran;
                try
                {
                    rInt = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (fam.DB_Option_Action_ == "Insert")
                    {
                        cmd.CommandText = "select SEQ_sys_ModuleExtPermission_ID.CURRVAL from  dual";
                        rInt = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    Tran.Commit();
                }
                catch (Exception ex)
                {
                    Tran.Rollback();
                    throw new ApplicationException(ex.ToString());
                }
                finally
                {
                    Tran.Dispose();
                    cmd.Dispose();
                    Conn.Dispose();
                    Conn.Close();
                }
            }
            return rInt;
        }

        /// <summary>
        /// ����sys_ModuleExtPermissionTableʵ�����ArrayList����
        /// </summary>
        /// <param name="qp">��ѯ��</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>sys_ModuleExtPermissionTableʵ�����ArrayList����</returns>
        public override ArrayList sys_ModuleExtPermissionList(QueryParam qp, out int RecordCount)
        {
            PopulateDelegate mypd = new PopulateDelegate(base.Populatesys_ModuleExtPermission);
            return this.GetObjectList(mypd, qp, out RecordCount);
        }

        #endregion	
	
        #region "������ѯ���ݺ���Oracle��"
        /// <summary>
        /// ������ѯ���ݺ���Oracle��
        /// </summary>
        /// <param name="pd">ί�ж���</param>
        /// <param name="pp">��ѯ�ַ���</param>
        /// <param name="RecordCount">���ؼ�¼����</param>
        /// <returns>���ؼ�¼��ArrayList</returns>
        private ArrayList GetObjectList(PopulateDelegate pd, QueryParam pp, out int RecordCount)
        {
            ArrayList lst = new ArrayList();
            RecordCount = 0;
            using (OracleConnection Conn = GetSqlConnection())
            {
                StringBuilder sb = new StringBuilder();
                OracleCommand cmd = new OracleCommand();
                OracleDataReader dr = null;
                cmd.Connection = Conn;

                int TotalRecordForPageIndex = pp.PageIndex * pp.PageSize;
                int FirstRecordForPageIndex = (pp.PageIndex - 1) * pp.PageSize;
                string OrderBy;
                if (pp.OrderType == 1)
                {
                    OrderBy = " Order by " + pp.Orderfld.Replace(",", " desc,") + " desc ";
                }
                else
                {
                    OrderBy = " Order by " + pp.Orderfld.Replace(",", " asc,") + " asc ";
                }
                sb.AppendFormat("SELECT * FROM (SELECT A.*, ROWNUM RN FROM (SELECT * FROM {0} {1} {2}) A WHERE ROWNUM <= {3})WHERE RN > {4} ", pp.TableName.ToUpper(), pp.Where, OrderBy, TotalRecordForPageIndex, FirstRecordForPageIndex);
                cmd.CommandText = sb.ToString();
                Conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lst.Add(pd(dr));
                }
                dr.Close();
                cmd.Parameters.Clear();
                // ȡ��¼����
                cmd.CommandText = string.Format("SELECT Count(1) From {0} {1}", pp.TableName, pp.Where);
                RecordCount = Convert.ToInt32(cmd.ExecuteScalar());
                dr.Dispose();
                dr.Close();
                cmd.Dispose();
                Conn.Dispose();
                Conn.Close();
            }
            return lst;
        }
        #endregion

        #region "��ȡ�����ֶ�ֵ"
        /// <summary>
        /// ��ȡ�����ֶ�ֵ
        /// </summary>
        /// <param name="table_name">����</param>
        /// <param name="table_fileds">�ֶ�</param>
        /// <param name="where_fileds">��ѯ�����ֶ�</param>
        /// <param name="where_value">��ѯֵ</param>
        /// <returns></returns>
        public override string get_table_fileds(string table_name, string table_fileds, string where_fileds, string where_value)
        {
            where_value = Common.inSQL(where_value);
            string rStr = "";
            using (OracleConnection Conn = GetSqlConnection())
            {
                string strSql = string.Format("select {0} from {1} where upper({2})='{3}'", table_fileds, table_name.ToUpper(), where_fileds, where_value);
                OracleCommand cmd = new OracleCommand(strSql, Conn);
                cmd.CommandType = CommandType.Text;
                Conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    rStr = dr[0].ToString();
                }
                dr.Close();
                dr.Dispose();
                cmd.Dispose();
                Conn.Dispose();
                Conn.Close();
            }
            return rStr;
        }
        #endregion

        #region "���±����ֶ�ֵ"
        /// <summary>
        /// ���±����ֶ�ֵ
        /// </summary>
        /// <param name="Table">����</param>
        /// <param name="Table_FiledsValue">��Ҫ����ֵ(���ô�Set)</param>
        /// <param name="Wheres">��������(���ô�Where)</param>
        /// <returns></returns>
        public override int Update_Table_Fileds(string Table, string Table_FiledsValue, string Wheres)
        {
            int rInt = 0;
            using (OracleConnection Conn = GetSqlConnection())
            {
                string strSql = string.Format("Update {0} Set {1}  Where {2}", Table.ToUpper(), Table_FiledsValue, Wheres);
                OracleCommand cmd = new OracleCommand(strSql, Conn);
                cmd.CommandType = CommandType.Text;
                Conn.Open();
                rInt = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                Conn.Dispose();
                Conn.Close();
            }
            return rInt;
        }
        #endregion
    }
}