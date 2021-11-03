using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TrueDBGridExplorer.Samples
{
    public partial class ThreeStatesCheckBox : UserControl
    {
        private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        
        public ThreeStatesCheckBox()
        {
            InitializeComponent();

            c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            ((ISupportInitialize)c1TrueDBGrid1).BeginInit();
            SuspendLayout();
            c1TrueDBGrid1.AllowRowSelect = false;
            c1TrueDBGrid1.Dock = DockStyle.Fill;
            var resources = new ComponentResourceManager(typeof(ThreeStatesCheckBox));
            c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            Controls.Add(c1TrueDBGrid1);
            ((ISupportInitialize)c1TrueDBGrid1).EndInit();
            ResumeLayout(false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            int maxrows = 100;
            DataTable dt = new("testdatatable");

            DataColumn dc;
            DataRow dr;

            // row number
            dc = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "RowNum"
            };
            dt.Columns.Add(dc);

            // set up an integer column - this will be our checkbox column
            dc = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Integer"
            };
            dt.Columns.Add(dc);

            // string column
            dc = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "String"
            };
            dt.Columns.Add(dc);

            // date
            dc = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                ColumnName = "Date"
            };
            dt.Columns.Add(dc);

            Random random = new();
            for (int i = 0; i < maxrows; i++)
            {
                dr = dt.NewRow();
                dr[0] = i;
                // the "Integer" column has 3 values corresponding to the 3 states the checkbox can have
                dr[1] = (int)(random.NextDouble() * 3.0);
                dr[2] = "Row: " + i.ToString();
                dr[3] = DateTime.Now;
                dt.Rows.Add(dr);
            }
            c1TrueDBGrid1.SetDataBinding(dt, "", true);
            c1TrueDBGrid1.Splits[0].ExtendRightColumn = true;

            SetTreeStateCheckBox();
        }

        private void SetTreeStateCheckBox()
        {
            var items = c1TrueDBGrid1.Columns["Integer"].ValueItems;
            // we're going to translate values - the datasource needs to hold at least 3 states
            items.Translate = true;
            // each click will cycle thru the various checkbox states
            items.CycleOnClick = true;
            // display the cell as a checkbox
            items.Presentation = C1.Win.TrueDBGrid.PresentationEnum.CheckBox;
            // now associate underlying db values with the checked state
            items.Values.Clear();
            items.Values.Add(new C1.Win.TrueDBGrid.ValueItem("0", false)); // unchecked
            items.Values.Add(new C1.Win.TrueDBGrid.ValueItem("1", true));  // checked
            items.Values.Add(new C1.Win.TrueDBGrid.ValueItem("2", "INDETERMINATE")); // indeterminate state
        }
    }
}
