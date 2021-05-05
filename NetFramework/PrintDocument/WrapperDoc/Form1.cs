using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace WrapperDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            C1PrintDocumentWrapper doc = new C1PrintDocumentWrapper();
            doc.StartDoc();

            doc.Style.Font = new Font("Tahoma", 12);

            doc.RenderBlock(new RenderText("This document was rendered using the C1PrintDocumentWrapper class.", new Font("Tahoma", 18)));
            doc.AdvanceBlockFlow("5mm");

            RenderText rt = new RenderText("RenderText object with border.");
            rt.Style.Font = new Font("Tahoma", 14);
            rt.Style.Borders.All = LineDef.DefaultBold;
            MeasureInfo mi = doc.RenderBlock(rt);

            doc.AdvanceBlockFlow("5mm");

            rt = new RenderText();
            rt.Text = string.Format("The previosly rendered object has the following coordinates:\rX = {0}\rY = {1}\rWidth = {2}\rHEight= {3}", mi.RenderedArea.X, mi.RenderedArea.Y, mi.RenderedArea.Width, mi.RenderedArea.Height);
            doc.RenderBlock(rt);

            rt = new RenderText();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 60; i++)
            {
                sb.Append("Line ");
                sb.Append(i.ToString());
                sb.Append("\r");
            }
            rt.Text = sb.ToString();
            rt.Style.Borders.All = new LineDef("1mm", Color.Red);
            doc.RenderBlock(rt);

            rt = new RenderText();
            sb = new StringBuilder("The previosly rendered object occipied the following areas:\r");
            for (int i = 0; i < doc.LastRenderedInfo.RenderedAreas.Length; i++)
            {
                sb.Append(string.Format("Area {0}, Bounds = {1}\r", i + 1, doc.LastRenderedInfo.RenderedAreas[i].ToString()));
            }
            rt.Text = sb.ToString();
            doc.RenderBlock(rt);

            doc.AdvanceBlockFlow("5mm");

            RenderTable table = new RenderTable();
            table.Style.GridLines.All = LineDef.Default;
            for (int r = 0; r < 10; r++)
                for (int c = 0; c < 3; c++)
                    table.Cells[r, c].Text = string.Format("Cell {0}:{1}", r, c);
            table.Width = new Unit(doc.CurrentPageArea.Bounds.Width, doc.ResolvedUnit);
            mi = doc.MeasureObject(table, new Unit(doc.CurrentPageArea.Bounds.Width, doc.ResolvedUnit), Unit.Auto);

            doc.RenderBlockText(string.Format("The following table's size is:\rWidth = {0}\rHeight = {1}", mi.WidthUnit, mi.HeightUnit));

            doc.RenderBlock(table);

            doc.EndDoc();

            c1PrintPreviewControl1.Document = doc;
        }
    }
}
