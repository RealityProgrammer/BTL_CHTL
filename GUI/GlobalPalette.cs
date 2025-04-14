using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CHTL.GUI
{
    public static class GlobalPalette
    {
        public static KryptonCustomPaletteBase Palette { get; } = CreatePalette();
        private static KryptonCustomPaletteBase CreatePalette()
        {
            var palette = new KryptonCustomPaletteBase();

            palette.FormStyles.FormMain.StateCommon.Back.Color1 = Color.White;
            palette.FormStyles.FormMain.StateCommon.Back.Color2 = Color.White;
            palette.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            palette.FormStyles.FormMain.StateCommon.Border.DrawBorders =
                PaletteDrawBorders.All;
            
            palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.MediumSlateBlue;
            palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.MediumSlateBlue;
            palette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            
            return palette;
        }
    }
}
