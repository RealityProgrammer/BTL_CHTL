using CHTL.DAL;
using CHTL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CHTL.BUS {
    public class XuLyNguoiDung {
        private readonly TruyCapNguoiDung truyCap = new TruyCapNguoiDung();

        public NguoiDung DangNhap(string tenDangNhap, string matKhau) => truyCap.DangNhap(tenDangNhap, matKhau);

        public List<NguoiDung> LayDanhSachNguoiDung() => truyCap.LayDanhSachNguoiDung();

        public void ThemNguoiDung(NguoiDung nd) {
            var danhSach = LayDanhSachNguoiDung();

            if (danhSach.Any(x => x.TenDangNhap == nd.TenDangNhap)) {
                throw new Exception("Tên đăng nhập đã tồn tại!");
            }

            if (danhSach.Any(x => x.MaNguoiDung == nd.MaNguoiDung)) {
                throw new Exception("Mã người dùng đã tồn tại!");
            }

            truyCap.ThemNguoiDung(nd);
        }

        public void SuaNguoiDung(NguoiDung nd) {
            var danhSach = LayDanhSachNguoiDung();

            // Kiểm tra trùng TenDangNhap với người dùng khác (trừ chính người dùng đang sửa)
            if (danhSach.Any(x => x.TenDangNhap == nd.TenDangNhap && x.MaNguoiDung != nd.MaNguoiDung)) {
                throw new Exception("Tên đăng nhập đã tồn tại!");
            }

            // Kiểm tra trùng MaNguoiDung với người dùng khác
            if (danhSach.Any(x => x.MaNguoiDung == nd.MaNguoiDung && x.MaNguoiDung != nd.MaNguoiDung)) {
                throw new Exception("Mã người dùng đã tồn tại!");
            }

            truyCap.SuaNguoiDung(nd);
        }

        public void XoaNguoiDung(string maNguoiDung) {
            truyCap.XoaNguoiDung(maNguoiDung);
        }

        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa) => truyCap.TimKiemNguoiDung(tuKhoa);
    }
}