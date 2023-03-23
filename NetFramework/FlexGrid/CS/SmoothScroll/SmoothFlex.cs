using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace SmoothScroll
{
    public class SmoothFlex : C1.Win.C1FlexGrid.C1FlexGrid
    {
        // ** fields
        const double SCROLL_STEP = 0.2;
        Timer _timer = new Timer();
        PictureBox _img = new PictureBox();

        Point _ptMouseDown;
        bool _middleButtonIsDown, _wasScrolling;

        // ** ctor
        public SmoothFlex()
        {
            // initialize smooth scroll timer
            _timer.Interval = 50;
            _timer.Tick += timer_Tick;

            // initialize smooth scroll indicator
            _img.SizeMode = PictureBoxSizeMode.AutoSize;
            _img.Image = Properties.Resources.smoothScroll;
            _img.Visible = false;
            Controls.Add(_img);
        }

        // ** start/stop smooth scrolling

        public bool IsScrolling
        {
            get { return _img.Visible; }
            set
            {
                if (value)
                {
                    var pt = PointToClient(Control.MousePosition);
                    pt.Offset(-_img.Width / 2, -_img.Height / 2);
                    _img.Location = pt;
                    _img.Visible = true;
                    _timer.Start();
                }
                else
                {
                    _img.Visible = false;
                    _timer.Stop();
                }
            }
        }

        // ** event handlers

        // monitor middle button to start smooth scrolling
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // stop scrolling if any
            if (IsScrolling)
            {
                _wasScrolling = true;
                IsScrolling = false;
            }
            else
            {
                _wasScrolling = false;
            }

            // get ready to start scrolling on mouse up
            _middleButtonIsDown = e.Button == MouseButtons.Middle;
            _ptMouseDown = new Point(e.X, e.Y);

            base.OnMouseDown(e);
        }

        // start smooth scrolling when user releases the middle button
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (_middleButtonIsDown && !_wasScrolling && e.Button == MouseButtons.Middle)
            {
                IsScrolling = true;
                _wasScrolling = true;
            }
            base.OnMouseUp(e);
        }

        // stop scrolling when we lose focus
        protected override void OnLostFocus(EventArgs e)
        {
            IsScrolling = false;
            _wasScrolling = false;
            base.OnLostFocus(e);
        }

        // perform smooth scrolling
        void timer_Tick(object sender, EventArgs e)
        {
            var pt = PointToClient(Control.MousePosition);
            int dx = (int)((_ptMouseDown.X - pt.X) * SCROLL_STEP);
            int dy = (int)((_ptMouseDown.Y - pt.Y) * SCROLL_STEP);

            if (Math.Abs(dx) > 4 * Math.Abs(dy))
            {
                dy = 0;
            }
            else if (Math.Abs(dy) > 4 * Math.Abs(dx))
            {
                dx = 0;
            }

            var sp = ScrollPosition;
            sp.Offset(dx, dy);
            ScrollPosition = sp;
        }
    }
}
