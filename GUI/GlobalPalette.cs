using Krypton.Toolkit;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CHTL.GUI {
    public static class GlobalPalette {
        public static KryptonCustomPaletteBase Palette { get; } = CreatePalette();
        public static IReadOnlyList<ButtonColorPalette> ButtonBanHangPalettes { get; } = CreateButtonBanHangPalettes();

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

        private static IReadOnlyList<ButtonColorPalette> CreateButtonBanHangPalettes() {
            return new List<ButtonColorPalette> {
                new ButtonColorPalette(Color.FromArgb(52, 152, 219), Color.FromArgb(41, 128, 185), Color.FromArgb(36, 111, 158), Color.White),
                new ButtonColorPalette(Color.FromArgb(255, 140, 53), Color.FromArgb(221, 122, 46), Color.FromArgb(201, 111, 42), Color.White),
                new ButtonColorPalette(Color.FromArgb(0, 226, 45), Color.FromArgb(0, 193, 35), Color.FromArgb(0, 170, 31), Color.White),
                new ButtonColorPalette(Color.FromArgb(182, 0, 255), Color.FromArgb(153, 0, 219), Color.FromArgb(128, 0, 188), Color.White),
                new ButtonColorPalette(Color.FromArgb(255, 212, 0), Color.FromArgb(204, 166, 0), Color.FromArgb(188, 150, 0), Color.White),
                new ButtonColorPalette(Color.FromArgb(112, 101, 188), Color.FromArgb(94, 81, 186), Color.FromArgb(80, 67, 186), Color.White),
            };
        }

        public readonly struct ButtonColorPalette {
            public readonly Color NormalColor;
            public readonly Color HoverColor;
            public readonly Color PressColor;
            public readonly Color TextColor;

            public ButtonColorPalette(Color normalColor, Color hoverColor, Color pressColor, Color textColor) {
                NormalColor = normalColor;
                HoverColor = hoverColor;
                PressColor = pressColor;
                TextColor = textColor;
            }
        }
    }
}