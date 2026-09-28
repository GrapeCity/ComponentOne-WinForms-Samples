using System;
using System.Collections.Generic;
using C1.Win.FlexGrid;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridShowcase
{

    // todo:
    // * use Ribbon & RibbonForm
    // * follow mock up https://xd.adobe.com/view/39af2b73-85cd-41ce-4b18-82821e0eb4f4-4f9e/
    // * add licensing
    // * add code comments and readme
    // * data taken from here: $/Rhino/Main/Wijmo5Mvc/Samples/CS/ASPNETCore/MvcExplorer/src/MvcExplorer/Models, see whether we need something more
    // ** - should we use CustomerSale instead?
    // * if we don't have something from mock up for the first version, write some todo doc for the future
    // * ask someone to check it on HDPI machine

    public partial class Form1 : C1.Win.Ribbon.C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitExportButtons();
            cbDataSize.SelectedIndex = 0;
            InitThemes();
        }

        #region ** Data
        private void cbDataSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // todo: 
            // * add more options
            // * do something with different column count?
            int rows = cbDataSize.SelectedIndex == 0 ? 10 : 100;
            if (c1FlexGrid1.DataSource == null || ((IList<Sale>)c1FlexGrid1.DataSource).Count != rows)
            {
                var list = Sale.GetData(rows);

                // bind the grid 
                c1FlexGrid1.DataSource = list;
            }
        }
        #endregion

        #region ** Export

        private void InitExportButtons()
        {
            AddExportButton("Excel", exportToExcel_Click);
            AddExportButton("CSV", exportToCsv_Click);
            AddExportButton("PDF", exportToPdf_Click);
        }

        private void AddExportButton(string text, EventHandler clickHandler)
        {
            var button = new C1.Win.Ribbon.RibbonButton
            {
                Text = text
            };
            button.Click += clickHandler;
            ribbonGroup2.Items.Add(button);
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            ExportGrid("xls", "Untitled.xls", FileFormatEnum.Excel);
        }

        private void exportToCsv_Click(object sender, EventArgs e)
        {
            ExportGrid(
                "csv",
                "Untitled.csv",
                FileFormatEnum.TextComma,
                FileFlags.None,
                Encoding.UTF8);
        }

        private void ExportGrid(
            string extension,
            string fileName,
            FileFormatEnum format,
            FileFlags flags = FileFlags.None,
            Encoding encoding = null)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = extension;
                dlg.FileName = fileName;
                dlg.InitialDirectory = Application.StartupPath;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    c1FlexGrid1.SaveGrid(dlg.FileName, format, flags, encoding);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exportToPdf_Click(object sender, EventArgs e)
        {
            try
            {
                var printDocument = c1FlexGrid1.PrintParameters.PrintDocument;
                printDocument.DocumentName = "Export to PDF";
                printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                if (!printDocument.PrinterSettings.IsValid)
                {
                    MessageBox.Show("Microsoft Print to PDF is not available. Please enable it to export to PDF.");
                    return;
                }

                // Print document into Microsoft PDF printer
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region ** Themes

        private void InitThemes()
        {
            var themes = C1.Win.Themes.C1ThemeController.GetThemes();
            foreach (var s in themes)
            {
                if (s.Contains("Office365") || s.Contains("Material"))
                    cbTheme.Items.Add(s);
            }
            cbTheme.SelectedIndex = cbTheme.Items.IndexOf("Office365Green");
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1.Win.Themes.C1ThemeController.ApplicationTheme = cbTheme.SelectedItem.Text;
        }

        #endregion
    }
}
