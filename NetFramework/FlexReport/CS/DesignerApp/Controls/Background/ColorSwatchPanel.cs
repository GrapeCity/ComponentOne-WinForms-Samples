//----------------------------------------------------------------------------
// ColorSwatchPanel.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlexReportDesignerApp.Controls.Background
{
    internal partial class ColorSwatchPanel : Control
    {
        private Rectangle _contentRectangle;
        private ColorSwatch _currentSwatch;
        private ColorSwatch _candidateSwatch;
        private readonly Dictionary<Color, ColorSwatch> _swatches = new Dictionary<Color, ColorSwatch>();
        private readonly Timer _hoverTimer;

        public event EventHandler ColorPicked;
        public event EventHandler CurrentColorChanged;

        public ColorSwatchPanel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            _hoverTimer = new Timer {Interval = 400, Enabled = false};
            _hoverTimer.Tick += HoverTimerTick;
        }

        public void PostInit()
        {
            GenerateButtons(this);
            SetCurrentSwatch(null);
        }

        public Color CurrentColor
        {
            get
            {
                return _currentSwatch != null ? _currentSwatch.Color : Color.Empty;
            }
            set
            {
                ColorSwatch cs;
                _swatches.TryGetValue(value, out cs);
                SetCurrentSwatch(cs);
            }
        }

        public Rectangle ContentRectangle
        {
            get { return _contentRectangle; }
        }

        private void OnCurrentColorChanged()
        {
            if (CurrentColorChanged != null)
                CurrentColorChanged(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (ColorSwatch cb in _swatches.Values)
            {
                cb.Paint(e.Graphics);
                if (cb == _currentSwatch)
                {
                    using (var p = new Pen(Color.Black))
                    {
                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                        var r = cb.Bounds;
                        r.Offset(-1, -1);
                        r.Width += 1;
                        r.Height += 1;
                        e.Graphics.DrawRectangle(p, r);
                    }
                }
            }
        }

        // we don't want to move current color immediately,
        // this is used to only change it on mouse hover:
        private void HoverTimerTick(object sender, EventArgs e)
        {
            _hoverTimer.Stop();
            if (_candidateSwatch != null && _candidateSwatch != _currentSwatch)
            {
                var cs = FindSwatch(PointToClient(Cursor.Position));
                if (cs == _candidateSwatch)
                    SetCurrentSwatch(_candidateSwatch);
            }
            _candidateSwatch = null;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            var cs = FindSwatch(e.Location);
            if (cs != _currentSwatch)
            {
                if (cs != _candidateSwatch)
                {
                    _hoverTimer.Stop();
                    _candidateSwatch = cs;
                    _hoverTimer.Start();
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            _currentSwatch = FindSwatch(e.Location);
            if (_currentSwatch != null && ColorPicked != null)
                ColorPicked(this, EventArgs.Empty);
        }

        private void SetCurrentSwatch(ColorSwatch cs)
        {
            if (cs != _currentSwatch)
            {
                if (_currentSwatch != null)
                {
                    var r = _currentSwatch.Bounds;
                    r.Inflate(2, 2);
                    Invalidate(r);
                }
                _currentSwatch = cs;
                if (_currentSwatch != null)
                {
                    var r = _currentSwatch.Bounds;
                    r.Inflate(2, 2);
                    Invalidate(r);
                }
                OnCurrentColorChanged();
            }
        }

        private ColorSwatch FindSwatch(Point location)
        {
            return _swatches.Values.FirstOrDefault(cs => cs.Bounds.Contains(location));
        }

        private class ColorSwatch
        {
            public Color Color { get; set; }
            public Rectangle Bounds { get; set; }

            public void Paint(Graphics g)
            {
                using (var b = new SolidBrush(Color))
                    g.FillRectangle(b, Bounds);
            }
        }

        private const int c_PalletteWidth = 9;
        private const int c_PalletteHeight = 5;

        // Rows in the table are 1, 3, 4, 6, 8.
        private static Color[,] s_customPalette = new Color[c_PalletteHeight, c_PalletteWidth] {
            {
            Color.FromArgb(unchecked((int)0xFF660000)), // reds"),
            Color.FromArgb(unchecked((int)0xFF663300)), // oranges"),
            Color.FromArgb(unchecked((int)0xFF666600)), // yellows"),
            Color.FromArgb(unchecked((int)0xFF006600)), // greens"),
            Color.FromArgb(unchecked((int)0xFF006666)), // cyans"),
            Color.FromArgb(unchecked((int)0xFF000066)), // blues"),
            Color.FromArgb(unchecked((int)0xFF330066)), // purples
            // Color.FromArgb(unchecked((int)0xFF660066)), // magentas"),
            Color.FromArgb(unchecked((int)0xFF660033)), // crimsons"),
            Color.FromArgb(unchecked((int)0xFF000000)), // blacks"),
            },{
            Color.FromArgb(unchecked((int)0xFFCC0000)), // reds"),
            Color.FromArgb(unchecked((int)0xFFCC6600)), // oranges"),
            Color.FromArgb(unchecked((int)0xFFCCCC00)), // yellows"),
            Color.FromArgb(unchecked((int)0xFF00CC00)), // greens"),
            Color.FromArgb(unchecked((int)0xFF00CCCC)), // cyans"),
            Color.FromArgb(unchecked((int)0xFF0000CC)), // blues"),
            Color.FromArgb(unchecked((int)0xFF6600CC)), // purples
            // Color.FromArgb(unchecked((int)0xFFCC00CC)), // magentas"),
            Color.FromArgb(unchecked((int)0xFFCC0066)), // crimsons"),
            Color.FromArgb(unchecked((int)0xFF404040)), // blacks"),
            },{
            Color.FromArgb(unchecked((int)0xFFFF0000)), // reds"),
            Color.FromArgb(unchecked((int)0xFFFF8000)), // oranges"),
            Color.FromArgb(unchecked((int)0xFFFFFF00)), // yellows"),
            Color.FromArgb(unchecked((int)0xFF00FF00)), // greens"),
            Color.FromArgb(unchecked((int)0xFF00FFFF)), // cyans"),
            Color.FromArgb(unchecked((int)0xFF0000FF)), // blues"),
            Color.FromArgb(unchecked((int)0xFF7F00FF)), // purples
            // Color.FromArgb(unchecked((int)0xFFFF00FF)), // magentas"),
            Color.FromArgb(unchecked((int)0xFFFF007F)), // crimsons"),
            Color.FromArgb(unchecked((int)0xFF808080)), // blacks"),
            },{
            Color.FromArgb(unchecked((int)0xFFFF6666)), // reds"),
            Color.FromArgb(unchecked((int)0xFFFFB266)), // oranges"),
            Color.FromArgb(unchecked((int)0xFFFFFF66)), // yellows"),
            Color.FromArgb(unchecked((int)0xFF66FF66)), // greens"),
            Color.FromArgb(unchecked((int)0xFF66FFFF)), // cyans"),
            Color.FromArgb(unchecked((int)0xFF6666FF)), // blues"),
            Color.FromArgb(unchecked((int)0xFFB266FF)), // purples
            // Color.FromArgb(unchecked((int)0xFFFF66FF)), // magentas"),
            Color.FromArgb(unchecked((int)0xFFFF66B2)), // crimsons"),
            Color.FromArgb(unchecked((int)0xFFC0C0C0)), // blacks"),
            },{
            Color.FromArgb(unchecked((int)0xFFFFCCCC)), // reds"),
            Color.FromArgb(unchecked((int)0xFFFFE5CC)), // oranges"),
            Color.FromArgb(unchecked((int)0xFFFFFFCC)), // yellows"),
            Color.FromArgb(unchecked((int)0xFFCCFFCC)), // greens"),
            Color.FromArgb(unchecked((int)0xFFCCFFFF)), // cyans"),
            Color.FromArgb(unchecked((int)0xFFCCCCFF)), // blues"),
            Color.FromArgb(unchecked((int)0xFFE5CCFF)), // purples
            // Color.FromArgb(unchecked((int)0xFFFFCCFF)), // magentas"),
            Color.FromArgb(unchecked((int)0xFFFFCCE5)), // crimsons"),
            Color.FromArgb(unchecked((int)0xFFE0E0E0)), // blacks"),
            }
        };

        private void AddSwatch(int x, int y, int width, int height, Color color)
        {
            var bounds = new Rectangle(x, y, width, height);
            _contentRectangle = _contentRectangle.IsEmpty ? bounds : Rectangle.Union(_contentRectangle, bounds);

            var swatch = new ColorSwatch()
            {
                Bounds = bounds,
                Color = color,
            };
#if DEBUG
            if (_swatches.ContainsKey(color))
                System.Diagnostics.Debug.Assert(false, "Duplicate color swatch: " + color.ToString());
            else
                _swatches.Add(color, swatch);
#else
            _swatches.Add(color, swatch);
#endif
        }

        // averaging squares seems to work better:
        private Color MixColors(Color one, Color two)
        {
            return Color.FromArgb(
                (int)Math.Round(Math.Sqrt((one.R * one.R + two.R * two.R) / 2)),
                (int)Math.Round(Math.Sqrt((one.G * one.G + two.G * two.G) / 2)),
                (int)Math.Round(Math.Sqrt((one.B * one.B + two.B * two.B) / 2)));
        }

        // For each palette color, we generate 3 automatic colors:
        // - right: average between this palette color, and the gray from this row;
        // - below: average between this palette color and the one below;
        // - below rigth: average between the one generated on the right,
        //   and the one that would be generated on the right of the paletter color below.
        // The intention is to have columns of pure colors, and on the right of each such column
        // to have a column of matching pastel colors (mix of each color and the corresponding gray).
        private void GenerateButtons(
            Control pnl)
        {
            const int btnsizex = 16;
            const int btnsizey = 17;

            const int pwidth = c_PalletteWidth * 2 -1;
            const int pheight = c_PalletteHeight * 2;

            int paddingHorz = (pnl.ClientSize.Width - btnsizex * pwidth) / (pwidth - 1);
            int paddingVert = (pnl.ClientSize.Height - btnsizey * pheight) / (pheight - 1);

            int x = 1;
            for (int c = 0; c < c_PalletteWidth; c++)
            {
                int y = 1;
                for (int r = 0; r < c_PalletteHeight; r++)
                {
                    var baseColor = s_customPalette[r, c];

                    // add palette color:
                    AddSwatch(x, y, btnsizex, btnsizey, baseColor);

                    Color palSS = r + 1 < c_PalletteHeight ? s_customPalette[r + 1, c] : Color.FromArgb(-1);

                    // add a generated color below:
                    Color genS = r + 1 == c_PalletteHeight && c + 1 == c_PalletteWidth ? Color.FromArgb(-1) : MixColors(baseColor, palSS);
                    AddSwatch(x, y + btnsizey + paddingVert, btnsizex, btnsizey, genS);

                    // add a generated color to the right and below/right
                    // unless we're at the last column (we don't want to add more grays):
                    if (c + 1 < c_PalletteWidth)
                    {
#if mix_with_grays // mix_with_grays will produce columns mixed with grays, otherwise we mix with next column (so we only mix crimsons or magentas with grays)
                        Color palEE = s_customPalette[r, c_PalletteWidth - 1];
#else
                        Color palEE = s_customPalette[r, c + 1];
#endif

                        Color genE = MixColors(baseColor, palEE);
                        AddSwatch(x + btnsizex + paddingHorz, y, btnsizex, btnsizey, genE);

#if mix_with_grays
                        Color genSSE = MixColors(
                            genE,
                            r + 1 < c_PalletteHeight ? MixColors(s_customPalette[r + 1, c], s_customPalette[r + 1, c_PalletteWidth - 1]) : Color.FromArgb(-1));
#else
                        Color genSSE = MixColors(
                            genE,
                            r + 1 < c_PalletteHeight ? MixColors(s_customPalette[r + 1, c], s_customPalette[r + 1, c + 1]) : Color.FromArgb(-1));
#endif
                        Color genSE = MixColors(genE, genSSE);
                        AddSwatch(x + btnsizex + paddingHorz, y + btnsizey + paddingVert, btnsizex, btnsizey, genSE);
                    }
                    y += (btnsizey + paddingVert) * 2;
                }
                x += (btnsizex + paddingHorz) * 2;
            }
        }
    }
}
