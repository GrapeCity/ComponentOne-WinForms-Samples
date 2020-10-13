using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.SuperTooltip
{
    public partial class GridTooltips : C1DemoForm
    {
        public GridTooltips()
        {
            InitializeComponent();
        }

        private void GridTooltips_Load(object sender, EventArgs e)
        {
            c1SuperTooltip1.SetToolTip(newToolStripButton, "here it is");
            toolStrip1.ShowItemToolTips = false;

            c1FlexGrid1.DataSource = DemoDataSource("Employees");
            c1FlexGrid1.AutoSizeCols();

            //Assign Notes text to each row's UserData
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                c1FlexGrid1.Rows[i].UserData = c1FlexGrid1[i, c1FlexGrid1.Cols["Notes"].Index];
            }
            c1FlexGrid1.Cols["Notes"].Visible = false;
            //AddTipsToToolStrip(toolStrip1);
        }

        int _row;
        private void c1FlexGrid1_MouseEnterCell(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Row < 1 || e.Row == _row)
                return;

            //this.c1SuperTooltip1.SetToolTip(c1FlexGrid1, c1FlexGrid1.Rows[e.Row].UserData.ToString());
            _row = e.Row;
        }

        private void c1FlexGrid1_MouseLeaveCell(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Row < 1 || e.Row == _row)
                return;

            //this.c1SuperTooltip1.Hide(c1FlexGrid1);
        }

        // add Html tooltips to items in a toolstrip
        private void AddTipsToToolStrip(ToolStrip toolStrip)
        {
            // do not show the default tooltips
            toolStrip.ShowItemToolTips = false;

            // att Html tooltips to each item in the toolStrip
            foreach (ToolStripItem item in toolStrip.Items)
            {
                // get tooltip text
                string text = item.ToolTipText;
                if (text != null && text.Length > 0)
                {
                    // get tooltip image
                    string image = string.Empty;
                    if (item.Image != null)
                    {
                        string imageName = item.Name + ".Image";
                        image = "res://" + imageName;
                    }

                    // build tip
                    StringBuilder tip = new StringBuilder();
                    tip.AppendFormat("<table><tr><td><img src='{0}'><td style='font:bold 11pt Tahoma'>{1}</table>",
                        image,
                        text);

                    // append general 'get help' tip
                    if (item != this.helpToolStripButton)
                    {
                        tip.Append("<hr noshade size=1 color=lightBlue>");
                        tip.AppendFormat("<table><tr><td><img src='{0}'><td>{1}</table>",
                            "res://helpToolStripButton.Image",
                            "Press <b>F1</b> for more help.");
                    }

                    // assign tooltip to item
                    c1SuperTooltip1.SetToolTip(item, tip.ToString());
                }
            }
        }
    }
}
