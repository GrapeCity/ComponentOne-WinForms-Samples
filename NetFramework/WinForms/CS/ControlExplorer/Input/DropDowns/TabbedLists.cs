using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Input.DropDowns
{
    public partial class TabbedLists : C1.Win.C1Input.DropDownForm
    {
        public TabbedLists()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            OwnerControl.Text = lb.GetItemText(lb.SelectedItem);
            CloseDropDown(true);
        }
    }
}
