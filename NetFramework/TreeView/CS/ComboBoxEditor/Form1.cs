using SamplesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1TreeView1.BindingInfo.ParentKeyField = "ChiefID";
            c1TreeView1.BindingInfo.KeyField = "ID";
            c1TreeView1.BindingInfo.DataSource = Employee.GetData();
            c1TreeView1.Columns[2].DataMap = Country.GetCountries();
        }
    }
}
