using FlexGridExplorer.Utility;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace FlexGridExplorer.Component.Tile
{
    /// <summary>
    /// Displays an image, title, and description text, with hover and click interactions.
    /// The control supports asynchronous image loading, smooth rounded border rendering,
    /// and inherits hover color from its parent <see cref="TileGroup"/>.
    /// </summary>
    public partial class TileCard : UserControl
    {
        #region Private Variables
        Color _hoverColor;
        #endregion

        #region Object Model
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text
        {
            get { return lblCardName.Text; }
            set { lblCardName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Description
        {
            get { return lblDesc.Text; }
            set { lblDesc.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image
        {
            get { return picBox.Image; }
            set { picBox.Image = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TileGroup TileGroup
        { get; set; }
        #endregion

        public TileCard()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            lblCardName.Margin = new Padding(5);

            subscribeMethods();

            imgSize = this.picBox.PreferredSize;
        }

        private void subscribeMethods()
        {
            lblCardName.Click += (s, e) => this.OnClick(e);
            picBox.Click += (s, e) => this.OnClick(e);
            lblDesc.Click += (s, e) => this.OnClick(e);

            lblCardName.MouseEnter += (s, e) => this.OnMouseEnter(e);
            picBox.MouseEnter += (s, e) => this.OnMouseEnter(e);
            lblDesc.MouseEnter += (s, e) => this.OnMouseEnter(e);

            lblCardName.MouseLeave += (s, e) => this.OnMouseLeave(e);
            picBox.MouseLeave += (s, e) => this.OnMouseLeave(e);
            lblDesc.MouseLeave += (s, e) => this.OnMouseLeave(e);
        }

        Size imgSize;

        public Size ImageSize
        {
            get => imgSize;
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
            try
            {
                if (InvokeRequired)
                {
                    var d = new SafeCallDelegate(SetImage);
                    Invoke(d, new object[] { img });
                }
                else
                {
                    if (IsDisposed) return;
                    Image = img;
                }
            }
            catch (ObjectDisposedException)
            {
                return;
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

            Color brushColor = Color.White;
            using (Brush whiteBrush = new SolidBrush(brushColor))
            {
                g.FillPath(whiteBrush, path);
            }

            brushColor = SkinManager.LightGray;
            using (Pen pen = new Pen(brushColor, 2))
            {
                g.DrawPath(pen, path);
            }
        }
    }
}
