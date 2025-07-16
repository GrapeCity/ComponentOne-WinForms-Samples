using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomFilters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // create data table
            var dt = new DataTable();
            dt.Columns.Add("Some Date", typeof(DateTime));
            dt.Columns.Add("Some Integer", typeof(int));
            dt.Columns.Add("KnownColor", typeof(KnownColor));
            dt.Columns.Add("Color", typeof(Color));

            var rnd = new Random();
            foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                Color clr = Color.FromKnownColor(kc);
                dt.Rows.Add(DateTime.Today.AddDays(-rnd.Next(0, 100)), rnd.Next(0, 1000), kc, clr);
            }

            // configure grid
            _flex.DataSource = dt;
            _flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            _flex.OwnerDrawCell += _flex_OwnerDrawCell;
            _flex.ExtendLastCol = true;
            _flex.AllowEditing = false;
            _flex.AllowFiltering = true;

            // assign custom filters
            _flex.Cols["Color"].Filter = new ColorFilter();
            _flex.Cols["Some Date"].Filter = new DateFilter();
            _flex.Cols["KnownColor"].Filter = new StringFilter();
        }

        void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (_flex[e.Row, e.Col] is Color)
            {
                var clr = (Color)_flex[e.Row, e.Col];
                if (clr != null)
                {
                    e.DrawCell(C1.Win.FlexGrid.DrawCellFlags.Background | C1.Win.FlexGrid.DrawCellFlags.Border);
                    var rc = e.Bounds;
                    rc.Inflate(-4, -2);
                    using (var br = new SolidBrush(clr))
                    {
                        e.Graphics.FillRectangle(br, rc);
                        e.Graphics.DrawRectangle(Pens.Black, rc);
                    }
                }
            }
        }
    }
}
