using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResizeNormalCell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // create grid, add to form
            var f = new C1FlexGridResizer();
            f.Dock = DockStyle.Fill;
            Controls.Add(f);

            // populate grid
            var list = new List<Rectangle>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Rectangle(i, i, i, i));
            }
            f.DataSource = list;

            // remove fixed rows and columns
            f.Rows.Fixed = 0;
            f.Cols.Fixed = 0;
        }
    }
}
