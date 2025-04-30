using CHTL.BUS;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.NguoiDung {
    public partial class FormNguoiDungAdd : KryptonForm {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();
        
        public FormNguoiDungAdd() {
            InitializeComponent();
            InitializeVaiTroComboBox();
        }
        
        private void InitializeVaiTroComboBox()
        {
            cbVaiTro.Items.Add("Admin");
            cbVaiTro.Items.Add("NhanVien");
            cbVaiTro.SelectedIndex = 0; // Mặc định chọn "Admin"
            cbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList; // Chỉ cho phép chọn, không cho nhập tay
        }
        
        private void btnSave_Click(object sender, EventArgs e) {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(textboxID.Text))
                {
                    MessageBox.Show("Mã người dùng không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textboxTenDangNhap.Text))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textboxMatKhau.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textboxTen.Text))
                {
                    MessageBox.Show("Họ tên không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbVaiTro.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng NguoiDung từ dữ liệu nhập
                CHTL.Models.NguoiDung nd = new CHTL.Models.NguoiDung
                {
                    MaNguoiDung = textboxID.Text.Trim(),
                    TenDangNhap = textboxTenDangNhap.Text.Trim(),
                    MatKhau = textboxMatKhau.Text.Trim(),
                    VaiTro = cbVaiTro.SelectedItem.ToString(),
                    HoTen = textboxTen.Text.Trim()
                };

                // Gọi phương thức thêm người dùng
                xuLy.ThemNguoiDung(nd);

                // Thông báo thành công
                MessageBox.Show("Thêm người dùng thành công!", "Thành công",
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