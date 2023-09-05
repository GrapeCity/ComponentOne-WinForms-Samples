//----------------------------------------------------------------------------
// EditorsHelper.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Globalization;

using C1.Win.FlexReport;
using C1.Win.FlexReport.Chart;
using C1.Win.FlexReport.CustomFields;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.TypeEditors;
using FlexReportDesignerApp.TypeEditors.CustomMapField;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.C1Document;
using Maps = C1.Win.FlexReport.CustomFields.Maps;
using FCF = C1.Win.FlexReport.FlexChart;

#if MAP
using FlexReportDesignerApp.TypeEditors.Map;
#endif

namespace FlexReportDesignerApp
{
    internal static class EditorsHelper
    {
        // Models in this collection are used as templates, duplicated for specific type instances
        // (which when no longer needed just go out of scope).
        private static Dictionary<Type, EditableModel> s_typeModels = new Dictionary<Type, EditableModel>();

        public static void SetServicesOwner(FlexDesignerHostServices owner)
        {
            foreach (var model in s_typeModels.Values)
                model.Services = owner;
        }

        static EditorsHelper()
        {
            var aNullableColorEditor = new EditorAttribute(typeof(NullableColorEditor), typeof(UITypeEditor));
            var aExpandableConverter = new TypeConverterAttribute(typeof(ExpandableObjectModelConverter));
            var aHideProperty = new BrowsableAttribute(false);
            var aShowProperty = new BrowsableAttribute(true);
            var aStatementEditor = new EditorAttribute(typeof(StatementEditor), typeof(UITypeEditor));
            var aExpressionEditor = new EditorAttribute(typeof(ExpressionEditor), typeof(UITypeEditor));
            var aReportListTypeConverter = new TypeConverterAttribute(typeof(SubreportFieldConverter));
            var aExpandableObjectConverter = new TypeConverterAttribute(typeof(ExpandableObjectConverter));
            var aPictureHolderEditor = new EditorAttribute(typeof(PictureHolderEditor), typeof(UITypeEditor));
            var aFieldPictureHolderEditor = new EditorAttribute(typeof(FieldPictureHolderEditor), typeof(UITypeEditor));
            var aChartObjectPictureHolderEditor = new EditorAttribute(typeof (ChartObjectPictureHolderEditor),
                typeof (UITypeEditor));
            var aBackgroundEditor = new EditorAttribute(typeof(BackgroundEditor), typeof(UITypeEditor));
            var aBackgroundConverter = new TypeConverterAttribute(typeof(BackgroundConverter));
            var aScriptValueConverter = new TypeConverterAttribute(typeof(ScriptStringValueConverter));
            var aScriptValueEditor = new EditorAttribute(typeof(ScriptStringValueEditor), typeof(UITypeEditor));
            var aTextAlignEditor = new EditorAttribute(typeof(TextAlignEditor), typeof(UITypeEditor));
            var aPictureAlignEditor = new EditorAttribute(typeof(PictureAlignEditor), typeof(UITypeEditor));
            var aOutlineParentEditor = new EditorAttribute(typeof(OutlineParentEditor), typeof(UITypeEditor));
            var aChartDataSourceConverter = new TypeConverterAttribute(typeof(ChartDataSourceConverter));
            var aFormatConverter = new TypeConverterAttribute(typeof(FormatConverter));
            var aAllowedValuesEditor = new EditorAttribute(typeof(AllowedValuesDefinitionEditor), typeof(UITypeEditor));
            var aAllowedValuesConverter = new TypeConverterAttribute(typeof(AllowedValuesDefinitionConverter));
            var aParameterValueEditor = new EditorAttribute(typeof(ParameterValueEditor), typeof(UITypeEditor));
            var aParameterValueConverter = new TypeConverterAttribute(typeof(ParameterValueConverter));
            var aCalculatedFieldTypeConverter = new TypeConverterAttribute(typeof(CalculatedFieldTypeConverter));
            var aBorderEditor = new EditorAttribute(typeof(BorderEditor), typeof(UITypeEditor));
            var aDataSourceConverter = new TypeConverterAttribute(typeof(DataSourceConverter));
            var aDataSourceEditor = new EditorAttribute(typeof(DataSourceEditor), typeof(UITypeEditor));
            var aShapeConverter = new TypeConverterAttribute(typeof(ShapeConverter));
            var aReportLinkTargetConverter = new TypeConverterAttribute(typeof(ReportLinkTargetConverter));
            var aCategoryGrouping = new CategoryAttribute(Strings.GroupEditorForm.GroupingCagetory);
            var aReportParameterValuesEditor = new EditorAttribute(typeof (ReportParameterValuesEditor), typeof (UITypeEditor));
            var aChartDataSeriesCollectionEditor = new EditorAttribute(typeof(ChartDataSeriesCollectionEditor), typeof(UITypeEditor));
            var aChartLabelsCollectionEditor = new EditorAttribute(typeof (ChartLabelsCollectionEditor), typeof (UITypeEditor));
            var aChart2DValueLabelsCollectionEditor = new EditorAttribute(typeof (Chart2DValueLabelsCollectionEditor), typeof (UITypeEditor));
            var aChartAlarmZonesCollectionEditor = new EditorAttribute(typeof (ChartAlarmZonesCollectionEditor), typeof (UITypeEditor));
            var aChartDataGroupsCollectionEditor = new EditorAttribute(typeof (ChartDataGroupsCollectionEditor), typeof (UITypeEditor));
            var aChartDataValuesCollectionEditor = new EditorAttribute(typeof (ChartDataValuesCollectionEditor), typeof (UITypeEditor));
            var aChart3DValueLabelsCollectionEditor = new EditorAttribute(typeof (Chart3DValueLabelsCollectionEditor), typeof (UITypeEditor));
            var aChart3DBarColorsCollectionEditor = new EditorAttribute(typeof (Chart3DBarColorsCollectionEditor), typeof (UITypeEditor));
            var aChart3DDataLabelsCollectionEditor = new EditorAttribute(typeof(Chart3DDataLabelsCollectionEditor), typeof (UITypeEditor));
            var aChartVisualEffectsStylesCollectionEditor = new EditorAttribute(typeof (ChartVisualEffectsStylesCollectionEditor), typeof (UITypeEditor));
            var aChart3DColorsCollectionEditor = new EditorAttribute(typeof (Chart3DColorsCollectionEditor), typeof (UITypeEditor));
            var aChartFilterExpressionConverter = new TypeConverterAttribute(typeof(ChartFieldFilterExpressionConverter));
            var aChartFilterExpressionEditor = new EditorAttribute(typeof(ChartFieldFilterExpressionEditor), typeof(UITypeEditor));
            var aChartAxisCompassConverter = new TypeConverterAttribute(typeof (ChartFieldAxisCompassConverter));
            var aChart3DPointsCollectionEditor = new EditorAttribute(typeof(Chart3DPointsCollectionEditor), typeof(UITypeEditor));
            var aChart3DPointSeriesCollectionEditor = new EditorAttribute(typeof(Chart3DPointSeriesCollectionEditor), typeof(UITypeEditor));
            var aChartUnboundDataSeriesCollectionEditor = new EditorAttribute(typeof(ChartUnboundDataSeriesCollectionEditor), typeof(UITypeEditor));
            var aChartSeriesDataEditor = new EditorAttribute(typeof(ChartSeriesDataEditor), typeof(UITypeEditor));
            var aChartGridDataEditor = new EditorAttribute(typeof(ChartGridDataEditor), typeof(UITypeEditor));
#if MAP
            var aReadonlyProperty = new ReadOnlyAttribute(true);
            var aMapDoubleConverter = new TypeConverterAttribute(typeof(MapDoubleConverter));
            var aMapLayersCollectionEditor = new EditorAttribute(typeof(MapLayersCollectionEditor), typeof(UITypeEditor));
            var aMapLegendsCollectionEditor = new EditorAttribute(typeof(MapLegendsCollectionEditor), typeof(UITypeEditor));
            var aMapLegendItemsCollectionEditor = new EditorAttribute(typeof(MapLegendItemsCollectionEditor), typeof(UITypeEditor));
            var aMapVectorTemplatesCollectionEditor = new EditorAttribute(typeof(MapVectorTemplatesCollectionEditor), typeof(UITypeEditor));
            var aMapPointTemplatesCollectionEditor = new EditorAttribute(typeof(MapPointTemplatesCollectionEditor), typeof(UITypeEditor));
            var aMapClusterPointTemplatesCollectionEditor = new EditorAttribute(typeof(MapClusterPointTemplatesCollectionEditor), typeof(UITypeEditor));
            var aMapLineTemplatesCollectionEditor = new EditorAttribute(typeof(MapLineTemplatesCollectionEditor), typeof(UITypeEditor));
            var aMapPolygonTemplatesCollectionEditor = new EditorAttribute(typeof(MapPolygonTemplatesCollectionEditor), typeof(UITypeEditor));
            var aMapSpatialElementsCollectionEditor = new EditorAttribute(typeof(MapSpatialElementsCollectionEditor), typeof(UITypeEditor));
            var aMapMarkersCollectionEditor = new EditorAttribute(typeof(MapMarkersCollectionEditor), typeof(UITypeEditor));
            var aMapDataFieldsCollectionEditor = new EditorAttribute(typeof(MapDataFieldsCollectionEditor), typeof(UITypeEditor));
            var aMapTileProviderConverter = new TypeConverterAttribute(typeof(MapTileProviderConverter));
            var aMapSpatialDataConverter = new TypeConverterAttribute(typeof (MapSpatialDataConverter));
            var aMapCoordinateSystemConverter = new TypeConverterAttribute(typeof (MapCoordinateSystemConverter));
            var aMapVectorDataConverter = new TypeConverterAttribute(typeof(MapVectorDataConverter));
            var aMapLayerDataConverter = new TypeConverterAttribute(typeof (MapLayerDataConverter));
            var aMapColorRuleConverter = new TypeConverterAttribute(typeof(MapColorRuleConverter));
            var aMapScriptValueEditor = new EditorAttribute(typeof (TypeEditors.Map.ScriptValueEditor), typeof (UITypeEditor));
            var aMapScriptBoolEditor = new EditorAttribute(typeof(TypeEditors.Map.ScriptBoolValueEditor), typeof(UITypeEditor));
            var aMapScriptTemplateKeyEditor = new EditorAttribute(typeof(TypeEditors.Map.ScriptTemplateKeyEditor), typeof(UITypeEditor));
            var aMapScriptDataSourceNameEditor = new EditorAttribute(typeof(TypeEditors.Map.ScriptDataSourceNameEditor), typeof(UITypeEditor));
            var aMapScriptFileDataSourceEditor = new EditorAttribute(typeof(TypeEditors.Map.ScriptFileDataSourceEditor), typeof(UITypeEditor));
            var aMapLegendNameConverter = new TypeConverterAttribute(typeof(MapLegendNameConverter));
            var aMapRuleLegendTextConverter = new TypeConverterAttribute(typeof(MapRuleLegendTextConverter));
            var aMapCoordinatePatternConverter = new TypeConverterAttribute(typeof(MapCoordinatePatternConverter));
            var aMapGeoCachePathEditor = new EditorAttribute(typeof(MapGeoCachePathEditor), typeof(UITypeEditor));
            var aMapColorPaletteEditor = new EditorAttribute(typeof(MapColorPaletteEditor), typeof(UITypeEditor));
            var aMapReportHyperLinkConverter = new TypeConverterAttribute(typeof(MapReportHyperLinkConverter));
            var aMapReportLinkTargetConverter = new TypeConverterAttribute(typeof(MapReportLinkTargetConverter));
            var aMapDataFieldNameConverter = new TypeConverterAttribute(typeof(MapDataFieldNameConverter));
            var aMapLabelPositionEditor = new EditorAttribute(typeof(MapLabelPositionEditor), typeof(UITypeEditor));
            var aMapAnchorsEditor = new EditorAttribute(typeof(MapAnchorsEditor), typeof(UITypeEditor));
            var aMapBorderEditor = new EditorAttribute(typeof(MapBorderEditor), typeof(UITypeEditor));
#endif
            var aRightToLeftConverter = new TypeConverterAttribute(typeof(RightToLeftConverter));
            // not needed yet, so for future reference for now:
            // var aMultilineStringEditor = new EditorAttribute(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor));

            // C1FlexReport:
            var mC1FlexReport = EditableModel<C1FlexReport>.NewEditableModel();
            // unhide properties hidden in VS designer:
            mC1FlexReport.RegisterAttribute("AsyncMethodsUseAwaitPattern", aHideProperty);
            mC1FlexReport.RegisterAttribute("DoEvents", aHideProperty);
            mC1FlexReport.RegisterAttribute("Culture", aShowProperty);
            mC1FlexReport.RegisterAttribute("Font", aShowProperty);
            mC1FlexReport.RegisterAttribute("BehaviorOptions", aShowProperty);
            mC1FlexReport.RegisterAttribute("ReportInfo", aShowProperty);
            mC1FlexReport.RegisterAttribute("DataSource", aShowProperty);
            mC1FlexReport.RegisterAttribute("Layout", aShowProperty);
            mC1FlexReport.RegisterAttribute("MaxPages", aShowProperty);
            mC1FlexReport.RegisterAttribute("OnOpen", aShowProperty);
            mC1FlexReport.RegisterAttribute("OnClose", aShowProperty);
            mC1FlexReport.RegisterAttribute("OnNoData", aShowProperty);
            mC1FlexReport.RegisterAttribute("OnPage", aShowProperty);
            mC1FlexReport.RegisterAttribute("OnError", aShowProperty);
            mC1FlexReport.RegisterAttribute("GlobalScripts", aShowProperty);
            mC1FlexReport.RegisterAttribute("OutlineRootLevel", aShowProperty);
            mC1FlexReport.RegisterAttribute("GrowShrinkMode", aShowProperty);
            mC1FlexReport.RegisterAttribute("IgnoreScriptErrors", aShowProperty);
            mC1FlexReport.RegisterAttribute("ExposeScriptObjects", aShowProperty);
            mC1FlexReport.RegisterAttribute("RecordsPerPage", aShowProperty);
            mC1FlexReport.RegisterAttribute("Watermark", aShowProperty);
            mC1FlexReport.RegisterAttribute("Overlay", aShowProperty);
            mC1FlexReport.RegisterAttribute("RightToLeft", aShowProperty);
            mC1FlexReport.RegisterAttribute("RightToLeft", aRightToLeftConverter);
            //
            mC1FlexReport.RegisterAttribute("OnOpen", aStatementEditor);
            mC1FlexReport.RegisterAttribute("OnClose", aStatementEditor);
            mC1FlexReport.RegisterAttribute("OnNoData", aStatementEditor);
            mC1FlexReport.RegisterAttribute("OnPage", aStatementEditor);
            mC1FlexReport.RegisterAttribute("OnError", aStatementEditor);
            mC1FlexReport.RegisterAttribute("GlobalScripts", aStatementEditor);
            mC1FlexReport.RegisterAttribute("Watermark", aExpandableConverter);
            mC1FlexReport.RegisterAttribute("Overlay", aExpandableConverter);
            mC1FlexReport.RegisterAttribute("DataSource", aDataSourceConverter);
            mC1FlexReport.RegisterAttribute("DataSource", aDataSourceEditor);
            s_typeModels.Add(typeof(C1FlexReport), mC1FlexReport);
            // ====================== Watermark
            var mWatermark = EditableModel<Watermark>.NewEditableModel();
            mWatermark.RegisterAttribute("Picture", aPictureHolderEditor);
            mWatermark.RegisterAttribute("PictureAlign", aPictureAlignEditor);
            s_typeModels.Add(typeof(Watermark), mWatermark);
            // ====================== CheckMark
            var mCheckMark = EditableModel<CheckMark>.NewEditableModel();
            mCheckMark.RegisterAttribute("CheckedImage", aPictureHolderEditor);
            mCheckMark.RegisterAttribute("UncheckedImage", aPictureHolderEditor);
            mCheckMark.RegisterAttribute("IndeterminateImage", aPictureHolderEditor);
            s_typeModels.Add(typeof(CheckMark), mCheckMark);
            // ====================== Visuals
            // VisualReportObject - used only as template for derived types:
            var mVisual = EditableModel<VisualReportObject>.NewEditableModel();
            mVisual.RegisterAttribute("Background", aBackgroundEditor);
            mVisual.RegisterAttribute("Background", aBackgroundConverter);
            mVisual.RegisterAttribute("BackColor", aHideProperty);
            mVisual.RegisterAttribute("OutlineLabel", aScriptValueEditor);
            mVisual.RegisterAttribute("OutlineLabel", aScriptValueConverter);
            mVisual.RegisterAttribute("OutlineParent", aOutlineParentEditor);
            mVisual.RegisterAttribute("Border", aBorderEditor);
            mVisual.RegisterAttribute("Bookmark", aScriptValueEditor);
            mVisual.RegisterAttribute("Bookmark", aScriptValueConverter);
            s_typeModels.Add(typeof(VisualReportObject), mVisual);
            // Section:
            var mSection = EditableModel<Section>.NewEditableModel();
            mSection.RegisterAttribute("OnFormat", aStatementEditor);
            mSection.RegisterAttribute("OnPrint", aStatementEditor);
            mSection.RegisterAttribute("SubSections", aHideProperty);
            mSection.RegisterAttributesFromModel(mVisual);
            s_typeModels.Add(typeof(Section), mSection);
            // Sub-section:
            var mSubSection = EditableModel<SubSection>.NewEditableModel();
            mSubSection.RegisterAttribute("Calculated", aHideProperty);
            mSubSection.RegisterAttribute("Index", aHideProperty);
            mSubSection.RegisterAttribute("Fields", aHideProperty);
            mSubSection.RegisterAttribute("ParentSection", aHideProperty);
            mSubSection.RegisterAttributesFromModel(mVisual);
            s_typeModels.Add(typeof(SubSection), mSubSection);
            // ====================== FIELD types
            // FieldBase - used only as template for derived fields:
            var mFieldBase = EditableModel<FieldBase>.NewEditableModel();
            mFieldBase.RegisterAttribute("Hyperlink", aExpandableConverter);
            mFieldBase.RegisterAttribute("RightToLeft", aRightToLeftConverter);
            mFieldBase.RegisterAttributesFromModel(mVisual);
            s_typeModels.Add(typeof(FieldBase), mFieldBase);
            // BarcodeField:
            var mBarCodeField = EditableModel<BarCodeField>.NewEditableModel();
            mBarCodeField.RegisterAttribute("Text", aScriptValueEditor);
            mBarCodeField.RegisterAttribute("Text", aScriptValueConverter);
            mBarCodeField.RegisterAttribute("Align", aPictureAlignEditor);
            mBarCodeField.RegisterAttributesFromModel(mFieldBase);
            s_typeModels.Add(typeof(BarCodeField), mBarCodeField);
            // ChartField
            var mChartField = EditableModel<ChartField>.NewEditableModel();
            mChartField.RegisterAttribute("RightToLeft", aHideProperty);
            mChartField.RegisterAttributesFromModel(mFieldBase);
            mChartField.RegisterAttribute("AutoHeight", aHideProperty);
            mChartField.RegisterAttribute("AutoWidth", aHideProperty);
            mChartField.RegisterAttribute("DataSource", aChartDataSourceConverter);
            mChartField.RegisterAttribute("FilterExpression", aChartFilterExpressionConverter);
            mChartField.RegisterAttribute("FilterExpression", aChartFilterExpressionEditor);
            mChartField.RegisterAttribute("Header", aExpandableConverter);
            mChartField.RegisterAttribute("Footer", aExpandableConverter);
            mChartField.RegisterAttribute("ChartArea2D", aExpandableConverter);
            mChartField.RegisterAttribute("ChartArea3D", aExpandableConverter);
            mChartField.RegisterAttribute("ChartGroups2D", aExpandableConverter);
            mChartField.RegisterAttribute("ChartGroups3D", aExpandableConverter);
            mChartField.RegisterAttribute("ChartLabels", aExpandableConverter);
            mChartField.RegisterAttribute("VisualEffects", aExpandableConverter);
            s_typeModels.Add(typeof(ChartField), mChartField);
            // ChartTitle
            var mChartTitle = EditableModel<ChartTitle>.NewEditableModel();
            mChartTitle.RegisterAttribute("Image", aChartObjectPictureHolderEditor);
            s_typeModels.Add(typeof(ChartTitle), mChartTitle);
            // ChartVisualEffects
            var mChartVisualEffects = EditableModel<ChartVisualEffects>.NewEditableModel();
            mChartVisualEffects.RegisterAttribute("Styles", aChartVisualEffectsStylesCollectionEditor);
            s_typeModels.Add(typeof(ChartVisualEffects), mChartVisualEffects);
            // Chart2DArea
            var mChart2DArea = EditableModel<Chart2DArea>.NewEditableModel();
            mChart2DArea.RegisterAttribute("AxisX", aExpandableConverter);
            mChart2DArea.RegisterAttribute("AxisY", aExpandableConverter);
            mChart2DArea.RegisterAttribute("AxisY2", aExpandableConverter);
            mChart2DArea.RegisterAttribute("PlotArea", aExpandableConverter);
            s_typeModels.Add(typeof(Chart2DArea), mChart2DArea);
            // ChartLabels
            var mChartLabels = EditableModel<ChartLabels>.NewEditableModel();
            mChartLabels.RegisterAttribute("LabelsCollection", aChartLabelsCollectionEditor);
            s_typeModels.Add(typeof(ChartLabels), mChartLabels);
            // ChartLabel
            var mChartLabel = EditableModel<ChartLabel>.NewEditableModel();
            mChartLabel.RegisterAttribute("Image", aChartObjectPictureHolderEditor);
            s_typeModels.Add(typeof(ChartLabel), mChartLabel);
            // Chart2DAxis
            var mChart2DAxis = EditableModel<Chart2DAxis>.NewEditableModel();
            mChart2DAxis.RegisterAttribute("ValueLabels", aChart2DValueLabelsCollectionEditor);
            mChart2DAxis.RegisterAttribute("Compass", aChartAxisCompassConverter);
            s_typeModels.Add(typeof(Chart2DAxis), mChart2DAxis);
            // Chart2DPlotArea
            var mChart2DPlotArea = EditableModel<Chart2DPlotArea>.NewEditableModel();
            mChart2DPlotArea.RegisterAttribute("AlarmZones", aChartAlarmZonesCollectionEditor);
            s_typeModels.Add(typeof(Chart2DPlotArea), mChart2DPlotArea);
            // ChartGroups2D
            var mChartGroups2D = EditableModel<Chart2DGroups>.NewEditableModel();
            mChartGroups2D.RegisterAttribute("Group0", aExpandableConverter);
            mChartGroups2D.RegisterAttribute("Group1", aExpandableConverter);
            s_typeModels.Add(typeof(Chart2DGroups), mChartGroups2D);
            // Chart2DGroup
            var mChart2DGroup = EditableModel<Chart2DGroup>.NewEditableModel();
            mChart2DGroup.RegisterAttribute("Histogram", aExpandableConverter);
            mChart2DGroup.RegisterAttribute("ChartData", aExpandableConverter);
            s_typeModels.Add(typeof(Chart2DGroup), mChart2DGroup);
            // Chart2DData
            var mChart2DData = EditableModel<Chart2DData>.NewEditableModel();
            mChart2DData.RegisterAttribute("CategoryGroups", aChartDataGroupsCollectionEditor);
            mChart2DData.RegisterAttribute("SeriesGroups", aChartDataGroupsCollectionEditor);
            mChart2DData.RegisterAttribute("SeriesValues", aChartDataSeriesCollectionEditor);
            mChart2DData.RegisterAttribute("UnboundSeriesList", aChartUnboundDataSeriesCollectionEditor);
            s_typeModels.Add(typeof(Chart2DData), mChart2DData);
            // ChartDataSeries
            var mChartDataSeries = EditableModel<ChartDataSeries>.NewEditableModel();
            mChartDataSeries.RegisterAttribute("FillStyle", aExpandableConverter);
            mChartDataSeries.RegisterAttribute("DataValues", aChartDataValuesCollectionEditor);
            s_typeModels.Add(typeof(ChartDataSeries), mChartDataSeries);
            // ChartUnboundDataSeries
            var mChartUnboundDataSeries = EditableModel<ChartUnboundDataSeries>.NewEditableModel();
            mChartUnboundDataSeries.RegisterAttributesFromModel(mChartDataSeries);
            mChartUnboundDataSeries.RegisterAttribute("DataValues", aHideProperty);
            mChartUnboundDataSeries.RegisterAttribute("SeriesData", aChartSeriesDataEditor);
            mChartUnboundDataSeries.RegisterAttribute("X", aChartSeriesDataEditor);
            mChartUnboundDataSeries.RegisterAttribute("Y", aChartSeriesDataEditor);
            mChartUnboundDataSeries.RegisterAttribute("Y1", aChartSeriesDataEditor);
            mChartUnboundDataSeries.RegisterAttribute("Y2", aChartSeriesDataEditor);
            mChartUnboundDataSeries.RegisterAttribute("Y3", aChartSeriesDataEditor);
            s_typeModels.Add(typeof(ChartUnboundDataSeries), mChartUnboundDataSeries);
            // ChartHistogram
            var mChartHistogram = EditableModel<ChartHistogram>.NewEditableModel();
            mChartHistogram.RegisterAttribute("NormalDisplay", aExpandableConverter);
            s_typeModels.Add(typeof(ChartHistogram), mChartHistogram);
            // ChartNormalCurve
            var mChartNormalCurve = EditableModel<ChartNormalCurve>.NewEditableModel();
            mChartNormalCurve.RegisterAttribute("FillStyle", aExpandableConverter);
            s_typeModels.Add(typeof(ChartNormalCurve), mChartNormalCurve);
            // ChartFillStyle
            var mChartFillStyle = EditableModel<ChartFillStyle>.NewEditableModel();
            mChartFillStyle.RegisterAttribute("Image", aChartObjectPictureHolderEditor);
            s_typeModels.Add(typeof(ChartFillStyle), mChartFillStyle);
            // Chart3DArea
            var mChart3DArea = EditableModel<Chart3DArea>.NewEditableModel();
            mChart3DArea.RegisterAttribute("AxisX", aExpandableConverter);
            mChart3DArea.RegisterAttribute("AxisY", aExpandableConverter);
            mChart3DArea.RegisterAttribute("AxisZ", aExpandableConverter);
            s_typeModels.Add(typeof(Chart3DArea), mChart3DArea);
            // Chart3DAxis
            var mChart3DAxis = EditableModel<Chart3DAxis>.NewEditableModel();
            mChart3DAxis.RegisterAttribute("ValueLabels", aChart3DValueLabelsCollectionEditor);
            s_typeModels.Add(typeof(Chart3DAxis), mChart3DAxis);
            // ChartGroups3D
            var mChartGroups3D = EditableModel<Chart3DGroups>.NewEditableModel();
            mChartGroups3D.RegisterAttribute("Group0", aExpandableConverter);
            mChartGroups3D.RegisterAttribute("RowLabels", aChart3DDataLabelsCollectionEditor);
            mChartGroups3D.RegisterAttribute("ColumnLabels", aChart3DDataLabelsCollectionEditor);
            mChartGroups3D.RegisterAttribute("ContourStyles", aExpandableConverter);
            s_typeModels.Add(typeof(Chart3DGroups), mChartGroups3D);
            // Chart3DContourStyles
            var mChart3DContourStyles = EditableModel<Chart3DContourStyles>.NewEditableModel();
            mChart3DContourStyles.RegisterAttribute("Colors", aChart3DColorsCollectionEditor);
            s_typeModels.Add(typeof(Chart3DContourStyles), mChart3DContourStyles);
            // Chart3DGroup
            var mChart3DGroup = EditableModel<Chart3DGroup>.NewEditableModel();
            mChart3DGroup.RegisterAttribute("ChartData", aExpandableConverter);
            mChart3DGroup.RegisterAttribute("Bar", aExpandableConverter);
            s_typeModels.Add(typeof(Chart3DGroup), mChart3DGroup);
            // Chart3DBar
            var mChart3DBar = EditableModel<Chart3DBar>.NewEditableModel();
            mChart3DBar.RegisterAttribute("Colors", aChart3DBarColorsCollectionEditor);
            s_typeModels.Add(typeof(Chart3DBar), mChart3DBar);
            // Chart3DData
            var mChart3DData = EditableModel<Chart3DData>.NewEditableModel();
            mChart3DData.RegisterAttribute("CategoryGroups", aChartDataGroupsCollectionEditor);
            mChart3DData.RegisterAttribute("SeriesGroups", aChartDataGroupsCollectionEditor);
            mChart3DData.RegisterAttribute("SeriesValues", aChartDataSeriesCollectionEditor);
            mChart3DData.RegisterAttribute("UnboundData", aExpandableConverter);
            s_typeModels.Add(typeof(Chart3DData), mChart3DData);
            // Chart3DUnboundData
            var mChart3DUnboundData = EditableModel<Chart3DUnboundData>.NewEditableModel();
            mChart3DUnboundData.RegisterAttribute("GridSet", aExpandableConverter);
            mChart3DUnboundData.RegisterAttribute("PointSet", aExpandableConverter);
            s_typeModels.Add(typeof (Chart3DUnboundData), mChart3DUnboundData);
            // Chart3DDataSetGrid
            var mChart3DDataSetGrid = EditableModel<Chart3DDataSetGrid>.NewEditableModel();
            mChart3DDataSetGrid.RegisterAttribute("GridData", aChartGridDataEditor);
            s_typeModels.Add(typeof(Chart3DDataSetGrid), mChart3DDataSetGrid);
            // Chart3DDataSetPoint
            var mChart3DDataSetPoint = EditableModel<Chart3DDataSetPoint>.NewEditableModel();
            mChart3DDataSetPoint.RegisterAttribute("SeriesCollection", aChart3DPointSeriesCollectionEditor);
            s_typeModels.Add(typeof(Chart3DDataSetPoint), mChart3DDataSetPoint);
            // Chart3DPointSeries
            var mChart3DPointSeries = EditableModel<Chart3DPointSeries>.NewEditableModel();
            mChart3DPointSeries.RegisterAttribute("LineStyle", aExpandableConverter);
            mChart3DPointSeries.RegisterAttribute("SymbolStyle", aExpandableConverter);
            mChart3DPointSeries.RegisterAttribute("Points", aChart3DPointsCollectionEditor);
            s_typeModels.Add(typeof(Chart3DPointSeries), mChart3DPointSeries);

#if MAP
            #region MapField
            // MapField
            var mMapField = EditableModel<MapField>.NewEditableModel();
            mMapField.RegisterAttribute("RightToLeft", aHideProperty);
            mMapField.RegisterAttributesFromModel(mFieldBase);
            mMapField.RegisterAttribute("AutoHeight", aHideProperty);
            mMapField.RegisterAttribute("AutoWidth", aHideProperty);
            mMapField.RegisterAttribute("Layers", aMapLayersCollectionEditor);
            mMapField.RegisterAttribute("PointTemplates", aMapPointTemplatesCollectionEditor);
            mMapField.RegisterAttribute("LineTemplates", aMapLineTemplatesCollectionEditor);
            mMapField.RegisterAttribute("PolygonTemplates", aMapPolygonTemplatesCollectionEditor);
            mMapField.RegisterAttribute("VectorTemplates", aMapVectorTemplatesCollectionEditor);
            mMapField.RegisterAttribute("Viewport", aExpandableConverter);
            mMapField.RegisterAttribute("ColorScale", aExpandableConverter);
            mMapField.RegisterAttribute("CompassTool", aExpandableConverter);
            mMapField.RegisterAttribute("CoordinatesTool", aExpandableConverter);
            mMapField.RegisterAttribute("DistanceScale", aExpandableConverter);
            mMapField.RegisterAttribute("Legends", aMapLegendsCollectionEditor);
            mMapField.RegisterAttribute("GeoCachePath", aMapGeoCachePathEditor);
            s_typeModels.Add(typeof(MapField), mMapField);
            // MapVisualItem
            var mMapVisualtem = EditableModel<Flex.Map.MapVisualItem>.NewEditableModel();
            mMapVisualtem.RegisterAttribute("Background", aBackgroundEditor);
            mMapVisualtem.RegisterAttribute("Background", aBackgroundConverter);
            mMapVisualtem.RegisterAttribute("Border", aMapBorderEditor);
            s_typeModels.Add(typeof(Flex.Map.MapVisualItem), mMapVisualtem);
            // MapSubItem
            var mMapSubItem = EditableModel<Flex.Map.MapSubItem>.NewEditableModel();
            mMapSubItem.RegisterAttributesFromModel(mMapVisualtem);
            mMapSubItem.RegisterAttribute("Hyperlink", aExpandableConverter);
            mMapSubItem.RegisterAttribute("Anchor", aMapAnchorsEditor);
            s_typeModels.Add(typeof(Flex.Map.MapSubItem), mMapSubItem);
            // MapLegend
            var mMapLegend = EditableModel<Flex.Map.MapLegend>.NewEditableModel();
            mMapLegend.RegisterAttribute("Title", aExpandableConverter);
            mMapLegend.RegisterAttribute("Items", aMapLegendItemsCollectionEditor);
            mMapLegend.RegisterAttributesFromModel(mMapSubItem);
            s_typeModels.Add(typeof(Flex.Map.MapLegend), mMapLegend);
            // MapLegendItem
            var mMapLegendItem = EditableModel<Flex.Map.MapLegendItem>.NewEditableModel();
            mMapLegendItem.RegisterAttribute("MarkerPicture", aPictureHolderEditor);
            mMapLegendItem.RegisterAttributesFromModel(mMapSubItem);
            s_typeModels.Add(typeof(Flex.Map.MapLegendItem), mMapLegendItem);
            // MapSubItemTitle
            var mMapSubItemTitle = EditableModel<Flex.Map.MapSubItemTitle>.NewEditableModel();
            mMapSubItemTitle.RegisterAttributesFromModel(mMapVisualtem);
            mMapSubItemTitle.RegisterAttribute("Align", aTextAlignEditor);
            s_typeModels.Add(typeof(Flex.Map.MapSubItemTitle), mMapSubItemTitle);
            // MapColorScale
            var mMapColorScale = EditableModel<Flex.Map.MapColorScale>.NewEditableModel();
            mMapColorScale.RegisterAttributesFromModel(mMapSubItem);
            mMapColorScale.RegisterAttribute("Title", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapColorScale), mMapColorScale);
            // MapCompass
            var mMapCompass = EditableModel<Flex.Map.MapCompassTool>.NewEditableModel();
            mMapCompass.RegisterAttributesFromModel(mMapSubItem);
            mMapCompass.RegisterAttribute("CompassBackground", aBackgroundConverter);
            mMapCompass.RegisterAttribute("CompassBackground", aBackgroundEditor);
            s_typeModels.Add(typeof(Flex.Map.MapCompassTool), mMapCompass);
            // MapCoordinatesTool
            var mMapCoordinatesTool = EditableModel<Flex.Map.MapCoordinatesTool>.NewEditableModel();
            mMapCoordinatesTool.RegisterAttributesFromModel(mMapSubItem);
            mMapCoordinatesTool.RegisterAttribute("PatternLong", aMapCoordinatePatternConverter);
            mMapCoordinatesTool.RegisterAttribute("PatternLat", aMapCoordinatePatternConverter);
            mMapCoordinatesTool.RegisterAttribute("CoordinateLong", aMapDoubleConverter);
            mMapCoordinatesTool.RegisterAttribute("CoordinateLat", aMapDoubleConverter);
            mMapCoordinatesTool.RegisterAttribute("Align", aTextAlignEditor);
            s_typeModels.Add(typeof(Flex.Map.MapCoordinatesTool), mMapCoordinatesTool);
            // MapDistanceScale
            var mMapDistanceScale = EditableModel<Flex.Map.MapDistanceScale>.NewEditableModel();
            mMapDistanceScale.RegisterAttributesFromModel(mMapSubItem);
            mMapDistanceScale.RegisterAttribute("ScaleBackground", aBackgroundConverter);
            mMapDistanceScale.RegisterAttribute("ScaleBackground", aBackgroundEditor);
            s_typeModels.Add(typeof(Flex.Map.MapDistanceScale), mMapDistanceScale);
            // MapViewport
            var mMapViewport = EditableModel<Flex.Map.MapViewport>.NewEditableModel();
            mMapViewport.RegisterAttribute("CoordinateSystem", aMapCoordinateSystemConverter);
            mMapViewport.RegisterAttributesFromModel(mMapSubItem);
            mMapViewport.RegisterAttribute("View", aExpandableConverter);
            mMapViewport.RegisterAttribute("Limits", aExpandableConverter);
            mMapViewport.RegisterAttribute("Meridians", aExpandableConverter);
            mMapViewport.RegisterAttribute("Parallels", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapViewport), mMapViewport);
            // MapGeographicCoordinateSystem
            var mMapGeographicCoordinateSystem = EditableModel<Flex.Map.MapGeographicCoordinateSystem>.NewEditableModel();
            mMapGeographicCoordinateSystem.RegisterAttribute("ProjectionOptions", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapGeographicCoordinateSystem), mMapGeographicCoordinateSystem);
            // MapProjectionOptions
            var mMapProjectionOptions = EditableModel<Flex.Map.MapProjectionOptions>.NewEditableModel();
            mMapProjectionOptions.RegisterAttribute("CenterLong", aMapDoubleConverter);
            mMapProjectionOptions.RegisterAttribute("CenterLat", aMapDoubleConverter);
            s_typeModels.Add(typeof(Flex.Map.MapProjectionOptions), mMapProjectionOptions);
            // MapViewportLimits
            var mMapViewportLimits = EditableModel<Flex.Map.MapViewportLimits>.NewEditableModel();
            mMapViewportLimits.RegisterAttribute("MinLong", aMapDoubleConverter);
            mMapViewportLimits.RegisterAttribute("MinLat", aMapDoubleConverter);
            mMapViewportLimits.RegisterAttribute("MaxLong", aMapDoubleConverter);
            mMapViewportLimits.RegisterAttribute("MaxLat", aMapDoubleConverter);
            s_typeModels.Add(typeof(Flex.Map.MapViewportLimits), mMapViewportLimits);
            // MapGridLines
            var mMapGridLines = EditableModel<Flex.Map.MapGridLines>.NewEditableModel();
            mMapGridLines.RegisterAttribute("LabelPattern", aMapCoordinatePatternConverter);
            mMapGridLines.RegisterAttribute("Interval", aMapDoubleConverter);
            s_typeModels.Add(typeof(Flex.Map.MapGridLines), mMapGridLines);
            // MapViewportView
            var mMapViewportView = EditableModel<Flex.Map.MapViewportView>.NewEditableModel();
            mMapViewportView.RegisterAttribute("CenterLong", aMapDoubleConverter);
            mMapViewportView.RegisterAttribute("CenterLat", aMapDoubleConverter);
            mMapViewportView.RegisterAttribute("AutoZoomOptions", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapViewportView), mMapViewportView);
            // MapTileLayer
            var mMapTileLayer = EditableModel<Flex.Map.MapTileLayer>.NewEditableModel();
            mMapTileLayer.RegisterAttribute("Provider", aMapTileProviderConverter);
            s_typeModels.Add(typeof(Flex.Map.MapTileLayer), mMapTileLayer);
            // MapCommonTileProvider
            var mMapCommonTileProvider = EditableModel<Flex.Map.MapCommonTileProvider>.NewEditableModel();
            mMapCommonTileProvider.RegisterAttribute("Source", aReadonlyProperty);
            s_typeModels.Add(typeof(Flex.Map.MapCommonTileProvider), mMapCommonTileProvider);
            // MapVectorsLayerBase
            var mMapVectorsLayerBase = EditableModel<Flex.Map.MapVectorsLayerBase>.NewEditableModel();
            mMapVectorsLayerBase.RegisterAttribute("LegendNames", aMapLegendNameConverter);
            mMapVectorsLayerBase.RegisterAttribute("LayerData", aMapLayerDataConverter);
            mMapVectorsLayerBase.RegisterAttribute("SpatialData", aMapSpatialDataConverter);
            mMapVectorsLayerBase.RegisterAttribute("PolygonRules", aExpandableConverter);
            mMapVectorsLayerBase.RegisterAttribute("PolygonCenterPointRules", aExpandableConverter);
            mMapVectorsLayerBase.RegisterAttribute("LineRules", aExpandableConverter);
            mMapVectorsLayerBase.RegisterAttribute("PointRules", aExpandableConverter);
            mMapVectorsLayerBase.RegisterAttribute("TemplateKey", aScriptValueConverter);
            mMapVectorsLayerBase.RegisterAttribute("TemplateKey", aMapScriptTemplateKeyEditor);
            s_typeModels.Add(typeof(Flex.Map.MapVectorsLayerBase), mMapVectorsLayerBase);
            // MapVectorsLayer
            var mMapVectorsLayer = EditableModel<Flex.Map.MapVectorsLayer>.NewEditableModel();
            mMapVectorsLayer.RegisterAttributesFromModel(mMapVectorsLayerBase);
            mMapVectorsLayer.RegisterAttribute("Template", aExpandableConverter);
            mMapVectorsLayer.RegisterAttribute("PolygonCenterPointTemplate", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapVectorsLayer), mMapVectorsLayer);
            // MapPointsLayer
            var mMapPointsLayer = EditableModel<Flex.Map.MapPointsLayer>.NewEditableModel();
            mMapPointsLayer.RegisterAttributesFromModel(mMapVectorsLayerBase);
            mMapPointsLayer.RegisterAttribute("VectorTypes", aHideProperty);
            mMapPointsLayer.RegisterAttribute("LineRules", aHideProperty);
            mMapPointsLayer.RegisterAttribute("PolygonRules", aHideProperty);
            mMapPointsLayer.RegisterAttribute("PolygonCenterPointRules", aHideProperty);
            mMapPointsLayer.RegisterAttribute("Template", aExpandableConverter);
            mMapPointsLayer.RegisterAttribute("ClusterTemplates", aMapClusterPointTemplatesCollectionEditor);
            s_typeModels.Add(typeof(Flex.Map.MapPointsLayer), mMapPointsLayer);
            // MapLinesLayer
            var mMapLinesLayer = EditableModel<Flex.Map.MapLinesLayer>.NewEditableModel();
            mMapLinesLayer.RegisterAttributesFromModel(mMapVectorsLayerBase);
            mMapLinesLayer.RegisterAttribute("VectorTypes", aHideProperty);
            mMapLinesLayer.RegisterAttribute("PointRules", aHideProperty);
            mMapLinesLayer.RegisterAttribute("PolygonRules", aHideProperty);
            mMapLinesLayer.RegisterAttribute("PolygonCenterPointRules", aHideProperty);
            mMapLinesLayer.RegisterAttribute("Template", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapLinesLayer), mMapLinesLayer);
            // MapPolygonsLayer
            var mMapPolygonsLayer = EditableModel<Flex.Map.MapPolygonsLayer>.NewEditableModel();
            mMapPolygonsLayer.RegisterAttributesFromModel(mMapVectorsLayerBase);
            mMapPolygonsLayer.RegisterAttribute("VectorTypes", aHideProperty);
            mMapPolygonsLayer.RegisterAttribute("LineRules", aHideProperty);
            mMapPolygonsLayer.RegisterAttribute("PointRules", aHideProperty);
            mMapPolygonsLayer.RegisterAttribute("Template", aExpandableConverter);
            mMapPolygonsLayer.RegisterAttribute("CenterPointTemplate", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapPolygonsLayer), mMapPolygonsLayer);
            // MapLayerData
            var mMapLayerData = EditableModel<Flex.Map.MapLayerData>.NewEditableModel();
            mMapLayerData.RegisterAttribute("DataSourceName", aScriptValueConverter);
            mMapLayerData.RegisterAttribute("DataSourceName", aMapScriptDataSourceNameEditor);
            mMapLayerData.RegisterAttribute("DataSourceFilter", aScriptValueConverter);
            mMapLayerData.RegisterAttribute("DataSourceFilter", aMapScriptValueEditor);
            mMapLayerData.RegisterAttribute("ItemFilter", aScriptValueConverter);
            mMapLayerData.RegisterAttribute("ItemFilter", aMapScriptValueEditor);
            mMapLayerData.RegisterAttribute("ValueGroup", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapLayerData), mMapLayerData);
            // MapLayerDataGroup
            var mMapLayerDataGroup = EditableModel<Flex.Map.MapLayerDataGroup>.NewEditableModel();
            mMapLayerDataGroup.RegisterAttribute("ValueBy", aScriptValueConverter);
            mMapLayerDataGroup.RegisterAttribute("ValueBy", aMapScriptValueEditor);
            s_typeModels.Add(typeof(Flex.Map.MapLayerDataGroup), mMapLayerDataGroup);
            // MapPolygonRules
            var mMapPolygonRules = EditableModel<Flex.Map.MapPolygonRules>.NewEditableModel();
            mMapPolygonRules.RegisterAttribute("ColorRule", aMapColorRuleConverter);
            mMapPolygonRules.RegisterAttribute("PieSizeRule", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapPolygonRules), mMapPolygonRules);
            // MapPointRules
            var mMapPointRules = EditableModel<Flex.Map.MapPointRules>.NewEditableModel();
            mMapPointRules.RegisterAttribute("ColorRule", aMapColorRuleConverter);
            mMapPointRules.RegisterAttribute("SizeRule", aExpandableConverter);
            mMapPointRules.RegisterAttribute("MarkerRule", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapPointRules), mMapPointRules);
            // MapLineRules
            var mMapLineRules = EditableModel<Flex.Map.MapLineRules>.NewEditableModel();
            mMapLineRules.RegisterAttribute("ColorRule", aMapColorRuleConverter);
            s_typeModels.Add(typeof(Flex.Map.MapLineRules), mMapLineRules);
            // MapVisualizationRule
            var mMapVisualizationRule = EditableModel<Flex.Map.MapVisualizationRule>.NewEditableModel();
            mMapVisualizationRule.RegisterAttribute("LegendName", aMapLegendNameConverter);
            mMapVisualizationRule.RegisterAttribute("DataValue", aScriptValueConverter);
            mMapVisualizationRule.RegisterAttribute("DataValue", aMapScriptValueEditor);
            mMapVisualizationRule.RegisterAttribute("StartValue", aScriptValueConverter);
            mMapVisualizationRule.RegisterAttribute("StartValue", aMapScriptValueEditor);
            mMapVisualizationRule.RegisterAttribute("EndValue", aScriptValueConverter);
            mMapVisualizationRule.RegisterAttribute("EndValue", aMapScriptValueEditor);
            mMapVisualizationRule.RegisterAttribute("LegendText", aMapRuleLegendTextConverter);
            s_typeModels.Add(typeof(Flex.Map.MapVisualizationRule), mMapVisualizationRule);
            // MapColorRule
            var mMapColorRule = EditableModel<Flex.Map.MapColorRule>.NewEditableModel();
            mMapColorRule.RegisterAttributesFromModel(mMapVisualizationRule);
            s_typeModels.Add(typeof(Flex.Map.MapColorRule), mMapColorRule);
            // MapColorRangeRule
            var mMapColorRangeRule = EditableModel<Flex.Map.MapColorRangeRule>.NewEditableModel();
            mMapColorRangeRule.RegisterAttributesFromModel(mMapColorRule);
            s_typeModels.Add(typeof(Flex.Map.MapColorRangeRule), mMapColorRangeRule);
            // MapColorPaletteRule
            var mMapColorPaletteRule = EditableModel<Flex.Map.MapColorPaletteRule>.NewEditableModel();
            mMapColorPaletteRule.RegisterAttributesFromModel(mMapColorRule);
            mMapColorPaletteRule.RegisterAttribute("Palette", aMapColorPaletteEditor);
            s_typeModels.Add(typeof(Flex.Map.MapColorPaletteRule), mMapColorPaletteRule);
            // MapCustomColorRule
            var mMapCustomColorRule = EditableModel<Flex.Map.MapCustomColorRule>.NewEditableModel();
            mMapCustomColorRule.RegisterAttributesFromModel(mMapColorRule);
            s_typeModels.Add(typeof(Flex.Map.MapCustomColorRule), mMapCustomColorRule);
            // MapSizeRule
            var mMapSizeRule = EditableModel<Flex.Map.MapSizeRule>.NewEditableModel();
            mMapSizeRule.RegisterAttributesFromModel(mMapVisualizationRule);
            s_typeModels.Add(typeof(Flex.Map.MapSizeRule), mMapSizeRule);
            // MapMarkerRule
            var mMapMarkerRule = EditableModel<Flex.Map.MapMarkerRule>.NewEditableModel();
            mMapMarkerRule.RegisterAttributesFromModel(mMapVisualizationRule);
            mMapMarkerRule.RegisterAttribute("Markers", aMapMarkersCollectionEditor);
            s_typeModels.Add(typeof(Flex.Map.MapMarkerRule), mMapMarkerRule);
            // MapTemplate
            var mMapTempalte = EditableModel<Flex.Map.MapTemplate>.NewEditableModel();
            mMapTempalte.RegisterAttribute("Visible", aScriptValueConverter);
            mMapTempalte.RegisterAttribute("Visible", aMapScriptBoolEditor);
            mMapTempalte.RegisterAttribute("Track", aScriptValueConverter);
            mMapTempalte.RegisterAttribute("Track", aMapScriptBoolEditor);
            mMapTempalte.RegisterAttribute("Hyperlink", aMapReportHyperLinkConverter);
            s_typeModels.Add(typeof(Flex.Map.MapTemplate), mMapTempalte);
            // MapVectorTemplate
            var mMapVectorTempalte = EditableModel<Flex.Map.MapVectorTemplate>.NewEditableModel();
            mMapVectorTempalte.RegisterAttributesFromModel(mMapTempalte);
            mMapVectorTempalte.RegisterAttribute("Label", aScriptValueConverter);
            mMapVectorTempalte.RegisterAttribute("Label", aMapScriptValueEditor);
            mMapVectorTempalte.RegisterAttribute("LineWidth", aScriptValueConverter);
            mMapVectorTempalte.RegisterAttribute("LineWidth", aMapScriptValueEditor);
            mMapVectorTempalte.RegisterAttribute("MarkerSize", aScriptValueConverter);
            mMapVectorTempalte.RegisterAttribute("MarkerSize", aMapScriptValueEditor);
            mMapVectorTempalte.RegisterAttribute("Background", aBackgroundEditor);
            mMapVectorTempalte.RegisterAttribute("Background", aBackgroundConverter);
            mMapVectorTempalte.RegisterAttribute("Marker", aExpandableConverter);
            mMapVectorTempalte.RegisterAttribute("Chart", aExpandableConverter);
            mMapVectorTempalte.RegisterAttribute("LabelPosition", aMapLabelPositionEditor);
            s_typeModels.Add(typeof(Flex.Map.MapVectorTemplate), mMapVectorTempalte);
            // MapPointTemplate
            var mMapPointTempalte = EditableModel<Flex.Map.MapPointTemplate>.NewEditableModel();
            mMapPointTempalte.RegisterAttributesFromModel(mMapTempalte);
            mMapPointTempalte.RegisterAttribute("Label", aScriptValueConverter);
            mMapPointTempalte.RegisterAttribute("Label", aMapScriptValueEditor);
            mMapPointTempalte.RegisterAttribute("MarkerSize", aScriptValueConverter);
            mMapPointTempalte.RegisterAttribute("MarkerSize", aMapScriptValueEditor);
            mMapPointTempalte.RegisterAttribute("Background", aBackgroundEditor);
            mMapPointTempalte.RegisterAttribute("Background", aBackgroundConverter);
            mMapPointTempalte.RegisterAttribute("Marker", aExpandableConverter);
            mMapPointTempalte.RegisterAttribute("LabelPosition", aMapLabelPositionEditor);
            s_typeModels.Add(typeof(Flex.Map.MapPointTemplate), mMapPointTempalte);
            // MapLineTemplate
            var mLineMapTempalte = EditableModel<Flex.Map.MapLineTemplate>.NewEditableModel();
            mLineMapTempalte.RegisterAttributesFromModel(mMapTempalte);
            mLineMapTempalte.RegisterAttribute("LineWidth", aScriptValueConverter);
            mLineMapTempalte.RegisterAttribute("LineWidth", aMapScriptValueEditor);
            s_typeModels.Add(typeof(Flex.Map.MapLineTemplate), mLineMapTempalte);
            // MapPolygonTemplate
            var mMapPolygonTempalte = EditableModel<Flex.Map.MapPolygonTemplate>.NewEditableModel();
            mMapPolygonTempalte.RegisterAttributesFromModel(mMapTempalte);
            mMapPolygonTempalte.RegisterAttribute("Background", aBackgroundEditor);
            mMapPolygonTempalte.RegisterAttribute("Background", aBackgroundConverter);
            mMapPolygonTempalte.RegisterAttribute("Chart", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapPolygonTemplate), mMapPolygonTempalte);
            // MapChart
            var mMapChart = EditableModel<Flex.Map.MapChart>.NewEditableModel();
            mMapChart.RegisterAttribute("BarHeight", aMapScriptValueEditor);
            mMapChart.RegisterAttribute("BarHeight", aScriptValueConverter);
            mMapChart.RegisterAttribute("PieSize", aMapScriptValueEditor);
            mMapChart.RegisterAttribute("PieSize", aScriptValueConverter);
            mMapChart.RegisterAttribute("Palette", aMapColorPaletteEditor);
            s_typeModels.Add(typeof(Flex.Map.MapChart), mMapChart);
            // MapMarker
            var mMapMarker = EditableModel<Flex.Map.MapMarker>.NewEditableModel();
            mMapMarker.RegisterAttribute("Image", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapMarker), mMapMarker);
            // MapMarkerImage
            var mMapMarkerImge = EditableModel<Flex.Map.MapMarkerImage>.NewEditableModel();
            mMapMarkerImge.RegisterAttribute("Picture", aPictureHolderEditor);
            s_typeModels.Add(typeof(Flex.Map.MapMarkerImage), mMapMarkerImge);
            // MapEmbeddedData
            var mMapEmbeddedData = EditableModel<Flex.Map.MapEmbeddedData>.NewEditableModel();
            mMapEmbeddedData.RegisterAttribute("Items", aMapSpatialElementsCollectionEditor);
            s_typeModels.Add(typeof(Flex.Map.MapEmbeddedData), mMapEmbeddedData);
            // MapSpatialElement
            var mMapSpatialElement = EditableModel<Flex.Map.MapSpatialElement>.NewEditableModel();
            mMapSpatialElement.RegisterAttribute("VectorData", aMapVectorDataConverter);
            mMapSpatialElement.RegisterAttribute("Fields", aMapDataFieldsCollectionEditor);
            s_typeModels.Add(typeof(Flex.Map.MapSpatialElement), mMapSpatialElement);
            // MapDataField
            var mMapDataField = EditableModel<Flex.Map.MapDataField>.NewEditableModel();
            mMapDataField.RegisterAttribute("Name", aMapDataFieldNameConverter);
            s_typeModels.Add(typeof(Flex.Map.MapDataField), mMapDataField);
            // MapSpatialPointElement
            var mMapSpatialPointElement = EditableModel<Flex.Map.MapSpatialPointElement>.NewEditableModel();
            mMapSpatialPointElement.RegisterAttributesFromModel(mMapSpatialElement);
            mMapSpatialPointElement.RegisterAttribute("Template", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapSpatialPointElement), mMapSpatialPointElement);
            // MapSpatialLineElement
            var mMapSpatialLineElement = EditableModel<Flex.Map.MapSpatialLineElement>.NewEditableModel();
            mMapSpatialLineElement.RegisterAttributesFromModel(mMapSpatialElement);
            mMapSpatialLineElement.RegisterAttribute("Template", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapSpatialLineElement), mMapSpatialLineElement);
            // MapSpatialPolygonElement
            var mMapSpatialPolygonElement = EditableModel<Flex.Map.MapSpatialPolygonElement>.NewEditableModel();
            mMapSpatialPolygonElement.RegisterAttributesFromModel(mMapSpatialElement);
            mMapSpatialPolygonElement.RegisterAttribute("Template", aExpandableConverter);
            mMapSpatialPolygonElement.RegisterAttribute("CenterPointTemplate", aExpandableConverter);
            s_typeModels.Add(typeof(Flex.Map.MapSpatialPolygonElement), mMapSpatialPolygonElement);
            // MapFileData
            var mMapFileData = EditableModel<Flex.Map.MapFileData>.NewEditableModel();
            mMapFileData.RegisterAttribute("FileName", aMapScriptFileDataSourceEditor);
            mMapFileData.RegisterAttribute("FileName", aScriptValueConverter);
            s_typeModels.Add(typeof(Flex.Map.MapFileData), mMapFileData);
            // MapDataSourceData
            var mMapDataSourceData = EditableModel<Flex.Map.MapDataSourceData>.NewEditableModel();
            mMapDataSourceData.RegisterAttribute("DataSourceName", aMapScriptDataSourceNameEditor);
            mMapDataSourceData.RegisterAttribute("DataSourceName", aScriptValueConverter);
            mMapDataSourceData.RegisterAttribute("DataSourceFilter", aScriptValueEditor);
            mMapDataSourceData.RegisterAttribute("DataSourceFilter", aScriptValueConverter);
            s_typeModels.Add(typeof(Flex.Map.MapDataSourceData), mMapDataSourceData);
            // MapDataSourceSqlData
            var mMapDataSourceSqlData = EditableModel<Flex.Map.MapDataSourceSqlData>.NewEditableModel();
            mMapDataSourceSqlData.RegisterAttributesFromModel(mMapDataSourceData);
            mMapDataSourceSqlData.RegisterAttribute("VectorData", aScriptValueConverter);
            mMapDataSourceSqlData.RegisterAttribute("VectorData", aScriptValueEditor);
            s_typeModels.Add(typeof(Flex.Map.MapDataSourceSqlData), mMapDataSourceSqlData);
            // MapDataSourcePointsData
            var mMapDataSourcePointsData = EditableModel<Flex.Map.MapDataSourcePointsData>.NewEditableModel();
            mMapDataSourcePointsData.RegisterAttributesFromModel(mMapDataSourceData);
            mMapDataSourcePointsData.RegisterAttribute("Longitude", aScriptValueConverter);
            mMapDataSourcePointsData.RegisterAttribute("Longitude", aScriptValueEditor);
            mMapDataSourcePointsData.RegisterAttribute("Latitude", aScriptValueConverter);
            mMapDataSourcePointsData.RegisterAttribute("Latitude", aScriptValueEditor);
            mMapDataSourcePointsData.RegisterAttribute("MapLocation", aScriptValueConverter);
            mMapDataSourcePointsData.RegisterAttribute("MapLocation", aScriptValueEditor);
            s_typeModels.Add(typeof(Flex.Map.MapDataSourcePointsData), mMapDataSourcePointsData);
            // MapDataSourceLinesData
            var mMapDataSourceLinesData = EditableModel<Flex.Map.MapDataSourceLinesData>.NewEditableModel();
            mMapDataSourceLinesData.RegisterAttributesFromModel(mMapDataSourceData);
            mMapDataSourceLinesData.RegisterAttribute("Longitude1", aScriptValueConverter);
            mMapDataSourceLinesData.RegisterAttribute("Longitude1", aScriptValueEditor);
            mMapDataSourceLinesData.RegisterAttribute("Latitude1", aScriptValueConverter);
            mMapDataSourceLinesData.RegisterAttribute("Latitude1", aScriptValueEditor);
            mMapDataSourceLinesData.RegisterAttribute("MapLocation1", aScriptValueConverter);
            mMapDataSourceLinesData.RegisterAttribute("MapLocation1", aScriptValueEditor);
            mMapDataSourceLinesData.RegisterAttribute("Longitude2", aScriptValueConverter);
            mMapDataSourceLinesData.RegisterAttribute("Longitude2", aScriptValueEditor);
            mMapDataSourceLinesData.RegisterAttribute("Latitude2", aScriptValueConverter);
            mMapDataSourceLinesData.RegisterAttribute("Latitude2", aScriptValueEditor);
            mMapDataSourceLinesData.RegisterAttribute("MapLocation2", aScriptValueConverter);
            mMapDataSourceLinesData.RegisterAttribute("MapLocation2", aScriptValueEditor);
            s_typeModels.Add(typeof(Flex.Map.MapDataSourceLinesData), mMapDataSourceLinesData);

            // MapReportHyperlinkEditModel
            var mMapReportHyplerlink = MapReportHyperlinkEditModel.NewMapObjectHolderEditableModel();
            mMapReportHyplerlink.RegisterAttribute("StatusText", aScriptValueConverter);
            mMapReportHyplerlink.RegisterAttribute("StatusText", aMapScriptValueEditor);
            mMapReportHyplerlink.RegisterAttribute("LinkTarget", aMapReportLinkTargetConverter);
            s_typeModels.Add(typeof(MapReportHyperlinkEditModel), mMapReportHyplerlink);
            // MapReportLinkTargetBookmarkEditModel
            var mMapReportLinkTargetBookmark = MapReportLinkTargetBookmarkEditModel.NewMapObjectHolderEditableModel();
            mMapReportLinkTargetBookmark.RegisterAttribute("Bookmark", aScriptValueConverter);
            mMapReportLinkTargetBookmark.RegisterAttribute("Bookmark", aMapScriptValueEditor);
            s_typeModels.Add(typeof(MapReportLinkTargetBookmarkEditModel), mMapReportLinkTargetBookmark);
            // MapReportLinkTargetUrlEditModel
            var mMapReportLinkTargetUrl = MapReportLinkTargetUrlEditModel.NewMapObjectHolderEditableModel();
            mMapReportLinkTargetUrl.RegisterAttribute("Url", aScriptValueConverter);
            mMapReportLinkTargetUrl.RegisterAttribute("Url", aMapScriptValueEditor);
            s_typeModels.Add(typeof(MapReportLinkTargetUrlEditModel), mMapReportLinkTargetUrl);
            #endregion
#endif

            // Field:
            var mField = EditableModel<Field>.NewEditableModel();
            mField.RegisterAttribute("Text", aScriptValueEditor);
            mField.RegisterAttribute("Subreport", aReportListTypeConverter);
            mField.RegisterAttribute("Align", aTextAlignEditor);
            mField.RegisterAttribute("Picture", aFieldPictureHolderEditor);
            mField.RegisterAttribute("PictureAlign", aPictureAlignEditor);
            mField.RegisterAttribute("Format", aFormatConverter);
            mField.RegisterAttribute("Shape", aShapeConverter);
            mField.RegisterAttribute("CanGrow", aHideProperty);
            mField.RegisterAttribute("CanShrink", aHideProperty);
            mField.RegisterAttribute("BorderStyle", aHideProperty);
            mField.RegisterAttribute("BorderColor", aHideProperty);
            mField.RegisterAttribute("LineWidth", aHideProperty);
            mField.RegisterAttributesFromModel(mFieldBase);
            s_typeModels.Add(typeof(Field), mField);
            // ImageField
            var mImageField = EditableModel<ImageField>.NewEditableModel();
            mImageField.RegisterAttribute("Picture", aFieldPictureHolderEditor);
            mImageField.RegisterAttribute("PictureAlign", aPictureAlignEditor);
            mImageField.RegisterAttributesFromModel(mFieldBase);
            mImageField.RegisterAttribute("RightToLeft", aHideProperty);
            s_typeModels.Add(typeof(ImageField), mImageField);
            // ParagraphField
            var mParagraphField = EditableModel<ParagraphField>.NewEditableModel();
            mParagraphField.RegisterAttribute("Align", aTextAlignEditor);
            mParagraphField.RegisterAttributesFromModel(mFieldBase);
            s_typeModels.Add(typeof(ParagraphField), mParagraphField);
            // RtfField
            var mRtfField = EditableModel<RtfField>.NewEditableModel();
            mRtfField.RegisterAttribute("Align", aTextAlignEditor);
            mRtfField.RegisterAttribute("Text", aScriptValueEditor);
            mRtfField.RegisterAttribute("Text", aScriptValueConverter);
            mRtfField.RegisterAttributesFromModel(mFieldBase);
            mRtfField.RegisterAttribute("RightToLeft", aHideProperty);
            s_typeModels.Add(typeof(RtfField), mRtfField);
            // ShapeField
            var mShapeField = EditableModel<ShapeField>.NewEditableModel();
            mShapeField.RegisterAttribute("Shape", aShapeConverter);
            mShapeField.RegisterAttribute("ShapeBackground", aBackgroundEditor);
            mShapeField.RegisterAttribute("ShapeBackground", aBackgroundConverter);
            mShapeField.RegisterAttribute("ShapeBackColor", aHideProperty);
            mShapeField.RegisterAttribute("AutoHeight", aHideProperty);
            mShapeField.RegisterAttribute("AutoWidth", aHideProperty);
            mShapeField.RegisterAttributesFromModel(mFieldBase);
            mShapeField.RegisterAttribute("RightToLeft", aHideProperty);
            s_typeModels.Add(typeof(ShapeField), mShapeField);
            // SubreportField
            var mSubreportField = EditableModel<SubreportField>.NewEditableModel();
            mSubreportField.RegisterAttribute("SubreportFilter", aScriptValueEditor);
            mSubreportField.RegisterAttribute("SubreportFilter", aScriptValueConverter);
            mSubreportField.RegisterAttribute("Subreport", aReportListTypeConverter);
            mSubreportField.RegisterAttribute("ParameterValues", aReportParameterValuesEditor);
            mSubreportField.RegisterAttributesFromModel(mFieldBase);
            s_typeModels.Add(typeof(SubreportField), mSubreportField);
            // TextField
            var mTextField = EditableModel<TextField>.NewEditableModel();
            mTextField.RegisterAttribute("Text", aScriptValueEditor);
            mTextField.RegisterAttribute("Text", aScriptValueConverter);
            mTextField.RegisterAttribute("Align", aTextAlignEditor);
            mTextField.RegisterAttribute("Format", aFormatConverter);
            mTextField.RegisterAttributesFromModel(mFieldBase);
            s_typeModels.Add(typeof(TextField), mTextField);
            // CheckBoxField
            var mCheckBoxField = EditableModel<CheckBoxField>.NewEditableModel();
            mCheckBoxField.RegisterAttribute("Value", aScriptValueEditor);
            mCheckBoxField.RegisterAttribute("Value", aScriptValueConverter);
            mCheckBoxField.RegisterAttribute("Text", aScriptValueEditor);
            mCheckBoxField.RegisterAttribute("Text", aScriptValueConverter);
            mCheckBoxField.RegisterAttribute("Align", aTextAlignEditor);
            mCheckBoxField.RegisterAttribute("CheckAlign", aPictureAlignEditor);
            mCheckBoxField.RegisterAttribute("SplitVertBehavior", aHideProperty);
            mCheckBoxField.RegisterAttribute("SplitHorzBehavior", aHideProperty);
            mCheckBoxField.RegisterAttribute("CheckMark", aExpandableConverter);
            mCheckBoxField.RegisterAttributesFromModel(mFieldBase);
            s_typeModels.Add(typeof(CheckBoxField), mCheckBoxField);

            // FlexChartField
            var aThicknessConverter = new TypeConverterAttribute(typeof(ThicknessConverter));
            var aElementSizeConverter = new TypeConverterAttribute(typeof(ElementSizeConverter));
            var aHiddenPropertiesFont = new HiddenPropertiesAttribute("Font");
            var aModelCollectionEditor = new EditorAttribute(typeof(ModelCollectionEditor), typeof(UITypeEditor));
            // FlexChartObject
            var mFlexChartObject = EditableModel<FCF.ChartObject>.NewEditableModel();
            mFlexChartObject.RegisterAttribute("ParentReport", aHideProperty);
            mFlexChartObject.RegisterAttribute("Field", aHideProperty);
            mFlexChartObject.RegisterAttribute("Owner", aHideProperty);
            s_typeModels.Add(typeof(FCF.ChartObject), mFlexChartObject);
            // Style
            var mStyle = EditableModel<FCF.ChartStyle>.NewEditableModel();
            mStyle.RegisterAttribute("FillColor", aNullableColorEditor);
            mStyle.RegisterAttribute("StrokeColor", aNullableColorEditor);
            mStyle.RegisterAttributesFromModel(mFlexChartObject);
            s_typeModels.Add(typeof(FCF.ChartStyle), mStyle);
            // Axis
            var mAxis = EditableModel<FCF.Axis>.NewEditableModel();
            mAxis.RegisterAttribute("Style", aExpandableConverter);
            mAxis.RegisterAttribute("TitleStyle", aExpandableConverter);
            mAxis.RegisterAttribute("MajorGridStyle", aExpandableConverter);
            mAxis.RegisterAttribute("MajorGridStyle", aHiddenPropertiesFont);
            mAxis.RegisterAttribute("MinorGridStyle", aExpandableConverter);
            mAxis.RegisterAttribute("MinorGridStyle", aHiddenPropertiesFont);
            mAxis.RegisterAttributesFromModel(mFlexChartObject);
            s_typeModels.Add(typeof(FCF.Axis), mAxis);
            // AxisX
            var mAxisX = EditableModel<FCF.AxisX>.NewEditableModel();
            mAxisX.RegisterAttributesFromModel(mAxis);
            s_typeModels.Add(typeof(FCF.AxisX), mAxisX);
            // AxisY
            var mAxisY = EditableModel<FCF.AxisY>.NewEditableModel();
            mAxisY.RegisterAttributesFromModel(mAxis);
            s_typeModels.Add(typeof(FCF.AxisY), mAxisY);
            // ChartTitle
            var mFlexChartTitle = EditableModel<FCF.ChartTitle>.NewEditableModel();
            mFlexChartTitle.RegisterAttributesFromModel(mFlexChartObject);
            mFlexChartTitle.RegisterAttribute("Style", aExpandableConverter);
            mFlexChartTitle.RegisterAttribute("BorderStyle", aExpandableConverter);
            mFlexChartTitle.RegisterAttribute("BorderStyle", aHiddenPropertiesFont);
            s_typeModels.Add(typeof(FCF.ChartTitle), mFlexChartTitle);
            // Legend
            var mFlexLegend = EditableModel<FCF.Legend>.NewEditableModel();
            mFlexLegend.RegisterAttributesFromModel(mFlexChartObject);
            mFlexLegend.RegisterAttribute("Style", aExpandableConverter);
            mFlexLegend.RegisterAttribute("TitleStyle", aExpandableConverter);
            s_typeModels.Add(typeof(FCF.Legend), mFlexLegend);
            // DataLabelBase
            var mDataLabelBase = EditableModel<FCF.DataLabelBase>.NewEditableModel();
            mDataLabelBase.RegisterAttributesFromModel(mFlexChartObject);
            mDataLabelBase.RegisterAttribute("Style", aExpandableConverter);
            mDataLabelBase.RegisterAttribute("BorderStyle", aExpandableConverter);
            mDataLabelBase.RegisterAttribute("BorderStyle", aHiddenPropertiesFont);
            s_typeModels.Add(typeof(FCF.DataLabelBase), mDataLabelBase);
            // DataLabel
            var mDataLabel = EditableModel<FCF.DataLabel>.NewEditableModel();
            mDataLabel.RegisterAttributesFromModel(mDataLabelBase);
            s_typeModels.Add(typeof(FCF.DataLabel), mDataLabel);
            // Series
            var mSeries = EditableModel<FCF.Series>.NewEditableModel();
            mSeries.RegisterAttribute("DataSourceName", aChartDataSourceConverter);
            mSeries.RegisterAttribute("Label", aScriptValueEditor);
            mSeries.RegisterAttribute("Label", aScriptValueConverter);
            mSeries.RegisterAttribute("XExpression", aScriptValueEditor);
            mSeries.RegisterAttribute("YExpression", aScriptValueEditor);
            mSeries.RegisterAttribute("Y1Expression", aScriptValueEditor);
            mSeries.RegisterAttribute("Y2Expression", aScriptValueEditor);
            mSeries.RegisterAttribute("Y3Expression", aScriptValueEditor);
            mSeries.RegisterAttribute("YExpressions", aHideProperty);
            mSeries.RegisterAttribute("Style", aExpandableConverter);
            mSeries.RegisterAttribute("Style", aHiddenPropertiesFont);
            mSeries.RegisterAttribute("AltStyle", aExpandableConverter);
            mSeries.RegisterAttribute("AltStyle", aHiddenPropertiesFont);
            mSeries.RegisterAttribute("SymbolStyle", aExpandableConverter);
            mSeries.RegisterAttribute("SymbolStyle", aHiddenPropertiesFont);
            mSeries.RegisterAttribute("Hyperlink", aExpandableConverter);
            mSeries.RegisterAttributesFromModel(mFlexChartObject);
            s_typeModels.Add(typeof(FCF.Series), mSeries);
            // DataGroup
            var mDataGroup = EditableModel<FCF.DataGroup>.NewEditableModel();
            mDataGroup.RegisterAttribute("FilterExpression", aScriptValueEditor);
            mDataGroup.RegisterAttribute("SortExpression", aScriptValueEditor);
            mDataGroup.RegisterAttribute("GroupExpression", aScriptValueEditor);
            mDataGroup.RegisterAttributesFromModel(mFlexChartObject);
            s_typeModels.Add(typeof(FCF.DataGroup), mDataGroup);
            // ChartOptions
            var mChartOptions = EditableModel<FCF.ChartOptions>.NewEditableModel();
            mChartOptions.RegisterAttribute("ClusterSize", aElementSizeConverter);
            mChartOptions.RegisterAttributesFromModel(mFlexChartObject);
            s_typeModels.Add(typeof(FCF.ChartOptions), mChartOptions);
            // FlexChartFieldBase
            var mFlexChartFieldBase = EditableModel<FlexChartFieldBase>.NewEditableModel();
            mFlexChartFieldBase.RegisterAttribute("PlotStyle", aExpandableConverter);
            mFlexChartFieldBase.RegisterAttribute("Header", aExpandableConverter);
            mFlexChartFieldBase.RegisterAttribute("Footer", aExpandableConverter);
            mFlexChartFieldBase.RegisterAttribute("Legend", aExpandableConverter);
            mFlexChartFieldBase.RegisterAttribute("DataSourceName", aChartDataSourceConverter);
            mFlexChartFieldBase.RegisterAttributesFromModel(mFieldBase);
            s_typeModels.Add(typeof(FlexChartFieldBase), mFlexChartFieldBase);
            // FlexChartField
            var mFlexChartField = EditableModel<FlexChartField>.NewEditableModel();
            mFlexChartField.RegisterAttribute("AxisX", aExpandableConverter);
            mFlexChartField.RegisterAttribute("AxisY", aExpandableConverter);
            mFlexChartField.RegisterAttribute("DataLabel", aExpandableConverter);
            mFlexChartField.RegisterAttribute("Options", aExpandableConverter);
            mFlexChartField.RegisterAttribute("XLabelExpression", aScriptValueEditor);
            mFlexChartField.RegisterAttribute("Series", aModelCollectionEditor);
            mFlexChartField.RegisterAttribute("CategoryGroups", aModelCollectionEditor);
            mFlexChartField.RegisterAttribute("SeriesGroups", aModelCollectionEditor);
            mFlexChartField.RegisterAttribute("PlotMargin", aThicknessConverter);
            mFlexChartField.RegisterAttributesFromModel(mFlexChartFieldBase);
            s_typeModels.Add(typeof(FlexChartField), mFlexChartField);

            // Custom Map Field
            if (MainForm.CustomFieldsAssemblyAvailable)
            {
                RegisterCustomMap(mField);
            }

            // ====================== DATA TREE
            // Parameter
            var mParameter = EditableReportParameterModel.NewEditableReportParameterModel();
            mParameter.RegisterAttribute("DocumentSource", aHideProperty);
            mParameter.RegisterAttribute("Owner", aHideProperty);
            mParameter.RegisterAttribute("ParentReport", aHideProperty);
            mParameter.RegisterAttribute("AllowedValues", aHideProperty);
            mParameter.RegisterAttribute("DisplayText", aHideProperty);
            mParameter.RegisterAttribute("Value", aParameterValueEditor);
            mParameter.RegisterAttribute("Value", aParameterValueConverter);
            mParameter.RegisterAttribute("AllowedValuesDefinition", aAllowedValuesEditor);
            mParameter.RegisterAttribute("AllowedValuesDefinition", aAllowedValuesConverter);
            s_typeModels.Add(typeof(ReportParameter), mParameter);
            // DataSource
            var mDataSource = EditableModel<DataSource>.NewEditableModel();
            mDataSource.RegisterAttribute("Filter", aExpressionEditor);
            mDataSource.RegisterAttribute("CalculatedFields", aHideProperty); // collection editor for this is not tuned, so hide it from prop grid for now
            mDataSource.RegisterAttribute("SortDefinitions", aHideProperty); // collection editor for this is not tuned, so hide it from prop grid for now
            mDataSource.RegisterAttribute("RecordSource", aHideProperty); // hidden for now
            mDataSource.RegisterAttribute("RecordSourceType", aHideProperty); // hidden for now
            s_typeModels.Add(typeof(DataSource), mDataSource);
            // CalculatedField
            var mCalculatedField = EditableModel<CalculatedField>.NewEditableModel();
            mCalculatedField.RegisterAttribute("Expression", aExpressionEditor);
            mCalculatedField.RegisterAttribute("Expression", aScriptValueConverter);
            mCalculatedField.RegisterAttribute("Type", aCalculatedFieldTypeConverter);
            s_typeModels.Add(typeof(CalculatedField), mCalculatedField);
            // SortDefinition
            var mSortDefinition = EditableModel<SortDefinition>.NewEditableModel();
            mSortDefinition.RegisterAttribute("Expression", aScriptValueEditor);
            mSortDefinition.RegisterAttribute("Expression", aScriptValueConverter);
            mSortDefinition.RegisterAttribute("Direction", aScriptValueEditor);
            mSortDefinition.RegisterAttribute("Direction", aScriptValueConverter);
            s_typeModels.Add(typeof(SortDefinition), mSortDefinition);
            // ====================== GROUPS
            var mGroup = EditableModel<Group>.NewEditableModel();
            mGroup.RegisterAttribute("GroupBy", aScriptValueEditor);
            mGroup.RegisterAttribute("GroupBy", aScriptValueConverter);
            mGroup.RegisterAttribute("OutlineLabel", aScriptValueEditor);
            mGroup.RegisterAttribute("OutlineLabel", aScriptValueConverter);
            mGroup.RegisterAttribute("OutlineParent", aOutlineParentEditor);
            mGroup.RegisterAttribute("SortExpression", aScriptValueEditor);
            mGroup.RegisterAttribute("Tag", aHideProperty);
            mGroup.RegisterAttribute("GroupBy", aCategoryGrouping);
            mGroup.RegisterAttribute("KeepTogether", aCategoryGrouping);
            mGroup.RegisterAttribute("Sort", aCategoryGrouping);
            mGroup.RegisterAttribute("SortExpression", aCategoryGrouping);
            mGroup.ExposeNestedProperty("ShowGroupHeader", typeof(bool), "SectionHeader", "Visible",
                Strings.GroupEditorForm.HeadersCagetory, Strings.GroupEditorForm.HeaderDescription);
            mGroup.ExposeNestedProperty("ShowGroupFooter", typeof(bool), "SectionFooter", "Visible",
                Strings.GroupEditorForm.HeadersCagetory, Strings.GroupEditorForm.FooterDescription);
            s_typeModels.Add(typeof(Group), mGroup);
            // ===================== ReportHyperlink
            var mReportHyperlink = EditableModel<ReportHyperlink>.NewEditableModel();
            mReportHyperlink.RegisterAttribute("StatusText", aScriptValueEditor);
            mReportHyperlink.RegisterAttribute("StatusText", aScriptValueConverter);
            mReportHyperlink.RegisterAttribute("LinkTarget", aReportLinkTargetConverter);
            s_typeModels.Add(typeof(ReportHyperlink), mReportHyperlink);
            // ===================== ReportLinkTarget
            var mReportLinkTarget = EditableModel<ReportLinkTargetBookmark>.NewEditableModel();
            mReportLinkTarget.RegisterAttribute("Bookmark", aScriptValueEditor);
            mReportLinkTarget.RegisterAttribute("Bookmark", aScriptValueConverter);
            mReportLinkTarget.RegisterAttribute("ParameterValues", aReportParameterValuesEditor);
            mReportLinkTarget.RegisterAttribute("Report", aReportListTypeConverter);
            s_typeModels.Add(typeof(ReportLinkTargetBookmark), mReportLinkTarget);
            // ===================== ReportLinkTargetExternal
            var mReportLinkTargetExternal = EditableModel<ReportLinkTargetUrl>.NewEditableModel();
            mReportLinkTargetExternal.RegisterAttribute("Url", aScriptValueEditor);
            mReportLinkTargetExternal.RegisterAttribute("Url", aScriptValueConverter);
            s_typeModels.Add(typeof(ReportLinkTargetUrl), mReportLinkTargetExternal);
            // ===================== ReportLinkTargetScript
            var mReportLinkTargetScript = EditableModel<ReportLinkTargetScript>.NewEditableModel();
            mReportLinkTargetScript.RegisterAttribute("OnNavigate", aStatementEditor);
            s_typeModels.Add(typeof(ReportLinkTargetScript), mReportLinkTargetScript);
            // ===================== ParagraphText
            var mParagraphItem = EditableModel<ParagraphText>.NewEditableModel();
            mParagraphItem.RegisterAttribute("Text", aScriptValueEditor);
            mParagraphItem.RegisterAttribute("Text", aScriptValueConverter);
            mParagraphItem.RegisterAttribute("Hyperlink", aExpandableConverter);
            mParagraphItem.RegisterAttribute("Format", aFormatConverter);
            mParagraphItem.RegisterAttribute("BackColor", aHideProperty);
            mParagraphItem.RegisterAttribute("Font", aHideProperty);
            mParagraphItem.RegisterAttribute("ForeColor", aHideProperty);
            mParagraphItem.RegisterAttribute("Background", aHideProperty);
            s_typeModels.Add(typeof(ParagraphText), mParagraphItem);
        }

        /// <summary>
        /// Register attributes for custom Map field.
        /// </summary>
        /// <remarks>
        /// Wrap all codes for custom Map field here to bypass the type checking, if the CustomField assembly is inavailable..
        /// </remarks>
        private static void RegisterCustomMap(EditableModel mField)
        {
            // converters & editors
            var aScriptValueConverter = new TypeConverterAttribute(typeof(ScriptStringValueConverter));
            var aScriptValueEditor = new EditorAttribute(typeof(ScriptStringValueEditor), typeof(UITypeEditor));
            var aCMapExpandableObjectConverter = new TypeConverterAttribute(typeof(CMapExpandableObjectConverter));
            var aCMapLayersCollectionEditor = new EditorAttribute(typeof(CMapLayersCollectionEditor),
                typeof(UITypeEditor));
            var aCMapKmlItemStylesCollectionEditor = new EditorAttribute(
                typeof(CMapKmlItemStylesCollectionEditor), typeof(UITypeEditor));
            var aCMapMarkerStylesCollectionEditor = new EditorAttribute(typeof(CMapMarkerStylesCollectionEditor),
                typeof(UITypeEditor));
            var aCMapLineStylesCollectionEditor = new EditorAttribute(typeof(CMapLineStylesCollectionEditor),
                typeof(UITypeEditor));
            var aCMapLegendsCollectionEditor = new EditorAttribute(typeof (CMapLegendsCollectionEditor),
                typeof (UITypeEditor));
            var aCMapLegendItemsCollectionEditor = new EditorAttribute(typeof (CMapLegendItemsCollectionEditor),
                typeof (UITypeEditor));
            var aCMapDataSourceConverter = new TypeConverterAttribute(typeof(CMapDataSourceConverter));

            // Map
            var mCMap = EditableModel<Map>.NewEditableModel();
            mCMap.RegisterAttributesFromModel(mField);
            mCMap.RegisterAttribute("Layers", aCMapLayersCollectionEditor);
            mCMap.RegisterAttribute("Legends", aCMapLegendsCollectionEditor);
            mCMap.RegisterAttribute("KmlItemStyles", aCMapKmlItemStylesCollectionEditor);
            mCMap.RegisterAttribute("MarkerStyles", aCMapMarkerStylesCollectionEditor);
            mCMap.RegisterAttribute("LineStyles", aCMapLineStylesCollectionEditor);
            s_typeModels.Add(typeof(Map), mCMap);
            // Maps.LayerBase
            var mCMapLayerBase = EditableModel<Maps.LayerBase>.NewEditableModel();
            mCMapLayerBase.RegisterAttribute("DataSource", aCMapDataSourceConverter);
            mCMapLayerBase.RegisterAttribute("DataSourceFilterExpr", aScriptValueConverter);
            mCMapLayerBase.RegisterAttribute("DataSourceFilterExpr", aScriptValueEditor);
            s_typeModels.Add(typeof(Maps.LayerBase), mCMapLayerBase);
            // Maps.PointsLayer
            var mCMapPointsLayer = EditableModel<Maps.PointsLayer>.NewEditableModel();
            mCMapPointsLayer.RegisterAttributesFromModel(mCMapLayerBase);
            mCMapPointsLayer.RegisterAttribute("ClusterStyles", aCMapMarkerStylesCollectionEditor);
            mCMapPointsLayer.RegisterAttribute("MarkerStyle", aCMapExpandableObjectConverter);
            mCMapPointsLayer.RegisterAttribute("Longitude", aScriptValueConverter);
            mCMapPointsLayer.RegisterAttribute("Longitude", aScriptValueEditor);
            mCMapPointsLayer.RegisterAttribute("Latitude", aScriptValueConverter);
            mCMapPointsLayer.RegisterAttribute("Latitude", aScriptValueEditor);
            mCMapPointsLayer.RegisterAttribute("MapLocation", aScriptValueConverter);
            mCMapPointsLayer.RegisterAttribute("MapLocation", aScriptValueEditor);
            mCMapPointsLayer.RegisterAttribute("MarkerVisibleExpr", aScriptValueConverter);
            mCMapPointsLayer.RegisterAttribute("MarkerVisibleExpr", aScriptValueEditor);
            mCMapPointsLayer.RegisterAttribute("MarkerStyleExpr", aScriptValueConverter);
            mCMapPointsLayer.RegisterAttribute("MarkerStyleExpr", aScriptValueEditor);
            s_typeModels.Add(typeof(Maps.PointsLayer), mCMapPointsLayer);
            // Maps.LinesLayer
            var mCMapLinesLayer = EditableModel<Maps.LinesLayer>.NewEditableModel();
            mCMapLinesLayer.RegisterAttributesFromModel(mCMapLayerBase);
            mCMapLinesLayer.RegisterAttribute("LineStyle", aCMapExpandableObjectConverter);
            mCMapLinesLayer.RegisterAttribute("MapLocation1", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("MapLocation1", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("MapLocation2", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("MapLocation2", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("Longitude1", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("Longitude1", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("Longitude2", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("Longitude2", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("Latitude1", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("Latitude1", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("Latitude2", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("Latitude2", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("LineVisibleExpr", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("LineVisibleExpr", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("LineStyleExpr", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("LineStyleExpr", aScriptValueEditor);
            mCMapLinesLayer.RegisterAttribute("ThicknessExpr", aScriptValueConverter);
            mCMapLinesLayer.RegisterAttribute("ThicknessExpr", aScriptValueEditor);
            s_typeModels.Add(typeof(Maps.LinesLayer), mCMapLinesLayer);
            // Maps.KmlLayer
            var mCMapKmlLayer = EditableModel<Maps.KmlLayer>.NewEditableModel();
            mCMapKmlLayer.RegisterAttributesFromModel(mCMapLayerBase);
            mCMapKmlLayer.RegisterAttribute("ItemStyle", aCMapExpandableObjectConverter);
            mCMapKmlLayer.RegisterAttribute("ItemFilterExpr", aScriptValueConverter);
            mCMapKmlLayer.RegisterAttribute("ItemFilterExpr", aScriptValueEditor);
            mCMapKmlLayer.RegisterAttribute("ItemTrackExpr", aScriptValueConverter);
            mCMapKmlLayer.RegisterAttribute("ItemTrackExpr", aScriptValueEditor);
            mCMapKmlLayer.RegisterAttribute("ItemVisibleExpr", aScriptValueConverter);
            mCMapKmlLayer.RegisterAttribute("ItemVisibleExpr", aScriptValueEditor);
            mCMapKmlLayer.RegisterAttribute("ItemStyleExpr", aScriptValueConverter);
            mCMapKmlLayer.RegisterAttribute("ItemStyleExpr", aScriptValueEditor);
            s_typeModels.Add(typeof(Maps.KmlLayer), mCMapKmlLayer);
            // Maps.Legend
            var mCMapLegend = EditableModel<Maps.Legend>.NewEditableModel();
            mCMapLegend.RegisterAttribute("Items", aCMapLegendItemsCollectionEditor);
            s_typeModels.Add(typeof(Maps.Legend), mCMapLegend);
            // Maps.KmlItemStyle
            var mCMapKmlItemStyle = EditableModel<Maps.KmlItemStyle>.NewEditableModel();
            mCMapKmlItemStyle.RegisterAttribute("ItemNameExpr", aScriptValueConverter);
            mCMapKmlItemStyle.RegisterAttribute("ItemNameExpr", aScriptValueEditor);
            s_typeModels.Add(typeof(Maps.KmlItemStyle), mCMapKmlItemStyle);
            // Maps.InlineKmlItemStyle
            var mCMapInlineKmlItemStyle = EditableModel<Maps.InlineKmlItemStyle>.NewEditableModel();
            mCMapInlineKmlItemStyle.RegisterAttributesFromModel(mCMapKmlItemStyle);
            s_typeModels.Add(typeof(Maps.InlineKmlItemStyle), mCMapInlineKmlItemStyle);
            // Maps.MarkerStyle
            var mCMapMarkerStyle = EditableModel<Maps.MarkerStyle>.NewEditableModel();
            mCMapMarkerStyle.RegisterAttribute("CaptionExpr", aScriptValueConverter);
            mCMapMarkerStyle.RegisterAttribute("CaptionExpr", aScriptValueEditor);
            mCMapMarkerStyle.RegisterAttribute("SizeExpr", aScriptValueConverter);
            mCMapMarkerStyle.RegisterAttribute("SizeExpr", aScriptValueEditor);
            s_typeModels.Add(typeof(Maps.MarkerStyle), mCMapMarkerStyle);
            // Maps.InlineMarkerStyle
            var mCMapInlineMarkerStyle = EditableModel<Maps.InlineMarkerStyle>.NewEditableModel();
            mCMapInlineMarkerStyle.RegisterAttributesFromModel(mCMapMarkerStyle);
            s_typeModels.Add(typeof(Maps.InlineMarkerStyle), mCMapInlineMarkerStyle);
            // Maps.LineStyle
            var mCMapLineStyle = EditableModel<Maps.LineStyle>.NewEditableModel();
            mCMapLineStyle.RegisterAttribute("ThicknessExpr", aScriptValueConverter);
            mCMapLineStyle.RegisterAttribute("ThicknessExpr", aScriptValueEditor);
            s_typeModels.Add(typeof(Maps.LineStyle), mCMapLineStyle);
            // Maps.InlineLineStyle
            var mCMapInlineLineStyle = EditableModel<Maps.InlineLineStyle>.NewEditableModel();
            mCMapInlineLineStyle.RegisterAttributesFromModel(mCMapLineStyle);
            s_typeModels.Add(typeof(Maps.InlineLineStyle), mCMapInlineLineStyle);
        }

        /// <summary>
        /// Associates a model with an instance if a model is available for the object's type.
        /// Returns either the model instance, or the object itself if no model is available.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static object CreateInstanceModel(object instance, FlexDesignerHostServices services)
        {
            if (instance == null)
                return null;

            EditableModel model = GetTypeModel(instance.GetType());
            if (model != null)
            {
                return model.CloneFor(instance, services);
            }
            else if (instance is Field)
            {
                // Special case for custom fields derived from Field:
                return EditableModelT.NewModelT(instance.GetType(), instance, services);
            }
            else if (instance is ParagraphText)
            {
                model = GetTypeModel(typeof(ParagraphText));
                System.Diagnostics.Debug.Assert(model != null);
                return model.CloneFor(instance, services);
            }
            else
                return instance;
        }

        public static EditableModel GetTypeModel(Type type)
        {
            EditableModel model;
            s_typeModels.TryGetValue(type, out model);
            return model;
        }
    }

    internal abstract class EditableModel : CustomTypeDescriptor
    {
        /// <summary>
        /// Keys are property names, values lists of additional attributes.
        /// </summary>
        protected IDictionary<string, IList<Attribute>> _propertyAttributes;

        protected EditableModel(ICustomTypeDescriptor originalDescriptor)
            : base(originalDescriptor)
        {
            _propertyAttributes = new Dictionary<string, IList<Attribute>>();
        }
        public object Instance { get; protected set; }
        public static object GetInstance(object maybeModel)
        {
            if (maybeModel is EditableModel)
                return ((EditableModel)maybeModel).Instance;
            return maybeModel;
        }

        public override object GetPropertyOwner(PropertyDescriptor pd)
        {
            return Instance;
        }
        public FlexDesignerHostServices Services { get; set; }
        public void RegisterAttribute(string propName, Attribute attr)
        {
            IList<Attribute> attrs;
            if (!_propertyAttributes.TryGetValue(propName, out attrs))
                _propertyAttributes[propName] = new List<Attribute>();
            _propertyAttributes[propName].Add(attr);
        }
        /// <summary>
        /// Registers all registered attributes from another model.
        /// Mostly useful for derived types.
        /// </summary>
        /// <param name="other"></param>
        public void RegisterAttributesFromModel(EditableModel other)
        {
            foreach (var pas in other._propertyAttributes)
                foreach (var attr in pas.Value)
                    RegisterAttribute(pas.Key, attr);
        }
        public override PropertyDescriptorCollection GetProperties()
        {
            return GetProperties(null);
        }
        public abstract EditableModel CloneFor(object instance, FlexDesignerHostServices services);
    }

    internal class EditableModel<T> : EditableModel
    {
        private List<NestedPropertyDescriptor> _nestedProps = null;

        public static EditableModel<T> NewEditableModel()
        {
            return new EditableModel<T>(TypeDescriptor.GetProvider(typeof(T)).GetTypeDescriptor(typeof(T)));
        }

        protected EditableModel(ICustomTypeDescriptor originalDescriptor)
            : base(originalDescriptor)
        {
        }

        public void ExposeNestedProperty(string name, Type type, string topProp, string subProp, string category = null, string description = null)
        {
            if (_nestedProps == null)
                _nestedProps = new List<NestedPropertyDescriptor>();

            NestedPropertyDescriptor npd = new NestedPropertyDescriptor(name, type, typeof(T), topProp, subProp, category, description);
            _nestedProps.Add(npd);
        }

        public override EditableModel CloneFor(object instance, FlexDesignerHostServices services)
        {
            var model = NewEditableModel();
            model._propertyAttributes = this._propertyAttributes;
            model.Instance = instance;
            model.Services = services;
            model._nestedProps = this._nestedProps;
            return model;
        }

        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            var baseProps = base.GetProperties(attributes).Cast<PropertyDescriptor>();
            var newProps = baseProps.Select(pd =>
            {
                IList<Attribute> attrs;
                if (_propertyAttributes.TryGetValue(pd.Name, out attrs))
                    return TypeDescriptor.CreateProperty(typeof(T), pd, attrs.ToArray());
                else
                    return pd;
            });
            if (_nestedProps != null)
                newProps = newProps.Concat(_nestedProps);
            return new PropertyDescriptorCollection(newProps.ToArray());
        }
    }

    /// <summary>
    /// Special case for custom fields (always created on the fly, no cloning).
    /// ('nested props' feature is omitted here.)
    /// </summary>
    internal class EditableModelT : EditableModel<Field>
    {
        private Type _type;
        public static EditableModelT NewModelT(Type type, object instance, FlexDesignerHostServices services)
        {
            var model = new EditableModelT(type, TypeDescriptor.GetProvider(type).GetTypeDescriptor(type));
            model.Instance = instance;
            model.Services = services;
            model.RegisterAttributesFromModel(EditorsHelper.GetTypeModel(typeof(Field)));
            return model;
        }
        protected EditableModelT(Type type, ICustomTypeDescriptor originalDescriptor)
            : base(originalDescriptor)
        {
            _type = type;
        }
        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            var baseProps = base.GetProperties(attributes).Cast<PropertyDescriptor>();
            var newProps = baseProps.Select(pd =>
            {
                IList<Attribute> attrs;
                if (_propertyAttributes.TryGetValue(pd.Name, out attrs))
                    return TypeDescriptor.CreateProperty(_type, pd, attrs.ToArray());
                else
                    return pd;
            });
            return new PropertyDescriptorCollection(newProps.ToArray());
        }
    }

    /// <summary>
    /// Allows to expose a nested property as a top-level one.
    /// </summary>
    internal class NestedPropertyDescriptor : PropertyDescriptor
    {
        private Type _propertyType;
        private Type _componentType;
        private string _topPropertyName;
        private string _subPropertyName;
        private string _category;
        private string _description;

        /// <summary>
        /// Inits a new instance of the type.
        /// </summary>
        /// <param name="propertyName">The new (virtual) property's name.</param>
        /// <param name="propertyType">The property type (must be same as the real nested property type).</param>
        /// <param name="componentType">The owner object type.</param>
        /// <param name="topPropertyName">The name of the top complex property containing the nested property.</param>
        /// <param name="subPropertyName">The name of the nested property within <paramref name="topPropertyName"/></param>
        /// <param name="category">If specified, set as category attribute.</param>
        /// <param name="description">If specified, set as description attribute.</param>
        public NestedPropertyDescriptor(string propertyName, Type propertyType, Type componentType, string topPropertyName, string subPropertyName,
            string category = null, string description = null)
            : base(propertyName, new Attribute[] { })
        {
            _propertyType = propertyType;
            _componentType = componentType;
            _topPropertyName = topPropertyName;
            _subPropertyName = subPropertyName;
            _category = category;
            _description = description;
        }

        public override object GetValue(object component)
        {
            var top = _componentType.GetProperty(_topPropertyName).GetValue(component, null);
            return top.GetType().GetProperty(_subPropertyName).GetValue(top, null);
        }

        public override void SetValue(object component, object value)
        {
            var top = _componentType.GetProperty(_topPropertyName).GetValue(component, null);
            top.GetType().GetProperty(_subPropertyName).SetValue(top, value, null);
        }

        public override bool CanResetValue(object component) { return true; }
        public override Type ComponentType { get { return _componentType; } }
        public override bool IsReadOnly { get { return false; } }
        public override Type PropertyType { get { return _propertyType; } }
        public override void ResetValue(object component) { SetValue(component, null); }
        public override bool ShouldSerializeValue(object component) { return true; }
        public override string Category { get { return _category ?? base.Category; } }
        public override string Description { get { return _description ?? base.Description; } }
    }

    [AttributeUsage(AttributeTargets.Property)]
    internal class HiddenPropertiesAttribute : Attribute
    {
        private string[] _hiddenProperties;

        #region Constructors
        public HiddenPropertiesAttribute(params string[] hiddenProperties)
        {
            _hiddenProperties = hiddenProperties;
        }
        #endregion

        #region Public properties
        public string[] HiddenProperties
        {
            get { return _hiddenProperties; }
        }
        #endregion
    }

    /// <summary>
    /// Allows to associate EditableModel with an expandable property as if it were a 'root' object in the property grid.
    /// NOTE/todo/etc: while this does add the necessary attributes, the context Instance that the editors/converters get is,
    /// unlike the root object's props, the *REAL* instance of the object, not the EditableModel. This may break
    /// editors/converters that rely on instance being the model.
    /// </summary>
    internal class ExpandableObjectModelConverter : ExpandableObjectConverter
    {
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            EditableModel model = EditorsHelper.GetTypeModel(value.GetType());
            if (model != null)
            {
                var instanceModel = model.CloneFor(value, model.Services);
                var props = instanceModel.GetProperties(attributes);// note: do we really need attributes passed to use? there's some weird stuff there (like browsable/never).
                // AM 2016/11/02:
                // I do not understand why NOT browsable properties of expandable object
                // are visible in property grid
                for (int i = props.Count - 1; i >= 0; i--)
                    if (!props[i].IsBrowsable)
                        props.RemoveAt(i);
                if (context.PropertyDescriptor != null && context.PropertyDescriptor.Attributes != null)
                {
                    int i = 0;
                    while (i < context.PropertyDescriptor.Attributes.Count && !(context.PropertyDescriptor.Attributes[i] is HiddenPropertiesAttribute))
                        i++;
                    if (i < context.PropertyDescriptor.Attributes.Count)
                    {
                        HiddenPropertiesAttribute hpa = (HiddenPropertiesAttribute)context.PropertyDescriptor.Attributes[i];
                        if (hpa.HiddenProperties != null)
                        {
                            for (int j = 0; j < hpa.HiddenProperties.Length; j++)
                            {
                                int k = 0;
                                while (k < props.Count && props[k].Name != hpa.HiddenProperties[j])
                                    k++;
                                if (k < props.Count)
                                    props.RemoveAt(k);
                            }
                        }
                    }
                }
                return props; 
                // return instanceModel.GetProperties();
            }
            else
                return base.GetProperties(context, value, attributes);
        }
    }

    /// <summary>
    /// TODO: this is for value conversion ONLY, and looks like the wrong place for that.
    /// </summary>
    internal class EditableReportParameterModel : EditableModel<ReportParameter>
    {
        private static readonly PropertyDescriptor DataTypeProperty;

        static EditableReportParameterModel()
        {
            DataTypeProperty = TypeDescriptor.GetProperties(typeof (EditableReportParameterModel))["DataType"];
        }

        public static EditableReportParameterModel NewEditableReportParameterModel()
        {
            return new EditableReportParameterModel(TypeDescriptor.GetProvider(typeof(ReportParameter)).GetTypeDescriptor(typeof(ReportParameter)));
        }

        private EditableReportParameterModel(ICustomTypeDescriptor originalDescriptor)
            :base(originalDescriptor)
        {
            
        }

        public override EditableModel CloneFor(object instance, FlexDesignerHostServices services)
        {
            var model = NewEditableReportParameterModel();
            model._propertyAttributes = _propertyAttributes;
            model.Instance = instance;
            model.Services = services;
            return model;
        }

        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            var baseProps = base.GetProperties(attributes).Cast<PropertyDescriptor>();
            var newProps = baseProps.Select(pd =>
            {
                if (pd.Name == "DataType")
                {
                    var npd = TypeDescriptor.CreateProperty(typeof(EditableReportParameterModel), DataTypeProperty, DataTypeProperty.Attributes.OfType<Attribute>().ToArray());
                    return npd;
                }
                return pd;
            });
            return new PropertyDescriptorCollection(newProps.ToArray());
        }

        public override object GetPropertyOwner(PropertyDescriptor pd)
        {
            if (pd != null && pd.Name == "DataType")
                return this;
            return base.GetPropertyOwner(pd);
        }

        /// <summary>
        /// Shadow property of ReportParameter.DataType, to update the ReportParameter.Value to specific DataType.
        /// </summary>
        public Doc.ParameterType DataType
        {
            get { return ((ReportParameter) Instance).DataType; }
            set
            {
                var parameter = (ReportParameter)Instance;
                if (parameter.DataType == value)
                    return;

                var result = ParameterValueEditor.EnsureValueDataType(parameter.Value, value, parameter.ParentReport.ActualCulture);
                parameter.Value = ParameterValueEditor.ResolveValue(result, value, parameter.MultiValue);
                parameter.DataType = value;
            }
        }
    }
}
