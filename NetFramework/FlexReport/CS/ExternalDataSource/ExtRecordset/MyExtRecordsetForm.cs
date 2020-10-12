using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExtRecordset
{
    public partial class MyExtRecordsetForm : Form
    {
        public MyExtRecordsetForm()
        {
            InitializeComponent();
        }

        public bool Edit(MyExtRecordset recordset)
        {
            tbRecCount.Text = recordset.RecCount.ToString();
            bool result = ShowDialog() == System.Windows.Forms.DialogResult.OK;
            if (result)
                recordset.RecCount = int.Parse(tbRecCount.Text);
            return result;
        }
    }
}
