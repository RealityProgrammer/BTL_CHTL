using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            FormNguoiDung formNguoiDung = new FormNguoiDung();
            ShowFormInPanel(formNguoiDung);
        }
    }
}
