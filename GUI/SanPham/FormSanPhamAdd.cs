using System;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;
using CHTL.BUS;
using CHTL.Models;
using CHTL.DAL;

namespace CHTL.GUI.SanPham
{
    public partial class FormSanPhamAdd : SampleAdd
    {
        private XuLySanPham xuLy = new XuLySanPham();
        private TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();

        public FormSanPhamAdd()
        {
            InitializeComponent();
            LoadDanhMuc();
        }

        private void LoadDanhMuc()
        {
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            cbMaDanhMuc.DataSource = danhMucList;
            cbMaDanhMuc.DisplayMember = "MaDanhMuc";
            cbMaDanhMuc.ValueMember = "MaDanhMuc";
            cbMaDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public override void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_ma_san_pham.Text))
                {
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_ten_san_pham.Text))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txt_gia_ban.Text, out decimal giaBan) || giaBan < 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbMaDanhMuc.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn mã danh mục!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txt_so_luong_ton.Text, out int soLuongTon) || soLuongTon < 0)
                {
                    MessageBox.Show("Số lượng tồn không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime? ngayHetHan = dtp_ngay_het_han.Checked ? (DateTime?)dtp_ngay_het_han.Value : null;

                // Tạo đối tượng SanPham
                CHTL.Models.SanPham sp = new CHTL.Models.SanPham
                {
                    MaSanPham = txt_ma_san_pham.Text.Trim(),
                    TenSanPham = txt_ten_san_pham.Text.Trim(),
                    GiaBan = giaBan,
                    MaDanhMuc = cbMaDanhMuc.SelectedValue.ToString(),
                    SoLuongTon = soLuongTon,
                    NgayHetHan = ngayHetHan
                };

                // Gọi phương thức thêm sản phẩm
                xuLy.ThemSanPham(sp);

                // Thông báo thành công
                MessageBox.Show("Thêm sản phẩm thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}