//--------------------------------------------------------------------------------
// PivotTable.cs
//--------------------------------------------------------------------------------
// Implements a PivotTable (cross-tab) based on a given DataTable, a pivot
// column, and a value column.
// 
// This initial version supports only sums and counts. More aggregates should
// be easy to add (e.g. Avg, StDev, Max, Min, Range, etc).
//
// This initial version supports only one pivot field.
//--------------------------------------------------------------------------------
using System;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace CrossTabs
{
	/// <summary>
	/// PivotTable is a transformed DataTable with additional columns that
	/// contain summarized data (sums or counts).
	/// </summary>
	/// <remarks>
	/// <p>This type of table/query is also know as a 'cross-tab'.</p>
	/// <p>The PivotTable is created based on a DataTable that contains the 
	/// original data, on a column that contains the pivot values, and on a
	/// column that contains the values to be summarized.</p>
	/// <p>The original data is usually obtained with a GROUP BY Sql query
	/// that summarizes the raw data into a flat table.</p>
	/// <p>The pivot column should contain discrete values that are transformed
	/// into columns. For example, categories, year, quarter. The PivotTable
	/// will generate a column for each distinct value in the pivot column.</p>
	/// <p>The value to be summarized are added (or counted) into the appropriate
	/// pivot column of the PivotTable depending on the value of the pivot 
	/// column.</p>
	/// </remarks>
	public class PivotTable : DataTable
	{
		/// <summary>
		/// Builds a new PivotTable based on a given DataTable, a pivot column,
		/// and the column that contains the values to be summarized.
		/// </summary>
		/// <param name="dt">DataTable with the original data.</param>
		/// <param name="pivotField">Name of the column that contains the pivot values (e.g. year, quarter).</param>
		/// <param name="valueField">Name of the column that contains the values to summarize (e.g. sales).</param>
		/// <param name="sum">Set to true to sum values, false to count.</param>
		public PivotTable(DataTable dt, string pivotField, string valueField, bool sum)
		{
			// sort source table by pivot values
			// so pivot columns will be added in order
			DataView dv = new DataView(dt);
			dv.Sort = pivotField;

			// create list of key columns
			// used as keys when adding rows to the pivot table
			ArrayList keyColumns = new ArrayList();
			foreach (DataColumn col in dt.Columns)
			{
				string colName = col.ColumnName;
				if (colName != pivotField && colName != valueField)
				{
					DataColumn key = Columns.Add(colName, col.DataType);
					keyColumns.Add(key);
				}
			}

			// add keys to pivot table (to enable lookup)
			UniqueConstraint unique = new UniqueConstraint(
				(DataColumn[])keyColumns.ToArray(typeof(DataColumn)), true);
			Constraints.Add(unique);

			// dimension look up array
			object[] keys = new object[keyColumns.Count];

			// use int or decimal to count or sum values
			Type type = (sum)? typeof(decimal): typeof(int);

			// add values to pivot table
			Hashtable pivotNames = new Hashtable();
			foreach (DataRowView drv in dv)
			{
				// get pivot value
				string pivotValue = drv[pivotField].ToString();

				// get pivot column name (from hash if we can, to save time)
				string pivotName = pivotNames[pivotValue] as string;
				if (pivotName == null)
				{
					// build pivot column name
					pivotName = Regex.Replace(pivotField, "[aeiou]", string.Empty);
					if (pivotName.Length > 5) pivotName = pivotName.Substring(0, 5);
					pivotName += pivotValue;
					pivotName = Regex.Replace(pivotName, "[^A-Za-z0-9_]", string.Empty);

					// save it for next time
					pivotNames[pivotValue] = pivotName;
				}

				// add pivot column if necessary
				if (!Columns.Contains(pivotName))
					Columns.Add(pivotName, type);

				// lookup existing row based on key columns
				for (int i = 0; i < keys.Length; i++)
				{
					string name = ((DataColumn)keyColumns[i]).ColumnName;
					keys[i] = drv[name];
				}
				DataRow drp = Rows.Find(keys);
				
				// add new row if necessary
				if (drp == null)
				{
					drp = NewRow();
					foreach (DataColumn col in keyColumns)
					{
						string name = col.ColumnName;
						drp[name] = drv[name];
					}
					Rows.Add(drp);
				}

				// get current aggregate value
				decimal oldVal = (drp[pivotName] != DBNull.Value)
					? (decimal)Convert.ChangeType(drp[pivotName],  typeof(decimal))
					: (decimal)0;

				// calculate aggregate (sum or count)
				if (sum)
				{
					decimal newVal = (drv[valueField] != DBNull.Value)
						? (decimal)Convert.ChangeType(drv[valueField],  typeof(decimal))
						: (decimal)0;
					drp[pivotName] = oldVal + newVal;
				}
				else
				{
					if (drv[valueField] != DBNull.Value)
						drp[pivotName] = (int)oldVal + 1;
				}
			}
		}
	}
}
