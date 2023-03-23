using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using FlexGridExplorer.Data;

namespace FlexGridExplorer.Samples
{
    public partial class ApplySearch : UserControl
    {
        public ApplySearch()
        {
            InitializeComponent();
            c1FlexGrid1.DataSource = DataSource.GetRows("Select * from Orders");
            foreach (var searchHighlightMode in (SearchHighlightMode[])Enum.GetValues(typeof(SearchHighlightMode)))
            {
                cmbHlMode.Items.Add(searchHighlightMode.ToString());
            }
            cmbHlMode.SelectedIndex = 1;
            cmbFilter.SelectedIndex = 0;
        }

        private void cmbHlMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartSearch();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartSearch();
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInput.Text = cmbTemplates.Text;
        }

        private void StartSearch()
        {
            c1FlexGrid1.ApplySearch(txtInput.Text, (SearchHighlightMode)cmbHlMode.SelectedIndex,
                cmbFilter.SelectedIndex == 0 ? true : false);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            StartSearch();
        }
    }
}
