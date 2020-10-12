using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TouchToolKitDemo.C1ZoomPages.Help_Forms;
using C1.Win.TouchToolKit;

namespace TouchToolKitDemo.C1ZoomPages
{
    public partial class C1ZoomCommenDemo : DemoBase
    {
        public C1ZoomCommenDemo()
        {
            InitializeComponent();
            InitializeDemo();
        }

        C1Zoom _C1Zoom = new C1Zoom();

        private void InitializeDemo()
        {
            this.Title = "C1Zoom Basic (Zoom and Scroll)";
            this.Description = @"This page demonstrates how to use C1Zoom’s features and its following properties: ZoomPreviewMode, BoundaryFeedbackMode, AllowDoubleTapZoom, ScrollIndicatorMode, IsHorizontalRailEnabled, IsVerticalRailEnabled, and KeepAspectRatio.  Select the settings for these properties on the page and click the Show Form button to see how these settings effect the zooming.";

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
            boundaryFeedbackUI1.BoundaryFeedbackModeChanged += boundaryFeedbackUI1_BoundaryFeedbackModeChanged;
        }

        void formButton_Click(object sender, EventArgs e)
        {
            using (C1ZoomCommenForm form = new C1ZoomCommenForm())
            {
                _C1Zoom.Target = form;
                form.ShowDialog(this);
                // The _C1Zoom will auto detach when the Form dispose.
                //_C1Zoom.SetEnabled(form, false);
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
