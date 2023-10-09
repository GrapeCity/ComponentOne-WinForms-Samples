//----------------------------------------------------------------------------
// MultiColorEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using C1.Win.Document;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    [ToolboxItem(true)]
    internal partial class MultiColorEditor : GradientColorsEditor
    {
        public MultiColorEditor()
        {
            InitializeComponent();
        }

        #region Public
        public override void Init(
            GradientBackgroundEditor owner,
            C1Brush brush)
        {
            base.Init(owner, brush);

            var gradientBrush = (C1GradientBrush)brush;
            tcbeColors.Init();
            tcbeColors.SetGradientStops(gradientBrush.GradientStops);
        }

        public override GradientStopCollection GetGradientStops()
        {
            return tcbeColors.GetGradientStops();
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowTransparent
        {
            get { return tcbeColors.AllowTransparent; }
            set
            {
                tcbeColors.AllowTransparent = value;
            }
        }
        #endregion

        private void tcbeColors_Changed(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            OnChanged();
        }
    }
}
