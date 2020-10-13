using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class CustomCellMerging : C1DemoForm
    {
        Bitmap _bmp = new Bitmap(80, 80);
        
        public CustomCellMerging()
        {
            InitializeComponent();
        }

        private void CustomCellMerging_Load(object sender, EventArgs e)
        {
            // don't change the TV schedule
            _flex.AllowEditing = false;
            _flex.AllowDragging = AllowDraggingEnum.None;
            _flex.AllowResizing = AllowResizingEnum.None;

            // create header row (weekdays)
            _flex.Cols.Count = 8;
            _flex.Rows.Count = 0;
            _flex.AddItem("\tMonday\tTuesday\tWednesday\tThursday\tFriday\tSaturday\tSunday");
            _flex.Rows.Fixed = 1;

            // add the schedule
            _flex.AddItem("12:00\tWalker\tMorning Show\tMorning Show\tSport\tWeather\tN/A\tN/A");
            _flex.AddItem("13:00\tToday Show\tToday Show\tSesame Street\tFootball\tMarket Watch\tN/A\tN/A");
            _flex.AddItem("14:00\tToday Show\tToday Show\tKid Zone\tFootball\tSoap Opera\tN/A\tN/A");
            _flex.AddItem("15:00\tNews\tNews\tNews\tNews\tNews\tN/A\tN/A");
            _flex.AddItem("16:00\tNews\tNews\tNews\tNews\tNews\tN/A\tN/A");

            // add some formatting
            _flex.Styles.Normal.Border.Style = BorderStyleEnum.Double;
            _flex.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
            _flex.Styles.Fixed.BackColor = Color.Navy;
            _flex.Styles.Fixed.Border.Color = Color.Khaki;
            _flex.Cols[0].Width = 50;
            _flex.Rows.MinSize = 40;
            _flex.Rows[1].StyleNew.BackColor = Color.Gold;
            _flex.Rows[2].StyleNew.BackColor = Color.Khaki;
            _flex.Rows[3].StyleNew.BackColor = Color.Goldenrod;
            _flex.Rows[4].StyleNew.BackColor = Color.Linen;
            _flex.Rows[5].StyleNew.BackColor = Color.Beige;
            for (int i = 1; i < _flex.Cols.Count; i++)
                _flex.Cols[i].Width = 100;

            // allow merging (that's the whole point)
            _flex.AllowMerging = AllowMergingEnum.Free;
            for (int i = 1; i < _flex.Cols.Count; i++)
                _flex.Cols[i].AllowMerging = true;
            for (int i = 1; i < _flex.Rows.Count; i++)
                _flex.Rows[i].AllowMerging = true;

            // initialize bitmap for custom painting
            Rectangle rc = Rectangle.Empty;
            rc.Size = _bmp.Size;
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rc);
            using (Graphics g = Graphics.FromImage(_bmp))
            using (PathGradientBrush br = new PathGradientBrush(path))
            {
                br.CenterColor = Color.Transparent;
                br.SurroundColors = new Color[] { Color.FromArgb(50, Color.Blue) };
                g.FillRectangle(br, rc);
            }
        }

        private void _flex_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (e.Row > 0 && e.Col > 0)
            {
                e.DrawCell(DrawCellFlags.Background);
                e.Graphics.DrawImage(_bmp, e.Bounds);
                e.DrawCell(DrawCellFlags.Border | DrawCellFlags.Content);
                e.Handled = true;
            }
        }
    }

    /// <summary>
    /// Inherits from C1FlexGrid and implements custom cell merging by
    /// overriding the GetMergedRange virtual method.
    /// 
    /// The control calls this function internally, to determine row
    /// and column spans.
    /// 
    /// Note: This is a critical function. It should be as fast as 
    /// possible, and always return consistent ranges. Otherwise the 
    /// control will slow down or paint in really strange ways.
    /// </summary>
    public class FlexTVGuide : C1.Win.C1FlexGrid.C1FlexGrid
    {
        override public CellRange GetMergedRange(int row, int col, bool clip)
        {
            // create basic cell range
            CellRange rg = GetCellRange(row, col);

            // expand left/right
            int i;
            int cnt = Cols.Count;
            int ifx = Cols.Fixed;
            for (i = rg.c1; i < cnt - 1; i++)
            {
                if (GetDataDisplay(rg.r1, i) != GetDataDisplay(rg.r1, i + 1)) break;
                rg.c2 = i + 1;
            }
            for (i = rg.c1; i > ifx; i--)
            {
                if (GetDataDisplay(rg.r1, i) != GetDataDisplay(rg.r1, i - 1)) break;
                rg.c1 = i - 1;
            }

            // expand up/down
            cnt = Rows.Count;
            ifx = Rows.Fixed;
            for (i = rg.r1; i < cnt - 1; i++)
            {
                if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i + 1, rg.c1)) break;
                rg.r2 = i + 1;
            }
            for (i = rg.r1; i > ifx; i--)
            {
                if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i - 1, rg.c1)) break;
                rg.r1 = i - 1;
            }

            // done
            return rg;
        }
    }
}
