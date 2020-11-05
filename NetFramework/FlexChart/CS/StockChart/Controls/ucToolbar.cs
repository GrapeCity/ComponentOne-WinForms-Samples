using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart.Finance;
using C1.Chart;

namespace StockChart
{

    public partial class ucToolbar : UserControl
    {
        public EventHandler<StringEventArgs> OnComparisonChanged;
        public EventHandler<IntgerEventArgs> OnSelectedIndexChanged;
        public EventHandler<BooleanEventArgs> OnShowVolumeChanged;
        public EventHandler<ChartTypeChangedEventArgs> OnChartTypeChanged;
        public EventHandler OnReseted;
        public EventHandler<StringEventArgs> OnSaveImage;
        public EventHandler<BooleanEventArgs> OnMovingAverageVisibilityChanged;
        public EventHandler<MovingAverageTypeChangedEventArgs> OnMovingAverageTypeChanged;
        public EventHandler<IntgerEventArgs> OnMovingAveragePeriodChanged;
        public EventHandler<BooleanEventArgs> OnLineMarkerVisibilityChanged;
        public EventHandler<BooleanEventArgs> OnNewsVisibilityChanged;

        public ucToolbar()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                InitializeControls();
            }

            this.Load += (o, e) =>
            {
                this.chkMovingAverage.Checked = false;
                this.chkLineMarker.Checked = false;
            };
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RangeText
        {
            get { return lblDateRange.Text; }
            set { lblDateRange.Text = value; }
        }


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RangeSelectedIndex
        {
            get { return this.ucButtonGroup.SelectedIndex; }
            set { ucButtonGroup.SelectedIndex = value; }
        }

        private bool _showChartType = false;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowChartType
        {
            get { return this._showChartType; }
            set
            {
                _showChartType = value;
                    cbChartType.SelectedIndex = 0;
                    cbChartType.Visible = panel10.Visible = _showChartType;
            }
        }
        private bool _enableReset = false;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool EnableReset
        {
            get { return this._enableReset; }
            set
            {
                _enableReset = value;
                    btnReset.Enabled = _enableReset;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEnumerable<QuoteInfo> QuotesInfo
        {
            get { return txtInfo.QuotesInfo; }
            set { txtInfo.QuotesInfo = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DisplayMode QuotesInfoDisplayMode
        {
            get { return txtInfo.DisplayMode; }
            set { txtInfo.DisplayMode = value; }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsShowMovingAverage
        {
            get { return this.chkMovingAverage.Checked; }
        }

        private bool _isShowNews = false;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsShowNews
        {
            get { return _isShowNews; }
            set
            {
                _isShowNews = value;
                chkNews.Visible = _isShowNews;
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLineMarkerChecked
        {
            get { return this.chkLineMarker.Checked; }
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNewsChecked
        {
            get { return _isShowNews && this.chkNews.Checked; }
        }

        internal string GetFirstSeriesCOntroller()
        {
            return this.pnlChecks.Controls.Count > 0 ? this.pnlChecks.Controls[0].Text : null;
        }

        internal void AddSeriesController(Symbol s, Action checkedChangedCallback)
        {
                C1.Win.C1Input.C1CheckBox cb = new C1.Win.C1Input.C1CheckBox();


                cb.BackColor = System.Drawing.Color.Transparent;
                cb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
                cb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                cb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
                cb.CheckState = System.Windows.Forms.CheckState.Checked;
                cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                 cb.TabIndex = 0;
                this.c1ThemeController1.SetTheme(cb, "ExpressionDark");
                cb.UseVisualStyleBackColor = true;

                cb.AutoSize = true;
                cb.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
                cb.Dock = DockStyle.Left;
                cb.ForeColor = s.Color;
                cb.Text = s.Code;
                cb.Checked = true;
                cb.Tag = s;

                cb.CheckedChanged += (o, e) =>
                {
                    s.Visibility = cb.Checked ? SeriesVisibility.Visible : SeriesVisibility.Hidden;
                    checkedChangedCallback();
                };

                this.pnlChecks.Controls.Add(cb);
        }

        internal void RemoveSeriesController(Symbol s)
        {
                C1.Win.C1Input.C1CheckBox cb = null;

                foreach (Control item in this.pnlChecks.Controls)
                {
                    if (item is C1.Win.C1Input.C1CheckBox)
                    {
                        if (item.Tag == s)
                        {
                            cb = item as C1.Win.C1Input.C1CheckBox;
                        }
                    }
                }

                if (cb!= null)
                {
                    this.pnlChecks.Controls.Remove(cb);
                    cb.Dispose();
                }
        }
        internal void RemoveAllSeriesController()
        {
            pnlChecks.Controls.Clear();
        }

        private void InitializeControls()
        {
            if (!DesignMode)
            {
                txtSearchBox.DataSource = Data.DataService.Instance.SymbolNames;
                Data.DataService.Instance.SymbolsLoaded += (s, e) => txtSearchBox.DataSource = Data.DataService.Instance.SymbolNames;
            }

            this.txtSearchBox.OnSymbolChanged += (o, e) =>
            {
                if(this.OnComparisonChanged != null)
                this.OnComparisonChanged(this, new StringEventArgs() { Value = e.Value });
            };
            
            this.ucButtonGroup.OnSelectedIndexChanged += (o, e) =>
            {
                if (this.OnSelectedIndexChanged != null)
                {
                    this.OnSelectedIndexChanged(this, e);
                }
            };

            this.btnReset.Click += (o, e) =>
            {
                if (this.OnReseted != null)
                {
                    this.OnReseted(this, new EventArgs());
                }
            };

            this.btnShowVolume.OnCheckedChanged += (o, e) =>
            {
                if (this.OnShowVolumeChanged != null)
                {
                    this.OnShowVolumeChanged(this, new BooleanEventArgs() { Value = this.btnShowVolume.Checked});
                }
            };

            cbChartType.SetItemsDataSource(new ChartType[] { ChartType.Line, ChartType.Area, ChartType.Candlestick, ChartType.HighLowOpenClose }, "",0);
            cbChartType.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            cbChartType.SelectedItemChanged += (o, e) =>
                {
                if (OnChartTypeChanged != null)
                    OnChartTypeChanged(this, new ChartTypeChangedEventArgs() { Type = (ChartType)(cbChartType.SelectedItem) });
            };
            cbChartType.TextChanged += (o,e) => cbChartType.FitWidth();

            cbExport.Text = "Export To";
            cbExport.Items.Add(new C1.Win.C1Input.DropDownItem() { Text = "PNG" });
            cbExport.Items.Add(new C1.Win.C1Input.DropDownItem() { Text = "JPG" });
            cbExport.Items.Add(new C1.Win.C1Input.DropDownItem() { Text = "SVG"});
            cbExport.ItemsDisplayMember = "Text";
            cbExport.DropDownClosed += (o, e) =>
            {
                var text = cbExport.SelectedText;

                if (OnSaveImage != null && text != "Export To")
                {
                    OnSaveImage(this, new StringEventArgs() { Value = text });
                }
                cbExport.SelectedIndex = -1;
                cbExport.Text = "Export To";
            };

            chkMovingAverage.CheckedChanged += (o, e) =>
            {
                cbMovingAverageType.Visible = txtMovingAveragePeriod.Visible = lblPeriod.Visible = chkMovingAverage.Checked;

                if (this.OnMovingAverageVisibilityChanged != null)
                {
                    this.OnMovingAverageVisibilityChanged(this, new BooleanEventArgs() { Value = chkMovingAverage.Checked });
                }
            };

            cbMovingAverageType.SetItemsDataSource(typeof(C1.Chart.MovingAverageType),"",0);
            cbMovingAverageType.SelectedIndexChanged += (o, e) =>
                {
                if (OnMovingAverageTypeChanged != null)
                    OnMovingAverageTypeChanged(this, new MovingAverageTypeChangedEventArgs() {
                        Type = (C1.Chart.MovingAverageType)cbMovingAverageType.SelectedItem });
            };

            txtMovingAveragePeriod.ValueChanged += (o, e) =>
                    {
                var val = Convert.ToInt32(txtMovingAveragePeriod.Value);
                if (val < 2)
                    txtMovingAveragePeriod.Value = val = 2;
                if (OnMovingAveragePeriodChanged != null)
                    OnMovingAveragePeriodChanged(this, new IntgerEventArgs() { Value = val  });
            };
            this.chkLineMarker.CheckedChanged += (o, e) =>
            {
                if (this.OnLineMarkerVisibilityChanged != null)
                {
                    this.OnLineMarkerVisibilityChanged(this, new BooleanEventArgs() { Value = chkLineMarker.Checked });
                }
            };

            this.chkNews.CheckedChanged += (o, e) =>
            {
                if (this.OnNewsVisibilityChanged != null)
                {
                    this.OnNewsVisibilityChanged(this, new BooleanEventArgs() { Value = chkNews.Checked });
                }
            };


            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.btnShowVolume, "Show Vlolume");
        }
    }

    public static class ComboBoxExtension
    {
        public static void FitWidth(this C1.Win.C1Input.C1ComboBox cmb)
        {
            using (Graphics g = Graphics.FromHwnd(cmb.Handle))
            {
                SizeF fontSize = g.MeasureString(cmb.Text, cmb.Font);
                cmb.Width = (int)(fontSize.Width + 29);
                cmb.Refresh();
            }
        }
    }


    public class StringEventArgs : EventArgs
    {
        public string Value { get; set; }
    }
    public class IntgerEventArgs : EventArgs
    {
        public int Value { get; set; }
    }
    public class BooleanEventArgs : EventArgs
    {
        public bool Value { get; set; }
    }

    public class ChartTypeChangedEventArgs : EventArgs
    {
        public ChartType Type { get; set; }
    }
    public class MovingAverageTypeChangedEventArgs : EventArgs
    {
        public C1.Chart.MovingAverageType Type { get; set; }
    }

}
