//----------------------------------------------------------------------------
// GradientCenterControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Util.Win;
using C1.Win.Document;
using NSD = C1.Win.Interop;

namespace FlexReportDesignerApp.Controls.Background
{
    internal class GradientCenterControl : Control
    {
        private static readonly Size c_MarkSize = new Size(3, 5);
        private const int c_MarkOffs = 4;

        private GradientStopCollection _stops;
        private Point _gradientCenter;
        private Point _centerPoint;
        private C1RadialBrush _brush;

        #region Constructors
        public GradientCenterControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            _stops=new GradientStopCollection();
            _stops.Add(new GradientStop(0, Color.White));
            _stops.Add(new GradientStop(1, Color.Black));
            _gradientCenter = new Point(50, 50);
            UpdateBrush();
        }
        #endregion

        #region Private
        private Point GetGradientCenter(
            int x,
            int y)
        {
            Rectangle r = ClientRectangle;
            var result = new Point
            {
                X = (int) Math.Round(x/(float) r.Width*100f),
                Y = (int) Math.Round(y/(float) r.Height*100f)
            };
            return result;
        }

        private Point GetCenterPoint(
            int x,
            int y)
        {
            Rectangle r = ClientRectangle;
            var result = new Point
            {
                X = r.Left + (int) Math.Round(x*r.Width/100f),
                Y = r.Top + (int) Math.Round(y*r.Height/100f)
            };
            return result;
        }

        private void UpdateBrush()
        {
            _brush = new C1RadialBrush();
            _brush.Center = new NSD.Point(_gradientCenter.X/100d, _gradientCenter.Y/100d);
            foreach (var stop in _stops)
            {
                _brush.GradientStops.Add(stop);
            }
        }
        #endregion

        #region Protected
        protected virtual void OnGradientCenterChanged()
        {
            if (GradientCenterChanged != null)
                GradientCenterChanged(this, EventArgs.Empty);
        }

        protected override void OnResize(
            EventArgs e)
        {
            _centerPoint = GetCenterPoint(_gradientCenter.X, _gradientCenter.Y);
            UpdateBrush();
            base.OnResize(e);
        }

        protected override void OnPaint(
            PaintEventArgs e)
        {
            Utils.DrawBackground(e.Graphics, BackColor, _brush, ClientRectangle);
            Utils.DrawPointMark(e.Graphics, _centerPoint, c_MarkSize, c_MarkOffs);

            base.OnPaint(e);
        }

        protected override void OnMouseDown(
            MouseEventArgs e)
        {
            GradientCenter = GetGradientCenter(e.X, e.Y);
            OnGradientCenterChanged();

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GradientCenter = GetGradientCenter(e.X, e.Y);
                OnGradientCenterChanged();
            }

            base.OnMouseMove(e);
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientStopCollection GradientStops
        {
            get { return _stops; }
            set
            {
                _stops = value;
                UpdateBrush();
                Refresh();
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Point GradientCenter
        {
            get { return _gradientCenter; }
            set
            {
                value.X = Math.Min(100, Math.Max(value.X, 0));
                value.Y = Math.Min(100, Math.Max(value.Y, 0));
                if (_gradientCenter == value)
                    return;

                _gradientCenter = value;
                _centerPoint = GetCenterPoint(_gradientCenter.X, _gradientCenter.Y);
                UpdateBrush();
                Refresh();
            }
        }
        #endregion
       
        #region Events

        public event EventHandler GradientCenterChanged;

        #endregion
    }
}
