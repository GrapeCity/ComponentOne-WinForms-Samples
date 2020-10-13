using System;
using System.Drawing;
using System.Windows.Forms;

namespace RichTextEditor.AppMenuTabs.Items
{
    public partial class AppMenuTabItem : UserControl
    {
        #region private fileds
        private Color _defaultBackColor = Color.FromArgb(212, 212, 212);
        private Color _hotBackColor = Color.DarkGray;
        private Color _hotPressedBackColor = Color.Gray;
        private RecentDocumentItem _item;
        #endregion

        #region ctor
        public AppMenuTabItem()
        {
            InitializeComponent();
            BackColor = _defaultBackColor;
        }
        #endregion

        #region properties
        public RecentDocumentItem Item
        {
            get { return _item; }            
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

        private void pbPin_Click(object sender, EventArgs e)
        {
            Item.Pinned = !Item.Pinned;
            OnPinnedChanged();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        #endregion

        #region methods        
        public void SetItem(RecentDocumentItem item, Image image)
        {
            _item = item;
            lblText.Text = item.Text;
            lblSubText.Text = item.SubText;
            pbImage.Image = image;
            UpdatePinnedState();
        }

        private void UpdatePinnedState(bool hot = false)
        {
            if (Item.Pinned)
                pbPin.Image = Properties.Resources.pinnned_small;
            else if (hot)
                pbPin.Image = Properties.Resources.pin_small;
            else
                pbPin.Image = null;
            pbPin.Invalidate();
        }
        #endregion
    }
}
