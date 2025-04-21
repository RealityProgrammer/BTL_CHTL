using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CHTL.GUI.BaoCao {
    public partial class FormChiTietHoaDonView : KryptonForm {
        public IReadOnlyList<Models.SanPhamBan> SoldProducts { get; set; }
        public string ReceiptId { get; set; }
        
        public FormChiTietHoaDonView() {
            InitializeComponent();
        }
        
        private void FormChiTietHoaDonView_Load(object sender, EventArgs e) {
            labelReceiptId.Text = ReceiptId;

            for (int i = SoldProducts.Count - 1; i >= 0; i--) {
                var product = SoldProducts[i];
                
                KryptonLabel label = new KryptonLabel();
                
                label.Text = $"{i + 1}. {product.TenSanPham} x{product.SoLuong}: {product.ThanhTien.ToString(CultureInfo.CurrentCulture)}";
                label.Dock = DockStyle.Top;
                
                panelProductDetails.Controls.Add(label);
            }
        }
    }
}