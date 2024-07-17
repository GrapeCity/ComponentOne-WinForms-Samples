//----------------------------------------------------------------------------
// MainForm_CreateField.cs
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
using System.Text;
using System.Windows.Forms;
using System.Collections;
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
using C1.Win.Localization;
using C1.Win.C1Command;

using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Doc = C1.Win.C1Document;
using Flex = C1.Win.FlexReport;

namespace FlexReportDesignerApp
{
    public partial class MainForm
    {
        private void flexDesigner_CreateField(object sender, C1.Win.FlexReport.CreateFieldEventArgs e)
        {
            // NOTE: currently add field buttons are used as the keys for inserting fields,
            // i.e. button.Tag/Action are not used. Might want to change that.

            RibbonItem btn = e.CreateFieldInfo as RibbonItem;
            FieldBase newField = null;
            string fldName = GetUniqueFieldName();

            Action<FieldBase> setFieldBaseProps = (field_) =>
                {
                    field_.Name = fldName;
                    field_.Left = e.FieldBounds.Left;
                    field_.Top = e.FieldBounds.Top;
                    field_.Width = e.FieldBounds.Width;
                    field_.Height = e.FieldBounds.Height;
                };

            // Select field type, create field:
            if (btn == rbtnFieldDataField)
            {
                TextField textField = new TextField();
                setFieldBaseProps(textField);
                e.SubSection.Fields.Add(textField);
                newField = textField;
                textField.Text = _createInfo != null ? ("=" + _createInfo) : string.Empty;
            }
            else if (btn == rbtnFieldCalculated)
            {
                TextField calcField = new TextField();
                setFieldBaseProps(calcField);
                e.SubSection.Fields.Add(calcField);
                CommonFields.SetupField(_flexDesigner.Report, calcField, _createInfo);
                newField = calcField;
            }
            else if (btn == rbtnFieldParagraph)
            {
                ParagraphField paraField = new ParagraphField();
                setFieldBaseProps(paraField);
                e.SubSection.Fields.Add(paraField);
                newField = paraField;
                paraField.Content.Add(_createInfo != null ? ("=" + _createInfo) : string.Empty);
            }
            else if (btn == rbtnFieldRtf)
            {
                RtfField rtfField = new RtfField();
                setFieldBaseProps(rtfField);
                e.SubSection.Fields.Add(rtfField);
                newField = rtfField;
                rtfField.Text = _createInfo != null ? ("=" + _createInfo) : string.Empty;
            }
            else if (btn == rbtnFieldCheckBox)
            {
                CheckBoxField cbField = new CheckBoxField();
                setFieldBaseProps(cbField);
                e.SubSection.Fields.Add(cbField);
                if (_createInfo != null)
                {
                    cbField.Value = "=" + _createInfo;
                    cbField.Text = _createInfo;
                }
                newField = cbField;
            }
            else if (btn == rbtnFieldChart)
            {
                ChartField chartField = new ChartField();
                setFieldBaseProps(chartField);
                e.SubSection.Fields.Add(chartField);
                newField = chartField;
            }
#if MAP
            else if (btn == rbtnFieldMap)
            {
                var mapField = new MapField();
                setFieldBaseProps(mapField);
                e.SubSection.Fields.Add(mapField);
                mapField.InitLayout();
                newField = mapField;
            }
#endif
            else if (btn == rbtnFieldBarCode)
            {
                BarCodeField barcodeField = new BarCodeField();
                setFieldBaseProps(barcodeField);
                e.SubSection.Fields.Add(barcodeField);
                barcodeField.Text = _createInfo != null ? ("=" + _createInfo) : "BARCODE";
                // barcodeField.BarCode = C1.Win.C1Document.BarCodeEnum.Code39x; // this was set as default in C1Report designer
                newField = barcodeField;
            }
            else if (btn == rbtnFieldPicture)
            {
                ImageField imageField = new ImageField();
                setFieldBaseProps(imageField);
                e.SubSection.Fields.Add(imageField);
                imageField.Picture = _createInfo;
                newField = imageField;
            }
            else if (btn == rbtnFieldShape)
            {
                ShapeField shapeField = new ShapeField();
                setFieldBaseProps(shapeField);
                e.SubSection.Fields.Add(shapeField);
                newField = shapeField;
            }
            else if (btn == rbtnFieldSubReport)
            {
                SubreportField subreportField = new SubreportField();
                setFieldBaseProps(subreportField);
                e.SubSection.Fields.Add(subreportField);
                foreach (ReportItem ri in _reportList.Items)
                {
                    if (ri.ToString() == _createInfo && ri.Report != _flexDesigner.Report)
                    {
                        subreportField.Subreport = ri.Report;
                        break;
                    }
                }
                newField = subreportField;
            }
            else if (btn == rbtnFieldLegacy)
            {
                Field legacyField = new Field();
                setFieldBaseProps(legacyField);
                e.SubSection.Fields.Add(legacyField);
                newField = legacyField;
            }
            else if (btn == rbtnFieldFlexChart)
            {
                FlexChartField flexChartField = new FlexChartField();
                setFieldBaseProps(flexChartField);
                flexChartField.Series.Add(new C1.Win.FlexReport.FlexChart.Series()
                {
                    Name = "DefaultSeries",
                    Label = "Count",
                    YExpression = "Count()"
                });
                e.SubSection.Fields.Add(flexChartField);
                newField = flexChartField;
            }
            else if (btn.Tag is Field) // custom field
            {
                Field customField = (Field)btn.Tag;
                setFieldBaseProps(customField);
                e.SubSection.Fields.Add(customField);
                newField = customField;
            }
            // else if (btn == rbtnFieldPageBreak) ....
            else
                System.Diagnostics.Debug.Assert(false, "unknown field insert op");

            // select the new field, zap creator
            _flexDesigner.UpdateFromReport();
            _flexDesigner.SelectField(newField, true, true);
            _flexDesigner.CreateFieldInfo = null;
            UpdateCreateFieldButtons(rbtnFieldArrow);
            UpdateUI(false);

            // update report list icons
            if (btn == rbtnFieldSubReport)
                _reportList.UpdateIcons();
        }

        private void DoCreateField(RibbonItem item)
        {
            if (item == rbtnFieldChart)
            {
                _flexDesigner.CreateFieldInfo = item;
                _createInfo = null;
            }
            else if (item == rbtnFieldFlexChart)
            {
                _flexDesigner.CreateFieldInfo = item;
                _createInfo = null;
            }
#if MAP
            else if(item == rbtnFieldMap)
            {
                _flexDesigner.CreateFieldInfo = item;
                _createInfo = null;
            }
#endif
            else if (item == rbtnFieldDataField || item == rbtnFieldRtf || item == rbtnFieldCheckBox || item == rbtnFieldBarCode ||
                item == rbtnFieldShape || item == rbtnFieldLegacy || item == rbtnFieldParagraph || item == rbtnFieldLegacy)
            {
                _flexDesigner.CreateFieldInfo = item;
                _createInfo = null;
            }
            else if (item == rbtnFieldCalculated)
            {
                ValueHolder valueHolder = new ValueHolder() { Value = string.Empty };
                var contextName = EditorScriptContextBase.MakeContextName(_flexDesigner.Report.DataSourceName, ScriptEditorContextKind.ReportScript);
                object result;
                if (EditScriptInternal(_flexDesigner.Report, contextName, null, valueHolder, "Value", Strings.MainForm.NewCalcFieldExprName, true, out result))
                {
                    _createInfo = valueHolder.Value;
                    if (!string.IsNullOrEmpty(_createInfo))
                        _flexDesigner.CreateFieldInfo = item;
                }
                else
                {
                    _flexDesigner.CreateFieldInfo = null;
                    item = rbtnFieldArrow; // to reset Pressed
                }
            }
            else if (item == rbtnFieldPicture)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.DereferenceLinks = true;
                    dlg.Filter = Strings.MainForm.OpenImageFilter;
                    dlg.FileName = "*.bmp;*.dib;*.ico;*.cur;*.gif;*.jpg;*.wmf;*.emf;*.png";
                    dlg.FilterIndex = 0;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        _createInfo = dlg.FileName;
                        _flexDesigner.CreateFieldInfo = rbtnFieldPicture;
                    }
                    else
                    {
                        _flexDesigner.CreateFieldInfo = null;
                        item = rbtnFieldArrow; // to reset Pressed
                    }
                }
            }
            else if (item.Parent is RibbonDropDownBase)
            {
                _flexDesigner.CreateFieldInfo = item.Parent;
                _createInfo = ((RibbonButton)item).Text;
            }
            else if (item.Tag is Field)
                _flexDesigner.CreateFieldInfo = item;

            // NO else here on purpose:
            if (item == rbtnFieldArrow)
            {
                _flexDesigner.CancelMouseOperation();
                _flexDesigner.CreateFieldInfo = null;
                _createInfo = null;
            }
            // We keep the button that caused the action pressed for the duration of adding the field
            // (i.e. while mouse cursor is a cross), while un-pressing all other items:
            UpdateCreateFieldButtons(item);
            //
            if (item != rbtnFieldArrow)
                _flexDesigner.DoCreateFieldWithMouse(_flexDesigner.CreateFieldInfo);
        }


        private void UpdateCreateFieldButtons(RibbonItem item)
        {
            // We keep the button that caused the action pressed for the duration of adding the field
            // (i.e. while mouse cursor is a cross), while un-pressing all other items:
            System.Collections.ArrayList fieldButtons = new ArrayList();
            fieldButtons.AddRange(rgFields.Items);
            fieldButtons.AddRange(rgCustomFields.Items);
            foreach (object ri in fieldButtons)
            {
                bool pressed = item != null && (ri == (object)item || ri == item.Parent);
                if (ri is RibbonSplitButton)
                    ((RibbonSplitButton)ri).Pressed = pressed;
                else if (ri is RibbonToggleButton)
                    ((RibbonToggleButton)ri).Pressed = pressed;
            }
        }
    }

    /// <summary>
    /// CommonFields: helper class used for building fields with often-used expressions
    /// </summary>
    internal class CommonFields
    {
        private static ListDictionary _fieldList;
        private static List<string> _fieldNames;

        static CommonFields()
        {
            // build special field list
            _fieldList = new ListDictionary();

            _fieldList.Add(Strings.CommonFields.DatePrinted, "Format(Now, \"Medium Date\")");
            _fieldList.Add(Strings.CommonFields.TimePrinted, "Format(Now, \"Medium Time\")");
            _fieldList.Add("- ", string.Empty); // << extra space to keep unique key
            _fieldList.Add(Strings.CommonFields.DateCreated, "=Format(Now, \"Medium Date\")");
            _fieldList.Add(Strings.CommonFields.TimeCreated, "=Format(Now, \"Medium Time\")");
            _fieldList.Add("-  ", string.Empty); // << extra space to keep unique key
            _fieldList.Add(Strings.CommonFields.PageNumber, "[Page]");
            _fieldList.Add(Strings.CommonFields.PageCount, "[Pages]");
            _fieldList.Add(Strings.CommonFields.PageNOfM, "\"Page \" & [Page] & \" of \" & [Pages]");
            _fieldList.Add("-   ", string.Empty); // << extra space to keep unique key
            _fieldList.Add(Strings.CommonFields.ReportName, "Report.ReportName");

            // build string array with field names
            _fieldNames = new List<string>(_fieldList.Count);
            foreach (string fieldName in _fieldList.Keys)
                _fieldNames.Add(fieldName.TrimEnd());
        }

        public static List<string> GetFieldNames()
        {
            return _fieldNames;
        }

        public static void SetupField(C1FlexReport report, TextField f, string createInfo)
        {
            // get expression
            if (createInfo != null && _fieldList.Contains(createInfo))
            {
                string expression = _fieldList[createInfo] as string;
                // System.Diagnostics.Debug.Assert(expression != null);


                // if the field expression starts with an equals sign, evaluate
                // the expression at creation time and store the value
                if (expression.StartsWith("="))
                {
                    f.Text = report.Evaluate(expression.Substring(1)).ToString();
                }
                else // otherwise, evaluate at render time
                {
                    f.Text = "=" + expression;
                }
            }
            else
            {
                // arbitrary formula:
                f.Text = ("=" + createInfo) ?? "data";
            }
        }
    }
}
