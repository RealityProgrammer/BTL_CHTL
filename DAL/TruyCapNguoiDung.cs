using CHTL.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CHTL.DAL {
    public class TruyCapNguoiDung {
        private readonly Database db = new Database();

        public NguoiDung DangNhap(string tenDangNhap, string matKhau) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "SELECT * FROM NguoiDung WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    return new NguoiDung {
                        MaNguoiDung = reader["MaNguoiDung"].ToString(),
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        VaiTro = reader["VaiTro"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                    };
                }

                return null;
            }
        }
        public List<NguoiDung> LayDanhSachNguoiDung() {
            var danhSach = new List<NguoiDung>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "SELECT * FROM NguoiDung";
                var cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    danhSach.Add(new NguoiDung {
                        MaNguoiDung = reader["MaNguoiDung"].ToString(),
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        VaiTro = reader["VaiTro"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                    });
            }

            return danhSach;
        }

        public void ThemNguoiDung(NguoiDung nd) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "INSERT INTO NguoiDung (MaNguoiDung, TenDangNhap, MatKhau, VaiTro, HoTen) " +
                               "VALUES (@MaNguoiDung, @TenDangNhap, @MatKhau, @VaiTro, @HoTen)";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", nd.MaNguoiDung);
                cmd.Parameters.AddWithValue("@TenDangNhap", nd.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", nd.MatKhau);
                cmd.Parameters.AddWithValue("@VaiTro", nd.VaiTro);
                cmd.Parameters.AddWithValue("@HoTen", nd.HoTen);
                cmd.ExecuteNonQuery();
            }
        }

        public void SuaNguoiDung(NguoiDung nd) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "UPDATE NguoiDung SET TenDangNhap = @TenDangNhap, " +
                               "VaiTro = @VaiTro, HoTen = @HoTen WHERE MaNguoiDung = @MaNguoiDung";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", nd.MaNguoiDung);
                cmd.Parameters.AddWithValue("@TenDangNhap", nd.TenDangNhap);

                cmd.Parameters.AddWithValue("@VaiTro", nd.VaiTro);
                cmd.Parameters.AddWithValue("@HoTen", nd.HoTen);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaNguoiDung(string maNguoiDung) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "DELETE FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                cmd.ExecuteNonQuery();
            }
        }

        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa) {
            var danhSach = new List<NguoiDung>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "SELECT * FROM NguoiDung WHERE HoTen LIKE @TuKhoa OR MaNguoiDung LIKE @TuKhoa";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    danhSach.Add(new NguoiDung {
                        MaNguoiDung = reader["MaNguoiDung"].ToString(),
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        VaiTro = reader["VaiTro"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                    });
            }

            return danhSach;
        }
    }
}