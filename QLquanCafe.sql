CREATE DATABASE QUANLYQUANCAPHE
GO

USE QUANLYQUANCAPHE
GO
CREATE TABLE NHANVIEN(
sMaNV VARCHAR(10) PRIMARY KEY NOT NULL,
sTenNV NVARCHAR(50) NOT NULL,
dNgaySinh DATE NOT NULL,
sGioiTinh nvarchar(5),
sDiaChi NVARCHAR(50) NOT NULL,
sChucVu nvarchar(15),
fHsl FLOAT,
sPassword varchar(15)
);

CREATE TABLE HOADON
(
sMaHD VARCHAR(15) PRIMARY KEY NOT NULL,
sMaNV VARCHAR(10),
dNgayLap DATE DEFAULT GETDATE()
);

CREATE TABLE SANPHAM
(
sMaSP VARCHAR(10) PRIMARY KEY NOT NULL,
sTenSP NVARCHAR(50),
iDonGia INT
);

CREATE TABLE CHITIETHOADON(
sMaHD VARCHAR(15) NOT NULL,
sMaSP VARCHAR(10) NOT NULL,
iSoLuong INT NOT NULL,
);
ALTER TABLE dbo.CHITIETHOADON
ADD PRIMARY KEY(sMaHD,sMaSP);

----- Add constain-------------------------------------
ALTER TABLE dbo.HOADON
ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY(sMaNV) REFERENCES dbo.NHANVIEN(sMaNV)
ON DELETE CASCADE   
ON UPDATE CASCADE

GO

ALTER TABLE dbo.CHITIETHOADON
ADD CONSTRAINT FK_HOADON_CHITIETHOADON FOREIGN KEY(sMaHD) REFERENCES dbo.HOADON(sMaHD)
ON DELETE CASCADE
ON UPDATE CASCADE

GO
 ALTER TABLE dbo.CHITIETHOADON
 ADD CONSTRAINT FK_CHITIEHOADON_SANPHAM FOREIGN KEY(sMaSP) REFERENCES dbo.SANPHAM(sMaSP)
 ON DELETE CASCADE
 ON UPDATE CASCADE

GO
--- Tạo view----------------------------------------------------------
CREATE VIEW vLoadLuong
AS
SELECT sMaNV [Mã NV],sTenNV [Tên NV], sChucVu [Chức vụ],fHsl [Hệ Số Lương] FROM dbo.NHANVIEN
GO
SELECT * FROM dbo.vLoadLuong
GO
CREATE VIEW vloadNV
AS
SELECT sMaNV [Mã NV],sTenNV [Tên NV],dNgaySinh [Ngày Sinh], sGioiTinh [Giới tính], sDiaChi [Địa Chỉ], sChucVu [Chức Vụ], fHsl [Hệ Số Lương], sPassword [Password] FROM dbo.NHANVIEN
GO
SELECT * FROM dbo.vloadNV

SELECT * FROM dbo.NHANVIEN
GO
UPDATE dbo.NHANVIEN SET sPassword='1996' WHERE sMaNV='Admin'
GO
------------------------------------------Tao view load san pham ban chay--------------------------------
CREATE VIEW vSanPhamTop
AS
SELECT TOP 5 CHITIETHOADON.sMaSP, dbo.SANPHAM.sTenSP , SUM(iSoLuong) soluong FROM 
 dbo.HOADON INNER JOIN dbo.CHITIETHOADON ON CHITIETHOADON.sMaHD = HOADON.sMaHD 
 INNER JOIN dbo.SANPHAM ON dbo.SANPHAM.sMaSP= dbo.CHITIETHOADON.sMaSP GROUP BY CHITIETHOADON.sMaSP, dbo.SANPHAM.sTenSP ORDER BY soluong DESC

---------------------------------------proc kiểm tra đăng nhập---------------------------------------------

CREATE PROC pCheckLogin
@username varchar(10)
AS
SELECT sMaNv,sTenNV,sPassword,sChucVu FROM dbo.NHANVIEN WHERE sMaNV=@username
GO
-----------------------------------------proc tính lương---------------------------------------------------
CREATE PROC pLoadLuong
@luong INT
AS
BEGIN
SELECT sMaNV [Mã NV], sTenNV [TênNV], sChucVu [Chức Vụ],fHsl [Hệ Số lương], fHsl*@luong [Lương] FROM dbo.NHANVIEN
END
GO 
EXEC dbo.pLoadLuong @luong = 5000000 -- int



GO
-------------------------------------------- Thêm Nhân Viên-------------------------------------------------
CREATE PROC pThemNhanVien
@manv VARCHAR(10),
@tennv NVARCHAR(50),
@dNgaySinh DATE,
@sGioiTinh nvarchar(5),
@sDiaChi NVARCHAR(50),
@sChucVu nvarchar(15),
@fHsl FLOAT,
@sPassword varchar(15)
AS
INSERT INTO dbo.NHANVIEN( sMaNV , sTenNV , dNgaySinh , sGioiTinh , sDiaChi , sChucVu ,fHsl , sPassword)
VALUES  ( @manv , -- sMaNV - varchar(10)
          @tennv , -- sTenNV - nvarchar(50)
          @dNgaySinh , -- dNgaySinh - date
          @sGioiTinh, -- sGioiTinh - nvarchar(5)
		  @sDiaChi , -- sDiaChi - nvarchar(50)
          @sChucVu, -- sChucVu - nvarchar(15)
          @fHsl , -- fHsl - float
          @sPassword  -- sPassword - varchar(15)
        )
-----------------------------------------------------sửa Nhân Viên-----------------------------------------
GO
 CREATE PROC pSuaThongTinNV
	@manv VARCHAR(10),
	@tennv NVARCHAR(50),
	@dNgaySinh DATE,
	@sGioiTinh nvarchar(5),
	@sDiaChi NVARCHAR(50),
	@sChucVu nvarchar(15),
	@fHsl FLOAT,
	@sPassword varchar(15)
	AS
   UPDATE dbo.NHANVIEN SET sTenNV=@tennv, dNgaySinh=@dNgaySinh,sGioiTinh=@sGioiTinh, sDiaChi=@sDiaChi, sChucVu= @sChucVu,fHsl=@fHsl,sPassword=@sPassword
   WHERE sMaNV=@manv
   -------------------------------------------------- Xóa Nhân Viên----------------------------------------------------------------------------------
   GO
   CREATE PROC pXoaNV
   @sMaNV VARCHAR(10)
   AS
   DELETE dbo.NHANVIEN WHERE sTenNV=@sMaNV
   GO
   
 
   --------------------------------------------------Thêm Hóa Đơn-------------------------------------------------------------------------------------
   CREATE PROC pThemHD
   @sMaHD VARCHAR(15),
   @sMaNV VARCHAR(10)
   AS
   INSERT INTO dbo.HOADON
           ( sMaHD, sMaNV, dNgayLap )
   VALUES  ( @sMaHD, -- sMaHD - varchar(15)
             @sMaNV, -- sMaNV - varchar(10)
             GETDATE()  -- dNgayLap - date
             )
GO 
-------------------------------------------------------Thêm chitiethoadon------------------------------------------------------------------------------
CREATE PROC pThemCTHD
@sMaHD VARCHAR(15),
@sMaSP VARCHAR(10),
@iSoLuong INT
AS
INSERT INTO dbo.CHITIETHOADON
        ( sMaHD, sMaSP, iSoLuong )
VALUES  ( @sMaHD, -- sMaHD - varchar(15)
          @sMaSP, -- sMaSP - varchar(10)
          @iSoLuong  -- iSoLuong - int
          )

		    
EXEC pCheckLogin 'Admin'

GO
--------------------------------------- proc in 1 hóa đơn---------------------------------
CREATE PROC pReportHD
 @sMaHD VARCHAR(15)
 AS
 SELECT dbo.CHITIETHOADON.sMaHD mahoadon, dbo.SANPHAM.sTenSP tensp, dbo.CHITIETHOADON.iSoLuong soluong, dbo.SANPHAM.iDonGia dongia,dbo.CHITIETHOADON.iSoLuong*dbo.SANPHAM.iDonGia thanhtien, dbo.NHANVIEN.sTenNV tennv FROM ((dbo.NHANVIEN INNER JOIN dbo.HOADON ON HOADON.sMaNV = NHANVIEN.sMaNV)
 INNER JOIN dbo.CHITIETHOADON ON dbo.HOADON.sMaHD= dbo.CHITIETHOADON.sMaHD)
 INNER JOIN dbo.SANPHAM ON SANPHAM.sMaSP = CHITIETHOADON.sMaSP WHERE dbo.CHITIETHOADON.sMaHD=@sMaHD
 EXEC dbo.pReportHD @sMaHD = 'HD1' -- varchar(15)

 GO
 ---------------------------------------In lương--------------------------------------------
  CREATE PROC pInLuong
 @phantramhoahong FLOAT,
 @sohoadon INT,
 @luongcoban INT
 AS
 SELECT sMaNV, sTenNV, sGioiTinh, fHsl, sChucVu, @luongcoban*fHsl luongcung, @sohoadon*@phantramhoahong hoahong FROM dbo.NHANVIEN
 ---------------------------------------------------------------------------------------------

 SELECT * FROM dbo.HOADON
 GO
 SELECT COUNT(sMaHD) sl FROM dbo.HOADON WHERE DAY(dNgayLap)=DAY(GETDATE()) AND MONTH(dNgayLap)= MONTH(GETDATE()) AND YEAR(dNgayLap)=YEAR(GETDATE());

 GO
 
 SELECT abc.dNgayLap ngaylap, SUM(Tien) tien FROM (SELECT TOP 5 CHITIETHOADON.sMaSP, SUM(iSoLuong) soluong FROM 
 dbo.HOADON INNER JOIN dbo.CHITIETHOADON ON CHITIETHOADON.sMaHD = HOADON.sMaHD 
 INNER JOIN dbo.SANPHAM ON dbo.SANPHAM.sMaSP= dbo.CHITIETHOADON.sMaSP GROUP BY CHITIETHOADON.sMaSP ORDER BY soluong DESC) abc
 GROUP BY abc.dNgayLap
 WHERE DAY(abc.dNgayLap)=DAY(GETDATE()) AND MONTH(abc.dNgayLap)= MONTH(GETDATE()) AND YEAR(abc.dNgayLap)= YEAR(GETDATE())


 SELECT * FROM dbo.NHANVIEN
 SELECT * FROM dbo.CHITIETHOADON

 GO
 
 -------------------------- 
 SELECT * from vloadNV

 Select * from vLoadLuong
 SELECT sMaNV,sTenNV, sChucVu,fHsl FROM dbo.NHANVIEN

 GO

 GO
 EXEC dbo.pInLuong @phantramhoahong = 10000, -- float
     @sohoadon = 100, -- int
     @luongcoban = 3500000 -- int
 --------------------
 SELECT abc.dNgayLap ngaylap, SUM(Tien) tien FROM (SELECT CHITIETHOADON.sMaHD,iSoLuong*iDonGia Tien, dNgayLap  FROM  dbo.HOADON INNER JOIN dbo.CHITIETHOADON ON CHITIETHOADON.sMaHD = HOADON.sMaHD INNER JOIN dbo.SANPHAM ON dbo.SANPHAM.sMaSP = dbo.CHITIETHOADON.sMaSP) abc  GROUP BY abc.dNgayLap

 GO
