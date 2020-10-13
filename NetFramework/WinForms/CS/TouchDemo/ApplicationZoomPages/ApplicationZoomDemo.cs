using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;

namespace TouchToolKitDemo.C1ApplicationZoomPages
{
    public partial class C1ApplicationZoomDemo : DemoBase
    {
        public C1ApplicationZoomDemo()
        {
            InitializeComponent();

            this.Description = "User can add a component to MainForm (startup form),  then it add touch-zoom capability to all Forms. " +
                               "It will be a simplest way for most WinForms Application.";

            InitializeDemo();
            this._C1Zoom.ZoomPolicies.Add(new MyImageButtonZoomPolicy());
            this._C1Zoom.C1ZoomAttaching += C1ApplicationZoom1_C1ZoomAttaching;
        }

        void C1ApplicationZoom1_C1ZoomAttaching(object sender, C1ZoomAttachingEventArgs e)
        {
            if ((e.Form is AppZoom_Main)
                || (e.Form is AppZoom_Child1)
                || (e.Form is AppZoom_Child2)
                || (e.Form is AppZoom_Child3))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        C1ApplicationZoom _C1Zoom = new C1ApplicationZoom();

        private void InitializeDemo()
        {
            this.Title = "C1ApplicationZoom";
            this.Description = @"This page demonstrates how to use C1ZoomApplication's features and its following properties: ZoomPreviewMode, BoundaryFeedbackMode, AllowDoubleTapZoom, ScrollIndicatorMode, IsHorizontalRailEnabled, IsVerticalRailEnabled, and KeepAspectRatio. Select the settings for these properties on the page and click the Show Form button see how these settings effect the zooming.";

            AddEnumItemsToComboBox(ZoomPreviewModeComboBox, typeof(ZoomPreviewMode));
            AddEnumItemsToComboBox(scrollIndicatorCombo, typeof(ScrollIndicatorMode));
            formatComboBox.Items.Add("Zooming {Percentage}%");
            formatComboBox.Items.Add("Zooming x{ZoomFactor}");

            scrollIndicatorCombo.SelectedItem = _C1Zoom.ScrollIndicatorMode;
            ZoomPreviewModeComboBox.SelectedItem = _C1Zoom.ZoomPreviewMode;
            formatComboBox.SelectedIndex = 0;
            displayLabel.Font = _C1Zoom.AlternativeContentSettings.Font;
            displayLabel.ForeColor = _C1Zoom.AlternativeContentSettings.ForeColor;
            HorizontalRailEnableCheckBox.DataBindings.Add("Checked", _C1Zoom, "IsHorizontalRailEnabled");
            VerticalRailEnableCheckBox.DataBindings.Add("Checked", _C1Zoom, "IsVerticalRailEnabled");
            AllowDoubleTapZoomCheckBox.DataBindings.Add("Checked", _C1Zoom, "AllowDoubleTapZoom");
            KeepAspectRatioCheckBox.DataBindings.Add("Checked", _C1Zoom, "KeepAspectRatio");
            scrollIndicatorCombo.DataBindings.Add("SelectedItem", _C1Zoom, "ScrollIndicatorMode");
            boundaryFeedbackUI1.DataBindings.Add("BoundaryFeedbackMode", _C1Zoom, "BoundaryFeedbackMode");

            ZoomPreviewModeComboBox.SelectedIndexChanged += ZoomPreviewModeComboBox_SelectedIndexChanged;
            formatComboBox.TextChanged += formatComboBox_TextChanged;
            FontButton.Click += FontButton_Click;
            ForeColorButton.Click += ForeColorButton_Click;
            formButton.Click += formButton_Click;
            _C1Zoom.C1ZoomAttached += _C1Zoom_C1ZoomAttached;
            boundaryFeedbackUI1.BoundaryFeedbackModeChanged += boundaryFeedbackUI1_BoundaryFeedbackModeChanged;
        }

        void _C1Zoom_C1ZoomAttached(object sender, C1ZoomAttachedEventArgs e)
        {
            if (e.Form is AppZoom_Child3)
            {
                e.GcZoom.InnerPanelLayoutMode = InnerPanelLayoutMode.MiddleCenter;
                e.GcZoom.AllowResizeByZoom = true;
            }
        }

        void formButton_Click(object sender, EventArgs e)
        {
            using (AppZoom_Main form = new AppZoom_Main())
            {
                form.ShowDialog(this);
            }
        }

        void ZoomPreviewModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _C1Zoom.ZoomPreviewMode = (ZoomPreviewMode)ZoomPreviewModeComboBox.SelectedItem;

            this.alternativeContentGroup.Visible = false;
            this.NoPreivewInfoPanel.Visible = false;
            this.boundaryFeedbackUI1.Visible = false;
            switch (_C1Zoom.ZoomPreviewMode)
            {
                case ZoomPreviewMode.Bitmap:
                    this.boundaryFeedbackUI1.Visible = true;
                    break;
                case ZoomPreviewMode.NoPreview:
                    this.NoPreivewInfoPanel.Visible = true;
                    break;
                case ZoomPreviewMode.AlternativeContent:
                    this.alternativeContentGroup.Visible = true;
                    break;
                default:
                    break;
            }
        }

        void formatComboBox_TextChanged(object sender, EventArgs e)
        {
            if (formatComboBox.Text != null)
            {
                _C1Zoom.AlternativeContentSettings.Format = formatComboBox.Text;
                displayLabel.Text = formatComboBox.Text.Replace("{Percentage}", "100").Replace("{ZoomFactor}", "1.00"); ;
            }
        }

        void ForeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                _C1Zoom.AlternativeContentSettings.ForeColor = dialog.Color;
                displayLabel.ForeColor = dialog.Color;
            }
        }

        void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                _C1Zoom.AlternativeContentSettings.Font = dialog.Font;
                displayLabel.Font = dialog.Font;
            }
        }

        void boundaryFeedbackUI1_BoundaryFeedbackModeChanged(object sender, EventArgs e)
        {
            _C1Zoom.BoundaryFeedbackMode = boundaryFeedbackUI1.BoundaryFeedbackMode;
        }

        private void AddEnumItemsToComboBox(ComboBox comboBox, Type enumType)
        {
            Array enumArray = Enum.GetValues(enumType);
            for (int i = 0; i < enumArray.Length; i++)
            {
                comboBox.Items.Add(enumArray.GetValue(i));
            }
        }
    }
}
