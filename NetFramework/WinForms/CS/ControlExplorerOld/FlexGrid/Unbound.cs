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
    public partial class Unbound : C1DemoForm
    {
        //Store column indexes
        private int procCol = 2;
        private int payCol = 3;
        private int gmCol = 4;
        private int gmrCol = 5;
        private int devCol = 6;
        Random rand;
        //Pool of sample data
        private double[] values = { 9000, 8000, 6000, 500, 20000, 10000, 45000, 75000, 7000, 3000 };

        public Unbound()
        {
            InitializeComponent();
        }

        private void Unbound_Load(object sender, EventArgs e)
        {
            rand = new Random();
            //Set AllowMerging to Spill meaning empty adjacent cells will allow long text to spill (similar to Excel)
            c1FlexGrid1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Spill;

            //Create some CellStyles
            CellStyle cs = c1FlexGrid1.Styles.Add("Up");
            cs.BackColor = Color.FromArgb(133, 236, 133);
            cs = c1FlexGrid1.Styles.Add("Down");
            cs.BackColor = Color.FromArgb(255, 150, 110);
            cs = c1FlexGrid1.Styles.Add("Heading");
            cs.Font = new Font(c1FlexGrid1.Font, FontStyle.Bold);

            //Load data
            LoadData();
        }

        private void c1FlexGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            //After edit, apply new changes to calculated columns
            if (isHeaderRow(e.Row))
            {
                //If header row remove all numeric data if it exists and apply custom Heading CellStyle
                ClearRow(e.Row);
                this.c1FlexGrid1.SetCellStyle(e.Row, 0, c1FlexGrid1.Styles["Heading"]);
            }
            else
            {
                //Calculate new totals for current row
                CalculateGrossMargins(e.Row);
                CalculateDeviation(e.Row);
            }
            //Calculate new deviation for adjacent affected row
            CalculateDeviation(e.Row + 1);       
        }

        private void CalculateGrossMargins(int row)
        {
            //this function calculates gross margin and gross margin rate given row's proceeds and payments values
            double proceeds = this.c1FlexGrid1[row, procCol] == null ? 0 : double.Parse(this.c1FlexGrid1[row, procCol].ToString());
            double payments = this.c1FlexGrid1[row, payCol] == null ? 0 : double.Parse(this.c1FlexGrid1[row, payCol].ToString());
            double grossMargin = proceeds - payments;
            double grossMarginRate = proceeds != 0 ? grossMargin / proceeds : 0;
            this.c1FlexGrid1[row, gmCol] = grossMargin;
            this.c1FlexGrid1[row, gmrCol] = grossMarginRate;
        }

        private void CalculateDeviation(int row)
        {
            //This function calculates gross margin rate deviation from previous row
            if (this.c1FlexGrid1[row, gmrCol] == null)
                return;

            if (this.c1FlexGrid1[row - 1, gmrCol] == null)
                return;

            double grossMarginRate = (double)this.c1FlexGrid1[row, gmrCol];
            double previousDateRate;
            //Try to grab previous rows GMR
            if (double.TryParse(this.c1FlexGrid1[row - 1, gmrCol].ToString(), out previousDateRate))
            {
                //If exists, calculate difference and apply Up or Down CellStyle accordingly
                Double dev = grossMarginRate - previousDateRate;

                if (dev > 0.0001)
                {
                    this.c1FlexGrid1[row, devCol] = dev;
                    this.c1FlexGrid1.SetCellStyle(row, devCol, c1FlexGrid1.Styles["Up"]);
                    this.c1FlexGrid1.SetCellImage(row, devCol, imageList1.Images["Up.png"]);
                }
                else if (dev < 0.0001 && dev > -0.0001)
                    this.c1FlexGrid1[row, devCol] = 0.000;
                else
                {
                    this.c1FlexGrid1[row, devCol] = dev;
                    this.c1FlexGrid1.SetCellStyle(row, devCol, c1FlexGrid1.Styles["Down"]);
                    this.c1FlexGrid1.SetCellImage(row, devCol, imageList1.Images["Down.png"]);
                }
            }
            else
            {
                this.c1FlexGrid1[row, devCol] = 0;
            }

        }

        private void ClearRow(int row)
        {
            //This function clears a row of data, style and images, skipping the 0th column
            for (int i = 1; i < c1FlexGrid1.Cols.Count; i++)
            {
                c1FlexGrid1[row, i] = null;
            }
            c1FlexGrid1.SetCellStyle(row, devCol, c1FlexGrid1.Styles["Normal"]);
            c1FlexGrid1.SetCellImage(row, devCol, null);
            
        }

        private void LoadData()
        {
            //This function loads random data from our pool of possible values
            this.c1FlexGrid1[1, 0] = "Quarter 1: " + DateTime.Now.ToShortDateString() + " to " + DateTime.Now.AddDays(9).ToShortDateString();
            this.c1FlexGrid1.SetCellStyle(1, 0, c1FlexGrid1.Styles["Heading"]);
            for (int i = 2; i < 12; i++)
            {
                this.c1FlexGrid1[i, 1] = DateTime.Now.AddDays(i - 2);
                this.c1FlexGrid1[i, 2] = values[rand.Next(0, 9)];
                this.c1FlexGrid1[i, 3] = values[rand.Next(0, 9)];
                CalculateGrossMargins(i);
                CalculateDeviation(i);
            }
            this.c1FlexGrid1[12, 0] = "Quarter 2: " + DateTime.Now.AddDays(10).ToShortDateString() + " to " + DateTime.Now.AddDays(20).ToShortDateString() + " (Notice this text spills across empty cells)";
            this.c1FlexGrid1.SetCellStyle(12, 0, c1FlexGrid1.Styles["Heading"]);
            this.c1FlexGrid1[13, 1] = DateTime.Now.AddDays(10);
            this.c1FlexGrid1[13, 2] = values[rand.Next(0, 9)];
            this.c1FlexGrid1[13, 3] = values[rand.Next(0, 9)];
            CalculateGrossMargins(13);
            CalculateDeviation(13);
        }

        //This function is used internally to determine if a row is a Header or data row.
        //Returns true if Header row (contains text in 0th column)
        private bool isHeaderRow(int index)
        {
            if (c1FlexGrid1[index, 0] != null)
                return true;
            else
                return false;
        }

        private void c1FlexGrid1_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            // if we begin to edit auto fill the date field
            if (e.Row > 1 && (e.Col == 2 || e.Col == 3))
            {
                if (c1FlexGrid1[e.Row, 1] == null)
                    if (c1FlexGrid1[e.Row - 1, 1] != null)
                        c1FlexGrid1[e.Row, 1] = ((DateTime)c1FlexGrid1[e.Row - 1, 1]).AddDays(1);
            }
        }
    }
}
