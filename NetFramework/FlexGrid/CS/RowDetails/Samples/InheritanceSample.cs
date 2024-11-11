using System;
using System.Data;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace RowDetails
{
    public partial class InheritanceSample : UserControl
    {
        public InheritanceSample()
        {
            InitializeComponent();
        }

        private void InheritanceSample_Load(object sender, EventArgs e)
        {
            string conn = Util.GetConnectionString();
            var ds = new DataSet();
            Util.FillTable(ds, "Employees", conn);

            flexGrid.DataSource = ds;
            flexGrid.DataMember = "Employees";
            flexGrid.RowDetailProvider = (g, r) => new DerivedRowDetail();
            flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected;
            flexGrid.Cols["Notes"].Visible = false;
        }
    }
}
