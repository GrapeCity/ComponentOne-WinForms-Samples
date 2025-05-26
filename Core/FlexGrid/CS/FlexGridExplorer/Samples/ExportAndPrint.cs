using C1.Win.FlexGrid;
using FlexGridExplorer.Data;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class ExportAndPrint : UserControl
    {
        public ExportAndPrint()
        {
            InitializeComponent();
        }
        private void ExportAndPrint_Load(object sender, EventArgs e)
        {
            var dt = DataSource.GetRows("select ProductId, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, Discontinued from products");
            ConvertDiscontinuedColumn(dt);
            c1FlexGrid1.DataSource = dt;
            c1FlexGrid1.Cols["ProductID"].Width = 65;

            //Freeze some rows for demonstration purposes
            c1FlexGrid1.Rows.Frozen = 2;

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

        void ConvertDiscontinuedColumn(DataTable dt)
        {
            if (!dt.Columns.Contains("Discontinued"))
                return;

            // Create a new boolean column
            dt.Columns.Add("DiscontinuedBool", typeof(bool));

            // Copy values from the old column (0 -> false, 1 -> true)
            foreach (DataRow row in dt.Rows)
            {
                row["DiscontinuedBool"] = Convert.ToInt32(row["Discontinued"]) == 1;
            }

            // Remove the old column and rename the new column
            dt.Columns.Remove("Discontinued");
            dt.Columns["DiscontinuedBool"].ColumnName = "Discontinued";
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.PrintGrid("Products", C1.Win.FlexGrid.PrintGridFlags.ShowPreviewDialog);
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
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });

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
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open Excel file: " + ex.Message);
                }
            }
        }
    }
}
