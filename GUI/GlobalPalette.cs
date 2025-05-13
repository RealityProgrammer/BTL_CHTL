using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace CHTL.GUI {
    public static class GlobalPalette {
        public static KryptonCustomPaletteBase Palette { get; } = CreatePalette();
        private static KryptonCustomPaletteBase CreatePalette() {
            var palette = new KryptonCustomPaletteBase();

            // Màu nền form
            palette.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            palette.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(236, 240, 241); // Xám nhạt

            // Viền form
            palette.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám trung bình
            palette.FormStyles.FormMain.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199); // Xám trung bình
            palette.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            palette.FormStyles.FormMain.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

            // Màu header form
            palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219); // Xanh dương
            palette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.White; // Chữ trắng
            palette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1); // Giữ padding hiện tại

            return palette;
        }
    }
}