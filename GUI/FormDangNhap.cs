using System;
using System.Windows.Forms;
using CHTL.BUS;
using Krypton.Toolkit;
using CHTL.Models;
using System.Drawing;

namespace CHTL.GUI
{
    public partial class FormDangNhap : KryptonForm
    {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();

        public FormDangNhap()
        {
            InitializeComponent();
            SetupPlaceholder();
            SetupButtonHover();
        }

        private void SetupPlaceholder()
        {
            // Placeholder cho textboxTaiKho TaiKhoan
            textboxTaiKhoan.Text = "Nhập tài khoản...";
            textboxTaiKhoan.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166); // Xám nhạt
            textboxTaiKhoan.Enter += (s, e) =>
            {
                if (textboxTaiKhoan.Text == "Nhập tài khoản...")
                {
                    textboxTaiKhoan.Text = "";
                    textboxTaiKhoan.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                }
            };
            textboxTaiKhoan.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textboxTaiKhoan.Text))
                {
                    textboxTaiKhoan.Text = "Nhập tài khoản...";
                    textboxTaiKhoan.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166);
                }
            };

            // Placeholder cho textboxMatKhau
            textboxMatKhau.Text = "Nhập mật khẩu...";
            textboxMatKhau.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166);
            textboxMatKhau.UseSystemPasswordChar = false; // Tạm tắt password char
            textboxMatKhau.Enter += (s, e) =>
            {
                if (textboxMatKhau.Text == "Nhập mật khẩu...")
                {
                    textboxMatKhau.Text = "";
                    textboxMatKhau.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80);
                    textboxMatKhau.UseSystemPasswordChar = true;
                }
            };
            textboxMatKhau.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textboxMatKhau.Text))
                {
                    textboxMatKhau.Text = "Nhập mật khẩu...";
                    textboxMatKhau.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166);
                    textboxMatKhau.UseSystemPasswordChar = false;
                }
            };
        }

        private void SetupButtonHover()
        {
            // Hover cho btnDangNhap
            btnDangNhap.MouseEnter += (s, e) =>
            {
                btnDangNhap.StateCommon.Back.Color1 = Color.FromArgb(41, 128, 185); // Xanh đậm
                btnDangNhap.StateCommon.Back.Color2 = Color.FromArgb(41, 128, 185);
            };
            btnDangNhap.MouseLeave += (s, e) =>
            {
                btnDangNhap.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
                btnDangNhap.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            };

            // Hover cho btnHuy
            btnHuy.MouseEnter += (s, e) =>
            {
                btnHuy.StateCommon.Back.Color1 = Color.FromArgb(192, 57, 43); // Đỏ đậm
                btnHuy.StateCommon.Back.Color2 = Color.FromArgb(192, 57, 43);
            };
            btnHuy.MouseLeave += (s, e) =>
            {
                btnHuy.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                btnHuy.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            };
        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
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
                this.Hide();
                switch (nguoiDung.VaiTro)
                {
                    case "Admin":
                        FormMain formMain = new FormMain();
                        formMain.Show();
                        break;
                    case "NhanVien":
                        FormNhanVien formNhanVien = new FormNhanVien();
                        formNhanVien.Show();
                        break;
                    default:
                        ShowErrorMessage("Vai trò không hợp lệ!");
                        this.Show();
                        break;
                }
            }
            else
            {
                ShowErrorMessage("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowErrorMessage(string message)
        {
            KryptonMessageBox.Show(message, "Lỗi đăng nhập", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
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