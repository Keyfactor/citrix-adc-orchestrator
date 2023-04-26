declare @success bit = 1

begin transaction
begin try
	Declare @StoreTypeId int
	set @StoreTypeId=(select StoreType from [cms_agents].[CertStoreTypes] where ShortName='CitrixAdc')
	select *  FROM [KFCommand].[cms_agents].[CertStoreTypes]
	select * from [cms_agents].[CertStoreTypeProperties] where StoreTypeId=@StoreTypeId

	--Custom Alias is now required
	Update [cms_agents].[CertStoreTypes] set CustomAliasAllowed=2

	--Insert the Default Store Custom Fields
	If not Exists(select * from [cms_agents].[CertStoreTypeProperties] where StoreTypeId=@StoreTypeId)
	BEGIN
		Insert Into [cms_agents].[CertStoreTypeProperties](StoreTypeId,[Name],DisplayName,[Type],[Required],DependsOn,DefaultValue)
		Values(@StoreTypeId,'ServerUsername','Server Username',3,0,NULL,NULL)

		Insert Into [cms_agents].[CertStoreTypeProperties](StoreTypeId,[Name],DisplayName,[Type],[Required],DependsOn,DefaultValue)
		Values(@StoreTypeId,'ServerPassword','Server Password',3,0,NULL,NULL)

		Insert Into [cms_agents].[CertStoreTypeProperties](StoreTypeId,[Name],DisplayName,[Type],[Required],DependsOn,DefaultValue)
		Values(@StoreTypeId,'ServerUseSsl','Use SSL',1,1,NULL,'TRUE')
	END

	--Remove old KeyPair Value, this is not used anymore
	If Exists(select * from [cms_agents].[CertStoreTypeEntryParameters] where StoreTypeId=@StoreTypeId and Name='KeyPairName')
	BEGIN
		Delete 	[cms_agents].[CertStoreTypeEntryParameters] where StoreTypeId=@StoreTypeId and Name='KeyPairName'
	END

	Insert Into [cms_agents].[CertStoreTypeEntryParameters](StoreTypeId,[Name],DisplayName,[Type],RequiredWhen,DependsOn,DefaultValue,Options)
	Values(@StoreTypeId,'sniCert','SNI Cert',0,2,NULL,'false',NULL)
end try
begin catch
    rollback transaction
    set @success = 0
end catch

if(@success = 1)
begin
    commit transaction
end



