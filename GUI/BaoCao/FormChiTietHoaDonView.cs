using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CHTL.GUI.BaoCao
{
    public partial class FormChiTietHoaDonView : KryptonForm
    {
        public IReadOnlyList<Models.SanPhamBan> SoldProducts { get; set; }
        public string ReceiptId { get; set; }

        public FormChiTietHoaDonView()
        {
            InitializeComponent();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            this.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt

            // Tùy chỉnh KryptonPanel1
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            //kryptonPanel1.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            //kryptonPanel1.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            //kryptonPanel1.StateCommon.Border.Rounding = 10F;

            // Tùy chỉnh labelReceiptId
            labelReceiptId.StateCommon.ShortText.Color1 = Color.White;
            labelReceiptId.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            // Tùy chỉnh panelProductDetails
            panelProductDetails.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            panelProductDetails.AutoScroll = true;
        }

        private void FormChiTietHoaDonView_Load(object sender, EventArgs e)
        {
            labelReceiptId.Text = $"Mã hóa đơn: {ReceiptId}";

            // Thêm tiêu đề phụ
            KryptonLabel lblTitle = new KryptonLabel
            {
                Location = new Point(10, 10),
                Size = new Size(560, 30),
                StateCommon = { ShortText = { Color1 = Color.FromArgb(44, 62, 80), Font = new Font("Segoe UI", 12F, FontStyle.Bold) } },
                Text = "Danh Sách Sản Phẩm"
            };
            panelProductDetails.Controls.Add(lblTitle);

            // Thêm danh sách sản phẩm
            for (int i = 0; i < SoldProducts.Count; i++)
            {
                var product = SoldProducts[i];
                KryptonLabel label = new KryptonLabel
                {
                    Location = new Point(10, 50 + i * 40),
                    Size = new Size(560, 30),
                    //StateCommon = {
                    //    ShortText = { Color1 = Color.FromArgb(44, 62, 80), Font = new Font("Segoe UI", 11F) },
                    //    Back = { Color1 = Color.White },
                    //    Border = { Color1 = Color.FromArgb(189, 195, 199), DrawBorders = PaletteDrawBorders.All, Rounding = 5F }
                    //},
                    Text = $"{i + 1}. {product.TenSanPham} x{product.SoLuong}: {product.ThanhTien:N0} VNĐ"
                };

                // Hiệu ứng hover
                label.MouseEnter += (s, args) =>
                {
                    //label.StateCommon.Back.Color1 = Color.FromArgb(247, 249, 250); // Xám rất nhạt
                    label.StateCommon.ShortText.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
                };
                label.MouseLeave += (s, args) =>
                {
                    //label.StateCommon.Back.Color1 = Color.White;
                    label.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                };

                panelProductDetails.Controls.Add(label);
            }

            // Thêm tổng cộng
            decimal totalAmount = SoldProducts.Sum(p => p.ThanhTien);
            KryptonLabel lblTotal = new KryptonLabel
            {
                Location = new Point(10, 50 + SoldProducts.Count * 40 + 20),
                Size = new Size(560, 30),
                StateCommon = {
                    ShortText = { Color1 = Color.FromArgb(52, 152, 219), Font = new Font("Segoe UI", 12F, FontStyle.Bold) },
                    //Back = { Color1 = Color.FromArgb(236, 240, 241) }
                },
                Text = $"Tổng cộng: {totalAmount:N0} VNĐ"
            };
            panelProductDetails.Controls.Add(lblTotal);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}