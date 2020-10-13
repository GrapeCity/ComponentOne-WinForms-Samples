//----------------------------------------------------------------------------
// C1\SqlBuilder\DataSetSchema.cs
//
// This is a part of the C1ReportDesigner package.
// Copyright (C) 2002 - 2005 ComponentOne LLC
// All rights reserved.
//
// This source code is intended as a supplement to the C1ReportDesigner 
// control and related documentation provided with the product.
//
// See these sources for detailed information regarding the
// C1ReportDesigner product.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace SqlBuilder
{
	/// <summary>
	/// 
	/// </summary>
	internal class DataSetSchema : DataSet
	{
		//----------------------------------------------------------------
		#region ** fields

		string _conn = string.Empty;

		#endregion

		//----------------------------------------------------------------
		#region ** object model

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

		//----------------------------------------------------------------
		#region ** private stuff

		private void GetSchema()
		{
			// translate ODBC requests into Access or SqlServer
			string connString = TranslateConnectionString(_conn);

			// note: don't call Clear(), that removes all rows in all tables
			// we want to get rid of the tables, relations, etc altogether.
			this.Reset();

			// go get the schema
			EnforceConstraints = false;
			using (OleDbConnection conn = new OleDbConnection(connString))
			{
				conn.Open();
				GetTables(conn);
				GetRelations(conn);
				GetConstraints(conn);
				conn.Close();
			}
		}
		private void GetTables(OleDbConnection conn)
		{
			DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
			foreach (DataRow dr in dt.Rows)
			{
				string type = dr["TABLE_TYPE"].ToString();
				if (string.Compare(type, "TABLE", true) == 0 ||
					string.Compare(type, "VIEW", true) == 0)
				{
					// create new table
					string name = BracketName((string)dr["TABLE_NAME"]);
                    DataTable table = new DataTable(name);

					// get table schema
					OleDbDataAdapter da = new OleDbDataAdapter("select * from " + name, conn);
					da.FillSchema(table, SchemaType.Mapped);

					// save table type (table or view)
					table.ExtendedProperties["TABLE_TYPE"] = type;

					// add new table to dataset
					Tables.Add(table);
				}
			}
		}
		private void GetRelations(OleDbConnection conn)
		{
			DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, null);
			foreach (DataRow dr in dt.Rows)
			{
				// get primary/foreign table and column names
				string pkTableName  = BracketName((string)dr["PK_TABLE_NAME"]);
				string fkTableName  = BracketName((string)dr["FK_TABLE_NAME"]);
				string pkColumnName = BracketName((string)dr["PK_COLUMN_NAME"]);
				string fkColumnName = BracketName((string)dr["FK_COLUMN_NAME"]);

				// make sure both tables are in our DataSet
				if (!Tables.Contains(pkTableName) || 
					!Tables.Contains(fkTableName))
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
		private void GetConstraints(OleDbConnection conn)
		{
			DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, null);
			Hashtable uniqueTables = new Hashtable();
			foreach (DataRow dr in dt.Rows)
			{
				// get primary key info
				string tableName  = dr["TABLE_NAME"].ToString();
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
				DataTable table   = Tables[tableName];
				DataColumn pk     = table.Columns[columnName];
				pk.Unique         = true;
				pk.AllowDBNull    = false;

				// set auto increment
				if (pk.DataType != typeof(string))
				{
					pk.AutoIncrement = true;
					pk.ReadOnly = true;
				}

				// set primary key on parent table
				Tables[tableName].PrimaryKey = new DataColumn[] { pk };
			}
		}
		char[] _badChars = new char[] { '.', ' ' };
		private string BracketName(string name)
		{
            return (name.IndexOfAny(_badChars) > -1 || name == "Order")
                ? string.Format("[{0}]", name)
                : name;
        }
		// translate ODBC connection strings into Access or SqlServer
		private static string TranslateConnectionString(string connString)
		{
			// we are only interested in the MSDASQL provider (ODBC data sources)
			if (connString == null || connString.ToLower().IndexOf("provider=msdasql") < 0)
				return connString;

			// get name of ODBC data source
			Match m = Regex.Match(connString, "Data Source=(?<ds>[^;]+)", RegexOptions.IgnoreCase);
			string ds = m.Groups["ds"].Value;
			if (ds == null || ds.Length == 0)
				return connString;

			// look up ODBC entry in registry (LocalMachine and CurrentUser) <<B166>>
			string keyName = @"software\odbc\odbc.ini\" + ds;
			using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyName))
			{
				if (key != null)
					return TranslateConnectionString(connString, key);
			}
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName))
			{
				if (key != null)
					return TranslateConnectionString(connString, key);
			}

			// key not found...
			return connString;
		}
		private static string TranslateConnectionString(string connString, RegistryKey key)
		{
			// get driver
			string driver = key.GetValue("driver") as string;

			// translate Access (jet) data sources
			if (driver != null && driver.ToLower().IndexOf("odbcjt") > -1)
			{
				string mdb = key.GetValue("dbq") as string;
				if (mdb != null && mdb.ToLower().EndsWith(".mdb"))
				{
					return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdb + ";";
				}
			}

			// translate SqlServer data sources
			if (driver != null && driver.ToLower().IndexOf("sqlsrv") > -1)
			{
				string server = key.GetValue("server") as string;
				string dbase  = key.GetValue("database") as string;
				if (server != null && server.Length > 0 && dbase != null && dbase.Length > 0)
				{
					string fmt = "Provider=SQLOLEDB.1;" +
						"Integrated Security=SSPI;" +
						"Persist Security Info=False;" +
						"Initial Catalog={0};" +
						"Data Source={1}";
					return string.Format(fmt, dbase, server);
				}
			}

			// unsupported data source...
			return connString;
		}
		
		#endregion
	}
}
