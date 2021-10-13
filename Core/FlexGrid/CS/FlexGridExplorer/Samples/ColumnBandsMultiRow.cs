using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using FlexGridExplorer.Data;

namespace FlexGridExplorer.Samples
{
    public partial class ColumnBandsMultiRow : UserControl
    {
        public ColumnBandsMultiRow()
        {
            InitializeComponent();

            SetupC1FlexGrid();

            CreateBands();
        }

        /// <summary>
        /// Create column bands
        /// </summary>
        public void CreateBands()
        {
            c1FlexGridBandedView1.BeginUpdate();

            c1FlexGridBandedView1.Bands.Clear();

            c1FlexGridBandedView1.BandsColumnsRelation = BandsColumnsRelation.Bands;

            var bands = c1FlexGridBandedView1.Bands;
            bands.Add("OrderID");

            var bMain = bands.Add("Ship");
            bMain.ColSpan = 3;
            bMain.Children.Add("ShipVia");
            bMain.Children.Add("ShippedDate");
            bMain.Children.Add("ShipName");

            var bDescription = bMain.Children.Add("ShipAddress");
            bDescription.ColSpan = 3;
            bDescription.RowSpan = 3;

            bands.Add("CustomerID");
            bands.Add("EmployeeID");
            bands.Add("OrderDate");

            c1FlexGridBandedView1.EndUpdate();
        }

        /// <summary>
        /// Setup C1FlexGrid with data
        /// </summary>
        private void SetupC1FlexGrid()
        {
            flexGrid1.BeginUpdate();

            flexGrid1.DataSource = DataSource.GetRows("Select * from Orders");

            flexGrid1.AutoSizeCols();
            flexGrid1.AutoSizeRows();

            flexGrid1.EndUpdate();
        }

    }
}
