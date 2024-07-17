using C1.Win.C1GanttView;
using C1.Win.C1InputPanel;
using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SoftwareDevelopmentPlan
{
    public partial class FileAppMenu : UserControl
    {
        #region ctor
        public FileAppMenu()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(212, 212, 212);
        }
        #endregion

        #region properties
        public C1GanttView GanttView
        {
            get;
            set;
        }

        public List<Item> Items
        {
            get;
            private set;
        }

        public RibbonApplicationMenu RibbonApplicationMenu
        {
            get;
            set;
        }
        #endregion

        #region methods
        public void LoadItems(List<Item> items)
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

        private void AddItem(Item item)
        {
            var mi = new MenuItem(item);
            mi.PinnedChanged += Mi_PinnedChanged;
            mi.Click += Mi_Click;
            var ch = new InputControlHost(mi);
            ch.Width = 390;
            ch.Height = 42;
            c1InputPanel1.Items.Add(ch);
        }

        #region virtual
        protected virtual void OnMenuItemClick(MenuItem item)
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
            OnMenuItemClick((MenuItem)sender);
            RibbonApplicationMenu.DroppedDown = false;
        }
        
        private void Mi_PinnedChanged(object sender, EventArgs e)
        {
            LoadItems(Items);
        }        

        private void menuButton1_Click(object sender, EventArgs e)
        {
            OnMenuButtonClick();
            RibbonApplicationMenu.DroppedDown = false;
        }
        #endregion

    }

    public class OpenFileAppMenu: FileAppMenu
    {
        #region override
        protected override void OnMenuItemClick(MenuItem mi)
        {
            GanttView.LoadXml(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text));
            mi.Item.Date = DateTime.Now;
        }

        protected override void OnMenuButtonClick()
        {
            if (GanttView != null)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.DefaultExt = ".xml";
                    dlg.Filter = "XML files|*.xml|All files|*.*";
                    dlg.Title = "Load From XML File";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            GanttView.LoadXml(dlg.FileName);
                            var item = new Item();
                            item.Date = DateTime.Now;
                            item.Text = Path.GetFileName(dlg.FileName);
                            item.SubText = Path.GetDirectoryName(dlg.FileName);
                            if (Items.FirstOrDefault(x => x.Text == item.Text && x.SubText == item.SubText) == null)
                                Items.Add(item);
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
        #endregion
    }

    public class SaveFileAppMenu : FileAppMenu
    {
        #region override
        protected override void OnMenuItemClick(MenuItem mi)
        {
            GanttView.SaveXml(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text));
            mi.Item.Date = DateTime.Now;
        }

        protected override void OnMenuButtonClick()
        {
            if (GanttView != null)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.DefaultExt = ".xml";
                    dlg.Filter = "XML files|*.xml|All files|*.*";
                    dlg.Title = "Save To XML File";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            GanttView.SaveXml(dlg.FileName);
                            var item = new Item();
                            item.Date = DateTime.Now;
                            item.Text = Path.GetFileName(dlg.FileName);
                            item.SubText = Path.GetDirectoryName(dlg.FileName);
                            if (Items.FirstOrDefault(x => x.Text == item.Text && x.SubText == item.SubText) == null)
                                    Items.Add(item);
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
        #endregion
    }
    [Serializable]
    public class Item
    {
        [NonSerialized]
        private Image _image;
        public string Text { get; set; }
        public string SubText { get; set; }               
        public DateTime Date { get; set; }
        public bool Pinned { get; set; }

        public Image GetImage()
        {
            return _image;
        }

        public void SetImage(Image image)
        {
            _image = image;
        }
    }
}
