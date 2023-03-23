using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using C1.Win.C1FlexGrid;

namespace FlexCalc
{
    public class FlexCalc : C1.Win.C1FlexGrid.C1FlexGrid
    {
        // ** fields
        FlexCalcEngine _ce;
        CellStyle _csHeader;
        Rectangle _marqueeRect = Rectangle.Empty;
        Pen _marqueePen = new Pen(Color.Black, 2);

        // ** ctor

        /// <summary>
        /// Initializes a new instance of a FlexCalc control.
        /// </summary>
        public FlexCalc()
        {
            // create calc engine
            _ce = new FlexCalcEngine(this);

            // use owner-draw to render row and column headers
            DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;

            // center align row and column headers
            _csHeader = this.Styles.Add("hdr");
            _csHeader.TextAlign = TextAlignEnum.CenterCenter;
        }

        // ** object model

        // data context exposes objects to the calc engine
        public object DataContext { get; set; }

        // evaluates the content of a cell using the calc engine
        public object Evaluate(int row, int col)
        {
            var val = this[row, col];
            var text = val as string;
            if (!string.IsNullOrEmpty(text))
            {
                double dbl;
                if (text[0] == '=')
                {
                    val = _ce.Evaluate(text);
                }
                else if (double.TryParse(text, out dbl))
                {
                    val = dbl;
                }
            }
            return val;
        }

        // evaluates an expression using the calc engine
        public object Evaluate(string expression)
        {
            return _ce.Evaluate(expression);
        }

        // gets the address of a cell using Excel notation (e.g. A1)
        public string GetAddress(int row, int col)
        {
            return string.Format("{0}{1}", 
                GetAlphaColumnHeader(col - Cols.Fixed),
                row - Rows.Fixed + 1);
        }

        // gets the address of a cell range using Excel notation (e.g. A1:B10)
        public string GetAddress(CellRange rng)
        {
            return rng.IsSingleCell
                ? GetAddress(rng.r1, rng.c1)
                : string.Format("{0}:{1}", GetAddress(rng.r1, rng.c1), GetAddress(rng.r2, rng.c2));
        }

        // ** overrides

        // get data for display (evaluates formulas)
        public override string GetDataDisplay(int row, int col, out System.Drawing.Image img, out C1.Win.C1FlexGrid.CheckEnum chk)
        {
            // no image, no checkbox
            img = null;
            chk = C1.Win.C1FlexGrid.CheckEnum.None;

            // get raw value
            object val = null;
            try
            {
                val = Evaluate(row, col);
            }
            catch (Exception x)
            {
                val = "ERR: " + x.Message;
            }

            // apply cell format
            var ifmt = val as IFormattable;
            if (ifmt != null)
            {
                var s = GetCellStyleDisplay(row, col);
                var fmt = !string.IsNullOrEmpty(s.Format)
                    ? s.Format
                    : "#,##0.#########"; // set default precision to 9 digits
                val = ifmt.ToString(fmt, CultureInfo.CurrentCulture);
            }
            else
            {
                // remove leading quotes (as Excel)
                var text = val as string;
                if (!string.IsNullOrEmpty(text) && text[0] == '\'')
                {
                    val = text.Substring(1);
                }
            }

            // done
            return val != null ? val.ToString() : null;
        }

        // invalidate all cells that contain formulas after any edits
        public override bool SetData(int row, int col, object value)
        {
            var retVal = base.SetData(row, col, value);

            if (retVal)
            {
                for (int r = TopRow; r <= BottomRow; r++)
                {
                    for (int c = LeftCol; c <= RightCol; c++)
                    {
                        var text = this.GetData(r, c) as string;
                        if (!string.IsNullOrEmpty(text) && text[0] == '=')
                        {
                            Invalidate(r, c);
                        }
                    }
                }
            }

            return retVal;
        }

        // draw row and column headers
        protected override void OnOwnerDrawCell(C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (e.Col == 0 && e.Row >= Rows.Fixed)
            {
                var row = e.Row - Rows.Fixed + 1;
                e.Text = row.ToString();
                e.Style = _csHeader;
            }
            else if (e.Row == 0 && e.Col >= Cols.Fixed)
            {
                var col = e.Col - Cols.Fixed;
                e.Text = GetAlphaColumnHeader(col);
                e.Style = _csHeader;
            }
            base.OnOwnerDrawCell(e);
        }
        static string GetAlphaColumnHeader(int i)
        {
            return GetAlphaColumnHeader(i, string.Empty);
        }
        static string GetAlphaColumnHeader(int i, string s)
        {
            var rem = i % 26;
            s = (char)((int)'A' + rem) + s;
            i = i / 26 - 1;
            return i < 0 ? s : GetAlphaColumnHeader(i, s);
        }

        // draw Excel-style marquee to highlight the selection
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            // fire event
            base.OnPaint(e);

            // compute marquee rectangle
            var sel = this.Selection;
            if (sel.IsValid)
            {
                var rcSel = this.GetCellRect(sel.TopRow, sel.LeftCol);
                if (!sel.IsSingleCell)
                {
                    rcSel = Rectangle.Union(rcSel, this.GetCellRect(sel.BottomRow, sel.RightCol));
                }
                if (rcSel != _marqueeRect)
                {
                    _marqueeRect = rcSel;
                    Invalidate();
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
