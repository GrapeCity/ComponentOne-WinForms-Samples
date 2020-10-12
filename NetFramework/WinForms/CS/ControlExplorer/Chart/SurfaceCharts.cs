using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart3D;

namespace ControlExplorer.Chart
{
    public partial class SurfaceCharts : C1DemoForm
    {

        public SurfaceCharts()
        {
            InitializeComponent();
        }

        private void SurfaceCharts_Load(object sender, EventArgs e)
        {
            Chart3DDataSetGrid grid = c1Chart3D1.ChartGroups.Group0.ChartData.SetGrid;
            IList rows = categorySales1.List;
            Chart3DAxis x = c1Chart3D1.ChartArea.AxisX;
            Chart3DAxis y = c1Chart3D1.ChartArea.AxisY;
            Chart3DAxis z = c1Chart3D1.ChartArea.AxisZ;
            grid.RowCount = rows.Count;
            grid.ColumnCount = 4;

            for (int i = 0; i < rows.Count; i++)
            {
                DataRowView view = rows[i] as DataRowView;
                DataRow r = view.Row;
                grid[0, i] = System.Convert.ToDouble(r[1]);
                grid[1, i] = System.Convert.ToDouble(r[2]);
                grid[2, i] = System.Convert.ToDouble(r[3]);
                grid[3, i] = System.Convert.ToDouble(r[4]);
                y.ValueLabels.Add(i, r[0].ToString());
            }

            x.ValueLabels.Add(0, "Q1");
            x.ValueLabels.Add(1, "Q2");
            x.ValueLabels.Add(2, "Q3");
            x.ValueLabels.Add(3, "Q4");
            x.AnnoMethod = AnnotationMethodEnum.ValueLabels;
            x.AnnoPosition = AnnoPositionEnum.Both;

            x.MajorGrid.IsOnXYPlane = true;
            x.MajorGrid.IsOnXZPlane = true;
            x.MajorGrid.Style.Color = SystemColors.ControlDarkDark;

            y.AnnoMethod = AnnotationMethodEnum.ValueLabels;
            y.AnnoRotated = true;
            y.AnnoPosition = AnnoPositionEnum.Both;

            y.MajorGrid.IsOnXYPlane = true;
            y.MajorGrid.IsOnYZPlane = true;
            y.MajorGrid.Style.Color = SystemColors.ControlDarkDark;

            z.AnnoFormat = FormatEnum.NumericManual;
            z.AnnoFormatString = "#,";
            z.Text = "$1,000's";
            z.UnitMajor = z.UnitMinor;

            z.MajorGrid.IsOnXZPlane = true;
            z.MajorGrid.IsOnYZPlane = true;
            z.MajorGrid.Style.Color = SystemColors.ControlDarkDark;

            InitComboFromEnum(cbChartTypes, typeof(Chart3DTypeEnum));
            InitComboFromEnum(cbProjections, typeof(View3DEnum));
            cbChartTypes.SelectedItem = Chart3DTypeEnum.Surface;

            //Adjust zoom level
            c1Chart3D1.ChartArea.View.ViewportScale = 1.4f;
            c1Chart3D1.ChartArea.View.ViewportHorizontalShift = .15f;
            c1Chart3D1.ChartArea.View.ViewportVerticalShift = -.17f;

            c1Chart3D1.UseAntiAliasedGraphics = true;

            // Add demo properties
            AddProperty("Boxed", c1Chart3D1.ChartArea.View);
            AddProperty("DropLines", c1Chart3D1.ChartGroups.Group0.Elevation); 
            AddProperty("IsInteractive", c1Chart3D1.ChartArea.View);
            AddProperty("IsMeshed", c1Chart3D1.ChartGroups.Group0.Elevation);
            AddProperty("Perspective", c1Chart3D1.ChartArea.View);
            AddPropertyHeader("Axis Properties");
            AddProperty("AnnoPosition", c1Chart3D1.ChartArea.AxisX, "AxisX.AnnoPosition");
            AddProperty("AnnoPosition", c1Chart3D1.ChartArea.AxisY, "AxisY.AnnoPosition");
            AddProperty("AnnoPosition", c1Chart3D1.ChartArea.AxisZ, "AxisZ.AnnoPosition");
            AddProperty("GridLines", this);
            AddPropertyHeader("Contour Properties");
            AddProperty("IsContoured", c1Chart3D1.ChartGroups.Group0.Contour);
            AddProperty("NumLevels", c1Chart3D1.ChartGroups.Group0.Contour);
            AddProperty("ZoneMethod", c1Chart3D1.ChartGroups.Group0.Contour);
            AddPropertyHeader("Ceiling Properties");
            AddProperty("IsContoured", c1Chart3D1.ChartArea.View.Ceiling);
            AddProperty("IsZoned", c1Chart3D1.ChartArea.View.Ceiling);
            AddPropertyHeader("Floor Properties");
            AddProperty("IsContoured", c1Chart3D1.ChartArea.View.Floor);
            AddProperty("IsZoned", c1Chart3D1.ChartArea.View.Floor); 
        }

        private void InitComboFromEnum(ComboBox cb, Type entype)
        {
            Array arr = Enum.GetValues(entype);
            for (int i = 0; i < arr.Length; i++)
                cb.Items.Add(arr.GetValue(i));

            cb.SelectedItem = arr.GetValue(0);
        }

        public AnnoPositionEnum AnnoPosition
        {
            get { return c1Chart3D1.ChartArea.AxisX.AnnoPosition; }
            set
            {
                c1Chart3D1.ChartArea.AxisX.AnnoPosition = value;
                c1Chart3D1.ChartArea.AxisY.AnnoPosition = value;
            }
        }

        private void cbChartTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1Chart3D1.ChartGroups.Group0.ChartType = (Chart3DTypeEnum)cbChartTypes.SelectedItem;
        }

        private void cbProjections_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1Chart3D1.ChartArea.View.View3D = (View3DEnum)cbProjections.SelectedItem;
        }

        private void chk2DProjection_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2DProjection.Checked)
            {
                cbProjections.Visible = true;
                cbProjections.SelectedItem = View3DEnum.XY_2D_Pos;
            }
            else
            {
                cbProjections.Visible = false;
                cbProjections.SelectedItem = View3DEnum.Default;
            }
        }

        private void trkXAxis_Scroll(object sender, EventArgs e)
        {
            c1Chart3D1.ChartArea.View.RotationX = trkXAxis.Value;
        }

        private void trkYAxis_Scroll(object sender, EventArgs e)
        {
            c1Chart3D1.ChartArea.View.RotationY = trkYAxis.Value;
        }

        private void trkZAxis_Scroll(object sender, EventArgs e)
        {
            c1Chart3D1.ChartArea.View.RotationZ = trkZAxis.Value;
        }

        public bool GridLines
        {
            get { return c1Chart3D1.ChartArea.AxisX.MajorGrid.IsOnXYPlane; }
            set
            {
                foreach (Chart3DAxis ax in c1Chart3D1.ChartArea.Axes)
                {
                    ax.MajorGrid.IsOnXYPlane = value;
                    ax.MajorGrid.IsOnXZPlane = value;
                    ax.MajorGrid.IsOnYZPlane = value;
                }
            }
        }
    }
}
