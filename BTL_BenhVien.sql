CREATE DATABASE BTL_BenhVien
go

use BTL_BenhVien
go

-- =================== TABLES ===================

CREATE TABLE tblTaiKhoan
(
	iMaTK int IDENTITY,
	sTenTaiKhoan nvarchar(50) NOT NULL UNIQUE,
	sMatKhau nvarchar(50) NOT NULL
	CONSTRAINT PK_tblTaiKhoan PRIMARY KEY (iMaTK)
)
alter table tblTaiKhoan  add sSDT nvarchar(10);
go

select * from tblTaiKhoan
CREATE TABLE tblNhanVien
(
	sMaNhanVien nvarchar(50) NOT NULL,
	sTenNhanVien nvarchar(50) NOT NULL,
	sSDT nvarchar(20) NOT NULL UNIQUE,
	dNgaySinh date,
	sGioiTinh nvarchar(20) NOT NULL, -- N?, Nam
	CONSTRAINT PK_tblNhanVien PRIMARY KEY (sMaNhanVien),
	CONSTRAINT CK_tuoiNhanVien CHECK (DATEDIFF(DAY, dNgaySinh, GETDATE()) / 365 >= 18)
)
go

CREATE TABLE tblBacSi
(
	sMaBacSi nvarchar(50) NOT NULL,
	sTenBacSi nvarchar(50) NOT NULL,
	sSDT nvarchar(20) NOT NULL UNIQUE,
	sGioiTinh nvarchar(20) NOT NULL, -- N?, Nam
	dNgaySinh datetime,
	CONSTRAINT PK_tblBacSi PRIMARY KEY (sMaBacSi),
	CONSTRAINT CK_tuoiBacSi CHECK (DATEDIFF(DAY, dNgaySinh, GETDATE()) / 365 >= 18)
)
alter table tblBacSi add mota nvarchar(255) ;
alter table tblBacSi drop column soThich
go

CREATE TABLE tblBenhNhan
(
	sMaBenhNhan nvarchar(50) NOT NULL,
	sTenBenhNhan nvarchar(50) NOT NULL,
	sSDT nvarchar(20) NOT NULL UNIQUE,
	sGioiTinh nvarchar(20) NOT NULL, -- N?, Nam
	dNgaySinh datetime,
	CONSTRAINT PK_tblBenhNhan PRIMARY KEY (sMaBenhNhan),
)
go

CREATE TABLE tblLoaiDichVu
(
	iMaLoaiDichVu int ,
	sTenLoaiDichVu nvarchar(50) NOT NULL,
	CONSTRAINT PK_tblLoaiDichVu PRIMARY KEY (iMaLoaiDichVu)
)
go


CREATE TABLE tblDichVu
(
	iMaDichVu int ,
	sTenDichVu nvarchar(50) NOT NULL,
	iMaLoaiDichVu int NOT NULL,
	fGiaTien float DEFAULT 0,
	CONSTRAINT PK_tblDichVu PRIMARY KEY (iMaDichVu),
	CONSTRAINT FK_tblDichVu_tblLoaiDichVu_maLoaiDichVu FOREIGN KEY (iMaLoaiDichVu) 
		REFERENCES tblLoaiDichVu(iMaLoaiDichVu)
)
go


CREATE TABLE tblPhieuKham
(
	iSoPK int IDENTITY,
	dNgayLap date NOT NULL DEFAULT GETDATE(),
	iTrangThai int NOT NULL DEFAULT 0,-- 1: ĐÃ THANH TOÁN // 0: CHƯA THANH TOÁN
	sMaBacSi nvarchar(50) NOT NULL,
	sMaBenhNhan nvarchar(50) NOT NULL,
	sMaNhanVien nvarchar(50) NOT NULL,
	fTongTien float DEFAULT 0 NOT NULL,
	CONSTRAINT PK_tblPhieuKham PRIMARY KEY (iSoPK),
	CONSTRAINT FK_tblPhieuKham_tblBacSi FOREIGN KEY (sMaBacSi) REFERENCES tblBacSi(sMaBacSi),
	CONSTRAINT FK_tblPhieuKham_tblBenhNhan FOREIGN KEY (sMaBenhNhan) REFERENCES tblBenhNhan(sMaBenhNhan),
	CONSTRAINT FK_tblPhieuKham_tblNhanVien FOREIGN KEY (sMaNhanVien) REFERENCES tblNhanVien(sMaNhanVien),
)
go



CREATE TABLE tblChiTietPhieuKham
(
	iMaChiTietHoaDon int IDENTITY,
	iSoPK int NOT NULL,
	iMaDichVu int NOT NULL,
	iSoLuong int NOT NULL,
	fDonGia float DEFAULT 0 NOT NULL,
	CONSTRAINT PK_tblChiTietHoaDon PRIMARY KEY (iMaChiTietHoaDon, iSoPK),
	CONSTRAINT FK_tblChiTietHoaDon_tblPhieuKham FOREIGN KEY (iSoPK) REFERENCES tblPhieuKham(iSoPK),
	CONSTRAINT FK_tblChiTietHoaDon_tblDichVu FOREIGN KEY (iMaDichVu) REFERENCES tblDichVu(iMaDichVu)
)
go 





--------------------------------------------------------
SELECT * FROM tblBacSi
SELECT * FROM tblBenhNhan
SELECT * FROM tblNhanVien
SELECT * FROM tblLoaiDichVu
SELECT * FROM tblDichVu
SELECT * FROM tblPhieuKham
SELECT * FROM tblChiTietPhieuKham
SELECT * FROM tblTaiKhoan
-----------------------------------------------------------
go 

Create or alter proc dangnhap (@tk nvarchar(30), @mk nvarchar(30) )
as 
begin
   select  * from tblTaiKhoan where sTenTaiKhoan = @tk and sMatKhau=@mk ;
end 


insert into tblTaiKhoan values ('nam','1234','0123456789');


go 

create or alter proc quenmk (@sdt nvarchar(30)  , @mkmoi nvarchar(30))
as 
begin 
   update tblTaiKhoan set sMatKhau = @mkmoi where sSDT = @sdt;
end

go


--Bác s? 
create or alter proc pr_HIEN_BacSi
as
begin
select*
from tblBacSi
end

go

create or alter proc pr_THEM_BacSi (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime)
as
begin
		insert into tblBacSi(sMaBacSi, sTenBacSi,sSDT, sGioiTinh, dNgaySinh)
		values(@ma, @ten,@sdt, @gt, @ns)

end

go

create or alter proc pr_XOA_BacSi (@ma nvarchar(50))
as
begin
		delete from tblBacSi where sMaBacSi =@ma

end

go 

create or alter proc pr_SUA_BacSi (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime)
as
begin
		update tblBacSi set sTenBacSi = @ten,sSDT = @sdt, sGioiTinh=@gt,dNgaySinh= @ns
		where sMaBacSi = @ma
end


go 
--B?nh nhân
create or alter proc pr_HIEN_BenhNhan
as
begin
select*
from tblBenhNhan
end


go 

create or alter proc pr_THEM_BenhNhan (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime)
as
begin
		insert into tblBenhNhan(sMaBenhNhan, sTenBenhNhan,sSDT, sGioiTinh, dNgaySinh)
		values(@ma, @ten,@sdt, @gt, @ns)

end

go

create or alter proc pr_XOA_BenhNhan (@ma nvarchar(50))
as
begin
		delete from tblBenhNhan where sMaBenhNhan =@ma

end

go

create or alter proc pr_SUA_BenhNhan (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime)
as
begin
		update tblBenhNhan set sTenBenhNhan = @ten,sSDT = @sdt, sGioiTinh=@gt,dNgaySinh= @ns
		where sMaBenhNhan = @ma
end

go


--D?ch v?
create or alter proc pr_HIEN_DichVu
as
begin
select*
from tblDichVu
end

go

create or alter proc pr_THEM_DichVu ( @ma int, @ten nvarchar(50), @loai int,@gia float)
as
begin
		insert into tblDichVu(iMaDichVu, sTenDichVu, iMaLoaiDichVu, fGiaTien)
		values(@ma, @ten, @loai, @gia)

end

go

create or alter proc pr_XOA_DichVu (@ma nvarchar(50))
as
begin
		delete from tblDichVu where iMaDichVu =@ma

end

go

create or alter proc pr_SUA_DichVu (@ma int, @ten nvarchar(50), @loai int,@gia float)
as
begin
		update tblDichVu set sTenDichVu = @ten, iMaLoaiDichVu=@loai,fGiaTien=@gia
		where iMaDichVu = @ma
end

-- exec pr_THEM_DichVu 9,'adsfdsa',3,1212121

--Nhân viên
go

create or alter proc pr_HIEN_NhanVien
as
begin
select*
from tblNhanVien
end

go


create or alter proc pr_THEM_NhanVien (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime)
as
begin
		insert into tblNhanVien(sMaNhanVien, sTenNhanVien,sSDT, sGioiTinh, dNgaySinh)
		values(@ma, @ten,@sdt, @gt, @ns)

end

go


create or alter proc pr_XOA_NhanVien (@ma nvarchar(50))
as
begin
		delete from tblNhanVien where sMaNhanVien =@ma

end


go

create or alter proc pr_SUA_NhanVien (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime)
as
begin
		update tblNhanVien set sTenNhanVien = @ten,sSDT = @sdt, sGioiTinh=@gt,dNgaySinh= @ns
		where sMaNhanVien = @ma
end

go

--Proc tìm ki?m 
---------------
create or alter proc proc_TimKiemBacSi (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ngay int=0,@thang int =0,@nam int =0)
as
begin
     select * 
	 from tblBacSi
	 where sMaBacSi like N'%'+@ma+'%'  and sTenBacSi like N'%'+@ten+'%' and sSDT like N'%'+@sdt+'%'
	 and sGioiTinh like N'%'+@gt+'%'
	 
	 and
	 day(dNgaySinh)=
	 case when @ngay =0 then day(dNgaySinh) else @ngay
	 end
	 and
	 month(dNgaySinh)=
	 case when @thang =0 then month(dNgaySinh) else @thang
	 end
	 and
	 year(dNgaySinh)=
	 case when @nam =0 then year(dNgaySinh) else @nam
	 end

end

---exec proc_TimKiemBacSi '','','','Nam','','',''

go

create or alter proc proc_TimKiemBenhNhan (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ngay int=0,@thang int =0,@nam int =0)
as
begin
     select * 
	 from tblBenhNhan
	 where sMaBenhNhan like N'%'+@ma+'%'  and sTenBenhNhan like N'%'+@ten+'%' and sSDT like N'%'+@sdt+'%'
	 and sGioiTinh like N'%'+@gt+'%'
	 
	 and
	 day(dNgaySinh)=
	 case when @ngay =0 then day(dNgaySinh) else @ngay
	 end
	 and
	 month(dNgaySinh)=
	 case when @thang =0 then month(dNgaySinh) else @thang
	 end
	 and
	 year(dNgaySinh)=
	 case when @nam =0 then year(dNgaySinh) else @nam
	 end

end

go

--exec proc_TimKiemBenhNhan'','','','Nam','','',''

create or alter proc proc_TimKiemNhanVien (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ngay int=0,@thang int =0,@nam int =0)
as
begin
     select * 
	 from tblNhanVien
	 where sMaNhanVien like N'%'+@ma+'%'  and sTenNhanVien like N'%'+@ten+'%' and sSDT like N'%'+@sdt+'%'
	 and sGioiTinh like N'%'+@gt+'%'
	 
	 and
	 day(dNgaySinh)=
	 case when @ngay =0 then day(dNgaySinh) else @ngay
	 end
	 and
	 month(dNgaySinh)=
	 case when @thang =0 then month(dNgaySinh) else @thang
	 end
	 and
	 year(dNgaySinh)=
	 case when @nam =0 then year(dNgaySinh) else @nam
	 end

end
go


create or alter proc proc_TimKiemDichVu (@ma nvarchar(50), @ten nvarchar(50),@loai nvarchar(20) ,@gia nvarchar(20))
as
begin
     select * 
	 from tblDichVu
	 where sTenDichVu like N'%'+@ten+'%' 
	 and
	 fGiaTien=
	 case when @gia =0 then fGiaTien else @gia
	 end
	 and
	 iMaDichVu=
	 case when @ma =0 then iMaDichVu else @ma
	 end
	 and
	 iMaLoaiDichVu=
	 case when @loai =0 then iMaLoaiDichVu else @loai
	 end
end
go


--exec proc_TimKiemDichVu'','g','',''

--Phiếu khám
-- use BTL_BenhVien

CREATE PROC spThemPhieuKham @maBacSi nvarchar(50), @maBenhNhan nvarchar(50), @maNhanVien nvarchar(50)
AS
BEGIN
	INSERT INTO tblPhieuKham (sMaBacSi, sMaBenhNhan, sMaNhanVien)
	VALUES (@maBacSi, @maBenhNhan, @maNhanVien)
END
go


CREATE PROC spUpdatePhieuKham @soPhieuKham int, @maBacSi nvarchar(50), @maBenhNhan nvarchar(50), @maNhanVien nvarchar(50)
AS
BEGIN
	UPDATE tblPhieuKham
	SET sMaBacSi = @maBacSi, sMaBenhNhan = @maBenhNhan, sMaNhanVien = @maNhanVien
	WHERE iSoPK = @soPhieuKham
END
go


CREATE PROC spDeletePhieuKham @soPhieuKham int
AS
BEGIN
	DELETE FROM tblPhieuKham
	WHERE iSoPK = @soPhieuKham
END

go

CREATE PROC spDSDichVuTheoDanhMuc @maLoaiDichVu int
as
BEGIN
	SELECT * FROM tblDichVu WHERE iMaLoaiDichVu = @maLoaiDichVu
END

--EXEC spDSDichVuTheoDanhMuc 1
go

create PROC spShowHoaDon @soPK int
AS
BEGIN
	SELECT tblDichVu.iMaDichVu, tblDichVu.sTenDichVu, tblChiTietPhieuKham.iSoLuong, tblChiTietPhieuKham.fDonGia
	FROM tblChiTietPhieuKham, tblDichVu
	WHERE tblDichVu.iMaDichVu = tblChiTietPhieuKham.iMaDichVu AND tblChiTietPhieuKham.iSoPK = @soPK
END
go

--exec spShowHoaDon 1

create or alter PROC spThemChiTietHoaDon	@soPK int, @maDichVu int, @soLuong int, @donGia float
AS
BEGIN
	DECLARE @isExistChiTietHD int
	DECLARE @soLuongDichVu int = 1
	DECLARE @donGiaDichVu float

	SELECT @isExistChiTietHD = iMaChiTietHoaDon, @soLuongDichVu = iSoLuong, @donGiaDichVu = fDonGia
	FROM tblChiTietPhieuKham
	WHERE tblChiTietPhieuKham.iSoPK = @soPK AND tblChiTietPhieuKham.iMaDichVu = @maDichVu

	IF (@isExistChiTietHD > 0)
		BEGIN
			DECLARE @soLuongMoi int = @soLuongDichVu + @soLuong
			DECLARE @donGiaMoi float = @donGiaDichVu + @donGia
			IF (@soLuongMoi > 0)
				UPDATE tblChiTietPhieuKham 
				SET iSoLuong = @soLuongMoi, fDonGia = @donGiaMoi
				WHERE iMaDichVu = @maDichVu
			ELSE
				DELETE tblChiTietPhieuKham WHERE iSoPK = @soPK AND iMaDichVu = @maDichVu
		END
	ELSE
		BEGIN
			INSERT INTO tblChiTietPhieuKham (iSoPK, iMaDichVu, iSoLuong, fDonGia)
			VALUES (@soPK, @maDichVu, @soLuong, @donGia)
		END
END
go


CREATE PROC spDeleteChiTietHoaDon @soPk int, @maDichVu int
AS
BEGIN
	DELETE FROM tblChiTietPhieuKham
	WHERE iSoPK = @soPk AND iMaDichVu = @maDichVu
END

ALTER TABLE tblPhieuKham
ADD fTongTien float DEFAULT 0 NOT NULL

CREATE PROC spThanhToan @soPK int, @tongTien float
AS
BEGIN
	UPDATE tblPhieuKham
	SET iTrangThai = 1, fTongTien = @tongTien
	WHERE iSoPK = @soPK
END
go

-- thủ tục in hóa đơn
ALTER PROC spInHoaDon @soPK int
AS
BEGIN
	SELECT PK.iSoPK , BS.sTenBacSi, BN.sTenBenhNhan, NV.sTenNhanVien, DV.sTenDichVu, DV.fGiaTien, BILL.iSoLuong, BILL.fDonGia
	FROM tblBacSi AS BS, tblBenhNhan AS BN, tblNhanVien AS NV, tblDichVu AS DV, tblPhieuKham AS PK, tblChiTietPhieuKham AS BILL
	WHERE PK.iSoPK = @soPK AND PK.iSoPK = BILL.iSoPK AND BILL.iMaDichVu = DV.iMaDichVu
	AND PK.sMaBacSi = BS.sMaBacSi AND PK.sMaBenhNhan = BN.sMaBenhNhan AND PK.sMaNhanVien = NV.sMaNhanVien
END
go

-- thủ tục thống kê doanh thu
CREATE OR ALTER PROC spThongKeDoanhThu @ngay date
AS
BEGIN
	SELECT iSoPK , fTongTien
	FROM tblPhieuKham
	WHERE dNgayLap like @ngay  AND iTrangThai = 1
END
go

select * from tblPhieuKham

--xóa phiếu khám kể cả có chứa hóa đơn bên trong
create or alter proc spDeleteHoaDon @soPK int
as 
begin
	DELETE FROM tblChiTietPhieuKham 
	WHERE iSoPK = @soPk
	DELETE FROM tblPhieuKham 
	WHERE iSoPK = @soPk
end


go 

create or alter proc pr_THEM_BacSi1 (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime , @st nvarchar(100))
as
begin
		insert into tblBacSi(sMaBacSi, sTenBacSi,sSDT, sGioiTinh, dNgaySinh , soThich )
		values(@ma, @ten,@sdt, @gt, @ns,@st)

end

create or alter proc pr_THEM_mota_BacSi (@ma nvarchar(50), @ten nvarchar(50),@sdt nvarchar(20) , @gt nvarchar(20),@ns datetime , @mt nvarchar(100))
as
begin
		insert into tblBacSi(sMaBacSi, sTenBacSi,sSDT, sGioiTinh, dNgaySinh , mota )
		values(@ma, @ten,@sdt, @gt, @ns,@mt)

end

select * from tblBacSi
go


create proc inBS (@kitu nvarchar(30))
as 
begin 
 select * from tblBacSi 
 end 

