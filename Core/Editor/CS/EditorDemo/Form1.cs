using C1.Win.Editor;
using C1.Win.Editor.Ribbon;
using C1.Win.Ribbon;
using C1.Win.Themes;
using System;
using System.Windows.Forms;

namespace EditorDemo
{
    public partial class Form1 : C1RibbonForm
    {
        private const string _noTheme = "(No Theme)";
        private readonly RibbonComboBox? _themeBox;

        public Form1()
        {
            InitializeComponent();

            // Add theme combobox to the ribbon.
            _themeBox = new RibbonComboBox();
            _themeBox.TextAreaWidth = 200;
            _themeBox.SelectedIndexChanged += _themeBox_SelectedIndexChanged;

            _themeBox.Items.Clear();
            string[] themes = C1ThemeController.GetThemes();
            _themeBox.Items.Add(_noTheme);
            foreach (string t in themes)
                _themeBox.Items.Add(t);
            _themeBox.SelectedIndex = 0;

            var toolbar = c1EditorRibbon1.RibbonControl.TopToolBar;
            toolbar.Items.Add(_themeBox);
        }

        private void _themeBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Change theme.
            if (_themeBox is not null)
            {
                var theme = C1ThemeController.GetThemeByName(_themeBox.SelectedItem.Text, false);
                if (theme is null)
                    C1ThemeController.ApplyThemeToControlTree(this, null);
                else
                    theme.ApplyThemeToControlTree(this);
            }
        }

        private void c1Editor1_C1EditorReady(object sender, EventArgs e)
        {
            // Load document.
            c1Editor1.LoadDocument(GetDocument());

            // Sets built in default style.
            c1Editor1.SetDefaultStyles(null);
        }
        private string GetDocument()
        {
            return "file:///" + Application.StartupPath.Replace('\\', '/') + @"/Resources/SmallTestFile.html";
        }
    }
}