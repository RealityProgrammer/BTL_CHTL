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
    public partial class FormNhanVien : KryptonForm {
        private bool _logout;
        
        public FormNhanVien()
        {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
            FormBanHangView formBanHang = new FormBanHangView();
            ShowFormInPanel(formBanHang);
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
            // FormSanPhamView formSanPham = new FormSanPhamView();
            // ShowFormInPanel(formSanPham);
        }

        private void btn_ban_hang_Click(object sender, EventArgs e)
        {
            FormBanHangView formBanHang = new FormBanHangView();
            ShowFormInPanel(formBanHang);
        }

        private void btn_bao_cao_Click(object sender, EventArgs e)
        {
            FormBaoCaoView formBaoCao = new FormBaoCaoView();
            ShowFormInPanel(formBaoCao);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            _logout = true;
            Close();
        }
        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e) {
            if (_logout) {
                Program.LoginForm.Show();
            } else if (e.CloseReason == CloseReason.UserClosing) {
                Program.LoginForm.Close();
            }
        }
    }
}
