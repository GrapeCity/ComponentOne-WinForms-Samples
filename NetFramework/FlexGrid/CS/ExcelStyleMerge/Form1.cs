using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ExcelStyleMerge
{
    public partial class Form1 : Form
    {
        Pen _marquee = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();

            // enable custom merging
            _flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom;

            // some settings to make the marquee look nice
            _flex.Styles.Highlight.ForeColor = Color.Black;
            _flex.Styles.Highlight.BackColor = Color.LightBlue;
            _flex.FocusRect = FocusRectEnum.Solid;
            _flex.Paint += _flex_Paint;
            _flex.AfterSelChange += _flex_AfterSelChange;
            _flex.StartEdit += _flex_StartEdit;
        }

        //---------------------------------------------------------------------------------------
        #region ** marquee

        void _flex_Paint(object sender, PaintEventArgs e)
        {
            // draw marquee if not editing
            if (_flex.Editor == null)
            {
                // get selection rectangle
                var sel = _flex.Selection;
                var rc1 = _flex.GetCellRect(sel.TopRow, sel.LeftCol);
                var rc2 = _flex.GetCellRect(sel.BottomRow, sel.RightCol);
                var rc = Rectangle.Union(rc1, rc2);

                // draw marquee around the selection
                e.Graphics.DrawRectangle(_marquee, rc);
            }
        }
        void _flex_AfterSelChange(object sender, RangeEventArgs e)
        {
            textBox1.Text = _flex.GetDataDisplay(_flex.Row, _flex.Col);
            _flex.Invalidate();
        }
        void _flex_StartEdit(object sender, RowColEventArgs e)
        {
            _flex.Invalidate();
        }
        void textBox1_TextChanged(object sender, EventArgs e)
        {
            _flex[_flex.Row, _flex.Col] = textBox1.Text;
        }

        #endregion

        //---------------------------------------------------------------------------------------
        #region ** merging logic

        void button1_Click(object sender, EventArgs e)
        {
            AddMergedRange(_flex.Selection);
        }
        void button2_Click(object sender, EventArgs e)
        {
            RemoveMergedRange(_flex.Selection);
        }
        void AddMergedRange(CellRange rng)
        {
            if (!rng.IsSingleCell)
            {
                RemoveMergedRange(rng);
                _flex.MergedRanges.Add(rng);
            }
        }
        void RemoveMergedRange(CellRange rng)
        {
            for (int i = 0; i < _flex.MergedRanges.Count; i++)
            {
                if (RangesIntersect(rng, _flex.MergedRanges[i]))
                {
                    _flex.MergedRanges.RemoveAt(i);
                    i--;
                }
            }
        }
        static bool RangesIntersect(CellRange rng1, CellRange rng2)
        {
            if (rng1.BottomRow < rng2.TopRow) return false;
            if (rng1.TopRow > rng2.BottomRow) return false;
            if (rng1.RightCol < rng2.LeftCol) return false;
            if (rng1.LeftCol > rng2.RightCol) return false;
            return true;
        }

        #endregion
    }
}
