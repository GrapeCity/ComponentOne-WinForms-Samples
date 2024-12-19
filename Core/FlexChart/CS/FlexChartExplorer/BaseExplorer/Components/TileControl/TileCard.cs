using BaseExplorer.Core;
using C1.Win.Themes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaseExplorer.Components
{
    public partial class TileCard : UserControl
    {
        #region fields
        private Color _hoverColor;
        private string _theme = "Office365White";
        #endregion

        #region Object Model
        public new string Text
        {
            get { return lblCardName.Text; }
            set { lblCardName.Text = value; }
        }
        public string Description 
        {
            get { return lblDesc.Text; }
            set { lblDesc.Text = value; }
        }

        public Image Image
        {
            get { return picBox.Image; }
            set { picBox.Image = value; }
        }

        public Color HoverColor
        {
            get
            {
                return TileGroup != null ? TileGroup.HoverColor : _hoverColor;
            }
            set
            {
                if (_hoverColor != value)
                {
                    _hoverColor = value;
                }
            }
        }

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
                    ApplyTheme();
                }
                else
                {
                    _theme = value;
                }
            }
        }


        public TileGroup TileGroup
        { get; set; }
        #endregion

        public TileCard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            lblCardName.Margin = new Padding(5);

            lblCardName.Click += (s, e) => this.OnClick(e);
            picBox.Click += (s, e) => this.OnClick(e);
            lblDesc.Click += (s, e) => this.OnClick(e);

            lblCardName.MouseEnter += (s, e) => this.OnMouseEnter(e);
            picBox.MouseEnter += (s, e) => this.OnMouseEnter(e);
            lblDesc.MouseEnter += (s, e) => this.OnMouseEnter(e);

            lblCardName.MouseLeave += (s, e) => this.OnMouseLeave(e);
            picBox.MouseLeave += (s, e) => this.OnMouseLeave(e);
            lblDesc.MouseLeave += (s, e) => this.OnMouseLeave(e);

            imgSize = this.picBox.PreferredSize;
        }

        Size imgSize;

        public Size ImageSize
        {
            get => imgSize;
        }

        public void ApplyTheme()
        {
            bool isWhite = Theme == "Office365White";
            Color backColor = isWhite ? Color.White : SkinManager.Office365Black;
            Color foreColor = isWhite ? SystemColors.ControlText : Color.White;
            tableLayoutPanel1.BackColor = isWhite ? Color.White: SkinManager.Office365LightBlack;

            ColorPanels(backColor, foreColor);
        }
        private void ColorPanels(Color backColor, Color foreColor)
        {
            this.BackColor = backColor;
            panel1.BackColor = backColor;
            flowLayoutPanel1.BackColor = backColor;
            lblCardName.BackColor = backColor;
            lblDesc.Styles.Disabled.BackColor = backColor;
            lblCardName.ForeColor = foreColor;
            lblDesc.Styles.Disabled.ForeColor = foreColor;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Cursor = Cursors.Default;
        }

        private delegate void SafeCallDelegate(Image img);

        internal void SetImage(Image img)
        {
            if (InvokeRequired)
            {
                var d = new SafeCallDelegate(SetImage);
                Invoke(d, new object[] { img });
            }
            else
            {
                Image = img;
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = 8;

            Rectangle rect = tableLayoutPanel1.ClientRectangle;
            rect.Inflate(-2, -2);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            bool whiteTheme = Theme == "Office365White";
            Color brushColor = whiteTheme ? Color.White : SkinManager.Office365Black;
            using (Brush whiteBrush = new SolidBrush(brushColor))
            {
                g.FillPath(whiteBrush, path);
            }

            brushColor = whiteTheme ? SkinManager.LightGray: Color.Black;
            using (Pen pen = new Pen(brushColor, 2))
            { 
                g.DrawPath(pen, path);
            }
        }
    }
}
