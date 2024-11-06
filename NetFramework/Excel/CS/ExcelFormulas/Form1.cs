using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using System.Diagnostics;

using C1.Excel;

namespace ExcelFormulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save(C1XLBook wb)
        {
            if (wb != null)
            {
                string path = Path.Combine(Application.StartupPath, "test.xls");
                if (cbOpenXml.Checked) path += "x";
                if (_radioDialog.Checked)
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = GetFilter(cbOpenXml.Checked);
                    dlg.Title = "Save As MS Excel File";
                    dlg.OverwritePrompt = true;
                    dlg.RestoreDirectory = true;
                    DialogResult dr = dlg.ShowDialog();
                    if (dr != DialogResult.OK)
                        return;
                    path = dlg.FileName;
                }

                wb.Save(path);

                if (_cbPreview.Checked)
                {
                    try { Process.Start(path); }
                    catch { }
                }
            }
        }

        public C1XLBook CreateSample()
        {
            // create C1XLBook
            C1XLBook wb = new C1XLBook();

            XLSheet ws = wb.Sheets[0];

            // column width in twips
            ws.Columns[0].Width = 2000;
            ws.Columns[1].Width = 2200;

            // string formulas
            string s = "String:";
            ws[0, 0].Value = s;
            ws[1, 0].Value = s;
            ws[2, 0].Value = s;

            ws[0, 1].Value = "apples";
            ws[1, 1].Value = "and";
            ws[2, 1].Value = "oranges";

            s = "String formula:";
            ws[4, 0].Value = s;
            ws[5, 0].Value = s;

            ws[4, 1].Value = "apples and oranges";
            ws[5, 1].Value = "apples an";
            ws[4, 1].Formula = "CONCATENATE(B1,\" \",B2, \" \",B3)";
            ws[5, 1].Formula = "LEFT(B5,9)";

            // simple formulas
            ws[7, 0].Value = "Formula: 5!";
            ws[7, 1].Value = 120;
            ws[7, 1].Formula = "1*2*3*4*5";

            ws[8, 0].Value = "Formula: 12/0";
            ws[8, 1].Value = 0;
            ws[8, 1].Formula = "12/0";

            ws[9, 0].Value = "Formula: 1 = 1";
            ws[9, 1].Value = true;
            ws[9, 1].Formula = "1=1";

            ws[10, 0].Value = "Formula: 1 = 2";
            ws[10, 1].Value = false;
            ws[10, 1].Formula = "1 = 2";

            // now function
            ws[12, 0].Value = "Formula: Now()";
            ws[12, 1].Value = DateTime.Now;
            ws[12, 1].Formula = "Now()";

            XLStyle style = new XLStyle(wb);
            DateTimeFormatInfo dtfi = CultureInfo.CurrentCulture.DateTimeFormat;
            style.Format = XLStyle.FormatDotNetToXL(dtfi.ShortDatePattern + " " + dtfi.ShortTimePattern);
            ws[12, 1].Style = style;

            // done
            return wb;
        }

        private void _btCreate_Click(object sender, EventArgs e)
        {
            Save(CreateSample());
        }

        internal static string GetFilter(bool write)
        {
            StringBuilder sb = new StringBuilder();
            if (write)
                sb.Append("Open XML MS Excel file (*.xlsx)|*.xlsx|");
            sb.Append("Binary MS Excel file (*.xls)|*.xls");
            return sb.ToString();
        }
        public static Stream GetManifestResource(string resource)
        {
            resource = resource.ToLower();
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (string res in a.GetManifestResourceNames())
            {
                if (res.ToLower().EndsWith(resource))
                    return a.GetManifestResourceStream(res);
            }
            return null;
        }
    }
}