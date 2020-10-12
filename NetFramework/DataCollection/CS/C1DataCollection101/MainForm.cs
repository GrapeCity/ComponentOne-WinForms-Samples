using System;
using System.Windows.Forms;

namespace C1DataCollection101
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


        }

        private void menu1_SelectionChanged(object sender, EventArgs e)
        {
            switch(menu1.SelectedSampleViewType)
            {
                case 0:
                    tabControl1.SelectedIndex = 1;
                    sorting1.ShowPage(menu1);
                    break;
                case 1:
                    tabControl1.SelectedIndex = 2;
                    filtering1.ShowPage(menu1);
                    break;
                case 2:
                    tabControl1.SelectedIndex = 3;
                    grouping1.ShowPage(menu1);
                    break;
                case 3:
                    tabControl1.SelectedIndex = 4;
                    virtualMode1.ShowPage(menu1);
                    break;
                default:
                    tabControl1.SelectedIndex = 0;
                    break;
            }
        }
    }
}
