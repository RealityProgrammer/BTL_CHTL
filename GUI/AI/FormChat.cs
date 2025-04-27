using Krypton.Toolkit;
using Mscc.GenerativeAI;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTL.GUI.AI {
    public partial class FormChat : KryptonForm {
        // private static readonly KryptonCustomPaletteBase _messageBubblePalette;
        private Font conversationFont;

        private GoogleAI _ai;
        private GenerativeModel _model;

        static FormChat() {
            // _messageBubblePalette = new KryptonCustomPaletteBase();
            // _messageBubblePalette.PanelStyles.PanelCommon.StateCommon.Color1 = Color.Red;
        }
        
        public FormChat() {
            InitializeComponent();

            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
            
            _ai = new GoogleAI(Configurations.GetValue("AI:GeminiKey"));
            _model = _ai.GenerativeModel(Model.Gemini20Flash001);
            
            LoadConversation();
        }

        private void LoadConversation() {
            // for (int i = 0; i < 100; i++) {
            //     TaoBongChat(i.ToString());
            // }
        }

        private void TaoBongChat(string text) {
            // TODO: Decorate
            Size size = TextRenderer.MeasureText(text, conversationFont, new Size((int)(Width * 0.75f), 10000));
            
            KryptonPanel panel = new KryptonPanel();
            panel.Dock = DockStyle.Bottom;
            panel.Height = size.Height;
            
            KryptonLabel label = new KryptonLabel();
            label.Text = text;
            label.Font = conversationFont;
            label.ForeColor = Color.Black;
            label.Dock = DockStyle.Fill;
            
            panel.Controls.Add(label);
            
            containerConversation.Controls.Add(panel);
        }
        
        private void btnGui_Click(object sender, EventArgs e) {
            string text = textboxTinNhan.Text;
            if (string.IsNullOrEmpty(text)) return;
            
            TaoBongChat(text);
            textboxTinNhan.Clear();

            Task.Run(() => GenerateAIAnswer(text));
        }

        private async Task GenerateAIAnswer(string prompt) {
            var response = await _model.GenerateContent(prompt);
            BeginInvoke(new Action(() => TaoBongChat(response.Text)));
        }
        
        private void FormChat_Load(object sender, EventArgs e) {
            conversationFont = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
        }
        
        private void FormChat_FormClosing(object sender, FormClosingEventArgs e) {
            conversationFont.Dispose();
        }
    }
}