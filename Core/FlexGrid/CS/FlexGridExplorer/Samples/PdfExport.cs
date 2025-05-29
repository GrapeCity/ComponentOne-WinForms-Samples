using C1.Win.FlexGrid;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
using C1.Win.Pdf;
using FlexGridExplorer.Data;
using System.Collections;
using System.IO;

namespace FlexGridExplorer.Samples
{
    public partial class PdfExport : UserControl
    {

        private Hashtable tempFiles = null;
        protected static string TEMP_DIR = System.Environment.GetEnvironmentVariable("tmp");

        public PdfExport()
        {
            InitializeComponent();
        }

        private void PdfExport_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = DataSource.GetRows("SELECT * FROM customers");
        }

        public string GetFullFileName(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            if (tempFiles == null)
                tempFiles = new Hashtable();

            if (!tempFiles.Contains(fileName))
            {
                string tempFile = TEMP_DIR + "\\" + fileName;
                tempFiles.Add(fileName, tempFile);
            }

            return tempFiles[fileName].ToString();
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            // get rows/cols per page
            int rpp = 10;
            int cpp = 3;
            try
            {
                rpp = int.Parse(NumericEditRow.Text);
                cpp = int.Parse(NumericEditCol.Text);
            }
            catch { }

            // mark grid with row/column breaks
            for (int r = c1FlexGrid1.Rows.Fixed; r < c1FlexGrid1.Rows.Count; r++)
            {
                c1FlexGrid1.Rows[r].UserData = (r % rpp == 0)
                    ? "*"
                    : null;
            }
            for (int c = c1FlexGrid1.Cols.Fixed; c < c1FlexGrid1.Cols.Count; c++)
            {
                c1FlexGrid1.Cols[c].UserData = (c % cpp == 0)
                    ? "*"
                    : null;
            }

            // print the grid using the specified page/column breaks
            FlexPdfCreator pdfCreator = new FlexPdfCreator(c1FlexGrid1);
            string fileName = GetFullFileName("flex.pdf");
            pdfCreator.Save(fileName);
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void NumericEditRow_ValueChanged(object sender, EventArgs e)
        {
            int newValue = Convert.ToInt32(NumericEditRow.Value);

            // Ensure the value is greater than 0
            if (newValue <= 0)
            {
                newValue = 1;  // Set to a default positive value (e.g., 1)
                NumericEditRow.Value = newValue; // Reset the control value
            }
        }

        private void NumericEditCol_ValueChanged(object sender, EventArgs e)
        {
            int newValue = Convert.ToInt32(NumericEditCol.Value);

            // Ensure the value is greater than 0
            if (newValue <= 0)
            {
                newValue = 1;  // Set to a default positive value (e.g., 1)
                NumericEditCol.Value = newValue; // Reset the control value
            }
        }
    }

    /// <summary>
    /// FlexPdfCreator
    /// 
    /// Renders a C1FlexGrid using specified row and column breaks into a pdf file.
    /// 
    /// The row and column breaks are specified by setting the Row.UserData
    /// (or Column.UserData) to an asterisk.
    /// 
    /// </summary>
    public class FlexPdfCreator
    {
        // ** fields
        private List<Image> _images;
        private float _zoom;

        // ** ctor
        public FlexPdfCreator(C1FlexGrid flex)
        {
            // initialize zoom factor
            _zoom = 1;

            // create page images
            _images = new List<Image>();

            // initialize
            int r1, c1, r2, c2;

            // loop through columns looking for breaks
            c1 = c2 = flex.Cols.Fixed;
            for (int c = flex.Cols.Fixed; c < flex.Cols.Count; c++)
            {
                // check if this is a column break
                if (c == flex.Cols.Count - 1 ||
                    (flex.Cols[c].UserData != null && flex.Cols[c].UserData.ToString() == "*"))
                {
                    // found break, column range is c1-c
                    c2 = c;

                    // loop through rows looking for breaks
                    r1 = r2 = flex.Rows.Fixed;
                    for (int r = flex.Rows.Fixed; r < flex.Rows.Count; r++)
                    {
                        // look for next row break
                        if (r == flex.Rows.Count - 1 ||
                            (flex.Rows[r].UserData != null && flex.Rows[r].UserData.ToString() == "*"))
                        {
                            // found break, row range is r1-r
                            r2 = r;

                            // create image
                            _images.Add(flex.CreateImage(r1, c1, r2, c2));

                            // update row range
                            r1 = r + 1;
                        }
                    }

                    // update column range
                    c1 = c + 1;
                }
            }
        }

        // ** event handlers
        public void Save(string fileName)
        {
            // create new pdf document
            var pdf = new C1PdfDocument();

            // add pages to document
            for (int page = 0; page < _images.Count; page++)
            {
                DrawPageImage(pdf, page);
            }

            // done
            pdf.Save(fileName);
        }

        private void DrawPageImage(C1.Win.Pdf.C1PdfDocument pdf, int index)
        {
            // get image bounds
            RectangleF rcBounds = pdf.PageRectangle;
            rcBounds.Inflate(-72, -72);

            // calculate zoom factor
            if (index == 0)
            {
                // get size of largest image
                SizeF szMax = Size.Empty;
                foreach (Image page in _images)
                {
                    szMax.Height = Math.Max(szMax.Height, page.Height);
                    szMax.Width = Math.Max(szMax.Width, page.Width);
                }

                // get size of page bounds
                SizeF szPage = rcBounds.Size;

                // calculate zoom so largest image doesn't overflow the page
                _zoom = 1;
                float zh = szPage.Width / szMax.Width;
                float zv = szPage.Height / szMax.Height;
                if (zh < 1 || zv < 1)
                    _zoom = Math.Min(zh, zv);
            }

            // draw grid image
            var rc = rcBounds;
            Image img = _images[index] as Image;
            rc.Width = (int)(img.Width * _zoom);
            rc.Height = (int)(img.Height * _zoom);
            if (index > 0) pdf.NewPage();
            pdf.DrawImage(img, rc);
        }
    }
}
