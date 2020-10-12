using System;
using System.Windows.Forms;
using C1.Win.Layout;
using C1.Win.C1Ribbon;

namespace DashboardDemo
{
    public partial class MainForm : Controls.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            ToolIconAppearance = c1DashboardLayout1.Options.ToolIconAppearance;
            LayoutType = c1DashboardLayout1.LayoutType;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // content Initialization
            Init();
            labelSales.Init();
            flexPie1.Init();
            flexChart1.Init();
            c1FlexGrid1.Init();
            c1TrueDBGrid1.Init();

            // save default dashboard layout
            c1DashboardLayout1.SaveLayout(Helper.DefaultLayoutPath);
        }

        // Called when one of the apply layout RibbonMenuButton is clicked.
        private void MainForm_ApplyLayoutClicked(object sender, Controls.FilePathEventArgs e)
        {
            // load dashboard layout
            c1DashboardLayout1.LoadLayout(e.FilePath);
            // content processing
            CenterLabelPosition();
        }
        // Called when one of the LyoutType RibbonToggleButton is pressed.
        private void MainForm_LayoutTypeChanged(object sender, Controls.LayoutTypeEventArgs e)
        {
            // change layout type (flow/grid/split)
            c1DashboardLayout1.LayoutType = e.Type;
            // content processing
            CenterLabelPosition();
        }
        // Called when reset layout RibbonMenuButton is clicked.
        private void MainForm_ResetLayoutClicked(object sender, Controls.FilePathEventArgs e)
        {
            // reset dashboard layout to default
            c1DashboardLayout1.LoadLayout(e.FilePath);
            // content processing
            CenterLabelPosition();
        }
        // Called when save layout RibbonMenuButton is clicked.
        private void MainForm_SaveLayoutClicked(object sender, Controls.FilePathEventArgs e)
        {
            // save dashboard layout
            c1DashboardLayout1.SaveLayout(e.FilePath);
        }
        // Called when ItemIndex of ToolIcon RibbonComboBox is changed.
        private void MainForm_ToolIconAppearanceChanged(object sender, Controls.ToolIconAppearanceEventArgs e)
        {
            c1DashboardLayout1.Options.ToolIconAppearance = e.ToolIconAppearance;
        }

        #region Content Processing
        private SampleHelper Helper => SampleHelper.Instance;

        // Apply theme
        private void MainForm_DemoThemeChanged(object sender, C1.Win.C1Themes.ThemeEventArgs e)
        {
            switch (e.ThemeName)
            {
                case "None":
                    // reset theme
                    c1ThemeController1.Theme = null;
                    RibbonVisualStyle = VisualStyle.Office2007Blue;
                    Helper.Theme = null;
                    break;
                default:
                    c1ThemeController1.Theme = e.ThemeName;
                    Helper.Theme = e.ThemeName;
                    break;
            }
        }

        // center label position for split layout
        private void c1SplitterPanel5_Resize(object sender, EventArgs e) => Helper.CenterPosition(sender as Control, labelSales);

        // center label position for grid layout
        private void panel7_Resize(object sender, EventArgs e) => Helper.CenterPosition(sender as Control, labelSales);

        // center label position for flow layout
        private void panel8_Resize(object sender, EventArgs e) => Helper.CenterPosition(sender as Control, labelSales);

        // center label position after LayoutType changed
        private void CenterLabelPosition()
        {
            switch (c1DashboardLayout1.LayoutType)
            {
                case LayoutType.Flow:
                    Helper.CenterPosition(panel8, labelSales);
                    break;
                case LayoutType.Grid:
                    Helper.CenterPosition(panel7, labelSales);
                    break;
                case LayoutType.Split:
                    Helper.CenterPosition(c1SplitterPanel5, labelSales);
                    break;
            }
        }
        #endregion Content Processing
    }
}
