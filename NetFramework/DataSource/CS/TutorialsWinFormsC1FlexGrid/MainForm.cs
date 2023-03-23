using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutorialsWinFormsC1FlexGrid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showSimpleBinding_Click(object sender, EventArgs e)
        {
            new SimpleBinding().Show();
        }

        private void showMasterDetailBinding_Click(object sender, EventArgs e)
        {
            new MasterDetailBinding().Show();
        }

        private void showServerSideFiltering_Click(object sender, EventArgs e)
        {
            new ServerSideFiltering().Show();
        }

        private void showPaging_Click(object sender, EventArgs e)
        {
            new Paging().Show();
        }

        private void showLargeDataset_Click(object sender, EventArgs e)
        {
            new LargeDataset().Show();
        }

        private void showCustomColumns_Click(object sender, EventArgs e)
        {
            new CustomColumns().Show();
        }

        private void showDataSourcesInCode_Click(object sender, EventArgs e)
        {
            new DataSourcesInCode().Show();
        }

        private void showClientSideQuerying_Click(object sender, EventArgs e)
        {
            new ClientSideQuerying().Show();
        }

        private void showMVVM_Click(object sender, EventArgs e)
        {
            new CategoryProductsView().Show();
        }
    }
}
