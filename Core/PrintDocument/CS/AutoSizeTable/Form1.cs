using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace AutoSizeTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C1PrintDocument doc = new C1PrintDocument();

            // create a RenderTable object:
            RenderTable rt = new RenderTable();
            // adjust table's properties so that columns are auto-sized:
            // 1) By default, table width is set to parent (page) width,
            // for auto-sizing we must change it to auto (i.e. based on content):
            rt.Width = Unit.Auto;
            // 2) Set ColumnSizingMode to Auto (default means Fixed for columns):
            rt.ColumnSizingMode = TableSizingModeEnum.Auto;
            // that's it, now the table's columns will be auto-sized.

            // Turn table grid lines on to better see autosizing, add some padding:
            rt.Style.GridLines.All = LineDef.Default;
            rt.CellStyle.Padding.All = "2mm";

            // add some data
            rt.Cells[0, 0].Text = "aaa";
            rt.Cells[0, 1].Text = "bbbbbbbbbb";
            rt.Cells[0, 2].Text = "cccccc";
            rt.Cells[1, 0].Text = "aaa aaa aaa";
            rt.Cells[1, 1].Text = "bbbbb";
            rt.Cells[1, 2].Text = "cccccc cccccc";
            rt.Cells[2, 2].Text = "zzzzzzzzzzzzzzz zz z";

            // add the table to the document
            doc.Body.Children.Add(rt);

            // show the document
            c1PrintPreviewControl1.Document = doc;
        }

    }
}