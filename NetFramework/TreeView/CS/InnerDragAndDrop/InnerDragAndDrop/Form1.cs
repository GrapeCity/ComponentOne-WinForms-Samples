using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InnerDragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            c1TreeView1.AllowDrop = true;
            c1TreeView1.EnableDragDrop = true;
            for (int i = 0; i < 10; i++)
            {
                c1TreeView1.Nodes.Add("Node" + i);
                for (int j = 0; j < 5; j++)
                {
                    c1TreeView1.Nodes[i].Nodes.Add("Node" + (i * 10 + j));
                }
            }
        }
    }
}
