using System;
using System.Data;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace RowDetails.Samples
{
    public partial class InputPanelSample : UserControl
    {
        public InputPanelSample()
        {
            InitializeComponent();
        }

        private void InputPanel_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            string conn = Util.GetConnectionString();
            var ds = new DataSet();
            Util.FillTable(ds, "Customers", conn);

            flexGrid.DataSource = ds;
            flexGrid.DataMember = "Customers";
            flexGrid.RowDetailProvider = (g, r) => new C1InputPanelRowDetail();
            flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected;
        }
    }
}
