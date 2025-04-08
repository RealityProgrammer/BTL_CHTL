using CHTL.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System;

namespace CHTL.DAL {
    public class TruyCapSanPham {
        private Database db = new Database();

        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> danhSach = new List<SanPham>();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM SanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(new SanPham
                    {
                        MaSanPham = reader["MaSanPham"].ToString(),
                        TenSanPham = reader["TenSanPham"].ToString(),
                        GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                        MaDanhMuc = reader["MaDanhMuc"].ToString(),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                        NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"]
                    });
                }
            }
            return danhSach;
        }



        public void ThemSanPham(SanPham sp)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO SanPham (MaSanPham, TenSanPham, GiaBan, MaDanhMuc, SoLuongTon, NgayHetHan) " +
                               "VALUES (@MaSanPham, @TenSanPham, @GiaBan, @MaDanhMuc, @SoLuongTon, @NgayHetHan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                cmd.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                cmd.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan.HasValue ? (object)sp.NgayHetHan.Value : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void SuaSanPham(SanPham sp)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE SanPham SET TenSanPham = @TenSanPham, GiaBan = @GiaBan, MaDanhMuc = @MaDanhMuc, " +
                               "SoLuongTon = @SoLuongTon, NgayHetHan = @NgayHetHan WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                cmd.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                cmd.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan.HasValue ? (object)sp.NgayHetHan.Value : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaSanPham(string maSanPham)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                cmd.ExecuteNonQuery();
            }
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa)
        {
            List<SanPham> danhSach = new List<SanPham>();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM SanPham WHERE MaSanPham LIKE @TuKhoa OR TenSanPham LIKE @TuKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(new SanPham
                    {
                        MaSanPham = reader["MaSanPham"].ToString(),
                        TenSanPham = reader["TenSanPham"].ToString(),
                        GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                        MaDanhMuc = reader["MaDanhMuc"].ToString(),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                        NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"]
                    });
                }
            }
            return danhSach;
        }

        public void CapNhatSoLuongTon(string maSanPham, int soLuongMua)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuongMua WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoLuongMua", soLuongMua);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                cmd.ExecuteNonQuery();
            }
        }

        public SanPham LaySanPhamTheoMa(string maSanPham)
        {
            SanPham sp = null;
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM SanPham WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sp = new SanPham
                    {
                        MaSanPham = reader["MaSanPham"].ToString(),
                        TenSanPham = reader["TenSanPham"].ToString(),
                        GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                        MaDanhMuc = reader["MaDanhMuc"].ToString(),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                        NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"]
                    };
                }
            }
            return sp;
        }
    }
}