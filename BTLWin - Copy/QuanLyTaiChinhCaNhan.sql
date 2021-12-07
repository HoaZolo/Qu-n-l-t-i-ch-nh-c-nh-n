go
use master
go
if exists (select name from sys.databases where name='QLTCCN')
	drop database QLTCCN
go
create database QLTCCN
go
use QLTCCN
go

create table TaiKhoan
(
	tenDN nvarchar(100) primary key,
	tenKH nvarchar(100) not null,
	GTinh bit not null,
	NgaySinh date not null,
	MatKhau nvarchar(1000) not null,
	Anh nvarchar(200) NULL
)

create table TheLoaiAccounts
(
	MaTheLoaiTN int identity primary key,
	TenTheLoaiTN nvarchar(100) not null,
)
	
create table Accounts
(
	MaTN int identity primary key,
	MaTheLoaiTN int not null,
	SotienTN  int not null,
	ThoiGianTN  date not null,
	ChiTietTN nvarchar(2000) not null,
	tenDN nvarchar(100) not null,

	foreign key(MaTheLoaiTN) references TheLoaiAccounts(MaTheLoaiTN),
	foreign key(tenDN ) references TaiKhoan(tenDN )
)

create table TheLoaiExpenses
(
	MaTheLoaiCT int identity primary key,
	TenTheLoaiCT nvarchar(100) not null
)
	
create table Expenses
(
	id int identity primary key,
	MaTheLoaiCT int,
	SotienCT  int not null,
	ThoiGianCT  datetime not null,
	ChiTietCT nvarchar(2000) not null,
	tenDN nvarchar(100) not null,

	foreign key(MaTheLoaiCT) references TheLoaiExpenses(MaTheLoaiCT),
	foreign key(tenDN) references TaiKhoan(tenDN)
)


insert into TaiKhoan values
('Admin',N'Trần Minh Hòa',0,'2000/12/21','12345',null)
select * from TaiKhoan

insert into TheLoaiAccounts values
(N'Tiền lương'),
(N'Thu nhập ngoài'),
(N'Quỹ đen')
select *from TheLoaiAccounts

insert into TheLoaiExpenses values
(N'Mua sắm'),
(N'Tiền nhà'),
(N'Tiền điện'),
(N'Tiền nước')
select * from TheLoaiExpenses

insert into Accounts values
(1,20000000,'10/08/2020',N'Tiền lương của công ty A','Admin')
select *from Accounts
insert into Expenses values
(1,100000,'2021/08/21',N'Tiền lương của công ty A','Admin')
select *from Expenses
