//----------------------------------------------------------------------------
// ColorBlendEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using C1.Document;
using C1.Win.Localization;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    internal partial class ColorBlendEditor : BaseUserControl
    {
        public ColorBlendEditor()
        {
            InitializeComponent();
            var tooltip = MainForm.TheMainForm as ITooltipService;
            if (tooltip != null)
            {
                tooltip.SetToolTip(btnAdd, Strings.ColorBlendEditor.AddPointToolTip);
                tooltip.SetToolTip(btnRemove, Strings.ColorBlendEditor.RemovePointToolTip);
                tooltip.SetToolTip(gpeMain, Strings.ColorBlendEditor.PointsToolTip);
                tooltip.SetToolTip(pePosition, Strings.ColorBlendEditor.PointPositionToolTip);
                tooltip.SetToolTip(ceColor, Strings.ColorBlendEditor.PointColorToolTip);
            }
        }

        #region Private
        private GradientPoint AddPoint(
            float position,
            Color color)
        {
            var gp = new GradientPoint {Position = position, Color = color, Tag = new GradientStop(position, color)};
            gpeMain.GradientPoints.Add(gp);
            return gp;
        }
        #endregion

        #region Protected
        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
        #endregion

        #region Public
        public void Init()
        {
            pePosition.MinValue = 0;
            pePosition.MaxValue = 100;
        }

        private bool IsValid(GradientStopCollection stops)
        {
            if (stops == null) return false;
            if (stops.Count < 2) return false;
            return stops.All(stop => !(stop.Position < 0) && !(stop.Position > 1));
        }

        public void SetGradientStops(GradientStopCollection stops)
        {
            // initialize gpeMain.GradientPoints from ThemeBlend object
            gpeMain.BeginUpdate();
            gpeMain.GradientPoints.Clear();
            if (!IsValid(stops))
            {
                // initialize gpeMain.GradientPoints with default values 0,0 : 1,1
                AddPoint(0, Color.Black);
                AddPoint(1, Color.White);
            }
            else
            {
                foreach (var stop in stops)
                {
                    var gp = new GradientPoint {Position = (float) stop.Position, Color = stop.Color, Tag = stop};
                    gpeMain.GradientPoints.Add(gp);
                }
            }
            gpeMain.SelectedPoint = gpeMain.GradientPoints[0];
            gpeMain.EndUpdate();
        }

        public GradientStopCollection GetGradientStops()
        {
            // build ThemeColorBlend object from gpeMain.GradientPoints
            var items = new GradientStopCollection();
            foreach (GradientPoint p in gpeMain.GradientPoints)
                items.Add((GradientStop)p.Tag);
            return items;
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowTransparent
        {
            get { return ceColor.AllowTransparent; }
            set { ceColor.AllowTransparent = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color StartColor
        {
            get { return gpeMain.StartColor; }
            set { gpeMain.StartColor = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color EndColor
        {
            get { return gpeMain.EndColor; }
            set { gpeMain.EndColor = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientStop SelectedPoint
        {
            get
            {
                return gpeMain.SelectedPoint == null ? null : gpeMain.SelectedPoint.Tag as GradientStop;
            }
        }
        #endregion

        #region Events
        public event EventHandler Changed;
        #endregion

        private void gpeMain_SelectedPointChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            GradientStop tcbi = SelectedPoint;
            if (tcbi == null)
            {
                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                lblPosition.Enabled = false;
                lblColor.Enabled = false;
                pePosition.Enabled = false;
                ceColor.Enabled = false;
                BeginUpdate();
                pePosition.EditorValue = null;
                ceColor.EditorValue = null;
                EndUpdate();
            }
            else
            {
                btnAdd.Enabled = true;
                btnRemove.Enabled = gpeMain.GradientPoints.Count > 2;
                lblPosition.Enabled = true;
                lblColor.Enabled = true;
                pePosition.Enabled = true;
                ceColor.Enabled = true;
                BeginUpdate();
                pePosition.EditorValue = tcbi.Position;
                ceColor.EditorValue = tcbi.Color;
                EndUpdate();
            }
        }

        private void gpeMain_PointChanged(object sender, GradientPointEventArgs e)
        {
            if (UpdateLocked)
                return;

            var tcbi = (GradientStop)e.Point.Tag;
            e.Point.Tag = new GradientStop(e.Point.Position, tcbi.Color);
            BeginUpdate();
            pePosition.EditorValue = e.Point.Position;
            EndUpdate();
            OnChanged();
        }

        private void gpeMain_PointAdded(object sender, GradientPointEventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            e.Point.Tag = new GradientStop(e.Point.Position, e.Point.Color);
            EndUpdate();
            OnChanged();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SelectedPoint == null)
                return;

            gpeMain.AddPoint();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (SelectedPoint == null || gpeMain.GradientPoints.Count <= 2)
                return;

            gpeMain.GradientPoints.Remove(gpeMain.SelectedPoint);
            OnChanged();
        }

        private void pePosition_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            GradientStop tcbi = SelectedPoint;
            if (tcbi == null)
                return;

            BeginUpdate();
            var vPosition = (float) pePosition.EditorValue;
            gpeMain.SelectedPoint.Tag = new GradientStop(vPosition, tcbi.Color);
            gpeMain.SelectedPoint.Position = vPosition;
            EndUpdate();
            OnChanged();
        }

        private void ceColor_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            GradientStop tcbi = SelectedPoint;
            if (tcbi == null)
                return;

            BeginUpdate();
            var vColor = ceColor.ColorValue;
            gpeMain.SelectedPoint.Tag = new GradientStop(tcbi.Position, vColor);
            gpeMain.SelectedPoint.Color = vColor;

            EndUpdate();
            OnChanged();
        }
    }
}
