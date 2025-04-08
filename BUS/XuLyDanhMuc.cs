using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHTL.Models;

namespace CHTL.BUS
{
    public class XuLyDanhMuc
    {
        private DAL.TruyCapDanhMuc truyCap = new DAL.TruyCapDanhMuc();

        public List<DanhMucSanPham> LayDanhSachDanhMuc()
        {
            return truyCap.LayDanhSachDanhMuc();
        }

        public void ThemDanhMuc(DanhMucSanPham dm)
        {
            var danhSach = LayDanhSachDanhMuc();
            if (danhSach.Any(x => x.MaDanhMuc == dm.MaDanhMuc))
            {
                throw new System.Exception("Mã danh mục đã tồn tại!");
            }
            if (danhSach.Any(x => x.TenDanhMuc == dm.TenDanhMuc))
            {
                throw new System.Exception("Tên danh mục đã tồn tại!");
            }
            truyCap.ThemDanhMuc(dm);
        }

        public void SuaDanhMuc(DanhMucSanPham dm)
        {
            var danhSach = LayDanhSachDanhMuc();
            if (danhSach.Any(x => x.TenDanhMuc == dm.TenDanhMuc && x.MaDanhMuc != dm.MaDanhMuc))
            {
                throw new System.Exception("Tên danh mục đã tồn tại!");
            }
            truyCap.SuaDanhMuc(dm);
        }

        public void XoaDanhMuc(string maDanhMuc)
        {
            truyCap.XoaDanhMuc(maDanhMuc);
        }

        public List<DanhMucSanPham> TimKiemDanhMuc(string tuKhoa)
        {
            return truyCap.TimKiemDanhMuc(tuKhoa);
        }
    }
}
