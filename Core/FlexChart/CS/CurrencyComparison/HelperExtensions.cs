using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Reflection;

namespace CurrencyComparison
{
    public static class HelperExtensions
    {
        public static DataTable FilterTableByDate(this DataTable sourceTable, DateTime date)
        {
            var rows = from row in sourceTable.AsEnumerable()
                       where row.Field<DateTime>("Date") >= date
                       select row;

            if (rows.Count() > 0)
                return rows.CopyToDataTable<DataRow>();
            else return null;
        }

        public static DataTable ImportData()
        {
            DataTable sourceTable = new DataTable();
            var rows = Utils.Read("CurrencyHistory.csv").TrimEnd().Split('\n');
            var headers = rows[0].TrimEnd().Split(',');
            foreach (string header in headers)
            {
                if (header == "Date")
                    sourceTable.Columns.Add(header, typeof(DateTime));
                else
                    sourceTable.Columns.Add(header, typeof(double));
            }

            for (int i = 1; i < rows.Length; i++)
            {
                string[] columns = rows[i].TrimEnd().Split(',');
                DataRow row = sourceTable.NewRow();
                for (int j = 0; j < columns.Length; j++)
                {
                    if (j == 0)
                        row[j] = DateTime.ParseExact(columns[j], "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    else
                    {
                        double d;
                        row[j] = double.TryParse(columns[j], out d) ? Math.Round(d, 4) : sourceTable.Rows[sourceTable.Rows.Count - 1][j];
                    }
                }
                sourceTable.Rows.Add(row);
            }
            return sourceTable;
        }

        public static DataTable ConvertToBase(this DataTable sourceTable, string baseCurrency)
        {
            DataTable newTable = sourceTable.Clone();
            foreach (DataRow sourceRow in sourceTable.Rows)
            {
                DataRow newRow = newTable.NewRow();
                foreach (DataColumn col in newTable.Columns)
                {
                    if (col.ColumnName == "Date")
                        newRow[col.ColumnName] = sourceRow["Date"];
                    else
                        newRow[col.ColumnName] = Math.Round((double)sourceRow[col.ColumnName] / (double)sourceRow[baseCurrency], 4);
                }
                newTable.Rows.Add(newRow);
            }
            return newTable;
        }

        public static DataTable ConvertToPercentage(this DataTable sourceTable)
        {
            DataTable newTable = sourceTable.Clone();
            for (int i = 0; i < sourceTable.Rows.Count; i++)
            {
                DataRow newRow = newTable.NewRow();
                foreach (DataColumn col in sourceTable.Columns)
                {
                    if (col.ColumnName == "Date")
                        newRow[col.ColumnName] = sourceTable.Rows[i].ItemArray[col.Ordinal];
                    else
                    {
                        var x1 = (double)sourceTable.Rows[sourceTable.Rows.Count - 1].ItemArray[col.Ordinal];
                        var x2 = (double)sourceTable.Rows[i].ItemArray[col.Ordinal];
                        newRow[col.ColumnName] = Math.Round(((x2 - x1) / x1), 4);
                    }
                }
                newTable.Rows.Add(newRow);
            }
            return newTable;
        }

        public static DateTime AddBusinessDays(this DateTime current, int days)
        {
            var sign = Math.Sign(days);
            var unsignedDays = Math.Abs(days);
            for (var i = 0; i < unsignedDays; i++)
            {
                do
                {
                    current = current.AddDays(sign);
                }
                while (current.DayOfWeek == DayOfWeek.Saturday ||
                    current.DayOfWeek == DayOfWeek.Sunday);
            }
            return current;
        }
    }



  
}
