using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHTL.Models;
using Microsoft.Data.SqlClient;

namespace CHTL.DAL
{
    public class TruyCapDanhMuc
    {
        private Database db = new Database();

        public List<DanhMucSanPham> LayDanhSachDanhMuc()
        {
            List<DanhMucSanPham> danhSach = new List<DanhMucSanPham>();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM DanhMucSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(new DanhMucSanPham
                    {
                        MaDanhMuc = reader["MaDanhMuc"].ToString(),
                        TenDanhMuc = reader["TenDanhMuc"].ToString()
                    });
                }
            }
            return danhSach;
        }

        public void ThemDanhMuc(DanhMucSanPham dm)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO DanhMucSanPham (MaDanhMuc, TenDanhMuc) VALUES (@MaDanhMuc, @TenDanhMuc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", dm.MaDanhMuc);
                cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc);
                cmd.ExecuteNonQuery();
            }
        }

        public void SuaDanhMuc(DanhMucSanPham dm)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE DanhMucSanPham SET TenDanhMuc = @TenDanhMuc WHERE MaDanhMuc = @MaDanhMuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", dm.MaDanhMuc);
                cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaDanhMuc(string maDanhMuc)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM DanhMucSanPham WHERE MaDanhMuc = @MaDanhMuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                cmd.ExecuteNonQuery();
            }
        }

        public List<DanhMucSanPham> TimKiemDanhMuc(string tuKhoa)
        {
            List<DanhMucSanPham> danhSach = new List<DanhMucSanPham>();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM DanhMucSanPham WHERE MaDanhMuc LIKE @TuKhoa OR TenDanhMuc LIKE @TuKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(new DanhMucSanPham
                    {
                        MaDanhMuc = reader["MaDanhMuc"].ToString(),
                        TenDanhMuc = reader["TenDanhMuc"].ToString()
                    });
                }
            }
            return danhSach;
        }

    }
}
