ALTER FUNCTION GetQueryFromXml(@a xml , @ForInsert bit = 0)  --For All Curd Operation
 RETURNS @SetWhere TABLE
 (
	SetClause nvarchar(max),
	whereClause nvarchar(max)
 )
 as
 begin
 
	 DEClare @set nvarchar(max) = '' , @where nvarchar(max) = '';
	 
	 IF @ForInsert = 0
	 BEGIN
		select 
			@set += ISNULL(
			case when x.value('text()[1]', 'varchar(max)') is not null and x.value('local-name(./..)', 'varchar(max)') = 'Row' then 
					  QUOTENAME(ISNULL(x.value('./column[1]', 'varchar(max)') , x.value('local-name(.)', 'varchar(max)')))  + ' = ' + ISNULL(x.value('./update[1]', 'varchar(max)') , '') + dbo.QuotenameForLong(x.value('text()[1]', 'varchar(max)') , '''' , default) end  
			+ ' ,'  , '') ,

			@where += ISNULL(

			 case when x.value('text()[1]', 'varchar(max)') is null and  x.value('.', 'varchar(max)') != ''
			 then 
			      ISNULL(x.value('./column[1]', 'varchar(max)') , x.value('local-name(.)', 'varchar(max)'))  + ' ' +
				  ISNULL(x.value('./operator[1]', 'varchar(max)') , '') + ' ' + 
				  ISNULL(dbo.QuotenameForLong(x.value('./value[1]', 'varchar(max)') , '''' , default) , '') + ' ' + 
				  ISNULL(x.value('./join[1]', 'varchar(max)') , '') 
			 end + ' ', '')

			 from @a.nodes('//Row/*') AS XT(x) 	
			 
			 IF @where is not null and LTRIM(RTRIM(@where)) != ''
				SET @where = ' WHERE ' + @where	
	 END

	 ELSE
	 BEGIN
	 	select 
			@set += ISNULL(
			case when x.value('text()[1]', 'varchar(max)') is not null and x.value('local-name(./..)', 'varchar(max)') = 'Row' then 
			dbo.QuotenameForLong(x.value('text()[1]', 'varchar(max)')  ,'''' , default) end
			+ ' ,'  , '') ,

			@where += ISNULL(
				case when x.value('text()[1]', 'varchar(max)') is not null and x.value('local-name(./..)', 'varchar(max)') = 'Row' then 
				QUOTENAME(ISNULL(x.value('./column[1]', 'varchar(max)') , x.value('local-name(.)', 'varchar(max)'))) + ' , ' 
			    end , '')

			 from @a.nodes('//Row/*') AS XT(x) 
	   set @where = LEFT(@where , (case when LEN(@where) - 1 < 0 then 0 else LEN(@where) - 1 end))
	 END
	 insert into @SetWhere values( LEFT(@set , (case when LEN(@set) - 1 < 0 then 0 else LEN(@set) - 1 end)) , @where)
	 RETURN
 end

 GO

CREATE PROC InsertForAll
@XML xml , @table varchar(30) , @schema varchar(30) = 'dbo' 
as
begin
DECLARE @qery nvarchar(max) = '' , @rowcont int = 0;

SELECT @qery += case when (select WhereClause from dbo.GetQueryFromXml(x.query('.') , 1)) is not null and
				          LTRIM(RTRIM( (select WhereClause from dbo.GetQueryFromXml(x.query('.') , 1)) )) != ''
 THEN  'insert into ' +  QUOTENAME(@schema) + '.' + QUOTENAME(@table) +' ( ' + (select WhereClause from dbo.GetQueryFromXml(x.query('.') , 1)) + ' ) select  ' + (select  SetClause from dbo.GetQueryFromXml(x.query('.') , 1)) + '; SET @rowcont += @@rowcount ' 
 ELSE ''
 END + CHAR(10) + CHAR(13)
from @xml.nodes('//Rows//Row') AS XT(x)

EXEC sp_executesql @qery , N'@rowcont int out' , @rowcont out 

return @rowcont
end

GO

alter PROC UPDATEForAll
@XML xml , @table varchar(30) , @schema varchar(30) = 'dbo' 
as
begin
DECLARE @qery nvarchar(max) = '' , @rowcont int = 0;

SELECT @qery += case when (select SetClause from dbo.GetQueryFromXml(x.query('.') , default)) is not null and
				          LTRIM(RTRIM( (select SetClause from dbo.GetQueryFromXml(x.query('.') , default)) )) != ''
 THEN 'UPDATE ' +  QUOTENAME(@schema) + '.' + QUOTENAME(@table) +' SET ' + (select SetClause from dbo.GetQueryFromXml(x.query('.') , default)) + (select  WhereClause from dbo.GetQueryFromXml(x.query('.') , default)) + '; SET @rowcont += @@rowcount ' + CHAR(10) + CHAR(13)
 ELSE ''
 END
from @xml.nodes('//Rows//Row') AS XT(x)

EXEC sp_executesql @qery , N'@rowcont int out' , @rowcont out 

return @rowcont
end

GO

CREATE PROC DELETEForAll
@XML xml , @table varchar(30) , @schema varchar(30) = 'dbo' 
as
begin
DECLARE @qery nvarchar(max) = '' , @rowcont int = 0;

SELECT @qery += 'DELETE FROM ' +  QUOTENAME(@schema) + '.' + QUOTENAME(@table) + (select  WhereClause from dbo.GetQueryFromXml(x.query('.') , default)) + '; SET @rowcont += @@rowcount ' + CHAR(10) + CHAR(13)
from @xml.nodes('//Rows//Row') AS XT(x)

EXEC sp_executesql @qery , N'@rowcont int out' , @rowcont out 

return @rowcont
end

GO

CREATE PROC InsertOrUpdate
@XML xml , @table varchar(30) , @schema varchar(30) = 'dbo' 

AS
BEGIN
-- 0 means item exists so call update AND 1 means item doesn't exists or condition is not specified so insert

	DECLARE @UpdateOrInsert TABLE(Xm xml , ForWhich varchar(max)); DECLARE @sql nvarchar(max) = '' , @xml1 xml  , @rowcontUpdate int = 0 , @rowcontInsert int = 0;

	SELECT @sql += 'SELECT ' + dbo.QuotenameForLong(cast(x.query('.') AS NVARCHAR(max)) , '''' , default)   + 
	' , CASE WHEN ' + 
				dbo.QuotenameForLong((select  WhereClause from dbo.GetQueryFromXml(x.query('.') , default)) , '''' , default) + ' is not null and ' + dbo.QuotenameForLong(LTRIM(RTRIM( (select WhereClause from dbo.GetQueryFromXml(x.query('.') , default)) )) ,  '''' ,default) + ' != '''' ' +  
				+ ' and EXISTS(SELECT * FROM ' + QUOTENAME(@schema) + '.' + QUOTENAME(@table) + ' ' + (select  WhereClause from dbo.GetQueryFromXml(x.query('.') , default)) + 
			' ) THEN 0 ELSE 1 END ' + char(10) + char(13)
	from @xml.nodes('//Rows//Row') AS XT(x) 
 
	insert @UpdateOrInsert
	EXEC sp_executesql @sql 

 	SET @xml1 = (select cast(Xm as xml) from @UpdateOrInsert where ForWhich = 0 FOR XML PATH('') , ROOT('Rows'))
	EXEC @rowcontUpdate = UPDATEForAll @xml1 , @table , @schema

	SET @xml1 = (select cast(Xm as xml) from @UpdateOrInsert where ForWhich = 1 FOR XML PATH('') , ROOT('Rows'))
	EXEC @rowcontInsert = InsertForAll @xml1 , @table , @schema

	RETURN @rowcontInsert + @rowcontUpdate
END

GO

CREATE FUNCTION QuotenameForLong(@expression nvarchar(max) , @StartquoteWith nvarchar(max) , @EndquoteWith nvarchar(max) = null)
RETURNS nvarchar(max)
AS
BEGIN
IF @EndquoteWith is null
	SET @EndquoteWith = @StartquoteWith

RETURN @StartquoteWith + REPLACE(cast(@expression AS NVARCHAR(max)),@EndquoteWith, @EndquoteWith + @EndquoteWith) + @EndquoteWith

END
GO


ALTER FUNCTION getShiftTime(@startDate DATE , @currentDate DATE , @EmpId int)
RETURNS TIME
AS
BEGIN
IF datediff(day , @startdate , @currentDate) < 0
	RETURN NULL

DECLARE @sumOfIntervals int , @IntervalGaps date , @currentIntervalTime time = ''

SELECT @sumOfIntervals = sum(shiftInterval) from shifts where empId = @EmpId
SET @sumOfIntervals = ( datediff(day , @startdate , @currentDate) / @sumOfIntervals ) * @sumOfIntervals 

SET @IntervalGaps = dateadd(day , @sumOfIntervals , @startDate) 

SELECT @currentIntervalTime = case when @currentDate between @IntervalGaps and dateadd(day , shiftInterval - 1 , @IntervalGaps) then EntryTime else @currentIntervalTime end , @IntervalGaps = dateadd(day , shiftInterval , @IntervalGaps)  
from shifts where empId = @EmpId order by id  

RETURN  @currentIntervalTime 

END

GO

ALTER PROC DisplayAttendance
 @month int , @year int
 as
 BEGIN
 DECLARE @sql nvarchar(max) = '' , @fullDate nvarchar(max) = '' , @days nvarchar(max) = ''

 SELECT @fullDate += QUOTENAME(cast(RegesteredDate as nvarchar)) + ' , ', 
		@sql += 'MAX (' + QUOTENAME(cast(RegesteredDate as nvarchar)) + ') as ' + QUOTENAME( cast(day(RegesteredDate) as nvarchar) , '''') + ' , ', 
		@days += QUOTENAME( cast( day(RegesteredDate) as nvarchar)) + ' = ISNULL( ' + QUOTENAME( cast( day(RegesteredDate) as nvarchar)) + ' , ''N'') , '
 FROM Attendence where MONTH(RegesteredDate) = @month and YEAR(RegesteredDate) = @year
 GROUP BY RegesteredDate

 IF LTRIM(RTRIM( @sql )) = ''
	RETURN NULL

 SET @fullDate = left(@fullDate , len(@fullDate) - 1)


 set @sql = ' 

	 SELECT  fname + '' '' + lname as [Full Name] , Employee.id , d.name as [Departement Name] , ' + @days + ' 
	(SELECT COUNT(empId) FROM Attendence a WHERE a.empId = Employee.id AND MONTH(RegesteredDate) = ' + cast(@month as nvarchar) + ' and YEAR(RegesteredDate) = ' + cast(@year as nvarchar) + ' and Stas = ''P'' ) as [Total Present],  
	(SELECT COUNT(empId) FROM Attendence a WHERE a.empId = Employee.id AND MONTH(RegesteredDate) = ' + cast(@month as nvarchar) + ' and YEAR(RegesteredDate) = ' + cast(@year as nvarchar) + ' and Stas = ''L'' ) as [Total Leave],
	(SELECT COUNT(empId) FROM Attendence a WHERE a.empId = Employee.id AND MONTH(RegesteredDate) = ' + cast(@month as nvarchar) + ' and YEAR(RegesteredDate) = ' + cast(@year as nvarchar) + ' and Stas = ''A'' ) as [Total Absent],
	(SELECT COUNT(empId) FROM Attendence a WHERE a.empId = Employee.id AND MONTH(RegesteredDate) = ' + cast(@month as nvarchar) + ' and YEAR(RegesteredDate) = ' + cast(@year as nvarchar) + ' ) as [Total Count]  
 
	from 
	 ( 
		select empId , ' + left(@sql , len(@sql) - 1) + 'from Attendence PIVOT
		(max( stas ) for RegesteredDate in (' + @fullDate + ')) as pivotTable GROUP BY empId
	 
	 ) as fg join Employee  on Employee.id = fg.empId
	      join Departement d  on Employee.Depid = d.id
	 '

 EXEC(@sql)
 END

 GO

 alter proc AttendenceList
@date Datetime
as
begin
	select e.ID , e.fname + ' ' + e.lname as [Full Name] , d.NAME as [Departement Name] , cast (dbo.getShiftTime(startDate , @date , e.ID) as time) as [Entry Time], 
	case 
	when exists (select * from Leave where empId = e.ID and cast (startDate as date) <= cast (@date as date) and cast (enddate as date) >= cast (@date as date))
	then 'L'
	else '' end
	 as [Status]
	from Employee e join Departement d on e.DepId = d.ID
	where  dateadd ( second, - datediff( second, 0, d.EarlyTime )  ,  cast (dbo.getShiftTime(startDate , @date , e.ID) as time) ) <= cast(@date as time) and
		   dateadd ( second,   datediff( second, 0, dbo.getShiftTime(startDate , @date , e.ID)) , d.LateEntry ) >= cast(@date as time) and
		   not exists(select * from Attendence where empId = e.ID and cast(RegesteredDate as Date) = cast(@date as Date))
end


GO

alter PROC getLeaveType
@id int , @date Date
as
begin
	select startDate , EndDate , Ltype from Leave join LeaveType t on t.id = Leave.LeaveId 
	where empId = @id and @date between startDate and EndDate
end

GO

ALTER PROC GetVoucher
@c char
as
begin
	select a.id as 'ID' , isnull(a.IsUpdatedId , -1) as 'UpdateId' , s.Name as 'Cname' , s.SType as 'Type' , a.DateStatChanged as 'Date' ,  e.ID as 'Employee ID' , e.fname + ' ' + e.lname as 'Full Name' from Proforma_Approval a
	join Supplier s on s.ID = a.SupplierId
	join Employee e on e.ID = a.EmpId

	 where a.Stas = @c and
	 not exists(select * from Proforma_Approval where a.ID = IsUpdatedId) and
	exists(	select IsUpdatedId from Proforma_Approval group by IsUpdatedId Having  a.IsUpdatedId is null or  a.ID = max(id)  )

end

GO


alter proc getProforma
@id int
as
begin
	select p.ID as 'ProformaId' , p.ProductId as 'ID' , pr.Name as 'Product Name' , cast( p.price as float) as 'Unit Price' , cast( p.QuntityOfType as float) as 'Quantity Of Type' , e.Name as 'Type' , p.Quantity
	from Proforma_Approval a
		join Proforma p on a.EmpId = p.EmpId and a.IssueDate = p.IssueDate
		join Product pr on pr.ID = p.ProductId
		join ProductType e on e.ID = pr.TypeID 
	where a.ID = @id
end

GO

alter proc getProformaSupplier
@id int
as
begin
	select s.ID ,  s.Name , s.phoneNumber , s.City , s.SubCity , s.Woreda , s.Kebele , s.SType , s.Email
	from Proforma_Approval a
		join Supplier s on s.ID = a.SupplierId

	where a.ID = @id
end

GO

alter proc viewHistoryOfVoucher
@UpdatedId int
as
begin
	select a.id as 'ID' , isnull(a.IsUpdatedId , -1) as 'UpdateId' , s.Name as 'Cname' , s.SType as 'Type' , a.DateStatChanged as 'Date' ,  e.ID as 'Employee ID' , e.fname + ' ' + e.lname as 'Full Name' from Proforma_Approval a
	join Supplier s on s.ID = a.SupplierId 
	join Employee e on e.ID = a.EmpId
	where a.IsUpdatedId = @UpdatedId or exists(select * from Proforma_Approval where a.ID = @UpdatedId)
	order by id desc
end