using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetGrid();
            FillReceiptGrid();
        }

        private void SetGrid()
        {
            grid.Cols.Count = 7;
            grid.Rows.Count = 1;
            grid.Rows.Fixed = 1;

            grid.SetData(0, 0, "Receipt #");
            grid.Cols[0].TextAlign = TextAlignEnum.LeftCenter;
            grid.Cols[0].TextAlignFixed = TextAlignEnum.LeftCenter;
            grid.Cols[0].Width = 70;

            grid.SetData(0, 1, "Deposit #");
            grid.Cols[1].TextAlign = TextAlignEnum.LeftCenter;
            grid.Cols[1].TextAlignFixed = TextAlignEnum.LeftCenter;
            grid.Cols[1].Width = 70;

            grid.SetData(0, 2, "Bank ID");
            grid.Cols[2].TextAlign = TextAlignEnum.LeftCenter;
            grid.Cols[2].TextAlignFixed = TextAlignEnum.LeftCenter;
            grid.Cols[2].Width = 95;

            grid.SetData(0, 3, "Amount");
            grid.Cols[3].TextAlign = TextAlignEnum.RightCenter;
            grid.Cols[3].TextAlignFixed = TextAlignEnum.RightCenter;
            grid.Cols[3].Width = 95;

            grid.SetData(0, 4, "DEP Date");
            grid.Cols[4].TextAlign = TextAlignEnum.LeftCenter;
            grid.Cols[4].TextAlignFixed = TextAlignEnum.LeftCenter;
            grid.Cols[4].Width = 80;

            grid.SetData(0, 5, "Check #");
            grid.Cols[5].TextAlign = TextAlignEnum.LeftCenter;
            grid.Cols[5].TextAlignFixed = TextAlignEnum.LeftCenter;
            grid.Cols[5].Width = 65;

            grid.SetData(0, 6, "Void Date");
            grid.Cols[6].TextAlign = TextAlignEnum.LeftCenter;
            grid.Cols[6].TextAlignFixed = TextAlignEnum.LeftCenter;
            grid.Cols[6].Width = 80;
        }

        private void FillReceiptGrid()
        {
            grid.Rows.Count = 1;

            grid.Rows.Count += 1;
            grid.SetData(1, 0, "100001");
            grid.SetData(1, 1, "1001");
            grid.SetData(1, 2, 1);
            grid.SetData(1, 3, 1000.39);
            grid.SetData(1, 4, "11/03/2009");
            grid.SetData(1, 5, 1000);
            grid.SetData(1, 6, "11/03/2009");

            grid.Rows.Count += 1;
            grid.SetData(2, 0, "100002");
            grid.SetData(2, 1, "1002");
            grid.SetData(2, 2, 2);
            grid.SetData(2, 3, 444.12);
            grid.SetData(2, 4, "11/01/2009");
            grid.SetData(2, 5, 2000);
            grid.SetData(2, 6, "11/02/2009");

            grid.Rows.Count += 1;
            grid.SetData(3, 0, "100003");
            grid.SetData(3, 1, "1003");
            grid.SetData(3, 2, 1);
            grid.SetData(3, 3, 999.27);
            grid.SetData(3, 4, "10/31/2009");
            grid.SetData(3, 5, 1111);
            grid.SetData(3, 6, "11/02/2009");

            grid.Rows.Count += 1;
            grid.SetData(4, 0, "100004");
            grid.SetData(4, 1, "1004");
            grid.SetData(4, 2, 3);
            grid.SetData(4, 3, 567.89);
            grid.SetData(4, 4, "11/04/2009");
            grid.SetData(4, 5, 1321);
            grid.SetData(4, 6, "11/07/2009");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var n = grid.Rows.Count;
            grid.Rows.Count += 1;
            grid.SetData(n, 0, "100006");
            grid.SetData(n, 1, "1008");
            grid.SetData(n, 2, 1);
            grid.SetData(n, 3, 123.45);
            grid.SetData(n, 4, "10/14/2009");
            grid.SetData(n, 5, 2222);
            grid.SetData(n, 6, "10/15/2009");
        }
    }
}
