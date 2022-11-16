--=============== CREATE DATABASE ===============--

USE master;
GO
DROP DATABASE IF EXISTS QuanLyThuVien
GO
CREATE DATABASE QuanLyThuVien
GO

USE QuanLyThuVien
GO

--=============== DROP CONSTRAINTS IF EXITS ===============--

IF (OBJECT_ID('dbo.FK_NhaXB_DauSach', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE DauSach DROP CONSTRAINT IF EXISTS FK_NhaXB_DauSach;
END

IF (OBJECT_ID('dbo.FK_NgonNgu_DauSach', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE DauSach DROP CONSTRAINT IF EXISTS FK_NgonNgu_DauSach;
END

IF (OBJECT_ID('dbo.FK_TheLoai_DauSach', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE DauSach DROP CONSTRAINT IF EXISTS FK_TheLoai_DauSach;
END

IF (OBJECT_ID('dbo.PK_MuonSach', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE MuonSach DROP CONSTRAINT IF EXISTS PK_MuonSach;
END

IF (OBJECT_ID('dbo.FK_Sach', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE MuonSach DROP CONSTRAINT IF EXISTS FK_Sach;
END

IF (OBJECT_ID('dbo.FK_Muon', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE MuonSach DROP CONSTRAINT IF EXISTS FK_Muon;
END

IF (OBJECT_ID('dbo.FK_DauSach_Sach', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE Sach DROP CONSTRAINT IF EXISTS FK_DauSach_Sach;
END

IF (OBJECT_ID('dbo.PK_Sach', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE Sach DROP CONSTRAINT IF EXISTS PK_Sach;
END

IF (OBJECT_ID('dbo.FK_DauSach', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE tacgia_sach DROP CONSTRAINT IF EXISTS FK_DauSach;
END

IF (OBJECT_ID('dbo.FK_TacGia', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE tacgia_sach DROP CONSTRAINT IF EXISTS FK_TacGia;
END

IF (OBJECT_ID('dbo.PK_TheLoai', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE TheLoai DROP CONSTRAINT IF EXISTS PK_TheLoai;
END

IF (OBJECT_ID('dbo.PK_NgonNgu', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE NgonNgu DROP CONSTRAINT IF EXISTS PK_NgonNgu;
END

IF (OBJECT_ID('dbo.PK_TacGia', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE TacGia DROP CONSTRAINT IF EXISTS PK_TacGia;
END

IF (OBJECT_ID('dbo.PK_NhaXuatBan', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE NhaXuatBan DROP CONSTRAINT IF EXISTS PK_NhaXuatBan;
END

IF (OBJECT_ID('dbo.PK_VaiTroNhanVien', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE vaitro_nhanVien DROP CONSTRAINT IF EXISTS PK_VaiTroNhanVien;
END

IF (OBJECT_ID('dbo.FK_VaiTro', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE vaitro_nhanVien DROP CONSTRAINT IF EXISTS FK_VaiTro;
END

IF (OBJECT_ID('dbo.FK_NhanVien', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE vaitro_nhanVien DROP CONSTRAINT IF EXISTS FK_NhanVien;
END

IF (OBJECT_ID('dbo.PK_VaiTro', 'PK') IS NOT NULL)
BEGIN
   ALTER TABLE VaiTro DROP CONSTRAINT IF EXISTS PK_VaiTro;
END

IF (OBJECT_ID('dbo.FK_Muon_NhanVien', 'F') IS NOT NULL)
BEGIN
   ALTER TABLE Muon DROP CONSTRAINT IF EXISTS FK_Muon_NhanVien;
END

IF (OBJECT_ID('dbo.FK_Muon_DocGia', 'F') IS NOT NULL)
BEGIN
	ALTER TABLE Muon DROP CONSTRAINT IF EXISTS FK_Muon_DocGia;
END

IF (OBJECT_ID('dbo.PK_NhanVien', 'PK') IS NOT NULL)
BEGIN
	ALTER TABLE NhanVien DROP CONSTRAINT IF EXISTS PK_NhanVien;
END

IF (OBJECT_ID('dbo.FK_HoSo_NhanVien', 'F') IS NOT NULL)
BEGIN
	ALTER TABLE NhanVien DROP CONSTRAINT IF EXISTS FK_HoSo_NhanVien;
END

IF (OBJECT_ID('dbo.PK_HoSo', 'PK') IS NOT NULL)
BEGIN
	ALTER TABLE HoSo DROP CONSTRAINT IF EXISTS PK_HoSo;
END

IF (OBJECT_ID('dbo.FK_HoSo_DocGia', 'F') IS NOT NULL)
BEGIN
	ALTER TABLE HoSo DROP CONSTRAINT IF EXISTS FK_HoSo_DocGia;
END

IF (OBJECT_ID('dbo.PK_DocGia', 'PK') IS NOT NULL)
BEGIN
	ALTER TABLE DocGia DROP CONSTRAINT IF EXISTS PK_DocGia;
END

IF (OBJECT_ID('dbo.PK_DauSach', 'PK') IS NOT NULL)
BEGIN
	ALTER TABLE DauSach DROP CONSTRAINT IF EXISTS PK_DauSach;
END
GO
-- Check constraints
IF (OBJECT_ID('dbo.CHK_DauSach', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE DauSach DROP CONSTRAINT IF EXISTS CHK_DauSach;
END

IF (OBJECT_ID('dbo.CHK_HoSo', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE HoSo DROP CONSTRAINT IF EXISTS CHK_HoSo;
END

IF (OBJECT_ID('dbo.CHK_NhanVien', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE HoSo DROP CONSTRAINT IF EXISTS CHK_NhanVien;
END

IF (OBJECT_ID('dbo.CHK_NhanVien', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE HoSo DROP CONSTRAINT IF EXISTS CHK_NhanVien;
END

IF (OBJECT_ID('dbo.CHK_Muon', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE Muon DROP CONSTRAINT IF EXISTS CHK_Muon;
END

IF (OBJECT_ID('dbo.CHK_Sach', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE Sach DROP CONSTRAINT IF EXISTS CHK_Sach;
END

IF (OBJECT_ID('dbo.CHK_TheLoai', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE TheLoai DROP CONSTRAINT IF EXISTS CHK_TheLoai;
END

IF (OBJECT_ID('dbo.CHK_NgonNgu', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE NgonNgu DROP CONSTRAINT IF EXISTS CHK_NgonNgu;
END

IF (OBJECT_ID('dbo.CHK_TacGia', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE TacGia DROP CONSTRAINT IF EXISTS CHK_TacGia;
END

GO

IF (OBJECT_ID('dbo.CHK_MuonSachTemp', 'C') IS NOT NULL)
BEGIN
	ALTER TABLE MuonSachTemp DROP CONSTRAINT IF EXISTS CHK_MuonSachTemp;
END

GO
--=============== CREATE TABLE ===============--

IF OBJECT_ID(N'TheLoai', N'U') IS NOT NULL  
	DROP TABLE [dbo].[TheLoai];  
CREATE TABLE TheLoai
(
  id INT IDENTITY(1,1),
  ten NVARCHAR(50) NOT NULL,
  CONSTRAINT PK_TheLoai PRIMARY KEY(id),
  CONSTRAINT CHK_TheLoai CHECK (ten LIKE '%[a-zA-Z ]%')
);
GO

IF OBJECT_ID(N'NgonNgu', N'U') IS NOT NULL  
	DROP TABLE [dbo].[NgonNgu];  
CREATE TABLE NgonNgu
(
  id INT IDENTITY(1,1),
  ten NVARCHAR(20) NOT NULL,
  CONSTRAINT PK_NgonNgu PRIMARY KEY(id),
  CONSTRAINT CHK_NgonNgu CHECK (ten LIKE '%[a-zA-Z ]%')
);
GO

IF OBJECT_ID(N'TacGia', N'U') IS NOT NULL  
	DROP TABLE [dbo].[TacGia];  
CREATE TABLE TacGia
(
  id INT IDENTITY(1,1),
  ten NVARCHAR(50) NOT NULL,
  CONSTRAINT PK_TacGia PRIMARY KEY(id),
  CONSTRAINT CHK_TacGia CHECK (ten LIKE '%[a-zA-Z ]%')
);
GO

IF OBJECT_ID(N'NhaXuatBan', N'U') IS NOT NULL  
	DROP TABLE [dbo].[NhaXuatBan]; 
CREATE TABLE NhaXuatBan
(
  id INT IDENTITY(1,1),
  ten NVARCHAR(50) NOT NULL,
  CONSTRAINT PK_NhaXuatBan PRIMARY KEY(id),
  CONSTRAINT CHK_NhaXuatBan CHECK (ten LIKE '%[a-zA-Z ]%')
);
GO

IF OBJECT_ID(N'VaiTro', N'U') IS NOT NULL  
	DROP TABLE [dbo].[VaiTro]; 
CREATE TABLE VaiTro
(
  id INT IDENTITY(1,1),
  ten NVARCHAR(20) NOT NULL,
  mota NVARCHAR(200),
  CONSTRAINT PK_VaiTro PRIMARY KEY(id),
  CONSTRAINT CHK_VaiTro CHECK (ten LIKE '%[a-zA-Z ]%')
);
GO

IF OBJECT_ID(N'DocGia', N'U') IS NOT NULL  
	DROP TABLE [dbo].[DocGia]; 
CREATE TABLE DocGia
(
  id INT IDENTITY(1,1),
  ten NVARCHAR(50) NOT NULL,
  mssv NVARCHAR(10),
  khoa NVARCHAR(30) NOT NULL,
  gioiTinh INT,
  trangThai INT NOT NULL,
  ngaySinh DATE,
  soDT NVARCHAR(10),
  email NVARCHAR(30),
  hinhAnh NVARCHAR(500),
  CONSTRAINT PK_DocGia PRIMARY KEY(id),
  CONSTRAINT CHK_DocGia CHECK (LEN(soDT) = 10 AND (soDT LIKE '%[0-9]%' ) AND (ten LIKE '%[a-zA-Z ]%') AND (gioitinh=0 OR gioitinh=1 OR gioitinh = 2))
);
GO

IF OBJECT_ID(N'DauSach', N'U') IS NOT NULL  
	DROP TABLE [dbo].[DauSach]; 
CREATE TABLE DauSach
(
  id INT IDENTITY(1,1),
  tieude NVARCHAR(3000) NOT NULL,
  mota NVARCHAR(3000),
  gia INT,
  ngayxuatban DATE,
  hinhanh NVARCHAR(500),
  loai INT NOT NULL, -- 1: Giáo khoa | 0: Tham khảo
  trangthai INT NOT NULL, -- 1: Cho mượn | 0: Không cho mượn
  maNXB INT,
  maNgonNgu INT,
  maTheLoai INT,
  CONSTRAINT PK_DauSach PRIMARY KEY(id),
  CONSTRAINT FK_NhaXB_DauSach FOREIGN KEY (maNXB) REFERENCES NhaXuatBan(id),
  CONSTRAINT FK_NgonNgu_DauSach FOREIGN KEY (maNgonNgu) REFERENCES NgonNgu(id),
  CONSTRAINT FK_TheLoai_DauSach FOREIGN KEY (maTheLoai) REFERENCES TheLoai(id),
  CONSTRAINT CHK_DauSach CHECK (gia>=0 AND (loai=0 OR loai=1) AND (trangthai = 1 OR trangthai = 0))
);
GO

IF OBJECT_ID(N'HoSo', N'U') IS NOT NULL  
	DROP TABLE [dbo].[HoSo]; 
CREATE TABLE HoSo
(
  id INT IDENTITY(1,1),
  ten NVARCHAR(200) NOT NULL,
  ho NVARCHAR(200) NOT NULL,
  diachi NVARCHAR(2000),
  soDT NVARCHAR(10),
  hinhanh NVARCHAR(1000),
  email NVARCHAR(1000) NOT NULL UNIQUE,
  gioitinh INT NOT NULL, -- 0: không rõ | 1: Nam | 2:Nữ
  ngaysinh Date,
  luong INT,
  CONSTRAINT PK_HoSo PRIMARY KEY(id),
  CONSTRAINT CHK_HoSo CHECK (LEN(soDT) = 10 AND (soDT LIKE '%[0-9]%' )  AND (ten LIKE '%[a-zA-Z ]%') AND (ho LIKE '%[a-zA-Z ]%') AND (gioitinh=0 OR gioitinh=1 OR gioitinh = 2))
);
GO




IF OBJECT_ID(N'NhanVien', N'U') IS NOT NULL  
	DROP TABLE [dbo].[NhanVien]; 
CREATE TABLE NhanVien
(
  id INT IDENTITY(1,1),
  tenDangNhap NVARCHAR(30) NOT NULL UNIQUE,
  matkhau VARBINARY(128) NOT NULL,
  trangthai INT NOT NULL,
  maHoSo INT NOT NULL,
  CONSTRAINT PK_NhanVien PRIMARY KEY(id),
  CONSTRAINT FK_HoSo_NhanVien FOREIGN KEY (maHoSo) REFERENCES HoSo(id),
  CONSTRAINT CHK_NhanVien CHECK ((tenDangNhap LIKE '%[a-zA-Z ]%') 
									AND (trangthai = 0 OR trangthai =1))
);
GO

IF OBJECT_ID(N'Muon', N'U') IS NOT NULL  
	DROP TABLE [dbo].[Muon]; 
CREATE TABLE Muon
(
  id INT IDENTITY(1,1),
  ngaymuon DATE NOT NULL,
  ngaytra DATE,
  ngayhethan DATE,
  tienphat INT,
  maNhanVien INT NOT NULL,
  maDocGia INT NOT NULL,
  CONSTRAINT PK_Muon PRIMARY KEY(id),
  CONSTRAINT FK_Muon_NhanVien FOREIGN KEY (maNhanVien) REFERENCES NhanVien(id),
  CONSTRAINT FK_Muon_DocGia FOREIGN KEY (maDocGia) REFERENCES DocGia(id),
  CONSTRAINT CHK_Muon CHECK (tienphat >= 0)
);
GO


IF OBJECT_ID(N'tacgia_sach', N'U') IS NOT NULL  
	DROP TABLE [dbo].[tacgia_sach]; 
CREATE TABLE tacgia_sach
(
  maDauSach INT NOT NULL,
  maTacGia INT NOT NULL,
  CONSTRAINT PK_tacgia_sach PRIMARY KEY (maDauSach, maTacGia),
  CONSTRAINT FK_DauSach FOREIGN KEY (maDauSach) REFERENCES DauSach(id),
  CONSTRAINT FK_TacGia FOREIGN KEY (maTacGia) REFERENCES TacGia(id)
);



IF OBJECT_ID(N'vaitro_NhanVien', N'U') IS NOT NULL  
	DROP TABLE [dbo].[vaitro_nhanVien]; 
CREATE TABLE vaitro_nhanVien
(
  maNhanVien INT NOT NULL,
  maVaiTro INT NOT NULL, -- 1: Quản lý | 2: Nhân viên
  CONSTRAINT PK_VaiTroNhanVien PRIMARY KEY (maNhanVien, maVaiTro),
  CONSTRAINT FK_VaiTro FOREIGN KEY (maVaiTro) REFERENCES VaiTro(id),
  CONSTRAINT FK_NhanVien FOREIGN KEY (maNhanVien) REFERENCES NhanVien(id)
);
GO


IF OBJECT_ID(N'Sach', N'U') IS NOT NULL  
	DROP TABLE [dbo].[Sach]; 
CREATE TABLE Sach
(
  id INT IDENTITY(1,1),
  trangthai INT NOT NULL, --  -1: Mất  1: Còn cho mượn | 0: Không cho mượn
  vitri NVARCHAR(100),
  maDauSach INT NOT NULL,
  CONSTRAINT PK_Sach PRIMARY KEY (id),
  CONSTRAINT FK_DauSach_Sach FOREIGN KEY (maDauSach) REFERENCES DauSach(id),
  CONSTRAINT CHK_Sach CHECK (trangthai = 0 OR trangthai = 1 OR trangthai = -1)
);
GO



IF OBJECT_ID(N'MuonSach', N'U') IS NOT NULL  
	DROP TABLE [dbo].[MuonSach]; 
CREATE TABLE MuonSach
(
  maSach INT NOT NULL,
  maMuon INT NOT NULL,
  ghiChu NVARCHAR(50),
  trangthai INT NOT NULL, -- 1: Đang mượn | 0: Trả rồi
  CONSTRAINT PK_MuonSach PRIMARY KEY (maSach, maMuon),
  CONSTRAINT FK_Sach FOREIGN KEY (maSach) REFERENCES Sach(id),
  CONSTRAINT FK_Muon FOREIGN KEY (maMuon) REFERENCES Muon(id),
  CONSTRAINT CHK_MuonSach Check (trangthai = 0 OR trangthai =1)
);
GO

IF OBJECT_ID(N'MuonSachTemp', N'U') IS NOT NULL  
	DROP TABLE [dbo].[MuonSachTemp]; 
CREATE TABLE MuonSachTemp
(
  maSach INT,
  maMuon INT,
  ghiChu NVARCHAR(50),
  trangthai INT, -- 1: Đang mượn | 0: Trả rồi
  CONSTRAINT CHK_MuonSachTemp Check (trangthai = 0 OR trangthai =1)
);
GO
								--=============== TRIGGER ===============--

-- Nếu ngayxuatban > thời gian hiện tại => rollback
-- Hoặc ngayxuatban < năm 1900 => rollback 
CREATE TRIGGER trig_namxuatban ON DauSach
FOR INSERT, UPDATE
AS
	DECLARE @ngayxuatban DATE;
	SELECT @ngayxuatban = DauSach.ngayxuatban FROM INSERTED DauSach
	IF YEAR(GETDATE()) - YEAR(@ngayxuatban)  < 0 OR YEAR(@ngayxuatban) < 1900 
	BEGIN
		ROLLBACK
	END

GO

-- Thay vì xóa dausach, đổi trạng thái từ  1 thành 0 (Không cho mượn)
CREATE TRIGGER trig_trangthai_dausach ON DauSach
INSTEAD OF DELETE
AS
	DECLARE @trangthai INT;
	
	IF (SELECT trangthai FROM DELETED DauSachDel) != 0
	BEGIN
		DECLARE @id INT
		SELECT @id = id FROM DELETED
		UPDATE DauSach
		SET trangthai = 0
		WHERE DauSach.id = @id;
	END
GO

-- Xóa phiếu mượn khi trangthai == 1 => rollback thay vào đó
CREATE TRIGGER trig_trangthai_muon ON MuonSach 
FOR DELETE
AS
	IF (SELECT trangthai FROM DELETED ) = 1
	BEGIN
		ROLLBACK
	END
Go

-- Xóa sach khi trangthai == -1 => rollback thay vào đó 
CREATE TRIGGER trig_trangthai_sach ON Sach
INSTEAD OF DELETE
AS
	DECLARE @trangthai INT;
	
	IF (SELECT trangthai FROM DELETED SachDel) != -1
	BEGIN
		DECLARE @id INT
		SELECT @id = id FROM DELETED
		UPDATE Sach
		SET trangthai = -1
		WHERE Sach.id = @id;
	END
GO

-- Thêm mới nếu vai trò là quản lý nhưng tuổi < 18 => rollback
CREATE TRIGGER trig_HoSo ON HoSo
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @ngaysinh DATE, @role NVARCHAR(20);
	SELECT @ngaysinh = ngaysinh FROM INSERTED HoSo
    SELECT @role = VaiTro.ten FROM INSERTED HoSo 
	INNER JOIN NhanVien ON HoSo.id=NhanVien.maHoSo 
		INNER JOIN vaitro_nhanVien ON NhanVien.id=vaitro_nhanVien.maNhanVien INNER JOIN VaiTro ON vaitro_nhanVien.maVaiTro=VaiTro.id
	IF ((YEAR(GETDATE())-YEAR(@ngaysinh)<18) AND @role='admin')
	BEGIN
		ROLLBACK
	END
END
GO

-- Khi xóa nhân viên nếu trangthai == 1 => rollback
CREATE TRIGGER trigg_enable_nhanVien ON NhanVien
FOR DELETE
AS
BEGIN
	DECLARE @trangthai INT
	SELECT @trangthai = trangthai FROM NhanVien
	IF (@trangthai = 1) 
	BEGIN
		ROLLBACK
	END
END
GO

							--=============== VIEW ===============--
--  view nhanvien
CREATE OR ALTER VIEW NHANVIEN_VIEW AS
SELECT HoSo.id, HoSo.ten, Hoso.email
FROM HoSo INNER JOIN NhanVien ON HoSo.id=NhanVien.maHoSo 
INNER JOIN vaitro_nhanVien ON NhanVien.id=vaitro_nhanVien.maNhanVien 
	INNER JOIN VaiTro ON vaitro_nhanVien.maVaiTro=VaiTro.id
WHERE VaiTro.ten='nhan vien'
GO
--  view nhaxuatban
CREATE OR ALTER VIEW NXB_VIEW AS
SELECT *
FROM NhaXuatBan 
GO
--  view theloai
CREATE OR ALTER VIEW THELOAI_VIEW AS
SELECT *
FROM TheLoai
GO

							--=============== Phân Quyền ===============--
-- function gán quyền cho thủ thư
CREATE OR ALTER PROC fn_Gan_Quyen_Nhan_Vien(
@TENDANGNHAP VARCHAR(100))
AS
BEGIN
	DECLARE @GRANT VARCHAR(200)
	DECLARE @DENY VARCHAR(200)
	SET @GRANT = 'GRANT EXEC, SELECT, INSERT, UPDATE, DELETE TO '+ @TENDANGNHAP
	EXEC(@GRANT)

	SET @DENY = 'DENY EXEC ON usp_Them_Thong_Tin_Nhan_Vien TO ' + @TENDANGNHAP
	EXEC(@DENY)

	SET @DENY = 'DENY EXEC ON usp_Quan_Ly_Doi_Mat_Khau TO ' + @TENDANGNHAP
	EXEC(@DENY)

	SET @DENY = 'DENY EXEC ON usp_Xem_Toan_Bo_Thong_Tin_Nhan_Vien TO ' + @TENDANGNHAP
	EXEC(@DENY)

	SET @DENY = 'DENY EXEC ON usp_Chuyen_Trang_Thai_Nhan_Vien TO ' + @TENDANGNHAP
	EXEC(@DENY)

	SET @DENY = 'DENY EXEC ON usp_Sua_Thong_Tin_Nhan_Vien TO ' + @TENDANGNHAP
	EXEC(@DENY)

END;
GO


							--=============== PROCEDURE ===============--


--============================================= ĐỘC GIẢ =============================================--

-- procedure Xem thông tin độc giả
CREATE OR ALTER PROCEDURE usp_Xem_Thong_Tin_Doc_gia
AS
BEGIN
   SELECT * FROM DocGia;
END;
GO

-- procedure Thêm thông tin độc giả
CREATE OR ALTER PROCEDURE usp_Them_Doc_Gia
@Ten NVARCHAR(50),
@MSSV NVARCHAR(10),
@KHOA NVARCHAR(30),
@GIOITINH INT,
@TRANGTHAI INT,
@NGAYSINH DATE,
@SODT NVARCHAR(10),
@EMAIL NVARCHAR(30),
@HINHANH NVARCHAR(1000)
AS
BEGIN
   INSERT INTO DocGia (ten,mssv,khoa,gioiTinh,trangThai,ngaySinh,soDT,email,hinhAnh)
   VALUES (@TEN,@MSSV,@KHOA,@GIOITINH,@TRANGTHAI,@NGAYSINH,@SODT,@EMAIL,@HINHANH);
   SELECT SCOPE_IDENTITY();
END;
GO

--procedure lấy độc giả theo id
CREATE OR ALTER PROCEDURE usp_Lay_Doc_Gia_Theo_Id
@ID INT
AS
BEGIN
	SELECT * FROM DocGia
	WHERE id = @ID;
END
GO

--procedure sửa độc giả
CREATE OR ALTER PROCEDURE usp_Sua_Doc_Gia
@ID INT,
@Ten NVARCHAR(50),
@MSSV NVARCHAR(10),
@KHOA NVARCHAR(30),
@GIOITINH INT,
@TRANGTHAI INT,
@NGAYSINH DATE,
@SODT NVARCHAR(10),
@EMAIL NVARCHAR(30),
@HINHANH NVARCHAR(1000)
AS
BEGIN
   UPDATE DocGia SET ten = @Ten ,mssv = @MSSV, khoa=@KHOA ,gioiTinh = @GIOITINH,trangThai = @TRANGTHAI,ngaySinh = @NGAYSINH,soDT=@SODT,email = @EMAIL, hinhAnh = @HINHANH
   WHERE id=@ID;
END;
GO

--procedure sửa hình ảnh độc giả
CREATE OR ALTER PROCEDURE usp_Sua_Hinh_Anh_Doc_Gia
@ID INT,
@HINHANH NVARCHAR(1000)
AS
BEGIN
	UPDATE DocGia SET hinhAnh = @HINHANH WHERE ID = @ID
END;
GO

-- procedure Chuyển trạng thái độc giả
CREATE OR ALTER PROCEDURE usp_Chuyen_Trang_Thai_Doc_gia
   @id INT,
   @trangthai INT
AS
BEGIN
   UPDATE Docgia
   SET trangthai = @trangthai
   WHERE id=@id;
END;

GO

-- procedure sửa thông tin độc giả
CREATE OR ALTER PROC usp_Sua_Thong_Tin_Doc_Gia  
@id INT,
@trangthai INT,
@ten NVARCHAR(50),
@mssv NVARCHAR(10),
@khoa NVARCHAR(30)
AS
BEGIN
	UPDATE DocGia SET ten=@TEN, trangthai = @trangthai, mssv = @mssv, khoa = @khoa
	WHERE id=@id
END;
GO

--============================================= SÁCH =============================================--

-- procedure Xem thể loại
CREATE OR ALTER PROCEDURE usp_Xem_The_Loai
AS
BEGIN
   	SELECT * FROM TheLoai;
END;
GO

-- procedure Xem sách theo ngôn ngữ
CREATE OR ALTER PROCEDURE usp_Xem_Sach_Theo_Ngon_Ngu
@id INT
AS
BEGIN
   	SELECT DauSach.tieude, DauSach.mota, DauSach.hinhanh FROM 
   	DauSach INNER JOIN NgonNgu ON DauSach.maNgonNgu = NgonNgu.id
	WHERE NgonNgu.id=@id
END;
GO



--procedure cập nhật thông tin đầu sách
CREATE OR ALTER PROC usp_CAP_NHAT_THONG_TIN_DAU_SACH
@ID INT,
@TIEUDE NVARCHAR(30),
@MOTA NVARCHAR(200),
@GIA INT,
@NGAYXB DATE,
@HINHANH NVARCHAR(100),
@LOAI INT,
@TRANGTHAI INT,
@MANXB INT,
@MANGONGU INT,
@MATHELOAI INT
AS
BEGIN
	UPDATE DauSach SET tieude=@TIEUDE, mota=@MOTA, gia=@GIA, ngayxuatban=@NGAYXB, hinhanh=@HINHANH, loai=@LOAI, trangthai=@TRANGTHAI,
		maNXB=@MANXB, maNgonNgu=@MANGONGU, maTheLoai=@MATHELOAI 
			WHERE id=@ID		
END
GO

-- procedure sửa hình ảnh đầu sách
CREATE OR ALTER PROC usp_Sua_Hinh_Anh_Dau_Sach
@ID INT,
@HINHANH NVARCHAR(1000)
AS
BEGIN
	UPDATE DauSach SET hinhAnh = @HINHANH
			WHERE id=@ID		
END
GO

CREATE OR ALTER PROC usp_THONG_TIN_PHIEU_MUON
@ID INT
AS
BEGIN
	SELECT DocGia.ten, DocGia.mssv, DocGia.khoa, HoSo.ten, Muon.ngaymuon, Muon.ngayhethan, Muon.ngaytra, Muon.tienphat, DocGia.hinhAnh
		FROM Muon JOIN NhanVien ON maNhanVien=NhanVien.id
					JOIN HoSo ON NhanVien.maHoSo=HoSo.id
						JOIN DocGia ON maDocGia=DocGia.id
			WHERE Muon.id=@ID		
END
GO

CREATE OR ALTER PROC usp_CAP_NHAT_THONG_TIN_PHIEU_MUON
@ID INT,
@NGAYTRA DATE,
@TIENPHAT INT
AS
BEGIN
	UPDATE Muon SET ngaytra=@NGAYTRA, tienphat=@TIENPHAT 
			WHERE id=@ID		
END
GO


-- procedure Xem thông tin đầu sách
CREATE OR ALTER PROCEDURE usp_Xem_Dau_Sach
AS
BEGIN
   SELECT * FROM DauSach;
END;
GO

-- procedure Xem thông tin đầu sách DTO
CREATE OR ALTER PROCEDURE usp_Xem_DauSachDTO
AS
BEGIN
SELECT DauSach.id, DauSach.tieude, TheLoai.ten as 'theloai', DauSach.gia
FROM DauSach INNER JOIN TheLoai ON DauSach.maTheLoai = TheLoai.id;
END;

GO

-- procedure Thêm thông tin đầu sách
CREATE OR ALTER PROCEDURE usp_Them_Dau_Sach
   @tieude NVARCHAR(30),
   @mota NVARCHAR(200),
   @gia INT,
   @ngayxuatban DATE,
   @hinhanh NVARCHAR(100),
   @loai INT,
   @trangthai INT,
   @maNXB INT,
   @maNgonNgu INT,
   @maTheLoai INT
AS
BEGIN
   BEGIN TRY
		BEGIN TRAN
         DECLARE @MaDauSach INT;
			INSERT INTO DauSach (
         tieude, 
         mota, 
         gia,
         ngayxuatban,
         hinhanh,
         loai,
         trangthai,
         maNXB,
         maNgonNgu,
         maTheLoai
      )
      VALUES (
         @tieude, 
         @mota, 
         @gia,
         @ngayxuatban,
         @hinhanh,
         @loai,
         @trangthai,
         @maNXB,
         @maNgonNgu,
         @maTheLoai
      );
      SET @MaDauSach = SCOPE_IDENTITY();
      COMMIT 
	END TRY
   BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
      SET @MaDauSach =-1;
	END CATCH
   SELECT @MaDauSach;   
END;
GO

-- procedure Chuyển trạng thái đầu sách ( Cho mượn, không cho mượn)
CREATE OR ALTER PROCEDURE usp_Chuyen_Trang_Thai_Dau_Sach
   @id INT,
   @trangthai INT
AS
BEGIN
   UPDATE DauSach
   SET trangthai = @trangthai
   WHERE id=@id;
END;

GO

-- procedure Liệt kê sách theo trạng thái 
CREATE OR ALTER PROCEDURE usp_Liet_Ke_Sach_Theo_Trang_Thai
   @trangthai INT
AS
BEGIN
   SELECT * FROM DauSach WHERE trangthai=@trangthai;
END;

GO

-- procedure Liệt kê những độc giả đang mượn sách
CREATE OR ALTER PROCEDURE usp_Liet_Ke_Doc_Gia_Dang_Muon_Sach
AS
BEGIN
   SELECT DocGia.ten, DocGia.mssv, DocGia.khoa FROM 
   DocGia INNER JOIN Muon ON DocGia.id = Muon.maDocGia;
END;

GO

-- procedure Liệt kê những độc giả đang mượn sách quá hạn
CREATE OR ALTER PROCEDURE usp_Liet_Ke_Doc_Gia_Dang_Muon_Sach_Qua_Han
AS
BEGIN
   SELECT DocGia.ten, DocGia.mssv, DocGia.khoa FROM 
   DocGia INNER JOIN Muon ON DocGia.id = Muon.maDocGia
   WHERE MONTH(GETDATE())-MONTH(Muon.ngaymuon) >=6;
END;

GO

CREATE OR ALTER PROCEDURE usp_LAY_SACH_THEO_MA_SACH
@id INT
AS
BEGIN
   SELECT Sach.id, DauSach.tieude, 0, '' FROM Sach JOIN DauSach ON Sach.maDauSach=DauSach.id WHERE Sach.id=@id
END;

GO

-- procedure Xem sách theo tác giả
CREATE OR ALTER PROCEDURE usp_Xem_Sach_Theo_Tac_Gia
@id INT
AS
BEGIN
   SELECT DauSach.tieude, DauSach.mota, DauSach.hinhanh FROM 
   TacGia INNER JOIN tacgia_sach ON TacGia.id = tacgia_sach.maTacGia
   INNER JOIN DauSach ON DauSach.id = tacgia_sach.maDauSach
   WHERE TacGia.id = @id;
END;

GO

-- procedure Xem sách theo danh mục
CREATE OR ALTER PROCEDURE usp_Xem_Sach_Theo_Danh_Muc
@id INT
AS
BEGIN
   SELECT DauSach.tieude, DauSach.mota, DauSach.hinhanh FROM 
   DauSach INNER JOIN TheLoai ON DauSach.maTheLoai = TheLoai.id
   WHERE TheLoai.id = @id;
END;
GO

-- procedure xem đầu sách theo nhà xuất bản
CREATE OR ALTER PROCEDURE usp_Xem_Dau_Sach_Theo_Nha_Xuat_Ban
@maNXB INT
AS
	BEGIN
	   SELECT * FROM DauSach INNER JOIN NhaXuatBan ON DauSach.maNXB = NhaXuatBan.id
	   WHERE NhaXuatBan.id = @maNXB;
	END;
GO

-- procedure Xóa ngôn ngữ
CREATE OR ALTER PROCEDURE usp_Xoa_Ngon_Ngu
@id INT
AS
	BEGIN
	   DELETE FROM NgonNgu WHERE id = @id;
	END;
GO

-- procedure xóa nhà xuất bản
CREATE OR ALTER PROCEDURE usp_Xoa_Nha_Xuat_Ban
@id INT
AS
	BEGIN
	   DELETE FROM NhaXuatBan WHERE id = @id;
	END;
GO

-- procedure xóa thể loại
CREATE OR ALTER PROCEDURE usp_Xoa_The_Loai
@id INT
AS
	BEGIN
	   DELETE FROM TheLoai WHERE id = @id;
	END;
GO

-- procedure xem ngôn ngữ
CREATE OR ALTER PROCEDURE usp_Xem_Ngon_Ngu_Theo_Id
@id INT
AS
BEGIN
   SELECT NgonNgu.ten
   FROM NgonNgu
   WHERE NgonNgu.id = @id
END;
GO

-- procedure xem tác giả theo mã tác giả
CREATE OR ALTER PROCEDURE usp_Xem_Tac_Gia_Theo_Id
@id INT
AS
BEGIN
   SELECT TacGia.ten
   FROM TacGia
   WHERE TacGia.id = @id
END;

-- procedure xem nhà xuất bản theo mã nhà xuất bản
GO
CREATE OR ALTER PROCEDURE usp_Xem_Nha_Xuat_Ban_Theo_Id
@id INT
AS
BEGIN
   SELECT NhaXuatBan.ten
   FROM NhaXuatBan
   WHERE NhaXuatBan.id = @id
END;

-- procedure xem thể loại theo mã thể loại
GO
CREATE OR ALTER PROCEDURE usp_Xem_The_Loai_Theo_Id
@id INT
AS
BEGIN
   SELECT TheLoai.ten
   FROM TheLoai
   WHERE TheLoai.id = @id
END;

GO
-- procedure Sửa thông tin thể loại
CREATE OR ALTER PROC usp_Sua_Thong_Tin_The_Loai  
@ID INT,
@TEN NVARCHAR(200)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE TheLoai SET ten=@TEN
			WHERE id=@ID
		COMMIT
	END TRY
		
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
	END CATCH 
END;
GO

-- procedure Sửa thông tin tác giả
CREATE OR ALTER PROC usp_Sua_Thong_Tin_Tac_Gia 
@ID INT,
@TEN NVARCHAR(200)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE TacGia SET ten=@TEN
			WHERE id=@ID
		COMMIT
	END TRY
		
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
	END CATCH 
END;
GO
-- procedure Sửa thông tin thể loại
CREATE OR ALTER PROC usp_Sua_Thong_Tin_Nha_Xuat_Ban  
@ID INT,
@TEN NVARCHAR(200)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE NhaXuatBan SET ten=@TEN
			WHERE id=@ID
		COMMIT
	END TRY
		
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
	END CATCH 
END;
GO
-- procedure Sửa thông tin thể loại
CREATE OR ALTER PROC usp_Sua_Thong_Tin_Ngon_Ngu  
@ID INT,
@TEN NVARCHAR(200)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE NgonNGu SET ten=@TEN
			WHERE id=@ID
		COMMIT
	END TRY
		
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
	END CATCH 
END;
GO

-- procedure Sửa thông tin về bảng tác giả và sách
CREATE OR ALTER PROCEDURE usp_SUA_TAC_GIA_SACH
@idSach INT,
@idTacGiaCu INT,
@idTacGiaMoi INT
AS
BEGIN
   UPDATE tacgia_sach SET maTacGia=@idTacGiaMoi WHERE maDauSach=@idSach AND maTacGia=@idTacGiaCu
END;
GO

-- procedure xóa bảng tác giả và sách
CREATE OR ALTER PROCEDURE usp_XOA_TAC_GIA_SACH
@idSach INT,
@idTacGia INT
AS
BEGIN
   DELETE FROM tacgia_sach WHERE maDauSach=@idSach AND maTacGia=@idTacGia
END;
GO

-- procedure thêm vào bảng tác giả và sách
CREATE OR ALTER PROCEDURE usp_THEM_TAC_GIA_SACH
@idSach INT,
@idTacGia INT
AS
	BEGIN
	   INSERT INTO tacgia_sach VALUES(@idSach, @idTacGia);
	END;
GO

-- procedure Xem sách theo đầu sách và tác giả
CREATE OR ALTER PROCEDURE usp_Xem_Danh_Sach_Dau_Sach_Theo_Tac_Gia
@id INT
AS
BEGIN
	SELECT TacGia.id as 'tacgiaID', TacGia.ten, DauSach.id as 'sachID'
	FROM TacGia 
	JOIN tacgia_sach ON TacGia.id = tacgia_sach.maTacGia
	JOIN DauSach ON DauSach.id = tacgia_sach.maDauSach
	WHERE TacGia.id=@id;
END;
GO


-- procedure Lấy thông tin chi tiết đầu sách theo mã đầu sách
CREATE OR ALTER PROC usp_Thong_Tin_Chi_Tiet_Dau_Sach
@id INT
AS
BEGIN
	SELECT tieude, mota, gia, ngayxuatban, hinhanh, loai as 'danhmuc', trangthai, NhaXuatBan.ten as 'nxb', NgonNgu.ten as 'ngonngu', TheLoai.ten as 'theloai' 
	FROM DauSach INNER JOIN TheLoai ON DauSach.maTheLoai = TheLoai.id
		INNER JOIN NhaXuatBan ON DauSach.maNXB = NhaXuatBan.id
			INNER JOIN NgonNgu ON DauSach.maNgonNgu = NgonNgu.id
	WHERE DauSach.id = @id
END
GO

-- procedure Lấy toàn bộ tác giả theo mã đầu sách
CREATE OR ALTER PROC usp_TAC_GIA_SACH_CU_THE
@id int
AS
BEGIN
	SELECT TacGia.id, TacGia.ten FROM tacgia_sach INNER JOIN TacGia ON tacgia_sach.maTacGia = TacGia.id
	WHERE tacgia_sach.maDauSach = @id
END
GO

-- procedure Lấy tất cả tác giả
CREATE OR ALTER PROC usp_TAC_GIA_SACH
AS
	BEGIN
		SELECT * FROM TacGia 
	END
GO

-- procedure thêm tác giả
CREATE OR ALTER PROC usp_THEM_TAC_GIA
@TEN NVARCHAR(50)
AS
BEGIN
	INSERT INTO TacGia VALUES(@TEN);
END
GO

-- procedure thêm nhà xuất bản
CREATE OR ALTER PROC usp_THEM_NXB
@TEN NVARCHAR(50)
AS
BEGIN
	INSERT INTO NhaXuatBan VALUES(@TEN);
END
GO

-- procedure thêm thể loại
CREATE OR ALTER PROC usp_THEM_THE_LOAI
@TEN NVARCHAR(50)
AS
BEGIN
	INSERT INTO TheLoai VALUES(@TEN);
END
GO

-- procedure thêm ngôn ngữ
CREATE OR ALTER PROC usp_THEM_NGON_NGU
@TEN NVARCHAR(50)
AS
BEGIN
	INSERT INTO NgonNgu VALUES(@TEN);
END
GO

--============================================= NHÂN VIÊN =============================================--
-- procedure Sửa thông tin nhân viên
CREATE OR ALTER PROC usp_Sua_Thong_Tin_Nhan_Vien  
@ID INT,
@TEN NVARCHAR(20),
@HO NVARCHAR(20),
@DIACHI NVARCHAR(20),
@SODT NVARCHAR(10),
@HINHANH NVARCHAR(100),
@EMAIL NVARCHAR(100),
@GIOITINH INT,
@NGAYSINH DATE,
@LUONG INT,
@TRANGTHAI INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			DECLARE @MANV INT;
			DECLARE @TENTK NVARCHAR(40);

			SET @MANV = (SELECT id FROM NhanVien WHERE maHoSo = @ID)
			SET @TENTK = (SELECT tenDangNhap FROM NhanVien WHERE maHoSo = @ID)

			UPDATE HoSo SET ten=@TEN, ho=@HO, diachi=@DIACHI, soDT=@SODT, hinhanh=@HINHANH, email=@EMAIL, gioitinh = @GIOITINH, ngaysinh=@NGAYSINH, luong = @LUONG
			WHERE id=@ID

			UPDATE NhanVien SET trangthai = @TRANGTHAI
			WHERE id = @MANV
		COMMIT
	END TRY
		
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
	END CATCH 
END;
GO

-- procedure Thêm thông tin nhân viên
CREATE OR ALTER PROC usp_Them_Thong_Tin_Nhan_Vien
@TEN NVARCHAR(20),
@HO NVARCHAR(20),
@DIACHI NVARCHAR(20),
@SODT NVARCHAR(10),
@HINHANH NVARCHAR(100),
@EMAIL NVARCHAR(100),
@GIOITINH INT,
@NGAYSINH DATE,
@LUONG INT,
@TENTK NVARCHAR(30),
@MK NVARCHAR(100),
@TRANGTHAI INT,
@VAITRO INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(LEN(@MK) < 8 )
				RETURN
			DECLARE @MAHS INT;
			DECLARE @MANV INT;
			INSERT INTO HoSo VALUES(@TEN,@HO,@DIACHI,@SODT,@HINHANH,@EMAIL,@GIOITINH,@NGAYSINH,@LUONG)
			SET @MAHS = SCOPE_IDENTITY();
			INSERT INTO NhanVien VALUES(@TENTK, pwdencrypt(@MK), @TRANGTHAI, @MAHS);
			SET @MANV = SCOPE_IDENTITY();

			DECLARE @Login VARCHAR(100);
			DECLARE @User VARCHAR(1000);
			DECLARE @Permision VARCHAR(1000);
			SET @Login = 'CREATE LOGIN ' + @TENTK + ' WITH PASSWORD = ''' + @MK +'''' 
			SET @User = 'CREATE USER ' + @TENTK + ' FOR LOGIN ' + @TENTK

			 -- Gán quyền thủ thư
			INSERT INTO vaitro_nhanVien VALUES (@MANV,2);

			 -- Gán quyền nhân viên quản lý ( vừa là quản lý, vừa thủ thư)
			IF(@VAITRO = 1)
				BEGIN 
					INSERT INTO vaitro_nhanVien VALUES (@MANV,1);
					SET @Permision = 'GRANT EXEC, SELECT, INSERT, UPDATE, DELETE TO ' + @TENTK
					EXEC (@Login)
					EXEC (@User)
					EXEC (@Permision)
					EXEC master..sp_addsrvrolemember @loginame = @TENTK, @rolename = N'sysadmin'
				END
			ELSE
				BEGIN
					EXEC (@Login)
					EXEC (@User)
					EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = @TENTK
				END
			SELECT @MAHS;

		COMMIT 
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
	END CATCH
	
END;
GO 

-- procedure đổi mật khẩu nhân viên
CREATE OR ALTER PROC usp_Doi_Mat_Khau 
@MAHOSO INT,
@MATKHAUCU NVARCHAR(1000),
@MATKHAUMOI NVARCHAR(1000)
AS
BEGIN
	IF(LEN(@MATKHAUMOI) < 8 )
	BEGIN 
		RETURN
	END

	DECLARE @MKDB VARBINARY(128);
	DECLARE @TENDANGNHAP VARCHAR(200)
	SELECT @MKDB =  matkhau, @TENDANGNHAP = tenDangNhap FROM NhanVien INNER JOIN HoSo ON NhanVien.maHoSo = HoSo.id WHERE HoSo.id = @MAHOSO
	If(pwdcompare(@MATKHAUCU,@MKDB) = 1)
	BEGIN
		UPDATE NhanVien SET  matkhau = pwdencrypt(@MATKHAUMOI)  FROM NhanVien INNER JOIN HoSo ON NhanVien.maHoSo = HoSo.id WHERE HoSo.id = @MAHOSO
		
		DECLARE @STATEMENT VARCHAR(200)
		SET @STATEMENT = 'ALTER LOGIN ' + @TENDANGNHAP + ' WITH PASSWORD = ''' + @MATKHAUMOI +'''' + ' OLD_PASSWORD = ''' + @MATKHAUCU +''''
		PRINT (@STATEMENT)
		EXEC(@STATEMENT)
	END
END
GO


-- procedure đổi mật khẩu cho quản lý
CREATE OR ALTER PROC usp_Quan_Ly_Doi_Mat_Khau 
@MAHOSO INT,
@MATKHAUMOI NVARCHAR(1000)
AS
BEGIN
	
	IF(LEN(@MATKHAUMOI) < 8 )
	BEGIN 
		RETURN
	END

	DECLARE @TENDANGNHAP VARCHAR(200)

	UPDATE NhanVien SET  matkhau = pwdencrypt(@MATKHAUMOI)  FROM NhanVien INNER JOIN HoSo ON NhanVien.maHoSo = HoSo.id WHERE HoSo.id = @MAHOSO
	SELECT @TENDANGNHAP = tenDangNhap FROM NhanVien INNER JOIN HoSo ON NhanVien.maHoSo = HoSo.id WHERE HoSo.id = @MAHOSO
	DECLARE @STATEMENT VARCHAR(200)
	SET @STATEMENT = 'ALTER LOGIN ' + @TENDANGNHAP + ' WITH PASSWORD = ''' + @MATKHAUMOI +''''
	EXEC(@STATEMENT)

END
GO
-- procedure sửa hồ sơ
CREATE OR ALTER PROC usp_Sua_Ho_So
@ID INT,
@TEN NVARCHAR(20),
@HO NVARCHAR(20),
@DIACHI NVARCHAR(20),
@SODT NVARCHAR(10),
@HINHANH NVARCHAR(100),
@EMAIL NVARCHAR(100),
@GIOITINH INT,
@NGAYSINH DATE
AS
BEGIN
	UPDATE HoSo SET ten=@TEN, ho=@HO, diachi=@DIACHI, soDT=@SODT, hinhanh=@HINHANH, email=@EMAIL, gioitinh = @GIOITINH, ngaysinh=@NGAYSINH
	WHERE id=@ID
END;
GO 

-- procedure lấy hình ảnh nhân viên
CREATE OR ALTER PROC usp_Hinh_Anh_Nhan_Vien
@TENDANGNHAP NVARCHAR(30)
AS
BEGIN
		SELECT HinhAnh FROM HoSo
		INNER JOIN NhanVien ON HoSo.id = NhanVien.maHoSo
		WHERE NhanVien.tenDangNhap = @TENDANGNHAP;
END
GO

CREATE OR ALTER PROC usp_MA_NHAN_VIEN_THEO_TEN
@TENDANGNHAP NVARCHAR(30)
AS
BEGIN
		SELECT id FROM NhanVien
		WHERE NhanVien.tenDangNhap = @TENDANGNHAP;
END
GO

-- procedure lấy mã hồ sơ
CREATE OR ALTER PROC usp_Lay_MaHS
@TENDANGNHAP NVARCHAR(30)
AS
BEGIN
		SELECT maHoSo FROM NhanVien
		WHERE NhanVien.tenDangNhap = @TENDANGNHAP;
END
GO

-- procedure thêm hình ảnh nhân viên
CREATE OR ALTER PROC usp_Them_Hinh_Anh_Nhan_Vien
@ID INT,
@HINHANH NVARCHAR(100)
AS
BEGIN
	UPDATE HoSo SET hinhAnh = @HINHANH WHERE ID = @ID
END;
GO

-- procedure Xem toàn bộ thông tin nhân viên
CREATE OR ALTER PROC usp_Xem_Toan_Bo_Thong_Tin_Nhan_Vien
AS
BEGIN
	SELECT HoSo.id, HoSo.ten, string_agg(VaiTro.ten,' , ') AS vaitro, tenDangNhap,ho,diachi ,soDT,hinhanh,email, gioitinh, ngaysinh,luong, trangthai
	FROM HoSo 
	INNER JOIN NhanVien on HoSo.id = NhanVien.maHoSo
		INNER JOIN vaitro_nhanVien ON vaitro_nhanVien.maNhanVien = NhanVien.id
			INNER JOIN VaiTro ON vaitro_nhanVien.maVaiTro = VaiTro.id
	GROUP BY NhanVien.id, HoSo.id,  HoSo.ten,tenDangNhap,ho,diachi ,soDT,hinhanh,email, gioitinh, ngaysinh,luong, trangthai
END;
GO

-- procedure Xem thông tin nhân viên theo id
CREATE OR ALTER PROC usp_Xem_Thong_Tin_Nhan_Vien
@id INT
AS
BEGIN
	SELECT NhanVien.id AS [maTaiKhoan], HoSo.id,HoSo.ten, string_agg(VaiTro.ten,' , ') AS vaitro, tenDangNhap, ho,diachi ,soDT,hinhanh,email, gioitinh, ngaysinh,luong, trangthai
	FROM HoSo 
	INNER JOIN NhanVien on HoSo.id = NhanVien.maHoSo
		INNER JOIN vaitro_nhanVien ON vaitro_nhanVien.maNhanVien = NhanVien.id
			INNER JOIN VaiTro ON vaitro_nhanVien.maVaiTro = VaiTro.id
	WHERE HoSo.id = @id
	GROUP BY NhanVien.id, HoSo.id,HoSo.ten,tenDangNhap, ho,diachi ,soDT,hinhanh,email, gioitinh, ngaysinh,luong, trangthai
END;
GO


-- procedure chuyển trạng thái tài khoản nhân viên
CREATE OR ALTER PROC usp_Chuyen_Trang_Thai_Nhan_Vien
@ID INT,
@TRANGTHAI INT
AS
BEGIN
	UPDATE NhanVien SET trangthai=@TRANGTHAI WHERE id=@ID
END;
GO





-- procedure kiểm tra đăng nhập 
CREATE OR ALTER PROC usp_Kiem_Tra_Dang_Nhap 
    @tenDangNhap NVARCHAR(40),
    @matKhau Nvarchar(100)
AS
BEGIN
	DECLARE @maNhanVien INT;
	DECLARE @trangThai INT;
	SELECT @maNhanVien = NhanVien.id, @trangThai = NhanVien.trangthai FROM NhanVien WHERE NhanVien.tenDangNhap = @tenDangNhap AND pwdcompare(@matKhau,NhanVien.matkhau) = 1
	
	-- Kiểm tra tài khoản có bị chặn không
	IF(@trangThai = 0 )
	BEGIN
		SELECT -1
			RETURN
	END
		
	IF (@maNhanVien IS NOT NULL)
		SELECT @maNhanVien 
	ELSE
		SELECT -1
END
GO
--============================================= PHIẾU MƯỢN =============================================--
-- procedure thêm thông tin phiếu mượn
CREATE OR ALTER proc usp_Them_Thong_Tin_Phieu_Muon
  @ngaymuon DATE,
  @ngaytra DATE,
  @ngayhethan DATE,
  @tienphat INT,
  @maNhanVien INT,
  @maDocGia INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE @MAMUON INT;
			INSERT INTO Muon VALUES(@ngaymuon, @ngaytra, @ngayhethan, @tienphat ,@maNhanVien, @maDocGia);
			SET @MAMUON = SCOPE_IDENTITY()

			UPDATE MuonSachTemp SET maMuon=@MAMUON, trangthai=0;

			INSERT INTO MuonSach(maSach, maMuon, ghiChu, trangthai) SELECT maSach, maMuon, trangthai, ghiChu FROM MuonSachTemp;
			
		COMMIT
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
	END CATCH
	EXEC usp_XOA_BANG_TAM;
END;

GO



CREATE OR ALTER PROC usp_THEM_TAM_SACH_TRONG_PHIEU_MUON
@MASACH INT,
@GHICHU NVARCHAR(50)
AS
BEGIN
	INSERT INTO MuonSachTemp(maSach, ghiChu) VALUES(@MASACH, @GHICHU);	
END
GO

CREATE OR ALTER PROC usp_XOA_BANG_TAM
AS
BEGIN
	DELETE FROM MuonSachTemp;	
END
GO

-- procedure xóa thông tin phiếu mượn quá hạn ( trên 1 năm )
CREATE OR ALTER PROC usp_Xoa_Phieu_Muon_Qua_Han
AS
BEGIN
	DELETE FROM Muon WHERE DATEDIFF(day, GETDATE(), Muon.ngaytra) > 365
END;
GO

-- procedure xem thông tin phiếu mượn
CREATE OR ALTER PROCEDURE usp_Xem_Thong_Tin_Phieu_Muon
@id INT
AS
BEGIN
   SELECT * FROM Muon
   WHERE id = @id;
END;
GO

-- procedure lấy thông tin phiếu mượn
CREATE OR ALTER PROC usp_THONG_TIN_PHIEU_MUON
@ID INT
AS
BEGIN
	SELECT DocGia.ten, DocGia.mssv, DocGia.khoa, HoSo.ten, Muon.ngaymuon, Muon.ngayhethan, Muon.ngaytra, Muon.tienphat
	FROM Muon JOIN NhanVien ON maNhanVien=NhanVien.id
				JOIN HoSo ON NhanVien.maHoSo=HoSo.id
					JOIN DocGia ON maDocGia=DocGia.id
	WHERE Muon.id=@ID		
END
GO

-- procedure cập nhật thông tin phiếu mượn
CREATE OR ALTER PROC usp_CAP_NHAT_THONG_TIN_PHIEU_MUON
@ID INT,
@NGAYTRA DATE,
@TIENPHAT INT
AS
BEGIN
	UPDATE Muon SET ngaytra=@NGAYTRA, tienphat=@TIENPHAT 
			WHERE id=@ID		
END
GO

-- procedure cập nhật thành phần phiếu mượn
CREATE OR ALTER PROC usp_CAP_NHAT_MUON_SACH
@MAMUON INT,
@MASACH INT,
@TRANGTHAI INT,
@GHICHU NVARCHAR(50)
AS
BEGIN
	UPDATE MuonSach SET trangthai=@TRANGTHAI, ghiChu=@GHICHU 
			WHERE maMuon=@MAMUON AND maSach=@MASACH		
END
GO

CREATE OR ALTER PROC usp_TIM_DOC_GIA
@USERNAME NVARCHAR(30)
AS
BEGIN
	SELECT id FROM NhanVien WHERE tenDangNhap=@USERNAME	
END
GO



CREATE OR ALTER PROC usp_THEM_SACH_TRONG_PHIEU_MUON
@MAMUON INT,
@MASACH INT,
@TRANGTHAI INT,
@GHICHU NVARCHAR(50)
AS
BEGIN
	INSERT INTO MuonSach VALUES(@MASACH, @MAMUON, @GHICHU, @TRANGTHAI);	
END
GO

-- procedure Lấy sách trong phiếu mượn
CREATE OR ALTER PROC usp_SACH_TRONG_PHIEU_MUON
@MAMUON INT
AS
BEGIN
	SELECT SACH.id, DauSach.tieude, MuonSach.trangthai, MuonSach.ghiChu FROM MuonSach JOIN Sach ON MuonSach.maSach=Sach.id
							JOIN DauSach ON Sach.maDauSach=DauSach.id
			WHERE maMuon=@MAMUON
END
GO

-- procedure xem thông tin phiếu mượn
CREATE OR ALTER PROC usp_PHIEU_MUON
AS
BEGIN
	SELECT id, ngaymuon, ngayhethan, dbo.fn_Trang_Thai_Phieu_Muon(m.id), tienphat FROM Muon m
END
GO

CREATE OR ALTER PROC usp_LOC_PHIEU_MUON
@MSSV INT,
@TRANGTHAI INT
AS
BEGIN
	IF(@MSSV = -1) 
	BEGIN
		IF(@TRANGTHAI = 2) SELECT id, ngaymuon, ngayhethan, dbo.fn_Trang_Thai_Phieu_Muon(m.id), tienphat FROM Muon m;
		ELSE SELECT id, ngaymuon, ngayhethan, dbo.fn_Trang_Thai_Phieu_Muon(m.id), tienphat FROM Muon m WHERE dbo.fn_Trang_Thai_Phieu_Muon(m.id)=@TRANGTHAI;
	END
	ELSE
	BEGIN
		IF(@TRANGTHAI=2) SELECT id, ngaymuon, ngayhethan, dbo.fn_Trang_Thai_Phieu_Muon(m.id), tienphat FROM Muon m WHERE maDocGia=@MSSV;
		ELSE SELECT id, ngaymuon, ngayhethan, dbo.fn_Trang_Thai_Phieu_Muon(m.id), tienphat FROM Muon m WHERE maDocGia=@MSSV AND dbo.fn_Trang_Thai_Phieu_Muon(m.id)=@TRANGTHAI;
	END
END
GO
--================ Function ====================================

-- function trả về tổng lương nhân viên
CREATE OR ALTER FUNCTION fn_Tong_Luong_Nhan_Vien()
RETURNS INT AS
BEGIN
   DECLARE @salary INT;
   SELECT @salary = COUNT(HoSo.luong) FROM NhanVien
	INNER JOIN HoSo ON NhanVien.maHoSo = HoSo.id;
   RETURN @salary;
END;
GO
-- function trả về tổng số lượng sách theo trạng thái
CREATE OR ALTER FUNCTION fn_Tong_Sach_Theo_Trang_Thai(
@ID_DAU_SACH INT,
@TRANG_THAI INT
)
RETURNS INT
AS
BEGIN
	DECLARE @NUMBER INT;
	SELECT @NUMBER=COUNT(*) FROM Sach WHERE maDauSach=@ID_DAU_SACH and trangthai=@TRANG_THAI;
	RETURN @NUMBER
END;
GO
-- function trả về tổng số cuốn sách
CREATE OR ALTER FUNCTION fn_Tong_Sach(
@ID_DAU_SACH INT
)
RETURNS INT
AS
BEGIN
	DECLARE @NUMBER INT;
	SELECT @NUMBER=COUNT(*) FROM Sach WHERE maDauSach=@ID_DAU_SACH;
	RETURN @NUMBER
END;

GO

-- function trả về vai trò theo nhân viên
CREATE OR ALTER FUNCTION fn_Vai_Tro_Nhan_Vien( @id INT)
RETURNS NVARCHAR(10) AS
BEGIN
   DECLARE @vaitro NVARCHAR(10);
   SELECT @vaitro = string_agg(VaiTro.id,' , ') FROM NhanVien
   INNER JOIN vaitro_nhanVien ON NhanVien.id = vaitro_nhanVien.maNhanVien
		INNER JOIN VaiTro ON vaitro_nhanVien.maVaiTro=VaiTro.id
   WHERE NhanVien.id = @id
   GROUP BY vaitro_nhanVien.maNhanVien
   RETURN @vaitro;
END;
GO



-- function trả về tổng số sách theo tác giả
CREATE OR ALTER FUNCTION fn_Tong_So_Sach_Theo_Tac_Gia(@id INT)
RETURNS INT
AS
BEGIN
	DECLARE @soLuong INT;
	SELECT @soLuong=COUNT(*) 
	FROM TacGia 
	JOIN tacgia_sach ON TacGia.id = tacgia_sach.maTacGia
	JOIN DauSach ON DauSach.id = tacgia_sach.maDauSach
	WHERE TacGia.id = @id
	GROUP BY TacGia.id;
	RETURN @soluong;
END;
GO

-- function trả về tổng số sách theo nhà xuất bản
CREATE OR ALTER FUNCTION fn_Tong_So_Sach_Theo_Nha_Xuat_Ban(@id INT)
RETURNS INT
AS
BEGIN
	DECLARE @soLuong INT;
	SELECT @soLuong=COUNT(DauSach.id) 
	FROM NhaXuatBan INNER JOIN DauSach ON NhaXuatBan.id = DauSach.maNXB
	WHERE NhaXuatBan.id = @id
	GROUP BY NhaXuatBan.id;
	RETURN @soLuong;
END;
GO

-- function trả về tổng số sách theo thể loại
CREATE OR ALTER FUNCTION fn_Tong_So_Sach_Theo_The_Loai(@id INT)
RETURNS INT
AS
BEGIN
	DECLARE @soLuong INT;
	SELECT @soLuong=COUNT(DauSach.id) 
	FROM TheLoai INNER JOIN DauSach ON TheLoai.id = DauSach.maTheLoai
	WHERE DauSach.id = @id
	GROUP BY DauSach.id;
	RETURN @soLuong;
END;
GO


-- function trả về tổng số sách theo ngôn ngữ
CREATE OR ALTER FUNCTION fn_Tong_So_Sach_Theo_Ngon_Ngu(@id INT)
RETURNS INT
AS
BEGIN
	DECLARE @soLuong INT;
	SELECT @soLuong=COUNT(DauSach.id) 
	FROM NgonNgu INNER JOIN DauSach ON NgonNgu.id = DauSach.maNgonNgu
	WHERE DauSach.id = @id
	GROUP BY DauSach.id;
	RETURN @soLuong;
END;
GO

-- function trả về tổng số phiếu mượn theo trạng thái 
CREATE OR ALTER FUNCTION fn_Trang_Thai_Phieu_Muon(
@ID_PHIEU_MUON INT
)
RETURNS INT
AS
BEGIN
	DECLARE @NUMBER INT;
	SELECT @NUMBER=COUNT(*) FROM MuonSach WHERE MuonSach.maMuon=@ID_PHIEU_MUON;
	IF @NUMBER > 0 RETURN 0;
	RETURN 1;
END;
GO


--================ INSERT DATA ====================================

INSERT INTO TheLoai VALUES(N'Công nghệ thông tin');					--1
INSERT INTO TheLoai VALUES(N'Công nghệ may - Thời trang');			--2
INSERT INTO TheLoai VALUES(N'Công nghệ in - Truyền thông');			--3
INSERT INTO TheLoai VALUES(N'Kinh tế - Quản lý');					--4
INSERT INTO TheLoai VALUES(N'Công nghệ thực phẩm - Môi trường');	--5
INSERT INTO TheLoai VALUES(N'Nông - Lâm - Ngư nghiệp');				--6
INSERT INTO TheLoai VALUES(N'Xây dựng - Kiến trúc');				--7
INSERT INTO TheLoai VALUES(N'Y học - Sức khỏe');					--8
INSERT INTO TheLoai VALUES(N'Cơ khí chế tạo máy');					--9
INSERT INTO TheLoai VALUES(N'Điện - điện tử');						--10
INSERT INTO TheLoai VALUES(N'Cơ khí động lực');						--11
INSERT INTO TheLoai VALUES(N'Văn học');								--12
INSERT INTO TheLoai VALUES(N'Ngôn ngữ');							--13
INSERT INTO TheLoai VALUES(N'Lịch sử - Địa Lý - Du lịch');			--14




INSERT INTO NgonNgu VALUES(N'Tiếng việt');							--1
INSERT INTO NgonNgu VALUES(N'Tiếng anh');							--2
INSERT INTO NgonNgu VALUES(N'Tiếng trung');							--3
INSERT INTO NgonNgu VALUES(N'Tiếng nhật');							--4
INSERT INTO NgonNgu VALUES(N'Tiếng hàn');							--5
INSERT INTO NgonNgu VALUES(N'Song ngữ');							--6

INSERT INTO TacGia VALUES(N'Ngô Trí Phúc');							--1
INSERT INTO TacGia VALUES(N'Nguyễn Sơn Lâm');						--2
INSERT INTO TacGia VALUES(N'Phạm Trọng Khu');						--3
INSERT INTO TacGia VALUES(N'Trần Quang Long');						--4
INSERT INTO TacGia VALUES(N'FOSECO (FS) Ltd');						--5
INSERT INTO TacGia VALUES(N'Don Sexton');							--6
INSERT INTO TacGia VALUES(N'Dan S. Kenedy');						--7
INSERT INTO TacGia VALUES(N'Kathleen Park Talaro');					--8
INSERT INTO TacGia VALUES(N'Barry Chess');							--9
INSERT INTO TacGia VALUES(N'Jake VanderPlas');						--10
INSERT INTO TacGia VALUES(N'Lawrence C. Linnemeyer');				--11
INSERT INTO TacGia VALUES(N'Bradley D. Brown');						--12
INSERT INTO TacGia VALUES(N'Peggy R Hoyt');							--13
INSERT INTO TacGia VALUES(N'Trịnh Ngọc Trang');						--14
INSERT INTO TacGia VALUES(N'Lisa Graham');							--15
INSERT INTO TacGia VALUES(N'A. K. Haghi');							--16
INSERT INTO TacGia VALUES(N'Elizabeth Carvajal-Millan');			--17
INSERT INTO TacGia VALUES(N'Trần Đức Hạ');							--18
INSERT INTO TacGia VALUES(N'Tạ Thu Cúc');							--19
INSERT INTO TacGia VALUES(N'Vũ Đình Chính');						--20
INSERT INTO TacGia VALUES(N'Nguyễn Văn Bình');						--21
INSERT INTO TacGia VALUES(N'Joel Goldberg');						--22
INSERT INTO TacGia VALUES(N'Valerie C. Scanlon');					--23
INSERT INTO TacGia VALUES(N'Tina Sanders Medical');					--24
INSERT INTO TacGia VALUES(N'Viện Dược Liệu');						--25
INSERT INTO TacGia VALUES(N'James Yu');								--26
INSERT INTO TacGia VALUES(N'Michael Herz');							--27
INSERT INTO TacGia VALUES(N'Simon Haykin');							--28
INSERT INTO TacGia VALUES(N'Rajkumar Buyya');						--29
INSERT INTO TacGia VALUES(N'Amir Vahid Dastjerdi');					--30
INSERT INTO TacGia VALUES(N'Trần Thế Sang');						--31
INSERT INTO TacGia VALUES(N'Nguyễn Đức Phấn');						--32
INSERT INTO TacGia VALUES(N'Nguyễn Duy Động');						--33
INSERT INTO TacGia VALUES(N'Nguyễn Đức Lợi');						--34
INSERT INTO TacGia VALUES(N'Nguyễn Nhật Ánh');						--35
INSERT INTO TacGia VALUES(N'Kousuke Sawamura');						--36
INSERT INTO TacGia VALUES(N'Trang Anh');							--37
INSERT INTO TacGia VALUES(N'Hứa Kim Sinh');							--38
INSERT INTO TacGia VALUES(N'Hồ Văn Hoa');							--39
INSERT INTO TacGia VALUES(N'Ngô Trung Vĩ');							--40
INSERT INTO TacGia VALUES(N'Ahn Jean-myung');						--41
INSERT INTO TacGia VALUES(N'Lee Kyung-ah');							--42
INSERT INTO TacGia VALUES(N'Han Hoo-young');						--43
INSERT INTO TacGia VALUES(N'Trần Hải Quỳnh');						--44
INSERT INTO TacGia VALUES(N'Paul Johnson');							--45
INSERT INTO TacGia VALUES(N'Bộ Giáo Dục Và Đào Tạo');				--46


INSERT INTO NhaXuatBan VALUES(N'Khoa học và Kỹ thuật');								--1
INSERT INTO NhaXuatBan VALUES(N'Xây dựng');											--2
INSERT INTO NhaXuatBan VALUES(N'Butterworth-Heinemann');							--3
INSERT INTO NhaXuatBan VALUES(N'Lao Động');											--4
INSERT INTO NhaXuatBan VALUES(N'Tổng Hợp TPHCM');									--5
INSERT INTO NhaXuatBan VALUES(N'McGraw Hill');										--7
INSERT INTO NhaXuatBan VALUES(N'O''Reilly Media');									--8
INSERT INTO NhaXuatBan VALUES(N'Gratitude Partners');								--9 
INSERT INTO NhaXuatBan VALUES(N'Giao thông vận tải');								--10 
INSERT INTO NhaXuatBan VALUES(N'Cengage Learning');									--11
INSERT INTO NhaXuatBan VALUES(N'Apple Academic Press');								--12
INSERT INTO NhaXuatBan VALUES(N'Phụ Nữ');											--13
INSERT INTO NhaXuatBan VALUES(N'Đại Học Sư Phạm');									--14
INSERT INTO NhaXuatBan VALUES(N'F.A. Davis Company');								--15
INSERT INTO NhaXuatBan VALUES(N'Design Media Publishing (UK) Limited');				--16
INSERT INTO NhaXuatBan VALUES(N'Wiley');											--17
INSERT INTO NhaXuatBan VALUES(N'Morgan Kaufmann');									--18
INSERT INTO NhaXuatBan VALUES(N'Giáo dục Việt Nam');								--19
INSERT INTO NhaXuatBan VALUES(N'Trẻ');												--20
INSERT INTO NhaXuatBan VALUES(N'Thanh Niên');										--21
INSERT INTO NhaXuatBan VALUES(N'Đại Học Quốc Gia Hà Nội');							--22
INSERT INTO NhaXuatBan VALUES(N'Hồng Đức');											--23
INSERT INTO NhaXuatBan VALUES(N'Dân Trí');											--24
INSERT INTO NhaXuatBan VALUES(N'Tổng hợp');											--25

INSERT INTO VaiTro VALUES(N'Quản lý',N'Quản lý mọi thứ');
INSERT INTO VaiTro VALUES(N'Thủ thư',N'Quản lý cho/nhận sách');


INSERT INTO DocGia VALUES(N'Lê Hải Đăng',N'20110623',N'Công nghệ thông tin',1,1,'01-01-2002','0123456789','20110623@student.hcmute.edu.vn','');
INSERT INTO DocGia VALUES(N'Hứa Lộc Sơn',N'20110345',N'Đào tạo Chất lượng cao',1,1,'01-07-2002','0122544789','20110345@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Lê Anh Kiệt',N'20110678',N'Công nghệ thông tin',1,1,'03-04-2002','0164246789','20110678@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Nguyễn Hưng Khang',N'20110912',N'Cơ khí Động lực',1,1,'01-04-2002','0125126789','20110912@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Nguyễn Văn Hải',N'20110722',N'Điện - Điện tử',1,1,'11-08-2002','0152421789','20110722@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Lưu Chí Bảo',N'20157625',N'Công nghệ Hóa học và Thực phẩm',1,1,'01-07-2002','0123425428','20157625@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Nguyễn Văn Tuấn',N'20156450',N'Xây dựng',1,1,'11-03-2002','0563465689','20156450@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Nguyễn Hưng Thịnh',N'20168573',N'Công nghệ Thông tin',1,1,'01-06-2002','0125242789','20168573@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Trần Hải My',N'20147657',N'Kinh tế',2,1,'11-07-2002','0121246789','20147657@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Nguyễn Hưng Phúc',N'20118158',N'Cơ khí Chế tạo máy',1,1,'01-01-2002','0123458729','20118158@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Lê Thị Trúc',N'20137548',N'In - Truyền thông',2,1,'11-04-2002','0124757389','20137548@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Trần Bảo Anh',N'20168251',N'Ngoại ngữ',2,1,'10-04-2002','0123689789','20168251@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Trần Anh Thư',N'20185645',N'Kinh tế',2,1,'02-05-2002','0123136989','20185645@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Nguyễn Hải Đăng',N'20168623',N'Đào tạo Quốc tế',1,1,'07-06-2002','0123412789','20168623@student.edu.vn','');
INSERT INTO DocGia VALUES(N'Nguyễn Thanh Thảo',N'20189367',N'Thời trang và Du lịch',2,1,'02-06-2002','0123459739','20189367@student.edu.vn','');




INSERT INTO DauSach VALUES(N'Công nghệ sản xuất ferro: Hợp kim sắt', N'Giáo trình này được biên soạn trong Bộ môn Luyện kim đen',76000,'06-04-2006','/uploads/dauSach/1.png',0,1,1,1,9);
INSERT INTO DauSach VALUES(N'Hàn trong môi trường khí bảo vệ', N'Cùng với sự phát triển của khoa học công nghệ trên thế giới, lĩnh vực cơ chí chế tạo nói chung và ngành Hàn ở Việt Nam nói riêng đã có những bước phát triển đáng kể về số lượng và chất lượng đóng góp cho sự nghiệp công nghiệp hóa – hiện đại hóa đất nước. Việc biên soạn tài liệu chuyên môn nhằm đáp ứng nhu cầu về tài liệu cho học sinh, tài liệu tham khảo cho giáo viên, tạo tiếng nói chung trong quá trình đào tạo, phù hợp với tiêu chuẩn Quốc tế và đáp ứng yêu cầu sản xuất thực tế là một điều cấp thiết.',30000,'03-01-2002','/uploads/dauSach/2.png',1,1,2,1,9);
INSERT INTO DauSach VALUES(N'Foseco Foundryman''s Handbook: Facts, figures and formulae', N'The aim of the Foundryman''s Handbook is to provide a practical reference book for all those concerned with making casting',1200000,'06-29-1994','/uploads/dauSach/3.png',0,0,3,2,9);
INSERT INTO DauSach VALUES(N'Marketing căn bản', N'Dù bạn bán cái gì và bán như thế nào, bạn điều hành một doanh nghiệp nhỏ hay một tập đoàn lớn, cuốn sách hướng dẫn đầy đủ và toàn diện này giải thích tất cả những điều bạn nên biết về marketing hiện đại.',135000,'04-22-2022','/uploads/dauSach/4.png',0,1,4,1,4);
INSERT INTO DauSach VALUES(N'Thư Bán Hàng Đỉnh Cao', N'Được xuất bản lần đầu tiên vào năm 1990, “Thư Bán Hàng Đỉnh Cao” đã được hàng chục ngàn độc giả thuộc rất nhiều ngành nghề và lĩnh vực kinh doanh khác nhau yêu thích. Đây là quyển sách hướng dẫn chi tiết và giúp truyền cảm hứng để mọi người tạo ra được những “thư bán hàng đỉnh cao”.',105000,'07-01-1990','/uploads/dauSach/5.png',0,0,5,1,4);
INSERT INTO DauSach VALUES(N'Foundations in Microbiology: Basic Principles', N'Foundations in Microbiology is an allied health microbiology text with a taxonomic approach to the disease chapters. It offers an engaging and accessible writing style through the use of case studies and analogies to thoroughly explain difficult microbiology concepts.',100000,'01-13-2017','/uploads/dauSach/6.png',0,0,7,2,1);
INSERT INTO DauSach VALUES(N'Python data science handbook: essential tools for working with data', N'For many researchers, Python is a first-class tool mainly because of its libraries for storing, manipulating, and gaining insight from data. Several resources exist for individual pieces of this data science stack, but only with the Python Data Science Handbook do you get them all--IPython, NumPy, Pandas, Matplotlib, Scikit-Learn, and other related tools.',360000,'03-01-2017','/uploads/dauSach/7.png',0,0,8,2,1);
INSERT INTO DauSach VALUES(N'Oracle HTML DB handbook', N'Oracle HTML DB Handbook shows you how to quickly create secure and scalable web applications that can be instantly deployed.',160000,'03-20-2006','/uploads/dauSach/8.png',0,0,7,2,1);
INSERT INTO DauSach VALUES(N'All My Children Wear Fur Coats', N'How to leave a legacy for your pet. Animal companions... your pets... "your children." Whatever you call them, they are dearly loved family members. ',480000,'05-01-2009','/uploads/dauSach/9.png',0,0,9,2,2);
INSERT INTO DauSach VALUES(N'Sửa Chữa Máy Photocopy - Kỹ Năng Thực Hành', N'Quyển sách này giới thiệu chi tiết các nguyên lý và kết cấu tổ hợp thành máy photo kỹ thuật số, đồng thời kết hợp nhiều ví dụ thực tiễn để giải thích và phân tích việc lắp đặt, tháo dỡ, điều chỉnh, khắc phục sự cố. Giúp  người đọc nắm vững được nguyên lý vận hành của máy photo, từ đó nâng cao kỹ năng sửa chữa. ',65000,'05-04-2001','/uploads/dauSach/10.png',0,1,10,1,3);
INSERT INTO DauSach VALUES(N'Basics of Design: Layout & Typography for Beginners', N'Basics of Design: Layout and Typography for Beginners demystifies the design process with straightforward and complete explanations of the fundamental principles that create first-rate visual design. ',580000,'01-13-2015','/uploads/dauSach/11.png',0,0,11,2,3);
INSERT INTO DauSach VALUES(N'Food Composition and Analysis: Methods and Strategies', N'This book covers methods and strategies related to food composition and analysis.',1200000,'01-05-2014','/uploads/dauSach/12.png',0,0,12,2,5);
INSERT INTO DauSach VALUES(N'Xử lý nước thải sinh hoạt quy mô nhỏ và vừa', N'giáo trình dùng cho sinh viên đại học các ngành xây dựng cơ bản',50000,'07-08-2009','/uploads/dauSach/13.png',1,1,1,1,5);
INSERT INTO DauSach VALUES(N'Kỹ thuật trồng rau sạch:Trồng rau ăn lá', N'Cuốn sách “Kỹ thuật trồng rau sạch - trồng rau ăn lá” hướng dẫn các bạn đọc áp dụng những tiến bộ khoa học kỹ thuật tiên tiến vào việc trồng rau, tạo ra những vườn rau sạch phục vụ cho bữa cơm hàng ngày của nhân dân.',15000,'05-01-2007','/uploads/dauSach/14.png',1,1,13,1,6);
INSERT INTO DauSach VALUES(N'Kĩ thuật trồng cây công nghiệp: Sách dành cho cao đẳng sư phạm', N'hướng dẫn các bạn đọc áp dụng những tiến bộ khoa học kỹ thuật tiên tiến vào việc trồng cây tạo ra những vườn cây sạch',40000,'03-05-2007','/uploads/dauSach/15.png',1,1,14,1,6);
INSERT INTO DauSach VALUES(N'Lange Practice Tests for the USMLE Step 3', N'Offering 15 comprehensive practice tests with a total of more than 750 review questions, this is the perfect study tool to assist time-strapped residences get through the study process.',270000,'04-11-2005','/uploads/dauSach/16.png',0,0,7,2,8);
INSERT INTO DauSach VALUES(N'Essentials of Anatomy and Physiology', N'Here is the approach that makes A&P easier to master. A student-friendly writing style, superb art program, and learning opportunities in every chapter build a firm foundation in this must-know subject to ensure success.',1300000,'10-15-2018','/uploads/dauSach/17.png',0,0,15,2,8);
INSERT INTO DauSach VALUES(N'Cây Thuốc Và Động Vật Làm Thuốc - Tập 3', N'Cây Thuốc Và Động Vật Làm Thuốc là công trình khoa học giới thiệu một cách chi tiết và toàn diện về nguồn dược liệu quý của Việt Nam do tập thể các nhà khoa học, tập thể các chuyên gia có uy tín đã và đang làm việc trong lĩnh vực dược liệu biên soạn.',340000,'07-04-2011','/uploads/dauSach/18.png',0,1,1,1,8);
INSERT INTO DauSach VALUES(N'Hotel Proposals', N'The book is a selection of outstanding hotel proposals around the world in recent years. It introduces the modern hotel design ideas that would be trends in the future.',1060000,'09-15-2014','/uploads/dauSach/19.png',0,0,16,2,7);
INSERT INTO DauSach VALUES(N'Campus Landscape Planning & Design', N'This book is composed by two parts: technical theories and some wonderful projects.',730000,'07-15-2014','/uploads/dauSach/20.png',0,0,16,2,7);
INSERT INTO DauSach VALUES(N'Digital Communication Systems: First Edition: A Modern Introduction', N'Digital communications is an elective course often taken as the second semester of an analog/digital sequence or as a follow-on course to communication systems. ',530000,'01-01-2013','/uploads/dauSach/21.png',0,1,17,2,10);
INSERT INTO DauSach VALUES(N'Internet of Things: Principles and Paradigms', N'Internet of Things: Principles and Paradigms captures the state-of-the-art research in Internet of Things, its applications, architectures, and technologies.',1530000,'11-05-2016','/uploads/dauSach/22.png',1,0,18,2,10);
INSERT INTO DauSach VALUES(N'Thực Hành Kỹ Thuật Cơ Điện Lạnh', N'Nội dung chủ yếu của sách trình bày các vấn đề cơ bản về hệ thống lạnh và điều hòa không khí, các phương pháp bảo trì, sửa chữa, lắp đặt hệ thống lạnh, từ tủ lạnh gia dụng, tủ lạnh và cấp đông dùng trong siêu thị, nhà hà cho đến các hệ thống điều hòa không khí dùng trong các tòa nhà lớn, trên các phương tiện giao thông vận tả',115000,'10-05-2011','/uploads/dauSach/23.png',1,1,1,1,11);
INSERT INTO DauSach VALUES(N'Thông gió và kỹ thuật xử lý khí thải', N'Cuốn sách Thông Gió Và Kỹ Thuật Xử Lý Khí Thải bao gồm 14 chương, trình bày những vấn đề cơ bản về tính toán nhiệt, ẩm, lượng độc hại tỏa ra trong nhà, trên cơ sở đó xác định lưu lượng khí cần thiết để khử nhiệt thừa, hơi nước và khí độc tỏa ra trong công trình.',60000,'11-19-2008','/uploads/dauSach/24.png',1,1,19,1,11);
INSERT INTO DauSach VALUES(N'Thiết kế hệ thống điều hòa không khí VRV', N'Để đáp ứng các nhu cầu của hệ thống điều hoà không khí VRV, nhóm tác giả biên soạn cuốn Thiết kế hệ thống điều hành không khí VRV.',25000,'06-03-2001','/uploads/dauSach/25.png',1,1,2,1,11);
INSERT INTO DauSach VALUES(N'Bảy Bước Tới Mùa Hè: Truyện dài', N'Câu chuyện về một mùa hè ngọt ngào, những trò chơi nghịch ngợm và bâng khuâng tình cảm tuổi mới lớn.',76000,'01-06-2022','/uploads/dauSach/26.png',1,1,20,1,12);
INSERT INTO DauSach VALUES(N'Tiệm Cắt Tóc Lúc Nửa Đêm', N'Tất cả những bí ẩn và sự thật đằng sau nó sẽ được hé lộ trong TIỆM CẮT TÓC LÚC NỬA ĐÊM, Một cuốn sách được độc giả Nhật Bản nhận xét là KHÔNG THỂ ĐOÁN TRƯỚC ĐƯỢC CÁI KẾT!',116000,'06-06-2022','/uploads/dauSach/27.png',1,1,21,1,12);
INSERT INTO DauSach VALUES(N'Cẩm Nang Cấu Trúc Tiếng Anh', N'Cuốn sách CẨM NANG CẤU TRÚC TIẾNG ANH gồm 25 phần, mỗi phần là một phạm trù kiến thức trong tiếng Anh được trình bày một cách ngắn gọn, đơn giản, cô đọng và hệ thống hoá dưới dạng sơ đồ, bảng biểu nhằm phát triển khả năng tư duy của người học và từ đó giúp người học nhớ kiến thức nhanh hơn và sâu hơn.',73000,'05-07-2018','/uploads/dauSach/28.png',1,1,14,6,13);
INSERT INTO DauSach VALUES(N'25 Chuyên Đề Ngữ Pháp Tiếng Anh Trọng Tâm (Tập 1)', N'Các chuyên đề ngữ pháp trọng tâm được trình bày đơn giản, dễ hiểu cùng với hệ thống bài tập và từ vựng phong phú. Có tất cả 25 chuyên đề trong 2 tập sách, là tài liệu hữu ích cho học sinh, sinh viên, người đi làm, luyện thi cho các kỳ thi quốc gia, ôn luyện các chứng chỉ quốc tế và là tài liệu tham khảo cho giáo viên.',68000,'01-08-2018','/uploads/dauSach/29.png',1,1,14,6,13);
INSERT INTO DauSach VALUES(N'Giáo trình Hán Ngữ MSUTONG sơ cấp', N'Sách học tiếng Trung là tài liệu quan trọng và cần chuẩn bị đầu tiên dù bạn quyết định tự học tiếng Trung tại nhà hay đến trung tâm. Việc xác định được loại sách học tiếng Trung cho người mới bắt đầu sẽ giúp bạn dễ dàng bắt đầu hành trình học ngôn ngữ.',170000,'01-05-2020','/uploads/dauSach/30.png',1,1,22,3,13);
INSERT INTO DauSach VALUES(N'Ngữ Pháp Tiếng Hàn Thông Dụng - Sơ Cấp', N'Đây là quyển đầu tiên trong bộ “Ngữ pháp tiếng Hàn thông dụng, Korean Grammar in use”',140000,'01-06-2020','/uploads/dauSach/31.png',1,1,23,5,12);
INSERT INTO DauSach VALUES(N'Tự Học Tiếng Nhật Cho Người Mới Bắt Đầu', N'Cuốn sách được xây dựng dành cho người chưa biết gì về tiếng Nhật có thể tiếp cận với ngoại ngữ này một cách dễ dàng và thú vị.',65000,'09-17-2018','/uploads/dauSach/32.png',0,1,23,4,12);
INSERT INTO DauSach VALUES(N'Lịch Sử Do Thái', N'Lịch sử Do Thái của Paul Johnson bắt đầu bằng những sự kiện được viết trong Kinh Thánh và kết thúc khi thành lập Nhà nước Israel. ',275000,'02-02-2020','/uploads/dauSach/33.png',1,1,24,1,14);
INSERT INTO DauSach VALUES(N'Atlat Địa Lí Việt Nam', N'Atlat Địa Lí Việt Nam - 2022',25000,'05-04-2022','/uploads/dauSach/34.png',0,1,19,1,14);

INSERT INTO HoSo VALUES(N'Khai', N'Nguyen',N'241 Nguyễn Trãi, Lái Thiêu, Thuận An, Bình Dương','0783511740','','20110655@student.hcmute.edu.vn',1,'06-06-2002',null);
INSERT INTO HoSo VALUES(N'Tuấn Kiệt', N'Lê Nguyễn',N'241 Đông Ba, Đống Đa, Hà Tĩnh','0783511234','','20110234@student.hcmute.edu.vn',1,'09-17-2002',2000000);
INSERT INTO HoSo VALUES(N'Hà', N'Vĩ Khang',N'N2 Quang Trung, Đông Nhì, Vĩnh Lộc, Đà Lạt','0767111345','','20110211@student.hcmute.edu.vn',1,'12-17-2002',2000000);
INSERT INTO HoSo VALUES(N'Nguyễn', N'Đức Thịnh',N'21 Trưng Vương, Bửu Lộc, Tăng Nhơn Phú A, TPHCM','0767223451','','201102221@student.hcmute.edu.vn',1,'12-17-2002',2000000);
INSERT INTO HoSo VALUES(N'Phúc', N'Nguyễn',N'95 Nguyễn Văn Trỗi, Hà Đông, Hà Tây, Hà Nội','0783512345','','20123298@student.hcmute.edu.vn',1,'07-09-2002',2000000);
INSERT INTO HoSo VALUES(N'Đức', N'Lê Hồng',N'252 Nguyễn Huệ, Bà Chiểu, Hà Linh, Nghệ An','0892651234','','20162974@student.hcmute.edu.vn',1,'09-17-2002',2000000);
INSERT INTO HoSo VALUES(N'Hà', N'Vĩ Khang',N'221 Nguyễn Đăng Quang, Hiệp Phú, Bình Hòa, Đồng Nai','0768454155','','20162326@student.hcmute.edu.vn',1,'12-17-2002',2000000);
INSERT INTO HoSo VALUES(N'Nguyễn', N'Đức Thịnh',N'123 Y Vân, Đồ Chiểu, Nhơn Hòa, Quy Nhơn','0786455451','','20132635@student.hcmute.edu.vn',1,'12-17-2002',2000000);


INSERT INTO NhanVien VALUES(N'khainguyen',pwdencrypt('12345678'),1,1);
GO
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'khainguyen')
BEGIN
	CREATE LOGIN khainguyen WITH PASSWORD = '12345678'
	CREATE USER khainguyen for LOGIN khainguyen
	GRANT EXEC, SELECT, INSERT, UPDATE, DELETE TO khainguyen
	EXEC master..sp_addsrvrolemember @loginame = khainguyen, @rolename = N'sysadmin'
END

INSERT INTO NhanVien VALUES(N'kietnguyen',pwdencrypt('12345678'),1,2);
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'kietnguyen')
BEGIN
	CREATE LOGIN kietnguyen WITH PASSWORD = '12345678'
	CREATE USER kietnguyen for LOGIN kietnguyen
	EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = kietnguyen
END

INSERT INTO NhanVien VALUES(N'vikhang',pwdencrypt('12345678'),1,3);
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'vikhang')
BEGIN
	CREATE LOGIN vikhang WITH PASSWORD = '12345678'
	CREATE USER vikhang for LOGIN vikhang
	EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = vikhang
END

INSERT INTO NhanVien VALUES(N'thinhNguyen',pwdencrypt('12345678'),1,4);
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'thinhNguyen')
BEGIN
	CREATE LOGIN thinhNguyen WITH PASSWORD = '12345678'
	CREATE USER thinhNguyen for LOGIN thinhNguyen
	EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = thinhNguyen
END

INSERT INTO NhanVien VALUES(N'phucnguyen',pwdencrypt('12348756'),1,5);
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'phucnguyen')
BEGIN
	CREATE LOGIN phucnguyen WITH PASSWORD = '12345678'
	CREATE USER phucnguyen for LOGIN phucnguyen
	EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = phucnguyen

END

INSERT INTO NhanVien VALUES(N'hongducle',pwdencrypt('12342327'),1,6);
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'hongducle')
BEGIN
	CREATE LOGIN hongducle WITH PASSWORD = '12345678'
	CREATE USER hongducle for LOGIN hongducle
	EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = hongducle
END

INSERT INTO NhanVien VALUES(N'baochiluu',pwdencrypt('12343235'),1,7);
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'baochiluu')
BEGIN
	CREATE LOGIN baochiluu WITH PASSWORD = '12345678'
	CREATE USER baochiluu for LOGIN baochiluu
	EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = baochiluu
END

INSERT INTO NhanVien VALUES(N'dangnguyenle',pwdencrypt('12349263'),1,8);
IF NOT EXISTS(SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'dangnguyenle')
BEGIN
	CREATE LOGIN dangnguyenle WITH PASSWORD = '12345678'
	CREATE USER dangnguyenle for LOGIN dangnguyenle
	EXEC fn_Gan_Quyen_Nhan_Vien @TENDANGNHAP = dangnguyenle
END


INSERT INTO Muon VALUES('10-14-2021',null,'10-14-2022',20000,2,2);
INSERT INTO Muon VALUES('9-12-2021','9-10-2022','9-12-2022',25000,3,3);
INSERT INTO Muon VALUES('7-23-2021','7-19-2022','7-23-2022',150000,4,4);
INSERT INTO Muon VALUES('11-1-2021',null,'11-1-2022',50000,1,1);
INSERT INTO Muon VALUES('10-14-2021',null,'10-14-2022',22000,2,2);
INSERT INTO Muon VALUES('9-12-2021','9-10-2022','9-12-2022',35000,3,3);
INSERT INTO Muon VALUES('7-23-2021','7-19-2022','7-23-2022',53000,4,4);
INSERT INTO Muon VALUES('7-25-2021','7-29-2022','7-29-2022',25000,5,5);
INSERT INTO Muon VALUES('8-25-2021','7-29-2022','8-29-2022',30000,6,5);
INSERT INTO Muon VALUES('9-25-2021','7-29-2022','9-29-2022',35000,7,6);
INSERT INTO Muon VALUES('10-25-2021','7-29-2022','10-29-2022',40000,8,13);
INSERT INTO Muon VALUES('12-1-2021',null,'11-1-2022',60000,1,1);
INSERT INTO Muon VALUES('10-13-2021',null,'10-14-2022',27000,2,2);
INSERT INTO Muon VALUES('1-12-2021','1-16-2022','9-12-2022',39000,3,7);
INSERT INTO Muon VALUES('2-23-2021','2-28-2022','2-28-2022',33000,4,8);
INSERT INTO Muon VALUES('3-25-2021','3-29-2022','3-29-2022',24000,5,9);
INSERT INTO Muon VALUES('4-25-2021','4-29-2022','4-29-2022',38000,6,10);
INSERT INTO Muon VALUES('5-25-2021','5-29-2022','5-29-2022',31000,7,11);
INSERT INTO Muon VALUES('6-25-2021','6-29-2022','6-29-2022',49000,8,12);


INSERT INTO tacgia_sach VALUES(1,1);
INSERT INTO tacgia_sach VALUES(1,2);
INSERT INTO tacgia_sach VALUES(2,3);
INSERT INTO tacgia_sach VALUES(2,4);
INSERT INTO tacgia_sach VALUES(3,5);
INSERT INTO tacgia_sach VALUES(4,6);
INSERT INTO tacgia_sach VALUES(5,7);
INSERT INTO tacgia_sach VALUES(6,8);
INSERT INTO tacgia_sach VALUES(6,9);
INSERT INTO tacgia_sach VALUES(7,10);
INSERT INTO tacgia_sach VALUES(8,11);
INSERT INTO tacgia_sach VALUES(8,12);
INSERT INTO tacgia_sach VALUES(9,13);
INSERT INTO tacgia_sach VALUES(10,14);
INSERT INTO tacgia_sach VALUES(11,15);
INSERT INTO tacgia_sach VALUES(12,16);
INSERT INTO tacgia_sach VALUES(12,17);
INSERT INTO tacgia_sach VALUES(13,18);
INSERT INTO tacgia_sach VALUES(14,19);
INSERT INTO tacgia_sach VALUES(15,20);
INSERT INTO tacgia_sach VALUES(15,21);
INSERT INTO tacgia_sach VALUES(16,22);
INSERT INTO tacgia_sach VALUES(17,23);
INSERT INTO tacgia_sach VALUES(17,24);
INSERT INTO tacgia_sach VALUES(18,25);
INSERT INTO tacgia_sach VALUES(19,26);
INSERT INTO tacgia_sach VALUES(20,27);
INSERT INTO tacgia_sach VALUES(21,28);
INSERT INTO tacgia_sach VALUES(22,29);
INSERT INTO tacgia_sach VALUES(22,30);
INSERT INTO tacgia_sach VALUES(23,31);
INSERT INTO tacgia_sach VALUES(24,32);
INSERT INTO tacgia_sach VALUES(25,33);
INSERT INTO tacgia_sach VALUES(26,34);
INSERT INTO tacgia_sach VALUES(27,35);
INSERT INTO tacgia_sach VALUES(28,36);
INSERT INTO tacgia_sach VALUES(29,37);
INSERT INTO tacgia_sach VALUES(30,37);
INSERT INTO tacgia_sach VALUES(31,38);
INSERT INTO tacgia_sach VALUES(31,39);
INSERT INTO tacgia_sach VALUES(31,40);
INSERT INTO tacgia_sach VALUES(32,41);
INSERT INTO tacgia_sach VALUES(32,42);
INSERT INTO tacgia_sach VALUES(32,43);
INSERT INTO tacgia_sach VALUES(33,44);
INSERT INTO tacgia_sach VALUES(33,45);
INSERT INTO tacgia_sach VALUES(34,46);


INSERT INTO vaitro_nhanVien VALUES(1,1);
INSERT INTO vaitro_nhanVien VALUES(1,2);
INSERT INTO vaitro_nhanVien VALUES(2,2);
INSERT INTO vaitro_nhanVien VALUES(3,2);
INSERT INTO vaitro_nhanVien VALUES(4,2);
INSERT INTO vaitro_nhanVien VALUES(5,2);
INSERT INTO vaitro_nhanVien VALUES(6,2);
INSERT INTO vaitro_nhanVien VALUES(7,2);
INSERT INTO vaitro_nhanVien VALUES(8,2);

INSERT INTO Sach VALUES(1,'Kệ 1',1);
INSERT INTO Sach VALUES(-1,'Kệ 1',1);
INSERT INTO Sach VALUES(0,'Kệ 1',1);
INSERT INTO Sach VALUES(1,'Kệ 1',1);
INSERT INTO Sach VALUES(1,'Kệ 1',1);
INSERT INTO Sach VALUES(1,'Kệ 2',2);
INSERT INTO Sach VALUES(0,'Kệ 2',2);
INSERT INTO Sach VALUES(-1,'Kệ 2',2);
INSERT INTO Sach VALUES(1,'Kệ 2',2);
INSERT INTO Sach VALUES(1,'Kệ 3',3);
INSERT INTO Sach VALUES(0,'Kệ 3',3);
INSERT INTO Sach VALUES(-1,'Kệ 3',3);
INSERT INTO Sach VALUES(1,'Kệ 3',3);
INSERT INTO Sach VALUES(1,'Kệ 2',4);
INSERT INTO Sach VALUES(0,'Kệ 2',4);
INSERT INTO Sach VALUES(-1,'Kệ 2',4);
INSERT INTO Sach VALUES(1,'Kệ 2',4);
INSERT INTO Sach VALUES(1,'Kệ 4',5);
INSERT INTO Sach VALUES(1,'Kệ 4',5);
INSERT INTO Sach VALUES(1,'Kệ 4',5);
INSERT INTO Sach VALUES(1,'Kệ 4',5);
INSERT INTO Sach VALUES(1,'Kệ 4',5);
INSERT INTO Sach VALUES(1,'Kệ 4',6);
INSERT INTO Sach VALUES(1,'Kệ 4',6);
INSERT INTO Sach VALUES(1,'Kệ 4',6);
INSERT INTO Sach VALUES(1,'Kệ 4',6);
INSERT INTO Sach VALUES(1,'Kệ 4',6);
INSERT INTO Sach VALUES(1,'Kệ 4',6);
INSERT INTO Sach VALUES(1,'Kệ 5',7);
INSERT INTO Sach VALUES(1,'Kệ 5',7);
INSERT INTO Sach VALUES(1,'Kệ 5',7);
INSERT INTO Sach VALUES(1,'Kệ 5',7);
INSERT INTO Sach VALUES(1,'Kệ 5',7);
INSERT INTO Sach VALUES(1,'Kệ 5',7);
INSERT INTO Sach VALUES(1,'Kệ 5',8);
INSERT INTO Sach VALUES(1,'Kệ 5',8);
INSERT INTO Sach VALUES(1,'Kệ 5',8);
INSERT INTO Sach VALUES(1,'Kệ 5',9);
INSERT INTO Sach VALUES(1,'Kệ 5',9);
INSERT INTO Sach VALUES(1,'Kệ 5',9);
INSERT INTO Sach VALUES(1,'Kệ 5',9);
INSERT INTO Sach VALUES(1,'Kệ 5',9);
INSERT INTO Sach VALUES(1,'Kệ 6',10);
INSERT INTO Sach VALUES(1,'Kệ 6',10);
INSERT INTO Sach VALUES(1,'Kệ 6',10);
INSERT INTO Sach VALUES(1,'Kệ 6',10);
INSERT INTO Sach VALUES(1,'Kệ 6',11);
INSERT INTO Sach VALUES(1,'Kệ 6',11);
INSERT INTO Sach VALUES(1,'Kệ 6',11);
INSERT INTO Sach VALUES(1,'Kệ 6',12);
INSERT INTO Sach VALUES(1,'Kệ 6',12);
INSERT INTO Sach VALUES(1,'Kệ 6',12);
INSERT INTO Sach VALUES(1,'Kệ 6',12);
INSERT INTO Sach VALUES(1,'Kệ 6',12);
INSERT INTO Sach VALUES(1,'Kệ 6',13);
INSERT INTO Sach VALUES(1,'Kệ 6',13);
INSERT INTO Sach VALUES(1,'Kệ 6',13);
INSERT INTO Sach VALUES(1,'Kệ 6',13);
INSERT INTO Sach VALUES(1,'Kệ 6',13);
INSERT INTO Sach VALUES(1,'Kệ 6',14);
INSERT INTO Sach VALUES(1,'Kệ 6',14);
INSERT INTO Sach VALUES(1,'Kệ 6',14);
INSERT INTO Sach VALUES(1,'Kệ 7',15);
INSERT INTO Sach VALUES(1,'Kệ 7',15);
INSERT INTO Sach VALUES(1,'Kệ 7',15);
INSERT INTO Sach VALUES(1,'Kệ 7',15);
INSERT INTO Sach VALUES(1,'Kệ 7',18);
INSERT INTO Sach VALUES(1,'Kệ 7',18);
INSERT INTO Sach VALUES(1,'Kệ 7',18);
INSERT INTO Sach VALUES(1,'Kệ 7',18);
INSERT INTO Sach VALUES(1,'Kệ 7',19);
INSERT INTO Sach VALUES(1,'Kệ 7',19);
INSERT INTO Sach VALUES(1,'Kệ 7',19);
INSERT INTO Sach VALUES(1,'Kệ 7',19);
INSERT INTO Sach VALUES(1,'Kệ 7',20);
INSERT INTO Sach VALUES(1,'Kệ 7',20);
INSERT INTO Sach VALUES(1,'Kệ 7',20);
INSERT INTO Sach VALUES(1,'Kệ 7',20);
INSERT INTO Sach VALUES(1,'Kệ 7',21);
INSERT INTO Sach VALUES(1,'Kệ 7',21);
INSERT INTO Sach VALUES(1,'Kệ 7',21);
INSERT INTO Sach VALUES(1,'Kệ 7',22);
INSERT INTO Sach VALUES(1,'Kệ 7',22);
INSERT INTO Sach VALUES(1,'Kệ 7',22);
INSERT INTO Sach VALUES(1,'Kệ 7',22);
INSERT INTO Sach VALUES(1,'Kệ 8',23);
INSERT INTO Sach VALUES(1,'Kệ 8',23);
INSERT INTO Sach VALUES(1,'Kệ 8',23);
INSERT INTO Sach VALUES(1,'Kệ 8',23);
INSERT INTO Sach VALUES(1,'Kệ 8',24);
INSERT INTO Sach VALUES(1,'Kệ 8',24);
INSERT INTO Sach VALUES(1,'Kệ 8',24);
INSERT INTO Sach VALUES(1,'Kệ 8',24);
INSERT INTO Sach VALUES(1,'Kệ 8',25);
INSERT INTO Sach VALUES(1,'Kệ 8',25);
INSERT INTO Sach VALUES(1,'Kệ 8',25);
INSERT INTO Sach VALUES(1,'Kệ 8',26);
INSERT INTO Sach VALUES(1,'Kệ 8',26);
INSERT INTO Sach VALUES(1,'Kệ 8',26);
INSERT INTO Sach VALUES(1,'Kệ 8',27);
INSERT INTO Sach VALUES(1,'Kệ 8',27);
INSERT INTO Sach VALUES(1,'Kệ 8',27);
INSERT INTO Sach VALUES(1,'Kệ 8',27);
INSERT INTO Sach VALUES(1,'Kệ 9',28);
INSERT INTO Sach VALUES(1,'Kệ 9',28);
INSERT INTO Sach VALUES(1,'Kệ 9',28);
INSERT INTO Sach VALUES(1,'Kệ 9',29);
INSERT INTO Sach VALUES(1,'Kệ 9',29);
INSERT INTO Sach VALUES(1,'Kệ 9',29);
INSERT INTO Sach VALUES(1,'Kệ 9',30);
INSERT INTO Sach VALUES(1,'Kệ 9',30);
INSERT INTO Sach VALUES(1,'Kệ 9',30);
INSERT INTO Sach VALUES(1,'Kệ 9',31);
INSERT INTO Sach VALUES(1,'Kệ 9',31);
INSERT INTO Sach VALUES(1,'Kệ 9',31);
INSERT INTO Sach VALUES(1,'Kệ 9',31);
INSERT INTO Sach VALUES(1,'Kệ 10',32);
INSERT INTO Sach VALUES(1,'Kệ 10',32);
INSERT INTO Sach VALUES(1,'Kệ 10',32);
INSERT INTO Sach VALUES(1,'Kệ 10',32);
INSERT INTO Sach VALUES(1,'Kệ 10',33);
INSERT INTO Sach VALUES(1,'Kệ 10',33);
INSERT INTO Sach VALUES(1,'Kệ 10',33);
INSERT INTO Sach VALUES(1,'Kệ 10',33);
INSERT INTO Sach VALUES(1,'Kệ 10',33);
INSERT INTO Sach VALUES(1,'Kệ 10',34);
INSERT INTO Sach VALUES(1,'Kệ 10',34);
INSERT INTO Sach VALUES(1,'Kệ 10',34);
INSERT INTO Sach VALUES(1,'Kệ 10',34);
INSERT INTO Sach VALUES(1,'Kệ 10',34);
INSERT INTO Sach VALUES(1,'Kệ 10',34);


INSERT INTO MuonSach VALUES(1,1,'Sách bình thường', 1);
INSERT INTO MuonSach VALUES(2,2,'Sách quăng góc', 1);
INSERT INTO MuonSach VALUES(3,3,'Sách rách bìa', 0);
INSERT INTO MuonSach VALUES(4,4,'Sách bình thường', 1);
INSERT INTO MuonSach VALUES(5,5,'Sách quăng góc', 1);
INSERT INTO MuonSach VALUES(32,6,'Sách rách bìa', 0);
INSERT INTO MuonSach VALUES(31,7,'Sách bình thường', 1);
INSERT INTO MuonSach VALUES(30,8,'Sách bình thường', 0);
INSERT INTO MuonSach VALUES(20,9,'Sách bình thường', 1);
INSERT INTO MuonSach VALUES(22,10,'Sách quăng góc', 0);
INSERT INTO MuonSach VALUES(21,11,'Sách bình thường', 1);
INSERT INTO MuonSach VALUES(23,12,'Sách rách bìa', 1);
INSERT INTO MuonSach VALUES(15,13,'Sách bình thường', 1);
INSERT INTO MuonSach VALUES(16,14,'Sách bình thường', 0);
INSERT INTO MuonSach VALUES(17,15,'Sách bình thường', 0);
INSERT INTO MuonSach VALUES(9,16,'Sách quăng góc', 0);
INSERT INTO MuonSach VALUES(10,17,'Sách bình thường', 1);
INSERT INTO MuonSach VALUES(14,18,'Sách rách bìa', 0);
INSERT INTO MuonSach VALUES(13,19,'Sách bình thường', 1);



