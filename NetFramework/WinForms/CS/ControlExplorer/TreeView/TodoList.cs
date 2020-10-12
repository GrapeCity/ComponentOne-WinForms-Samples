using C1.Win.TreeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.TreeView
{
    public partial class TodoList : C1DemoForm
    {
        public TodoList()
        {
            InitializeComponent();
            SetupTreeView();
        }

        private void SetupTreeView()
        {
            c1TreeView1.DataMember = "Cases";
            c1TreeView1.Columns[0].DisplayFieldName = "Case";
            c1TreeView1.KeyField = "ID";
            c1TreeView1.ParentKeyField = "ParentCaseID";
            c1TreeView1.DataSource = GetBindingSource();
            c1TreeView1.CheckStateChanged += C1TreeView1_CheckStateChanged;
        }

        private void C1TreeView1_CheckStateChanged(object sender, C1TreeViewEventArgs e)
        {
            foreach (C1TreeNode node in e.Node.Nodes)
                node.Checked = e.Node.Checked;
        }

        public BindingSource GetBindingSource()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = GetTodosSelfRefDataSet();
            bindingSource.DataMember = "Cases";
            return bindingSource;
        }

        public static DataSet GetTodosSelfRefDataSet()
        {
            DataSet dataSet = new DataSet();
            DataTable cases = new DataTable("Cases");

            cases.Columns.Add("ID", Type.GetType("System.Int32"));
            cases.Columns.Add("ParentCaseID", Type.GetType("System.Int32"));
            cases.Columns.Add("Case", Type.GetType("System.String"));

            cases.Rows.Add(new object[3] { 1, -1, "make dinner" });

            cases.Rows.Add(new object[3] { 10, 1, "cook pasta carbonara" });

            cases.Rows.Add(new object[3] { 100, 10, "buy spaghetti" });
            cases.Rows.Add(new object[3] { 101, 10, "buy bacon" });
            cases.Rows.Add(new object[3] { 102, 10, "buy eggs" });
            cases.Rows.Add(new object[3] { 103, 10, "buy Parmesan cheese" });
            cases.Rows.Add(new object[3] { 104, 10, "buy black pepper–coarsely ground" });
            cases.Rows.Add(new object[3] { 105, 10, "buy crushed garlic" });

            cases.Rows.Add(new object[3] { 11, 1, "buy bread" });
            cases.Rows.Add(new object[3] { 12, 1, "buy juice" });

            cases.Rows.Add(new object[3] { 120, 12, "apple" });
            cases.Rows.Add(new object[3] { 120, 12, "orange" });
            cases.Rows.Add(new object[3] { 121, 12, "carrot" });
            cases.Rows.Add(new object[3] { 122, 12, "pineapple" });
            cases.Rows.Add(new object[3] { 123, 12, "mango" });
            cases.Rows.Add(new object[3] { 124, 12, "banana" });

            cases.Rows.Add(new object[3] { 2, -1, "clean the apartment" });

            cases.Rows.Add(new object[3] { 20, 2, "kitchen" });

            cases.Rows.Add(new object[3] { 200, 20, "wash the dishes" });

            cases.Rows.Add(new object[3] { 21, 2, "bedroom" });
            cases.Rows.Add(new object[3] { 22, 2, "living room" });
            cases.Rows.Add(new object[3] { 23, 2, "bathroom" });

            cases.Rows.Add(new object[3] { 3, -1, "fill up the car with petrol" });

            cases.Rows.Add(new object[3] { 4, -1, "work" });

            cases.Rows.Add(new object[3] { 40, 4, "fix 3 issues" });
            cases.Rows.Add(new object[3] { 41, 4, "write sample with C1TreeView" });

            dataSet.Tables.Add(cases);

            return dataSet;
        }
    }
}
