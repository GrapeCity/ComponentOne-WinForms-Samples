using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Editor.ToolStrips;

namespace ToolStrips
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowDocumentInformation();
        }

        void ShowDocumentInformation()
        {
            String text = c1Editor1.Text;
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
            string msg = string.Format(
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


        void UpdateToolStripLayout(ToolStrip toolStrip, bool visible)
        {
            ToolStripPanel panel = (ToolStripPanel)toolStrip.Parent;
            if (!visible && panel != null)
            {
                // Hide
                toolStrip.Parent.Controls.Remove(toolStrip); 
            }
            else
            {
                if (visible && panel == null)
                {
                    panel = toolStripContainer1.TopToolStripPanel;
                    // Show
                    bool done = false;
                    int width = toolStrip.Width;
                    for (int i = 0; i < toolStripContainer1.TopToolStripPanel.Rows.Length; i++)
                    {
                        ToolStripPanelRow row = toolStripContainer1.TopToolStripPanel.Rows[i];
                        int leftPos = 0;
                        foreach(Control c in row.Controls)
                        {
                            leftPos = Math.Max(leftPos, c.Right + 1);
                        }
                        if (row.Bounds.Width >= leftPos + width)
                        {
                           panel.Join(toolStrip, leftPos, row.Bounds.Top);
                           System.Diagnostics.Debug.WriteLine(toolStrip.Name + " Join " + leftPos.ToString() + "," + row.Bounds.Top.ToString());
                            done = true;
                        }
                    }
                    if (!done)
                    {
                        panel.Join(toolStrip, panel.Rows.Length);
                        toolStrip.Left = 0;
                    }
                }
            }
        }

        void UpdateUI()
        {
            UpdateToolStripLayout(editorToolStripMain1, checkBox1.Checked);
            UpdateToolStripLayout(editorToolStripStyle1,checkBox1.Checked);
            UpdateToolStripLayout(editorToolStripObjects1, checkBox1.Checked);
            UpdateToolStripLayout(editorToolStripTable1, checkBox1.Checked);
            UpdateToolStripLayout(toolStrip2, checkBox2.Checked);
            UpdateToolStripLayout(_myToolStrip, checkBox3.Checked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _myToolStrip.Editor = c1Editor1;
            toolStripContainer1.TopToolStripPanel.Controls.Clear();
            UpdateUI();
            c1Editor1.LoadXml("tesla.htm");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        MyToolStrip _myToolStrip = new MyToolStrip();

        /// <summary>
        /// Custom toolstrip
        /// </summary>
        class MyToolStrip : C1.Win.C1Editor.ToolStrips.C1EditorToolStripBase
        {
            protected override void OnInitialize()
            {
                base.OnInitialize();
                AddButton(CommandButton.New);
                AddButton(CommandButton.Open);
                AddButton(CommandButton.Save);
                Items.Add(new ToolStripSeparator());
                AddComboBox(CommandComboBox.Style);
                AddButton(CommandButton.Left);
                AddButton(CommandButton.Center);
                AddButton(CommandButton.Right);
                AddButton(CommandButton.Justify);
                Items.Add(new ToolStripSeparator());
                AddButton(CommandButton.Undo);
                AddButton(CommandButton.Redo);
                Items.Add(new ToolStripSeparator());
                AddSplitButton(CommandSplitButton.Border);
            }
        }

    }
}
