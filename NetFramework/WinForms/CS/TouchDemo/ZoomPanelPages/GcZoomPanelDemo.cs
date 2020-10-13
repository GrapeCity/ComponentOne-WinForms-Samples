using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;
using TouchToolKitDemo.C1ZoomPages.Help_Forms;

namespace TouchToolKitDemo.C1ZoomPanelPages
{
    public partial class C1ZoomPanelDemo : DemoBase
    {
        public C1ZoomPanelDemo()
        {
            InitializeComponent();
            InitializeDemo();
        }

        private void InitializeDemo()
        {
            this.Title = "C1ZoomPanel Basic (Zoom and Scroll)";
            this.Description = @"This page demonstrates how to use C1ZoomPanel’s features and its following properties: ZoomPreviewMode, BoundaryFeedbackMode, AllowDoubleTapZoom, ScrollIndicatorMode, IsHorizontalRailEnabled, IsVerticalRailEnabled, and KeepAspectRation.  Select the settings for these properties on the page and click the Show Form button to see how these settings effect the zooming. When you zoom by touch, the ZoomFactor percentage is shown in the box on the left side of the test form.s";

            AddEnumItemsToComboBox(ZoomPreviewModeComboBox, typeof(ZoomPreviewMode));
            ZoomPreviewModeComboBox.SelectedItem = ZoomPreviewMode.Bitmap;
            ZoomPreviewModeComboBox.SelectedIndexChanged += ZoomPreviewModeComboBox_SelectedIndexChanged;

            formatComboBox.Items.Add("Zooming {Percentage}%");
            formatComboBox.Items.Add("Zooming x{ZoomFactor}");
            formatComboBox.SelectedIndex = 0;
            formatComboBox.TextChanged += formatComboBox_TextChanged;

            FontButton.Click += FontButton_Click;
            ForeColorButton.Click += ForeColorButton_Click;

            displayLabel.Font = this.Font;
            displayLabel.ForeColor = this.ForeColor;

            boundaryFeedbackUI1.BoundaryFeedbackMode = BoundaryFeedbackMode.Split;

            AddEnumItemsToComboBox(scrollIndicatorCombo, typeof(ScrollIndicatorMode));
            scrollIndicatorCombo.SelectedItem = ScrollIndicatorMode.ScrollIndicator;

            VerticalRailEnableCheckBox.Checked = true;
            HorizontalRailEnableCheckBox.Checked = true;
            AllowDoubleTapZoomCheckBox.Checked = false;

            formButton.Click += formButton_Click;
        }

        void formatComboBox_TextChanged(object sender, EventArgs e)
        {
            if (formatComboBox.Text!=null)
            {
                displayLabel.Text = formatComboBox.Text.Replace("{Percentage}", "100").Replace("{ZoomFactor}", "1.00"); ;
            }
        }

        void formButton_Click(object sender, EventArgs e)
        {
            using (Help form = new Help())
            {
                FillValues(form.C1ZoomPanel);
                form.ShowDialog(this);
                // The _C1Zoom will auto detach when the Form dispose.
                //_C1Zoom.SetEnabled(form, false);
            }
        }

        private void FillValues(C1ZoomPanel C1ZoomPanel)
        {
            C1ZoomPanel.ZoomPreviewMode = (ZoomPreviewMode)ZoomPreviewModeComboBox.SelectedItem;
            C1ZoomPanel.AlternativeContentSettings.Format = formatComboBox.Text;
            C1ZoomPanel.AlternativeContentSettings.ForeColor = displayLabel.ForeColor;
            C1ZoomPanel.AlternativeContentSettings.Font = displayLabel.Font;

            C1ZoomPanel.BoundaryFeedbackMode = boundaryFeedbackUI1.BoundaryFeedbackMode;
            C1ZoomPanel.ScrollIndicatorMode = (ScrollIndicatorMode)scrollIndicatorCombo.SelectedItem;

            C1ZoomPanel.IsVerticalRailEnabled = VerticalRailEnableCheckBox.Checked;
            C1ZoomPanel.IsHorizontalRailEnabled = HorizontalRailEnableCheckBox.Checked;
            C1ZoomPanel.AllowDoubleTapZoom = AllowDoubleTapZoomCheckBox.Checked;
        }

        void ForeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                displayLabel.ForeColor = dialog.Color;
            }
        }

        void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                
                displayLabel.Font = dialog.Font;
            }
        }

        void ZoomPreviewModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.alternativeContentGroup.Visible = false;
            this.NoPreivewInfoPanel.Visible = false;
            this.boundaryFeedbackUI1.Visible = false;
            switch ((ZoomPreviewMode)ZoomPreviewModeComboBox.SelectedItem)
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
