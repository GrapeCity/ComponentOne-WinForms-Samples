using System;
using System.Windows.Forms;

namespace StockPortfolio
{
    public partial class SettingsTile : UserControl
    {
        public SettingsTile()
        {
            InitializeComponent();
        }

        #region CustomEventCode
        public delegate void StockRefresh(object sender, EventArgs e);

        public event StockRefresh StockRefreshClicked;

        public delegate void StockSearch(object sender, EventArgs e);

        public event StockSearch StockSearchClicked;

        public delegate void StockRemove(object sender, EventArgs e);

        public event StockRemove StockRemoveClicked;


        private void onRefreshClicked(object sender, EventArgs args)
        {
            if (StockRefreshClicked != null)
            {
                StockRefreshClicked(sender, args);
            }
        }

        private void onStockSearchClick(object sender, EventArgs args)
        {
            if (StockSearchClicked != null)
            {
                StockSearchClicked(sender, args);
            }
        }

        private void onStockRemoveClick(object sender, EventArgs args)
        {
            if (StockRemoveClicked != null)
            {
                StockRemoveClicked(sender, args);
            }
        }

        #endregion CustomEventCode

        public delegate void SettingsClickEventHandler(object sender, MouseEventArgs e);

        public event SettingsClickEventHandler SettingsClicked;

        private void onSettingsClicked(object sender, MouseEventArgs e)
        {
            if (SettingsClicked != null)
            {
                SettingsClicked(sender, e);
            }
        }

        #region TileEvents

        /// <summary>
        /// Tile Remove Click Process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileRemove_Click(object sender, EventArgs e)
        {
            onStockRemoveClick(sender, e);
        }

        /// <summary>
        /// Tile Refresh Click Process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileRefresh_Click(object sender, EventArgs e)
        {
            onRefreshClicked(sender, e);
        }

        #endregion TileEvents

        /// <summary>
        /// Tile Search Click process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileSearch_Click(object sender, EventArgs e)
        {
            TileAllSettings.Visible = false;

            onStockSearchClick(sender, e);
        }

        private void TileAllSettings_MouseClick(object sender, MouseEventArgs e)
        {
            onSettingsClicked(sender, e);
        }
    }
}