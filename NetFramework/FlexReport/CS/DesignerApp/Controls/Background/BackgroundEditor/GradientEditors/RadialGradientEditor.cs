//----------------------------------------------------------------------------
// RadialGradientEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using C1.Win.C1Document;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    [ToolboxItem(true)]
    internal partial class RadialGradientEditor : GradientModeEditor
    {
        public RadialGradientEditor()
        {
            InitializeComponent();
        }

        #region Public
        public override void Init(
            GradientBackgroundEditor owner,
            C1GradientBrush brush)
        {
            m_Owner = owner;

            var radialBrush = (C1RadialBrush)brush;
            gceCenter.Init();
            var center = new Point((int)(radialBrush.Center.X*100), (int)(radialBrush.Center.Y*100));
            gceCenter.GradientCenter = center;
        }

        public override C1GradientBrush GetBrush()
        {
            var brush = new C1RadialBrush();
            var center = new C1.Win.Interop.Point(gceCenter.GradientCenter.X/100d, gceCenter.GradientCenter.Y/100d);
            brush.Center = center;
            return brush;
        }

        public override void UpdateGradientStops(
            GradientStopCollection stops)
        {
            gceCenter.GradientStops = stops;
        }

        #endregion

        private void gceCenter_Changed(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            OnChanged();
        }
    }
}
