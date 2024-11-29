using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using _Font = C1.Util.Font;
using _FontStyle = C1.Util.FontStyle;
using _Pen = GrapeCity.Documents.Drawing.Pen;

namespace FlowHtml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string BROWSE_TEXT = "<Browse...>";
        string _html;

        private void Form1_Load(object sender, EventArgs e)
        {
            // populate file list
            _cmbFiles.Items.Clear();
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (string res in a.GetManifestResourceNames())
            {
                if (res.ToLower().EndsWith(".htm"))
                {
                    _cmbFiles.Items.Add(res.Substring("FlowHtml.Resources.".Length));
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
            _cmbFiles.SelectedIndex = 1;
            _cmbColumns.SelectedIndex = 0;
        }

        // show document in rich text box when it's selected
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select file/document
            if (_cmbFiles.Text == BROWSE_TEXT)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.FileName = "*.htm";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(dlg.FileName))
                            _html = sr.ReadToEnd();
                    }
                }
            }
            else
            {
                Assembly a = Assembly.GetExecutingAssembly();
                foreach (string resName in a.GetManifestResourceNames())
                {
                    if (resName.EndsWith(_cmbFiles.Text))
                    {
                        using (StreamReader sr = new StreamReader(a.GetManifestResourceStream(resName)))
                            _html = sr.ReadToEnd();
                    }
                }
            }

            // show the document in browser
            webBrowser1.DocumentText = _html;
        }

        private RectangleF[] _cols;
        private int _currentColumn;

        // create pdf document
        void button1_Click(object sender, EventArgs e)
        {
            //if (false)
            //{
            //    RenderPlainText();
            //}
            //else
            {
                RenderHtml();
            }
        }
        void RenderPlainText()
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

            // print the HTML string spanning multiple pages
            _c1pdf.Clear();
            _currentColumn = 0;
            for (int start = 0; start < int.MaxValue; )
            {
                // render this part
                _status.Text = string.Format("Page {0} Column {1}", _c1pdf.Pages.Count, _currentColumn + 1);
                Application.DoEvents();
                RectangleF rc = _cols[_currentColumn];
                start = _c1pdf.DrawString(_html, Font, Brushes.Black, rc, start);

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
            string fn = Path.Combine(Application.ExecutablePath, "html.pdf");
            _c1pdf.Save(fn);
            System.Diagnostics.Process.Start(fn);
        }
        void RenderHtml()
        {
            // get ready to work
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
            rcPage.Inflate(-50, -50);
            for (int i = 0; i < cols; i++)
            {
                RectangleF rcc = rcPage;
                rcc.Width /= cols;
                rcc.Offset(rcc.Width * i, 0);
                rcc.Inflate(-10, -10);
                _cols[i] = rcc;
            }
            
            // get Html to render
            string text = _html;

            // print the HTML string spanning multiple pages
            _c1pdf.Clear();
            _currentColumn = 0;
            var font = new _Font("Times New Roman", 12);
            var pen = new _Pen(Color.LightCoral, 0.01f);
            for (float start = 0; ; )
            {
                // render this part
                _status.Text = string.Format("Page {0} Column {1}", _c1pdf.Pages.Count, _currentColumn + 1);
                Application.DoEvents();
                RectangleF rc = _cols[_currentColumn];
                start = _c1pdf.DrawStringHtml(text, font, Color.Black, rc, start);
                _c1pdf.DrawRectangle(pen, rc);

                // done?
                if (start >= int.MaxValue)
                {
                    break;
                }

                // skip page/column
                _currentColumn++;
                if (_currentColumn >= _cols.Length)
                {
                    _currentColumn = 0;
                    _c1pdf.NewPage();
                }
            }

            // done
            _status.Text = "Ready";
            button1.Enabled = true;
            TimeSpan ts = DateTime.Now.Subtract(bs);
            Console.WriteLine("done in {0:f2}s", ts.TotalSeconds);

            // show the result
            string fn = Path.Combine(Application.StartupPath, "html.pdf");
            _c1pdf.Save(fn);
            System.Diagnostics.Process.Start(fn);
        }

        // just for testing...
        void button2_Click(object sender, EventArgs e)
        {
            string resName = @"FlowHtml.HTMLPage1.htm";
            using (StreamReader sr = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(resName)))
            {
                _html = sr.ReadToEnd();
            }
            _c1pdf.Clear();
            RectangleF rc = new RectangleF(100, 100, 500, 0);
            rc.Height = 62;
            var font = new _Font("Arial", 24, _FontStyle.Bold);
            float offset = _c1pdf.DrawStringHtml(_html, font, Color.Black, rc);
            _c1pdf.DrawRectangle(Pens.Red, rc);
            if (offset < int.MaxValue)
            {
                rc.Offset(0, rc.Height + 50);
                _c1pdf.DrawStringHtml(_html, font, Color.Black, rc, offset);
                _c1pdf.DrawRectangle(Pens.Red, rc);
            }
            string fileName = @"c:\temp\foo.pdf";
            _c1pdf.Save(fileName);
            System.Diagnostics.Process.Start(fileName);
        }
    }
}