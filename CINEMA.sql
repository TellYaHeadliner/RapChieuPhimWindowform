use master

CREATE DATABASE CINEMA_2;
USE CINEMA_2
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
	trangThai BIT CHECK (trangThai IN (0,1)),
	luotXem int default 0
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
	cauTraLoiBaoMat nvarchar (128) NOT NULL,
	thongBao bit NOT NULL CHECK (thongBao IN(0,1)),
)

CREATE TABLE NHANVIEN(
	maNhanVien char (10) PRIMARY KEY NOT NULL,
	kiemDuyet bit not null CHECK (kiemDuyet IN (0,1)) -- 0 là can xac nhan, 1 là khong can duyet.
)

CREATE TABLE TINTUC(
	id int IDENTITY PRIMARY KEY,
	tieuDe nvarchar (500),
	noiDung nvarchar (4000),
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
--BaoLam-------------------------------------------
begin
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

end;
GO
begin
--TuanKiet-----------------------------------------
--Thêm tài khoản
INSERT INTO TAIKHOAN VALUES ('0886627561','kietkiet',N'admin',1,1,N'Bao nhieu tuổi',N'20',1)
--Thêm tin tức
insert into TINTUC (anhTieuDe,tieuDe,noiDung,maNhanVien,luotXem,daDuyet,trangThai) values 
				   (N'ThuTuong.png',N'Tổng Bí thư Nguyễn Phú Trọng chúc mừng năm mới Lào và Campuchia',N'Trong thư chúc mừng gửi Tổng Bí thư, Chủ tịch nước Lào Thongloun Sisoulith, có đoạn viết: "Nhân dịp tết cổ truyền của Lào (Bunpimay), thay mặt Đảng, Nhà nước, nhân dân Việt Nam, tôi thân ái gửi tới đồng chí và các đồng chí lãnh đạo Đảng, Nhà nước và nhân dân Lào những tình cảm đồng chí, anh em thân thiết và những lời chúc mừng tốt đẹp nhất.','0886627561',0,1,1),
				   (N'ThuTuong.png',N'TP.HCM làm gì để ngăn nhân viên y tế nghỉ việc?',N'TS-BS Phan Thu Hằng, Phó giám đốc Bệnh viện Hùng Vương cho biết sau khi đại dịch Covid-19 đi qua, bệnh viện đã thực hiện khảo sát mức độ trầm cảm, lo âu, stress với 1.300 nhân viên y tế. Trong đó, có 42,2% nhân viên gặp vấn đề về lo âu, 24,3% nhân viên trầm cảm và có 16,5% nhân viên gặp stress.','0886627561',0,1,1),
				   (N'ThuTuong.png',N'Bình Phước: Hơn 100 cảnh sát truy bắt nghi phạm liên quan vụ án ma túy',N'Lực lượng chức năng đã bắt giữ một nghi phạm và thu giữ các vật chứng có liên quan để điều tra. Riêng Lê Minh Công là người có liên quan đến vụ việc, lợi dụng khu vực hiện trường có địa hình cây cối rậm rạp đã lẩn trốn.','0886627561',0,1,1),
				   (N'ThuTuong.png',N'Diễn viên phim "Tiếng sét trong mưa" đột ngột qua đời',N'Trao đổi với Thanh Niên, đạo diễn Ngụy Minh Khang cho biết sáng 5.4, anh có buổi hẹn gặp mặt diễn viên Lê Hữu Thủy để chuẩn bị cho dự án mới. Tuy nhiên, khi mọi người có mặt đông đủ thì nam diễn viên vẫn chưa xuất hiện. "Tôi tưởng anh Thủy ngủ quên nên gọi điện liên tục nhưng không nghe máy. Lát sau thì cháu của anh Lê Hữu Thủy chạy đến báo tin là anh Thủy đã qua đời. Tôi nghe mà bàng hoàng, không tin đây là sự thật bởi trước giờ anh Thủy rất khỏe. Tôi gọi trực tiếp cho con gái anh Hữu Thủy thì xác nhận ba mất lúc sáng. Vì con gái anh Thủy khóc nhiều nên tôi cũng không dám hỏi thêm. Giờ gia đình vẫn đang chuẩn bị tang lễ, ê kíp chúng tôi cũng đang ngồi đợi đến 15 giờ rồi sang nhà", Ngụy Minh Khang chia sẻ.','0886627561',0,1,1)
--Insert và Update thông báo
insert into THONGBAO (thongTin) values
					 (N'Thông báo về các suất chiếu mới: "Chúng tôi vừa thêm các suất chiếu mới vào hệ thống. Hãy kiểm tra và cập nhật lịch trình của bạn!"'),
					 (N'Thông báo về các ưu đãi và khuyến mãi: "Chào mừng mùa hè! Chúng tôi có các ưu đãi đặc biệt cho các bộ phim nổi tiếng trong mùa này. Đừng bỏ lỡ cơ hội!"'),
					 (N'Thông báo về sự kiện đặc biệt: "Chúng tôi sắp tổ chức một buổi chiếu đặc biệt cho bộ phim bom tấn sắp ra mắt. Đăng ký ngay để nhận vé miễn phí!"'),
					 (N'Thông báo về cập nhật về dịch vụ: "Hệ thống đặt vé của chúng tôi vừa được cập nhật! Bạn có thể trải nghiệm giao diện mới và các tính năng tiện ích hơn."'),
					 (N'Thông báo về các sự cố kỹ thuật: "Xin lỗi về sự cố kỹ thuật gần đây. Chúng tôi đang làm việc chăm chỉ để khắc phục và đảm bảo rằng mọi thứ đều hoạt động suôn sẻ."'),
					 (N'Thông báo về sự kiện đặc biệt: "Chúng tôi sắp tổ chức một sự kiện đặc biệt dành cho các fan hâm mộ của series phim nổi tiếng. Đừng bỏ lỡ cơ hội gặp gỡ các diễn viên và nhận những phần quà độc đáo!"')
UPDATE TAIKHOAN SET thongBao = 1
end;
select * from TAIKHOAN
--vy
begin
use CINEMA_2
insert into TAIKHOAN values (N'0328761417', N'zyy123', N'zyy',2, 1, '','',1)

insert into NHANVIEN values (N'0328761417', 1)

select * from TINTUC
end;