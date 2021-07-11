using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace DemoTables
{
    partial class PropGrid : Form
    {
        public PropGrid(Control ctrl)
        {
            InitializeComponent();
            _addKids(ctrl);
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = comboBox1.SelectedItem;
        }

        private void _addKids(Control c)
        {
            foreach (Control cc in c.Controls)
            {
                comboBox1.Items.Add(cc);
                _addKids(cc);
            }
        }

        private void Properties_Load(object sender, EventArgs e)
        {
        }
    }
}
