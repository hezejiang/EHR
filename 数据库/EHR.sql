USE [master]
GO
/****** Object:  Database [EHR]    Script Date: 05/22/2013 00:12:58 ******/
CREATE DATABASE [EHR] ON  PRIMARY 
( NAME = N'EHR', FILENAME = N'E:\数据库\Data\sql2005\EHR.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EHR_log', FILENAME = N'E:\数据库\Data\sql2005\EHR_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EHR] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EHR].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [EHR] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [EHR] SET ANSI_NULLS OFF
GO
ALTER DATABASE [EHR] SET ANSI_PADDING OFF
GO
ALTER DATABASE [EHR] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [EHR] SET ARITHABORT OFF
GO
ALTER DATABASE [EHR] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [EHR] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [EHR] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [EHR] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [EHR] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [EHR] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [EHR] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [EHR] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [EHR] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [EHR] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [EHR] SET  DISABLE_BROKER
GO
ALTER DATABASE [EHR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [EHR] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [EHR] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [EHR] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [EHR] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [EHR] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [EHR] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [EHR] SET  READ_WRITE
GO
ALTER DATABASE [EHR] SET RECOVERY FULL
GO
ALTER DATABASE [EHR] SET  MULTI_USER
GO
ALTER DATABASE [EHR] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [EHR] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'EHR', N'ON'
GO
USE [EHR]
GO
/****** Object:  Table [dbo].[sys_Applications]    Script Date: 05/22/2013 00:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_Applications](
	[ApplicationID] [int] IDENTITY(1,1) NOT NULL,
	[A_AppName] [nvarchar](50) NULL,
	[A_AppDescription] [nvarchar](200) NULL,
	[A_AppUrl] [varchar](50) NULL,
	[A_Order] [int] NULL,
 CONSTRAINT [PK_SYS_APPLICATIONS] PRIMARY KEY NONCLUSTERED 
(
	[ApplicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自动ID 1:为系统管理应用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'ApplicationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_AppName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用介绍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_AppDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用Url地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_AppUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications', @level2type=N'COLUMN',@level2name=N'A_Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Applications'
GO
/****** Object:  StoredProcedure [dbo].[SupesoftPage]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************************************
*      Copyright (C) 2005 141421.com,All Rights Reserved						 *
*      Function:  SuperPaging													 *
*      Description:                                                              *
*             超强通用分页存储过程												 *
*      Author:                                                                   *
*             邱学军(Ryan)                                                       *
*             lifergb@hotmail.com                                                *
*             http://www.141421.com                                              *
*      Finish DateTime:                                                          *
*             2005年9月24日                                                      *
*      History:																	 *
*             2006/4/21 Edit By Michael Li                                       *         
*	   Example:																	 *
*	          SuperPaging @TableName='表名',@Orderfld='排序列名'                 *           
*********************************************************************************/
CREATE PROCEDURE [dbo].[SupesoftPage]
(
	@TableName		nvarchar(50),			-- 表名
	@ReturnFields	nvarchar(2000) = '*',	-- 需要返回的列 
	@PageSize		int = 10,				-- 每页记录数
	@PageIndex		int = 1,				-- 当前页码
	@Where			nvarchar(2000) = '',		-- 查询条件
	@Orderfld		nvarchar(2000),			-- 排序字段名 最好为唯一主键
	@OrderType		int = 1					-- 排序类型 1:降序 其它为升序
	
)
AS
    DECLARE @TotalRecord int
	DECLARE @TotalPage int
	DECLARE @CurrentPageSize int
    DECLARE @TotalRecordForPageIndex int
    DECLARE @OrderBy nvarchar(255)
    DECLARE @CutOrderBy nvarchar(255)
	
	if @OrderType = 1
		BEGIN
			set @OrderBy = ' Order by ' + REPLACE(@Orderfld,',',' desc,') + ' desc '
			set @CutOrderBy = ' Order by '+ REPLACE(@Orderfld,',',' asc,') + ' asc '
		END
	else
		BEGIN
			set @OrderBy = ' Order by ' +  REPLACE(@Orderfld,',',' asc,') + ' asc '
			set @CutOrderBy = ' Order by '+ REPLACE(@Orderfld,',',' desc,') + ' desc '			
		END
	
	
        -- 记录总数
	declare @countSql nvarchar(4000)  
	set @countSql='SELECT @TotalRecord=Count(*) From '+@TableName+' '+@Where
	execute sp_executesql @countSql,N'@TotalRecord int out',@TotalRecord out
	
	SET @TotalPage=(@TotalRecord-1)/@PageSize+1
	SET @CurrentPageSize=@PageSize
        IF(@TotalPage=@PageIndex)
	BEGIN
		SET @CurrentPageSize=@TotalRecord%@PageSize
		IF(@CurrentPageSize=0)
			SET @CurrentPageSize=@PageSize
	END
	-- 返回记录
	set @TotalRecordForPageIndex=@PageIndex*@PageSize
	exec('SELECT * FROM
		(SELECT TOP '+@CurrentPageSize+' * FROM
			(SELECT TOP '+@TotalRecordForPageIndex+' '+@ReturnFields+'
			FROM '+@TableName+' '+@Where+' '+@OrderBy+') TB2
		'+@CutOrderBy+') TB3
              '+@OrderBy)
	-- 返回总页数和总记录数
	SELECT @TotalPage as PageCount,@TotalRecord as RecordCount
GO
/****** Object:  Table [dbo].[supervision_Inspect]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supervision_Inspect](
	[InspectID] [int] IDENTITY(1,1) NOT NULL,
	[I_Location] [nvarchar](100) NOT NULL,
	[I_Type] [tinyint] NOT NULL,
	[I_Date] [datetime] NOT NULL,
	[I_UserID] [int] NOT NULL,
	[I_Conent] [text] NOT NULL,
	[I_MainProblem] [text] NOT NULL,
	[I_Note] [text] NULL,
 CONSTRAINT [PK_supervision_Inspect] PRIMARY KEY CLUSTERED 
(
	[InspectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卫生监管巡查ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'InspectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'巡查时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'巡查人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'寻常内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_Conent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发现的主要问题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_MainProblem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Inspect', @level2type=N'COLUMN',@level2name=N'I_Note'
GO
/****** Object:  Table [dbo].[supervision_Info]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supervision_Info](
	[InfoID] [int] IDENTITY(1,1) NOT NULL,
	[I_FindDate] [datetime] NOT NULL,
	[I_Type] [tinyint] NOT NULL,
	[I_Content] [text] NULL,
	[I_ReportDate] [datetime] NOT NULL,
	[I_ReportUserID] [int] NOT NULL,
 CONSTRAINT [PK_supervision_Info] PRIMARY KEY CLUSTERED 
(
	[InfoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卫生监督信息ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'InfoID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发现时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_FindDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'信息类别，1：食品安全，2：饮用水卫生，3：职业病安全，4：学校卫生，5：非法行医（采供血）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'信息内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_ReportDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'supervision_Info', @level2type=N'COLUMN',@level2name=N'I_ReportUserID'
GO
/****** Object:  Table [dbo].[record_UserBaseInfo]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[record_UserBaseInfo](
	[UserID] [int] NOT NULL,
	[U_Hometown] [nvarchar](255) NOT NULL,
	[U_CurrentAddress] [nvarchar](255) NOT NULL,
	[U_FilingUnits] [int] NOT NULL,
	[U_FilingUserID] [int] NOT NULL,
	[U_ResponsibilityUserID] [int] NOT NULL,
	[U_Committee] [int] NOT NULL,
	[U_FlingTime] [datetime] NOT NULL,
	[U_WorkingUnits] [nvarchar](255) NULL,
	[U_WorkingContactName] [nvarchar](20) NULL,
	[U_WorkingContactTel] [varchar](20) NULL,
	[U_BloodType] [tinyint] NULL,
	[U_NationID] [tinyint] NULL,
	[U_MarriageStatus] [tinyint] NULL,
	[U_PermanentType] [tinyint] NULL,
	[U_Education] [tinyint] NULL,
	[U_PaymentType] [varchar](20) NULL,
	[U_SocialNO] [varchar](30) NULL,
	[U_MedicalNO] [varchar](50) NULL,
	[U_FamilyCode] [varchar](22) NULL,
	[U_RelationShip] [tinyint] NULL,
	[U_AuditStatus] [tinyint] NULL,
 CONSTRAINT [PK_record_BaseInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'户籍地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_Hometown'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'现住址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_CurrentAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档单位（居委会或者是医院部门）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FilingUnits'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档人，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FilingUserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任医生，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_ResponsibilityUserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'居(村)委会' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_Committee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FlingTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_WorkingUnits'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位联系人姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_WorkingContactName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位联系人电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_WorkingContactTel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'血型 1:A型，2:B型，3:AB型，4:O型，0:不详' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_BloodType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族，对应民族表NationID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_NationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'婚姻状态 1:未婚，2:已婚，3:丧偶，4:离婚' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_MarriageStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'常住类型 1:户籍，2:非户籍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_PermanentType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文化程度 0:不详, 1:文盲及半文盲，2:小学，3:中学，4:高中/技校/中专，5:大学专科，6:大学本科，7:研究生及以上' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_Education'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付费类型(可多选，以逗号隔开) 1:城镇职工基本医疗保险，2:城镇居民基本医疗保险，3:贫困扶助，4:新型农村合作医疗，5:商业医疗保险，6:全公费，7:全自费，8:其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_PaymentType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'社保号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_SocialNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医保号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_MedicalNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭编号，与家庭健康档案F_FamilyCode相对应' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_FamilyCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'与户主关系 0:户主 1:父亲 2:母亲 3:儿子 4:儿媳 5:女儿 6:女婿' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_RelationShip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'档案状态，1：正常，2：审核中（迁出迁入需要审核）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_UserBaseInfo', @level2type=N'COLUMN',@level2name=N'U_AuditStatus'
GO
/****** Object:  Table [dbo].[record_MedicationTime]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[record_MedicationTime](
	[MedicationTimeID] [int] IDENTITY(1,1) NOT NULL,
	[M_Time] [varchar](20) NOT NULL,
	[MedicationID] [int] NOT NULL,
 CONSTRAINT [PK_record_MedicationTime] PRIMARY KEY CLUSTERED 
(
	[MedicationTimeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药时间ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_MedicationTime', @level2type=N'COLUMN',@level2name=N'MedicationTimeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'服药时间点（24小时制，如：15:30:00）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_MedicationTime', @level2type=N'COLUMN',@level2name=N'M_Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'与record_Medication表MedicationID相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_MedicationTime', @level2type=N'COLUMN',@level2name=N'MedicationID'
GO
/****** Object:  Table [dbo].[record_Medication]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[record_Medication](
	[MedicationID] [int] NOT NULL,
	[M_ConsultationID] [int] NOT NULL,
	[M_StartDate] [datetime] NOT NULL,
	[M_Status] [tinyint] NULL,
 CONSTRAINT [PK_record_Medication] PRIMARY KEY CLUSTERED 
(
	[MedicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'MedicationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊流水号，与record_Consultation表相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'M_ConsultationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药开始日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'M_StartDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用药状态，1：正在服用，2：已服用完（病人服用完药之后将该提醒取消并同步就说明服用完毕）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Medication', @level2type=N'COLUMN',@level2name=N'M_Status'
GO
/****** Object:  Table [dbo].[record_HealthCheck]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[record_HealthCheck](
	[HealthID] [int] IDENTITY(1,1) NOT NULL,
	[H_BodyTemperature] [float] NULL,
	[H_PulseRate] [tinyint] NULL,
	[H_RespiratoryRate] [tinyint] NULL,
	[H_LeftDiastolic] [tinyint] NULL,
	[H_LeftSystolic] [tinyint] NULL,
	[H_RightDiastolic] [tinyint] NULL,
	[H_RightSystolic] [tinyint] NULL,
	[H_Height] [tinyint] NULL,
	[H_Weight] [tinyint] NULL,
	[H_Result] [text] NULL,
	[H_Suggestion] [text] NULL,
	[H_CheckTime] [datetime] NOT NULL,
	[H_MedicalInstitutions] [int] NOT NULL,
	[H_CheckUserID] [int] NOT NULL,
 CONSTRAINT [PK_record_HealthCheck] PRIMARY KEY CLUSTERED 
(
	[HealthID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康体检ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'HealthID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体温' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_BodyTemperature'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'脉率（次/min）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_PulseRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'呼吸频率（次/min）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_RespiratoryRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'左侧舒张压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_LeftDiastolic'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'左侧收缩压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_LeftSystolic'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'右侧舒张压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_RightDiastolic'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'右侧收缩压(mmHg)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_RightSystolic'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身高（cm）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Height'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体重（kg）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Weight'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检结果' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Result'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检建议' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_Suggestion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_CheckTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检机构，与sys_Group表中的GroupID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_MedicalInstitutions'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体检医生，与sys_User表中的UserID相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_HealthCheck', @level2type=N'COLUMN',@level2name=N'H_CheckUserID'
GO
/****** Object:  Table [dbo].[record_FollowUp]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[record_FollowUp](
	[FollowUpID] [int] IDENTITY(1,1) NOT NULL,
	[F_PatientID] [int] NOT NULL,
	[F_Type] [tinyint] NULL,
	[F_Date] [datetime] NULL,
	[F_Status] [tinyint] NULL,
 CONSTRAINT [PK_record_Work] PRIMARY KEY CLUSTERED 
(
	[FollowUpID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'FollowUpID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'病人ID，与sys_User中的UserID相关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_PatientID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'随访类型，1：高血压，2：糖尿病患者，3：儿童防疫，4：老年人保健' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'下次随访日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'随访状态 1：为完成，2：已完成，3：已到期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FollowUp', @level2type=N'COLUMN',@level2name=N'F_Status'
GO
/****** Object:  Table [dbo].[record_FimaryProblem]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[record_FimaryProblem](
	[F_FimaryCode] [varchar](30) NOT NULL,
	[F_RecordTime] [datetime] NOT NULL,
	[F_StartTime] [datetime] NOT NULL,
	[F_endTime] [datetime] NULL,
	[F_OverviewProblem] [nvarchar](255) NOT NULL,
	[F_DetailProblem] [text] NULL,
	[F_FillingUserID] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭编号，与record_FamilybaseInfo中的F_FimaryCode关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_FimaryCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_RecordTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发生时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_endTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'问题概述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_OverviewProblem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'问题详述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_DetailProblem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档医生' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FimaryProblem', @level2type=N'COLUMN',@level2name=N'F_FillingUserID'
GO
/****** Object:  Table [dbo].[record_FamilyBaseInfo]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[record_FamilyBaseInfo](
	[FimaryID] [int] IDENTITY(1,1) NOT NULL,
	[F_FimaryCode] [varchar](30) NULL,
	[F_UserID] [int] NOT NULL,
	[F_GroupID] [int] NOT NULL,
	[F_FimaryTel] [varchar](20) NULL,
	[F_FimrayAddress] [nvarchar](100) NULL,
	[F_HouseType] [tinyint] NULL,
	[F_HouseArea] [float] NULL,
	[F_Ventilation] [tinyint] NULL,
	[F_Humidity] [tinyint] NULL,
	[F_Warm] [tinyint] NULL,
	[F_Lighting] [tinyint] NULL,
	[F_Sanitation] [tinyint] NULL,
	[F_Kitchen] [tinyint] NULL,
	[F_Fuel] [tinyint] NULL,
	[F_Water] [tinyint] NULL,
	[F_WasteDisposal] [tinyint] NULL,
	[F_LivestockBar] [tinyint] NULL,
	[F_ToiletType] [tinyint] NULL,
	[F_ResponsibilityUserID] [int] NOT NULL,
	[F_FillingUserID] [int] NOT NULL,
 CONSTRAINT [PK_record_FamilyInfo] PRIMARY KEY CLUSTERED 
(
	[FimaryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自增家庭ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'FimaryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭档案编号，由12位居（村）委会行政代码+自增的FimaryID组成' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_FimaryCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'户主，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'村(居)委会ID，与sys_Group表中GroupID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_GroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_FimrayAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'房屋类型 1:砖瓦平房，2:砖瓦楼房，3:土屋，4:茅屋，5:木屋' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_HouseType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'居住面积' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_HouseArea'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'通风 1:好，2:一般，3:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Ventilation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'湿度 1:潮湿，2:干燥，3:一般' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Humidity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保暖 1:好，2:一般，3:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Warm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'采光 1:好，2:一般，3:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Lighting'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卫生 1:清洁，2:一般，3:较脏，4:差' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Sanitation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'厨房 1:合用，2:独用，3:无' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Kitchen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'使用燃料 1：液化气，2：煤气，3:天然气，4:沼气，5:柴火，6:其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Fuel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'饮水来源 1：自来水，2：经净化过滤的水，3：井水，4：河湖水，5：塘水口，6：桶装水，7：其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_Water'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'垃圾处理 1：垃圾处理，2：垃圾箱，3：其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_WasteDisposal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'禽畜栏 1：单设，2：室内，3：室外' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_LivestockBar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'厕所类型 1：家庭卫生厕所：三格式粪池式，2：家庭卫生厕所：双瓮漏斗式，3：家庭卫生厕所：三联沼气池式，4：家庭卫生厕所：粪尿分集式，5：家庭卫生厕所：完整下水道水冲式，6：家庭卫生厕所：双坑交替式，7：非卫生厕所：一格或两格粪池式，8：非卫生厕所：马桶，9：非卫生厕所：露天粪坑，10：非卫生厕所：简易棚厕' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_ToiletType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任人，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_ResponsibilityUserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'建档人，与sys_User表中的UerID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_FamilyBaseInfo', @level2type=N'COLUMN',@level2name=N'F_FillingUserID'
GO
/****** Object:  Table [dbo].[record_DeathRegistration]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[record_DeathRegistration](
	[DeathID] [int] IDENTITY(1,1) NOT NULL,
	[D_DateTime] [datetime] NOT NULL,
	[D_Location] [nvarchar](50) NOT NULL,
	[D_Icd10ID] [int] NULL,
	[D_Note] [text] NULL,
	[D_UserID] [int] NOT NULL,
	[D_RegDate] [datetime] NOT NULL,
 CONSTRAINT [PK_record_DeathRegistration] PRIMARY KEY CLUSTERED 
(
	[DeathID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'疾病icd10编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_Icd10ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'死亡说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_Note'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登记人,与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登记日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_DeathRegistration', @level2type=N'COLUMN',@level2name=N'D_RegDate'
GO
/****** Object:  Table [dbo].[record_Consultation]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[record_Consultation](
	[ConsultationID] [int] IDENTITY(1,1) NOT NULL,
	[C_UserID] [int] NOT NULL,
	[C_Cause] [text] NULL,
	[C_Comments] [text] NULL,
	[C_InstitutionDoctor] [text] NULL,
	[C_Time] [datetime] NOT NULL,
 CONSTRAINT [PK_record_Consultation] PRIMARY KEY CLUSTERED 
(
	[ConsultationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊流水号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'ConsultationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊原因' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_Cause'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊意见' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_Comments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊医生及其所在机构名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_InstitutionDoctor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会诊日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'record_Consultation', @level2type=N'COLUMN',@level2name=N'C_Time'
GO
/****** Object:  Table [dbo].[Nation]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nation](
	[NationID] [int] IDENTITY(1,1) NOT NULL,
	[N_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK__NATION__4924D839] PRIMARY KEY CLUSTERED 
(
	[NationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Nation', @level2type=N'COLUMN',@level2name=N'NationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Nation', @level2type=N'COLUMN',@level2name=N'N_Name'
GO
/****** Object:  Table [dbo].[extend_GeneticDisease]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extend_GeneticDisease](
	[GeneticDiseaseID] [int] IDENTITY(1,1) NOT NULL,
	[GD_Name] [nvarchar](50) NOT NULL,
	[GD_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_GeneticDisease] PRIMARY KEY CLUSTERED 
(
	[GeneticDiseaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'遗传病ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_GeneticDisease', @level2type=N'COLUMN',@level2name=N'GeneticDiseaseID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'遗传病名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_GeneticDisease', @level2type=N'COLUMN',@level2name=N'GD_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_GeneticDisease', @level2type=N'COLUMN',@level2name=N'GD_UserID'
GO
/****** Object:  Table [dbo].[extend_FamilyHistory]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extend_FamilyHistory](
	[FamilyHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[FH_Type] [tinyint] NOT NULL,
	[FH_Who] [tinyint] NOT NULL,
	[FH_Note] [nvarchar](50) NULL,
	[FH_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_FamilyHistory] PRIMARY KEY CLUSTERED 
(
	[FamilyHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家族史ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FamilyHistoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'疾病名称：1 高血压, 2 糖尿病, 3冠心病, 4慢性阻塞性肺疾病, 5恶性肿瘤,6脑卒中, 7中性精神疾病, 8结核病, 9肝炎, 10先天畸形, 11其他+备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭成员角色：1父亲、2母亲、3兄弟姐妹、4儿女' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_Who'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_Note'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_FamilyHistory', @level2type=N'COLUMN',@level2name=N'FH_UserID'
GO
/****** Object:  Table [dbo].[extend_Environment]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extend_Environment](
	[EnvironmentID] [int] IDENTITY(1,1) NOT NULL,
	[E_Kind] [tinyint] NOT NULL,
	[E_Type] [tinyint] NOT NULL,
	[E_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_Environment] PRIMARY KEY CLUSTERED 
(
	[EnvironmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'种类：1 厨房排风设施，2 燃料类型，3 饮水，4 厕所，5 禽畜栏' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Environment', @level2type=N'COLUMN',@level2name=N'E_Kind'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型，和E_Kind一起才能确定：1-1 无，1-2 油烟机,1-3 换气扇，1-4 烟囱；2-1 液化气，2-2 煤气，2-3 天然气，2-4 沼气，2-5 柴火，2-6 其他；3-1 自来水，3-2 经净化过滤的水，3-3 井水，3-4 河湖水，3-5 糖水，3-6 其他；4-1 卫生厕所，4-2 一格或两格粪池式，4-3 马桶，4-4 露天粪坑，4-5 简易棚厕； 5-1 单设，5-2 室内，5-3 室外；' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Environment', @level2type=N'COLUMN',@level2name=N'E_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Environment', @level2type=N'COLUMN',@level2name=N'E_UserID'
GO
/****** Object:  Table [dbo].[extend_DiseaseOther]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extend_DiseaseOther](
	[DiseaseOtherID] [int] IDENTITY(1,1) NOT NULL,
	[DO_Type] [tinyint] NOT NULL,
	[DO_Date] [date] NOT NULL,
	[DO_Name] [nvarchar](50) NOT NULL,
	[DO_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_DiseaseOther] PRIMARY KEY CLUSTERED 
(
	[DiseaseOtherID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型，1 手上, 2 外伤, 3 输血' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseOther', @level2type=N'COLUMN',@level2name=N'DO_UserID'
GO
/****** Object:  Table [dbo].[extend_DiseaseHistory]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extend_DiseaseHistory](
	[DiseaseHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[DH_Type] [tinyint] NOT NULL,
	[DH_DiagnosisDate] [date] NOT NULL,
	[DH_Note] [nvarchar](50) NULL,
	[DH_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_DiseaseHistory] PRIMARY KEY CLUSTERED 
(
	[DiseaseHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'疾病史ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DiseaseHistoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'疾病名称：1 高血压, 2 糖尿病, 3冠心病, 4慢性阻塞性肺疾病, 5恶性肿瘤,6脑卒中, 7中性精神疾病, 8结核病, 9肝炎, 10其他法定传染病+备注, 11其他+备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'确诊日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_DiagnosisDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_Note'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_DiseaseHistory', @level2type=N'COLUMN',@level2name=N'DH_UserID'
GO
/****** Object:  Table [dbo].[extend_Disability]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[extend_Disability](
	[DisabilityID] [int] IDENTITY(1,1) NOT NULL,
	[D_Type] [tinyint] NOT NULL,
	[D_Note] [nvarchar](50) NULL,
	[D_UserID] [int] NOT NULL,
 CONSTRAINT [PK_extend_Disability] PRIMARY KEY CLUSTERED 
(
	[DisabilityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'残疾情况ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'DisabilityID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'残疾类型：0无，1视力残疾，2听力残疾，3言语残疾，4体残疾，5智力残疾，6精神残疾，7其他+备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'D_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'D_Note'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'extend_Disability', @level2type=N'COLUMN',@level2name=N'D_UserID'
GO
/****** Object:  Table [dbo].[education_Prescription]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[education_Prescription](
	[PrescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[P_Object] [money] NOT NULL,
	[P_Name] [nvarchar](100) NOT NULL,
	[P_Content] [text] NULL,
	[P_Doctor] [int] NOT NULL,
	[P_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_education_Prescription] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康处方ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'PrescriptionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康处方对象，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Object'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方医生，，与sys_User表的UserID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Doctor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处方日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Prescription', @level2type=N'COLUMN',@level2name=N'P_Date'
GO
/****** Object:  Table [dbo].[education_Document]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[education_Document](
	[DocumentID] [int] IDENTITY(1,1) NOT NULL,
	[D_Name] [nvarchar](100) NOT NULL,
	[D_Url] [varchar](2038) NULL,
 CONSTRAINT [PK_education_Document] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康知识文档ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Document', @level2type=N'COLUMN',@level2name=N'DocumentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康知识文档名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Document', @level2type=N'COLUMN',@level2name=N'D_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康知识文档地址，最大不超过2038个字符（IE）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Document', @level2type=N'COLUMN',@level2name=N'D_Url'
GO
/****** Object:  Table [dbo].[education_Activity]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[education_Activity](
	[ActivityID] [int] IDENTITY(1,1) NOT NULL,
	[A_DateTime] [datetime] NOT NULL,
	[A_Location] [nvarchar](100) NOT NULL,
	[A_Form] [nvarchar](50) NOT NULL,
	[A_Object] [int] NOT NULL,
	[A_Crowd] [nvarchar](50) NOT NULL,
	[A_Duration] [int] NULL,
	[A_Organizers] [nvarchar](50) NOT NULL,
	[A_Partners] [nvarchar](50) NULL,
	[A_Missionary] [nvarchar](20) NULL,
	[A_Number] [int] NULL,
	[A_Theme] [text] NOT NULL,
 CONSTRAINT [PK_education_Activity] PRIMARY KEY CLUSTERED 
(
	[ActivityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'健康教育活动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'ActivityID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动地点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Location'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动形式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'居委会ID，与sys_Group表的GroupID关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Object'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'参与人群' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Crowd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'持续时间（min）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Duration'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主办单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Organizers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合作伙伴' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Partners'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'宣教人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Missionary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'参与人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'活动主题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'education_Activity', @level2type=N'COLUMN',@level2name=N'A_Theme'
GO
/****** Object:  Table [dbo].[AR_Report]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AR_Report](
	[ReportID] [int] IDENTITY(1,1) NOT NULL,
	[R_Title] [nvarchar](255) NOT NULL,
	[R_Content] [text] NULL,
	[R_DateTime] [datetime] NULL,
	[R_ResponsibilityUserID] [int] NULL,
 CONSTRAINT [PK_AR_Report] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'ReportID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报告时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Report', @level2type=N'COLUMN',@level2name=N'R_ResponsibilityUserID'
GO
/****** Object:  Table [dbo].[AR_Announcement]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AR_Announcement](
	[AnnouncementID] [int] IDENTITY(1,1) NOT NULL,
	[A_Title] [nvarchar](255) NOT NULL,
	[A_Content] [text] NULL,
	[A_DateTime] [datetime] NOT NULL,
	[A_ResponsibilityUserID] [int] NOT NULL,
	[A_Type] [tinyint] NOT NULL,
 CONSTRAINT [PK_AR_Announcement] PRIMARY KEY CLUSTERED 
(
	[AnnouncementID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'AnnouncementID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'责任人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_ResponsibilityUserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告类型，1：普通公告，2：重大疫情公告' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AR_Announcement', @level2type=N'COLUMN',@level2name=N'A_Type'
GO
/****** Object:  Table [dbo].[sys_Event]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[E_U_LoginName] [nvarchar](20) NULL,
	[E_UserID] [int] NULL,
	[E_DateTime] [datetime] NOT NULL,
	[E_ApplicationID] [int] NULL,
	[E_A_AppName] [nvarchar](50) NULL,
	[E_M_Name] [nvarchar](50) NULL,
	[E_M_PageCode] [varchar](6) NULL,
	[E_From] [nvarchar](500) NULL,
	[E_Type] [tinyint] NOT NULL,
	[E_IP] [varchar](15) NULL,
	[E_Record] [nvarchar](500) NULL,
 CONSTRAINT [PK_SYS_EVENT] PRIMARY KEY NONCLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'事件ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'EventID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_U_LoginName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时用户ID与sys_Users中UserID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'事件发生的日期及时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属应用程序ID与sys_Applicatio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_ApplicationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属应用名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_A_AppName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PageCode模块名称与sys_Module相同' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_M_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发生事件时模块名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_M_PageCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_From'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日记类型,1:操作日记2:安全日志3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户端IP地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_IP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'详细描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event', @level2type=N'COLUMN',@level2name=N'E_Record'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统日记表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Event'
GO
/****** Object:  Table [dbo].[sys_Field]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_Field](
	[FieldID] [int] IDENTITY(1,1) NOT NULL,
	[F_Key] [varchar](50) NULL,
	[F_CName] [nvarchar](50) NULL,
	[F_Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_Sys_Field] PRIMARY KEY NONCLUSTERED 
(
	[FieldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'FieldID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段关键字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'F_Key'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段中文说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'F_CName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field', @level2type=N'COLUMN',@level2name=N'F_Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统应用字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Field'
GO
/****** Object:  Table [dbo].[sys_FieldValue]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_FieldValue](
	[ValueID] [int] IDENTITY(1,1) NOT NULL,
	[V_F_Key] [varchar](50) NULL,
	[V_Text] [nvarchar](100) NULL,
	[V_Code] [varchar](100) NULL,
	[V_ShowOrder] [int] NOT NULL,
 CONSTRAINT [PK_Sys_FieldValue] PRIMARY KEY NONCLUSTERED 
(
	[ValueID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'索引ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'ValueID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'与sys_Field表中F_Key字段关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_F_Key'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'中文说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_Text'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'同级显示顺序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue', @level2type=N'COLUMN',@level2name=N'V_ShowOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用字段值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_FieldValue'
GO
/****** Object:  Table [dbo].[sys_Group]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_Group](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[G_CName] [nvarchar](50) NULL,
	[G_ParentID] [int] NOT NULL,
	[G_ShowOrder] [int] NOT NULL,
	[G_Level] [int] NULL,
	[G_ChildCount] [int] NULL,
	[G_Delete] [tinyint] NULL,
	[G_Type] [tinyint] NULL,
	[G_Code] [varchar](20) NULL,
 CONSTRAINT [PK_SYS_GROUP] PRIMARY KEY NONCLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'GroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类中文说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_CName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上级分类ID0:为最高级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_ParentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'显示顺序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_ShowOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前分类所在层数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Level'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当???分类子分类数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_ChildCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除1:是0:否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Delete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门类型，0表示非医院部门，1表示医院部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'行政代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group', @level2type=N'COLUMN',@level2name=N'G_Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Group'
GO
/****** Object:  Table [dbo].[sys_ModuleExtPermission]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_ModuleExtPermission](
	[ExtPermissionID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleID] [int] NOT NULL,
	[PermissionName] [nvarchar](100) NOT NULL,
	[PermissionValue] [int] NOT NULL,
 CONSTRAINT [PK_SYS_MODULEEXTPERMISSION] PRIMARY KEY NONCLUSTERED 
(
	[ModuleID] ASC,
	[PermissionValue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展权限ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'ExtPermissionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'PermissionName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission', @level2type=N'COLUMN',@level2name=N'PermissionValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块扩展权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_ModuleExtPermission'
GO
/****** Object:  Table [dbo].[sys_Module]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_Module](
	[ModuleID] [int] IDENTITY(1,1) NOT NULL,
	[M_ApplicationID] [int] NOT NULL,
	[M_ParentID] [int] NOT NULL,
	[M_PageCode] [varchar](100) NOT NULL,
	[M_CName] [nvarchar](50) NULL,
	[M_Directory] [nvarchar](255) NULL,
	[M_OrderLevel] [varchar](4) NULL,
	[M_IsSystem] [tinyint] NULL,
	[M_Close] [tinyint] NULL,
	[M_Icon] [varchar](255) NULL,
	[M_Info] [nvarchar](500) NULL,
 CONSTRAINT [PK_Sys_Module] PRIMARY KEY NONCLUSTERED 
(
	[M_PageCode] ASC,
	[M_ApplicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能模块ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属应用程序ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_ApplicationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属父级模块ID与ModuleID关联,0为顶级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_ParentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块编码Parent为0,则为S00(xx),否则为S00M00(xx)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_PageCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块/栏目名称当ParentID为0为模块名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_CName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块/栏目???录名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Directory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前所在排序级别支持双层99级菜单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_OrderLevel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否为系统模块1:是0:否如为系统则无法修改' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_IsSystem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否关闭1:是0:否' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Close'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块Icon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Icon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module', @level2type=N'COLUMN',@level2name=N'M_Info'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能模块' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Module'
GO
/****** Object:  Table [dbo].[sys_Online]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_Online](
	[OnlineID] [int] IDENTITY(1,1) NOT NULL,
	[O_SessionID] [varchar](24) NOT NULL,
	[O_UserName] [nvarchar](20) NOT NULL,
	[O_Ip] [varchar](15) NOT NULL,
	[O_LoginTime] [datetime] NOT NULL,
	[O_LastTime] [datetime] NOT NULL,
	[O_LastUrl] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_SYS_ONLINE] PRIMARY KEY NONCLUSTERED 
(
	[O_SessionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'OnlineID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户SessionID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_SessionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户IP地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_Ip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_LoginTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后访问时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_LastTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后请求网站' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online', @level2type=N'COLUMN',@level2name=N'O_LastUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'在线用户表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Online'
GO
/****** Object:  Table [dbo].[sys_RoleApplication]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_RoleApplication](
	[A_RoleID] [int] NOT NULL,
	[A_ApplicationID] [int] NOT NULL,
 CONSTRAINT [PK_SYS_ROLEAPPLICATION] PRIMARY KEY NONCLUSTERED 
(
	[A_RoleID] ASC,
	[A_ApplicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID与sys_Roles中RoleID相关' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RoleApplication', @level2type=N'COLUMN',@level2name=N'A_RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应用ID与sys_Applications中Appl' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RoleApplication', @level2type=N'COLUMN',@level2name=N'A_ApplicationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RoleApplication'
GO
/****** Object:  Table [dbo].[sys_RolePermission]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_RolePermission](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[P_RoleID] [int] NOT NULL,
	[P_ApplicationID] [int] NOT NULL,
	[P_PageCode] [varchar](20) NOT NULL,
	[P_Value] [int] NULL,
 CONSTRAINT [PK_sys_RolePermission] PRIMARY KEY NONCLUSTERED 
(
	[P_RoleID] ASC,
	[P_ApplicationID] ASC,
	[P_PageCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用权限自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'PermissionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID与sys_Roles表中RoleID相' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色所属应用ID与sys_Applicatio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_ApplicationID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用中页面权限代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_PageCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission', @level2type=N'COLUMN',@level2name=N'P_Value'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色应用权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_RolePermission'
GO
/****** Object:  Table [dbo].[sys_Roles]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[R_UserID] [int] NOT NULL,
	[R_RoleName] [nvarchar](50) NOT NULL,
	[R_Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_sys_Roles] PRIMARY KEY NONCLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角角所属用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'R_UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'R_RoleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色介绍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles', @level2type=N'COLUMN',@level2name=N'R_Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_Roles'
GO
/****** Object:  Table [dbo].[sys_SystemInfo]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_SystemInfo](
	[SystemID] [int] IDENTITY(1,1) NOT NULL,
	[S_Name] [nvarchar](50) NULL,
	[S_Version] [nvarchar](50) NULL,
	[S_SystemConfigData] [image] NULL,
	[S_Licensed] [varchar](50) NULL,
 CONSTRAINT [PK_SYS_SYSTEMINFO] PRIMARY KEY NONCLUSTERED 
(
	[SystemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自动ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'SystemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'版本号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_Version'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统配置信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_SystemConfigData'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序列号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo', @level2type=N'COLUMN',@level2name=N'S_Licensed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_SystemInfo'
GO
/****** Object:  Table [dbo].[sys_User]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sys_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[U_LoginName] [nvarchar](20) NULL,
	[U_Password] [varchar](32) NULL,
	[U_CName] [nvarchar](20) NULL,
	[U_EName] [varchar](50) NULL,
	[U_GroupID] [int] NULL,
	[U_Email] [varchar](100) NULL,
	[U_Type] [tinyint] NOT NULL,
	[U_Status] [tinyint] NOT NULL,
	[U_Licence] [varchar](30) NULL,
	[U_Mac] [varchar](50) NULL,
	[U_Remark] [nvarchar](200) NULL,
	[U_IDCard] [varchar](30) NULL,
	[U_Sex] [tinyint] NULL,
	[U_BirthDay] [datetime] NULL,
	[U_MobileNo] [varchar](15) NULL,
	[U_UserNO] [varchar](20) NULL,
	[U_WorkStartDate] [datetime] NULL,
	[U_WorkEndDate] [datetime] NULL,
	[U_CompanyMail] [varchar](255) NULL,
	[U_Title] [int] NULL,
	[U_Extension] [varchar](10) NULL,
	[U_HomeTel] [varchar](20) NULL,
	[U_PhotoUrl] [nvarchar](255) NULL,
	[U_DateTime] [datetime] NULL,
	[U_LastIP] [varchar](15) NULL,
	[U_LastDateTime] [datetime] NULL,
	[U_ExtendField] [ntext] NULL,
	[U_LoginType] [varchar](255) NULL,
	[U_HospitalGroupID] [int] NULL,
 CONSTRAINT [PK_Sys_User] PRIMARY KEY NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LoginName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码md5加密字符' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'中文姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_CName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'英文名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_EName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门ID号与sys_Group表中GroupID关联，这里是选择所在居委会' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_GroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电子邮件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户类型0:超级用户1:普通用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前状态0:正常 1:禁止登陆 2:删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户序列号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Licence'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'锁定机器硬件地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Mac'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_IDCard'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别1:男0:女' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出生日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_BirthDay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_MobileNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_UserNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'到职日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_WorkStartDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'离职日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_WorkEndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司邮件地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_CompanyMail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职称与应用字段关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_Extension'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家中电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_HomeTel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户照片网址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_PhotoUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后访问IP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LastIP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后访问时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LastDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_ExtendField'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登入类型(为空系统认证,其它值为其它认证)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_LoginType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医院部门ID号与sys_Group表中GroupID关联，这里是选择所在医院部门，默认为0，即表示该用户是非医院工作人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User', @level2type=N'COLUMN',@level2name=N'U_HospitalGroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_User'
GO
/****** Object:  Table [dbo].[sys_UserRoles]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_UserRoles](
	[R_UserID] [int] NOT NULL,
	[R_RoleID] [int] NOT NULL,
 CONSTRAINT [PK_SYS_USERROLES] PRIMARY KEY NONCLUSTERED 
(
	[R_UserID] ASC,
	[R_RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID与sys_User表中UserID相关' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_UserRoles', @level2type=N'COLUMN',@level2name=N'R_UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户所属角色ID与Sys_Roles关联' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_UserRoles', @level2type=N'COLUMN',@level2name=N'R_RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_UserRoles'
GO
/****** Object:  StoredProcedure [dbo].[sys_UserRolesInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_UserRolesInsertUpdateDelete]
(	

	@R_UserID	 int = 0,	-- 用户ID与sys_User表中UserID相关
	@R_RoleID	 int = 0,	-- 用户所属角色ID与Sys_Roles关联
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_UserRoles( 
			R_UserID,
			R_RoleID
		) VALUES (	
			@R_UserID,
			@R_RoleID
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_UserRoles SET	
			R_UserID = @R_UserID,
			R_RoleID = @R_RoleID
		WHERE ( R_UserID = @R_UserID and R_RoleID = @R_RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_UserRoles	WHERE ( R_UserID = @R_UserID and R_RoleID = @R_RoleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_UserInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_UserInsertUpdateDelete]
(	

	@UserID	 int = 0,	-- 用户ID号
	@U_LoginName	 nvarchar(20) = '',	-- 登陆名
	@U_Password	 varchar(32) = '',	-- 密码md5加密字符
	@U_CName	 nvarchar(20) = '',	-- 中文姓名
	@U_EName	 varchar(50) = '',	-- 英文名
	@U_GroupID	 int = 0,	-- 部门ID号与sys_Group表中GroupID关联
	@U_Email	 varchar(100) = '',	-- 电子邮件
	@U_Type	 tinyint = 0,	-- 用户类型0:超级用户1:普通用户
	@U_Status	 tinyint = 0,	-- 当前状态0:正常 1:禁止
	@U_Licence	 varchar(30) = '',	-- 用户序列号
	@U_Mac	 varchar(50) = '',	-- 锁定机器硬件地址
	@U_Remark	 nvarchar(200) = '',	-- 备注说明
	@U_IDCard	 varchar(30) = '',	-- 身份证号码
	@U_Sex	 tinyint = 0,	-- 性别1:男0:女
	@U_BirthDay	 datetime = Null,	-- 出生日期
	@U_MobileNo	 varchar(15) = '',	-- 手机号
	@U_UserNO	 varchar(20) = '',	-- 员工编号
	@U_WorkStartDate	 datetime = Null,	-- 到职日期
	@U_WorkEndDate	 datetime = Null,	-- 离职日期
	@U_CompanyMail	 varchar(255) = '',	-- 公司邮件地址
	@U_Title	 int = 0,	-- 职称与应用字段关联
	@U_Extension	 varchar(10) = '',	-- 分机号
	@U_HomeTel	 varchar(20) = '',	-- 家中电话
	@U_PhotoUrl	 nvarchar(255) = '',	-- 用户照片网址
	@U_DateTime	 datetime = Null,	-- 操作时间
	@U_LastIP	 varchar(15) = '',	-- 最后访问IP
	@U_LastDateTime	 datetime = Null,	-- 最后访问时间
	@U_ExtendField	 ntext = '',	-- 扩展字段
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_User( 
			U_LoginName,
			U_Password,
			U_CName,
			U_EName,
			U_GroupID,
			U_Email,
			U_Type,
			U_Status,
			U_Licence,
			U_Mac,
			U_Remark,
			U_IDCard,
			U_Sex,
			U_BirthDay,
			U_MobileNo,
			U_UserNO,
			U_WorkStartDate,
			U_WorkEndDate,
			U_CompanyMail,
			U_Title,
			U_Extension,
			U_HomeTel,
			U_PhotoUrl,
			U_DateTime,
			U_LastIP,
			U_LastDateTime,
			U_ExtendField
		) VALUES (	
			@U_LoginName,
			@U_Password,
			@U_CName,
			@U_EName,
			@U_GroupID,
			@U_Email,
			@U_Type,
			@U_Status,
			@U_Licence,
			@U_Mac,
			@U_Remark,
			@U_IDCard,
			@U_Sex,
			@U_BirthDay,
			@U_MobileNo,
			@U_UserNO,
			@U_WorkStartDate,
			@U_WorkEndDate,
			@U_CompanyMail,
			@U_Title,
			@U_Extension,
			@U_HomeTel,
			@U_PhotoUrl,
			@U_DateTime,
			@U_LastIP,
			@U_LastDateTime,
			@U_ExtendField
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_User SET	
			U_LoginName = @U_LoginName,
			U_Password = @U_Password,
			U_CName = @U_CName,
			U_EName = @U_EName,
			U_GroupID = @U_GroupID,
			U_Email = @U_Email,
			U_Type = @U_Type,
			U_Status = @U_Status,
			U_Licence = @U_Licence,
			U_Mac = @U_Mac,
			U_Remark = @U_Remark,
			U_IDCard = @U_IDCard,
			U_Sex = @U_Sex,
			U_BirthDay = @U_BirthDay,
			U_MobileNo = @U_MobileNo,
			U_UserNO = @U_UserNO,
			U_WorkStartDate = @U_WorkStartDate,
			U_WorkEndDate = @U_WorkEndDate,
			U_CompanyMail = @U_CompanyMail,
			U_Title = @U_Title,
			U_Extension = @U_Extension,
			U_HomeTel = @U_HomeTel,
			U_PhotoUrl = @U_PhotoUrl,
			U_DateTime = @U_DateTime,
			U_LastIP = @U_LastIP,
			U_LastDateTime = @U_LastDateTime,
			U_ExtendField = @U_ExtendField
		WHERE (UserID = @UserID)
		
		SET @ReturnValue = @UserID
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_User	WHERE (UserID = @UserID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_SystemInfoInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_SystemInfoInsertUpdateDelete]
(	

	@SystemID	 int = 0,	-- 自动ID
	@S_Name	 nvarchar(50) = '',	-- 系统名称
	@S_Version	 nvarchar(50) = '',	-- 版本号
	@S_SystemConfigData	 image ,	-- 系统配置信息
	@S_Licensed	 varchar(50) = '',	-- 序列号
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_SystemInfo( 
			S_Name,
			S_Version,
			S_SystemConfigData,
			S_Licensed
		) VALUES (	
			@S_Name,
			@S_Version,
			@S_SystemConfigData,
			@S_Licensed
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_SystemInfo SET	
			S_Name = @S_Name,
			S_Version = @S_Version,
			S_SystemConfigData = @S_SystemConfigData,
			S_Licensed = @S_Licensed
		WHERE (SystemID = @SystemID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_SystemInfo	WHERE (SystemID = @SystemID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_RolesInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE  PROCEDURE [dbo].[sys_RolesInsertUpdateDelete]
(	

	@RoleID	 int = 0,	-- 角色ID自动ID
	@R_UserID	 int = 0,	-- 角角所属用户ID
	@R_RoleName	 nvarchar(50) = '',	-- 角色名称
	@R_Description	 nvarchar(255) = '',	-- 角色介绍
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Roles( 
			R_UserID,
			R_RoleName,
			R_Description
		) VALUES (	
			@R_UserID,
			@R_RoleName,
			@R_Description
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Roles SET	
			R_UserID = @R_UserID,
			R_RoleName = @R_RoleName,
			R_Description = @R_Description
		WHERE (RoleID = @RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Roles	WHERE (RoleID = @RoleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_RolePermissionInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_RolePermissionInsertUpdateDelete]
(	

	@PermissionID	 int = 0,	-- 角色应用权限自动ID
	@P_RoleID	 int = 0,	-- 角色ID与sys_Roles表中RoleID相
	@P_ApplicationID	 int = 0,	-- 角色所属应用ID与sys_Applicatio
	@P_PageCode	 varchar(20) = '',	-- 角色应用中页面权限代码
	@P_Value	 int = 0,	-- 权限值
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_RolePermission( 
			P_RoleID,
			P_ApplicationID,
			P_PageCode,
			P_Value
		) VALUES (	
			@P_RoleID,
			@P_ApplicationID,
			@P_PageCode,
			@P_Value
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_RolePermission SET	
			P_RoleID = @P_RoleID,
			P_ApplicationID = @P_ApplicationID,
			P_PageCode = @P_PageCode,
			P_Value = @P_Value
		WHERE (PermissionID = @PermissionID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_RolePermission	WHERE (PermissionID = @PermissionID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_RoleApplicationInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_RoleApplicationInsertUpdateDelete]
(	

	@A_RoleID	 int = 0,	-- 角色ID与sys_Roles中RoleID相关
	@A_ApplicationID	 int = 0,	-- 应用ID与sys_Applications中Appl
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_RoleApplication( 
			A_RoleID,
			A_ApplicationID
		) VALUES (	
			@A_RoleID,
			@A_ApplicationID
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_RoleApplication SET	
			A_RoleID = @A_RoleID,
			A_ApplicationID = @A_ApplicationID
		WHERE ( A_RoleID= @A_RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_RoleApplication	WHERE ( A_RoleID= @A_RoleID and A_ApplicationID = @A_ApplicationID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_OnlineInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_OnlineInsertUpdateDelete]
(	

	@OnlineID	 int = 0,	-- 自动ID
	@O_SessionID	 varchar(24) = '',	-- 用户SessionID
	@O_UserName	 nvarchar(20) = '',	-- 用户名
	@O_Ip	 varchar(15) = '',	-- 用户IP地址
	@O_LoginTime	 datetime = Null,	-- 登陆时间
	@O_LastTime	 datetime = Null,	-- 最后访问时间
	@O_LastUrl	 nvarchar(500) = '',	-- 最后请求网站
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Online( 
			O_SessionID,
			O_UserName,
			O_Ip,
			O_LoginTime,
			O_LastTime,
			O_LastUrl
		) VALUES (	
			@O_SessionID,
			@O_UserName,
			@O_Ip,
			@O_LoginTime,
			@O_LastTime,
			@O_LastUrl
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Online SET	
			O_SessionID = @O_SessionID,
			O_UserName = @O_UserName,
			O_Ip = @O_Ip,
			O_LoginTime = @O_LoginTime,
			O_LastTime = @O_LastTime,
			O_LastUrl = @O_LastUrl
		WHERE (OnlineID = @OnlineID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Online	WHERE (OnlineID = @OnlineID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_ModuleInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_ModuleInsertUpdateDelete]
(	

	@ModuleID	 int = 0,	-- 功能模块ID号
	@M_ApplicationID	 int = 0,	-- 所属应用程序ID
	@M_ParentID	 int = 0,	-- 所属父级模块ID与ModuleID关联,0为顶级
	@M_PageCode	 varchar(6) = '',	-- 模块编码Parent为0,则为S00(xx),否则为S00M00(xx)
	@M_CName	 nvarchar(50) = '',	-- 模块/栏目名称当ParentID为0为模块名称
	@M_Directory	 nvarchar(255) = '',	-- 模块/栏目目录名
	@M_OrderLevel	 varchar(4) = '',	-- 当前所在排序级别支持双层99级菜单
	@M_IsSystem	 tinyint = 0,	-- 是否为系统模块1:是0:否如为系统则无法修改
	@M_Close	 tinyint = 0,	-- 是否关闭1:是0:否
	@M_Icon		 nvarchar(255) = '', --默认图标
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Module( 
			M_ApplicationID,
			M_ParentID,
			M_PageCode,
			M_CName,
			M_Directory,
			M_OrderLevel,
			M_IsSystem,
			M_Close,
			M_Icon
		) VALUES (	
			@M_ApplicationID,
			@M_ParentID,
			@M_PageCode,
			@M_CName,
			@M_Directory,
			@M_OrderLevel,
			@M_IsSystem,
			@M_Close,
			@M_Icon
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Module SET	
			M_ApplicationID = @M_ApplicationID,
			M_ParentID = @M_ParentID,
			M_PageCode = @M_PageCode,
			M_CName = @M_CName,
			M_Directory = @M_Directory,
			M_OrderLevel = @M_OrderLevel,
			M_IsSystem = @M_IsSystem,
			M_Close = @M_Close,
			M_Icon = @M_Icon
		WHERE (ModuleID = @ModuleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Module	WHERE (ModuleID = @ModuleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]
(	

	@ExtPermissionID	 int = 0,	-- 扩展权限ID
	@ModuleID	 int = 0,	-- 模块ID
	@PermissionName	 nvarchar(100) = '',	-- 权限名称
	@PermissionValue	 int = 0,	-- 权限值
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_ModuleExtPermission( 
			ModuleID,
			PermissionName,
			PermissionValue
		) VALUES (	
			@ModuleID,
			@PermissionName,
			@PermissionValue
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_ModuleExtPermission SET	
			ModuleID = @ModuleID,
			PermissionName = @PermissionName,
			PermissionValue = @PermissionValue
		WHERE (ExtPermissionID = @ExtPermissionID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_ModuleExtPermission	WHERE (ExtPermissionID = @ExtPermissionID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_GroupInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_GroupInsertUpdateDelete]
(	

	@GroupID	 int = 0,	-- 分类ID号
	@G_CName	 nvarchar(50) = '',	-- 分类中文说明
	@G_ParentID	 int = 0,	-- 上级分类ID0:为最高级
	@G_ShowOrder	 int = 0,	-- 显示顺序
	@G_Level	 int = 0,	-- 当前分类所在层数
	@G_ChildCount	 int = 0,	-- 当前分类子分类数
	@G_Delete	 tinyint = 0,	-- 是否删除1:是0:否
	@G_Type	 tinyint = 0,	-- 部门类型，0表示非医院部门，1表示医院部门
	@G_Code	 varchar(20) = '',	-- 行政代码
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Group( 
			G_CName,
			G_ParentID,
			G_ShowOrder,
			G_Level,
			G_ChildCount,
			G_Delete,
			G_Type,
			G_Code
		) VALUES (	
			@G_CName,
			@G_ParentID,
			@G_ShowOrder,
			@G_Level,
			@G_ChildCount,
			@G_Delete,
			@G_Type,
			@G_Code
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Group SET	
			G_CName = @G_CName,
			G_ParentID = @G_ParentID,
			G_ShowOrder = @G_ShowOrder,
			G_Level = @G_Level,
			G_ChildCount = @G_ChildCount,
			G_Delete = @G_Delete,
			G_Type = @G_Type,
			G_Code = @G_Code
		WHERE (GroupID = @GroupID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Group	WHERE (GroupID = @GroupID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_FieldValueInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_FieldValueInsertUpdateDelete]
(	

	@ValueID	 int = 0,	-- 索引ID号
	@V_F_Key	 varchar(50) = '',	-- 与sys_Field表中F_Key字段关联
	@V_Text	 nvarchar(100) = '',	-- 中文说明
	@V_Code	 nvarchar(100) = '',	-- 编码
	@V_ShowOrder	 int = 0,	-- 同级显示顺序
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_FieldValue( 
			V_F_Key,
			V_Text,
			V_Code,
			V_ShowOrder
		) VALUES (	
			@V_F_Key,
			@V_Text,
			@V_Code,
			@V_ShowOrder
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_FieldValue SET	
			V_F_Key = @V_F_Key,
			V_Text = @V_Text,
			V_Code = @V_Code,
			V_ShowOrder = @V_ShowOrder
		WHERE (ValueID = @ValueID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_FieldValue	WHERE (ValueID = @ValueID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_FieldInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_FieldInsertUpdateDelete]
(	

	@FieldID	 int = 0,	-- 应用字段ID号
	@F_Key	 varchar(50) = '',	-- 应用字段关键字
	@F_CName	 nvarchar(50) = '',	-- 应用字段中文说明
	@F_Remark	 nvarchar(200) = '',	-- 描述说明
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Field( 
			F_Key,
			F_CName,
			F_Remark
		) VALUES (	
			@F_Key,
			@F_CName,
			@F_Remark
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Field SET	
			F_Key = @F_Key,
			F_CName = @F_CName,
			F_Remark = @F_Remark
		WHERE (FieldID = @FieldID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Field	WHERE (FieldID = @FieldID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_EventInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_EventInsertUpdateDelete]
(	

	@EventID	 int = 0,	-- 事件ID号
	@E_U_LoginName	 nvarchar(20) = '',	-- 用户名
	@E_UserID	 int = 0,	-- 操作时用户ID与sys_Users中UserID
	@E_DateTime	 datetime = Null,	-- 事件发生的日期及时间
	@E_ApplicationID	 int = 0,	-- 所属应用程序ID与sys_Applicatio
	@E_A_AppName	 nvarchar(50) = '',	-- 所属应用名称
	@E_M_Name	 nvarchar(50) = '',	-- PageCode模块名称与sys_Module相同
	@E_M_PageCode	 varchar(6) = '',	-- 发生事件时模块名称
	@E_From	 nvarchar(500) = '',	-- 来源
	@E_Type	 tinyint = 0,	-- 日记类型,1:操作日记2:安全日志3
	@E_IP	 varchar(15) = '',	-- 客户端IP地址
	@E_Record	 nvarchar(500) = '',	-- 详细描述
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Event( 
			E_U_LoginName,
			E_UserID,
			E_DateTime,
			E_ApplicationID,
			E_A_AppName,
			E_M_Name,
			E_M_PageCode,
			E_From,
			E_Type,
			E_IP,
			E_Record
		) VALUES (	
			@E_U_LoginName,
			@E_UserID,
			@E_DateTime,
			@E_ApplicationID,
			@E_A_AppName,
			@E_M_Name,
			@E_M_PageCode,
			@E_From,
			@E_Type,
			@E_IP,
			@E_Record
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Event SET	
			E_U_LoginName = @E_U_LoginName,
			E_UserID = @E_UserID,
			E_DateTime = @E_DateTime,
			E_ApplicationID = @E_ApplicationID,
			E_A_AppName = @E_A_AppName,
			E_M_Name = @E_M_Name,
			E_M_PageCode = @E_M_PageCode,
			E_From = @E_From,
			E_Type = @E_Type,
			E_IP = @E_IP,
			E_Record = @E_Record
		WHERE (EventID = @EventID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Event	WHERE (EventID = @EventID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  StoredProcedure [dbo].[sys_ApplicationsInsertUpdateDelete]    Script Date: 05/22/2013 00:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 创建更新删除
CREATE PROCEDURE [dbo].[sys_ApplicationsInsertUpdateDelete]
(	

	@ApplicationID	 int = 0,	-- 自动ID 1:为系统管理应用
	@A_AppName	 nvarchar(50) = '',	-- 应用名称
	@A_AppDescription	 nvarchar(200) = '',	-- 应用介绍
	@A_AppUrl	 varchar(50) = '',	-- 应用Url地址
	@DB_Option_Action_  nvarchar(20) = ''		-- 操作方法 Insert:增加 Update:修改 Delete:删除 
)
AS
	DECLARE @ReturnValue int -- 返回操作结果
	
	SET @ReturnValue = -1
	
	-- 新增
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Applications( 
			A_AppName,
			A_AppDescription,
			A_AppUrl
		) VALUES (	
			@A_AppName,
			@A_AppDescription,
			@A_AppUrl
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 更新
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Applications SET	
			A_AppName = @A_AppName,
			A_AppDescription = @A_AppDescription,
			A_AppUrl = @A_AppUrl
		WHERE (ApplicationID = @ApplicationID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Applications	WHERE (ApplicationID = @ApplicationID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
GO
/****** Object:  Default [DF_supervision_Inspect_I_Note]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[supervision_Inspect] ADD  CONSTRAINT [DF_supervision_Inspect_I_Note]  DEFAULT ('') FOR [I_Note]
GO
/****** Object:  Default [DF_supervision_Info_I_Content]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[supervision_Info] ADD  CONSTRAINT [DF_supervision_Info_I_Content]  DEFAULT ('') FOR [I_Content]
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingUnits]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_WorkingUnits]  DEFAULT ('') FOR [U_WorkingUnits]
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingContactName]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_WorkingContactName]  DEFAULT ('') FOR [U_WorkingContactName]
GO
/****** Object:  Default [DF_record_BaseInfo_B_WorkingContactPhone]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_WorkingContactPhone]  DEFAULT ('') FOR [U_WorkingContactTel]
GO
/****** Object:  Default [DF_record_BaseInfo_B_BloodType]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_BloodType]  DEFAULT ((0)) FOR [U_BloodType]
GO
/****** Object:  Default [DF_record_BaseInfo_B_MarriageStatus]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_MarriageStatus]  DEFAULT ((0)) FOR [U_MarriageStatus]
GO
/****** Object:  Default [DF_record_BaseInfo_B_PermanentType]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_PermanentType]  DEFAULT ((0)) FOR [U_PermanentType]
GO
/****** Object:  Default [DF_record_BaseInfo_B_Education]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_Education]  DEFAULT ((0)) FOR [U_Education]
GO
/****** Object:  Default [DF_record_BaseInfo_B_PaymentType]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_PaymentType]  DEFAULT ('') FOR [U_PaymentType]
GO
/****** Object:  Default [DF_record_BaseInfo_B_SocialSecurityNO]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_SocialSecurityNO]  DEFAULT ('') FOR [U_SocialNO]
GO
/****** Object:  Default [DF_record_BaseInfo_B_FamilyNO]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_UserBaseInfo] ADD  CONSTRAINT [DF_record_BaseInfo_B_FamilyNO]  DEFAULT ((0)) FOR [U_FamilyCode]
GO
/****** Object:  Default [DF_record_Medication_MedicationID]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_Medication] ADD  CONSTRAINT [DF_record_Medication_MedicationID]  DEFAULT ((0)) FOR [MedicationID]
GO
/****** Object:  Default [DF_record_HealthCheck_H_BodyTemperature]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_BodyTemperature]  DEFAULT ((0)) FOR [H_BodyTemperature]
GO
/****** Object:  Default [DF_record_HealthCheck_H_PulseRate]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_PulseRate]  DEFAULT ((0)) FOR [H_PulseRate]
GO
/****** Object:  Default [DF_record_HealthCheck_H_RespiratoryRate]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_RespiratoryRate]  DEFAULT ((0)) FOR [H_RespiratoryRate]
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftDiastolicBloodPressure]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftDiastolicBloodPressure]  DEFAULT ((0)) FOR [H_LeftDiastolic]
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftSystolic]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftSystolic]  DEFAULT ((0)) FOR [H_LeftSystolic]
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftDiastolic1]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftDiastolic1]  DEFAULT ((0)) FOR [H_RightDiastolic]
GO
/****** Object:  Default [DF_record_HealthCheck_H_LeftSystolic1]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_LeftSystolic1]  DEFAULT ((0)) FOR [H_RightSystolic]
GO
/****** Object:  Default [DF_record_HealthCheck_H_Height]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Height]  DEFAULT ((0)) FOR [H_Height]
GO
/****** Object:  Default [DF_record_HealthCheck_H_Weight]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Weight]  DEFAULT ((0)) FOR [H_Weight]
GO
/****** Object:  Default [DF_record_HealthCheck_H_Result]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Result]  DEFAULT ('') FOR [H_Result]
GO
/****** Object:  Default [DF_record_HealthCheck_H_Suggestion]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_HealthCheck] ADD  CONSTRAINT [DF_record_HealthCheck_H_Suggestion]  DEFAULT ('') FOR [H_Suggestion]
GO
/****** Object:  Default [DF_record_FollowUp_F_PatientID]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FollowUp] ADD  CONSTRAINT [DF_record_FollowUp_F_PatientID]  DEFAULT ((0)) FOR [F_PatientID]
GO
/****** Object:  Default [DF_record_FollowUp_F_Status]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FollowUp] ADD  CONSTRAINT [DF_record_FollowUp_F_Status]  DEFAULT ((0)) FOR [F_Status]
GO
/****** Object:  Default [DF_record_Family_F_FimaryTel]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_FimaryTel]  DEFAULT ('') FOR [F_FimaryTel]
GO
/****** Object:  Default [DF_record_Family_F_FimrayAddress]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_FimrayAddress]  DEFAULT ('') FOR [F_FimrayAddress]
GO
/****** Object:  Default [DF_record_Family_F_HouseType]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_HouseType]  DEFAULT ((0)) FOR [F_HouseType]
GO
/****** Object:  Default [DF_record_Family_F_HouseArea]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_HouseArea]  DEFAULT ((0)) FOR [F_HouseArea]
GO
/****** Object:  Default [DF_record_Family_F_Ventilation]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Ventilation]  DEFAULT ((0)) FOR [F_Ventilation]
GO
/****** Object:  Default [DF_record_Family_F_Humidity]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Humidity]  DEFAULT ((0)) FOR [F_Humidity]
GO
/****** Object:  Default [DF_record_Family_F_Warm]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Warm]  DEFAULT ((0)) FOR [F_Warm]
GO
/****** Object:  Default [DF_record_Family_Lighting]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_Lighting]  DEFAULT ((0)) FOR [F_Lighting]
GO
/****** Object:  Default [DF_record_Family_F_Sanitation]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Sanitation]  DEFAULT ((0)) FOR [F_Sanitation]
GO
/****** Object:  Default [DF_record_Family_F_Kitchen]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Kitchen]  DEFAULT ((0)) FOR [F_Kitchen]
GO
/****** Object:  Default [DF_record_Family_F_Fuel]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Fuel]  DEFAULT ((0)) FOR [F_Fuel]
GO
/****** Object:  Default [DF_record_Family_F_Water]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_Water]  DEFAULT ((0)) FOR [F_Water]
GO
/****** Object:  Default [DF_record_Family_F_WasteDisposal]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_WasteDisposal]  DEFAULT ((0)) FOR [F_WasteDisposal]
GO
/****** Object:  Default [DF_record_Family_F_LivestockBar]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_LivestockBar]  DEFAULT ((0)) FOR [F_LivestockBar]
GO
/****** Object:  Default [DF_record_Family_F_ToiletType]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_FamilyBaseInfo] ADD  CONSTRAINT [DF_record_Family_F_ToiletType]  DEFAULT ((0)) FOR [F_ToiletType]
GO
/****** Object:  Default [DF_record_DeathRegistration_D_Icd10ID]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_DeathRegistration] ADD  CONSTRAINT [DF_record_DeathRegistration_D_Icd10ID]  DEFAULT ((0)) FOR [D_Icd10ID]
GO
/****** Object:  Default [DF_record_DeathRegistration_D_Note]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_DeathRegistration] ADD  CONSTRAINT [DF_record_DeathRegistration_D_Note]  DEFAULT ('') FOR [D_Note]
GO
/****** Object:  Default [DF_record_DeathRegistration_D_UserID]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_DeathRegistration] ADD  CONSTRAINT [DF_record_DeathRegistration_D_UserID]  DEFAULT ((0)) FOR [D_UserID]
GO
/****** Object:  Default [DF_record_Consultation_C_Cause]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_Consultation] ADD  CONSTRAINT [DF_record_Consultation_C_Cause]  DEFAULT ('') FOR [C_Cause]
GO
/****** Object:  Default [DF_record_Consultation_C_Comments]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_Consultation] ADD  CONSTRAINT [DF_record_Consultation_C_Comments]  DEFAULT ('') FOR [C_Comments]
GO
/****** Object:  Default [DF_record_Consultation_C_InstitutionDoctor]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[record_Consultation] ADD  CONSTRAINT [DF_record_Consultation_C_InstitutionDoctor]  DEFAULT ('') FOR [C_InstitutionDoctor]
GO
/****** Object:  Default [DF_extend_FamilyHistory_DH_Note]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[extend_FamilyHistory] ADD  CONSTRAINT [DF_extend_FamilyHistory_DH_Note]  DEFAULT ('') FOR [FH_Note]
GO
/****** Object:  Default [DF_extend_DiseaseHistory_D_Note]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[extend_DiseaseHistory] ADD  CONSTRAINT [DF_extend_DiseaseHistory_D_Note]  DEFAULT ('') FOR [DH_Note]
GO
/****** Object:  Default [DF_extend_Disability_D_Note]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[extend_Disability] ADD  CONSTRAINT [DF_extend_Disability_D_Note]  DEFAULT ('') FOR [D_Note]
GO
/****** Object:  Default [DF_education_Prescription_P_Content]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[education_Prescription] ADD  CONSTRAINT [DF_education_Prescription_P_Content]  DEFAULT ('') FOR [P_Content]
GO
/****** Object:  Default [DF_education_Activity_A_Duration]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Duration]  DEFAULT ((0)) FOR [A_Duration]
GO
/****** Object:  Default [DF_education_Activity_A_Partners]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Partners]  DEFAULT ('') FOR [A_Partners]
GO
/****** Object:  Default [DF_education_Activity_A_Missionary]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Missionary]  DEFAULT ('') FOR [A_Missionary]
GO
/****** Object:  Default [DF_education_Activity_A_Number]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[education_Activity] ADD  CONSTRAINT [DF_education_Activity_A_Number]  DEFAULT ((0)) FOR [A_Number]
GO
/****** Object:  Default [DF_AR_Report_R_Detail]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[AR_Report] ADD  CONSTRAINT [DF_AR_Report_R_Detail]  DEFAULT ('') FOR [R_Content]
GO
/****** Object:  Default [DF_AR_Announcement_A_Title]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[AR_Announcement] ADD  CONSTRAINT [DF_AR_Announcement_A_Title]  DEFAULT ('') FOR [A_Title]
GO
/****** Object:  Default [DF_AR_Announcement_A_Detail]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[AR_Announcement] ADD  CONSTRAINT [DF_AR_Announcement_A_Detail]  DEFAULT ('') FOR [A_Content]
GO
/****** Object:  Default [DF__sys_Event__E_Dat__7F60ED59]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_Event] ADD  DEFAULT (getdate()) FOR [E_DateTime]
GO
/****** Object:  Default [DF__sys_Event__E_Typ__00551192]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_Event] ADD  DEFAULT ((1)) FOR [E_Type]
GO
/****** Object:  Default [DF__sys_Field__V_Sho__0519C6AF]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_FieldValue] ADD  DEFAULT ((0)) FOR [V_ShowOrder]
GO
/****** Object:  Default [DF__sys_Group__G_Par__07F6335A]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_Group] ADD  DEFAULT ((0)) FOR [G_ParentID]
GO
/****** Object:  Default [DF__sys_Group__G_Sho__08EA5793]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_Group] ADD  DEFAULT ((0)) FOR [G_ShowOrder]
GO
/****** Object:  Default [DF_sys_Group_G_Type]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_Group] ADD  CONSTRAINT [DF_sys_Group_G_Type]  DEFAULT ((0)) FOR [G_Type]
GO
/****** Object:  Default [DF_sys_Group_G_Code]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_Group] ADD  CONSTRAINT [DF_sys_Group_G_Code]  DEFAULT ('') FOR [G_Code]
GO
/****** Object:  Default [DF__sys_User__U_Type__1920BF5C]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF__sys_User__U_Type__1920BF5C]  DEFAULT ((1)) FOR [U_Type]
GO
/****** Object:  Default [DF__sys_User__U_Stat__1A14E395]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF__sys_User__U_Stat__1A14E395]  DEFAULT ((1)) FOR [U_Status]
GO
/****** Object:  Default [DF_sys_User_U_HospitalGroupID]    Script Date: 05/22/2013 00:13:06 ******/
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF_sys_User_U_HospitalGroupID]  DEFAULT ((0)) FOR [U_HospitalGroupID]
GO
