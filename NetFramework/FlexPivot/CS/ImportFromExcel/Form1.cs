using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using C1.DataEngine;
using System.Collections.Generic;
using System.Net;

namespace ImportFromExcel
{
    public partial class Form1 : Form
    {
        string dataPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data");
        string samplePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\TorontoParkingTickets.xlsx";

        public Form1()
        {
            // designer support
            InitializeComponent();

            // where DataEngine data is stored
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath);
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            // download sample data
            if (!File.Exists(samplePath) && !DownloadSample())
                return;

            // connect to sample data
            string tableName = GetFirstWorkbookTable();
            _c1FlexPivotPage.FlexPivotPanel.ConnectDataEngine(tableName);

            // show default view
            var engine = _c1FlexPivotPage.FlexPivotPanel.PivotEngine;
            engine.BeginUpdate();
            engine.RowFields.Add("infraction_description");
            engine.ValueFields.Add("tag_number_masked");
            engine.EndUpdate();
        }

        // data row item
        public class Ticket
        {
            public string tag_number_masked { get; set; }
            public DateTime? date_of_infraction { get; set; }
            public double? infraction_code { get; set; }
            public string infraction_description { get; set; }
            public double? set_fine_amount { get; set; }
            public double? time_of_infraction { get; set; }
            public string location1 { get; set; }
            public string location2 { get; set; }
            public string province { get; set; }

            // create item from a reader
            public Ticket(IDataReader reader)
            {
                tag_number_masked = reader.IsDBNull(0) ? null : reader.GetString(0);
                date_of_infraction = ConverDateOfInfraction(reader.IsDBNull(1) ? null : (double?)reader.GetDouble(1));
                infraction_code = reader.IsDBNull(2) ? null : (double?)reader.GetDouble(2);
                infraction_description = reader.IsDBNull(3) ? null : reader.GetString(3);
                set_fine_amount = reader.IsDBNull(4) ? null : (double?)reader.GetDouble(4);
                time_of_infraction = reader.IsDBNull(5) ? null : (double?)reader.GetDouble(5);
                location1 = reader.IsDBNull(6) ? null : reader.GetString(6);
                location2 = reader.IsDBNull(7) ? null : reader.GetString(7);
                province = reader.IsDBNull(8) ? null : reader.GetString(8);
            }

            // convert date format into a real date
            private DateTime? ConverDateOfInfraction(double? data)
            {
                if (data == null || !data.HasValue)
                    return null;
                string date = data.ToString();
                return new DateTime(int.Parse(date.Substring(0, 4)), int.Parse(date.Substring(4, 2)), int.Parse(date.Substring(6)));
            }

            public static IEnumerable<Ticket> GetTicletsInfo(IDataReader reader)
            {
                while (reader.Read())
                    yield return new Ticket(reader);
            }
        }

        // download sample workbook
        private bool DownloadSample()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                label1.Text = "Downloading sample data file...";
                Application.DoEvents();

                // create folder
                if (!Directory.Exists(Path.GetDirectoryName(samplePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(samplePath));

                int read = 0;
                byte[] buffer = new byte[2048];

                // create ftp request
                var request = (FtpWebRequest)WebRequest.Create("ftp://publicfiles.componentone.com/FlexPivot/TorontoParkingTickets.xlsx");
                request.Proxy = null;
                request.KeepAlive = true;
                request.UseBinary = true;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("anonymous", "*");
                using (var response = (FtpWebResponse)request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (var writer = new FileStream(samplePath, FileMode.OpenOrCreate))
                {
                    //write recieved data to a file
                    while (true)
                    {
                        read = stream.Read(buffer, 0, buffer.Length);
                        if (read == 0)
                            break;
                        writer.Write(buffer, 0, read);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    // delete the corrupted file
                    if (File.Exists(samplePath))
                        File.Delete(samplePath);
                }
                catch { }
                return false;
            }
            finally
            {
                label1.Text = string.Empty;
                Cursor = Cursors.Default;
            }
        }

        // get data from the sample workbook
        private string GetFirstWorkbookTable()
        {
            using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
            {
                Cursor = Cursors.WaitCursor;
                label1.Text = "Getting data from the sample workbook...";
                Application.DoEvents();

                conn.Open();

                // get workbook table list
                var tables = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                // get the name of the first table
                string name = tables.Rows[0]["TABLE_NAME"].ToString();

                // get data from the first table
                var command = new OleDbCommand("select * from [" + name + "]", conn);
                using (var reader = command.ExecuteReader())
                {
                    var connector = new ObjectConnector<Ticket>(_c1FlexPivotPage.FlexPivotPanel.Workspace, Ticket.GetTicletsInfo(reader));
                    connector.GetData(name);
                }

                label1.Text = string.Empty;
                Cursor = Cursors.Default;
                return name;
            }
        }


        // remove data generated by C1 DataEngine
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear();
            base.OnFormClosed(e);
        }

        // get sample Excel file connection string
        private string GetConnectionString(bool firstRowHasNames = true, bool mixedTypesAsText= true)
        {
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR={1};IMEX={2};ReadOnly=true\"";
            return string.Format(conn, samplePath, firstRowHasNames, mixedTypesAsText);
        }

    }
}
