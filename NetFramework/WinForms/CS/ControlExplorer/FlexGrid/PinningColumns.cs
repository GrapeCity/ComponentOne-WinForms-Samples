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
    public partial class PinningColumns : C1DemoForm
    {
        public PinningColumns()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            FillFlexGrid(c1FlexGrid1);
            c1FlexGrid1.AllowPinning = C1.Win.C1FlexGrid.AllowPinning.SingleColumn;
            c1FlexGrid1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns;
            c1FlexGrid1.Cols.Frozen = 3;
            FillFlexGrid(c1FlexGrid2);
            c1FlexGrid2.AllowPinning = C1.Win.C1FlexGrid.AllowPinning.ColumnRange;
            c1FlexGrid2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns;
            c1FlexGrid2.Cols.Frozen = 4;
        }

        private void FillFlexGrid(C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid)
        {
            c1FlexGrid.DataSource = DemoDataSource("EmployeeOrders");

            c1FlexGrid.Cols["Product"].MinWidth = 120;
            c1FlexGrid.Cols["Product"].StarWidth = "*";
            c1FlexGrid.Cols["UnitPrice"].Format = "n2";
            c1FlexGrid.Cols["ExtendedPrice"].Format = "n2";
        }
    }
}
