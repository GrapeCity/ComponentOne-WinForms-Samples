//----------------------------------------------------------------------------
// EditorScriptItem.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
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
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp
{
    public class EditorScriptItem
    {
        private const string c_globalScriptsKey = "1_report.GlobalScripts";

        #region Fields
        private string _key;
        private string _displayName;
        private string _text;
        private object _value = null;
        private object _propOwner;
        private string _propName;
        private EditorScriptContextBase _context;
        private bool _isScript;
        private bool _isTextMode = false;
        #endregion

        #region Public properties
        /// <summary>
        /// Keys are used to identify script items.
        /// Additionally, items are sorted by key in UI.
        /// </summary>
        public string Key { get { return _key; } }
        /// <summary>
        /// Gets the text of the item's expression/script/text.
        /// </summary>
        public string Text { get { return _text; } }
        /// <summary>
        /// Gets the item's context.
        /// </summary>
        public EditorScriptContextBase Context { get { return _context; } }
        /// <summary>
        /// Indicates that the item represents a sequence of statements rather than a single expression that yields a value.
        /// True for GlobalScripts, OnOpen and so on, false for field expressions etc.
        /// <see cref="IsTextMode"/> can be turned on only for items wihth this property false.
        /// </summary>
        public bool IsScript { get { return _isScript; } }
        /// <summary>
        /// Indicates whether the item contains plain text rather than a calculated expression.
        /// This is used as a hint to editor (turns off syntax highlighting and code completion),
        /// and if editing a ScriptObjectValue, as a flag to set literal value rather than expression.
        /// Unlike most other items' properties, this may be changed while editing the item.
        /// </summary>
        public bool IsTextMode
        {
            get { return _isTextMode; }
            set
            {
                if (value && _isScript)
                    throw new ArgumentOutOfRangeException("IsTextMode"); // scripts cannot be text mode
                _isTextMode = value;
            }
        }
        /// <summary>
        /// Gets the value written back to the property.
        /// NOTE: this property is valid ONLY after the script has been written back.
        /// The value used to initialize this script item is NOT cached by this.
        /// </summary>
        public object Value { get { return _value; } }
        #endregion

        #region ctors (only static ctors are public)
        public static EditorScriptItem FromTypeDescriptorContext(
            ITypeDescriptorContext typeDescriptorContext,
            EditorScriptContextBase scriptContext,
            bool isScript,
            string displayName = null)
        {
            if (typeDescriptorContext == null)
                return null;

            var pd = typeDescriptorContext.PropertyDescriptor;
            var propertyOwner = typeDescriptorContext.Instance;
            if (propertyOwner is EditableModel)
                propertyOwner = ((EditableModel)propertyOwner).Instance;

            if (pd == null || propertyOwner == null)
                return null;

            var value = pd.GetValue(propertyOwner);
            return new EditorScriptItem(value, propertyOwner, pd.Name, isScript, scriptContext, displayName);
        }

        public static EditorScriptItem FromObjectProperty(
            object propertyOwner,
            string propertyName,
            EditorScriptContextBase scriptContext,
            bool isScript,
            string displayName = null)
        {
            if (propertyOwner is EditableModel)
                propertyOwner = ((EditableModel)propertyOwner).Instance;

            if (propertyOwner == null || string.IsNullOrEmpty(propertyName))
                return null;

            var pd = propertyOwner.GetType().GetProperty(propertyName);
            if (pd == null)
                return null;

            var value = pd.GetValue(propertyOwner, null);
            return new EditorScriptItem(value, propertyOwner, propertyName, isScript, scriptContext, displayName);
        }

        private EditorScriptItem(object value, object propOwner, string propName, bool isScript, EditorScriptContextBase context, string displayName)
        {
            System.Diagnostics.Debug.Assert(propOwner != null && !string.IsNullOrEmpty(propName));
            // Key/name:
            _displayName = MakeName(propOwner, propName, out _key);
            if (!string.IsNullOrEmpty(displayName))
                _displayName = displayName;
            // Is script (i.e. statements rather than an expression):
            _isScript = isScript;
            // Text value/Text mode (valid for non-scripts only), if we cannot figure it out assume false:
            bool? isExpression;
            _text = Util.ScriptValueHelper.ObjectToText(value, out isExpression);
            if (!isExpression.HasValue && propOwner is Field)
                isExpression = ((Field)propOwner).Calculated;
            if (isExpression.HasValue && !isExpression.Value)
                IsTextMode = true; // this will throw exception if IsScript
            //
            _propOwner = propOwner;
            _propName = propName;
            _context = context;
        }
        #endregion

        #region Publics
        /// <summary>
        /// Returns true for the GlobalScripts item, false for all others.
        /// </summary>
        public bool IsGlobal
        {
            get { return Key == c_globalScriptsKey; }
        }
        public override string ToString()
        {
            return _displayName;
        }
        /// <summary>
        /// Updates the item's key to ensure the item sorts at the top of all others.
        /// </summary>
        public void EnsureTopKey()
        {
            System.Diagnostics.Debug.Assert(!_key.StartsWith("0-"));
            _key = "0-" + _key; // 0- sorts higher than 0_
        }
        /// <summary>
        /// Gets a value indicating whether the item can be synax-checked.
        /// Returns false for items in text mode.
        /// </summary>
        /// <param name="asExpression">OUT: true indicates that the item is an expression rather than a script.</param>
        /// <returns>True if the item can be syntax-checked, false otherwise.</returns>
        public bool CanSyntaxCheck(out bool asExpression)
        {
            if (_context.ContextKind == ScriptEditorContextKind.DataView)
            {
                asExpression = false;
                return false;
            }
            else
            {
                asExpression = !IsScript;
                return !_isTextMode;
            }
        }
        /// <summary>
        /// Converts the passed text to the owner property type, and writes it back to the owner property.
        /// The passed text and the converted value are cached in <see cref="Text"/> and <see cref="Value"/> properties.
        /// </summary>
        /// <param name="text">The item text.</param>
        public void WriteValue(string text)
        {
            _text = text;
            //
            var prop = _propOwner.GetType().GetProperty(_propName);
            var value = Util.ScriptValueHelper.TextToObject(_text, prop.PropertyType, !IsTextMode);
            prop.SetValue(_propOwner, value, null);
            // Save actual written value (used by UITypeEditor to determine whether the value has changed):
            _value = value;
        }
        #endregion

        #region Privates
        /// <summary>
        /// The heart of the matter.
        /// Generates human-readable item name (shown in the editor's caption etc),
        /// and a unique key used to identify the item. Same item must have the same key.
        /// </summary>
        /// <param name="propertyOwner"></param>
        /// <param name="propertyName"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string MakeName(object propertyOwner, string propertyName, out string key)
        {
            // ordinal prefix form is "N_":
            string name;
            var type = propertyOwner.GetType();
            if (type == typeof(C1FlexReport))
            {
                name = string.Format("Report.{0}", propertyName);
                if (propertyName == "GlobalScripts")
                    key = c_globalScriptsKey;
                else
                    key = string.Format("2_report.{0}", propertyName);
            }
            else if (type == typeof(Section))
            {
                var s = (Section)propertyOwner;
                name = string.Format("{0}.{1}", s.Name, propertyName);
                key = string.Format("3_sections[{0}].{1}", (int)s.Type, propertyName);
            }
            else if (type.IsSubclassOf(typeof(FieldBase)))
            {
                var f = (FieldBase)propertyOwner;
                string sName;
                int fIndex;
                if (f.Section >= 0 && f.ParentReport != null)
                {
                    var s = f.ParentReport.Sections[f.Section];
                    sName = s.Name;
                    fIndex = s.Fields.IndexOf(f);
                }
                else
                {
                    sName = "<no section>";
                    fIndex = -1;
                }
                name = string.Format("{0}.{1}.{2}", sName, f.Name, propertyName);
                key = string.Format("4_sections[{0}].fields[{1}].{2}", (int)f.Section, fIndex, propertyName);
            }
            else if (type == typeof(ReportParameter))
            {
                var p = (ReportParameter)propertyOwner;
                name = string.Format("ReportParameters.{0}.{1}", p.Name, propertyName);
                key = string.Format("5_parameters[{0}].{1}", p.Owner.IndexOf(p), propertyName);
            }
            else if (type == typeof(DataSource))
            {
                var ds = (DataSource)propertyOwner;
                name = string.Format("DataSource {0}: {1}", ds.Name, propertyName);
                key = string.Format("6_datasources[{0}].{1}", ds.ParentReport.DataSources.IndexOf(ds), propertyName);
            }
            else if (type == typeof(CalculatedField))
            {
                var cf = (CalculatedField)propertyOwner;
                name = string.Format("DataSource {0}: CalculatedFields.{1}.{2}", cf.DataSource.Name, cf.Name, propertyName);
                key = string.Format("7_datasources[{0}].calculatedfields[{1}].{2}", cf.DataSource.ParentReport.DataSources.IndexOf(cf.DataSource), cf.Owner.IndexOf(cf), propertyName);
            }
            else if (type == typeof(SortDefinition))
            {
                var sd = (SortDefinition)propertyOwner;
                var ds = sd.Owner.Owner;
                var seIdx = sd.Owner.IndexOf(sd);
                name = string.Format("DataSource {0}: Sort {1}.{2}", ds.Name, seIdx, propertyName);
                key = string.Format("8_datasources[{0}].sorts[{1}].{2}", ds.ParentReport.DataSources.IndexOf(ds), seIdx, propertyName);
            }
            else
            {
                const string self = "c1.win.flexreport.";
                var objName = propertyOwner.ToString().Trim();
                if (objName.Contains(" ") || objName.Length > 64)
                    objName = type.Name;
                if (objName.ToLower().StartsWith(self))
                    objName = objName.Substring(self.Length);

                name = string.Format("{0}.{1}", objName, propertyName);
                key = string.Format("0_unknown.{0}.{1}", type, propertyName);
            }
            return name;
        }
        #endregion
    }

    /// <summary>
    /// Represents the collection of script items accessible/editable from a run of script editor form.
    /// The list is built by the form and is filled with the standard items by the ctor.
    /// If the specific item that the script editor form was called to edit is not in the list,
    /// it is added to the collection for that run of the editor.
    /// </summary>
    public class EditorScriptItemCollection : SortedDictionary<string, EditorScriptItem>
    {
        public EditorScriptItemCollection(C1FlexReport report, EditorScriptContextCollection contexts, C1FlexReportDesigner designer)
        {
            var ctxtName = EditorScriptContextBase.MakeContextName(report.DataSourceName, ScriptEditorContextKind.ReportScript);
            var context = contexts.GetContext(ctxtName);

            Action<EditorScriptItem> addScriptItem = (si_) => this.Add(si_.Key, si_);

            // global script:
            addScriptItem(EditorScriptItem.FromObjectProperty(report, "GlobalScripts", context, true));

            // report event handlers:
            addScriptItem(EditorScriptItem.FromObjectProperty(report, "OnOpen", context, true));
            addScriptItem(EditorScriptItem.FromObjectProperty(report, "OnClose", context, true));
            addScriptItem(EditorScriptItem.FromObjectProperty(report, "OnNoData", context, true));
            addScriptItem(EditorScriptItem.FromObjectProperty(report, "OnPage", context, true));
            addScriptItem(EditorScriptItem.FromObjectProperty(report, "OnError", context, true));

            // Sections' event handlers:
            foreach (Section s in report.Sections)
            {
                addScriptItem(EditorScriptItem.FromObjectProperty(s, "OnFormat", context, true));
                addScriptItem(EditorScriptItem.FromObjectProperty(s, "OnPrint", context, true));
            }

            // Report fields' expressions:
            foreach (FieldBase f in report.Fields)
            {
                ScriptEditorExpressionInfo fieldEditorInfo = designer.GetScriptEditorExpressionInfo(f);
                if (fieldEditorInfo != null)
                    addScriptItem(EditorScriptItem.FromObjectProperty(f, fieldEditorInfo.PropertyName, context, false));
            }
        }
    }
}
