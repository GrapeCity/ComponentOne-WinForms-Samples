using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ColumnFilters
{
    public partial class SearchBox : UserControl
    {
        //--------------------------------------------------------------------
        #region ** ctor

        public SearchBox()
        {
            InitializeComponent();
        }

        #endregion

        //--------------------------------------------------------------------
        #region ** object model

        public override string  Text
        {
	        get { return _txtSearch.Text; }
            set { _txtSearch.Text = value; }
        }

        [DefaultValue(100)]
        public int Delay
        {
            get { return _timer.Interval; }
            set { _timer.Interval = value; }
        }
        public event EventHandler Search;
        protected virtual void OnSearch(EventArgs e)
        {
            if (Search != null)
            {
                Search(this, e);
            }
        }

        #endregion

        //--------------------------------------------------------------------
        #region ** overrides

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            var rc = ClientRectangle;
            rc.Inflate(-1, -1);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            DrawRoundRect(e.Graphics, SystemPens.ControlDark, SystemBrushes.Window, rc);
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            var h = ClientSize.Height;
            var w = ClientSize.Width - _lblIcon.Width - _lblClear.Width;

            _lblWatermark.Bounds = new Rectangle(
                _lblIcon.Width, (h - _lblWatermark.Height) / 2,
                w, _lblWatermark.Height);

            _txtSearch.Bounds = new Rectangle(
                _lblIcon.Width, (h - _txtSearch.Height) / 2 + 1,
                w, _txtSearch.Height);
        }

        #endregion

        //--------------------------------------------------------------------
        #region ** event handlers

        // update clear label
        void _txtSearch_TextChanged(object sender, EventArgs e)
        {
            _lblClear.Visible = _txtSearch.Text.Length > 0;
            _timer.Stop();
            _timer.Start();
        }

        // fire TextChanged on the timer
        void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            OnSearch(EventArgs.Empty);
        }

        // clear search text
        void _lblClear_Click(object sender, EventArgs e)
        {
            _txtSearch.Text = string.Empty;
            _timer.Stop();
            OnSearch(EventArgs.Empty);
        }

        // show/hide watermark
        void _lblWatermark_Click(object sender, EventArgs e)
        {
            _txtSearch.Focus();
        }
        void _txtSearch_Enter(object sender, EventArgs e)
        {
            _lblWatermark.Visible = false;
        }
        void _txtSearch_Leave(object sender, EventArgs e)
        {
            _lblWatermark.Visible = _txtSearch.Text.Length == 0;
        }

        #endregion

        //--------------------------------------------------------------------
        #region ** implementation

        // draw/fill rounded rectangle
        static void DrawRoundRect(Graphics g, Pen p, Brush b, Rectangle rc)
        {
            // left rectangle
            var rcl = rc;
            rcl.Width = Math.Min(rc.Height, rc.Width / 3);

            // right rectangle
            var rcr = rcl;
            rcr.X = rc.Right - rcl.Width;

            // middle rectangle
            rc.X += rc.Height;
            rc.Width -= 2 * rc.Height;

            // prepare path
            using (var gp = new GraphicsPath())
            {
                gp.AddLine(rc.X, rc.Y, rc.Right, rc.Y);
                gp.AddArc(rcr, 270, 180);
                gp.AddLine(rc.Right, rc.Bottom, rc.X, rc.Bottom);
                gp.AddArc(rcl, 90, 180);
                gp.CloseFigure();

                // fill path
                if (b != null)
                {
                    g.FillPath(b, gp);
                }

                // draw path
                if (p != null)
                {
                    g.DrawPath(p, gp);
                }
            }
        }

        #endregion
    }
}
