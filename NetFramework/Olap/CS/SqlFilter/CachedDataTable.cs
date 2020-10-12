//#define USE_SQL
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SqlFilter
{
    /// <summary>
    /// Extends the <see cref="DataTable"/> class to load and cache data on demand
    /// using a <see cref="Fill"/> method that takes a set of keys as a parameter.
    /// </summary>
    class CachedDataTable : DataTable
    {
        //----------------------------------------------------------------------------
        #region ** fields

        Dictionary<object, bool> _values = new Dictionary<object, bool>();

        #endregion

        //----------------------------------------------------------------------------
        #region ** ctors

        public CachedDataTable(string sqlTemplate, string whereClauseTemplate, string connString)
        {
            ConnectionString = connString;
            SqlTemplate = sqlTemplate;
            WhereClauseTemplate = whereClauseTemplate;
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** object model

        public string ConnectionString { get; set; }
        public string SqlTemplate { get; set; }
        public string WhereClauseTemplate { get; set; }

        public void Fill(IEnumerable filterValues)
        {
            Fill(filterValues, false);
        }
        public void Fill(IEnumerable filterValues, bool reset)
        {
            // reset table if requested
            if (reset)
            {
                _values.Clear();
                Rows.Clear();
            }

            // get a list with the new values
            List<object> newValues = GetNewValues(filterValues);
            if (newValues.Count > 0)
            {
                // get sql statement and data adapter
                var sql = GetSqlStatement(newValues);
#if USE_SQL
                using (var da = new SqlDataAdapter(sql, ConnectionString))
#else
                using (var da = new OleDbDataAdapter(sql, ConnectionString))
#endif
                {
                    // add new values to the table
                    try
                    {
                        BeginLoadData();
                        var start = DateTime.Now;
                        int rows = da.Fill(this);
                        Console.WriteLine("read {0} rows in {1} ms", rows, DateTime.Now.Subtract(start).TotalMilliseconds);
                    }
                    finally
                    {
                        EndLoadData();
                    }
                }
            }
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** implementation

        // gets a list with the filter values that are not already in the
        // current values collection; 
        // and add them all to the current values collection.
        List<object> GetNewValues(IEnumerable filterValues)
        {
            var list = new List<object>();
            foreach (object value in filterValues)
            {
                if (!_values.ContainsKey(value))
                {
                    list.Add(value);
                    _values[value] = true;
                }
            }
            return list;
        }

        // gets a sql statement to add new values to the table
        string GetSqlStatement(List<object> newValues)
        {
            return string.Format(SqlTemplate, GetWhereClause(newValues));
        }
        string GetWhereClause(List<object> newValues)
        {
            if (newValues.Count == 0 || string.IsNullOrEmpty(WhereClauseTemplate))
            {
                return string.Empty;
            }

            // build list of values
            StringBuilder sb = new StringBuilder();
            foreach (object value in newValues)
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                if (value is string)
                {
                    sb.AppendFormat("'{0}'", ((string)value).Replace("'", "''"));
                }
                else
                {
                    sb.Append(value);
                }
            }

            // build where clause
            return string.Format(WhereClauseTemplate, sb);
        }

        #endregion
    }
}
