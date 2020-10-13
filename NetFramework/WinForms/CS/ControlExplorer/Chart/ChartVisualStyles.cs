using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1Chart;

namespace ControlExplorer.Chart
{
    class ChartVisualStyles
    {
        public enum ChartStyles
        {
            Gallery,
            Office2007Blue,
            Office2007Black,
            Office2007Silver,
            MediaPlayer
        }
        public static void ApplyVisualStyle(C1Chart chart, ChartStyles style)
        {
            if (style == ChartStyles.Gallery)
            {
                chart.BackColor = Color.FromArgb(153, 180, 209);
                chart.ForeColor = Color.Black;
                chart.ChartArea.PlotArea.BackColor = Color.White;
                chart.ChartArea.PlotArea.BackColor2 = Color.FromArgb(215, 228, 242);
                chart.ChartArea.PlotArea.GradientStyle = GradientStyleEnum.None;
                chart.Style.BackColor = Color.FromArgb(153, 180, 209);
                chart.Style.BackColor2 = Color.FromArgb(215, 228, 242);
                chart.Style.GradientStyle = GradientStyleEnum.DiagonalCenter;
                chart.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Style.Border.Color = Color.DarkGray;
                chart.Style.Border.Thickness = 1;
                chart.Style.Border.Rounding.All = 0;
                chart.ChartArea.AxisX.ForeColor = Color.DimGray;
                chart.ChartArea.AxisX.Thickness = 2;
                chart.ChartArea.AxisX.GridMajor.Color = Color.LightGray;
                chart.ChartArea.AxisX.GridMinor.Color = Color.LightGray;
                chart.ChartArea.AxisY.ForeColor = Color.DimGray;
                chart.ChartArea.AxisY.Thickness = 1;
                chart.ChartArea.AxisY.GridMajor.Color = Color.LightGray;
                chart.ChartArea.AxisY.GridMinor.Color = Color.LightGray;
                chart.Footer.Style.ForeColor = Color.Black;
                chart.Footer.Style.BackColor = Color.FromArgb(153, 180, 209);
                chart.Footer.Style.BackColor2 = Color.FromArgb(215, 228, 242);
                chart.Footer.Style.GradientStyle = GradientStyleEnum.DiagonalCenter;
                chart.Footer.Style.Border.Color = Color.Transparent;
                chart.Footer.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Footer.Style.Border.Rounding.All = 0;
                chart.Header.Style.ForeColor = Color.Black;
                chart.Header.Style.BackColor = Color.Transparent;
                chart.Header.Style.BackColor2 = Color.Transparent;
                chart.Header.Style.GradientStyle = GradientStyleEnum.None;
                chart.Header.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Header.Style.Border.Rounding.All = 0;
                chart.Header.Style.Opaque = false;
                chart.Legend.Style.BackColor = Color.FromArgb(153, 180, 209);
                chart.Legend.Style.BackColor2 = Color.FromArgb(215, 228, 242);
                chart.Legend.Style.GradientStyle = GradientStyleEnum.DiagonalCenter;
                chart.Legend.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Legend.Style.Border.Rounding.All = 0;
                chart.Legend.Style.Border.Color = Color.Transparent;
                chart.Legend.Style.Border.Thickness = 1;
                chart.Legend.Style.ForeColor = Color.Black;
                chart.ColorGeneration = ColorGeneration.Custom;
            }
            else if (style == ChartStyles.MediaPlayer)
            {
                chart.BackColor = Color.FromArgb(18, 23, 38);
                chart.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ChartArea.PlotArea.BackColor = Color.FromArgb(234, 238, 245);
                chart.ChartArea.PlotArea.GradientStyle = GradientStyleEnum.None;
                chart.Style.BackColor = Color.FromArgb(234, 238, 245);
                chart.Style.GradientStyle = GradientStyleEnum.None;
                chart.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Style.Border.Color = Color.FromArgb(104, 112, 134);
                chart.Style.Border.Thickness = 1;
                chart.Style.Border.Rounding.All = 3;
                chart.ChartArea.AxisX.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ChartArea.AxisX.Thickness = 1;
                chart.ChartArea.AxisX.GridMajor.Color = Color.FromArgb(200, 203, 206);
                chart.ChartArea.AxisX.GridMinor.Color = Color.FromArgb(200, 203, 206);
                chart.ChartArea.AxisY.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ChartArea.AxisY.Thickness = 1;
                chart.ChartArea.AxisY.GridMajor.Color = Color.FromArgb(200, 203, 206);
                chart.ChartArea.AxisY.GridMinor.Color = Color.FromArgb(200, 203, 206);
                chart.Footer.Style.ForeColor = Color.FromArgb(234, 238, 245);
                chart.Footer.Style.BackColor = Color.Transparent;
                chart.Footer.Style.BackColor2 = Color.Transparent;
                chart.Footer.Style.GradientStyle = GradientStyleEnum.None;
                chart.Footer.Style.Border.Color = Color.FromArgb(28, 42, 118);
                chart.Footer.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Footer.Style.Border.Rounding.All = 3;
                chart.Header.Style.ForeColor = Color.FromArgb(234, 238, 245);
                chart.Header.Style.BackColor = Color.FromArgb(96, 106, 134);
                chart.Header.Style.BackColor2 = Color.FromArgb(64, 72, 88);
                chart.Header.Style.GradientStyle = GradientStyleEnum.Vertical;
                chart.Header.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Header.Style.Border.Rounding.All = 3;
                chart.Header.Style.Opaque = true;
                chart.Legend.Style.BackColor = Color.Transparent;
                chart.Legend.Style.BackColor2 = Color.Transparent;
                chart.Legend.Style.GradientStyle = GradientStyleEnum.None;
                chart.Legend.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Legend.Style.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ColorGeneration = ColorGeneration.Flow;
            }
            else if (style == ChartStyles.Office2007Blue)
            {
                chart.BackColor = Color.FromArgb(202, 218, 237);
                chart.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ChartArea.PlotArea.BackColor = Color.FromArgb(247, 250, 253);
                chart.ChartArea.PlotArea.GradientStyle = GradientStyleEnum.None;
                chart.Style.BackColor = Color.FromArgb(237, 242, 249);
                chart.Style.BackColor2 = Color.FromArgb(242, 249, 254);
                chart.Style.GradientStyle = GradientStyleEnum.Vertical;
                chart.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Style.Border.Color = Color.FromArgb(147, 186, 219);
                chart.Style.Border.Thickness = 1;
                chart.Style.Border.Rounding.All = 3;
                chart.ChartArea.AxisX.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ChartArea.AxisX.Thickness = 1;
                chart.ChartArea.AxisX.GridMajor.Color = Color.FromArgb(198, 199, 201);
                chart.ChartArea.AxisX.GridMinor.Color = Color.FromArgb(198, 199, 201);
                chart.ChartArea.AxisY.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ChartArea.AxisY.Thickness = 1;
                chart.ChartArea.AxisY.GridMajor.Color = Color.FromArgb(198, 199, 201);
                chart.ChartArea.AxisY.GridMinor.Color = Color.FromArgb(198, 199, 201);
                chart.Footer.Style.ForeColor = Color.FromArgb(21, 66, 139);
                chart.Footer.Style.BackColor = Color.Transparent;
                chart.Footer.Style.BackColor2 = Color.Transparent;
                chart.Footer.Style.GradientStyle = GradientStyleEnum.None;
                chart.Footer.Style.Border.Color = Color.FromArgb(28, 42, 118);
                chart.Footer.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Footer.Style.Border.Rounding.All = 3;
                chart.Header.Style.ForeColor = Color.FromArgb(21, 66, 139);
                chart.Header.Style.BackColor = Color.FromArgb(218, 229, 244);
                chart.Header.Style.BackColor2 = Color.FromArgb(207, 221, 239);
                chart.Header.Style.GradientStyle = GradientStyleEnum.Vertical;
                chart.Header.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Header.Style.Border.Rounding.All = 3;
                chart.Header.Style.Opaque = true;
                chart.Legend.Style.BackColor = Color.FromArgb(219, 233, 250);
                chart.Legend.Style.BackColor2 = Color.FromArgb(219, 233, 250);
                chart.Legend.Style.GradientStyle = GradientStyleEnum.None;
                chart.Legend.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Legend.Style.Border.Rounding.All = 3;
                chart.Legend.Style.Border.Color = Color.FromArgb(135, 178, 213);
                chart.Legend.Style.Border.Thickness = 1;
                chart.Legend.Style.ForeColor = Color.FromArgb(21, 66, 139);
                chart.ColorGeneration = ColorGeneration.Office;
            }
            else if (style == ChartStyles.Office2007Black)
            {
                chart.BackColor = Color.FromArgb(181, 188, 198);
                chart.ForeColor = Color.FromArgb(70, 70, 70);
                chart.ChartArea.PlotArea.BackColor = Color.FromArgb(242, 243, 245);
                chart.ChartArea.PlotArea.GradientStyle = GradientStyleEnum.None;
                chart.Style.BackColor = Color.FromArgb(235, 237, 240);
                chart.Style.BackColor2 = Color.WhiteSmoke;
                chart.Style.GradientStyle = GradientStyleEnum.Vertical;
                chart.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Style.Border.Color = Color.FromArgb(149, 150, 151);
                chart.Style.Border.Thickness = 1;
                chart.Style.Border.Rounding.All = 3;
                chart.ChartArea.AxisX.ForeColor = Color.FromArgb(70, 70, 70);
                chart.ChartArea.AxisX.Thickness = 1;
                chart.ChartArea.AxisX.GridMajor.Color = Color.FromArgb(188, 188, 188);
                chart.ChartArea.AxisX.GridMinor.Color = Color.FromArgb(188, 188, 188);
                chart.ChartArea.AxisY.ForeColor = Color.FromArgb(70, 70, 70);
                chart.ChartArea.AxisY.Thickness = 1;
                chart.ChartArea.AxisY.GridMajor.Color = Color.FromArgb(188, 188, 188);
                chart.ChartArea.AxisY.GridMinor.Color = Color.FromArgb(188, 188, 188);
                chart.Footer.Style.ForeColor = Color.FromArgb(70, 70, 70);
                chart.Footer.Style.BackColor = Color.Transparent;
                chart.Footer.Style.BackColor2 = Color.Transparent;
                chart.Footer.Style.GradientStyle = GradientStyleEnum.None;
                chart.Footer.Style.Border.Color = Color.FromArgb(28, 42, 118);
                chart.Footer.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Footer.Style.Border.Rounding.All = 3;
                chart.Header.Style.ForeColor = Color.FromArgb(70, 70, 70);
                chart.Header.Style.BackColor = Color.FromArgb(214, 218, 224);
                chart.Header.Style.BackColor2 = Color.FromArgb(193, 198, 207);
                chart.Header.Style.GradientStyle = GradientStyleEnum.Vertical;
                chart.Header.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Header.Style.Border.Rounding.All = 3;
                chart.Header.Style.Opaque = true;
                chart.Legend.Style.BackColor = Color.FromArgb(202, 208, 214);
                chart.Legend.Style.BackColor2 = Color.FromArgb(202, 208, 214);
                chart.Legend.Style.GradientStyle = GradientStyleEnum.None;
                chart.Legend.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Legend.Style.Border.Rounding.All = 3;
                chart.Legend.Style.Border.Color = Color.FromArgb(152, 153, 155);
                chart.Legend.Style.Border.Thickness = 1;
                chart.Legend.Style.ForeColor = Color.FromArgb(70, 70, 70);
                chart.ColorGeneration = ColorGeneration.Office;
            }
            else if (style == ChartStyles.Office2007Silver)
            {
                chart.BackColor = Color.FromArgb(225, 233, 240);
                chart.ForeColor = Color.FromArgb(76, 83, 92);
                chart.ChartArea.PlotArea.BackColor = Color.FromArgb(245, 248, 248);
                chart.ChartArea.PlotArea.GradientStyle = GradientStyleEnum.None;
                chart.Style.BackColor = Color.FromArgb(242, 245, 247);
                chart.Style.BackColor2 = Color.FromArgb(247, 249, 249);
                chart.Style.GradientStyle = GradientStyleEnum.Vertical;
                chart.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Style.Border.Color = Color.FromArgb(162, 163, 163);
                chart.Style.Border.Thickness = 1;
                chart.Style.Border.Rounding.All = 3;
                chart.ChartArea.AxisX.ForeColor = Color.FromArgb(76, 83, 92);
                chart.ChartArea.AxisX.Thickness = 1;
                chart.ChartArea.AxisX.GridMajor.Color = Color.FromArgb(198, 199, 199);
                chart.ChartArea.AxisX.GridMinor.Color = Color.FromArgb(198, 199, 199);
                chart.ChartArea.AxisY.ForeColor = Color.FromArgb(76, 83, 92);
                chart.ChartArea.AxisY.Thickness = 1;
                chart.ChartArea.AxisY.GridMajor.Color = Color.FromArgb(198, 199, 199);
                chart.ChartArea.AxisY.GridMinor.Color = Color.FromArgb(198, 199, 199);
                chart.Footer.Style.ForeColor = Color.FromArgb(76, 83, 92);
                chart.Footer.Style.BackColor = Color.Transparent;
                chart.Footer.Style.BackColor2 = Color.Transparent;
                chart.Footer.Style.GradientStyle = GradientStyleEnum.None;
                chart.Footer.Style.Border.Color = Color.FromArgb(28, 42, 118);
                chart.Footer.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Footer.Style.Border.Rounding.All = 3;
                chart.Header.Style.ForeColor = Color.FromArgb(76, 83, 92);
                chart.Header.Style.BackColor = Color.FromArgb(242, 244, 248);
                chart.Header.Style.BackColor2 = Color.FromArgb(193, 198, 207);
                chart.Header.Style.GradientStyle = GradientStyleEnum.Vertical;
                chart.Header.Style.Border.BorderStyle = BorderStyleEnum.None;
                chart.Header.Style.Border.Rounding.All = 3;
                chart.Header.Style.Opaque = true;
                chart.Legend.Style.BackColor = Color.FromArgb(242, 244, 247);
                chart.Legend.Style.BackColor2 = Color.FromArgb(242, 244, 247);
                chart.Legend.Style.GradientStyle = GradientStyleEnum.None;
                chart.Legend.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                chart.Legend.Style.Border.Rounding.All = 3;
                chart.Legend.Style.Border.Color = Color.FromArgb(151, 152, 153);
                chart.Legend.Style.Border.Thickness = 1;
                chart.Legend.Style.ForeColor = Color.FromArgb(76, 83, 92);
                chart.ColorGeneration = ColorGeneration.Office;
            }
        }
    }
}
