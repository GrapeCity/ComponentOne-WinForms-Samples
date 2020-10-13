using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwareDevelopmentPlan
{
    public partial class AppMenuButton : UserControl
    {
        #region private fields
        private Color _defaultBackColor = Color.FromArgb(212, 212, 212);
        private Color _hotBackColor = Color.DarkGray;
        private Color _hotPressedBackColor = Color.Gray;
        #endregion

        #region ctor
        public AppMenuButton()
        {
            InitializeComponent();                        
        }
        #endregion

        #region properties
        public string ButtonText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        public Image ButtonImage
        {
            get { return pbImage.Image; }
            set { pbImage.Image = value; }
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

        private void Element_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        #endregion
    }
}
