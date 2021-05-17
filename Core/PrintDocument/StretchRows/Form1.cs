using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace StretchRows
{
    public partial class Form1 : Form
    {
        private string _desc1 = "This document contains a table with all rows stretched vertically to fill the whole page.";
        private string _desc2 = "This document contains a table in which only the last row on each page is stretched vertically to fill the page.";
        private string _desc3 = "This document contains a table in which all rows and columns are stretched to fill the entire page.";


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

        private RenderTable CreateTable(int colCount, int rowCount, string cellTextMask)
        {
            RenderTable result = new RenderTable();

            for (int r = 0; r < rowCount; r++)
                for (int c = 0; c < colCount; c++)
                    result.Cells[r, c].Text = string.Format(cellTextMask, r, c);

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 16);

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText(_desc1));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            // create RenderTable
            RenderTable table = CreateTable(4, 70, "Cell {0} {1} Cell Cell Cell Cell");
            table.Style.GridLines.All = LineDef.DefaultBold;
            // stretch rows
            table.StretchRows = StretchTableEnum.AllVectors;
            doc.Body.Children.Add(table);

            doc.Generate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 16);

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText(_desc2));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            RenderTable table = CreateTable(4, 70, "Cell {0} {1} Cell Cell Cell Cell");
            table.Style.GridLines.All = LineDef.DefaultBold;
            table.StretchRows = StretchTableEnum.LastVectorOnPage;
            doc.Body.Children.Add(table);

            doc.Generate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 16);

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText(_desc3));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            RenderTable table = CreateTable(3, 3, "Cell {0}:{1}");
            // center text in cells by vertical and horizontal
            table.Style.TextAlignHorz = AlignHorzEnum.Center;
            table.Style.TextAlignVert = AlignVertEnum.Center;
            table.ColumnSizingMode = TableSizingModeEnum.Auto;
            table.Style.GridLines.All = LineDef.DefaultBold;
            // stretch all rows
            table.StretchRows = StretchTableEnum.AllVectors;
            // stretch all columns
            table.StretchColumns = StretchTableEnum.AllVectors;
            doc.Body.Children.Add(table);

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