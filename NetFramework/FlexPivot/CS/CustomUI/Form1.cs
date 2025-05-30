﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Disable the cross thread check for we use multi thread for data update.
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // load data
            var da = new OleDbDataAdapter("select * from Invoices", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);

            // assign it to C1FlexPivotPanel that is driving the app
            this.c1FlexPivotPanel1.DataSource = dt;

            // start with the SalesPerson view, all products
            _btnSalesperson.PerformClick();
            _btnAllPrices.PerformClick();
        }

        //------------------------------------------------------------------------
        #region ** handle clicks on view buttons

        void _btnSalesperson_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
            BuildView("Salesperson");
        }
        void _btnProduct_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
            BuildView("ProductName");
        }
        void _btnCountry_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
            BuildView("Country");
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** handle clicks on price filter buttons

        void _btnExpensive_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
            SetPriceFilter("Expensive Products (price > $50)", 50, double.MaxValue);
        }
        void _btnModerate_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
            SetPriceFilter("Moderately Priced Products ($20 < price < $50)", 20, 50);
        }
        void _btnInexpensive_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
            SetPriceFilter("Inexpensive Products (price < $20)", 0, 20);
        }
        void _btnAllProducts_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
            SetPriceFilter("All Products", 0, double.MaxValue);
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** generate report

        void _btnReport_Click(object sender, EventArgs e)
        {
            using (var dlg = new C1.Win.FlexPivot.C1FlexPivotPrintPreviewDialog())
            {
                dlg.Document = c1FlexPivotPrintDocument1;
                dlg.StartPosition = FormStartPosition.Manual;
                dlg.Bounds = this.Bounds;
                dlg.ShowDialog(this);
            }
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** implementation

        // rebuild the view after a button was clicked
        void BuildView(string fieldName)
        {
            // get FlexPivot engine
            var fp = c1FlexPivotPanel1.PivotEngine;

            // stop updating until done
            fp.BeginUpdate();

            // clear all fields
            fp.RowFields.Clear();
            fp.ColumnFields.Clear();
            fp.ValueFields.Clear();

            // format order dates to group by year
            var f = fp.Fields["OrderDate"];
            f.Format = "yyyy";

            // build up view
            fp.ColumnFields.Add("OrderDate");
            fp.RowFields.Add(fieldName);
            fp.ValueFields.Add("ExtendedPrice");

            // restore updates
            fp.EndUpdate();
        }

        // apply a filter to the product price
        void SetPriceFilter(string footerText, double min, double max)
        {
            // get FlexPivot engine
            var fp = c1FlexPivotPanel1.PivotEngine;

            // stop updating until done
            fp.BeginUpdate();

            // make sure unit price field is active in the view
            var field = fp.Fields["UnitPrice"];
            fp.FilterFields.Add(field);

            // customize the filter
            var filter = field.Filter;
            filter.Clear();
            filter.Condition1.Operator = C1.PivotEngine.ConditionOperator.GreaterThanOrEqualTo;
            filter.Condition1.Parameter = min;
            filter.Condition2.Operator = C1.PivotEngine.ConditionOperator.LessThanOrEqualTo;
            filter.Condition2.Parameter = max;

            // restore updates
            fp.EndUpdate();

            // set report footer
            c1FlexPivotPrintDocument1.FooterText = footerText;
        }

        // show which button was pressed
        void CheckButton(object pressedButton)
        {
            var btn = pressedButton as ToolStripButton;
            btn.Checked = true;

            var items = btn.Owner.Items;
            var index = items.IndexOf(btn);
            for (int i = index + 1; i < items.Count; i++)
            {
                if (items[i] is ToolStripButton)
                {
                    ((ToolStripButton)items[i]).Checked = false;
                }
                else
                {
                    break;
                }
            }
            for (int i = index - 1; i > 0 && !(items[i] is ToolStripSeparator); i--)
            {
                if (items[i] is ToolStripButton)
                {
                    ((ToolStripButton)items[i]).Checked = false;
                }
                else
                {
                    break;
                }
            }
        }

        // get standard nwind mdb connection string
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
        #endregion
    }
}
