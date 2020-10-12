using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.C1Pdf;

namespace ControlExplorer.PDF
{
    public partial class PdfAcroform : C1DemoForm
    {
        private int _textBoxCount;
        private int _checkBoxCount;
        private int _radioButtonCount;
        private int _pushButtonCount;
        private int _comboBoxCount;
        private int _listBoxCount;
        private int _rowCount;

        public PdfAcroform()
        {
            InitializeComponent();
        }

        private void Acroform_Load(object sender, EventArgs e)
        {
            // create pdf document
            _c1pdf.Clear();
            _c1pdf.DocumentInfo.Title = "PDF Acroform";

            // calculate page rect (discounting margins)
            RectangleF rcPage = GetPageRect();
            RectangleF rc = rcPage;


            // add title
            Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
            rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);

            // render Employees table
            rc = RenderTable(rc, rcPage);

            // Render Buttons
            Font btnFont = new Font("Tahoma", 14, FontStyle.Bold);
            PdfPushButton button1 = RenderPushButton("Submit", btnFont, new RectangleF(new PointF(rc.X, rc.Y + 10), new SizeF(90, 25)), ButtonLayout.TextLeftImageRight);
            button1.Actions.LostFocus.Add(new PdfPushButton.Action(ButtonAction.GotoPage, "Bmark"));
            button1.BorderStyle = FieldBorderStyle.Inset;
            button1.BorderWidth = FieldBorderWidth.Medium;
            button1.BorderColor = Color.Black;

            PdfPushButton button2 = RenderPushButton("Clear Fields", btnFont, new RectangleF(new PointF(rc.X + 110, rc.Y + 10), new SizeF(110, 25)), ButtonLayout.TextLeftImageRight);
            button2.Actions.Pressed.Add(new PdfPushButton.Action(ButtonAction.ClearFields));
            button2.BorderStyle = FieldBorderStyle.Dashed;
            button2.BorderWidth = FieldBorderWidth.Medium;
            button2.BorderColor = Color.Black;

            // second pass to number pages
            AddFooters();

            // save to file and show it
            // save pdf file
            string filename = GetTempFileName(".pdf");
            //_c1pdf.Compression = CompressionLevel.NoCompression;
            _c1pdf.Save(filename);

            // display it
            webBrowser1.Navigate(filename);

        }

        private RectangleF RenderTable(RectangleF rc, RectangleF rcPage)
        {
            // get data
            DataTable dt = DemoDataSource("Employees");
            //  select fonts
            Font hdrFont = new Font("Tahoma", 12, FontStyle.Bold);
            Font txtFont = new Font("Tahoma", 10);

            // build table
            rc = RenderParagraph("NorthWind Employees", hdrFont, rcPage, rc, false);

            // build table
            rc = RenderTableHeader(hdrFont, rc, new string[] { "TextBoxes", "RadioButtons", "CheckBoxes", "ComboBoxes", "ListBoxes" });
            foreach (DataRow dr in dt.Rows)
                rc = RenderTableRow(txtFont, hdrFont, rcPage, rc, dr);

            // done
            return rc;
        }

        private RectangleF RenderTableHeader(Font font, RectangleF rc, string[] fields)
        {
            // calculate cell width (same for all columns)
            RectangleF rcCell = rc;
            rcCell.Width = rc.Width / fields.Length;
            rcCell.Height = 0;

            //  calculate cell height (max of all columns)
            foreach (string field in fields)
            {
                float height = _c1pdf.MeasureString(field, font, rcCell.Width).Height;
                rcCell.Height = Math.Max(rcCell.Height, height);
            }

            // render header cells
            foreach (string field in fields)
            {
                _c1pdf.FillRectangle(Brushes.Black, rcCell);
                _c1pdf.DrawString(field, font, Brushes.White, rcCell);
                rcCell.Offset(rcCell.Width, 0);
            }

            // update rectangle and return it
            rc.Offset(0, rcCell.Height);
            return rc;
        }

        private RectangleF RenderTableRow(Font font, Font hdrFont, RectangleF rcPage, RectangleF rc, DataRow dr)
        {
            _rowCount += 1;
            RectangleF rcCell = rc;
            rcCell.Height = 100;

            // break page if we have to
            if (rcCell.Bottom > rcPage.Bottom)
            {
                _c1pdf.NewPage();
                rc = RenderTableHeader(hdrFont, rcPage, new string[] { "TextBoxes", "RadioButtons", "CheckBoxes", "ComboBoxes", "ListBoxes" });
                rcCell.Y = rc.Y;
            }


            // render data cells
            Pen pen = new Pen(Brushes.Gray, 0.1f);

            _c1pdf.DrawRectangle(pen, rcCell);
            rcCell.Inflate(-4, 0);
            // Render name
            float nameWidth = (float)(rc.Width * .5);
            float colWidth = rc.Width / 2;
            float x1 = rc.Location.X + 2;
            float x2 = rc.Location.X + rc.Width / 2;
            float y1 = rc.Location.Y + 2;
            float y2 = rc.Location.Y + 25;

            // Declare possible locations for row controls
            PointF r1c1 = new PointF(rc.Location.X + 2, rc.Location.Y + 2);
            PointF r2c1 = new PointF(rc.Location.X + 2, rc.Location.Y + 30);
            PointF r1c2 = new PointF(rc.Location.X + rc.Width / 2, rc.Location.Y + 2);
            PointF r2c2 = new PointF(rc.Location.X + rc.Width / 2, rc.Location.Y + 32);
            PointF r3c2 = new PointF(rc.Location.X + rc.Width / 2, rc.Location.Y + 62);

            // Render String
            string employeeName = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
            _c1pdf.DrawString(employeeName, new Font(font.FontFamily, 20, FontStyle.Bold), Brushes.Black, new RectangleF(r1c1, new SizeF(nameWidth, 25)));

            // Render ComboBox
            _c1pdf.DrawString("Reports to:", font, Brushes.Black, new PointF(x1, y1 + 30));
            int reportsTo = string.IsNullOrEmpty(dr["ReportsTo"].ToString()) ? 0 : (int)dr["ReportsTo"];
            RenderComboBox(new string[] { "Nancy Davolio", "Andrew Fuller", "Janet Leverling", "Margaret Peacock", "Steven Buchanan", "Michael Suyama", "Robert King" }, reportsTo, font, new RectangleF(new PointF(x1 + 55, y1 + 29), new SizeF(colWidth - 70, 15)));

            // Render Radiobuttons
            _c1pdf.DrawString("Product Division:", font, Brushes.Black, new PointF(x1, y1 + 50));
            RenderRadioButton(true, "GroupDivision" + _rowCount.ToString(), "One", font, new RectangleF(new PointF(x1 + 80, y1 + 50), new SizeF(colWidth - 85, 15)));
            RenderRadioButton(true, "GroupDivision" + _rowCount.ToString(), "Two", font, new RectangleF(new PointF(x1 + 120, y1 + 50), new SizeF(colWidth - 125, 15)));
            RenderRadioButton(true, "GroupDivision" + _rowCount.ToString(), "Three", font, new RectangleF(new PointF(x1 + 160, y1 + 50), new SizeF(colWidth - 165, 15)));

            // Render Checkbox
            RenderCheckBox(true, " Receives Email Notifications", font, new RectangleF(new PointF(x2 + 10, y1 + 5), new SizeF(colWidth - 5, 15)));
            _c1pdf.DrawString("Email Address:", font, Brushes.Black, new PointF(x2 + 10, y1 + 30));

            // Render Textbox
            RenderTextBox(dr["Lastname"].ToString().ToLower() + "@nwind.com", font, new RectangleF(new PointF(x2 + 80, y1 + 29), new SizeF(colWidth - 95, 15)), Color.FromKnownColor(KnownColor.Info), "Enter Email Address", false);

            // Render Listbox
            _c1pdf.DrawString("Title:", font, Brushes.Black, new PointF(x2 + 10, y1 + 60));
            RenderListBox(new string[] { "Sales Representative", "Sales Manager", "Vice President, Sales", "Inside Sales Coordinator" }, dr["Title"].ToString(), font, new RectangleF(new PointF(x2 + 50, y1 + 55), new SizeF(colWidth - 65, 30)));

            rcCell.Inflate(4, 0);


            pen.Dispose();

            // update rectangle and return it
            rc.Offset(0, rcCell.Height);
            return rc;
        }

        // get the current page rectangle (depends on paper size)
        // and apply a 1" margin all around it.
        internal RectangleF GetPageRect()
        {
            RectangleF rcPage = _c1pdf.PageRectangle;
            rcPage.Inflate(-72, -72);
            return rcPage;
        }

        internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc, bool outline, bool linkTarget)
        {
            // if it won't fit this page, do a page break
            rc.Height = _c1pdf.MeasureString(text, font, rc.Width).Height;
            if (rc.Bottom > rcPage.Bottom)
            {
                _c1pdf.NewPage();
                rc.Y = rcPage.Top;
            }

            // draw the string
            _c1pdf.DrawString(text, font, Brushes.Black, rc);

            // show bounds (mainly to check word wrapping)
            // _c1pdf.DrawRectangle(Pens.Sienna, rc);

            // add headings to outline
            if (outline)
            {
                _c1pdf.DrawLine(Pens.Black, rc.X, rc.Y, rc.Right, rc.Y);
                _c1pdf.AddBookmark(text, 0, rc.Y);
            }

            // add link target
            if (linkTarget)
            {
                _c1pdf.AddTarget(text, rc);
            }

            // update rectangle for next time
            rc.Offset(0, rc.Height);
            return rc;
        }
        internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc, bool outline)
        {
            return RenderParagraph(text, font, rcPage, rc, outline, false);
        }
        internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc)
        {
            return RenderParagraph(text, font, rcPage, rc, false, false);
        }


        // add text box field for fields of the PDF document
        // with common parameters and default names.
        //  
        internal PdfTextBox RenderTextBox(string text, Font font, RectangleF rc, Color back, string toolTip, bool multiline)
        {
            //  create
            string name = string.Format("ACFTB{0}", _textBoxCount + 1);
            PdfTextBox textBox = new PdfTextBox();

            //  default border
            // textBox.BorderWidth = 3f / 4;
            textBox.BorderStyle = FieldBorderStyle.Solid;
            textBox.BorderColor = SystemColors.ControlDarkDark;

            // parameters
            textBox.Font = font;
            textBox.Name = name;
            textBox.DefaultText = text;
            textBox.Text = text;
            textBox.ToolTip = string.IsNullOrEmpty(toolTip) ? string.Format("{0} ({1})", text, name) : toolTip;
            if (back != Color.Transparent && !back.IsEmpty)
            {
                textBox.BackColor = back;
            }
            textBox.IsMultiline = multiline;
            // add
            _c1pdf.AddField(textBox, rc);
            _textBoxCount++;

            // done
            return textBox;
        }
        internal PdfTextBox RenderTextBox(string text, Font font, RectangleF rc, Color back)
        {
            return RenderTextBox(text, font, rc, back, null, false);
        }
        internal PdfTextBox RenderTextBox(string text, Font font, RectangleF rc)
        {
            return RenderTextBox(text, font, rc, Color.Transparent, null, false);
        }
        internal PdfTextBox RenderTextBox(string text, Font font, RectangleF rc, bool multiline)
        {
            return RenderTextBox(text, font, rc, Color.Transparent, null, multiline);
        }

        // add combo box field for fields of the PDF document
        // with common parameters and default names.
        //  
        internal PdfComboBox RenderComboBox(string[] list, int activeIndex, Font font, RectangleF rc, Color back, string toolTip)
        {
            // create
            string name = string.Format("ACFCLB{0}", _comboBoxCount + 1);
            PdfComboBox comboBox = new PdfComboBox();

            // default border
            comboBox.BorderWidth = FieldBorderWidth.Thin;
            comboBox.BorderStyle = FieldBorderStyle.Solid;
            comboBox.BorderColor = SystemColors.ControlDarkDark;

            // array
            foreach (string text in list)
            {
                comboBox.Items.Add(text);
            }

            // parameters
            comboBox.Font = font;
            comboBox.Name = name;
            comboBox.DefaultValue = activeIndex;
            comboBox.Value = activeIndex;
            comboBox.ToolTip = string.IsNullOrEmpty(toolTip) ? string.Format("{0} ({1})", string.Format("Count = {0}", comboBox.Items.Count), name) : toolTip;
            if (back != Color.Transparent && !back.IsEmpty)
            {
                comboBox.BackColor = back;
            }

            // add
            _c1pdf.AddField(comboBox, rc);
            _comboBoxCount++;

            // done
            return comboBox;
        }
        internal PdfComboBox RenderComboBox(string[] list, int activeIndex, Font font, RectangleF rc, Color back)
        {
            return RenderComboBox(list, activeIndex, font, rc, back, null);
        }
        internal PdfComboBox RenderComboBox(string[] list, int activeIndex, Font font, RectangleF rc)
        {
            return RenderComboBox(list, activeIndex, font, rc, Color.Transparent, null);
        }

        // add list box field for fields of the PDF document
        // with common parameters and default names.
        //  
        internal PdfListBox RenderListBox(string[] list, string text, Font font, RectangleF rc, Color back, string toolTip)
        {
            // create
            string name = string.Format("ACFLB{0}", _listBoxCount + 1);
            PdfListBox listBox = new PdfListBox();

            // default border
            listBox.BorderWidth = FieldBorderWidth.Thin;
            listBox.BorderStyle = FieldBorderStyle.Solid;
            listBox.BorderColor = SystemColors.ControlDarkDark;

            // array
            foreach (string item in list)
            {
                listBox.Items.Add(item);
            }

            // parameters
            listBox.Font = font;
            listBox.Name = name;
            listBox.Text = text;
            listBox.ToolTip = string.IsNullOrEmpty(toolTip) ? string.Format("{0} ({1})", string.Format("Count = {0}", listBox.Items.Count), name) : toolTip;
            if (back != Color.Transparent && !back.IsEmpty)
            {
                listBox.BackColor = back;
            }

            // add
            _c1pdf.AddField(listBox, rc);
            _listBoxCount++;

            // done
            return listBox;
        }
        internal PdfListBox RenderListBox(string[] list, string text, Font font, RectangleF rc, Color back)
        {
            return RenderListBox(list, text, font, rc, back, null);
        }
        internal PdfListBox RenderListBox(string[] list, string text, Font font, RectangleF rc)
        {
            return RenderListBox(list, text, font, rc, Color.Transparent, null);
        }

        // add radio button box field for fields of the PDF document
        // with common parameters and default names.
        //  
        internal PdfRadioButton RenderRadioButton(bool value, string group, string text, Font font, RectangleF rc, Color back, string toolTip)
        {
            // create
            string name = string.IsNullOrEmpty(group) ? "ACFRGR" : group;
            PdfRadioButton radioButton = new PdfRadioButton();

            // parameters
            radioButton.Name = name;
            radioButton.DefaultValue = value;
            radioButton.Value = value;
            radioButton.ToolTip = string.IsNullOrEmpty(toolTip) ? string.Format("{0} ({1})", text, name) : toolTip;
            if (back != Color.Transparent && !back.IsEmpty)
            {
                radioButton.BackColor = back;
            }

            // add
            float radioSize = font.Size;
            float radioTop = rc.Top + (rc.Height - radioSize) / 2;
            _c1pdf.AddField(radioButton, new RectangleF(rc.Left, radioTop, radioSize, radioSize));
            _radioButtonCount++;

            // text for radio button field
            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                float x = rc.Left + radioSize + 1.0f;
                float y = rc.Top + (rc.Height - radioSize - 1.0f) / 2;
                _c1pdf.DrawString(text, new Font(font.Name, radioSize, font.Style), brush, new PointF(x, y));
            }

            // done
            return radioButton;
        }
        internal PdfRadioButton RenderRadioButton(bool value, string group, string text, Font font, RectangleF rc, Color back)
        {
            return RenderRadioButton(value, group, text, font, rc, back, null);
        }
        internal PdfRadioButton RenderRadioButton(bool value, string group, string text, Font font, RectangleF rc)
        {
            return RenderRadioButton(value, group, text, font, rc, Color.Transparent, null);
        }

        // add check box field for fields of the PDF document
        // with common parameters and default names.
        //  
        internal PdfCheckBox RenderCheckBox(bool value, string text, Font font, RectangleF rc, Color back, string toolTip)
        {
            // create
            string name = string.Format("ACFCB{0}", _checkBoxCount + 1);
            PdfCheckBox checkBox = new PdfCheckBox();

            // default border
            checkBox.BorderWidth = FieldBorderWidth.Thin;
            checkBox.BorderStyle = FieldBorderStyle.Solid;
            checkBox.BorderColor = SystemColors.ControlDarkDark;

            // parameters
            checkBox.Name = name;
            checkBox.DefaultValue = value;
            checkBox.Value = value;
            checkBox.ToolTip = string.IsNullOrEmpty(toolTip) ? string.Format("{0} ({1})", text, name) : toolTip;
            if (back != Color.Transparent && !back.IsEmpty)
            {
                checkBox.BackColor = back;
            }

            // add
            float checkBoxSize = font.Size;
            float checkBoxTop = rc.Top + (rc.Height - checkBoxSize) / 2;
            _c1pdf.AddField(checkBox, new RectangleF(rc.Left, checkBoxTop, checkBoxSize, checkBoxSize));
            _checkBoxCount++;

            // text for check box field
            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                float x = rc.Left + checkBoxSize + 1.0f;
                float y = rc.Top + (rc.Height - checkBoxSize - 1.0f) / 2;
                _c1pdf.DrawString(text, new Font(font.Name, checkBoxSize, font.Style), brush, new PointF(x, y));
            }

            // done
            return checkBox;
        }
        internal PdfCheckBox RenderCheckBox(bool value, string text, Font font, RectangleF rc, Color back)
        {
            return RenderCheckBox(value, text, font, rc, back, null);
        }
        internal PdfCheckBox RenderCheckBox(bool value, string text, Font font, RectangleF rc)
        {
            return RenderCheckBox(value, text, font, rc, Color.Transparent, null);
        }

        // add push button box field for fields of the PDF document
        // with common parameters and default names.
        //  
        internal PdfPushButton RenderPushButton(string text, Font font, RectangleF rc, Color back, Color fore, string toolTip, Image image, ButtonLayout layout)
        {
            // create
            string name = string.Format("ACFPB{0}", _pushButtonCount + 1);
            PdfPushButton pushButton = new PdfPushButton();

            // parameters
            pushButton.Name = name;
            pushButton.DefaultValue = text;
            pushButton.Value = text;
            pushButton.Font = font;
            pushButton.ToolTip = string.IsNullOrEmpty(toolTip) ? string.Format("{0} ({1})", text, name) : toolTip;
            if (back != Color.Transparent && !back.IsEmpty)
            {
                pushButton.BackColor = back;
            }
            if (fore != Color.Transparent && !fore.IsEmpty)
            {
                pushButton.ForeColor = fore;
            }

            // icon
            if (image != null)
            {
                pushButton.Image = image;
                pushButton.Layout = layout;
            }

            // add
            _c1pdf.AddField(pushButton, rc);
            _pushButtonCount++;

            // done
            return pushButton;
        }
        internal PdfPushButton RenderPushButton(string text, Font font, RectangleF rc, Color back)
        {
            return RenderPushButton(text, font, rc, back, Color.Transparent, null, null, ButtonLayout.TextOnly);
        }
        internal PdfPushButton RenderPushButton(string text, Font font, RectangleF rc)
        {
            return RenderPushButton(text, font, rc, Color.Transparent, Color.Transparent, null, null, ButtonLayout.TextOnly);
        }
        internal PdfPushButton RenderPushButton(string text, Font font, RectangleF rc, Image icon, ButtonLayout layout)
        {
            return RenderPushButton(text, font, rc, Color.Transparent, Color.Transparent, null, icon, layout);
        }
        internal PdfPushButton RenderPushButton(string text, Font font, RectangleF rc, ButtonLayout layout)
        {
            return RenderPushButton(text, font, rc, Color.Transparent, Color.Transparent, null, null, layout);
        }
        internal PdfPushButton RenderPushButton(Font font, RectangleF rc, Color back, Image image)
        {
            return RenderPushButton(string.Empty, font, rc, back, Color.Transparent, null, image, ButtonLayout.ImageOnly);
        }

        //================================================================================
        // add page footers to a document
        // 
        // this method is called by all samples in this project. it scans the document
        // and adds a 'page n of m' footer to each page. the footers are rendered as 
        // vertical text along the right edge of the document.
        // 
        // adding content to an existing page is easy: just set the CurrentPage property
        // to point to an existing page and write into it as usual.
        // 
        private void AddFooters()
        {
            Font fontHorz = new Font("Tahoma", 7, FontStyle.Bold);
            Font fontVert = new Font("Viner Hand ITC", 14, FontStyle.Bold);

            StringFormat sfRight = new StringFormat();
            sfRight.Alignment = StringAlignment.Far;

            StringFormat sfVert = new StringFormat();
            sfVert.FormatFlags |= StringFormatFlags.DirectionVertical;
            sfVert.Alignment = StringAlignment.Center;

            for (int page = 0; page < _c1pdf.Pages.Count; page++)
            {
                // select page we want (could change PageSize)
                _c1pdf.CurrentPage = page;

                // build rectangles for rendering text
                RectangleF rcPage = GetPageRect();
                RectangleF rcFooter = rcPage;
                rcFooter.Y = rcFooter.Bottom + 6;
                rcFooter.Height = 12;
                RectangleF rcVert = rcPage;
                rcVert.X = rcPage.Right + 6;

                // add left-aligned footer
                string text = _c1pdf.DocumentInfo.Title;
                _c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter);

                // add right-aligned footer
                text = string.Format("Page {0} of {1}", page + 1, _c1pdf.Pages.Count);
                _c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter, sfRight);

                // add vertical text
                text = _c1pdf.DocumentInfo.Title + " (document created using the C1Pdf .NET component)";
                _c1pdf.DrawString(text, fontVert, Brushes.LightGray, rcVert, sfVert);

                // draw lines on bottom and right of the page
                _c1pdf.DrawLine(Pens.Gray, rcPage.Left, rcPage.Bottom, rcPage.Right, rcPage.Bottom);
                _c1pdf.DrawLine(Pens.Gray, rcPage.Right, rcPage.Top, rcPage.Right, rcPage.Bottom);
            }
        }

        private int MapJobTitle(string title)
        {
            int index = 0;
            if(title.Equals("Sales Representative"))
                return 1;
            else if(title.Equals("Sales Manager"))
                return 2;
            else if(title.Equals("Vice President, Sales"))
                return 3;
            else if(title.Equals("Inside Sales Coordinator"))
                return 4;

            return index;
        }
    }
}
