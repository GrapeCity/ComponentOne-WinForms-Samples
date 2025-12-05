using C1.Win.Themes;
using C1.Win.Ribbon;
namespace MapSample
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            C1ThemeController.ApplyThemeToControlTree(this, C1ThemeController.GetThemeByName("Office365White", false), null, true);

        }
    }
}
