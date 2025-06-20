using C1.Win.InputPanel;
using MultiColumnComboExplorer.Data;
using System;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    public partial class MasterDetail : UserControl
    {
        public MasterDetail()
        {
            InitializeComponent();
        }

        private void MasterDetail_Load(object sender, EventArgs e)
        {
            var data = new BindingSource(DataSource.GetSalesInfo(), "");
            CustomizeDetailPanel(data);
        }

        private void CustomizeDetailPanel(BindingSource source)
        {            
            ipDetailed.DataSource = source;
            // master area
            ipDetailed.Items.Insert(0, new InputGroupHeader()
            {
                Text = "Master"
            });
            ipDetailed.Items.Insert(1, new InputLabel()
            {
                Text = "Select a product:",
                AutoAdjustWidth = true
            });
            MultiColumnComboHost columnComboHost = new();
            ipDetailed.Items.Insert(2, columnComboHost);
            columnComboHost.MultiColumnCombo.DataSource = source;
            columnComboHost.MultiColumnCombo.DisplayMember = "Product";
            columnComboHost.MultiColumnCombo.ValueMember = "Id";
            // detail area
            ((InputGroupHeader)ipDetailed.Items[3]).Text = "Detail";
            ipDetailed.Items[4].Visibility = C1.Win.InputPanel.Visibility.Collapsed;
            ipDetailed.Items[5].Visibility = C1.Win.InputPanel.Visibility.Collapsed;
            ipDetailed.Items[6].Visibility = C1.Win.InputPanel.Visibility.Collapsed;
            ipDetailed.Items[7].Visibility = C1.Win.InputPanel.Visibility.Collapsed;
            ipDetailed.Items[11].Break = C1.Win.InputPanel.BreakType.Column;
            ((C1.Win.InputPanel.InputNumericBox)ipDetailed.Items[15]).Maximum = 10000;
            ((C1.Win.InputPanel.InputNumericBox)ipDetailed.Items[17]).Maximum = 10000;
        }
    }
}
