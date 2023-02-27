using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

namespace PdfAcroforms
{
    using C1.C1Pdf;

    public partial class Form1 : Form
    {
        private int _textBoxCount;
        private int _checkBoxCount;
        private int _radioButtonCount;
        private int _pushButtonCount;
        private int _comboBoxCount;
        private int _listBoxCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void _btCreate_Click(object sender, EventArgs e)
        {
            // create pdf document
            _c1pdf.Clear();
            _c1pdf.DocumentInfo.Title = "PDF Acroform";
            _statusBar.Text = "Creating pdf document...";

            // calculate page rect (discounting margins)
            RectangleF rcPage = GetPageRect();
            RectangleF rc = rcPage;

            // add title
            Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
            rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);

            // render acroforms
            rc = rcPage;
            Font fieldFont = new Font("Arial", 14, FontStyle.Regular);

            // text box field
            rc = new RectangleF(rc.X, rc.Y + rc.Height / 10, rc.Width / 3, rc.Height / 30);
            PdfTextBox textBox1 = RenderTextBox("TextBox Sample", fieldFont, rc);
            textBox1.BorderWidth = FieldBorderWidth.Thick;
            textBox1.BorderStyle = FieldBorderStyle.Inset;
            textBox1.BorderColor = Color.Green;
            //textBox1.BackColor = Color.Yellow;

            // first check box field
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            RenderCheckBox(true, "CheckBox 1 Sample", fieldFont, rc);

            // first radio button group
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            RenderRadioButton(false, "RadioGroup1", "RadioButton 1 Sample Group 1", fieldFont, rc);
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            RenderRadioButton(true, "RadioGroup1", "RadioButton 2 Sample Group 1", fieldFont, rc);
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            RenderRadioButton(false, "RadioGroup1", "RadioButton 3 Sample Group 1", fieldFont, rc);

            // second check box field
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            RenderCheckBox(false, "CheckBox 2 Sample", fieldFont, rc);

            // second radio button group
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            RenderRadioButton(true, "RadioGroup2", "RadioButton 1 Sample Group 2", fieldFont, rc);
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            RenderRadioButton(false, "RadioGroup2", "RadioButton 2 Sample Group 2", fieldFont, rc);

            // first combo box field
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, rc.Height);
            PdfComboBox comboBox1 = RenderComboBox(new string[] { "First", "Second", "Third" }, 2, fieldFont, rc);

            // first list box field
            RectangleF rclb = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, 3 * rc.Height);
            RenderListBox(new string[] { "First", "Second", "Third", "Fourth", "Fifth" }, 5, fieldFont, rclb);

            // load first icon
            Image icon = null;
            using (Stream stream = GetManifestResource("phoenix.png"))
            {
                icon = Image.FromStream(stream);
            }

            // first push putton field
            rc = new RectangleF(rc.X, rc.Y + 6 * rc.Height, rc.Width, rc.Height);
            PdfPushButton button1 = RenderPushButton("Submit", fieldFont, rc, icon, ButtonLayout.ImageLeftTextRight);
            button1.Actions.Released.Add(new PdfPushButton.Action(ButtonAction.CallMenu, "FullScreen"));
            button1.Actions.GotFocus.Add(new PdfPushButton.Action(ButtonAction.OpenFile, "Program.cs"));
            button1.Actions.LostFocus.Add(new PdfPushButton.Action(ButtonAction.GotoPage, "2"));
            button1.Actions.Released.Add(new PdfPushButton.Action(ButtonAction.OpenUrl, "http://www.componentone.com/"));

            // load second icon
            using (Stream stream = GetManifestResource("download.png"))
            {
                icon = Image.FromStream(stream);
            }

            // second push putton field
            rc = new RectangleF(rc.X, rc.Y + 2 * rc.Height, rc.Width, 2 * rc.Height);
            PdfPushButton button2 = RenderPushButton("Cancel", fieldFont, rc, icon, ButtonLayout.TextTopImageBottom);
            button2.Actions.Pressed.Add(new PdfPushButton.Action(ButtonAction.ClearFields));
            button2.Actions.Released.Add(new PdfPushButton.Action(ButtonAction.CallMenu, "Quit"));

            // load second icon
            using (Stream stream = GetManifestResource("top100.png"))
            {
                icon = Image.FromStream(stream);
            }

            // push putton only icon field
            rc = new RectangleF(rc.X + 1.5f * rc.Width, rc.Y, rc.Width / 2, rc.Height);
            PdfPushButton button3 = RenderPushButton("", fieldFont, rc, icon, ButtonLayout.ImageOnly);
            button3.Actions.MouseEnter.Add(new PdfPushButton.Action(ButtonAction.HideField, button1.Name));
            button3.Actions.MouseLeave.Add(new PdfPushButton.Action(ButtonAction.ShowField, button1.Name));
            button3.Actions.Released.Add(new PdfPushButton.Action(ButtonAction.CallMenu, "ShowGrid"));
            button3.BorderWidth = FieldBorderWidth.Medium;
            button3.BorderStyle = FieldBorderStyle.Beveled;
            button3.BorderColor = Color.Gray;

            // next page
            _c1pdf.NewPage();

            // text for next page
            rc = rcPage;
            RenderParagraph("Second page as bookmark", titleFont, rcPage, rc, false);

            // text box field
            //rc = rcPage;
            //rc = new RectangleF(rc.X, rc.Y + rc.Height / 10, rc.Width / 3, rc.Height / 30);
            //PdfTextBox textBox2 = RenderTextBox("TextSample 2", fieldFont, rc, Color.Yellow, "In 2 page");

            // second pass to number pages
            AddFooters();

            // save to file and show it
            _statusBar.Text = "Saving pdf document...";
            string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\PdfAcroForm.pdf";
            _c1pdf.Compression = CompressionEnum.None;
            _c1pdf.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

        // get the current page rectangle (depends on paper size)
        // and apply a 1" margin all around it.
        internal RectangleF GetPageRect()
        {
            RectangleF rcPage = _c1pdf.PageRectangle;
            rcPage.Inflate(-72, -72);
            return rcPage;
        }


        // add text box field for fields of the PDF document
        // with common parameters and default names.
        // 
        internal PdfTextBox RenderTextBox(string text, Font font, RectangleF rc, Color back, string toolTip)
        {
            // create
            string name = string.Format("ACFTB{0}", _textBoxCount + 1);
            PdfTextBox textBox = new PdfTextBox();

            // default border
            //textBox.BorderWidth = 3f / 4;
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

            // add
            _c1pdf.AddField(textBox, rc);
            _textBoxCount++;

            // done
            return textBox;
        }
        internal PdfTextBox RenderTextBox(string text, Font font, RectangleF rc, Color back)
        {
            return RenderTextBox(text, font, rc, back, null);
        }
        internal PdfTextBox RenderTextBox(string text, Font font, RectangleF rc)
        {
            return RenderTextBox(text, font, rc, Color.Transparent, null);
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
        internal PdfListBox RenderListBox(string[] list, int activeIndex, Font font, RectangleF rc, Color back, string toolTip)
        {
            // create
            string name = string.Format("ACFLB{0}", _listBoxCount + 1);
            PdfListBox listBox = new PdfListBox();

            // default border
            listBox.BorderWidth = FieldBorderWidth.Thin;
            listBox.BorderStyle = FieldBorderStyle.Solid;
            listBox.BorderColor = SystemColors.ControlDarkDark;

            // array
            foreach (string text in list)
            {
                listBox.Items.Add(text);
            }

            // parameters
            listBox.Font = font;
            listBox.Name = name;
            listBox.DefaultValue = activeIndex;
            listBox.Value = activeIndex;
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
        internal PdfListBox RenderListBox(string[] list, int activeIndex, Font font, RectangleF rc, Color back)
        {
            return RenderListBox(list, activeIndex, font, rc, back, null);
        }
        internal PdfListBox RenderListBox(string[] list, int activeIndex, Font font, RectangleF rc)
        {
            return RenderListBox(list, activeIndex, font, rc, Color.Transparent, null);
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
        internal PdfPushButton RenderPushButton(Font font, RectangleF rc, Color back, Image image)
        {
            return RenderPushButton(string.Empty, font, rc, back, Color.Transparent, null, image, ButtonLayout.ImageOnly);
        }

        // measure a paragraph, skip a page if it won't fit, render it into a rectangle,
        // and update the rectangle for the next paragraph.
        // 
        // optionally mark the paragraph as an outline entry and as a link target.
        //
        // this routine will not break a paragraph across pages. for that, see the Text Flow sample.
        //
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
            //_c1pdf.DrawRectangle(Pens.Sienna, rc);

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

        /// <summary>
        /// Gets embedded resource by the file name.
        /// </summary>
        /// <param name="resourceName">The file on embedded resources.</param>
        /// <returns>The stream with embedded resource or null.</returns>
        public static Stream GetManifestResource(string resourceName)
        {
            return GetManifestResource(Assembly.GetExecutingAssembly(), resourceName);
        }
        /// <summary>
        /// Gets embedded resource by the file name.
        /// </summary>
        /// <param name="a">The calling <see cref="Assembly"/>.</param>
        /// <param name="resourceName">The file on embedded resources.</param>
        /// <returns>The stream with embedded resource or null.</returns>
        public static Stream GetManifestResource(Assembly a, string resourceName)
        {
            // search resource in embedded resources
            try
            {
                foreach (string res in a.GetManifestResourceNames())
                {
                    if (res.EndsWith(resourceName))
                    {
                        return a.GetManifestResourceStream(res);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            // done
            return null;
        }
    }
}