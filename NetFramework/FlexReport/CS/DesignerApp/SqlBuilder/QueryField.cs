//----------------------------------------------------------------------------
// QueryField.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Data;
using System.ComponentModel;
using System.Collections;

using C1.Win.FlexReport;

namespace SqlBuilder
{
	/// <summary>
	/// 
	/// </summary>
	public enum Sort
	{
		NoSort,
		Ascending,
		Descending
	}

	public enum Aggregate
	{
		GroupBy,
		Sum,
		Avg,
		Min,
		Max,
		Count,
		//Expression,
		//Where,
		SumDistinct,
		AvgDistinct,
		MinDistinct,
		MaxDistinct,
		CountDistinct,
		StDev,
		StDevP,
		Var,
		VarP
	}

	/// <summary>
	/// 
	/// </summary>
    public class QueryField : ICloneable, IDataErrorInfo
    {
        private static Regex _rx1 = new Regex(@"^([^<>=]*)\s*(<|>|=|<>|<=|>=)\s*([^<>=]+)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex _rx2 = new Regex(@"^([^<>=]*)\s*BETWEEN\s+(.+)\s+AND\s+(.+)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private string _column;	// column name (or expression)
        private string _alias;		// alias for this field (optional)
        private DataTable _table;		// source table
        private bool _output;	// include in SELECT clause
        private Aggregate _groupBy;	// GROUP BY clause
        private Sort _sort;		// ORDER BY clause
        private string _criteria;	// WHERE clause
        private string _errorInfo;	// IDataErrorInfo
        private bool _dirty;		// has changed since the last Sql gen
        internal QueryFieldCollection _coll;	// parent collection

        #region Constructors
        public QueryField(DataColumn col)
        {
            _table = col.Table;
            _column = col.ColumnName;
            _output = true;
            _dirty = true;
        }
        #endregion

        #region Private
        private string CheckedString(string s)
        {
            return (s == null) ? string.Empty : s;
        }

        private string MakeNewAlias()
        {
            for (int i = 1; true; i++)
            {
                bool duplicate = false;
                string alias = "Expr" + i;
                foreach (QueryField qf in _coll)
                {
                    if (qf != this && string.Compare(alias, qf.Alias, true) == 0)
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                    return alias;
            }
        }
        #endregion

        #region Internal properties
        internal bool IsDirty
        {
            get { return _dirty; }
            set { _dirty = value; }
        }
        #endregion

        #region Internal
        internal string GetCriteria()
        {
            // empty? easy
            string crit = this.Criteria.Trim();
            if (crit.Length == 0)
                return string.Empty;

            // get simple expressions
            Match m = _rx1.Match(crit);
            if (m.Success)
            {
                if (m.Groups[1].Value.Length == 0) // > x
                {
                    return string.Format("(({0}) {1})", this.ToString(true).Trim(), crit);
                }
                else // x > y
                {
                    return string.Format("({0})", crit);
                }
            }

            // get 'between' expressions
            m = _rx2.Match(crit);
            if (m.Success)
            {
                if (m.Groups[1].Value.Length == 0) // between x and y
                {
                    return string.Format("({0} {1})", this.ToString().Trim(), crit);
                }
                else // x between y and z
                {
                    return string.Format("({0})", crit);
                }
            }

            // oops...
            _errorInfo = "Cannot parse Criteria value. Should be '[y] <>= x' or '[z] between x and y'.";
            return string.Empty;
        }
        #endregion

        #region Public properties
        public string Column
        {
            get { return _column; }
            set
            {
                if (_column != value)
                {
                    _column = value;
                    IsDirty = true; ;
                }
            }
        }

        public string Alias
        {
            get { return CheckedString(_alias); }
            set
            {
                if (_alias != value)
                {
                    _alias = value;
                    IsDirty = true;
                }
            }
        }

        public DataTable Table
        {
            get { return _table; }
            set
            {
                if (_table != value)
                {
                    _table = value;
                    IsDirty = true;
                }
            }
        }

        public bool Output
        {
            get { return _output; }
            set
            {
                if (_output != value)
                {
                    _output = value;
                    IsDirty = true;
                }
            }
        }

        public Aggregate GroupBy
        {
            get { return _groupBy; }
            set
            {
                if (_groupBy != value)
                {
                    _groupBy = value;

                    // if groupby is an aggregate, we need an alias
                    if (_groupBy != Aggregate.GroupBy && Alias.Length == 0)
                        Alias = MakeNewAlias();

                    IsDirty = true;
                }
            }
        }

        public Sort Sort
        {
            get { return _sort; }
            set
            {
                if (_sort != value)
                {
                    _sort = value;
                    IsDirty = true;
                }
            }
        }

        public string Criteria
        {
            get { return CheckedString(_criteria); }
            set
            {
                if (_criteria != value)
                {
                    _errorInfo = null;
                    _criteria = value;
                    IsDirty = true;
                }
            }
        }
        #endregion

        #region Public
        public string ToString(
            bool groupBy)
        {
            string str = ToString();

            if (groupBy == false)
                return str;

            string fmt = "{0}";
            switch (GroupBy)
            {
                case Aggregate.Sum: fmt = "SUM({0})"; break;
                case Aggregate.Avg: fmt = "AVG({0})"; break;
                case Aggregate.Min: fmt = "MIN({0})"; break;
                case Aggregate.Max: fmt = "MAX({0})"; break;
                case Aggregate.Count: fmt = "COUNT({0})"; break;
                case Aggregate.StDev: fmt = "STDEV({0})"; break;
                case Aggregate.StDevP: fmt = "STDEVP({0})"; break;
                case Aggregate.Var: fmt = "VAR({0})"; break;
                case Aggregate.VarP: fmt = "VARP({0})"; break;
                case Aggregate.SumDistinct: fmt = "SUM(DISTINCT {0})"; break;
                case Aggregate.AvgDistinct: fmt = "AVG(DISTINCT {0})"; break;
                case Aggregate.MinDistinct: fmt = "MIN(DISTINCT {0})"; break;
                case Aggregate.MaxDistinct: fmt = "MAX(DISTINCT {0})"; break;
                case Aggregate.CountDistinct: fmt = "COUNT(DISTINCT {0})"; break;
            }
            return string.Format(fmt, str);
        }

        public override string ToString()
        {
            return Table.Columns.Contains(Column)
                ? string.Format("{0}.{1}", StringParser.BracketSqlObject(Table.TableName), StringParser.BracketSqlObject(Column))
                : StringParser.BracketSqlObject(Column);
        }
        #endregion

        #region ** ICloneable
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion

        #region ** IDataErrorInfo
        string IDataErrorInfo.this[string columnName]
        {
            get { return (columnName == "Criteria") ? _errorInfo : null; }
        }

        string IDataErrorInfo.Error
        {
            get { return null; } //_errorInfo; }
        }
        #endregion
    }

	/// <summary>
	/// 
	/// </summary>
	public class QueryFieldCollection : BindingArrayList
	{
		//----------------------------------------------------------------
		#region ** fields
		private int _chksum = -1;	// to detect changes in members
		#endregion

		//----------------------------------------------------------------
		#region ** ctor
		internal QueryFieldCollection() : base("Query Fields", typeof(QueryField))
		{
			AllowRemove = true;
			AllowSort = false;
		}
		#endregion

		//----------------------------------------------------------------
		#region ** overrides
		public int Add(QueryField value)
		{
			value._coll = this;
			return base.Add(value);
		}
		public int Add(DataColumn value)
		{
			return Add(new QueryField(value));
		}
		#endregion

		//----------------------------------------------------------------
		#region ** internal
		internal bool IsDirty
		{
			get 
			{
				// -1 means dirty, no work here...
				if (_chksum == -1)
					return true;

				// build checksum based on fields
				int chk = 1;
				foreach (QueryField qf in this)
				{
					// return true if the field is dirty
					if (qf.IsDirty) return true;
					chk += qf.GetHashCode() * chk;
				}

				// return true if the check sum has changed
				return chk != _chksum;
			}
			set
			{
				// making dirty is easy
				if (value)
				{
					_chksum = -1;
					return;
				}

				// we're clean, so build checksum based on fields
				int chk = 1;
				foreach (QueryField qf in this)
				{
					qf.IsDirty = value;
					chk += qf.GetHashCode() * chk;	
				}

				// and store checksum
				_chksum = chk;
			}
		}
		#endregion
	}
}
