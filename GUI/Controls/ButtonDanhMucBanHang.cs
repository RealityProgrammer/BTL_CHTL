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

namespace CHTL.GUI.Controls {
    public partial class ButtonDanhMucBanHang : UserControl {
        public override string Text {
            get => button.Text;
            set => button.Text = value;
        }

        public new event EventHandler Click {
            add => button.Click += value;
            remove => button.Click -= value;
        }

        public KryptonButton Button => button;

        public ButtonDanhMucBanHang() {
            InitializeComponent();
        }
    }
}
