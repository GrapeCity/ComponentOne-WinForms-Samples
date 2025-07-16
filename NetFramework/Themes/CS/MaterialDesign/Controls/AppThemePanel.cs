using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Themes;
using System.ComponentModel;

namespace MaterialDesign.Controls
{
    public partial class AppThemePanel : UserControl, IThemeable, ISupportInitialize
    {
        #region Fields
        private bool _initialized;
        #endregion Fields

        public AppThemePanel()
        {
            InitializeComponent();

            c1ColorPicker1.ColorChanged += C1ColorPicker1_ColorChanged;
            c1ColorPicker2.ColorChanged += C1ColorPicker2_ColorChanged;
        }

        #region Events
        public event EventHandler AccentColorChanged;
        private void OnAccentColorChanged() => AccentColorChanged?.Invoke(this, EventArgs.Empty);
        #endregion Events    

        #region Properties
        public Color PrimaryColor
        {
            get { return c1ColorPicker1.Color; }
            set { c1ColorPicker1.Color = value; }
        }

        public Color SecondaryColor
        {
            get { return c1ColorPicker2.Color; }
            set { c1ColorPicker2.Color = value; }
        }

        private SampleHelper Helper => SampleHelper.Instance;
        #endregion Properties

        #region Handlers
        private void C1ColorPicker2_ColorChanged(object sender, EventArgs e)
        {
            if (_initialized)
                OnAccentColorChanged();
        }
        private void C1ColorPicker1_ColorChanged(object sender, EventArgs e)
        {
            if (_initialized)
                OnAccentColorChanged();
        }
        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                c1ComboBox1.CloseDropDown();
                SampleHelper.Instance.Theme = c1ComboBox1.SelectedIndex == 1 ? "MaterialDark" : "Material";
            }
        }
        #endregion Handlers

        #region ISupportInitialize
        public void BeginInit() => _initialized = false;

        public void EndInit() => _initialized = true;
        #endregion ISupportInitialize

        #region IThemeable
        void IThemeable.ThemeChanged()
        {
            C1ThemeController.ApplyThemeToControlTree(this, Helper.C1Theme);
            Font = new Font(Font.FontFamily, 12);
            c1Label1.Font = new Font(c1Label1.Font.FontFamily, 20);

            c1ComboBox1.SelectedIndex = SampleHelper.Instance.Theme == "Material" ? 0 : 1;
            C1MaterialThemeSettings settings = Helper.C1Theme.GetSettings() as C1MaterialThemeSettings;
            if (settings != null)
            {
                c1ColorPicker1.Color = settings.PrimaryColor;
                c1ColorPicker2.Color = settings.SecondaryColor;
            }
        }
        #endregion IThemeable
    }
}
