using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Xml.Linq;

namespace StockPortfolio
{
    public partial class StockPortfolioContainer : Form
    {
        private SettingsTile _tileSettings = new SettingsTile();
        private StockTilePortfolio _tilePortfolioUserControl = new StockTilePortfolio();
        private LandingPage _stockLandingPage = new LandingPage();

        private PageNameLabel _pageLabel = new PageNameLabel();

        #region Constructor and Form Load code

        //<summary>
        //StockPortfolio Constructor
        //</summary

        public StockPortfolioContainer()
        {
            InitializeComponent();

            _tilePortfolioUserControl.TileCheckedChanged += _tilePortfolioUserControl_TileCheckedChanged;
            this.LoadingPictureBox.Image = StockPortfolio.Properties.Resources.C1LoadingSpinner;  //Loading Spinner
            _tileSettings.SettingsClicked += _tileSettings_SettingsClicked;
        }

        private void _tileSettings_SettingsClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ToggleSettingsPanelVisibility(true);
            }
            else
            {
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[2].Visible = true;
                _tilePortfolioUserControl.EnableTileClick = true;
                _tileSettings.Visible = false;
            }
        }

        private void _tilePortfolioUserControl_TileCheckedChanged(object sender, EventArgs e)
        {
            if (_tileSettings.Visible == false)
            {
                ToggleSettingsPanelVisibility(true);
            }
            else
            {
                if (_tilePortfolioUserControl.isTileChecked != true)
                {
                    ToggleSettingsPanelVisibility(false);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddControlstoStockTilePorfolio();

            _tilePortfolioUserControl.StockPortfolioTileControl.MouseClick += TilePortfolioUserControl_MouseClick;  // Mouse Click handled
            _tilePortfolioUserControl.BackTile.Click += BackTile_Click;
            _tilePortfolioUserControl.StockTileClicked += TilePortfolioUserControl_StockTileClicked;

            _tileSettings.StockRemoveClicked += TileSettings_StockRemoveClicked;
            _tileSettings.StockRefreshClicked += TileSettings_StockRefreshClicked;
            _tileSettings.StockSearchClicked += TileSettings_StockSearchClicked;

            _stockLandingPage.ForwardTile.Click += ForwardTile_Click;

            _stockLandingPage.Visible = true;
            _tilePortfolioUserControl.Visible = false;
            this.panel1.Controls.Add(_stockLandingPage);
            this.panel1.Controls.Add(_tilePortfolioUserControl);
        }

        private void ForwardTile_Click(object sender, EventArgs e)
        {
            _stockLandingPage.Visible = false;
            this.LoadingPictureBox.Visible = true;
            this.LoadingBackGroundWorker.RunWorkerAsync();
        }

        //<summary>
        //Navigation Button Logic Stock Portfolio
        //</summary>
        //<param name="sender"></param>
        //<param name="e"></param>

        // There are Three Navigation Levels

        //NavigationLevel1- When user is on the Stock Portfolio Page
        //NavigationLevel2- When user is on the Add Stock Page,Summary or Chart Page
        //Navigation Level 3- When user is on the Search Stock Page

        private void BackTile_Click(object sender, EventArgs e)
        {
            //Navigation Level:

            C1.Win.C1Tile.Tile backTile = sender as C1.Win.C1Tile.Tile;
            if (backTile != null)
            {

                if ((string)backTile.Tag == "NavigationLevel1")
                {
                    _stockLandingPage.Visible = true;
                    _tilePortfolioUserControl.Visible = false;
                }

                if ((string)backTile.Tag == "NavigationLevel2")
                {
                    _tilePortfolioUserControl.splitContainer1.Panel2.Controls[4].Visible = false;
                    _tilePortfolioUserControl.splitContainer1.Panel2.Controls[3].Visible = false;
                    _tilePortfolioUserControl.splitContainer1.Panel2.Controls[2].Visible = false;
                    _tilePortfolioUserControl.splitContainer1.Panel2.Controls[1].Visible = true;

                    PageNameLabel _pagelabel = (PageNameLabel)_tilePortfolioUserControl.splitContainer1.Panel1.Controls[3];
                    _pagelabel.lblPagelabel.Text = "WATCHLIST";

                    _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Visible = true; 
                    _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Visible = true;

                    _tilePortfolioUserControl.UpdatedTimeLabelVisibility(true);

                    this.LoadingBackGroundWorker.RunWorkerAsync();
                    backTile.Tag = "NavigationLevel1";
                    _tilePortfolioUserControl.EnableTileClick = true;
                }
            }
        }

        // Show Settings Panel........

        private void ToggleSettingsPanelVisibility(Boolean state)
        {
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Visible = !state;
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Visible = !state;
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[2].Visible = !state;
            _tileSettings.Visible = state;
            _tileSettings.Controls[0].Visible = state;
            _tilePortfolioUserControl.EnableTileClick = !state;
            if (_tilePortfolioUserControl.StockPortfolioTileControl.Groups[1].Tiles.Count == 0)
            {
                _tileSettings.TileAllSettings.Groups[0].Tiles[1].Visible = !state;
            }
            else
            {
                _tileSettings.TileAllSettings.Groups[0].Tiles[1].Visible = state;
            }
        }

        /// <summary>
        /// Tile Settings Visible Logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TilePortfolioUserControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ToggleSettingsPanelVisibility(true);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[2].Visible = true;
                _tilePortfolioUserControl.EnableTileClick = true;
                _tileSettings.Visible = false;
            }
        }

        #endregion Constructor and Form Load code

        #region TileSettingCode
        /// <summary>
        /// Remove Tile from Tiles.config
        /// </summary>
        /// <param name="Symbol"></param>
        private void RemoveSymbolFromXML(string Symbol)
        {
            XDocument xdoc = XDocument.Load("Tiles.config");
            xdoc.Descendants("Tile").Where(x => x.Value == Symbol).Remove();
            xdoc.Save("Tiles.config");
        }

        /// <summary>
        /// Hide Controls in the Panel 1 when Search Tile is clicked in the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TileSettings_StockSearchClicked(object sender, EventArgs args)
        {
            _tilePortfolioUserControl.UnCheckAllTiles();
            _tilePortfolioUserControl.splitContainer1.Panel2.Controls[0].Visible = false;
            _tilePortfolioUserControl.splitContainer1.Panel2.Controls[1].Visible = false;
            _tilePortfolioUserControl.splitContainer1.Panel2.Controls[2].Visible = false;
            _tilePortfolioUserControl.splitContainer1.Panel2.Controls[3].Visible = true;
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Visible = true;
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[3].Visible = true;
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[2].Visible = false;
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Visible = true;
            _tilePortfolioUserControl.BackTile.Tag = "NavigationLevel2";

            PageNameLabel _pagelabel = (PageNameLabel)_tilePortfolioUserControl.splitContainer1.Panel1.Controls[3];
            _pagelabel.lblPagelabel.Text = "SEARCH STOCK";

            //_searchStock.Visible = true;
        }

        /// <summary>
        /// Stock Refresh Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TileSettings_StockRefreshClicked(object sender, EventArgs args)
        {
            _tilePortfolioUserControl.Visible = false;
            LoadingPictureBox.Visible = true;
            this.LoadingBackGroundWorker.RunWorkerAsync("Refresh");
            _tilePortfolioUserControl.UnCheckAllTiles();
        }

        /// <summary>
        /// When TileSettings is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TileSettings_SelectionEnabled(object sender, EventArgs args)
        {
            _tilePortfolioUserControl.EnableTileClick = false;
            _tilePortfolioUserControl.StockPortfolioTileControl.AllowChecking = true;
        }

        /// <summary>
        /// When remove  stock button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TileSettings_StockRemoveClicked(object sender, EventArgs e)
        {
            foreach (C1.Win.C1Tile.Tile stockSymbolTile in _tilePortfolioUserControl.StockPortfolioTileControl.Groups["AddTileGroup"].Tiles.Where(t => t.Checked).ToList())
            {
                String stockSymbol = stockSymbolTile.Text1;
                _tilePortfolioUserControl.StockPortfolioTileControl.Groups["AddTileGroup"].Tiles.Remove(stockSymbolTile);

                RemoveSymbolFromXML(stockSymbol);
            }

            _tilePortfolioUserControl.EnableTileClick = true;
            _tilePortfolioUserControl.Visible = false;
            LoadingPictureBox.Visible = true;
            this.LoadingBackGroundWorker.RunWorkerAsync("Refresh");
        }

         #endregion TileSettingCode

        #region StockTilePortfolioUserControlCode

        /// <summary>
        /// Add TileSettings to StokPortfolio
        /// </summary>
        private void AddControlstoStockTilePorfolio()
        {
            _tileSettings.Dock = DockStyle.Fill;
            _tileSettings.Visible = false;

            _pageLabel.Location = new Point(90, 41);

            _tilePortfolioUserControl.splitContainer1.Panel1.Controls.Add(_tileSettings);

            _tilePortfolioUserControl.splitContainer1.Panel1.Controls.Add(_pageLabel);
        }

        /// <summary>
        /// When a Stock Tile is Clicked. Hide all control IN Panel 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TilePortfolioUserControl_StockTileClicked(object sender, EventArgs args)
        {
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Hide();
            _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Hide();
        }

        #endregion StockTilePortfolioUserControlCode

        #region backgroundworkercode

        //<summary>
        //Container Form Load
        //</summary>
        //<param name="sender"></param>
        //<param name="e"></param>

        //<summary>
        //BackGround worder to Load Stock Listing for Market Index
        //</summary>
        //<param name="sender"></param>
        //<param name="e"></param>
        private void LoadingBackGroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((string)e.Argument == "Refresh")
            {
                _tilePortfolioUserControl.LoadStockListing("Nasdaq", true);
                e.Result = "RefreshCompleted";
            }
            else
            {
                _tilePortfolioUserControl.LoadStockListing("Nasdaq", false);
            }
        }

        //<summary>
        //Background worker completed handler
        //</summary>
        //<param name="sender"></param>
        //<param name="e"></param>
        private void LoadingBackGroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _tilePortfolioUserControl.setUpdatedTime("Last Updated " + DateTime.Now.ToString("f"));
            if (LoadingPictureBox.Visible == true)
            {
                this.LoadingPictureBox.Visible = false;
                _tilePortfolioUserControl.Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[2].Visible = false;
            }

            if (_tilePortfolioUserControl.splitContainer1.Panel2.Controls[3].Visible == true)
            {
                _tilePortfolioUserControl.splitContainer1.Panel2.Controls[0].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[0].Visible = true;
                _tilePortfolioUserControl.splitContainer1.Panel1.Controls[1].Visible = true;
            }
        }

        #endregion backgroundworkercode

        private void StockPortfolioContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}