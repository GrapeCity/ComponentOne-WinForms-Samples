using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace _V1_2010_NewFeatures
{
    public partial class Form2 : Form
    {
        GridColumnFilter _filter;

        public Form2()
        {
            InitializeComponent();

            _filter = new GridColumnFilter(typeof(string));
            _filter.Condition1.Operator = ConditionOperator.Contains;
        }

        void Form2_Load(object sender, EventArgs e)
        {
            var da = new OleDbDataAdapter("select * from invoices", Form1.GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);
            _flex.DataSource = dt;
        }

        void _searchBox_Search(object sender, EventArgs e)
        {
            _filter.Condition1.Parameter = _searchBox.Text;

            _flex.BeginUpdate();
            for (int r = _flex.Rows.Fixed; r < _flex.Rows.Count; r++)
            {
                bool visible = false;
                for (int c = _flex.Cols.Fixed; c < _flex.Cols.Count; c++)
                {
                    if (_filter.Apply(_flex[r, c]))
                    {
                        visible = true;
                        break;
                    }
                }
                _flex.Rows[r].Visible = visible;
            }
            _flex.EndUpdate();
        }
    }
}
