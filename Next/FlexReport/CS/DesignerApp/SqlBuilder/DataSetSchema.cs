//----------------------------------------------------------------------------
// DataSetSchema.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using Microsoft.Win32;

using C1.Win.FlexReport;

namespace SqlBuilder
{
	/// <summary>
	/// 
	/// </summary>
	internal class DataSetSchema : DataSet
	{
		string _conn = string.Empty;

		#region Public properties
		public string ConnectionString
		{
			get { return (_conn != null)? _conn: string.Empty; }
			set
			{
				if (value == null) value = string.Empty;
				if (value != _conn)
				{
					_conn = value;
					GetSchema();
				}
			}
		}
		#endregion 

		#region Private
		private void GetSchema()
		{
			// note: don't call Clear(), that removes all rows in all tables
			// we want to get rid of the tables, relations, etc altogether.
			this.Reset();

			// go get the schema
			EnforceConstraints = false;
            DataLinkParams dlp = new DataLinkParams()
            {
                ConnectionString = _conn,
            };
            using (OleDbConnection conn = (OleDbConnection)OledbLink.Instance.CreateConnection(dlp))
			{
				conn.Open();
				GetTables(conn);
				GetRelations(conn);
				GetConstraints(conn);
				conn.Close();
			}
		}

		private void GetTables(
            OleDbConnection conn)
		{
			DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
			foreach (DataRow dr in dt.Rows)
			{
				string type = dr["TABLE_TYPE"].ToString();
				if (string.Compare(type, "TABLE", true) == 0 ||
					string.Compare(type, "VIEW", true) == 0)
				{
					// create new table
					string tableName = (string)dr["TABLE_NAME"];
					DataTable table = new DataTable(tableName);

                    // try getting the table schema (this can fail)
                    try
                    {
                        // add brackets now 
                        // so we can work with tables called 'index' for example.
                        // get table schema
                        OleDbDataAdapter da = new OleDbDataAdapter(string.Format("select * from [{0}]", tableName), conn);
                        da.FillSchema(table, SchemaType.Mapped);

                        // save table type (table or view)
                        table.ExtendedProperties["TABLE_TYPE"] = type;

                        // add new table to dataset
                        Tables.Add(table);
                    }
                    catch
                    {
                        // error happened when reading schema for this table
                        // ignore and continue...
                    }
				}
			}
		}

		private void GetRelations(
            OleDbConnection conn)
		{
			DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, null);
			foreach (DataRow dr in dt.Rows)
			{
				// get primary/foreign table and column names
                string pkTableName = (string)dr["PK_TABLE_NAME"];
                string fkTableName = (string)dr["FK_TABLE_NAME"];
                string pkColumnName = (string)dr["PK_COLUMN_NAME"];
                string fkColumnName = (string)dr["FK_COLUMN_NAME"];

				// make sure both tables are in our DataSet
				if (!Tables.Contains(pkTableName) || !Tables.Contains(fkTableName))
					continue;

				// make sure tables are different
				if (pkTableName == fkTableName)
					continue;

				// get unique relation name
				string relationName = pkTableName + '_' + fkTableName;
				if (Relations.Contains(relationName))
					relationName += Relations.Count.ToString();

				// add to collection
				DataColumn pkColumn = Tables[pkTableName].Columns[pkColumnName];
				DataColumn fkColumn = Tables[fkTableName].Columns[fkColumnName];
				Relations.Add(relationName, pkColumn, fkColumn, true);
			}
		}

        private void GetConstraints(
            OleDbConnection conn)
        {
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, null);
            Hashtable uniqueTables = new Hashtable();
            foreach (DataRow dr in dt.Rows)
            {
                // get primary key info
                string tableName = dr["TABLE_NAME"].ToString();
                string columnName = dr["COLUMN_NAME"].ToString();

                // make sure this table is in our DataSet
                if (!Tables.Contains(tableName))
                    continue;

                // make sure it's unique
                if (uniqueTables.Contains(tableName))
                {
                    uniqueTables.Remove(tableName);
                    continue;
                }

                // save and move on
                uniqueTables[tableName] = columnName;
            }

            // built unique list, now set up primary key columns
            foreach (string tableName in uniqueTables.Keys)
            {
                // set up column
                string columnName = (string)uniqueTables[tableName];
                DataTable table = Tables[tableName];
                DataColumn pk = table.Columns[columnName];
                pk.Unique = true;
                pk.AllowDBNull = false;

                // try setting auto increment this can fail...
                if (pk.DataType != typeof(string))
                {
                    try
                    {
                        pk.AutoIncrement = true;
                        pk.ReadOnly = true;
                    }
                    catch { }
                }

                // set primary key on parent table
                Tables[tableName].PrimaryKey = new DataColumn[] { pk };
            }
        }
		#endregion
	}
}
