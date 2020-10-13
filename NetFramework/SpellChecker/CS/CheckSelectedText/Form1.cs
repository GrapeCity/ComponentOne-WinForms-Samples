using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SpellChecker;

namespace CheckSelectedText
{
    public partial class Form1 : Form
    {
        int _selectionEnd;
        int _textLength;

        public Form1()
        {
            InitializeComponent();
        }

        private void _btnCheckSelection_Click(object sender, EventArgs e)
        {
            // trivial case
            if (_textBox.SelectionLength == 0)
            {
                _spellChecker.CheckControl(_textBox);
                return;
            }

            // adjust selection
            var text = _textBox.Text;
            var start = _textBox.SelectionStart;
            while (start > 0 && char.IsLetterOrDigit(text[start - 1]))
            {
                start--;
            }
            var end = _textBox.SelectionStart + _textBox.SelectionLength;
            while (end < text.Length && char.IsLetterOrDigit(text[end]))
            {
                end++;
            }
            _textBox.Select(start, end - start);

            // prepare to check selection
            _textLength = text.Length;
            _selectionEnd = end;
            _textBox.TextChanged += _textBox_TextChanged;
            _spellChecker.BadWordFound += _spellChecker_BadWordFound;

            // check selection
            _spellChecker.CheckControl(_textBox, true);

            // done checking selection
            _textBox.TextChanged -= _textBox_TextChanged;
            _spellChecker.BadWordFound -= _spellChecker_BadWordFound;
            _textBox.Select(start, _selectionEnd - start);
        }

        void _spellChecker_BadWordFound(object sender, BadWordEventArgs e)
        {
            // ignore bad words after selection end
            if (e.BadWord.Start >= _selectionEnd)
            {
                var dlg = e.Dialog as C1SpellDialog;
                dlg.CancelButton.PerformClick();
            }
        }
        void _textBox_TextChanged(object sender, EventArgs e)
        {
            // adjust selection end when a word changes
            _selectionEnd += (_textBox.TextLength - _textLength);
            _textLength = _textBox.TextLength;
        }
    }
}
