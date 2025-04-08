using System;

namespace CHTL.Models {
    public class SanPham {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaBan { get; set; }
        public string MaDanhMuc { get; set; }
        public int SoLuongTon { get; set; }
        public DateTime? NgayHetHan { get; set; }
    }
}