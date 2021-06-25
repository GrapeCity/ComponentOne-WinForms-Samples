//----------------------------------------------------------------------------
// DataSourcePicker.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
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
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Util
{
    public partial class DataSourcePicker : UserControl
    {
        private const int c_MaxMRUSize = 10;
        private const int c_TablesImageIndex = 0;
        private const int c_TableImageIndex = 1;
        private const int c_RecordsetsImageIndex = 0;
        private const int c_RecordsetImageIndex = 4;
        private const int c_ViewsImageIndex = 0;
        private const int c_ViewImageIndex = 2;
        private const int c_SchemaImageIndex = 0;
        private const int c_StoredProceduresImageIndex = 0;
        private const int c_StoredProcedureImageIndex = 3;
        private const int c_ConnectionDrawLeftOffset = 5;
        private const int c_ConnectionDrawSpacing = 10;
        private static readonly string c_Tables = Strings.DataSourcePicker.Tables;
        private static readonly string c_Views = Strings.DataSourcePicker.Views;
        private static readonly string c_StoredProcedures = Strings.DataSourcePicker.StoredProcedures;
        private static readonly string c_Recordsets = Strings.DataSourcePicker.Recordsets;

        private static StringFormat s_CaptionStringFormat;
        private static StringFormat s_DetailsStringFormat;

        private int _updateCounter;
        private FlexDesignerHostServices _services = null;
        private Hashtable _dataSchema;
        private DataSource _dataSource;
        private IsolationLevel _isolationLevel;
        private string _oldConnectionString;
        private TabPage _lastSelectedDataTab = null;

        static DataSourcePicker()
        {
            s_CaptionStringFormat = new StringFormat(StringFormat.GenericTypographic);
            s_CaptionStringFormat.Alignment = StringAlignment.Near;
            s_CaptionStringFormat.LineAlignment = StringAlignment.Center;
            s_DetailsStringFormat = new StringFormat(StringFormat.GenericTypographic);
            s_DetailsStringFormat.Alignment = StringAlignment.Near;
            s_DetailsStringFormat.LineAlignment = StringAlignment.Center;
            s_DetailsStringFormat.Trimming = StringTrimming.EllipsisPath;
        }

        public DataSourcePicker()
        {
            InitializeComponent();
            try
            {
                _tbSql.Font = MainForm.TheMainForm._scriptEditorFont;
            }
            catch { }

            var tooltip = MainForm.TheMainForm as ITooltipService;
            if (tooltip != null)
            {
                tooltip.SetToolTip(this._btnEditConnection, Strings.DataSourcePicker.TtipBtnEditConnection);
                tooltip.SetToolTip(this._btnDataSourceProperties, Strings.DataSourcePicker.TtipBtnDataSourceProperties);
            }

            // Fill _cbDataProvider
            foreach (DsgnDataLinkBase dl in DsgnDataLinkBase.Links)
                _cbDataProvider.Items.Add(new DataProviderDesc(dl));

            // Fill _cbConnectionString
            ArrayList connections = AppSettings.LoadList("recentconnections", MessageForm.Warn);
            foreach (string s in connections)
                _cbConnectionString.Items.Add(ConnectionDesc.FromSettingsString(s));

            _lastSelectedDataTab = _tpConnection;
        }

        #region Privates
        private bool Updating
        {
            get { return _updateCounter > 0; }
        }

        /// <summary>
        /// Last selected of the "Connection" and "DataObjects" tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_tcMain.SelectedTab == _tpDataObjects)
                _lastSelectedDataTab = _tpDataObjects;
            else
                _lastSelectedDataTab = _tpConnection;
        }

        private void BeginUpdate()
        {
            _updateCounter++;
        }

        private void EndUpdate()
        {
            _updateCounter--;
        }

        // searches TreeNode in _tvDataObjects linked with DataSet in
        // specified _dataSchema, returns null if not found
        private TreeNode FindDataSetObject(
            string s)
        {
            foreach (TreeNode n in _tvDataObjects.Nodes)
                if (n.Tag is DataSet && string.Compare(n.Text, s, true) == 0)
                    return n;
            return null;
        }

        // searches TreeNode in _tvDataObjects linked with DataTable in
        // specified _dataSchema, returns null if not found
        private TreeNode FindDataTableObject(
            TreeNodeCollection nodes,
            string s)
        {
            foreach (TreeNode n in nodes)
            {
                if (n.Tag is DataTable && string.Compare(n.Text, s, true) == 0)
                    return n;
                TreeNode result = FindDataTableObject(n.Nodes, s);
                if (result != null)
                    return result;
            }
            return null;
        }

        private int IndexOfConnectionDesc(
            DsgnDataLinkBase dataLink,
            string connectionString)
        {
            for (int i = 0; i < _cbConnectionString.Items.Count; i++)
            {
                ConnectionDesc cd = (ConnectionDesc)_cbConnectionString.Items[i];
                if (cd.Link == dataLink && cd.ConnectionString == connectionString)
                    return i;
            }
            return -1;
        }

        // updates state of buttons linked with other controls
        private void UpdateButtons()
        {
            DataProviderDesc dpd = _cbDataProvider.SelectedItem as DataProviderDesc;
            _btnEditConnection.Enabled = dpd != null && dpd.Link.Available;
            _btnDataSourceProperties.Enabled = _tvDataSource.SelectedNode != null && _tvDataSource.SelectedNode.Tag is ExternalRecordsetDesc;
            _btnQueryBuilder.Enabled = dpd != null && dpd.Link == DsgnOledbLink.Instance;
        }

        // Updates list of available datasources (tables, views, stored procs)
        // for connection string specified by _cbDataProvider, _cbConnectionString
        // selects specified recordSource if possible
        private void ConnectionStringChanged(
            string recordSource)
        {
            // store current value of connection string to prevent update when
            // _cbConnectionString lost focus
            _oldConnectionString = _cbConnectionString.Text;

            BeginUpdate();
            Cursor = Cursors.WaitCursor;
            try
            {
                DsgnDataLinkBase dl = ((DataProviderDesc)_cbDataProvider.SelectedItem).Link;
                _tvDataSource.Nodes.Clear();
                if (!string.IsNullOrEmpty(_cbConnectionString.Text) && dl.Available)
                {
                    if (dl.UpdateControls(this, recordSource))
                    {
                        // current connection string should be stored in MRU list
                        int i = IndexOfConnectionDesc(dl, _cbConnectionString.Text);
                        if (i >= 0)
                        {
                            ConnectionDesc ci = (ConnectionDesc)_cbConnectionString.Items[i];
                            _cbConnectionString.Items.Remove(ci);
                            _cbConnectionString.Items.Insert(0, ci);
                            _cbConnectionString.SelectedIndex = 0;
                        }
                        else
                        {
                            if (_cbConnectionString.Items.Count > c_MaxMRUSize)
                                _cbConnectionString.Items.RemoveAt(_cbConnectionString.Items.Count - 1);
                            _cbConnectionString.Items.Add(new ConnectionDesc(dl, _cbConnectionString.Text));
                        }
                        // save MRU connections to application's settings
                        // SaveList uses ToString() method of objects in list so we can
                        // simple pass _cbConnectionString.Items items will be automatically converted to string like:
                        // OLEDB;Data source=...
                        List<string> l = new List<string>();
                        foreach (ConnectionDesc cd in _cbConnectionString.Items)
                            l.Add(cd.ToSettingsString());
                        AppSettings.SaveList("recentconnections", l, true, MessageForm.Warn);
                    }
                }
                UpdateButtons();
            }
            finally
            {
                Cursor = Cursors.Default;
                EndUpdate();
            }
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IsolationLevel IsolationLevel
        {
            get { return _isolationLevel; }
            set { _isolationLevel = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool WordWrap
        {
            get { return _cbWordWrap.Checked; }
            set { _cbWordWrap.Checked = value; }
        }

        public FlexDesignerHostServices DesignerHostServices
        {
            get { return _services; }
            set { _services = value; }
        }

        public DataSource DataSource
        {
            get { return _dataSource; }
            set
            {
                if (_dataSource != null && _dataSource.ParentReport != null)
                    _dataSource.ParentReport.ReportDefinitionChanged -= ParentReport_ReportDefinitionChanged;

                _dataSource = value;
                _lvCalculatedFields.Clear();
                if (_dataSource == null)
                {
                    _tcMain.TabPages.Remove(_tpCalculatedFields);
                }
                else
                {
                    if (!_tcMain.TabPages.Contains(_tpCalculatedFields))
                        _tcMain.TabPages.Add(_tpCalculatedFields);

                    var calcFields = _dataSource.CalculatedFields;
                    foreach (var cf in calcFields)
                        _lvCalculatedFields.Items.Add(new CalcFieldItem(cf));

                    if (_dataSource.ParentReport != null)
                        _dataSource.ParentReport.ReportDefinitionChanged += ParentReport_ReportDefinitionChanged;
                }
                _lvCalculatedFields_SelectedIndexChanged(_lvCalculatedFields, EventArgs.Empty);
            }
        }

        private void ParentReport_ReportDefinitionChanged(object sender, EventArgs e)
        {
            foreach (CalcFieldItem cfi in _lvCalculatedFields.Items)
            {
                if (cfi.Text != cfi.Field.Name)
                    cfi.Text = cfi.Field.Name;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Hashtable DataSchema
        {
            get { return _dataSchema; }
            set
            {
                _dataSchema = value;
                _tvDataObjects.Nodes.Clear();
                BeginUpdate();
                if (_dataSchema == null)
                {
                    // we should hide _tpDataObjects if DataSchema is empty
                    _tcMain.TabPages.Remove(_tpDataObjects);
                }
                else
                {
                    if (!_tcMain.TabPages.Contains(_tpDataObjects))
                        _tcMain.TabPages.Add(_tpDataObjects);
                    foreach (DataSet ds in _dataSchema.Values)
                    {
                        TreeNode ndDataSet = new TreeNode(ds.DataSetName, 4, 4);
                        ndDataSet.Tag = ds;
                        _tvDataObjects.Nodes.Add(ndDataSet);
                        foreach (DataTable dt in ds.Tables)
                        {
                            TreeNode ndTable = new TreeNode(dt.TableName, -1, -1);
                            ndTable.Tag = dt;
                            ndDataSet.Nodes.Add(ndTable);
                        }
                    }
                }
                EndUpdate();
                // Keep track of last selected data tab (removing a tab page does not fire the event):
                _tcMain_SelectedIndexChanged(_tcMain, EventArgs.Empty);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataProvider DataProvider
        {
            get
            {
                if (_lastSelectedDataTab != _tpConnection)
                    return DataProvider.Auto;
                DataProviderDesc dpd = _cbDataProvider.SelectedItem as DataProviderDesc;
                return dpd == null ? DataProvider.Auto : dpd.Link.DataProvider;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConnectionString
        {
            get
            {
                if (_lastSelectedDataTab == _tpDataObjects)
                {
                    if (_tvDataObjects.SelectedNode == null)
                        return string.Empty;
                    DataSet dataSet = _tvDataObjects.SelectedNode.Tag as DataSet;
                    if (dataSet != null)
                        return _tvDataObjects.SelectedNode.Text;
                    DataTable dataTable = _tvDataObjects.SelectedNode.Tag as DataTable;
                    if (dataTable != null)
                        return _tvDataObjects.SelectedNode.Parent.Text;
                    return string.Empty;
                }
                if (_lastSelectedDataTab == _tpConnection)
                {
                    return _cbConnectionString.Text;
                }
                return string.Empty;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool RecordSourceSelected
        {
            get
            {
                if (_lastSelectedDataTab == _tpDataObjects)
                {
                    return _tvDataObjects.SelectedNode != null && _tvDataObjects.SelectedNode.Tag is DataTable;
                }
                if (_lastSelectedDataTab == _tpConnection)
                {
                    if (_tcConnection.SelectedTab == _tpDataSource)
                    {
                        if (_tvDataSource.SelectedNode == null)
                            return false;
                        return _tvDataSource.SelectedNode.Tag is ObjectDesc;
                    }
                    if (_tcConnection.SelectedTab == _tpSql)
                    {
                        return !string.IsNullOrEmpty(_tbSql.Text);
                    }
                    return false;
                }
                return false;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RecordSourceType RecordSourceType
        {
            get
            {
                if (_lastSelectedDataTab == _tpConnection)
                {
                    if (_tcConnection.SelectedTab == _tpDataSource)
                    {
                        if (_tvDataSource.SelectedNode != null)
                        {
                            ObjectDesc od = _tvDataSource.SelectedNode.Tag as ObjectDesc;
                            if (od != null)
                                return od.RecordSourceType;
                        }
                    }
                }
                return RecordSourceType.Auto;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RecordSource
        {
            get
            {
                if (_lastSelectedDataTab == _tpDataObjects)
                {
                    if (_tvDataObjects.SelectedNode == null)
                        return string.Empty;
                    DataTable dataTable = _tvDataObjects.SelectedNode.Tag as DataTable;
                    return dataTable == null ? string.Empty : dataTable.TableName;
                }
                if (_lastSelectedDataTab == _tpConnection)
                {
                    if (_tcConnection.SelectedTab == _tpDataSource)
                    {
                        if (_tvDataSource.SelectedNode == null)
                            return string.Empty;
                        ObjectDesc od = _tvDataSource.SelectedNode.Tag as ObjectDesc;
                        if (od != null)
                            return od.RecordSourceString;
                        return string.Empty;
                    }
                    if (_tcConnection.SelectedTab == _tpSql)
                    {
                        return _tbSql.Text;
                    }
                    return string.Empty;
                }
                return string.Empty;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object Recordset
        {
            get
            {
                if (_lastSelectedDataTab == _tpDataObjects)
                {
                    if (_tvDataObjects.SelectedNode == null)
                        return null;
                    return _tvDataObjects.SelectedNode.Tag as DataTable;
                }
                return null;
            }
        }
        #endregion

        #region Public
        public IList<ReportParameterDesc> GetRecordSourceParameters()
        {
            if (_lastSelectedDataTab == _tpConnection)
            {
                if (_tcConnection.SelectedTab == _tpDataSource)
                {
                    if (_tvDataSource.SelectedNode == null)
                        return null;
                    ObjectDesc od = _tvDataSource.SelectedNode.Tag as ObjectDesc;
                    if (od == null)
                        return null;
                    return od.GetRecordSourceParameters();
                }
            }
            return null;
        }

        public void SetDataSource(DataProvider dataProvider, string connectionString, string recordSource)
        {
            BeginUpdate();
            try
            {
                if (connectionString == null)
                    connectionString = string.Empty;

                // Check if connectionString equals to DataSet name in _dataSchema.
                if (_dataSchema != null && _dataSchema.ContainsKey(connectionString))
                {
                    _tpDataObjects.Select();
                    ActiveControl = _tvDataObjects;
                    _tvDataObjects.SelectedNode = FindDataTableObject(_tvDataObjects.Nodes, recordSource);
                    if (_tvDataObjects.SelectedNode == null)
                        _tvDataObjects.SelectedNode = FindDataSetObject(connectionString);

                    // init controls on _tcConnection with default values
                    _cbDataProvider.SelectedIndex = 0;
                    _oldConnectionString = string.Empty;
                    _cbConnectionString.Text = string.Empty;
                    _tvDataSource.Nodes.Clear();
                    _tbSql.Text = string.Empty;

                    return;
                }

                // Select item in _cbDataProvider
                _tpConnection.Select();
                foreach (DataProviderDesc dpd in _cbDataProvider.Items)
                    if (dpd.Link.DataProvider == dataProvider)
                    {
                        _cbDataProvider.SelectedItem = dpd;
                        break;
                    }

                //
                _cbConnectionString.Text = connectionString;
                ConnectionStringChanged(recordSource);

                //
                if (_tvDataSource.SelectedNode != null)
                {
                    _tcConnection.SelectTab(_tpDataSource);
                }
                else
                {
                    if (_tcConnection.TabPages.Contains(_tpSql))
                    {
                        _tcConnection.SelectTab(_tpSql);
                        _tbSql.Text = recordSource;
                    }
                }

                //
                ActiveControl = _cbConnectionString;
            }
            finally
            {
                EndUpdate();
            }
        }
        #endregion

        private void _cbDataProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Updating)
                return;

            // check connection string and clear it if it is not valid
            // for selected data provider
            DataProviderDesc dpd = _cbDataProvider.SelectedItem as DataProviderDesc;
            if (dpd.Link != DsgnAutoLink.Instance)
            {
                if (!dpd.Link.Link.Available)
                {
                    // selected data provider is not installed on the system
                    // show warning for user
                    MessageForm.Warn(string.Format(Strings.DataSourcePicker.ProviderNotInstalledFmt, dpd.Link.Caption));
                    _cbConnectionString.Text = string.Empty;
                }
                else
                {
                    DataLinkParams dlp = new DataLinkParams();
                    dlp.ConnectionString = _cbConnectionString.Text;
                    if (DataSource != null)
                        dlp.Report = DataSource.ParentReport;
                    if (!dpd.Link.Link.Validate(dlp))
                        // connection string is not valid clear it
                        _cbConnectionString.Text = string.Empty;
                }
            }
            ConnectionStringChanged(RecordSource);
        }

        private void _cbConnectionString_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Updating)
                return;

            ConnectionDesc cd = _cbConnectionString.SelectedItem as ConnectionDesc;
            if (cd != null)
            {
                BeginUpdate();
                foreach (DataProviderDesc dpd in _cbDataProvider.Items)
                    if (dpd.Link == cd.Link)
                    {
                        _cbDataProvider.SelectedItem = dpd;
                        break;
                    }
                ConnectionStringChanged(RecordSource);
                EndUpdate();
            }
        }

        private void _cbConnectionString_Enter(object sender, EventArgs e)
        {
            _oldConnectionString = _cbConnectionString.Text;
        }

        private void _cbConnectionString_Leave(object sender, EventArgs e)
        {
            if (Updating)
                return;

            if (_cbConnectionString.Text != _oldConnectionString)
                ConnectionStringChanged(RecordSource);
        }

        private void _tvDataSource_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Updating)
                return;

            UpdateButtons();
        }

        private void _btnEditConnection_Click(object sender, EventArgs e)
        {
            DataProviderDesc dpd = _cbDataProvider.SelectedItem as DataProviderDesc;
            DsgnDataLinkBase dl;
            if (dpd == null || dpd.Link == DsgnAutoLink.Instance)
            {
                // auto link can not be used for editing parameters
                // we should determine real type of connection string
                // and use needed Link class
                dl = DsgnAutoLink.Instance.GetRealLink(this);
            }
            else
                dl = dpd.Link;

            try
            {
                string connectionString = _cbConnectionString.Text;
                if (dl.EditConnection(this, ref connectionString))
                    SetDataSource(dl.DataProvider, connectionString, RecordSource);
            }
            catch (Exception ex)
            {
                DataSourceForm.ReportDataSourceError(string.Format(Strings.DataSourcePicker.ErrCannotEditConnFmt, ex.Message));
            }
            ActiveControl = _cbConnectionString;
        }

        private void _cbWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            _tbSql.WordWrap = _cbWordWrap.Checked;
        }

        private void _btnDataSourceProperties_Click(object sender, EventArgs e)
        {
            if (_tvDataSource.SelectedNode != null)
            {
                ExternalRecordsetDesc erd = _tvDataSource.SelectedNode.Tag as ExternalRecordsetDesc;
                if (erd != null)
                {
                    erd.Recordset.Params = erd.Parameters;
                    erd.Recordset.EditParams();
                    erd.Parameters = erd.Recordset.Params;
                    return;
                }
            }
        }

        private void _btnQueryBuilder_Click(object sender, EventArgs e)
        {
            using (SqlBuilderDialog dlg = new SqlBuilderDialog())
            {
                // initialize sql wizard
                try
                {
                    dlg.ConnectionString = _cbConnectionString.Text;
                    dlg.Sql = RecordSource;
                }
                catch
                {
                    // error initializing, don't show the dialog
                    return;
                }

                // show sql wizard
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    BeginUpdate();
                    if (_cbConnectionString.Text != dlg.ConnectionString)
                    {
                        // copy connection string from SqlBuilderDialog
                        // select OleDb link
                        for (int i = 0; i < _cbDataProvider.Items.Count; i++)
                            if (((DataProviderDesc)_cbDataProvider.Items[i]).Link == DsgnOledbLink.Instance)
                            {
                                _cbDataProvider.SelectedIndex = i;
                                break;
                            }

                        // set connection string text
                        _cbConnectionString.Text = dlg.ConnectionString;

                        // update controls
                        ConnectionStringChanged(RecordSource);
                    }
                    _tbSql.Text = dlg.Sql;
                    EndUpdate();
                }
            }
        }

        private void _cbConnectionString_DrawItem(object sender, DrawItemEventArgs e)
        {
            //
            ConnectionDesc cd = (ConnectionDesc)_cbConnectionString.Items[e.Index];

            e.DrawBackground();
            Color color = ((e.State & DrawItemState.Selected) != 0) ? SystemColors.HighlightText : SystemColors.WindowText;
            using (Font f = new Font(_cbConnectionString.Font, FontStyle.Bold))
            {
                Size sz = TextRenderer.MeasureText(e.Graphics, cd.Caption, f, Size.Empty, TextFormatFlags.Default);
                Rectangle captionRect = new Rectangle(e.Bounds.X + c_ConnectionDrawLeftOffset, e.Bounds.Y, sz.Width, e.Bounds.Height);
                Rectangle detailsRect = new Rectangle(e.Bounds.X + sz.Width + c_ConnectionDrawLeftOffset + c_ConnectionDrawSpacing, e.Bounds.Y, e.Bounds.Width - sz.Width - c_ConnectionDrawLeftOffset - c_ConnectionDrawSpacing, e.Bounds.Height);
                TextRenderer.DrawText(e.Graphics, cd.Caption, f, captionRect, color, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                TextRenderer.DrawText(e.Graphics, cd.Details, _cbConnectionString.Font, detailsRect, color, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.PathEllipsis);
            }
            e.DrawFocusRectangle();
        }

        private void _cbDataProvider_DrawItem(object sender, DrawItemEventArgs e)
        {
            DataProviderDesc dpd = (DataProviderDesc)_cbDataProvider.Items[e.Index];
            e.DrawBackground();
            Color color;
            if ((e.State & DrawItemState.Selected) != 0)
                color = SystemColors.HighlightText;
            else
                color = dpd.Link.Available ? SystemColors.WindowText : SystemColors.GrayText;
            TextRenderer.DrawText(e.Graphics, dpd.ToString(), _cbDataProvider.Font, e.Bounds, color, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            e.DrawFocusRectangle();
        }

        private class CalcFieldItem : ListViewItem
        {
            private CalculatedField _field;

            public CalcFieldItem(CalculatedField field)
            {
                _field = field;
                base.Text = _field.Name;
            }

            public CalculatedField Field { get { return _field; } }
        }

        private CalcFieldItem GetSelectedItem()
        {
            if (_lvCalculatedFields.SelectedItems.Count == 1)
                return _lvCalculatedFields.SelectedItems[0] as CalcFieldItem;
            else
                return null;
        }

        private void _lvCalculatedFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcFieldItem cfi = GetSelectedItem();
            _propGrid.SelectedObject = cfi != null ? EditorsHelper.CreateInstanceModel(cfi.Field, DesignerHostServices) : null;
            _btnRemove.Enabled = cfi != null;
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (DataSource == null)
                return;

            var cf = new CalculatedField();
            cf.Name = DesignerUtil.MakeUniqueName(this.DataSource.CalculatedFields, "CalculatedField");
            this.DataSource.CalculatedFields.Add(cf);
            var cfItem = _lvCalculatedFields.Items.Add(new CalcFieldItem(cf));
            _lvCalculatedFields.Focus();
            cfItem.Selected = true;
        }

        private void _btnRemove_Click(object sender, EventArgs e)
        {
            if (DataSource == null)
                return;

            CalcFieldItem cfi = GetSelectedItem();
            if (cfi != null)
            {
                int idx = cfi.Index;
                this.DataSource.CalculatedFields.Remove(cfi.Field);
                _lvCalculatedFields.Items.Remove(cfi);
                _lvCalculatedFields.Focus();
                if (idx >= _lvCalculatedFields.Items.Count)
                    --idx;
                if (idx >= 0)
                    _lvCalculatedFields.Items[idx].Selected = true;
            }
        }
    }
}
