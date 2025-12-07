using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Win.Chart.Interaction;
using C1.Win.Chart.Finance;
using C1.Chart.Finance;

namespace StockAnalysis
{
    public partial class MainForm : Form
    {
        const int MenuButtonHeight = 50;
        EditableAnnotationLayer al = null;
        Color MenuBackColor = Color.White; //Color.FromArgb(249, 249, 249);
        Color MenuOnOverColor = Color.FromArgb(200, 200, 200);
        Color MenuSelectedColor = Color.FromArgb(230, 230, 230);
        Color MenuPosForeColor = ViewModel.IndicatorPalettes.StockGreen;
        Color MenuNegForeColor = ViewModel.IndicatorPalettes.StockRed;
        RangeSelector XRangeSelector = null;
        int _annoFontButtonLeft = 0;

        ViewModel.ViewModel viewModel = null;
        bool isTimeIndependent = false;

        public MainForm()
        {
            InitializeComponent();

            financialChart.BackColor = ViewModel.IndicatorPalettes.PaperWhite1000;
            rangeChart.BackColor = ViewModel.IndicatorPalettes.PaperWhite1000;
            this.ForeColor = ViewModel.IndicatorPalettes.Grey700;

            // since PointAndFigure is possible and inherits from FinancialChartOptions, just start with it.
            financialChart.Options = new PointAndFigureOptions();

            // initialize the RangeSelector after the chart is initially rendered.
            rangeChart.Rendered += (obj, ev) => InitializeRangeSelector();

            // whenever the financial chart is rendered, ensure that the range chart plot boundaries
            // are the same.
            financialChart.Rendered += (obj, ev) =>
                {
                    if (rangeChart.Visible)
                    {
                        Rectangle r = Rectangle.Round(financialChart.PlotRect);
                        Padding newPadding = new Padding(r.Left, 0, rangeChart.ClientSize.Width - r.Right, 0);
                        if (rangeChart.PlotMargin != newPadding) rangeChart.PlotMargin = newPadding;
                    }
                };

            // post the application image.
            pictureBoxTitle.Image = ImageManager.GetNamedImage("StockAnalysis");
            pictureBoxTitle.Padding = new Padding(0, (pictureBoxTitle.Height - pictureBoxTitle.Image.Height) / 2, 0, 0);

            // draw dividing lines as appropriate for the design.
            tableLayoutPanel1.CellPaint += tableLayoutPanel_CellPaint;
            tableLayoutPanel2.CellPaint += tableLayoutPanel_CellPaint;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            viewModel = ViewModel.ViewModel.Instance;

            // wait until data is available.
            int count = 61;
            do
            {
                count--;
                while (viewModel.Quotes == null && count > 0)
                {
                    System.Threading.Thread.Sleep(1000);
                    count--;
                }

                if (count == 0)
                {
                    DialogResult dr = MessageBox.Show("Data for Stocks are not available.\r\nPlease try again later.",
                        "StockAnalysis", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.Cancel)
                        Environment.Exit(1);
                    else
                        count = 61;
                }
            } while (count > 60);

            InitializeMasterSettings();
            InitializeSelections();
            InitializeButtons();
            InitializeAnnotationControls();
            InitializeAnnotationLayer(financialChart);

            // close the drop panel with other inputs
            InitializePanelBehavior(this);
        }

        protected override void WndProc(ref Message m)
        { 
            // WM_SYSCOMMAND
            if (m.Msg == 0x0112)
            {
                if (m.WParam == new IntPtr(0xF030) // Maximize event - SC_MAXIMIZE from Winuser.h
                    || m.WParam == new IntPtr(0xF120)) // Restore event - SC_RESTORE from Winuser.h
                {
                    DropPanel.CloseActivePanelClickHandler(null, null);
                }
            }
            base.WndProc(ref m);
        }

        #region Initializations
        public enum NewAnnotationType
        {
            None,
            Circle,
            Ellipse,
            Line,
            Polygon,
            Rectangle,
            Square,
            Text,
        }

        private void InitializeAnnotationLayer(FinancialChart chart)
        {
            al = new EditableAnnotationLayer(chart);
            al.DefaultStyle = new ChartStyle()
            {
                //Fill = new SolidBrush(btnAnnoFill.BackColor),
                //Stroke = new SolidBrush(btnAnnoStroke.FlatAppearance.BorderColor),
                FillColor = btnAnnoFill.BackColor,
                StrokeColor = btnAnnoStroke.FlatAppearance.BorderColor,
            };
            al.DefaultContentStyle = new ChartStyle()
            {
                //Fill = new SolidBrush(Color.White),
                //Stroke = new SolidBrush(Color.Black),
                FillColor = Color.White,
                StrokeColor = Color.Black,
            };

            chart.MouseDown += (s, e) =>
            {
                chart.Focus(); //KeyDown does not triggers without this
                if (e.Button == MouseButtons.Right)
                {
                    if (al.HitTest(e.Location) != null)
                    {
                        if (chart.ContextMenu == null)
                        {
                            MenuItem edit = new MenuItem("Edit");
                            edit.Click += (smie, eve) =>
                                {
                                    using (frmAnnotation frm = new frmAnnotation(al.SelectedAnnotation))
                                    {
                                        frm.BuildForm();
                                        frm.StartPosition = FormStartPosition.Manual;
                                        frm.Location = chart.PointToScreen(AdjustPosition(e.Location, frm.Size, financialChart));
                                        frm.ShowDialog();
                                    }
                                };

                            MenuItem del = new MenuItem("Delete");
                            del.Click += (smi, ev) => { al.Annotations.Remove(al.SelectedAnnotation); };

                            chart.ContextMenu = new System.Windows.Forms.ContextMenu(new MenuItem[] { edit, del });
                            foreach (MenuItem mi in chart.ContextMenu.MenuItems)
                            {
                                mi.OwnerDraw = true;
                                mi.MeasureItem += (sed, eed) => { eed.ItemHeight = 14; eed.ItemWidth = 35; };
                                mi.DrawItem += (sed, eed) =>
                                {
                                    string text = chart.ContextMenu.MenuItems[eed.Index].Text;

                                    Brush bbr = eed.State.HasFlag(DrawItemState.Selected) ? Brushes.LightGray : Brushes.White;
                                    Pen pen = eed.State.HasFlag(DrawItemState.Selected) ? Pens.LightGray : Pens.White;
                                    eed.Graphics.FillRectangle(bbr, eed.Bounds);
                                    eed.Graphics.DrawRectangle(pen, eed.Bounds);

                                    using(Brush br = new SolidBrush(this.ForeColor))
                                        using(Font font = new Font(this.Font, FontStyle.Regular))
                                            eed.Graphics.DrawString(text, font, br, eed.Bounds.Location);
                                };
                            }
                        }
                        chart.ContextMenu.Show(chart, e.Location);
                    }
                    chart.ContextMenu = null;
                }
            };

            chart.KeyDown += (s, e) =>
            {
                if (e.KeyData == Keys.Delete)
                    al.Annotations.Remove(al.SelectedAnnotation);
            };


            // For an arbitrary polygon shape, use a triangle
            al.PolygonAddFunc = (pt) =>
            {
                return new C1.Win.Chart.Annotation.Polygon("Polygon")
                {
                    Points =
                    {
                        pt,pt,pt
                    }
                };
            };

            al.PolygonResizeFunc = (poly, rectangle) =>
            {
                var top = new PointF((float)(rectangle.Left + rectangle.Width / 2), rectangle.Y);
                var left = new PointF(rectangle.Left, rectangle.Bottom);
                var right = new PointF(rectangle.Right, rectangle.Bottom);
                poly.Points[0] = Helpers.CoordsToAnnoPoint(chart, poly, top);
                poly.Points[1] = Helpers.CoordsToAnnoPoint(chart, poly, left);
                poly.Points[2] = Helpers.CoordsToAnnoPoint(chart, poly, right);
            };

        }

        public static Point AdjustPosition(Point point, Size size, FlexChart chart)
        {
            // attempts to keep a form or control within the bounds of the chart.
            if (point.X + size.Width > chart.Width)
                point.X -= size.Width;
            if (point.Y + size.Height > chart.Height)
                point.Y -= size.Height;
            if (point.X < 0) point.X = 0;
            if (point.Y < 0) point.Y = 0;
            return point;
        }

        private void InitializeAnnotationControls()
        {
            #region Annotation Type Combo
            ComboBox cb = cboAnnoType;
            cb.Items.AddRange(Enum.GetNames(typeof(NewAnnotationType)));
            cb.SelectedItem = "None";
            cb.SelectedIndexChanged += (sender, e) =>
            {
                ComboBox cbs = sender as ComboBox;
                Type baseType = typeof(C1.Win.Chart.Annotation.AnnotationBase);
                string typeName = cbs.SelectedItem as string;
                if (typeName == null || typeName == NewAnnotationType.None.ToString())
                    al.AllowAdd = false;
                else
                {
                    al.NewAnnotationType = baseType.Assembly.GetType(baseType.Namespace + "." + typeName);
                    al.AllowAdd = true;
                }
            };
            cboAnnoType.DrawMode = DrawMode.OwnerDrawFixed;
            cboAnnoType.DrawItem += (sender, e) =>
            {
                ComboBox cbs = sender as ComboBox;
                string text = cbs.Items[e.Index] as string;

                Brush bbr = (e.State.HasFlag(DrawItemState.Selected) && cb.DroppedDown)
                    ? Brushes.LightGray : Brushes.White;
                e.Graphics.FillRectangle(bbr, e.Bounds);
                using (Brush br = new SolidBrush(this.ForeColor))
                    e.Graphics.DrawString(text, cb.Font, br, new PointF(e.Bounds.X + 24, e.Bounds.Y + 3));

                PointF pt = new PointF(e.Bounds.X + 4, e.Bounds.Y + 2);
                Pen pen = new Pen(this.ForeColor);

                var saveSmoothingMode = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                switch (text)
                {
                    case "None":
                        break;
                    case "Circle":
                        e.Graphics.DrawEllipse(pen, pt.X, pt.Y + 1, 14, 14);
                        break;
                    case "Ellipse":
                        e.Graphics.DrawEllipse(pen, pt.X, pt.Y + 5, 14, 8);
                        break;
                    case "Polygon":
                        e.Graphics.DrawPolygon(pen, new PointF[] 
                                { 
                                    new PointF(pt.X +  7, pt.Y + 2),
                                    new PointF(pt.X + 12, pt.Y + 14),
                                    new PointF(pt.X + 2, pt.Y + 14),
                                });
                        break;
                    case "Line":
                        e.Graphics.DrawLine(pen, new PointF(pt.X, pt.Y + 4), new PointF(pt.X + 14, pt.Y + 12));
                        break;
                    case "Rectangle":
                        e.Graphics.DrawRectangle(pen, pt.X, pt.Y + 5, 14, 8);
                        break;
                    case "Square":
                        e.Graphics.DrawRectangle(pen, pt.X, pt.Y + 3, 12, 12);
                        break;
                    case "Text":
                        e.Graphics.DrawString("T", cb.Font, Brushes.Black, new PointF(pt.X, pt.Y + 1));
                        break;
                };
                e.Graphics.SmoothingMode = saveSmoothingMode;
                pen.Dispose();

                if(_annoFontButtonLeft == 0) 
                    _annoFontButtonLeft = btnAnnoFont.Left;

                if (!cbs.DroppedDown)
                {
                    if (text == "None")
                        btnAnnoStroke.Visible = btnAnnoFill.Visible = btnAnnoFont.Visible = false;

                    else if (text == "Text")
                    {
                        btnAnnoStroke.Visible = btnAnnoFill.Visible = false;
                        btnAnnoFont.Visible = true;
                        btnAnnoFont.Left = btnAnnoStroke.Left;
                    }

                    else if (text == "Line")
                    {
                        btnAnnoFill.Visible = false;
                        btnAnnoStroke.Visible = btnAnnoFont.Visible = true;
                        btnAnnoFont.Left = btnAnnoFill.Left;
                    }
                    else
                    {
                        btnAnnoStroke.Visible = btnAnnoFill.Visible = btnAnnoFont.Visible = true;
                        btnAnnoFont.Left = _annoFontButtonLeft;
                    }

                    if (al != null)
                    {
                        using (frmAnnoFont frm = new frmAnnoFont())
                        {
                            ChartStyle defStyle = al.DefaultContentStyle;

                            if (defStyle.StrokeColor != frm.Foreground)
                                //defStyle.Stroke = new SolidBrush(frm.Foreground);
                                defStyle.StrokeColor = frm.Foreground;

                            if (frm.FontDiffers(defStyle.Font))
                                defStyle.Font = frm.GetFont();
                        }
                    }
                }
            };
            #endregion
            
            #region Annotation Stroke (Border) and Fill Buttons
            btnAnnoStroke.Click += (sender, e) =>
            {
                Button bs = sender as Button;
                Point cdePosition = bs.PointToScreen(new Point(0,bs.Height+1));
                ColorDialogEx cde = new ColorDialogEx(cdePosition.X, cdePosition.Y, "Select Default Stroke Color");
                cde.SolidColorOnly = false;
                cde.Color = bs.BackColor;
                if (cde.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bs.FlatAppearance.BorderColor = cde.Color;
                    if(al != null && al.DefaultStyle != null)
                        //al.DefaultStyle.Stroke = new SolidBrush(cde.Color);
                        al.DefaultStyle.StrokeColor = cde.Color;
                }
            };

            btnAnnoFill.Click += (sender, e) =>
            {
                Button bs = sender as Button;
                Point cdePosition = bs.PointToScreen(new Point(0, bs.Height+1));
                ColorDialogEx cde = new ColorDialogEx(cdePosition.X, cdePosition.Y, "Select Default Fill Color");
                cde.SolidColorOnly = true;
                cde.Color = bs.BackColor;
                if (cde.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bs.FlatAppearance.BorderColor = bs.BackColor = cde.Color;
                    if (al != null && al.DefaultStyle != null)
                        //al.DefaultStyle.Fill = new SolidBrush(cde.Color);
                        al.DefaultStyle.FillColor = cde.Color;
                }
            };

            btnAnnoFont.Click += (sender, e) =>
            {
                Button bs = sender as Button;
                using (frmAnnoFont frm = new frmAnnoFont())
                {
                    frm.BuildForm();
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Location = bs.PointToScreen(new Point(0, bs.Height + 1));
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string text = cboAnnoType.Text;
                        ChartStyle style = al.DefaultContentStyle;

                        if (frm.FontDiffers(style.Font))
                            style.Font = frm.GetFont();

                        if (frm.Foreground != style.StrokeColor)
                            style.StrokeColor = frm.Foreground;
                    }
                }
            };
            #endregion

        }

        private void InitializeMasterSettings()
        {
            frmBase.InitMasterSettingData();
        }

        private void InitializeSelections()
        {
            panel1.Margin = new Padding(0,1,0,0);
            
            ListMenu listMenu = new ListMenu()
            {
                DrawMode = DrawMode.OwnerDrawFixed,
                Margin = new Padding(10, 0, 0, 0),
                ItemHeight = MenuButtonHeight,
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.None,
                BackColor = MenuBackColor,
                BackColorOnOver = MenuOnOverColor,
                ForeColor = MenuPosForeColor,
                ForeColorAlt = MenuNegForeColor,
            };
            Font = new Font(Font, FontStyle.Bold);

            panel1.Controls.Add(listMenu);
            foreach(Object.Quote quote in viewModel.Quotes)
                listMenu.Items.Add(quote);

            // automatically select the first quote available.
            listMenu.SelectedIndexChanged += listMenu_SelectedIndexChanged;
            listMenu.SelectedIndex = 0;
        }

        private bool NotAButtonOption(Control sender)
        {
            if (isTimeIndependent)
            {
                DropPanel.CloseActivePanelClickHandler(null, null);

                string flagName = sender.Name.Replace("btn", "");
                const string notAnOption = " are not applicable in Kagi, Renko or Point & Figure charts, which are time-independent.";
                MessageBox.Show(flagName + notAnOption, flagName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private void InitializeButtons()
        {
            DropPanel dpo = InitializeOptions();
            btnOptions.Click += (sender, ev) => dpo.PanelButtonClick(sender as Button);
            dpo.VisibleChanged += (sender, ev) =>
                {
                    DropPanel dp = sender as DropPanel;
                    if (dp.Visible)
                    {
                        RadioButton rb = dp.GetControl<RadioButton>("rb" + financialChart.ChartType.ToString());
                        if (rb != null) rb.Checked = true;
                    }
                };

            DropPanel dpi = InitializeIndicators();
            btnIndicators.Click += (sender, ev) =>
                {
                    if (!NotAButtonOption(sender as Control))
                        dpi.PanelButtonClick(sender as Button);
                };

            DropPanel dpv = InitializeOverlays();
            btnOverlays.Click += (sender, ev) =>
                {
                    if (!NotAButtonOption(sender as Control))
                        dpv.PanelButtonClick(sender as Button);
                };
        }

        private DropPanel InitializeOptions()
        {
            DropPanel dp = new DropPanel()
            {
                Name = "dropPanelOptions",
                DefaultControlSize = new Size(210, 32),
                BackColor = Color.White,
                ForeColor = this.ForeColor, //Color.Black,
                Padding = new Padding(15, 15, 15, 15),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Visible = false,
            };

            // add to the form.
            Controls.Add(dp);
            dp.BringToFront();
            dp.PositionDropPanel(btnOptions);

            dp.Add(new Label()
            {
                Text = "CHART STYLE",
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.Blue,
                Size = Size.Empty,
            });

            string[] chartTypes =
            {
                "Candlestick",
                "ArmsCandleVolume",
                "CandleVolume",
                "HeikinAshi",
                "HighLowOpenClose",
                "Line",
                "LineSymbols"
            };

            foreach (string text in chartTypes)
            {
                Button b = new Button()
                {
                    // Add buttons only for the purposes of spacing and
                    // set the name so it does not correspond with the radio button.
                    // The name change results in the desired behavior.
                    Name = "btn" + text + "Ignore",
                    //Image = ImageManager.GetNamedImage("Settings"),
                    //ImageAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(23, 23),
                    FlatStyle = FlatStyle.Flat,
                    Enabled = false,
                    Visible = false,
                };
                b.FlatAppearance.BorderSize = 0;

                RadioButton rb = (new RadioButton()
                {
                    Name = "rb" + text,
                    Text = text,
                    CheckAlign = ContentAlignment.MiddleRight,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(0, 35),
                    Padding = new Padding(0, 0, 15, 0),
                });

                // set the default.
                if (text == "Candlestick")
                {
                    rb.Checked = true;
                    rb.ForeColor = Color.Blue;
                }
                rb.CheckedChanged += DropPanelEvents;
                dp.Add(rb, b);
            }

            dp.AddSeparator();

            foreach (string text in "Kagi,Renko,PointAndFigure".Split(','))
            {
                Button b = new Button()
                {
                    Name = "btn" + text,
                    Image = ImageManager.GetNamedImage("Settings"),
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(23, 23),
                    FlatStyle = FlatStyle.Flat,
                    Visible = false,
                };
                b.FlatAppearance.BorderSize = 0;
                b.Click += DropPanelEvents;

                RadioButton rb = new RadioButton()
                {
                    Name = "rb" + text,
                    Text = text,
                    CheckAlign = ContentAlignment.MiddleRight,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(0, 35),
                    Padding = new Padding(0, 0, 15, 0),
                };

                rb.CheckedChanged += DropPanelEvents;

                dp.Add(rb, b);
            }

            dp.Setup();
            return dp;
        }

        private DropPanel InitializeIndicators()
        {
            DropPanel dp = new DropPanel()
            {
                Name = "dropPanelIndicators",
                DefaultControlSize = new Size(350, 32),
                BackColor = Color.White,
                ForeColor = this.ForeColor, // Color.Black,
                Padding = new Padding(15, 15, 15, 15),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Visible = false,
            };

            // add to the form.
            Controls.Add(dp);
            dp.BringToFront();
            dp.PositionDropPanel(btnIndicators);

            dp.Add(new Label()
            {
                Text = "INDICATOR TYPE",
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.Blue,
                Size = Size.Empty,
            });

            string[] indicators = new string[]
            {
                "ATR (Average True Range)",
                "RSI (Relative Strength Index)",
                "CCI (Commodity Channel Index)",
                "Williams%R",
                "MACD (Moving Average Convergence Divergence)",
                "Stochastic",
                "Volume Chart",
                "-",
                "A.D.X.",
                "Mass Index",
            };
            foreach (string text in indicators)
            {
                int space = text.IndexOf(' ');
                string shortName = (space < 0 ? text : text.Substring(0, space))
                    .Replace("%", "").Replace("MACD", "Macd").Replace("Mass","MassIndex").Replace(".", "");

                if (text == "-")
                {
                    dp.AddSeparator();
                    continue;
                }

                Button b = new Button()
                {
                    Name = "btn" + shortName,
                    Image = ImageManager.GetNamedImage("Settings"),
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(23, 23),
                    FlatStyle = FlatStyle.Flat,
                    Visible = false,
                };
                b.FlatAppearance.BorderSize = 0;
                b.Click += DropPanelEvents;

                CheckBox cb = new CheckBox()
                {
                    Name = "cb" + shortName,
                    Text = text,
                    TextAlign = ContentAlignment.MiddleLeft,
                    CheckAlign = ContentAlignment.MiddleRight,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(0, 35),
                    Padding = new Padding(0, 0, 15, 0),
                };

                cb.CheckedChanged += DropPanelEvents;

                dp.Add(cb, b);
            }

            dp.Setup();

            return dp;
        }

        private DropPanel InitializeOverlays()
        {
            DropPanel dp = new DropPanel()
            {
                Name = "dropPanelOverlays",
                DefaultControlSize = new Size(230, 32),
                BackColor = Color.White,
                ForeColor = this.ForeColor,   // Color.Black,
                Padding = new Padding(15, 15, 15, 15),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Visible = false,
            };

            // add to the form.
            Controls.Add(dp);
            dp.BringToFront();
            dp.PositionDropPanel(btnOverlays);

            dp.Add(new Label()
            {
                Text = "OVERLAY TYPE",
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.Blue,
                Size = Size.Empty,
            });

            string[] overlays = new string[]
            {
                "Alligator",
                "Ichimoku Cloud",
                "Bollinger Bands",
                "Envelopes",
                "Fibonacci Retracements",
                "Fibonacci Arcs",
                "Fibonacci Fans",
                "Fibonacci Time Zones",
                "-",
                "Pivot Points",
                "ZigZag"
            };
            foreach (string text in overlays)
            {
                if (text == "-")
                {
                    dp.AddSeparator();
                    continue;
                }

                string shortName = text.Replace(" ", "");
                Button b = new Button()
                {
                    Name = "btn" + shortName,
                    Image = ImageManager.GetNamedImage("Settings"),
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(23, 23),
                    FlatStyle = FlatStyle.Flat,
                    Visible = false,
                };
                b.FlatAppearance.BorderSize = 0;
                b.Click += DropPanelEvents;

                RadioButton rb = new RadioButton()
                {
                    Name = "rb" + shortName,
                    Text = text,
                    TextAlign = ContentAlignment.MiddleLeft,
                    CheckAlign = ContentAlignment.MiddleRight,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(0, 35),
                    Padding = new Padding(0, 0, 15, 0),
                };

                rb.CheckedChanged += DropPanelEvents;

                dp.Add(rb, b);
            }

            dp.AddSeparator();

            Button btnClear = new Button()
            {
                Name = "btnClear",
                Text = "Clear",
                BackColor = Color.Blue,
                ForeColor = Color.White,
                Size = Size.Empty,
                Location = new Point(0, 10),
                FlatStyle = FlatStyle.Flat,
            };
            btnClear.FlatAppearance.BorderSize = 1;

            btnClear.Click += DropPanelEvents;

            dp.Add(btnClear);

            dp.Setup();

            return dp;
        }

        private void InitializeRangeSelector()
        {
            if (XRangeSelector != null || !rangeChart.Visible) return;

            // add XRangeSelector and initialize it  The range select cannot be set
            // until the financeChart is rendered because the values are not yet available.
            XRangeSelector = new RangeSelector(rangeChart);
            XRangeSelector.MouseDown += DropPanel.CloseActivePanelClickHandler;
            XRangeSelector.ValueChanged += XRangeSelector_ValueChanged;
            XRangeSelector.LowerValue = XRangeSelector.UpperValue - 60;
        }

        private void InitializePanelBehavior(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is DropPanel || c is Button) continue;
                c.Click += DropPanel.CloseActivePanelClickHandler;
                InitializePanelBehavior(c);
            }
        }

        #endregion

        void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            TableLayoutPanel tlp = sender as TableLayoutPanel;
            Pen pen = Pens.LightGray;

            if (tlp.Name == tableLayoutPanel1.Name || tlp.GetControlFromPosition(e.Column, e.Row) != null)
            {
                if (tlp.Name == tableLayoutPanel2.Name && e.Column == 0 && e.Row == 1)
                {
                    e.Graphics.DrawLine(pen, new Point(e.CellBounds.Left, e.CellBounds.Top),
                        new Point(e.CellBounds.Left, e.CellBounds.Bottom));
                }
                else
                    e.Graphics.DrawRectangle(pen, e.CellBounds);
            }
        }

        void XRangeSelector_ValueChanged(object sender, EventArgs e)
        {
            // update the chart axes limits and viewModel as the RangeSelect is adjusted.
            viewModel.LowerValue = financialChart.AxisX.Min = XRangeSelector.LowerValue;
            viewModel.UpperValue = financialChart.AxisX.Max = XRangeSelector.UpperValue;

            foreach (Series ser in financialChart.Series)
            {
                if (ser is FibonacciExtension)
                {
                    SetFibonacciValues(ser as FibonacciExtension);
                    break;
                }
            }
        }

        void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListMenu listMenu = sender as ListMenu;
            Object.Quote quote = listMenu.SelectedItem as Object.Quote;

            // remove all annotations when changing quotes as they are no longer relevant to the new quote.
            if (al != null && al.Annotations != null && al.Annotations.Count > 0)
                al.Annotations.Clear();

            // select the current quote.
            viewModel.CurrentQuote = quote;

            // add the Company Icon and vertically center it.
            pictureBoxSecurityIcon.Image = ImageManager.GetNamedImage(quote.Name);
            pictureBoxSecurityIcon.Padding = new Padding(0, (pictureBoxSecurityIcon.Height - pictureBoxSecurityIcon.Image.Height) / 2, 0, 0);

            // update the financial chart based on current quote parameters.
            C1.Chart.Finance.FinancialChartType finType = financialChart.ChartType = viewModel.ChartType;
            financialChart.Series.Clear();
            frmBase.SetChartOptions(financialChart);

            FinancialSeries ser = new FinancialSeries();
            ser.Style.FillColor = Color.FromArgb((int)0x80, ViewModel.IndicatorPalettes.LogoBlue);
            ser.Style.StrokeColor = ViewModel.IndicatorPalettes.Blue700;
            ser.Style.StrokeWidth = 1;

            financialChart.Series.Add(ser);

            financialChart.BindingX = "LocalDate";
            financialChart.Binding = (finType == FinancialChartType.Line || finType == FinancialChartType.LineSymbols)
                ? "Close" : "High,Low,Open,Close,Volume";
            financialChart.DataSource = quote.Data;

            // update the range chart based on the current quote parameters
            rangeChart.ChartType = C1.Chart.Finance.FinancialChartType.Line;
            rangeChart.Margin = new Padding(5);
            rangeChart.Series.Clear();
            rangeChart.Series.Add(new C1.Win.Chart.Finance.FinancialSeries() { Name = quote.Name });
            rangeChart.Binding = "Close";
            rangeChart.DataSource = quote.Data;
            rangeChart.Visible = !isTimeIndependent;

            if (!isTimeIndependent)
            {
                // add any indicators and overlays requested.
                financialChart.PlotAreas.Clear();
                foreach (Type indicatorType in viewModel.IndicatorCharts)
                    IndicatorChart(indicatorType, true);
                foreach (Type overlayType in viewModel.OverlayTypes)
                    OverLays(overlayType, true);
                foreach (Type customIndicator in viewModel.CustomIndicators)
                    CustomIndicatorChart(customIndicator, true);
            }
        }

        void DropPanelEvents(object sender, EventArgs ev)
        {
            if (sender is RadioButton)
            {
                #region RadioButton Handling
                RadioButton rb = sender as RadioButton;
                string btnKey = "btn" + rb.Name.Substring(2);

                if (rb.Checked)
                {
                    // update color based on selection.
                    rb.ForeColor = Color.Blue;

                    switch (rb.Parent.Name)
                    {
                        case "dropPanelOptions":
                            {
                                // initialize the dropPanel with the current ChartType selected.
                                C1.Chart.Finance.FinancialChartType chartType;
                                if (Enum.TryParse<C1.Chart.Finance.FinancialChartType>(rb.Text, out chartType))
                                {
                                    bool willBeTimeIndependent = chartType == FinancialChartType.Kagi ||
                                        chartType == FinancialChartType.Renko ||
                                        chartType == FinancialChartType.PointAndFigure;

                                    if (willBeTimeIndependent)
                                    {
                                        rangeChart.Visible = false;

                                        // RangeSelect0r can already be null when switching from Kagi <=> Renko
                                        if (XRangeSelector != null)
                                        {
                                            XRangeSelector.ValueChanged -= XRangeSelector_ValueChanged;
                                            XRangeSelector.Click -= DropPanel.CloseActivePanelClickHandler;
                                            XRangeSelector.Remove();
                                            XRangeSelector = null;
                                        }

                                        if (!isTimeIndependent)
                                        {
                                            //financialChart.PlotAreas.Clear();
                                            foreach (Type indicatorType in viewModel.IndicatorCharts)
                                                RemoveSeriesType(indicatorType);
                                            foreach (Type overlayType in viewModel.OverlayTypes)
                                                RemoveSeriesType(overlayType);
                                            foreach (Type customType in viewModel.CustomIndicators)
                                                CustomIndicatorChart(customType, false, true);

                                            financialChart.PlotAreas.Clear();
                                        }

                                        financialChart.AxisX.Max = financialChart.AxisX.Min = double.NaN;
                                    }
                                    else
                                    {
                                        // Restore rangeChart visibility.  This will create a new RangeSelector
                                        // and initialize it.
                                        rangeChart.Visible = true;

                                        if (isTimeIndependent)      // changing from time-independent to time-dependent.
                                        {
                                            foreach (Type indicatorType in viewModel.IndicatorCharts)
                                                IndicatorChart(indicatorType, true);
                                            foreach (Type overlayType in viewModel.OverlayTypes)
                                                OverLays(overlayType, true);
                                            foreach (Type customType in viewModel.CustomIndicators)
                                                CustomIndicatorChart(customType, true);
                                        }
                                    }
                                    isTimeIndependent = willBeTimeIndependent;

                                    bool lineChart = chartType == FinancialChartType.LineSymbols ||
                                        chartType == FinancialChartType.Line;

                                    financialChart.Series[0].Binding = lineChart ? "Close" : "High,Low,Open,Close,Volume";
                                    viewModel.ChartType = financialChart.ChartType = chartType;
                                }

                                if (rb.Parent.Controls.ContainsKey(btnKey))
                                {
                                    (rb.Parent.Controls[btnKey] as Button).Visible = true;
                                }
                                else
                                {
                                    DropPanel.CloseActivePanelClickHandler(rb.Parent, new EventArgs());
                                }
                            }
                            break;

                        case "dropPanelOverlays":
                            {
                                (rb.Parent.Controls[btnKey] as Button).Visible = true;

                                if (rb.Name == "rbPivotPoints")
                                {
                                    CustomIndicatorChart(rb.Name.Substring(2), true);
                                }
                                else
                                {
                                    OverLays(rb.Name.Substring(2), true);
                                }
                            }
                            break;
                    }

                }
                else
                {
                    rb.ForeColor = this.ForeColor;
                    if (rb.Parent.Controls.ContainsKey(btnKey))
                        (rb.Parent.Controls[btnKey] as Button).Visible = false;

                    switch (rb.Parent.Name)
                    {                        
                        case "dropPanelOverlays":
                            if (rb.Name == "rbPivotPoints")
                                CustomIndicatorChart(rb.Name.Substring(2), false);
                            else
                                OverLays(rb.Name.Substring(2), false);
                            break;
                    }
                }

                #endregion RadioButton Handling
            }

            else if (sender is CheckBox)
            {
                #region Checkbox Handling
                var cb = sender as CheckBox;

                if (cb.Parent != null)
                {
                    Button b = cb.Parent.Controls["btn" + cb.Name.Substring(2)] as Button;

                    if (cb.Checked)
                    {
                        switch(cb.Parent.Name)
                        {
                            case "dropPanelIndicators":
                                {
                                    int count = 0;
                                    foreach (Control tcb in cb.Parent.Controls)
                                    {
                                        if (tcb is CheckBox && (tcb as CheckBox).Checked) count++;
                                    }

                                    if (count > 3)  // limit to 3 selected items.
                                    {
                                        cb.Checked = false;

                                        MessageBox.Show("You can apply maximum of 3 indicators at a time.", "Indicators",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        return;
                                    }

                                    switch (cb.Name)
                                    {
                                        case "cbADX":
                                        case "cbMassIndex":
                                            CustomIndicatorChart(cb.Name.Substring(2), true);
                                            break;

                                        default:
                                            IndicatorChart(cb.Name.Substring(2), true);
                                            break;
                                    }
                                }
                                break;

                            case "dropPanelCustomIndicator":
                                {
                                    CustomIndicatorChart(cb.Name.Substring(2), true);
                                }
                                break;
                        }

                        cb.ForeColor = Color.Blue;
                        b.Visible = true;
                    }
                    else
                    {
                        cb.ForeColor = this.ForeColor;  // Color.Black;
                        b.Visible = false;

                        switch (cb.Parent.Name)
                        {
                            case "dropPanelIndicators":
                                {
                                    switch (cb.Name)
                                    {
                                        case "cbADX":
                                        case "cbMassIndex":
                                            CustomIndicatorChart(cb.Name.Substring(2), false);
                                            break;

                                        default:
                                            IndicatorChart(cb.Name.Substring(2), false);
                                            break;
                                    }
                                }
                                break;

                            case "dropPanelCustomIndicator":
                                CustomIndicatorChart(cb.Name.Substring(2), false);
                                break;
                        }
                    }
                }
                #endregion Checkbox Handling
            }

            else if (sender is Button)
            {
                #region Button Handling
                var b = sender as Button;
                if (b.Name == "btnClear")
                {
                    foreach (Control c in b.Parent.Controls)
                    {
                        if (c is RadioButton) (c as RadioButton).Checked = false;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(b.Text) && b.Image != null)
                    {
                        string frmName = typeof(frmBase).Namespace + "." + b.Name.Replace("btn", "frm");
                        using (frmBase frm = Assembly.GetExecutingAssembly().CreateInstance(frmName) as frmBase)
                        {
                            frm.BuildForm();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                switch (b.Name)
                                {
                                    case "btnKagi":
                                    case "btnRenko":
                                    case "btnPointAndFigure":
                                        frmBase.SetChartOptions(financialChart);
                                        break;

                                    case "btnATR":
                                    case "btnRSI":
                                    case "btnVolume":
                                    case "btnCCI":
                                    case "btnWilliamsR":
                                    case "btnStochastic":
                                    case "btnMacd":
                                    case "btnBollingerBands":
                                    case "btnEnvelopes":
                                    case "btnFibonacciRetracements":
                                    case "btnIchimokuCloud":
                                    case "btnAlligator":
                                    case "btnZigZag":
                                        frm.SetSeriesData(financialChart);
                                        break;

                                    case "btnFibonacciArcs":
                                    case "btnFibonacciFans":
                                    case "btnFibonacciTimeZones":
                                        frm.SetSeriesData(financialChart, this);
                                        break;

                                    case "btnADX":
                                    case "btnMassIndex":
                                    case "btnPivotPoints":
                                        frm.SetSeriesData(financialChart, viewModel);
                                        break;
                                }
                            }
                        }
                    }
                }
                #endregion Button Handling
            }
        }

        internal void SetFibonacciValues(C1.Win.Chart.Finance.FibonacciExtension fibSeries)
        {
            // FibonacciExtensions have StartX, EndX, StartY, EndY properties that are set
            // based upon the available data.
            int maxYXval = -1, minYXval = -1;
            double maxY = double.MinValue, minY = double.MaxValue;

            // FinanacciFan settings, StartY and EndY are max and min data values, respectively,
            // and StartX and EndX are the point indices of those values.
            int i = 0;
            int sta = (int)viewModel.LowerValue, end = (int)viewModel.UpperValue;
            foreach (Object.QuoteData qd in viewModel.CurrentQuote.Data)
            {
                if (i++ < sta) continue;
                if (i > end) break;

                if (qd.Close > maxY)
                {
                    maxY = qd.Close;
                    maxYXval = i;
                }
                if (qd.Close < minY)
                {
                    minY = qd.Close;
                    minYXval = i;
                }
            }

            if (fibSeries is FibonacciArcs)
            {
                fibSeries.StartX = maxYXval;
                fibSeries.StartY = maxY;
                fibSeries.EndX = minYXval;
                fibSeries.EndY = minY;
            }
            else if (fibSeries is FibonacciFans)
            {
                fibSeries.StartX = minYXval;
                fibSeries.StartY = minY;
                fibSeries.EndX = maxYXval;
                fibSeries.EndY = maxY;
            }
        }

        private void RemoveSeriesType(Type type)
        {
            // this is only intended to remove indicator or overlay series
            // all of which will have an index greater than 1
            for (int s = financialChart.Series.Count - 1; s >= 1; s--)
            {
                Series ser = financialChart.Series[s];
                if (ser.GetType() == type || ser.Name.StartsWith(type.Name))
                        financialChart.Series.RemoveAt(s);
            }
        }

        private void IndicatorPlotArea(string plotAreaName, bool add)
        {
            var pas = financialChart.PlotAreas;
            if (add)
            {
                PlotArea pa = new PlotArea() { Name = "spacer" + plotAreaName, Row = pas.Count + 1, };
                pa.Height = new C1.Chart.GridLength(10);
                pas.Add(pa);

                pa = new PlotArea() { Name = plotAreaName, Row = pas.Count + 1, };
                pa.Height = new C1.Chart.GridLength(40);
                pas.Add(pa);
            }
            else
            {
                PlotArea pa = pas.FirstOrDefault((p) => p.Name == plotAreaName);
                PlotArea spacer = pas.FirstOrDefault((p) => p.Name == "spacer" + plotAreaName);
                if (pa != null) pas.Remove(pa);
                if (spacer != null) pas.Remove(spacer);

                // move the remaining PlotAreas down a row if necessary
                for (int p = 0; p < pas.Count; p++)
                {
                    pa = pas[p];
                    if(pa.Row != p+1) pa.Row = p+1;
                }
            }
        }

        private void IndicatorChart(object nameOrType, bool add)
        {
            Type indicatorType = nameOrType as Type;
            if (indicatorType == null && nameOrType is string)
            {
                string className = (nameOrType as string).Replace("Volume", "FinancialSeries");

                indicatorType = financialChart.GetType().Assembly.
                    GetType("C1.Win.Chart.Finance." + className);
            }

            if (indicatorType != null)
            {
                string indicatorName = indicatorType.Name.Replace("FinancialSeries","Volume");
                if (add)
                {
                    IndicatorPlotArea(indicatorName, true);
                    FinancialSeries ser = indicatorType.Assembly.CreateInstance(indicatorType.FullName) as FinancialSeries;
                    ser.Name = indicatorName;
                    ser.Binding = (indicatorName == "Volume") ? "Volume,Close" : "High,Low,Close";
                    ser.Style.StrokeWidth = 1;
                    ser.AxisY = new Axis()
                    {
                        MajorTickMarks = C1.Chart.TickMark.None,
                        Position = C1.Chart.Position.Left,
                        Labels = false,
                        PlotAreaName = indicatorName,
                        Title = (indicatorName == "Macd") ? "MACD" : indicatorName,
                    };
                    ser.Visibility = C1.Chart.SeriesVisibility.Plot;
                    financialChart.Series.Add(ser);

                    if (indicatorName == "Volume")
                    {
                        ser.ChartType = C1.Chart.Finance.FinancialChartType.Column;
                        ser.SymbolRendering += (sender, ev) =>
                            {
                                if(ev.Index == 0) 
                                    return;

                                double[] values = ser.GetValues(2); // this is the closing value;
                                if (values != null)
                                {
                                    if (values[ev.Index - 1] > values[ev.Index])
                                    {
                                        int c = ser.AltStyle.StrokeColor.ToArgb();
                                        ev.Engine.SetStroke(c);
                                        ev.Engine.SetFill(c);
                                    }
                                }
                            };
                    }

                    if (indicatorName == "Macd")
                    {
                        //MacdHistogram mdh = new MacdHistogram()
                        //{
                        //    Name = indicatorName + "Histogram",
                        //    Binding = "High,Low,Close",
                        //    AxisY = ser.AxisY,
                        //};
                        //mdh.Style.StrokeWidth = 1;
                        //if(mdh.AltStyle == null)
                        //{
                        //    mdh.AltStyle = new ChartStyle();
                        //    mdh.AltStyle.StrokeWidth = 1;
                        //}
                        //financialChart.Series.Add(mdh);

                        Macd macd = ser as Macd;
                        macd.GetValues(0);
                        double[] macdValues = macd.MacdVals;
                        double[] sigValues = macd.SignalVals;
                        double[] sigXValues = macd.SignalXVals;
                        PointF[] histValues = new PointF[sigValues.Length];

                        int ii = 0;
                        while (macd.MacdXVals[ii] < macd.SignalXVals[0]) ii++;

                        for (int i=0; i < sigValues.Length; i++)
                            histValues[i] = new PointF((float)sigXValues[i], (float)(macdValues[i+ii] - sigValues[i]));
                        FinancialSeries mdh = new FinancialSeries()
                        {
                            ChartType = FinancialChartType.Column,
                            Name = indicatorName + "Histogram",
                            AxisY = ser.AxisY,
                            BindingX = "X",
                            Binding = "Y",
                            DataSource = histValues,
                            AltStyle = new ChartStyle(),
                        };
                        financialChart.Series.Add(mdh);
                    }

                    if (!viewModel.IndicatorCharts.Contains(indicatorType))
                        viewModel.IndicatorCharts.Add(indicatorType);
                    {
                        using(frmBase f = frmBase.CreateForm(indicatorName))
                            f.SetSeriesData(financialChart);
                    }
                }
                else
                {
                    Series[] sers = financialChart.Series.Where((s) => s.Name.StartsWith(indicatorName)).ToArray();
                    if (sers != null && sers.Length > 0)
                    {
                        foreach (Series ser in sers)
                            financialChart.Series.Remove(ser);
                    }
                    IndicatorPlotArea(indicatorName, false);
                    if (viewModel.IndicatorCharts.Contains(indicatorType))
                        viewModel.IndicatorCharts.Remove(indicatorType);
                }
            }
        }

        private void OverLays(object nameOrType, bool add)
        {
            Type overlayType = nameOrType as Type;
            if (overlayType == null && nameOrType is string)
            {
                string className = (nameOrType as string).Replace("Retracements", "");

                overlayType = financialChart.GetType().Assembly.
                    GetType("C1.Win.Chart.Finance." + className);
            }
            
            if(overlayType != null)
            {
                string overlayName = overlayType.Name;

                if (add)
                {
                    C1.Win.Chart.Series ser = overlayType.Assembly.CreateInstance(overlayType.FullName) as C1.Win.Chart.Series;
                    ser.Name = overlayName;
                    ser.Style.StrokeWidth = 1;
                    ser.Binding = overlayName.StartsWith("Fibonacci") ? "Close" : "High,Low,Open,Close";
                    ser.Visibility = C1.Chart.SeriesVisibility.Plot;
                    financialChart.Series.Add(ser);

                    if (overlayName == "Fibonacci")
                        overlayName = "FibonacciRetracements";

                    using (frmBase frm = frmBase.CreateForm(overlayName))
                    {
                        if (ser is FibonacciExtension)
                            frm.SetSeriesData(financialChart, this);
                        else
                            frm.SetSeriesData(financialChart);

                        //  Following is included in the SetSeriesData() methods of several of the Fibonacci
                        //  forms: FibonacciArcs, FibonacciFans, FibonacciTimeZones.
                        //
                        //if (ser is FibonacciExtension)
                        //{
                        //    var fib = ser as FibonacciExtension;
                        //    if (fib.StartX != null && Convert.ToInt32(fib.StartX) < 0)
                        //        SetFibonacciValues(fib);
                        //}
                    }

                    if(!viewModel.OverlayTypes.Contains(overlayType))
                        viewModel.OverlayTypes.Add(overlayType);
                }
                else
                {
                    Series ser = financialChart.Series.FirstOrDefault((s) => s.Name == overlayName);
                    if (ser != null) financialChart.Series.Remove(ser);
                    if (viewModel.OverlayTypes.Contains(overlayType))
                        viewModel.OverlayTypes.Remove(overlayType);
                }
            }
        }

        private void CustomIndicatorChart(object nameOrType, bool add, bool seriesOnly=false)
        {
            Type indicatorType = nameOrType as Type;
            if (nameOrType is string)
            {
                string name = nameOrType as string;

                switch(name)
                {
                    case "ADX":
                        indicatorType = typeof(CustomIndicators.ADXIndicator);
                        break;

                    case "MassIndex":
                        indicatorType = typeof(CustomIndicators.MassIndexIndicator);
                        break;

                    case "PivotPoints":
                        indicatorType = typeof(CustomIndicators.PivotPointOverlay);
                        break;
                }
            }

            if (indicatorType != null)
            {
                string indicatorName = indicatorType.Name.Replace("Indicator","").Replace("Overlay","");
                if (add)
                {
                    IndicatorPlotArea(indicatorName, true);

                    switch (indicatorName)
                    {
                        case "ADX":
                            {
                                CustomIndicators.ADXIndicator adx = new CustomIndicators.ADXIndicator();
                                adx.Period = 14;
                                adx.QuoteData = viewModel.CurrentQuote.Data;
                                Axis ax = new Axis()
                                {
                                    MajorTickMarks = C1.Chart.TickMark.None,
                                    Position = C1.Chart.Position.Left,
                                    Labels = false,
                                    PlotAreaName = indicatorName,
                                    Title = indicatorName,
                                };

                                CustomIndicators.ADXIndicator.DIPASeries dipaser = adx.DIPA;
                                dipaser.AxisY = ax;

                                CustomIndicators.ADXIndicator.DINASeries dinaser = adx.DINA;
                                dinaser.AxisY = ax;

                                CustomIndicators.ADXIndicator.ADXSeries adxser = adx.ADX;
                                adxser.AxisY = ax;

                                financialChart.Series.Add(dipaser);
                                financialChart.Series.Add(dinaser);
                                financialChart.Series.Add(adxser);

                                using (frmADX fx = new frmADX())
                                {
                                    fx.SetSeriesData(financialChart, viewModel);
                                }
                            }
                            break;

                        case "MassIndex":
                            {
                                CustomIndicators.MassIndexIndicator mi = new CustomIndicators.MassIndexIndicator();
                                mi.QuoteData = viewModel.CurrentQuote.Data;
                                Axis ax = new Axis()
                                {
                                    MajorTickMarks = C1.Chart.TickMark.None,
                                    Position = C1.Chart.Position.Left,
                                    Labels = false,
                                    PlotAreaName = indicatorName,
                                    Title = indicatorName,
                                };

                                CustomIndicators.MassIndexIndicator.MassIndexSeries miSeries = mi.MassIndex;
                                miSeries.AxisY = ax;

                                Series mits = mi.MassIndexThreshold;
                                mits.AxisY = ax;

                                financialChart.Series.Add(miSeries);
                                financialChart.Series.Add(mits);

                                using (frmMassIndex fmi = new frmMassIndex())
                                {
                                    fmi.SetSeriesData(financialChart, viewModel);
                                }
                            }
                            break;

                        case "PivotPoint":
                            {
                                CustomIndicators.PivotPointOverlay ppo = new CustomIndicators.PivotPointOverlay();
                                ppo.QuoteData = viewModel.CurrentQuote.Data;

                                financialChart.Series.Add(ppo.Pivot);
                                financialChart.Series.Add(ppo.S1);
                                financialChart.Series.Add(ppo.S2);
                                financialChart.Series.Add(ppo.S3);
                                financialChart.Series.Add(ppo.R1);
                                financialChart.Series.Add(ppo.R2);
                                financialChart.Series.Add(ppo.R3);
                                financialChart.Legend.Position = C1.Chart.Position.Right;

                                using (frmPivotPoints fpp = new frmPivotPoints())
                                {
                                    fpp.SetSeriesData(financialChart, viewModel);
                                }
                            }
                            break;
                    }

                    if (!viewModel.CustomIndicators.Contains(indicatorType))
                        viewModel.CustomIndicators.Add(indicatorType);
                }
                else
                {
                    switch (indicatorName)
                    {
                        case "ADX":
                            {
                                foreach (string sername in "ADXSeries,ADXDINASeries,ADXDIPASeries".Split(','))
                                {
                                    Series ser = financialChart.Series.FirstOrDefault(s => s.Name == sername);
                                    if (ser != null) financialChart.Series.Remove(ser);
                                }
                            }
                            break;

                        case "MassIndex":
                            {
                                foreach (string sername in "MassIndexSeries,MassIndexThresholdSeries".Split(','))
                                {
                                    Series ser = financialChart.Series.FirstOrDefault(s => s.Name == sername);
                                    if (ser != null) financialChart.Series.Remove(ser);
                                }
                            }
                            break;

                        case "PivotPoint":
                            {
                                foreach (string sername in "Pivot,S1,S2,R1,R2,S3,R3".Split(','))
                                {
                                    Series ser = financialChart.Series.FirstOrDefault(s => s.Name == sername);
                                    if (ser != null) financialChart.Series.Remove(ser);
                                }
                                financialChart.Legend.Position = C1.Chart.Position.None;
                            }
                            break;
                    }
                    IndicatorPlotArea(indicatorName, false);
                    if (!seriesOnly && viewModel.CustomIndicators.Contains(indicatorType))
                        viewModel.CustomIndicators.Remove(indicatorType);
                }
            }
        }
    }
}
