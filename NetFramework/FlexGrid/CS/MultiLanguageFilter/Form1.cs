using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace MultiLanguageFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // populate grid
            var s = "An indictment unsealed in Hawaii on Thursday accuses employees of a California-based company of luring about 400 people from Thailand with false promises of lucrative jobs. Many of the imported workers wound up laboring on farms under substandard conditions had their passports confiscated and were threatened with deportation".Split(' ');
            for (int i = 0; i < flex.Rows.Count; i++)
            {
                for (int j = 0; j < flex.Cols.Count; j++)
                {
                    flex[i,j] = s[(i + j) % s.Length];
                }
            }

            // enable filter
            flex.AllowFiltering = true;

            // select language that matches the current UI culture
            var c = System.Threading.Thread.CurrentThread.CurrentUICulture;
            for (int i = 0; i < _cmbLanguage.Items.Count; i++)
            {
                var txt = _cmbLanguage.Items[i].ToString();
                var pos = txt.IndexOf("(");
                var cultureName = txt.Substring(pos + 1, 2);
                if (cultureName == c.TwoLetterISOLanguageName)
                {
                    _cmbLanguage.SelectedIndex = i;
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get language selected by the user
            var txt = _cmbLanguage.Text;
            if (!string.IsNullOrEmpty(txt))
            {
                // extract two-letter culture name
                var pos = txt.IndexOf("(");
                var cultureName = txt.Substring(pos + 1, 2);

                // apply culture to current thread
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);
            }
        }
    }
}
