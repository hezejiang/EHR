--����Ӧ�������ֶ�
alter table sys_Applications  add A_Order int 
go
update sys_Applications set A_Order =0
go
-- ��������ɾ��
ALTER PROCEDURE sys_ApplicationsInsertUpdateDelete
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
go


