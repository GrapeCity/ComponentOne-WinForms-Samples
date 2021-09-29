//----------------------------------------------------------------------------
// LinearGradientEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using C1.Win.Document;
using NSD = C1.Win.Interop;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    [ToolboxItem(true)]
    internal partial class LinearGradientEditor : GradientModeEditor
    {
        public LinearGradientEditor()
        {
            InitializeComponent();
        }

        #region Public
        public override void Init(
            GradientBackgroundEditor owner,
            C1GradientBrush brush)
        {
            m_Owner = owner;
            
            var linearBrush = (C1LinearBrush)brush;
            gbeBounds.Init();
            gbeBounds.GradientStart = new Point((int) (linearBrush.StartPoint.X*100),
                (int) (linearBrush.StartPoint.Y*100));
            gbeBounds.GradientEnd = new Point((int)(linearBrush.EndPoint.X * 100),
                (int)(linearBrush.EndPoint.Y * 100));
        }

        public override bool IsValid()
        {
            return true;
        }

        public override C1GradientBrush GetBrush()
        {
            var brush = new C1LinearBrush
            {
                StartPoint = new NSD.Point(gbeBounds.GradientStart.X/100d, gbeBounds.GradientStart.Y/100d),
                EndPoint = new NSD.Point(gbeBounds.GradientEnd.X/100d, gbeBounds.GradientEnd.Y/100d)
            };
            return brush;
        }

        public override void UpdateGradientStops(
            GradientStopCollection stops)
        {
            gbeBounds.GradientStops = stops;
        }

        #endregion

        private void gbeBounds_Changed(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            OnChanged();
        }
    }
}
