using C1.Win.Input;
using C1.Win.Themes;
using C1.Win.Chart.Finance;
using FinancialChartExplorer.CustomControls;
using FinancialChartExplorer.Samples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinancialChartExplorer
{
    public partial class Form1 : Form
    {
        private string _currentTheme = "Office365White"; // Track current theme
        public Form1()
        {
            InitializeComponent();
        }

        private void AccordionChild_Clicked_Callback(object sender, EventArgs e)
        {
            AccordionChildCT control = sender as AccordionChildCT;
            ShowSample((Sample)control.Tag);
        }

        private void BtnHamb_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed != true)
            {
                this.splitContainer1.Panel1Collapsed = true;
                this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0);
                panel1.Controls.Add(_btnHamb);
            }
            else
            {
                this.splitContainer1.Panel1Collapsed = false;
                this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
                this.splitContainer1.Panel1.Controls.Add(_btnHamb);
            }
        }

        // Event handler to create rounded upper-left corner
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                int cornerRadius = 10; // Rounded corner radius in pixels

                // Create a GraphicsPath to define the rounded upper-left corner
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

                // Upper-left corner
                path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90); // Quarter-circle arc for upper-left
                path.AddLine(cornerRadius, 0, panel.Width, 0);                   // Top edge
                path.AddLine(panel.Width, 0, panel.Width, panel.Height);          // Right edge
                path.AddLine(panel.Width, panel.Height, 0, panel.Height);         // Bottom edge
                path.AddLine(0, panel.Height, 0, cornerRadius);                   // Left edge

                // Set the Region of the panel to the created path
                panel.Region = new Region(path);

            }
        }

        public void ToggleBtn_Click(object sender, EventArgs e)
        {
            var currentTheme = C1ThemeController.ApplicationTheme;
            string newTheme = "";
            if (currentTheme == "Office365White")
            {
                newTheme = "Office365Black";
            }
            else
            {
                newTheme = "Office365White";
            }
            _currentTheme = newTheme;

            ApplyTheme(newTheme);

        }

        private void ApplyTheme(string newTheme)
        {
            // Apply theme to the entire control tree
            C1ThemeController.ApplyThemeToControlTree(this, C1ThemeController.GetThemeByName(newTheme, false), null, true);

            // Set specific colors based on theme
            if (newTheme == "Office365Black")
            {
                this.splitContainer1.Panel1.BackColor = Color.Black;
                this.splitContainer1.Panel2.BackColor = Color.Black;
                this.panelSample.BackColor = Color.Black;
                this.panel1.BackColor = ColorTranslator.FromHtml("#262726");
                this.labelSampleHeader.BackColor = Color.Transparent;
                this.labelSampleDescription.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                this.labelSampleDescription.BackColor = ColorTranslator.FromHtml("#262726");
                this._btnHamb.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                this.splitContainer1.BackColor = Color.WhiteSmoke;
                this.splitContainer1.Panel1.BackColor = Color.WhiteSmoke;
                this.splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
                this.panelSample.BackColor = Color.WhiteSmoke;
                this.panel1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.labelSampleHeader.BackColor = Color.Transparent;
                this.labelSampleDescription.ForeColor = ColorTranslator.FromHtml("#000000");
                this.labelSampleDescription.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this._btnHamb.ForeColor = Color.FromArgb(68, 68, 68);
            }
            // Update the theme for toggle button
            this._toggleBtn.ImageIndex = _currentTheme == "Office365Black" ? 0 : 1;
            this.accordionAreaCT1.SetTheme = newTheme;
            C1ThemeController.ApplicationTheme = newTheme;
            c1ThemeController1.SetTheme(splitContainer1, newTheme);
            c1ThemeController1.SetTheme(_toggleBtn, newTheme);
            SetThemeToUnThemeableControl(doExtra: true);

        }

        private void SetThemeToUnThemeableControl(bool doExtra = false)
        {
            List<Type> l = new List<Type>
            {
                typeof(HeikinAshi),
                typeof(LineBreak),
                typeof(Renko),
                typeof(Kagi),
                typeof(Volume),
                typeof(PointAndFigure),
                typeof(LineMarker),
                typeof(TrendLines),
                typeof(MovingAverages),
                typeof(Overlays),
                typeof(Indicators),
                typeof(FibonacciTool)
            };
            // Iterate through all controls inside the parent control
            foreach (Control control in panelSample.Controls)
            {
                if (!l.Contains(control.GetType())) continue;
                Control tabLayoutPnl = control.Controls.Count > 0 ? control.Controls[0] : null;
                if (tabLayoutPnl == null) continue;

                foreach (Control cnt1 in tabLayoutPnl.Controls)
                {
                    if (cnt1 is FlowLayoutPanel flowLayoutPanel)
                    {
                        flowLayoutPanel.BackColor = _currentTheme == "Office365Black" ? ColorTranslator.FromHtml("#262726") : SystemColors.Window;

                        if (doExtra)
                        {
                            foreach (Control cnt2 in flowLayoutPanel.Controls)
                            {
                                if (cnt2 is Label)
                                {
                                    cnt2.BackColor = Color.Transparent;
                                }
                                else if (cnt2 is C1ComboBox || cnt2 is C1CheckBox || cnt2 is C1NumericEditEx)
                                {
                                    C1ThemeController.ApplyThemeToControlTree(cnt2, C1ThemeController.GetThemeByName(_currentTheme, false), null, true);
                                    if (cnt2 is C1ComboBox)
                                        cnt2.Width = 163;
                                    if (cnt2 is C1NumericEditEx)
                                        cnt2.Width = 65;
                                    if (cnt2 is C1CheckBox)
                                        cnt2.Width = 150;
                                }
                            }
                        }
                    }
                    else if (cnt1 is FinancialChart)
                    {
                        cnt1.BackColor = _currentTheme == "Office365White" ? Color.WhiteSmoke : Color.Black; 
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllSamples samples = null;
            _btnHamb.Font = new Font("Segoe MDL2 Assets", _btnHamb.Font.Size);
            // hamburger icon
            _btnHamb.Text = char.ConvertFromUtf32(0xe700);

            string path = "FinancialChartExplorer.Resources.config.xml";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
            {
                var ser = new XmlSerializer(typeof(AllSamples));
                samples = ser.Deserialize(stream) as AllSamples;
            }

            Debug.Assert(samples != null);

            if (samples != null)
            {
                accordionAreaCT1.AddChildren(samples);
                ShowSample(samples.Groups[0].Samples[0]);
            }
        }

        void ShowSample(Sample sample)
        {
            panelSample.Controls.Clear();
            labelSampleHeader.Text = sample.Name;
            labelSampleDescription.Text = sample.Description;

            var ctrl = GetSampleControl(sample.ControlName);
            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                ctrl.Tag = sample;
                panelSample.Controls.Add(ctrl);
            }
            SetThemeToUnThemeableControl(doExtra: true);
        }

        UserControl GetSampleControl(string name)
        {
            var ctrl = Assembly.GetExecutingAssembly().CreateInstance("FinancialChartExplorer.Samples." + name) as UserControl;
            Debug.Assert(ctrl != null);
            return ctrl;
        }
    }
}