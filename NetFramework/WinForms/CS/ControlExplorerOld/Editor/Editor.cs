using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ControlExplorer.Editor
{
    public partial class Editor : C1DemoForm
    {
        ToolStripButton _btnShowErrors;
        ToolStripButton _btnSpell;
        ToolStripButton _btnWordCount;

        public Editor()
        {
            InitializeComponent();
            AddProperty("Mode", C1Editor1);
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            C1Editor1.LoadXml(ControlExplorer.Properties.Resources.tesla, null);

            // add custom buttons for proofing
            C1EditorToolStripMain1.Items.Add(new ToolStripSeparator());
            _btnShowErrors = new ToolStripButton("Show Spelling Errors", imageList1.Images["ShowErrors_small.png"]);
            _btnShowErrors.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _btnShowErrors.Click += new EventHandler(_btnShowErrors_Click);
            _btnSpell = new ToolStripButton("Spell-Check", imageList1.Images["Spelling_small.png"]);
            _btnSpell.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _btnSpell.Click += new EventHandler(_btnSpell_Click);
            _btnWordCount = new ToolStripButton("Word Count", imageList1.Images["WordCount_small.png"]);
            _btnWordCount.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _btnWordCount.Click += new EventHandler(_btnWordCount_Click);
            C1EditorToolStripMain1.Items.Add(_btnShowErrors);
            C1EditorToolStripMain1.Items.Add(_btnSpell);
            C1EditorToolStripMain1.Items.Add(_btnWordCount);

        }

        void _btnWordCount_Click(object sender, EventArgs e)
        {
            var text = C1Editor1.Text;
            int chars = 0;
            int nonSpaceChars = 0;
            int words = 0;
            int paragraphs = 0;
            int sentences = 0;

            int length = text.Length;

            // calculate statistics
            for (int i = 0; i < length; i++)
            {
                char c = text[i];

                // count chars
                chars++;

                // count non-space chars
                if (!char.IsWhiteSpace(c))
                {
                    nonSpaceChars++;
                }

                // count paragraphs
                if (c == '\n' || i == length - 1)
                {
                    if (i == length - 1 || text[i + 1] != '\n')
                    {
                        paragraphs++;
                    }
                }

                // count sentences
                if (c == '.' || c == '!' || c == '?' || i == length - 1)
                {
                    if (i == length - 1 || char.IsWhiteSpace(text, i + 1))
                    {
                        sentences++;
                    }
                }

                // count words
                if (char.IsLetterOrDigit(c))
                {
                    if (i == length - 1 || !char.IsLetterOrDigit(text, i + 1))
                    {
                        words++;
                    }
                }
            }

            // show statistics
            var msg = string.Format(
                "Words: {0:n0}\r\n" +
                "Characters: {1:n0}\r\n" +
                "Non-Space Characters: {2:n0}\r\n" +
                "Sentences: {3:n0}\r\n" +
                "Paragraphs: {4:n0}\r\n" +
                "Average Word Length: {5:n1}\r\n" +
                "Average Sentence Length: {6:n1}\r\n" +
                "Average Paragraph Length: {7:n1}\r\n",
                words, chars, nonSpaceChars, sentences, paragraphs,
                words > 0 ? nonSpaceChars / (float)words : 0f,
                sentences > 0 ? nonSpaceChars / (float)sentences : 0f,
                paragraphs > 0 ? nonSpaceChars / (float)paragraphs : 0f);
            MessageBox.Show(msg, "Word Count");
        }

        void _btnSpell_Click(object sender, EventArgs e)
        {
            if (c1SpellChecker1 != null)
            {
                c1SpellChecker1.CheckControl(C1Editor1, C1Editor1.GetActiveXInstance());
            }
        }

        void _btnShowErrors_Click(object sender, EventArgs e)
        {
            if (c1SpellChecker1 != null)
            {
                var show = !_btnShowErrors.Checked;
                _btnShowErrors.Checked = show;
                c1SpellChecker1.SetActiveSpellChecking(C1Editor1, C1Editor1.GetActiveXInstance(), show);
            }
        }

        private void toolStripSplitButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == designModeToolStripMenuItem)
            {
                C1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design;
                sourceModeToolStripMenuItem.Checked = false;
                previewModeToolStripMenuItem.Checked = false;
            }
            else if (e.ClickedItem == sourceModeToolStripMenuItem)
            {
                C1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source;
                designModeToolStripMenuItem.Checked = false;
                previewModeToolStripMenuItem.Checked = false;
            }
            else if (e.ClickedItem == previewModeToolStripMenuItem)
            {
                C1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview;
                sourceModeToolStripMenuItem.Checked = false;
                designModeToolStripMenuItem.Checked = false;
            }
        }
    }
}
