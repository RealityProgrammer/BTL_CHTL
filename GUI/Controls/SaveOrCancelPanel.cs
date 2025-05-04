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
    public partial class SaveOrCancelPanel : UserControl {
        public event EventHandler SaveButtonClick {
            add => btnSave.Click += value;
            remove => btnSave.Click -= value;
        }

        public event EventHandler CancelButtonClick {
            add => btnCancel.Click += value;
            remove => btnCancel.Click -= value;
        }

        public KryptonButton SaveButton => btnSave;
        public KryptonButton CancelButton => btnCancel;

        public SaveOrCancelPanel()
        {
            InitializeComponent();
        }
    }
}
