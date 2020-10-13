using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockPortfolio
{
    public partial class StockTilePortfolio : UserControl
    {
        private AddStockPortfolio _addstockPortfolio = new AddStockPortfolio();
        private StockChartData _chartdata = new StockChartData();
        private PictureBox _stockPortfolioLoadingPictureBox = new PictureBox();
        private List<string> _companyList = new List<string>();
        private List<string> _symbolsList = new List<string>();
        private String _addstockText = "ADD STOCK";
        private string _stockSummaryText = "STOCK SUMMARY DETAIL";
        private List<Color> _tileColors = new List<Color>();

        public bool isTileChecked { get; set; }

        public bool EnableTileClick { get; set; }

        public void setUpdatedTime(String value)
        {
            this.lblStockPortfolioDataUpdate.Text = value;
        }

        public void UpdatedTimeLabelVisibility(Boolean value)
        {
            this.lblStockPortfolioDataUpdate.Visible = value;
        }

        #region CustomEventCode

        // Custom events...............
        public event EventHandler StockTileClicked;

        public event EventHandler TileCheckedChanged;

        private void onStockTileClicked(object sender, EventArgs args)
        {
            if (StockTileClicked != null)
            {
                StockTileClicked(sender, args);
            }
        }

        private void onTileCheckedChanged(object sender, EventArgs e)
        {
            if (TileCheckedChanged != null)
            {
                TileCheckedChanged(sender, e);
            }
        }

        #endregion CustomEventCode

        #region StockTilePorfolio Constructor

        public StockTilePortfolio()
        {
            _addstockPortfolio = new AddStockPortfolio();
            _chartdata = new StockChartData();

            _tileColors.AddRange(new Color[]
            {
                Color.FromArgb(255, 190, 0), Color.FromArgb(255, 255, 0), Color.FromArgb(148, 215, 82), Color.FromArgb(0, 182, 82), Color.FromArgb(0, 182, 239), Color.FromArgb(0, 117, 198), Color.FromArgb(115, 53, 156),
                Color.FromArgb(21, 72, 123), Color.FromArgb(239, 239, 231), Color.FromArgb(74, 130, 189), Color.FromArgb(198, 80, 74), Color.FromArgb(156, 186, 90), Color.FromArgb(132, 101, 165), Color.FromArgb(74, 174, 198), Color.FromArgb(247, 150, 66),
                Color.FromArgb(107, 101, 107), Color.FromArgb(206, 195, 214), Color.FromArgb(206, 186, 99), Color.FromArgb(156, 178, 132), Color.FromArgb(107, 178, 206), Color.FromArgb(99, 134, 206), Color.FromArgb(123, 105, 206), Color.FromArgb(165, 120, 189),
                Color.FromArgb(231, 223, 214), Color.FromArgb(247, 125, 0), Color.FromArgb(21, 89, 123), Color.FromArgb(74, 134, 66), Color.FromArgb(99, 72, 123), Color.FromArgb(198, 154, 90),
                Color.FromArgb(99, 105, 132), Color.FromArgb(198, 211, 214), Color.FromArgb(214, 96, 74), Color.FromArgb(206, 182, 0), Color.FromArgb(40, 174, 173), Color.FromArgb(140, 120, 115), Color.FromArgb(140, 178, 140), Color.FromArgb(14, 146, 74)
            });

            InitializeComponent();
            EnableTileClick = true;
            this.Dock = DockStyle.Fill;
            LoadControls();
            _chartdata.ChartLoadCompleted += _chartdata_ChartLoadCompleted;
            StockSummarytile.Click += StockSummarytile_Click;
        }

        /// <summary>
        /// Load Controls to the StockPortfolio
        /// </summary>
        private void LoadControls()
        {
            this.splitContainer1.Panel2.Controls.Add(_chartdata);
            this.splitContainer1.Panel2.Controls.Add(_addstockPortfolio);
            this.splitContainer1.Panel2.Controls.Add(_stockPortfolioLoadingPictureBox);

            _chartdata.Location = new Point(50, 100);
            _addstockPortfolio.Location = new Point(100, 10);
            _stockPortfolioLoadingPictureBox.Location = new Point(462, 145);
            _stockPortfolioLoadingPictureBox.Size = new System.Drawing.Size(200, 158);
            _stockPortfolioLoadingPictureBox.Image = StockPortfolio.Properties.Resources.C1LoadingSpinner;

            _chartdata.Visible = false;
            _addstockPortfolio.Visible = false;
            _stockPortfolioLoadingPictureBox.Visible = false;
        }

        #endregion StockTilePorfolio Constructor

        #region StockDetailsCode

        /// <summary>
        /// Populates Company and Symbol Lists
        /// </summary>
        private void CreateSymbolsCompanyList()
        {
            int elementCount = 0;
            C1.Win.C1Tile.Template TA = StockPortfolioTileControl.Templates[1];
            _companyList.Clear();
            _symbolsList.Clear();
            if (elementCount < 18)
            {
                foreach (var el in TA.Elements)
                {
                    if (el.GetType().ToString() == "C1.Win.C1Tile.PanelElement")
                    {
                        C1.Win.C1Tile.PanelElement _panel = (C1.Win.C1Tile.PanelElement)el;
                        C1.Win.C1Tile.TextElement _companyText = (C1.Win.C1Tile.TextElement)_panel.Children[0];

                        if (_panel.Visible == true)
                        {
                            _companyList.Add(_companyText.Description);
                            _symbolsList.Add(_panel.Description);
                        }
                    }

                    elementCount++;
                }
            }
        }

        /// <summary>
        /// Reset the Stock Template to clear fields. This is called in refresh
        /// </summary>
        private void ResetStockDetailsTemplate()
        {
            int elementCount = 0;
            C1.Win.C1Tile.Template ta = StockPortfolioTileControl.Templates[1];

            if (elementCount < 11)
            {
                foreach (var el in ta.Elements)
                {
                    if (el.GetType().ToString() == "C1.Win.C1Tile.PanelElement")
                    {
                        if (elementCount != 0)
                        {
                            C1.Win.C1Tile.PanelElement panel = (C1.Win.C1Tile.PanelElement)el;
                            C1.Win.C1Tile.TextElement companyText = (C1.Win.C1Tile.TextElement)panel.Children[0];
                            C1.Win.C1Tile.TextElement askText = (C1.Win.C1Tile.TextElement)panel.Children[1];
                            C1.Win.C1Tile.ImageElement statusImage = (C1.Win.C1Tile.ImageElement)panel.Children[2];

                            panel.Visible = false;
                            panel.Description = "";
                            companyText.Text = "";
                            companyText.Description = "";
                            askText.Text = "";
                            statusImage.Symbol = C1.Win.C1Tile.TileSymbol.SBArrowDown;
                        }
                    }
                    elementCount++;
                }
            }
        }

        /// <summary>
        /// Load Stock Details of Stocks to the Stock Details Tile
        /// </summary>
        /// <param name="stockName">Company Name</param>
        /// <param name="AskPrice">Ask Price</param>
        /// <param name="change">Change Percentage</param>
        private void LoadStockDetails(String stockName, String stockSymbol, String lastTrade, String change)
        {
            int elementCount = 0;

            C1.Win.C1Tile.Template ta = StockPortfolioTileControl.Templates[1];

            if (elementCount < 11)
            {
                for (int i = 0; i < ta.Elements.Count; i++)
                {
                    var el = ta.Elements[i];
                    if (el.GetType().ToString() == "C1.Win.C1Tile.PanelElement")
                    {
                        if (elementCount != 0)
                        {
                            C1.Win.C1Tile.PanelElement panel = (C1.Win.C1Tile.PanelElement)el;
                            C1.Win.C1Tile.TextElement companyText = (C1.Win.C1Tile.TextElement)panel.Children[0];
                            C1.Win.C1Tile.TextElement askText = (C1.Win.C1Tile.TextElement)panel.Children[1];
                            C1.Win.C1Tile.ImageElement statusImage = (C1.Win.C1Tile.ImageElement)panel.Children[2];

                            if (panel.Visible == false)
                            {
                                panel.Visible = true;
                                panel.Description = stockSymbol;
                                if (stockName.Length > 6)
                                {
                                    companyText.Description = stockName;
                                    companyText.Text = stockName.Substring(0, 6);
                                }
                                else
                                {
                                    companyText.Text = stockName;
                                }

                                askText.Text = Math.Round(float.Parse(lastTrade), 2).ToString();

                                if (change.Contains("-"))
                                {
                                    statusImage.Symbol = C1.Win.C1Tile.TileSymbol.SBArrowDown;
                                    statusImage.Margin = new Padding(0, 0, 20, 0);
                                }
                                else
                                {
                                    if (change.Contains("0.00"))
                                    {
                                        statusImage.Symbol = C1.Win.C1Tile.TileSymbol.RemoteDesktopHome;

                                        statusImage.Margin = new Padding(0, 0, 20, 0);
                                    }
                                    else
                                    {
                                        statusImage.Symbol = C1.Win.C1Tile.TileSymbol.SBArrowUp;
                                        statusImage.Margin = new Padding(0, 0, 20, 10);
                                    }
                                }
                                break;
                            }
                        }
                    }
                    elementCount++;
                }
            }
        }

        public void UnCheckAllTiles()
        {
            foreach (C1.Win.C1Tile.Tile tile in StockPortfolioTileControl.Groups["AddTileGroup"].Tiles)
            {
                tile.Checked = false;
            }
        }

        private bool IsTileChecked()
        {
            foreach (C1.Win.C1Tile.Tile tile in StockPortfolioTileControl.Groups["AddTileGroup"].Tiles)
            {
                if (tile.Checked == true)
                {
                    isTileChecked = true;
                    break;
                }
                else
                {
                    isTileChecked = false;
                }
            }

            return isTileChecked;
        }

        /// <summary>
        /// Stock Summary Click. This is load the Sumary Chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StockSummarytile_Click(object sender, EventArgs e)
        {
            if (EnableTileClick == true)
            {
                CreateSymbolsCompanyList();

                onStockTileClicked(sender, e);
                this.StockPortfolioTileControl.Hide();

                PageNameLabel pagelabel = (PageNameLabel)this.splitContainer1.Panel1.Controls[3];
                pagelabel.lblPagelabel.Text = _stockSummaryText;

                this.splitContainer1.Panel1.Controls[3].Visible = false;
                this._addstockPortfolio.Visible = false;
                _stockPortfolioLoadingPictureBox.Visible = true;
                _chartdata.LoadInitialChartData(_symbolsList, _companyList, sender);
                _stockPortfolioLoadingPictureBox.Visible = false;
                this._chartdata.Visible = true;

                this.BackTile.Tag = "NavigationLevel2";
            }
            else
            {
                StockSummarytile.Checked = false;
            }
        }

        #endregion StockDetailsCode

        #region StockChartCode

        /// <summary>
        /// When chart loading is comple
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void _chartdata_ChartLoadCompleted(object sender, EventArgs args)
        {
            this.splitContainer1.Panel1.Controls[0].Visible = true;
            this.splitContainer1.Panel1.Controls[1].Visible = true;
            this.splitContainer1.Panel1.Controls[3].Visible = true;
        }

        #endregion StockChartCode

        #region StockTileCode

        /// <summary>
        /// Get Stock Data for Symbol
        /// </summary>
        /// <param name="Symbol"></param>
        /// <returns></returns>
        private StockQuotes GetStockData(String symbol)
        {
            StockData stockQuoteData = new StockData();
            return stockQuoteData.GetStockQuoteData(symbol);
        }

        /// <summary>
        /// Load All Stocks from Tiles.Config to the Portfolio Tile
        /// </summary>
        public void LoadStockListing(String stockIndex, Boolean refreshData)
        {
            XDocument xdoc = XDocument.Load("Tiles.config");
            var tiles = (from Tile in xdoc.Descendants("Tile")
                         select new { Tile.Value }).ToList();
            Random randomcall = new Random();
            if (refreshData == true)
            {
                ResetStockDetailsTemplate();
                foreach (var symbol in tiles)
                {
                    {
                        StockQuotes quote = GetStockData(symbol.Value);
                        if (quote != null)
                        {
                            LoadStockDetails(quote.StockName, quote.StockSymbol, quote.LastTrade.ToString(), quote.Change.ToString());
                        }
                    }
                }
                EnableTileClick = true;
            }

            foreach (var tile in StockPortfolioTileControl.Groups["AddTileGroup"].Tiles)
            {
                foreach (var symbol in tiles.ToList())
                {
                    if (symbol.Value == tile.Text1)
                    {
                        tiles.Remove(symbol);
                    }
                }
            }

            int number = _tileColors.Count - 1;
            foreach (var symbol in tiles)
            {
                StockQuotes quote = GetStockData(symbol.Value);
                if (quote != null)
                {
                    LoadStockDetails(quote.StockName, quote.StockSymbol, quote.LastTrade.ToString(), quote.Change.ToString());
                    AddStockTile(quote.StockSymbol, quote.StockName, quote.LastTrade.ToString(), quote.Change.ToString(), quote.PercentChange, _tileColors[randomcall.Next(0, number)]);
                }
            }
        }

        /// <summary>
        /// Handle Stock Tile Click-This will open the Chart Detail of the Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tile_Click(object sender, EventArgs e)
        {
            C1.Win.C1Tile.Tile stockTile = (C1.Win.C1Tile.Tile)sender;
            if (EnableTileClick == true)
            {
                _companyList.Clear();
                _symbolsList.Clear();

                onStockTileClicked(sender, e);

                String companyName = stockTile.Text;
                String stockSymbol = stockTile.Text1;

                _companyList.Add(companyName);
                _symbolsList.Add(stockSymbol);

                this.StockPortfolioTileControl.Hide();

                PageNameLabel pagelabel = (PageNameLabel)this.splitContainer1.Panel1.Controls[3];
                pagelabel.lblPagelabel.Text = companyName;

                this.splitContainer1.Panel1.Controls[3].Visible = false;
                this._addstockPortfolio.Visible = false;
                _stockPortfolioLoadingPictureBox.Visible = true;

                _stockPortfolioLoadingPictureBox.Visible = false;

                _chartdata.LoadInitialChartData(_symbolsList, _companyList, sender);
                this._chartdata.Visible = true;

                this.BackTile.Tag = "NavigationLevel2";
                IsTileChecked();
            }
            else
            {
                stockTile.Checked = true;
            }
        }

        #endregion StockTileCode

        #region AddStockTileLogic

        /// <summary>
        /// Add a Stock Tile to the Tile Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStockPortfolioTile_Click(object sender, EventArgs e)
        {
            if (EnableTileClick)
            {
                this.lblStockPortfolioDataUpdate.Visible = false;
                this.StockPortfolioTileControl.Hide();

                PageNameLabel pagelabel = (PageNameLabel)this.splitContainer1.Panel1.Controls[3];
                pagelabel.lblPagelabel.Text = _addstockText;

                this._chartdata.Visible = false;
                _addstockPortfolio.Visible = true;
                this.Refresh();

                this.BackTile.Tag = "NavigationLevel2";
            }
        }

        /// <summary>
        /// Add  a Stock Tile to the TileControl
        /// </summary>
        /// <param name="symbol">Stock Symbol</param>
        /// <param name="company">Company Name</param>
        /// <param name="Ask">Ask Price</param>
        /// <param name="change">Change Percentage</param>
        /// <param name="tileColor">Tile Color</param>
        public void AddStockTile(String symbol, String company, String lastTrade, String change, String changePercent, Color tileColor)
        {
            C1.Win.C1Tile.Tile tile = new C1.Win.C1Tile.Tile();

            #region ProcessTileAdd

            tile.Click += tile_Click;
            tile.CheckedChanged += StockSummarytile_CheckedChanged;
            if (change.Contains("-"))
            {
                tile.Symbol = C1.Win.C1Tile.TileSymbol.Dislike;
            }
            else
            {
                if (change.Contains("0.00"))
                {
                    tile.Symbol = C1.Win.C1Tile.TileSymbol.ChooseLikeOrDislike;
                }
                else
                {
                    tile.Symbol = C1.Win.C1Tile.TileSymbol.Like;
                }
            }

            changePercent = changePercent.Replace("\"", "");
            tile.Text = company;
            tile.Text1 = symbol;

            int index = company.Substring(0, Math.Min(company.Length, 10)).LastIndexOf(',');
            if (index != -1)
            {
                tile.Text2 = company.Substring(0, Math.Min(company.Length, 10)).Remove(index, 1);
            }
            else
            {
                tile.Text2 = company.Substring(0, Math.Min(company.Length, 10));
            }
            tile.Text3 = lastTrade;
            tile.Text4 = change + "(" + changePercent + ")";
            tile.Template = StockPortfolioTileControl.Templates["StockDataTemplate"];
            tile.HorizontalSize = 3;
            tile.VerticalSize = 2;
            tile.BackColor = tileColor;
            StockPortfolioTileControl.Groups["AddTileGroup"].Tiles.Insert(0, tile);

            #endregion ProcessTileAdd
        }

        #endregion AddStockTileLogic

        private void StockSummarytile_CheckedChanged(object sender, EventArgs e)
        {
            C1.Win.C1Tile.Tile checkedTile = (C1.Win.C1Tile.Tile)sender;
            IsTileChecked();

            if ((checkedTile.Name == "AddStockPortfolioTile") || (checkedTile.Name == "StockSummarytile"))
            {
                onTileCheckedChanged(sender, e);
                checkedTile.Checked = false;
            }
            else
            {
                onTileCheckedChanged(sender, e);
            }
        }

        private void splitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                onTileCheckedChanged(sender, e);
            }
        }
    }
}