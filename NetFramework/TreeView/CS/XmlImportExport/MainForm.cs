using C1.Win.Themes;
using C1.Win.Ribbon;
using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace XmlImportExport
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Xml File | *.xml",
                InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources"),
                FileName = "SimpleTree.xml"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        c1TreeView1.ReadXml(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "C1TreeView can't import from xml file.");
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Xml File | *.xml",
                FileName = "C1TreeView.xml"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        c1TreeView1.WriteXml(saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "C1TreeView can't export to xml file.");
                    }
                }
            }
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365White");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion
    }
}
