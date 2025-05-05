using System.Windows.Forms;
using Krypton.Toolkit;

namespace CHTL.GUI.Controls {
    public partial class SanPhamBanHang : UserControl {
        public KryptonButton AddButton => btnAdd;

        public Models.SanPham SanPham {
            get => Tag as Models.SanPham;
            set {
                ConfigGui(value);
                Tag = value;
            }
        }

        public SanPhamBanHang() {
            InitializeComponent();
        }

        private void ConfigGui(Models.SanPham sanPham) {
            labelName.Text = sanPham.TenSanPham;
            labelPrice.Text = $"Giá: {sanPham.GiaBanCuoiCung}";
            labelInventory.Text = $"Tồn kho: {sanPham.SoLuongTon}";
        }
    }
}
