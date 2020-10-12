using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace StockPortfolio
{
    public partial class LandingPage : UserControl
    {
        private List<StockQuotes> _stockIndexQuotes = new List<StockQuotes>();
        private StockData _stockDataProcess = new StockData();
        private List<String> _stockIndexSymbols = new List<string>();

        public LandingPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            PopulateStockIndexSymbols();
            PopulateStockIndexData();
            FillStockIndexTiles();
        }

        #region PopulateDataCode

        private void PopulateStockIndexData()
        {
            _stockIndexQuotes.Clear();
            foreach (var stockIndexSymbol in _stockIndexSymbols)
            {
                _stockIndexQuotes.Add(_stockDataProcess.GetStockQuoteData(stockIndexSymbol));
            }
            LastUpdated();
        }

        /// <summary>
        /// Load Stock Index data
        /// </summary>
        private void PopulateStockIndexSymbols()
        {
            foreach (C1.Win.C1Tile.Tile stockIndexTile in c1TileControl1.Groups[0].Tiles)
            {
                //Text 3 contains StockIndex Symbols. Please update Text 3 whenever adding a new index tile.
                if (stockIndexTile.Text3 != "")
                {
                    _stockIndexSymbols.Add(stockIndexTile.Text3);
                }
            }
        }

        #endregion PopulateDataCode

        /// <summary>
        ///  Handle Mouse Move over the Stock Index Tiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c1TileControl1_MouseMove(object sender, MouseEventArgs e)
        {
            Collection<C1.Win.C1Tile.Tile> tileCollection = GetALLTiles(c1TileControl1);

            int xvalue = e.X;
            int yvalue = e.Y;

            foreach (C1.Win.C1Tile.Tile tile in tileCollection)
            {
                if ((yvalue > (tile.TopCell - 1) * c1TileControl1.CellHeight) && (yvalue < (tile.TopCell - 1) * c1TileControl1.CellHeight + c1TileControl1.CellHeight) && (xvalue > (tile.LeftCell - 1) * c1TileControl1.CellWidth) && (xvalue < (tile.LeftCell - 1) * c1TileControl1.CellWidth + c1TileControl1.CellWidth))
                {
                    if (tile.Tag != null && tile.Tag.ToString() == "0")
                    {
                        tile.IntValue = 1;
                        tile.VerticalSize = 4;
                    }
                    tile.Tag = "1";
                }
                else
                {
                    if (tile.Tag != null && tile.Tag.ToString() == "1")
                    {
                        tile.IntValue = 0;
                        tile.VerticalSize = 1;
                    }

                    tile.Tag = "0";
                }
            }
        }

        private void FillStockIndexTiles()
        {
            foreach (C1.Win.C1Tile.Tile stockIndexTile in c1TileControl1.Groups[0].Tiles)
            {
                foreach (var stockIndexQuote in _stockIndexQuotes)
                {
                    if (stockIndexQuote.StockSymbol == stockIndexTile.Text3)
                    {
                        stockIndexTile.Text1 = stockIndexQuote.LastTrade.ToString();
                        stockIndexTile.Text2 = stockIndexQuote.PercentChange.Replace("\"", "");
                    }
                }
            }
        }

        //Get List of All Tiles in a TileControl
        private Collection<C1.Win.C1Tile.Tile> GetALLTiles(C1.Win.C1Tile.C1TileControl TileControl)
        {
            Collection<C1.Win.C1Tile.Tile> tilecol = new Collection<C1.Win.C1Tile.Tile>();

            foreach (C1.Win.C1Tile.Group tileGroups in TileControl.Groups)
            {
                foreach (C1.Win.C1Tile.Tile tile in tileGroups.Tiles)
                {
                    tilecol.Add(tile);
                }
            }
            return tilecol;
        }

        /// <summary>
        /// Last Updated Data for Stock Index
        /// </summary>
        private void LastUpdated()
        {
            lblIndexDataUpdatedSince.Text = "Last Updated " + DateTime.Now.ToString("f");
        }
    }
}