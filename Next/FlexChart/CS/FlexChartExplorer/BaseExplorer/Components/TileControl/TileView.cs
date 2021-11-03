using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using BaseExplorer.Core;

namespace BaseExplorer.Components
{
    public partial class TileView : UserControl
    {
        #region fields
        private Color _hoverColor;
        #endregion

        #region Object Model
        public new string Text
        {
            get { return lblCardName.Text; }
            set { lblCardName.Text = value; }
        }
        public string Description { get; set; }

        public Image Image
        {
            get { return picBox.Image; }
            set
            {
                Explorer.Instance.SyncContext.Post(UpdateImage, value);
            }
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

        public TileGroup TileGroup
        { get; set; }
        #endregion

        public TileView()
        {
            InitializeComponent();
            Margin = new Padding(10);
            lblCardName.Click += (s, e) => this.OnClick(e);
            picBox.Click += (s, e) => this.OnClick(e);
            pnlPB.Click += (s, e) => this.OnClick(e);

            lblCardName.MouseEnter += (s, e) => this.OnMouseEnter(e);
            picBox.MouseEnter += (s, e) => this.OnMouseEnter(e);
            pnlPB.MouseEnter += (s, e) => this.OnMouseEnter(e);
            lblCardName.MouseLeave += (s, e) => this.OnMouseLeave(e);
            picBox.MouseLeave += (s, e) => this.OnMouseLeave(e);
            pnlPB.MouseLeave += (s, e) => this.OnMouseLeave(e);

            BackColor = Color.White;
            ForeColor = SkinManager.PrimaryColor;
        }


        private void UpdateImage(object state)
        {
            var image = state as Image;
            var thumb = image.GetThumbnailImage(picBox.PreferredSize.Width, picBox.PreferredSize.Height, null, IntPtr.Zero);
            picBox.Image = thumb;
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
    }
}
