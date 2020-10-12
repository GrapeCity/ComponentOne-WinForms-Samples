using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConditionalFormatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get data
            var da = new OleDbDataAdapter("select * from invoices", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);

            // bind to FlexPivot page
            this.c1FlexPivotPage1.DataSource = dt;

            // initialize view
            var def = Properties.Settings.Default.ViewDefinition;
            def = null;
            if (string.IsNullOrEmpty(def))
            {
                // initialize view in code
                var fp = this.c1FlexPivotPage1.FlexPivotEngine;
                fp.RowFields.Add("ProductName");
                fp.ColumnFields.Add("Country");
                fp.ValueFields.MaxItems = 5;
                fp.ValueFields.Add("ExtendedPrice", "Freight");

                // set up conditional formats in code
                foreach (var f in fp.ValueFields)
                {
                    // show top 10% of the values in bold, with a green background
                    var sh = f.StyleHigh;
                    sh.ConditionType = C1.FlexPivot.ConditionType.Percentage;
                    sh.Value = 0.9;
                    sh.BackColor = Color.FromArgb(230, 255, 230);
                    sh.FontBold = true;

                    // show bottom 10% of the values in bold, with a red background
                    var sl = f.StyleLow;
                    sl.ConditionType = C1.FlexPivot.ConditionType.Percentage;
                    sl.Value = 0.1;
                    sl.BackColor = Color.FromArgb(255, 230, 230);
                    sl.FontBold = true;
                }
            }
            else
            {
                // load view definition saved in previous runs
                this.c1FlexPivotPage1.ViewDefinition = def;
            }
        }

        // save view when closing
        protected override void OnClosing(CancelEventArgs e)
        {
            var def = this.c1FlexPivotPage1.ViewDefinition;
            Properties.Settings.Default.ViewDefinition = def;
            Properties.Settings.Default.Save();

            base.OnClosing(e);
        }

        // get connection string to sample database
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
