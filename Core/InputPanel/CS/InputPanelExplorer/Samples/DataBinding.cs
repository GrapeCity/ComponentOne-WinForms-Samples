using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputPanelExplorer.Samples
{
    public partial class DataBinding : UserControl
    {
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private InputPanelExplorer.C1DemoDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;

        public DataBinding()
        {
            InitializeComponent();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource();
            this.c1DemoDataSet = new InputPanelExplorer.C1DemoDataSet();
            this.employeesTableAdapter = new InputPanelExplorer.C1DemoDataSetTableAdapters.EmployeesTableAdapter();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            this.c1DemoDataSet.DataSetName = "C1DemoDataSet";
            this.c1DemoDataSet.Namespace = "http://tempuri.org/C1DemoDataSet.xsd";
            this.c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            this.c1InputPanel1.DataSource = this.employeesBindingSource;
            // TODO: This line of code loads data into the 'c1DemoDataSet.Employees' table.
            this.employeesTableAdapter.Fill(this.c1DemoDataSet.Employees);

        }
    }
}
