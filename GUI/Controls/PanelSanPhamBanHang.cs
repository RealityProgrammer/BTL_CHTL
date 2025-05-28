using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using CHTL.Models;
using Krypton.Toolkit;

namespace CHTL.GUI.Controls {
    public partial class PanelSanPhamBanHang : UserControl {
        public KryptonButton ButtonQuayLai => btnQuayLai;

        public string TenDanhMuc {
            get => labelDanhMuc.Text;
            set => labelDanhMuc.Text = value;
        }

        private IReadOnlyCollection<Models.SanPham> _danhSachSanPham;
        public IReadOnlyCollection<Models.SanPham> DanhSachSanPham {
            get => _danhSachSanPham;
            set {
                _danhSachSanPham = value;
                TaoGuiSanPham();
            }
        }

        public event EventHandler ThemSanPhamClick;

        public PanelSanPhamBanHang() {
            InitializeComponent();
            _danhSachSanPham = Array.Empty<Models.SanPham>();
        }

        private void TaoGuiSanPham() {
            flpContent.Controls.Clear();

            foreach (var sanPham in _danhSachSanPham) {
                SanPhamBanHang sp = new SanPhamBanHang {
                    SanPham = sanPham,
                };
                sp.AddButton.Click += (sender, e) => {
                    ThemSanPhamClick?.Invoke(sender, e);
                };

                flpContent.Controls.Add(sp);
            }
        }
    }
}
