using ListExplorer.Data;
using System;
using System.Windows.Forms;

namespace ListExplorer.Samples
{
    public partial class FixedColumns : UserControl
    {
        public FixedColumns()
        {
            InitializeComponent();
        }

        private void FixedColumns_Load(object sender, EventArgs e)
        {
			string sql = @"SELECT Distinct
                    LastName,
                    FirstName,
                    Title,
                    TitleOfCourtesy,
                    BirthDate,
                    HireDate,
                    Address,
                    City,
                    Region,
                    PostalCode,
                    Country,
                    HomePhone,
                    Extension,
                    Notes
                FROM Employees;";
			c1List1.DataSource = DataSource.GetRows(sql);
            c1List1.Splits[0].DisplayColumns["LastName"].FixColumn(true);
            c1List1.Splits[0].DisplayColumns["FirstName"].FixColumn(true, 1);
        }
    }
}
