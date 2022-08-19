using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples
{
    public partial class MailMessageForm : UserControl
    {
        public MailMessageForm()
        {
            InitializeComponent();
            SetupDataSource();
            Load += NewMessageForm_Load;
        }

        private void NewMessageForm_Load(object sender, EventArgs e)
        {
            ccMultiSelect.BindingInfo.DataSource = toMultiSelect.BindingInfo.DataSource = bindingSource1;
            ccMultiSelect.BindingInfo.DisplayMemberPath = toMultiSelect.BindingInfo.DisplayMemberPath = "email";                        
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
            foreach (DataRow row in dataTable.Rows)
            {
                row["full_name"] = row["first_name"] + " " + row["last_name"];
            }
            this.bindingSource1.DataSource = dataTable;
        }
    }
}
