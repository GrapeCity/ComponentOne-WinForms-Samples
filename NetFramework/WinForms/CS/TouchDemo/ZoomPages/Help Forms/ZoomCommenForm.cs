using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchDemo.C1ZoomPages.Help_Forms
{
    public partial class C1ZoomCommenForm : Form
    {
        public C1ZoomCommenForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            this.treeView1.Nodes[0].Expand();

            this.dataGridView1.RowCount = 10;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < this.dataGridView1.ColumnCount; j++)
                {
                    this.dataGridView1[j, i].Value = i.ToString() + j;
                }
            }
        }
    }
}
