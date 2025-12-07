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

namespace ControlExplorer.FlexGrid.RowDetails
{
    public partial class InputPanelSample : C1DemoForm
    {
        public InputPanelSample()
        {
            InitializeComponent();
        }

        private void InputPanelSample_Load(object sender, EventArgs e)
        {
            flexGrid.DataSource = DemoDataSource("Customers");

            flexGrid.RowDetailProvider = (g, r) => new C1InputPanelRowDetail();
            flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected;
        }
    }
}
