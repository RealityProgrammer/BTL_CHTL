using CHTL.BUS;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.NguoiDung {
    public partial class FormNguoiDungEdit : KryptonForm {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();
        private Models.NguoiDung nguoiDungEdit;

        public Models.NguoiDung NguoiDungEdit {
            get => nguoiDungEdit;
            set {
                nguoiDungEdit = value;
                NhapDuLieu();
            }
        }
        
        public FormNguoiDungEdit() {
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

        private void NhapDuLieu() {
            Console.WriteLine("Password: " + nguoiDungEdit.MatKhau);
            
            if (nguoiDungEdit != null)
            {
                textboxID.Text = nguoiDungEdit.MaNguoiDung;
                textboxTenDangNhap.Text = nguoiDungEdit.TenDangNhap;
                textboxMatKhau.Text = nguoiDungEdit.MatKhau; // Hiển thị mật khẩu nhưng không cho sửa
                cbVaiTro.SelectedItem = nguoiDungEdit.VaiTro; // Chọn vai trò tương ứng
                textboxTen.Text = nguoiDungEdit.HoTen;
            }
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
                nguoiDungEdit.MaNguoiDung = textboxID.Text.Trim();
                nguoiDungEdit.TenDangNhap = textboxTenDangNhap.Text.Trim();
                nguoiDungEdit.VaiTro = cbVaiTro.SelectedItem.ToString();
                nguoiDungEdit.HoTen = textboxTen.Text.Trim();

                // Gọi phương thức thêm người dùng
                xuLy.SuaNguoiDung(nguoiDungEdit);

                // Thông báo thành công
                MessageBox.Show("Sửa người dùng thành công!", "Thành công",
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
        
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}