using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnBandsMultiRow : BaseDataBoundForm
    {
        public ColumnBandsMultiRow()
        {
            InitializeComponent();

            CreateBands();
        }

        /// <summary>
        /// Create column bands
        /// </summary>
        private void CreateBands()
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

    }
}
