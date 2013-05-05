--增加应用排序字段
alter table sys_Applications  add A_Order int 
go
update sys_Applications set A_Order =0
go
-- 创建更新删除
ALTER PROCEDURE sys_ApplicationsInsertUpdateDelete
(	

	@ApplicationID	 int = 0,	-- 自动ID 1:为系统管理应用
	@A_AppName	 nvarchar(50) = '',	-- 应用名称
	@A_AppDescription	 nvarchar(200) = '',	-- 应用介绍
	@A_AppUrl	 varchar(50) = '',	-- 应用Url地址
	@A_Order	 int = 0,	-- 应用排序
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
	
	-- 更新
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
	
	-- 删除
	IF (@DB_Option_Action_='Delete')
	BEGIN
		DELETE sys_Applications	WHERE (ApplicationID = @ApplicationID)
		SET @ReturnValue = @@ROWCOUNT
  	END

SELECT @ReturnValue
go


