using CHTL.DAL;
using CHTL.Models;
using System;
using System.Collections.Generic;

namespace CHTL.BUS {
    public class XuLyHoaDon {
        private readonly TruyCapHoaDon truyCapHoaDon = new TruyCapHoaDon();
        private readonly TruyCapSanPham truyCapSanPham = new TruyCapSanPham();

        public void LuuHoaDon(HoaDon hd, List<ChiTietHoaDon> chiTietList) {
            // Kiểm tra số lượng tồn trước khi lưu hóa đơn
            foreach (ChiTietHoaDon cthd in chiTietList) {
                SanPham sanPham = truyCapSanPham.LaySanPhamTheoMa(cthd.MaSanPham);

                if (sanPham == null) {
                    throw new Exception($"Sản phẩm {cthd.MaSanPham} không tồn tại!");
                }

                if (sanPham.SoLuongTon < cthd.SoLuong) {
                    throw new Exception($"Sản phẩm {sanPham.TenSanPham} không đủ số lượng tồn (còn {sanPham.SoLuongTon})!");
                }
            }

            // Lưu hóa đơn
            truyCapHoaDon.ThemHoaDon(hd);

            // Lưu chi tiết hóa đơn
            foreach (ChiTietHoaDon cthd in chiTietList) {
                truyCapHoaDon.ThemChiTietHoaDon(cthd);
                // Cập nhật số lượng tồn
                truyCapSanPham.CapNhatSoLuongTon(cthd.MaSanPham, cthd.SoLuong);
            }
        }
    }
}