create database BTL_QuanLySinhVien_Nhom_G02
GO 
use BTL_QuanLySinhVien_Nhom_G02
GO 

-- Tao bang
create table tblSinhVien(
	sSoBD varchar(20) not null primary key,
	sHoTen nvarchar(255) not null,
	dNgaySinh DATE not null,
	sCMND varchar(15) not null unique,
	sTonGiao nvarchar(10) not null,
	sEmail varchar(255) not null,
	sTruongTotNghiep nvarchar(255) not null,
	sQueQuan nvarchar(255) not null,
	sGioiTinh nvarchar(10) not null,
	sMaLop varchar(20) not null
)

create table tblHoSoSinhVien(
	sMaHS varchar(255) not null primary key,
	sHoKhau nvarchar(255),
	iNamTotNghiep int,
	sHoTenBo nvarchar(50),
	sHoTenMe nvarchar(50),
	dThoiGianThu date,
	dThoiGianGui date,
	check(dThoiGianThu>dThoiGianGui),
	sSoBD varchar(20) not null,
	sMaCB varchar(20) not null
)

create table tblNganh(
	 sMaNganh varchar(20) not null primary key,
	 sTenNganh nvarchar(40),
	 sMaKhoa varchar(20) not null
)

create table tblKhoa(
	sMaKhoa varchar(20) not null primary key,
	sTenKhoa nvarchar(50),
	sDiaChi nvarchar(255)
)

create table tblDiemChuan(
	sSoBD varchar(20) not null,
	sMaNganh varchar(20) not null,
	sKhoiToHop varchar(10),
	fDiem1 float,
	fDiem2 float,
	fDiem3 float,
	fDiemUuTien float,
	check(fDiemUuTien>=0 and fDiemUuTien<=3)
)

create table tblHoaDonHocPhi(
	sMaHD varchar(20) not null primary key,
	fTongTien float,
	sSoBD varchar(20) not null,
	check(fTongTien>0)
)

create table tblCanBo(
	sMaCB varchar(20) not null primary key,
	sTenCB nvarchar(50),
	sSDT varchar(20),
	sMaNganh varchar(20) not null
)

create table tblLop(
	sMaLop varchar(20) not null primary key,
	sTenLop varchar(20),
	sMaNganh varchar(20)
)

-- Tao khoa chinh, khoa ngoai
alter table tblSinhVien
add foreign key (sMalop) references tblLop(sMaLop)

alter table tblHoSoSinhVien
add foreign key  (sSoBD) references tblSinhVien(sSoBD),foreign key (sMaCB) references tblCanBo(sMaCB)

alter table tblNganh
add foreign key (sMaKhoa) references tblKhoa(sMakhoa)

alter table tblDiemChuan
add primary key(sSoBD,sMaNganh)

alter table tblDiemChuan
add foreign key (sSoBD) references tblSinhVien(sSoBD),
	foreign key (sMaNganh) references tblNganh(sMaNganh)

alter table tblHoaDonHocPhi
add foreign key (sSoBD) references tblSinhVien(sSoBD)

alter table tblCanBo
add foreign key (sMaNganh) references tblNganh(sMaNganh)

alter table tblLop
add foreign key (sMaNganh) references tblNganh(sMaNganh)

---------------Nhap Data--------------
INSERT INTO dbo.tblKhoa (sMaKhoa, sTenKhoa,sDiaChi)
VALUES ( 'K1', N'Khoa kế toán', N'Kim Đồng'),
	('K2',N'Khoa công nghệ thông tin',N'Định Công'),
	('K3',N'Khoa ngôn ngữ Anh',N'Giải Phóng'),
	('K4',N'Khoa thương mại điện tử',N'Kim Giang'),
	('K5',N'Khoa điện tử hoá',N'Tân Mai')
select * from tblKhoa
delete from tblKhoa


INSERT INTO dbo.tblNganh(sMaNganh,sTenNganh,sMaKhoa)
VALUES('N1',N'Kế toán', 'K1'),
	('N2',N'Công nghệ thông tin','K2'),
	('N3',N'Ngôn ngữ Anh','K3'),
	('N4',N'Thương mại','K4'),
	('N5',N'Điện tử hoá','K5')
select * from tblDiemchuan
delete from tblNganh

INSERT INTO dbo.tblLop( sMaLop,sTenLop,sMaNganh)
VALUES ('A1',N'Toán','N1'),
	   ('A2',N'Lý','N2'),
	   ('A3',N'Hóa','N3'),
       ('A4',N'Sinh','N4'),
	   ('A5',N'Văn','N5')
select * from tblLop
delete from tblLop

INSERT INTO tblSinhVien
(
    sSoBD,sHoten, dNgaysinh, sCMND, sTongiao, sEmail, sTruongtotnghiep, sQuequan, sGioitinh, sMalop
)
VALUES
('SV1', N'Nguyễn Trà My','20040724','031303001890', N'Không','tramy@gmail.com',N'THPT Quang Trung', N'Hải Phòng', N'Nữ','A1'),
('SV2', N'Lê Thanh Trúc','20080623','031663626789', N'Không','thanhtruc06@gmal.com',N'THPT Trần Phú',N'Hà Nội', N'Nữ','A2'),
('SV3', N'Bùi Thành Trung','20041010','031878393780',N'Không','thanhtrung1@gmail.com',N'THPT Mê Linh',N'Qảng Ninh',N'Nam','A3'),
('SV4', N'Hà Quỳnh Anh','20010511', '035145375256',N'Không','qanh115@gmail.com',N'THPT Thái Phiên',N'Thái Bình', N'Nữ', 'A4'),
('SV5', N'Trần Phương Nam','20070906','034527865775',N'Không','namtran27@gmail.com',N'THPT Ngô Quyền',N'Hà Nội',N'Nam','A5')
select * from tblSinhVien
delete from tblSinhVien

INSERT INTO tblCanBo (sMaCB, sTenCB, sSDT, sMaNganh)
VALUES ('CB01', N'Phan Hoài Thanh','01234567', 'N1'),
	   ('CB02',	N'Nguyễn Thanh Sơn','09817362','N2'),
	   ('CB03',	N'Lê Hải Yến','08762863','N1'),
	   ('CB04',	N'Trần Anh Tuấn','09898261','N3'),
	   ('CB05',	N'Nguyễn Thu Thủy','09982662','N4'),
	   ('CB06',	N'Trần Thanh Mai','09818262','N5')
select * from tblCanBo
delete from tblCanBo	 

INSERT INTO tblHoSoSinhVien 
(
	sMaHS, sHoKhau, iNamTotNghiep, sHoTenBo, sHoTenMe, dThoiGianThu, dThoiGianGui, sSoBD, sMaCB
)
VALUES ('HS01', '12345', '2022', N'Nguyễn Văn Huy', N'Trần Trà Hương', '2022-09-20', '2022-09-15', 'SV1', 'CB01' ),
	   ('HS02', '23456', '2021', N'Lê Việt Anh', N'Nguyễn Thị Hải', '2022-09-21', '2022-09-16', 'SV2', 'CB02' ),
	   ('HS03', '56782', '2022', N'Bùi Thành Công', N'Nguyễn Mai Linh', '2022-09-20', '2022-09-17', 'SV3', 'CB03' ),
	   ('HS04', '98162', '2021', N'Hà Văn Chính', N'Đỗ Như Quỳnh', '2022-09-18', '2022-09-14', 'SV4', 'CB04' ),
	   ('HS05', '99712', '2022', N'Trần Anh Duy', N'Vũ Thu Hương', '2022-09-25', '2022-09-20', 'SV5', 'CB05' )

select * from tblHoSoSinhVien
delete from tblSinhVien

INSERT INTO tblHoaDonHocPhi (sMaHD, fTongTien, sSoBD)
VALUES ('HD01', '12600000', 'SV1'),
	   ('HD02', '7565000', 'SV2'),
	   ('HD03', '10380000', 'SV3'),
	   ('HD04', '9455000', 'SV4'),
	   ('HD05', '11220000', 'SV5')
select * from tblHoaDonHocPhi
delete from tblHoaDonHocPhi

INSERT INTO tblDiemChuan (sSoBD, sMaNganh, sKhoiToHop, fDiem1, fDiem2, fDiem3, fDiemUuTien)
VALUES ('SV1','N2','A00', '8.0', '7.8', '8.2','0.25')
delete from tblDiemChuan where sSoBD='SV1'

select * from tblDiemChuan
select * from tblKhoa
select * from tblNganh
select * from tblLop
select * from tblSinhVien
select * from tblHoSoSinhVien
select * from tblDiemChuan
select * from tblCanBo
select * from tblHoaDonHocPhi
	
alter proc sp_sinhvien as
begin
	select sSoBD, sHoTen, dNgaySinh from tblSinhVien
end
create proc sp_sinhvientheolop @id_lop varchar(10)
as
begin
	select * from tblSinhVien where sMaLop=@id_lop
end


create proc sp_tongnganh 
as 
begin
	select sMaKhoa, count(sMaNganh) as tong_so from tblNganh 
	group by sMaKhoa
end
--Tạo view và select 
--1. Chọn ra các sinh viên có quê quán là Hà Nội
select * from tblDiemChuan
where sQuequan like N'Hà Nội'
insert into tblSinhVien values('SV6',N'Phạm Duy Trường','11-03-2003','0321932138123',N'Không','truongpham@gmail.com',N'THPT Tây Hồ',N'Hà Nội',N'Nam','A3')
--2. Hãy cho biết các giáo viên đang công tác tại ngành công nghệ thông tin
select * from tblCanBo as CB
inner join tblNganh as N
on CB.sMaNganh=N.sManganh
where sTennganh like N'Công nghệ thông tin'
delete from tblDiemChuan where sSoBD='SV6'

--3. Tìm sinh viên có điểm chuẩn lớn nhất của tất cả các ngành
select top 1 DC.sSoBD,sMaNganh,sHoTen,(fDiem1+fDiem2+fDiem3+fDiemuutien) as tong_diem from tblDiemChuan as DC
inner join tblSinhVien as SV
on DC.sSoBD=SV.sSoBD
order by (fDiem1+fDiem2+fDiem3+fDiemuutien) desc

--4. Tạo view đếm số sinh viên có điểm chuẩn lớn hơn 25
create view vvSVTheoDiem as
select count(sHoten) as tong_so_sv from tblSinhVien as SV
inner join tblDiemChuan as DC
on SV.sSoBD=DC.sSoBD
where (fDiem1+fDiem2+fDiem3+fDiemuutien)>25

select * from vvSVTheoDiem

--5. Tạo view cho biết các sinh viên có giới tính là "Nam"
create view vvSVTheoGT as
select * from tblSinhVien
where sGioitinh like N'Nam'

select * from vvSVTheoGT
--6. Tạo view cho biết số báo danh, họ tên sinh viên đã tốt nghiệp năm 2021
create view vvSVTheoNamTN as
select SV.sSoBD,SV.sHoten,iNamtotnghiep from tblSinhVien as SV
inner join tblHoSoSinhVien as HSSV
on SV.sSoBD=HSSV.sSoBD
where iNamtotnghiep=2021

select * from vvSVTheoNamTN

--7. Tạo view cho biết tên, số điện thoại của cán đang công tác tại khoa điện tử hóa
create view vvTimCanBo as
select sTenCB,sSDT from tblCanBo
where sMaNganh in 
(
select N.sManganh from tblNganh as N
inner join tblKhoa as K
on N.sMaKhoa=K.sMaKhoa
where sTenkhoa = N'Khoa điện tử hóa'
)
select * from vvTimCanBo

------Tạo thủ tục------------
--1. Tạo thủ tục cho biết các sinh viên đã tốt nghiệp theo năm nào đó (năm là tham số truyền vào)
create proc spTkeSVTheoNamTN @nam_tot_nghiep int as
begin
	select * from tblSinhVien as SV
	inner join tblHoSoSinhVien as HSSV
	on SV.sSoBD=HSSV.sSoBD
	where iNamtotnghiep=@nam_tot_nghiep
end
exec spTkeSVTheoNamTN 2022


--2. Tạo thủ tục thống kê các lớp thuộc 1 ngành nào đó (Với ngành là tham sổ truyền vào)
create proc spTkeLopTheoNganh @ten_nganh nvarchar(40) as
begin
	select L.* from tblLop as L
	inner join tblNganh as N
	on L.sMaNganh=N.sManganh
	where N.sTennganh=@ten_nganh
end 
exec spTkeLopTheoNganh N'Điện tử hóa'


--3. Tạo thủ tục cho biết các sinh viên đạt điểm chuẩn nào đó sẽ đỗ vào trường (Với điểm chuẩn là tham số truyền vào)
create proc spTkeSVDo @diem_chuan float as
begin 
	select SV.sSoBD,sHoten,(fDiem1+fDiem2+fDiem3+fDiemuutien) as tong_diem from tblSinhVien as SV
	inner join tblDiemChuan as DC
	on SV.sSoBD=DC.sSoBD
	where (fDiem1+fDiem2+fDiem3+fDiemuutien)>@diem_chuan
end
exec spTkeSVDo 23


--4. Tạo thủ đếm số sinh viên thuộc 1 lớp nào đó( với lớp là tham số truyền vào) và giới tính cũng là tham số truyền vào
create proc spTkeSVTheoLopVaGT @ma_lop varchar(20),@gioi_tinh nvarchar(10) as
begin
	select SV.* from tblSinhVien as SV
	inner join tblLop as L
	on SV.sMalop=L.sMaLop
	where SV.sGioitinh=@gioi_tinh and L.sMaLop=@ma_lop
end
exec spTkeSVTheoLopVaGT 'A3',N'Nam'

--5. Tạo thủ tục cho biết tên cán bộ đã thu hồ sơ của sinh viên nào đó với số báo danh là tham số truyền vào 
create proc spTimTenCBThuHS @so_bao_danh varchar(20) as 
begin 
	select sTenCB,SV.sSoBD,sHoten,sMaHS from tblHoSoSinhVien as HSSV
	inner join tblCanBo as CB
	on HSSV.sMaCB=CB.sMaCB
	inner join tblSinhVien as SV
	on HSSV.sSoBD=SV.sSoBD
	where SV.sSoBD = @so_bao_danh
end
exec spTimTenCBThuHS 'SV3'
--6. Tạo thủ tục đếm số sinh viên có điểm ưu tiên theo từng mức điểm và có điểm chuẩn lớn hơn 1 số nào đó (với điểm chuẩn là tham số truyền vào)
create proc spTkeSVTheoDiemuutien @diem_chuan float as
begin
	select fDiemuutien,count(sSoBD) as tong_so_sv  from tblDiemChuan 
	where (fDiem1+fDiem2+fDiem3+fDiemuutien)>@diem_chuan
	group by fDiemuutien
end
exec spTkeSVTheoDiemuutien 24
--7. Tạo thủ tục cho biết tên sinh viên đã đóng tiền lớn hơn 1 số nào đó (với số tiền là tham số truyền vào)
create proc spTkeSVDongTien @tong_tien float as
begin
	select SV.sSoBD,SV.sHoten,HDPH.fTongtien from tblHoaDonHocPhi as HDPH
	inner join tblSinhVien as SV
	on HDPH.sSoBD=SV.sSoBD
	where fTongtien>@tong_tien
end
exec spTkeSVDongTien 9500000

-----------Tạo trigger---------
--1. Thêm cột iSiSo vào bảng tblLop. Tạo trigger khi thêm sinh viên vào bảng tblSinhVien thì sẽ tự động động cập nhật sĩ số của lớp
alter table tblLop
add iSiSo int 

update tblLop 
set iSiSo=1

create trigger tgSiSoLop_add on tblSinhVien
for insert
as
begin
	declare @ma_lop varchar(20)
	select @ma_lop=sMaLop from inserted

	update tblLop
	set iSiSo=iSiSo+1
	where sMaLop=@ma_lop
end
create trigger tgSiSoLop_remove on tblSinhVien
for delete 
as
begin
	declare @ma_lop varchar(20)
	select @ma_lop=sMaLop from deleted

	update tblLop
	set iSiSo=iSiSo-1
	where sMaLop=@ma_lop
end
INSERT INTO dbo.tblSinhVien(sSoBD,sHoten, dNgaysinh, sCMND, sTongiao, sEmail, sTruongtotnghiep, sQuequan, sGioitinh, sMalop)
VALUES
('SV6', N'Nguyễn Hồng Hà','2005-03-29','0928327372734', N'Không','hh234@gmail.com',N'THPT Hoàng Diệu', N'Thanh Hóa', N'Nữ','A3')
select * from tblLop
select * from tblSinhVien


--2. Thêm cột fMucgiamhocphi vào bảng tblSinhVien, cột fTiendadong vào bảng tblHoaDonHocPhi. Khi thêm 1 sinh viên mà có mức giảm học phí thì sẽ tự cập nhật tổng tiền trong bảng tblHoaDonHocPhi
alter table tblSinhVien
add fMucgiamhocphi float 

alter table tblHoaDonHocPhi
add fTiendadong float

update tblSinhVien
set fMucgiamhocphi=0

alter trigger tgGiamHocPhi on tblHoaDonHocPhi
for insert
as
begin
	declare @so_bao_danh varchar(20) 
	select @so_bao_danh=sSoBD from inserted

	declare @muc_giam float
	select @muc_giam=fMucgiamhocphi from tblSinhVien
	where sSoBD=@so_bao_danh

	update tblHoaDonHocPhi
	set fTongtien=fTiendadong
	where sSoBD=@so_bao_danh
end
alter trigger tgGiamHocPhi_upt on tblHoaDonHocPhi
for update 
as
begin
	declare @so_bao_danh varchar(20) 
	select @so_bao_danh=sSoBD from inserted

	declare @muc_giam float
	select @muc_giam=fMucgiamhocphi from tblSinhVien
	where sSoBD=@so_bao_danh
	
	print @so_bao_danh

	update tblHoaDonHocPhi
	set fTongtien=fTiendadong-@muc_giam
	where sSoBD=@so_bao_danh
end
alter trigger tgGiamHocPhi_upt_sv on tblSinhVien
for update 
as
begin
	declare @so_bao_danh varchar(20) 
	select @so_bao_danh=sSoBD from inserted

	declare @muc_giam float
	select @muc_giam=fMucgiamhocphi from tblSinhVien
	where sSoBD=@so_bao_danh

	print @so_bao_danh

	update tblHoaDonHocPhi
	set fTongtien=fTongtien
	where sSoBD=@so_bao_danh
end
INSERT INTO tblHoaDonHocPhi (sMaHD,sSoBD,fTiendadong)
VALUES ('HD02', 'SV2','9000000')


update tblHoaDonHocPhi
set fTiendadong=7000000
where sSoBD='SV2'

update tblSinhVien
set fMucgiamhocphi=2000000
where sSoBD='SV2'

delete from tblHoaDonHocPhi where sMaHD='HD04'
select * from tblHoaDonHocPhi
select * from tblSinhVien


--3. Thêm cột fLuong vào bảng tblCanBo. Khi thêm 1 cán bộ thì lương sẽ được tính như sau:
-- Ngành Công nghệ thông tin: Luong=Luong + 400000
-- Ngành Kế toán: Lương = Luong + 600000
-- Ngành Ngôn ngữ Anh: Lương = Lương + 280000
-- Ngành Điện tử hóa: Lương = Lương + 500000
alter table tblCanBo
add fLuong float

update tblCanBo
set fLuong=8000000

select * from tblCanBo

create trigger tgLuongCB on tblCanBo 
for insert 
as
begin
	declare @ma_can_bo varchar(20)
	select @ma_can_bo=sMaCB from inserted
	
	declare @luong float
	select @luong=fLuong from inserted

	declare @nganh varchar(20) 
	select @nganh=sMaNganh from inserted

	if @nganh = 'N1'
		begin 
			update tblCanBo 
			set fLuong=@luong+600000
			where sMaCB=@ma_can_bo
		end	
	else if @nganh='N2'
		begin 
			update tblCanBo 
			set fLuong=@luong+400000
			where sMaCB=@ma_can_bo
		end
	else if @nganh='N3'
		begin 
			update tblCanBo 
			set fLuong=@luong+280000
			where sMaCB=@ma_can_bo
		end
	else if @nganh='N5'
		begin 
			update tblCanBo 
			set fLuong=@luong+500000
			where sMaCB=@ma_can_bo
		end
end
INSERT INTO tblCanBo (sMaCB, sTenCB, sSDT, sMaNganh,fLuong)
VALUES ('CB07', N'Trần Thái Hoàn','0931289378', 'N1',6400000)
INSERT INTO tblCanBo (sMaCB, sTenCB, sSDT, sMaNganh,fLuong)
VALUES ('CB08', N'Tạ Quang Khải','0932189384', 'N2',7600000)
INSERT INTO tblCanBo (sMaCB, sTenCB, sSDT, sMaNganh,fLuong)
VALUES ('CB09', N'Nông Văn Sĩ','03912837124', 'N3',5050000)
INSERT INTO tblCanBo (sMaCB, sTenCB, sSDT, sMaNganh,fLuong)
VALUES ('CB010', N'Chu Cẩm Thái','09389857823', 'N5',8090000)


select * from tblNganh
select * from tblCanBo
--4. Thêm cột dNgaydong vào bảng tblSinhVien và bảng tblHoaDonHocPhi. Khi thêm 1 hóa đơn sẽ tự động cập nhật ngày đóng tiền cho bảng tblHoaDonHocPhi
alter table tblHoaDonHocPhi 
add dNgaydong date

alter trigger tgNgayDongHocPhi on tblHoaDonHocPhi
for insert 
as
begin
	declare @ma_hoa_don varchar(20)
	select @ma_hoa_don=sMaHD from inserted

	declare @ngay_dong date
	set @ngay_dong=GETDATE()

	update tblHoaDonHocPhi
	set dNgaydong=@ngay_dong
	where sMaHD=@ma_hoa_don
end
INSERT INTO tblHoaDonHocPhi (sMaHD, fTiendadong, sSoBD)
VALUES ('HD01','12000000', 'SV1')

delete from tblHoaDonHocPhi
select * from tblHoaDonHocPhi
select * from tblSinhVien
--5. Thêm cột tổng số ngành vào trong bảng tblKhoa. Khi thêm 1 ngành thì sẽ cập nhật tổng số ngành trong bảng tblKhoa
alter table tblKhoa 
add iTongSoNganh int

update tblKhoa
set iTongSoNganh=1

create trigger tgTongSoKhoa on tblNganh
for insert 
as 
begin
	declare @ma_khoa varchar(20) 
	select @ma_khoa=sMaKhoa from inserted

	update tblKhoa
	set iTongSoNganh=iTongSoNganh+1
	where sMaKhoa=@ma_khoa
end
alter trigger tgTongSoKhoa_del on tblNganh
for delete 
as 
begin
	declare @ma_khoa varchar(20) 
	select @ma_khoa=sMaKhoa from deleted

	update tblKhoa
	set iTongSoNganh=iTongSoNganh-1
	where sMaKhoa=@ma_khoa
end
INSERT INTO dbo.tblNganh(sMaNganh,sTenNganh,sMaKhoa)
VALUES('N6',N'Kế toán', 'K1')

delete from tblNganh where sManganh='N6'
select * from tblKhoa
select * from tblNganh
--------Phân quyền----------
------Phạm Duy Trường-------------
create login truong
with password ='1';

create user truong_sinhvien1
for login truong
with default_schema=BTL_QuanLySinhVien_Nhom_G02;

grant select,update 
on tblSinhVien
to truong_sinhvien1;

grant all 
on tblDiemChuan
to truong_sinhvien1;

REVOKE select ON tblSinhVien FROM truong_sinhvien1;

--------Ngô Thị Trang------------
create login thitrang
with password ='2';

create user thitrang_canbo
for login thitrang
with default_schema=BTL_QuanLySinhVien_Nhom_G02;

grant select,update, delete 
on tblCanBo
to thitrang_canbo;

grant all 
on tblNganh
to thitrang_canbo;

REVOKE delete ON tblNganh FROM thitrang_canbo;

--------Phạm Thị Thu Trang----------
create login thutrang
with password = '123456'

create user thutrang_hoadon
for login thutrang
with default_schema=BTL_QuanLySinhVien_Nhom_G02;

grant all on tblHoaDonHocPhi to thutrang_hoadon
grant insert, select on tblDiemChuan to thutrang_hoadon

REVOKE delete ON tblHoaDonHocPhi FROM thutrang_hoadon;

--------------Phân tán------------------
create database QuanLySinhVien_PT

use QuanLySinhVien_PT
-----Phân tán dọc cho bảng sinh viên-------
create table tblSinhVien_PT_tram1(
	sSoBD varchar(20) primary key,
	sHoten nvarchar(255),
	dNgaysinh date,
	sCMND varchar(15) UNIQUE,
	sTongiao nvarchar(10),
	sEmail varchar(255),
	sTruongtotnghiep nvarchar(255),
	sQuequan nvarchar(255)
)
create synonym tram1 for QuanLySinhVien_PT.dbo.tblSinhVien_PT_tram1
create synonym tram2 for MAYAO.QuanLySinhVien_PT.dbo.tblSinhVien_PT_tram2


-------Lấy dữ liệu từ bảng cũ sang bảng được phân tán----------
insert into tram1(sSoBD,sHoten,dNgaysinh,sCMND,sTongiao,sEmail,sTruongtotnghiep,sQuequan)
select sSoBD,sHoten,dNgaysinh,sCMND,sTongiao,sEmail,sTruongtotnghiep,sQuequan from BTL_QuanLySinhVien_Nhom_G02.dbo.tblSinhVien

select * from tram1

insert into tram2(sSoBD,sGioitinh,sMaLop,fMucgiamhocphi)
select sSoBD,sGioitinh,sMaLop,fMucgiamhocphi from BTL_QuanLySinhVien_Nhom_G02.dbo.tblSinhVien

select * from tram2


--Tạo thủ tục tự động phân tán dữ liệu
create proc spPTSinhVien @sSoBD varchar(20), @ho_ten nvarchar(255), @dNgaysinh date,@CMND varchar(15),@ton_giao nvarchar(10),@email varchar(255),@truong_tn nvarchar(255),@que_quan nvarchar(255),@gioi_tinh nvarchar(10),@lop varchar(20),@muc_giam float as
begin
	INSERT INTO tblSinhVien(sSoBD,sHoten, dNgaysinh, sCMND, sTongiao, sEmail, sTruongtotnghiep, sQuequan, sGioitinh, sMalop,fMucgiamhocphi)
	VALUES (@sSoBD,@ho_ten,@dNgaysinh,@CMND,@ton_giao,@email,@truong_tn,@que_quan,@gioi_tinh,@lop,@muc_giam)

	insert into tram1(sSoBD,sHoten,dNgaysinh,sCMND,sTongiao,sEmail,sTruongtotnghiep,sQuequan)
	select sSoBD,sHoten,dNgaysinh,sCMND,sTongiao,sEmail,sTruongtotnghiep,sQuequan from BTL_QuanLySinhVien_Nhom_G02.dbo.tblSinhVien where sSoBD=@sSoBD

	insert into tram2(sSoBD,sGioitinh,sMaLop,fMucgiamhocphi)
	select sSoBD,sGioitinh,sMaLop,fMucgiamhocphi from BTL_QuanLySinhVien_Nhom_G02.dbo.tblSinhVien where sSoBD=@sSoBD
end

exec spPTSinhVien 'SV7', N'Phạm Thu Hằng','2003-11-03','092183128774', N'Không','thuhang@gmail.com',N'THPT Nguyễn Công Trứ', N'Hà Giang', N'Nữ','A3','1500000'


delete from tram1 where sSoBD ='SV7'
delete from tram2 where sSoBD ='SV7'

delete from tblSinhVien where sSoBD='SV7'

select * from tblSinhVien

use QuanLySinhVien_PT
use BTL_QuanLySinhVien_Nhom_G02


select * from tram1
select * from tram2

--Tạo view cho biết những sinh viên có giới tính là nam
create view vvGioiTinhSV_PT as
select tram1.*,tram2.sGioitinh,tram2.sMaLop,tram2.fMucgiamhocphi from tram1
inner join tram2
on tram1.sSoBD=tram2.sSoBD
where sGioitinh=N'Nam'

select * from vvGioiTinhSV_PT

-------------Phân tán ngang theo bảng Khoa ----------------

create table tblKhoa_PT_tram1(
	sMaKhoa varchar(20) primary key,
	sTenkhoa nvarchar(50),
	sDiachi nvarchar(20),
	iTongsonganh int
)

--Phân tán cơ sở dữ liệu theo địa chỉ trạm 1 là Kim Đồng, trạm 2 là phần còn lại
create synonym tram1_Khoa for QuanLySinhVien_PT.dbo.tblKhoa_PT_tram1
create synonym tram2_Khoa for MAYAO.QuanLySinhVien_PT.dbo.tblKhoa_PT_tram2

insert into tram1_Khoa(sMaKhoa,sTenkhoa,sDiachi,iTongsonganh)
select sMaKhoa,sTenkhoa,sDiachi,iTongSoNganh from BTL_QuanLySinhVien_Nhom_G02.dbo.tblKhoa where sDiachi like N'%Kim Đồng%'

insert into tram2_Khoa(sMaKhoa,sTenkhoa,sDiachi,iTongsonganh)
select sMaKhoa,sTenkhoa,sDiachi,iTongSoNganh from BTL_QuanLySinhVien_Nhom_G02.dbo.tblKhoa where  sDiachi not like N'%Kim Đồng%'

create proc spPTKhoa @ma_khoa varchar(20),@ten_khoa nvarchar(50),@dia_chi nvarchar(255),@tong_nganh int as
begin
	insert into tblKhoa(sMaKhoa,sTenkhoa,sDiachi,iTongSoNganh)
	values(@ma_khoa,@ten_khoa,@dia_chi,@tong_nganh)
	
	if @dia_chi like N'%Kim Đồng%'
		begin
			insert into tram1_Khoa(sMaKhoa,sTenkhoa,sDiachi,iTongsonganh)
			select sMaKhoa,sTenkhoa,sDiachi,iTongSoNganh from BTL_QuanLySinhVien_Nhom_G02.dbo.tblKhoa 
			where sDiachi like N'%Kim Đồng%' and sMaKhoa=@ma_khoa
		end
	else
		begin
			insert into tram2_Khoa(sMaKhoa,sTenkhoa,sDiachi,iTongsonganh)
			select sMaKhoa,sTenkhoa,sDiachi,iTongSoNganh from BTL_QuanLySinhVien_Nhom_G02.dbo.tblKhoa 
			where  sDiachi not like N'%Kim Đồng%' and sMaKhoa=@ma_khoa
		end
end

exec spPTKhoa 'K8', N'Khoa sinh học', N'Kim Đồng',1

select * from tblKhoa
select * from tram1_Khoa
select * from tram2_Khoa

delete from tram1_Khoa where sMaKhoa='K7'

delete from tram2_Khoa where sMaKhoa='K8'
delete from tblKhoa where sMaKhoa='K7'


use QuanLySinhVien_PT
use BTL_QuanLySinhVien_Nhom_G02


--Câu 1
alter table tblKhoa 
add iTongSoNganh int

create proc spCapnhatTongNganh @ma_khoa varchar(20) as
begin
	declare @tong_so int 
	select @tong_so=count(sManganh) from tblNganh
	where sMaKhoa=@ma_khoa
	group by sMaKhoa

	update tblKhoa
	set iTongSoNganh=@tong_so
	where sMaKhoa=@ma_khoa
end	
select * from tblKhoa
select * from tblNganh
exec spCapnhatTongNganh 'K1'


insert into tblNganh(sManganh,sTennganh,sMaKhoa)
values('N6','Thời Trang','K1')

--câu 2
create trigger tgTongSoNganh on tblNganh
for insert 
as 
begin
	declare @ma_khoa varchar(20) 
	select @ma_khoa=sMaKhoa from inserted

	update tblKhoa
	set iTongSoNganh=iTongSoNganh+1
	where sMaKhoa=@ma_khoa
end
create trigger tgTongSoNganh_del on tblNganh
for delete 
as 
begin
	declare @ma_khoa varchar(20) 
	select @ma_khoa=sMaKhoa from deleted

	update tblKhoa
	set iTongSoNganh=iTongSoNganh-1
	where sMaKhoa=@ma_khoa
end
INSERT INTO dbo.tblNganh(sMaNganh,sTenNganh,sMaKhoa)
VALUES('N8',N'Thời Trang', 'K2')
delete from tblNganh where sManganh='N8'
use BTL_QuanLySinhVien_Nhom_G02


select * from tblKhoa
select * from tblNganh

--câu 3 
create view vvHienThongTinSV as
select tram1.sSoBD,sHoten,dNgaysinh,sGioitinh,fMucgiamhocphi from tram1
inner join tram2
on tram1.sSoBD=tram2.sSoBD

select * from vvHienThongTinSV

alter proc sp_HoSoTheoHocSinh @masv varchar(max)
as
begin
	select sv.sSoBD,sv.sHoTen,hs.* from tblSinhVien as sv
	inner join tblHoSoSinhVien as hs
	on sv.sSoBD=hs.sSoBD
	where sv.sSoBD=@masv
end
create proc sp_TTSVTheoLop @malop varchar(max)
as
begin
	select l.sMaLop,l.sTenLop,sv.sSoBD,sv.sHoTen,sv.sCMND from tblLop as l
	inner join tblSinhVien as sv
	on l.sMaLop=sv.sMaLop
	where l.sMaLop=@malop
end

select * from tblDiemChuan
select * from tblKhoa
select * from tblNganh
select * from tblLop
select * from tblSinhVien
select * from tblHoSoSinhVien
select * from tblDiemChuan
select * from tblCanBo
select * from tblHoaDonHocPhi

create proc sp_HienSVTheoLop 
as
begin
	select l.sMaLop,l.sTenLop,sv.sSoBD,sv.sHoTen,sv.sCMND from tblLop as l
	inner join tblSinhVien as sv
	on l.sMaLop=sv.sMaLop
	order by sMaLop
end

create view vv_SiSoTungLop 
as 
select l.sMaLop,l.sTenLop,count(sv.sSoBD ) as si_so from tblLop as l
inner join tblSinhVien as sv
on l.sMaLop=sv.sMaLop
group by l.sMaLop,l.sTenLop

select * from vv_SiSoTungLop

create proc sp_TTNganhTheoKhoa @makhoa varchar(max)
as 
begin
	select k.sMaKhoa,k.sTenKhoa,n.sMaNganh,n.sTenNganh from tblKhoa as k
	inner join tblNganh as n
	on k.sMaKhoa = n.sMaKhoa
	where k.sMaKhoa=@makhoa
end

exec sp_TTNganhTheoKhoa 'K1'