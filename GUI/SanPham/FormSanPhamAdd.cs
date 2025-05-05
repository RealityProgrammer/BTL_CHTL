using CHTL.BUS;
using CHTL.DAL;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.SanPham {
    public partial class FormSanPhamAdd : KryptonForm {
        private readonly TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();
        private readonly XuLySanPham xuLy = new XuLySanPham();

        public FormSanPhamAdd() {
            InitializeComponent();
            InitializeVaiTroComboBox();
        }

        private void InitializeVaiTroComboBox() {
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            cbDanhMuc.DataSource = danhMucList;
            cbDanhMuc.DisplayMember = "MaDanhMuc";
            cbDanhMuc.ValueMember = "MaDanhMuc";
            cbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(textboxID.Text)) {
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textboxTen.Text)) {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textboxGia.Text, out decimal giaBan) || giaBan < 0) {
                    MessageBox.Show("Giá bán không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textboxGiamGia.Text, out decimal giamGia) || giamGia < 0) {
                    MessageBox.Show("Giảm giá không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (giamGia > giaBan) {
                    MessageBox.Show("Giảm giá không hợp lệ! Vui lòng nhập giá trị nhỏ hơn giá bán.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbDanhMuc.SelectedValue == null) {
                    MessageBox.Show("Vui lòng chọn mã danh mục!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textboxSoLuongTon.Text, out int soLuongTon) || soLuongTon < 0) {
                    MessageBox.Show("Số lượng tồn không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ngayHetHan = dtpNgayHetHan.Checked ? (DateTime?)dtpNgayHetHan.Value : null;

                // Tạo đối tượng SanPham
                var sp = new Models.SanPham {
                    MaSanPham = textboxID.Text.Trim(),
                    TenSanPham = textboxTen.Text.Trim(),
                    GiaBan = giaBan,
                    MaDanhMuc = cbDanhMuc.SelectedValue.ToString(),
                    SoLuongTon = soLuongTon,
                    NgayHetHan = ngayHetHan,
                    GiamGia = giamGia,
                };

                // Gọi phương thức thêm sản phẩm
                xuLy.ThemSanPham(sp);

                // Thông báo thành công
                MessageBox.Show("Thêm sản phẩm thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            } catch (Exception ex) {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}