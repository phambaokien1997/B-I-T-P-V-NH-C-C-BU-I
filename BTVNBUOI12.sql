use BTVN12
go
create database BTVN12
--Bạn đang làm việc cho một cửa hàng sách trực tuyến. Cửa hàng này cần một cơ sở dữ liệu để quản lý thông tin về các cuốn sách, tác giả và đơn đặt hàng của khách hàng. Hãy thiết kế cơ sở dữ liệu cho cửa hàng sách này.

--Yêu cầu:

--Mỗi cuốn sách cần có thông tin về: ID cuốn sách, tên cuốn sách, tác giả, danh mục sách (ví dụ: tiểu thuyết, kinh tế, khoa học), giá bán và số lượng tồn kho.

--Mỗi tác giả cần có thông tin về: ID tác giả, tên tác giả và quốc gia.

--Mỗi đơn đặt hàng cần có thông tin về: ID đơn đặt hàng, ngày đặt hàng, tên khách hàng, địa chỉ giao hàng và tổng số tiền.

--Mỗi đơn đặt hàng tương ứng với nhiều cuốn sách được đặt hàng. Mỗi mục cần có số lượng đặt hàng và giá bán tại thời điểm đó.

--Phân tích để tạo một cơ sở dữ liệu một cách kĩ càng dễ dàng mở rộng , sửa, xóa

--Mối quan hệ :
--Customer - Orders : 1 nhiều,
--Authors - Books : 1 nhiều,
--Orders - Books : nhiều - nhiều.
--Books - Customer : nhiều - nhiều
---> OderItems : được tạo ra như một bảng trung gian để ràng buộc và toàn vẹn dữ liệu
go
create table Authors(
ID nvarchar(10) primary key not null,
Aname nvarchar(100),
Country nvarchar(50),
);
go
create table Books(
ID int primary key not null, --id sách
title nvarchar(200), -- tiêu đề(tên) sách
category nvarchar(100), -- danh mục sách
price int, --giá sách
inventory_quantity int,	 --số lượng tồn kho của cuốn sách
authorID nvarchar(10),
constraint FK_Books_Authors foreign key (authorID) references Authors(ID)

);
go
create table Customers
(
ID nvarchar(10) primary key not null,
customerName nvarchar(250),
phonenumber nvarchar(11),
gender nvarchar(4),
);
go
create table Orders(
ID int primary key not null,
orderdate date,
customerID nvarchar(10),
saddress nvarchar(250),
totalmount int,
constraint FK_Orders_Customer foreign key (customerid) references Customers(ID)
);
go
create table OdersItems
(
ID int primary key not null,
oderID int,
bookID int,
quantity int,
priceatorder int,
constraint FK_OdersItems_Books foreign key (bookID) references Books(ID),
constraint FK_OrdersItems_Orders foreign key (oderID) references Orders(ID)
);

