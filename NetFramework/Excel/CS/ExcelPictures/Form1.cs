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
using System.Diagnostics;

using C1.Excel;

namespace ExcelPictures
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

            // three methods add images to Excel file
            XLPictureShape picture;

            // create images
            Metafile metafile = (Metafile)Metafile.FromStream(GetManifestResource("meta.emf"));
            Image spbImage = Image.FromStream(GetManifestResource("spb.jpg"));
            Image canadaImage = Image.FromStream(GetManifestResource("canada.bmp"));
            Image googleImage = Image.FromStream(GetManifestResource("google.bmp"));
            Image babyImage = Image.FromStream(GetManifestResource("baby.png"));

            /////////////////////////////////////////////////////////
            // List "Images" -- three methods add images
            /////////////////////////////////////////////////////////
            XLSheet sheet = wb.Sheets[0];
            sheet.Name = "Images";
            sheet.PrintSettings.Header = "&LCanada:&G&D&CHeader Center&R&P";
            sheet.PrintSettings.Footer = "&C&Z";


            // first method
            picture = new XLPictureShape(googleImage, 0, 0, 2200, 5000);
            picture.DashedLineStyle = XLShapeDashedLineStyle.Solid;
            picture.LineStyle = XLShapeLineStyle.Simple;
            picture.LineColor = Color.BlueViolet;
            picture.Rotation = 90.0f;
            picture.LineWidth = 10;
            sheet[1, 7].Value = picture;
            sheet[1, 1].Value = metafile;

            // second method
            picture = new XLPictureShape(spbImage, 100, 3000, 8000, 6000);
            //picture = new XLPictureShape(canadaImage);
            picture.Brightness = .55f;
            picture.Contrast = .5f;
            sheet.Shapes.Add(picture);

            picture = new XLPictureShape(canadaImage);
            picture.LineColor = Color.Aqua;
            picture.LineWidth = 100;
            sheet.PrintSettings.HeaderPictureLeft = picture;

            // third method
            picture = new XLPictureShape(babyImage);
            picture.Rotation = 30.0f;
            picture.LineColor = Color.Aqua;
            picture.LineWidth = 100;
            sheet[15, 2].Value = picture;

            // header or footer image
            //picture = new XLPictureShape(spbImage);
            //picture.Rotation = 45.0f;               // for header or footer ignored
            //picture.LineColor = Color.Blue;
            //picture.LineWidth = 50;
            //picture.Brightness = 0.4f;
            //sheet.PrintSettings.HeaderPictureCenter = picture;

            /////////////////////////////////////////////////////////
            // List "Types" -- support image types (bmp, png, jpg, emf)
            /////////////////////////////////////////////////////////
            sheet = wb.Sheets.Add("Types");
            sheet[1, 0].Value = "Bmp:";
            sheet[1, 1].Value = googleImage;
            sheet[8, 0].Value = "Png:";
            sheet[8, 1].Value = babyImage;
            sheet[25, 0].Value = "Jpeg:";
            sheet[25, 1].Value = spbImage;
            sheet[34, 0].Value = "Emf:";
            sheet[34, 1].Value = metafile;

            /////////////////////////////////////////////////////////
            // List "Borders" -- various picture borders
            /////////////////////////////////////////////////////////
            sheet = wb.Sheets.Add("Borders");
            int row = 1, col = 0;
            foreach (XLShapeLineStyle style in Enum.GetValues(typeof(XLShapeLineStyle)))
            {
                col = 1;
                sheet.Rows[row].Height = 3700;

                foreach (XLShapeDashedLineStyle dashedStyle in Enum.GetValues(typeof(XLShapeDashedLineStyle)))
                {
                    sheet.Columns[col].Width = 2300;
                    picture = new XLPictureShape(babyImage);
                    picture.LineWidth = 100;
                    picture.LineColor = Color.FromArgb(100, 200, Math.Min(col * 12, 255));
                    picture.DashedLineStyle = dashedStyle;
                    picture.LineStyle = style;
                    sheet[row, col].Value = picture;
                    sheet[row + 1, col].Value = "style: " + style.ToString();
                    sheet[row + 2, col].Value = "dashed: " + dashedStyle.ToString();

                    col += 2;
                }

                row += 4;
            }

            /////////////////////////////////////////////////////////
            // List "Alignment" -- position image using ContentAlignment
            /////////////////////////////////////////////////////////
            sheet = wb.Sheets.Add("Alignment");
            row = 1;
            sheet.Columns[1].Width = sheet.Columns[4].Width = 6000;
            sheet.Columns[7].Width = sheet.Columns[10].Width = 2000;
            foreach (XLAlignHorz horizontalAlignment in Enum.GetValues(typeof(XLAlignHorz)))
            {
                foreach (XLAlignVert verticalAlignment in Enum.GetValues(typeof(XLAlignVert)))
                {
                    sheet.Rows[row].Height = 2400;

                    Size cellSize = new Size(sheet.Columns[1].Width, sheet.Rows[row].Height);
                    picture = new XLPictureShape(googleImage, cellSize, horizontalAlignment, verticalAlignment, ImageScaling.Clip);
                    sheet[row, 1].Value = picture;
                    sheet[row, 2].Value = $"clip: {horizontalAlignment} {verticalAlignment}";

                    picture = new XLPictureShape(googleImage, cellSize, horizontalAlignment, verticalAlignment, ImageScaling.Scale);
                    sheet[row, 4].Value = picture;
                    sheet[row, 5].Value = $"scale: {horizontalAlignment} {verticalAlignment}";

                    row += 4;
                }
            }

            /////////////////////////////////////////////////////////
            // List "Properties" -- various picture properties
            /////////////////////////////////////////////////////////
            sheet = wb.Sheets.Add("Properties");

            // associating hyperlink with the shape
            sheet.Rows[1].Height = 2000;
            sheet.Columns[1].Width = 3600;
            picture = new XLPictureShape(spbImage);
            picture.Hyperlink = "http://www.spb.ru/";
            sheet[1, 1].Value = picture;
            sheet[2, 1].Value = "hyperlink (click on the picture)";

            // others view type
            col = 1;
            sheet.Rows[4].Height = 2000;
            foreach (XLPictureViewType viewType in Enum.GetValues(typeof(XLPictureViewType)))
            {
                sheet.Columns[col].Width = 3600;
                picture = new XLPictureShape(spbImage);
                picture.ViewType = viewType;
                sheet[4, col].Value = picture;
                sheet[5, col].Value = "view type: " + viewType.ToString(); ;

                col += 2;
            }

            // brightness & contrast
            col = 1;
            sheet.Rows[7].Height = sheet.Rows[10].Height = 2000;
            for (int i = 0; i <= 100; i += 10)
            {
                sheet.Columns[col].Width = 3600;
                picture = new XLPictureShape(spbImage);
                picture.Brightness = (float)i / 100;
                sheet[7, col].Value = picture;
                sheet[8, col].Value = string.Format("brightness: {0}", picture.Brightness);

                picture = new XLPictureShape(spbImage);
                picture.Contrast = (float)i / 100;
                sheet[10, col].Value = picture;
                sheet[11, col].Value = string.Format("contrast: {0}", picture.Contrast);

                col += 2;
            }

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