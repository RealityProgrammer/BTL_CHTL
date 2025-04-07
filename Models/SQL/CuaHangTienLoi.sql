-- Tạo cơ sở dữ liệu
CREATE DATABASE CuaHangTienLoi;
GO
USE CuaHangTienLoi;
GO

-- Tạo bảng NguoiDung
CREATE TABLE NguoiDung (
    MaNguoiDung NVARCHAR(10) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) UNIQUE,
    MatKhau NVARCHAR(100),
    VaiTro NVARCHAR(20) CHECK (VaiTro IN ('Admin', 'NhanVien')),
    HoTen NVARCHAR(100)
);

-- Tạo bảng DanhMucSanPham
CREATE TABLE DanhMucSanPham (
    MaDanhMuc NVARCHAR(10) PRIMARY KEY,
    TenDanhMuc NVARCHAR(50) UNIQUE
);

-- Tạo bảng SanPham
CREATE TABLE SanPham (
    MaSanPham NVARCHAR(20) PRIMARY KEY,
    TenSanPham NVARCHAR(100),
    GiaBan DECIMAL(18,2) CHECK (GiaBan >= 0),
    MaDanhMuc NVARCHAR(10) FOREIGN KEY REFERENCES DanhMucSanPham(MaDanhMuc),
    SoLuongTon INT CHECK (SoLuongTon >= 0),
    NgayHetHan DATE
);

-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    MaHoaDon NVARCHAR(20) PRIMARY KEY,
    MaNguoiDung NVARCHAR(10) FOREIGN KEY REFERENCES NguoiDung(MaNguoiDung),
    NgayBan DATETIME DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) CHECK (TongTien >= 0)
);

-- Tạo bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaChiTiet NVARCHAR(20) PRIMARY KEY,
    MaHoaDon NVARCHAR(20) FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    MaSanPham NVARCHAR(20) FOREIGN KEY REFERENCES SanPham(MaSanPham),
    SoLuong INT CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) CHECK (DonGia >= 0)
);

-- Chèn dữ liệu mẫu
INSERT INTO NguoiDung VALUES 
('NV001', 'admin', 'admin123', 'Admin', 'Nguyễn Văn A'),
('NV002', 'nhanvien1', 'nhanvien123', 'NhanVien', 'Trần Thị B');

INSERT INTO DanhMucSanPham VALUES 
('DM001', 'Thực phẩm'),
('DM002', 'Đồ uống');

INSERT INTO SanPham VALUES 
('SP001', 'Bánh mì', 15000, 'DM001', 50, '2025-12-31'),
('SP002', 'Nước ngọt', 10000, 'DM002', 100, '2026-01-15');

INSERT INTO HoaDon VALUES 
('HD20250406001', 'NV002', '2025-04-06 15:00:00', 25000),
('HD20250406002', 'NV001', '2025-04-06 16:00:00', 30000);

INSERT INTO ChiTietHoaDon VALUES 
('CT001', 'HD20250406001', 'SP001', 1, 15000),
('CT002', 'HD20250406001', 'SP002', 1, 10000),
('CT003', 'HD20250406002', 'SP002', 3, 10000);
