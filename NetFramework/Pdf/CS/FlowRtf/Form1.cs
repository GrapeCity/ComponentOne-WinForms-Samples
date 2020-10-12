using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlowRtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string BROWSE_TEXT = "<Browse...>";

		string tempdir = Application.ExecutablePath.Substring(0,
			Application.ExecutablePath.LastIndexOf("\\")+1);

        private void Form1_Load(object sender, EventArgs e)
        {
            // populate file list
            _cmbFiles.Items.Clear();
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (string res in a.GetManifestResourceNames())
            {
                if (res.ToLower().EndsWith(".rtf"))
                {
                    _cmbFiles.Items.Add(res);
                }
            }
            _cmbFiles.Items.Add(BROWSE_TEXT);

            // populate columns list
            _cmbColumns.Items.Clear();
            for (int i = 1; i < 6; i++)
            {
                _cmbColumns.Items.Add(i.ToString());
            }

            // initialize selection
            _cmbFiles.SelectedIndex = 0;
            _cmbColumns.SelectedIndex = 0;
        }

        // show document in rich text box when it's selected
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbFiles.Text == BROWSE_TEXT)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.FileName = "*.rtf";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
                    }
                }
                return;
            }

            Assembly a = Assembly.GetExecutingAssembly();
            using (Stream s = a.GetManifestResourceStream(_cmbFiles.Text))
            {
                richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText);
            }
        }

        private RectangleF[] _cols;
        private int _currentColumn;

        // create pdf document
        private void button1_Click(object sender, EventArgs e)
        {
            //if (false)
            //{
            //    RenderPlainText();
            //}
            //else
            {
                RenderRichText();
            }
        }
        private void RenderPlainText()
        {
            button1.Enabled = false;
            DateTime bs = DateTime.Now;

            // get number of columns, create layout array
            int cols = int.Parse(_cmbColumns.Text);
            _cols = new RectangleF[cols];

            // 4 or more columns? switch to landscape
            if (cols >= 4) _btnLandscape.Checked = true;

            // apply document orientation
            _c1pdf.Landscape = _btnLandscape.Checked;

            // create one rectangle per column
            RectangleF rcPage = _c1pdf.PageRectangle;
            rcPage.Inflate(-72, -72);
            for (int i = 0; i < cols; i++)
            {
                RectangleF rcc = rcPage;
                rcc.Width /= cols;
                rcc.Offset(rcc.Width * i, 0);
                rcc.Inflate(-20, -20);
                _cols[i] = rcc;
            }

            // get Rtf to render
            string text = richTextBox1.Text;

            // print the Rtf string spanning multiple pages
            _c1pdf.Clear();
            _currentColumn = 0;
            for (int start = 0; start < int.MaxValue; )
            {
                // render this part
                _status.Text = string.Format("Page {0} Column {1}", _c1pdf.Pages.Count, _currentColumn + 1);
                Application.DoEvents();
                RectangleF rc = _cols[_currentColumn];
                start = _c1pdf.DrawString(text, Font, Brushes.Black, rc, start);

                // skip page/column
                if (start < int.MaxValue)
                {
                    _currentColumn++;
                    if (_currentColumn >= _cols.Length)
                    {
                        _currentColumn = 0;
                        _c1pdf.NewPage();
                    }
                }
            }

            // done
            _status.Text = "Ready";
            button1.Enabled = true;
            TimeSpan ts = DateTime.Now.Subtract(bs);
            Console.WriteLine("done in {0:f2}s", ts.TotalSeconds);

            // show the result
            string fn = tempdir + @"rtf.pdf";
            _c1pdf.Save(fn);
            System.Diagnostics.Process.Start(fn);
        }
        private void RenderRichText()
        {
            button1.Enabled = false;
            DateTime bs = DateTime.Now;

            // get number of columns, create layout array
            int cols = int.Parse(_cmbColumns.Text);
            _cols = new RectangleF[cols];

            // 4 or more columns? switch to landscape
            if (cols >= 4) _btnLandscape.Checked = true;

            // apply document orientation
            _c1pdf.Landscape = _btnLandscape.Checked;

            // create one rectangle per column
            RectangleF rcPage = _c1pdf.PageRectangle;
            rcPage.Inflate(-72, -72);
            for (int i = 0; i < cols; i++)
            {
                RectangleF rcc = rcPage;
                rcc.Width /= cols;
                rcc.Offset(rcc.Width * i, 0);
                rcc.Inflate(-20, -20);
                _cols[i] = rcc;
            }
            
            // get Rtf to render
            string text = richTextBox1.Rtf;

            // print the Rtf string spanning multiple pages
            _c1pdf.Clear();
            _currentColumn = 0;
            for (int start = 0; start < int.MaxValue; )
            {
                // render this part
                _status.Text = string.Format("Page {0} Column {1}", _c1pdf.Pages.Count, _currentColumn + 1);
                Application.DoEvents();
                RectangleF rc = _cols[_currentColumn];
                start = _c1pdf.DrawStringRtf(text, Font, Brushes.Black, rc, start);

                // skip page/column
                if (start < int.MaxValue)
                {
                    _currentColumn++;
                    if (_currentColumn >= _cols.Length)
                    {
                        _currentColumn = 0;
                        _c1pdf.NewPage();
                    }
                }
            }

            // done
            _status.Text = "Ready";
            button1.Enabled = true;
            TimeSpan ts = DateTime.Now.Subtract(bs);
            Console.WriteLine("done in {0:f2}s", ts.TotalSeconds);

            // show the result
            string fn = tempdir + @"rtf.pdf";
            _c1pdf.Save(fn);
            System.Diagnostics.Process.Start(fn);
        }
    }
}