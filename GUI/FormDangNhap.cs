using System.Windows.Forms;
using CHTL.BUS;
using Krypton.Toolkit;
using CHTL.Models;

namespace CHTL.GUI {
    public partial class FormDangNhap : KryptonForm
    {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dang_nhap_Click(object sender, System.EventArgs e)
        {
            string taiKhoan = textboxTaiKhoan.Text.Trim();
            string matKhau = textboxMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                ShowErrorMessage("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            CHTL.Models.NguoiDung nguoiDung = xuLy.DangNhap(taiKhoan, matKhau);
            if (nguoiDung != null)
            {
                this.Hide();
                if (nguoiDung.VaiTro == "Admin")
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();

                }
                else if (nguoiDung.VaiTro == "NhanVien")
                {
                    FormNhanVien formNhanVien = new FormNhanVien();
                    formNhanVien.Show();
                }
                else
                {
                    ShowErrorMessage("Vai trò không hợp lệ!");
                    this.Show();
                }
            }
            else
            {
                ShowErrorMessage("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void ShowErrorMessage(string message) {
            KryptonMessageBox.Show(message, "Lỗi đăng nhập", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, KryptonMessageBoxDefaultButton.Button1, 0, null, false, null);
            // KryptonMessageBox.Show(message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error); // Removed showCtrlCopy parameter
        }

        private void txt_mat_khau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dang_nhap_Click(sender, e);
            }
        }
    }
}