﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace SampleExplorer
{
    public partial class FlexGridWithBulletGraph : UserControl
    {
        #region Fields
        private DataTable _ds;
        private C1.Win.Gauge.C1BulletGraph _graph = new C1.Win.Gauge.C1BulletGraph();
        private Random rnd = new Random();
        #endregion Fields

        public FlexGridWithBulletGraph()
        {
            InitializeComponent();
            _graph.GraphScale.ShowLabels = false;
            _graph.GraphScale.ShowMarks = false;
        }        

        private void DrawBulletGraph(Graphics g, Rectangle bounds, int row)
        {
            _graph.Bounds = bounds;
            _graph.Target = (int)_ds.Rows[row]["Target"];
            _graph.Bad.To = (int)_ds.Rows[row]["Bad"];
            _graph.Good.To = (int)_ds.Rows[row]["Good"];
            _graph.Value = (double)_ds.Rows[row]["Sales"];

            using (var img = _graph.GetImage(bounds.Width, bounds.Height))
                g.DrawImage(img, bounds);
        }

        private DataTable GetDataSource(int rows)
        {
            DataTable table = new DataTable("Data");
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Good", typeof(int));
            table.Columns.Add("Bad", typeof(int));
            table.Columns.Add("Target", typeof(int));
            table.Columns.Add("Sales", typeof(double));
            table.Columns.Add("BulletGraph", typeof(double));

            for (int i = 0; i < rows; i++)
            {
                var r0 = rnd.Next(26, 50);
                var r1 = rnd.Next(0, 25);
                var m = rnd.Next(60, 99);
                var r = new List<int>();
                for (int k = 0; k < 12; k++)
                    r.Add(rnd.Next(-50, 50));
                table.Rows.Add(DateTime.Now.Date.AddMonths(-2).AddDays(i), r0, r1, m, rnd.Next(0, 100));
            }

            _ds?.Dispose();
            _ds = table;

            return _ds;
        }

        #region Handlers

        private void c1FlexGrid1_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (e.Row > 0 && e.Col == 6)
            {
                DrawBulletGraph(e.Graphics, e.Bounds, e.Row-1);
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DrawMode = DrawModeEnum.OwnerDraw;
            c1FlexGrid1.DataSource = GetDataSource(50);
            for( int i = 2; i <=5; i++)
            {
                c1FlexGrid1.Cols[i].Width = 55;
            }
            var col = c1FlexGrid1.Cols[6];
            col.AllowEditing = false;
            c1FlexGrid1.ExtendLastCol = true;
        }

        private void c1FlexGrid1_AfterEdit(object sender, RowColEventArgs e)
        {
            Invalidate(true);
        }

        #endregion Handlers
    }
}
