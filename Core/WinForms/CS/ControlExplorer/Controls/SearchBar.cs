using ControlExplorer.Core;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public partial class SearchBar : UserControl
    {
        #region Private Variables

        int _diameter = 8;
        int _borderWidth = 2;

        #endregion

        #region Public Methods

        public event EventHandler<string> TextChangedEvent;
        public string SearchText
        {
            get { return textBoxExSearch.Text; }
            set { textBoxExSearch.Text = value; }
        }

        public SearchBar()
        {
            InitializeComponent();
            tableLayoutPanel1.Paint += TableLayoutPanel1_Paint;
            textBoxExSearch.TextChanged += (s, e) =>
            {
                TextChangedEvent?.Invoke(this, textBoxExSearch.Text);
            };
        }

        #endregion

        #region Private Methods
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = tableLayoutPanel1.ClientRectangle;
            rect.Inflate(-_borderWidth, -_borderWidth);

            Color borderColor;
            Color bgColor;
            Color bottomColor;
            Color lightCorner;
            Color darkCorner;

            borderColor = Color.White;
            bgColor = Color.White;
            bottomColor = SkinManager.DarkGray;
            lightCorner = bgColor;
            darkCorner = SkinManager.DarkGray;

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

            using (Pen pen = new Pen(bottomColor, _borderWidth))
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
        //to remove the flickering ffect on form resize
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  
                return cp;
            }
        }

        #endregion
    }
}
