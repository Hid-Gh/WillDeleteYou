
CREATE TABLE RoomType
(
ID int identity primary key,
name nvarchar(100) not null UNIQUE,	
NumberOfPpl int not null,
color int not null
)

update RoomType set color = -4177920 where name = 'King'
update RoomType set color = -7722014 where name = 'Standard'
update RoomType set color = -16777088 where name = 'Queen'
update RoomType set color = -7077677 where name = 'Suits'

select * from RoomType

--exec sp_rename 'RoomType.bedNumber' , 'NumberOfPpl' , 'COLUMN'

GO
INSERT INTO RoomType VALUES ('Standard' , 1) , ('King' , 3) , ('Queen' , 2) , ('Suits' , 2)

GO

CREATE TABLE Room
(
ID int identity primary key,
RoomNumber int not null UNIQUE,
RoomTypeID int foreign key references RoomType(ID) not null
)

GO
INSERT INTO Room VALUES (101 , 1) , (102 , 3) , (103 , 2) , (104 , 2) , (201 , 1) , (202 , 3) , (203 , 2) , (204 , 2)
INSERT INTO Room VALUES (301 , 4) , (302 , 4) , (303 , 4) , (304 , 4)
go

CREATE TABLE Customer
(
ID int identity primary key,
fname nvarchar(100) not null,
lname nvarchar(100) not null,
gname nvarchar(100) not null,
DateOfBirth date not null,
Gender nvarchar(8) not null,
phoneNumber nvarchar(50) not null,
nationality varchar(100) not null,
DateAdded date default GETDATE()

CONSTRAINT UC_Customer  UNIQUE(fname , lname , gname , DateOfBirth , Gender , phoneNumber , nationality)
)
GO

CREATE TABLE Reservation
(
	ID int identity primary key,
	CustId int foreign key references Customer(ID) not null,
	RoomId int foreign key references Room(ID) not null,
	CheckInDate date not null,
	CheckOutDate date not null,
	IsPaid bit not null,
	NumberOfPeople int default 1,
	WhenReserved Date default getdate(),
	EmpId int foreign key references Employee(ID) not null
)

GO

CREATE TABLE Departement(

	ID int primary key identity,
	NAME nvarchar(40) not null UNIQUE,
	EarlyTime time default '2:00',
	LateEntry time default '4:00'
)

insert into Departement values('Waiter' , default , default)
insert into Departement values('CEO' , default , default)
insert into Departement values('HR Office' , default , default)
insert into Departement values('Front Desk' , default , default)

GO

CREATE TABLE Employee(

	ID int primary key identity,
	fname nvarchar(100),
    lname nvarchar(100),
	DepId int foreign key references Departement(ID),
    startDate Date
)

GO

insert into Employee values ('mehret' , 'Bekele' , 1 , DATEADD(month , -10 , getdate()) )
insert into Employee values ('abebe' , 'melelse' , 1 , DATEADD(month , -10 , getdate()))
insert into Employee values ('lakech' , 'lake' , 2 , DATEADD(month , -10 , getdate()))
insert into Employee values ('samri' , 'solomon' , 3 , DATEADD(month , -10 , getdate()))
insert into Employee values ('saba' , 'abel' , 3 , DATEADD(month , -10 , getdate()))

GO

create table shifts(
	id int primary key identity,
	empId int foreign key references Employee(ID),
	shiftInterval int,
	EntryTime time
)
go
delete from shifts

insert into shifts values(1 , 7 , '8:00 am')
insert into shifts values(1 , 7 , '5:30 pm')
insert into shifts values(2 , 1 , '8:00 am')
insert into shifts values(3 , 3 , '5:30 pm')
insert into shifts values(3 , 3 , '8:00 am')
insert into shifts values(4 , 14 , '5:30 pm')
insert into shifts values(4 , 14 , '8:00 am')
insert into shifts values(5 , 1 , '5:30 pm')


GO

CREATE TABLE LeaveType(
	id int primary key identity,
	Ltype nvarchar(100) unique not null,
	AllowedDays int
)

GO
Insert into LeaveType values('Sick Leave' , null) , ('Annual Leave' , 30) , ('Maternaty Leave' , 60)

GO

CREATE TABLE Leave(

	LeaveId int foreign key references LeaveType(id),
    empId int foreign key references Employee(ID),
	startDate Date,
	EndDate Date
)
GO
insert into Leave values(1 , 1 , DATEADD(month , -10 , getdate()) , DATEADD(month , 10 , getdate()) )
insert into Leave values(3 , 2 , DATEADD(month , -10 , getdate()) , DATEADD(month , 10 , getdate()) )

GO
select * from Attendence
CREATE TABLE Attendence(

	ID int primary key identity,
    empId int foreign key references Employee(ID),
	Stas char default 'A',
	EntryTime time,
	EnteredTime time,
	RegesteredDate DATE default GETDATE() 

	CONSTRAINT UC_Attendence  UNIQUE(empId , RegesteredDate)

)

GO

CREATE TABLE ProductType(

	ID int primary key identity,
    Name varchar(100) not null UNIQUE,
)
go
insert into ProductType values ('KG') , ('Liter')
GO 

CREATE TABLE ProductCatogory(

	ID int primary key identity,
    Name varchar(100) not null UNIQUE,
)
go
insert into ProductCatogory values ('vegetable') , ('fruit') , ('animal Product') , ('drink')

GO

CREATE TABLE Product(

	ID int primary key identity,
	Name varchar(100) not null UNIQUE,
	TypeID int foreign key references ProductType(ID) not null,
    CatogoryID int foreign key references ProductCatogory(ID) not null,
	MinRequirement int Default 100

)
go
insert into Product values ('Egg' , 1 , 3 , default)
insert into Product values ('Onion' , 1 , 1 , default)
insert into Product values ('Tomato' , 1 , 1 , default)
insert into Product values ('Water' , 2 , 1 , default)

GO

select p.ID , p.Name as 'Product Name' , p.MinRequirement , t.Name as 'Type Name' , c.Name as 'Catagory Name' from 
Product p join ProductType t on t.ID = p.TypeID 
join ProductCatogory c on c.ID = p.CatogoryID

CREATE TABLE Supplier(

	ID int primary key identity,
	Name varchar(100) not null unique,
	SType varchar(100) not null,
	City varchar(100) not null default 'Addis Ababa',
	SubCity varchar(100) not null,
	Woreda varchar(10) not null default  '07',
	Kebele varchar(10) not null default  '01',
	phoneNumber nvarchar(50) not null unique,
	Email varchar(100) not null unique,
)


go
insert into Supplier values('Meow Campany' , 'Vegetable and Animal Product' , 'Nifas silk' , '922345434' , 'Meow@gmail.com')
insert into Supplier values('Almaz Campany' , 'Drink' , 'Gogeb' , '922345434' , 'Almaz@gmail.com')
insert into Supplier values('Bekele Campany' , 'Vegetable' , 'Saris' , '97824981' , 'Bekele@gmail.com')
insert into Supplier values('Woow Campany' , 'Soft Drink' , 'Merkato' , '92983335' , 'Woow@gmail.com')

GO

CREATE TABLE Proforma(

	ID int primary key identity,
	ProductId int foreign key references Product(ID),
	price Money not null, --price per one product
	Quantity int not null,
	IssueDate DateTime not null,
	EmpId int foreign key references Employee(ID) not null,
	QuntityOfType Money default 1 --eg . 2 and type is Liter for liquid
)
GO

CREATE TABLE Proforma_Approval(

	ID int primary key identity,
	SupplierId int foreign key references Supplier(ID),
	IssueDate DateTime not null,
	EmpId int not null,
	Stas char, -- (A approved , D disapproved , P pending)
	DateStatChanged DateTime,
	IsUpdatedId int foreign key references Proforma_Approval(ID)

    CONSTRAINT UC_ProformaApproval  UNIQUE(EmpId , IssueDate)
)


GO
declare @date datetime = '2022-10-17 10:30:08.090'
insert into Proforma_Approval values(1 , @date , 1 , 'A' , getdate())

insert into Proforma values(1 , 35.6 , 5 , @date , 1 , 1)
insert into Proforma values(2 , 12 , 15 , @date , 1 , 2)
insert into Proforma values(3 , 32.1 , 52 , @date , 1 , 3)
insert into Proforma values(4 , 11 , 27 , @date , 1 , 2.5)


declare @date datetime = getdate()
insert into Proforma_Approval values(2 , @date , 2 , 'A' , getdate())

insert into Proforma values(1 , 70 , 51 , @date , 2 , 5)
insert into Proforma values(2 , 120 , 95 , @date , 2 , 2)
insert into Proforma values(3 , 321 , 102 , @date , 2 , 3)
insert into Proforma values(4 , 61 , 270 , @date , 2 , 2.5)

declare @date datetime = dateadd(year , -3 ,  getdate())
insert into Proforma_Approval values(2 , @date , 2 , 'A' , getdate())

insert into Proforma values(1 , 70 , 51 , @date , 2 , 5)
insert into Proforma values(2 , 120 , 95 , @date , 2 , 2)
insert into Proforma values(3 , 321 , 102 , @date , 2 , 3)
insert into Proforma values(4 , 61 , 270 , @date , 2 , 2.5)



declare @date datetime = dateadd(year , -1 ,  getdate())
insert into Proforma_Approval values(2 , @date , 2 , 'P' , getdate())

insert into Proforma values(1 , 70 , 51 , @date , 2 , 5)
insert into Proforma values(2 , 120 , 95 , @date , 2 , 2)
insert into Proforma values(3 , 321 , 102 , @date , 2 , 3)
insert into Proforma values(4 , 61 , 270 , @date , 2 , 2.5)

GO

CREATE TABLE ProductInStore(

	ID int primary key identity,
    ProformaID int foreign key references Proforma(ID) not null unique,
	Quantity int not null,
	ExpiredDate DateTime not null,
	EntryDate DateTime not null,
)
Go
insert into ProductInStore values(1 , 10 , DATEADD(year , 2 , GETDATE()) , GETDATE())
insert into ProductInStore values(2 , 34 , DATEADD(year , 5 , GETDATE()) , GETDATE())
insert into ProductInStore values(3 , 17 , DATEADD(year , 1 , GETDATE()) , GETDATE())

insert into ProductInStore values(6 , 50 , DATEADD(year , 2 , GETDATE()) , GETDATE())
insert into ProductInStore values(7 , 89 , DATEADD(year , 5 , GETDATE()) , GETDATE())
insert into ProductInStore values(8 , 98 , DATEADD(year , 1 , GETDATE()) , GETDATE())

GO


select p.ID , a.Stas , pr.Name , p.IssueDate , p.price , p.QuntityOfType ,e.Name as 'Type' , p.Quantity, s.Name , s.Addres 
from Proforma_Approval a 
join Proforma p on a.EmpId = p.EmpId and a.IssueDate = p.IssueDate
join Product pr on pr.ID = p.ProductId
join Supplier s on s.ID = a.SupplierId
join ProductType e on e.ID = pr.TypeID


select s.Name as 'Supplier Name' , pr.Name as 'Product Name' , p.price , p.QuntityOfType , e.Name , p.Quantity ,
pIs.Quantity as 'Quantity In Store' , cast(pis.EntryDate as date) as 'Entry Date' , cast(pis.ExpiredDate as date) as 'Expired Date'
from ProductInStore pIs
	join Proforma p on p.ID = pIs.ProformaID
	join Product pr on pr.ID = p.ProductId
	join ProductType e on e.ID = pr.TypeID 
	join Proforma_Approval a on a.EmpId = p.EmpId and a.IssueDate = p.IssueDate
	join Supplier s on s.ID = a.SupplierId


GO


go

