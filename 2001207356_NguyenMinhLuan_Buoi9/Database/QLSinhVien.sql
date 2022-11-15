CREATE DATABASE QLSinhVien
GO

CREATE TABLE Khoa(
	MaKhoa char(10) Primary key,
	TenKhoa nvarchar(20)
)

CREATE TABLE Lop(
	MaLop char(10) Primary Key,
	TenLop nvarchar(20),
	MaKhoa char(10),
	CONSTRAINT FK_Lop_Khoa
	FOREIGN KEY (MaKhoa)
	REFERENCES Khoa(MaKhoa)
)

CREATE TABLE SinhVien(
	MaSinhVien char(10) Primary Key,
	HoTen nvarchar(30),
	NgaySinh Date,
	MaLop char(10),
	CONSTRAINT FK_SinhVien_Lop
	FOREIGN KEY (MaLop)
	REFERENCES Lop(MaLop)
)

CREATE TABLE MonHoc(
	MaMonHoc char(10) Primary Key,
	TenMonHoc nvarchar(20)
)

CREATE TABLE Diem(
	MaSinhVien char(10),
	MaMonHoc char(10),
	Diem float,
	CONSTRAINT PK_Diem PRIMARY KEY (MaSinhVien,MaMonHoc),

	CONSTRAINT FK_Diem_SinhVien
	FOREIGN KEY (MaSinhVien)
	REFERENCES SinhVien(MaSinhVien),

	CONSTRAINT FK_Diem_MonHoc
	FOREIGN KEY (MaMonHoc)
	REFERENCES MonHoc(MaMonHoc)
)
Insert into Khoa
values('K01',N'Công Nghệ Thực Phẩm'),
	  ('K02',N'Công nghệ thông tin'),
	  ('K03',N'Ngôn ngữ Anh')

Insert into Lop
values('L01',N'11DHTP10','K01'),
	  ('L02',N'12DHTH11','K02'),
	  ('L03',N'12DHNN1','K03')


Insert into MonHoc
values('MH01',N'Chế biến'),
	  ('MH02',N'Lập trình web'),
	  ('MH03',N'Nói 3')

Insert into SinhVien
values('SV01',N'Trần Cách Cách','10/11/2002','L01'),
	  ('SV02',N'Trần Nhi Nhẫn','12/11/2002','L02'),
	  ('SV03',N'Trần A Nỏ','11/11/2002','L03')

Insert into Diem
values ('SV01','MH01',9),
       ('SV02','MH02',8),
	   ('SV03','MH03',10)

Select sv.MaSinhVien,HoTen,NgaySinh,Diem,d.MaMonHoc,mh.TenMonHoc from SinhVien sv ,Diem d,MonHoc mh,Khoa,Lop where sv.MaSinhVien=d.MaSinhVien and d.MaMonHoc = mh.MaMonHoc and Khoa.MaKhoa=Lop.MaKhoa and sv.MaLop=Lop.MaLop and Khoa.MaKhoa='K03' 
select * from Lop where MaKhoa = 'K01'
Select * from MonHoc
select * from SinhVien

insert into SinhVien
values ('SV04',N'Lê Văn Chỉn','03/04/2005','L01')

DELETE FROM SinhVien WHERE MaSinhVien = 'SV01'


