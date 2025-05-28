using CHTL.GUI.Controls;
using Krypton.Toolkit;
using Mscc.GenerativeAI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTL.GUI.AI {
    public partial class FormChat : KryptonForm {
        private readonly GoogleAI _ai;
        private readonly GenerativeModel _model;
        private Font conversationFont;

        public FormChat() {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;

            _ai = new GoogleAI(Configurations.GetValue("AI:GeminiKey"));
            _model = _ai.GenerativeModel(Model.Gemini20Flash001);
        }

        private void TaoBongChat(bool isUserMessage, string text) {
            Size measuredSize = TextRenderer.MeasureText(text, conversationFont, new Size((int)(Width * 0.7f), 0), TextFormatFlags.WordBreak);

            var table = new KryptonTableLayoutPanel {
                StateCommon = {
                    Color1 = Color.Transparent,
                },
                Dock = DockStyle.Top,
                Margin = Padding.Empty,
                Padding = new Padding(0, 0, 0, 5),
                Size = new Size(0, measuredSize.Height + 15),
                ColumnCount = 2,
                RowCount = 1,
            };

            ColumnStyle bubbleColumn = new ColumnStyle { SizeType = SizeType.Absolute, Width = measuredSize.Width + 10, };
            ColumnStyle autosizeColumn = new ColumnStyle { SizeType = SizeType.Percent, Width = 0.3f };

            var bubble = new KryptonPanel {
                StateCommon = {
                    Color1 = isUserMessage ? Color.FromArgb(52, 152, 219) : Color.FromArgb(189, 195, 199),
                },
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 5, 0, 5),
                Padding = new Padding(5),
                Controls = {
                    new Label {
                        Dock = DockStyle.Fill,
                        BackColor = Color.Transparent,
                        ForeColor = isUserMessage ? Color.White : Color.FromArgb(44, 62, 80),
                        Text = text,
                        Font = conversationFont,
                        MaximumSize = new Size(measuredSize.Width, 0),
                        Margin = Padding = Padding.Empty,
                    },
                },
            };

            if (isUserMessage) {
                table.ColumnStyles.Add(autosizeColumn);
                table.ColumnStyles.Add(bubbleColumn);

                table.Controls.Add(bubble, 1, 0);
            } else {
                table.ColumnStyles.Add(bubbleColumn);
                table.ColumnStyles.Add(autosizeColumn);

                table.Controls.Add(bubble, 0, 0);
            }

            containerConversation.Controls.Add(table);
            table.BringToFront();

            containerConversation.ScrollControlIntoView(table);
        }

        private void btnGui_Click(object sender, EventArgs e) {
            string text = textboxTinNhan.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            TaoBongChat(true, text);
            textboxTinNhan.Clear();

            Task.Run(() => GenerateAIAnswer(text));
        }

        private async Task GenerateAIAnswer(string prompt) {
            try {
                // TODO: Access database here.
                string injectedPromp = $"You are a convinience store agent that assists employee !...!. Here is the user prompt: '{prompt}'. Answer in user's language.";
                
                GenerateContentResponse response = await _model.GenerateContent(injectedPromp);
                BeginInvoke(new Action(() => {
                    TaoBongChat(false, response.Text.Trim());
                }));
            } catch (Exception ex) {
                BeginInvoke(new Action(() => {
                    TaoBongChat(false, "Có lỗi xảy ra: " + ex.Message);
                }));
            }
        }

        private void FormChat_Load(object sender, EventArgs e) {
            conversationFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);

            TaoBongChat(false, "Xin chào! Tôi là trợ lý AI của cửa hàng. Tôi có thể giúp gì cho bạn hôm nay?");
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e) {
            Debug.WriteLine("FormChat_FormClosing.");
            conversationFont.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}