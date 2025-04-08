﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHTL.GUI.DanhMuc;
using CHTL.GUI.NguoiDung;
using ComponentFactory.Krypton.Toolkit;

namespace CHTL.GUI
{
    public partial class FormMain : KryptonForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.Palette = GlobalPalette.Palette;
            this.PaletteMode = PaletteMode.Custom;
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

        private void btn_nguoi_dung_Click(object sender, EventArgs e)
        {
            FormNguoiDungView formNguoiDung = new FormNguoiDungView();
            ShowFormInPanel(formNguoiDung);
        }

        private void btn_danh_muc_Click(object sender, EventArgs e)
        {
            FormDanhMucView formDanhMuc = new FormDanhMucView();
            ShowFormInPanel(formDanhMuc);
        }

        private void btn_san_pham_Click(object sender, EventArgs e)
        {

        }

        private void btn_ban_hang_Click(object sender, EventArgs e)
        {

        }

        private void btn_bao_cao_Click(object sender, EventArgs e)
        {

        }

        private void btn_ai_tips_Click(object sender, EventArgs e)
        {

        }
    }
}
