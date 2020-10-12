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

#if OBSOLETE // since ColumnSizingMode set to TableSizingModeEnum.Auto is supported, the code below is not needed anymore.
        /// <summary>
        /// Auto-sizes the table based on cells' content.
        /// </summary>
        /// <param name="rt">The table to auto-size.</param>
        private static void AutoSizeTable(RenderTable rt)
        {
            if (rt.Document == null)
                throw new Exception("The table must be already added to the document");
            double[] widths = new double[rt.Cols.Count];
            for (int row = 0; row < rt.Rows.Count; ++row)
            {
                for (int col = 0; col < rt.Cols.Count; ++col)
                {
                    if (rt.Cells[row, col].RenderObject != null)
                    {
                        SizeD s = rt.Cells[row, col].RenderObject.CalcSize(Unit.Auto, Unit.Auto);
                        widths[col] = Math.Max(widths[col], s.Width);
                    }
                }
            }
            // 1. grid line widths are added to the columns' widths, so we must take them into consideration.
            // 2. for calculations in the document, the maximum width is used, so we do that too.
            // 3. first and last columns include an extra half-width of a line.
            double wVert = rt.Style.GridLines.Vert == null ? 0 : rt.Style.GridLines.Vert.Width.ConvertUnit(rt.Document.ResolvedUnit);
            double wLeft = rt.Style.GridLines.Left == null ? 0 : rt.Style.GridLines.Left.Width.ConvertUnit(rt.Document.ResolvedUnit);
            double wRight = rt.Style.GridLines.Right == null ? 0 : rt.Style.GridLines.Right.Width.ConvertUnit(rt.Document.ResolvedUnit);
            double lineWidths = Math.Max(wVert, Math.Max(wLeft, wRight));
            for (int col = 0; col < rt.Cols.Count; ++col)
            {
                if (col == 0 || col == rt.Cols.Count - 1)
                    rt.Cols[col].Width = new Unit(widths[col] + lineWidths * 1.5, rt.Document.ResolvedUnit);
                else
                    rt.Cols[col].Width = new Unit(widths[col] + lineWidths, rt.Document.ResolvedUnit);
            }
            // the default for a table is 100% of the parent's width, so we must set the width
            // to auto (which means the sum of all columns' widths).
            rt.Width = Unit.Auto;
        }
#endif
    }
}