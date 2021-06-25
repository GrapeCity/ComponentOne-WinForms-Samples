//----------------------------------------------------------------------------
// GradientBackgroundEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using C1.Win.Document;
using C1.Win.Input;
using C1.Win.Command;
using C1.Win.Localization;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors;
using GradientModeEditor = FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors.GradientModeEditor;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    [Flags]
    internal enum BrushType
    {
        None = 0x00,
        Solid = 0x01,
        RadialGradient = 0x02,
        LinearGradient = 0x4,
        Gradient = RadialGradient | LinearGradient,
        All = Solid | Gradient,
    }

    [ToolboxItem(true)]
    internal partial class GradientBackgroundEditor : BaseUserControl
    {
        private C1Brush _background;
        private BrushType _modeType = BrushType.LinearGradient;

        public event EventHandler BackgroundSelected;
        public event EventHandler Changed;

        public GradientBackgroundEditor()
        {
            InitializeComponent();
            var tooltip = MainForm.TheMainForm as ITooltipService;
            if (tooltip != null)
            {
                tooltip.SetToolTip(cbLinear, Strings.GradientBackgroundEditor.LinearToolTip);
                tooltip.SetToolTip(cbRadial, Strings.GradientBackgroundEditor.RadialToolTip);
            }
        }

        private void UpdateColors()
        {
            var stops = mceMultiColor.GetGradientStops();
            lgeLinear.UpdateGradientStops(stops);
            rgeRadial.UpdateGradientStops(stops);
        }

        private C1LinearBrush ConvertToLinearBrush(C1Brush brush)
        {
            if(brush==null)return new C1LinearBrush();

            var linearBrush = brush as C1LinearBrush;
            if (linearBrush != null) return linearBrush;

            var solidBrush = brush as C1SolidBrush;
            if (solidBrush != null)
            {
                linearBrush = new C1LinearBrush {StartColor = solidBrush.Color, EndColor = solidBrush.Color};
                return linearBrush;
            }

            var radialBrush = brush as C1RadialBrush;
            if (radialBrush != null)
            {
                linearBrush = new C1LinearBrush();
                foreach (var stop in radialBrush.GradientStops)
                {
                    linearBrush.GradientStops.Add(stop);
                }
                return linearBrush;
            }

            return new C1LinearBrush();
        }

        private C1RadialBrush ConvertToRadialBrush(C1Brush brush)
        {
            if (brush == null) return new C1RadialBrush();

            var radialBrush = brush as C1RadialBrush;
            if (radialBrush != null) return radialBrush;

            var solidBrush = brush as C1SolidBrush;
            if (solidBrush != null)
            {
                radialBrush = new C1RadialBrush { CenterColor = solidBrush.Color, SurroundColor = solidBrush.Color};
                return radialBrush;
            }

            var linearBrush = brush as C1LinearBrush;
            if (linearBrush != null)
            {
                radialBrush = new C1RadialBrush();
                foreach (var stop in linearBrush.GradientStops)
                {
                    radialBrush.GradientStops.Add(stop);
                }
                return radialBrush;
            }

            return new C1RadialBrush();
        }

        private BrushType GetBrushType(C1Brush brush)
        {
            if(brush ==null)return BrushType.None;
            if(brush is C1SolidBrush) return BrushType.Solid;
            if(brush is C1LinearBrush)return BrushType.LinearGradient;
            if(brush is C1RadialBrush)return BrushType.RadialGradient;
            return BrushType.None;
        }

        private void OnBackgroundSelected()
        {
            if (BackgroundSelected != null)
                BackgroundSelected(this, EventArgs.Empty);
        }

        public void Init(C1Brush background)
        {
            _background = background;

            BeginUpdate();

            cbLinear.Checked = true;
            cbRadial.Checked = false;
            lgeLinear.Visible = true;
            rgeRadial.Visible = false;
            
            var linearBrush = ConvertToLinearBrush(background);
            lgeLinear.Init(this, linearBrush);
            var radialBrush = ConvertToRadialBrush(background);
            mceMultiColor.Init(this, radialBrush);
            rgeRadial.Init(this, radialBrush);

            var brushType = GetBrushType(background);
            if ((brushType & BrushType.Gradient) != 0)
                ModeType = brushType & BrushType.Gradient;
            else
            {
                ModeType = BrushType.LinearGradient;
            }

            UpdateColors();

            EndUpdate();
        }

        private C1Brush GetBackground()
        {
            var brush = ModeEditor.GetBrush();
            var stops = mceMultiColor.GetGradientStops().ToArray();
            if (ModeType == BrushType.RadialGradient)
                stops = stops.Reverse().ToArray();
            brush.GradientStops.Clear();
            foreach (var stop in stops)
            {
                brush.GradientStops.Add(stop);
            }
            
            return brush;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1Brush Background
        {
            get { return _background; }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BrushType ModeType
        {
            get { return _modeType; }
            set
            {
                if (_modeType == value)
                    return;

                _modeType = value;

                var isLinear = _modeType == BrushType.LinearGradient;
                var isRadial = _modeType == BrushType.RadialGradient;
                cbLinear.Checked = isLinear;
                cbLinear.TabStop = !isLinear;
                cbRadial.Checked = isRadial;
                cbRadial.TabStop = !isRadial;
                lgeLinear.Visible = isLinear;
                rgeRadial.Visible = isRadial;
                if (isLinear && cbRadial.Focused)
                    cbLinear.Focus();
                if (isRadial && cbLinear.Focused)
                    cbRadial.Focus();

                OnChanged();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GradientModeEditor ModeEditor
        {
            get
            {
                if (_modeType == BrushType.LinearGradient) return lgeLinear;
                if (_modeType == BrushType.RadialGradient) return rgeRadial;
                return null;
            }
        }

        private void lgeLinear_Changed(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;

            OnChanged();
        }

        private void cbLinear_Click(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            ModeType = BrushType.LinearGradient;
        }

        private void cbRadial_Click(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            ModeType = BrushType.RadialGradient;
        }

        private void mceMultiColor_Changed(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            
            UpdateColors();
            OnChanged();
        }

        private void OnChanged()
        {
            _background = GetBackground();

            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnBackgroundSelected();
        }
    }
}
