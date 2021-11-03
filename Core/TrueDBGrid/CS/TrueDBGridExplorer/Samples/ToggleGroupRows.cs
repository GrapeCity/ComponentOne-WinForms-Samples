using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrueDBGridExplorer.Samples
{
    using TrueDBGridExplorer.Data;

    public partial class ToggleGroupRows : UserControl
    {
        private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private RadioButton rbCollapseGroupRow;
        private RadioButton rbExpandGroupRow;
        private int _topPanelHeight = 38;

        public ToggleGroupRows()
        {
            InitializeComponent();

            var gridPanel = new Panel();
            gridPanel.Dock = DockStyle.Fill;
            Controls.Add(gridPanel);

            var topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = _topPanelHeight;
            Controls.Add(topPanel);

            InitializeRadioButtons(topPanel);

            InitializeTrueDBGrid(gridPanel);
        }

        private void InitializeRadioButtons(Panel topPanel)
        {
            var rbCollapseAll = new RadioButton
            {
                Text = "Collapse All",
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };
            rbCollapseAll.CheckedChanged += RBCollapseAll_CheckedChanged;
            topPanel.Controls.Add(rbCollapseAll);
            var rbExpandAll = new RadioButton
            {
                Text = "Expand All",
                Location = new Point(10 + rbCollapseAll.Right, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };
            rbExpandAll.CheckedChanged += RBExpandAll_CheckedChanged;
            topPanel.Controls.Add(rbExpandAll);
            rbCollapseGroupRow = new RadioButton
            {
                Text = "Collapse Group Row",
                Location = new Point(10 + rbExpandAll.Right, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };
            rbCollapseGroupRow.CheckedChanged += RBCollapseGroupRow_CheckedChanged;
            topPanel.Controls.Add(rbCollapseGroupRow);
            rbExpandGroupRow = new RadioButton
            {
                Text = "Expand Group Row",
                Location = new Point(10 + rbCollapseGroupRow.Right, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };
            rbExpandGroupRow.CheckedChanged += RBExpandGroupRow_CheckedChanged;
            topPanel.Controls.Add(rbExpandGroupRow);
        }

        private void InitializeTrueDBGrid(Panel gridPanel)
        {
            c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(c1TrueDBGrid1)).BeginInit();
            c1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.GroupBy;
            c1TrueDBGrid1.Dock = DockStyle.Fill;
            c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            c1TrueDBGrid1.RowColChange += C1TrueDBGrid1_RowColChange;
            gridPanel.Controls.Add(c1TrueDBGrid1);
            ((System.ComponentModel.ISupportInitialize)(c1TrueDBGrid1)).EndInit();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string sql = @"SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" +
                "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " +
                "ShipVia FROM Orders";
            c1TrueDBGrid1.DataSource = DataSource.GetRows(sql);
            // intialize the grid to be grouped by CustomerID on load
            this.c1TrueDBGrid1.GroupedColumns.Add(this.c1TrueDBGrid1.Columns["CustomerID"]);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
            _topPanelHeight = (int)(42 * factor.Height);            
        }

        private void C1TrueDBGrid1_RowColChange(object sender, C1.Win.TrueDBGrid.RowColChangeEventArgs e)
        {
            if ((c1TrueDBGrid1.Splits[0].Rows.Count <= 0) || (c1TrueDBGrid1.Splits[0].Rows[c1TrueDBGrid1.Row] == null)) 
                return;                                                                                                          
            C1.Win.TrueDBGrid.RowTypeEnum rtype = c1TrueDBGrid1.Splits[0].Rows[c1TrueDBGrid1.Row].RowType;
            switch (rtype)
            {
                case C1.Win.TrueDBGrid.RowTypeEnum.CollapsedGroupRow:
                    rbCollapseGroupRow.Checked = true;
                    break;
                case C1.Win.TrueDBGrid.RowTypeEnum.ExpandedGroupRow:
                    rbExpandGroupRow.Checked = true;
                    break;
            }
        }

        private void RBExpandGroupRow_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                int row = c1TrueDBGrid1.Row;
                if (c1TrueDBGrid1.Splits[0].Rows[row].RowType == C1.Win.TrueDBGrid.RowTypeEnum.CollapsedGroupRow)
                    c1TrueDBGrid1.ExpandGroupRow(row);
            }
        }

        private void RBCollapseGroupRow_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                int row = c1TrueDBGrid1.Row;
                if (c1TrueDBGrid1.Splits[0].Rows[row].RowType == C1.Win.TrueDBGrid.RowTypeEnum.ExpandedGroupRow)
                    c1TrueDBGrid1.CollapseGroupRow(row);
            }   
        }

        private void RBExpandAll_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                for (int i = 0; i < c1TrueDBGrid1.Splits[0].Rows.Count; i++)
                {
                    if (c1TrueDBGrid1.Splits[0].Rows[i].RowType != C1.Win.TrueDBGrid.RowTypeEnum.DataRow)
                        c1TrueDBGrid1.ExpandGroupRow(i);
                }
            }
        }

        private void RBCollapseAll_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                for (int i = 0; i < c1TrueDBGrid1.Splits[0].Rows.Count; i++)
                {
                    if (c1TrueDBGrid1.Splits[0].Rows[i].RowType != C1.Win.TrueDBGrid.RowTypeEnum.DataRow)
                        c1TrueDBGrid1.CollapseGroupRow(i);
                }
            }
        }
    }
}
