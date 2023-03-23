using System.Drawing;
using C1.Win.C1Ribbon;

namespace MaterialDesign.Controls
{
    public partial class About : C1RibbonForm, IThemeable
    {
        public About()
        {
            InitializeComponent();

            string[] lines = new string[]
            {
                "The interactive Material Theme Designer allows you to select primary and accent colors for Material theme.",
                "",
                "Use Theme tab in application menu to customize material theme settings. Save the resulting theme to reuse it in your application."
            };
            c1TextBox1.Lines = lines;
        }

        #region IThemeable
        void IThemeable.ThemeChanged()
        {
            C1.Win.C1Themes.C1ThemeController.ApplyThemeToControlTree(this, SampleHelper.Instance.C1Theme);
            c1Label1.Font = new Font(c1Label1.Font.FontFamily, 16);            
        }
        #endregion IThemeable
    }
}
