using C1.CalcEngine;
using C1.CalcEngine.ExcelEngine;
using C1.Win.C1FlexGrid;
using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ExcelEngineSample
{
    public partial class Form1 : Form
    {
        private C1CalcEngine _calcEngine;
        private const string Abc = "ABCDEF";

        public Form1()
        {
            InitializeComponent();
            _calcEngine = new C1CalcEngine(new ExcelEngine());
            var sheet1 = GetDataTable("Sheet1");
            c1FlexGrid1.DataSource = sheet1;
            c1FlexGrid1.AllowSorting = AllowSortingEnum.None;
            for (int i = 1; i <= 80; i++)
                c1FlexGrid1.Rows[i][0] = i;
            c1FlexGrid1.AutoSizeCol(0);
            LoadUnboundGrid(sheet2);
            sheet2.AutoSizeCol(0);
            _calcEngine.DataSource = new List<IDataSheet> { sheet1, sheet2 };
            c1FlexGrid1.Select(1, 1, 2, 2);
            sheet2.Select(3, 2, 5, 3);
        }

        public SheetTable GetDataTable(string sheetName)
        {
            var table = new SheetTable(c1FlexGrid1);
            table.Name = sheetName;
            foreach(var c in Abc)
                table.Columns.Add(c.ToString(), typeof(int));
            for (int i = 0; i < 80; i++)
                table.Rows.Add(new object[] { i * 2, i * 3, i * 4, i * 5, i * 6, i * 7 });                
            return table;
        }

        private void LoadUnboundGrid(C1FlexGrid grid)
        {
            grid.Rows.Count = 81;
            grid.Cols.Count = 7;
            for (int i = 1; i <= Abc.Length; i++)
                grid.Rows[0][i] = Abc[i - 1];
            for (int i = 1; i <= 80; i++)
                grid.Rows[i][0] = i;
            for (int i = 0; i < 80; i++)
                for (int j = 1; j <= Abc.Length; j++)
                    grid.Rows[i + 1][j] = i * j;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            _calcEngine.Expression = textBox1.Text;
            if (_calcEngine.TryEvaluate(out object result))
                textBox2.Text = (result ?? "").ToString();
            else
                textBox2.Text = _calcEngine.GetErrors().FirstOrDefault()?.FullMessage ?? "";

        }

        private void grid_SelChange(object sender, System.EventArgs e)
        {
            textBox1.Text = string.Format("=Sum(sheet1!{0}) + Sum(sheet2!{1})", GetMark(c1FlexGrid1), GetMark(sheet2));
        }

        private string GetMark(C1FlexGrid grid)
        {
            var sel = grid.Selection;
            return string.Format("{0}{1}:{2}{3}", Abc[sel.LeftCol - 1], sel.TopRow, Abc[sel.RightCol - 1], sel.BottomRow);
        }

    }

    public class ExcelFlexGrid : C1FlexGrid, IDataSheet
    {
        public object GetValue(int col, int row) => Rows[row + 1][col + 1];
    }

    public class SheetTable : DataTable, IDataSheet
    {
        private readonly C1FlexGrid _grid;

        public SheetTable(C1FlexGrid grid) => _grid = grid;        

        public string Name
        {
            get => TableName;
            set => TableName = value;
        }

        public object GetValue(int col, int row)
        {
            return Rows[row][col];
        }
    }
}
