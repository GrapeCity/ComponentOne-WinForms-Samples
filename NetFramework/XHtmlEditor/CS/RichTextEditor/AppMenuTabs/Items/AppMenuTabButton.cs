using System;
using System.Drawing;
using System.Windows.Forms;

namespace RichTextEditor.AppMenuTabs.Items
{
    public partial class AppMenuTabButton : UserControl
    {
        #region private fields
        private Color _defaultBackColor = Color.FromArgb(212, 212, 212);
        private Color _hotBackColor = Color.DarkGray;
        private Color _hotPressedBackColor = Color.Gray;
        #endregion

        #region ctor
        public AppMenuTabButton()
        {
            InitializeComponent();
            BackColor = _defaultBackColor;
        }
        #endregion

        #region properties
        public Image ItemImage
        {
            get { return pbImage.Image; }
            set { pbImage.Image = value; }
        }

        public string ItemText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        #endregion

        #region event handlers
        private void MenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = _hotPressedBackColor;
        }

        private void MenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = _hotBackColor;
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = _defaultBackColor;
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = _hotBackColor;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        #endregion

    }
}
