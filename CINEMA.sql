CREATE DATABASE CINEMA_2;

-- CREATE DATABASE
CREATE TABLE DICHVU(
	maDichVu char (5) NOT NULL PRIMARY KEY,
	tenDichVu nvarchar (100) NULL,
	giaDichVu float NULL,
) 

CREATE TABLE DICHVUTHEOHOADON(
	maHoaDon int NOT NULL IDENTITY(1,1),
	maDichVu char (5) NOT NULL,
	soLuong int default 0
	PRIMARY KEY(maHoaDon, maDichVu)
)

CREATE TABLE GIAMGIA(
	maGiamGia char (15) NOT NULL PRIMARY KEY,
	phanTramGiamGia float NULL,
	hanSuDung datetime NULL,
	trangThai BIT CHECK (trangThai IN(0,1))
)

CREATE TABLE GIAODICH(
    maGiaoDich int NOT NULL identity(1,1) PRIMARY KEY,
    maHoaDon int NOT NULL,
    soTKNganHang char (10) NOT NULL
);

CREATE TABLE HOADON(
	maHoaDon int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	tongGiaHoaDon float NOT NULL,
	ghiChu nvarchar (100) NULL,
	soDienThoai char (10) NOT NULL,
	maGiamGia char (15) NULL,
	trangThai BIT CHECK (trangThai IN (0,1))
)

CREATE TABLE PHIM(
	maPhim char (7) NOT NULL PRIMARY KEY,
	tenPhim nvarchar (50) NOT NULL,
	ngayPhatHanh date NOT NULL,
	moTa nvarchar (1000) NULL,
	anhBia char (100),
	maTheLoai char (3) NOT NULL,
	trangThai BIT CHECK (trangThai IN (0,1))
)

CREATE TABLE PHONGCHIEU(
	maPhong char (6) NOT NULL PRIMARY KEY,
	maRap char (5) NOT NULL
)

CREATE TABLE RAPPHIM(
	maRap char (5) NOT NULL PRIMARY KEY,
	diaChi nvarchar (100) NOT NULL,
	trangThai NVARCHAR (4) CHECK (trangThai IN(N'Đóng','Mở')),
	gioMoCua datetime NULL,
	gioDongCua datetime NULL
)

CREATE TABLE TAIKHOAN(
	soDienThoai char (10) PRIMARY KEY NOT NULL,
	matKhau char (128) NOT NULL,
	tenNguoiDung nvarchar (30) NOT NULL,
	vaiTro INT CHECK (vaiTro IN(1,2,3)), -- 1 là admin, 2 là nhân viên, 3 là admin
	trangThai bit NOT NULL CHECK (trangThai IN (0,1)), --  Trạng thái xóa
	cauHoiBaoMat nvarchar (100) NOT NULL,
	cauTraLoiBaoMat nvarchar (128) NOT NULL
	thongBao bit NOT NULL CHECK (thongBao IN(0,1)),
)

CREATE TABLE NHANVIEN(
	maNhanVien char (10) PRIMARY KEY NOT NULL,
	kiemDuyet int CHECK (kiemDuyet IN (0,1,2)) -- 0 là khóa, 1 là kiểm duyệt, 2 không cần kiểm duyệt
)

CREATE TABLE TINTUC(
	id int PRIMARY KEY,
	tieuDe nvarchar (100),
	noiDung nvarchar (1000),
	ngayTao datetime default getdate(),
	maNhanVien char (10),
	anhTieuDe char (100),
	anhNoiDung char (100),
	luotXem int default 0,
	daDuyet bit check (daDuyet IN(0,1)), -- 0 là chưa duyệt, 1 là đã duyệt
	trangThai bit check (trangThai IN(0,1)) -- Trạng thái bài viết đã xóa chưa
)

CREATE TABLE THELOAIPHIM(
	maTheLoai char (3) NOT NULL PRIMARY KEY,
	theLoaiPhim  nvarchar (10) NOT NULL,
)

CREATE TABLE VE(
	maVe int identity(1,1) NOT NULL PRIMARY KEY,
	maGhe char (3) NOT NULL,
	maXuatChieu char (6) NOT NULL,
	maHoaDon int,
)

CREATE TABLE VITRIGHE(
	maGhe char (3) NOT NULL PRIMARY KEY,
	maPhong char (6) NOT NULL
)

CREATE TABLE XUATCHIEU(
	maXuatChieu char (6) NOT NULL PRIMARY KEY,
	maPhim char (7) NOT NULL,
	maPhong char (6) NOT NULL,
	ngayChieu date NULL,
	gioChieu time NULL,
	giaXuatChieu float NULL,
)

CREATE TABLE THONGBAO(
	id int IDENTITY(1,1) PRIMARY KEY,
	thongTin nvarchar(2000) NOT NULL,
	ngayDang datetime default getdate()
)

--FOREIGN KEY 
ALTER TABLE PHIM ADD FOREIGN KEY(maTheLoai) REFERENCES THELOAIPHIM(maTheLoai)

ALTER TABLE XUATCHIEU ADD FOREIGN KEY (maPhim) REFERENCES PHIM(maPhim)

ALTER TABLE XUATCHIEU ADD FOREIGN KEY (maPHONG) REFERENCES PHONGCHIEU(maPhong)

ALTER TABLE PHONGCHIEU ADD FOREIGN KEY (maRap) REFERENCES RAPPHIM(maRap)

ALTER TABLE VITRIGHE ADD FOREIGN KEY (maPhong) REFERENCES PHONGCHIEU(maPhong)

ALTER TABLE VE ADD FOREIGN KEY (maGhe) REFERENCES VITRIGHE(maGhe)

ALTER TABLE VE ADD FOREIGN KEY (maXuatChieu) REFERENCES XUATCHIEU(maXuatChieu)

ALTER TABLE VE ADD FOREIGN KEY (maHoaDon) REFERENCES HOADON (maHoaDon)

ALTER TABLE GIAODICH ADD FOREIGN KEY (maHoaDon) REFERENCES HOADON(maHoaDon)

ALTER TABLE HOADON ADD FOREIGN KEY (soDienThoai) REFERENCES TAIKHOAN(soDienThoai)

ALTER TABLE HOADON ADD FOREIGN KEY (maGiamGia) REFERENCES GIAMGIA(maGiamGia)

ALTER TABLE DICHVUTHEOHOADON ADD FOREIGN KEY (maDichVu) REFERENCES DICHVU(maDichVu)

ALTER TABLE DICHVUTHEOHOADON ADD FOREIGN KEY (maHoaDon) REFERENCES HOADON(maHoaDon)

ALTER TABLE NHANVIEN ADD FOREIGN KEY (maNhanVien) REFERENCES TAIKHOAN(soDienThoai)

ALTER TABLE TINTUC ADD FOREIGN KEY (maNhanVien) REFERENCES TAIKHOAN(soDienThoai)

-- Insert admin account
INSERT INTO TAIKHOAN VALUES ('0913661977','Baolamok123@',N'admin',1,1,N'Đội tuyển bạn hâm một nhất ?',N'Machester United')
INSERT INTO TAIKHOAN VALUES ('0913661945','Baolamok123@',N'admin',3,1,N'Đội tuyển bạn hâm một nhất ?',N'Manchester United')
--Store procedure
CREATE PROCEDURE dangNhap
    @SDT CHAR(10), 
    @matKhau CHAR(16),
	@vaiTro INT OUTPUT
AS
BEGIN
    -- Lấy giá trị của vaiTro từ bảng TAIKHOAN
    SELECT @vaiTro = vaiTro
    FROM TAIKHOAN 
    WHERE soDienThoai = @SDT AND matKhau = @matKhau;
END

CREATE PROCEDURE dangKi
	@soDienThoai CHAR (10),
	@matKhau CHAR (16),
	@tenNguoiDung nvarchar (30),
	@cauHoiBaoMat nvarchar (100),
	@cauTraLoiBaoMat nvarchar (50)
AS
	INSERT INTO TAIKHOAN VALUES (@soDienThoai,@matKhau,@tenNguoiDung,3,1,@cauHoiBaoMat,@cauTraLoiBaoMat)

CREATE PROCEDURE checkSDT
	@SDT CHAR (10),
	@result bit output
AS
BEGIN
	IF EXISTS (SELECT 1 FROM TAIKHOAN WHERE soDienThoai = @SDT)
		SET @result = 1;
	ELSE
		SET @result = 0;
END

CREATE PROCEDURE checkCauHoiBaoMat
	@SDT char (10),
	@cauHoiBaoMat nvarchar (100)
AS
BEGIN
	SELECT @cauHoiBaoMat = TAIKHOAN.cauHoiBaoMat FROM TAIKHOAN WHERE soDienThoai = @SDT
END

CREATE PROCEDURE quenMatKhau_getInformation
	@SDT char (10)
AS 
BEGIN
	SELECT cauHoiBaoMat, cauTraLoiBaoMat, soDienThoai
	FROM TAIKHOAN
	WHERE soDienThoai = @SDT
END;
GO

CREATE PROCEDURE updateMatKhau
	@matKhauMoi char (16),
	@SDT CHAR (10)
AS
BEGIN
	UPDATE TAIKHOAN SET matKhau = @matKhauMoi WHERE soDienThoai = @SDT
END;

CREATE PROCEDURE loadProfileAdmin
AS
BEGIN
	SELECT tk.tenNguoiDung, tk.matKhau
	FROM TAIKHOAN tk
END;

