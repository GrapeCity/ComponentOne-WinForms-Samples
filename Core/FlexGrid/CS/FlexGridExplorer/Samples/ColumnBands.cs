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
    public partial class ColumnBands : UserControl
    {
        public ColumnBands()
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

            var bands = c1FlexGridBandedView1.Bands;

            var band1 = bands.Add("Order");
            band1.Children.Add("OrderID");
            band1.Children.Add("OrderDate");
            band1.CollapseTo = "OrderDate";

            var band2 = bands.Add("Shipping");
            band2.CollapseTo = "ShipCountry";
            band2.Children.Add("ShippedDate");
            band2.Children.Add("ShipVia");
            band2.Children.Add("ShipName");
            band2.Children.Add("ShipAddress");
            band2.Children.Add("ShipCity");
            band2.Children.Add("ShipRegion");
            band2.Children.Add("ShipPostalCode");
            band2.Children.Add("ShipCountry");

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

            foreach (RowCol col in flexGrid1.Cols)
            {
                col.TextAlign = TextAlignEnum.CenterCenter;
            }

            flexGrid1.EndUpdate();
        }

    }
}
