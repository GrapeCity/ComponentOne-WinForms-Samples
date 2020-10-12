using System;
using System.Collections.Generic;
using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;

namespace ControlExplorer.FlexGrid
{
    public partial class CustomTheme : C1DemoForm
    {
        private const string _themePath = @"Resources\CustomThemes\Office2016FlexGridExcelLike.c1themez";

        public CustomTheme()
        {
            IsThemeable = false; // don't apply application theme
            InitializeComponent();            
        }        

        private void CustomTheme_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = DemoDataSource("Products");

            // load and apply custom theme
            C1Theme customTheme = new C1Theme();
            customTheme.Load(_themePath);
            customTheme.ApplyThemeToControlTree(this);  
        }
    }
}
