using Custom_Localization.Events;
using Custom_Localization.Pages;
using Custom_Localization.Services;
using Custom_Localization.UserControls.Events;
using System.Globalization;

namespace Custom_Localization
{
    public partial class Form1 : Form
    {
        UserControl homePage = new HomePage();
        UserControl resorucePage = new ViewResourceFilePage();
        UserControl _activePage = null;

        public Form1()
        {
            InitializeComponent();

            // sets the inidial page/default page to the HomePage
            _activePage = new HomePage();
            ShowPage();

            // Sets the cultures and current Texts
            RefreshCultures();

            CultureManager.CultureChanged += CultureManager_CultureChanged; 
        }

        private void CultureManager_CultureChanged(object? sender, EventArgs e)
        {
            RefreshCultures();
        }

        private void ShowPage()
        {
            hostPanel.Controls.Clear();
            _activePage.Dock = DockStyle.Fill;
            hostPanel.Controls.Add(_activePage);
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            if (_activePage == null) return;

            if (_activePage != resorucePage)
            {
                _activePage = resorucePage;
                c1Button1.Text = Resources.Form_TopNavigationBar_ToggleButton_PreviewLabel_Text;
                ShowPage();
            }
            else if (_activePage != homePage)
            {
                _activePage = homePage;
                c1Button1.Text = Resources.Form_TopNavigationBar_ToggleButton_ViewSourceLabel_Text;
                ShowPage();
            }
        }

        private void RefreshCultures()
        {
            c1Button1.Text = Resources.Form_TopNavigationBar_ToggleButton_ViewSourceLabel_Text;
            SampleHeaderTitle.Text = Resources.Form_TopNavigationBar_Heading_Title_Text;
            ComponentOneHeaderTitle.Text = Resources.Form_TopNavigationBar_Heading_ComponentOneTitle_Text;
            TitleBarHeaderBreak.Text = Resources.Form_TopNavigationBar_Heading_Title_VerticalBar;
        }
    }
}
