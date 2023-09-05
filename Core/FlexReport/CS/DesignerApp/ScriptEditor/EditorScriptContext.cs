//----------------------------------------------------------------------------
// EditorScriptContext.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using C1.Win.FlexReport;
using Maps = C1.Win.FlexReport.CustomFields.Maps;
using C1.Win.FlexReport.FlexDesigner;
using FCF = C1.Win.FlexReport.FlexChart;
#if MAP
using C1.Win.FlexReport.Map;
#endif

namespace FlexReportDesignerApp
{
    public abstract class EditorScriptContextBase
    {
        private static string GetDataSourceName(FlexChartFieldBase field, C1FlexReport report)
        {
            if (field != null && !string.IsNullOrEmpty(field.DataSourceName))
                return field.DataSourceName;
            return report.DataSourceName;
        }

        public static string MakeContextName(string dataSourceName, ScriptEditorContextKind kind)
        {
            dataSourceName = dataSourceName ?? string.Empty;
            switch (kind)
            {
                case ScriptEditorContextKind.DataHandler:
                    return dataSourceName + "_data";
                case ScriptEditorContextKind.ReportScript:
                    return dataSourceName + "_rep";
                case ScriptEditorContextKind.DataView:
                    return dataSourceName + "_DataView";
                case ScriptEditorContextKind.MetaView:
                    return "_MetaView";
                default:
                    System.Diagnostics.Debug.Assert(false);
                    return null;
            }
        }

        /// <summary>
        /// Use this method to reasonably accurately guess context name (i.e. data source and kind)
        /// based on the object on which a property is going to be edited.
        /// For use in type converters/ui editors.
        /// Note that if item type is not recognized, it defaults to ReportScript - so no need
        /// to add specific support for report script items.
        /// </summary>
        /// <param name="object"></param>
        /// <returns></returns>
        /// <seealso cref="MakeContextName"/>
        public static void GuessContextName(C1FlexReport report, object @object, string propertyName, 
            out string dsName, out ScriptEditorContextKind kind)
        {
            if (report == null || @object == null)
            {
                dsName = null;
                kind = ScriptEditorContextKind.ReportScript;
            }
            else if (@object is DataSource)
            {
                dsName = ((DataSource)@object).Name;
                if (propertyName == "Filter")
                {
                    if (((DataSource)@object).FilterSyntax == FilterExpressionSyntax.DataView)
                        kind = ScriptEditorContextKind.DataView;
                    else
                        kind = ScriptEditorContextKind.DataHandler;
                }
                else
                    kind = ScriptEditorContextKind.DataHandler;
            }
            else if (@object is ReportParameter)
            {
                dsName = report.DataSourceName;
                kind = ScriptEditorContextKind.DataHandler;
            }
            else if (@object is CalculatedField)
            {
                dsName = ((CalculatedField)@object).DataSource.Name;
                kind = ScriptEditorContextKind.DataHandler;
            }
            else if (@object is SortDefinition)
            {
                if (propertyName == "Expression")
                {
                    dsName = null;
                    kind = ScriptEditorContextKind.MetaView;
                }
                else // is an 'else' possible?
                {
                    dsName = ((SortDefinition)@object).Owner.Owner.Name;
                    kind = ScriptEditorContextKind.DataHandler;
                }
            }
            else if (@object is Group)
            {
                dsName = ((Group)@object).ParentReport.DataSourceName;
                kind = ScriptEditorContextKind.DataHandler;
            }
            else if (@object is ChartField)
            {
                if (propertyName == "FilterExpression")
                {
                    dsName =  ((ChartField) @object).DataSource;
                    kind = ScriptEditorContextKind.DataHandler;
                }
                else
                {
                    dsName = report.DataSourceName;
                    kind = ScriptEditorContextKind.ReportScript;
                }
            }
            else if (@object is FlexChartFieldBase)
            {
                kind = ScriptEditorContextKind.DataHandler;
                dsName = GetDataSourceName((FlexChartFieldBase)@object, report);
            }
            else if (@object is FCF.Series)
            {
                kind = ScriptEditorContextKind.DataHandler;
                if (!string.IsNullOrEmpty(((FCF.Series)@object).DataSourceName))
                    dsName = ((FCF.Series)@object).DataSourceName;
                else
                    dsName = GetDataSourceName(((FCF.Series)@object).Field, report);
            }
            else if (@object is FCF.ChartObject)
            {
                kind = ScriptEditorContextKind.DataHandler;
                dsName = GetDataSourceName(((FCF.ChartObject)@object).Field, report);
            }
            /*else if (@object is ReportLinkTargetBookmark)
            {
                ReportLinkTargetBookmark rltb = (ReportLinkTargetBookmark)@object;
                if (rltb.)
            }*/
#if MAP
            else if (@object is IMapObject)
            {
                var mapObject = @object as IMapObject;
                var template = GetParent<MapTemplate>(mapObject);
                var spatialData = GetParent<MapSpatialData>(mapObject);
                var layerData = GetParent<MapLayerData>(mapObject);
                var vectorLayerBase = GetParent<MapVectorsLayerBase>(mapObject);
                if (vectorLayerBase == null)
                {
                    // properties not in vector layer
                    dsName = report.DataSourceName;
                }
                else if (layerData != null)
                {
                    // properties in layer data
                    if (propertyName == "DataSourceName" || propertyName == "DataSourceFilter")
                        dsName = report.DataSourceName;
                    else
                    {
                        dsName = layerData.DataSourceName.ToString();
                        if (string.IsNullOrEmpty(dsName)) dsName = report.DataSourceName;
                    }

                }
                else if (spatialData != null && template == null)
                {
                    // properties of SpatialData
                    dsName = report.DataSourceName;
                }
                else
                {
                    // properties in vector layer
                    if (vectorLayerBase.LayerData == null)
                        dsName = report.DataSourceName;
                    else
                    {
                        dsName = vectorLayerBase.LayerData.DataSourceName.ToString();
                        if (string.IsNullOrEmpty(dsName)) dsName = report.DataSourceName;
                    }
                }

                kind = (propertyName == "ItemFilter" || propertyName == "DataSourceFilter")
                    ? ScriptEditorContextKind.DataHandler
                    : ScriptEditorContextKind.ReportScript;
            }
#endif
            // otherwise, first try to guess custom Map field,
            // the default is report script / main data source:
            else
            {
                if (!MainForm.CustomFieldsAssemblyAvailable
                    || !GuessCustomMapContextName(report, @object, propertyName, out dsName, out kind))
                {
                    dsName = report.DataSourceName;
                    kind = ScriptEditorContextKind.ReportScript;
                }
            }
        }

        /// <summary>
        /// Try to guess the context name for custom Map field.
        /// </summary>
        /// <returns>true, if it's the context name for custom Map field; otherwise, false.</returns>
        /// <remarks>
        /// Wrap all codes for custom Map field here to bypass the type checking, if the CustomField assembly is inavailable..
        /// </remarks>
        private static bool GuessCustomMapContextName(C1FlexReport report, object @object, string propertyName,
            out string dsName, out ScriptEditorContextKind kind)
        {
            if (@object is Maps.MapOwnedItemBase)
            {
                if (propertyName == "DataSourceFilterExpression")
                {
                    dsName = report.DataSourceName;
                    kind = ScriptEditorContextKind.DataHandler;
                }
                else
                {
                    kind = ScriptEditorContextKind.ReportScript;
                    if (@object is Maps.LayerBase)
                    {
                        var layer = (Maps.LayerBase) @object;
                        dsName = string.IsNullOrEmpty(layer.DataSource)
                            ? report.DataSourceName
                            : layer.DataSource;
                    }
                    else if (@object is Maps.ILayerReferencedItem)
                    {
                        var layer = ((Maps.ILayerReferencedItem) @object).Layer;
                        dsName = (layer == null || string.IsNullOrEmpty(layer.DataSource))
                            ? report.DataSourceName
                            : layer.DataSource;
                    }
                    else
                    {
                        dsName = report.DataSourceName;
                    }
                }

                return true;
            }
            else
            {
                dsName = report.DataSourceName;
                kind = ScriptEditorContextKind.ReportScript;
                return false;
            }
        }

#if MAP
        private static T GetParent<T>(IMapObject mapObject) where T : class
        {
            var parent = mapObject;
            while (parent != null && !(parent is T))
                parent = parent.Parent;

            return parent as T;
        }
#endif

        public static string GuessContextName(C1FlexReport report, object @object, string propertyName)
        {
            string dsName;
            ScriptEditorContextKind kind;
            GuessContextName(report, @object, propertyName, out dsName, out kind);
            return MakeContextName(dsName, kind);
        }

        protected string _dataSourceName = null;
        private DataSourceInfo _dataSourceInfo = null;
        private CalculatedFieldCollection _calculatedFields = null;
        private ReportParameterCollection _parameters = null;
        private C1FlexReportDesigner _designer = null;

        public abstract ScriptEditorContextKind ContextKind { get; }
        public string Name { get; private set; }

        public ReportParameterCollection Parameters { get { return _parameters; } }
        public string DataSourceName { get { return _dataSourceName; } }
        public abstract ScriptSyntax Syntax { get; }
        public bool HasDataSourceInfo { get { return _dataSourceInfo != null; } }
        public DataSourceInfo DataSourceInfo { get { return _dataSourceInfo; } }
        public CalculatedFieldCollection CalculatedFields { get { return _calculatedFields; } }
        public C1FlexReportDesigner Designer { get { return _designer; } }

        protected EditorScriptContextBase(string name, C1FlexReport report, DataSource dataSource, C1FlexReportDesigner designer)
        {
            Name = name;
            _parameters = report.Parameters;
            _designer = designer;
            if (dataSource != null)
            {
                _dataSourceName = dataSource.Name;
                _calculatedFields = dataSource.CalculatedFields;
                if (dataSource.IsDataSourceInfoFetched)
                    SetDataSourceInfo(dataSource.DataSourceInfo);
            }
        }

        /// <summary>
        /// Sets the data source info. This method is separate from the ctor because
        /// fetching DataSourceInfo might be done in a separate non-ui thread to improve responsiveness.
        /// </summary>
        /// <param name="dataSourceInfo"></param>
        public void SetDataSourceInfo(DataSourceInfo dataSourceInfo)
        {
            _dataSourceInfo = dataSourceInfo;
        }
    }

    public class EditorScriptDataHandlerContext : EditorScriptContextBase
    {
        public override ScriptEditorContextKind ContextKind { get { return ScriptEditorContextKind.DataHandler; } }
        public EditorScriptDataHandlerContext(string name, C1FlexReport report, DataSource dataSource, C1FlexReportDesigner designer)
            : base(name, report, dataSource, designer)
        {
        }
        public override ScriptSyntax Syntax
        {
            get { return ScriptSyntax.VBScript; }
        }
    }

    public class EditorScriptDataFilterContext : EditorScriptContextBase
    {
        public override ScriptEditorContextKind ContextKind { get { return ScriptEditorContextKind.DataView; } }
        public EditorScriptDataFilterContext(string name, C1FlexReport report, DataSource dataSource, C1FlexReportDesigner designer)
            : base(name, report, dataSource, designer)
        {
        }
        public override ScriptSyntax Syntax
        {
            get { return ScriptSyntax.DataView; }
        }
    }

    public class EditorScriptMetaViewContext : EditorScriptContextBase
    {
        public override ScriptEditorContextKind ContextKind { get { return ScriptEditorContextKind.MetaView; } }
        public EditorScriptMetaViewContext(string name, C1FlexReport report, C1FlexReportDesigner designer)
            : base(name, report, null, designer)
        {
        }
        public override ScriptSyntax Syntax
        {
            get { return ScriptSyntax.DataView; }
        }
    }

    public class EditorScriptReportScriptContext : EditorScriptContextBase
    {
        public override ScriptEditorContextKind ContextKind { get { return ScriptEditorContextKind.ReportScript; } }
        public EditorScriptReportScriptContext(string name, C1FlexReport report, DataSource dataSource, C1FlexReportDesigner designer)
            : base(name, report, dataSource, designer)
        {
        }
        public override ScriptSyntax Syntax
        {
            get { return ScriptSyntax.VBScript; }
        }
    }

    public class EditorScriptContextCollection
    {
        private Dictionary<string, EditorScriptContextBase> _contexts = new Dictionary<string, EditorScriptContextBase>();
        private Forms.ScriptEditorFormEx _owner;
        private C1FlexReport _report;

        public EditorScriptContextCollection(Forms.ScriptEditorFormEx owner, C1FlexReport report, C1FlexReportDesigner designer)
        {
            _owner = owner;
            _report = report;
            string name;
            foreach (var ds in report.DataSources)
            {
                // For each data source, we add 3 contexts:
                // - data handler
                // - regular report
                // - data filter
                string dsName = ds.Name;
                name = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.DataHandler);
                _contexts.Add(name, new EditorScriptDataHandlerContext(name, _report, ds, designer));
                name = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.ReportScript);
                _contexts.Add(name, new EditorScriptReportScriptContext(name, _report, ds, designer));
                name = EditorScriptContextBase.MakeContextName(ds.Name, ScriptEditorContextKind.DataView);
                _contexts.Add(name, new EditorScriptDataFilterContext(name, _report, ds, designer));
            }
            // 'report-only' context (currently used for parameter's allowed values collection edits):
            name = EditorScriptContextBase.MakeContextName(string.Empty, ScriptEditorContextKind.ReportScript);
            _contexts.Add(name, new EditorScriptReportScriptContext(name, _report, null, designer));
            // meta context for expressions that can only access parameters (currently only data sort definition),
            // also is used for cases when corresponding context was not found (patchy but will do for now):
            name = EditorScriptContextBase.MakeContextName(null, ScriptEditorContextKind.MetaView);
            _contexts.Add(name, new EditorScriptMetaViewContext(name, _report, designer));
        }

        /// <summary>
        /// Fills the data source infos in separate threads.
        /// This method is not a part of the ctor because it needs form.Invoke,
        /// and that can only be used when the form's handle has been created,
        /// i.e. in FormLoad but not in Form ctor.
        /// </summary>
        public void Init()
        {
            foreach (var context in _contexts.Values)
            {
                if (!context.HasDataSourceInfo)
                {
                    Thread t = new Thread(new ParameterizedThreadStart(LoadDataSourceInfo));
                    t.Start(context.Name);
                }
            }
        }

        public EditorScriptContextBase GetContext(string name)
        {
            EditorScriptContextBase ret;
            _contexts.TryGetValue(name, out ret);
            if (ret == null)
                // fallback context for invalid data source names:
                ret = _contexts[EditorScriptContextBase.MakeContextName(null, ScriptEditorContextKind.MetaView)];
            return ret;
        }

        private void LoadDataSourceInfo(object contextName)
        {
            var context = _contexts[(string)contextName];
            lock (_report)
            {
                var dataSource = _report.DataSources.FindByName(context.DataSourceName);
                if (dataSource != null)
                {
                    // get the list of db fields (may be slow the first time)
                    dataSource.FetchDataSourceInfo(false);
                    var info = dataSource.DataSourceInfo;
                    context.SetDataSourceInfo(info);
                }
            }
            // done, update UI on the main thread
            try
            {
                _owner.Invoke((Action<string>)((s_) => _owner.DataSourceInfoFetched(s_)), context.DataSourceName);
            }
            catch
            {
                // eat exceptions - we may have left the window...
            }
        }
    }
}
