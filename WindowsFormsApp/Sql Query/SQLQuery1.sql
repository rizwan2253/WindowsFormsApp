create database CashFlow
go 
use CashFlow
go
CREATE TABLE Category
(
	Id  int IDENTITY(1,1) PRIMARY KEY ,
	Name  VARCHAR(500)  NULL ,
	[Status] int null 
)
go


CREATE TABLE Manufacturer 
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name  VARCHAR(500)  NULL  ,
	[Status] int null 
)
go


CREATE TABLE ProductItem 
(
	Id  int IDENTITY(1,1) PRIMARY KEY ,
	Barcode  VARCHAR(500)  NULL ,
	Name  VARCHAR(500)  NULL ,
	SalePrice  INTEGER  NULL ,
	CostPrice  INTEGER  NULL ,	
	ManufacturerId  INTEGER not NULL ,
	CategoryId  INTEGER not NULL  ,
	[Status] int null 
)
go

CREATE TABLE Customer 
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	CustomerId int  NULL  ,
	ProductId int  NULL  ,
	buyDate datetime, 
	Quantity int null 
)

CREATE TABLE Users 
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	userName VARCHAR(500)  NULL ,
	[Password] VARCHAR(500)  NULL 
)
insert into Users values ('admin','pass')

create procedure [dbo].[storeProcedure]
@Type int=0,
@Id int=0,
@Name varchar(500)='',
@Barcode varchar(500)='',
@SalePrice int =0,
@CostPrice int =0,
@ManufacturerId int =0,
@CategoryId int =0,
@CustomerId int=0,
@ProductId int = 0,
@Quantity int=0,
@uName varchar(500)='',
@pass varchar(500)=''
as
begin
if(@Type=1)
begin
select Id,Name from Category where [Status]=1 and (id =  @Id or  @Id='0')
end
if(@Type=2)
begin
if not exists (select 1 from category where name = @Name)
begin 
 insert into Category values(@Name,1)
end
else
begin
select 0 
end
end
if(@Type=3)
begin
if not exists (select 1 from category where name = @Name)
begin 
 update Category set Name = @Name where Id = @Id
end
else
begin
select 0 
end
end

if(@Type=4)
begin
update Category set [Status]=0 where Id = @Id
end

if(@Type=5)
begin
select Id,Name from Manufacturer where [Status]=1 and (id =  @Id or  @Id='0')
end
if(@Type=6)
begin
if not exists (select 1 from Manufacturer where name = @Name)
begin 
 insert into Manufacturer values(@Name,1)
end
else
begin
select 0 
end
end
if(@Type=7)
begin
if not exists (select 1 from Manufacturer where name = @Name)
begin
update Manufacturer set Name = @Name where Id = @Id
end
else
begin
select 0 
end
end

if(@Type=8)
begin
update Manufacturer set [Status]=0 where Id = @Id
end

if(@Type=9)
begin 
select ProductItem.Id, ProductItem.Name,ProductItem.Barcode,ProductItem.CostPrice,ProductItem.SalePrice,
category.Name categoryName,Manufacturer.Name  ManufacturerName,category.Id categoryId,Manufacturer.Id ManufacturerId from ProductItem
inner join category on productitem.CategoryId=category.id
inner join manufacturer on productitem.ManufacturerId=Manufacturer.id
 where ProductItem.Status=1 and (ProductItem.Id = @id or  @Id='0')
end
if(@Type=10)
begin
if not exists (select 1 from ProductItem where name = @Name and CategoryId=@CategoryId and ManufacturerId=@ManufacturerId)
begin
insert into ProductItem(Barcode,Name,SalePrice,CostPrice,CategoryId,ManufacturerId,Status)
			 values(@Barcode,@Name,@SalePrice,@CostPrice,@CategoryId,@ManufacturerId,1)
end
else
begin
select 0 
end
end

if(@Type=11)
begin
if not exists (select 1 from ProductItem where name = @Name and CategoryId=@CategoryId and ManufacturerId=@ManufacturerId)
begin
update ProductItem set Name = @Name,Barcode=@Barcode,SalePrice=@SalePrice,CostPrice=@CostPrice,ManufacturerId= @ManufacturerId,CategoryId= @CategoryId where Id = @Id
end
else
begin
select 0 
end
end

if(@Type=12)
begin
update ProductItem set [Status]=0 where Id = @Id
end
if(@Type=13)
begin
insert into Customer(CustomerId,ProductId,buyDate,Quantity) values (@CustomerId,@ProductId,GETDATE(),@Quantity)
end
if(@Type=14)
begin
select distinct top 1 customerid from Customer order by  CustomerId desc
end
if(@Type=15)
begin
select userName,[Password] from Users where  userName=@uName and [Password]=@pass
end
if(@Type=16)
begin
select c.Id, c.CustomerId,p.Name,c.Quantity,p.SalePrice,c.Quantity*p.SalePrice TotalPrice from Customer c
inner join ProductItem p on c.ProductId=p.Id 
 where CustomerId = @CustomerId  or  @CustomerId='0'
end

end

--truncate table Users    
--truncate table  Customer   
--truncate table   ProductItem  
--truncate table    Manufacturer 
--truncate table     Category