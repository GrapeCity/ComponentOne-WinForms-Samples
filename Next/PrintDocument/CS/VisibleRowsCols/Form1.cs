using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace VisibleRowsCols
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal RenderTable CreateTable(C1PrintDocument doc, int colCount, int rowCount, string cellTextMask)
        {
            RenderTable result = new RenderTable(doc);

            for (int r = 0; r < rowCount; r++)
                for (int c = 0; c < colCount; c++)
                    result.Cells[r, c].Text = string.Format(cellTextMask, r, c);

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 20);

            doc.Body.Children.Add(new RenderText("Some rows and columns of table are hidden."));

            RenderTable rt = CreateTable(doc, 3, 10, "Cell {0} : {1}");
            rt.Style.GridLines.All = new LineDef("1mm", Color.Blue);
            rt.Cols[1].Visible = false;
            rt.Rows[7].Visible = false;

            TableCell c = rt.Cells[0, 0];
            c.SpanCols = 3;
            c.Text = string.Format("Merged cell: Row={0}, Col={1}, SpanRows={2}, SpanCols={3}", c.Row, c.Col, c.SpanRows, c.SpanCols);
            c.Style.TextAlignHorz = AlignHorzEnum.Center;
            c.Style.BackColor = Color.LightGoldenrodYellow;

            c = rt.Cells[3, 1];
            c.SpanCols = 2;
            c.Text = string.Format("Merged cell: Row={0}, Col={1}, SpanRows={2}, SpanCols={3}", c.Row, c.Col, c.SpanRows, c.SpanCols);
            c.Style.TextAlignHorz = AlignHorzEnum.Center;
            c.Style.BackColor = Color.LightSeaGreen;

            c = rt.Cells[6, 0];
            c.SpanRows = 2;
            c.Text = string.Format("Merged cell: Row={0}, Col={1}, SpanRows={2}, SpanCols={3}", c.Row, c.Col, c.SpanRows, c.SpanCols);
            c.Style.TextAlignHorz = AlignHorzEnum.Center;
            c.Style.BackColor = Color.LightSkyBlue;

            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 20);

            doc.Body.Children.Add(new RenderText("Some rows of header and footer are hidden"));

            RenderTable rt = CreateTable(doc, 3, 50, "Cell {0} : {1}");
            rt.Style.GridLines.All = new LineDef("1mm", Color.Blue);

            // build table header
            TableVectorGroup ph = rt.RowGroups[0, 3];
            ph.PageHeader = true;
            ph.Style.BackColor = Color.LightSlateGray;
            ph.Style.Font = new Font("Verdana", 25);
            // hide row in table header
            rt.Rows[0].Visible = false;

            // build table footer
            TableVectorGroup pf = rt.RowGroups[rt.Rows.Count - 3, 3];
            pf.PageFooter = true;
            pf.Style.BackColor = Color.CornflowerBlue;
            pf.Style.Font = new Font("Tahoma", 25);
            // hide row in table footer
            rt.Rows[rt.Rows.Count - 1].Visible = false;

            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(null, EventArgs.Empty);
        }
    }
}