using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlExplorer.Chart.Data;
using C1.Win.C1Chart;
using C1.C1Excel;

namespace ControlExplorer.Chart
{
    public partial class Interaction : C1DemoForm
    {
        C1XLBook _xlBook = new C1XLBook();
        ChartDataSeries cdsTemp;
        ChartDataSeries cdsPress;
        ChartDataSeries cdsCond;
        ChartDataSeries cdsPh;
        double _zoomScale = 0.9;

        public Interaction()
        {
            InitializeComponent();
        }

        private void Interaction_Load(object sender, EventArgs e)
        {
            // Enable interaction
            c1Chart1.Interaction.Enabled = true;
            c1Chart1.Interaction.Actions["Zoom"].Modifier = Keys.None;
            c1Chart1.Interaction.Actions["Scale"].Modifier = Keys.Control;
            c1Chart1.Interaction.Actions["Translate"].Modifier = Keys.Shift;
            c1Chart1.Interaction.Actions["Rotate"].Modifier = Keys.Alt;
            c1Chart1.Interaction.Appearance = InteractionAppearance.FillSelectionArea;

            // Create chart series
            c1Chart1.ChartGroups[0].ChartData.SeriesList.Clear();
            cdsTemp = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
            cdsPress = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
            cdsCond = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
            cdsPh = c1Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

            cdsTemp.SymbolStyle.Shape = SymbolShapeEnum.None;
            cdsTemp.LineStyle.Color = Color.FromArgb(150, 32, 132);
            cdsTemp.LineStyle.Thickness = 2;
            cdsPress.SymbolStyle.Shape = SymbolShapeEnum.None;
            cdsPress.LineStyle.Color = Color.FromArgb(42, 2, 153);
            cdsPress.LineStyle.Thickness = 2;
            cdsCond.SymbolStyle.Shape = SymbolShapeEnum.None;
            cdsCond.LineStyle.Color = Color.FromArgb(0, 114, 160);
            cdsCond.LineStyle.Thickness = 2;
            cdsPh.SymbolStyle.Shape = SymbolShapeEnum.None;
            cdsPh.LineStyle.Color = Color.FromArgb(100, 126, 52);
            cdsPh.LineStyle.Thickness = 2;

            // Misc settings
            c1Chart1.UseAntiAliasedGraphics = true;
            c1Chart1.UseAntiAliasedText = true;
            
            // Load initial data source
            comboLocations.SelectedIndex = 0;

            // Add ValueLabel event handling
            // The moveable marker is created at design-time
            ValueLabel vl = c1Chart1.ChartArea.AxisX.ValueLabels[0];
            vl.NumericValue = 140;
            vl.ValueChanged += new EventHandler(vl_ValueChanged);

            // Setup chart axes and scrollbar
            c1Chart1.ChartArea.AxisX.ScrollBar.Scale = 0.1;
            c1Chart1.ChartArea.AxisY.ScrollBar.Scale = 1.0;
            c1Chart1.ChartArea.AxisX.ScrollBar.Alignment = StringAlignment.Near;
            c1Chart1.ChartArea.AxisY.ScrollBar.Alignment = StringAlignment.Near;
            c1Chart1.ChartArea.AxisX.ScrollBar.Appearance = ScrollBarAppearanceEnum.XP;
            c1Chart1.ChartArea.AxisY.ScrollBar.Appearance = ScrollBarAppearanceEnum.XP;
            c1Chart1.ChartArea.AxisX.ScrollBar.Visible = true;
            c1Chart1.ChartArea.AxisY.ScrollBar.Visible = true;
            c1Chart1.ChartArea.AxisY.ScrollBar.Max = 80;
            c1Chart1.ChartArea.AxisY.ScrollBar.Min = 20;
            c1Chart1.ChartArea.AxisX.ScrollBar.AxisScroll += new AxisScrollEventHandler(ScrollBar_AxisScroll);

            // Update chart labels
            UpdateChartLabels();

            // Update shaded zones
            UpdateZones();
        }   

        

        DrillDataPoints GetChartData(C1XLBook book)
        {
            // Get first sheet
            var sheet = book.Sheets[0];

            // Get location, date, and cell count
            var location = sheet[1, 1].Value as string;
            var date = (DateTime)sheet[2, 1].Value;
            var count = sheet.Rows.Count - 5;
            label.Text = string.Format("{0}, {1} points", location, count);

            // Get values into arrays for charting
            var drillData = new DrillDataPoints(count);
            for (int r = 0; r < count; r++)
            {
                drillData.Temperature[r] = (double)sheet[r + 5, 1].Value;
                drillData.Pressure[r] = (double)sheet[r + 5, 2].Value;
                drillData.Conductivity[r] = (double)sheet[r + 5, 3].Value;
                drillData.Ph[r] = (double)sheet[r + 5, 4].Value;
                drillData.Depth[r] = r;
            }
            drillData.ScaleValues();

            // Send data to chart
            return drillData;
        }

        private void LoadChart(string filename)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                try
                {
                    _xlBook.Load(AppDomain.CurrentDomain.BaseDirectory + "Chart\\Data\\" + filename);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to load Excel file: " + filename);
                }
            }
            else
            {
                return;
            }

            // Go get the data from the excel book we just loaded
            var data = GetChartData(_xlBook);

            // Copy data arrays into c1Chart
            c1Chart1.ChartArea.AxisX.Max = data.Depth.Length - 1;
            c1Chart1.ChartArea.AxisX.ScrollBar.Max = data.Depth.Length - 1;
            cdsTemp.Y.CopyDataIn(data.Temperature);
            cdsTemp.X.CopyDataIn(data.Depth);
            cdsPress.Y.CopyDataIn(data.Pressure);
            cdsPress.X.CopyDataIn(data.Depth);
            cdsCond.Y.CopyDataIn(data.Conductivity);
            cdsCond.X.CopyDataIn(data.Depth);
            cdsPh.Y.CopyDataIn(data.Ph);
            cdsPh.X.CopyDataIn(data.Depth);

            // Show all series after loading the data
            checkConductivity.Checked = true;
            checkPh.Checked = true;
            checkTemperature.Checked = true;
            checkPressure.Checked = true;

            // Reset scroll bar position
            c1Chart1.ChartArea.AxisX.ScrollBar.Value = 0;
        }

        // Load excel file
        private void comboLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
           LoadChart(comboLocations.SelectedOption.Text);
           UpdateChartLabels();
        }

        private void checkConductivity_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide data series
            if (checkConductivity.Checked)
            {
                cdsCond.Display = SeriesDisplayEnum.Show;
            }
            else
            {
                cdsCond.Display = SeriesDisplayEnum.Hide;
            }
        }

        private void checkPh_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide data series
            if (checkPh.Checked)
            {
                cdsPh.Display = SeriesDisplayEnum.Show;
            }
            else
            {
                cdsPh.Display = SeriesDisplayEnum.Hide;
            }
        }

        private void checkTemperature_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide data series
            if (checkTemperature.Checked)
            {
                cdsTemp.Display = SeriesDisplayEnum.Show;
            }
            else
            {
                cdsTemp.Display = SeriesDisplayEnum.Hide;
            }
        }

        private void checkPressure_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide data series
            if (checkPressure.Checked)
            {
                cdsPress.Display = SeriesDisplayEnum.Show;
            }
            else
            {
                cdsPress.Display = SeriesDisplayEnum.Hide;
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            // Zoom in
            c1Chart1.ChartArea.AxisX.ScrollBar.Scale = c1Chart1.ChartArea.AxisX.ScrollBar.Scale * _zoomScale;
            c1Chart1.ChartArea.AxisY.ScrollBar.Scale = c1Chart1.ChartArea.AxisY.ScrollBar.Scale * _zoomScale;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            // Zoom out
            c1Chart1.ChartArea.AxisX.ScrollBar.Scale = c1Chart1.ChartArea.AxisX.ScrollBar.Scale / _zoomScale;
            c1Chart1.ChartArea.AxisY.ScrollBar.Scale = c1Chart1.ChartArea.AxisY.ScrollBar.Scale / _zoomScale;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset scales
            c1Chart1.ChartArea.AxisX.ScrollBar.Scale = 0.1;
            c1Chart1.ChartArea.AxisY.ScrollBar.Scale = 1.0;
        }

        private void chkChartAreaInverted_CheckedChanged(object sender, EventArgs e)
        {
            c1Chart1.ChartArea.Inverted = chkChartAreaInverted.Checked;
            UpdateChartLabels();
            
        }

        private void chkAxisXReversed_CheckedChanged(object sender, EventArgs e)
        {
            c1Chart1.ChartArea.AxisX.Reversed = chkAxisXReversed.Checked;
        }

        // Fires when drill point marker is moved. Updates labels
        void vl_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartLabels();
        }

        private void UpdateChartLabels()
        {
            foreach (C1.Win.C1Chart.Label lbl in c1Chart1.ChartLabels.LabelsCollection)
            {
                // Move label to the correct point along the X Axis
                lbl.AttachMethodData.PointIndex = (int)c1Chart1.ChartArea.AxisX.ValueLabels[0].NumericValue;

                // Set label text to the Y value
                if (lbl.AttachMethodData.PointIndex > -1)
                {
                    lbl.Text = c1Chart1.ChartGroups.Group0.ChartData.SeriesList[lbl.AttachMethodData.SeriesIndex].PointData[lbl.AttachMethodData.PointIndex].ToString();
                }
            }

            // Adjust labels to avoid overlap
            if (c1Chart1.ChartArea.Inverted)
            {
                // AxisX runs vertical so we should stagger labels
                c1Chart1.ChartLabels.LabelsCollection[0].Offset = 15;
                c1Chart1.ChartLabels.LabelsCollection[1].Offset = 15;
                c1Chart1.ChartLabels.LabelsCollection[1].Compass = LabelCompassEnum.SouthEast;
                c1Chart1.ChartLabels.LabelsCollection[2].Offset = 40;
                c1Chart1.ChartLabels.LabelsCollection[3].Offset = 40;
                c1Chart1.ChartLabels.LabelsCollection[3].Compass = LabelCompassEnum.SouthEast;
            }
            else
            {
                // AxisX runs vertical so we should stagger labels
                c1Chart1.ChartLabels.LabelsCollection[0].Offset = 15;
                c1Chart1.ChartLabels.LabelsCollection[1].Offset = 15;
                c1Chart1.ChartLabels.LabelsCollection[2].Offset = 15;
                c1Chart1.ChartLabels.LabelsCollection[3].Offset = 15;
                c1Chart1.ChartLabels.LabelsCollection[0].Compass = LabelCompassEnum.NorthEast;
                c1Chart1.ChartLabels.LabelsCollection[1].Compass = LabelCompassEnum.NorthEast;
                c1Chart1.ChartLabels.LabelsCollection[2].Compass = LabelCompassEnum.NorthEast;
                c1Chart1.ChartLabels.LabelsCollection[3].Compass = LabelCompassEnum.NorthEast;
            }
        }

        private void UpdateZones()
        {
            if (c1Chart1.ChartArea.PlotArea.AlarmZones.Count == 0)
            {
                for (int i = 10; i < c1Chart1.ChartArea.AxisY.Max; i += 20)
                {
                    AlarmZone az = c1Chart1.ChartArea.PlotArea.AlarmZones.AddNewZone();
                    az.LowerExtent = i;
                    az.UpperExtent = i + 10;
                    az.BackColor = Color.WhiteSmoke;
                    az.Visible = true;
                }
            }
        }

        void ScrollBar_AxisScroll(object sender, AxisScrollEventArgs e)
        {
            // Detect AxisX scrolling
        }

        private void c1Chart1_DoubleClick(object sender, EventArgs e)
        {
            Form form1 = new Form();
            PropertyGrid pg = new PropertyGrid();
            pg.SelectedObject = c1Chart1;
            pg.Dock = DockStyle.Fill;
            form1.Controls.Add(pg);
            form1.Show();
        }
    }
}
