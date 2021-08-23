using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace WideTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1PrintPreviewControl1.PreviewPane.ZoomFactor = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // because we want to show a wide table, we adjust the properties
            // of the preview accordingly:
            // hide all margins
            c1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.All;
            // do not allow the user to show margins
            c1PrintPreviewControl1.PreviewPane.HideMargins = HideMarginsFlags.None;
            // set padding between pages with hidden margins to 0, so that no gap is visible:
            c1PrintPreviewControl1.PreviewPane.PagesPaddingSmall = new Size(0, 0);
            // set zoom mode:
            c1PrintPreviewControl1.PreviewPane.ZoomMode = ZoomModeEnum.PageWidth;
            // make the document:
            MakeDoc1(c1PrintDocument1);
            c1PrintDocument1.Reflow();
        }

        private void MakeDoc1(C1PrintDocument doc)
        {
            doc.Clear();

            RenderText rtxt = new RenderText();
            rtxt.Text = "This sample demonstrates horizontal (extended) pages, which allow to " +
                "render wide objects (for example, tables with many columns) on separate pages that can " +
                "be \"glued\" side to side.";
            // set the width of the text to 3 times the width of the page
            rtxt.Width = "page*3";
            // allow it to span horizontal pages:
            rtxt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
            // add padding
            rtxt.Style.Padding.All = "2mm";
            rtxt.Style.Padding.Bottom = "5mm";
            /// add text to the document
            doc.Body.Children.Add(rtxt);

            doc.Style.Font = new Font("Arial", 12, FontStyle.Regular);

            const int ROWS = 63;
            const int COLS = 8;

            // make the table
            RenderTable rt = new RenderTable();
            // for tables, "auto" width means that the width of the table
            // will be equal to the widths of all columns, so we MUST also
            // set the columns' widths.
            rt.Width = "auto";
            for (int col = 0; col < COLS; ++col)
                rt.Cols[col].Width = "5cm";

            // we want the last column on page to stretch to the right edge of the page,
            // so that there is no white space left before the margin
            rt.StretchColumns = StretchTableEnum.LastVectorOnPage;
            // for the rightmost column, we turn stretching off:
            rt.Cols[rt.Cols.Count - 1].Stretch = StretchColumnEnum.No;
            // tell the table that it can split horizontally,
            // otherwise the right part of the table will be clipped:
            rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;


            // fill table with sample data
            for (int row = 0; row < ROWS; ++row)
                for (int col = 0; col < COLS; ++col)
                    rt.Cells[row, col].Text = string.Format("Cell ({0}, {1})", row, col);

            // add the table to the document
            doc.Body.Children.Add(rt);

            // set up table style
            rt.Style.GridLines.All = new LineDef("2pt", Color.Black);
            rt.Style.GridLines.Horz = new LineDef("1pt", Color.Gray);
            rt.Style.GridLines.Vert = new LineDef("1pt", Color.Gray);

            // add some comments at the bottom
            rtxt = new RenderText();
            rtxt.Text = "Note also that the preview supports such documents by showing " +
                "the pages side by side rather than one below the other.";
            // set the width of the text to the width of the preceding sibling (i.e. the table):
            rtxt.Width = "prev.width";
            // allow it to span horizontal pages:
            rtxt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
            // add padding
            rtxt.Style.Padding.All = "2mm";
            rtxt.Style.Padding.Top = "5mm";
            // add the text to the document
            doc.Body.Children.Add(rtxt);
        }
    }
}