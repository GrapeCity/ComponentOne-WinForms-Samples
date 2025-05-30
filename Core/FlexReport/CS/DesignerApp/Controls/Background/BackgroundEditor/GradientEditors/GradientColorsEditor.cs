﻿//----------------------------------------------------------------------------
// GradientColorsEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.ComponentModel;
using C1.Document;

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
