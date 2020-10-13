using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace ControlExplorer.Chart
{
    public partial class TrendLines : C1DemoForm
    {
        Random rnd = new Random();
        int np = 100;
        double[] k;
        bool hasPoint = false;
        Point tlp0;

        enum DataType
        {
            Poly2,
            Poly3,
            Poly4,
            Expo,
            Log,
            Pow,
            Fourier2,
            Fourier3,
            Fourier4,
            Random
        }

        DataType dtLastGenerated = DataType.Poly2;

        public TrendLines()
        {
            InitializeComponent();
        }

        private void TrendLines_Load(object sender, EventArgs e)
        {
            c1Chart1.Legend.Orientation = LegendOrientationEnum.Vertical;
            c1Chart1.Legend.Visible = true;

            InitComboFromEnum(cbTrendType, typeof(TrendLineTypeEnum));
            InitComboFromEnum(cbDataType, typeof(DataType));
            c1Chart1.UseAntiAliasedGraphics = true;

            GenerateNewData((DataType)cbDataType.SelectedItem);

            udYIntercept.Minimum = -10;
            udYIntercept.Maximum = 10;

        }

        private void InitComboFromEnum(ComboBox cb, Type entype)
        {
            Array arr = Enum.GetValues(entype);
            for (int i = 0; i < arr.Length; i++)
                cb.Items.Add(arr.GetValue(i));

            cb.SelectedItem = arr.GetValue(0);
        }

        // generates normally distributed random numbers
        double[] RandNormal(int n)
        {
            if (n % 2 == 1)
                n++;

            double[] rn = new double[n]; //!!VBSubst Dim rn(n-1) As Double

            for (int i = 0; i < n / 2; i++)
            {
                do
                {
                    double u = 2 * rnd.NextDouble() - 1;
                    double v = 2 * rnd.NextDouble() - 1;

                    double s = u * u + v * v;

                    if (s < 1)
                    {
                        s = Math.Sqrt(-2 * Math.Log(s) / s);
                        rn[2 * i] = u * s;
                        rn[2 * i + 1] = v * s;
                        break;
                    }
                } while (true);
            }

            return rn;
        }

        // create pseudo-random data
        private void GenerateNewData(DataType dt)
        {
            ChartData cd = c1Chart1.ChartGroups[0].ChartData;
            ChartDataSeries ds;

            if (cd.SeriesList.Count != 1)
            {
                // create and setup data series
                cd.SeriesList.Clear();
                ds = cd.SeriesList.AddNewSeries();
                ds.LineStyle.Pattern = LinePatternEnum.None;
                ds.SymbolStyle.Color = Color.LightBlue;
                ds.SymbolStyle.OutlineColor = Color.DarkBlue;
                ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
            }
            else
                ds = cd[0];

            double[] x = new double[np]; //!!VBSubst Dim x(np-1) As Double
            double[] y = new double[np]; //!!VBSubst Dim y(np-1) As Double

            int nk = 2;

            if (dt == DataType.Poly3 || dt == DataType.Fourier3)
                nk = 3;

            if (dt == DataType.Poly4 || dt == DataType.Fourier4)
                nk = 4;

            k = new Double[nk];//!!VBSubst k = New Double(nk - 1) {}

            int i;

            for (i = 0; i < k.Length; i++)
            {
                k[i] = 2 * rnd.NextDouble() - 1;

                if (dt == DataType.Fourier2 || dt == DataType.Fourier3 || dt == DataType.Fourier4
                    || dt == DataType.Log)
                    k[i] *= 10;
            }

            double[] rns = RandNormal(np);

            double xconst = 5;

            if (dt == DataType.Fourier2 || dt == DataType.Fourier3 || dt == DataType.Fourier4)
                xconst = 50;

            if (dt == DataType.Log)
                k[1] = Math.Abs(k[1]);
            else if (dt == DataType.Pow || dt == DataType.Expo)
            {
                if (k[0] < 0)
                    k[1] = -Math.Abs(k[1]);
                else
                    k[1] = Math.Abs(k[1]);
            }

            for (i = 0; i < np; i++)
            {
                x[i] = xconst * rnd.NextDouble();

                switch (dt)
                {
                    case DataType.Poly2:
                    case DataType.Poly3:
                    case DataType.Poly4:
                        y[i] = 0;
                        for (int j = 0; j < k.Length; j++)
                            y[i] += k[j] * Math.Pow(x[i], j);
                        break;

                    case DataType.Log:
                        y[i] = k[0] * Math.Log(k[1] * x[i]);
                        break;

                    case DataType.Pow:
                        y[i] = k[0] * Math.Pow(x[i], k[1]);
                        break;

                    case DataType.Expo:
                        y[i] = k[0] * Math.Exp(x[i] * k[1]);
                        break;

                    case DataType.Fourier2:
                        y[i] = k[0] + Math.Cos(x[i]) * k[1];
                        break;

                    case DataType.Fourier3:
                        y[i] = k[0] + Math.Cos(x[i]) * k[1] + Math.Sin(x[i]) * k[2];
                        break;

                    case DataType.Fourier4:
                        y[i] = k[0] + Math.Cos(x[i]) * k[1] + Math.Sin(x[i]) * k[2] + Math.Cos(2 * x[i]) * k[3];
                        break;

                    default:
                        break;
                }

                y[i] += rns[i] / 10; // add some random noise
            }

            dtLastGenerated = dt;

            // put data into chart
            ds.X.CopyDataIn(x);
            ds.Y.CopyDataIn(y);

            // init trend line
            if (cd.TrendsList.Count == 0)
            {
                TrendLine tl = cd.TrendsList.AddNewTrendLine();
                tl.SeriesIndex = 0;
                tl.LineStyle.Color = Color.RoyalBlue;
                tl.LineStyle.Thickness = 3;
                tl.NumTerms = (int)udOrder.Value;
                tl.ForecastBackward = 1;
                tl.ForecastForward = 1;
            }

            // reset axes limits
            c1Chart1.ChartArea.AxisX.AutoMax = true;
            c1Chart1.ChartArea.AxisX.AutoMin = true;
            c1Chart1.ChartArea.AxisY.AutoMax = true;
            c1Chart1.ChartArea.AxisY.AutoMin = true;

            // update labels
            UpdateStatisticsLabel();
            UpdateFormulaLabel();
        }

        private string GetFormula(DataType dt, double[] k)
        {
            string fmt = "G2";

            string s = "";
            switch (dt)
            {
                case DataType.Poly2:
                case DataType.Poly3:
                case DataType.Poly4:
                    s = k[0].ToString(fmt);
                    for (int i = 1; i < k.Length; i++)
                        s += string.Format("+{0}x^{1}", k[i].ToString(fmt), i);
                    break;

                case DataType.Expo:
                    s = string.Format("{0} * exp({1}*x)", k[0].ToString(fmt), k[1].ToString(fmt));
                    break;

                case DataType.Log:
                    s = string.Format("{0} * ln({1}*x)", k[0].ToString(fmt), k[1].ToString(fmt));
                    break;

                case DataType.Pow:
                    s = string.Format("{0} * pow( x, {1})", k[0].ToString(fmt), k[1].ToString(fmt));
                    break;

                case DataType.Fourier2:
                case DataType.Fourier3:
                case DataType.Fourier4:
                    s = string.Format("{0} + {1}*cos(x)", k[0].ToString(fmt), k[1].ToString(fmt));

                    if (k.Length > 2)
                        s += string.Format(" + {0}*sin(x)", k[2].ToString(fmt));

                    if (k.Length > 3)
                        s += string.Format(" + {0}*cos(2*x)", k[3].ToString(fmt));

                    if (k.Length > 4)
                        s += string.Format(" + {0}*sin(2*x)", k[4].ToString(fmt));

                    break;

                default:
                    break;
            }

            return s;
        }

        private string GetFormula(TrendLineTypeEnum tlt, double[] k)
        {
            string s = "";
            switch (tlt)
            {
                case TrendLineTypeEnum.Polynom:
                    return GetFormula(DataType.Poly2, k);

                case TrendLineTypeEnum.Exponent:
                    return GetFormula(DataType.Expo, k);

                case TrendLineTypeEnum.Logarithmic:
                    return GetFormula(DataType.Log, k);

                case TrendLineTypeEnum.Power:
                    return GetFormula(DataType.Pow, k);

                case TrendLineTypeEnum.Fourier:
                    return GetFormula(DataType.Fourier2, k);

                default:
                    break;
            }

            return s;
        }

        private void UpdateFormulaLabel()
        {
            C1.Win.C1Chart.Label lbl;

            if (c1Chart1.ChartLabels.LabelsCollection.Count < 2)
            {
                // create formula label
                lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
                lbl.AttachMethod = AttachMethodEnum.Coordinate;
                lbl.AttachMethodData.X = c1Chart1.ChartArea.PlotArea.Location.X + c1Chart1.ChartArea.PlotArea.Size.Width / 2;
                lbl.AttachMethodData.Y = c1Chart1.ChartArea.PlotArea.Location.Y + 20;
                lbl.Style.BackColor = Color.FromArgb(192, Color.LightBlue);
                lbl.Style.GradientStyle = GradientStyleEnum.None;
                lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                lbl.Style.Border.Color = Color.DarkBlue;
                lbl.Style.Border.Rounding.All = 15;
                lbl.Style.VerticalAlignment = AlignVertEnum.Center;
                lbl.Compass = LabelCompassEnum.North;
            }
            else
                lbl = c1Chart1.ChartLabels[1];

            TrendLine tl = null;

            if (c1Chart1.ChartGroups[0].ChartData.TrendsList.Count > 0)
                tl = c1Chart1.ChartGroups[0].ChartData.TrendsList[0];
            else
                return;

            RegressionStatistics rs = tl.RegressionStatistics;

            if (rs == null || rs.Coeffs == null || !cbViewFormula.Checked)
            {
                lbl.Visible = false;
                return;
            }

            TrendLineTypeEnum tlt = (TrendLineTypeEnum)cbTrendType.SelectedItem;

            string s_regr = GetFormula(tlt, rs.Coeffs);
            string s_exact = GetFormula(dtLastGenerated, k);

            if (s_regr.Length > 0 && s_exact.Length > 0)
            {
                lbl.Visible = true;
                lbl.Text = string.Format("Data formula: {0}\n\nRegression formula: {1}", s_exact, s_regr);
            }
            else if (s_regr.Length > 0)
            {
                lbl.Visible = true;
                lbl.Text = string.Format("Regression formula: {1}", s_exact, s_regr);
            }
            else
                lbl.Visible = false;
        }

        private void UpdateStatisticsLabel()
        {
            C1.Win.C1Chart.Label lbl;

            if (c1Chart1.ChartLabels.LabelsCollection.Count < 1)
            {
                // create statistics label
                lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
                lbl.AttachMethod = AttachMethodEnum.Coordinate;
                lbl.Style.BackColor = Color.FromArgb(192, Color.MistyRose);
                lbl.Style.GradientStyle = GradientStyleEnum.None;
                lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid;
                lbl.Style.Border.Color = Color.IndianRed;
                lbl.Style.Border.Rounding.All = 15;
                lbl.Compass = LabelCompassEnum.West;
                lbl.Style.VerticalAlignment = C1.Win.C1Chart.AlignVertEnum.Center;
                lbl.Style.Font = new Font("Lucida Console", 8);
            }
            else
                lbl = c1Chart1.ChartLabels[0];

            TrendLine tl = null;

            if (c1Chart1.ChartGroups[0].ChartData.TrendsList.Count > 0)
                tl = c1Chart1.ChartGroups[0].ChartData.TrendsList[0];
            else
                return;

            RegressionStatistics rs = tl.RegressionStatistics;

            bool isRegression = (tl.TrendLineType == TrendLineTypeEnum.Exponent) ||
                (tl.TrendLineType == TrendLineTypeEnum.Fourier) ||
                (tl.TrendLineType == TrendLineTypeEnum.Logarithmic) ||
                (tl.TrendLineType == TrendLineTypeEnum.Polynom) ||
                (tl.TrendLineType == TrendLineTypeEnum.Power);

            if ((rs == null) && isRegression)
            {
                lblErrorData.Visible = true;
            }
            else
            {
                lblErrorData.Visible = false;
            }

            if (rs != null && cbViewStatistics.Checked)
            {
                lbl.Text = CreateStatisticsString(rs, "g4", false);
                //string.Format(
                //"Statistics\n----------\nRSQ\t= {0:g4}\nSEY\t= {1:g4}\nF\t= {2:g4}\nDF\t= {3:g4}\nSSR\t= {4:g4}\nSSE\t= {5:g4}",
                //rs.Rsq, rs.Sey, rs.F, rs.DF, rs.Ssr, rs.Sse);
                lbl.Visible = true;
            }
            else
                lbl.Visible = false;
        }

        string CreateStatisticsString(RegressionStatistics rs, string fmt, bool coeffs)
        {
            string s = "Statistics\n----------\n";

            if (coeffs)
            {
                double[] k = rs.Coeffs;

                for (int i = 0; i < k.Length; i++)
                    s += string.Format("k[{0}]\t= {1}\n", i, k[i].ToString(fmt));
            }

            s += string.Format(
                "RSQ\t= {0}\nSEY\t= {1}\nF\t= {2}\nDF\t= {3}\nSSR\t= {4}\nSSE\t= {5}",
                rs.Rsq.ToString(fmt), rs.Sey.ToString(fmt), rs.F.ToString(fmt),
                rs.DF.ToString(fmt), rs.Ssr.ToString(fmt), rs.Sse.ToString(fmt));

            return s;
        }

        private void cbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateNewData((DataType)cbDataType.SelectedItem);
        }

        private void cbTrendType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartData cd = c1Chart1.ChartGroups[0].ChartData;

            if (cd.TrendsList.Count > 0)
            {
                TrendLine tl = cd.TrendsList[0];
                tl.TrendLineType = (TrendLineTypeEnum)cbTrendType.SelectedItem;
                if (tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage)
                    udOrder.Maximum = np;
                else
                    udOrder.Maximum = 5;

                bool isNumber = tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage ||
                    tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.Polynom ||
                    tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.Fourier;

                lblNumber.Visible = isNumber;
                udOrder.Visible = isNumber;

                bool isPoly = (tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.Polynom);

                cbUseYIntercept.Visible = isPoly;
                udYIntercept.Visible = isPoly;

                if (tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage)
                    lblNumber.Text = "Period:";
                else
                    lblNumber.Text = "Number of terms:";

                UpdateStatisticsLabel();
                UpdateFormulaLabel();
            }
        }

        private void c1Chart1_Paint(object sender, PaintEventArgs e)
        {
            if (hasPoint)
            {
                Pen pen = new Pen(Color.Red, 2);
                e.Graphics.DrawEllipse(pen, tlp0.X - 5, tlp0.Y - 5, 11, 11);
                pen.Dispose();
            }
        }

        private void c1Chart1_MouseMove(object sender, MouseEventArgs e)
        {
            //handle dragging
            if (cbAllowDragging.Checked)
            {
                if (dragging)
                {
                    Point pt1 = c1Chart1.PointToScreen(move_pt);

                    if (!prev.IsEmpty)
                        ControlPaint.DrawReversibleLine(pt1, prev, c1Chart1.ChartArea.PlotArea.BackColor);

                    Point pt2 = c1Chart1.PointToScreen(new Point(e.X, e.Y));
                    ControlPaint.DrawReversibleLine(pt1, pt2, c1Chart1.ChartArea.PlotArea.BackColor);
                    prev = pt2;
                }
                else
                {
                    int si = -1, pi = -1, dist = -1;
                    if (c1Chart1.ChartGroups[0].CoordToDataIndex(e.X, e.Y,
                        C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref dist))
                    {
                        if (dist <= 6)
                            c1Chart1.Cursor = Cursors.Hand;
                        else
                            c1Chart1.Cursor = Cursors.Default;
                    }
                    else
                        c1Chart1.Cursor = Cursors.Default;
                }
            }

            //handle trend cursor
            Point mpt = new Point(e.X, e.Y);

            PlotArea pa = c1Chart1.ChartArea.PlotArea;

            Rectangle rect = new Rectangle(pa.Location, pa.Size);

            if (rect.Contains(mpt) && this.cbTLCursor.Checked)
            {
                ChartGroup cg = c1Chart1.ChartGroups[0];
                if (cg.ChartData.TrendsList.Count > 0)
                {
                    TrendLine tl = cg.ChartData.TrendsList[0];

                    double x = 0, y = 0;
                    int ix = 0, iy = 0;

                    if (tl.RegressionStatistics != null)
                    {
                        if (cg.CoordToDataCoord(mpt.X, mpt.Y, ref x, ref y))
                        {
                            y = tl.GetY(x);

                            if (cg.DataCoordToCoord(x, y, ref ix, ref iy) && rect.Contains(ix, iy))
                            {
                                Point tlp = new Point(ix, iy);

                                hasPoint = true;

                                Rectangle invRect = new Rectangle(tlp.X - 8, tlp.Y - 8, 16, 16);

                                if (!tlp0.IsEmpty)
                                    invRect = Rectangle.Union(invRect, new Rectangle(tlp0.X - 8, tlp0.Y - 8, 16, 16));

                                c1Chart1.Invalidate(invRect);

                                tlp0 = tlp;

                                return;
                            }
                        }
                    }
                }
            }
            hasPoint = false;
        }

        private void c1Chart1_LayoutLabels(object sender, EventArgs e)
        {
            Point p = c1Chart1.ChartArea.PlotArea.Location;

            if (c1Chart1.Legend.Visible)
                c1Chart1.Legend.Location = new Point(p.X + 20, p.Y + 20);

            if (c1Chart1.ChartLabels.LabelsCollection.Count > 0)
            {
                C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels[0];

                p.X += c1Chart1.ChartArea.PlotArea.Size.Width - 10;
                p.Y += c1Chart1.ChartArea.PlotArea.Size.Height / 2;

                lbl.AttachMethodData.X = p.X;
                lbl.AttachMethodData.Y = p.Y;
            }

            if (c1Chart1.ChartLabels.LabelsCollection.Count > 1)
            {
                C1.Win.C1Chart.Label lbl = c1Chart1.ChartLabels[1];

                p = c1Chart1.ChartArea.PlotArea.Location;

                p.X += c1Chart1.ChartArea.PlotArea.Size.Width / 2;
                p.Y += c1Chart1.ChartArea.PlotArea.Size.Height - 10;


                lbl.AttachMethodData.X = p.X;
                lbl.AttachMethodData.Y = p.Y;
            }
        }

        private void cbViewStatistics_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatisticsLabel();
        }

        private void cbViewFormula_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFormulaLabel();
        }

        private void cbViewLegend_CheckedChanged(object sender, EventArgs e)
        {
            c1Chart1.Legend.Visible = cbViewLegend.Checked;
        }

        private void cbUseYIntercept_CheckedChanged(object sender, EventArgs e)
        {
            ChartGroup cg = c1Chart1.ChartGroups[0];
            if (cg.ChartData.TrendsList.Count > 0)
            {
                TrendLine tl = cg.ChartData.TrendsList[0];
                tl.RegressionOptions.UseYIntercept = cbUseYIntercept.Checked;

                UpdateStatisticsLabel();
                UpdateFormulaLabel();
            }

            udYIntercept.Visible = cbUseYIntercept.Checked;
        }

        private void udYIntercept_ValueChanged(object sender, EventArgs e)
        {
            ChartData cd = c1Chart1.ChartGroups[0].ChartData;

            if (cd.TrendsList.Count > 0)
            {
                TrendLine tl = cd.TrendsList[0];

                tl.RegressionOptions.YIntercept = (double)udYIntercept.Value;

                UpdateStatisticsLabel();
                UpdateFormulaLabel();
            }
        }

        private void udOrder_ValueChanged(object sender, EventArgs e)
        {
            ChartData cd = c1Chart1.ChartGroups[0].ChartData;

            if (cd.TrendsList.Count > 0)
            {
                TrendLine tl = cd.TrendsList[0];

                if (tl.TrendLineType == C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage)
                    tl.Period = (int)udOrder.Value;
                else
                    tl.NumTerms = (int)udOrder.Value;

                UpdateStatisticsLabel();
                UpdateFormulaLabel();
            }
        }

        private void c1Chart1_Resize(object sender, EventArgs e)
        {
            c1Chart1.Update();
        }

        bool dragging = false;
        int move_si = -1;
        int move_pi = -1;
        Point move_pt;
        Point prev = Point.Empty;

        private void c1Chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbAllowDragging.Checked)
            {
                int si = -1, pi = -1, dist = -1;
                if (c1Chart1.ChartGroups[0].CoordToDataIndex(e.X, e.Y,
                    C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref dist))
                {
                    if (dist <= 6)
                    {
                        c1Chart1.Cursor = Cursors.Hand;
                        dragging = true;
                        move_si = si;
                        move_pi = pi;
                        move_pt = new Point(e.X, e.Y);
                    }
                }
            }
        }

        private void c1Chart1_MouseUp(object sender, MouseEventArgs e)
        {
            if (cbAllowDragging.Checked)
            {
                if (dragging)
                {
                    double x = 0, y = 0;
                    if (c1Chart1.ChartGroups[0].CoordToDataCoord(e.X, e.Y, ref x, ref y))
                    {
                        if (y > c1Chart1.ChartArea.AxisY.Max)
                            y = c1Chart1.ChartArea.AxisY.Max;
                        else if (y < c1Chart1.ChartArea.AxisY.Min)
                            y = c1Chart1.ChartArea.AxisY.Min;

                        c1Chart1.ChartGroups[0].ChartData[move_si].X[move_pi] = x;
                        c1Chart1.ChartGroups[0].ChartData[move_si].Y[move_pi] = y;
                    }

                    c1Chart1.Cursor = Cursors.Default;
                    dragging = false;

                    if (!prev.IsEmpty)
                    {
                        Point pt1 = c1Chart1.PointToScreen(move_pt);
                        ControlPaint.DrawReversibleLine(pt1, prev, c1Chart1.ChartArea.PlotArea.BackColor);
                        prev = Point.Empty;
                    }
                    UpdateStatisticsLabel();
                    UpdateFormulaLabel();
                }
            }
        }

    }
}
