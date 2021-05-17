using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace SizingMode
{
    public partial class Form1 : Form
    {
        private string _desc1 = "This document contains a table with auto width columns and auto height rows.";
        private string _desc2 = "This document contains a table with an auto width first and fixed width remaining columns.";
        private string _desc3 = "This document contains a table with text rotated by 90 degrees, with auto width columns and fixed height rows.";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create "welcome" document

            //RenderTable rt = new RenderTable();
            //rt.Height = "parent.height";
            //rt.RowSizingMode = TableSizingModeEnum.Fixed;
            //rt.Cells[0, 0].RenderObject = CreateButton("Demo1");
            //rt.Cells[0, 1].RenderObject = CreateDesc(_desc1);
            //rt.Cells[1, 0].RenderObject = CreateButton("Demo2");
            //rt.Cells[1, 1].RenderObject = CreateDesc(_desc2);
            //rt.Cells[2, 0].RenderObject = CreateButton("Demo3");
            //rt.Cells[2, 1].RenderObject = CreateDesc(_desc3);
            //doc.Body.Children.Add(rt);
            //doc.Generate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Verdana", 18);

            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText(_desc1));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            // create RenderTable object
            RenderTable rt = new RenderTable();
            for (int r = 0; r < 70; r++)
                for (int c = 0; c < 3; c++)
                    rt.Cells[r, c].Text = string.Format("Cell ({0}, {1})", r, c);
            rt.Style.GridLines.All = LineDef.Default;
            // by default columns calculated as Fixed
            rt.ColumnSizingMode = TableSizingModeEnum.Auto;
            // by default width of table is "parent.width"
            rt.Width = Unit.Auto;
            // typically by default width of render objects is parent.width
            // so we should set it to auto
            foreach (RenderObject ro in rt.Children)
                ro.Width = Unit.Auto;

            // add table to document
            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const int rowCount = 60; // count of rows in table
            const int colCount = 4; // count of columns in table

            doc.Clear();

            doc.Style.Font = new Font("Verdana", 18);

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText(_desc2));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            // use image from dictionary
            doc.Dictionary.Add(new DictionaryImage("Checked", Image.FromFile(@"Checked.bmp")));

            RenderTable rt = new RenderTable();
            rt.Style.GridLines.All = LineDef.Default;

            for (int r = 0; r < rowCount; r++)
            {
                // create RenderImage object in the first column
                RenderImage ri = new RenderImage();
                ri.ImageName = "Checked";
                ri.Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Center;
                ri.Style.ImageAlign.AlignVert = ImageAlignVertEnum.Center;
                rt.Cells[r, 0].RenderObject = ri;

                // generate content for all other columns
                for (int c = 1; c < colCount; c++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < (c % 2 == 0 ? 2 : 1); i++)
                        sb.Append(string.Format("Line{0}\r", i));
                    rt.Cells[r, c].Text = sb.ToString();
                }

                if (r % 2 == 0)
                    rt.Rows[r].Style.BackColor = Color.LightBlue;
            }

            // change sizing mode of first column, it width will be determinated
            // by the width of image
            rt.Cols[0].SizingMode = TableSizingModeEnum.Auto;

            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doc.Clear();

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Style.Font = new Font("Tahoma", 18);
            desc.Content.Add(new ParagraphText(_desc3));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            RenderTable rt = new RenderTable();
            for (int r = 0; r < 5; r++)
                for (int c = 0; c < 60; c++)
                    rt.Cells[r, c].Text = string.Format("Cell {0}:{1}", r, c);
            // use not solid grid lines
            rt.Style.GridLines.All = new LineDef("1mm", Color.Gray, DashStyle.Dash);
            rt.Style.TextAngle = 90;
            rt.ColumnSizingMode = TableSizingModeEnum.Auto;
            rt.RowSizingMode = TableSizingModeEnum.Fixed;
            rt.Width = Unit.Auto;
            rt.Height = "page.height - prev.height"; // table will use all available height on page
            rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
            foreach (RenderObject ro in rt.Children)
                ro.Width = Unit.Auto;
            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private RenderObject CreateButton(string caption)
        {
            RenderArea ra = new RenderArea();
            RenderInputButton rb = new RenderInputButton(caption);
            rb.Style.Font = new Font("Tahoma", 14);
            rb.X = LengthExp.Predefined.HorzCenterAlign;
            rb.Y = LengthExp.Predefined.VertCenterAlign;
            rb.Width = "35mm";
            rb.Height = "20mm";
            ra.Children.Add(rb);
            return ra;
        }

        private RenderObject CreateDesc(string desc)
        {
            RenderText rt = new RenderText();
            rt.Text = desc;
            rt.Style.Font = new Font("Verdana", 12);
            rt.Style.TextAlignVert = AlignVertEnum.Center;
            return rt;
        }

        private void c1PrintPreviewControl1_PreviewPane_FormsUserAction(object sender, FormsUserActionEventArgs e)
        {
            if (e.UserAction != UserActionEnum.Click)
                return;

            e.Handled = true;
            switch (((RenderInputButton)e.RenderObject).Text)
            {
                case "Demo1":
                    button1_Click(null, null);
                    break;
                case "Demo2":
                    button2_Click(null, null);
                    break;
                case "Demo3":
                    button3_Click(null, null);
                    break;
            }
        }
    }
}