using BaseExplorer.Core;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaseExplorer.CustomControls
{
    public partial class SearchBar : UserControl
    {
        public event EventHandler<string> TextChangedEvent;

        private string _theme = "Office365White";
        int diameter = 8;
        int borderWidth = 2;

        public string Theme 
        {
            get
            {
                return _theme;
            }
            set
            {
                if (_theme != value)
                {
                    _theme = value;
                    ApplyThemeChanges();
                }
            }
        }

        public SearchBar()
        {
            InitializeComponent();
            bool blackTheme = Theme == "Office365Black";
            string iconColor = blackTheme ? "white" : "black";
            btnSearch.Image = (Image)Properties.Resources.ResourceManager.GetObject($"Search_{iconColor}");

            tableLayoutPanel1.Paint += TableLayoutPanel1_Paint;
            textBoxExSearch.TextChanged += (s, e) =>
            {
                TextChangedEvent?.Invoke(this, textBoxExSearch.Text);
            };
        }

        public void ApplyThemeChanges()
        {
            string iconColor = Theme == "Office365Black" ? "white" : "black";
            btnSearch.Image = (Image)Properties.Resources.ResourceManager.GetObject($"Search_{iconColor}");
            if(Theme == "Office365Black")
            {
                textBoxExSearch.BackColor = SkinManager.Office365Black;
                textBoxExSearch.ForeColor = Color.White;
                tableLayoutPanel1.BackColor = SkinManager.BlackBackColor;
                btnSearch.BackColor = SkinManager.Office365Black;
            }
            else
            {
                textBoxExSearch.BackColor = Color.White;
                textBoxExSearch.ForeColor = DefaultForeColor;
                tableLayoutPanel1.BackColor = Color.White;
                btnSearch.BackColor = Color.White;
            }
            tableLayoutPanel1.Invalidate();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = tableLayoutPanel1.ClientRectangle;
            rect.Inflate(-borderWidth, -borderWidth);

            Color borderColor;
            Color bgColor;
            Color bottomColor;
            Color lightCorner;
            Color darkCorner;
            if (Theme == "Office365White")
            {
                borderColor = Color.White;
                bgColor = Color.White;
                bottomColor = SkinManager.DarkGray;
                lightCorner = bgColor;
                darkCorner = SkinManager.DarkGray;
            }
            else
            {
                borderColor = Color.FromArgb(43, 50, 54);
                bgColor = SkinManager.Office365Black;
                bottomColor = Color.FromArgb(48, 55, 58);
                lightCorner = borderColor;
                darkCorner = Color.FromArgb(48, 55, 58);
            }

            // Drawing the base light grey border
            DrawBaseBorder(g, rect, borderColor, bgColor);

            // Drawing the buttom dark gray 
            DrawButtomLine(g, rect, bottomColor);

            // Drawing the right gradient corner
            GraphicsPath basePathRight = new GraphicsPath();
            basePathRight.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            DrawGradientCorner(new Point(rect.Right, rect.Bottom - diameter), new Point(rect.Right - diameter, rect.Bottom), g, basePathRight, rect, lightCorner, darkCorner);

            // Drawing the left gradient corner
            GraphicsPath basePathLeft = new GraphicsPath();
            basePathLeft.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            DrawGradientCorner(new Point(rect.X, rect.Bottom - diameter), new Point(rect.X + diameter, rect.Bottom), g, basePathLeft, rect, lightCorner, darkCorner);      
        }

        private void DrawBaseBorder(Graphics g, Rectangle rect, Color borderColor, Color bgColor)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            using (Pen pen = new Pen(borderColor, borderWidth))
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
            bottom_line.AddLine(new Point(rect.X + diameter / 2, rect.Bottom), new Point(rect.Right - diameter / 2, rect.Bottom));

            using (Pen pen = new Pen(bottomColor, borderWidth))
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
                using (Pen gradientPen = new Pen(gradientBrush, borderWidth))
                {
                    g.DrawPath(gradientPen, path);
                }
            }
        }   
    }
}
