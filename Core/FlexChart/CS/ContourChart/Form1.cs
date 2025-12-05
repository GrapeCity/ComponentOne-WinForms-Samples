// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Chart;
using C1.Win.Chart.Extended;
using C1.Win.Chart.Palettes;
using C1.Win.Themes;
using ContourChart.Data;
using ContourChart.Properties;

namespace ContourChart
{
    public partial class Form1 : Form
    {
        private Contour _contour;
        private TwoDDataItem data;
        private GradientColorScale gradientScale;
        List<Color> gradientColors = Qualitative.Accent.Select(sb => ((SolidBrush)sb).Color).ToList();

        public Form1()
        {
            InitializeComponent();
            // apply theme to ribbon
            C1ThemeController.ApplyThemeToObject(c1Ribbon1, C1ThemeController.GetThemeByName("Office365White", false));

            InitializeLocalizedText();

            data = DataFunctionsService.MonkeySaddleData();

            SetupListView();
            SetUpComboBoxes();
            ConfigureContourChart();
        }

        private void InitializeLocalizedText()
        {
            Text = Resources.FormName;
            ribbonTab1.Text = Resources.DataTabName;
            ribbonTab2.Text = Resources.ExportTabName;


            ribbonGroup1.Text = Resources.AppearanceGroupName;
            ribbonGroup2.Text = Resources.ImageGroupName;
            ribbonGroup3.Text = Resources.ContourGroupName;

            ribCmbDataSet.Label = Resources.DataSetLabel;
            ribCmbAppearance.Label = Resources.ContourAppearanceLabel;


            ribBtnExportToPNG.Text = Resources.PngLabel;
            ribBtnExportToJPG.Text = Resources.JpgLabel;
            ribBtnExportToSVG.Text = Resources.SvgLabel;


            ribCmbAppearance.Label = Resources.AppearanceGroupName;
            ribCmbDataSet.Label = Resources.DataSetLabel;
            ribNumEditContourLevels.Label = Resources.ContourLevelsName;
            ribCBEnableCustomLevels.Text = Resources.CustomContourlLevelsName;

            ribCBEnableCustomLevels.ToolTip = Resources.CustomContourLevelsToolTip;
            ribNumEditContourLevels.ToolTip = Resources.ContourLevelsToolTip;
            ribTxtBoxCustomLevels.ToolTip = Resources.CustomContourLevelTextBoxToolTip;
        }

        void ConfigureContourChart()
        {
            this.flexChart1.Series.Clear();

            gradientScale = new GradientColorScale
            {
                Min = data.Min,
                Max = data.Max,
                Colors = gradientColors,
                Axis = new ColorAxis { Position = Position.Right }
            };

            _contour = new Contour
            {
                ColorScale = gradientScale,
                DataSource = data.Values,
                NumberOfLevels = ((int)ribNumEditContourLevels.Value),
                Appearance = (ContourAppearance)Enum.Parse(typeof(ContourAppearance), ribCmbAppearance.SelectedItem.Text)
            };

            this.flexChart1.Series.Add(_contour);

            this.flexChart1.AxisX.Max = data.Values.GetLength(0) - 1;
            this.flexChart1.AxisY.Max = data.Values.GetLength(1) - 1;
            this.flexChart1.AxisX.DataSource = data.CatXData;
            this.flexChart1.AxisY.DataSource = data.CatYData;
        }

        void SetUpComboBoxes()
        {
            foreach (ContourAppearance appearance in Enum.GetValues(typeof(ContourAppearance)))
            {
                ribCmbAppearance.Items.Add(appearance.ToString());
            }

            ribCmbAppearance.SelectedIndex = 0;

            foreach (string data in DataFunctionsService.dataFunctions)
            {
                ribCmbDataSet.Items.Add(data);
            }

            ribCmbDataSet.SelectedIndex = 1;
            ribNumEditContourLevels.Value = 10;
        }

        void SetupListView()
        {
            var imageList = new ImageList() { ImageSize = new Size(64, 12) };

            AddItems(imageList, "Qualitative", Qualitative.Brushes);
            AddItems(imageList, "Diverging", Diverging.Brushes);
            AddItems(imageList, "SequentialSingle", SequentialSingle.Brushes);
            AddItems(imageList, "SequentialMulti", SequentialMulti.Brushes);

            listViewColorPalette.LargeImageList = imageList;
            listViewColorPalette.View = View.LargeIcon;
            listViewColorPalette.SelectedIndexChanged += (s, a) =>
            {
                if (listViewColorPalette.SelectedItems.Count > 0)
                {
                    var burshes = listViewColorPalette.SelectedItems[0].Tag as List<Brush>;
                    var colors = burshes.Select(sb => ((SolidBrush)sb).Color).ToList();
                    gradientColors = colors;
                }
            };

            listViewColorPalette.OwnerDraw = true;
            listViewColorPalette.DrawItem += (s, a) =>
            {
                var rect = a.Bounds;
                var center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                var sz = a.Item.ImageList.ImageSize;
                rect.Inflate(-1, -1);
                a.Graphics.DrawImage(a.Item.ImageList.Images[a.Item.ImageIndex], center.X - sz.Width / 2, center.Y - sz.Height / 2 - 4);
                a.DrawText(TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter);

                if (a.Item.Selected)
                    a.Graphics.DrawRectangle(SystemPens.Highlight, rect);
            };
        }

        void AddItems(ImageList imageList, string name, IDictionary<string, IList<Brush>> brushes)
        {
            var ig = listViewColorPalette.Groups.Add(new ListViewGroup(name, HorizontalAlignment.Left));
            foreach (var key in brushes.Keys)
            {
                var item = listViewColorPalette.Items.Add(key);
                item.ImageIndex = imageList.Images.Count;
                item.Group = listViewColorPalette.Groups[ig];
                item.Tag = brushes[key];
                imageList.Images.Add(key, CreateSwatch(imageList.ImageSize.Width, imageList.ImageSize.Height, brushes[key]));
            }
        }

        Bitmap CreateSwatch(int width, int height, IList<Brush> brushes)
        {
            var bmp = new Bitmap(width, height);

            using (var g = Graphics.FromImage(bmp))
            {
                int count = brushes.Count;
                float segmentWidth = (float)width / count;

                for (int i = 0; i < count; i++)
                {
                    g.FillRectangle(
                        brushes[i],
                        new RectangleF(i * segmentWidth, 0, segmentWidth, height)
                    );
                }
            }

            return bmp;
        }

        private void ribCmbAppearance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_contour != null &&
                ribCmbAppearance.SelectedItem is C1.Win.Ribbon.RibbonButton btn &&
                !string.IsNullOrEmpty(btn.Text))
            {
                _contour.Appearance = (ContourAppearance)Enum.Parse(
                    typeof(ContourAppearance),
                    btn.Text);
            }

        }

        private void ribCmbDataSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var displayName = ribCmbDataSet.Text;
            var methodName = $"{displayName.Replace(" ", "")}Data";
            data = (TwoDDataItem)typeof(DataFunctionsService).GetMethod(methodName).Invoke(typeof(DataFunctionsService), new object[0]); ;
            ConfigureContourChart();
        }

        private void ribNumEditContourLevels_ValueChanged(object sender, EventArgs e)
        {
            if (_contour != null)
            {
                _contour.NumberOfLevels = ((int)ribNumEditContourLevels.Value);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewColorPalette.SelectedItems.Count > 0)
            {
                var burshes = listViewColorPalette.SelectedItems[0].Tag as List<Brush>;
                var colors = burshes.Select(sb => ((SolidBrush)sb).Color).ToList();
                gradientColors = colors;
                ConfigureContourChart();
            }
        }

        private void ribCBEnableCustomLevels_CheckedChanged(object sender, EventArgs e)
        {
            bool customEnabled = ribCBEnableCustomLevels.Checked;

            // Enable/disable controls
            ribNumEditContourLevels.Enabled = !customEnabled;
            ribTxtBoxCustomLevels.Enabled = customEnabled;

            if (customEnabled && _contour != null)
            {
                // When custom levels are enabled, set NumberOfLevels to 1
                ribNumEditContourLevels.Value = 1;
            }

            // If custom levels are not enabled, reset _contour.Levels
            if (!customEnabled && _contour != null)
            {
                _contour.Levels = null;
                ribTxtBoxCustomLevels.Text = string.Empty;
            }
        }

        // Restrict input to digits, comma, dot, backspace, and minus sign
        private void ribTxtBoxCustomLevels_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        // Parse and assign to _contour.Levels on text change
        private void ribTxtBoxCustomLevels_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ribTxtBoxCustomLevels.Text))
           {
                _contour.Levels = null; // Clear levels if textbox is empty
                _contour.NumberOfLevels = 1;
                return;
            }

            try
            {
                // Split the text by commas
                var parts = ribTxtBoxCustomLevels.Text.Split(',');
                var numbers = new List<double>();

                foreach (var part in parts)
                {
                    if (double.TryParse(part.Trim(), out double val))
                    {
                        numbers.Add(val);
                    }
                    else
                    {
                        // Stop processing if input is invalid
                        return;
                    }
                }

                // Assign the numbers to _contour.Levels
                _contour.Levels = numbers.ToArray();

            }
            catch
            {
                _contour.Levels = null; // Fallback if something goes wrong
            }
        }

        // Helper method to export the chart
        private void ExportChart(string filter, string defaultExt, C1.Win.Chart.ImageFormat format)
        {
            using (var saveFileDialog = new SaveFileDialog()
            {
                OverwritePrompt = true,
                Filter = filter,
                DefaultExt = defaultExt
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = saveFileDialog.OpenFile())
                    {
                        flexChart1.SaveImage(stream, format, flexChart1.Width, flexChart1.Height);
                    }
                }
            }
        }

        private void ribBtnExportToPNG_Click(object sender, EventArgs e)
        {
            ExportChart("PNG Image (*.png)|*.png", "png", C1.Win.Chart.ImageFormat.Png);
        }

        private void ribBtnExportToJPG_Click(object sender, EventArgs e)
        {
            ExportChart("JPEG Image (*.jpg)|*.jpg", "jpg", C1.Win.Chart.ImageFormat.Jpg);
        }

        private void ribBtnExportToSVG_Click(object sender, EventArgs e)
        {
            ExportChart("SVG Image (*.svg)|*.svg", "svg", C1.Win.Chart.ImageFormat.Svg);
        }
    }
}
