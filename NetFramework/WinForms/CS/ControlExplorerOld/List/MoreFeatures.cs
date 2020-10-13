using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.List
{
    public partial class MoreFeatures : C1DemoForm
    {
        Random rnd;
        public MoreFeatures()
        {
            InitializeComponent();          
        }

        private void MoreFeatures_Load(object sender, EventArgs e)
        {
            rnd = new Random();

            //call HoldFields to preserve all design-time settings before setting datasource
            c1List1.HoldFields();
            c1List1.DataSource = DemoDataSource("Suppliers");

            c1Combo1.HoldFields();
            c1Combo1.DataSource = DemoDataSource("Suppliers");

            // fix column
            c1Combo1.Splits[0].DisplayColumns["ContactName"].FixColumn(true);

            //add demo properties
            AddProperty("CellTips", c1List1);
            AddProperty("ScrollTips", c1List1);
            AddProperty("ScrollTrack", c1List1);
            AddProperty("SelectionMode", c1List1);   
        }

        private void c1List1_UnboundColumnFetch(object sender, C1.Win.C1List.UnboundColumnFetchEventArgs e)
        {
            //fill random unbound column data
            if (e.Col == 3)
                e.Value = e.Row % 2 == 0 ? "true" : "false";
            else if (e.Col == 4)
                e.Value = (e.Row % 4).ToString();
        }

        private void btnHorizontalSplit_Click(object sender, EventArgs e)
        {
            c1List1.InsertHorizontalSplit(0);
        }

        private void btnVerticalSplit_Click(object sender, EventArgs e)
        {
            c1List1.InsertVerticalSplit(0);
        }

        private void c1List1_FetchScrollTips(object sender, C1.Win.C1List.FetchScrollTipsEventArgs e)
        {
            //set the ScrollTip depending on which scroll bar was moved
            switch (e.ScrollBar)
            {
                case C1.Win.C1List.ScrollBarEnum.Horizontal:
                    e.ScrollTip = this.c1List1.Columns[e.ColIndex].Caption;
                    break;
                case C1.Win.C1List.ScrollBarEnum.Vertical:
                    e.ScrollTip = "Record: " + (e.Row + 1) + " of " +
                        this.c1List1.ListCount + "\n";
                    e.ScrollTip += "Company: " + this.c1List1.Columns["CompanyName"].CellText(e.Row) + "\n";
                    break;
            }
            e.TipStyle.BackColor = Color.White;
            e.TipStyle.ForeColor = Color.Black;
        }
    }
}
