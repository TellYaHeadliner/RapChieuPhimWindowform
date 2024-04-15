CREATE DATABASE CINEMA_2;
USE CINEMA_2
-- CREATE DATABASE
CREATE TABLE DICHVU(
	maDichVu char (5) NOT NULL PRIMARY KEY,
	tenDichVu nvarchar (100) NULL,
	giaDichVu float NULL,
) 

CREATE TABLE DICHVUTHEOHOADON(
	maHoaDon char (10) NOT NULL,
	maDichVu char (5) NOT NULL,
	PRIMARY KEY(maHoaDon, maDichVu)
)

CREATE TABLE GIAMGIA(
	maGiamGia char (15) NOT NULL PRIMARY KEY,
	phanTramGiamGia float NULL,
	hanSuDung datetime NULL,
	trangThai BIT CHECK (trangThai IN(0,1))
)

CREATE TABLE GIAODICH(
	maGiaoDich char (10) NOT NULL PRIMARY KEY,
	maHoaDon char (10) NOT NULL,
	soTKNganHang char (10) NOT NULL,
)

CREATE TABLE HOADON(
	maHoaDon char (10) NOT NULL PRIMARY KEY,
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
	matKhau char (16) NOT NULL,
	tenNguoiDung nvarchar (30) NOT NULL,
	vaiTro INT CHECK (vaiTro IN(1,2,3)), -- 1 là admin, 2 là nhân viên, 3 là admin
	trangThai bit NOT NULL CHECK (trangThai IN (0,1)), --  Trạng thái xóa
	thongBao bit NOT NULL CHECK (thongBao IN (0,1)) --  Trạng thái thông báo
)

CREATE TABLE NHANVIEN(
	maNhanVien char (10) PRIMARY KEY NOT NULL,
	trangThai bit CHECK (trangThai IN (0,1)),
	kiemDuyet int CHECK (kiemDuyet IN (0,1,2)) -- 0 là khóa, 1 là kiểm duyệt, 2 không cần kiểm duyệt
)

CREATE TABLE TINTUC(
	id int PRIMARY KEY,
	tieuDe nvarchar (100),
	noiDung nvarchar (1000),
	ngayTao datetime default getdate(),
	soDienThoai char (10),
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
	maVe char (10) NOT NULL PRIMARY KEY,
	maGhe char (3) NOT NULL,
	maXuatChieu char (6) NOT NULL,
	maHoaDon char (10) NOT NULL,
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

ALTER TABLE TINTUC ADD FOREIGN KEY (soDienThoai) REFERENCES TAIKHOAN(soDienThoai)

-- Insert admin account
INSERT INTO TAIKHOAN VALUES ('0886627561','kietkiet',N'admin',1,1,0)

CREATE PROC getUserName @SDT char(10)
as
begin
	select tenNguoiDung from TAIKHOAN where soDienThoai = @SDT
end
EXEC dbo.getUserName '0886627561'

CREATE PROC insertTHONGBAO @thongTin nvarchar(2000)
as
begin
	insert into THONGBAO (thongTin) values (@thongTin)
	update TAIKHOAN set thongBao = 1
end
EXEC dbo.insertTHONGBAO N'Thông báo: "Chúng tôi đã cập nhật chính sách đặt vé để cải thiện trải nghiệm của bạn. Bây giờ bạn có thể đặt vé dễ dàng hơn và nhận được các ưu đãi đặc biệt khi mua vé trực tuyến!"'
select * from THONGBAO
select * from TINTUC
insert into TINTUC (id,tieuDe,noiDung,soDienThoai,luotXem,daDuyet,trangThai) values 
				   (0,N'Tổng Bí thư Nguyễn Phú Trọng chúc mừng năm mới Lào và Campuchia',N'Trong thư chúc mừng gửi Tổng Bí thư, Chủ tịch nước Lào Thongloun Sisoulith, có đoạn viết: "Nhân dịp tết cổ truyền của Lào (Bunpimay), thay mặt Đảng, Nhà nước, nhân dân Việt Nam, tôi thân ái gửi tới đồng chí và các đồng chí lãnh đạo Đảng, Nhà nước và nhân dân Lào những tình cảm đồng chí, anh em thân thiết và những lời chúc mừng tốt đẹp nhất.','0886627561',0,1,1),
				   (1,N'TP.HCM làm gì để ngăn nhân viên y tế nghỉ việc?',N'TS-BS Phan Thu Hằng, Phó giám đốc Bệnh viện Hùng Vương cho biết sau khi đại dịch Covid-19 đi qua, bệnh viện đã thực hiện khảo sát mức độ trầm cảm, lo âu, stress với 1.300 nhân viên y tế. Trong đó, có 42,2% nhân viên gặp vấn đề về lo âu, 24,3% nhân viên trầm cảm và có 16,5% nhân viên gặp stress.','0886627561',0,1,1),
				   (2,N'Bình Phước: Hơn 100 cảnh sát truy bắt nghi phạm liên quan vụ án ma túy',N'Lực lượng chức năng đã bắt giữ một nghi phạm và thu giữ các vật chứng có liên quan để điều tra. Riêng Lê Minh Công là người có liên quan đến vụ việc, lợi dụng khu vực hiện trường có địa hình cây cối rậm rạp đã lẩn trốn.','0886627561',0,1,1),
				   (3,N'Diễn viên phim "Tiếng sét trong mưa" đột ngột qua đời',N'Trao đổi với Thanh Niên, đạo diễn Ngụy Minh Khang cho biết sáng 5.4, anh có buổi hẹn gặp mặt diễn viên Lê Hữu Thủy để chuẩn bị cho dự án mới. Tuy nhiên, khi mọi người có mặt đông đủ thì nam diễn viên vẫn chưa xuất hiện. "Tôi tưởng anh Thủy ngủ quên nên gọi điện liên tục nhưng không nghe máy. Lát sau thì cháu của anh Lê Hữu Thủy chạy đến báo tin là anh Thủy đã qua đời. Tôi nghe mà bàng hoàng, không tin đây là sự thật bởi trước giờ anh Thủy rất khỏe. Tôi gọi trực tiếp cho con gái anh Hữu Thủy thì xác nhận ba mất lúc sáng. Vì con gái anh Thủy khóc nhiều nên tôi cũng không dám hỏi thêm. Giờ gia đình vẫn đang chuẩn bị tang lễ, ê kíp chúng tôi cũng đang ngồi đợi đến 15 giờ rồi sang nhà", Ngụy Minh Khang chia sẻ.','0886627561',0,1,1)

select ngayDang,thongTin from THONGBAO
insert into THONGBAO (thongTin) values
					 (N'Thông báo về các suất chiếu mới: "Chúng tôi vừa thêm các suất chiếu mới vào hệ thống. Hãy kiểm tra và cập nhật lịch trình của bạn!"'),
					 (N'Thông báo về các ưu đãi và khuyến mãi: "Chào mừng mùa hè! Chúng tôi có các ưu đãi đặc biệt cho các bộ phim nổi tiếng trong mùa này. Đừng bỏ lỡ cơ hội!"'),
					 (N'Thông báo về sự kiện đặc biệt: "Chúng tôi sắp tổ chức một buổi chiếu đặc biệt cho bộ phim bom tấn sắp ra mắt. Đăng ký ngay để nhận vé miễn phí!"'),
					 (N'Thông báo về cập nhật về dịch vụ: "Hệ thống đặt vé của chúng tôi vừa được cập nhật! Bạn có thể trải nghiệm giao diện mới và các tính năng tiện ích hơn."'),
					 (N'Thông báo về các sự cố kỹ thuật: "Xin lỗi về sự cố kỹ thuật gần đây. Chúng tôi đang làm việc chăm chỉ để khắc phục và đảm bảo rằng mọi thứ đều hoạt động suôn sẻ."'),
					 (N'Thông báo về sự kiện đặc biệt: "Chúng tôi sắp tổ chức một sự kiện đặc biệt dành cho các fan hâm mộ của series phim nổi tiếng. Đừng bỏ lỡ cơ hội gặp gỡ các diễn viên và nhận những phần quà độc đáo!"')

select * from TAIKHOAN
update TINTUC set anhTieuDe = 'ThuTuong.png', anhNoiDung = 'ThuTuong.png' where id = 0
update TAIKHOAN set thongBao = 0 where soDienThoai = '0886627561'
update TAIKHOAN set thongBao = 1 where soDienThoai = '0886627561'
