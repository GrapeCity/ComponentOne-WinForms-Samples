using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples.RowDetails
{
    using FlexGridExplorer.Data;
    public partial class InputPanelSample : UserControl
    {
        public InputPanelSample()
        {
            InitializeComponent();
        }

        private void InputPanelSample_Load(object sender, EventArgs e)
        {
            flexGrid.DataSource = DataSource.GetRows("Select * from Customers");

            flexGrid.RowDetailProvider = (g, r) => new C1InputPanelRowDetail();
            flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected;
        }
    }
}
