if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SupesoftPage]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SupesoftPage]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_ApplicationsInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_ApplicationsInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_EventInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_EventInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_FieldInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_FieldInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_FieldValueInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_FieldValueInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_GroupInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_GroupInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_ModuleInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_ModuleInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_OnlineInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_OnlineInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_RoleApplicationInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_RoleApplicationInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_RolePermissionInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_RolePermissionInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_RolesInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_RolesInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_SystemInfoInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_SystemInfoInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_UserInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_UserInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_UserRolesInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_UserRolesInsertUpdateDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_ModuleExtPermissionInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]
GO


SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





/*********************************************************************************
*      Copyright (C) 2005 141421.com,All Rights Reserved						 *
*      Function:  SuperPaging													 *
*      Description:                                                              *
*             ��ǿͨ�÷�ҳ�洢����												 *
*      Author:                                                                   *
*             ��ѧ��(Ryan)                                                       *
*             lifergb@hotmail.com                                                *
*             http://www.141421.com                                              *
*      Finish DateTime:                                                          *
*             2005��9��24��                                                      *
*      History:																	 *
*             2006/4/21 Edit By Michael Li                                       *         
*	   Example:																	 *
*	          SuperPaging @TableName='����',@Orderfld='��������'                 *           
*********************************************************************************/
CREATE PROCEDURE SupesoftPage
(
	@TableName		nvarchar(50),			-- ����
	@ReturnFields	nvarchar(2000) = '*',	-- ��Ҫ���ص��� 
	@PageSize		int = 10,				-- ÿҳ��¼��
	@PageIndex		int = 1,				-- ��ǰҳ��
	@Where			nvarchar(2000) = '',		-- ��ѯ����
	@Orderfld		nvarchar(2000),			-- �����ֶ��� ���ΪΨһ����
	@OrderType		int = 1					-- �������� 1:���� ����Ϊ����
	
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
	
	
        -- ��¼����
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
	-- ���ؼ�¼
	set @TotalRecordForPageIndex=@PageIndex*@PageSize
	exec('SELECT * FROM
		(SELECT TOP '+@CurrentPageSize+' * FROM
			(SELECT TOP '+@TotalRecordForPageIndex+' '+@ReturnFields+'
			FROM '+@TableName+' '+@Where+' '+@OrderBy+') TB2
		'+@CutOrderBy+') TB3
              '+@OrderBy)
	-- ������ҳ�����ܼ�¼��
	SELECT @TotalPage as PageCount,@TotalRecord as RecordCount




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



-- ��������ɾ��
CREATE PROCEDURE sys_ApplicationsInsertUpdateDelete
(	

	@ApplicationID	 int = 0,	-- �Զ�ID 1:Ϊϵͳ����Ӧ��
	@A_AppName	 nvarchar(50) = '',	-- Ӧ������
	@A_AppDescription	 nvarchar(200) = '',	-- Ӧ�ý���
	@A_AppUrl	 varchar(50) = '',	-- Ӧ��Url��ַ
	@A_Order	 int = 0,	-- Ӧ������
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Applications( 
			A_AppName,
			A_AppDescription,
			A_AppUrl,
			A_Order
		) VALUES (	
			@A_AppName,
			@A_AppDescription,
			@A_AppUrl,
			@A_Order
		)
		SET @ReturnValue = @@IDENTITY
	END
	
	-- ����
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Applications SET	
			A_AppName = @A_AppName,
			A_AppDescription = @A_AppDescription,
			A_AppUrl = @A_AppUrl,
			A_Order = @A_Order
		WHERE (ApplicationID = @ApplicationID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Applications	WHERE (ApplicationID = @ApplicationID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_EventInsertUpdateDelete
(	

	@EventID	 int = 0,	-- �¼�ID��
	@E_U_LoginName	 nvarchar(20) = '',	-- �û���
	@E_UserID	 int = 0,	-- ����ʱ�û�ID��sys_Users��UserID
	@E_DateTime	 datetime = Null,	-- �¼����������ڼ�ʱ��
	@E_ApplicationID	 int = 0,	-- ����Ӧ�ó���ID��sys_Applicatio
	@E_A_AppName	 nvarchar(50) = '',	-- ����Ӧ������
	@E_M_Name	 nvarchar(50) = '',	-- PageCodeģ��������sys_Module��ͬ
	@E_M_PageCode	 varchar(6) = '',	-- �����¼�ʱģ������
	@E_From	 nvarchar(500) = '',	-- ��Դ
	@E_Type	 tinyint = 0,	-- �ռ�����,1:�����ռ�2:��ȫ��־3
	@E_IP	 varchar(15) = '',	-- �ͻ���IP��ַ
	@E_Record	 nvarchar(500) = '',	-- ��ϸ����
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
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
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Event	WHERE (EventID = @EventID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_FieldInsertUpdateDelete
(	

	@FieldID	 int = 0,	-- Ӧ���ֶ�ID��
	@F_Key	 varchar(50) = '',	-- Ӧ���ֶιؼ���
	@F_CName	 nvarchar(50) = '',	-- Ӧ���ֶ�����˵��
	@F_Remark	 nvarchar(200) = '',	-- ����˵��
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Field SET	
			F_Key = @F_Key,
			F_CName = @F_CName,
			F_Remark = @F_Remark
		WHERE (FieldID = @FieldID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Field	WHERE (FieldID = @FieldID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_FieldValueInsertUpdateDelete
(	

	@ValueID	 int = 0,	-- ����ID��
	@V_F_Key	 varchar(50) = '',	-- ��sys_Field����F_Key�ֶι���
	@V_Text	 nvarchar(100) = '',	-- ����˵��
	@V_Code	 nvarchar(100) = '',	-- ����
	@V_ShowOrder	 int = 0,	-- ͬ����ʾ˳��
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
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
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_FieldValue	WHERE (ValueID = @ValueID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_GroupInsertUpdateDelete
(	

	@GroupID	 int = 0,	-- ����ID��
	@G_CName	 nvarchar(50) = '',	-- ��������˵��
	@G_ParentID	 int = 0,	-- �ϼ�����ID0:Ϊ��߼�
	@G_ShowOrder	 int = 0,	-- ��ʾ˳��
	@G_Level	 int = 0,	-- ��ǰ�������ڲ���
	@G_ChildCount	 int = 0,	-- ��ǰ�����ӷ�����
	@G_Delete	 tinyint = 0,	-- �Ƿ�ɾ��1:��0:��
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
	IF (@DB_Option_Action_='Insert')
	BEGIN
		INSERT INTO sys_Group( 
			G_CName,
			G_ParentID,
			G_ShowOrder,
			G_Level,
			G_ChildCount,
			G_Delete
		) VALUES (	
			@G_CName,
			@G_ParentID,
			@G_ShowOrder,
			@G_Level,
			@G_ChildCount,
			@G_Delete
		)
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ����
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Group SET	
			G_CName = @G_CName,
			G_ParentID = @G_ParentID,
			G_ShowOrder = @G_ShowOrder,
			G_Level = @G_Level,
			G_ChildCount = @G_ChildCount,
			G_Delete = @G_Delete
		WHERE (GroupID = @GroupID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Group	WHERE (GroupID = @GroupID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

-- ��������ɾ��
CREATE PROCEDURE sys_ModuleInsertUpdateDelete
(	

	@ModuleID	 int = 0,	-- ����ģ��ID��
	@M_ApplicationID	 int = 0,	-- ����Ӧ�ó���ID
	@M_ParentID	 int = 0,	-- ��������ģ��ID��ModuleID����,0Ϊ����
	@M_PageCode	 varchar(6) = '',	-- ģ�����ParentΪ0,��ΪS00(xx),����ΪS00M00(xx)
	@M_CName	 nvarchar(50) = '',	-- ģ��/��Ŀ���Ƶ�ParentIDΪ0Ϊģ������
	@M_Directory	 nvarchar(255) = '',	-- ģ��/��ĿĿ¼��
	@M_OrderLevel	 varchar(4) = '',	-- ��ǰ�������򼶱�֧��˫��99���˵�
	@M_IsSystem	 tinyint = 0,	-- �Ƿ�Ϊϵͳģ��1:��0:����Ϊϵͳ���޷��޸�
	@M_Close	 tinyint = 0,	-- �Ƿ�ر�1:��0:��
	@M_Icon		 nvarchar(255) = '', --Ĭ��ͼ��
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
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
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Module	WHERE (ModuleID = @ModuleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

-- ��������ɾ��
CREATE PROCEDURE sys_OnlineInsertUpdateDelete
(	

	@OnlineID	 int = 0,	-- �Զ�ID
	@O_SessionID	 varchar(24) = '',	-- �û�SessionID
	@O_UserName	 nvarchar(20) = '',	-- �û���
	@O_Ip	 varchar(15) = '',	-- �û�IP��ַ
	@O_LoginTime	 datetime = Null,	-- ��½ʱ��
	@O_LastTime	 datetime = Null,	-- ������ʱ��
	@O_LastUrl	 nvarchar(500) = '',	-- ���������վ
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
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
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Online	WHERE (OnlineID = @OnlineID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_RoleApplicationInsertUpdateDelete
(	

	@A_RoleID	 int = 0,	-- ��ɫID��sys_Roles��RoleID���
	@A_ApplicationID	 int = 0,	-- Ӧ��ID��sys_Applications��Appl
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_RoleApplication SET	
			A_RoleID = @A_RoleID,
			A_ApplicationID = @A_ApplicationID
		WHERE ( A_RoleID= @A_RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_RoleApplication	WHERE ( A_RoleID= @A_RoleID and A_ApplicationID = @A_ApplicationID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_RolePermissionInsertUpdateDelete
(	

	@PermissionID	 int = 0,	-- ��ɫӦ��Ȩ���Զ�ID
	@P_RoleID	 int = 0,	-- ��ɫID��sys_Roles����RoleID��
	@P_ApplicationID	 int = 0,	-- ��ɫ����Ӧ��ID��sys_Applicatio
	@P_PageCode	 varchar(20) = '',	-- ��ɫӦ����ҳ��Ȩ�޴���
	@P_Value	 int = 0,	-- Ȩ��ֵ
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
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
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_RolePermission	WHERE (PermissionID = @PermissionID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






-- ��������ɾ��
CREATE  PROCEDURE sys_RolesInsertUpdateDelete
(	

	@RoleID	 int = 0,	-- ��ɫID�Զ�ID
	@R_UserID	 int = 0,	-- �ǽ������û�ID
	@R_RoleName	 nvarchar(50) = '',	-- ��ɫ����
	@R_Description	 nvarchar(255) = '',	-- ��ɫ����
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_Roles SET	
			R_UserID = @R_UserID,
			R_RoleName = @R_RoleName,
			R_Description = @R_Description
		WHERE (RoleID = @RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Roles	WHERE (RoleID = @RoleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


-- ��������ɾ��
CREATE PROCEDURE sys_SystemInfoInsertUpdateDelete
(	

	@SystemID	 int = 0,	-- �Զ�ID
	@S_Name	 nvarchar(50) = '',	-- ϵͳ����
	@S_Version	 nvarchar(50) = '',	-- �汾��
	@S_SystemConfigData	 image ,	-- ϵͳ������Ϣ
	@S_Licensed	 varchar(50) = '',	-- ���к�
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
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
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_SystemInfo	WHERE (SystemID = @SystemID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_UserInsertUpdateDelete
(	

	@UserID	 int = 0,	-- �û�ID��
	@U_LoginName	 nvarchar(20) = '',	-- ��½��
	@U_Password	 varchar(32) = '',	-- ����md5�����ַ�
	@U_CName	 nvarchar(20) = '',	-- ��������
	@U_EName	 varchar(50) = '',	-- Ӣ����
	@U_GroupID	 int = 0,	-- ����ID����sys_Group����GroupID����
	@U_Email	 varchar(100) = '',	-- �����ʼ�
	@U_Type	 tinyint = 0,	-- �û�����0:�����û�1:��ͨ�û�
	@U_Status	 tinyint = 0,	-- ��ǰ״̬0:���� 1:��ֹ
	@U_Licence	 varchar(30) = '',	-- �û����к�
	@U_Mac	 varchar(50) = '',	-- ��������Ӳ����ַ
	@U_Remark	 nvarchar(200) = '',	-- ��ע˵��
	@U_IDCard	 varchar(30) = '',	-- ���֤����
	@U_Sex	 tinyint = 0,	-- �Ա�1:��0:Ů
	@U_BirthDay	 datetime = Null,	-- ��������
	@U_MobileNo	 varchar(15) = '',	-- �ֻ���
	@U_UserNO	 varchar(20) = '',	-- Ա�����
	@U_WorkStartDate	 datetime = Null,	-- ��ְ����
	@U_WorkEndDate	 datetime = Null,	-- ��ְ����
	@U_CompanyMail	 varchar(255) = '',	-- ��˾�ʼ���ַ
	@U_Title	 int = 0,	-- ְ����Ӧ���ֶι���
	@U_Extension	 varchar(10) = '',	-- �ֻ���
	@U_HomeTel	 varchar(20) = '',	-- ���е绰
	@U_PhotoUrl	 nvarchar(255) = '',	-- �û���Ƭ��ַ
	@U_DateTime	 datetime = Null,	-- ����ʱ��
	@U_LastIP	 varchar(15) = '',	-- ������IP
	@U_LastDateTime	 datetime = Null,	-- ������ʱ��
	@U_ExtendField	 ntext = '',	-- ��չ�ֶ�
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
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
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_User	WHERE (UserID = @UserID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





-- ��������ɾ��
CREATE PROCEDURE sys_UserRolesInsertUpdateDelete
(	

	@R_UserID	 int = 0,	-- �û�ID��sys_User����UserID���
	@R_RoleID	 int = 0,	-- �û�������ɫID��Sys_Roles����
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_UserRoles SET	
			R_UserID = @R_UserID,
			R_RoleID = @R_RoleID
		WHERE ( R_UserID = @R_UserID and R_RoleID = @R_RoleID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_UserRoles	WHERE ( R_UserID = @R_UserID and R_RoleID = @R_RoleID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO



if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_ModuleExtPermissionInsertUpdateDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_ModuleExtPermissionInsertUpdateDelete]
GO

-- ��������ɾ��
CREATE PROCEDURE sys_ModuleExtPermissionInsertUpdateDelete
(	

	@ExtPermissionID	 int = 0,	-- ��չȨ��ID
	@ModuleID	 int = 0,	-- ģ��ID
	@PermissionName	 nvarchar(100) = '',	-- Ȩ������
	@PermissionValue	 int = 0,	-- Ȩ��ֵ
	@DB_Option_Action_  nvarchar(20) = ''		-- �������� Insert:���� Update:�޸� Delete:ɾ�� 
)
AS
	DECLARE @ReturnValue int -- ���ز������
	
	SET @ReturnValue = -1
	
	-- ����
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
	
	-- ����
	IF (@DB_Option_Action_='Update')
	BEGIN
		UPDATE sys_ModuleExtPermission SET	
			ModuleID = @ModuleID,
			PermissionName = @PermissionName,
			PermissionValue = @PermissionValue
		WHERE (ExtPermissionID = @ExtPermissionID)
		
		SET @ReturnValue = @@ROWCOUNT
	END
	
	-- ɾ��
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_ModuleExtPermission	WHERE (ExtPermissionID = @ExtPermissionID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
go
