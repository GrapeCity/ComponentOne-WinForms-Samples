using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace ControlExplorer.Input
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Products' table.
            this.productsTableAdapter.Fill(this.c1DemoDataSet.Products);
            // TODO: This line of code loads data into the 'c1DemoDataSet.Employees' table.
            this.employeesTableAdapter.Fill(this.c1DemoDataSet.Employees);
        }

        private void c1DbNavigator1_Error(object sender, NavigatorErrorEventArgs e)
        {
            MessageBox.Show("Error");
        }

        //clears DataBindings of the C1TextBox control or any child C1TextBox controls.
        void ClearC1Bindings(Control control)
        {
            if (control is C1TextBox)
            {
                ((C1TextBox)control).DataBindings.Clear();
            }
            else // do it recursive
            {
                foreach (Control c in control.Controls)
                {
                    ClearC1Bindings(c);
                }
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            //we're leaving the form
            if (this.Parent == null)
                ClearC1Bindings(this);
            base.OnParentChanged(e);
        }
    }
}
