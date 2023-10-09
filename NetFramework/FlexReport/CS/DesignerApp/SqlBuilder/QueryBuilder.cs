//----------------------------------------------------------------------------
// QueryBuilder.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;

using C1.Win.FlexReport;

namespace SqlBuilder
{
	public enum GroupByExtension
	{
		None,
		Cube,
		Rollup,
		All
	}

	/// <summary>
	/// 
	/// </summary>
	public class QueryBuilder
	{
		//----------------------------------------------------------------
		#region ** fields

		private QueryFieldCollection	_queryFields;	// used to build query
		private DataSetSchema			_schema;		// used to build query
		private string					_sql;			// generated sql
		private int						_tableCount;	// number of tables used
		private bool					_missingJoins;	// not all tables joined
		private bool					_groupBy;		// add GROUP BY clause
		private int						_top;			// top N records
		private bool					_distinct;		// distinct records
		private GroupByExtension		_gbExtension;	// cube/rollup/all

		#endregion

		//----------------------------------------------------------------
		#region ** ctor

		public QueryBuilder()
		{
			_sql = null;
			_schema = new DataSetSchema();
			_queryFields = new QueryFieldCollection();
			_distinct = true;
		}

		#endregion

		//----------------------------------------------------------------
		#region ** object model

		public string ConnectionString
		{
			get { return _schema.ConnectionString; }
			set 
			{
				if (_schema.ConnectionString != value)
				{
					_schema.ConnectionString = value;
					_sql = null;
					QueryFields.Clear();
				}
			}
		}
		public DataSet Schema
		{
			get { return _schema; }
		}
		public QueryFieldCollection QueryFields
		{
			get { return _queryFields; }
		}
		public bool GroupBy
		{
			get { return _groupBy; }
			set
			{
				if (_groupBy != value)
				{
					_groupBy = value; 
					_sql = null;
				}
			}
		}
		public GroupByExtension GroupByExtension
		{
			get { return _gbExtension; }
			set
			{
				if (_gbExtension != value)
				{
					_gbExtension = value; 
					_sql = null;
				}
			}
		}
		public int Top
		{
			get { return _top; }
			set
			{
				_top = value; 
				_sql = null;
			}
		}
		public bool Distinct
		{
			get { return _distinct; }
			set
			{
				_distinct = value; 
				_sql = null;
			}
		}
		public string Sql
		{
			get
			{
				if (_sql == null || _queryFields.IsDirty)
				{
					_queryFields.IsDirty = false;
					_sql = BuildSqlSelectStatement();
				}
				return _sql;
			}
		}
		public bool MissingJoins
		{
			get { return _missingJoins; }
		}
		public int TableCount
		{
			get { return _tableCount; }
		}
		#endregion

		//----------------------------------------------------------------
		#region ** private stuff

		private string BuildSqlSelectStatement()
		{
			// sanity
			if (QueryFields.Count == 0 || _schema == null)
			{
				_tableCount = 0;
				_missingJoins = false;
				return string.Empty;
			}

			// prepare to build sql statement
			StringBuilder sb = new StringBuilder();

			// select
			sb.Append("SELECT ");
			if (Distinct)	sb.Append("DISTINCT ");
			if (Top > 0)	sb.AppendFormat("TOP {0} ", Top);
			sb.Append(BuildSelectClause());

			// from
			sb.AppendFormat("\r\nFROM {0}", BuildFromClause());

			// group by
			if (GroupBy)
			{
				string groupBy = BuildGroupByClause();
				if (groupBy.Length > 0)
					sb.AppendFormat("\r\nGROUP BY {0}", groupBy);

				// having
				string having = BuildWhereClause();
				if (having.Length > 0)
				{
					sb.AppendFormat("\r\nHAVING {0}", having);
				}
			}
			else
			{
				// where
				string where = BuildWhereClause();
				if (where.Length > 0)
				{
					sb.AppendFormat("\r\nWHERE {0}", where);
				}
			}

			// order by
			string orderBy = GetOrderBy();
			if (orderBy.Length > 0)
				sb.AppendFormat("\r\nORDER BY {0}", orderBy);

			// done
			sb.Append(';');
			return sb.ToString();
		}

		private string BuildSelectClause()
		{
			StringBuilder sb = new StringBuilder();
			foreach (QueryField qf in QueryFields)
			{
				if (qf.Output)
				{
					// add separator
					if (sb.Length > 0)
						sb.Append(",\r\n\t");

					// add field expression ("table.column" or "colexpr")
					string item = qf.ToString(GroupBy);
					sb.Append(item);

					// add alias (use brackets to contain spaces, reserved words, etc)
					string alias = qf.Alias;
					if (alias.Length > 0)
					{
						if (alias.StartsWith("[") && alias.EndsWith("]"))
							sb.AppendFormat(" AS {0}", alias);
						else
							sb.AppendFormat(" AS [{0}]", alias);
					}
				}
			}
			return sb.ToString();
		}

		private string BuildFromClause()
		{
			// build list of tables in query
            List<DataTable> tables = new List<DataTable>();
			foreach (QueryField qf in QueryFields)
			{
				string tableName = qf.Table.TableName;
				DataTable table = _schema.Tables[tableName];
				if (table != null && !tables.Contains(table))
					tables.Add(table);
			}

			// save table count so caller can check this
			_tableCount = tables.Count;

			// build list of joined tables so each table is related to the next one
			// (Access requires this, SqlServer doesn't care)
            List<DataTable> qTables = new List<DataTable>();
			bool done = false;
			while (qTables.Count < tables.Count && !done)
			{
				done = true;
				foreach (DataTable dt in tables)
				{
					bool inserted = InsertRelatedTable(dt, qTables);
					if (inserted)
						done = false;
				}
			}

			// build join list
            List<string> qJoins = new List<string>();
			for (int index = 0; index < qTables.Count - 1; index++)
			{
				// get relation
				DataTable dt1 = qTables[index];
				DataTable dt2 = qTables[index+1];
				DataRelation dr = GetRelation(dt1, dt2);

				// build join statement
				qJoins.Add(string.Format("{0}.{1} = {2}.{3}",
                    StringParser.BracketSqlObject(dr.ParentTable.TableName),
                    StringParser.BracketSqlObject(dr.ParentColumns[0].ColumnName),
                    StringParser.BracketSqlObject(dr.ChildTable.TableName),
                    StringParser.BracketSqlObject(dr.ChildColumns[0].ColumnName)));
			}

			// build from statement
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < qTables.Count-1; i++)
                sb.AppendFormat("\r\n\t({0} INNER JOIN", StringParser.BracketSqlObject(qTables[i].TableName));
            sb.AppendFormat(" {0}", StringParser.BracketSqlObject(qTables[qTables.Count - 1].TableName));
            for (int i = qJoins.Count - 1; i >= 0; i--)
                sb.AppendFormat("\r\n\tON {0})", qJoins[i]);

			// not all tables joined? probably not what the user wants...
			_missingJoins = (qTables.Count < tables.Count);

			// add tables that couldn't be joined
			if (_missingJoins)
			{
				foreach (DataTable dt in tables)
				{
					if (!qTables.Contains(dt))
					{
                        sb.AppendFormat(", {0}", StringParser.BracketSqlObject(dt.TableName));
						qTables.Add(dt);
					}
				}
			}

			// done
			return sb.ToString();
		}

		// insert a table into the list in a position such that the table is
		// related to the table before and after it; return true on success
		private bool InsertRelatedTable(DataTable dt, List<DataTable> list)
		{
			// skip tables that have already been added
			if (list.Contains(dt))
			{
				return false;
			}

			// insert the first one
			if (list.Count == 0)
			{
				list.Add(dt);
				return true;
			}

			// look for a good insertion point
			for (int index = 0; index <= list.Count; index++)
			{
				// related to table before?
				bool before = index == 0 || 
					GetRelation(dt, list[index-1]) != null;

				// related to table after?
				bool after  = index == list.Count ||
					GetRelation(dt, list[index]) != null;

				// found a good insertion point, move on
				if (before && after)
				{
					list.Insert(index, dt);
					return true;
				}
			}

			// failed to insert
			return false;
		}

		// get the relation between two tables (or null if there's no relation)
		private DataRelation GetRelation(DataTable dt1, DataTable dt2)
		{
			foreach (DataRelation dr in _schema.Relations)
			{
				if ((dr.ParentTable == dt1 && dr.ChildTable == dt2) ||
					(dr.ParentTable == dt2 && dr.ChildTable == dt1))
				{
					return dr;
				}
			}
			return null;
		}

        private string BuildWhereClause()
		{
			StringBuilder sb = new StringBuilder();
			foreach (QueryField qf in QueryFields)
			{
				if (qf.Criteria.Length > 0)
				{
					// parse item
					string item = qf.GetCriteria();
					if (item.Length == 0)
						continue;

					// add separator
					if (sb.Length > 0)
						sb.Append(" AND\r\n\t");

					// add item (x > y)
					sb.Append(item);
				}
			}
			return sb.ToString();
		}

		private string BuildGroupByClause()
		{
			// no group by? done.
			if (!GroupBy)
				return string.Empty;

			StringBuilder sb = new StringBuilder();
			foreach (QueryField qf in QueryFields)
			{
				if (qf.GroupBy == Aggregate.GroupBy)
				{
					// add separator
					if (sb.Length > 0)
						sb.Append(",\r\n\t");

					// add field expression ("table.column" or "colexpr")
					string item = qf.ToString();
					sb.Append(item);
				}
			}

			// extension
			switch (GroupByExtension)
			{
				case GroupByExtension.All:
					return "ALL " + sb.ToString();
				case GroupByExtension.Cube:
					sb.Append(" WITH CUBE");
					break;
				case GroupByExtension.Rollup:
					sb.Append(" WITH ROLLUP");
					break;
			}

			// done
			return sb.ToString();
		}
		private string GetOrderBy()
		{
			StringBuilder sb = new StringBuilder();
			foreach (QueryField qf in QueryFields)
			{
				if (qf.Sort != Sort.NoSort)
				{
					// add separator
					if (sb.Length > 0)
						sb.Append(",\r\n\t");

					// add ORDER BY expression ("table.column" or "colexpr")
					string item = qf.ToString(true);
					sb.Append(item);

					// descending
					if (qf.Sort == Sort.Descending)
						sb.Append(" DESC");
				}
			}
			return sb.ToString();
		}
		#endregion
	}
}
