using CHTL.DAL;
using CHTL.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CHTL.BUS {
    public class XuLySanPham {
        private TruyCapSanPham truyCap = new TruyCapSanPham();
        private TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();

        public List<SanPham> LayDanhSachSanPham()
        {
            return truyCap.LayDanhSachSanPham();
        }

        public void ThemSanPham(SanPham sp)
        {
            var danhSach = LayDanhSachSanPham();
            if (danhSach.Any(x => x.MaSanPham == sp.MaSanPham))
            {
                throw new Exception("Mã sản phẩm đã tồn tại!");
            }
            if (danhSach.Any(x => x.TenSanPham == sp.TenSanPham))
            {
                throw new Exception("Tên sản phẩm đã tồn tại!");
            }

            // Kiểm tra MaDanhMuc có tồn tại không
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            if (!danhMucList.Any(dm => dm.MaDanhMuc == sp.MaDanhMuc))
            {
                throw new Exception("Mã danh mục không tồn tại!");
            }

            truyCap.ThemSanPham(sp);
        }

        public void SuaSanPham(SanPham sp)
        {
            var danhSach = LayDanhSachSanPham();
            if (danhSach.Any(x => x.TenSanPham == sp.TenSanPham && x.MaSanPham != sp.MaSanPham))
            {
                throw new Exception("Tên sản phẩm đã tồn tại!");
            }

            // Kiểm tra MaDanhMuc có tồn tại không
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            if (!danhMucList.Any(dm => dm.MaDanhMuc == sp.MaDanhMuc))
            {
                throw new Exception("Mã danh mục không tồn tại!");
            }

            truyCap.SuaSanPham(sp);
        }

        public void XoaSanPham(string maSanPham)
        {
            truyCap.XoaSanPham(maSanPham);
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa)
        {
            return truyCap.TimKiemSanPham(tuKhoa);
        }
    }
}