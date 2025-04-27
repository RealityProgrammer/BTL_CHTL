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

namespace CHTL.GUI.Sample_Form
{
    public partial class SampleView : KryptonForm
    {
        public SampleView()
        {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
        }


        public virtual void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
