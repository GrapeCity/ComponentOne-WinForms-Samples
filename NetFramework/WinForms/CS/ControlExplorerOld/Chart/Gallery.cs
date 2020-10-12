using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;
using ControlExplorer.Chart;

namespace ControlExplorer.Chart
{
    public partial class Gallery : C1DemoForm
    {
        private PointStyle _ps;
            
        public Gallery()
        {
            InitializeComponent();

            
        }

        private void comboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyThemePalette();
        }

        private void ApplyThemePalette()
        {
            ColorGeneration palette = (ColorGeneration)Enum.Parse(typeof(ColorGeneration), comboPalette.SelectedValue.ToString());
            c1Chart1.ColorGeneration = palette;
        }

        private void InitPointStyle()
        {
            _ps = c1Chart1.ChartGroups[0].ChartData.PointStylesList.AddNewPointStyle();
            _ps.LineStyle.Color = Color.White;
            _ps.LineStyle.Thickness = 3;
            _ps.SymbolStyle.Color = Color.White;
            _ps.SymbolStyle.Size = 15;
            _ps.SymbolStyle.OutlineColor = Color.Black;
            _ps.SymbolStyle.OutlineWidth = 2;
            _ps.FillStyle.Alpha = this.Alpha;
            _ps.FillStyle.Color1 = Color.White;
            _ps.FillStyle.Color2 = Color.Gainsboro;
            _ps.FillStyle.FillType = FillTypeEnum.Gradient;
            _ps.FillStyle.GradientStyle = GradientStyleEnum.Vertical;
        }

        private void ResetChart()
        {
            categorySales1.ResetBindings(false);
            c1Chart1.ChartArea.Inverted = false;
            c1Chart1.ChartArea.AxisX.AnnotationRotation = -30;
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            ChartDataSeriesCollection series = g.ChartData.SeriesList;
            foreach (ChartDataSeries s in series)
            {
                s.SymbolStyle.Shape = SymbolShapeEnum.None;
                s.LineStyle.Thickness = 3;
                s.LineStyle.Pattern = LinePatternEnum.Solid;
            }
            ApplyThemePalette();
            this.Alpha = 192;
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            categorySales1.ResetBindings(false);
            c1Chart1.ChartArea.AxisX.AnnotationRotation = -30;
            comboPalette.DataSource = Enum.GetValues(typeof(ColorGeneration));
            comboPalette.SelectedItem = ColorGeneration.Custom;

            // setup tooltips
            ChartDataSeriesCollection sc = c1Chart1.ChartGroups[0].ChartData.SeriesList;

            foreach (ChartDataSeries ds in sc)
            {
                ds.TooltipText = "Series: {#TEXT}" + '\r' + '\n' + "x = {#XVAL}" + '\r' + '\n' + "y = {#YVAL}";
            }

            // setup pointstyle
            InitPointStyle();
            _ps.Selection = PointStyleSelectionEnum.Index;
            _ps.SeriesIndex = 0;
            _ps.PointIndex = 0;

            // add demo properties
            AddProperty("Compass", c1Chart1.ChartArea.AxisX, "AxisX.Compass");
            AddProperty("Compass", c1Chart1.ChartArea.AxisY, "AxisY.Compass");
            AddProperty("Alpha", this, "FillStyle.Alpha");
            AddProperty("GridLines", this);
            AddProperty("PointStyle", this, "Highlighting");
            AddProperty("ShowOutline", c1Chart1.ChartGroups.Group0);
            AddProperty("Enabled", c1Chart1.ToolTip, "Tooltips");
            AddProperty("Enabled", c1Chart1.VisualEffects["Default"], "VisualEffects");
        }

        // combines all gridlines properties into one for demo
        public bool GridLines
        {
            get { return c1Chart1.ChartArea.AxisX.GridMajor.Visible; }
            set
            {
                c1Chart1.ChartArea.AxisX.GridMajor.Visible = value;
                c1Chart1.ChartArea.AxisY.GridMajor.Visible = value;
                c1Chart1.ChartArea.AxisY.GridMinor.Visible = value;
            }
        }

        public PointStyleSelectionEnum PointStyle
        {
            get { return _ps.Selection; }
            set { _ps.Selection = value; }
        }    

        private void ConfigureLineChart(bool threed, bool stacked, FitTypeEnum fit)
        {
            ResetChart();
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            g.ChartType = Chart2DTypeEnum.XYPlot;
            ChartDataSeriesCollection series = g.ChartData.SeriesList;
            g.Use3D = threed;
            g.Stacked = stacked;

            foreach (ChartDataSeries s in series)
                s.FitType = fit;
        }

        private void ConfigureStepChart(bool threed)
        {
            ResetChart();
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            g.ChartType = Chart2DTypeEnum.Step;
            ChartDataSeriesCollection series = g.ChartData.SeriesList;
            g.Use3D = threed;
        }

        private void ConfigureSymbols(bool lines)
        {
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            ChartDataSeriesCollection series = g.ChartData.SeriesList;
            int n = 0;

            SymbolShapeEnum[] shapes =
            {
                SymbolShapeEnum.Box,
                SymbolShapeEnum.Dot,
                SymbolShapeEnum.Diamond,
                SymbolShapeEnum.Tri
            };

            foreach (ChartDataSeries s in series)
            {
                s.SymbolStyle.Shape = shapes[n++];

                if (lines)
                {
                    s.LineStyle.Thickness = 1;
                }
                else
                {
                    s.LineStyle.Pattern = LinePatternEnum.None;
                }
            }
        }

        private void ConfigureAreaChart(bool threed, bool stacked, bool hundred)
        {
            ResetChart();
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            g.ChartType = Chart2DTypeEnum.Area;
            g.Use3D = threed;
            g.Stacked = stacked;
            g.Is100Percent = hundred;
        }

        private void ConfigureBarChart(bool threed, bool stacked, bool hundred, BarAppearanceEnum shape)
        {
            ResetChart();
            c1Chart1.ChartArea.Inverted = true;
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            g.ChartType = Chart2DTypeEnum.Bar;
            g.Bar.Appearance = shape;
            g.Use3D = threed;
            g.Stacked = stacked;
            g.Is100Percent = hundred;
        }

        private void ConfigureColumnChart(bool threed, bool stacked, bool hundred, bool multirow, BarAppearanceEnum shape)
        {
            ResetChart();
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            g.ChartType = Chart2DTypeEnum.Bar;
            g.Bar.Appearance = shape;
            g.Bar.MultiRow = multirow;
            g.Use3D = threed;
            g.Stacked = stacked;
            g.Is100Percent = hundred;
        }

        private void ConfigurePieChart(bool threed, bool stacked, int doughnut, int slice)
        {
            ResetChart();
            ChartGroup g = c1Chart1.ChartGroups.Group0;
            g.ChartType = Chart2DTypeEnum.Pie;
            g.Pie.InnerRadius = doughnut;
            ChartDataSeriesCollection series = g.ChartData.SeriesList;
            foreach (ChartDataSeries s in series)
            {
                s.Offset = slice;
                
            }
            g.Use3D = threed;
            g.Stacked = stacked;
            if (stacked == true)
            {
                this.Alpha = 255;
            }
            else
            {
                this.Alpha = 192;
            } 
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
                return;

            string[] tag = e.Node.Tag.ToString().Split('.');

            if (tag.Length < 2)
                return;

            if (tag[0].ToLower().Equals("line"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureLineChart(false, false, FitTypeEnum.Line);
                }
                else if(tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Line);
                }
                else if(tag[1].ToLower().Equals("bezier"))
                {
                    ConfigureLineChart(false, false, FitTypeEnum.Beziers);
                }
                else if(tag[1].ToLower().Equals("spline"))
                {
                    ConfigureLineChart(false, false, FitTypeEnum.Spline);
                }
                else if(tag[1].ToLower().Equals("splinestacked"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Spline);
                }
                else if(tag[1].ToLower().Equals("3d"))
                {
                    ConfigureLineChart(true, false, FitTypeEnum.Line);
                }
                else if(tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureLineChart(true, true, FitTypeEnum.Line);
                }
                else if(tag[1].ToLower().Equals("linesandsymbols"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Line);
                    ConfigureSymbols(true);
                }
                else if(tag[1].ToLower().Equals("symbolsonly"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Line);
                    ConfigureSymbols(false);
                }
                else if (tag[1].ToLower().Equals("step"))
                {
                    ConfigureStepChart(false);
                }
                else if (tag[1].ToLower().Equals("stepandsymbols"))
                {
                    ConfigureStepChart(false);
                    ConfigureSymbols(true);
                }
                else if (tag[1].ToLower().Equals("3dstep"))
                {
                    ConfigureStepChart(true);
                }
            }
            else if (tag[0].ToLower().Equals("area"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureAreaChart(false, false, false);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureAreaChart(false, true, false);
                }
                else if (tag[1].ToLower().Equals("stacked100pc"))
                {
                    ConfigureAreaChart(false, true, true);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigureAreaChart(true, false, false);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureAreaChart(true, true, false);
                }
                else if (tag[1].ToLower().Equals("3dstacked100pc"))
                {
                    ConfigureAreaChart(true, true, true);
                }
            }
            else if (tag[0].ToLower().Equals("bar"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureBarChart(false, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureBarChart(false, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked100pc"))
                {
                    ConfigureBarChart(false, true, true, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigureBarChart(true, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked100pc"))
                {
                    ConfigureBarChart(true, true, true, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("cylinder"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Cylinder);
                }
                else if (tag[1].ToLower().Equals("cone"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Cone);
                }
                else if (tag[1].ToLower().Equals("pyramid"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Pyramid);
                }
            }
            else if (tag[0].ToLower().Equals("column"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureColumnChart(false, false, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureColumnChart(false, true, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked100pc"))
                {
                    ConfigureColumnChart(false, true, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigureColumnChart(true, false, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked100pc"))
                {
                    ConfigureColumnChart(true, true, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dmultirow"))
                {
                    ConfigureColumnChart(true, false, false, true, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("cylinder"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Cylinder);
                }
                else if (tag[1].ToLower().Equals("cone"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Cone);
                }
                else if (tag[1].ToLower().Equals("pyramid"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Pyramid);
                }
            }
            else if (tag[0].ToLower().Equals("pie"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigurePieChart(false, false, 0, 0);
                }
                else if (tag[1].ToLower().Equals("sliced"))
                {
                    ConfigurePieChart(false, false, 0, 10);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigurePieChart(false, true, 0, 0);
                }
                else if (tag[1].ToLower().Equals("doughnut"))
                {
                    ConfigurePieChart(false, false, 50, 0);
                }
                else if (tag[1].ToLower().Equals("sliceddoughnut"))
                {
                    ConfigurePieChart(false, false, 50, 10);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigurePieChart(true, false, 0, 0);
                }
                else if (tag[1].ToLower().Equals("3dsliced"))
                {
                    ConfigurePieChart(true, false, 0, 10);
                }
                else if (tag[1].ToLower().Equals("3ddoughnut"))
                {
                    ConfigurePieChart(true, false, 50, 0);
                }
                else if (tag[1].ToLower().Equals("3dsliceddoughnut"))
                {
                    ConfigurePieChart(true, false, 50, 10);
                }
            }
        }

        private void Gallery_Resize(object sender, EventArgs e)
        {
            c1Chart1.Header.Size = new Size(c1Chart1.Width, 40);
        }

        //Style properties
        public byte Alpha
        {
            get { return c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].FillStyle.Alpha; }
            set
            {
                foreach (ChartDataSeries ds in c1Chart1.ChartGroups.Group0.ChartData.SeriesList)
                {
                    ds.FillStyle.Alpha = value;
                    _ps.FillStyle.Alpha = value;
                }
            }
        }

        private void c1TopicBar1_LinkClick(object sender, C1.Win.C1Command.C1TopicBarClickEventArgs e)
        {
            if (e.Link.Tag == null)
                return;

            string[] tag = e.Link.Tag.ToString().Split('.');

            if (tag.Length < 2)
                return;

            if (tag[0].ToLower().Equals("line"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureLineChart(false, false, FitTypeEnum.Line);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Line);
                }
                else if (tag[1].ToLower().Equals("bezier"))
                {
                    ConfigureLineChart(false, false, FitTypeEnum.Beziers);
                }
                else if (tag[1].ToLower().Equals("spline"))
                {
                    ConfigureLineChart(false, false, FitTypeEnum.Spline);
                }
                else if (tag[1].ToLower().Equals("splinestacked"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Spline);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigureLineChart(true, false, FitTypeEnum.Line);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureLineChart(true, true, FitTypeEnum.Line);
                }
                else if (tag[1].ToLower().Equals("linesandsymbols"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Line);
                    ConfigureSymbols(true);
                }
                else if (tag[1].ToLower().Equals("symbolsonly"))
                {
                    ConfigureLineChart(false, true, FitTypeEnum.Line);
                    ConfigureSymbols(false);
                }
                else if (tag[1].ToLower().Equals("step"))
                {
                    ConfigureStepChart(false);
                }
                else if (tag[1].ToLower().Equals("stepandsymbols"))
                {
                    ConfigureStepChart(false);
                    ConfigureSymbols(true);
                }
                else if (tag[1].ToLower().Equals("3dstep"))
                {
                    ConfigureStepChart(true);
                }
            }
            else if (tag[0].ToLower().Equals("area"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureAreaChart(false, false, false);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureAreaChart(false, true, false);
                }
                else if (tag[1].ToLower().Equals("stacked100pc"))
                {
                    ConfigureAreaChart(false, true, true);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigureAreaChart(true, false, false);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureAreaChart(true, true, false);
                }
                else if (tag[1].ToLower().Equals("3dstacked100pc"))
                {
                    ConfigureAreaChart(true, true, true);
                }
            }
            else if (tag[0].ToLower().Equals("bar"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureBarChart(false, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureBarChart(false, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked100pc"))
                {
                    ConfigureBarChart(false, true, true, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigureBarChart(true, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked100pc"))
                {
                    ConfigureBarChart(true, true, true, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("cylinder"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Cylinder);
                }
                else if (tag[1].ToLower().Equals("cone"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Cone);
                }
                else if (tag[1].ToLower().Equals("pyramid"))
                {
                    ConfigureBarChart(true, true, false, BarAppearanceEnum.Pyramid);
                }
            }
            else if (tag[0].ToLower().Equals("column"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigureColumnChart(false, false, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigureColumnChart(false, true, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("stacked100pc"))
                {
                    ConfigureColumnChart(false, true, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigureColumnChart(true, false, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dstacked100pc"))
                {
                    ConfigureColumnChart(true, true, true, false, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("3dmultirow"))
                {
                    ConfigureColumnChart(true, false, false, true, BarAppearanceEnum.Default);
                }
                else if (tag[1].ToLower().Equals("cylinder"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Cylinder);
                }
                else if (tag[1].ToLower().Equals("cone"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Cone);
                }
                else if (tag[1].ToLower().Equals("pyramid"))
                {
                    ConfigureColumnChart(true, true, false, false, BarAppearanceEnum.Pyramid);
                }
            }
            else if (tag[0].ToLower().Equals("pie"))
            {
                if (tag[1].ToLower().Equals("default"))
                {
                    ConfigurePieChart(false, false, 0, 0);
                }
                else if (tag[1].ToLower().Equals("sliced"))
                {
                    ConfigurePieChart(false, false, 0, 10);
                }
                else if (tag[1].ToLower().Equals("stacked"))
                {
                    ConfigurePieChart(false, true, 0, 0);
                }
                else if (tag[1].ToLower().Equals("doughnut"))
                {
                    ConfigurePieChart(false, false, 50, 0);
                }
                else if (tag[1].ToLower().Equals("sliceddoughnut"))
                {
                    ConfigurePieChart(false, false, 50, 10);
                }
                else if (tag[1].ToLower().Equals("3d"))
                {
                    ConfigurePieChart(true, false, 0, 0);
                }
                else if (tag[1].ToLower().Equals("3dstacked"))
                {
                    ConfigurePieChart(true, true, 0, 0);
                }
                else if (tag[1].ToLower().Equals("3dsliced"))
                {
                    ConfigurePieChart(true, false, 0, 10);
                }
                else if (tag[1].ToLower().Equals("3ddoughnut"))
                {
                    ConfigurePieChart(true, false, 50, 0);
                }
                else if (tag[1].ToLower().Equals("3dsliceddoughnut"))
                {
                    ConfigurePieChart(true, false, 50, 10);
                }
            }
        }

        private void c1Chart1_MouseMove(object sender, MouseEventArgs e)
        {
            int si = -1, pi = -1, dist = -1;
            if (c1Chart1.ChartGroups[0].CoordToDataIndex(e.X, e.Y, C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref dist))
            {
                if (dist <= 5)
                {
                    _ps.SeriesIndex = si;
                    _ps.PointIndex = pi;
                    _ps.SymbolStyle.Shape = c1Chart1.ChartGroups[0].ChartData.SeriesList[si].SymbolStyle.Shape;
                }                 
            }
        }

        private void c1TopicBar1_PageExpanded(object sender, C1.Win.C1Command.C1TopicBarPageEventArgs e)
        {
            foreach (C1.Win.C1Command.C1TopicPage page in c1TopicBar1.Pages)
            {
                if (page != e.Page && !page.Collapsed)
                    page.Collapsed = true;
            }
        }

    }
}
