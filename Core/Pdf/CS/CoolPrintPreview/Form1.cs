using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoolPrintPreview
{
    public partial class Form1 : Form
    {
        // constructor
        public Form1()
        {
            InitializeComponent();
        }

        // generate sample document
        int _page = 0;
        Font _font = new Font("Segoe UI", 14);
        void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _page = 0;
        }
        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // fill page with text
            Rectangle rc = e.MarginBounds;
            rc.Height = _font.Height + 10;
            for (int i = 0; ; i++)
            {
                var text = string.Format("line {0} on page {1}", i + 1, _page + 1);
                e.Graphics.DrawString(text, _font, Brushes.Black, rc);
                rc.Y += rc.Height;
                if (rc.Bottom > e.MarginBounds.Bottom)
                {
                    break;
                }
            }

            // move on to next page
            _page++;
            e.HasMorePages = _page < 30;
        }

        // show standard print preview
        void button1_Click(object sender, EventArgs e)
        {
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = this.printDocument1;
                dlg.ShowDialog(this);
            }
        }

        // show cool print preview
        void button2_Click(object sender, EventArgs e)
        {
            using (var dlg = new CoolPrintPreviewDialog())
            {
                dlg.Document = this.printDocument1;
                dlg.ShowDialog(this);
            }
        }
    }
}
