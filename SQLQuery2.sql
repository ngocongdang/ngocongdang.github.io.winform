 create database BTL

use BTL

create table tblPhongBan
(
	PK_sMaPB nvarchar(10) primary key,
	sTenPB nvarchar(50),
	sDiaChi nvarchar(100), 
	sSdtPB varchar(15)
)

create table tblTrinhDoHocVan
(
	PK_sMaTDHV nvarchar(5) primary key,
	sTDHV nvarchar(50),
)

create table tblLuong
(
	FK_BacLuong varchar(10) primary key,
	fLuongCoBan float,
	fPhuCap float
)
ALTER TABLE tblNhanVien ADD dNgaySinh date ;
create table tblChucVu
(
	PK_sMaCV nvarchar(10) primary key,
	sChucVu nvarchar(50),
	fHeSoLuong float
)
create table tblNhanVien
(
	PK_sMaNV nvarchar(10) primary key,
	sHoTen nvarchar(50),
	dNgaySinh date,
	sQueQuan nvarchar(100),
	sGioiTinh nvarchar(10),
	sDanToc nvarchar(20),
	sSDT varchar(11),
	sMaPB nvarchar(10)REFERENCES tblPhongBan(PK_sMaPB),
	sMaCV nvarchar(10)REFERENCES tblChucVu(PK_sMaCV),
	sMaTDHV nvarchar(5)REFERENCES tblTrinhDoHocVan(PK_sMaTDHV),
	sBacLuong varchar(10)REFERENCES tblLuong(FK_BacLuong)
)

create table tblUser
(
	PK_ID int identity(1,1) primary key, 
	sUsername varchar(15),
	sPassword	varchar	(15)
)
ALTER TABLE tblNhanVien
ADD FOREIGN KEY (sMaCV) REFERENCES tblChucVu(PK_MaCV);

create proc btnLogin
@name nvarchar(50),
@pass nvarchar(10)
as
select tblUser.PK_ID from tblUser
where sUsername = @name and sPassword = @pass 

exec btnLogin N'user',N'user'

alter proc LoadNV
as
select NV.PK_sMaNV, NV.sHoTen,NV.dNgaySinh,NV.sQueQuan,NV.sGioiTinh,NV.sDanToc,NV.sSDT,PB.sTenPB,L.FK_BacLuong,CV.sChucVu,TDHV.sTDHV
from tblNhanVien NV inner join tblPhongBan PB
on NV.sMaPB = PB.PK_sMaPB inner join tblLuong L
on NV.sBacLuong = L.FK_BacLuong inner join tblChucVu CV
on NV.sMaCV = CV.PK_sMaCV inner join tblTrinhDoHocVan TDHV
on NV.sMaTDHV = TDHV.PK_sMaTDHV
order by NV.PK_sMaNV 

exec LoadNV

Insert into tblNhanVien
values
(
	N'NV5',N'Ngô Văn Thụ','1999-10-10',N'Hà Nội',N'Nam',N'Kinh','0145598558',N'PKD',N'GD',N'GS','3'
);


	select * from tblPhongBan


create proc SearchNV
@id nvarchar(10)
as
select NV.PK_sMaNV, NV.sHoTen,NV.dNgaySinh,NV.sQueQuan,NV.sGioiTinh,NV.sDanToc,NV.sSDT,PB.sTenPB,L.FK_BacLuong,CV.sChucVu,TDHV.sTDHV
from tblNhanVien NV inner join tblPhongBan PB
on NV.sMaPB = PB.PK_sMaPB inner join tblLuong L
on NV.sBacLuong = L.FK_BacLuong inner join tblChucVu CV
on NV.sMaCV = CV.PK_sMaCV inner join tblTrinhDoHocVan TDHV
on NV.sMaTDHV = TDHV.PK_sMaTDHV
where NV.PK_sMaNV = @id

exec SearchNV N'NV1'

create proc DeleteNV
@id nvarchar(10)
as
delete from tblNhanVien
where PK_sMaNV =@id

exec DeleteNV N'NV4'

create proc InsertNV 
@id	nvarchar (10),
@name nvarchar (50),
@DateOfBirth date,
@Address nvarchar(150),
@Sex nvarchar(10),
@Nation nvarchar(20),
@Phone varchar(11),
@TeamName nvarchar(50),
@Office nvarchar(50),
@Level nvarchar(50),
@Salary nvarchar(10)
as
begin
declare @TeamID nvarchar(10) = (select tblPhongBan.PK_sMaPB from tblPhongBan where sTenPB = @TeamName),
		@OfficeID nvarchar(10) = (select tblChucVu.PK_sMaCV from tblChucVu where sChucVu = @Office),
		@LevelID nvarchar(5) = (select tblTrinhDoHocVan.PK_sMaTDHV from tblTrinhDoHocVan where sTDHV =@Level);
Insert into tblNhanVien
values (@id,@name,@DateOfBirth,@Address,@Sex,@Nation,@Phone,@TeamID,@OfficeID,@LevelID,@Salary)
end

exec InsertNV N'NV5',N'Ngô Thanh Hải','1999-10-10',N'Hà Nội',N'Nữ',N'Kinh','0145598558',N'Kinh doanh',N'Giám đốc',N'Thạc sĩ','3'

select * from tblNhanVien

create proc LoadIDNV
as
select tblNhanVien.PK_sMaNV from tblNhanVien

exec LoadIDNV


create proc AlterNV
@id	nvarchar (10),
@name nvarchar (50),
@DateOfBirth date,
@Address nvarchar(150),
@Sex nvarchar(10),
@Nation nvarchar(20),
@Phone varchar(11),
@TeamName nvarchar(50),
@Office nvarchar(50),
@Level nvarchar(50),
@Salary nvarchar(10)
as
begin
declare @TeamID nvarchar(10) = (select tblPhongBan.PK_sMaPB from tblPhongBan where sTenPB = @TeamName),
		@OfficeID nvarchar(10) = (select tblChucVu.PK_sMaCV from tblChucVu where sChucVu = @Office),
		@LevelID nvarchar(5) = (select tblTrinhDoHocVan.PK_sMaTDHV from tblTrinhDoHocVan where sTDHV =@Level);
Update tblNhanVien 
set  sHoTen = @name,dNgaySinh= @DateOfBirth,sQueQuan = @Address,sGioiTinh = @Sex,sDanToc = @Nation,sSDT = @Phone,sMaPB = @TeamID,sMaCV = @OfficeID,sMaTDHV = @LevelID,sBacLuong = @Salary
where PK_sMaNV = @id;
end

exec AlterNV N'NV53',N'Ngô Thanh Hải','1999-10-25',N'Hà Nội',N'Nam',N'Kinh','0145598558',N'Kinh doanh',N'Giám đốc',N'Thạc sĩ','3'



select * from tblPhongBan

alter proc SearchPB
@id nvarchar(10)
as
Select * from tblPhongBan
where PK_sMaPB = @id

exec SearchPB N'PQT'

create proc countNV_PB
@id nvarchar(10)
as
select COUNT(PK_sMaNV) from tblNhanVien where sMaPB = @id

exec countNV_PB N'PGD'

create proc AlterPB 
@id nvarchar (10),
@name nvarchar (50),
@address nvarchar(150),
@phone varchar(11)
as
Update tblPhongBan
set sTenPB = @name, sDiaChi = @address, sSdtPB = @phone
where PK_sMaPB = @id;

exec AlterPB N'KHO' ,N'kho', N'Kho, tầng hầm' ,'0123456789' 

create proc LoadPB 
as
select * from tblPhongBan

exec LoadPB

create proc DeletePB
@id nvarchar(10)
as
delete from tblPhongBan
where PK_sMaPB = @id

exec DeletePB N'k'

create proc InsertPB 
@id nvarchar (10),
@name nvarchar (50),
@address nvarchar(150),
@phone varchar(11)
as
insert into tblPhongBan
values(@id,@name,@address,@phone)

exec InsertPB N'K' ,N'k', N'Kho, tầng hầm' ,'0123456789'

alter proc LoadNV_PB
@teamName nvarchar(50)
as
select NV.PK_sMaNV,NV.sHoTen,NV.dNgaySinh,NV.sGioiTinh,NV.sQueQuan,NV.sSDT,PB.sTenPB
from tblNhanVien NV inner join tblPhongBan PB
on NV.sMaPB = PB.PK_sMaPB
where PB.sTenPB = @teamName

exec LoadNV_PB N'kinh doanh'


alter proc LoadNVT
as
select NV.PK_sMaNV,NV.sHoTen,NV.dNgaySinh,NV.sGioiTinh,NV.sQueQuan,NV.sSDT,PB.sTenPB
from tblNhanVien NV inner join tblPhongBan PB
on NV.sMaPB = PB.PK_sMaPB


exec LoadNVT 


create proc countNV_NPB
@name nvarchar(50)
as
select COUNT(PK_sMaNV) from tblNhanVien NV inner join tblPhongBan PB 
on NV.sMaPB = PB.PK_sMaPB
where PB.sTenPB = @name

exec countNV_NPB N'kinh doanh' 

alter proc MoveNV
@id nvarchar(10),
@name nvarchar(50)
as
begin
declare @teamID nvarchar(10) = (select PK_sMaPB from tblPhongBan where sTenPB =  @name);
update tblNhanVien
set  sMaPB = @teamID
where PK_sMaNV = @id
end

select * from tblNhanVien where PK_sMaNV = N'NV3'
exec MoveNV N'NV3',N'Kĩ thuật'
exec LoadNV

create proc ChagneLevel
@id nvarchar(10),
@name nvarchar(50)
as
begin
declare @levelID nvarchar(10) = (select PK_sMaTDHV from tblTrinhDoHocVan where sTDHV =  @name);
update tblNhanVien
set  sMaTDHV = @levelID
where PK_sMaNV = @id
end

alter proc loadTDHV 
as
select NV.PK_sMaNV,NV.sHoTen,NV.dNgaySinh,NV.sGioiTinh,NV.sQueQuan,NV.sSDT,TDHV.sTDHV
from tblNhanVien NV inner join tblTrinhDoHocVan TDHV
on NV.sMaTDHV = TDHV.PK_sMaTDHV 

exec loadTDHV

alter proc LoadNV_TDHV
@levelName nvarchar(50)
as
select NV.PK_sMaNV,NV.sHoTen,NV.dNgaySinh,NV.sGioiTinh,NV.sQueQuan,NV.sSDT,TDHV.sTDHV
from tblNhanVien NV inner join tblTrinhDoHocVan TDHV
on  NV.sMaTDHV = TDHV.PK_sMaTDHV 
where TDHV.sTDHV = @levelName

exec LoadNV_TDHV N'Giáo sư'

create proc countNV_TDHV
@levelName nvarchar(50)
as
select COUNT(PK_sMaNV) from tblNhanVien NV inner join tblTrinhDoHocVan TDHV
on NV.sMaTDHV = TDHV.PK_sMaTDHV 
where TDHV.sTDHV = @levelName

exec countNV_TDHV N'Giáo sư'


alter proc LoadNV_L
as
select NV.PK_sMaNV,NV.sHoTen,CV.sChucVu,CV.fHeSoLuong,NV.sBacLuong, L.fLuongCoBan,L.fPhuCap
from tblNhanVien NV inner join tblChucVu CV
on NV.sMaCV = CV.PK_sMaCV inner join tblLuong L
on NV.sBacLuong = L.FK_BacLuong


exec LoadNV_L

select * from tblNhanVien

alter proc SearchNV_L
@bacLuong varchar(10)
as
select NV.PK_sMaNV,NV.sHoTen,CV.sChucVu,CV.fHeSoLuong,NV.sBacLuong,L.fLuongCoBan,L.fPhuCap
from tblNhanVien NV inner join tblChucVu CV
on NV.sMaCV = CV.PK_sMaCV inner join tblLuong L
on NV.sBacLuong = L.FK_BacLuong
where NV.sBacLuong = @bacLuong

exec SearchNV_L '3'

create proc alterBacLuong
@id nvarchar(10),
@bacLuong varchar(10)
as
update tblNhanVien
set sBacLuong =@bacLuong
where PK_sMaNV = @id



Backup database BTL to disk = 'D:\Study\C# Projects\BTL.bak'

use BTL

alter proc CRLuong 
as
Select NV.PK_sMaNV,NV.sHoTen,PB.sTenPB,L.fLuongCoBan,CV.fHeSoLuong,CV.sChucVu,L.fPhuCap,((L.fLuongCoBan*CV.fHeSoLuong)+L.fPhuCap) as Luong
from tblNhanVien NV inner join tblChucVu CV
on NV.sMaCV = CV.PK_sMaCV inner join tblLuong L
on NV.sBacLuong = l.FK_BacLuong inner join tblPhongBan PB
on NV.sMaPB = PB.PK_sMaPB


exec CRLuong

