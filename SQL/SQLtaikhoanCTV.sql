CREATE DATABASE TAIKHOAN
USE TAIKHOAN 
CREATE TABLE TAI_KHOAN_CTV
(
	TenDangNhap NVARCHAR (100) PRIMARY KEY,
	TenHienThi NVARCHAR (100) NOT NULL DEFAULT N'NHOM4',
	MatKhau NVARCHAR (1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 --1:admin && 0: nhanvien
)
 
insert TAI_KHOAN_CTV (TenDangNhap, TenHienThi, MatKhau) values ('quynhnhu', 'Trần Quỳnh Như', 'nhu123'),
('thuyquynh', 'Hoàng Thúy Quỳnh', 'quynh123'),
('thinh', 'Trần Thị Thịnh', 'thinh123')


select * from TAI_KHOAN_CTV