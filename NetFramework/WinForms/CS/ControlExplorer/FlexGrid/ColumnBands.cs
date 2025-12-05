using C1.Win.FlexGrid;
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
    public partial class ColumnBands : BaseDataBoundForm
    {
        public ColumnBands()
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

            var bandOrder = new Band
            {
                Name = "BandOrder",
                Caption = "Order",
                CollapseTo = "OrderDate"
            };
            c1FlexGridBandedView1.Bands.Add(bandOrder);

            var bandOrderId = new Band
            {
                Name = "OrderID",
                Caption = "Id"
            };
            bandOrder.Children.Add(bandOrderId);

            var bandOrderDate = new Band
            {
                Name = "OrderDate",
                Caption = "Date"
            };
            bandOrder.Children.Add(bandOrderDate);

            c1FlexGridBandedView1.Bands.Add("CompanyName");
            c1FlexGridBandedView1.Bands.Add("Country");
            c1FlexGridBandedView1.Bands.Add("Salesperson");

            var bandProduct = new Band
            {
                Name = "BandProduct",
                Caption = "Product",
                CollapseTo = "Quantity"
            };
            c1FlexGridBandedView1.Bands.Add(bandProduct);

            var bandProductName = new Band
            {
                Name = "Product",
                Caption = "Name"
            };
            bandProduct.Children.Add(bandProductName);

            var bandQuantity = new Band
            {
                Name = "Quantity",
                Caption = "Quantity"
            };
            bandProduct.Children.Add(bandQuantity);

            var bandPrice = new Band
            {
                Name = "Price",
                Caption = "Price",
                CollapseTo = "Discount"
            };
            bandProduct.Children.Add(bandPrice);

            var bandUnitPrice = new Band
            {
                Name = "UnitPrice",
                Caption = "UnitPrice"
            };
            bandPrice.Children.Add(bandUnitPrice);

            var bandDicsount = new Band
            {
                Name = "Discount",
                Caption = "Discount"
            };
            bandPrice.Children.Add(bandDicsount);

            c1FlexGridBandedView1.EndUpdate();
        }

    }
}
