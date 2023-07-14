using System;
using System.Linq;
using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;

namespace ControlExplorer.FlexGrid
{
    public partial class HoverStyle : C1DemoForm
    {
        public HoverStyle()
        {
            InitializeComponent();
            Load += HoverStyle_Load;

            Enum.GetValues(typeof(HoverMode)).Cast<HoverMode>().ToList().ForEach(x => rbHoverMode.Items.Add(x.ToString()));
            Enum.GetValues(typeof(SelectionModeEnum)).Cast<SelectionModeEnum>().ToList().ForEach(x => rbSelectMode.Items.Add(x.ToString()));
            rbHoverMode.SelectedIndex = 3;
            rbSelectMode.SelectedIndex = 0;

            c1FlexGrid1.DataSource = DemoDataSource("EmployeeOrders");
        }

        private void HoverStyle_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.Styles.Hover.BackColor = rbHoverColor.Color;
        }

        private void rbHoverMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.HoverMode = (HoverMode)Enum.Parse(typeof(HoverMode), rbHoverMode.Text);
        }

        private void rbSelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.SelectionMode = (SelectionModeEnum)Enum.Parse(typeof(SelectionModeEnum), rbSelectMode.Text);
        }

        private void rbHoverColor_SelectedColorChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.Styles.Hover.BackColor = rbHoverColor.Color;
        }
    }
}
