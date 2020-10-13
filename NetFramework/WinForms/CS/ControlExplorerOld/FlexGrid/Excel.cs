using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class Excel : C1DemoForm
    {
        public Excel()
        {
            InitializeComponent();
        }

        private void Printing_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = DemoDataSource("Products2");
            c1FlexGrid1.Cols["ProductID"].Width = 65;

            //Freeze some rows for demonstration purposes
            c1FlexGrid1.Rows.Frozen = 8;

            //Apply red background to cells in UnitsInStock column with value less than 20
            CellStyle cs = c1FlexGrid1.Styles.Add("LowStock");
            cs.BackColor = Color.Red;
            cs.ForeColor = Color.White;
            foreach (Row r in c1FlexGrid1.Rows)
            {
                if (r.Index < 1) continue;
                int u = int.Parse(r["UnitsInStock"].ToString());
                if (u < 20)
                    c1FlexGrid1.SetCellStyle(r.Index, c1FlexGrid1.Cols["UnitsInStock"].Index, c1FlexGrid1.Styles["LowStock"]);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.PrintGrid("Products", C1.Win.C1FlexGrid.PrintGridFlags.ShowPreviewDialog);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //This function saves and launches Excel file from FlexGrid
            //Diplay custom ExportOptions dialog first to select FileFlags
            ExportOptions options = new ExportOptions();
            if (options.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (options.Flags.ToString().Contains("OpenXml"))
                    sfd.Filter = "Excel OpenXml (*.xlsx)|*.xlsx";
                else
                    sfd.Filter = "Excel (*.xls)|*.xls";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    c1FlexGrid1.SaveExcel(sfd.FileName, options.Flags);
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //This function displays an OpenFileDialog allowing user to select any Excel file from their machine
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel (*.xls, *.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Load selected Excel File
                    c1FlexGrid1.DataSource = null;
                    c1FlexGrid1.LoadExcel(ofd.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to open Excel file: " + ex.Message);
                }
            }
        }

    }
}
