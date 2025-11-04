using FlexGridExplorer.Properties;
using FlexGridExplorer.Utility;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace FlexGridExplorer.Component.Input
{
    /// <summary>
    /// A compact search input control with rounded border, focus highlight, and an adaptive icon button.
    /// Shows a search icon when empty and a clear (cross) icon when text is present.
    /// </summary>
    /// <remarks>
    /// - The control custom-draws its border and bottom highlight inside a TableLayoutPanel paint handler.
    /// - Focus changes update the bottom border color to indicate active state.
    /// - Press <c>Esc</c> to clear focus (and return focus to the parent).
    /// - Use <see cref="SearchText"/> to get or set the current query; subscribe to <see cref="TextChangedEvent"/> for updates.
    /// </remarks>
    public partial class SearchBar : UserControl
    {
        #region Private Variables
        bool _isTextBoxFocused = false;
        int _diameter = 8;
        int _borderWidth = 2;
        int _bottomBorderWidth = 1;
        #endregion

        #region Public Methods
        public event EventHandler<string> TextChangedEvent;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SearchText
        {
            get { return textBoxExSearch.Text; }
            set { textBoxExSearch.Text = value; }
        }
        public SearchBar()
        {
            InitializeComponent();
            textBoxExSearch.Placeholder = StringsEN.TxtSearch;
            btnSearch.Icon = IconUtils.Search;
            tableLayoutPanel1.Paint += TableLayoutPanel1_Paint;
            AddToggleIconEvents();
            AddFocusEvents();
        }
        public void ClearFocus()
        {
            _isTextBoxFocused = false;
            tableLayoutPanel1.Invalidate();
            Parent.Focus();
        }
        public override bool Focused => textBoxExSearch.Focused;

        #endregion

        #region Private Methods
        private void AddFocusEvents()
        {
            textBoxExSearch.GotFocus += (s, e) =>
            {
                _isTextBoxFocused = true;
                tableLayoutPanel1.Invalidate();
            };

            textBoxExSearch.LostFocus += (s, e) =>
            {
                _isTextBoxFocused = false;
                tableLayoutPanel1.Invalidate();
            };
        }
        private void AddToggleIconEvents()
        {
            textBoxExSearch.TextChanged += (s, e) =>
            {
                btnSearch.Icon = string.IsNullOrWhiteSpace(textBoxExSearch.Text) ? IconUtils.Search : IconUtils.Cross;
                TextChangedEvent?.Invoke(this, textBoxExSearch.Text);
            };

            btnSearch.Click += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(textBoxExSearch.Text))
                {
                    textBoxExSearch.Clear();
                    btnSearch.Icon = IconUtils.Search;
                }
                textBoxExSearch.Focus();
            };
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = tableLayoutPanel1.ClientRectangle;
            rect.Inflate(-_borderWidth, -_borderWidth);

            Color borderColor = Color.White;
            Color bgColor = Color.White;
            Color lightCorner = bgColor;
            Color darkCorner = SkinManager.DarkGray;
            Color bottomColor = _isTextBoxFocused ? SkinManager.HighlighterColor : SkinManager.DarkGray;

            DrawBaseBorder(g, rect, borderColor, bgColor);
            DrawButtomLine(g, rect, bottomColor);
            GraphicsPath basePathRight = new GraphicsPath();
            basePathRight.AddArc(rect.Right - _diameter, rect.Bottom - _diameter, _diameter, _diameter, 0, 90);
            DrawGradientCorner(new Point(rect.Right, rect.Bottom - _diameter), new Point(rect.Right - _diameter, rect.Bottom), g, basePathRight, rect, lightCorner, darkCorner);
            GraphicsPath basePathLeft = new GraphicsPath();
            basePathLeft.AddArc(rect.X, rect.Bottom - _diameter, _diameter, _diameter, 90, 90);
            DrawGradientCorner(new Point(rect.X, rect.Bottom - _diameter), new Point(rect.X + _diameter, rect.Bottom), g, basePathLeft, rect, lightCorner, darkCorner);
        }

        private void DrawBaseBorder(Graphics g, Rectangle rect, Color borderColor, Color bgColor)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, _diameter, _diameter, 180, 90);
            path.AddArc(rect.Right - _diameter, rect.Y, _diameter, _diameter, 270, 90);
            path.AddArc(rect.Right - _diameter, rect.Bottom - _diameter, _diameter, _diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - _diameter, _diameter, _diameter, 90, 90);
            path.CloseFigure();

            using (Pen pen = new Pen(borderColor, _borderWidth))
            {
                g.DrawPath(pen, path);
            }

            using (Brush whiteBrush = new SolidBrush(bgColor))
            {
                g.FillPath(whiteBrush, path);
            }
        }

        private void DrawButtomLine(Graphics g, Rectangle rect, Color bottomColor)
        {
            GraphicsPath bottom_line = new GraphicsPath();
            bottom_line.AddLine(new Point(rect.X + _diameter / 2, rect.Bottom), new Point(rect.Right - _diameter / 2, rect.Bottom));

            using (Pen pen = new Pen(bottomColor, _bottomBorderWidth))
            {
                g.DrawPath(pen, bottom_line);
            }
        }

        private void DrawGradientCorner(Point start, Point end, Graphics g, GraphicsPath path, Rectangle rect, Color lightCorner, Color darkCorner)
        {
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                start,
                end,
                lightCorner,
                darkCorner))
            {
                using (Pen gradientPen = new Pen(gradientBrush, _borderWidth))
                {
                    g.DrawPath(gradientPen, path);
                }
            }
        }

        #endregion

        #region Protected Methods
        //to remove the flickering effect
        protected override CreateParams CreateParams
        {
            get => base.CreateParams;
        }

        //to remove focus on press ESC Key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                ClearFocus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
