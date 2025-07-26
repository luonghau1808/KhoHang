-- Tạo database
CREATE DATABASE QuanLyKhoHangQuanAo;
GO

USE QuanLyKhoHangQuanAo;
GO

CREATE TABLE ChucVu(
    MaChucVu INT PRIMARY KEY IDENTITY,
    TenChucVu NVARCHAR(50) NOT NULL
);

CREATE TABLE NhanVien (
    Id INT PRIMARY KEY IDENTITY,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    MaChucVu INT,
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);

CREATE TABLE TaiKhoanNhanVien (
    Id INT PRIMARY KEY IDENTITY,
    NhanVienId INT NOT NULL UNIQUE,
    TenDangNhap NVARCHAR(100) NOT NULL UNIQUE,
    MatKhau NVARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Hoạt động',
    FOREIGN KEY (NhanVienId) REFERENCES NhanVien(Id)
);

CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY IDENTITY,
    Ten NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15) NOT NULL,
    DiaChi NVARCHAR(255),
    Email NVARCHAR(100)
);

CREATE TABLE ThuongHieu (
    MaThuongHieu INT PRIMARY KEY IDENTITY,
    TenThuongHieu NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE NhaCungCap (
    MaNCC INT PRIMARY KEY IDENTITY,
    TenNCC NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    Email NVARCHAR(100) NOT NULL UNIQUE,
    SoDienThoai VARCHAR(15) NOT NULL
);

CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY IDENTITY,
    MaNCC INT,
    TenSP NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(MAX),
    MaThuongHieu INT,
    TrangThai BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (MaThuongHieu) REFERENCES ThuongHieu(MaThuongHieu),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

CREATE TABLE MauSac (
    MaMau INT PRIMARY KEY IDENTITY,
    TenMau NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE KichThuoc (
    MaKichThuoc INT PRIMARY KEY IDENTITY,
    TenKichThuoc NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE ChiTietSanPham (
    MaCTSP INT PRIMARY KEY IDENTITY,
    MaSP INT NOT NULL,
    MaMau INT,
    MaKichThuoc INT,
    DonGiaNhap DECIMAL(18,2) NOT NULL CHECK (DonGiaNhap >= 0),
    DonGiaXuat DECIMAL(18,2) NOT NULL CHECK (DonGiaXuat >= 0),
    SoLuong INT NOT NULL CHECK (SoLuong >= 0),
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
    FOREIGN KEY (MaMau) REFERENCES MauSac(MaMau),
    FOREIGN KEY (MaKichThuoc) REFERENCES KichThuoc(MaKichThuoc)
);

CREATE TABLE PhieuNhap (
    MaPhieuNhap INT PRIMARY KEY IDENTITY,

    MaNV INT NOT NULL,
    NgayNhap DATE NOT NULL DEFAULT GETDATE(),
    GhiChu NVARCHAR(255),
    TrangThaiThanhToan BIT NOT NULL DEFAULT 0,
    NgayThanhToan DATE,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(Id)
);

CREATE TABLE ChiTietPhieuNhap (
    MaPhieuCT INT PRIMARY KEY IDENTITY,
    MaPhieuNhap INT NOT NULL,
    MaCTSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18, 2) NOT NULL CHECK (DonGia >= 0),
    FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
    FOREIGN KEY (MaCTSP) REFERENCES ChiTietSanPham(MaCTSP)
);

CREATE TABLE PhieuXuat (
    MaPhieuXuat INT PRIMARY KEY IDENTITY,
    MaKH INT NOT NULL,
    MaNV INT NOT NULL,
    NgayXuat DATE NOT NULL DEFAULT GETDATE(),
    TrangThaiThanhToan BIT NOT NULL DEFAULT 0,
    MoTa NVARCHAR(MAX),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(Id)
);

CREATE TABLE PhieuXuatChiTiet (
    MaCT INT PRIMARY KEY IDENTITY,
    MaPhieuXuat INT NOT NULL,
    MaCTSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    GiaBan DECIMAL(18, 2) NOT NULL CHECK (GiaBan >= 0),
    FOREIGN KEY (MaPhieuXuat) REFERENCES PhieuXuat(MaPhieuXuat),
    FOREIGN KEY (MaCTSP) REFERENCES ChiTietSanPham(MaCTSP)
);


INSERT INTO ChucVu (TenChucVu) VALUES
(N'Quản lý'),
(N'Nhân viên');
INSERT INTO NhanVien (HoTen, SoDienThoai, Email, MaChucVu) VALUES
(N'Nguyễn Thị Mai',     '0912345678', 'mainguyen@gmail.com', 1),
(N'Lê Văn Hùng',        '0934567890', 'hunghlv@gmail.com', 2),
(N'Trần Thị Hương',     '0987654321', 'huongtran@gmail.com', 1),
(N'Phạm Minh Tuấn',     '0909090909', 'tuanpham@gmail.com', 2),
(N'Hồ Thị Lan',         '0922334455', 'lanhothi@gmail.com', 2),
(N'Võ Đức Anh',         '0944112233', 'anhvo.duc@gmail.com', 2),
(N'Đỗ Thị Kim Ngân',    '0977553311', 'kimngandtk@gmail.com', 1),
(N'Bùi Văn Quang',      '0966332211', 'quangbui@gmail.com', 2),
(N'Ngô Thị Thảo',       '0955778899', 'thaongo@gmail.com', 2),
(N'Huỳnh Quốc Khánh',   '0933888899', 'khanhhuynh@gmail.com', 2);

INSERT INTO TaiKhoanNhanVien (NhanVienId, TenDangNhap, MatKhau) VALUES
(1, 'mainguyen', '123456'),
(2, 'hunghlv', '123456'),
(3, 'huongtran', '123456'),
(4, 'tuanpham', '123456'),
(5, 'lanhothi', '123456'),
(6, 'anhvo', '123456'),
(7, 'kimngan', '123456'),
(8, 'quangbui', '123456'),
(9, 'thaongo', '123456'),
(10, 'khanhhuynh', '123456');

INSERT INTO KhachHang (Ten, SDT, DiaChi, Email) VALUES
(N'Nguyễn Thị Thanh', '0905123456', N'123 Lý Thường Kiệt, Hà Nội', 'thanhnguyen@gmail.com'),
(N'Lê Hoàng Long', '0912345678', N'45 Nguyễn Trãi, TP.HCM', 'longle@gmail.com'),
(N'Trần Thị Bích Ngọc', '0988776655', N'88 Hai Bà Trưng, Đà Nẵng', 'bichngoc.tran@gmail.com'),
(N'Phạm Văn Nam', '0934567890', N'12 Trần Hưng Đạo, Cần Thơ', 'nampham@gmail.com'),
(N'Hoàng Minh Châu', '0944332211', N'76 Phạm Văn Đồng, Huế', 'chauhm@gmail.com'),
(N'Vũ Thị Hà', '0977553311', N'22 Điện Biên Phủ, Hà Nội', 'havu@gmail.com'),
(N'Đặng Quốc Bảo', '0966887799', N'18 Nguyễn Văn Cừ, TP.HCM', 'baodq@gmail.com'),
(N'Ngô Thị Kim Yến', '0955998877', N'99 Nguyễn Huệ, Đà Nẵng', 'yenngo.kim@gmail.com'),
(N'Huỳnh Văn Hậu', '0933112233', N'5 Lê Duẩn, Hải Phòng', 'hauhuynh@gmail.com'),
(N'Bùi Thị Thu Trang', '0922446688', N'34 Trần Phú, Nha Trang', 'trangbui@gmail.com');
INSERT INTO ThuongHieu (TenThuongHieu) VALUES
(N'Adidas'),
(N'Nike'),
(N'Puma'),
(N'Zara'),
(N'Uniqlo'),
(N'Gucci'),
(N'Louis Vuitton'),
(N'H&M'),
(N'Lacoste'),
(N'Mango');
INSERT INTO NhaCungCap (TenNCC, DiaChi, Email, SoDienThoai) VALUES
(N'Công ty TNHH Vạn Thành', N'123 Nguyễn Trãi, Hà Nội', 'vanthanh@gmail.com', '0909000011'),
(N'Công ty May Kim Liên', N'45 Lý Tự Trọng, TP.HCM', 'kimlien@gmail.com', '0911000022'),
(N'Cửa hàng Thời Trang ABC', N'88 Trần Hưng Đạo, Đà Nẵng', 'abcfashion@gmail.com', '0922000033'),
(N'Xưởng Sản Xuất Áo Quần Quang Minh', N'12 Trần Phú, Cần Thơ', 'quangminh@gmail.com', '0933000044'),
(N'Nhà cung cấp Zara Việt Nam', N'76 Nguyễn Văn Cừ, Huế', 'zara.vn@gmail.com', '0944000055'),
(N'Xưởng Uniqlo Việt Nam', N'22 Hai Bà Trưng, Hà Nội', 'uniqlo.vn@gmail.com', '0955000066'),
(N'Công ty TNHH Gucci', N'18 Nguyễn Huệ, TP.HCM', 'gucci.vn@gmail.com', '0966000077'),
(N'Nhà phân phối Mango', N'99 Lê Duẩn, Đà Nẵng', 'mango@gmail.com', '0977000088'),
(N'Tổng kho Adidas', N'5 Điện Biên Phủ, Hải Phòng', 'adidas@gmail.com', '0988000099'),
(N'Công ty TNHH Louis Vuitton', N'34 Lê Lợi, Nha Trang', 'lv@gmail.com', '0999000010');


INSERT INTO SanPham (MaNCC, TenSP, MoTa, MaThuongHieu, TrangThai) VALUES
(1, N'Áo thun nam thể thao', N'Chất liệu cotton thấm hút mồ hôi tốt', 1, 1),
(2, N'Quần jean nữ dáng skinny', N'Co giãn tốt, màu xanh đậm', 2, 1),
(3, N'Áo sơ mi công sở nam', N'Form rộng, dễ phối đồ', 3, 1),
(4, N'Váy dài họa tiết hoa', N'Chất vải mát, nhẹ', 4, 1),
(5, N'Áo khoác bomber nữ', N'Dày dặn, giữ ấm tốt', 5, 1),
(6, N'Quần short nam thể thao', N'Phong cách năng động', 6, 1),
(7, N'Váy xòe dáng công chúa', N'Phù hợp dự tiệc, lễ hội', 7, 1),
(8, N'Áo len cổ lọ', N'Phù hợp mùa đông, giữ nhiệt tốt', 8, 1),
(9, N'Áo hoodie oversize', N'Phong cách streetwear', 9, 1),
(10, N'Quần tây nữ công sở', N'Lịch sự, sang trọng', 10, 1);
INSERT INTO MauSac (TenMau) VALUES
(N'Đen'),
(N'Trắng'),
(N'Xám'),
(N'Xanh dương'),
(N'Đỏ'),
(N'Vàng'),
(N'Nâu'),
(N'Hồng'),
(N'Tím'),
(N'Xanh lá');
INSERT INTO KichThuoc (TenKichThuoc) VALUES
(N'S'),
(N'M'),
(N'L'),
(N'XL'),
(N'XXL'),
(N'28'),
(N'30'),
(N'32'),
(N'34'),
(N'36');
INSERT INTO ChiTietSanPham (MaSP, MaMau, MaKichThuoc, DonGiaNhap, DonGiaXuat, SoLuong, GhiChu) VALUES
(11, 1, 1, 80000, 120000, 50, N'Bán chạy'),
(2, 2, 2, 120000, 180000, 40, N'Hàng mới'),
(3, 3, 3, 100000, 150000, 30, N'Ưa chuộng'),
(4, 4, 10, 150000, 220000, 20, N'Hot trend'),
(5, 5, 8, 180000, 250000, 25, N'Limited'),
(6, 6, 6, 70000, 110000, 60, N'Giảm giá'),
(7, 7, 7, 200000, 280000, 15, N'Mẫu độc quyền'),
(8, 8, 8, 130000, 190000, 35, N'Mùa đông'),
(9, 9, 9, 110000, 160000, 45, N'Hàng tồn'),
(10, 10, 10, 140000, 210000, 55, N'Best seller');
INSERT INTO PhieuNhap (MaNV, NgayNhap, GhiChu, TrangThaiThanhToan, NgayThanhToan) VALUES
(1, '2025-07-01', N'Nhập hàng đầu tháng', 1, '2025-07-02'),
(2, '2025-07-02', N'Nhập bổ sung áo thun', 1, '2025-07-03'),
(3, '2025-07-03', N'Nhập thêm hàng mùa hè', 0, NULL),
(1, '2025-07-04', N'Nhập hàng từ NCC Vạn Thành', 1, '2025-07-04'),
(4, '2025-07-05', N'Đặt hàng khẩn cấp', 0, NULL),
(5, '2025-07-06', N'Nhập hàng định kỳ', 1, '2025-07-06'),
(2, '2025-07-07', N'Nhập quần jeans mới', 0, NULL),
(3, '2025-07-08', N'Nhập hàng đồng phục', 1, '2025-07-09'),
(4, '2025-07-09', N'Nhập hàng khuyến mãi', 0, NULL),
(1, '2025-07-10', N'Nhập lô hàng lớn', 1, '2025-07-10');
INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaCTSP, SoLuong, DonGia) VALUES
(21, 12, 100, 120000),
(21, 12, 50, 150000),
(22, 11, 70, 110000),
(23, 10, 60, 95000),
(24, 5, 80, 99000),
(25, 6, 100, 105000),
(26, 7, 120, 140000),
(27, 8, 75, 130000),
(28, 9, 90, 100000),
(29, 10, 110, 115000),
(30, 10, 110, 115000);
INSERT INTO PhieuXuat (MaKH, MaNV, NgayXuat, TrangThaiThanhToan, MoTa) VALUES
(1, 1, '2025-07-10', 1, N'Khách mua đơn hàng thời trang nam'),
(2, 2, '2025-07-11', 0, N'Đơn hàng chưa thanh toán'),
(3, 3, '2025-07-11', 1, N'Mua áo thun mùa hè'),
(4, 1, '2025-07-12', 1, N'Đơn hàng giao gấp'),
(5, 4, '2025-07-12', 0, N'Khách lấy áo sơ mi và quần tây'),
(6, 2, '2025-07-13', 1, N'Khách VIP, thanh toán tại chỗ'),
(7, 5, '2025-07-14', 0, N'Chờ xác nhận thanh toán'),
(8, 3, '2025-07-14', 1, N'Đơn hàng giảm giá 20%'),
(9, 1, '2025-07-15', 0, N'Khách mua quần short và áo thun'),
(10, 2, '2025-07-15', 1, N'Đơn hàng xuất kho cuối ngày');
INSERT INTO PhieuXuatChiTiet (MaPhieuXuat, MaCTSP, SoLuong, GiaBan) VALUES
(21, 11, 2, 180000),
(22, 12, 1, 220000),
(23, 13, 3, 150000),
(24, 14, 2, 175000),
(25, 5, 1, 190000),
(26, 6, 4, 165000),
(27, 7, 2, 210000),
(28, 8, 1, 160000),
(29, 9, 3, 185000),
(30, 10, 2, 200000);

SELECT * FROM ChucVu;
SELECT * FROM NhanVien;
SELECT * FROM TaiKhoanNhanVien;
SELECT * FROM KhachHang;
SELECT * FROM ThuongHieu;
SELECT * FROM NhaCungCap;
SELECT * FROM SanPham;
SELECT * FROM MauSac;
SELECT * FROM KichThuoc;
SELECT * FROM ChiTietSanPham;
SELECT * FROM PhieuNhap;
SELECT * FROM ChiTietPhieuNhap;
SELECT * FROM PhieuXuat;
SELECT * FROM PhieuXuatChiTiet;























