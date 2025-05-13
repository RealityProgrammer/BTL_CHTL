using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.Controls {
    public partial class SaveOrCancelPanel : UserControl {
        public SaveOrCancelPanel() {
            InitializeComponent();
        }

        public KryptonButton SaveButton => btnSave;
        public KryptonButton CancelButton => btnCancel;

        public event EventHandler SaveButtonClick {
            add => btnSave.Click += value;
            remove => btnSave.Click -= value;
        }

        public event EventHandler CancelButtonClick {
            add => btnCancel.Click += value;
            remove => btnCancel.Click -= value;
        }
    }
}