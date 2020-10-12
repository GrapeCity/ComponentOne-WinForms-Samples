using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockPortfolio
{
    public partial class AddStockPortfolio : UserControl
    {
        private List<string> _companyList = new List<string>();
        private AutoCompleteStringCollection _autoCompleteCompanyCollection = new AutoCompleteStringCollection();
        private List<StockSymbolData> _stockSymbolList;

        #region Constructor Code

        /// <summary>
        /// AddStockPortfolio constructor handles AutoComplete Operation
        /// </summary>
        public AddStockPortfolio()
        {
            InitializeComponent();

            LoadAutoCompleteData();

            c1FlexGrid.SetCellImage(0, 0, StockPortfolio.Properties.Resources.Sort);

            CellRange cr = c1FlexGrid.GetCellRange(0, 0);
            cr.StyleDisplay.ImageAlign = ImageAlignEnum.RightBottom;
            cr.StyleDisplay.Margins = new System.Drawing.Printing.Margins(0, 2, 0, 2);

            AddStockPortfolioButton.Click += AddStockPortfolioButton_Click;

            c1FlexGrid.Visible = false;

            SearchTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!_companyList.Contains(SearchTextBox.Text))
                    {
                        SearchTextBox.AutoCompleteCustomSource.Add(SearchTextBox.Text);
                    }
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    AutoCompleteStringCollection _tempCollection = SearchTextBox.AutoCompleteCustomSource;
                    _tempCollection.Remove(SearchTextBox.Text);
                    SearchTextBox.AutoCompleteCustomSource = _tempCollection;
                    SearchTextBox.Clear();
                }
            };
        }

        #endregion Constructor Code

        #region EventHandling Code

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "Company Name" && SearchTextBox.Text != "")
            {
                LoadSymbolInfo();
                c1FlexGrid.Visible = true;
            }
        }

        /// <summary>
        /// Add Stock Portfolio button adds Stock Symbol to Tiles.config
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStockPortfolioButton_Click(object sender, EventArgs e)
        {
            String symbol = "";
            XDocument xdoc = XDocument.Load("Tiles.config");
            var tiles = xdoc.Descendants("Tile").ToList();
            bool changed = false;
            for (int i = 0; i < c1FlexGrid.Rows.Count; i++)
            {
                var row = c1FlexGrid.Rows[i];
                if (row.Selected)
                {
                    symbol = row[1].ToString();
                    // check that we don't adding it twice
                    foreach(XElement tile in tiles)
                    {
                        if ( symbol.Equals( tile.Value))
                        {
                            // already exists
                            symbol = "";
                            break;
                        }

                    }
                    if (!string.IsNullOrEmpty(symbol))
                    {
                        xdoc.Element("StockTile").Add(new XElement("Tile", symbol));
                        changed = true;
                    }
                }
            }
            if (changed)
            {
                xdoc.Save("Tiles.config");
            }
            AddStockPortfolioButton.Enabled = false;
            c1FlexGrid.Visible = false;
            AddStockPortfolioButton.Visible = false;
            SearchTextBox.Text = "";
        }

        /// <summary>
        /// Clear TextBox when user tried to Type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AddStockPortfolioButton.Visible = false;
            c1FlexGrid.Visible = false;
            if (SearchTextBox.Text == "Company Name")
            {
                SearchTextBox.Text = "";
            }
        }

        #endregion EventHandling Code

        #region SymbolData and AutoCompleteload Code

        // Loads Data of Stock to the C1 Flexgrid
        private void LoadSymbolInfo()
        {
            c1FlexGrid.SetDataBinding(_stockSymbolList.Where(x => x.CompanyName == SearchTextBox.Text).ToList<StockSymbolData>(), "", true);

            if (c1FlexGrid.Rows.Count > 1)
            {
                c1FlexGrid.Visible = true;
                AddStockPortfolioButton.Visible = true;
                AddStockPortfolioButton.Enabled = true;

                c1FlexGrid.BeginUpdate();
                int rowHeight = c1FlexGrid.Rows.Count * c1FlexGrid.Rows[0].HeightDisplay;

                if (rowHeight < 256)
                {
                    c1FlexGrid.Height = rowHeight;
                }
                else
                {
                    c1FlexGrid.Height = 256;
                }

                c1FlexGrid.EndUpdate();
            }
        }

        /// <summary>
        /// Loads the Company Names of listed stocks to the Autocomplete TextBox
        /// </summary>
        private void LoadAutoCompleteData()
        {
            StockData stockDataProcessor = new StockData();
            _stockSymbolList = stockDataProcessor.GetStockSymbolData();
            _companyList = _stockSymbolList.Select(x => x.CompanyName).Distinct().ToList();
            _autoCompleteCompanyCollection.AddRange(_companyList.ToArray());
            SearchTextBox.AutoCompleteCustomSource = _autoCompleteCompanyCollection;
            SearchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        #endregion SymbolData and AutoCompleteload Code

  /*      private void c1FlexGrid_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (e.Col == 0)
            {
                e.Style.ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.RightBottom;
                e.Image = c1FlexGrid.Glyphs[C1.Win.C1FlexGrid.GlyphEnum.Ascending];
            }
        }*/
    }
}