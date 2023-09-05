//----------------------------------------------------------------------------
// GradientBoundsControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Util.Win;
using C1.Win.C1Document;
using NSD=C1.Win.Interop;

namespace FlexReportDesignerApp.Controls.Background
{
    internal class GradientBoundsControl : Control
    {
        internal enum Corner
        {
            Start,
            End
        }

        private static readonly Size ActiveMarkSize = new Size(3, 5);
        private static readonly Size DeactiveMarkSize = new Size(2, 4);
        private const int MarkOffset = 4;

        private Corner _activeCorner = Corner.Start;
        private GradientStopCollection _stops;
        private Point _gradientStart;
        private Point _gradientEnd;
        private Point _startPoint;
        private Point _endPoint;
        private C1LinearBrush _brush;

        #region Constructors

        public GradientBoundsControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            _stops = new GradientStopCollection
            {
                new GradientStop(0, Color.White),
                new GradientStop(1, Color.Black)
            };
            _gradientStart = new Point(0, 50);
            _gradientEnd = new Point(100, 50);
            UpdateBrush();
        }

        #endregion

        #region Events

        public event EventHandler GradientStartChanged;

        public event EventHandler GradientEndChanged;

        public event EventHandler ActiveCornerChanged;

        #endregion

        #region Private
        private Point GetGradientCorner(int x, int y)
        {
            Rectangle r = ClientRectangle;
            var result = new Point
            {
                X = (int) Math.Round(x/(float) r.Width*100f),
                Y = (int) Math.Round(y/(float) r.Height*100f)
            };
            return result;
        }

        private Point GetCornerPoint(int x, int y)
        {
            Rectangle r = ClientRectangle;
            var result = new Point
            {
                X = r.Left + (int) Math.Round(x*r.Width/100f),
                Y = r.Top + (int) Math.Round(y*r.Height/100f)
            };
            return result;
        }

        private Size GetMarkSize(Corner corner)
        {
            return corner == _activeCorner ? ActiveMarkSize : DeactiveMarkSize;
        }

        private void UpdateBrush()
        {
            _brush = new C1LinearBrush
            {
                StartPoint = new NSD.Point(_gradientStart.X/100d, _gradientStart.Y/100d),
                EndPoint = new NSD.Point(_gradientEnd.X/100d, _gradientEnd.Y/100d)
            };

            foreach (var stop in _stops)
            {
                _brush.GradientStops.Add(stop);
            }
        }

        private void DetectActiveCorner(int x, int y)
        {
            var hits = new List<HitInfo>();
            var hitStart = HitTestCorner(x, y, Corner.Start, _startPoint);
            if (hitStart != null) hits.Add(hitStart);
            var hitEnd = HitTestCorner(x, y, Corner.End, _endPoint);
            if (hitEnd != null) hits.Add(hitEnd);

            if (hits.Count == 0) return;
            if (hits.Count > 1) hits.Sort(new HitInfo.Comparer());
            var activeCorner = hits[0].Corner;

            if (activeCorner != _activeCorner)
            {
                ActiveCorner = activeCorner;
                OnActiveCornerChanged();
            }
        }

        private HitInfo HitTestCorner(int x, int y, Corner corner, Point point)
        {
            var activeRadius = ActiveMarkSize.Height + MarkOffset/2 + 1;
            var deactiveRadius = DeactiveMarkSize.Height + MarkOffset/2 + 1;
            var testRadius = _activeCorner == corner ? activeRadius : deactiveRadius;
            var radius = (int)Math.Sqrt((point.X - x) * (point.X - x) + (point.Y - y) * (point.Y - y));
            if (radius <= testRadius)
                return new HitInfo(corner, radius, _activeCorner == corner);
            return null;
        }

        #endregion

        #region Protected
        protected virtual void OnGradientStartChanged()
        {
            if (GradientStartChanged != null)
                GradientStartChanged(this, EventArgs.Empty);
        }

        protected virtual void OnGradientEndChanged()
        {
            if (GradientEndChanged != null)
                GradientEndChanged(this, EventArgs.Empty);
        }

        protected virtual void OnActiveCornerChanged()
        {
            if (ActiveCornerChanged != null)
                ActiveCornerChanged(this, EventArgs.Empty);
        }

        protected override void OnResize(
            EventArgs e)
        {
            _startPoint = GetCornerPoint(_gradientStart.X, _gradientStart.Y);
            _endPoint = GetCornerPoint(_gradientEnd.X, _gradientEnd.Y);
            UpdateBrush();
            base.OnResize(e);
        }

        protected override void OnPaint(
            PaintEventArgs e)
        {
            Utils.DrawBackground(e.Graphics, BackColor, _brush, ClientRectangle);
            Utils.DrawPointMark(e.Graphics, _startPoint, GetMarkSize(Corner.Start), MarkOffset);
            Utils.DrawPointMark(e.Graphics, _endPoint, GetMarkSize(Corner.End), MarkOffset);

            base.OnPaint(e);
        }

        protected override void OnMouseDown(
            MouseEventArgs e)
        {
            DetectActiveCorner(e.X, e.Y);

            switch (_activeCorner)
            {
                case Corner.Start:
                    GradientStart = GetGradientCorner(e.X, e.Y);
                    OnGradientStartChanged();
                    break;
                case Corner.End:
                    GradientEnd = GetGradientCorner(e.X, e.Y);
                    OnGradientEndChanged();
                    break;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (_activeCorner)
                {
                    case Corner.Start:
                        GradientStart = GetGradientCorner(e.X, e.Y);
                        OnGradientStartChanged();
                        break;
                    case Corner.End:
                        GradientEnd = GetGradientCorner(e.X, e.Y);
                        OnGradientEndChanged();
                        break;
                }
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
        public Point GradientStart
        {
            get { return _gradientStart; }
            set
            {
                value.X = Math.Min(100, Math.Max(value.X, 0));
                value.Y = Math.Min(100, Math.Max(value.Y, 0));
                if (_gradientStart == value)
                    return;

                _gradientStart = value;
                _startPoint = GetCornerPoint(_gradientStart.X, _gradientStart.Y);
                UpdateBrush();
                Refresh();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Point GradientEnd
        {
            get { return _gradientEnd; }
            set
            {
                value.X = Math.Min(100, Math.Max(value.X, 0));
                value.Y = Math.Min(100, Math.Max(value.Y, 0));
                if (_gradientEnd == value)
                    return;

                _gradientEnd = value;
                _endPoint = GetCornerPoint(_gradientEnd.X, _gradientEnd.Y);
                UpdateBrush();
                Refresh();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Corner ActiveCorner
        {
            get { return _activeCorner; }
            set
            {
                if (_activeCorner == value) return;

                _activeCorner = value;
                Invalidate();
            }
        }

        #endregion

        #region nested class

        private class HitInfo
        {
            public Corner Corner { get; private set; }
            public int Radius { get; private set; }
            public bool IsActive { get; private set; }

            public HitInfo(Corner corner, int radius, bool isActive)
            {
                Corner = corner;
                Radius = radius;
                IsActive = isActive;
            }

            internal class Comparer : IComparer<HitInfo>
            {
                public int Compare(HitInfo x, HitInfo y)
                {
                    if (x.Radius < y.Radius) return -1;
                    if (x.Radius > y.Radius) return 1;
                    if (x.IsActive) return -1;
                    if (y.IsActive) return 1;
                    return 0;
                }
            }
        }

        #endregion
    }
}
