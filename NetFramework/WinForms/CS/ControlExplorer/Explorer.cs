using C1.Win.Ribbon;
using ControlExplorer.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Xml;
using C1.Win.C1Themes;
using System.Xml.Linq;
using System.Diagnostics;

namespace ControlExplorer
{
    public partial class Explorer : C1RibbonForm
    {
        //===================================================================================//
        #region fields
        private static readonly object locker = new object();
        private bool tileLayoutCompleted = false;
        private int tileColumns = 0;
        private C1DemoViewer _viewer = null;
        private C1DemoForm _activeForm;
        private FlatIconList _icons = new FlatIconList();
        private Image _controlNewOverlay = Properties.Resources.New;
        private Image _shortCutOverlay = Properties.Resources.ShortcutOverlay;
        private ExplorerMode explorerMode;

        #endregion
        //===================================================================================//
        #region properties

        public ExplorerMode CurrentExplorerMode
        {
            get
            {
                return explorerMode;
            }
            set
            {
                explorerMode = value;
                switch (explorerMode)
                {
                    case ExplorerMode.Suite:
                        pnlMainSamples.Visible = false;
                        pnlMainControls.Visible = true;
                        pnlLeftSamples.Visible = false;
                        pnlLeftControls.Visible = true;
                        if (_viewer != null)
                            _viewer.HideProps();
                        break;
                    case ExplorerMode.Controls:
                    case ExplorerMode.Samples:
                        if (!pnlMainSamples.Visible)
                        {
                            pnlMainSamples.Visible = true;
                            pnlLeftSamples.Visible = true;
                            pnlMainControls.Visible = false;
                            pnlLeftControls.Visible = false;
                        }
                        break;
                }
            }
        }

        public static Explorer TheExplorer { get; private set; }

        #endregion
        //===================================================================================//
        public Explorer()
        {
            foreach (KeyValuePair<string, Image> icon in StyleInfo.ControlIcons)
            {
                _icons.Add(icon.Key, icon.Value);
            }
            _icons.Add("ControlOverlay", _controlNewOverlay);
            _icons.Add("ShortCutOverlay", _shortCutOverlay);
            InitializeComponent();
            TheExplorer = this;
            _viewer = new C1DemoViewer();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            CurrentExplorerMode = ExplorerMode.Suite;
            breadCrumb.Home.Tag = ExplorerMode.Suite;
            breadCrumb.HomeImage = Properties.Resources.home24;
        }

        //===================================================================================//
        #region Load Samples and Controls

        private void LoadControlTiles()
        {
            tilesPopular.Groups[0].Tiles.Clear();
            tilesNew.Groups[0].Tiles.Clear();
            tilesControlUtil.Groups[0].Tiles.Clear();
            cteUtil.Text = "Utilities";
            tilesControlDV.Groups[0].Tiles.Clear();
            ctelDV.Text = "DataVisualization";
            tilesControlNaL.Groups[0].Tiles.Clear();
            cteNaL.Text = "Navigation and Layout";
            tilesControlIaE.Groups[0].Tiles.Clear();
            cteIaE.Text = "Input and Editing";
            tilesControlRaD.Groups[0].Tiles.Clear();
            cteRaD.Text = "Reporting and Documents";
            tilesControlGDM.Groups[0].Tiles.Clear();
            cteGDM.Text = "Grids and Data Management";
            tilesControlSch.Groups[0].Tiles.Clear();
            cteSch.Text = "Scheduling";

            foreach (ControlInfo control in ControlInfo.Controls)
            {
                C1.Win.C1Tile.Tile controlTile = new C1.Win.C1Tile.Tile();
                controlTile.Text = control.Name;
                controlTile.Template = template2;
                controlTile.Tag = control;
                if (control.IsNew)
                {
                    controlTile.Image1 = _icons["ControlOverlay"].Image;

                    C1.Win.C1Tile.Tile newTile = new C1.Win.C1Tile.Tile();
                    newTile.Text = control.Name;
                    newTile.Tag = control;
                    tilesNew.Groups[0].Tiles.Add(newTile);
                }
                if (control.IsPopular)
                {
                    C1.Win.C1Tile.Tile newTile = new C1.Win.C1Tile.Tile();
                    newTile.Text = control.Name;
                    newTile.Tag = control;
                    tilesPopular.Groups[0].Tiles.Add(newTile);
                }
                if (!string.IsNullOrEmpty(control.Tooltip))
                {
                    // add tooltip
                    controlTile.ToolTipText = control.Tooltip;
                }
                if (!string.IsNullOrEmpty(control.Link))
                {
                    // add shortcut overlay image
                    controlTile.Image2 = _shortCutOverlay;
                }
                switch (control.Group)
                {
                    case "Utilities":
                        tilesControlUtil.Groups[0].Tiles.Add(controlTile);
                        break;
                    case "Data Visualization":
                        tilesControlDV.Groups[0].Tiles.Add(controlTile);
                        break;
                    case "Navigation and Layout":
                        tilesControlNaL.Groups[0].Tiles.Add(controlTile);
                        break;
                    case "Input and Editing":
                        tilesControlIaE.Groups[0].Tiles.Add(controlTile);
                        break;
                    case "Reporting and Documents":
                        tilesControlRaD.Groups[0].Tiles.Add(controlTile);
                        break;
                    case "Grids and Data Management":
                        tilesControlGDM.Groups[0].Tiles.Add(controlTile);
                        break;
                    case "Scheduling":
                        tilesControlSch.Groups[0].Tiles.Add(controlTile);
                        break;
                }
            }
            UpdateTileLayout();
            tileLayoutCompleted = true;
            if (tilesNew.Groups[0].Tiles.Count == 0)
            {
                tilesNew.Parent.Visible = false;
            }
            if (tilesPopular.Groups[0].Tiles.Count == 0)
            {
                tilesPopular.Parent.Visible = false;
            }
        }
        private void UpdateTileLayout()
        {
            lock (locker)
            {
                int width = pnlMainControls.Width;
                int widthofeachpanel = 122;
                int spacing = 10;
                int heightofeachpanel = 122;
                int topandbottompadding = 20 + 20;
                int noofCols = width / (widthofeachpanel + spacing);

                if (noofCols > 0)
                {
                    if (noofCols != tileColumns)
                    {
                        tileColumns = noofCols;
                        int i = 0;
                        Dictionary<C1.Win.C1Tile.C1TileControl, ControlTreeExpander> tiles 
                            = new Dictionary<C1.Win.C1Tile.C1TileControl, ControlTreeExpander>()
                        {
                            { tilesControlUtil,cteUtil },
                            { tilesControlDV,ctelDV},
                            { tilesControlNaL,cteNaL},
                            { tilesControlIaE,cteIaE},
                            { tilesControlRaD,cteRaD},
                            { tilesControlGDM,cteGDM },
                            { tilesControlSch,cteSch }
                        };
                        foreach (KeyValuePair<C1.Win.C1Tile.C1TileControl, ControlTreeExpander> tileControl in tiles)
                        {
                            tileControl.Value.ChildCollapsedHeight = 20;
                            i = 0;
                            int k = 0;
                            foreach (var tile in tileControl.Key.Groups[0].Tiles)
                            {
                                tile.LeftCell = (i % noofCols) + 1;
                                tile.TopCell = (i / noofCols) + 1;
                                k = k < tile.TopCell ? tile.TopCell : k;
                                i++;
                            }
                            int Height = topandbottompadding + k * (heightofeachpanel + spacing) - spacing;
                            tileControl.Value.ChildExpandedHeight = Height;
                        }
                    }
                }
            }
        }

        private void loadSample(SampleInfo sample)
        {
            if (sample != null)
            {
                if ( sample.FormName.StartsWith(@"ComponentOne\Demos\"))
                {
                    // run standalone demo or demo installer
                    RunDemo(sample.FormName);
                    return;
                }
                try
                {
                    this.Cursor = Cursors.AppStarting;
                    LockWindowUpdate(Handle);
                    if (breadCrumb.Items.Count == 2)
                    {
                        BreadCrumbItem item = breadCrumb.AddItem(sample.Name);
                        item.Tag = ExplorerMode.Samples;
                    }
                    else
                    {
                        breadCrumb.RemoveTop();
                        BreadCrumbItem item = breadCrumb.AddItem(sample.Name);
                        item.Tag = ExplorerMode.Samples;
                    }
                    string description = sample.LongDescription;
                    if (description == null || description == "")
                    {
                        description = sample.ShortDescription;
                    }
                    lblLeftDescriptionSamples.Text = description;
                    if (_activeForm != null)
                        _activeForm.Dispose();
                    
                    // load sample form
                    _activeForm = _viewer.Run(sample.FormName, sample.Name, sample.LongDescription);
                    // attach viewer if it is not attached yet
                    Control.ControlCollection collection = pnlMainSamples.Controls;
                    if (!collection.Contains(_viewer))
                    {
                        collection.Clear();
                        collection.Add(_viewer);
                        _viewer.Visible = true;
                    }
                    TheExplorer.CurrentExplorerMode = ExplorerMode.Samples;
                }
                finally
                {
                    LockWindowUpdate(IntPtr.Zero);
                    this.Cursor = Cursors.Default;
                }
            }
        }

        [DllImport("user32.dll", ExactSpelling = true)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);

        private void RunDemo(string path)
        {
            /*
 ComponentOne\Demos\WinForms Edition\CurrencyComparison\CurrencyComparison.exe
 ComponentOne\Demos\WinForms Edition\FlexChart\FlexChartExplorer.exe
 ComponentOne\Demos\WinForms Edition\FinancialChartExplorer\FinancialChartExplorer.exe
 ComponentOne\Demos\WinForms Edition\C1WordX\C1words.exe
 ComponentOne\Demos\WinForms Edition\FlexReportExplorer\FlexReportExplorer.exe
 ComponentOne\Demos\WinForms Edition\StockPortfolio\StockPortfolio.exe
 ComponentOne\Demos\WinForms Edition\MapSample\MapSample.exe
 ComponentOne\Demos\WinForms Edition\SoftwareDevelopmentPlan\SoftwareDevelopmentPlan.exe
 ComponentOne\Demos\WinForms Edition\StockChart\StockChart.exe
 ComponentOne\Demos\WinForms Edition\TouchToolkit\TouchToolKitDemo.exe
 ComponentOne\Demos\WinForms Edition\WeatherChart\WeatherChart.exe
  * */

            string appPath = Environment.Is64BitOperatingSystem ? Environment.GetEnvironmentVariable("ProgramFiles(x86)") : Environment.GetEnvironmentVariable("ProgramFiles");
            path = appPath + "\\" + path;
            string name = System.IO.Path.GetFileNameWithoutExtension(path);
            if (System.IO.File.Exists(path))
            {
                var processes = Process.GetProcessesByName(name);
                if (processes.Count() > 0)
                {
                    // if already runningm, bring to front
                    WindowHelper.BringProcessToFront(processes[0]);
                }
                else
                {
                    // run app
                    Process.Start(path);
                }
            }
            else
            {
                // show message and navigate to demos page
                // todo: might try to run Samples Explorer first
                var result = MessageBox.Show(name + " not found.\r\nClick Yes to visit the downloads page.", name + " Not Found", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    Process.Start("https://developer.mescius.com/componentone/demos");
                }
            }
        }
        #endregion
        //===================================================================================//
        #region Theming
        static string themeName;

        public static string ThemeName
        {
            get
            {
                return themeName;
            }
            set
            {
                if (themeName != value)
                {
                    themeName = value;
                }
            }
        }

        public static C1Theme Theme
        {
            get
            {
                if (!string.IsNullOrEmpty(ThemeName))
                    return C1.Win.C1Themes.C1ThemeController.GetThemeByName(ThemeName, false);
                else
                    return null;
            }
        }

        public static void ApplyTheme(Control control)
        {
            var theme = Theme;
            if (theme != null)
            {
                if (control == TheExplorer)
                {
                    // color all icons according to the new loaded theme
                    Color foreground = Theme.GetColor(@"BaseThemeProperties\ControlText");
                    bool needUpdateIcons = foreground != TheExplorer._icons.Foreground;
                    if (needUpdateIcons)
                    {
                        TheExplorer._icons.Foreground = foreground;
                        // Data Visualization group
                        ApplyTileImages(TheExplorer.tilesControlDV.Groups[0].Tiles);
                        // Grids and Data Management group
                        ApplyTileImages(TheExplorer.tilesControlGDM.Groups[0].Tiles);
                        // Input and Editing group
                        ApplyTileImages(TheExplorer.tilesControlIaE.Groups[0].Tiles);
                        // Navigation and Layout group
                        ApplyTileImages(TheExplorer.tilesControlNaL.Groups[0].Tiles);
                        // Reporting and Documents group
                        ApplyTileImages(TheExplorer.tilesControlRaD.Groups[0].Tiles);
                        // Scheduling group
                        ApplyTileImages(TheExplorer.tilesControlSch.Groups[0].Tiles);
                        // Utilities group
                        ApplyTileImages(TheExplorer.tilesControlUtil.Groups[0].Tiles);

                        // new
                        ApplyTileImages(TheExplorer.tilesNew.Groups[0].Tiles);
                        // favorites
                        ApplyTileImages(TheExplorer.tilesPopular.Groups[0].Tiles);
                    }
                    TheExplorer.UpdateStyles();
                }

                if (control.FindForm() == TheExplorer)
                {
                    // Controls that rely on specific colors to be visible/usable:
                    List<Control> noTheming = new List<Control>()
                    {
                        TheExplorer.pnlInputPanel,
                    };
                    C1ThemeController.ApplyThemeToControlTree(control, theme, (c) => !noTheming.Contains(c) && (!(c is C1DemoForm) || ((C1DemoForm)c).IsThemeable));
                }
                else
                {
                    var demoForm = control as C1DemoForm;
                    if (demoForm == null || demoForm.IsThemeable)
                    {
                        C1ThemeController.ApplyThemeToControlTree(control, theme);
                    }
                }

                // Style non themable controls for uniformity
                StyleForNonThemableControls();

                if (control == TheExplorer)
                {
                    OnThemeApplied(EventArgs.Empty);
                }
            }
        }

         private static void ApplyTileImages(C1.Win.C1Tile.TileCollection tiles)
        {
            for (int i = 0; i < tiles.Count; ++i)
            {
                var tile = tiles[i];
                if (tile.Image1 != null) //= _controlNewOverlay;
                    tile.Image1 = TheExplorer._icons["ControlOverlay"].Image;
                if (tile.Image2 != null) //= _shortCutOverlay;
                    tile.Image2 = TheExplorer._icons["ShortCutOverlay"].Image;
                ControlInfo cnt = tile.Tag as ControlInfo;
                tile.Image = TheExplorer._icons[cnt.Name].Image;
            }
        }

        private static void StyleForNonThemableControls()
        {
            #region get font and colors from existing theme
            Font newFont = Theme.GetFont(@"BaseThemeProperties\ControlText", null);
            Color newFormBackColor = TheExplorer.tilesControlDV.BackColor;
            Color newFormForeColor = GetContrastForeground(newFormBackColor, TheExplorer.tilesControlDV.ForeColor);

            Color OpaqueTileTileBackColor = Theme.GetColor(@"C1TileControl\Tiles\TileBackColor", Color.Transparent);
            Color OpaqueTileBackColor = Theme.GetColor(@"C1TileControl\Common\BackColor", Color.Transparent);
            Color OpaqueTileForeColor = Theme.GetColor(@"C1TileControl\Common\ForeColor", Color.Transparent);
            Color OpaqueTileCheckMarkColor = Theme.GetColor(@"C1TileControl\Tiles\CheckMarkColor", Color.Transparent);
            Color OpaqueTileCheckBorderColor = Theme.GetColor(@"C1TileControl\Tiles\CheckBorderColor", Color.Transparent);
            Color OpaqueTileHotBorderColor = Theme.GetColor(@"C1TileControl\Tiles\HotBorderColor", Color.Transparent);
            #endregion

            // Apply background containers adn controls to blend with form
            /* 
            TheExplorer.C1Logo.BackColor = newFormBackColor;
            TheExplorer.pnlHeaderTop.BackColor = newFormBackColor;*/
            Color staticBackColor = Color.FromArgb(255, 246, 246, 246);
            TheExplorer.C1Logo.BackColor = staticBackColor;
            TheExplorer.pnlHeaderTop.BackColor = staticBackColor;
            TheExplorer.pnlFooter.BackColor = staticBackColor;
            TheExplorer.pnlFooterLogo.BackColor = staticBackColor;
            TheExplorer.pnlInputPanel.BackColor = staticBackColor;

            TheExplorer.pnlLeftControls.BackColor = newFormBackColor;
            TheExplorer.pnlMainTopGutter.BackColor = newFormBackColor;
            TheExplorer.pnlMainGutter.BackColor = newFormBackColor;
            TheExplorer.pnlMainControls.BackColor = newFormBackColor;
            TheExplorer.pnlLeftSamples.BackColor = newFormBackColor;
            TheExplorer.pnlMainSamples.BackColor = newFormBackColor;
            TheExplorer._viewer.BackColor = newFormBackColor;

            TheExplorer.lblLeftDescriptionControls.BackColor = newFormBackColor;
            TheExplorer.lblNewControls.BackColor = newFormBackColor;
            TheExplorer.lblPopularControls.BackColor = newFormBackColor;
            TheExplorer.lblLeftDescriptionSamplesTitle.BackColor = newFormBackColor;
            TheExplorer.lblLeftDescriptionSamples.BackColor = newFormBackColor;
            TheExplorer.lblLeftSamplesListTitle.BackColor = newFormBackColor;
            TheExplorer.lblThemeLabel.BackColor = staticBackColor;

            TheExplorer.lblLeftDescriptionControls.ForeColor = newFormForeColor;
            TheExplorer.lblNewControls.ForeColor = newFormForeColor;
            TheExplorer.lblPopularControls.ForeColor = newFormForeColor;
            TheExplorer.lblLeftDescriptionSamplesTitle.ForeColor = newFormForeColor;
            TheExplorer.lblLeftDescriptionSamples.ForeColor = newFormForeColor;
            TheExplorer.lblLeftSamplesListTitle.ForeColor = newFormForeColor;
            TheExplorer.lblThemeLabel.ForeColor = SystemColors.ControlText;

            // Apply style to title labels
            if (newFont != null)
            {
                TheExplorer.lblFree.Font = new Font(newFont, FontStyle.Bold);
            }

            StyleInfo.LabelNormalBackColor = OpaqueTileTileBackColor;
            StyleInfo.LabelNormalForeColor = GetFarthestColor(OpaqueTileTileBackColor, new Color[] { OpaqueTileForeColor, OpaqueTileCheckMarkColor });

            StyleInfo.HoverLabelNormalBackColor = OpaqueTileCheckBorderColor;
            StyleInfo.HoverLabelNormalForeColor = GetFarthestColor(OpaqueTileCheckBorderColor, new Color[] { OpaqueTileHotBorderColor, OpaqueTileCheckMarkColor });

            foreach (Control sender in new Control[] { TheExplorer.lblAbout, TheExplorer.lblPricing, TheExplorer.lblSupport, TheExplorer.lblFree })
            {
                if ((sender as Label).Tag != null && (sender as Label).Tag.ToString() == "Highlight")
                {
                    (sender as Label).Parent.BackColor = StyleInfo.LabelHighlightBackColor;
                    (sender as Label).BackColor = StyleInfo.LabelHighlightBackColor;
                    (sender as Label).ForeColor = StyleInfo.LabelHighlightForeColor;
                }
                else
                {
                    (sender as Label).Parent.BackColor = StyleInfo.LabelNormalBackColor;
                    (sender as Label).BackColor = StyleInfo.LabelNormalBackColor;
                    (sender as Label).ForeColor = StyleInfo.LabelNormalForeColor;
                }
            }

            TheExplorer.pnlHeaderMid.BackColor = OpaqueTileTileBackColor == Color.Transparent ? TheExplorer.pnlHeaderMid.BackColor : OpaqueTileTileBackColor;
            TheExplorer.pnlHeaderMid.ForeColor = GetContrastForeground(TheExplorer.pnlHeaderMid.BackColor, OpaqueTileForeColor == Color.Transparent ? TheExplorer.pnlHeaderMid.ForeColor : OpaqueTileForeColor);

            TheExplorer.lblMainTitle.BackColor = OpaqueTileTileBackColor == Color.Transparent ? TheExplorer.lblMainTitle.BackColor : OpaqueTileTileBackColor;
            TheExplorer.lblMainTitle.ForeColor = GetContrastForeground(TheExplorer.lblMainTitle.BackColor, OpaqueTileForeColor == Color.Transparent ? TheExplorer.lblMainTitle.ForeColor : OpaqueTileForeColor);

            TheExplorer.pnlHeaderMidTitle.BackColor = OpaqueTileTileBackColor == Color.Transparent ? TheExplorer.pnlHeaderMidTitle.BackColor : OpaqueTileTileBackColor;
            TheExplorer.pnlHeaderMidTitle.ForeColor = GetContrastForeground(TheExplorer.pnlHeaderMidTitle.BackColor, OpaqueTileForeColor == Color.Transparent ? TheExplorer.pnlHeaderMidTitle.ForeColor : OpaqueTileForeColor);

            // Apply style to breadcrumb
            Color bccolor1 = OpaqueTileTileBackColor == Color.Transparent ? TheExplorer.pnlHeaderMid.BackColor : OpaqueTileTileBackColor;
            Color bcforecolor = GetContrastForeground(bccolor1, OpaqueTileForeColor == Color.Transparent ? TheExplorer.pnlHeaderMid.ForeColor : OpaqueTileForeColor);
            Color bccolor2 = OpaqueTileCheckBorderColor == Color.Transparent ? TheExplorer.breadCrumb.BackColor : OpaqueTileCheckBorderColor;
            Color bcforecolor2 = GetContrastForeground(bccolor2, OpaqueTileCheckMarkColor == Color.Transparent ? TheExplorer.breadCrumb.ForeColor : OpaqueTileCheckMarkColor);

            if (newFont != null)
            {
                TheExplorer.breadCrumb.Font = new Font(newFont.FontFamily, TheExplorer.breadCrumb.Font.Size);
            }

            TheExplorer.breadCrumb.BackColor = bccolor1;
            TheExplorer.breadCrumb.BackColor2 = bccolor2;
            TheExplorer.breadCrumb.ForeColor = bcforecolor; 
            TheExplorer.breadCrumb.ForeColor2 = bcforecolor2; 
            TheExplorer.breadCrumb.Parent.BackColor = newFormBackColor;

            // Apply style to feature stack
            Color fsHoverBackColor = OpaqueTileCheckBorderColor == Color.Transparent ? TheExplorer.featureStack.HoverBackColor : OpaqueTileCheckBorderColor;
            Color fsHoverForeColor = GetFarthestColor(fsHoverBackColor, new Color[] { TheExplorer.featureStack.HoverForeColor, OpaqueTileCheckMarkColor });
            Color fsSelectedBackColor = OpaqueTileCheckBorderColor == Color.Transparent ? TheExplorer.featureStack.SelectedBackColor : OpaqueTileCheckBorderColor;
            Color fsSelectedForeColor = GetFarthestColor(fsSelectedBackColor, new Color[] { TheExplorer.featureStack.SelectedForeColor, OpaqueTileCheckMarkColor });
            Color fsBackColor = newFormBackColor == Color.Transparent ? TheExplorer.featureStack.BackColor : newFormBackColor;
            Color fsForeColor = OpaqueTileCheckBorderColor == Color.Transparent ? TheExplorer.featureStack.ForeColor : OpaqueTileCheckBorderColor;
            fsForeColor = GetContrastForeground(fsBackColor, fsForeColor);

            TheExplorer.featureStack.HoverBackColor = fsHoverBackColor;
            TheExplorer.featureStack.HoverForeColor = fsHoverForeColor;

            TheExplorer.featureStack.SelectedBackColor = fsSelectedBackColor;
            TheExplorer.featureStack.SelectedForeColor = fsSelectedForeColor;
            
            TheExplorer.featureStack.BackColor = fsBackColor;
            TheExplorer.featureStack.ForeColor = fsForeColor;

            // Apply background to controlexpanders
            TheExplorer.cteGDM.BackColor = TheExplorer.cteIaE.BackColor 
                = TheExplorer.ctelDV.BackColor = TheExplorer.cteNaL.BackColor 
                = TheExplorer.cteRaD.BackColor = TheExplorer.cteSch.BackColor
                = TheExplorer.cteUtil.BackColor 
                = OpaqueTileTileBackColor == Color.Transparent ? TheExplorer.pnlHeaderMid.BackColor : OpaqueTileTileBackColor;

            // Apply foreground to controlexpanders
            TheExplorer.cteGDM.ForeColor = TheExplorer.cteIaE.ForeColor
                = TheExplorer.ctelDV.ForeColor = TheExplorer.cteNaL.ForeColor
                = TheExplorer.cteRaD.ForeColor = TheExplorer.cteSch.ForeColor
                = TheExplorer.cteUtil.ForeColor = GetContrastForeground(TheExplorer.cteUtil.BackColor, TheExplorer.tilesControlDV.ForeColor);
        }

        #region Color Utility

        public static Color GetFarthestColor(Color backColor, Color[] foreColors)
        {
            int c = Convert.ToInt16(backColor.R) + Convert.ToInt16(backColor.G) + Convert.ToInt16(backColor.B);
            Dictionary<Color, int> ColorDistance = new Dictionary<Color, int>();
            foreach(Color option in foreColors.Distinct())
            {
                int o = Convert.ToInt16(option.R) + Convert.ToInt16(option.G) + Convert.ToInt16(option.B);
                int val = (int)Math.Sqrt(Math.Pow(c - o, 2));
                ColorDistance.Add(option, val);
            }
            var tempColor = ColorDistance.Aggregate((c1, c2) => c1.Value > c2.Value ? c1 : c2).Key;
            return GetContrastForeground(backColor, tempColor); // more contrast if required
        }


        internal static Color GetContrastForeground(Color backColor, Color foreColor)
        {
            if (backColor.IsEmpty || backColor == Color.Transparent)
            {
                return DefaultForeColor;
            }
            double metric = GetColorMetric(backColor);

            // select contrast foreground
            if (foreColor.IsEmpty || foreColor == Color.Transparent)
            {
                // if ForeColor is not set, select automatically
                foreColor = metric >= 128 ? Color.Black : Color.White;
            }
            else
            {
                // check contrast for existing ForeColor
                double foreMetric = GetColorMetric(foreColor);
                if (metric >= 127)
                {
                    // light background
                    // should be dark foreground
                    if (foreMetric >= 128)
                    {
                        // change from light foreground 
                        int diff = Math.Max((byte)80, Math.Min(Math.Min((byte)128, foreColor.G), Math.Min(foreColor.R, foreColor.B)));
                        foreColor = Color.FromArgb(Math.Max(0, foreColor.R - diff), Math.Max(0, foreColor.G - diff), Math.Max(0, foreColor.B - diff));
                        foreMetric = GetColorMetric(foreColor);
                    }
                    if (Math.Abs(metric - foreMetric) < 128)
                    {
                        // need more contrast
                        int diff = Math.Max(60, 128 - (int)Math.Abs(metric - foreMetric));
                        foreColor = Color.FromArgb(Math.Max(0, foreColor.R - diff), Math.Max(0, foreColor.G - diff), Math.Max(0, foreColor.B - diff));
                    }
                }
                else
                {
                    // dark background
                    // should be light foreground
                    if (foreMetric < 128)
                    {
                        // change from dark foreground
                        int diff = Math.Max(80, Math.Min(Math.Min((int)128, 255 - foreColor.G), Math.Min(255 - foreColor.R, 255 - foreColor.B)));
                        foreColor = Color.FromArgb(Math.Min(255, foreColor.R + diff), Math.Min(255, foreColor.G + diff), Math.Min(255, foreColor.B + diff));
                        foreMetric = GetColorMetric(foreColor);
                    }
                    if (Math.Abs(metric - foreMetric) < 128)
                    {
                        // need more contrast
                        int diff = Math.Max(60, 128 - (int)Math.Abs(metric - foreMetric));
                        foreColor = Color.FromArgb(Math.Min(255, foreColor.R + diff), Math.Min(255, foreColor.G + diff), Math.Min(255, foreColor.B + diff));
                    }
                }
            }
            return foreColor;
        }

        private static double GetColorMetric(Color color)
        {
            return (color.R * 299 + color.G * 587 + color.B * 114) / 1000;
        }


        #endregion

        private void ThpThemePicker_ThemeApplying(object sender, ThemeApplyingEventArgs e)
        {
            e.Handled = true;
            ThemeName = e.ThemeName;

            try
            {
                LockWindowUpdate(Handle);
                ApplyTheme(this);
            }
            finally
            {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        internal static event EventHandler ThemeApplied;

        private static void OnThemeApplied(EventArgs e)
        {
            ThemeApplied?.Invoke(TheExplorer, e);
        }

        private static void LoadDefaultStyle()
        {
            TheExplorer.lblMainTitle.BackColor = StyleInfo.TitleBackColor;
            TheExplorer.pnlHeaderMidTitle.BackColor = StyleInfo.TitleBackColor;
            TheExplorer.pnlHeaderMid.BackColor = StyleInfo.TitleBackColor;
            TheExplorer.lblAbout.BackColor = StyleInfo.LabelNormalBackColor;
            TheExplorer.lblSupport.BackColor = StyleInfo.LabelNormalBackColor;
            TheExplorer.lblPricing.BackColor = StyleInfo.LabelNormalBackColor;
            TheExplorer.breadCrumb.BackColor = StyleInfo.BreadcrumbColor1;
            TheExplorer.breadCrumb.BackColor2 = StyleInfo.BreadcrumbColor2;
            TheExplorer.breadCrumb.ForeColor = StyleInfo.BreadcrumbForeColor;
            TheExplorer.breadCrumb.ForeColor2 = StyleInfo.BreadcrumbForeColor2;
            TheExplorer.lblLeftDescriptionSamples.ForeColor = StyleInfo.FeatureDescriptionForeColor;
            TheExplorer.featureStack.ForeColor = StyleInfo.FeatureListForeColor;
            TheExplorer.featureStack.BackColor = TheExplorer.featureStack.Parent.BackColor;
            TheExplorer.featureStack.SelectedForeColor = StyleInfo.FeatureListSelectedForeColor;
            TheExplorer.featureStack.SelectedBackColor = StyleInfo.FeatureListSelectedBackColor;
            TheExplorer.featureStack.HoverForeColor = StyleInfo.FeatureListHoverForeColor;
            TheExplorer.featureStack.HoverBackColor = StyleInfo.FeatureListHoverBackColor;
        }

        #endregion
        //===================================================================================//
        #region Events and Methods

        private void Explorer_Load(object sender, EventArgs e)
        {
            LoadDefaultString();
            LoadDefaultStyle();
            LoadControlTiles();

            // set initial theme
            thpThemePicker.SelectedItem = "Office365White";
        }

        private void LoadDefaultString()
        {
            lblLeftDescriptionControls.Text = StringInfo.SuiteDescription;
        }

        private void taskLabels_MouseEnter(object sender, EventArgs e)
        {
            if (thpThemePicker.SelectedIndex == -1)
            {
                if ((sender as Label).Tag != null && (sender as Label).Tag.ToString() == "Highlight")
                {
                    (sender as Label).Parent.BackColor = StyleInfo.HoverLabelHighlightBackColor;
                    (sender as Label).BackColor = StyleInfo.HoverLabelHighlightBackColor;
                    (sender as Label).ForeColor = StyleInfo.HoverLabelHighlightForeColor;
                }
                else
                {
                    (sender as Label).Parent.BackColor = StyleInfo.HoverLabelNormalBackColor;
                    (sender as Label).BackColor = StyleInfo.HoverLabelNormalBackColor;
                    (sender as Label).ForeColor = StyleInfo.HoverLabelNormalForeColor;
                }
            }
            else
            {
                if ((sender as Label).Tag != null && (sender as Label).Tag.ToString() == "Highlight")
                {
                    (sender as Label).Parent.BackColor = StyleInfo.HoverLabelHighlightBackColor;
                    (sender as Label).BackColor = StyleInfo.HoverLabelHighlightBackColor;
                    (sender as Label).ForeColor = StyleInfo.HoverLabelHighlightForeColor;
                }
                else
                {
                    (sender as Label).Parent.BackColor = StyleInfo.HoverLabelNormalBackColor;
                    (sender as Label).BackColor = StyleInfo.HoverLabelNormalBackColor;
                    (sender as Label).ForeColor = StyleInfo.HoverLabelNormalForeColor;
                }
            }

        }

        private void taskLabels_MouseLeave(object sender, EventArgs e)
        {
            if (thpThemePicker.SelectedIndex == -1)
            {
                if ((sender as Label).Tag != null && (sender as Label).Tag.ToString() == "Highlight")
                {
                    (sender as Label).Parent.BackColor = StyleInfo.LabelHighlightBackColor;
                    (sender as Label).BackColor = StyleInfo.LabelHighlightBackColor;
                    (sender as Label).ForeColor = StyleInfo.LabelHighlightForeColor;
                }
                else
                {
                    (sender as Label).Parent.BackColor = StyleInfo.LabelNormalBackColor;
                    (sender as Label).BackColor = StyleInfo.LabelNormalBackColor;
                    (sender as Label).ForeColor = StyleInfo.LabelNormalForeColor;
                }
            }
            else
            {
                if ((sender as Label).Tag != null && (sender as Label).Tag.ToString() == "Highlight")
                {
                    (sender as Label).Parent.BackColor = StyleInfo.LabelHighlightBackColor;
                    (sender as Label).BackColor = StyleInfo.LabelHighlightBackColor;
                    (sender as Label).ForeColor = StyleInfo.LabelHighlightForeColor;
                }
                else
                {
                    (sender as Label).Parent.BackColor = StyleInfo.LabelNormalBackColor;
                    (sender as Label).BackColor = StyleInfo.LabelNormalBackColor;
                    (sender as Label).ForeColor = StyleInfo.LabelNormalForeColor;
                }
            }
        }

        private void tiles_TileClicked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            var control = ControlInfo.Controls.First(ct => ct.Name == e.Tile.Text);
            if (control != null)
            {
                if (!string.IsNullOrEmpty(control.Link))
                {
                    // run standalone demo or demo installer
                    RunDemo(control.Link);
                    return;
                }
                //    TheExplorer.CurrentExplorerMode = ExplorerMode.Controls; // avoid setting sample visibility too early
                if (breadCrumb.Items.Count == 1)
                {
                    BreadCrumbItem item = breadCrumb.AddItem(control.Name);
                    item.Tag = ExplorerMode.Controls;
                    lblLeftDescriptionSamplesTitle.Text = control.Name;
                    SampleInfo newSample = null;
                    if (!string.IsNullOrEmpty(control.NewFeatureName))
                    {
                        // if there is new feature specified in xml, open it instead of first node
                        newSample = control.Find(control.NewFeatureName) as SampleInfo;
                    }
                    featureStack.loadSamples(control, newSample);
                }
            }
        }

        private void breadCrumb_ItemClicked(object sender, BreadCrumbEventArgs e)
        {
            breadCrumb.RemoveItemsAfter(e.BreadCrumbItem);
            if (e.BreadCrumbItem.Tag != null)
            {
                try
                {
                    switch ((ExplorerMode)e.BreadCrumbItem.Tag)
                    {
                        case ExplorerMode.Suite:
                            CurrentExplorerMode = ExplorerMode.Suite;
                            break;
                        case ExplorerMode.Controls:
                            featureStack.loadSamples(ControlInfo.Controls.First(c=>c.Name == e.BreadCrumbItem.Value));
                            break;
                        case ExplorerMode.Samples:
                            CurrentExplorerMode = ExplorerMode.Samples;
                            break;

                    }
                }
                catch { }
            }
        }

        private void featureStack_ItemClicked(object sender, Main.FeatureTreeEventArgs e)
        {
            loadSample(e.Sample);
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            switch ((sender as Label).Text.ToLower())
            {
                case "about":
                    System.Diagnostics.Process.Start(Links.About);
                    break;
                case "support":
                    System.Diagnostics.Process.Start(Links.Support);
                    break;
                case "pricing":
                    System.Diagnostics.Process.Start(Links.Pricing);
                    break;
                case "free trial":
                    System.Diagnostics.Process.Start(Links.Download);
                    break;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (tileLayoutCompleted)
            {
                UpdateTileLayout();
            }
        }

        #endregion
        //===================================================================================//
    }

    #region helper classes
    public enum ExplorerMode
    {
        Suite, Controls, Samples
    }

    public static class StyleInfo
    {
        public static readonly Dictionary<string, Font> FontSet = new Dictionary<string, Font>()
        {
            {"TaskbarTitle", new System.Drawing.Font("Segoe UI Semibold", 16, FontStyle.Regular, GraphicsUnit.Point) },
            {"TaskbarHighlight", new System.Drawing.Font("Segoe UI", 14, FontStyle.Bold, GraphicsUnit.Point) },
            {"Taskbar", new System.Drawing.Font("Segoe UI", 14, FontStyle.Regular, GraphicsUnit.Point) },
            {"Description", new System.Drawing.Font("Segoe UI", 12, FontStyle.Regular, GraphicsUnit.Point) },
            {"Popular", new System.Drawing.Font("Segoe UI Semibold", 14, FontStyle.Regular, GraphicsUnit.Point) }
        };

        public static Color TileBackColor = Color.FromArgb(82, 81, 80);
        public static Color TileHoverBackColor = Color.FromArgb(113, 113, 113);

        public static Color TitleBackColor = Color.FromArgb(114, 114, 114);

        public static Color HoverLabelHighlightBackColor = Color.FromArgb(253, 220, 160);
        public static Color HoverLabelNormalBackColor = Color.FromArgb(203, 204, 203);
        public static Color LabelHighlightBackColor = Color.FromArgb(251, 172, 24);
        public static Color LabelNormalBackColor = Color.FromArgb(114, 114, 114);
        public static Color HoverLabelHighlightForeColor = Color.White;
        public static Color HoverLabelNormalForeColor = Color.White;
        public static Color LabelHighlightForeColor = Color.White;
        public static Color LabelNormalForeColor = Color.White;

        public static Color BreadcrumbColor1 = Color.FromArgb(203, 204, 203);
        public static Color BreadcrumbColor2 = Color.FromArgb(162, 163, 162);
        public static Color BreadcrumbForeColor = Color.White;
        public static Color BreadcrumbForeColor2 = Color.White;

        public static Color FeatureDescriptionForeColor = Color.FromArgb(113, 113, 113);
        public static Color FeatureTitleForeColor = Color.FromArgb(87, 87, 87);
        public static Color FeatureListForeColor = Color.FromArgb(87, 87, 87);
        public static Color FeatureListBackColor = Color.Transparent;
        public static Color FeatureListSelectedBackColor = Color.FromArgb(162, 162, 162);
        public static Color FeatureListSelectedForeColor = Color.FromArgb(87, 87, 87);
        public static Color FeatureListHoverBackColor = Color.FromArgb(162, 162, 162);
        public static Color FeatureListHoverForeColor = Color.FromArgb(87, 87, 87);

        public static readonly Dictionary<string, Image> ControlIcons = new Dictionary<string, Image>()
        {
            {"Barcode", Properties.Resources.ci_Barcode },
            {"Chart", Properties.Resources.ci_Chart},
            {"FlexChart", Properties.Resources.ci_FlexChart},
            {"FinancialChart", Properties.Resources.ci_FinancialChart},
            {"Data Collection", Properties.Resources.ci_DataCollection},
            {"DockingTab", Properties.Resources.ci_DockingTab},
            {"DynamicHelp", Properties.Resources.ci_DynamicHelp},
            {"Editor", Properties.Resources.ci_Editor},
            {"Excel", Properties.Resources.ci_Excel},
            {"FlexGrid", Properties.Resources.ci_FlexGrid},
            {"FlexPivot", Properties.Resources.ci_FlexPivot},
            {"FlexReport", Properties.Resources.ci_FlexReport},
            {"GanttView", Properties.Resources.ci_GanttView},
            {"Gauges", Properties.Resources.ci_Gauge},
            {"Input", Properties.Resources.ci_Input},
            {"InputPanel", Properties.Resources.ci_InputPanel},
            {"List", Properties.Resources.ci_List},
            {"Maps", Properties.Resources.ci_Map},
            {"MultiSelect", Properties.Resources.ci_MultiSelect },
            {"PDF", Properties.Resources.ci_PDF},
            {"Ribbon", Properties.Resources.ci_Ribbon},
            {"Rules Manager", Properties.Resources.ci_RulesManager},
            {"Scheduler", Properties.Resources.ci_Scheduler},
            {"Sizer", Properties.Resources.ci_Sizer},
            {"Sparkline", Properties.Resources.ci_Sparkline},
            {"SpellChecker", Properties.Resources.ci_SpellChecker},
            {"SplitContainer", Properties.Resources.ci_SplitContainer},
            {"SuperTooltip", Properties.Resources.ci_SuperTooltip},
            {"Themes", Properties.Resources.ci_Themes},
            {"TileControl", Properties.Resources.ci_TileControl},
            {"Toolbars", Properties.Resources.ci_Toolbars},
            {"TreeView", Properties.Resources.ci_TreeView},
            {"True DBGrid", Properties.Resources.ci_TrueDBGrid},
            {"Win Pack", Properties.Resources.ci_Win7Pack},
            {"Word", Properties.Resources.ci_Word},
            {"Calendar View", Properties.Resources.ci_CalendarView},
            {"PdfSource", Properties.Resources.ci_PdfSource},
            {"FlexViewer", Properties.Resources.ci_FlexViewer},
            {"Expressions", Properties.Resources.ci_ExpressionEditor},
            {"Dashboard", Properties.Resources.ci_DashboardLayout},
            {"Data Filters", Properties.Resources.ci_DataFilter},
            {"Calc Engine", Properties.Resources.ci_CalcEngine},
            {"Bitmap", Properties.Resources.ci_Bitmap },
            {"Printing", Properties.Resources.ci_Report }
     };
    }

    public static class StringInfo
    {
        public static string SuiteDescription = "Over 80 .NET Windows Forms controls, including the ones you can't get anywhere else.\n\nComponentOne Studio® WinForms Edition controls come packed with smart, code-free designers, endless built-in features, superior flexibility, and the outstanding assurance that these controls will stand the test of time.";
    }

  /*  public class DemoForm
    {
        string _form;
        string _desc;
        string _name;

        public DemoForm(string form, string desc)
        {
            _form = form;
            _desc = desc;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FormName
        {
            get { return _form; }
            set { _form = value; }
        }

        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }

    }*/

    public static class WindowHelper
    {
        public static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            if (IsIconic(handle))
            {
                ShowWindow(handle, SW_RESTORE);
            }

            SetForegroundWindow(handle);
        }

        const int SW_RESTORE = 9;

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);
    }
    #endregion
}
