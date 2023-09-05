//----------------------------------------------------------------------------
// DataSourcePicker_Types.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SqlBuilder;

using Doc = C1.Win.C1Document;
using C1.Win.FlexReport;

namespace FlexReportDesignerApp.Util
{
    public partial class DataSourcePicker : UserControl
    {
        #region Nested types
        public class ReportParameterDesc
        {
            public string Name;
            public Doc.ParameterType Type;

            #region Constructors
            public ReportParameterDesc(string name, Doc.ParameterType type)
            {
                Name = name;
                Type = type;
            }
            #endregion
        }


        private class DataProviderDesc
        {
            public DsgnDataLinkBase Link;

            #region Constructors
            public DataProviderDesc(
                DsgnDataLinkBase link)
            {
                Link = link;
            }
            #endregion

            #region Public
            public override string ToString()
            {
                return Link.Caption;
            }
            #endregion
        }

        private class ConnectionDesc
        {
            public DsgnDataLinkBase Link;
            public string ConnectionString;
            public string Caption;
            public string Details;

            #region Constructors
            public ConnectionDesc(
                DsgnDataLinkBase link,
                string connectionString)
            {
                Link = link;
                ConnectionString = connectionString;
                Link.Parse(ConnectionString, out Caption, out Details);
            }
            #endregion

            #region Public static
            public static ConnectionDesc FromSettingsString(
                string s)
            {
                int i = s.IndexOf(';');
                if (i == -1)
                    return new ConnectionDesc(DsgnAutoLink.Instance, s);
                if (Enum.IsDefined(typeof(DataProvider), s.Substring(0, i)))
                    return new ConnectionDesc(DsgnDataLinkBase.GetLink((DataProvider)Enum.Parse(typeof(DataProvider), s.Substring(0, i))), s.Substring(i + 1));
                else
                    return new ConnectionDesc(DsgnAutoLink.Instance, s);
            }
            #endregion

            #region Public
            public string ToSettingsString()
            {
                return Link.DataProvider.ToString() + ";" + ConnectionString;
            }

            public override string ToString()
            {
                return ConnectionString;
            }
            #endregion
        }

        private abstract class ObjectDesc
        {
            #region Public
            public virtual IList<ReportParameterDesc> GetRecordSourceParameters()
            {
                return null;
            }
            #endregion

            #region Public properties
            public abstract string RecordSourceString { get; }

            public abstract RecordSourceType RecordSourceType { get; }
            #endregion
        }

        private abstract class DataObjectDesc : ObjectDesc
        {
            public string Name;
            public string SchemaName;

            #region Constructors
            public DataObjectDesc(
                string name,
                string schemaName)
                : base()
            {
                Name = name;
                SchemaName = schemaName;
            }
            #endregion

            #region Public properties
            public override string RecordSourceString
            {
                get
                {
                    return string.IsNullOrEmpty(SchemaName) ? StringParser.Bracket(Name) : string.Format("{0}.{1}", StringParser.Bracket(SchemaName), StringParser.Bracket(Name));
                }
            }
            #endregion
        }

        private class ExternalRecordsetDesc : ObjectDesc
        {
            public IC1FlexReportExternalRecordset Recordset;
            public string Parameters;

            #region Constructors
            public ExternalRecordsetDesc(
                IC1FlexReportExternalRecordset recordset,
                string parameters)
                : base()
            {
                Recordset = recordset;
                Parameters = parameters;
            }
            #endregion

            #region Public properties
            public override string RecordSourceString
            {
                get { return Recordset.GetType().FullName + ";" + Parameters; }
            }

            public override RecordSourceType RecordSourceType
            {
                get { return C1.Win.FlexReport.RecordSourceType.Text; }
            }
            #endregion
        }

        private class DataTableDesc : DataObjectDesc
        {
            #region Constructors
            public DataTableDesc(
                string name,
                string schemaName)
                : base(name, schemaName)
            {
            }
            #endregion

            #region Public properties
            public override RecordSourceType RecordSourceType
            {
                get { return C1.Win.FlexReport.RecordSourceType.TableDirect; }
            } 
            #endregion
        }

        private class StoredProcedureDesc : DataObjectDesc
        {
            public List<ReportParameterDesc> Params = new List<ReportParameterDesc>();

            #region Constructors
            public StoredProcedureDesc(
                string name,
                string schemaName)
                : base(name, schemaName)
            {
            }
            #endregion

            #region Public
            public override IList<ReportParameterDesc> GetRecordSourceParameters()
            {
                return Params;
            }
            #endregion

            #region Public properties
            public override string RecordSourceString
            {
                get
                {
                    string procName = base.RecordSourceString;
                    if (Params.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder(procName + "(");
                        foreach (ReportParameterDesc rpd in Params)
                        {
                            sb.Append(string.Format("{0}, ", rpd.Name));
                        }
                        sb.Remove(sb.Length - 2, 2);
                        sb.Append(")");
                        return sb.ToString();
                    }
                    else
                        return procName;
                }
            }

            public override RecordSourceType RecordSourceType
            {
                get { return C1.Win.FlexReport.RecordSourceType.StoredProcedure; }
            }
            #endregion
        }

        private abstract class DsgnDataLinkBase
        {
            public readonly static DsgnDataLinkBase[] Links = new DsgnDataLinkBase[] { DsgnAutoLink.Instance, DsgnOledbLink.Instance, DsgnOdbcLink.Instance, DsgnXmlLink.Instance, DsgnExternalObjectLink.Instance, DsgnSqlServerCe3_5Link.Instance, DsgnSqlServerCe4_0Link.Instance, DsgnSQLiteLink.Instance };

            #region Public static
            public static DsgnDataLinkBase GetLink(
                DataProvider dataProvider)
            {
                foreach (DsgnDataLinkBase dl in Links)
                    if (dl.DataProvider == dataProvider)
                        return dl;
                // should never be here
                throw new ArgumentException();
            }
            #endregion

            #region Public
            public abstract bool EditConnection(DataSourcePicker dsp, ref string connectionString);

            public abstract bool UpdateControls(DataSourcePicker dsp, string recordSource);

            public virtual void Parse(
                string connectionString,
                out string caption,
                out string details)
            {
                details = null;
                caption = ShortCaption;
                ConnectionStringParser csp = ConnectionStringParser.Parse(connectionString);
                if (csp != null)
                    details = csp.GetDataLocation();
                if (string.IsNullOrEmpty(details))
                    details = connectionString;
            }
            #endregion

            #region Public properties
            public abstract DataLinkBase Link { get; }

            public abstract string Caption { get; }

            public abstract string ShortCaption { get; }

            public abstract DataProvider DataProvider { get; }

            public virtual bool Available
            {
                get { return Link.Available; }
            }
            #endregion
        }

        private class DsgnAutoLink : DsgnDataLinkBase
        {
            public readonly static DsgnAutoLink Instance = new DsgnAutoLink();

            #region Public
            public DsgnDataLinkBase GetRealLink(DataSourcePicker dsp)
            {
                DataLinkParams dlp = new DataLinkParams();
                dlp.ConnectionString = dsp._cbConnectionString.Text;
                if (dsp.DataSource != null)
                    dlp.Report = dsp.DataSource.ParentReport;
                DataProvider dp = DataLinkBase.GetDataProviderForConnectionString(dlp);
                return GetLink(dp);
            }

            public override bool UpdateControls(
                DataSourcePicker dsp,
                string recordSource)
            {
                return GetRealLink(dsp).UpdateControls(dsp, recordSource);
            }

            public override bool EditConnection(
                DataSourcePicker dsp,
                ref string connectionString)
            {
                // should never be here
                return false;
            }
            #endregion

            #region Public properties
            public override DataLinkBase Link
            {
                get { return null; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.AutoCaption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.AutoShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.Auto; }
            }

            public override bool Available
            {
                get { return true; }
            }
            #endregion
        }

        private abstract class DsgnDbLink : DsgnDataLinkBase
        {
            #region Private
            private TreeNode FindNode(
                TreeNodeCollection nodes,
                string recordSource)
            {
                foreach (TreeNode n in nodes)
                {
                    DataObjectDesc dod = n.Tag as DataObjectDesc;
                    if (dod != null && dod.RecordSourceString == recordSource)
                        return n;
                    TreeNode result = FindNode(n.Nodes, recordSource);
                    if (result != null)
                        return result;
                }
                return null;
            }
            #endregion

            #region Protected
            protected enum ObjectType
            {
                TableOrView,
                StoredProcedure,
            }

            protected TreeNode AddTableViewNode(
                string name,
                string schema,
                int imageIndex,
                TreeNode parentNode)
            {
                //
                DataTableDesc dtd = new DataTableDesc(name, schema);

                //
                TreeNode result = new TreeNode(name);
                result.Tag = dtd;
                result.ImageIndex = imageIndex;
                result.SelectedImageIndex = imageIndex;
                if (string.IsNullOrEmpty(schema))
                {
                    parentNode.Nodes.Add(result);
                }
                else
                {
                    TreeNode nSchema = FindSchemaNode(parentNode.Nodes, schema);
                    if (nSchema == null)
                    {
                        nSchema = new TreeNode(schema, c_SchemaImageIndex, c_SchemaImageIndex);
                        parentNode.Nodes.Add(nSchema);
                    }
                    nSchema.Nodes.Add(result);
                }

                //
                return result;
            }

            protected virtual bool IsDbObjectVisible(
                ObjectType objectType,
                string name,
                string schema,
                string type)
            {
                if (schema == "sys" || schema == "INFORMATION_SCHEMA")
                    return false;
                switch (objectType)
                {
                    case ObjectType.TableOrView:
                        if (string.Compare(type, "TABLE", true) != 0 &&
                            string.Compare(type, "VIEW", true) != 0 &&
                            string.Compare(type, "LINK", true) != 0)
                            return false;
                        return true;
                    case ObjectType.StoredProcedure:
                        if (name.StartsWith("~") || name.StartsWith("dt_"))
                            return false;
                        return true;
                }
                return false;
            }

            protected TreeNode AddStoredProcedureNode(
                StoredProcedureDesc spd,
                TreeNode parentNode)
            {
                TreeNode result = new TreeNode();
                result.Tag = spd;
                // build caption of stored procedure node
                if (spd.Params.Count > 0)
                {
                    StringBuilder sb = new StringBuilder(spd.Name + "(");
                    foreach (ReportParameterDesc rpd in spd.Params)
                    {
                        sb.Append(rpd.Type);
                        sb.Append(", ");
                    }
                    sb.Remove(sb.Length - 2, 2);
                    result.Text = sb.ToString() + ")";
                }
                else
                    result.Text = spd.Name;
                result.ImageIndex = c_StoredProcedureImageIndex;
                result.SelectedImageIndex = c_StoredProcedureImageIndex;
                if (string.IsNullOrEmpty(spd.SchemaName))
                {
                    parentNode.Nodes.Add(result);
                }
                else
                {
                    TreeNode nSchema = FindSchemaNode(parentNode.Nodes, spd.SchemaName);
                    if (nSchema == null)
                    {
                        nSchema = new TreeNode(spd.SchemaName, c_SchemaImageIndex, c_SchemaImageIndex);
                        parentNode.Nodes.Add(nSchema);
                    }
                    nSchema.Nodes.Add(result);
                }
                return result;
            }

            protected TreeNode FindSchemaNode(
                TreeNodeCollection nodes,
                string schemaName)
            {
                foreach (TreeNode n in nodes)
                    if (n.Text == schemaName)
                        return n;
                return null;
            }

            protected abstract bool UpdateControlsInt(DataSourcePicker dsp);
            #endregion

            #region Public
            public override bool UpdateControls(
                DataSourcePicker dsp,
                string recordSource)
            {
                // show _tpSql page if it hidden
                if (!dsp._tcConnection.TabPages.Contains(dsp._tpSql))
                    dsp._tcConnection.TabPages.Add(dsp._tpSql);
                string connectionString = dsp._cbConnectionString.Text;

                //
                try
                {
                    UpdateControlsInt(dsp);
                    if (!string.IsNullOrEmpty(recordSource))
                        dsp._tvDataSource.SelectedNode = FindNode(dsp._tvDataSource.Nodes, recordSource);
                    return true;
                }
                catch (Exception e)
                {
                    DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotGetTablesDbFmt, connectionString, e.Message));
                    return false;
                }
            }
            #endregion
        }

        private class DsgnOledbLink : DsgnDbLink
        {
            public readonly static DsgnOledbLink Instance = new DsgnOledbLink();

            #region Private
            private bool GetTablesAndViews(
                DataSourcePicker dsp,
                OleDbConnection connection)
            {
                DataTable dataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                try
                {
                    if (!dataTable.Columns.Contains("TABLE_TYPE") ||
                        !dataTable.Columns.Contains("TABLE_NAME"))
                    {
                        DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotGetTablesOleDbFmt, connection.ConnectionString));
                        return false;
                    }

                    //
                    TreeNode nTables = new TreeNode(c_Tables, c_TablesImageIndex, c_TablesImageIndex);
                    TreeNode nViews = new TreeNode(c_Views, c_ViewsImageIndex, c_ViewsImageIndex);
                    int schemaIndex = dataTable.Columns.IndexOf("TABLE_SCHEMA");
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        // check the table type
                        string type = dr["TABLE_TYPE"].ToString();
                        string name = dr["TABLE_NAME"].ToString();
                        string schema = string.Empty;
                        if (schemaIndex >= 0)
                            schema = dr[schemaIndex].ToString();
                        if (!IsDbObjectVisible(ObjectType.TableOrView, name, schema, type))
                            continue;

                        //
                        if (type == "VIEW")
                            AddTableViewNode(name, schema, c_ViewImageIndex, nViews);
                        else
                            AddTableViewNode(name, schema, c_TableImageIndex, nTables);
                    }
                    if (nTables.Nodes.Count > 0)
                        dsp._tvDataSource.Nodes.Add(nTables);
                    if (nViews.Nodes.Count > 0)
                        dsp._tvDataSource.Nodes.Add(nViews);
                    return true;
                }
                finally
                {
                    dataTable.Dispose();
                }
            }

            private bool GetStoredProcedures(
                DataSourcePicker dsp,
                OleDbConnection connection)
            {
                DataTable dataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Procedures, null);
                DataTable parameters = null;
                try
                {
                    if (!dataTable.Columns.Contains("PROCEDURE_NAME"))
                    {
                        DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotGetStoredProcsFmt, connection.ConnectionString));
                        return false;
                    }
                    // get table with procedures parameters not all data sources supports it
                    try
                    {
                        // Jet doesn't support this
                        if (connection.ConnectionString.IndexOf("Microsoft.Jet") < 0)
                            parameters = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Procedure_Parameters, null);
                    }
                    catch
                    {
                        parameters = null;
                    }


                    TreeNode nProcedures = new TreeNode(c_StoredProcedures, c_StoredProceduresImageIndex, c_StoredProceduresImageIndex);
                    int schemaIndex = dataTable.Columns.IndexOf("PROCEDURE_SCHEMA");
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        // get the procedure name, skip system stuff
                        string name = dr["PROCEDURE_NAME"].ToString();
                        string schema = string.Empty;
                        if (schemaIndex >= 0)
                            schema = dr[schemaIndex].ToString();
                        if (!IsDbObjectVisible(ObjectType.StoredProcedure, name, schema, string.Empty))
                            continue;

                        // truncate at ';'
                        int j = name.LastIndexOf(';');
                        string userName;
                        if (j > -1)
                            userName = name.Substring(0, j);
                        else
                            userName = name;

                        //
                        StoredProcedureDesc spd = new StoredProcedureDesc(userName, schema);

                        // get procedure parameters
                        if (parameters != null)
                        {
                            DataView dataView = parameters.DefaultView;
                            dataView.RowFilter = string.Format("PROCEDURE_NAME = '{0}' AND PARAMETER_NAME <> 'RETURN_VALUE' AND PARAMETER_NAME <> '@RETURN_VALUE'", name);
                            for (int i = 0; i < dataView.Count; i++)
                            {
                                DataRowView drv = dataView[i];
                                string pName = drv["PARAMETER_NAME"].ToString();
                                if (pName.StartsWith("@"))
                                    pName = pName.Substring(1); // eat @
                                string pType = drv["TYPE_NAME"].ToString().ToLower();
                                if (pType.IndexOf("date") >= 0)
                                {
                                    spd.Params.Add(new ReportParameterDesc(pName, Doc.ParameterType.DateTime));
                                }
                                else if (pType.IndexOf("char") >= 0 || pType.IndexOf("text") >= 0 || pType == "xml")
                                    spd.Params.Add(new ReportParameterDesc(pName, Doc.ParameterType.String));
                                else
                                    spd.Params.Add(new ReportParameterDesc(pName, Doc.ParameterType.Integer));
                            }
                        }

                        //
                        AddStoredProcedureNode(spd, nProcedures);
                    }
                    if (nProcedures.Nodes.Count > 0)
                        dsp._tvDataSource.Nodes.Add(nProcedures);


                    return true;
                }
                finally
                {
                    dataTable.Dispose();
                }
            }
            #endregion

            #region Protected
            protected override bool UpdateControlsInt(
                DataSourcePicker dsp)
            {
                OleDbConnection connection = null;
                try
                {
                    //
                    DataLinkParams dlp = new DataLinkParams()
                    {
                        ConnectionString = dsp._cbConnectionString.Text,
                        Report = dsp.DataSource != null ? dsp.DataSource.ParentReport : null,
                    };
                    connection = (OleDbConnection)OledbLink.Instance.CreateConnection(dlp);
                    connection.Open();

                    dsp._tvDataSource.BeginUpdate();
                    try
                    {
                        // add to _tvDataSource tables and views
                        GetTablesAndViews(dsp, connection);

                        // add to _tvDataSource stored procedures
                        GetStoredProcedures(dsp, connection);
                    }
                    finally
                    {
                        dsp._tvDataSource.EndUpdate();
                    }

                    //
                    return true;
                }
                finally
                {
                    if (connection != null)
                        connection.Dispose();
                }
            }
            #endregion

            #region Public
            public override bool EditConnection(
                DataSourcePicker dsp,
                ref string connectionString)
            {
                MSDASC.DataLinksClass dlc = new MSDASC.DataLinksClass();
                if (dlc == null)
                {
                    // AppUtils.ShowWarning(Strings.DataSourcePicker.WarnFailedToCreateDataLinks);
                    MessageForm.Warn(Strings.DataSourcePicker.WarnFailedToCreateDataLinks);
                    return false;
                }
                dlc.hWnd = (int)dsp.Handle; // << make it modal
                bool result;
                if (string.IsNullOrEmpty(connectionString))
                {
                    ADODB.Connection connection = (ADODB.Connection)dlc.PromptNew();
                    result = connection != null;
                    if (result)
                        connectionString = connection.ConnectionString;
                }
                else
                {
                    object connection = new ADODB.Connection();
                    ((ADODB.Connection)connection).ConnectionString = connectionString;
                    result = dlc.PromptEdit(ref connection);
                    if (result)
                        connectionString = ((ADODB.Connection)connection).ConnectionString;
                }
                return result;
            }
            #endregion

            #region Public properties
            public override DataLinkBase Link
            {
                get { return OledbLink.Instance; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.OleDbCaption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.OleDbShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.OLEDB; }
            }
            #endregion
        }

        private abstract class DsgnSqlServerCeLink : DsgnDbLink
        {
            #region Private
            private bool GetTables(
                DataSourcePicker dsp,
                DbConnection connection)
            {
                // from here:
                // http://social.msdn.microsoft.com/Forums/eu/adodotnetdataproviders/thread/89c25dfb-5f1d-48d6-b2c2-82044733a822
                // GetSchema has been implemented in SQL Server Compact 4.0,
                // for earlier versions you must use other methods to obtain schema information.
                DbCommand command = null;
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES";
                    command.Transaction = connection.BeginTransaction();

                    using (DbDataReader ddr = command.ExecuteReader())
                    {
                        //
                        TreeNode nTables = new TreeNode(c_Tables, c_TablesImageIndex, c_TablesImageIndex);
                        while (ddr.Read())
                        {
                            // check the table type
                            string type = ddr["TABLE_TYPE"].ToString().ToUpper();
                            string name = ddr["TABLE_NAME"].ToString();
                            string schema = ddr["TABLE_SCHEMA"].ToString();
                            if (!IsDbObjectVisible(ObjectType.TableOrView, name, schema, type))
                                continue;

                            //
                            AddTableViewNode(name, schema, c_TableImageIndex, nTables);
                        }
                        if (nTables.Nodes.Count > 0)
                            dsp._tvDataSource.Nodes.Add(nTables);
                    }

                    return true;
                }
                finally
                {
                    if (command != null)
                        command.Transaction.Dispose();
                    command.Dispose();
                }
            }
            #endregion

            #region Protected
            protected override bool UpdateControlsInt(
                DataSourcePicker dsp)
            {
                DbConnection connection = null;
                try
                {
                    //
                    DataLinkParams dlp = new DataLinkParams()
                    {
                        ConnectionString = dsp._cbConnectionString.Text,
                        Report = dsp.DataSource != null ? dsp.DataSource.ParentReport : null,
                    };
                    connection = ((DbLink)Link).CreateConnection(dlp);
                    connection.Open();

                    dsp._tvDataSource.BeginUpdate();
                    try
                    {
                        // SqlServerCe provides only list of tables
                        GetTables(dsp, connection);
                    }
                    finally
                    {
                        dsp._tvDataSource.EndUpdate();
                    }

                    //
                    return true;
                }
                finally
                {
                    if (connection != null)
                        connection.Dispose();
                }
            }
            #endregion

            #region Public
            public override bool EditConnection(
                DataSourcePicker dsp,
                ref string connectionString)
            {
                using (SqlServerCeConnectionStringEditorForm f = new SqlServerCeConnectionStringEditorForm())
                    return f.Edit(ref connectionString);
            }
            #endregion
        }

        private class DsgnSqlServerCe3_5Link : DsgnSqlServerCeLink
        {
            public readonly static DsgnSqlServerCe3_5Link Instance = new DsgnSqlServerCe3_5Link();

            #region Public properties
            public override DataLinkBase Link
            {
                get { return SqlServerCe3_5Link.Instance; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.SqlServerCe3_5Caption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.SqlServerCe3_5ShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.SqlServerCe3_5; }
            }
            #endregion
        }

        private class DsgnSqlServerCe4_0Link : DsgnSqlServerCeLink
        {
            public readonly static DsgnSqlServerCe4_0Link Instance = new DsgnSqlServerCe4_0Link();

            #region Public properties
            public override DataLinkBase Link
            {
                get { return SqlServerCe4_0Link.Instance; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.SqlServerCe4_0Caption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.SqlServerCe4_0ShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.SqlServerCe4_0; }
            }
            #endregion
        }

        private class DsgnSQLiteLink : DsgnDbLink
        {
            public readonly static DsgnSQLiteLink Instance = new DsgnSQLiteLink();

            #region Private
            private bool GetObjects(
                DataSourcePicker dsp,
                DbConnection connection)
            {
                DbCommand command = null;
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM sqlite_master where type in ('table', 'view')";
                    command.Transaction = connection.BeginTransaction();

                    using (DbDataReader ddr = command.ExecuteReader())
                    {
                        //
                        TreeNode nViews = new TreeNode(c_Views, c_ViewImageIndex, c_ViewImageIndex);
                        TreeNode nTables = new TreeNode(c_Tables, c_TablesImageIndex, c_TablesImageIndex);
                        while (ddr.Read())
                        {
                            // check the table type
                            string type = ddr["TYPE"].ToString().ToLower();
                            string name = ddr["NAME"].ToString();
                            if (!IsDbObjectVisible(ObjectType.TableOrView, name, null, type))
                                continue;

                            //
                            if (type == "table")
                                AddTableViewNode(name, null, c_TableImageIndex, nTables);
                            else
                                AddTableViewNode(name, null, c_ViewImageIndex, nViews);
                        }
                        if (nTables.Nodes.Count > 0)
                            dsp._tvDataSource.Nodes.Add(nTables);
                        if (nViews.Nodes.Count > 0)
                            dsp._tvDataSource.Nodes.Add(nViews);
                    }

                    return true;
                }
                finally
                {
                    if (command != null && command.Transaction != null)
                        command.Transaction.Dispose();
                    command.Dispose();
                }
            }
            #endregion

            #region Protected
            protected override bool UpdateControlsInt(
                DataSourcePicker dsp)
            {
                DbConnection connection = null;
                try
                {
                    //
                    DataLinkParams dlp = new DataLinkParams()
                    {
                        ConnectionString = dsp._cbConnectionString.Text,
                        Report = dsp.DataSource != null ? dsp.DataSource.ParentReport : null,
                    };
                    connection = ((DbLink)Link).CreateConnection(dlp);
                    connection.Open();

                    dsp._tvDataSource.BeginUpdate();
                    try
                    {
                        GetObjects(dsp, connection);
                    }
                    finally
                    {
                        dsp._tvDataSource.EndUpdate();
                    }

                    //
                    return true;
                }
                finally
                {
                    if (connection != null)
                        connection.Dispose();
                }
            }
            #endregion

            #region Public
            public override bool EditConnection(
                DataSourcePicker dsp,
                ref string connectionString)
            {
                using (SQLiteConnectionStringEditorForm f = new SQLiteConnectionStringEditorForm())
                    return f.Edit(ref connectionString);
            }
            #endregion

            #region Public properties
            public override DataLinkBase Link
            {
                get { return SQLiteLink.Instance; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.SQLiteCaption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.SQLiteShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.SQLite; }
            }
            #endregion
        }

        private class DsgnOdbcLink : DsgnDbLink
        {
            public readonly static DsgnOdbcLink Instance = new DsgnOdbcLink();

            #region Private
            /*private TreeNode AddTableViewNode(
                string name,
                string schema,
                int imageIndex,
                TreeNode parentNode)
            {
                //
                DataTableDesc dtd = new DataTableDesc(name, schema);

                //
                TreeNode result = new TreeNode(name);
                result.Tag = dtd;
                result.ImageIndex = imageIndex;
                result.SelectedImageIndex = imageIndex;
                if (string.IsNullOrEmpty(schema))
                {
                    parentNode.Nodes.Add(result);
                }
                else
                {
                    TreeNode nSchema = FindSchemaNode(parentNode.Nodes, schema);
                    if (nSchema == null)
                    {
                        nSchema = new TreeNode(schema, c_SchemaImageIndex, c_SchemaImageIndex);
                        parentNode.Nodes.Add(nSchema);
                    }
                    nSchema.Nodes.Add(result);
                }

                //
                return result;
            }*/

            private bool GetTables(
                DataSourcePicker dsp,
                OdbcConnection connection)
            {
                DataTable dataTable = connection.GetSchema(OdbcMetaDataCollectionNames.Tables);
                try
                {
                    if (!dataTable.Columns.Contains("TABLE_TYPE") ||
                        !dataTable.Columns.Contains("TABLE_NAME"))
                    {
                        DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotGetTablesOdbcFmt, connection.ConnectionString));
                        return false;
                    }

                    //
                    TreeNode nTables = new TreeNode(c_Tables, c_TablesImageIndex, c_TablesImageIndex);
                    int schemaIndex = dataTable.Columns.IndexOf("TABLE_SCHEM");
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        // check the table type
                        string type = dr["TABLE_TYPE"].ToString().ToUpper();
                        string name = dr["TABLE_NAME"].ToString();
                        string schema = string.Empty;
                        if (schemaIndex >= 0)
                            schema = dr[schemaIndex].ToString();
                        if (!IsDbObjectVisible(ObjectType.TableOrView, name, schema, type))
                            continue;

                        //
                        AddTableViewNode(name, schema, c_TableImageIndex, nTables);
                    }
                    if (nTables.Nodes.Count > 0)
                        dsp._tvDataSource.Nodes.Add(nTables);

                    return true;
                }
                finally
                {
                    dataTable.Dispose();
                }
            }

            private bool GetViews(
                DataSourcePicker dsp,
                OdbcConnection connection)
            {
                DataTable dataTable = connection.GetSchema(OdbcMetaDataCollectionNames.Views);
                try
                {
                    if (!dataTable.Columns.Contains("TABLE_TYPE") ||
                        !dataTable.Columns.Contains("TABLE_NAME"))
                    {
                        DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotGetViewsOdbcFmt, connection.ConnectionString));
                        return false;
                    }

                    //
                    TreeNode nViews = new TreeNode(c_Views, c_ViewsImageIndex, c_ViewsImageIndex);
                    int schemaIndex = dataTable.Columns.IndexOf("TABLE_SCHEM");
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        // check the table type
                        string type = dr["TABLE_TYPE"].ToString().ToUpper();
                        string name = dr["TABLE_NAME"].ToString();
                        string schema = string.Empty;
                        if (schemaIndex >= 0)
                            schema = dr[schemaIndex].ToString();
                        if (!IsDbObjectVisible(ObjectType.TableOrView, name, schema, type))
                            continue;

                        //
                        AddTableViewNode(name, schema, c_ViewImageIndex, nViews);
                    }
                    if (nViews.Nodes.Count > 0)
                        dsp._tvDataSource.Nodes.Add(nViews);

                    return true;
                }
                finally
                {
                    dataTable.Dispose();
                }
            }

            private bool GetStoredProcedures(
                DataSourcePicker dsp,
                OdbcConnection connection)
            {
                DataTable dataTable = null;
                try
                {
                    dataTable = connection.GetSchema(OdbcMetaDataCollectionNames.Procedures, null);
                }
                catch
                {
                    // simple eat an exception, not all data sources supports it
                    return true;
                }
                DataTable parameters = null;
                try
                {
                    if (!dataTable.Columns.Contains("PROCEDURE_NAME"))
                    {
                        DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotGetStoredProcsOdbcFmt, connection.ConnectionString));
                        return false;
                    }
                    // get table with procedures parameters not all data sources supports it
                    try
                    {
                        parameters = connection.GetSchema(OdbcMetaDataCollectionNames.ProcedureParameters, null);
                    }
                    catch
                    {
                        parameters = null;
                    }

                    TreeNode nProcedures = new TreeNode(c_StoredProcedures, c_StoredProceduresImageIndex, c_StoredProceduresImageIndex);
                    int schemaIndex = dataTable.Columns.IndexOf("PROCEDURE_SCHEM");
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        string name = dr["PROCEDURE_NAME"].ToString();
                        string schema = string.Empty;
                        if (schemaIndex >= 0)
                            schema = dr[schemaIndex].ToString();
                        if (!IsDbObjectVisible(ObjectType.StoredProcedure, name, schema, string.Empty))
                            continue;

                        // truncate at ';'
                        int j = name.LastIndexOf(';');
                        string userName;
                        if (j > -1)
                            userName = name.Substring(0, j);
                        else
                            userName = name;

                        //
                        StoredProcedureDesc spd = new StoredProcedureDesc(userName, schema);

                        // set filter to parameters
                        if (parameters != null)
                        {
                            DataView dataView = parameters.DefaultView;
                            dataView.RowFilter = string.Format("PROCEDURE_NAME = '{0}'", name);
                            for (int i = 0; i < dataView.Count; i++)
                            {
                                DataRowView drv = dataView[i];
                                string pName = drv["COLUMN_NAME"].ToString();
                                if (pName.StartsWith("@"))
                                    pName = pName.Substring(1); // eat @
                                string pType = drv["TYPE_NAME"].ToString().ToLower();
                                if (pType.IndexOf("date") >= 0)
                                {
                                    spd.Params.Add(new ReportParameterDesc(pName, Doc.ParameterType.DateTime));
                                }
                                else if (pType.IndexOf("char") >= 0 || pType.IndexOf("text") >= 0 || pType == "xml")
                                    spd.Params.Add(new ReportParameterDesc(pName, Doc.ParameterType.String));
                                else
                                    spd.Params.Add(new ReportParameterDesc(pName, Doc.ParameterType.Integer));
                            }
                        }

                        //
                        AddStoredProcedureNode(spd, nProcedures);
                    }
                    if (nProcedures.Nodes.Count > 0)
                        dsp._tvDataSource.Nodes.Add(nProcedures);


                    return true;
                }
                finally
                {
                    dataTable.Dispose();
                }
            }
            #endregion

            #region Protected
            protected override bool UpdateControlsInt(
                DataSourcePicker dsp)
            {
                OdbcConnection connection = null;
                try
                {
                    //
                    DataLinkParams dlp = new DataLinkParams()
                    {
                        ConnectionString = dsp._cbConnectionString.Text,
                        Report = dsp.DataSource != null ? dsp.DataSource.ParentReport : null,
                    };
                    connection = (OdbcConnection)OdbcLink.Instance.CreateConnection(dlp);
                    connection.Open();

                    dsp._tvDataSource.BeginUpdate();
                    try
                    {
                        // add to _tvDataSource tables and views
                        GetTables(dsp, connection);
                        GetViews(dsp, connection);

                        // add to _tvDataSource stored procedures
                        GetStoredProcedures(dsp, connection);
                    }
                    finally
                    {
                        dsp._tvDataSource.EndUpdate();
                    }

                    //
                    return true;
                }
                finally
                {
                    if (connection != null)
                        connection.Dispose();
                }
            }
            #endregion

            #region Public
            public override bool EditConnection(
                DataSourcePicker dsp,
                ref string connectionString)
            {
                IntPtr henv = IntPtr.Zero;
                IntPtr hdbc = IntPtr.Zero;
                short result = 0;
                try
                {
                    result = Win32.SQLAllocEnv(out henv);
                    if (!Win32.SQL_SUCCEEDED(result))
                        throw new ApplicationException("OdbcConnectionUIControl_SQLAllocConnectFailed");

                    result = Win32.SQLAllocConnect(henv, out hdbc);
                    if (!Win32.SQL_SUCCEEDED(result))
                        throw new ApplicationException("OdbcConnectionUIControl_SQLAllocConnectFailed");

                    string currentConnectionString = connectionString;
                    StringBuilder newConnectionString = new StringBuilder(1024);
                    short newConnectionStringLength = 0;
                    result = Win32.SQLDriverConnect(hdbc, dsp.Handle, currentConnectionString, (short)currentConnectionString.Length, newConnectionString, 1024, out newConnectionStringLength, Win32.SQL_DRIVER_PROMPT);
                    if (!Win32.SQL_SUCCEEDED(result) && result != Win32.SQL_NO_DATA)
                    {
                        // Try again without the current connection string, in case it was invalid
                        result = Win32.SQLDriverConnect(hdbc, dsp.Handle, null, 0, newConnectionString, 1024, out newConnectionStringLength, Win32.SQL_DRIVER_PROMPT);
                    }
                    if (!Win32.SQL_SUCCEEDED(result) && result != Win32.SQL_NO_DATA)
                        throw new ApplicationException("OdbcConnectionUIControl_SQLDriverConnectFailed");

                    Win32.SQLDisconnect(hdbc);

                    if (newConnectionStringLength > 0)
                    {
                        connectionString = newConnectionString.ToString();
                        return true;
                    }
                    return false;
                }
                finally
                {
                    if (hdbc != IntPtr.Zero)
                        Win32.SQLFreeConnect(hdbc);
                    if (henv != IntPtr.Zero)
                        Win32.SQLFreeEnv(henv);
                }
            }
            #endregion

            #region Public properties
            public override DataLinkBase Link
            {
                get { return OdbcLink.Instance; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.OdbcCaption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.OdbcShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.ODBC; }
            }
            #endregion
        }

        private class DsgnXmlLink : DsgnDataLinkBase
        {
            public readonly static DsgnXmlLink Instance = new DsgnXmlLink();

            #region Public
            public override bool EditConnection(
                DataSourcePicker dsp,
                ref string connectionString)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.DereferenceLinks = true;
                    dlg.DefaultExt = "xsd";
                    dlg.Title = Strings.DataSourcePicker.XmlDialogTitle;
                    dlg.Filter = Strings.DataSourcePicker.XmlDialogFilter;
                    if (File.Exists(connectionString))
                        dlg.FileName = connectionString;
                    if (dlg.ShowDialog() != DialogResult.OK)
                        return false;

                    connectionString = dlg.FileName;
                    return true;
                }
            }

            public override bool UpdateControls(
                DataSourcePicker dsp,
                string recordSource)
            {
                dsp._tcConnection.SelectedTab = dsp._tpDataSource;
                dsp._tcConnection.TabPages.Remove(dsp._tpSql);

                try
                {
                    ResourceNameParser rnp = ResourceNameParser.Open(dsp._cbConnectionString.Text, C1FlexReport.GetActualBasePath(dsp.DataSource != null ? dsp.DataSource.ParentReport : null));
                    if (rnp == null)
                    {
                        DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.XmlFileNotFoundFmt, dsp._cbConnectionString.Text));
                        return false;
                    }
                    using (rnp)
                    {
                        DataSet dataSet = DbUtils.ReadXmlSchema(rnp.Stream);
                        if (dataSet.Tables.Count <= 0)
                        {
                            DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.NoTablesInXmlFileFmt, dsp._cbConnectionString.Text));
                            return false;
                        }
                        TreeNode nTables = new TreeNode(c_Tables, DataSourcePicker.c_TablesImageIndex, DataSourcePicker.c_TablesImageIndex);
                        dsp._tvDataSource.Nodes.Add(nTables);
                        foreach (DataTable dt in dataSet.Tables)
                        {
                            TreeNode n = new TreeNode(dt.TableName, DataSourcePicker.c_TableImageIndex, DataSourcePicker.c_TableImageIndex);
                            n.Tag = new DataTableDesc(dt.TableName, string.Empty);
                            nTables.Nodes.Add(n);
                        }
                        dsp._tvDataSource.SelectedNode = AppUtils.FindNodeByText(dsp._tvDataSource.Nodes, recordSource, false);
                        return true;
                    }
                }
                catch (Exception e)
                {
                    DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrLoadingDatasetFromXmlFmt, dsp._cbConnectionString.Text, e.Message));
                    return false;
                }
            }

            public override void Parse(
                string connectionString,
                out string caption,
                out string details)
            {
                caption = ShortCaption;
                details = connectionString;
            }
            #endregion

            #region Public properties
            public override DataLinkBase Link
            {
                get { return XmlLink.Instance; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.XmlCaption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.XmlShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.XmlFile; }
            }
            #endregion
        }

        private class DsgnExternalObjectLink : DsgnDataLinkBase
        {
            public readonly static DsgnExternalObjectLink Instance = new DsgnExternalObjectLink();

            #region Public
            #endregion

            #region Private static
            private static IC1FlexReportExternalRecordset[] GetRecordsets(
                Assembly assembly)
            {
                Type[] types;
                try
                {
                    types = assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    types = ex.Types;
                }
                catch (Exception)
                {
                    throw;
                }

                List<IC1FlexReportExternalRecordset> result = new List<IC1FlexReportExternalRecordset>();
                foreach (Type t in types)
                {
                    if (t == null)
                        continue;
                    if (t.IsAbstract)
                        continue;
                    Type it = t.GetInterface("IC1FlexReportExternalRecordset");
                    if (it == null)
                        continue;
                    ConstructorInfo ci = t.GetConstructor(
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                        null,
                        new Type[0],
                        null);
                    if (ci == null)
                        continue;
                    IC1FlexReportExternalRecordset r = ci.Invoke(null) as IC1FlexReportExternalRecordset;
                    if (r == null)
                        continue;
                    result.Add(r);
                }
                return result.ToArray();
            }
            #endregion

            #region Public
            public override bool EditConnection(
                DataSourcePicker dsp,
                ref string connectionString)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.DereferenceLinks = true;
                    dlg.DefaultExt = "dll";
                    dlg.Title = Strings.DataSourcePicker.ExternalDialogTitle;
                    dlg.Filter = Strings.DataSourcePicker.ExternalDialogFilter;
                    if (File.Exists(connectionString))
                        dlg.FileName = connectionString;
                    if (dlg.ShowDialog() != DialogResult.OK)
                        return false;

                    connectionString = dlg.FileName;
                    return true;
                }
            }

            public override bool UpdateControls(
                DataSourcePicker dsp,
                string recordSource)
            {
                dsp._tcConnection.SelectedTab = dsp._tpDataSource;
                dsp._tcConnection.TabPages.Remove(dsp._tpSql);
                string fileName = dsp._cbConnectionString.Text;
                Assembly assembly = ExternalObjectLink.GetExternalAssembly(fileName, dsp.DataSource != null ? dsp.DataSource.ParentReport : null);
                if (assembly == null)
                {
                    DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotLoadAsmbFmt, fileName));
                    return false;
                }

                try
                {
                    IC1FlexReportExternalRecordset[] recordsets = GetRecordsets(assembly);
                    if (recordsets == null || recordsets.Length <= 0)
                    {
                        DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrNoDataInAsmbFmt, fileName));
                        return false;
                    }
                    TreeNode nExternalRecordsets = new TreeNode(c_Recordsets, c_RecordsetsImageIndex, c_RecordsetsImageIndex);
                    dsp._tvDataSource.Nodes.Add(nExternalRecordsets);
                    int i = recordSource.IndexOf(';');
                    string typeName = i < 0 ? string.Empty : recordSource.Substring(0, i);
                    foreach (IC1FlexReportExternalRecordset rer in recordsets)
                    {
                        TreeNode n = new TreeNode(rer.Caption, c_RecordsetImageIndex, c_RecordsetImageIndex);
                        n.Tag = new ExternalRecordsetDesc(rer, string.Empty);
                        nExternalRecordsets.Nodes.Add(n);
                        if (rer.GetType().FullName == typeName)
                        {
                            ((ExternalRecordsetDesc)n.Tag).Parameters = recordSource.Substring(i + 1);
                            dsp._tvDataSource.SelectedNode = n;
                        }
                    }

                    // done
                    return true;
                }
                catch (Exception e)
                {
                    DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotLoadDataFromAsmbFmt, fileName, e.Message));
                    return false;
                }
            }

            public override void Parse(
                string connectionString,
                out string caption,
                out string details)
            {
                caption = ShortCaption;
                details = connectionString;
            }
            #endregion

            #region Public properties
            public override DataLinkBase Link
            {
                get { return ExternalObjectLink.Instance; }
            }

            public override string Caption
            {
                get { return Strings.DataSourcePicker.ExternalCaption; }
            }

            public override string ShortCaption
            {
                get { return Strings.DataSourcePicker.ExternalShortCaption; }
            }

            public override DataProvider DataProvider
            {
                get { return DataProvider.ExternalObject; }
            }
            #endregion
        }

        private static class Win32
        {
            #region ODBC constants
            // ODBC Driver prompt options
            internal const ushort
                SQL_DRIVER_PROMPT = 2;

            // ODBC return values
            internal const short
                SQL_NO_DATA = 100;
            #endregion

            #region ODBC functions
            internal static bool SQL_SUCCEEDED(
                short rc)
            {
                return (((rc) & (~1)) == 0);
            }

            [DllImport("odbc32.dll")]
            internal static extern short SQLAllocEnv(
                out IntPtr EnvironmentHandle);

            [DllImport("odbc32.dll")]
            internal static extern short SQLAllocConnect(
                IntPtr EnvironmentHandle,
                out IntPtr ConnectionHandle);

            [DllImport("odbc32.dll", EntryPoint = "SQLDriverConnectW", CharSet = CharSet.Unicode)]
            internal static extern short SQLDriverConnect(
                IntPtr hdbc,
                IntPtr hwnd,
                string szConnStrIn,
                short cbConnStrIn,
                System.Text.StringBuilder szConnStrOut,
                short cbConnStrOutMax,
                out short pcbConnStrOut,
                ushort fDriverCompletion);

            [DllImport("odbc32.dll")]
            internal static extern short SQLDisconnect(
                IntPtr ConnectionHandle);

            [DllImport("odbc32.dll")]
            internal static extern short SQLFreeConnect(
                IntPtr ConnectionHandle);

            [DllImport("odbc32.dll")]
            internal static extern short SQLFreeEnv(
                IntPtr EnvironmentHandle);

            [DllImport("odbccp32.dll", CharSet = CharSet.Unicode)]
            internal static extern bool SQLGetInstalledDrivers(
                char[] lpszBuf,
                int cbBufMax,
                ref int pcbBufOut);

            [DllImport("odbccp32.dll", CharSet = CharSet.Unicode)]
            internal static extern int SQLGetPrivateProfileString(
                string lpszSection,
                string lpszEntry,
                string lpszDefault,
                StringBuilder RetBuffer,
                int cbRetBuffer,
                string lpszFilename);
            #endregion
        }
        #endregion
    }
}
