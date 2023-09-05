//----------------------------------------------------------------------------
// GradientCenterEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using C1.Win.Document;
using C1.Win.Localization;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Controls.Background.Editors;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    internal partial class GradientCenterEditor : BaseUserControl
    {
        public event EventHandler Changed;

        public GradientCenterEditor()
        {
            InitializeComponent();
            var tooltip = MainForm.TheMainForm as ITooltipService;
            if (tooltip != null)
            {
                tooltip.SetToolTip(neHorizontal, Strings.GradientCenterEditor.HorizontalToolTip);
                tooltip.SetToolTip(neVertical, Strings.GradientCenterEditor.VerticalToolTip);
            }
            //
            neHorizontal.NumericType = NumericType.Integer;
            neHorizontal.DecimalPlaces = 0;
            neHorizontal.Format = "{0}%";
            neVertical.NumericType = NumericType.Integer;
            neVertical.DecimalPlaces = 0;
            neVertical.Format = "{0}%";
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }

        public void Init()
        {
            neHorizontal.MinValue = 0;
            neHorizontal.MaxValue = 100;
            neVertical.MinValue = 0;
            neVertical.MaxValue = 100;
            BeginUpdate();
            neHorizontal.EditorValue= gccMain.GradientCenter.X;
            neVertical.EditorValue = gccMain.GradientCenter.Y;
            EndUpdate();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Point GradientCenter
        {
            get { return gccMain.GradientCenter; }
            set
            {
                if (GradientCenter == value)
                    return;

                gccMain.GradientCenter = value;
                BeginUpdate();
                neHorizontal.EditorValue = value.X;
                neVertical.EditorValue = value.Y;
                EndUpdate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientStopCollection GradientStops
        {
            get { return gccMain.GradientStops; }
            set { gccMain.GradientStops = value; }
        }

        private void gccMain_GradientCenterChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            neHorizontal.EditorValue = gccMain.GradientCenter.X;
            neVertical.EditorValue = gccMain.GradientCenter.Y;
            EndUpdate();
            OnChanged();
        }

        private void peHorizontal_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            gccMain.GradientCenter = new Point((int)neHorizontal.Value, gccMain.GradientCenter.Y);
            EndUpdate();
            OnChanged();
        }

        private void peVertical_EditorValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            BeginUpdate();
            gccMain.GradientCenter = new Point(gccMain.GradientCenter.X, (int)neVertical.Value);
            EndUpdate();
            OnChanged();
        }
    }
}
