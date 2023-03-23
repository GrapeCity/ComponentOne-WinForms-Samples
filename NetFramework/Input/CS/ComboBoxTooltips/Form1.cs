using C1.Win.C1SuperTooltip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxTooltips
{
    public partial class Form1 : Form
    {
        private C1SuperTooltipBase _superTooltip = new C1SuperTooltipBase();
        private List<DataItem> _dataSource = new List<DataItem>();

        public Form1()
        {
            InitializeComponent();

            // set tooltip parameters property grid
            pgDefaultParameters.SelectedObject = _superTooltip;

            // add items and tooltip data
            AddDataItem("It`s Sphere.", "sphere", "sphere.png",
                string.Format("<table width='{0}' height='{1}' align='center'>" +
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:gold'>{2}</td></tr>" +
                              "<tr><td><img src='{3}' width='100' height='100'></td></tr></table>", 150, 150, "Sphere", "sphere.png"));

            AddDataItem("This Is The Cone.", "cone", "cone.png",
                string.Format("<table width='{0}' height='{1}' align='center'>" +
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:gold'>{2}</td></tr>" +
                              "<tr><td><img src='{3}' width='100' height='100'></td></tr></table>", 150, 150, "Cone", "cone.png"), 0);

            AddDataItem("Just a cube", "cube", "cube.png",
                string.Format("<table width='{0}' height='{1}' align='center'> " +
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:lightgreen'>{2}</td></tr>" +
                              "<tr><td align='center' style='background-color:lightblue'><img src='{3}' width='180' height='180'></td></tr></table>",
                              250, 250, "Cube", "cube.png"), -265);

            AddDataItem("Tooltip without image.", "", "",
                string.Format("<table width='{0}' height='{1}' align='center'>" +
                              "<tr><td style='font-size:15px;font-weight:bold;color:blue;background-color:cyan'>{2}<br><br>" +
                              "<font style='font-size:11px;color:DarkGreen'>{3}</font></td></tr></table>",
                              150, 80, "text only,<br>rounded corners", "without image"), 0);

            AddDataItem("Item without tooltip.", "", "", "", 0);

            AddDataItem("Cylinder", "cylinder", "cylinder.png",
                string.Format("<table width='{0}' height='{1}' align='center'>" +
                              "<tr><td><img src='{2}' width='100' height='100'></td></tr>" +
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:lightgreen'>{3}</td></tr></table>",
                              150, 150, "cylinder.png", "Cylinder..."), 0);

            // set data source
            c1ComboBox1.DataSource = _dataSource;
            c1ComboBox1.ItemsDataSource = _dataSource;
            c1ComboBox1.ItemsDisplayMember = "ItemText";
            c1ComboBox1.ItemsValueMember = "ItemText";

            // set other properties
            c1ComboBox1.ItemsImageList = imageList1;
            c1ComboBox1.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern;
            c1ComboBox1.HtmlPattern = "<table><tr><td><img src='{ImageFile}' width='16' height='16'></img></td><td><div style='white-space:nowrap'>{ItemText}</div></td></tr></table>";
            c1ComboBox1.ShowTooltip = true;

            c1ComboBox1.SelectedIndex = 1;

            // set instructions text
            label1.Text = "Design-time:" + Environment.NewLine + Environment.NewLine +
                          "1. Add items to C1ComboBox.Items collection." + Environment.NewLine +
                          "2. Add images to the imageList1." + Environment.NewLine +
                          "3. Set keys(Name) of the images equal to the items in C1ComboBox.Items." + Environment.NewLine +
                          "4. Enable tooltips for highlighted items by setting ShowTooltip = true." + Environment.NewLine +
                          "5. Add TooltipShowing event handler method." + Environment.NewLine +
                          "6. In the TooltipShowing event handler method add code to set tooltip parameters.";

            Reset();
        }

        private void c1ComboBox1_TooltipShowing(object sender, C1.Win.C1Input.TooltipShowingEventArgs e)
        {
            var item = _dataSource[e.Index];

            if (item != null)
            {
                if (string.IsNullOrEmpty(item.TooltipText))
                {
                    e.Handled = true; // don`t show tooltip for this item

                    // remove info text
                    tbxText.Text = string.Empty;
                    tbxX.Text = string.Empty;
                    tbxY.Text = string.Empty;

                    return;
                }

                // set default tooltip properties
                e.Tooltip.Active = _superTooltip.Active;
                e.Tooltip.AutomaticDelay = _superTooltip.AutomaticDelay;
                e.Tooltip.AutoPopDelay = _superTooltip.AutoPopDelay;
                e.Tooltip.BackColor = _superTooltip.BackColor;
                e.Tooltip.BackgroundGradient = _superTooltip.BackgroundGradient;
                e.Tooltip.BackgroundImage = _superTooltip.BackgroundImage;
                e.Tooltip.BackgroundImageLayout = _superTooltip.BackgroundImageLayout;
                e.Tooltip.Border = _superTooltip.Border;
                e.Tooltip.BorderColor = _superTooltip.BorderColor;
                e.Tooltip.FollowCursor = _superTooltip.FollowCursor;
                e.Tooltip.Font = _superTooltip.Font;
                e.Tooltip.ForeColor = _superTooltip.ForeColor;
                e.Tooltip.HitTestVisible = _superTooltip.HitTestVisible;
                e.Tooltip.InitialDelay = _superTooltip.InitialDelay;
                e.Tooltip.IsBalloon = _superTooltip.IsBalloon;
                e.Tooltip.MaximumWidth = _superTooltip.MaximumWidth;
                e.Tooltip.Opacity = _superTooltip.Opacity;
                e.Tooltip.ReshowDelay = _superTooltip.ReshowDelay;
                e.Tooltip.RoundedCorners = _superTooltip.RoundedCorners;
                e.Tooltip.Shadow = _superTooltip.Shadow;
                e.Tooltip.ShowAlways = _superTooltip.ShowAlways;
                e.Tooltip.StripAmpersands = _superTooltip.StripAmpersands;
                e.Tooltip.UseFading = _superTooltip.UseFading;

                e.Duration = Convert.ToInt32(tbxDuration.Text);

                // set tooltip X coordinate if assigned
                if (item.X != 0)
                {
                    e.X = item.X;
                }

                e.Text = item.TooltipText;

                // show info
                tbxText.Text = e.Text;
                tbxX.Text = Convert.ToString(e.X);
                tbxY.Text = Convert.ToString(e.Y);
            }
        }

        private void AddDataItem(string itemText, string imageKey, string imageFile, string tooltipText, int x = 0)
        {
            _dataSource.Add(new DataItem(itemText, imageKey, imageFile, tooltipText, x));

            // add images if assigned
            if (!string.IsNullOrEmpty(imageKey) && !string.IsNullOrEmpty(imageFile))
            {
                imageList1.Images.Add(imageKey, Image.FromFile(imageFile));
            }
        }

        private class DataItem
        {
            public DataItem()
            {}

            public DataItem(string itemText, string imageKey, string imageFile, string tooltipText, int x)
            {
                ItemText = itemText;
                ImageKey = imageKey;
                ImageFile = imageFile;
                TooltipText = tooltipText;
                X = x;
            }

            public string ItemText { get; set; }
            public string ImageKey { get; set; }
            public string ImageFile { get; set; }
            public string TooltipText { get; set; }
            public int X { get; set; }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridItem item = pgDefaultParameters.SelectedGridItem;
            PropertyDescriptor propertyDescriptor = item.PropertyDescriptor;

            if (propertyDescriptor != null && propertyDescriptor.CanResetValue(pgDefaultParameters.SelectedObject))
            {
                propertyDescriptor.ResetValue(pgDefaultParameters.SelectedObject);
                item.Select(); // refresh
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var item = pgDefaultParameters.SelectedGridItem;

            if (item != null && item.PropertyDescriptor != null)
            {
                resetToolStripMenuItem.Enabled = item != null && item.GridItemType == GridItemType.Property &&
                    item is ITypeDescriptorContext context && item.PropertyDescriptor.CanResetValue(context.Instance);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            tbxDuration.Text = "0";
        }
    }
}