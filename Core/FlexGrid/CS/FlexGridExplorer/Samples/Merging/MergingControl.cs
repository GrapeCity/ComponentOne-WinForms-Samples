using C1.Win.FlexGrid;
using FlexGridExplorer.Data;
using System;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class MergingControl : UserControl
    {
        public MergingControl()
        {
            InitializeComponent();

            mergingFlexGrid.DataSource = DataSource.MergingDataSource("EmployeeOrders");

            //apply some formatting
            mergingFlexGrid.Cols["Product"].Width = 250;
            mergingFlexGrid.Cols["UnitPrice"].Format = "c";
            mergingFlexGrid.Cols["ExtendedPrice"].Format = "c";

            //sort grid by specified column
            mergingFlexGrid.Sort(SortFlags.Ascending, 1, 2);

            // Populate propertiesCombobox with FlexGrid AllowMergingEnum values
            foreach (AllowMergingEnum value in Enum.GetValues(typeof(AllowMergingEnum)))
            {
                if (value.ToString() != "Default" && value.ToString() != "Custom")
                {
                    propertiesTsCbox.Items.Add(value.ToString());
                }
            }
        }

        private void propertiesTsCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (propertiesTsCbox.SelectedItem != null)
            {
                // Convert the selected string back to AllowMergingEnum
                mergingFlexGrid.AllowMerging = (AllowMergingEnum)Enum.Parse(
                    typeof(AllowMergingEnum), propertiesTsCbox.SelectedItem.ToString()
                );
            }
        }
    }
}
