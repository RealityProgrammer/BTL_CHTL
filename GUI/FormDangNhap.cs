using System;
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

            if (string.IsNullOrEmpty(taiKhoan) || taiKhoan == "Nhập tài khoản..." ||
                string.IsNullOrEmpty(matKhau) || matKhau == "Nhập mật khẩu...")
            {
                ShowErrorMessage("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            CHTL.Models.NguoiDung nguoiDung = xuLy.DangNhap(taiKhoan, matKhau);
            if (nguoiDung != null)
            {
                Models.Auth.Session.MaNguoiDung = nguoiDung.MaNguoiDung;
                switch (nguoiDung.VaiTro)
                {
                    case "Admin":
                        FormMain formMain = new FormMain();
                        formMain.Show();
                        Hide();
                        break;
                    case "NhanVien":
                        FormNhanvien formNhanVien = new FormNhanvien();
                        formNhanVien.Show();
                        Hide();
                        break;
                    default:
                        ShowErrorMessage("Vai trò không hợp lệ!");
                        break;
                }
            }
            else
            {
                ShowErrorMessage("Tài khoản hoặc mật khẩu không đúng!");
            }
        }
        

        private void ShowErrorMessage(string message) {
            KryptonMessageBox.Show(message, "Lỗi đăng nhập", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, KryptonMessageBoxDefaultButton.Button1, 0, null, false, null);
        }
        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}