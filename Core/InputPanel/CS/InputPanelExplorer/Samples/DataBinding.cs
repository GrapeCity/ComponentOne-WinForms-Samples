using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputPanelExplorer.Samples
{
    using InputPanelExplorer.Data;
    public partial class DataBinding : UserControl
    {
        private BindingSource employeesBindingSource;

        public DataBinding()
        {
            InitializeComponent();
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {

            // Creating data source
            employeesBindingSource = new BindingSource();
            employeesBindingSource.DataSource = DataSource.GetRows("Select * from Employees");

            c1InputPanel1.DataSource = employeesBindingSource;
        }
    }
}
