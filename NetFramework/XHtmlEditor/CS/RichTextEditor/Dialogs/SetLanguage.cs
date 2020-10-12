using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using C1.Win.C1SpellChecker;

namespace RichTextEditor
{
    public partial class SetLanguage : Form
    {
        // ** fields
        C1SpellChecker _spellChecker;

        // ** ctors
        public SetLanguage()
        {
            InitializeComponent();
        }
        public SetLanguage(C1SpellChecker spellChecker)
        {
            InitializeComponent();

            // save reference to spell checker
            _spellChecker = spellChecker;

            // populate list
            _list.Items.Add("Default (built-in English US)");
            foreach (string fn in Directory.GetFiles(Application.StartupPath, "c1spell_*.dct"))
            {
                Dictionary item = new Dictionary(fn);
                if (item.IsValid)
                {
                    _list.Items.Add(item);
                }
            }

            // select current
            _list.SelectedIndex = 0;
            string current = _spellChecker.MainDictionary.FileName;
            if (!string.IsNullOrEmpty(current))
            {
                foreach (Object item in _list.Items)
                {
                    Dictionary dct = item as Dictionary;
                    if (dct != null &&
                        string.Equals(Path.GetFileName(dct.FileName), Path.GetFileName(current), StringComparison.OrdinalIgnoreCase))
                    {
                        _list.SelectedItem = dct;
                        break;
                    }
                }
            }
        }

        // ** event handlers
        private void _btnOK_Click(object sender, EventArgs e)
        {
            // save main dictionary
            Dictionary dct = _list.SelectedItem as Dictionary;
            _spellChecker.MainDictionary.FileName = dct != null
                ? dct.FileName
                : null;
        }

        /// <summary>
        /// Helper class to keep track of dictionary names and languages.
        /// </summary>
        class Dictionary
        {
            string _fileName;
            CultureInfo _ci;

            public Dictionary(string fileName)
            {
                _fileName = fileName;
                string name = Path.GetFileNameWithoutExtension(fileName).Substring(8);
                try
                {
                    _ci = new CultureInfo(name);
                }
                catch { }
            }
            public bool IsValid
            {
                get { return _ci != null; }
            }
            public string FileName
            {
                get { return _fileName; }
            }
            public override string ToString()
            {
                return _ci.EnglishName;
            }
        }
    }
}
