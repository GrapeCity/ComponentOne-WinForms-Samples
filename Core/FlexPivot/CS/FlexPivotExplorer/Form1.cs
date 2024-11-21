using C1.Win.Themes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlexPivotExplorer
{
    public partial class Form1 : Form
    {
        private Timer _hideLabelTimer;

        public Form1()
        {
            InitializeComponent();

            foreach (SampleItem sample in SampleDataSource.AllItems)
            {
                lblSamples.Items.Add(sample);
            }
            lblSamples.SelectedIndex = 0;

            var themes = C1ThemeController.GetThemes();
            cmbThemes.Items.Add("(none)");
            foreach(var theme in themes)
            {
                cmbThemes.Items.Add(theme);
            }
            cmbThemes.SelectedIndex = cmbThemes.Items.Select(x => x.DisplayText).ToList().IndexOf("Office365White");
        }

        private void lblSamples_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Check if the index is valid
            if (e.Index < 0) return;

            // Define padding values
            int leftPadding = 20;

            // Set the background color based on selection
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0x87, 0xCE, 0xFA)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            // Get the current item
            SampleItem item = lblSamples.Items[e.Index] as SampleItem;

            if (item != null)
            {
                // Measure the size of the text
                Size textSize = TextRenderer.MeasureText(item.Title, e.Font);

                // Calculate the Y position for vertical centering
                int centerY = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

                // Define the rectangle for the text
                Rectangle textBounds = new Rectangle(
                    e.Bounds.Left + leftPadding, // Keep left padding
                    centerY,
                    e.Bounds.Width - leftPadding, // Adjust width to exclude left padding
                    textSize.Height
                );

                // Draw the text with vertical centering and left padding
                TextRenderer.DrawText(e.Graphics, item.Title, e.Font, textBounds, e.ForeColor, TextFormatFlags.Left);
            }

            // Draw the focus rectangle if the item is selected
            e.DrawFocusRectangle();
        }

        private void HideLabelWaiting(bool mode)
        {
            if (!mode)
            {
                lbWaiting.Visible = true;

                // Stop and dispose of the timer if it exists
                _hideLabelTimer?.Stop();
                _hideLabelTimer?.Dispose();
                _hideLabelTimer = null;
            }
            else
            {
                // Only create a new timer if one does not already exist
                if (_hideLabelTimer == null)
                {
                    _hideLabelTimer = new Timer();
                    _hideLabelTimer.Interval = 1000;
                    _hideLabelTimer.Tick += (s, e) =>
                    {
                        lbWaiting.Visible = false;
                        _hideLabelTimer.Stop();
                        _hideLabelTimer.Dispose();
                        _hideLabelTimer = null;
                    };
                }

                _hideLabelTimer.Start();
            }
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            this.pnlSample.Controls.Clear();
            this.pnlSample.Controls.Add(lbWaiting);
            HideLabelWaiting(false);
            var sample = lblSamples.SelectedItem as SampleItem;
            lblTitle.Text = sample.Title;
            lblDescription.Text = sample.Description;
            var control = sample.Sample;
            control.Dock = DockStyle.Fill;

            this.pnlSample.Controls.Add(control);

            applyTheme();

            if (control is Form)
            {
                ((Form)control).Show();
            }
        }

        private void applyTheme()
        {
            if (cmbThemes.SelectedIndex == -1)
                return;

            var selectedTheme = C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false);
            C1ThemeController.ApplyThemeToControlTree(pnlSample, selectedTheme, null, true);
            HideLabelWaiting(true);
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideLabelWaiting(false);
            applyTheme();
        }
    }
}
