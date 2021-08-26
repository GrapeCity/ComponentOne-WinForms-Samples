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
        private C1PrintDocument makeDoc_TableBorders()
        {
            C1PrintDocument doc = new C1PrintDocument();

            RenderText rtxt = new RenderText(doc);
            rtxt.Text = "This test shows some non-standard ways to draw table borders.\n\n";
            doc.Body.Children.Add(rtxt);

            doc.Style.Font = new Font("Arial", 12, FontStyle.Regular);

            const int ROWS = 42;
            const int COLS = 16;

            RenderTable rt = new RenderTable(doc);
            rt.Width = "16in";
            rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
            for (int row = 0; row < ROWS; ++row)
            {
                for (int col = 0; col < COLS; ++col)
                {
                    //if (row == col)
                        //continue;
                    RenderText celltext = new RenderText(doc);
                    celltext.Text = string.Format("Cell ({0},{1})", row, col);
                    rt.Cells[row, col].RenderObject = celltext;
                }
            }
            // add the table to the document
            doc.Body.Children.Add(rt);

            // set up table style
            rt.Style.GridLines.All = new LineDef("1pt", Color.Black);
            rt.Style.GridLines.Horz = LineDef.Empty;
            rt.Style.GridLines.Vert = LineDef.Empty;
            rt.CellStyle.Borders.All = new LineDef("1pt", Color.DarkOrange);
            rt.CellStyle.Spacing.All = new Unit("0.5mm");
            rt.Style.TextAlignVert = AlignVertEnum.Center;

            return doc;
        }
    }
}