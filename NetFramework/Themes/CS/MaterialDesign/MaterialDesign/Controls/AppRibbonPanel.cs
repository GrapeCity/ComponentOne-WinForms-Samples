using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Themes;
using System.ComponentModel;

namespace MaterialDesign.Controls
{
    public partial class AppRibbonPanel : UserControl, IThemeable
    {         
        public AppRibbonPanel()
        {
            InitializeComponent();

            c1CheckBox1.CheckedChanged += OnRibbonHeaderChanged;
            c1CheckBox2.CheckedChanged += OnRibbonTabsChanged;
            c1CheckBox3.CheckedChanged += OnRibbonQATChanged;
        }

        public event EventHandler HeaderRowVisibilityChanged;
        public event EventHandler TabsVisibilityChanged;
        public event EventHandler QATVisibilityChanged;

        public bool IsHeaderRowVisible => c1CheckBox1.Checked;
        public bool IsTabsVisible => c1CheckBox2.Checked;
        public bool IsQATVisible => c1CheckBox3.Checked;

        private void OnRibbonQATChanged(object sender, EventArgs e) => QATVisibilityChanged?.Invoke(sender, e);

        private void OnRibbonTabsChanged(object sender, EventArgs e) => TabsVisibilityChanged?.Invoke(sender, e);

        private void OnRibbonHeaderChanged(object sender, EventArgs e) => HeaderRowVisibilityChanged?.Invoke(sender, e);

        private SampleHelper Helper => SampleHelper.Instance;

        #region IThemeable
        void IThemeable.ThemeChanged()
        {
            C1ThemeController.ApplyThemeToControlTree(this, Helper.C1Theme);
            Font = new Font(Font.FontFamily, 12);

            c1Label1.Font = new Font(c1Label1.Font.FontFamily, 16);
        }
        #endregion IThemeable
    }
}
