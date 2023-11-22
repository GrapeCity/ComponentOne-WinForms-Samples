//----------------------------------------------------------------------------
// GradientModeEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.ComponentModel;
using C1.Win.C1Document;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    [ToolboxItem(false)]
    internal partial class GradientModeEditor : GradientPartEditor
    {
        public GradientModeEditor()
        {
            InitializeComponent();
        }

        #region Public
        public virtual void Init(
            GradientBackgroundEditor owner,
            C1GradientBrush brush)
        {
            m_Owner = owner;
        }

        public virtual C1GradientBrush GetBrush()
        {
            return null;
        }

        public virtual void UpdateGradientStops(
            GradientStopCollection stops)
        {
        }
        #endregion
    }
}
