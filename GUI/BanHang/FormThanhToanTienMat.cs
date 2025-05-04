using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CHTL.GUI.BanHang {
    public partial class FormThanhToanTienMat : KryptonForm {
        public FormThanhToanTienMat(decimal grandTotal) {
            InitializeComponent();

            labelTotal.Text = $"{grandTotal} VNĐ";
        }

        private void panelFooter_CancelButtonClick(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void panelFooter_SaveButtonClick(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
