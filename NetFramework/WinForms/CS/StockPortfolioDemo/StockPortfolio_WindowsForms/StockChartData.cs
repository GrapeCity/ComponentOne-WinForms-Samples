using C1.Win.C1Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StockPortfolio
{
    public partial class StockChartData : UserControl
    {
        private StockData _stockData = new StockData();
        private DataTable _stockDataTable = new DataTable();
        private List<string> _stockSymbols = new List<string>();
        private List<string> _companyNames = new List<string>();

        public static String QuerySender = "";
        private Color _legendColor = new Color();
        private PictureBox _chartLoadingImage = new PictureBox();

        #region InitialChartLoadCode

        private void IntialChartLoadPage(C1.Win.C1Tile.Tile tile)
        {
            _stockDataTable.Clear();
            UnCheckAllTiles();
            ToogleStockDetailsVisibility(false);
            _chartLoadingImage.Visible = true;
            StockChart.Visible = false;
            ToogleTileVisibility(false);
            backgroundWorkerChart.RunWorkerAsync(DurationEnum.Weekly);
            tile.Checked = true;
        }

        #endregion InitialChartLoadCode

        #region CustomEvents

        public delegate void ChartLoad(object sender, EventArgs e);

        public event ChartLoad ChartLoadCompleted;

        public delegate void ChartLoadStart(object sender, EventArgs e);

        public event ChartLoadStart ChartLoadStarted;

        private void onChartLoadCompleted(object sender, EventArgs args)
        {
            if (ChartLoadCompleted != null)
            {
                ChartLoadCompleted(sender, args);
            }
        }

        private void onChartLoadStarted(object sender, EventArgs args)
        {
            if (ChartLoadStarted != null)
            {
                onChartLoadStarted(sender, args);
            }
        }

        #endregion CustomEvents

        #region Constructor&others

        /// <summary>
        /// Uncheck All Duration Tiles
        /// </summary>
        private void UnCheckAllTiles()
        {
            foreach (C1.Win.C1Tile.Tile tile in TileControlDuration.Groups[0].Tiles)
            {
                tile.Checked = false;
            }
        }

        /// <summary>
        /// Add PictureBox to Panel 2 to Show Loading Gif
        /// </summary>
        private void AddChartLoadingPictureBox()
        {
            this.StockChartPanel.Controls.Add(_chartLoadingImage);
            _chartLoadingImage.Location = new Point(459, 30);
            _chartLoadingImage.Size = new Size(200, 158);
            _chartLoadingImage.Image = StockPortfolio.Properties.Resources.C1LoadingSpinner;
            _chartLoadingImage.Visible = false;
        }

        public StockChartData()
        {
            InitializeComponent();
            ToogleStockDetailsVisibility(false);
            AddChartLoadingPictureBox();
            this.Dock = DockStyle.Fill;
            AddColumnToStockDataTable();
            tileWeek.Checked = true;
            foreach (C1.Win.C1Tile.Tile tile in TileControlDuration.Groups[0].Tiles)
            {
                tile.Click += tile_Click;
            }
        }

        #endregion Constructor&others

        #region StockDataTableCode

        /// <summary>
        /// Populate Stock Details-Only Populates date from the First row of the StockDatatable
        /// </summary>
        private void SetStockDetails()
        {
            if (_stockDataTable.Rows.Count > 0)
            {
                lblCompanyDetail.Text = _companyNames[0];
                lblSymbolDetail.Text = _stockSymbols[0];
                lblOpenDetail.Text = _stockDataTable.Rows[0]["Open"].ToString();
                lblCloseDetail.Text = _stockDataTable.Rows[0]["Close"].ToString();
                lblHighDetail.Text = _stockDataTable.Rows[0]["High"].ToString();
                lblLowDetail.Text = _stockDataTable.Rows[0]["Low"].ToString();
                lblAdjCloseDetail.Text = _stockDataTable.Rows[0]["AdjClose"].ToString();
                lblVolumeDetail.Text = _stockDataTable.Rows[0]["Volume"].ToString();
            }
        }

        /// <summary>
        /// Add Columns to StockDataTable
        /// </summary>
        private void AddColumnToStockDataTable()
        {
            _stockDataTable.Columns.Add("ID", System.Type.GetType("System.String"));
            _stockDataTable.Columns.Add("Symbol", System.Type.GetType("System.String"));
            _stockDataTable.Columns.Add("CompanyName", System.Type.GetType("System.String"));
            _stockDataTable.Columns.Add("AdjClose", System.Type.GetType("System.Double"));
            _stockDataTable.Columns.Add("Close", System.Type.GetType("System.Double"));
            _stockDataTable.Columns.Add("High", System.Type.GetType("System.Double"));
            _stockDataTable.Columns.Add("Low", System.Type.GetType("System.Double"));
            _stockDataTable.Columns.Add("Open", System.Type.GetType("System.Double"));
            _stockDataTable.Columns.Add("Volume", System.Type.GetType("System.Double"));
            _stockDataTable.Columns.Add("Date", System.Type.GetType("System.DateTime"));
        }

        /// <summary>
        /// Populate StockData Table
        /// </summary>
        /// <param name="historicalStockList"></param>
        private void FillStockDataTable(List<HistoricalStock> historicalStockList, String stockSymbol, String companyName)
        {
            foreach (HistoricalStock hisStockData in historicalStockList)
            {
                DataRow dr = _stockDataTable.NewRow();
                dr["ID"] = hisStockData.Id;
                dr["Symbol"] = stockSymbol;
                dr["CompanyName"] = companyName;
                dr["AdjClose"] = hisStockData.AdjClose;
                dr["Close"] = hisStockData.Close;
                dr["High"] = hisStockData.High;
                dr["Low"] = hisStockData.Low;
                dr["Open"] = hisStockData.Open;
                dr["Volume"] = hisStockData.Volume;
                dr["Date"] = hisStockData.Date;

                _stockDataTable.Rows.Add(dr);
            }
        }

        #endregion StockDataTableCode

        #region ToogleVisibilityCode

        /// <summary>
        /// Toogle Visibility of all Controls that show Stock Details
        /// </summary>
        /// <param name="Visibility">Visibility Parameter</param>
        private void ToogleStockDetailsVisibility(Boolean visibility)
        {
            foreach (Control control in StockSummaryPanel.Controls)
            {
                control.Visible = visibility;
            }
        }

        /// <summary>
        /// Toogle Visibility of all Stock Tiles
        /// </summary>
        /// <param name="Visibility"></param>
        private void ToogleTileVisibility(Boolean visibility)
        {
            foreach (C1.Win.C1Tile.Tile tile in TileControlDuration.Groups[0].Tiles)
            {
                tile.Visible = visibility;
            }
        }

        #endregion ToogleVisibilityCode

        #region StockChartCode

        /// <summary>
        /// Stock Duration Tile click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tile_Click(object sender, EventArgs e)
        {
            C1.Win.C1Tile.Tile durationTile = (C1.Win.C1Tile.Tile)sender;
            StockSummaryPanel.Visible = true;
            if (!durationTile.Checked)
            {
                // onChartLoadStarted(sender, e);
                _stockDataTable.Clear();
                UnCheckAllTiles();
                ToogleStockDetailsVisibility(false);
                switch (durationTile.Text)
                {
                    case "7 Days":
                        _chartLoadingImage.Visible = true;
                        StockChart.Visible = false;
                        ToogleTileVisibility(false);
                        backgroundWorkerChart.RunWorkerAsync(DurationEnum.Weekly);
                        durationTile.Checked = true;
                        break;

                    case "30 Days":
                        _chartLoadingImage.Visible = true;
                        StockChart.Visible = false;
                        ToogleTileVisibility(false);
                        backgroundWorkerChart.RunWorkerAsync(DurationEnum.Monthly);
                        durationTile.Checked = true;
                        break;

                    case "90 Days":
                        _chartLoadingImage.Visible = true;
                        StockChart.Visible = false;
                        ToogleTileVisibility(false);
                        backgroundWorkerChart.RunWorkerAsync(DurationEnum.Quarterly);
                        durationTile.Checked = true;
                        break;

                    case "6 Months":
                        _chartLoadingImage.Visible = true;
                        StockChart.Visible = false;
                        ToogleTileVisibility(false);
                        backgroundWorkerChart.RunWorkerAsync(DurationEnum.HalfYearly);
                        durationTile.Checked = true;
                        break;

                    case "1 Year":
                        _chartLoadingImage.Visible = true;
                        StockChart.Visible = false;
                        ToogleTileVisibility(false);
                        backgroundWorkerChart.RunWorkerAsync(DurationEnum.YearOne);
                        durationTile.Checked = true;
                        break;

                    case "3 Years":
                        _chartLoadingImage.Visible = true;
                        StockChart.Visible = false;
                        ToogleTileVisibility(false);
                        backgroundWorkerChart.RunWorkerAsync(DurationEnum.YearThree);
                        durationTile.Checked = true;
                        break;

                    case "5 Years":
                        _chartLoadingImage.Visible = true;
                        StockChart.Visible = false;
                        ToogleTileVisibility(false);
                        backgroundWorkerChart.RunWorkerAsync(DurationEnum.YearFive);
                        durationTile.Checked = true;
                        break;
                }
            }
        }

        /// <summary>
        ///  This function only accepts  Multiple Stocks.Initial Chart Settings. 7 days tile is always the one selected when tile is opened first time.
        /// </summary>
        /// <param name="stockSymbol">Stock Symbol</param>
        /// <param name="companyName">Company Name</param>
        public void LoadInitialChartData(List<string> stockSymbols, List<string> companyNames, Object sender)
        {
            C1.Win.C1Tile.Tile tile = (C1.Win.C1Tile.Tile)sender;

            if (tile.Name == "StockSummarytile")
            {
                QuerySender = "StockSummaryTile";
            }
            else
            {
                QuerySender = "StockChartTile";
            }
            UnCheckAllTiles();
            _stockSymbols = stockSymbols;
            _companyNames = companyNames;
            _legendColor = tile.BackColor;
            tileWeek.Checked = false;

            IntialChartLoadPage(tileWeek);
            //tileWeek.PerformClick();
        }

        /// <summary>
        /// Set ChartDatasource to StockDataTable
        /// </summary>
        private void SetChartDataSource(String querysender)
        {
            #region StockChartCode

            if (_stockDataTable.Rows.Count > 0)
            {
                int seriesCount = -1;
                ChartDataSeriesCollection dscoll = StockChart.ChartGroups[0].ChartData.SeriesList;
                dscoll.Clear();
                int modValue = 0;

                ChartLabels lbls = StockChart.ChartLabels;
                lbls.LabelsCollection.Clear();
                foreach (var stkSymbol in _stockSymbols)
                {
                    String Query = "Symbol =" + "'" + stkSymbol + "'" + @"";

                    DataRow[] result = _stockDataTable.Select(Query);
                    if (result.Count() > 0)
                    {
                        ChartDataSeries series = dscoll.AddNewSeries();

                        if (querysender == "StockSummaryTile") // If Summary Tile is Clicked Set Chart type to XY
                        {
                            StockChart.ChartGroups[0].ChartType = Chart2DTypeEnum.XYPlot;
                            series.LineStyle.Pattern = LinePatternEnum.Solid;
                            series.SymbolStyle.Shape = SymbolShapeEnum.None;
                            StockSummaryPanel.Visible = false;
                        }

                        if (querysender == "StockChartTile") // If Stock Tile is Clicked Set Chart type to Area
                        {
                            StockChart.ChartGroups[0].ChartType = Chart2DTypeEnum.Area;
                            series.LineStyle.Pattern = LinePatternEnum.Solid;
                            series.SymbolStyle.Shape = SymbolShapeEnum.None;
                            series.LineStyle.Color = _legendColor;
                            StockSummaryPanel.Visible = true;
                        }

                        seriesCount++;
                        series.Label = result[0]["CompanyName"].ToString(); ;
                        series.PointData.Length = result.Count();

                        #region HandeLargeDataPoints

                        if (result.Count() < 7)
                        {
                            modValue = 1;
                        }

                        if (result.Count() > 6 && result.Count() < 25)
                        {
                            modValue = 3;
                        }

                        if (result.Count() > 24 && result.Count() < 70)
                        {
                            modValue = 5;
                        }

                        if (result.Count() > 69 && result.Count() < 130)
                        {
                            modValue = 10;
                        }

                        if (result.Count() > 129 && result.Count() < 260)
                        {
                            modValue = 16;
                        }

                        if (result.Count() > 259 && result.Count() < 800)
                        {
                            modValue = 50;
                        }

                        if (result.Count() > 799 && result.Count() < 1300)
                        {
                            modValue = 70;
                        }

                        for (int i = 0; i < result.Count(); i++)
                        {
                            series.X[i] = result[i]["Date"];

                            series.Y[i] = result[i]["Close"];

                            if (i % modValue == 0)
                            {
                                C1.Win.C1Chart.Label lbl = lbls.LabelsCollection.AddNewLabel();
                                lbl.Text = result[i]["Close"].ToString();

                                lbl.AttachMethod = AttachMethodEnum.DataIndex;
                                lbl.AttachMethodData.GroupIndex = 0;
                                lbl.AttachMethodData.SeriesIndex = seriesCount;
                                lbl.AttachMethodData.PointIndex = i;
                                lbl.Offset = 1;
                                lbl.Connected = true;
                                lbl.Style.ForeColor = SystemColors.WindowText;
                                lbl.Style.Font = new System.Drawing.Font(" Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                                lbl.Style.BackColor = Color.Transparent; ;

                                lbl.Visible = true;
                            }
                        }

                        #endregion HandeLargeDataPoints
                    }
                }
            }

            #endregion StockChartCode
        }

        /// <summary>
        /// Load Historical Data for Stock
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="duration">Duration Enumeration</param>
        /// <returns></returns>
        private List<HistoricalStock> LoadHistoricalChartData(String symbol, DurationEnum duration)
        {
            List<HistoricalStock> historicalData = new List<HistoricalStock>();
            DateTime today = DateTime.Today;
            switch (duration)
            {
                case DurationEnum.Weekly:

                    historicalData = _stockData.GetStockHistoricalData(symbol, today.AddDays(-7), today);
                    break;

                case DurationEnum.Monthly:
                    historicalData = _stockData.GetStockHistoricalData(symbol, today.AddMonths(-1), today);
                    break;

                case DurationEnum.Quarterly:
                    historicalData = _stockData.GetStockHistoricalData(symbol, today.AddMonths(-3), today);
                    break;

                case DurationEnum.HalfYearly:
                    historicalData = _stockData.GetStockHistoricalData(symbol, today.AddMonths(-6), today);
                    break;

                case DurationEnum.YearOne:
                    historicalData = _stockData.GetStockHistoricalData(symbol, today.AddYears(-1), today);
                    break;

                case DurationEnum.YearThree:
                    historicalData = _stockData.GetStockHistoricalData(symbol, today.AddYears(-3), today);
                    break;

                case DurationEnum.YearFive:
                    historicalData = _stockData.GetStockHistoricalData(symbol, today.AddYears(-5), today);
                    break;
            }

            return historicalData;
        }

        #endregion StockChartCode

        #region BackGroundWorker Code

        /// <summary>
        /// BackGround worker which loads the Histrorical Data of a Stock Symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerChart_DoWork(object sender, DoWorkEventArgs e)
        {
            DurationEnum duration = (DurationEnum)e.Argument;
            _stockDataTable.Rows.Clear();

            if ((_stockSymbols.Count() > 0) && (_companyNames.Count() > 0))
            {
                int count = 0;
                foreach (var symbol in _stockSymbols)
                {
                    var historicalData = LoadHistoricalChartData(symbol, duration);
                    if (historicalData != null)
                    {
                        FillStockDataTable(historicalData, symbol, _companyNames[count]);
                    }
                    count++;
                }
            }

            var io = _stockDataTable;
        }

        /// <summary>
        /// Hide Loading Spinner once loading is finished.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerChart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            onChartLoadCompleted(sender, e);

            SetChartDataSource(QuerySender);
            SetStockDetails();
            ToogleTileVisibility(true);
            _chartLoadingImage.Visible = false;
            StockChart.Visible = true;
            ToogleStockDetailsVisibility(true);
        }

        #endregion BackGroundWorker Code
    }
}