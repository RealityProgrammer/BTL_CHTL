﻿using System.Collections.Generic;
using System;

namespace CHTL.Models
{
    public class BaoCao
    {
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal TongDoanhThu { get; set; }
        public int TongSoHoaDon { get; set; }
        public string SanPhamBanChay { get; set; }
        public int SoLuongBanChay { get; set; }
        public Dictionary<string, decimal> DoanhThuTheoDanhMuc { get; set; } // Doanh thu theo danh mục
        public List<ChiTietBaoCao> ChiTietHoaDon { get; set; } // Chi tiết các hóa đơn

        public BaoCao()
        {
            DoanhThuTheoDanhMuc = new Dictionary<string, decimal>();
            ChiTietHoaDon = new List<ChiTietBaoCao>();
        }
    }

    public class ChiTietBaoCao
    {
        public string MaHoaDon { get; set; }
        public DateTime NgayBan { get; set; }
        public string TenNguoiDung { get; set; }
        public decimal TongTien { get; set; }
        public List<SanPhamBan> SanPham { get; set; }

        public ChiTietBaoCao()
        {
            SanPham = new List<SanPhamBan>();
        }
    }

    public class SanPhamBan
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}