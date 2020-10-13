using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.MultiSelect
{
    public partial class CheckList : C1DemoForm
    {
        public CheckList()
        {
            InitializeComponent();

            this.c1CheckList1.ShowSelectAll = true;
            this.c1CheckList1.BindingInfo.DataSource = Customer.GetCustomers();
            this.c1CheckList1.BindingInfo.DisplayMemberPath = "Country";
            this.c1CheckList1.BindingInfo.CheckedMemberPath = "IsLicensed";

            AddProperty("ShowCheckBoxes", c1CheckList1);
            AddProperty("ShowSelectAll", c1CheckList1);
            AddProperty("SelectionMode", c1CheckList1);
            AddProperty("SelectAllCaption", c1CheckList1);
            AddProperty("UnselectAllCaption", c1CheckList1);
        }
    }
}
