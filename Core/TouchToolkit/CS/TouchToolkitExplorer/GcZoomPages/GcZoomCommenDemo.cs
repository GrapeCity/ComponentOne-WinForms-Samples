using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TouchToolkitExplorer.C1ZoomPages.Help_Forms;
using C1.Win.TouchToolKit;

namespace TouchToolkitExplorer.C1ZoomPages
{
    public partial class C1ZoomCommenDemo : DemoBase
    {
        public C1ZoomCommenDemo()
        {
            InitializeComponent();
            InitializeDemo();
        }

        C1Zoom _gcZoom = new C1Zoom();

        private void InitializeDemo()
        {
            this.Title = "C1Zoom Basic (Zoom and Scroll)";
            this.Description = @"This page is used to try basic features of C1Zoom. 
  - Click the Show Form Button to show a test form. And test the Gestrue zoom/scroll.
  - Try to change the settings to knows how to config the C1Zoom.";

            AddEnumItemsToComboBox(ZoomPreviewModeComboBox, typeof(ZoomPreviewMode));
            AddEnumItemsToComboBox(scrollIndicatorCombo, typeof(ScrollIndicatorMode));
            formatComboBox.Items.Add("Zooming {Percentage}%");
            formatComboBox.Items.Add("Zooming x{ZoomFactor}");

            scrollIndicatorCombo.SelectedItem = _gcZoom.ScrollIndicatorMode;
            ZoomPreviewModeComboBox.SelectedItem = _gcZoom.ZoomPreviewMode;
            formatComboBox.SelectedIndex = 0;
            displayLabel.Font = _gcZoom.AlternativeContentSettings.Font;
            displayLabel.ForeColor = _gcZoom.AlternativeContentSettings.ForeColor;
            HorizontalRailEnableCheckBox.DataBindings.Add("Checked", _gcZoom, "IsHorizontalRailEnabled");
            VerticalRailEnableCheckBox.DataBindings.Add("Checked", _gcZoom, "IsVerticalRailEnabled");
            AllowDoubleTapZoomCheckBox.DataBindings.Add("Checked", _gcZoom, "AllowDoubleTapZoom");
            KeepAspectRatioCheckBox.DataBindings.Add("Checked", _gcZoom, "KeepAspectRatio");
            scrollIndicatorCombo.DataBindings.Add("SelectedItem", _gcZoom, "ScrollIndicatorMode");
            boundaryFeedbackUI1.DataBindings.Add("BoundaryFeedbackMode", _gcZoom, "BoundaryFeedbackMode");

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
                _gcZoom.Target = form;
                form.ShowDialog(this);
                // The _gcZoom will auto detach when the Form dispose.
                //_gcZoom.SetEnabled(form, false);
            }
        }

        void ZoomPreviewModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _gcZoom.ZoomPreviewMode = (ZoomPreviewMode)ZoomPreviewModeComboBox.SelectedItem;

            this.alternativeContentGroup.Visible = false;
            this.NoPreivewInfoPanel.Visible = false;
            this.boundaryFeedbackUI1.Visible = false;
            switch (_gcZoom.ZoomPreviewMode)
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
                _gcZoom.AlternativeContentSettings.Format = formatComboBox.Text;
                displayLabel.Text = formatComboBox.Text.Replace("{Percentage}", "100").Replace("{ZoomFactor}", "1.00"); ;
            }
        }

        void ForeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                _gcZoom.AlternativeContentSettings.ForeColor = dialog.Color;
                displayLabel.ForeColor = dialog.Color;
            }
        }

        void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                _gcZoom.AlternativeContentSettings.Font = dialog.Font;
                displayLabel.Font = dialog.Font;
            }
        }

        void boundaryFeedbackUI1_BoundaryFeedbackModeChanged(object sender, EventArgs e)
        {
            _gcZoom.BoundaryFeedbackMode = boundaryFeedbackUI1.BoundaryFeedbackMode;
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
