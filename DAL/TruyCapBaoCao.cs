using CHTL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CHTL.DAL {
    public class TruyCapBaoCao {
        private readonly Database db = new Database();
        public BaoCao LayBaoCao(DateTime ngayBatDau, DateTime ngayKetThuc) {
            var baoCao = new BaoCao {
                NgayBatDau = ngayBatDau,
                NgayKetThuc = ngayKetThuc,
            };

            using (SqlConnection conn = db.GetConnection()) {
                conn.Open();

                // 1. Tính tổng doanh thu và số lượng hóa đơn
                string queryTong = @"
                    SELECT SUM(TongTien) AS TongDoanhThu, COUNT(*) AS TongSoHoaDon
                    FROM HoaDon
                    WHERE NgayBan BETWEEN @NgayBatDau AND @NgayKetThuc";

                using (var cmd = new SqlCommand(queryTong, conn)) {
                    cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            baoCao.TongDoanhThu = reader["TongDoanhThu"] != DBNull.Value ? Convert.ToDecimal(reader["TongDoanhThu"]) : 0;
                            baoCao.TongSoHoaDon = reader["TongSoHoaDon"] != DBNull.Value ? Convert.ToInt32(reader["TongSoHoaDon"]) : 0;
                        }
                    }
                }

                // 2. Tìm sản phẩm bán chạy nhất
                string querySanPhamBanChay = @"
                    SELECT TOP 1 sp.TenSanPham, SUM(ct.SoLuong) AS SoLuongBan
                    FROM ChiTietHoaDon ct
                    JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
                    JOIN HoaDon hd ON ct.MaHoaDon = hd.MaHoaDon
                    WHERE hd.NgayBan BETWEEN @NgayBatDau AND @NgayKetThuc
                    GROUP BY sp.TenSanPham
                    ORDER BY SoLuongBan DESC";

                using (var cmd = new SqlCommand(querySanPhamBanChay, conn)) {
                    cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            baoCao.SanPhamBanChay = reader["TenSanPham"].ToString();
                            baoCao.SoLuongBanChay = Convert.ToInt32(reader["SoLuongBan"]);
                        }
                    }
                }

                // 3. Doanh thu theo danh mục
                string queryDoanhThuTheoDanhMuc = @"
                    SELECT dm.TenDanhMuc, SUM(ct.DonGia * ct.SoLuong) AS DoanhThu
                    FROM ChiTietHoaDon ct
                    JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
                    JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc
                    JOIN HoaDon hd ON ct.MaHoaDon = hd.MaHoaDon
                    WHERE hd.NgayBan BETWEEN @NgayBatDau AND @NgayKetThuc
                    GROUP BY dm.TenDanhMuc";

                using (var cmd = new SqlCommand(queryDoanhThuTheoDanhMuc, conn)) {
                    cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            string tenDanhMuc = reader["TenDanhMuc"].ToString();
                            decimal doanhThu = reader["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(reader["DoanhThu"]) : 0;
                            baoCao.DoanhThuTheoDanhMuc.Add(tenDanhMuc, doanhThu);
                        }
                    }
                }

                // 4. Chi tiết hóa đơn
                string queryChiTiet = @"
                    SELECT hd.MaHoaDon, hd.NgayBan, nd.HoTen, hd.TongTien,
                           sp.TenSanPham, ct.SoLuong, ct.DonGia
                    FROM HoaDon hd
                    JOIN NguoiDung nd ON hd.MaNguoiDung = nd.MaNguoiDung
                    JOIN ChiTietHoaDon ct ON hd.MaHoaDon = ct.MaHoaDon
                    JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
                    WHERE hd.NgayBan BETWEEN @NgayBatDau AND @NgayKetThuc
                    ORDER BY hd.NgayBan";

                using (var cmd = new SqlCommand(queryChiTiet, conn)) {
                    cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        var chiTietDict = new Dictionary<string, ChiTietBaoCao>();

                        while (reader.Read()) {
                            string maHoaDon = reader["MaHoaDon"].ToString();

                            if (!chiTietDict.ContainsKey(maHoaDon)) {
                                chiTietDict[maHoaDon] = new ChiTietBaoCao {
                                    MaHoaDon = maHoaDon,
                                    NgayBan = Convert.ToDateTime(reader["NgayBan"]),
                                    TenNguoiDung = reader["HoTen"].ToString(),
                                    TongTien = Convert.ToDecimal(reader["TongTien"]),
                                };
                            }

                            chiTietDict[maHoaDon].SanPham.Add(new SanPhamBan {
                                TenSanPham = reader["TenSanPham"].ToString(),
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                            });
                        }

                        baoCao.ChiTietHoaDon = chiTietDict.Values.ToList();
                    }
                }
            }

            return baoCao;
        }
    }
}