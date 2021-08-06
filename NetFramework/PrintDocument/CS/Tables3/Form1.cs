using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace Tables3
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

            RenderText rtxt = new RenderText(doc);
            rtxt.Text = "This test demonstrates multiple inheritance of styles in tables. " +
                "In the table below, the font is redefined for row 4. " +
                "Then, the text color is redefined for column 1. " +
                "Finally, a cell group is defined containing cells in rows 4 to 6, cols 1 & 2, " +
                "and background color is redefined for that cell group. " +
                "\nThe cell at the intersection of row 4 and col 1 combines all 3 styles.\n\n";
            doc.Body.Children.Add(rtxt);

            doc.Style.Font = new Font("Arial", 12, FontStyle.Regular);

            const int ROWS = 12;
            const int COLS = 6;

            RenderTable rt = new RenderTable(doc);
            rt.Style.Padding.All = new Unit("4mm");
            for (int row = 0; row < ROWS; ++row)
            {
                for (int col = 0; col < COLS; ++col)
                {
                    RenderText celltext = new RenderText(doc);
                    celltext.Text = string.Format("Cell ({0},{1})", row, col);
                    rt.Cells[row, col].RenderObject = celltext;
                }
            }
            // add the table to the document
            doc.Body.Children.Add(rt);

            // set up table style
            rt.Style.GridLines.All = new LineDef("2pt", Color.Black);
            rt.Style.GridLines.Horz = new LineDef("1pt", Color.Gray);
            rt.Style.GridLines.Vert = new LineDef("1pt", Color.Gray);

            // define a row style
            rt.Rows[4].Style.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);

            // define a column style
            rt.Cols[1].Style.TextColor = Color.DarkOrange;

            // define a cell group with a background color
            rt.UserCellGroups.Add(new UserCellGroup(new Rectangle(1, 4, 2, 3)));
            rt.UserCellGroups[0].Style.BackColor = Color.PaleGreen;
        }
    }
}