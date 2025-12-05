// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using MultiSelectExplorer.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultiSelectExplorer.Samples.Filter
{
    /// <summary>
    /// Generic service for filtering any column in a DataTable-bound grid.
    /// </summary>
    public class GridColumnFilterService
    {
        private readonly DataTable _table;
        private readonly string _columnName;

        public GridColumnFilterService(DataTable table, string columnName)
        {
            _table = table ?? throw new ArgumentNullException(nameof(table));
            _columnName = !string.IsNullOrWhiteSpace(columnName)
                ? columnName
                : throw new ArgumentException(Resources.ColumnNameNullOrEmpty, nameof(columnName));
        }

        public void ApplyFilter(IEnumerable<string> selectedValues)
        {
            if (selectedValues == null || !selectedValues.Any())
            {
                // Apply a filter that always evaluates to false ("1=0"),
                // ensuring the DataView returns no rows (empty result).
                _table.DefaultView.RowFilter = "1=0";
                return;
            }

            string filter = string.Join(" OR ",
                selectedValues.Select(v => $"{_columnName} = '{EscapeSql(v)}'"));

            _table.DefaultView.RowFilter = filter;
        }

        public void ClearFilter()
        {
            _table.DefaultView.RowFilter = string.Empty;
        }

        public List<string> GetDistinctValues()
        {
            return _table.AsEnumerable()
                         .Select(r => r.Field<string>(_columnName))
                         .Where(v => !string.IsNullOrEmpty(v))
                         .Distinct()
                         .OrderBy(v => v)
                         .ToList();
        }

        private static string EscapeSql(string value)
        {
            return value?.Replace("'", "''") ?? string.Empty;
        }
    }
}
