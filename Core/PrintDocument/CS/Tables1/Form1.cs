using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace Tables1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeDoc1(c1PrintDocument1);
            c1PrintDocument1.Reflow();
        }

        private void MakeDoc1(C1PrintDocument doc)
        {
            doc.Clear();

            Random rnd = new Random((int)DateTime.Now.Ticks);

            int n;
            // make a table
            RenderTable rt1 = new RenderTable();
            // set up some styles on the table
            //
            // Note: all style attributes are divided into ambient and non-ambient.
            // Ambient attributes affect the data itself, whereas non-ambient attributes
            // are those affecting the decorations. Examples of ambient are:
            // Font, TextColor, text alignment. Examples of non-ambient are:
            // Borders, Padding, Spacing.
            // Ambient attributes are propagated via the objects containment,
            // so that e.g. setting the Font on the table will affect text in cells.
            // Non-ambient attributes are inherited via the styles hierarchy. In tables,
            // to set a non-ambient on all cells, table.CellStyle should be used. Ambient
            // attributes can be set via table.Style:
            rt1.Style.GridLines.All = LineDef.Default;
            rt1.Style.TextAlignHorz = AlignHorzEnum.Right;
            rt1.Style.Font = new Font("Courier New", 12);
            rt1.Style.TextColor = Color.Green;
            rt1.CellStyle.Padding.All = "1mm";

            // fill the table with more or less random data
            int nrows = rnd.Next(100, 500);
            int ncols = rnd.Next(2, 4);

            for (int row = 0; row < nrows; ++row)
                for (int col = 0; col < ncols; ++col)
                {
                    n = rnd.Next();
                    rt1.Cells[row, col].Text = n.ToString();
                    rt1.Cells[nrows, col].Tag = rt1.Cells[nrows, col].Tag == null ? n :
                        n + (long)rt1.Cells[nrows, col].Tag;
                }

            // table headers and footers are implemented as row groups.

            // The header:
            // insert 2 rows for the header at the top:
            rt1.Rows.Insert(0, 2);
            // mark the top row as a table header (not repeated),
            // set it up appropriately:
            rt1.RowGroups[0, 1].Header = TableHeaderEnum.None;
            rt1.RowGroups[0, 1].Style.BackColor = Color.GreenYellow;
            rt1.Cells[0, 0].SpanCols = rt1.Cols.Count;
            rt1.Cells[0, 0].Text =
                "This table is filled with random data. It also has a table header (this text), " +
                "running headers with column captions, running footers duplicating the running headers, " +
                "and a footer which prints the column totals.";
            rt1.Cells[0, 0].Style.TextAlignHorz = AlignHorzEnum.Center;
            rt1.Cells[0, 0].Style.Font = new Font("Courier New", 14, FontStyle.Bold);
            // mark the 2nd row as a page header (i.e. repeated on each page).
            rt1.RowGroups[1, 1].Header = TableHeaderEnum.All;
            rt1.RowGroups[1, 1].Style.TextColor = Color.Honeydew;
            rt1.RowGroups[1, 1].Style.BackColor = Color.DarkKhaki;
            for (int col = 0; col < ncols; ++col)
                rt1.Cells[1, col].Text = string.Format("Column {0}", col);

            // The footer:
            // We used the last row for totals. We push it down
            // (to be printed at the very bottom of the table), and add
            // a "running footer" in front, with column headers to be
            // printed on each page:
            n = rt1.Rows.Count - 1;
            rt1.Rows.Insert(n, 1);
            // Orphan control:
            // this line makes sure that at least 3 lines are printed before the
            // footer on the same page.
            rt1.RowGroups[n, 1].MinVectorsBefore = 3;
            rt1.RowGroups[n, 1].Footer = TableFooterEnum.All;
            rt1.RowGroups[n, 1].Style.TextColor = rt1.RowGroups[1, 1].Style.TextColor;
            rt1.RowGroups[n, 1].Style.BackColor = rt1.RowGroups[1, 1].Style.BackColor;
            for (int col = 0; col < ncols; ++col)
                rt1.Cells[n, col].Text = rt1.Cells[1, col].Text;

            // the final footer with totals and a line saying "the end":
            n = rt1.Rows.Count - 1;
            rt1.RowGroups[n, 2].Footer = TableFooterEnum.None;
            rt1.RowGroups[n, 2].Style.BackColor = Color.SandyBrown;
            for (int col = 0; col < ncols; ++col)
                rt1.Cells[n, col].Text = ((long)rt1.Cells[n, col].Tag).ToString();
            rt1.Cells[n + 1, 0].SpanCols = rt1.Cols.Count;
            rt1.Cells[n + 1, 0].Text = "The end.";
            rt1.Cells[n + 1, 0].Style.TextAlignHorz = AlignHorzEnum.Center;

            doc.Body.Children.Add(rt1);
        }
    }
}