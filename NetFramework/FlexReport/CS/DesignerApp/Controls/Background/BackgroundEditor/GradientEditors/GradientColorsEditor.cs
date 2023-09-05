//----------------------------------------------------------------------------
// GradientColorsEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.ComponentModel;
using C1.Win.C1Document;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    [ToolboxItem(false)]
    internal partial class GradientColorsEditor : GradientPartEditor
    {
        public GradientColorsEditor()
        {
            InitializeComponent();
        }

        #region Public
        public virtual void Init(
            GradientBackgroundEditor owner,
            C1Brush brush)
        {
            m_Owner = owner;
        }

        public virtual GradientStopCollection GetGradientStops()
        {
            return null;
        }
        #endregion
    }
}
