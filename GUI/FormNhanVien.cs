using CHTL.GUI.AI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHTL.GUI.BanHang;
using CHTL.GUI.BaoCao;
using CHTL.GUI.DanhMuc;
using CHTL.GUI.NguoiDung;
using CHTL.GUI.SanPham;
using Krypton.Toolkit;

namespace CHTL.GUI
{
    public partial class FormNhanVien : KryptonForm
    {
        private KryptonButton activeButton = null; // Theo dõi nút đang được chọn

        public FormNhanVien()
        {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
            FormBanHangView formBanHang = new FormBanHangView();
            ShowFormInPanel(formBanHang);
            SetActiveButton(btnBanHang); // Đặt nút "Bán Hàng" là mặc định
            CustomizeComponents();
        }

        private void CustomizeComponents()
        {
            // Tùy chỉnh giao diện các nút
            CustomizeButton(btnSanPham);
            CustomizeButton(btnBanHang);
            CustomizeButton(btnBaoCao);
            CustomizeButton(btnDangXuat, isLogoutButton: true);

            // Tùy chỉnh màu nền
            this.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(236, 240, 241); // Xám nhạt
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(236, 240, 241); // Xám nhạt

            // Tùy chỉnh font và màu chữ cho nhãn
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
           
        }

        private void CustomizeButton(KryptonButton button, bool isLogoutButton = false)
        {
            // Màu sắc mặc định
            Color normalColor = isLogoutButton ? Color.FromArgb(243, 156, 18) : Color.FromArgb(52, 152, 219); // Cam nhạt hoặc xanh dương
            Color hoverColor = isLogoutButton ? Color.FromArgb(230, 126, 34) : Color.FromArgb(41, 128, 185); // Cam đậm hoặc xanh đậm
            Color activeColor = isLogoutButton ? Color.FromArgb(230, 126, 34) : Color.FromArgb(41, 128, 185); // Cam đậm hoặc xanh đậm

            // Cài đặt kiểu dáng nút
            button.StateCommon.Back.Color1 = normalColor;
            button.StateCommon.Back.Color2 = normalColor;
            button.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            button.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            button.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            button.StateCommon.Border.Rounding = 10F;
            button.StateCommon.Border.Width = 1;
            button.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button.StateCommon.Content.ShortText.Color1 = Color.White;

            // Hiệu ứng hover
            button.MouseEnter += (s, e) =>
            {
                if (button != activeButton)
                {
                    button.StateCommon.Back.Color1 = hoverColor;
                    button.StateCommon.Back.Color2 = hoverColor;
                }
            };
            button.MouseLeave += (s, e) =>
            {
                if (button != activeButton)
                {
                    button.StateCommon.Back.Color1 = normalColor;
                    button.StateCommon.Back.Color2 = normalColor;
                }
            };
        }

        private void SetActiveButton(KryptonButton button)
        {
            // Đặt lại màu của nút active trước đó (nếu có)
            if (activeButton != null && activeButton != button)
            {
                Color normalColor = activeButton == btnDangXuat ? Color.FromArgb(243, 156, 18) : Color.FromArgb(52, 152, 219);
                activeButton.StateCommon.Back.Color1 = normalColor;
                activeButton.StateCommon.Back.Color2 = normalColor;
            }

            // Cập nhật nút active mới
            activeButton = button;
            Color activeColor = button == btnDangXuat ? Color.FromArgb(230, 126, 34) : Color.FromArgb(41, 128, 185);
            button.StateCommon.Back.Color1 = activeColor;
            button.StateCommon.Back.Color2 = activeColor;
        }

        private void ShowFormInPanel(KryptonForm childForm)
        {
            kryptonPanel2.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            kryptonPanel2.Controls.Add(childForm);
            kryptonPanel2.Tag = childForm;
            childForm.Show();
        }

        private void btn_san_pham_Click(object sender, EventArgs e)
        {
            FormSanPhamView formSanPham = new FormSanPhamView();
            ShowFormInPanel(formSanPham);
            SetActiveButton(btnSanPham);
        }

        private void btn_ban_hang_Click(object sender, EventArgs e)
        {
            FormBanHangView formBanHang = new FormBanHangView();
            ShowFormInPanel(formBanHang);
            SetActiveButton(btnBanHang);
        }

        private void btn_bao_cao_Click(object sender, EventArgs e)
        {
            FormBaoCaoView formBaoCao = new FormBaoCaoView();
            ShowFormInPanel(formBaoCao);
            SetActiveButton(btnBaoCao);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDangXuat);
            // Hiển thị lại form đăng nhập
            FormDangNhap formLogin = new FormDangNhap();
            formLogin.Show();

            // Đóng form hiện tại (FormNhanVien)
            this.Close();
        }
    }
}