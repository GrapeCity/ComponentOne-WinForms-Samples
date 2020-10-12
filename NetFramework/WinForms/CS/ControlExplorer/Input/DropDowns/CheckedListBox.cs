using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace ControlExplorer.Input.DropDowns
{
    public partial class CheckedListBox : DropDownForm
    {
        public CheckedListBox()
        {
            InitializeComponent();
            
        }
        public CheckedListBox(string[] items)
        {
            InitializeComponent();
            foreach (string item in items)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void CheckedListBox_Open(object sender, EventArgs e)
        {
            //Check items which are included in text (useful if used as a grid editor)
            string s = OwnerControl.Text;
            for (int i = 0; i < checkedListBox1.Items.Count; i++ )
            {
                if (s.Contains(checkedListBox1.Items[i].ToString()))
                    checkedListBox1.SetItemChecked(i, true);
                else
                    checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void CheckedListBox_PostChanges(object sender, EventArgs e)
        {
            //Format selected items into comma separated list
            string conc = "";
            foreach (string item in checkedListBox1.CheckedItems)
            {
                conc += item + ", ";
            }
            if (conc.Length > 0)
                conc = conc.Remove(conc.LastIndexOf(','), 2);
            OwnerControl.Value = conc;
        }
    }
}
