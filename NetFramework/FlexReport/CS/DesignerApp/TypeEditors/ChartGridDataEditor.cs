//----------------------------------------------------------------------------
// ChartGridDataEditor.cs
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
using C1.Win.FlexReport.Chart;
using C1.Win.FlexReport.FlexDesigner;
using C1Chart3D = C1.Win.C1Chart3D;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ChartGridDataEditor : UITypeEditor
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
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return base.GetEditStyle(context);

            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return base.EditValue(context, provider, value);
            
            var set = instance as Chart3DDataSetGrid;
            if (set == null) return base.EditValue(context, provider, value);

            var c1Set = CreateSet(set);
            var c1Property = TypeDescriptor.GetProperties(c1Set)["GridData"];
            var c1Editor = c1Property.GetEditor(typeof(UITypeEditor)) as UITypeEditor;
            if (c1Editor == null) return base.EditValue(context, provider, value);

            var c1Context = new ContextWrapper(context, c1Set, c1Property);
            var c1Values = c1Editor.EditValue(c1Context, provider, c1Set.GridData);

            object newValue = value;
            if (c1Context.ComponentChanged)
            {
                newValue = c1Values;
                context.OnComponentChanged();
            }

            return newValue;
        }

        private C1Chart3D.Chart3DDataSetGrid CreateSet(Chart3DDataSetGrid set)
        {
            var group = set.GetChartGroup();
            if (group == null) return null;

            var data = group.ChartData;
            var c1Chart = new C1Chart3D.C1Chart3D();
            var c1Group = c1Chart.ChartGroups.Group0;
            var c1Data = c1Group.ChartData;

            c1Data.Layout = C1Chart3D.DataLayoutEnum.GridData;

            var values = set.GridData ?? new double[0, 0];
            var c1Set = new C1Chart3D.Chart3DDataSetGrid(0, 0, 1, 1, values);
            c1Set.Hole = data.Hole;
            c1Data.SetGrid = c1Set;

            return c1Set;
        }
    }
}
