using FlexGridExplorer.Utility;
using System.ComponentModel;

namespace FlexGridExplorer.Component.Tile
{
    /// <summary>
    /// Represents an individual tile view element that displays an image, title, and optional description
    /// within a <see cref="TileGroup"/>.
    /// </summary>
    public partial class TileView : UserControl
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
        public string Description { get; set; }

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

        public TileView()
        {
            InitializeComponent();
            Margin = new Padding(10);
            subscribeMethods();

            BackColor = Color.White;
            ForeColor = SkinManager.PrimaryColor;

            imgSize = this.picBox.PreferredSize;
        }

        private void subscribeMethods()
        {
            lblCardName.Click += (s, e) => this.OnClick(e);
            picBox.Click += (s, e) => this.OnClick(e);
            pnlPB.Click += (s, e) => this.OnClick(e);

            lblCardName.MouseEnter += (s, e) => this.OnMouseEnter(e);
            picBox.MouseEnter += (s, e) => this.OnMouseEnter(e);
            pnlPB.MouseEnter += (s, e) => this.OnMouseEnter(e);
            lblCardName.MouseLeave += (s, e) => this.OnMouseLeave(e);
            picBox.MouseLeave += (s, e) => this.OnMouseLeave(e);
            pnlPB.MouseLeave += (s, e) => this.OnMouseLeave(e);
        }
        Size imgSize;

        public Size ImageSize
        {
            get => imgSize;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var rect = new Rectangle(0, 0, pnlPB.Width - 1, pnlPB.Height - 1);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(221, 221, 221)), rect);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Cursor = Cursors.Hand;
            this.lblCardName.ForeColor = HoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Cursor = Cursors.Default;
            this.lblCardName.ForeColor = this.ForeColor;
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
    }
}
