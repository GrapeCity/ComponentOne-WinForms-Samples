using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using C1.Win.Editor;
using C1.Win.Ribbon;

namespace EditorExplorer.Samples
{
    using Data;
    using System.Threading.Tasks;

    public partial class Chat : UserControl
    {
        private const string _chatInputPath = @"Resources\ChatInput.html";
        private const string _chatViewPath = @"Resources\ChatView.html";
        private const string _messageFormat = "<div class=\"row\"><span class=\"{0}\"><b>{1}</b>&nbsp;&nbsp;&nbsp;<span class=\"dim\">{2}</span><br>{3}</span></div><span id=\"NewLine\"/>";
        private const string _newLineId = "NewLine";

        private Random _random = new Random();
        private SimpleBot _bot = new SimpleBot();

        public Chat()
        {
            InitializeComponent();

            c1EditorView.BorderStyle = BorderStyle.None;
            c1EditorView.ClientSizeChanged += C1Editor1_Resize;
            c1EditorView.SizeChanged += C1Editor1_Resize;

            c1EditorInput.BorderStyle = BorderStyle.None;
            c1EditorInput.ClientSizeChanged += C1Editor1_Resize;
            c1EditorInput.SizeChanged += C1Editor1_Resize;

            Color backColor = panel1.BackColor;
            c1EditorRibbon1.RibbonStyle.ColorSet[StyleColor.TabBorder] = backColor;
            c1EditorRibbon1.RibbonStyle.BrushSet.SetColor(StyleBrush.TabBackground2, backColor);
        }
        private void C1Editor1_Resize(object sender, EventArgs e)
        {
            (sender as C1Editor).Focus();
        }

        private async Task ShowAnswerAsync(string promptText)
        {
            // Get and show Bot's answer.
            IList<string> answers = _bot.Prompt(promptText);
            if (answers.Count > 0)
            {
                int index = _random.Next(answers.Count);
                string message = string.Format(_messageFormat, "incoming", "Bot", DateTime.Now.ToShortTimeString(), answers[index]);
                await c1EditorView.ReplaceElementAsync(message, _newLineId);
            }
        }

        private async Task SendPromptAsync()
        {
            string promptText = c1EditorInput.Text;

            // Show user message in chat view.
            string html = await c1EditorInput.GetInnerHTMLAsync();
            if (string.IsNullOrEmpty(html))
                return;
            string message = string.Format(_messageFormat, "outgoing", "You", DateTime.Now.ToShortTimeString(), html);
            await c1EditorView.ReplaceElementAsync(message, _newLineId);

            // Clear Input view.
            await c1EditorInput.RemoveElementAsync(null, "body");

            // Get and show Bot's answer.
            await ShowAnswerAsync(promptText);
        }

        private async Task LoadDocumentAsync(C1Editor editor, string filename)
        {
            if (File.Exists(filename))
            {
                await editor.LoadDocumentAsync(Path.GetFullPath(filename));
                await editor.SetDefaultStylesAsync(null, true);
            }
        }

        private async void c1EditorView_C1EditorReadyAsync(object sender, EventArgs e)
        {
            await LoadDocumentAsync(c1EditorView, _chatViewPath);
        }

        private async void c1EditorInput_C1EditorReadyAsync(object sender, EventArgs e)
        {
            await LoadDocumentAsync(c1EditorInput, _chatInputPath);
        }

        private async void c1EditorInput_KeyDownAsync(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers != Keys.Shift)
                await SendPromptAsync();
        }

        private void c1EditorInput_SizeChanged(object sender, EventArgs e)
        {
            RoundedRectangle.SetRoundedCorners(c1EditorInput, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1EditorRibbon1.Minimized = !c1EditorRibbon1.Minimized;
        }

        private async void ribbonButton1_ClickAsync(object sender, EventArgs e)
        {
            // Show emoji dialog.
            using (var form = new EmojiForm())
            {
                form.Location = c1EditorRibbon1.Parent.PointToScreen(new Point(c1EditorRibbon1.Location.X, c1EditorRibbon1.Location.Y - form.Height)); //PointToScreen(button1.Location);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await c1EditorInput.PasteFragmentAsync(form.EmojiCode);
                }
            }
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            await SendPromptAsync();
        }
    }
}