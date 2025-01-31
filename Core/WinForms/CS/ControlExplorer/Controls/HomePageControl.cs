using ControlExplorer.Contrlols;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public partial class HomePageControl : UserControl
    {
        #region Private Variables
        private List<ItemInfo> _samples;
        #endregion

        #region Public Methods
        public HomePageControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            lblTitle.Text = Explorer.HomeTitle;
            lblDesc.Text = Explorer.SuiteDescription;
            lblFeature.Text = Explorer.HomeControlTitle;
        }

        public List<ItemInfo> Samples
        {
            get { return _samples; }
            set
            {
                if (value != null)
                {
                    _samples = value;
                    LoadCards();
                }
            }
        }
        #endregion

        #region Private Methods
        private void LoadCards()
        {
            var sortedControls = GetAllItems(_samples)
                               .Where(control => control.Home)
                               .OrderBy(control => control.Name)
                               .ToArray();

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Dock = DockStyle.Fill;

            foreach (ItemInfo control in sortedControls)
            {
                var tile = new TileCard()
                {
                    Text = control.Name,
                    Description = control.LongDescription,
                    Tag = control,
                };
                tile.Image = GetIconByName("Icon_" + control.Name);
                flowLayoutPanel.Controls.Add(tile);
            }
            pnlFeatureBody.Controls.Add(flowLayoutPanel);
        }
        private IEnumerable<ItemInfo> GetAllItems(IEnumerable<ItemInfo> items)
        {
            foreach (var item in items)
            {
                yield return item;
                if (item.Items != null && item.Items.Any())
                {
                    foreach (var childItem in GetAllItems(item.Items))
                    {
                        yield return childItem;
                    }
                }
            }
        }

        private Image GetIconByName(string iconName)
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(iconName);
        }

        #endregion
    }
}
