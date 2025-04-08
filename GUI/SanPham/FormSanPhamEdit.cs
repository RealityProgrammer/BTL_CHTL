using System;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;
using CHTL.BUS;
using CHTL.Models;
using CHTL.DAL;

namespace CHTL.GUI.SanPham
{
    public partial class FormSanPhamEdit : SampleEdit
    {
        private XuLySanPham xuLy = new XuLySanPham();
        private TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();

        private CHTL.Models.SanPham sanPhamEdit;
        public CHTL.Models.SanPham SanPhamEdit
        {
            get { return sanPhamEdit; }
            set
            {
                sanPhamEdit = value;
                LoadDataToForm();
            }
        }

        public FormSanPhamEdit()
        {
            InitializeComponent();
            LoadDanhMuc();
            InitializeControls();
        }

        private void LoadDanhMuc()
        {
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            cbMaDanhMuc.DataSource = danhMucList;
            cbMaDanhMuc.DisplayMember = "MaDanhMuc";
            cbMaDanhMuc.ValueMember = "MaDanhMuc";
            cbMaDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeControls()
        {
            // Không cho phép sửa MaSanPham
            txt_ma_san_pham.ReadOnly = true;
        }

        private void LoadDataToForm()
        {
            if (sanPhamEdit != null)
            {
                txt_ma_san_pham.Text = sanPhamEdit.MaSanPham;
                txt_ten_san_pham.Text = sanPhamEdit.TenSanPham;
                txt_gia_ban.Text = sanPhamEdit.GiaBan.ToString();
                cbMaDanhMuc.SelectedValue = sanPhamEdit.MaDanhMuc;
                txt_so_luong_ton.Text = sanPhamEdit.SoLuongTon.ToString();
                if (sanPhamEdit.NgayHetHan.HasValue)
                {
                    dtp_ngay_het_han.Value = sanPhamEdit.NgayHetHan.Value;
                    dtp_ngay_het_han.Checked = true;
                }
                else
                {
                    dtp_ngay_het_han.Checked = false;
                }
            }
        }

        public override void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
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

                // Cập nhật thông tin sản phẩm
                sanPhamEdit.TenSanPham = txt_ten_san_pham.Text.Trim();
                sanPhamEdit.GiaBan = giaBan;
                sanPhamEdit.MaDanhMuc = cbMaDanhMuc.SelectedValue.ToString();
                sanPhamEdit.SoLuongTon = soLuongTon;
                sanPhamEdit.NgayHetHan = ngayHetHan;

                // Gọi phương thức sửa sản phẩm
                xuLy.SuaSanPham(sanPhamEdit);

                // Thông báo thành công
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công",
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