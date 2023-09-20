//----------------------------------------------------------------------------
// ColorListBox.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Reflection;
using System.Globalization;

namespace FlexReportDesignerApp.Controls.Background
{
    internal enum ShowColors
    {
        /// <summary>
        /// List of colors defined by Items property in format ColorValue;Alias.
        /// </summary>
        Custom,
        /// <summary>
        /// System colors.
        /// </summary>
        SystemColors,
        /// <summary>
        /// Named colors.
        /// </summary>
        Web,
    }

    internal class ColorListBox : ListBox
    {
        private const int c_ColorMarkTopBottomPaddings = 2;
        private const int c_ColorMarkLeftPadding = 2;
        private const int c_ColorMarkRightPadding = 4;

        private static readonly List<Color> _webColors = new List<Color>();
        private static readonly List<Color> _systemColors = new List<Color>();
        private ShowColors _showColors;
        private IList<Color> _hiddenColors;
        private bool _showEmpty;
        private string _emptyColorAlias;

        #region Constructors
        static ColorListBox()
        {
            _webColors = GetColors(typeof(Color));
            _webColors.Sort(new ColorComparer());
            _systemColors = GetColors(typeof(SystemColors));
            _systemColors.Sort(new SystemColorComparer());
        }

        public ColorListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            IntegralHeight = false;
            ItemHeight = 18;
        }
        #endregion

        #region Private static
        private static List<Color> GetColors(
            Type type)
        {
            const MethodAttributes attributes1 = MethodAttributes.Static | MethodAttributes.Public;
            PropertyInfo[] infoArray1 = type.GetProperties();
            var result = new List<Color>();
            foreach (var info1 in infoArray1)
            {
                if (info1.PropertyType == typeof(Color))
                {
                    MethodInfo info2 = info1.GetGetMethod();
                    if ((info2 != null) && ((info2.Attributes & attributes1) == attributes1))
                    {
                        object[] objArray1 = null;
                        result.Add((Color)info1.GetValue(null, objArray1));
                    }
                }
            }
            return result;
        }
        #endregion

        #region Private
        private void FillItems(List<Color> colors)
        {
            BeginUpdate();
            Items.Clear();
            if (_showEmpty)
                Items.Add(new ColorRec(Color.Empty, _emptyColorAlias));
            if (colors != null)
                foreach (Color c in colors)
                    if (_hiddenColors == null || _hiddenColors.IndexOf(c) == -1)
                        Items.Add(new ColorRec(c));
            EndUpdate();
        }

        private ColorRec GetColorRec(
            int index)
        {
            if (index < 0 || index >= Items.Count)
                return ColorRec.Empty;
            if (Items[index] is ColorRec)
                return (ColorRec)Items[index];
            return ColorRec.Parse(Items[index] as string);
        }

        private void MakeItemVisible(
            int index)
        {
            if (index < TopIndex)
                TopIndex = index;
            else if (index > TopIndex + (ClientSize.Height / ItemHeight))
                TopIndex = index - ClientSize.Height / ItemHeight;
        }

        private void UpdateItems()
        {
            switch (_showColors)
            {
                case ShowColors.Custom:
                    FillItems(null);
                    break;
                case ShowColors.SystemColors:
                    FillItems(_systemColors);
                    break;
                case ShowColors.Web:
                    FillItems(_webColors);
                    break;
            }
        }
        #endregion

        #region Protected
        protected override void OnDrawItem(
            DrawItemEventArgs e)
        {
            e.DrawBackground();

            ColorRec cr = GetColorRec(e.Index);

            var markRect = new Rectangle
            {
                X = e.Bounds.Left + c_ColorMarkLeftPadding,
                Y = e.Bounds.Top + c_ColorMarkTopBottomPaddings,
                Height = e.Bounds.Height - c_ColorMarkTopBottomPaddings - c_ColorMarkTopBottomPaddings
            };
            markRect.Width = markRect.Height;

            var textRect = new Rectangle
            {
                X = e.Bounds.Left + markRect.Right + c_ColorMarkRightPadding,
                Y = e.Bounds.Top
            };
            textRect.Width = e.Bounds.Width - textRect.X - 2;
            textRect.Height = e.Bounds.Height;

            Utils.DrawColorMark(e.Graphics, cr.Value, true, markRect);
            TextRenderer.DrawText(
                e.Graphics,
                cr.GetDisplayText(),
                Font,
                textRect,
                ((e.State & DrawItemState.Selected) != 0) ? SystemColors.HighlightText : ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            if ((e.State & DrawItemState.Focus) != 0)
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds);

            base.OnDrawItem(e);
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowEmpty
        {
            get { return _showEmpty; }
            set
            {
                if (_showEmpty == value)
                    return;
                _showEmpty = value;
                UpdateItems();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmptyColorAlias
        {
            get { return _emptyColorAlias; }
            set
            {
                if (_emptyColorAlias == value)
                    return;
                _emptyColorAlias = value;
                UpdateItems();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ShowColors ShowColors
        {
            get { return _showColors; }
            set
            {
                if (_showColors == value)
                    return;
                _showColors = value;
                UpdateItems();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SelectedColor
        {
            get
            {
                int i = SelectedIndex;
                return i < 0 || i >= Items.Count ? Color.Empty : GetColorRec(i).Value;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                    if (GetColorRec(i).Value == value)
                    {
                        SelectedIndex = i;
                        MakeItemVisible(i);
                        return;
                    }
                SelectedIndex = -1;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Color> HiddenColors
        {
            get { return _hiddenColors; }
            set
            {
                if (_hiddenColors == value)
                    return;
                _hiddenColors = value;
                UpdateItems();
            }
        }
        #endregion

        #region Nested types
        private struct ColorRec
        {
            public static readonly ColorRec Empty = new ColorRec(Color.Empty, null);

            public Color Value;
            public string Alias;

            #region Constructors
            public ColorRec(
                Color value,
                string alias)
            {
                Value = value;
                Alias = alias;
            }

            public ColorRec(
                Color value)
            {
                Value = value;
                Alias = null;
            }
            #endregion

            #region Public
            public override string ToString()
            {
                string result = string.Format(Utils.ColorToString(Value));
                if (string.IsNullOrEmpty(Alias))
                    return result;
                return result + ";" + Alias;
            }

            public string GetDisplayText()
            {
                return string.IsNullOrEmpty(Alias) ? Utils.GetColorDisplayText(Value, null) : Alias;
            }
            #endregion

            #region Public static
            public static ColorRec Parse(
                string s)
            {
                if (string.IsNullOrEmpty(s))
                    return Empty;

                string[] ss = s.Split(';');
                return new ColorRec(Utils.ColorFromString(ss[0]), ss.Length < 2 ? null : ss[1]);
            }
            #endregion
        }

        private class SystemColorComparer : IComparer<Color>
        {
            #region Public
            public int Compare(
                Color x,
                Color y)
            {
                return string.Compare(x.Name, y.Name, false, CultureInfo.InvariantCulture);
            }
            #endregion
        }

        private class ColorComparer : IComparer<Color>
        {
            #region Public
            public int Compare(
                Color x,
                Color y)
            {
                byte a1 = x.A, a2 = y.A;
                float h1 = x.GetHue(), h2 = y.GetHue();
                float s1 = x.GetSaturation(), s2 = y.GetSaturation();
                float b1 = x.GetBrightness(), b2 = y.GetBrightness();

                h1 = (float)Math.Round(h1, 6, MidpointRounding.ToEven);
                h2 = (float)Math.Round(h2, 6, MidpointRounding.ToEven);
                s1 = (float)Math.Round(s1, 6, MidpointRounding.ToEven);
                s2 = (float)Math.Round(s2, 6, MidpointRounding.ToEven);
                b1 = (float)Math.Round(b1, 6, MidpointRounding.ToEven);
                b2 = (float)Math.Round(b2, 6, MidpointRounding.ToEven);

                int rv = 0;

                if (a1 < a2)
                    rv = -1;
                else if (a1 > a2)
                    rv = 1;
                else if (h1 < h2)
                    rv = -1;
                else if (h1 > h2)
                    rv = 1;
                else if (s1 < s2)
                    rv = -1;
                else if (s1 > s2)
                    rv = 1;
                else if (b1 < b2)
                    rv = -1;
                else if (b1 > b2)
                    rv = 1;

                return rv;
            }
            #endregion
        }
        #endregion
    }
}
