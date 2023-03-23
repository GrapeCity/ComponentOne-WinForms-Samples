using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Themes;
using C1.Win.C1Ribbon;
using MaterialDesign.Controls;

namespace MaterialDesign
{
    public partial class Form1 : C1RibbonForm, IThemeable
    {
        #region Fields
        private bool _updating;
        private About _about;
        private AppRibbonPanel _appRibbonPanel;
        private AppThemePanel _appThemePanel;
        #endregion Fields

        #region Ctor
        public Form1()
        {
            InitializeComponent();

            // create the Theme tab of the application menu
            _appThemePanel = new AppThemePanel();
            appTheme.Control = _appThemePanel;
            appTheme.ID = appTheme.Text;

            // create the Ribbon tab of the application menu
            _appRibbonPanel = new AppRibbonPanel();
            appRibbon.Control = _appRibbonPanel;
            appRibbon.ID = appRibbon.Text;            
        }
        #endregion Ctor

        #region Private        
        private SampleHelper Helper => SampleHelper.Instance;

        private void Init()
        {
            // initialize controls
            flexPie1.Init();
            flexChart1.Init();
            flexChart2.Init();
            c1FlexGrid1.Init();

            c1Ribbon1.Minimized = true;

            SubscribeEvents();

            Helper.Theme = "Material";
        }

        // subscribes to events
        private void SubscribeEvents()
        {
            Helper.ThemeChanged += Helper_ThemeChanged;
            _appThemePanel.AccentColorChanged += _appThemePanel_AccentColorChanged;
            _appRibbonPanel.HeaderRowVisibilityChanged += C_HeaderRowVisibilityChanged;
            _appRibbonPanel.TabsVisibilityChanged += C_TabsVisibilityChanged;
            _appRibbonPanel.QATVisibilityChanged += C_QATVisibilityChanged;
            ribbonColorPicker1.SelectedColorChanged += RibbonColorPicker_SelectedColorChanged;
            ribbonColorPicker2.SelectedColorChanged += RibbonColorPicker_SelectedColorChanged;
        }

        // sets accent color to the current Theme and applies Theme to the controls
        private void SetAccentColors(Color primary, Color secondary)
        {
            if (!_updating)
            {
                _updating = true;

                // get C1Theme
                C1Theme theme = Helper.C1Theme;
                // Create C1ThemeSettings containing the desired theme settings
                C1MaterialThemeSettings settings = new C1MaterialThemeSettings() { PrimaryColor = primary, SecondaryColor = secondary };
                // Apply settings to the C1Theme
                theme.ApplySettings(settings);
                // Apply new Theme to the controls
                ((IThemeable)this).ThemeChanged();

                _updating = false;
            }
        }
        #endregion Private

        #region Handlers
        private void Form1_Load(object sender, EventArgs e) => Init();

        private void C_QATVisibilityChanged(object sender, EventArgs e) => 
            c1Ribbon1.Qat.Visible = _appRibbonPanel.IsQATVisible;

        private void C_TabsVisibilityChanged(object sender, EventArgs e) => 
            c1Ribbon1.Tabs[0].Visible = _appRibbonPanel.IsTabsVisible;

        private void C_HeaderRowVisibilityChanged(object sender, EventArgs e) => 
            c1Ribbon1.HideTabHeaderRow = !_appRibbonPanel.IsHeaderRowVisible;

        private void RibbonColorPicker_SelectedColorChanged(object sender, EventArgs e) =>
            SetAccentColors(ribbonColorPicker1.Color, ribbonColorPicker2.Color);

        private void _appThemePanel_AccentColorChanged(object sender, EventArgs e) =>
            SetAccentColors(_appThemePanel.PrimaryColor, _appThemePanel.SecondaryColor);

        private void ribbonToggleTemplate_PressedChanged(object sender, EventArgs e) =>
            SampleHelper.Instance.Theme = ribbonToggleLight.Pressed ? "Material" : "MaterialDark";

        private void appExit_Click(object sender, EventArgs e) => Close();

        private void ribbonApplicationMenu1_DropDown(object sender, EventArgs e) => 
            appTheme.Selected = true;

        private void Helper_ThemeChanged(object sender, EventArgs e) =>
            ((IThemeable)this).ThemeChanged();

        // saves current theme to the specified file with the settings applied
        private void appSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Helper.C1Theme.Name = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                Helper.C1Theme.Save(saveFileDialog1.FileName);
            }
        }
        // loads theme from the specified  file.
        private void appLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                C1Theme theme = new C1Theme();
                theme.Load(openFileDialog1.FileName);
                Helper.SetTheme(theme);
            }
        }
        // shows about sample form
        private void ribbonBtnAbout_Click(object sender, EventArgs e)
        {
            if (_about == null)
            {
                _about = new About();
                ((IThemeable)_about).ThemeChanged();
            }
            _about.ShowDialog(this);
        }
        #endregion Handlers

        #region IThemeable
        // Applies current C1Theme to the controls
        void IThemeable.ThemeChanged()
        {
            _updating = true;
            LockWindowUpdate(Handle);

            ribbonToggleLight.Pressed = SampleHelper.Instance.Theme == "Material";
            C1MaterialThemeSettings settings = Helper.C1Theme.GetSettings() as C1MaterialThemeSettings;
            if (settings != null)
            {
                ribbonColorPicker1.DefaultColor = ribbonColorPicker1.Color = settings.PrimaryColor;
                ribbonColorPicker2.DefaultColor = ribbonColorPicker2.Color = settings.SecondaryColor;
            }
            C1ThemeController.ApplyThemeToControlTree(this, Helper.C1Theme);

            ((IThemeable)_appThemePanel).ThemeChanged();
            ((IThemeable)_appRibbonPanel).ThemeChanged();
            ((IThemeable)flexChart1).ThemeChanged();
            ((IThemeable)flexChart2).ThemeChanged();
            ((IThemeable)c1FlexGrid1).ThemeChanged();
            ((IThemeable)formDemo1).ThemeChanged();
            ((IThemeable)_about)?.ThemeChanged();

            LockWindowUpdate(IntPtr.Zero);
            _updating = false;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion IThemeable
    }
}
