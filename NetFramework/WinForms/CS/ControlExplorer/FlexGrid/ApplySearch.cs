using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class ApplySearch : C1DemoForm
    {
        public ApplySearch()
        {
            InitializeComponent();
        }

        private void ApplySearch_Load(object sender, EventArgs e)
        {
            c1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(flexGrid, c1FlexGridSearchPanel1);
            foreach (var searchHighlightMode in (SearchHighlightMode[])Enum.GetValues(typeof(SearchHighlightMode)))
            {
                cmbHlMode.Items.Add(searchHighlightMode.ToString());
            }
            cmbHlMode.SelectedIndex = 1;
            cmbFilter.SelectedIndex = 0;
            flexGrid.DataSource = DemoDataSource("orders");
        }

        private void cmbHlMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGridSearchPanel1.HighlightSearchResultsMode = (SearchHighlightMode)cmbHlMode.SelectedIndex;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGridSearchPanel1.FilterSearchResults = cmbFilter.SelectedIndex == 0 ? true : false;
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGridSearchPanel1.Text = cmbTemplates.Text;
        }
    }
}
