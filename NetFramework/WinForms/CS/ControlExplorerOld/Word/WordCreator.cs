using System;
using System.IO;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Data;
using C1.C1Word;
using C1.C1Word.Objects;

namespace ControlExplorer.Word
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class WordCreator : C1DemoForm
    {
        private string _format;

        public WordCreator()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
#if DEBUG
            _comboFormat.SelectedIndex = 1;
            _format = ".rtf";
#else
            _comboFormat.SelectedIndex = 0;
            _format = ".docx";
#endif
        }

        private void btSimple_Click(object sender, System.EventArgs e)
        {
            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Simple sample";
            _statusBar.Text = "Creating document...";

            Font font = new Font("Tahoma", 24, FontStyle.Italic);
            c1Word.AddParagraph("Hello World!", font, Color.Blue);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "simple.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _tbPicture_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Gif (*.gif)|*.gif|Png (*.png)|*.png|Jpeg (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|Windows metafile (*.wmf)|*.wmf|All files (*.*)|*.*";
            dlg.FilterIndex = 6;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Show any picture sample";
            _statusBar.Text = "Creating document...";

            Font font = new Font("Arial", 14, FontStyle.Bold);
            c1Word.AddParagraph("Picture:", font, Color.Chocolate);

            Image img;
            string ext = Path.GetExtension(dlg.FileName);
            if (ext == ".wmf" || ext == ".emf")
            {
                img = Metafile.FromFile(dlg.FileName);
            }
            else
            {
                img = new Bitmap(dlg.FileName);
            }
            c1Word.AddPicture(img, RtfHorizontalAlignment.Left);

            c1Word.LineBreak();

            font = new Font("Arial", 10, FontStyle.Regular);
            c1Word.AddParagraph(dlg.FileName, font, Color.Blue);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "picture.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _btTable_Click(object sender, System.EventArgs e)
        {
            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Sample with tables";
            _statusBar.Text = "Creating document...";

            int rows = 4;
            int cols = 2;
            RtfTable table = new RtfTable(rows, cols);
            c1Word.Add(table);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    RtfParagraph paragraph = new RtfParagraph();
                    paragraph.Content.Add(new RtfString(string.Format("table cell {0}:{1}.", row, col)));
                    table.Rows[row].Cells[col].Content.Add(paragraph);
                }
            }

            Font font = new Font("Arial", 10, FontStyle.Regular);
            c1Word.AddParagraph("Simple table.", font, Color.Blue);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "table.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _btComplex_Click(object sender, System.EventArgs e)
        {
            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Complex sample";
            _statusBar.Text = "Creating document...";

            // add title
            c1Word.AddParagraph(c1Word.Info.Title, new Font("Tahoma", 24, FontStyle.Italic), Color.BlueViolet);

            // add image
            c1Word.AddParagraph("picture:", new Font("Courier New", 9, FontStyle.Regular), Color.Black);
            Bitmap img = new Bitmap(GetManifestResource("picture.jpg"));
            c1Word.AddPicture(img, RtfHorizontalAlignment.Center);

            // add table
            c1Word.LineBreak();
            int rows = 7;
            int cols = 2;
            RtfTable table = new RtfTable(rows, cols);
            c1Word.Add(table);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    RtfParagraph paragraph = new RtfParagraph();
                    paragraph.Content.Add(new RtfString(string.Format("table cell {0}:{1}.", row, col)));
                    table.Rows[row].Cells[col].Content.Add(paragraph);
                }
            }

            // add graphics
            c1Word.LineBreak();
            c1Word.DrawLine(Pens.Green, 200, 90, 400, 90);

            var rc = new RectangleF(150, 170, 90, 40);
            using (Pen pen = new Pen(Brushes.Blue, 5.0f))
            {
                c1Word.DrawRectangle(pen, rc);
            }
            c1Word.FillRectangle(Color.Gold, rc);
            c1Word.ShapeFillOpacity(50);
            c1Word.ShapeRotation(25);

            rc = new RectangleF(300, 120, 80, 80);
            c1Word.DrawEllipse(Pens.Red, rc);
            c1Word.FillEllipse(Color.Pink, rc);
            c1Word.ShapeFillOpacity(70);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "complex.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _btFonts_Click(object sender, System.EventArgs e)
        {
            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "All Fonts";
            _statusBar.Text = "Creating document...";

            // add title
            c1Word.AddParagraph(c1Word.Info.Title, new Font("Tahoma", 24, FontStyle.Bold), Color.Black);

            // draw text in many fonts
            Font font = new Font("Tahoma", 9);
            InstalledFontCollection ifc = new InstalledFontCollection();
            foreach (FontFamily ff in ifc.Families)
            {
                // create font
                Font sample = null;
                foreach (FontStyle fs in Enum.GetValues(typeof(FontStyle)))
                {
                    if (ff.IsStyleAvailable(fs))
                    {
                        sample = new Font(ff.Name, 9, fs);
                        break;
                    }
                }
                if (sample == null)
                    continue;

                // show font
                c1Word.AddParagraph(ff.Name, font, Color.Black);
                c1Word.AddParagraph("The quick brown fox jumped over the lazy dog. 1234567890!", sample, Color.Black);
                sample.Dispose();
                // TODO: add split bar or line

                // TODO: add new page if necessary
                //				c1Word.PageBreak();
            }

            // save and show document
            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "fonts.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _btGraphics_Click(object sender, System.EventArgs e)
        {
            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Graphics primitives sample";
            _statusBar.Text = "Creating document...";

            RectangleF rc = new RectangleF(250, 100, 200, 200);
            Bitmap image = new Bitmap(GetManifestResource("Word.picture.jpg"));
            c1Word.DrawImage(image, rc);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            rc = new RectangleF(250, 100, 150, 20);
            Font font = new Font("Arial", 14, FontStyle.Italic);
            c1Word.DrawString(c1Word.Info.Title, font, Color.DeepPink, rc, sf);

            c1Word.DrawLine(Pens.Green, 200, 190, 400, 190);

            rc = new RectangleF(150, 150, 190, 80);
            using (Pen pen = new Pen(Brushes.Blue, 5.0f))
            {
                c1Word.DrawRectangle(pen, rc);
            }
            c1Word.FillRectangle(Color.Gold, rc);
            c1Word.ShapeFillOpacity(50);
            c1Word.ShapeRotation(25);

            rc = new RectangleF(300, 150, 80, 80);
            c1Word.DrawEllipse(Pens.Red, rc);
            c1Word.FillEllipse(Color.Pink, rc);
            c1Word.ShapeFillOpacity(70);

            PointF[] pts = new PointF[4];
            pts[0] = new PointF(200, 200);
            pts[1] = new PointF(250, 300);
            pts[2] = new PointF(330, 250);
            pts[3] = new PointF(340, 140);
            c1Word.DrawPolyline(Pens.BlueViolet, pts);

            sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Far;
            sf.FormatFlags |= StringFormatFlags.DirectionVertical;
            rc = new RectangleF(450, 150, 25, 75);
            font = new Font("Verdana", 12, FontStyle.Bold);
            c1Word.DrawString("Vertical", font, Color.Black, rc, sf);

            pts = new PointF[4];
            pts[0] = new PointF(372, 174);
            pts[1] = new PointF(325, 174);
            pts[2] = new PointF(325, 281);
            pts[3] = new PointF(269, 281);
            c1Word.DrawBeziers(Pens.HotPink, pts);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "graphics.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _btMetafile_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Extended metafile (*.emf)|*.emf|Windows metafile (*.wmf)|*.wmf|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Convert metafile to RTF example";
            _statusBar.Text = "Creating document...";

            Image img;
            string ext = Path.GetExtension(dlg.FileName);
            if (ext == ".wmf" || ext == ".emf")
            {
                img = Metafile.FromFile(dlg.FileName);
            }
            else
            {
                throw new FormatException("Not metafile.");
            }
            c1Word.DrawMetafile((Metafile)img);

            c1Word.PageBreak();

            c1Word.AddPicture(img, RtfHorizontalAlignment.Left);

            c1Word.LineBreak();

            Font font = new Font("Arial", 10, FontStyle.Regular);
            c1Word.AddParagraph(dlg.FileName, font, Color.Black);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "metafile.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _btCurve_Click(object sender, System.EventArgs e)
        {
            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Various curves sample";
            _statusBar.Text = "Creating document...";

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            RectangleF rc = new RectangleF(250, 100, 150, 20);
            Font font = new Font("Tachoma", 12, FontStyle.Italic | FontStyle.Underline);
            c1Word.DrawString("Curves sample", font, Color.Black, rc, sf);

            //// curve
            //PointF[] pts = new PointF[7];
            //pts[0] = new PointF(191.1f, 172.3f);
            //pts[1] = new PointF(229.1f, 205.3f);
            //pts[2] = new PointF(267.15f, 238.3f);
            //pts[3] = new PointF(296.4f, 235.3f);
            //pts[4] = new PointF(325.65f, 232.3f);
            //pts[5] = new PointF(346.1f, 193.3f);
            //pts[6] = new PointF(366.6f, 154.3f);
            //c1Word.DrawBeziers(Pens.HotPink, pts);

            //// pie
            //rc = new RectangleF(120, 100, 150, 80);
            //c1Word.FillPie(Brushes.Yellow, rc, 0, 90);
            //c1Word.DrawPie(Pens.Indigo, rc, 0, 90);

            // arc
            rc = new RectangleF(120, 100, 150, 80);
            c1Word.DrawArc(Pens.Red, rc, 0, 90);

            //// arc
            //rc = new RectangleF(320, 300, 90, 45);
            //c1Word.DrawArc(Pens.Blue, rc, 270, 90);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "curves.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        private void _btRead_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = GetFileFilter();
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // create document
            C1WordDocument c1Word = new C1WordDocument();
            _statusBar.Text = "Loading RTF document...";
            c1Word.Load(dlg.FileName);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "reading.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        string GetFileFilter()
        {
            if (_format.Equals(".rtf"))
                return "RTF files (*.rtf)|*.rtf|MS Word (Open XML) files (*.docx)|*.docx";
            return "MS Word (Open XML) files (*.docx)|*.docx|RTF files (*.rtf)|*.rtf";
        }
        string GetFileName(C1WordDocument c1Word, string fileName)
        {
            c1Word.Info.Author = "C1WordCreator";
            c1Word.Info.Company = "GrapeCity";

            if (_format.Equals(".rtf"))
            {
                return Path.GetDirectoryName(Application.ExecutablePath) + '\\' + fileName;
            }

            if (_check2007.Checked)
            {
                c1Word.ShapesWord2007Compatible = true;
            }

            return Path.GetDirectoryName(Application.ExecutablePath) + '\\' + Path.GetFileNameWithoutExtension(fileName) + _format;
        }
        private static Stream GetManifestResource(string resource)
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

        private void _comboFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = _comboFormat.Text.ToUpper();
            if (text.Contains("DOCX"))
                _format = ".docx";
            else
                _format = ".rtf";
        }
    }
}
