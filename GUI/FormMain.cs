using CHTL.GUI.AI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CHTL.GUI.BanHang;
using CHTL.GUI.BaoCao;
using CHTL.GUI.DanhMuc;
using CHTL.GUI.NguoiDung;
using CHTL.GUI.SanPham;
using Krypton.Toolkit;
using CHTL.Models.Auth;

namespace CHTL.GUI
{
    public partial class FormMain : KryptonForm
    {
        private KryptonButton currentActiveButton;

        public FormMain()
        {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
            SetupButtonHover();
            FormBanHangView formBanHang = new FormBanHangView();
            ShowFormInPanel(formBanHang, btnBanHang);
        }

        private void ShowFormInPanel(KryptonForm childForm, KryptonButton activeButton = null)
        {
            kryptonPanel2.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            kryptonPanel2.Controls.Add(childForm);
            kryptonPanel2.Tag = childForm;
            childForm.Show();

            // Cập nhật trạng thái active cho nút
            if (currentActiveButton != null)
            {
                ResetButtonStyle(currentActiveButton);
            }
            if (activeButton != null)
            {
                SetActiveButtonStyle(activeButton);
                currentActiveButton = activeButton;
            }
        }

        private void SetupButtonHover()
        {
            var buttons = new[] { btnNguoiDung, btnDanhMuc, btnSanPham, btnBanHang, btnBaoCao, btnAITips, btnDangXuat };
            foreach (var btn in buttons)
            {
                btn.MouseEnter += (s, e) =>
                {
                    if (btn != currentActiveButton)
                    {
                        btn.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
                        btn.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
                        btn.StateCommon.Content.ShortText.Color1 = Color.White;
                    }
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (btn != currentActiveButton)
                    {
                        ResetButtonStyle(btn);
                    }
                };
            }

            // Đặc biệt cho btnDangXuat
            btnDangXuat.MouseEnter += (s, e) =>
            {
                btnDangXuat.StateCommon.Back.Color1 = Color.FromArgb(192, 57, 43); // Đỏ đậm
                btnDangXuat.StateCommon.Back.Color2 = Color.FromArgb(192, 57, 43);
                btnDangXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            };
            btnDangXuat.MouseLeave += (s, e) =>
            {
                btnDangXuat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                btnDangXuat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
                btnDangXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            };
        }

        private void SetActiveButtonStyle(KryptonButton btn)
        {
            btn.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            btn.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btn.StateCommon.Content.ShortText.Color1 = Color.White;
        }

        private void ResetButtonStyle(KryptonButton btn)
        {
            if (btn == btnDangXuat)
            {
                btn.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                btn.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
                btn.StateCommon.Content.ShortText.Color1 = Color.White;
            }
            else
            {
                btn.StateCommon.Back.Color1 = Color.White;
                btn.StateCommon.Back.Color2 = Color.White;
                btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            }
        }

        private void btn_nguoi_dung_Click(object sender, EventArgs e)
        {
            FormNguoiDungView formNguoiDung = new FormNguoiDungView();
            ShowFormInPanel(formNguoiDung, btnNguoiDung);
        }

        private void btn_danh_muc_Click(object sender, EventArgs e)
        {
            FormDanhMucView formDanhMuc = new FormDanhMucView();
            ShowFormInPanel(formDanhMuc, btnDanhMuc);
        }

        private void btn_san_pham_Click(object sender, EventArgs e)
        {
            FormSanPhamView formSanPham = new FormSanPhamView();
            ShowFormInPanel(formSanPham, btnSanPham);
        }

        private void btn_ban_hang_Click(object sender, EventArgs e)
        {
            FormBanHangView formBanHang = new FormBanHangView();
            ShowFormInPanel(formBanHang, btnBanHang);
        }

        private void btn_bao_cao_Click(object sender, EventArgs e)
        {
            FormBaoCaoView formBaoCao = new FormBaoCaoView();
            ShowFormInPanel(formBaoCao, btnBaoCao);
        }

        private void btn_ai_tips_Click(object sender, EventArgs e)
        {
            FormChat formChat = new FormChat();
            ShowFormInPanel(formChat, btnAITips);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap formLogin = new FormDangNhap();
            formLogin.Show();
            this.Close();
        }
    }
}