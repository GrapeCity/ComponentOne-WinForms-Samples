using C1.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSizeColumns
{
    public partial class Form1 : Form
    {
        private C1.Excel.C1XLBook c1XLBook1;

        public Form1()
        {
            InitializeComponent();
            c1XLBook1 = new C1.Excel.C1XLBook();

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            // clear book
            c1XLBook1.Clear();

            // add some styles
            XLStyle s1 = new XLStyle(c1XLBook1);
            XLStyle s2 = new XLStyle(c1XLBook1);
            XLStyle s3 = new XLStyle(c1XLBook1);
            s1.Format = "#,##0.00000";
            s2.Format = "#,##0.00000";
            s2.Font = new XLFont("Courier New", 14);
            s3.Format = "dd-MMM-yy";

            // populate sheet with some random values
            C1.Excel.XLSheet sheet = c1XLBook1.Sheets[0];
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                sheet[i, 0].Value = r.NextDouble() * 100000;
                sheet[i, 0].Style = (i % 13 == 0) ? s2 : s1;
            }
            for (int i = 0; i < 100; i++)
            {
                sheet[i, 1].Value = new DateTime(2005, r.Next(1, 12), r.Next(1, 28));
                sheet[i, 1].Style = s3;
            }

            string tempdir = Application.ExecutablePath.Substring(0,
                Application.ExecutablePath.LastIndexOf("\\") + 1);

            // save with default column widths
            c1XLBook1.Save(tempdir + @"defaultWidth.xls");

            // autosize columns
            AutoSizeColumns(sheet);

            // save again after autosizing
            c1XLBook1.Save(tempdir + @"autoSized.xls");

            // show the autosized version
            System.Diagnostics.Process.Start(tempdir + @"autoSized.xls");
        }
        private void AutoSizeColumns(XLSheet sheet)
        {
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                for (int c = 0; c < sheet.Columns.Count; c++)
                {
                    int colWidth = -1;
                    for (int r = 0; r < sheet.Rows.Count; r++)
                    {
                        object value = sheet[r, c].Value;
                        if (value != null)
                        {
                            // get value (unformatted at this point)
                            string text = value.ToString();

                            // format value if cell has a style with format set
                            C1.Excel.XLStyle s = sheet[r, c].Style;
                            if (s != null && s.Format.Length > 0 && value is IFormattable)
                            {
                                string fmt = XLStyle.FormatXLToDotNet(s.Format);
                                text = ((IFormattable)value).ToString(fmt, CultureInfo.CurrentCulture);
                            }

                            // get font (default or style)
                            Font font = ConvertXLFont(sheet.Book.DefaultFont);
                            if (s != null && s.Font != null)
                            {
                                font = ConvertXLFont(s.Font);
                            }

                            // measure string (add a little tolerance)
                            Size sz = Size.Ceiling(g.MeasureString(text + "XX", font));

                            // keep widest so far
                            if (sz.Width > colWidth)
                                colWidth = sz.Width;
                        }
                    }

                    // done measuring, set column width
                    if (colWidth > -1)
                        sheet.Columns[c].Width = C1XLBook.PixelsToTwips(colWidth);
                }
            }
        }

        Font ConvertXLFont(XLFont font)
        {
            FontStyle fs = FontStyle.Regular;
            if (font.Bold) fs |= FontStyle.Bold;
            if (font.Italic) fs |= FontStyle.Italic;
            if (font.Strikeout) fs |= FontStyle.Strikeout;
            if (font.Underline != XLUnderlineStyle.None) fs |= FontStyle.Underline;
            return new Font(font.FontName, font.FontSize, fs);
        }
    }


}
