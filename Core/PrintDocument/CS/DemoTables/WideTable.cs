#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

using C1.C1Preview;
using C1.Win.C1Preview;

#endregion

namespace DemoTables
{
    partial class Form1
    {
        private C1.C1Preview.C1PrintDocument makeDoc_WideTable()
        {
            C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument();

            RenderText rtxt = new RenderText(doc);
            rtxt.Text = "This test demonstrates horizontal (extended) pages, which allow to " +
                "render for example tables with many columns on separate pages that can " +
                "be \"glued\" side to side.\n\n";
            doc.Body.Children.Add(rtxt);

            doc.Style.Font = new Font("Arial", 12, FontStyle.Regular);

            const int ROWS = 63;
            const int COLS = 16;

            RenderTable rt = new RenderTable(doc);
            rt.Width = "16in";
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

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
                sb.Append(string.Format("Text fragment{0}", i));
            rt.Cells[1, 1].Text = sb.ToString();
            // add the table to the document
            doc.Body.Children.Add(rt);

            // set up table style
            rt.Style.GridLines.All = new LineDef("2pt", Color.Black);
            rt.Style.GridLines.Horz = new LineDef("1pt", Color.Gray);
            rt.Style.GridLines.Vert = new LineDef("1pt", Color.Gray);

            // add some comments at the bottom
            rtxt = new RenderText(doc);
            rtxt.Text = "\n\nNote also that the preview supports such documents by showing " +
                "the pages side by side rather than one below the other (this can be turned off " +
                "if desired). Also, the vertical margins can be hidden in the preview for better viewing.";
            doc.Body.Children.Add(rtxt);

            return doc;
        }
    }
}