using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using FlexGridExplorer.Data;

namespace FlexGridExplorer.Samples
{
    public partial class HoverStyle : UserControl
    {
        public HoverStyle()
        {
            InitializeComponent();

            InitData();

            Enum.GetValues(typeof(HoverMode)).Cast<HoverMode>().ToList().ForEach(x => cbHoverMode.Items.Add(x.ToString()));
            Enum.GetValues(typeof(SelectionModeEnum)).Cast<SelectionModeEnum>().ToList().ForEach(x => cbSelectMode.Items.Add(x.ToString()));
            cbHoverMode.SelectedIndex = 3;
            cbSelectMode.SelectedIndex = 0;

            c1FlexGrid1.Styles.Hover.BackColor = Color.LightGreen;
        }

        private void InitData()
        {
            var dataTable = DataSource.GetRows("Select * from Orders");
            c1FlexGrid1.DataSource = dataTable;
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    c1FlexGrid1.Styles.Hover.BackColor = colorDialog.Color;
                }
            }
        }

        private void cbHoverMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.HoverMode = (HoverMode)Enum.Parse(typeof(HoverMode), cbHoverMode.Text);
        }

        private void cbSelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.SelectionMode = (SelectionModeEnum)Enum.Parse(typeof(SelectionModeEnum), cbSelectMode.Text);
        }
    }
}
