﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using C1.Win.Editor;

namespace EditorExplorer.Samples
{
    using Data;

    public partial class Chat : UserControl
    {
        private const string _chatInputPath = @"Resources\ChatInput.html";
        private const string _chatViewPath = @"Resources\ChatView.html";
        private const string _messageFormat = "<div class=\"row\"><span class=\"{0}\"><b>{1}</b>&nbsp;&nbsp;&nbsp;<span class=\"dim\">{2}</span><br>{3}</span></div><span id=\"NewLine\"/>";
        private const string _newLineId = "NewLine";

        private List<string> _questions = new List<string>();
        private Random _random = new Random();
        private SimpleBot _bot = new SimpleBot();

        public Chat()
        {
            InitializeComponent();

            c1EditorView.BorderStyle = BorderStyle.None;
            c1EditorInput.BorderStyle = BorderStyle.None;
        }

        private void ShowAnswer(string promptText)
        {
            // Get and show Bot's answer.
            IList<string> answers = _bot.Prompt(promptText);
            if (answers.Count > 0)
            {
                int index = _random.Next(answers.Count);
                string message = string.Format(_messageFormat, "incoming", "Bot", DateTime.Now.ToShortTimeString(), answers[index]);
                c1EditorView.ReplaceElement(message, _newLineId);
            }
        }

        private void SendPrompt()
        {
            string promptText = c1EditorInput.GetText();
            if (string.IsNullOrEmpty(promptText))
                return;
            _questions.Add(promptText);

            // Show user message in chat view.
            string message = string.Format(_messageFormat, "outgoing", "You", DateTime.Now.ToShortTimeString(), promptText);
            c1EditorView.ReplaceElement(message, _newLineId);

            // Clear Input view.
            c1EditorInput.RemoveElement(null, "body");

            // Get and show Bot's answer.
            ShowAnswer(promptText);
        }

        private void LoadDocument(C1Editor editor, string filename)
        {
            if (File.Exists(filename))
            {
                editor.LoadDocument(Path.GetFullPath(filename));
                editor.SetDefaultStyles(null, true);
            }
        }

        private void c1EditorView_C1EditorReady(object sender, EventArgs e)
        {
            LoadDocument(c1EditorView, _chatViewPath);
        }

        private void c1EditorInput_C1EditorReady(object sender, EventArgs e)
        {
            LoadDocument(c1EditorInput, _chatInputPath);
        }

        private void c1EditorInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers != Keys.Shift)
                SendPrompt();
        }

        private void c1EditorInput_SizeChanged(object sender, EventArgs e)
        {
            RoundedRectangle.SetRoundedCorners(c1EditorInput, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show emoji dialog.
            using (var form = new EmojiForm())
            {
                form.Location = c1EditorInput.Parent.PointToScreen(new Point(c1EditorInput.Location.X, c1EditorInput.Location.Y - form.Height)); //PointToScreen(button1.Location);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    c1EditorInput.PasteFragment(form.EmojiCode);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendPrompt();
        }
    }
}