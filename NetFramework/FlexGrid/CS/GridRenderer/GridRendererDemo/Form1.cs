using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace GridRendererDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // custom renderer that paints radial gradients...
            //c1FlexGrid1.Renderer = new MyRenderer();
        }

        private void _btnEditRenderer_Click(object sender, EventArgs e)
        {
            if (gridRenderer2.EditRenderer())
            {
                c1FlexGrid1.Renderer = gridRenderer2.Renderer;
            }
        }
    }

    class MyRenderer : GridRendererOffice2007Blue
    {
        public override void OnDrawCell(C1FlexGridBase flex, OwnerDrawCellEventArgs e, C1FlexGridRenderer.CellType cellType)
        {
            if (cellType == CellType.ColumnHeader)
            {
                using (var brush = GetHeaderBrush(e.Bounds))
                {
                    // paint the cell background
                    e.Graphics.FillRectangle(brush, e.Bounds);

                    // paint the border and content
                    e.DrawCell(DrawCellFlags.Border | DrawCellFlags.Content);
                }
            }
            else
            {
                base.OnDrawCell(flex, e, cellType);
            }
        }
        public override bool TracksSelection
        {
            get
            {
                return false;
            }
        }
        Brush GetHeaderBrush(Rectangle rc)
        {
            // build brush
            using (var path = new GraphicsPath())
            {
                var outer = rc;
                outer.Inflate(rc.Width / 4, rc.Height / 4);
                path.AddEllipse(outer);
                var pgb = new PathGradientBrush(path);

                // apply parameters
                pgb.CenterColor = Color.DarkGray;
                pgb.SurroundColors = new Color[] { Color.White };
                pgb.CenterPoint = new Point(rc.X + rc.Width / 2, rc.Y + rc.Height / 2);

                // return the brush
                return pgb;
            }
        }
    }
}
