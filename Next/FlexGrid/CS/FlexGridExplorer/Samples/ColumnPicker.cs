using FlexGridExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class ColumnPicker : UserControl
    {
        public ColumnPicker()
        {
            InitializeComponent();

            //Setup FlexGrid
            c1FlexGrid1.ColumnContextMenuEnabled = true;
            c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.Highlight;
            c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = true;
            c1FlexGrid1.ColumnPickerInfo.ShowToolButton = true;

            c1FlexGrid1.BeginUpdate();

            c1FlexGrid1.DataSource = DataSource.GetRows("Select * from Orders");

            c1FlexGrid1.AutoSizeCols();
            c1FlexGrid1.AutoSizeRows();

            c1FlexGrid1.EndUpdate();
        }

        /// <summary>
        /// Handles menu Create column bands click.
        /// </summary>
        private void btnCreateBands_Click(object sender, EventArgs e)
        {
            if (c1FlexGridBandedView1.FlexGrid != null) return;

            c1FlexGrid1.BeginUpdate();
            c1FlexGridBandedView1.FlexGrid = c1FlexGrid1;
            c1FlexGridBandedView1.BandsColumnsRelation = C1.Win.FlexGrid.BandsColumnsRelation.BandsBeforeColumns;

            c1FlexGridBandedView1.BeginUpdate();
            c1FlexGridBandedView1.Bands.Clear();

            var bands = c1FlexGridBandedView1.Bands;

            var bandOrder = bands.Add(c1FlexGrid1.Cols["OrderID"]);
            bandOrder.Caption = "Order";

            var bandDate = bandOrder.Children.Add(c1FlexGrid1.Cols["OrderDate"]);
            bandDate.Caption = "Date";

            var bandCompany = bandOrder.Children.Add(c1FlexGrid1.Cols["CustomerID"]);
            bandCompany.Caption = "Customer";

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
