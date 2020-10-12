using C1.Win.C1InputPanel;
using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WordPad.BackstageTabs.Items
{
    public partial class BackstageTab : UserControl
    {
        #region fields

        private Dictionary<string, Image> _icons;

        #endregion

        #region ctor

        public BackstageTab()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(243, 243, 243);
            _icons = new Dictionary<string, Image>();
        }

        #endregion

        #region properties

        protected string Caption
        {
            get
            {
                return lblCaption.Text;
            }
            set
            {
                lblCaption.Text = value;
            }
        }

        public List<RecentDocumentItem> Items
        {
            get;
            private set;
        }

        public Form1 Owner
        {
            get;
            set;
        }

        public C1BackstageView View
        {
            get;
            set;
        }

        public ItemButton Button
        {
            get
            {
                return tabButton1;
            }
        }

        #endregion

        #region methods

        public void LoadItems(List<RecentDocumentItem> items)
        {
            c1InputPanel1.Items.Clear();
            Items = items;
            var now = DateTime.Now;

            var pinned = items.Where(x => x.Pinned);
            var list = items.Except(pinned);
            if (pinned.Count() > 0)
            {
                AddLabel("Pinned");
                foreach (var item in pinned)
                    AddItem(item);
            }
            var today = list.Where(x => x.Date.Day == now.Day && x.Date.Month == now.Month && x.Date.Year == now.Year);
            if (today.Count() > 0)
            {
                AddLabel("Today");
                foreach (var item in today.OrderBy(x => x.Date))
                    AddItem(item);
            }
            var later = list.Except(today);
            if (later.Count() > 0)
            {
                AddLabel("Later");
                foreach (var item in later.OrderBy(x => x.Date))
                    AddItem(item);
            }
        }

        private void AddLabel(string text)
        {
            var label = new InputLabel();
            label.Break = BreakType.Row;
            label.Text = text;
            label.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.ForeColor = Color.FromArgb(0, 114, 198);
            c1InputPanel1.Items.Add(label);
        }

        private void AddItem(RecentDocumentItem item)
        {
            var mi = new ListItem();
            mi.SetItem(item, GetImage(item));
            mi.PinnedChanged += Mi_PinnedChanged;
            mi.Click += Mi_Click;
            var ch = new InputControlHost(mi);
            ch.Width = 370;
            ch.Height = 42;
            c1InputPanel1.Items.Add(ch);
        }
        
        private Image GetImage(RecentDocumentItem item)
        {
            var ext = System.IO.Path.GetExtension(item.FileName);
            if (_icons.ContainsKey(ext))
            {
                return _icons[ext];
            }
            if (System.IO.File.Exists(item.FileName))
            {
                _icons.Add(ext, Icon.ExtractAssociatedIcon(item.FileName).ToBitmap());
                return _icons[ext];
            }
            return null;
        }

        protected string GetElementText(string text)
        {
            string[] textParts = text != null
                ? text.Split('\n')
                : new string[] { string.Empty };

            return textParts[0].Trim();
        }

        #region virtual        
        protected virtual void OnMenuItemClick(ListItem item)
        {

        }
        protected virtual void OnMenuButtonClick()
        {

        }
        #endregion

        #endregion

        #region event handlers

        private void Mi_Click(object sender, EventArgs e)
        {
            OnMenuItemClick((ListItem)sender);
            View.DroppedDown = false;
        }

        private void Mi_PinnedChanged(object sender, EventArgs e)
        {
            LoadItems(Items);
        }

        private void menuButton1_Click(object sender, EventArgs e)
        {
            OnMenuButtonClick();
            View.DroppedDown = false;
        }

        #endregion
    }
}
