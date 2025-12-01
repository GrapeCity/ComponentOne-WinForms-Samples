using Custom_Localization.Events;
using Custom_Localization.Services;
using Custom_Localization.UserControls.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Custom_Localization.Pages
{
    public partial class HomePage : UserControl
    {
        private CustomLocalizationService _customLocalizationSerivice;
        public HomePage()
        {
            _customLocalizationSerivice = new CustomLocalizationService();
            InitializeComponent();

            //c1Schedule1.BorderStyle = BorderStyle.None;
            c1Schedule1.Padding = new Padding(10, 10, 10, 10);

            // For getting all the Culture Code
            cultureDisplayControl1.CustomAddedCulture = _customLocalizationSerivice.GetCustomCultures();
            cultureDisplayControl1.PreDefinedCulture = _customLocalizationSerivice.GetPreSupportedCultures();
            cultureDisplayControl1.SelectedCultureChanged += CultureDisplayControl1_SelectedCultureChanged;
            cultureDisplayControl1.IsOverrideCultureVisible = true;
            cultureDisplayControl1.OverrideCultures = _customLocalizationSerivice.GetOverridenCultures();


            CultureManager.CultureChanged += CultureManager_CultureChanged;

        }

        private void CultureManager_CultureChanged(object? sender, EventArgs e)
        {
            RefreshCultures();
        }

        private void CultureDisplayControl1_SelectedCultureChanged(object? sender, CultureChangedEventArgs e)
        {
            var cultureInfo = e.Culture as CultureInfo;
            if (cultureInfo != null)
            {
                CultureManager.ChangeCulture(cultureInfo);
                c1Schedule1.CalendarInfo.CultureInfo = cultureInfo;
            }
        }

        private void RefreshCultures()
        {
            cultureDisplayControl1.PreDefinedCultureHeaderText = Resources.PreviewPage_ViewCulturePane_PreSupportedCultures_Label_Text;
            cultureDisplayControl1.CustomAddedCultureHeaderText = Resources.PreviewPage_ViewCulturePane_CustomAddedCultures_Label_Text;
            cultureDisplayControl1.OverrideCultureHeaderText = Resources.PreviewPage_ViewCulturePane_OveridenCultures_Label_Text;
            availiableCultures.Text = Resources.PreviewPage_ViewCulturesPane_Label_Text;
            ScheduleLabel.Text = Resources.PreviewPage_ComponentOneControlPane_Label_Text;
        }
    }
}
