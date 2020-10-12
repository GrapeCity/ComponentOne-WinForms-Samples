using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace OwnerDraw
{
    public partial class Form1 : Form
    {
        CellStyle _bigValue;
        const int BIGVALUE = 100;

        public Form1()
        {
            InitializeComponent();

            // configure grid
            var grid = this.c1OlapPage1.OlapGrid;

            // style used to show 'big values'
            _bigValue = grid.Styles.Add("bigValue");
            _bigValue.BackColor = Color.LightGreen;

            // owner draw to apply the style
            grid.DrawMode = DrawModeEnum.OwnerDraw;
            grid.OwnerDrawCell += grid_OwnerDrawCell;

            // load data
            var da = new OleDbDataAdapter("select * from invoices", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);

            // bind data
            this.c1OlapPage1.DataSource = dt;

            // apply default view
            this.c1OlapPage1.ViewDefinition = Properties.Resources.DefaultView;
        }

        void grid_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            var grid = sender as C1.Win.C1FlexGrid.C1FlexGrid;
            if (e.Row >= grid.Rows.Fixed && 
                e.Col >= grid.Cols.Fixed && 
                grid[e.Row, e.Col] is double)
            {
                var value = (double)grid[e.Row, e.Col];
                if (value > BIGVALUE)
                {
                    e.Style = _bigValue;
                }
            }
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
