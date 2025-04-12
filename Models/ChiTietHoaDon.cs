// File: D:\AUniversityDocs\N3\.NET\cua_hang_tien_loi\Models\ChiTietHoaDon.cs
namespace CHTL.Models
{
    public class ChiTietHoaDon
    {
        public string MaChiTiet { get; set; }
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public ChiTietHoaDon()
        {
        }
    }
}