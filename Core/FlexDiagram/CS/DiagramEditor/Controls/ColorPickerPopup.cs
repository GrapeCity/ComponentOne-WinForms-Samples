using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace DiagramEditor.Controls;

public class ColorPickerPopup : ToolStripDropDown
{
    public event EventHandler<Color>? ColorPicked;

    public ColorPickerPopup(Color current, IWin32Window dialogOwner)
    {
        AutoClose = true;
        Padding = new Padding(1);

        var grid = new ColorGridControl(current);
        grid.ColorClicked += (_, c) =>
        {
            ColorPicked?.Invoke(this, c);
            Close();
        };
        grid.MoreColorsClicked += (_, _) =>
        {
            Close();
            using var dlg = new ColorDialog { Color = current, FullOpen = true };
            if (dlg.ShowDialog(dialogOwner) == DialogResult.OK)
                ColorPicked?.Invoke(this, dlg.Color);
        };

        var host = new ToolStripControlHost(grid) { Margin = Padding.Empty, AutoSize = false, Size = grid.Size };
        Items.Add(host);
    }
}

/// <summary>
/// Owner-drawn palette grid used by <see cref="ColorPickerPopup"/>.
/// </summary>
public class ColorGridControl : Control
{
    private static readonly Color[,] Palette =
    {
        // Gray,      Red,       Orange,    Yellow,    Green,     Teal,      Blue,      Purple
        { FromHex("FFFFFF"), FromHex("FFEBEE"), FromHex("FFF3E0"), FromHex("FFFDE7"), FromHex("E8F5E9"), FromHex("E0F2F1"), FromHex("E3F2FD"), FromHex("F3E5F5") },
        { FromHex("E0E0E0"), FromHex("FFCDD2"), FromHex("FFE0B2"), FromHex("FFF9C4"), FromHex("C8E6C9"), FromHex("B2DFDB"), FromHex("BBDEFB"), FromHex("E1BEE7") },
        { FromHex("9E9E9E"), FromHex("EF5350"), FromHex("FFA726"), FromHex("FFEE58"), FromHex("66BB6A"), FromHex("26A69A"), FromHex("42A5F5"), FromHex("AB47BC") },
        { FromHex("616161"), FromHex("D32F2F"), FromHex("F57C00"), FromHex("FBC02D"), FromHex("388E3C"), FromHex("00796B"), FromHex("1976D2"), FromHex("7B1FA2") },
        { FromHex("000000"), FromHex("B71C1C"), FromHex("E65100"), FromHex("F57F17"), FromHex("1B5E20"), FromHex("004D40"), FromHex("0D47A1"), FromHex("4A148C") },
        };

    private const int Rows = 5;
    private const int Cols = 8;
    private const int SwatchSize = 20;
    private const int Gap = 4;
    private const int GridPadding = 8;
    private const int LinkHeight = 26;

    public event EventHandler<Color>? ColorClicked;
    public event EventHandler? MoreColorsClicked;

    private readonly Color _current;
    private Point _hoverCell = new(-1, -1);
    private bool _hoverLink;

    public ColorGridControl(Color current)
    {
        _current = current;
        DoubleBuffered = true;
        BackColor = Color.White;
        Cursor = Cursors.Hand;

        int gridWidth = Cols * SwatchSize + (Cols - 1) * Gap;
        int gridHeight = Rows * SwatchSize + (Rows - 1) * Gap;
        Size = new Size(gridWidth + GridPadding * 2, gridHeight + GridPadding * 2 + LinkHeight);
    }

    private static Color FromHex(string hex) => ColorTranslator.FromHtml("#" + hex);

    private Rectangle SwatchBounds(int row, int col) =>
        new(GridPadding + col * (SwatchSize + Gap), GridPadding + row * (SwatchSize + Gap), SwatchSize, SwatchSize);

    private Rectangle LinkBounds => new(0, GridPadding * 2 + Rows * SwatchSize + (Rows - 1) * Gap, Width, LinkHeight);

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        for (int r = 0; r < Rows; r++)
        {
            for (int c = 0; c < Cols; c++)
            {
                var bounds = SwatchBounds(r, c);
                var color = Palette[r, c];

                using (var brush = new SolidBrush(color))
                    g.FillRectangle(brush, bounds);

                bool isCurrent = color.ToArgb() == _current.ToArgb();
                bool isHover = _hoverCell.X == c && _hoverCell.Y == r;

                using var borderPen = new Pen(isCurrent ? Color.FromArgb(0x1A, 0x73, 0xE8) : Color.FromArgb(0xC8, 0xC8, 0xC8), isCurrent ? 2f : 1f);
                var borderRect = bounds;
                if (isCurrent) borderRect.Inflate(1, 1);
                g.DrawRectangle(borderPen, borderRect);

                if (isHover)
                {
                    using var hoverPen = new Pen(Color.FromArgb(0x40, 0x40, 0x40), 1.5f);
                    var hoverRect = bounds;
                    hoverRect.Inflate(2, 2);
                    g.DrawRectangle(hoverPen, hoverRect);
                }
            }
        }

        var linkBounds = LinkBounds;
        using (var separatorPen = new Pen(Color.FromArgb(0xE3, 0xE3, 0xE3)))
            g.DrawLine(separatorPen, 8, linkBounds.Top, Width - 8, linkBounds.Top);

        using var linkBrush = new SolidBrush(_hoverLink ? Color.FromArgb(0x0F, 0x5B, 0xC7) : Color.FromArgb(0x1A, 0x73, 0xE8));
        using var linkFont = new Font("Segoe UI", 8.5f, _hoverLink ? FontStyle.Underline : FontStyle.Regular);
        using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        g.DrawString("More Colors...", linkFont, linkBrush, new RectangleF(0, linkBounds.Top, Width, LinkHeight), format);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        var newHover = HitTestCell(e.Location);
        bool newHoverLink = LinkBounds.Contains(e.Location);
        if (newHover != _hoverCell || newHoverLink != _hoverLink)
        {
            _hoverCell = newHover;
            _hoverLink = newHoverLink;
            Invalidate();
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _hoverCell = new Point(-1, -1);
        _hoverLink = false;
        Invalidate();
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        if (LinkBounds.Contains(e.Location))
        {
            MoreColorsClicked?.Invoke(this, EventArgs.Empty);
            return;
        }

        var cell = HitTestCell(e.Location);
        if (cell.X >= 0)
            ColorClicked?.Invoke(this, Palette[cell.Y, cell.X]);
    }

    private Point HitTestCell(Point location)
    {
        for (int r = 0; r < Rows; r++)
            for (int c = 0; c < Cols; c++)
                if (SwatchBounds(r, c).Contains(location))
                    return new Point(c, r);
        return new Point(-1, -1);
    }
}