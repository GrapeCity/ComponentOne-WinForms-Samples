using MultiColumnComboExplorer.Data;
using System;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    public partial class CustomView : UserControl
    {
        public CustomView()
        {
            InitializeComponent();
        }

        private void CustomView_Load(object sender, EventArgs e)
        {
            multiComboTree.CustomView = new CustomTreeView(multiComboTree);
            multiComboTree.ValueMember = "ID";
            multiComboTree.DisplayMember = "FirstName";            
            multiComboTree.GroupDescriptions.Add(new("ChiefID"));
            multiComboTree.GroupDescriptions.Add(new("ID"));
            multiComboTree.DataSource = DataSource.GetRows();

            multiComboGridView.CustomView = new CustomDataGridView(multiComboGridView);
            multiComboGridView.DataSource = DataSource.GetRows("Select * from Customers", "Customers");
            multiComboGridView.ValueMember = "CustomerID";
            multiComboGridView.DisplayMember = "CompanyName";            
        }
    }
}
