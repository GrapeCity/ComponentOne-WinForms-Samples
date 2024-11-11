using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualStyles
{
    public partial class Form1 : C1.Win.Ribbon.C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbOuterStyle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbOuterStyle.SelectedIndex >= 0)
            {
                c1SplitContainer1.VisualStyle = (C1.Win.C1SplitContainer.VisualStyle)Enum.
                    Parse(typeof(C1.Win.C1SplitContainer.VisualStyle),
                    (string)cbOuterStyle.SelectedItem, false);
            }
        }

        private void btnOuterReset_Click(object sender, EventArgs e)
        {
            cbOuterStyle.SelectedIndex = -1;
            c1SplitContainer1.ResetVisualStyle();
        }

        private void cbInnerStyle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbInnerStyle.SelectedIndex >= 0)
            {
                c1SplitContainer2.VisualStyle = (C1.Win.C1SplitContainer.VisualStyle)Enum.
                    Parse(typeof(C1.Win.C1SplitContainer.VisualStyle),
                    (string)cbInnerStyle.SelectedItem, false);
            }
        }

        private void btnInnerReset_Click(object sender, EventArgs e)
        {
            cbInnerStyle.SelectedIndex = -1;
            c1SplitContainer2.ResetVisualStyle();
        }

        private void cbPanelStyle_ChangeCommitted(object sender, EventArgs e)
        {
            if (cbPanelStyle.SelectedIndex >= 0)
            {
                c1InputPanel1.VisualStyle = (C1.Win.C1InputPanel.VisualStyle)Enum.
                    Parse(typeof(C1.Win.C1InputPanel.VisualStyle),
                    (string)cbPanelStyle.SelectedOption.Text, false);
            }
        }

        private void btnPanelReset_Click(object sender, EventArgs e)
        {
            cbPanelStyle.SelectedIndex = -1;
            c1InputPanel1.ResetVisualStyle();
        }
    }
}
