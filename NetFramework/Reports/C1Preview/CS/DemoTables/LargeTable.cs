#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

#endregion

namespace DemoTables
{
    partial class Form1
    {
        private C1.C1Preview.C1PrintDocument makeDoc_LargeTable(int nrows, int ncols)
        {
            C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument();

            RenderText rtxt = new RenderText(doc);
            rtxt.Text = "This test demonstrates the speed of large tables " +
                "(the worst bottleneck in the old print doc)." +
                "\n\n";
            doc.Body.Children.Add(rtxt);

            doc.Style.Font = new Font("Arial", 12, FontStyle.Regular);

            int ROWS = nrows;
            int COLS = ncols;

            RenderTable rt = new RenderTable(doc);
            // allocate 3cm per column:
            rt.Width = new Unit(ncols * 30, UnitTypeEnum.Mm);
            rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
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

            return doc;
        }
    }
}