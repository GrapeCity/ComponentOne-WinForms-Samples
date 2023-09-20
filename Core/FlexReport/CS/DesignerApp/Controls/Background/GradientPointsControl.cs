//----------------------------------------------------------------------------
// GradientPointsControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FlexReportDesignerApp.Controls.Background
{
    internal enum GradientType
    {
        Blend,
        InterpolationColors,
    }

    internal class GradientPoint
    {
        private GradientPointCollection _owner;
        private float _position;
        private float _factor;
        private Color _color;

        #region Protected
        protected virtual void NotifyOwner()
        {
            if (_owner != null)
                _owner.NotifyOwner();
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientPointCollection Owner
        {
            get { return _owner; }
            internal set { _owner = value; }
        }

        public float Position
        {
            get { return _position; }
            set
            {
                value = Math.Min(1, Math.Max(0, value));
                if (_position == value)
                    return;

                _position = value;
                if (_owner != null)
                    _owner.Sort();
            }
        }

        public float Factor
        {
            get { return _factor; }
            set
            {
                value = Math.Min(1, Math.Max(0, value));
                if (_factor == value)
                    return;

                _factor = value;
                NotifyOwner();
            }
        }

        public Color Color
        {
            get { return _color; }
            set
            {
                if (_color == value)
                    return;

                _color = value;
                NotifyOwner();
            }
        }

        public object Tag { get; set; }

        #endregion
    }

    internal class GradientPointCollection : Collection<GradientPoint>
    {
        private readonly GradientPointsControl _owner;

        #region Constructors
        public GradientPointCollection(
            GradientPointsControl owner)
        {
            _owner = owner;
        }
        #endregion

        #region Protected
        protected internal virtual void NotifyOwner()
        {
            if (_owner != null)
                _owner.OnPointsChanged(this);
        }

        protected override void ClearItems()
        {
            foreach (GradientPoint gp in this)
                gp.Owner = null;
            base.ClearItems();
            NotifyOwner();
        }

        protected override void InsertItem(
            int index,
            GradientPoint item)
        {
            item.Owner = this;
            base.InsertItem(index, item);
            NotifyOwner();
        }

        protected override void RemoveItem(int index)
        {
            this[index].Owner = null;
            base.RemoveItem(index);
            NotifyOwner();
        }

        protected override void SetItem(int index, GradientPoint item)
        {
            this[index].Owner = null;
            item.Owner = this;
            base.SetItem(index, item);
            NotifyOwner();
        }
        #endregion

        #region Public
        public void Sort()
        {
            ((List<GradientPoint>)Items).Sort(Comparer.Instance);
            NotifyOwner();
        }
        #endregion

        #region Public properties
        #endregion

        #region Nested types
        private class Comparer : IComparer<GradientPoint>
        {
            public static readonly Comparer Instance = new Comparer();

            #region IComparer implementation
            int IComparer<GradientPoint>.Compare(GradientPoint x, GradientPoint y)
            {
                return Math.Sign(x.Position - y.Position);
            }
            #endregion
        }
        #endregion
    }

    internal class GradientPointEventArgs : EventArgs
    {
        private readonly GradientPoint _point;

        #region Constructors
        public GradientPointEventArgs(
            GradientPoint point)
        {
            _point = point;
        }
        #endregion

        #region Public properties
        public GradientPoint Point
        {
            get { return _point; }
        }
        #endregion
    }

    internal class GradientPointsControl : Control
    {
        private const int c_MarkWidth = 12; // should be even

        private const GradientType c_DefGradientType = GradientType.InterpolationColors;
        private static readonly Color c_DefStartColor = Color.Black;
        private static readonly Color c_DefEndColor = Color.White;
        private static readonly Padding c_DefPadding = new Padding(4, 1, 4, 1);

        private static readonly Color c_SelectedItemBorderColor1 = Color.FromArgb(255, 226, 148);
        private static readonly Color c_SelectedItemBorderColor2 = Color.FromArgb(239, 72, 16);
        private static readonly Color c_HighlightedItemBorderColor1 = Color.FromArgb(255, 226, 148);
        private static readonly Color c_HighlightedItemBorderColor2 = Color.FromArgb(242, 148, 54);
        private static readonly Color c_ItemBorderColor2 = SystemColors.ControlDark;
        private static readonly Color c_ItemBorderColor = SystemColors.ControlDarkDark;

        private GradientType _gradientType = c_DefGradientType;
        private Color _startColor;
        private Color _endColor;
        private readonly GradientPointCollection _gradientPoints;

        private GradientPoint _selectedPoint;
        private GradientPoint _highlightedPoint;
        private GradientPoint _draggedPoint;
        private int _updateCounter;
        // disable updating (painting) control
        private bool _internalChanges;

        #region Constructors
        public GradientPointsControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            _gradientPoints = new GradientPointCollection(this);
            ResetGradientPoints();
            _startColor = c_DefStartColor;
            _endColor = c_DefEndColor;
            Padding = c_DefPadding;

            _selectedPoint = _gradientPoints[0];
        }
        #endregion

        #region Private properties
        private bool UpdateLocked
        {
            get { return _updateCounter != 0 || _internalChanges; }
        }
        #endregion

        #region Private static
        /// <summary>
        /// Calculates average color between to colors,
        /// delta defines a position between to colors, 
        /// 0 - result will equals c1,
        /// 1 - result will equal c2,
        /// 0.5 - average color between c1 and c2.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        private static Color GetMixedColor(
            Color c1,
            Color c2,
            float delta)
        {
            return Color.FromArgb(
                (c1.A + (int)Math.Round((c2.A - c1.A) * delta)) & 0xFF,
                (c1.R + (int)Math.Round((c2.R - c1.R) * delta)) & 0xFF,
                (c1.G + (int)Math.Round((c2.G - c1.G) * delta)) & 0xFF,
                (c1.B + (int)Math.Round((c2.B - c1.B) * delta)) & 0xFF);
        }
        #endregion

        #region Internal
        protected internal virtual void OnPointsChanged(
            GradientPointCollection points)
        {
            if (_selectedPoint != null)
            {
                // update selected item
                if (_gradientPoints.IndexOf(_selectedPoint) == -1)
                {
                    if (_gradientPoints.Count == 0)
                        SelectedPoint = null;
                    else
                    {
                        int i;
                        for (i = 0; i < _gradientPoints.Count && _gradientPoints[i].Position < _selectedPoint.Position; i++) ;

                        if (i >= _gradientPoints.Count)
                            SelectedPoint = _gradientPoints[_gradientPoints.Count - 1];
                        else
                            SelectedPoint = _gradientPoints[i];
                    }
                    if (!UpdateLocked)
                        OnSelectedPointChanged();
                }
            }
            if (!UpdateLocked)
                Refresh();
        }
        #endregion

        #region Protected
        protected virtual void OnPointAdded(
            GradientPoint point)
        {
            if (PointAdded != null)
                PointAdded(this, new GradientPointEventArgs(point));
        }

        protected virtual void OnPointChanged(
            GradientPoint point)
        {
            if (PointChanged != null)
                PointChanged(this, new GradientPointEventArgs(point));
        }

        protected virtual void OnSelectedPointChanged()
        {
            if (SelectedPointChanged != null)
                SelectedPointChanged(this, EventArgs.Empty);
        }

        protected override Padding DefaultPadding
        {
            get { return c_DefPadding; }
        }

        protected virtual bool ShouldSerializeStartColor()
        {
            return _startColor != c_DefStartColor;
        }

        protected virtual void ResetStartColor()
        {
            _startColor = c_DefStartColor;
        }

        protected virtual bool ShouldSerializeEndColor()
        {
            return _endColor != c_DefEndColor;
        }

        protected virtual void ResetEndColor()
        {
            _endColor = c_DefEndColor;
        }

        protected virtual bool ShouldSerializeGradientPoints()
        {
            if (_gradientPoints.Count != 2)
                return true;
            if (_gradientPoints[0].Position != 0f)
                return true;
            if (_gradientPoints[0].Factor != 1f)
                return true;
            if (_gradientPoints[0].Color != c_DefStartColor)
                return true;
            if (_gradientPoints[0].Position != 1f)
                return true;
            if (_gradientPoints[0].Factor != 0f)
                return true;
            if (_gradientPoints[0].Color != c_DefEndColor)
                return true;
            return false;
        }

        protected virtual void ResetGradientPoints()
        {
            _gradientPoints.Clear();
            _gradientPoints.Add(new GradientPoint { Position = 0f, Factor = 0f, Color = c_DefStartColor });
            _gradientPoints.Add(new GradientPoint { Position = 1f, Factor = 1f, Color = c_DefEndColor });
        }

        private Rectangle GetGradientRect()
        {
            var result = new Rectangle {X = Padding.Left + (c_MarkWidth + 2)/2, Y = Padding.Top + 3};
            result.Width = ClientSize.Width - (Padding.Right + (c_MarkWidth + 2) / 2) - result.X;
            result.Height = ClientSize.Height - (Padding.Bottom + c_MarkWidth / 2 + 2) - result.Y;
            return result;
        }

        private Rectangle GetPointRect(
            GradientPoint point,
            PointState state,
            Rectangle gradientRect)
        {
            var result = new Rectangle(
                gradientRect.Left + (int) Math.Round(gradientRect.Width*point.Position) - c_MarkWidth/2,
                Padding.Top + 2,
                c_MarkWidth,
                ClientSize.Height - Padding.Top - Padding.Bottom - 2 - 2);
            if (state != PointState.None)
                result.Inflate(2, 2);
            return result;
        }

        private Rectangle GetPointRect(
            GradientPoint point,
            Rectangle gradientRect)
        {
            return GetPointRect(point, GetPointState(point), gradientRect);
        }

        private PointState GetPointState(
            GradientPoint point)
        {
            var result = PointState.None;
            if (point == _selectedPoint)
                result |= PointState.Selected;
            if (point == _highlightedPoint)
                result |= PointState.Highlighted;
            return result;
        }

        private Color GetPointColor(
            GradientPoint gp,
            Bitmap bmp)
        {
            return _gradientType == GradientType.InterpolationColors
                ? gp.Color
                : bmp.GetPixel((int) Math.Round((bmp.Width - 1)*gp.Position), 0);
        }

        private void DrawPoint(
            Graphics g,
            Rectangle r,
            Color backColor,
            PointState state)
        {
            var cr = r;

            // build point graphics path
            using (var backPen = new Pen(BackColor, 1))
            {
                using (var gp = new GraphicsPath())
                {
                    if (state != PointState.None)
                    {
                        gp.AddLine(r.Left, r.Top, r.Right, r.Top);
                        gp.AddLine(r.Right, r.Top, r.Right, r.Bottom - c_MarkWidth / 2 - 2);
                        gp.AddLine(r.Right, r.Bottom - c_MarkWidth / 2 - 2, r.Left + r.Width / 2 - 1, r.Bottom);
                        gp.AddLine(r.Left + r.Width / 2, r.Bottom, r.Left, r.Bottom - c_MarkWidth / 2 - 2);
                        gp.AddLine(r.Left, r.Bottom - c_MarkWidth / 2 - 2, r.Left, r.Top);
                    }
                    else
                    {
                        gp.AddLine(r.Left, r.Top, r.Right, r.Top);
                        gp.AddLine(r.Right, r.Top + 1, r.Right - 1, r.Bottom - c_MarkWidth / 2);
                        gp.AddLine(r.Right, r.Bottom - c_MarkWidth / 2, r.Left + r.Width / 2, r.Bottom);
                        gp.AddLine(r.Left + r.Width / 2 - 1, r.Bottom, r.Left, r.Bottom - c_MarkWidth / 2);
                        gp.AddLine(r.Left, r.Bottom - c_MarkWidth / 2, r.Left, r.Top + 1);
                    }
                    gp.CloseFigure();

                    if (state != PointState.None)
                    {
                        Color c1, c2;
                        if ((state & PointState.Highlighted) != 0)
                        {
                            c1 = c_HighlightedItemBorderColor1;
                            c2 = c_HighlightedItemBorderColor2;
                        }
                        else
                        {
                            c1 = c_SelectedItemBorderColor1;
                            c2 = c_SelectedItemBorderColor2;
                        }

                        g.DrawLine(backPen, r.Left, r.Top, r.Left + 1, r.Top);
                        g.DrawLine(backPen, r.Right - 2, r.Top, r.Right - 1, r.Top);

                        using (var p = new Pen(c2, 1))
                        {
                            g.DrawLine(p, r.Left + 1, r.Top, r.Right - 2, r.Top);
                            g.DrawLine(p, r.Right - 1, r.Y + 1, r.Right - 1, r.Bottom - c_MarkWidth / 2 - 2);
                            g.DrawLine(p, r.Right - 1, r.Bottom - c_MarkWidth / 2 - 2, r.Left + r.Width / 2 - 1, r.Bottom);
                            g.DrawLine(p, r.Left + r.Width / 2, r.Bottom, r.Left, r.Bottom - c_MarkWidth / 2 - 2);
                            g.DrawLine(p, r.Left, r.Bottom - c_MarkWidth / 2 - 2, r.Left, r.Top + 1);
                        }
                        r.Inflate(-1, -1);

                        using (var p = new Pen(c1, 1))
                        {
                            g.DrawLine(p, r.Left, r.Top, r.Right - 1, r.Top);
                            g.DrawLine(p, r.Right - 1, r.Y + 1, r.Right - 1, r.Bottom - c_MarkWidth / 2 - 1);
                            g.DrawLine(p, r.Left + r.Width / 2, r.Bottom - 1, r.Right - 1, r.Bottom - c_MarkWidth / 2 - 1);
                            g.DrawLine(p, r.Left, r.Bottom - c_MarkWidth / 2 - 1, r.Left + r.Width / 2 - 1, r.Bottom - 1);
                            g.DrawLine(p, r.Left, r.Top + 1, r.Left, r.Bottom - c_MarkWidth / 2 - 1);
                        }

                        r.Inflate(-1, -1);
                    }

                    using (var p = new Pen(c_ItemBorderColor, 1))
                    {
                        g.DrawLine(p, r.Left, r.Top, r.Right - 1, r.Top);
                        g.DrawLine(p, r.Right - 1, r.Top + 1, r.Right - 1, r.Bottom - c_MarkWidth / 2);
                        g.DrawLine(p, r.Right - 1, r.Bottom - c_MarkWidth / 2, r.Left + r.Width / 2, r.Bottom - 1);
                        using (var p2 = new Pen(c_ItemBorderColor2, 1))
                            g.DrawLine(p2, r.Left + r.Width / 2 - 1, r.Bottom - 1, r.Left, r.Bottom - c_MarkWidth / 2);
                        g.DrawLine(p, r.Left, r.Bottom - c_MarkWidth / 2, r.Left, r.Top + 1);
                    }
                    r.Inflate(-1, -1);

                    g.DrawRectangle(backPen, r.Left, r.Top, r.Right - 1 - r.Left, r.Bottom - c_MarkWidth / 2 - r.Top);
                    for (int i = 0; i < c_MarkWidth / 2 - 1; i++)
                    {
                        int y = r.Bottom - c_MarkWidth / 2 + i + 1;
                        g.DrawLine(backPen, r.Left + i, y, r.Right - i - 1, y);
                    }

                    r.Inflate(-1, -1);

                    using (var b = new SolidBrush(backColor))
                    {
                        g.FillRectangle(b, r.Left, r.Top, r.Width, r.Height - c_MarkWidth / 2 + 1);
                    }

                    using (var rgn = new Region(gp))
                        g.ExcludeClip(rgn);
                }
            }
        }

        private Brush CreateGradientBrush(
            Rectangle r)
        {
            Color startColor = _startColor.A == 0 ? BackColor : _startColor;
            Color endColor = _endColor.A == 0 ? BackColor : _endColor;
            var b = new LinearGradientBrush(r, startColor, endColor, 0f);
            switch (_gradientType)
            {
                case GradientType.Blend:
                    var blend = new Blend();
                    if (_gradientPoints.Count < 2)
                    {
                        blend.Positions = new[] { 0f, 1f };
                        blend.Factors = new[] { 0f, 1f };
                    }
                    else
                    {
                        var positions = new List<float>();
                        var factors = new List<float>();
                        foreach (GradientPoint t in _gradientPoints)
                        {
                            positions.Add(t.Position);
                            factors.Add(t.Factor);
                        }

                        if (positions[0] != 0)
                        {
                            positions.Insert(0, 0f);
                            factors.Insert(0, 0f);
                        }
                        if (positions[positions.Count - 1] != 1)
                        {
                            positions.Add(1f);
                            factors.Add(1f);
                        }
                        blend.Positions = positions.ToArray();
                        blend.Factors = factors.ToArray();
                    }
                    b.Blend = blend;
                    break;
                case GradientType.InterpolationColors:
                    var colorBlend = new ColorBlend();
                    if (_gradientPoints.Count < 2)
                    {
                        colorBlend.Positions = new float[] { 0f, 1f };
                        colorBlend.Colors = new Color[] { startColor, endColor };
                    }
                    else
                    {
                        int count = _gradientPoints.Count;
                        if (_gradientPoints[0].Position != 0f)
                            count++;
                        if (_gradientPoints[_gradientPoints.Count - 1].Position != 1f)
                            count++;
                        colorBlend.Positions = new float[count];
                        colorBlend.Colors = new Color[count];
                        int offs = 0;
                        if (_gradientPoints[0].Position != 0f)
                        {
                            colorBlend.Positions[0] = 0f;
                            colorBlend.Colors[0] = _gradientPoints[0].Color;
                            offs = 1;
                        }
                        for (int i = 0; i < _gradientPoints.Count; i++)
                        {
                            colorBlend.Positions[i + offs] = _gradientPoints[i].Position;
                            colorBlend.Colors[i + offs] = _gradientPoints[i].Color;
                        }
                        if (_gradientPoints[_gradientPoints.Count - 1].Position != 1f)
                        {
                            colorBlend.Positions[colorBlend.Positions.Length - 1] = 1f;
                            colorBlend.Colors[colorBlend.Positions.Length - 1] = _gradientPoints[_gradientPoints.Count - 1].Color;
                        }
                    }
                    b.InterpolationColors = colorBlend;
                    break;
            }
            return b;
        }

        protected override void OnPaint(
            PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            var r = GetGradientRect();
            var fr = new Rectangle(r.X + 2, r.Y + 2, r.Width - 4, r.Height - 4);

            //
            Bitmap bmp = null;
            if (_gradientType == GradientType.Blend)
            {
                bmp = new Bitmap(fr.Width, 1);
                using (Graphics g = Graphics.FromImage(bmp))
                    using (Brush b = CreateGradientBrush(new Rectangle(0, 0, fr.Width, 1)))
                        g.FillRectangle(b, 0, 0, fr.Width, 1);
            }
            if (_selectedPoint != null)
                DrawPoint(e.Graphics, GetPointRect(_selectedPoint, r), GetPointColor(_selectedPoint, bmp), GetPointState(_selectedPoint));
            foreach (GradientPoint gp in _gradientPoints)
            {
                if (gp != _selectedPoint)
                    DrawPoint(e.Graphics, GetPointRect(gp, r), GetPointColor(gp, bmp), GetPointState(gp));
            }
            if (bmp != null)
                bmp.Dispose();

            // draw area with gradient
            using (var p = new Pen(SystemColors.ControlDark, 1))
                e.Graphics.DrawRectangle(p, r.X, r.Y, r.Width - 1, r.Height - 1);
            using (var p = new Pen(SystemColors.Window, 1))
                e.Graphics.DrawRectangle(p, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3);
            using (var b = CreateGradientBrush(fr))
                e.Graphics.FillRectangle(b, fr);
            e.Graphics.ExcludeClip(r);

            using (var b = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(b, ClientRectangle);

            //
            if (ContainsFocus)
                ControlPaint.DrawFocusRectangle(e.Graphics, ClientRectangle);

            base.OnPaint(e);
        }

        protected override void OnGotFocus(
            EventArgs e)
        {
            Invalidate();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(
            EventArgs e)
        {
            Invalidate();
            base.OnLostFocus(e);
        }

        protected override void OnMouseMove(
            MouseEventArgs e)
        {
            if (_draggedPoint != null)
            {
                Rectangle gradientRect = GetGradientRect();
                int p = Math.Min(gradientRect.Right, Math.Max(gradientRect.Left, e.X)) - gradientRect.Left;
                float newPosition = p / (float)gradientRect.Width;
                _draggedPoint.Position = newPosition;
                OnPointChanged(_draggedPoint);
            }
            else
            {
                HitTestInfo hti = HitTest(e.X, e.Y);
                HighlightedItem = hti.Point;
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(
            EventArgs e)
        {
            HighlightedItem = null;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(
            MouseEventArgs e)
        {
            HitTestInfo hti = HitTest(e.X, e.Y);
            if (hti.Point != null)
            {
                _draggedPoint = hti.Point;
                HighlightedItem = hti.Point;
                SelectedPoint = hti.Point;
                OnSelectedPointChanged();
            }
            Focus();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(
            MouseEventArgs e)
        {
            if (_draggedPoint == null)
            {
                // add new point in specified position
                Rectangle gradientRect = GetGradientRect();
                if (e.X >= gradientRect.Left && e.X <= gradientRect.Right)
                {
                    //
                    float pos = Math.Min(1f, (e.X - gradientRect.Left) / (float)gradientRect.Width);
                    int i;
                    for (i = 0; i < _gradientPoints.Count && _gradientPoints[i].Position <= pos; i++) ;

                    //
                    AddPoint(i, i == 0 ? pos : pos - _gradientPoints[i - 1].Position);
                }
            }
            else
            {
                _draggedPoint = null;
            }
            base.OnMouseUp(e);
        }

        protected override bool IsInputKey(
            Keys keyData)
        {
            if (keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.Up || keyData == Keys.Down)
                return true;
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(
            KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Handled)
                return;

            if (e.KeyData == Keys.Left)
            {
                if (SelectedPointIndex > 0)
                {
                    SelectedPointIndex--;
                    OnSelectedPointChanged();
                }
            }
            else if (e.KeyData == Keys.Right)
            {
                if (SelectedPointIndex < _gradientPoints.Count - 1)
                {
                    SelectedPointIndex++;
                    OnSelectedPointChanged();
                }
            }
            else if (e.KeyData == Keys.Up)
            {
                if (SelectedPoint != null)
                {
                    SelectedPoint.Position = Math.Max(0, SelectedPoint.Position - 0.01f);
                    OnPointChanged(SelectedPoint);
                }
            }
            else if (e.KeyData == Keys.Down)
            {
                if (SelectedPoint != null)
                {
                    SelectedPoint.Position = Math.Min(1, SelectedPoint.Position + 0.01f);
                    OnPointChanged(SelectedPoint);
                }
            }
            else if (e.KeyData == Keys.PageUp)
            {
                if (SelectedPoint != null)
                {
                    SelectedPoint.Position = Math.Max(0, SelectedPoint.Position - 0.1f);
                    OnPointChanged(SelectedPoint);
                }
            }
            else if (e.KeyData == Keys.PageDown)
            {
                if (SelectedPoint != null)
                {
                    SelectedPoint.Position = Math.Min(1, SelectedPoint.Position + 0.1f);
                    OnPointChanged(SelectedPoint);
                }
            }
            else if (e.KeyData == Keys.Delete)
            {
                if (SelectedPoint != null && _gradientPoints.Count > 2)
                {
                    _gradientPoints.Remove(SelectedPoint);
                }
            }
            else if (e.KeyData == Keys.Insert)
            {
                if (SelectedPoint != null)
                    AddPoint();
            }
        }
        #endregion

        #region Protected properties
        protected GradientPoint HighlightedItem
        {
            get { return _highlightedPoint; }
            set
            {
                if (_highlightedPoint == value)
                    return;

                if (UpdateLocked)
                    _highlightedPoint = value;
                else
                {
                    using (var rgn = new Region())
                    {
                        rgn.MakeEmpty();
                        Rectangle gradientRect = GetGradientRect();
                        if (_highlightedPoint != null)
                            rgn.Union(GetPointRect(_highlightedPoint, gradientRect));
                        _highlightedPoint = value;
                        if (_highlightedPoint != null)
                            rgn.Union(GetPointRect(_highlightedPoint, gradientRect));
                        Invalidate(rgn);
                    }
                }
            }
        }
        #endregion

        #region Public
        public void BeginUpdate()
        {
            _updateCounter++;
        }

        public void EndUpdate()
        {
            _updateCounter--;
            if (!UpdateLocked)
            {
                _gradientPoints.Sort();
                Invalidate();
                OnSelectedPointChanged();
            }
        }

        public HitTestInfo HitTest(
            int x,
            int y)
        {
            Rectangle gradientRect = GetGradientRect();
            if (_selectedPoint != null)
            {
                if (GetPointRect(_selectedPoint, GetPointState(_selectedPoint), gradientRect).Contains(x, y))
                    return new HitTestInfo(_selectedPoint);
            }
            foreach (GradientPoint point in _gradientPoints)
                if (GetPointRect(point, GetPointState(point), gradientRect).Contains(x, y))
                    return new HitTestInfo(point);
            if (gradientRect.Contains(x, y))
                return HitTestInfo.Gradient;
            return HitTestInfo.Outside;
        }

        private GradientPoint AddPoint(
            int index,
            float posRelativeToLeftPoint)
        {
            _internalChanges = true;

            var gp = new GradientPoint();
            if (index == 0)
            {
                gp.Position = posRelativeToLeftPoint;
                gp.Factor = posRelativeToLeftPoint;
                gp.Color = _gradientPoints[0].Color;
            }
            else if (index >= _gradientPoints.Count)
            {
                gp.Position = _gradientPoints[_gradientPoints.Count - 1].Position + posRelativeToLeftPoint;
                gp.Factor = _gradientPoints[_gradientPoints.Count - 1].Factor + posRelativeToLeftPoint / (1 - _gradientPoints[_gradientPoints.Count - 1].Position) * (1 - _gradientPoints[_gradientPoints.Count - 1].Factor);
                gp.Color = _gradientPoints[_gradientPoints.Count - 1].Color;
            }
            else
            {
                gp.Position = _gradientPoints[index - 1].Position + posRelativeToLeftPoint;
                gp.Factor = _gradientPoints[index - 1].Factor + posRelativeToLeftPoint / (_gradientPoints[index].Position - _gradientPoints[index - 1].Position) * (_gradientPoints[index].Factor - _gradientPoints[index - 1].Factor);
                gp.Color = GetMixedColor(
                    _gradientPoints[index - 1].Color,
                    _gradientPoints[index].Color,
                    posRelativeToLeftPoint / (_gradientPoints[index].Position - _gradientPoints[index - 1].Position));
            }
            _gradientPoints.Insert(index, gp);

            _internalChanges = false;

            SelectedPoint = gp;
            HighlightedItem = gp;
            Invalidate(GetPointRect(gp, GetGradientRect()));
            OnPointAdded(gp);
            OnSelectedPointChanged();

            return gp;
        }

        /// <summary>
        /// Adds new <see cref="GradientPoint"/> after currently selected point.
        /// </summary>
        /// <returns></returns>
        public GradientPoint AddPoint()
        {
            GradientPoint gp = SelectedPoint;
            if (gp == null)
                return null;

            int index = GradientPoints.IndexOf(gp);
            if (index == 0)
                return AddPoint(index + 1, (GradientPoints[index + 1].Position - gp.Position) / 2);
            if (index >= GradientPoints.Count - 1)
                return AddPoint(index, (gp.Position - GradientPoints[index - 1].Position) / 2);
            return AddPoint(index + 1, (GradientPoints[index + 1].Position - gp.Position) / 2);
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedPointIndex
        {
            get { return _gradientPoints.IndexOf(_selectedPoint); }
            set
            {
                if (value < 0 || value >= _gradientPoints.Count)
                    return;
                SelectedPoint = _gradientPoints[value];
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientPoint SelectedPoint
        {
            get { return _selectedPoint; }
            set
            {
                if (_selectedPoint == value)
                    return;

                if (UpdateLocked)
                    _selectedPoint = value;
                else
                {
                    using (var rgn = new Region())
                    {
                        rgn.MakeEmpty();
                        Rectangle gradientRect = GetGradientRect();
                        if (_selectedPoint != null)
                            rgn.Union(GetPointRect(_selectedPoint, gradientRect));
                        _selectedPoint = value;
                        if (_selectedPoint != null)
                            rgn.Union(GetPointRect(_selectedPoint, gradientRect));
                        Invalidate(rgn);
                    }
                }
            }
        }

        [DefaultValue(c_DefGradientType)]
        public GradientType GradientType
        {
            get { return _gradientType; }
            set { _gradientType = value; }
        }

        public Color StartColor
        {
            get { return _startColor; }
            set
            {
                _startColor = value;
                Invalidate();
            }
        }

        public Color EndColor
        {
            get { return _endColor; }
            set
            {
                _endColor = value;
                Invalidate();
            }
        }

        public GradientPointCollection GradientPoints
        {
            get { return _gradientPoints; }
        }
        #endregion

        #region Events

        public event EventHandler<GradientPointEventArgs> PointAdded;

        public event EventHandler<GradientPointEventArgs> PointChanged;

        public event EventHandler SelectedPointChanged;
        #endregion

        #region Nested types
        [Flags]
        private enum PointState
        {
            None = 0x00,
            Selected = 0x01,
            Highlighted = 0x02,
        }

        internal enum HitTestArea
        {
            Outside,
            Gradient,
            Point,
        }

        internal struct HitTestInfo
        {
            public static readonly HitTestInfo Outside = new HitTestInfo(HitTestArea.Outside);
            public static readonly HitTestInfo Gradient = new HitTestInfo(HitTestArea.Gradient);

            private readonly HitTestArea _area;
            private readonly GradientPoint _point;

            #region Contructors
            public HitTestInfo(
                HitTestArea area)
            {
                _area = area;
                _point = null;
            }

            public HitTestInfo(
                GradientPoint point)
            {
                _area = HitTestArea.Point;
                _point = point;
            }
            #endregion

            #region Public properties
            public HitTestArea Area
            {
                get { return _area; }
            }

            public GradientPoint Point
            {
                get { return _point; }
            }
            #endregion
        }
        #endregion
    }
}
