using CHTL.DAL;
using CHTL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CHTL.BUS {
    public class XuLySanPham {
        private readonly TruyCapSanPham truyCap = new TruyCapSanPham();
        private readonly TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();

        public List<SanPham> LayDanhSachSanPham() => truyCap.LayDanhSachSanPham();
        public List<SanPham> LayDanhSachSanPham(string danhMuc) => truyCap.LayDanhSachSanPham(danhMuc);

        public void ThemSanPham(SanPham sp) {
            foreach (var sanPham in LayDanhSachSanPham()) {
                if (sanPham.MaSanPham == sp.MaSanPham) {
                    throw new Exception("Mã sản phẩm đã tồn tại!");
                }

                if (sanPham.TenSanPham == sp.TenSanPham) {
                    throw new Exception("Tên sản phẩm đã tồn tại!");
                }
            }

            // Kiểm tra MaDanhMuc có tồn tại không
            if (truyCapDanhMuc.LayDanhSachDanhMuc().All(dm => dm.MaDanhMuc != sp.MaDanhMuc)) {
                throw new Exception("Mã danh mục không tồn tại!");
            }

            truyCap.ThemSanPham(sp);
        }

        public void SuaSanPham(SanPham sp) {
            foreach (var sanPham in LayDanhSachSanPham()) {
                if (sanPham.TenSanPham == sp.TenSanPham && sanPham.MaSanPham != sp.MaSanPham) {
                    throw new Exception("Tên sản phẩm đã tồn tại!");
                }
            }

            // Kiểm tra MaDanhMuc có tồn tại không
            if (truyCapDanhMuc.LayDanhSachDanhMuc().All(dm => dm.MaDanhMuc != sp.MaDanhMuc)) {
                throw new Exception("Mã danh mục không tồn tại!");
            }
            
            truyCap.SuaSanPham(sp);
        }

        public void XoaSanPham(string maSanPham) {
            truyCap.XoaSanPham(maSanPham);
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa) => truyCap.TimKiemSanPham(tuKhoa);
    }
}