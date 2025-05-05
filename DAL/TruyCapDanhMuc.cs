using CHTL.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CHTL.DAL {
    public class TruyCapDanhMuc {
        private readonly Database db = new Database();

        public List<DanhMucSanPham> LayDanhSachDanhMuc() {
            var danhSach = new List<DanhMucSanPham>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "SELECT * FROM DanhMucSanPham";
                var cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    danhSach.Add(new DanhMucSanPham {
                        MaDanhMuc = reader["MaDanhMuc"].ToString(),
                        TenDanhMuc = reader["TenDanhMuc"].ToString(),
                    });
            }

            return danhSach;
        }

        public void ThemDanhMuc(DanhMucSanPham dm) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "INSERT INTO DanhMucSanPham (MaDanhMuc, TenDanhMuc) VALUES (@MaDanhMuc, @TenDanhMuc)";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", dm.MaDanhMuc);
                cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc);
                cmd.ExecuteNonQuery();
            }
        }

        public void SuaDanhMuc(DanhMucSanPham dm) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "UPDATE DanhMucSanPham SET TenDanhMuc = @TenDanhMuc WHERE MaDanhMuc = @MaDanhMuc";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", dm.MaDanhMuc);
                cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaDanhMuc(string maDanhMuc) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "DELETE FROM DanhMucSanPham WHERE MaDanhMuc = @MaDanhMuc";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                cmd.ExecuteNonQuery();
            }
        }

        public List<DanhMucSanPham> TimKiemDanhMuc(string tuKhoa) {
            var danhSach = new List<DanhMucSanPham>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                string query = "SELECT * FROM DanhMucSanPham WHERE MaDanhMuc LIKE @TuKhoa OR TenDanhMuc LIKE @TuKhoa";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    danhSach.Add(new DanhMucSanPham {
                        MaDanhMuc = reader["MaDanhMuc"].ToString(),
                        TenDanhMuc = reader["TenDanhMuc"].ToString(),
                    });
            }

            return danhSach;
        }
    }
}