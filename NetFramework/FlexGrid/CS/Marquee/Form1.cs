using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marquee
{
    public partial class Form1 : Form
    {
        Rectangle _marqueeRect = Rectangle.Empty;
        Pen _marqueePen = new Pen(Color.Black, 2);

        public Form1()
        {
            InitializeComponent();

            // create style for changed cells
            var cs = this.c1FlexGrid1.Styles.Add("changed");
            cs.BackColor = Color.LemonChiffon;
        }

        void c1FlexGrid1_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            // apply style to changed cells
            var cs = this.c1FlexGrid1.Styles["changed"];
            this.c1FlexGrid1.SetCellStyle(e.Row, e.Col, cs);
        }
        void c1FlexGrid1_Paint(object sender, PaintEventArgs e)
        {
            // compute marquee rectangle
            var sel = this.c1FlexGrid1.Selection;
            if (sel.IsValid)
            {
                var rcSel = this.c1FlexGrid1.GetCellRect(sel.TopRow, sel.LeftCol);
                if (!sel.IsSingleCell)
                {
                    rcSel = Rectangle.Union(rcSel, this.c1FlexGrid1.GetCellRect(sel.BottomRow, sel.RightCol));
                }
                if (rcSel != _marqueeRect)
                {
                    _marqueeRect = rcSel;
                    c1FlexGrid1.Invalidate();
                }
            }

            // draw marquee rectangle
            if (!_marqueeRect.IsEmpty)
            {
                e.Graphics.DrawRectangle(_marqueePen, _marqueeRect);
            }
        }
    }
}
