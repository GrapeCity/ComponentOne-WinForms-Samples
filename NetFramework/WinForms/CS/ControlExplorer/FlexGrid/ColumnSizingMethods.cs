using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnSizingMethods : C1DemoForm
    {
        public ColumnSizingMethods()
        {
            InitializeComponent();
        }

        private void ColumnSizingOptions_Load(object sender, EventArgs e)
        {
            SetupGrid();
            SetupComboBox();
        }

        private void SetupGrid()
        {
            flexGrid.DataSource = DemoDataSource("EmployeeOrders");
        }

        private void SetupComboBox()
        {
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbMethod.Items.Add("Fixed");
            cmbMethod.Items.Add("AutoSize");
            cmbMethod.Items.Add("ExtendLastColumn");
            cmbMethod.Items.Add("StarSize");

            cmbMethod.SelectedValueChanged += CmbMethod_SelectedValueChanged;

            cmbMethod.SelectedIndex = 3;
        }

        private void CmbMethod_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFixedSize();

            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                switch (cmb.GetItemText(cmb.SelectedItem))
                {
                    case "AutoSize":
                        flexGrid.AutoSizeCols();
                        break;
                    case "ExtendLastColumn":
                        flexGrid.ExtendLastCol = true;
                        break;
                    case "StarSize":
                        ApplyStarSize();
                        break;
                }
            }
        }

        private void ApplyFixedSize()
        {
            flexGrid.ExtendLastCol = false;

            var cols = flexGrid.Cols;

            for (var c = cols.Fixed; c < cols.Count; c++)
            {
                cols[c].Width = 95;
            }
        }

        private void ApplyStarSize()
        {
            var cols = flexGrid.Cols;

            for (var c = cols.Fixed; c < cols.Count; c++)
            {
                cols[c].MinWidth = 50;
            }

            cols["OrderID"].StarWidth = "*";
            cols["OrderDate"].StarWidth = "2*";
            cols["CompanyName"].StarWidth = "2*";
            cols["Country"].StarWidth = "2*";
            cols["Salesperson"].StarWidth = "2*";
            cols["Product"].StarWidth = "3*";
            cols["UnitPrice"].StarWidth = "*";
            cols["Quantity"].StarWidth = "*";
            cols["Discount"].StarWidth = "*";
            cols["ExtendedPrice"].StarWidth = "*";
        }
    }
}
