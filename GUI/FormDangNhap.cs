using CHTL.BUS;
using CHTL.Models.Auth;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI {
    public partial class FormDangNhap : KryptonForm {
        private readonly XuLyNguoiDung xuLy = new XuLyNguoiDung();

        public FormDangNhap() {
            InitializeComponent();
        }

        private void btn_dang_nhap_Click(object sender, EventArgs e) {
            string taiKhoan = textboxTaiKhoan.Text.Trim();
            string matKhau = textboxMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || taiKhoan == "Nhập tài khoản..." ||
                string.IsNullOrEmpty(matKhau) || matKhau == "Nhập mật khẩu...") {
                ShowErrorMessage("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            Models.NguoiDung nguoiDung = xuLy.DangNhap(taiKhoan, matKhau);

            if (nguoiDung != null) {
                Session.MaNguoiDung = nguoiDung.MaNguoiDung;

                switch (nguoiDung.VaiTro) {
                    case "Admin":
                        var formMain = new FormMain();
                        formMain.Show();
                        Hide();
                        break;

                    case "NhanVien":
                        var formNhanVien = new FormNhanVien();
                        formNhanVien.Show();
                        Hide();
                        break;

                    default:
                        ShowErrorMessage("Vai trò không hợp lệ!");
                        break;
                }
            } else {
                ShowErrorMessage("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ShowErrorMessage(string message) {
            KryptonMessageBox.Show(message, "Lỗi đăng nhập", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
        }

        private void txt_mat_khau_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btn_dang_nhap_Click(sender, e);
            }
        }
    }
}