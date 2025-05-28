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
            foreach (var nguoiDung in LayDanhSachNguoiDung()) {
                if (nguoiDung.TenDangNhap == nd.TenDangNhap) {
                    throw new Exception("Tên đăng nhập đã tồn tại!");
                }

                if (nguoiDung.MaNguoiDung == nd.MaNguoiDung) {
                    throw new Exception("Mã người dùng đã tồn tại!");
                }
            }

            truyCap.ThemNguoiDung(nd);
        }

        public void SuaNguoiDung(NguoiDung nd) {
            foreach (var nguoiDung in LayDanhSachNguoiDung()) {
                // Kiểm tra trùng TenDangNhap với người dùng khác (trừ chính người dùng đang sửa)
                if (nguoiDung.TenDangNhap == nd.TenDangNhap && nguoiDung.MaNguoiDung != nd.MaNguoiDung) {
                    throw new Exception("Tên đăng nhập đã tồn tại!");
                }

                // Kiểm tra trùng MaNguoiDung với người dùng khác
                if (nguoiDung.MaNguoiDung == nd.MaNguoiDung && nguoiDung.MaNguoiDung != nd.MaNguoiDung) {
                    throw new Exception("Mã người dùng đã tồn tại!");
                }
            }

            truyCap.SuaNguoiDung(nd);
        }

        public void XoaNguoiDung(string maNguoiDung) {
            truyCap.XoaNguoiDung(maNguoiDung);
        }

        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa) => truyCap.TimKiemNguoiDung(tuKhoa);
    }
}