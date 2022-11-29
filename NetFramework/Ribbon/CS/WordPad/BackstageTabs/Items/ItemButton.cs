using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordPad.BackstageTabs.Items
{
    public partial class ItemButton : UserControl
    {
        #region private fields
        private Color _defaultBackColor = Color.FromArgb(243, 243, 243);
        private Color _hotBackColor = Color.FromArgb(198, 198, 198);
        private Color _hotPressedBackColor = Color.FromArgb(195, 195, 195);
        #endregion

        #region ctor
        public ItemButton()
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
