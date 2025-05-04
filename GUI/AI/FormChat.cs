using Krypton.Toolkit;
using Mscc.GenerativeAI;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTL.GUI.AI
{
    public partial class FormChat : KryptonForm
    {
        private Font conversationFont;
        private GoogleAI _ai;
        private GenerativeModel _model;
        private bool isUserMessage = true; // Biến để phân biệt tin nhắn người dùng và AI

        public FormChat()
        {
            InitializeComponent();
            LocalCustomPalette = CHTL.GUI.GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;

            _ai = new GoogleAI(Configurations.GetValue("AI:GeminiKey"));
            _model = _ai.GenerativeModel(Model.Gemini20Flash001);

            LoadConversation();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            this.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt

            // Tùy chỉnh containerConversation
            containerConversation.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            //containerConversation.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;

            // Tùy chỉnh panel1
            panel1.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt

            // Tùy chỉnh textboxTinNhan
            textboxTinNhan.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            textboxTinNhan.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textboxTinNhan.StateCommon.Border.Rounding = 10F;
            textboxTinNhan.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            textboxTinNhan.StateCommon.Content.Font = new Font("Segoe UI", 11F);

            // Thêm tiêu đề phụ
            KryptonLabel lblTitle = new KryptonLabel
            {
                Location = new Point(10, 10),
                Size = new Size(780, 30),
                StateCommon = { ShortText = { Color1 = Color.FromArgb(44, 62, 80), Font = new Font("Segoe UI", 12F, FontStyle.Bold) } },
                Text = "Chat Với AI"
            };
            containerConversation.Controls.Add(lblTitle);
        }

        private void LoadConversation()
        {
            // Tải dữ liệu cuộc trò chuyện nếu có (hiện tại để trống)
        }

        private void TaoBongChat(string text)
        {
            Size size = TextRenderer.MeasureText(text, conversationFont, new Size((int)(Width * 0.7f), 10000));

            KryptonPanel panel = new KryptonPanel
            {
                Size = new Size(size.Width + 20, size.Height + 20), // Padding 10px mỗi bên
                Margin = new Padding(5),
                StateCommon = {
                    Color1 = isUserMessage ? Color.FromArgb(52, 152, 219) : Color.FromArgb(189, 195, 199), // Xanh dương cho người dùng, xám nhạt cho AI
                    //Border = { Color1 = Color.Transparent, DrawBorders = PaletteDrawBorders.None, Rounding = 15F }
                }
            };

            // Căn trái/phải dựa trên người gửi
            if (isUserMessage)
            {
                panel.Location = new Point(containerConversation.Width - panel.Width - 20, containerConversation.Controls.Count * 40 + 50);
            }
            else
            {
                panel.Location = new Point(10, containerConversation.Controls.Count * 40 + 50);
            }

            KryptonLabel label = new KryptonLabel
            {
                Text = text,
                Font = conversationFont,
                StateCommon = { ShortText = { Color1 = isUserMessage ? Color.White : Color.FromArgb(44, 62, 80) } }, // Trắng cho người dùng, xám đậm cho AI
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                //TextAlign = ContentAlignment.MiddleLeft
            };

            panel.Controls.Add(label);
            containerConversation.Controls.Add(panel);

            // Tự động cuộn xuống tin nhắn mới nhất
            containerConversation.ScrollControlIntoView(panel);
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string text = textboxTinNhan.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            isUserMessage = true;
            TaoBongChat(text);
            textboxTinNhan.Clear();

            Task.Run(() => GenerateAIAnswer(text));
        }

        private async Task GenerateAIAnswer(string prompt)
        {
            try
            {
                var response = await _model.GenerateContent(prompt);
                BeginInvoke(new Action(() =>
                {
                    isUserMessage = false;
                    TaoBongChat(response.Text);
                }));
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    isUserMessage = false;
                    TaoBongChat("Có lỗi xảy ra: " + ex.Message);
                }));
            }
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            conversationFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            conversationFont.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}