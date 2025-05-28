using CHTL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CHTL.DAL {
    public class TruyCapSanPham {
        private readonly Database db = new Database();

        public List<SanPham> LayDanhSachSanPham() {
            var danhSach = new List<SanPham>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();

                string query = "SELECT * FROM SanPham";
                using (var cmd = new SqlCommand(query, conn)) {
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            danhSach.Add(new SanPham {
                                MaSanPham = reader["MaSanPham"].ToString(),
                                TenSanPham = reader["TenSanPham"].ToString(),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                GiamGia = Convert.ToDecimal(reader["GiamGia"] == DBNull.Value ? 0 : reader["GiamGia"]),
                                MaDanhMuc = reader["MaDanhMuc"].ToString(),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"],
                            });
                        }
                    }
                }
            }

            return danhSach;
        }

        public List<SanPham> LayDanhSachSanPham(string danhMuc) {
            var danhSach = new List<SanPham>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();

                string query = "SELECT * FROM SanPham WHERE MaDanhMuc = @MaDanhMuc";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@MaDanhMuc", danhMuc);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            danhSach.Add(new SanPham {
                                MaSanPham = reader["MaSanPham"].ToString(),
                                TenSanPham = reader["TenSanPham"].ToString(),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                GiamGia = Convert.ToDecimal(reader["GiamGia"] == DBNull.Value ? 0 : reader["GiamGia"]),
                                MaDanhMuc = reader["MaDanhMuc"].ToString(),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"],
                            });
                        }
                    }
                }
            }

            return danhSach;
        }

        public void ThemSanPham(SanPham sp) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();

                string query = "INSERT INTO SanPham (MaSanPham, TenSanPham, GiaBan, GiamGia, MaDanhMuc, SoLuongTon, NgayHetHan) " +
                               "VALUES (@MaSanPham, @TenSanPham, @GiaBan, @GiamGia, @MaDanhMuc, @SoLuongTon, @NgayHetHan)";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                    cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@GiamGia", sp.GiamGia);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan.HasValue ? (object)sp.NgayHetHan.Value : DBNull.Value);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SuaSanPham(SanPham sp) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();

                string query = "UPDATE SanPham SET TenSanPham = @TenSanPham, GiaBan = @GiaBan, GiamGia = @GiamGia, MaDanhMuc = @MaDanhMuc, " +
                               "SoLuongTon = @SoLuongTon, NgayHetHan = @NgayHetHan WHERE MaSanPham = @MaSanPham";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                    cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@GiamGia", sp.GiamGia);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan.HasValue ? (object)sp.NgayHetHan.Value : DBNull.Value);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void XoaSanPham(string maSanPham) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                
                string query = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa) {
            var danhSach = new List<SanPham>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                
                string query = "SELECT * FROM SanPham WHERE MaSanPham LIKE @TuKhoa OR TenSanPham LIKE @TuKhoa";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            danhSach.Add(new SanPham {
                                MaSanPham = reader["MaSanPham"].ToString(),
                                TenSanPham = reader["TenSanPham"].ToString(),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                GiamGia = Convert.ToDecimal(reader["GiamGia"] == DBNull.Value ? 0 : reader["GiamGia"]),
                                MaDanhMuc = reader["MaDanhMuc"].ToString(),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"],
                            });
                        }
                    }
                }
            }

            return danhSach;
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa, string maDanhMuc) {
            var danhSach = new List<SanPham>();

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                
                string query = "SELECT * FROM SanPham WHERE (MaSanPham LIKE @TuKhoa OR TenSanPham LIKE @TuKhoa) AND MaDanhMuc = @MaDanhMuc";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                    cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            danhSach.Add(new SanPham {
                                MaSanPham = reader["MaSanPham"].ToString(),
                                TenSanPham = reader["TenSanPham"].ToString(),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                GiamGia = Convert.ToDecimal(reader["GiamGia"] == DBNull.Value ? 0 : reader["GiamGia"]),
                                MaDanhMuc = reader["MaDanhMuc"].ToString(),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"],
                            });
                        }
                    }
                }
            }

            return danhSach;
        }

        public void CapNhatSoLuongTon(string maSanPham, int soLuongMua) {
            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();
                
                string query = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuongMua WHERE MaSanPham = @MaSanPham";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@SoLuongMua", soLuongMua);
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SanPham LaySanPhamTheoMa(string maSanPham) {
            SanPham sp = null;

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();

                string query = "SELECT * FROM SanPham WHERE MaSanPham = @MaSanPham";
                using (var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            sp = new SanPham {
                                MaSanPham = reader["MaSanPham"].ToString(),
                                TenSanPham = reader["TenSanPham"].ToString(),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                GiamGia = Convert.ToDecimal(reader["GiamGia"] == DBNull.Value ? 0 : reader["GiamGia"]),
                                MaDanhMuc = reader["MaDanhMuc"].ToString(),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                NgayHetHan = reader["NgayHetHan"] == DBNull.Value ? null : (DateTime?)reader["NgayHetHan"],
                            };
                        }
                    }
                }
            }

            return sp;
        }
    }
}