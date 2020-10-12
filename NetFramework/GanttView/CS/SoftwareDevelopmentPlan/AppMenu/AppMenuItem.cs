using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwareDevelopmentPlan
{
    public partial class MenuItem : UserControl
    {
        #region private fileds
        private Color _defaultBackColor = Color.FromArgb(212, 212, 212);
        private Color _hotBackColor = Color.DarkGray;
        private Color _hotPressedBackColor = Color.Gray;
        #endregion

        #region ctor
        public MenuItem(Item item)
        {
            InitializeComponent();
            Item = item;
            lblText.Text = item.Text;
            lblSubText.Text = item.SubText;
            pbImage.Image = item.GetImage();
            UpdatePinnedState();
        }
        #endregion

        #region properties
        public Item Item
        {
            get;
            private set;
        }
        #endregion

        #region events
        public event EventHandler PinnedChanged;

        public void OnPinnedChanged()
        {
            PinnedChanged?.Invoke(this, new EventArgs());
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
            UpdatePinnedState();
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = _hotBackColor;
            UpdatePinnedState(true);            
        }

        private void UpdatePinnedState(bool hot = false)
        {            
            if (Item.Pinned)
                pbPin.Image = Properties.Resources.pinnned;
            else if (hot)
                pbPin.Image = Properties.Resources.pin;
            else
                pbPin.Image = null;
            pbPin.Invalidate();
        }

        private void pbPin_Click(object sender, EventArgs e)
        {
            Item.Pinned = !Item.Pinned;
            OnPinnedChanged();
        }

        private void Element_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        #endregion
    }
}
