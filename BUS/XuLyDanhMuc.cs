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
            foreach (var danhMuc in LayDanhSachDanhMuc()) {
                if (danhMuc.MaDanhMuc == dm.MaDanhMuc) {
                    throw new Exception("Mã danh mục đã tồn tại!");
                }

                if (danhMuc.TenDanhMuc == dm.TenDanhMuc) {
                    throw new Exception("Tên danh mục đã tồn tại!");
                }
            }

            truyCap.ThemDanhMuc(dm);
        }

        public void SuaDanhMuc(DanhMucSanPham dm) {
            foreach (var danhMuc in LayDanhSachDanhMuc()) {
                if (danhMuc.TenDanhMuc == dm.TenDanhMuc && danhMuc.MaDanhMuc != dm.MaDanhMuc) {
                    throw new Exception("Tên danh mục đã tồn tại!");
                }
            }
            
            truyCap.SuaDanhMuc(dm);
        }

        public void XoaDanhMuc(string maDanhMuc) {
            truyCap.XoaDanhMuc(maDanhMuc);
        }

        public List<DanhMucSanPham> TimKiemDanhMuc(string tuKhoa) => truyCap.TimKiemDanhMuc(tuKhoa);
    }
}