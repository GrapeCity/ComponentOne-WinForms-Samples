//----------------------------------------------------------------------------
// ChartFieldFilterExpressionEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ChartFieldFilterExpressionEditor : ScriptStringValueEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return UITypeEditorEditStyle.None;

            var chart = instance as ChartField;
            if(chart==null || string.IsNullOrEmpty(chart.DataSource))
                return UITypeEditorEditStyle.None;

            return base.GetEditStyle(ctx);
        }
    }

    internal class ChartFieldFilterExpressionConverter : ScriptStringValueConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext ctx, Type type)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return false;

            var chart = instance as ChartField;
            if (chart == null || string.IsNullOrEmpty(chart.DataSource)) return false;

            return base.CanConvertFrom(ctx, type);
        }
    }
}
