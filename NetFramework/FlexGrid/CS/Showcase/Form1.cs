using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;
using C1.Win.Ribbon;
using C1.Win.RulesManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Showcase
{

    public partial class Form1 : C1RibbonForm
    {
        private const string _customThemeName = "Greenwich";
        private const int _footerTextPadding = 4;
        private DataSet _ds = new DataSet();
        private C1RulesManager _rulesManager = new C1RulesManager();
        private IEnumerable<IRule> _rules = Enumerable.Empty<IRule>();
        private Random _rnd = new Random();

        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();

            InitFlexGrid();
            InitRules();
            InitThemes();

            // Data sizes
            var dataSizes = new List<string>() { "10 Rows, 12 Columns", "50 Rows, 12 Columns", "100 Rows, 12 Columns", "1000 Rows, 12 Columns", "5000 Rows, 12 Columns" };
            foreach (var item in dataSizes)
                _listDataSize.Items.Add(item);

            // Columns visible
            _lstColumns.Items.Clear();
            (from s in _flex.Cols.Cast<Column>() select s)
                .Where(x => !string.IsNullOrEmpty(x.Name))
                .Select(x => new RibbonToggleButton()
                {
                    Text = x.Caption,
                    Pressed = x.Visible
                })
                .ToList()
                .ForEach(x =>
                {
                    x.PressedButtonChanged += new EventHandler(_lstColumns_PressedChanged);
                    _lstColumns.Items.Add(x);
                });


            _listDataSize.SelectedIndex = 2;

            ActiveControl = _flex;
        }

        #endregion

        #region Fill Data

        private enum Countries
        {
            Germany,
            UK,
            US,
            Japan
        };

        private enum DrawColors
        {
            Black,
            White,
            Green,
            Red
        };

        private void BuildRows(int countRows, DataTable dt)
        {
            var startPeriod = new DateTime(2020, 01, 25, 8, 29, 0);
            _flex.BeginUpdate();

            // Related data
            var products = (from s in _ds.Tables["Products"].Rows.Cast<DataRow>() select s)
                    .Select(x => x["Name"].ToString())
                    .ToArray();

            var countries = Enum.GetValues(typeof(Countries))
                    .Cast<Countries>()
                    .ToArray();

            var colors = Enum.GetValues(typeof(DrawColors))
                    .Cast<DrawColors>()
                    .ToArray();

            // Creating rows
            var data = Enumerable.Range(1, countRows)
                    .Select(x => new object[]
                    { 
                    // ID
                    x,
                    // Product
                    products[_rnd.Next(products.Length)],
                    // Country
                    countries[_rnd.Next(countries.Length)],
                    // Color
                    colors[_rnd.Next(colors.Length)],
                    // Price
                    _rnd.NextDouble() * 100 * _rnd.Next(100),
                    // Change
                    _rnd.NextDouble() * 10 * _rnd.Next(100) * (_rnd.Next(1,3) == 1 ? (-1) : 1),
                    // History
                    Enumerable.Range(0, 12).Select(y => _rnd.Next(0,50)).ToArray(),
                    // Discount
                    _rnd.NextDouble(),
                    // Raiting
                    _rnd.Next(0,5),
                    // Active
                    (_rnd.Next(1,3) == 1 ? false : true),
                    // Date
                    startPeriod.AddDays(_rnd.Next(60))
                        .AddHours(_rnd.Next(60))
                        .AddMinutes(_rnd.Next(60))
                    });

            dt.Clear();
            data.ToList().ForEach(x => dt.Rows.Add(x));

            _ds.AcceptChanges();
            _flex.EndUpdate();
        }

        private void FillData()
        {
            var descriptions = new List<string>()
            {
                "Across all our software products and services, our focus is on helping our customers achieve their goals. Our key principles – thoroughly understanding our customers' business objectives, maintaining a strong emphasis on quality, and adhering to the highest ethical standards – serve as the foundation for everything we do."
            };

            // Products table
            var dt = new DataTable("Products");
            var columns = new List<string>() { "Name", "Size", "Weight", "Quantity", "Description" }
                        .Select(x => new DataColumn() { ColumnName = x, DataType = typeof(string) });
            dt.Columns.AddRange(columns.ToArray());

            // Add rows
            dt.Rows.Add(new object[] { "Gadget", "120", "900", "2", descriptions[_rnd.Next(descriptions.Count - 1)] });
            dt.Rows.Add(new object[] { "Widget", "20", "20", "25", descriptions[_rnd.Next(descriptions.Count - 1)] });
            dt.Rows.Add(new object[] { "Doohickey", "74", "90", "100", descriptions[_rnd.Next(descriptions.Count - 1)] });
            _ds.Tables.Add(dt);

            // Data table
            dt = new DataTable("Data");
            dt.Columns.Add("ID", typeof(int));

            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Country", typeof(Countries));
            dt.Columns.Add("Color", typeof(DrawColors));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Change", typeof(decimal));
            dt.Columns.Add("History", typeof(object));
            dt.Columns.Add("Discount", typeof(decimal));
            dt.Columns.Add("Rating", typeof(int));
            dt.Columns.Add("Active", typeof(bool));
            dt.Columns.Add("Date", typeof(DateTime));

            _ds.Tables.Add(dt);

            // Creating relation between products and data
            _ds.Relations.Add("Producs_Data",
                    _ds.Tables["Products"].Columns["Name"], _ds.Tables["Data"].Columns["Product"]);

            _flex.DataSource = _ds;
            _flex.DataMember = "Data";
        }

        #endregion

        #region Init FlexGrid

        static Image LoadImage(string recourceName)
        {
            // load the picture
            Image img = null;
            try
            {
                var resource = "Showcase.Properties.Resources";
                var assembly = Assembly.GetExecutingAssembly();

                var manager = new System.Resources.ResourceManager(resource, assembly);
                if (manager != null)
                {
                    Bitmap bmp = (Bitmap)manager.GetObject(recourceName, CultureInfo.InvariantCulture);
                    return bmp;
                }
            }
            catch (Exception)
            {
            }

            // return what we got
            return img;
        }

        private void InitGroups()
        {
            var props = new List<string>();
            if (_optGroupByCountry.Checked)
                props.Add("Country");
            if (_optGroupByProduct.Checked)
                props.Add("Product");

            // Clear condition filters
            if (_flex.GroupDescriptions != null && props.Count == 0)
            {
                _flex.GroupDescriptions = null;
                return;
            }

            var groups = props
                    .Select(x => new GroupDescription(x, ListSortDirection.Ascending))
                    .ToList();
            _flex.GroupDescriptions = groups;
        }

        private void InitFlexGrid()
        {
            _flex.AllowFiltering = true;
            _flex.ShowErrors = true;

            _flex.Cols[0].Width = 22;

            // build data map
            var flagsHt = new Hashtable();
            Enum.GetValues(typeof(Countries))
             .Cast<Countries>()
             .ToList()
             .ForEach(x =>
             {
                 flagsHt.Add(x, LoadImage(x.ToString()));
             });

            // assign ImageMap to countries column
            _flex.Cols["Country"].ImageMap = flagsHt;
            _flex.Cols["Country"].ImageAndText = true;

            var colorsHt = new Hashtable();
            Enum.GetValues(typeof(DrawColors))
                .Cast<DrawColors>()
                .ToList()
                .ForEach(x =>
                {
                    colorsHt.Add(x, LoadImage(x.ToString()));
                });

            _flex.Cols["Color"].ImageMap = colorsHt;
            _flex.Cols["Color"].ImageAndText = true;

            // Formatting columns
            _flex.Cols["ID"].Width = 50;
            _flex.Cols["ID"].AllowEditing = false;
            _flex.Cols["Date"].Format = "g";
            _flex.Cols["Price"].Format = "C2";
            _flex.Cols["Price"].TextAlign = TextAlignEnum.RightCenter;

            // Add validator
            _flex.Cols["Price"].EditorValidation.Add(new RequiredRule());
            _flex.Cols["Price"].EditorValidation.Add(new RangeRule()
            {
                Minimum = decimal.Zero,
                Maximum = decimal.MaxValue,
                ErrorMessage = "Price cannot be negative"
            });


            _flex.Cols["Change"].Format = "C2";
            _flex.Cols["Change"].TextAlign = TextAlignEnum.RightCenter;
            _flex.Cols["Discount"].Format = "p0";
            _flex.Cols["Discount"].AllowEditing = false;
            _flex.Cols["Discount"].Width = 80;
            _flex.Cols["Rating"].ImageAndText = false;
            _flex.Cols["Rating"].AllowEditing = false;
            _flex.Cols["Price"].Width = 80;

            // For the history column initialize sparkline
            _flex.Cols["History"].ShowSparkline = true;
            _flex.Cols["History"].Sparkline.ShowLow = true;
            _flex.Cols["History"].Sparkline.ShowHigh = true;
            _flex.Cols["History"].AllowEditing = false;

            _flex.Cols["Active"].Width = 60;

            // Init combobox list
            var productList = (from s in _ds.Tables["Products"].Rows.Cast<DataRow>() select s)
                .Select(x => x["Name"].ToString())
                .ToArray();
            var list = string.Join("|", productList);
            _flex.Cols["Product"].ComboList = list;


            // Creating footers
            var footerDescription = new FooterDescription();

            // Price agg
            var aggFooterPriceAvg = new AggregateDefinition();
            aggFooterPriceAvg.Aggregate = AggregateEnum.Average;
            aggFooterPriceAvg.Caption = "Average price: ${0:N2}";
            aggFooterPriceAvg.PropertyName = "Price";

            // Discount agg
            var aggFooterDiscoutAvg = new AggregateDefinition();
            aggFooterDiscoutAvg.Aggregate = AggregateEnum.Average;
            aggFooterDiscoutAvg.Caption = "Average discount: {0:P}";
            aggFooterDiscoutAvg.PropertyName = "Discount";

            footerDescription.Aggregates.Add(aggFooterPriceAvg);
            footerDescription.Aggregates.Add(aggFooterDiscoutAvg);

            // Add footers
            _flex.Footers.Descriptions.Add(footerDescription);
            _flex.Footers.Fixed = true;

            // Set details
            _flex.RowDetailProvider = (g, r) => new CustomRowDetail();

            // Other properties
            _flex.HideGroupedColumns = true;
            _flex.AllowFiltering = true;
            _flex.AllowMerging = AllowMergingEnum.Nodes;


            // Add styles (Red, Green and Rating)
            var style = _flex.Styles.Add("Red");
            style.ImageAlign = ImageAlignEnum.LeftCenter;
            style.ForeColor = Color.Red;

            style = _flex.Styles.Add("Green");
            style.ImageAlign = ImageAlignEnum.LeftCenter;
            style.ForeColor = Color.Green;

            style = _flex.Styles.Add("Rating");
            style.ImageAlign = ImageAlignEnum.RightCenter;

        }

        private void InitRules()
        {
            _rulesManager.SetC1RulesManager(_flex, _rulesManager);
            var rulesDict = new Dictionary<string, string>()
                {
                    { "Discount < 10%", "= [Discount] < 0.1" },
                    { "Discount < 20%", "= [Discount] < 0.2" },
                    { "Discount < 30%", "= [Discount] < 0.3" }
                };

            // Creating rules
            _rules = rulesDict.Keys
                .Select(x => new C1.Win.RulesManager.Rule()
                {
                    Name = x,
                    Expression = rulesDict[x],
                    Style = new ItemStyle()
                    {
                        ForeColor = Color.FromArgb(_rnd.Next(255), _rnd.Next(255), _rnd.Next(255)),
                        BorderColor = Color.DarkBlue,
                        FontStyle = FontStyle.Bold
                    }
                });

            // Add menu items
            rulesDict.Keys
                .Select(x => new RibbonToggleButton()
                {
                    Text = x,
                    Pressed = false
                })
                .ToList()
                .ForEach(x =>
                {
                    x.PressedButtonChanged += new EventHandler(_lstFormating_PressedChanged);
                    _lstFormating.Items.Add(x);
                });

        }

        #endregion

        #region Themes

        private void InitThemes()
        {
            // Register custom theme
            var customThemePath = Path.Combine(Directory.GetCurrentDirectory(), _customThemeName + ".c1themez");
            if (File.Exists(customThemePath))
            {
                C1ThemeController.RegisterTheme(customThemePath);
            }

            // Load themes into ribbon combo box
            var themes = C1ThemeController.GetThemes().Where(x => x == _customThemeName || x.Contains("Office2016") || x.Contains("Material"));
            foreach (var theme in themes)
            {
                _lstThemes.Items.Add(theme);
            }

            // Set default theme
            var customThemeIndex = _lstThemes.Items.IndexOf(_customThemeName);
            if (customThemeIndex > -1)
            {
                _lstThemes.SelectedIndex = customThemeIndex;
            }
        }

        #endregion

        #region FlexGrid Events

        private void _flex_GridChanged(object sender, GridChangedEventArgs e)
        {
            var lastRowIndex = _flex.Rows.Count - 1;
            if (e.GridChangedType == GridChangedTypeEnum.CellChanged && e.r1 == lastRowIndex)
            {
                UpdateFooterColumnWidth(e.c1);
            }
        }

        private void _flex_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            var columnName = _flex.Cols[e.Col].Name;

            // custom paint cells for change column
            if (_flex[e.Row, e.Col] is decimal && columnName == "Change")
            {
                var value = (decimal)_flex[e.Row, e.Col];
                if (value >= 0)
                {
                    e.Style = _flex.Styles["Green"];
                    e.Image = LoadImage("UpGreen");
                }
                else
                {
                    e.Style = _flex.Styles["Red"];
                    e.Image = LoadImage("DownRed");
                }
            }

            // custom paint cells for raiting
            if (_flex[e.Row, e.Col] is int && columnName == "Rating")
            {
                var value = (int)_flex[e.Row, e.Col];
                if (value > 0)
                {
                    e.Style = _flex.Styles["Rating"];
                    e.Image = LoadImage($"star{value}");
                }
            }
        }

        private void UpdateFooterColumnWidth(int columnIndex)
        {
            var lastRowIndex = _flex.Rows.Count - 1;
            if (_flex.Footers.Descriptions.Count > 0)
            {
                var footerCellValue = _flex[lastRowIndex, columnIndex];
                if (footerCellValue == null)
                {
                    return;
                }

                var footerCellTextWidth = TextRenderer.MeasureText(footerCellValue.ToString(), _flex.Styles.Footer.Font).Width;
                _flex.Cols[columnIndex].Width = Math.Max(footerCellTextWidth + _footerTextPadding, _flex.Cols[columnIndex].Width);
            }
        }

        #endregion

        #region Ribbon Events
        private void _exportPdf_Click(object sender, EventArgs e)
        {
            var printDocument = _flex.PrintParameters.PrintDocument;
            printDocument.DocumentName = "Export to PDF";
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            try
            {
                // Print document into Microsoft PDF printer
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _optGroupByCountry_CheckedChanged(object sender, EventArgs e)
        {
            InitGroups();
        }

        private void _optGroupByProduct_CheckedChanged(object sender, EventArgs e)
        {
            InitGroups();
        }

        private void _listDataSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = _ds.Tables["Data"];
            switch (_listDataSize.SelectedIndex)
            {
                case 0:
                    {
                        BuildRows(10, dt);
                        break;
                    }
                case 1:
                    {
                        BuildRows(50, dt);
                        break;
                    }
                case 2:
                    {
                        BuildRows(100, dt);
                        break;
                    }
                case 3:
                    {
                        BuildRows(1000, dt);
                        break;
                    }
                case 4:
                    {
                        BuildRows(5000, dt);
                        break;
                    }
            }
        }

        private void _lstThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change theme
            var themeName = _lstThemes.Text;
            _themeController.Theme = themeName;
        }

        private void _exportToExcell_Click(object sender, EventArgs e)
        {
            // Export to excel
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "xls";
            dlg.FileName = "*.xls";
            dlg.InitialDirectory = Application.ExecutablePath;
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            _flex.SaveGrid(dlg.FileName, FileFormatEnum.Excel);
        }

        private void _exportToCsv_Click(object sender, EventArgs e)
        {
            // Export to csv
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "csv";
            dlg.FileName = "*.csv";
            dlg.InitialDirectory = Application.ExecutablePath;
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            _flex.SaveGrid(dlg.FileName, FileFormatEnum.TextComma, FileFlags.None, Encoding.UTF8);
        }

        private void _txtSearch_ChangeCommitted(object sender, EventArgs e)
        {
            _flex.ApplySearch(_txtSearch.Text, true, true);
        }

        private void _lstColumns_PressedChanged(object sender, EventArgs e)
        {
            var preseedColumn = sender as RibbonToggleButton;
            if (preseedColumn != null)
                _flex.Cols[preseedColumn.Text].Visible = preseedColumn.Pressed;
        }

        private void _lstFormating_PressedChanged(object sender, EventArgs e)
        {
            var pressedRule = sender as RibbonToggleButton;
            if (pressedRule != null)
            {
                var ruleName = pressedRule.Text;
                var pressed = pressedRule.Pressed;

                var newRule = _rules.Where(x => x.Name == ruleName).FirstOrDefault();
                newRule.AppliesTo.Add(new FieldRange(new string[] { "Product", "Country", "Color", "Discount" }));

                var existsRule = _rulesManager.Rules.Where(x => x.Name == ruleName).FirstOrDefault();

                if (!pressed && _rulesManager.Rules.Contains(existsRule))
                    _rulesManager.Rules.Remove(existsRule);
                if (pressed && existsRule == null)
                    _rulesManager.Rules.Add(newRule);
            }
        }

        private void _filter_Click(object sender, EventArgs e)
        {
            _flex.ApplySearch(_txtSearch.Text, true, true);
        }

        private void _txtSearch_TextChanged(object sender, EventArgs e)
        {
            _flex.ApplySearch(_txtSearch.Text, true, false);
        }

        #endregion

        #region ThemeController Events

        private void _themeController_ObjectThemeApplied(C1ThemeController sender, ObjectThemeEventArgs e)
        {
            if (e.Object != _flex)
            {
                return;
            }

            _flex.Styles.Footer.TextAlign = TextAlignEnum.RightCenter;

            var cols = _flex.Cols;
            if (cols == null)
            {
                return;
            }

            if (cols.Contains("Price"))
            {
                UpdateFooterColumnWidth(cols["Price"].Index);
            }
            if (cols.Contains("Discount"))
            {
                UpdateFooterColumnWidth(cols["Discount"].Index);
            }
        }

        #endregion
      
    }
}
