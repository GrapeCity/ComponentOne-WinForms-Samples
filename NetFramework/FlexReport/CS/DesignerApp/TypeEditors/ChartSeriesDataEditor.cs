//----------------------------------------------------------------------------
// ChartSeriesDataEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.FlexReport.FlexDesigner;
using C1Chart = C1.Win.C1Chart;
using C1.Win.FlexReport.Chart;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ChartSeriesDataEditor : UITypeEditor
    {
        private class ContextWrapper : ITypeDescriptorContext
        {
            private readonly ITypeDescriptorContext _baseContext;
            private readonly object _instance;
            private readonly PropertyDescriptor _property;

            public ContextWrapper(ITypeDescriptorContext baseContext, object instance, PropertyDescriptor property)
            {
                _baseContext = baseContext;
                _instance = instance;
                _property = property;
            }

            public bool ComponentChanged { get; private set; }

            public object GetService(Type serviceType)
            {
                return _baseContext.GetService(serviceType);
            }

            public bool OnComponentChanging()
            {
                return _baseContext.OnComponentChanging();
            }

            public void OnComponentChanged()
            {
                ComponentChanged = true;
            }

            public IContainer Container { get { return _baseContext.Container; } }
            public object Instance { get { return _instance; } }
            public PropertyDescriptor PropertyDescriptor { get { return _property; } }
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return base.EditValue(context, provider, value);

            var series = instance as ChartUnboundDataSeries;
            if (context.PropertyDescriptor == null || series == null)
                return base.EditValue(context, provider, value);

            var propertyName = context.PropertyDescriptor.Name;
            Debug.Assert(propertyName == "SeriesData" || propertyName == "X"
                         || propertyName == "Y" || propertyName == "Y1"
                         || propertyName == "Y2" || propertyName == "Y3");

            var c1Series = CreateChartDataSeries(series);
            var c1Property = TypeDescriptor.GetProperties(c1Series)[propertyName];
            object c1Value = c1Property.GetValue(c1Series);
            var c1Editor = c1Property.GetEditor(typeof (UITypeEditor)) as UITypeEditor;
            if (c1Editor == null) return base.EditValue(context, provider, value);

            var c1Context = new ContextWrapper(context, c1Series, c1Property);
            c1Editor.EditValue(c1Context, provider, c1Value);

            object newValue = value;
            if (c1Context.ComponentChanged)
            {
                ApplyData(c1Series, series, propertyName);
                context.OnComponentChanged();

                newValue = context.PropertyDescriptor.GetValue(series);
            }

            return newValue;
        }

        private C1Chart.ChartDataSeries CreateChartDataSeries(ChartUnboundDataSeries series)
        {
            var c1Chart = new C1Chart.C1Chart();
            var c1Group = c1Chart.ChartGroups.Group0;
            var c1Data = c1Group.ChartData;

            var group = series.GetChartGroup();
            if (group != null)
            {
                c1Group.ChartType = (C1.Win.C1Chart.Chart2DTypeEnum)group.ChartType;
                c1Data.Hole = group.ChartData.Hole;
            }

            var c1Series = c1Data.SeriesList.AddNewSeries();
            c1Series.X.CopyDataIn(series.X);
            c1Series.Y.CopyDataIn(series.Y);
            c1Series.Y1.CopyDataIn(series.Y1);
            c1Series.Y2.CopyDataIn(series.Y2);
            c1Series.Y3.CopyDataIn(series.Y3);

            return c1Series;
        }

        private void ApplyData(C1Chart.ChartDataSeries c1Series, ChartUnboundDataSeries series, string propertyNname)
        {
            var seriesData = propertyNname == "SeriesData";
            if (seriesData || propertyNname == "X")
                series.X = c1Series.X.CopyDataOut(typeof (double)) as double[];
            if (seriesData || propertyNname == "Y")
                series.Y = c1Series.Y.CopyDataOut(typeof (double)) as double[];
            if (seriesData || propertyNname == "Y1")
                series.Y1 = c1Series.Y1.CopyDataOut(typeof (double)) as double[];
            if (seriesData || propertyNname == "Y2")
                series.Y2 = c1Series.Y2.CopyDataOut(typeof (double)) as double[];
            if (seriesData || propertyNname == "Y3")
                series.Y3 = c1Series.Y3.CopyDataOut(typeof (double)) as double[];
        }
    }
}
