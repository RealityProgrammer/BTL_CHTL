using CHTL.BUS;
using CHTL.DAL;
using Krypton.Toolkit;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CHTL.GUI.SanPham {
    public partial class FormSanPhamEdit : KryptonForm {
        private XuLySanPham xuLy = new XuLySanPham();
        private TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();

        private Models.SanPham sanPhamEdit;
        public Models.SanPham SanPhamEdit
        {
            get => sanPhamEdit;
            set
            {
                sanPhamEdit = value;
                NhapDuLieu();
            }
        }
        
        public FormSanPhamEdit() {
            InitializeComponent();
            InitializeVaiTroComboBox();
        }
        
        private void InitializeVaiTroComboBox()
        {
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            cbDanhMuc.DataSource = danhMucList;
            cbDanhMuc.DisplayMember = "MaDanhMuc";
            cbDanhMuc.ValueMember = "MaDanhMuc";
            cbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void NhapDuLieu() {
            textboxID.Text = sanPhamEdit.MaSanPham;
            textboxTen.Text = sanPhamEdit.TenSanPham;
            textboxGia.Text = sanPhamEdit.GiaBan.ToString(CultureInfo.CurrentCulture);
            cbDanhMuc.SelectedValue = sanPhamEdit.MaDanhMuc;
            textboxSoLuongTon.Text = sanPhamEdit.SoLuongTon.ToString();
            textboxGiamGia.Text = sanPhamEdit.GiamGia.ToString(CultureInfo.CurrentCulture);

            if (sanPhamEdit.NgayHetHan.HasValue)
            {
                dtpNgayHetHan.Value = sanPhamEdit.NgayHetHan.Value;
                dtpNgayHetHan.Checked = true;
            }
            else
            {
                dtpNgayHetHan.Checked = false;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e) {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(textboxID.Text))
                {
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textboxTen.Text))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textboxGia.Text, out decimal giaBan) || giaBan < 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (!decimal.TryParse(textboxGiamGia.Text, out decimal giamGia) || giamGia < 0)
                {
                    MessageBox.Show("Giảm giá không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (giamGia > giaBan) {
                    MessageBox.Show("Giảm giá không hợp lệ! Vui lòng nhập giá trị nhỏ hơn giá bán.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbDanhMuc.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn mã danh mục!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textboxSoLuongTon.Text, out int soLuongTon) || soLuongTon < 0)
                {
                    MessageBox.Show("Số lượng tồn không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime? ngayHetHan = dtpNgayHetHan.Checked ? (DateTime?)dtpNgayHetHan.Value : null;

                // Cập nhật thông tin sản phẩm
                sanPhamEdit.TenSanPham = textboxTen.Text.Trim();
                sanPhamEdit.GiaBan = giaBan;
                sanPhamEdit.MaDanhMuc = cbDanhMuc.SelectedValue.ToString();
                sanPhamEdit.SoLuongTon = soLuongTon;
                sanPhamEdit.NgayHetHan = ngayHetHan;
                sanPhamEdit.GiamGia = giamGia;

                // Gọi phương thức sửa sản phẩm
                xuLy.SuaSanPham(sanPhamEdit);

                // Thông báo thành công
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}