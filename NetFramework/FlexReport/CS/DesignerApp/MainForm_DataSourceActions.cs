//----------------------------------------------------------------------------
// MainForm_DataSourceActions.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Globalization;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Linq;

using C1.Win.Ribbon;
using FlexReportDesignerApp.Util;
using C1.Win.C1Command;
using C1.Win.Localization;
using C1.Win.C1Themes;
using C1.Util.Licensing;

using C1.Report;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Doc = C1.Win.C1Document;
using Flex = C1.Win.FlexReport;
using FlexReportDesignerApp.Controls;

namespace FlexReportDesignerApp
{
    public partial class MainForm
    {
        private class DataSourcesState
        {
            private C1FlexReport _report;
            private string _mainDataSourceName;
            private List<DataSource> _dataSources;
            public DataSourcesState(C1FlexReport report)
            {
                _report = report;
                _mainDataSourceName = report.DataSourceName;
                _dataSources = new List<DataSource>(_report.DataSources.Count);
                foreach (var ds in report.DataSources)
                {
                    var copy = new DataSource();
                    copy.AssignFrom(ds, true);
                    _dataSources.Add(copy);
                }
            }
            public void Restore()
            {
                while (_report.DataSources.Count > 0)
                    _report.DataSources.RemoveAt(0);
                for (int i = 0; i < _dataSources.Count; ++i)
                    _report.DataSources.Add(_dataSources[i]);
                _report.DataSourceName = _mainDataSourceName;
            }
        }

        private object _inplaceUndo = null;
        private void _dataTree_InplaceEditBegin(object sender, DataTreeInplaceEditEventArgs e)
        {
            System.Diagnostics.Debug.Assert(_inplaceUndo == null);
            _inplaceUndo = _flexDesigner.Undo_CreateSavedState();
        }
        private void _dataTree_InplaceEditEnd(object sender, DataTreeInplaceEditEventArgs e)
        {
            // NOTE: The actual assigning of edited values is done by the data tree, we only have to ensure undo-ableness,
            // and update the designer.
            System.Diagnostics.Debug.Assert(_inplaceUndo != null);
            if (e.Cancel)
            {
                _flexDesigner.Undo_DiscardSavedState(_inplaceUndo);
            }
            else
            {
                _flexDesigner.Undo_PushSavedState(_inplaceUndo);
                // not needed here: _flexDesigner.UpdateFromReport();
                _fieldPicker.Refresh();
            }
            // done.
            _inplaceUndo = null;
        }

        private void _dataTree_DataObjectDoubleClick(object sender, DataTreeDoubleClickEventArgs e)
        {
            var sd = e.DataObject as SortDefinition;
            if (sd == null)
                return;

            DoDataTreeChangeSortOrder(sd);
        }

        private void DoDataSourceRefresh()
        {
            var ds = _dataTree.SelectedDataObject as DataSource;
            if (ds == null)
                return;
            ds.ResetDataSourceInfo();
            UpdateUI(true, true);
        }

        private void DoDataTreeChangeSortOrder(SortDefinition sd = null)
        {
            if (sd == null)
                sd = _dataTree.GetCurrentSortDefinition();
            if (sd == null)
                return;

            _dataTree.EndInPlaceEdit();
            _flexDesigner.UndoSaveState();
            if (!sd.Direction.IsExpression)
            {
                if (sd.Direction.Value == SortDirection.Ascending)
                    sd.Direction.Value = SortDirection.Descending;
                else
                    sd.Direction.Value = SortDirection.Ascending;
            }
            _flexDesigner.UpdateFromReport();
            _dataTree.UpdateFromReport();
            UpdateUI(true, true);
        }

        private void DoDataTreeEdit()
        {
            var dataObject = _dataTree.SelectedDataObject;
            if (dataObject == null)
                return;

            if (dataObject is DataSource)
            {
                DoDataSourcesAction((Func<DataSource, bool>)DataSources_EditDataSource, (DataSource)dataObject);
                return;
            }

            _dataTree.EndInPlaceEdit();
            var undo = _flexDesigner.Undo_CreateSavedState();
            if (dataObject is CalculatedField)
            {
                var cf = (CalculatedField)dataObject;
                var ds = _dataTree.GetCurrentDataSource();
                var contextName = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.DataHandler);
                object result;
                if (EditScriptInternal((C1FlexReport)ds.ParentReport, contextName, null, dataObject, "Expression", null, true, out result))
                {
                    _flexDesigner.Undo_PushSavedState(undo);
                    _flexDesigner.UpdateFromReport();
                    _dataTree.UpdateFromReport();
                }
                else
                {
                    _flexDesigner.Undo_DiscardSavedState(undo);
                }
            }
            else if (dataObject is SortDefinition)
            {
#if skip_dima // simplifying...
                var sd = (SortDefinition)dataObject;
                var ds = _dataTree.GetCurrentDataSource();
                var contextName = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.MetaView);
                object result;
                if (EditScriptInternal(ds.ParentReport, contextName, null, dataObject, "Expression", null, true, out result))
                {
                    _flexDesigner.Undo_PushSavedState(undo);
                    _flexDesigner.UpdateFromReport();
                    _dataTree.UpdateFromReport();
                }
                else
                {
                    _flexDesigner.Undo_DiscardSavedState(undo);
                }
#else
                var sd = (SortDefinition)dataObject;
                var ds = _dataTree.GetCurrentDataSource();
                using (Forms.AddSortDefForm addForm = new Forms.AddSortDefForm(ds))
                {
                    addForm.SortExpression = sd.Expression;
                    addForm.Ascending = sd.Direction.Value == SortDirection.Ascending;
                    if (addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        sd.Expression = addForm.SortExpression;
                        sd.Direction = addForm.Ascending ? SortDirection.Ascending : SortDirection.Descending;
                        _flexDesigner.Undo_PushSavedState(undo);
                        _flexDesigner.UpdateFromReport();
                        _dataTree.UpdateFromReport();
                    }
                    else
                    {
                        _flexDesigner.Undo_DiscardSavedState(undo);
                    }
                }
#endif
            }
            else
                System.Diagnostics.Debug.Assert(false, "Do not know how to edit data object");
            UpdateUI(true, true);
        }

        private void DoDataTreeMoveUp()
        {
            if (!cDataTreeMoveUp.Enabled)
                return;

            _dataTree.EndInPlaceEdit();
            _flexDesigner.UndoSaveState();
            _dataTree.MoveNodeUp();
            _flexDesigner.UpdateFromReport();
            UpdateUI(false);
        }

        private void DoDataTreeMoveDown()
        {
            if (!cDataTreeMoveDown.Enabled)
                return;

            _dataTree.EndInPlaceEdit();
            _flexDesigner.UndoSaveState();
            _dataTree.MoveNodeDown();
            _flexDesigner.UpdateFromReport();
            UpdateUI(false);
        }

        private void DoDataSourceSetAsMain(DataSource ds)
        {
            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            _dataTree.EndInPlaceEdit();
            _flexDesigner.UndoSaveState();
            report.DataSourceName = ds.Name;
            UpdateUI(true, true);
        }

        private void DoDataSourcesAction(object tAction, DataSource ds)
        {
            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            _dataTree.EndInPlaceEdit();
            // save state to handle data dialogs' Cancel button
            // (they change the report itself, we roll back the changes if cancel):
            DataSourcesState dss = new DataSourcesState(report);
            // undo state - will be pused on undo stack if changes are accepted:
            DiscardPendingUndoState();
            var undo = _flexDesigner.Undo_CreateSavedState();

            BeginUpdates();
            bool accepted;
            DataSource targetDS = null;
            if (tAction is Func<bool>)
                accepted = ((Func<bool>)tAction)();
            else if (tAction is Func<DataSource>)
                accepted = (targetDS = ((Func<DataSource>)tAction)()) != null;
            else if (tAction is Func<DataSource, bool>)
                accepted = ((Func<DataSource, bool>)tAction)(ds);
            else
            {
                System.Diagnostics.Debug.Assert(false);
                accepted = false;
            }

            // Push undo stack or roll back the changes:
            if (accepted)
            {
                _flexDesigner.Undo_PushSavedState(undo);
                UpdateUI(true, true);
                _dataTree.UpdateFromReport();
                if (targetDS != null)
                    _dataTree.GoToDataSource(targetDS);
            }
            else
            {
                _flexDesigner.Undo_DiscardSavedState(undo);
                dss.Restore();
                _flexDesigner.UpdateFromReport();
                UpdateUI(true, true);
                _dataTree.UpdateFromReport();
            }
            EndUpdates(accepted);
        }

        private bool DataSources_EditMain()
        {
            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return false;

            var ds = report.DataSource;
            if (ds == null)
            {
                if (MessageForm.Ask(Strings.MainForm.CreateMainDataSourceQ, MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
                    return false;
                ds = DataSources_AddDataSource();
                if (ds == null)
                    return false;
                report.DataSourceName = ds.Name;
                return true;
            }
            else
                return DataSources_EditDataSource(ds);
        }

        private DataSource DataSources_AddDataSource()
        {
            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return null;

            Cursor = Cursors.WaitCursor;
            try
            {
                DataSource ds = new DataSource();
                ds.Name = DesignerUtil.MakeUniqueName(report.DataSources);
                report.DataSources.Add(ds);
                using (DataSourceForm dlg = new DataSourceForm())
                {
                    if (dlg.EditDataSource(report, _dataSchema, ds, _services, true))
                        return ds;
                }
                return null;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool DataSources_EditDataSource(DataSource ds)
        {
            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return false;

            Cursor = Cursors.WaitCursor;
            try
            {
                using (DataSourceForm dlg = new DataSourceForm())
                {
                    if (dlg.EditDataSource(report, _dataSchema, ds, _services))
                    {
                        ds.ResetDataSourceInfo();
                        return true;
                    }
                }
                return false;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool DataSources_RemoveDataSource(DataSource ds)
        {
            if (ds == null)
                return false;
            if (MessageForm.Ask(String.Format(Strings.MainForm.RemoveDataSourceFmt, ds.Name)) == DialogResult.No)
                return false;
            var dss = ds.ParentReport.DataSources;
            dss.RemoveAt(dss.IndexOf(ds));
            return true;
        }

        private void DoAddParameter()
        {
            if (!cAddParameter.Enabled)
                return;

            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            _dataTree.EndInPlaceEdit();
            BeginUpdates();
            _flexDesigner.UndoSaveState();
            ReportParameter parameter = new ReportParameter();
            parameter.Name = DesignerUtil.MakeUniqueName(report.Parameters, "Parameter");
            report.Parameters.Add(parameter);
            EndUpdates(true);
            foreach (var ds in report.DataSources)
                ds.ResetDataSourceInfo();
            UpdateUI(true, true);
            if (_dataTree.GoToParameter(parameter))
                _dataTree.StartInplaceEdit();
        }

        private void DoAddCalculatedField()
        {
            if (!cAddCalculatedField.Enabled)
                return;

            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            var ds = _dataTree.GetCurrentDataSource();
            if (ds == null)
                return;

            var contextName = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.DataHandler);
            CalculatedField cf = null;
            Func<DataSource, bool> addField = (ds_) =>
            {
                cf = new CalculatedField();
                cf.Name = DesignerUtil.MakeUniqueName(ds_.CalculatedFields, "CalculatedField");
                ds_.CalculatedFields.Add(cf);
                object result;
                if (EditScriptInternal((Flex.C1FlexReport)ds_.ParentReport, contextName, null, cf, "Expression", null, true, out result))
                    return true;
                cf = null;
                return false;
            };

            DoDataSourcesAction(addField, ds);

            if (cf != null)
                _dataTree.GoToCalculatedField(cf);
        }

#if skip_dima // old add sort
        private void DoAddSortDefinition()
        {
            if (!cAddSort.Enabled)
                return;

            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            var ds = _dataTree.GetCurrentDataSource();
            if (ds == null)
                return;

            var contextName = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.MetaView);
            SortDefinition sd = null;
            Func<DataSource, bool> addSort = (ds_) =>
                {
                    sd = new SortDefinition();
                    ds_.SortDefinitions.Add(sd);
                    object result;
                    if (EditScriptInternal(ds_.ParentReport, contextName, null, sd, "Expression", null, true, out result))
                        return true;
                    sd = null;
                    return false;
                };

            DoDataSourcesAction(addSort, ds);

            if (sd != null)
                _dataTree.GoToSortDefinition(ds, sd);
        }
#else
        private void DoAddSortDefinition()
        {
            if (!cAddSort.Enabled)
                return;

            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            var ds = _dataTree.GetCurrentDataSource();
            if (ds == null)
                return;

            var contextName = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.MetaView);
            SortDefinition sd = null;
            Func<DataSource, bool> addSort = (ds_) =>
                {
                    sd = new SortDefinition();
                    ds_.SortDefinitions.Add(sd);
                    using (Forms.AddSortDefForm addForm = new Forms.AddSortDefForm(ds))
                    {
                        if (addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            sd.Expression = addForm.SortExpression;
                            sd.Direction = addForm.Ascending ? SortDirection.Ascending : SortDirection.Descending;
                            return true;
                        }
                        else
                        {
                            sd = null;
                            return false;
                        }
                    }
                };

            DoDataSourcesAction(addSort, ds);

            if (sd != null)
                _dataTree.GoToSortDefinition(ds, sd);
        }
#endif

        private void DoDataTreeDelete()
        {
            if (!cDataTreeDelete.Enabled)
                return;

            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            var o = _dataTree.SelectedDataObject;

            _dataTree.EndInPlaceEdit();
            BeginUpdates();
            _flexDesigner.UndoSaveState();
            var nextBoss = _dataTree.GetNextBossKey();
            if (o is ReportParameter)
            {
                var rp = (ReportParameter)o;
                rp.Owner.Remove(rp);
                foreach (var ds in report.DataSources)
                    ds.ResetDataSourceInfo();
            }
            else if (o is DataSource)
            {
                var ds = (DataSource)o;
                report.DataSources.RemoveAt(report.DataSources.IndexOf(ds));
            }
            else if (o is CalculatedField)
            {
                var cf = (CalculatedField)o;
                cf.DataSource.CalculatedFields.Remove(cf);
            }
            else if (o is SortDefinition)
            {
                var se = (SortDefinition)o;
                se.Owner.Remove(se);
            }
            else
                System.Diagnostics.Debug.Assert(false);
            EndUpdates(true);
            UpdateUI(true, true);
            _dataTree.GoToNode(null, nextBoss, true);
        }

        private void DoDataTreeInsert()
        {
            if (!cDataTreeInsert.Enabled)
                return;

            var pars = _dataTree.GetCurrentParameters();
            if (pars != null)
                DoAddParameter();
            else if (_dataTree.GetCurrentDataSources() != null)
                DoDataSourcesAction((Func<DataSource>)DataSources_AddDataSource, null);
            else if (_dataTree.GetCurrentCalculatedFields() != null)
                DoAddCalculatedField();
            else if (_dataTree.GetCurrentSortDefinitions() != null)
                DoAddSortDefinition();
        }

#if not_needed
        private class ParametersState
        {
            private C1FlexReport _report;
            private List<ReportParameter> _parameters;
            public ParametersState(C1FlexReport report)
            {
                _report = report;
                _parameters = new List<ReportParameter>(_report.Parameters.Count);
                foreach (var p in report.Parameters)
                {
                    var copy = new ReportParameter();
                    copy.AssignFrom(p);
                    _parameters.Add(copy);
                }
            }
            public void Restore()
            {
                _report.Parameters.Clear();
                for (int i = 0; i < _parameters.Count; ++i)
                    _report.Parameters.Add(_parameters[i]);
            }
        }
#endif
    }
}
