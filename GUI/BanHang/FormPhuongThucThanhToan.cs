using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.BanHang {
    public partial class FormPhuongThucThanhToan : KryptonForm {
        private readonly decimal grandTotal;

        private readonly string maHoaDon;

        public FormPhuongThucThanhToan(string maHoaDon, decimal grandTotal) {
            InitializeComponent();

            this.maHoaDon = maHoaDon;
            this.grandTotal = grandTotal;
        }
        public KryptonForm PaymentForm { get; private set; }

        private void btnQR_Click(object sender, EventArgs e) {
            PaymentForm = new FormThanhToanQR(maHoaDon, grandTotal);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCash_Click(object sender, EventArgs e) {
            PaymentForm = new FormThanhToanTienMat(grandTotal);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}