/*==============================================================*/
/* Database name:  FrameWork                                    */
/* DBMS name:      SQL SERVER 2000(EXTENDED)                    */
/* Created on:     2009-10-27 20:45:05                          */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_Applications')
            and   type = 'U')
   drop table dbo.sys_Applications
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_Event')
            and   type = 'U')
   drop table dbo.sys_Event
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_Field')
            and   type = 'U')
   drop table dbo.sys_Field
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_FieldValue')
            and   type = 'U')
   drop table dbo.sys_FieldValue
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_Group')
            and   type = 'U')
   drop table dbo.sys_Group
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_Module')
            and   type = 'U')
   drop table dbo.sys_Module
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_ModuleExtPermission')
            and   type = 'U')
   drop table dbo.sys_ModuleExtPermission
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_Online')
            and   type = 'U')
   drop table dbo.sys_Online
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_RoleApplication')
            and   type = 'U')
   drop table dbo.sys_RoleApplication
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_RolePermission')
            and   type = 'U')
   drop table dbo.sys_RolePermission
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_Roles')
            and   type = 'U')
   drop table dbo.sys_Roles
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_SystemInfo')
            and   type = 'U')
   drop table dbo.sys_SystemInfo
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_User')
            and   type = 'U')
   drop table dbo.sys_User
go


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.sys_UserRoles')
            and   type = 'U')
   drop table dbo.sys_UserRoles
go


/*==============================================================*/
/* Table: sys_Applications                                      */
/*==============================================================*/
create table dbo.sys_Applications (
   ApplicationID        int                  identity,
   A_AppName            nvarchar(50)         null,
   A_AppDescription     nvarchar(200)        null,
   A_AppUrl             varchar(50)          null,
   A_Order              int                  null,
   constraint PK_SYS_APPLICATIONS primary key clustered (ApplicationID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ�ñ�', N'user', N'dbo', N'table', N'sys_Applications', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�Զ�ID 1:Ϊϵͳ����Ӧ��', N'user', N'dbo', N'table', N'sys_Applications', N'column', N'ApplicationID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ������', N'user', N'dbo', N'table', N'sys_Applications', N'column', N'A_AppName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ�ý���', N'user', N'dbo', N'table', N'sys_Applications', N'column', N'A_AppDescription'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ��Url��ַ', N'user', N'dbo', N'table', N'sys_Applications', N'column', N'A_AppUrl'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ������', N'user', N'dbo', N'table', N'sys_Applications', N'column', N'A_Order'
go


/*==============================================================*/
/* Table: sys_Event                                             */
/*==============================================================*/
create table dbo.sys_Event (
   EventID              int                  identity,
   E_U_LoginName        nvarchar(20)         null,
   E_UserID             int                  null,
   E_DateTime           datetime             not null default getdate(),
   E_ApplicationID      int                  null,
   E_A_AppName          nvarchar(50)         null,
   E_M_Name             nvarchar(50)         null,
   E_M_PageCode         varchar(6)           null,
   E_From               nvarchar(500)        null,
   E_Type               tinyint              not null default 1,
   E_IP                 varchar(15)          null,
   E_Record             nvarchar(500)        null,
   constraint PK_SYS_EVENT primary key clustered (EventID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ϵͳ�ռǱ�', N'user', N'dbo', N'table', N'sys_Event', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�¼�ID��', N'user', N'dbo', N'table', N'sys_Event', N'column', N'EventID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û���', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_U_LoginName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����ʱ�û�ID��sys_Users��UserID', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_UserID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�¼����������ڼ�ʱ��', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_DateTime'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����Ӧ�ó���ID��sys_Applicatio', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_ApplicationID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����Ӧ������', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_A_AppName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'PageCodeģ��������sys_Module��ͬ', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_M_Name'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�����¼�ʱģ������', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_M_PageCode'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��Դ', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_From'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�ռ�����,1:�����ռ�2:��ȫ��־3', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_Type'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�ͻ���IP��ַ', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_IP'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ϸ����', N'user', N'dbo', N'table', N'sys_Event', N'column', N'E_Record'
go


/*==============================================================*/
/* Table: sys_Field                                             */
/*==============================================================*/
create table dbo.sys_Field (
   FieldID              int                  identity,
   F_Key                varchar(50)          null,
   F_CName              nvarchar(50)         null,
   F_Remark             nvarchar(200)        null,
   constraint PK_Sys_Field primary key clustered (FieldID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ϵͳӦ���ֶ�', N'user', N'dbo', N'table', N'sys_Field', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ���ֶ�ID��', N'user', N'dbo', N'table', N'sys_Field', N'column', N'FieldID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ���ֶιؼ���', N'user', N'dbo', N'table', N'sys_Field', N'column', N'F_Key'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ���ֶ�����˵��', N'user', N'dbo', N'table', N'sys_Field', N'column', N'F_CName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����˵��', N'user', N'dbo', N'table', N'sys_Field', N'column', N'F_Remark'
go


/*==============================================================*/
/* Table: sys_FieldValue                                        */
/*==============================================================*/
create table dbo.sys_FieldValue (
   ValueID              int                  identity,
   V_F_Key              varchar(50)          null,
   V_Text               nvarchar(100)        null,
   V_Code               varchar(100)         null,
   V_ShowOrder          int                  not null default 0,
   constraint PK_Sys_FieldValue primary key clustered (ValueID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ���ֶ�ֵ', N'user', N'dbo', N'table', N'sys_FieldValue', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����ID��', N'user', N'dbo', N'table', N'sys_FieldValue', N'column', N'ValueID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��sys_Field����F_Key�ֶι���', N'user', N'dbo', N'table', N'sys_FieldValue', N'column', N'V_F_Key'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����˵��', N'user', N'dbo', N'table', N'sys_FieldValue', N'column', N'V_Text'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'sys_FieldValue', N'column', N'V_Code'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ͬ����ʾ˳��', N'user', N'dbo', N'table', N'sys_FieldValue', N'column', N'V_ShowOrder'
go


/*==============================================================*/
/* Table: sys_Group                                             */
/*==============================================================*/
create table dbo.sys_Group (
   GroupID              int                  identity,
   G_CName              nvarchar(50)         null,
   G_ParentID           int                  not null default 0,
   G_ShowOrder          int                  not null default 0,
   G_Level              int                  null,
   G_ChildCount         int                  null,
   G_Delete             tinyint              null,
   constraint PK_SYS_GROUP primary key clustered (GroupID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'sys_Group', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����ID��', N'user', N'dbo', N'table', N'sys_Group', N'column', N'GroupID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��������˵��', N'user', N'dbo', N'table', N'sys_Group', N'column', N'G_CName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�ϼ�����ID0:Ϊ��߼�', N'user', N'dbo', N'table', N'sys_Group', N'column', N'G_ParentID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ʾ˳��', N'user', N'dbo', N'table', N'sys_Group', N'column', N'G_ShowOrder'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ǰ�������ڲ���', N'user', N'dbo', N'table', N'sys_Group', N'column', N'G_Level'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ǰ�����ӷ�����', N'user', N'dbo', N'table', N'sys_Group', N'column', N'G_ChildCount'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�Ƿ�ɾ��1:��0:��', N'user', N'dbo', N'table', N'sys_Group', N'column', N'G_Delete'
go


/*==============================================================*/
/* Table: sys_Module                                            */
/*==============================================================*/
create table dbo.sys_Module (
   ModuleID             int                  identity,
   M_ApplicationID      int                  not null,
   M_ParentID           int                  not null,
   M_PageCode           varchar(6)           not null,
   M_CName              nvarchar(50)         null,
   M_Directory          nvarchar(255)        null,
   M_OrderLevel         varchar(4)           null,
   M_IsSystem           tinyint              null,
   M_Close              tinyint              null,
   M_Icon               varchar(255)         null,
   constraint PK_Sys_Module primary key clustered (M_PageCode, M_ApplicationID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����ģ��', N'user', N'dbo', N'table', N'sys_Module', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����ģ��ID��', N'user', N'dbo', N'table', N'sys_Module', N'column', N'ModuleID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����Ӧ�ó���ID', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_ApplicationID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��������ģ��ID��ModuleID����,0Ϊ����', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_ParentID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ģ�����ParentΪ0,��ΪS00(xx),����ΪS00M00(xx)', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_PageCode'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ģ��/��Ŀ���Ƶ�ParentIDΪ0Ϊģ������', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_CName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ģ��/��ĿĿ¼��', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_Directory'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ǰ�������򼶱�֧��˫��99���˵�', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_OrderLevel'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�Ƿ�Ϊϵͳģ��1:��0:����Ϊϵͳ���޷��޸�', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_IsSystem'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�Ƿ�ر�1:��0:��', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_Close'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ģ��Icon', N'user', N'dbo', N'table', N'sys_Module', N'column', N'M_Icon'
go


/*==============================================================*/
/* Table: sys_ModuleExtPermission                               */
/*==============================================================*/
create table dbo.sys_ModuleExtPermission (
   ExtPermissionID      int                  identity,
   ModuleID             int                  not null,
   PermissionName       nvarchar(100)        not null,
   PermissionValue      int                  not null,
   constraint PK_SYS_MODULEEXTPERMISSION primary key  (ModuleID, PermissionValue)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ģ����չȨ��', N'user', N'dbo', N'table', N'sys_ModuleExtPermission', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��չȨ��ID', N'user', N'dbo', N'table', N'sys_ModuleExtPermission', N'column', N'ExtPermissionID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ģ��ID', N'user', N'dbo', N'table', N'sys_ModuleExtPermission', N'column', N'ModuleID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ȩ������', N'user', N'dbo', N'table', N'sys_ModuleExtPermission', N'column', N'PermissionName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ȩ��ֵ', N'user', N'dbo', N'table', N'sys_ModuleExtPermission', N'column', N'PermissionValue'
go


/*==============================================================*/
/* Table: sys_Online                                            */
/*==============================================================*/
create table dbo.sys_Online (
   OnlineID             int                  identity,
   O_SessionID          varchar(24)          not null,
   O_UserName           nvarchar(20)         not null,
   O_Ip                 varchar(15)          not null,
   O_LoginTime          datetime             not null,
   O_LastTime           datetime             not null,
   O_LastUrl            nvarchar(500)        not null,
   constraint PK_SYS_ONLINE primary key  (O_SessionID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�����û���', N'user', N'dbo', N'table', N'sys_Online', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�Զ�ID', N'user', N'dbo', N'table', N'sys_Online', N'column', N'OnlineID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û�SessionID', N'user', N'dbo', N'table', N'sys_Online', N'column', N'O_SessionID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û���', N'user', N'dbo', N'table', N'sys_Online', N'column', N'O_UserName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û�IP��ַ', N'user', N'dbo', N'table', N'sys_Online', N'column', N'O_Ip'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��½ʱ��', N'user', N'dbo', N'table', N'sys_Online', N'column', N'O_LoginTime'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'������ʱ��', N'user', N'dbo', N'table', N'sys_Online', N'column', N'O_LastTime'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'���������վ', N'user', N'dbo', N'table', N'sys_Online', N'column', N'O_LastUrl'
go


/*==============================================================*/
/* Table: sys_RoleApplication                                   */
/*==============================================================*/
create table dbo.sys_RoleApplication (
   A_RoleID             int                  not null,
   A_ApplicationID      int                  not null,
   constraint PK_SYS_ROLEAPPLICATION primary key clustered (A_RoleID, A_ApplicationID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫӦ�ñ�', N'user', N'dbo', N'table', N'sys_RoleApplication', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫID��sys_Roles��RoleID���', N'user', N'dbo', N'table', N'sys_RoleApplication', N'column', N'A_RoleID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӧ��ID��sys_Applications��Appl', N'user', N'dbo', N'table', N'sys_RoleApplication', N'column', N'A_ApplicationID'
go


/*==============================================================*/
/* Table: sys_RolePermission                                    */
/*==============================================================*/
create table dbo.sys_RolePermission (
   PermissionID         int                  identity,
   P_RoleID             int                  not null,
   P_ApplicationID      int                  not null,
   P_PageCode           varchar(20)          not null,
   P_Value              int                  null,
   constraint PK_sys_RolePermission primary key clustered (P_RoleID, P_ApplicationID, P_PageCode)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫӦ��Ȩ�ޱ�', N'user', N'dbo', N'table', N'sys_RolePermission', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫӦ��Ȩ���Զ�ID', N'user', N'dbo', N'table', N'sys_RolePermission', N'column', N'PermissionID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫID��sys_Roles����RoleID��', N'user', N'dbo', N'table', N'sys_RolePermission', N'column', N'P_RoleID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫ����Ӧ��ID��sys_Applicatio', N'user', N'dbo', N'table', N'sys_RolePermission', N'column', N'P_ApplicationID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫӦ����ҳ��Ȩ�޴���', N'user', N'dbo', N'table', N'sys_RolePermission', N'column', N'P_PageCode'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ȩ��ֵ', N'user', N'dbo', N'table', N'sys_RolePermission', N'column', N'P_Value'
go


/*==============================================================*/
/* Table: sys_Roles                                             */
/*==============================================================*/
create table dbo.sys_Roles (
   RoleID               int                  identity,
   R_UserID             int                  not null,
   R_RoleName           nvarchar(50)         not null,
   R_Description        nvarchar(255)        null,
   constraint PK_sys_Roles primary key clustered (RoleID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫ��', N'user', N'dbo', N'table', N'sys_Roles', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫID�Զ�ID', N'user', N'dbo', N'table', N'sys_Roles', N'column', N'RoleID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�ǽ������û�ID', N'user', N'dbo', N'table', N'sys_Roles', N'column', N'R_UserID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫ����', N'user', N'dbo', N'table', N'sys_Roles', N'column', N'R_RoleName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ɫ����', N'user', N'dbo', N'table', N'sys_Roles', N'column', N'R_Description'
go


/*==============================================================*/
/* Table: sys_SystemInfo                                        */
/*==============================================================*/
create table dbo.sys_SystemInfo (
   SystemID             int                  identity,
   S_Name               nvarchar(50)         null,
   S_Version            nvarchar(50)         null,
   S_SystemConfigData   image                null,
   S_Licensed           varchar(50)          null,
   constraint PK_SYS_SYSTEMINFO primary key  (SystemID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ϵͳ��Ϣ��', N'user', N'dbo', N'table', N'sys_SystemInfo', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�Զ�ID', N'user', N'dbo', N'table', N'sys_SystemInfo', N'column', N'SystemID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ϵͳ����', N'user', N'dbo', N'table', N'sys_SystemInfo', N'column', N'S_Name'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�汾��', N'user', N'dbo', N'table', N'sys_SystemInfo', N'column', N'S_Version'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ϵͳ������Ϣ', N'user', N'dbo', N'table', N'sys_SystemInfo', N'column', N'S_SystemConfigData'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'���к�', N'user', N'dbo', N'table', N'sys_SystemInfo', N'column', N'S_Licensed'
go


/*==============================================================*/
/* Table: sys_User                                              */
/*==============================================================*/
create table dbo.sys_User (
   UserID               int                  identity,
   U_LoginName          nvarchar(20)         not null,
   U_Password           varchar(32)          not null,
   U_CName              nvarchar(20)         null,
   U_EName              varchar(50)          null,
   U_GroupID            int                  not null,
   U_Email              varchar(100)         null,
   U_Type               tinyint              not null default 1,
   U_Status             tinyint              not null default 1,
   U_Licence            varchar(30)          null,
   U_Mac                varchar(50)          null,
   U_Remark             nvarchar(200)        null,
   U_IDCard             varchar(30)          null,
   U_Sex                tinyint              null,
   U_BirthDay           datetime             null,
   U_MobileNo           varchar(15)          null,
   U_UserNO             varchar(20)          null,
   U_WorkStartDate      datetime             null,
   U_WorkEndDate        datetime             null,
   U_CompanyMail        varchar(255)         null,
   U_Title              int                  null,
   U_Extension          varchar(10)          null,
   U_HomeTel            varchar(20)          null,
   U_PhotoUrl           nvarchar(255)        null,
   U_DateTime           datetime             null,
   U_LastIP             varchar(15)          null,
   U_LastDateTime       datetime             null,
   U_ExtendField        ntext                null,
   constraint PK_Sys_User primary key clustered (UserID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û���', N'user', N'dbo', N'table', N'sys_User', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û�ID��', N'user', N'dbo', N'table', N'sys_User', N'column', N'UserID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��½��', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_LoginName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����md5�����ַ�', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Password'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_CName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ӣ����', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_EName'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����ID����sys_Group����GroupID����', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_GroupID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�����ʼ�', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Email'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û�����0:�����û�1:��ͨ�û�', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Type'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ǰ״̬0:���� 1:��ֹ��½ 2:ɾ��', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Status'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û����к�', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Licence'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��������Ӳ����ַ', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Mac'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ע˵��', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Remark'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'���֤����', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_IDCard'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�Ա�1:��0:Ů', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Sex'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_BirthDay'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�ֻ���', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_MobileNo'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'Ա�����', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_UserNO'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ְ����', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_WorkStartDate'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��ְ����', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_WorkEndDate'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��˾�ʼ���ַ', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_CompanyMail'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'ְ����Ӧ���ֶι���', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Title'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�ֻ���', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_Extension'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'���е绰', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_HomeTel'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û���Ƭ��ַ', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_PhotoUrl'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_DateTime'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'������IP', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_LastIP'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'������ʱ��', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_LastDateTime'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'��չ�ֶ�', N'user', N'dbo', N'table', N'sys_User', N'column', N'U_ExtendField'
go


/*==============================================================*/
/* Table: sys_UserRoles                                         */
/*==============================================================*/
create table dbo.sys_UserRoles (
   R_UserID             int                  not null,
   R_RoleID             int                  not null,
   constraint PK_SYS_USERROLES primary key clustered (R_UserID, R_RoleID)
)
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û���ɫ��', N'user', N'dbo', N'table', N'sys_UserRoles', NULL, NULL
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û�ID��sys_User����UserID���', N'user', N'dbo', N'table', N'sys_UserRoles', N'column', N'R_UserID'
go


EXECUTE sp_addextendedproperty N'MS_Description', N'�û�������ɫID��Sys_Roles����', N'user', N'dbo', N'table', N'sys_UserRoles', N'column', N'R_RoleID'
go


