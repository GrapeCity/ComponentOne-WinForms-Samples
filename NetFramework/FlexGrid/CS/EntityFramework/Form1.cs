using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        northwndEntities _ctx = new northwndEntities();

        public Form1()
        {
            InitializeComponent();

            // bind grid to sortable list
            var list = new SortableBindingList<Customer>(_ctx.Customers);
            _flex.AutoResize = true;
            _flex.DataSource = list;

            _flex.Cols["customerID"].AllowEditing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save changes, if any
            _ctx.SaveChanges();
        }
    }
}
