//----------------------------------------------------------------------------
// ChartFieldCollectionEditors.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI;
using System.Windows.Forms;
using C1.Util.DX.DirectWrite;
using C1.Win.FlexReport;
using C1.Win.FlexReport.Chart;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ChartObjectCollectionEditor : CollectionEditor
    {
        private ChartField _chart;
        private bool _canceled;

        public ChartObjectCollectionEditor(Type type) : base(type)
        {
        }

        protected override CollectionForm CreateCollectionForm()
        {
            CollectionForm cf = base.CreateCollectionForm();

            var ctrls = cf.Controls.Find("propertyBrowser", true);
            if (ctrls != null && ctrls.Length > 0)
            {
                var propGrid = (PropertyGrid) ctrls[0];
                propGrid.HelpVisible = true;
                propGrid.SelectedObjectsChanged += propGrid_SelectedObjectsChanged;
            }

            return cf;
        }

        void propGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {
            var propGrid = sender as PropertyGrid;
            if(SupportWrapSelectedObject())
                propGrid.SelectedObject = WrapSelectedObject(propGrid.SelectedObject);
        }

        protected virtual bool SupportUndo()
        {
            return true;
        }

        protected virtual bool SupportWrapSelectedObject()
        {
            return false;
        }

        protected virtual object WrapSelectedObject(object obj)
        {
            return obj;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            var selection = MainForm.TheMainForm.FlexDesigner.SelectedFields;
            if (selection != null && selection.Count == 1)
            {
                _chart = selection[0] as ChartField;
                if(_chart!=null)
                    return UITypeEditorEditStyle.Modal;
            }
            return UITypeEditorEditStyle.None;
        }

        protected override void CancelChanges()
        {
            base.CancelChanges();
            _canceled = true;
        }

        protected virtual object SaveState(object value)
        {
            var list = value as IList;
            if (list == null) return null;

            var state = new List<object>();
            foreach (var item in list)
            {
                var chartObject = item as ChartObject;
                if(chartObject!=null)
                    state.Add(chartObject.Clone());
            }
            return state;
        }

        protected virtual void RestoreState(object value, object state)
        {
            if (state == null) return;
            var stateList = state as IList;
            if (stateList == null) return;

            var list = value as IList;
            list.Clear();
            foreach (var item in stateList)
            {
                list.Add(item);
            }
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var state = SaveState(value);
            _canceled = false;
            _chart.BeginUpdate();

            object undostate = null;
            if (SupportUndo())
            {
                try
                {
                    undostate = MainForm.TheMainForm.FlexDesigner.Undo_CreateSavedState();
                }
                catch
                {
                    // only one level undo sate could be saved.
                }
            }

            object result;
            try
            {
                result = base.EditValue(context, provider, value);
            }
            catch (Exception)
            {
                RestoreState(value, state);
                if (undostate != null)
                    MainForm.TheMainForm.FlexDesigner.Undo_DiscardSavedState(undostate);
                _chart.EndUpdate(false);

                throw;
            }

            if (_canceled)
            {
                RestoreState(value, state);

                if(undostate!=null)
                    MainForm.TheMainForm.FlexDesigner.Undo_DiscardSavedState(undostate);
            }
            else
            {
                if(undostate!=null)
                    MainForm.TheMainForm.FlexDesigner.Undo_PushSavedState(undostate);
            }

            _chart.EndUpdate(!_canceled);

            return result;
        }
    }

    internal class ChartLabelsCollectionEditor : ChartObjectCollectionEditor
    {
        public ChartLabelsCollectionEditor() : base(typeof(ChartLabelsCollection))
        {
        }

        protected override bool SupportWrapSelectedObject()
        {
            return true;
        }

        protected override object WrapSelectedObject(object obj)
        {
            if (obj is ChartLabel)
            {
                return EditorsHelper.CreateInstanceModel(obj, MainForm.TheMainForm.DesignerHostServices);
            }


            return obj;
        }
    }

    internal class Chart2DValueLabelsCollectionEditor : ChartObjectCollectionEditor
    {
        public Chart2DValueLabelsCollectionEditor() : base(typeof (Chart2DValueLabelsCollection))
        {
        }
    }

    internal class ChartAlarmZonesCollectionEditor : ChartObjectCollectionEditor
    {
        public ChartAlarmZonesCollectionEditor()
            : base(typeof(ChartAlarmZonesCollection))
        {
        }
    }

    internal class ChartDataGroupsCollectionEditor : ChartObjectCollectionEditor
    {
        public ChartDataGroupsCollectionEditor() : base(typeof (ChartDataGroupsCollection))
        {
        }
    }

    internal class ChartDataValuesCollectionEditor : ChartObjectCollectionEditor
    {
        public ChartDataValuesCollectionEditor() : base(typeof (ChartDataValuesCollection))
        {
        }

        protected override bool SupportUndo()
        {
            return false;
        }
    }

    internal class Chart3DValueLabelsCollectionEditor : ChartObjectCollectionEditor
    {
        public Chart3DValueLabelsCollectionEditor()
            : base(typeof(ChartValueLabelsCollection))
        {
        }
    }

    internal class Chart3DBarColorsCollectionEditor : ChartObjectCollectionEditor
    {
        public Chart3DBarColorsCollectionEditor()
            : base(typeof(Chart3DBarColorsCollection))
        {
        }
    }

    internal class Chart3DDataLabelsCollectionEditor : ChartObjectCollectionEditor
    {
        public Chart3DDataLabelsCollectionEditor()
            : base(typeof(Chart3DDataLabelsCollection))
        {
        }
    }

    internal class ChartDataSeriesCollectionEditor : ChartObjectCollectionEditor
    {
        public ChartDataSeriesCollectionEditor() : base(typeof (ChartDataSeriesCollection))
        {
        }

        protected override bool SupportWrapSelectedObject()
        {
            return true;
        }

        protected override object WrapSelectedObject(object obj)
        {
            if (obj is ChartDataSeries)
            {
                return EditorsHelper.CreateInstanceModel(obj, MainForm.TheMainForm.DesignerHostServices);
            }
            return obj;
        }
    }

    internal class ChartUnboundDataSeriesCollectionEditor : ChartObjectCollectionEditor
    {
        public ChartUnboundDataSeriesCollectionEditor()
            : base(typeof(ChartUnboundDataSeriesCollection))
        {
        }

        protected override bool SupportWrapSelectedObject()
        {
            return true;
        }

        protected override object WrapSelectedObject(object obj)
        {
            if (obj is ChartUnboundDataSeries)
            {
                return EditorsHelper.CreateInstanceModel(obj, MainForm.TheMainForm.DesignerHostServices);
            }
            return obj;
        }
    }

    internal class ChartVisualEffectsStylesCollectionEditor : ChartObjectCollectionEditor
    {
        public ChartVisualEffectsStylesCollectionEditor()
            : base(typeof(ChartVisualEffectsStylesCollection))
        {
        }

        protected override object SaveState(object value)
        {
            var chart = new ChartField();
            AssignVisualEffectsStyles(value as ChartVisualEffectsStylesCollection, chart.VisualEffects.Styles);
            return chart.VisualEffects.Styles;
        }

        protected override void RestoreState(object value, object state)
        {
            AssignVisualEffectsStyles(state as ChartVisualEffectsStylesCollection,
                value as ChartVisualEffectsStylesCollection);
        }

        private void AssignVisualEffectsStyles(ChartVisualEffectsStylesCollection src,
            ChartVisualEffectsStylesCollection des)
        {
            if (src == null || des == null)
                return;

            foreach (var srcStyle in src)
            {
                var desStyle = des[srcStyle.Name];
                if (desStyle != null)
                {
                    desStyle.AssignFrom(srcStyle);
                }
            }
        }
    }

    internal class Chart3DColorsCollectionEditor : ChartObjectCollectionEditor
    {
        public Chart3DColorsCollectionEditor()
            : base(typeof(Chart3DColorsCollection))
        {
        }

        protected override object SaveState(object value)
        {
            var colors = value as Chart3DColorsCollection;
            if (colors == null) return null;
            return colors.Cast<Color>().ToList();
        }

        protected override void RestoreState(object value, object state)
        {
            var colors = value as Chart3DColorsCollection;
            var list = state as List<Color>;
            if (colors == null || list == null) return;

            colors.Clear();
            foreach (var color in list)
            {
                colors.Add(color);
            }
        }
    }

    internal class Chart3DPointsCollectionEditor : ChartObjectCollectionEditor
    {
        public Chart3DPointsCollectionEditor()
            : base(typeof(Chart3DPointsCollection))
        {
        }
    }

    internal class Chart3DPointSeriesCollectionEditor : ChartObjectCollectionEditor
    {
        public Chart3DPointSeriesCollectionEditor()
            : base(typeof(Chart3DPointSeriesCollection))
        {
        }

        protected override bool SupportWrapSelectedObject()
        {
            return true;
        }

        protected override object WrapSelectedObject(object obj)
        {
            if (obj is Chart3DPointSeries)
            {
                return EditorsHelper.CreateInstanceModel(obj, MainForm.TheMainForm.DesignerHostServices);
            }
            return obj;
        }
    }
}
