using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CHTL.GUI.BanHang {
    public partial class FormThanhToanTienMat : KryptonForm {
        private readonly decimal grandTotal;
        public FormThanhToanTienMat(decimal grandTotal) {
            InitializeComponent();
            this.grandTotal = grandTotal;
            labelTotal.Text = $"{grandTotal} VNĐ";
            lblTienThua.Text = "Tiền thừa: 0.00 VNĐ";
            txtKhachDua.TextChanged += txtKhachDua_TextChanged;
        }


        private void panelFooter_CancelButtonClick(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void panelFooter_SaveButtonClick(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e) {
            if (decimal.TryParse(txtKhachDua.Text, out decimal tienKhachDua)) {
                decimal tienThua = tienKhachDua - grandTotal;
                lblTienThua.Text = $"Tiền thừa: {tienThua:N2} VNĐ";
                lblTienThua.ForeColor = tienThua >= 0 ? Color.FromArgb(52, 152, 219) : Color.FromArgb(231, 76, 60);

                // Kiểm tra số tiền có đủ không
                if (tienKhachDua < grandTotal) {
                    lblTienThua.Text += " (Không đủ)";

                }

            } else {
                lblTienThua.Text = "Tiền thừa: 0.00 VNĐ";
                lblTienThua.ForeColor = Color.FromArgb(52, 152, 219);
            }
        }
    }
}