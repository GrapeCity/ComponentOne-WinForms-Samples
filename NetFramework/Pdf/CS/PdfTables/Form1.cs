﻿using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using _Font = C1.Util.Font;

namespace PdfTables
{
    public partial class Form1 : Form
    {
        string _html = string.Empty;

        public Form1()
        {
            InitializeComponent();

            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (string resName in asm.GetManifestResourceNames())
            {
                if (resName.EndsWith(".htm"))
                {
                    using (StreamReader sr = new StreamReader(asm.GetManifestResourceStream(resName)))
                    {
                        _html = sr.ReadToEnd();
                        _webBrowser.DocumentText = _html;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // setup
            _pdf.Clear();
            RectangleF rcPage = _pdf.PageRectangle;
            rcPage.Inflate(-72, -72);

            // render
            for (float offset = 0; offset < int.MaxValue;)
            {
                if (offset > 0)
                {
                    _pdf.NewPage();
                }
                var font = new _Font(Font.FontFamily.Name, Font.SizeInPoints);
                offset = this._pdf.DrawStringHtml(_html, font, Color.Black, rcPage, offset);
            }

            // save
            string fn = Path.Combine(Application.StartupPath, "html.pdf");
            this._pdf.Save(fn);

            // show
            System.Diagnostics.Process.Start(fn);
        }
    }
}
