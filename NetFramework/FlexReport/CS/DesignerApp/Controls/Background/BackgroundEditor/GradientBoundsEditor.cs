//----------------------------------------------------------------------------
// GradientBoundsEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1Document;
using C1.Win.Localization;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Controls.Background.Editors;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    internal partial class GradientBoundsEditor : BaseUserControl
    {
        private static readonly Dictionary<LinearGradientMode, Point[]>  ModePoints = new Dictionary<LinearGradientMode, Point[]>();

        public event EventHandler Changed;

        static GradientBoundsEditor()
        {
            ModePoints.Add(LinearGradientMode.Horizontal, new[] {new Point(0, 50), new Point(100, 50)});
            ModePoints.Add(LinearGradientMode.Vertical, new[] { new Point(50, 0), new Point(50, 100) });
            ModePoints.Add(LinearGradientMode.ForwardDiagonal, new[] { new Point(0, 0), new Point(100, 100) });
            ModePoints.Add(LinearGradientMode.BackwardDiagonal, new[] { new Point(0, 100), new Point(100, 0) });
        }

        public GradientBoundsEditor()
        {
            InitializeComponent();
            var tooltip = MainForm.TheMainForm as ITooltipService;
            if (tooltip != null)
            {
                tooltip.SetToolTip(cbStartPoint, Strings.GradientBoundsEditor.StartPointToolTip);
                tooltip.SetToolTip(cbEndPoint, Strings.GradientBoundsEditor.EndPointToolTip);
                tooltip.SetToolTip(lgmeMode, Strings.GradientBoundsEditor.ModeToolTip);
                tooltip.SetToolTip(neStartX, Strings.GradientBoundsEditor.StartXToolTip);
                tooltip.SetToolTip(neStartY, Strings.GradientBoundsEditor.StartYToolTip);
                tooltip.SetToolTip(neEndX, Strings.GradientBoundsEditor.EndXToolTip);
                tooltip.SetToolTip(neEndY, Strings.GradientBoundsEditor.EndYToolTip);
            }
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }

        public void Init()
        {
            BeginUpdate();
            neStartX.EditorValue = gbcMain.GradientStart.X;
            neStartY.EditorValue = gbcMain.GradientStart.Y;
            neEndX.EditorValue = gbcMain.GradientEnd.X;
            neEndY.EditorValue = gbcMain.GradientEnd.Y;
            UpdateMode();
            EndUpdate();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Point GradientStart
        {
            get { return gbcMain.GradientStart; }
            set
            {
                if (GradientStart == value)
                    return;

                gbcMain.GradientStart = value;
                BeginUpdate();
                neStartX.EditorValue = value.X;
                neStartY.EditorValue = value.Y;
                UpdateMode();
                EndUpdate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Point GradientEnd
        {
            get { return gbcMain.GradientEnd; }
            set
            {
                if (GradientEnd == value)
                    return;

                gbcMain.GradientEnd = value;
                BeginUpdate();
                neEndX.EditorValue = value.X;
                neEndY.EditorValue = value.Y;
                UpdateMode();
                EndUpdate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientStopCollection GradientStops
        {
            get { return gbcMain.GradientStops; }
            set { gbcMain.GradientStops = value; }
        }

        private void UpdateMode()
        {
            object mode = -1;
            foreach (var pair in ModePoints)
            {
                var points = pair.Value;
                if (points[0] == GradientStart && points[1] == GradientEnd)
                {
                    mode = pair.Key;
                    break;
                }
            }
            lgmeMode.EditorValue = mode;
        }

        private void cbStartPoint_Click(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            gbcMain.ActiveCorner = GradientBoundsControl.Corner.Start;
            cbStartPoint.Checked = true;
            cbStartPoint.TabStop = false;
            cbEndPoint.Checked = false;
            cbEndPoint.TabStop = true;
        }

        private void cbEndPoint_Click(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            gbcMain.ActiveCorner= GradientBoundsControl.Corner.End;
            cbStartPoint.Checked = false;
            cbStartPoint.TabStop = true;
            cbEndPoint.Checked = true;
            cbEndPoint.TabStop = false;
        }

        private void gbcMain_GradientStartChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            UpdateMode();
            neStartX.EditorValue = gbcMain.GradientStart.X;
            neStartY.EditorValue = gbcMain.GradientStart.Y;
            EndUpdate();
            OnChanged();
        }

        private void gbcMain_GradientEndChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            UpdateMode();
            neEndX.EditorValue = gbcMain.GradientEnd.X;
            neEndY.EditorValue = gbcMain.GradientEnd.Y;
            EndUpdate();
            OnChanged();
        }

        private void neStartX_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            gbcMain.GradientStart = new Point((int)neStartX.Value, gbcMain.GradientStart.Y);
            UpdateMode();
            EndUpdate();
            OnChanged();
        }

        private void neStartY_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            gbcMain.GradientStart = new Point(gbcMain.GradientStart.X, (int)neStartY.Value);
            UpdateMode();
            EndUpdate();
            OnChanged();
        }

        private void neEndX_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            gbcMain.GradientEnd = new Point((int)neEndX.Value, gbcMain.GradientEnd.Y);
            UpdateMode();
            EndUpdate();
            OnChanged();
        }

        private void neEndY_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            gbcMain.GradientEnd = new Point(gbcMain.GradientEnd.X, (int)neEndY.Value);
            UpdateMode();
            EndUpdate();
            OnChanged();
        }

        private void lgmeMode_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            var mode = (LinearGradientMode) lgmeMode.EditorValue;

            Point[] points;
            if(!ModePoints.TryGetValue(mode, out points))
                return;

            BeginUpdate();
            GradientStart = points[0];
            GradientEnd = points[1];
            EndUpdate();
            OnChanged();
        }

        private void gbcMain_ActiveCornerChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            cbStartPoint.Checked = gbcMain.ActiveCorner == GradientBoundsControl.Corner.Start;
            cbStartPoint.TabStop = !cbStartPoint.Checked;
            cbEndPoint.Checked = gbcMain.ActiveCorner == GradientBoundsControl.Corner.End;
            cbEndPoint.TabStop = !cbEndPoint.Checked;
            EndUpdate();
        }
    }
}
