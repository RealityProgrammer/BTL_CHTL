using CHTL.DAL;
using CHTL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CHTL.BUS {
    public class XuLyDanhMuc {
        private readonly TruyCapDanhMuc truyCap = new TruyCapDanhMuc();

        public List<DanhMucSanPham> LayDanhSachDanhMuc() => truyCap.LayDanhSachDanhMuc();

        public void ThemDanhMuc(DanhMucSanPham dm) {
            var danhSach = LayDanhSachDanhMuc();

            if (danhSach.Any(x => x.MaDanhMuc == dm.MaDanhMuc)) {
                throw new Exception("Mã danh mục đã tồn tại!");
            }

            if (danhSach.Any(x => x.TenDanhMuc == dm.TenDanhMuc)) {
                throw new Exception("Tên danh mục đã tồn tại!");
            }

            truyCap.ThemDanhMuc(dm);
        }

        public void SuaDanhMuc(DanhMucSanPham dm) {
            var danhSach = LayDanhSachDanhMuc();

            if (danhSach.Any(x => x.TenDanhMuc == dm.TenDanhMuc && x.MaDanhMuc != dm.MaDanhMuc)) {
                throw new Exception("Tên danh mục đã tồn tại!");
            }

            truyCap.SuaDanhMuc(dm);
        }

        public void XoaDanhMuc(string maDanhMuc) {
            truyCap.XoaDanhMuc(maDanhMuc);
        }

        public List<DanhMucSanPham> TimKiemDanhMuc(string tuKhoa) => truyCap.TimKiemDanhMuc(tuKhoa);
    }
}