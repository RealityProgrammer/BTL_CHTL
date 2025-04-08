﻿using Microsoft.Data.SqlClient;
using CHTL.Models;

namespace CHTL.DAL {
    public class TruyCapHoaDon {
        private Database db = new Database();

        public void ThemHoaDon(HoaDon hd)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO HoaDon (MaHoaDon, MaNguoiDung, NgayBan, TongTien) " +
                               "VALUES (@MaHoaDon, @MaNguoiDung, @NgayBan, @TongTien)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", hd.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaNguoiDung", hd.MaNguoiDung);
                cmd.Parameters.AddWithValue("@NgayBan", hd.NgayBan);
                cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
                cmd.ExecuteNonQuery();
            }
        }

        public void ThemChiTietHoaDon(ChiTietHoaDon cthd)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO ChiTietHoaDon (MaChiTiet, MaHoaDon, MaSanPham, SoLuong, DonGia) " +
                               "VALUES (@MaChiTiet, @MaHoaDon, @MaSanPham, @SoLuong, @DonGia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaChiTiet", cthd.MaChiTiet);
                cmd.Parameters.AddWithValue("@MaHoaDon", cthd.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaSanPham", cthd.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", cthd.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", cthd.DonGia);
                cmd.ExecuteNonQuery();
            }
        }
    }
}