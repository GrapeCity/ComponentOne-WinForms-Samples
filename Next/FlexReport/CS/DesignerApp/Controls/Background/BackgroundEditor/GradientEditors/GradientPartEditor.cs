//----------------------------------------------------------------------------
// GradientPartEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    [ToolboxItem(false)]
    internal partial class GradientPartEditor : BaseUserControl
    {
        protected GradientBackgroundEditor m_Owner;

        public GradientPartEditor()
        {
            InitializeComponent();
        }

        #region Protected
        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
        #endregion

        #region Public

        public virtual bool IsValid()
        {
            return true;
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientBackgroundEditor Owner
        {
            get { return m_Owner; }
        }

        #endregion

        #region Events

        public event EventHandler Changed;

        #endregion
    }
}
