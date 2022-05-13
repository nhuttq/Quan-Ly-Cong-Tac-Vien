create database Quanly_ctv
go
use Quanly_ctv
---
create table CONG_TAC_VIEN
(
	MaCTV varchar(15) not null primary key,
	TenCTV nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	TrangThai int
)
insert into CONG_TAC_VIEN
values ('0911341451', 'Hoàng Như Quỳnh', 'Đà Nẵng', 0),
	   ('0911341452', 'Trần Thị Như', 'Đà Nẵng', 0),
	   ('0911341453', 'Nguyễn Minh Hiếu', 'Hà Tĩnh', 1),
	   ('0911341454', 'Nguyễn Cao Anh', 'Huế', 1),
	   ('0911341455', 'Phan Kim Ngọc', 'Nghệ An', 0),
	   ('0911341456', 'Lê Thị Ngân', 'Nghệ An', 0),
	   ('0911341457', 'Hoàng Anh Minh', 'Quảng Nam', 1),
	   ('0911341458', 'Nguyễn Lâm Anh', 'Quảng Trị', 1),
	   ('0911341459', 'Võ Phương Trúc', 'Gia Lai', 0),
	   ('0911341450', 'Trần Khánh Linh', 'Quảng Nam', 0)
select * from CONG_TAC_VIEN
---
create table LOAI_SAN_PHAM
(
	MaLoaiSP int not null primary key,
	TenLoaiSP nvarchar(100) not null,
	DonGiaThue int not null,
	DonViTinh nvarchar(50) not null
)
insert into LOAI_SAN_PHAM
values (1, 'Tranh thêu', 70000, 'VND'),
	   (2, 'Đan móc túi', 40000, 'VND'),
	   (3, 'Giỏ tre', 100000, 'VND'),
	   (4, 'Khay mây', 150000, 'VND'),
	   (5, 'Túi xách', 200000, 'VND'),
	   (6, 'Móc khoá', 20000, 'VND'),
	   (7, 'Mũ đan', 90000, 'VND'),
	   (8, 'Quạt giấy', 15000, 'VND'),
	   (9, 'Hoa giấy', 5000, 'VND'),
	   (10, 'Sổ tay', 50000, 'VND')
select * from LOAI_SAN_PHAM
---
create table HOA_DON
(
	MaHoaDon nvarchar(100) not null primary key,
	MaLoaiSP int not null,
	TenLoaiSP nvarchar(100) not null,
	MaCTV varchar(15) not null,
	TenCTV nvarchar(100) not null,
	Ngay date not null,
	SoLuong int not null,
	DonGiaThue int not null,
	ThanhTien int,
)
insert into HOA_DON(MaHoaDon,MaLoaiSP,TenLoaiSP,MaCTV,TenCTV,Ngay,SoLuong,DonGiaThue)
values ('HD1', 1, 'Tranh thêu',	 '0911341451','Hoàng Như Quỳnh',  '2021-01-01', 1,70000),
	   ('HD2', 2, 'Đan móc túi', '0911341452','Trần Thị Như',	  '2021-02-04', 3,40000),
	   ('HD3', 3, 'Giỏ tre',	 '0911341453','Nguyễn Minh Hiếu', '2021-03-14', 2,100000),
	   ('HD4', 4, 'Khay mây',	 '0911341454','Nguyễn Cao Anh',   '2021-04-05', 3,150000),
	   ('HD5', 5, 'Túi xách',	 '0911341455','Phan Kim Ngọc',    '2021-05-09', 4,200000),
	   ('HD6', 6, 'Móc khoá',	 '0911341456','Lê Thị Ngân',	  '2021-03-11', 2,20000),
	   ('HD7', 7, 'Mũ đan',		 '0911341457','Hoàng Anh Minh',	  '2021-04-25', 1,90000),
	   ('HD8', 8, 'Quạt giấy',	 '0911341458','Nguyễn Lâm Anh',   '2021-02-18', 5,15000),
	   ('HD9', 9, 'Hoa giấy',	 '0911341459','Võ Phương Trúc',   '2021-01-17', 9,5000),
	   ('HD0', 10, 'Sổ tay',	 '0911341450','Trần Khánh Linh',   '2021-05-28', 3,50000)
select * from HOA_DON
---
update HOA_DON
set ThanhTien = SoLuong * DonGiaThue 
select * from HOA_DON

