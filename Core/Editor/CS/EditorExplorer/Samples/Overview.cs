using System;
using System.Windows.Forms;
using System.IO;
using C1.Win.Editor;
using C1.Win.Editor.Ribbon;
using C1.Win.Ribbon;
using C1.Win.Themes;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.WinForms;

namespace EditorExplorer.Samples
{
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();
            RibbonTheming.AddTheming(c1EditorRibbon1);
            c1Editor1.C1EditorReady += c1Editor1_C1EditorReady;
            c1Editor1.ClientSizeChanged += C1Editor1_Resize;
            c1Editor1.SizeChanged += C1Editor1_Resize;
        }
        private void C1Editor1_Resize(object sender, EventArgs e)
        {
            c1Editor1.Focus();
        }

        private async void c1Editor1_C1EditorReady(object sender, EventArgs e)
        {
            string filename = @"Resources\tesla.html";
            if (File.Exists(filename))
            {
                await c1Editor1.LoadDocumentAsync(Path.GetFullPath(filename));
                c1Editor1.SetDefaultStyles(null, true);
            }
        }

        private class RibbonTheming
        {
            private readonly RibbonComboBox themeBox;
            public RibbonTheming(C1EditorRibbon editorRibbon)
            {
                // Add theme combobox to the ribbon.
                themeBox = new RibbonComboBox();
                themeBox.TextAreaWidth = 200;
                themeBox.SelectedIndexChanged += (o, e) =>
                {
                    if (themeBox is not null)
                    {
                        var theme = C1ThemeController.GetThemeByName(themeBox.SelectedItem.Text, false);
                        if (theme is null)
                            C1ThemeController.ApplyThemeToControlTree(editorRibbon.Parent, null);
                        else
                            theme.ApplyThemeToControlTree(editorRibbon.Parent);
                    }
                };

                themeBox.Items.Clear();
                string[] themes = C1ThemeController.GetThemes();
                themeBox.Items.Add("(No Theme)");
                foreach (string t in themes)
                    themeBox.Items.Add(t);
                themeBox.SelectedIndex = themeBox.Items.IndexOf("Office365White");

                var toolbar = editorRibbon.TopToolBar;
                toolbar.Visible = true;
                toolbar.Items.Add(themeBox);
            }

            public static void AddTheming(C1EditorRibbon editorRibbon)
            {
                new RibbonTheming(editorRibbon);
            }
        }
    }
}
