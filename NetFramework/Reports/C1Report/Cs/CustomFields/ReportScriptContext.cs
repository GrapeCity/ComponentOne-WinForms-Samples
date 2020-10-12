/*
 * This code is part of C1Report CustomFields sample.
 * 
 * Copyright (C) ComponentOne LLC
 */

using System;
using System.Collections.Generic;
using System.Data;

namespace C1.C1Report.CustomFields
{
    /// <summary>
    /// The abstract base class for DataTable/DataRow script contexts.
    /// Script contexts are used to evaluate script expressions in non-standard
    /// report contexts (e.g. if a custom RecordSource was provided for a map layer).
    /// </summary>
    abstract class DataTableReportScriptContextBase : IReportScriptContext
    {
        private Dictionary<string, ItemBase> _fields;

        protected DataTableReportScriptContextBase(DataColumnCollection columns)
        {
            // we *know* that usually an additional constant item (kmlItemName) will be added,
            // hence we add 1 to capacity even though it is not very elegant:
            if (columns != null)
            {
                _fields = new Dictionary<string, ItemBase>(columns.Count + 1);
                for (int i = 0; i < columns.Count; ++i)
                    _fields.Add(columns[i].ColumnName.ToLowerInvariant(), new Field(this, i));
            }
            else
                _fields = new Dictionary<string, ItemBase>(1);
        }

        protected abstract DataRow CurrentRow { get; }

        public void AddConstant(string name, object value)
        {
            _fields.Add(name.ToLowerInvariant(), new Constant(value));
        }

        #region Script object (must have Value property)
        private abstract class ItemBase
        {
            public abstract object Value { get; }
        }

        // NOTE: this must be a class (it can't be a struct) due to script engine implementation:
        private class Field : ItemBase
        {
            private DataTableReportScriptContextBase _owner;
            private int _columnIndex;

            public Field(DataTableReportScriptContextBase owner, int columnIndex)
            {
                _owner = owner;
                _columnIndex = columnIndex;
            }

            override public object Value
            {
                get { return _owner.CurrentRow[_columnIndex]; }
            }
        }

        private class Constant : ItemBase
        {
            private object _value;

            public Constant(object value)
            {
                _value = value;
            }

            override public object Value
            {
                get { return _value; }
            }
        }
        #endregion

        #region IReportScriptContext
        /// <summary>
        /// Retrieves an object from the current context for use in a script.
        /// </summary>
        /// <param name="name">The object's name.</param>
        /// <returns>The named object (the Value property will be used in the script).</returns>
        object IReportScriptContext.GetObjectByName(string name)
        {
            return _fields[name.ToLowerInvariant()];
        }

        /// <summary>
        /// Tests whether a name is defined by the current context.
        /// </summary>
        /// <param name="name">The object's name.</param>
        /// <returns>True if the specified name is defined by this context, false otherwise.</returns>
        bool IReportScriptContext.IsNameDefined(string name)
        {
            return _fields.ContainsKey(name);
        }
        #endregion
    }

    /// <summary>
    /// Represents a DataTable context.
    /// Use the <see cref="DataTableReportScriptContext.Foreach()"/> static method to loop through all rows of a table.
    /// </summary>
    class DataTableReportScriptContext : DataTableReportScriptContextBase
    {
        private DataTable _dataTable;
        private int _rowIndex;

        /// <summary>
        /// Loops through all rows of a data table.
        /// </summary>
        /// <param name="dataTable">The data table to loop through.</param>
        /// <returns>The context for each row.</returns>
        public static IEnumerable<IReportScriptContext> Foreach(DataTable dataTable)
        {
            var sc = new DataTableReportScriptContext(dataTable);
            for (sc._rowIndex = 0; sc._rowIndex < sc._dataTable.Rows.Count; ++sc._rowIndex)
                yield return sc;
        }

        private DataTableReportScriptContext(DataTable dataTable)
            : base(dataTable.Columns)
        {
            _dataTable = dataTable;
            _rowIndex = -1;
        }

        protected override DataRow CurrentRow
        {
            get { return _dataTable.Rows[_rowIndex]; }
        }
    }

    /// <summary>
    /// Represents a single DataRow context.
    /// </summary>
    class DataRowReportScriptContext : DataTableReportScriptContextBase
    {
        private DataRow _dataRow;

        /// <summary>
        /// Initializes a new instance of the data row context.
        /// Use this ctor for rows that belong to a data table.
        /// </summary>
        /// <param name="dataRow">The data row to create the context for.</param>
        public DataRowReportScriptContext(DataRow dataRow)
            : base(dataRow.Table.Columns)
        {
            _dataRow = dataRow;
        }

        /// <summary>
        /// Initializes a new instance of the data row context.
        /// Use this ctor for rows that have not yet been inserted into a table.
        /// </summary>
        /// <param name="dataRow">The data row to create the context for.</param>
        /// <param name="columns">The table columns collection.</param>
        public DataRowReportScriptContext(DataRow dataRow, DataColumnCollection columns)
            : base(columns)
        {
            _dataRow = dataRow;
        }

        protected override DataRow CurrentRow
        {
            get { return _dataRow; }
        }
    }
}
