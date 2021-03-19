
begin tran
declare @sitename as nvarchar(max)
select @sitename = '%GRANADA%';

declare @centerId as int;
select @centerId = 10628;

declare @siteid as int;
select @siteid = ( select Id from sites where name like @sitename );
--select @siteid = ( select Id from sites where companyId = 17 );
--select @siteid = ( select SiteId from centers where Id = @centerId );

select * from centers where siteid = @siteid;

declare @crmaccount as uniqueidentifier;
select @crmaccount = ( select CrmAccountId from sites where id = @siteid );

declare @companyid as int;
select @companyid = ( select CompanyId from sites where id = @siteid );

select @siteid as site, @crmaccount as crmaccount, @companyid as company;

declare @checks as int;
select @checks = (select count(*) as 'centers with site' from centers where siteid = @siteid and id <> @centerId);
select @checks as A
select @checks += (select count(*) as 'other sites with company' from sites where companyid = @companyid and id <> @siteid);
select @checks as B
select @checks += (select count(*) as 'other sites with crmaccount' from sites where crmaccountid = @crmaccount and id <> @siteid);
select @checks as C
select @checks += (select count(*) as 'other companies with crmaccount' from companies where crmaccountid = @crmaccount and id <> @companyId);
select @checks as D
select @checks += (select count(*) as 'other matching names' from sites where name like @sitename and id <> @siteid)
select @checks as E

if @checks <> 0 
	throw 666666, 'consistency warning!', @checks;
	
update centers set siteid = null where siteid = @siteid

delete sites where id = @siteid;
delete companies where id = @companyid;
delete crmaccounts where crmaccountid = @crmaccount;


--rollback tran
commit tran