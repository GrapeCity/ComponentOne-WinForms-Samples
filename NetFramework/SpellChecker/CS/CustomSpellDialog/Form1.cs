using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.SpellChecker;

namespace CustomSpellDialog
{
    public partial class Form1 : Form
    {
        bool _checkRichTextBox = false;

        // ** initialize
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox1.Text;
        }

        // ** keep track of last editor with focus
        private void textBox1_Enter(object sender, EventArgs e)
        {
            _checkRichTextBox = false;
        }
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            _checkRichTextBox = true;
        }

        // ** spell check editors
        private void btnSpellCheck_Click(object sender, EventArgs e)
        {
            using (SpellDialog dlg = new SpellDialog())
            {
                dlg.Load += new EventHandler(dlg_Load);
                dlg.FormClosed += new FormClosedEventHandler(dlg_FormClosed);

                if (_checkRichTextBox)
                {
                    c1SpellChecker1.CheckControl(textBox1, false, dlg);
                }
                else
                {
                    c1SpellChecker1.CheckControl(textBox1, false, dlg);
                }
            }
        }
        private void btnSpellCheckCustom_Click(object sender, EventArgs e)
        {
            using (SpellDialogWord dlg = new SpellDialogWord())
            {
                dlg.Load += new EventHandler(dlg_Load);
                dlg.FormClosed += new FormClosedEventHandler(dlg_FormClosed);

                if (_checkRichTextBox)
                {
                    c1SpellChecker1.CheckControl(textBox1, false, dlg);
                }
                else
                {
                    c1SpellChecker1.CheckControl(textBox1, false, dlg);
                }
            }
        }

        // ** dialog event handlers
        void dlg_Load(object sender, EventArgs e)
        {
            SpellDialog dlg = sender as SpellDialog;
            if (dlg != null)
            {
                status.Text = string.Format("Checking spelling... {0}", dlg.ErrorCount);
            }
            else
            {
                SpellDialogWord dlgw = sender as SpellDialogWord;
                status.Text = string.Format("Checking spelling... {0}", dlgw.ErrorCount);
            }
            Console.WriteLine(this.status.Text);
        }
        void dlg_FormClosed(object sender, FormClosedEventArgs e)
        {
            SpellDialog dlg = sender as SpellDialog;
            if (dlg != null)
            {
                status.Text = string.Format("Spell-check done, {0} errors handled; result {1}.", dlg.ErrorCount, dlg.DialogResult);
            }
            else
            {
                SpellDialogWord dlgw = sender as SpellDialogWord;
                status.Text = string.Format("Spell-check done, {0} errors handled; result {1}.", dlgw.ErrorCount, dlgw.DialogResult);
            }
            Console.WriteLine(this.status.Text);
        }

        private void c1SpellChecker1_BadWordFound(object sender, BadWordEventArgs e)
        {
            Console.WriteLine("Bad word found {0}, {1} of {2}", e.BadWord.Text, e.BadWordList.IndexOf(e.BadWord) + 1, e.BadWordList.Count);
            if (e.Dialog != null)
            {
                // show some feedback on the status line
                int index = e.BadWordList.IndexOf(e.BadWord) + 1;
                status.Text = string.Format("Error {0} of {1}: '{2}'", index, e.BadWordList.Count, e.BadWord.Text);
            }
            else
            {
                // prevent control from underlining words that start with a capital
                //if (char.IsUpper(e.BadWord.Text[0]))
                //{
                //    e.Cancel = true;
                //}
            }
        }
    }
}