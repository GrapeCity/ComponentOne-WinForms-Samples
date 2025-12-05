using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Themes;

namespace FlexPivotRanges
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            SetupRibbon();
            SetupThemes();
            pivotView1.WorkspaceSetup(GetConnectionString());
            pivotView1.ActiveViewIndex = 0;
        }

        void SetupRibbon()
        {
            backstageViewTab1.Control = panel1;
            rGallery.AllowZooming = true;
            foreach (var view in pivotView1.Views)
            {
                var gi = new RibbonGalleryItem(view.Name) {GroupName = view.GroupName, ID = view.Name, ToolTip = view.Name};
                rGallery.Items.Add(gi);
            }

            cbShowPanel.Checked = pivotView1.ShowFlexPivotPanel;
        }

        void SetupThemes()
        {
            foreach(var theme in C1ThemeController.GetThemes().Where(x => x.Contains("Office365")).ToList())
                listBox1.Items.Add(theme);
            listBox1.SelectedIndex = listBox1.Items.IndexOf("Office365White");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1ThemeController.ApplyThemeToControlTree(this, C1ThemeController.GetThemeByName(listBox1.SelectedItem.ToString(), false), null, true);
        }

        private void cbShowSlicers_Click(object sender, EventArgs e)
        {
            pivotView1.ShowSlicers = cbShowSlicers.Checked;
        }

        private void cbShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            pivotView1.ShowFlexPivotPanel = cbShowPanel.Checked;
        }

        private void rGallery_SelectedIndexChanged(object sender, EventArgs e)
        {
            pivotView1.ActiveViewIndex = rGallery.SelectedIndex;
        }

        // get connection string to sample database
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
