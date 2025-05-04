using Krypton.Toolkit;
using System.Windows.Forms;

namespace CHTL.GUI.BanHang {
    public partial class FormPhuongThucThanhToan : KryptonForm {
        public KryptonForm PaymentForm { get; private set; }

        private readonly string maHoaDon;
        private readonly decimal grandTotal;

        public FormPhuongThucThanhToan(string maHoaDon, decimal grandTotal) {
            InitializeComponent();

            this.maHoaDon = maHoaDon;
            this.grandTotal = grandTotal;
        }

        private void btnQR_Click(object sender, System.EventArgs e) {
            PaymentForm = new FormThanhToanQR(maHoaDon, grandTotal);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCash_Click(object sender, System.EventArgs e) {
            PaymentForm = new FormThanhToanTienMat(grandTotal);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}