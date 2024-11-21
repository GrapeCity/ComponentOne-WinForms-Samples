using C1.Win.Ribbon;
using System;
using System.Windows.Forms;

namespace FlexPivotExplorer.Samples.FlexPivotRanges
{
    public partial class Form1 : UserControl
    {
        public Form1()
        {
            InitializeComponent();

            SetupRibbon();
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
