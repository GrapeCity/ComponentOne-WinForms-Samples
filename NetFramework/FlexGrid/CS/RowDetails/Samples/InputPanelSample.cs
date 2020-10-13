using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace RowDetails
{
    public partial class InputPanelSample : UserControl
    {
        public InputPanelSample()
        {
            InitializeComponent();
        }

        private void InputPanel_Load(object sender, EventArgs e)
        {
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
