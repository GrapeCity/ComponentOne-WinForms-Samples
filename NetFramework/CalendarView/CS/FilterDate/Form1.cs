using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilterDate
{
    public partial class Form1 : Form
    {
        DataTable _dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataSource();
            SetupDateEdit();
            SetupDataGridView();
            HighlightBestDealDates();
        }

        private void SetupDataSource()
        {
            var idColumn = new DataColumn("ID", typeof(int));
            idColumn.AutoIncrement = true;
            _dt.Columns.Add(idColumn);
            _dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            _dt.Columns.Add(new DataColumn("Price", typeof(double)));
            _dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
            _dt.Columns.Add(new DataColumn("Cost", typeof(double)));
            _dt.Columns.Add(new DataColumn("Title", typeof(string)));

            var startDate = GetStartDate();

            var row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(1, 10, 52, 11)), 1000, 10, 10000, "Pear PC Mark I" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(2, 14, 48, 1)), 699.95, 50, 34997.5, "Samson Universe S" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(3, 9, 1, 46)), 699.95, 10, 6999.5, "Samson Universe S" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(3, 17, 19, 29)), 899.95, 25, 22498.75, "Samson Universe B" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(4, 11, 21, 13)), 755.99, 17, 12851.83, "Pegasus Dao II" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(6, 13, 26, 21)), 111.65, 12, 1339.8, "Pear PC Mark II" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(6, 15, 4, 27)), 755.99, 10, 7559.9, "Pegasus Dao II" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(7, 12, 43, 12)), 755.99, 15, 11339.85, "Pegasus Dao II" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(10, 14, 47, 28)), 100, 10, 1000, "Pegasus Dao III" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(13, 16, 21, 37)), 749.95, 30, 22498.5, "Pear Phone Ultra" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(14, 14, 13, 24)), 899.95, 25, 22498.75, "Samson Universe B" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(15, 9, 17, 49)), 999.95, 10, 9999.50, "Samson Universe B2" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(16, 9, 26, 37)), 755.99, 20, 15119.8, "Pegasus Dao II" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(17, 18, 31, 9)), 755.99, 18, 13607.82, "Pegasus Dao II" };
            _dt.Rows.Add(row);

            row = _dt.NewRow();
            row.ItemArray = new object[6] { null, startDate.Add(new TimeSpan(21, 16, 10, 27)), 349.99, 10, 1749.95, "Pegasus Dao I" };
            _dt.Rows.Add(row);
        }

        private DateTime GetStartDate()
        {
            var previousMonth = DateTime.Now.Date.AddMonths(-1);
            return new DateTime(previousMonth.Year, previousMonth.Month, 1);
        }

        private void SetupDateEdit()
        {
            var minDate = (DateTime)_dt.Compute("Min(Date)", string.Empty);
            var maxDate = (DateTime)_dt.Compute("Max(Date)", string.Empty);

            deStartDate.Value = deStartDate.Calendar.MinDate = deEndDate.Calendar.MinDate = minDate;
            deEndDate.Value = deStartDate.Calendar.MaxDate = deEndDate.Calendar.MaxDate = maxDate;
        }

        private void SetupDataGridView()
        {
            dgvData.DataSource = _dt;
            dgvData.Columns["Price"].DefaultCellStyle.Format = "c";
            dgvData.Columns["Cost"].DefaultCellStyle.Format = "c";
        }

        private void de_ValueChanged(object sender, EventArgs e)
        {
            var rowFilter = string.Empty;
            var startDateExist = deStartDate.Value != DBNull.Value;
            var endDateExist = deEndDate.Value != DBNull.Value;

            var endDate = deEndDate.Value as DateTime?;
            var startDate = deStartDate.Value as DateTime?;

            if (startDateExist)
            {
                rowFilter = "Date >= #" + startDate?.ToString("MM/dd/yyyy 00:00:00", CultureInfo.InvariantCulture) + "#";
                if (endDateExist)
                    rowFilter += " And ";
            }
            if (endDateExist)
            {
                rowFilter += "Date <= #" + endDate?.ToString("MM/dd/yyyy 23:59:59", CultureInfo.InvariantCulture) + "#";
            }

            HighlightBestDealDates(rowFilter);

            _dt.DefaultView.RowFilter = rowFilter;
        }

        private void HighlightBestDealDates(string rowFilter = null)
        {
            var maxCostInRange = _dt.Compute("Max(Cost)", rowFilter) as double?;
            var maxCostInRangeExpression = string.Empty;
            if (maxCostInRange != null)
            {
                maxCostInRangeExpression = "Cost=" + maxCostInRange?.ToString(CultureInfo.InvariantCulture);
            }

            if (!string.IsNullOrEmpty(rowFilter))
            {
                if (maxCostInRangeExpression.Length > 0)
                    maxCostInRangeExpression += " And ";
                maxCostInRangeExpression += rowFilter;
            }

            var dataRows = _dt.Select(maxCostInRangeExpression);

            var datesToHighlight = new DateTime[dataRows.Length];

            for (int d = 0; d < dataRows.Length; d++)
                datesToHighlight[d] = (DateTime)dataRows[d][1];

            deStartDate.Calendar.BoldedDates = deEndDate.Calendar.BoldedDates = datesToHighlight;
        }
    }
}
