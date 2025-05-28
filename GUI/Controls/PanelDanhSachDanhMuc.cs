using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHTL.Models;
using Krypton.Toolkit;

namespace CHTL.GUI.Controls {
    public partial class PanelDanhSachDanhMuc : UserControl {
        private IReadOnlyCollection<Models.DanhMucSanPham> _danhSachDanhMuc;
        public IReadOnlyCollection<Models.DanhMucSanPham> DanhSachDanhMuc {
            get => _danhSachDanhMuc;
            set {
                _danhSachDanhMuc = value;
                TaoGuiDanhMuc();
            }
        }

        public event EventHandler DanhMucClick;

        public PanelDanhSachDanhMuc() {
            InitializeComponent();
        }

        private void TaoGuiDanhMuc() {
            flowPanel.Controls.Clear();

            ButtonDanhMucBanHang buttonAll = new ButtonDanhMucBanHang {
                Text = "Tất cả",
                Tag = null,
            };

            ConfigPalette(buttonAll, 0);

            buttonAll.Button.Click += (sender, e) => {
                DanhMucClick?.Invoke(sender, e);
            };

            flowPanel.Controls.Add(buttonAll);

            foreach (var danhMuc in _danhSachDanhMuc) {
                int index = Math.Abs(danhMuc.TenDanhMuc.GetHashCode() % GlobalPalette.ButtonBanHangPalettes.Count);
                var palette = GlobalPalette.ButtonBanHangPalettes[index];

                ButtonDanhMucBanHang button = new ButtonDanhMucBanHang {
                    Text = danhMuc.TenDanhMuc,
                    Tag = danhMuc,
                };

                ConfigPalette(button, index);

                button.Button.Click += (sender, e) => {
                    DanhMucClick?.Invoke(sender, e);
                };

                flowPanel.Controls.Add(button);
            }
        }

        private void ConfigPalette(ButtonDanhMucBanHang btn, int paletteIndex) {
            var palette = GlobalPalette.ButtonBanHangPalettes[paletteIndex];
            var button = btn.Button;

            button.StateCommon.Content.ShortText.Color1 = button.StateCommon.Content.ShortText.Color2 = palette.TextColor;
            button.StateNormal.Back.Color1 = button.StateNormal.Back.Color2 = palette.NormalColor;
            button.StateTracking.Back.Color1 = button.StateTracking.Back.Color2 = palette.HoverColor;
            button.StatePressed.Back.Color1 = button.StatePressed.Back.Color2 = palette.PressColor;
        }
    }
}
