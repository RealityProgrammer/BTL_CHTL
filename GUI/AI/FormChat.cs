using Krypton.Toolkit;
using Mscc.GenerativeAI;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTL.GUI.AI {
    public partial class FormChat : KryptonForm {
        private readonly GoogleAI _ai;
        private readonly GenerativeModel _model;
        private Font conversationFont;
        private bool isUserMessage = true; // Biến để phân biệt tin nhắn người dùng và AI

        public FormChat() {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;

            _ai = new GoogleAI(Configurations.GetValue("AI:GeminiKey"));
            _model = _ai.GenerativeModel(Model.Gemini20Flash001);

            LoadConversation();
            CustomizeForm();
        }

        private void CustomizeForm() {
            // Cập nhật màu sắc theo theme cửa hàng
            BackColor = Color.FromArgb(255, 255, 255); // Nền trắng

            // Container chat
            containerConversation.StateCommon.Color1 = Color.FromArgb(255, 255, 255);
            containerConversation.AutoScroll = true;

            // Panel input
            panel1.BackColor = Color.FromArgb(240, 240, 240);

            // Textbox nhập tin nhắn
            textboxTinNhan.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            textboxTinNhan.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textboxTinNhan.StateCommon.Border.Rounding = 20F;
            textboxTinNhan.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80);
            textboxTinNhan.StateCommon.Content.Font = new Font("Segoe UI", 11F);

            // Nút gửi
            btnGui.StateCommon.Back.Color1 = Color.FromArgb(46, 204, 113); // Xanh lá
            btnGui.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnGui.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            btnGui.StateCommon.Border.Rounding = 10F;
            btnGui.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGui.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Thêm avatar và tiêu đề
            AddChatHeader();
        }

        private void AddChatHeader() {
            // Panel header
            var headerPanel = new KryptonPanel {
                Height = 60,
                Dock = DockStyle.Top,
                StateCommon = {
                    Color1 = Color.FromArgb(52, 152, 219),
                },
            };

            // Avatar AI
            var avatar = new PictureBox {
                //Image = Properties.Resources.AIAvatar, // Thêm hình ảnh vào Resources
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(40, 40),
                Location = new Point(15, 10),
            };

            // Tiêu đề
            var lblTitle = new KryptonLabel {
                Text = "Trợ lý AI Cửa Hàng Tiện Lợi",
                StateCommon = {
                    ShortText = {
                        Color1 = Color.White,
                        Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                        TextH = PaletteRelativeAlign.Near,
                    },
                },
                Location = new Point(70, 15),
                Size = new Size(300, 30),
            };

            headerPanel.Controls.Add(avatar);
            headerPanel.Controls.Add(lblTitle);
            containerConversation.Controls.Add(headerPanel);

            // Thêm lời chào ban đầu từ AI
            isUserMessage = false;
            TaoBongChat("Xin chào! Tôi là trợ lý AI của cửa hàng. Tôi có thể giúp gì cho bạn hôm nay?");
        }

        private void LoadConversation() {
            // Tải dữ liệu cuộc trò chuyện nếu có (hiện tại để trống)
        }

        private void TaoBongChat(string text) {
            Size size = TextRenderer.MeasureText(text, conversationFont, new Size((int)(Width * 0.7f), 10000));

            var panel = new KryptonPanel {
                Size = new Size(size.Width + 20, size.Height + 20), // Padding 10px mỗi bên
                Margin = new Padding(5),
                StateCommon = {
                    Color1 = isUserMessage ? Color.FromArgb(52, 152, 219) : Color.FromArgb(189, 195, 199), // Xanh dương cho người dùng, xám nhạt cho AI
                    //Border = { Color1 = Color.Transparent, DrawBorders = PaletteDrawBorders.None, Rounding = 15F }
                },
            };

            // Căn trái/phải dựa trên người gửi
            if (isUserMessage) {
                panel.Location = new Point(containerConversation.Width - panel.Width - 20, containerConversation.Controls.Count * 40 + 50);
            } else {
                panel.Location = new Point(10, containerConversation.Controls.Count * 40 + 50);
            }

            var label = new KryptonLabel {
                Text = text,
                Font = conversationFont,
                StateCommon = {
                    ShortText = {
                        Color1 = isUserMessage ? Color.White : Color.FromArgb(44, 62, 80),
                    },
                }, // Trắng cho người dùng, xám đậm cho AI
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                //TextAlign = ContentAlignment.MiddleLeft
            };

            panel.Controls.Add(label);
            containerConversation.Controls.Add(panel);

            // Tự động cuộn xuống tin nhắn mới nhất
            containerConversation.ScrollControlIntoView(panel);
        }

        private void btnGui_Click(object sender, EventArgs e) {
            string text = textboxTinNhan.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            isUserMessage = true;
            TaoBongChat(text);
            textboxTinNhan.Clear();

            Task.Run(() => GenerateAIAnswer(text));
        }

        private async Task GenerateAIAnswer(string prompt) {
            try {
                GenerateContentResponse response = await _model.GenerateContent(prompt);
                BeginInvoke(new Action(() => {
                    isUserMessage = false;
                    TaoBongChat(response.Text);
                }));
            } catch (Exception ex) {
                BeginInvoke(new Action(() => {
                    isUserMessage = false;
                    TaoBongChat("Có lỗi xảy ra: " + ex.Message);
                }));
            }
        }

        private void FormChat_Load(object sender, EventArgs e) {
            conversationFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e) {
            conversationFont.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}