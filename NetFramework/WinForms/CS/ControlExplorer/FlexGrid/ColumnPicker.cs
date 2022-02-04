using System;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnPicker : C1DemoForm
    {
        public ColumnPicker()
        {
            InitializeComponent();

            //Setup FlexGrid
            c1FlexGrid1.ColumnContextMenuEnabled = true;
            c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.Highlight;
            c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = true;
            c1FlexGrid1.ColumnPickerInfo.ShowToolButton = true;
            c1FlexGrid1.DataSource = DemoDataSource("EmployeeOrders");
        }

        /// <summary>
        /// Handles menu Create column bands click.
        /// </summary>
        private void btnCreateBands_Click(object sender, EventArgs e)
        {
            if (c1FlexGridBandedView1.FlexGrid != null) return;
            
            c1FlexGrid1.BeginUpdate();
            c1FlexGridBandedView1.FlexGrid = c1FlexGrid1;
            c1FlexGridBandedView1.BandsColumnsRelation = C1.Win.C1FlexGrid.BandsColumnsRelation.BandsBeforeColumns;
            
            c1FlexGridBandedView1.BeginUpdate();
            c1FlexGridBandedView1.Bands.Clear();
            
            var bands = c1FlexGridBandedView1.Bands;
            
            var bandOrder = bands.Add(c1FlexGrid1.Cols["OrderID"]);
            bandOrder.Caption = "Order";
            
            var bandDate = bandOrder.Children.Add(c1FlexGrid1.Cols["OrderDate"]);
            bandDate.Caption = "Date";

            var bandCompany = bandOrder.Children.Add(c1FlexGrid1.Cols["CompanyName"]);
            bandCompany.Caption = "Company";

            c1FlexGridBandedView1.EndUpdate();
            c1FlexGrid1.EndUpdate();
        }

        /// <summary>
        /// Handles menu Remove column bands click.
        /// </summary>
        private void btnRemoveBands_Click(object sender, EventArgs e)
        {
            if (c1FlexGridBandedView1.FlexGrid == null) return;

            c1FlexGrid1.BeginUpdate();
            c1FlexGridBandedView1.FlexGrid = null;

            c1FlexGridBandedView1.BeginUpdate();
            c1FlexGridBandedView1.Bands.Clear();

            c1FlexGridBandedView1.EndUpdate();
            c1FlexGrid1.EndUpdate();
        }
    }
}
