//----------------------------------------------------------------------------
// ChartFieldAxisCompassConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.ComponentModel;
using C1.Win.FlexReport;
using C1.Win.FlexReport.Chart;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ChartFieldAxisCompassConverter:EnumConverter
    {
        public ChartFieldAxisCompassConverter() : base(typeof (ChartCompass))
        {
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            var selection = MainForm.TheMainForm.FlexDesigner.SelectedFields;
            if (selection == null || selection.Count != 1)
                return base.GetStandardValues(context);

            var chart = selection[0] as ChartField;
            if (chart == null)
                return base.GetStandardValues(context);

            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return base.GetStandardValues(context);

            var axis = instance as Chart2DAxis;
            if (axis == null)
                return base.GetStandardValues(context);

            var group = chart.ChartGroups2D.Group0;
            var isCircular = group.ChartType == Chart2DType.Polar || group.ChartType == Chart2DType.Radar;
            var isVirtical = axis.Compass == ChartCompass.East ||
                             axis.Compass == ChartCompass.West;
            if (!isCircular)
            {
                return isVirtical
                    ? new StandardValuesCollection(new[] {ChartCompass.East, ChartCompass.West})
                    : new StandardValuesCollection(new[] {ChartCompass.North, ChartCompass.South});
            }

            return base.GetStandardValues(context);
        }
    }
}
