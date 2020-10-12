using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebBrowserSpell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initialize WebBrowser content
            _webBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
            _webBrowser.DocumentText = Properties.Resources.Intro;

            // turn on spell-checking
            SetActiveSpelling(true);
        }
        void _webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = _webBrowser.Document;
            if (doc != null && doc.Body != null)
            {
                doc.Body.SetAttribute("contentEditable", "true");
            }
        }
        void SetActiveSpelling(bool value)
        {
            _chkActiveSpelling.Checked = value;
            _spellChecker.SetActiveSpellChecking(_webBrowser, value);
        }
        void _chkActiveSpelling_Click(object sender, EventArgs e)
        {
            SetActiveSpelling(!_chkActiveSpelling.Checked);
        }
        private void _chkModalSpellCheck_Click(object sender, EventArgs e)
        {
            int errorCount = _spellChecker.CheckControl(_webBrowser);
            if (errorCount < 0)
            {
                MessageBox.Show("Spell-Check was canceled.");
            }
            else
            {
                var msg = string.Format("Spell-check complete. {0} error{1} detected.",
                    errorCount == 0 ? "No" : errorCount.ToString(),
                    errorCount != 1 ? "s" : string.Empty);
                MessageBox.Show(msg);
            }
        }
    }
}
