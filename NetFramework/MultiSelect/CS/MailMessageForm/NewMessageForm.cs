using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailMessageForm
{
    public partial class NewMessageForm : Form
    {
        public NewMessageForm()
        {
            InitializeComponent();
            SetupDataSource();
            Load += NewMessageForm_Load;
        }

        private void NewMessageForm_Load(object sender, EventArgs e)
        {
            ccMultiSelect.BindingInfo.DataSource = toMultiSelect.BindingInfo.DataSource = bindingSource1;

            ccMultiSelect.BindingInfo.DisplayMemberPath = toMultiSelect.BindingInfo.DisplayMemberPath = "email";
            
            // todo: 
            // 1. bind TagsDataSource 
            // 2. ccMultiSelect.BindingInfo.HeaderMemberPath = toMultiSelect.BindingInfo.HeaderMemberPath = "full_name"; // implement this property
        }

        void SetupDataSource()
        {
            string fileName = "us-500.csv";

            string sql = @"SELECT * FROM [" + fileName + "]";
            DataTable dataTable = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + "//Resources" +
                      ";Extended Properties=\"Text;HDR=Yes\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);
            }

            // add calculated column to keep full name we need to display in UI
            dataTable.Columns.Add("full_name", typeof(string));
            foreach(DataRow row in dataTable.Rows)
            {
                row["full_name"] = row["first_name"] + " " + row["last_name"];
            }
            this.bindingSource1.DataSource = dataTable;
        }
    }
}
