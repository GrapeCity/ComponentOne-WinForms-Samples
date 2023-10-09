//----------------------------------------------------------------------------
// CMapCollectionEditors.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexReport.CustomFields;
using C1.Win.FlexReport.CustomFields.Maps;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors.CustomMapField
{
    internal class CMapLayersCollectionEditor : LayerCollection.LayerCollectionEditor
    {
        protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
        {
            base.OnGridSelectedObjectsChanged(propGrid);

            var layer = propGrid.SelectedObject as LayerBase;
            if (layer != null)
            {
                propGrid.SelectedObject = EditorsHelper.CreateInstanceModel(layer,
                    MainForm.TheMainForm.DesignerHostServices);
            }
        }

        protected override CollectionForm CreateCollectionForm()
        {
            const string stateName = "CustomMapFieldLayersCollectionEditorState";

            var form = base.CreateCollectionForm();
            var sps = MainForm.TheMainForm.DesignerHostServices.GetService(typeof(ISettingsPersisterService)) as ISettingsPersisterService;
            if (sps != null)
            {
                var state = new UiWindowState();
                form.Closing += (s, e) =>
                {
                    state.Bounds = form.DesktopBounds;
                    sps.SaveObject(stateName, state);
                };

                sps.LoadObject(stateName, state);
                if (!state.Bounds.IsEmpty)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.DesktopBounds = state.Bounds;
                }
            }

            return form;
        }
    }

    internal class CMapKmlItemStylesCollectionEditor : KmlItemStyleCollection.KmlItemStyleCollectionEditor
    {
        protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
        {
            base.OnGridSelectedObjectsChanged(propGrid);

            var style = propGrid.SelectedObject as MapStyleBase;
            if (style != null)
            {
                propGrid.SelectedObject = EditorsHelper.CreateInstanceModel(style,
                    MainForm.TheMainForm.DesignerHostServices);
            }
        }

        protected override CollectionForm CreateCollectionForm()
        {
            const string stateName = "CustomMapFieldKmlItemStylesCollectionEditorState";

            var form = base.CreateCollectionForm();
            var sps = MainForm.TheMainForm.DesignerHostServices.GetService(typeof(ISettingsPersisterService)) as ISettingsPersisterService;
            if (sps != null)
            {
                var state = new UiWindowState();
                form.Closing += (s, e) =>
                {
                    state.Bounds = form.DesktopBounds;
                    sps.SaveObject(stateName, state);
                };

                sps.LoadObject(stateName, state);
                if (!state.Bounds.IsEmpty)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.DesktopBounds = state.Bounds;
                }
            }

            return form;
        }
    }

    internal class CMapMarkerStylesCollectionEditor : MarkerStyleCollection.MarkerStyleCollectionEditor
    {
        protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
        {
            base.OnGridSelectedObjectsChanged(propGrid);

            var style = propGrid.SelectedObject as MapStyleBase;
            if (style != null)
            {
                propGrid.SelectedObject = EditorsHelper.CreateInstanceModel(style,
                    MainForm.TheMainForm.DesignerHostServices);
            }
        }

        protected override CollectionForm CreateCollectionForm()
        {
            const string stateName = "CustomMapFieldMarkerStylesCollectionEditorState";

            var form = base.CreateCollectionForm();
            var sps = MainForm.TheMainForm.DesignerHostServices.GetService(typeof(ISettingsPersisterService)) as ISettingsPersisterService;
            if (sps != null)
            {
                var state = new UiWindowState();
                form.Closing += (s, e) =>
                {
                    state.Bounds = form.DesktopBounds;
                    sps.SaveObject(stateName, state);
                };

                sps.LoadObject(stateName, state);
                if (!state.Bounds.IsEmpty)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.DesktopBounds = state.Bounds;
                }
            }

            return form;
        }
    }

    internal class CMapLineStylesCollectionEditor : LineStyleCollection.LineStyleCollectionEditor
    {
        protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
        {
            base.OnGridSelectedObjectsChanged(propGrid);

            var style = propGrid.SelectedObject as MapStyleBase;
            if (style != null)
            {
                propGrid.SelectedObject = EditorsHelper.CreateInstanceModel(style,
                    MainForm.TheMainForm.DesignerHostServices);
            }
        }

        protected override CollectionForm CreateCollectionForm()
        {
            const string stateName = "CustomMapFieldLineStylesCollectionEditorState";

            var form = base.CreateCollectionForm();
            var sps = MainForm.TheMainForm.DesignerHostServices.GetService(typeof(ISettingsPersisterService)) as ISettingsPersisterService;
            if (sps != null)
            {
                var state = new UiWindowState();
                form.Closing += (s, e) =>
                {
                    state.Bounds = form.DesktopBounds;
                    sps.SaveObject(stateName, state);
                };

                sps.LoadObject(stateName, state);
                if (!state.Bounds.IsEmpty)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.DesktopBounds = state.Bounds;
                }
            }

            return form;
        }
    }

    internal class CMapLegendsCollectionEditor : LegendCollection.LegendCollectionEditor
    {
        protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
        {
            base.OnGridSelectedObjectsChanged(propGrid);

            var legend = propGrid.SelectedObject as Legend;
            if (legend != null)
            {
                propGrid.SelectedObject = EditorsHelper.CreateInstanceModel(legend,
                    MainForm.TheMainForm.DesignerHostServices);
            }
        }

        protected override CollectionForm CreateCollectionForm()
        {
            const string stateName = "CustomMapFieldLegendsCollectionEditorState";

            var form = base.CreateCollectionForm();
            var sps = MainForm.TheMainForm.DesignerHostServices.GetService(typeof(ISettingsPersisterService)) as ISettingsPersisterService;
            if (sps != null)
            {
                var state = new UiWindowState();
                form.Closing += (s, e) =>
                {
                    state.Bounds = form.DesktopBounds;
                    sps.SaveObject(stateName, state);
                };

                sps.LoadObject(stateName, state);
                if (!state.Bounds.IsEmpty)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.DesktopBounds = state.Bounds;
                }
            }

            return form;
        }
    }

    internal class CMapLegendItemsCollectionEditor : LegendItemCollection.LegendItemCollectionEditor
    {
        protected override void OnGridSelectedObjectsChanged(PropertyGrid propGrid)
        {
            base.OnGridSelectedObjectsChanged(propGrid);

            var legendItem = propGrid.SelectedObject as LegendItemBase;
            if (legendItem != null)
            {
                propGrid.SelectedObject = EditorsHelper.CreateInstanceModel(legendItem,
                    MainForm.TheMainForm.DesignerHostServices);
            }
        }

        protected override CollectionForm CreateCollectionForm()
        {
            const string stateName = "CustomMapFieldLegendItemsCollectionEditorState";

            var form = base.CreateCollectionForm();
            var sps = MainForm.TheMainForm.DesignerHostServices.GetService(typeof(ISettingsPersisterService)) as ISettingsPersisterService;
            if (sps != null)
            {
                var state = new UiWindowState();
                form.Closing += (s, e) =>
                {
                    state.Bounds = form.DesktopBounds;
                    sps.SaveObject(stateName, state);
                };

                sps.LoadObject(stateName, state);
                if (!state.Bounds.IsEmpty)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.DesktopBounds = state.Bounds;
                }
            }

            return form;
        }
    }
}
