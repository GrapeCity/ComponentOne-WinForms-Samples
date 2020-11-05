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
        private DataSet employeesDataSet;
        private BindingSource employeesDataSource;

        public DataBinding()
        {
            InitializeComponent();
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            // Creating data source
            var sql = @"
                Select 
	                EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate,  HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes
                from Employees";

            var table = DataSource.GetRows(sql);
            table.TableName = "Employees";

            employeesDataSet = new DataSet();
            employeesDataSet.Tables.Add(table);

            employeesDataSource = new BindingSource();
            employeesDataSource.DataSource = employeesDataSet;
            employeesDataSource.DataMember = "Employees";

            // Connecting datasource
            c1InputPanel1.DataSource = employeesDataSource;
        }
    }
}
