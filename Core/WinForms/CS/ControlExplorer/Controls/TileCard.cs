using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ControlExplorer.Contrlols
{
    public partial class TileCard : UserControl
    {
        #region Private Variables
        private Color _hoverColor;
        #endregion

        #region Public Methods
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
        public TileCard()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            lblCardName.Margin = new Padding(5);

            lblCardName.Click += Card_Click;
            picBox.Click += Card_Click;
            lblDesc.Click += Card_Click;

            imgSize = this.picBox.PreferredSize;
        }

        Size imgSize;
        public Size ImageSize
        {
            get => imgSize;
        }
        #endregion

        #region Private Methods
        private Image GetIconByName(string iconName)
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(iconName);
        }

        private void Card_Click(object sender, EventArgs e)
        {
            TileCard tileCard = this;
            if (tileCard.Tag is ItemInfo itemInfo)
            {
                ItemInfo firstItem = itemInfo.Items?.Count > 0 ? itemInfo.Items[0] : null;
                if (firstItem != null)
                {
                    Explorer.TheExplorer?.ShowControl(firstItem, true);
                    Explorer.TheExplorer?.ChangeSideBarSelection(firstItem);
                }
                else
                {
                    MessageBox.Show("No items available to load.");
                }
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.SuspendLayout();
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

            brushColor = Color.LightGray;
            using (Pen pen = new Pen(brushColor, 1))
            {
                g.DrawPath(pen, path);
            }
            this.ResumeLayout();
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
