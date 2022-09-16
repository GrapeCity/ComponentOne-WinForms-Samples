using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccordionExplorer.Samples
{
    public partial class SimpleMenu : UserControl
    {
        public SimpleMenu()
        {
            InitializeComponent();
        }

        private void c1Accordion1_PageHeaderClick(object sender, C1.Win.Accordion.PageHeaderClickEventArgs e)
        {
            switch (e.Page.Name)
            {
                case "HomePage":
                    label1.Text = "Home Content";
                    break;
                case "DataPage":
                    label1.Text = "Data Content";
                    break;
                case "ChartPage":
                    label1.Text = "Chart Content";
                    break;
            }
        }
    }
}
