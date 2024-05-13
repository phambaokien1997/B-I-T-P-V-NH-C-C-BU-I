

create database BTVN13
go 
use BTVN13
go
create table Authors
(
ID nvarchar(10) primary key not null,
AName nvarchar(50),
Country nvarchar(50)
)
create table Books
(
ID int primary key not null,
title nvarchar(50),
authorID nvarchar(10),
category nvarchar (100),
price int,
inventory_quantity int,
constraint FK_Books_Authors foreign key (authorID) references Authors(ID)
)
create table Customers
(
ID int primary key not null,
customerName nvarchar(50),
phoneNumber varchar(11),
gender nvarchar(5)
)
create table Orders
(
ID int primary key not null,
orderdate DATE,
customerID int,
shippingAddress nvarchar(300),
totalAmount int,
constraint FK_Orders_Customer foreign key (customerID) references Customers(ID)
)
create table OrderDetails
(
ID int primary key not null,
bookID int,
orderID int,
customerID int,
constraint FK_OrderDetails_Books foreign key (bookID) references Books(ID),
constraint FK_OrderDetails_Oders foreign key (orderID) references Orders(ID),
quantity int,
priceatorder int,
constraint FK_OderDetails_Customers foreign key (customerID) references Customers(ID)
);
select * from Orders;
