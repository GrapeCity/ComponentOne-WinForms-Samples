using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace ZeroWidthRowsCols
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

        private void Form1_Load(object sender, EventArgs e)
        {
            doc.Style.Font = new Font("Tahoma", 20);

            doc.Body.Children.Add(new RenderText("This table has the rows and columns with zero-width.\r\rColumn 1 is hidden and rows 2, 5 are hidden."));

            RenderTable rt = CreateTable(doc, 3, 10, "Cell {0} : {1}");
            rt.Style.GridLines.All = new LineDef("1mm", Color.Blue);
            rt.Cols[1].Width = Unit.Empty;
            rt.Rows[2].Height = Unit.Empty;
            rt.Rows[5].Height = Unit.Empty;
            doc.Body.Children.Add(rt);

            doc.Generate();
        }
    }
}