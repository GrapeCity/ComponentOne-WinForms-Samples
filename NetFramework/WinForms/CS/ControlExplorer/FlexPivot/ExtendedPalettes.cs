using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.Chart.Palettes;
using C1.Win.FlexPivot;

namespace ControlExplorer.FlexPivot
{
    public partial class ExtendedPalettes : C1DemoForm
    {
        public ExtendedPalettes()
        {
            InitializeComponent();
        }

        FlexPivotChart chart;

        private void OnLoad(object sender, EventArgs e)
        {
            var panel = new C1FlexPivotPanel() { Dock = DockStyle.Fill, Visible = false };
            chart = new FlexPivotChart() { Dock = DockStyle.Fill, LegendGroups = true };
            tableLayoutPanel1.Controls.Add(chart);

            panel.DataSource = LegendGroups.CreateSampleDataTable(1000);

            panel.PivotEngine.RowFields.Add( "Product");
            panel.PivotEngine.ColumnFields.Add("Region", "Country");
            panel.PivotEngine.ValueFields.Add("Sales");

            chart.DataSource = panel;

            chart.Updated += (_,__) => CreatePaletteContextMenu();
        }

        void CreatePaletteContextMenu()
        {
            var cmenu = chart.ContextMenuStrip;

            // check if already created
            if (cmenu.Items[cmenu.Items.Count - 1].Text == "Extended Palettes")
                return;


            // create palette menu items and add them to the default context menu
            cmenu.Items.Add(new ToolStripSeparator());

            var menu = new ToolStripMenuItem("Extended Palettes");
           
            menu.DropDownItems.Add(CreatePaletteMenu("Qualitative", Qualitative.Brushes));
            menu.DropDownItems.Add(CreatePaletteMenu("Diverging", Diverging.Brushes));
            menu.DropDownItems.Add(CreatePaletteMenu("Sequential Single", SequentialSingle.Brushes));
            menu.DropDownItems.Add(CreatePaletteMenu("Sequential Multi", SequentialMulti.Brushes));

            cmenu.Items.Add(menu);
        }

        // create menu item for the set of palettes
        ToolStripMenuItem CreatePaletteMenu(string name, IDictionary<string, IList<Brush>> dict)
        {
            var menu = new ToolStripMenuItem(name);
            foreach (var item in dict)
                menu.DropDownItems.Add(item.Key, GetPaletteImage(item.Value), (_, __) =>
                {
                    chart.CustomPalette = item.Value;
                    chart.Palette = C1.Chart.Palette.Custom;
                });

            menu.DropDownOpening += (_, __) =>
            {
                foreach (ToolStripMenuItem item in menu.DropDownItems)
                    item.Checked = chart.CustomPalette == dict[item.Text];
            };

            return menu;
        }

        // create palette swatch
        static Image GetPaletteImage(IList<Brush> brushes)
        {
            if (brushes == null)
                return null;

            var img = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(img))
            {
                var dx = 4;

                for (var i = 0; i < 8; i++)
                {
                    var sb = brushes[i];

                    if (i >= 4)
                        g.FillRectangle(sb, dx * (i - 4), 8, dx, 8);
                    else
                        g.FillRectangle(sb, dx * i, 0, dx, 8);
                }
            }
            return img;
        }
    }
}
