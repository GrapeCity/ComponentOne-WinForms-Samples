using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using C1.DataEngine;
using System.Net;
using Office = Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using AddIn = C1.DataEngine.ExcelAddIn;


namespace PowerQueryConnection
{
    public partial class Form1 : Form
    {
        string dataPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data");
        string samplePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\TorontoParkingTickets.xlsx";
        private bool _workspaceInitialized = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Workspace_Initialize(object sender, EventArgs e)
        {
            _workspaceInitialized = true;
        }

        // get data from the sample workbook
        private void buttonGetData_Click(object sender, EventArgs e)
        {
            // download sample data
            if (!File.Exists(samplePath) && !DownloadSample())
                return;

            // connect to sample data
            string tableName = GetFirstWorkbookTable();
            _c1FlexPivotPage.FlexPivotPanel.ConnectDataEngine(tableName);

            // show default view
            var engine = _c1FlexPivotPage.FlexPivotPanel.FlexPivotEngine;
            engine.BeginUpdate();
            engine.RowFields.Add("infraction_description");
            engine.ValueFields.Add("tag_number_masked");
            engine.EndUpdate();
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

        // get data model from the sample workbook
        private string GetFirstWorkbookTable()
        {
            Excel.Application excel = null;
            Excel.Workbook workbook = null;
            Office.COMAddIn addin = null;
            AddIn.IDataModel dataModel = null;
            AddIn.IDataTable[] tables = null;
            try
            {
                // open the sample workbook
                this.Cursor = Cursors.WaitCursor;
                label1.Text = "Getting Data Model...";
                excel = new Excel.Application();
                workbook = excel.Workbooks.Open(samplePath);
                // get Excel add-in COM object
                addin = excel.COMAddIns.Item("C1.DataEngine.ExcelAddIn");
                dataModel = (AddIn.IDataModel)addin.Object;
                // get data model tables
                tables = dataModel.GetModelTables(excel.ActiveWorkbook);
                // import data model tables to C1 DataEngine tables
                label1.Text = "Importing Data Model...";
                dataModel.ExportToDataEngine(tables, dataPath);
                // initialize C1 DataEngine workspace
                // that must be done after export since export works in Excel process
                _c1FlexPivotPage.FlexPivotPanel.Workspace.Initialize += Workspace_Initialize;
                _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath);
                // returns the first imported table name
                return tables[0].Alias;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                // release COM objects
                ReleaseObject(tables);
                ReleaseObject(dataModel);
                ReleaseObject(addin);

                if (workbook != null)
                {
                    workbook.Close(false);
                    ReleaseObject(workbook);
                    workbook = null;
                }
                if (excel != null)
                {
                    excel.Quit();
                    ReleaseObject(excel);
                    excel = null;
                }
                this.Cursor = Cursors.Default;
                label1.Text = string.Empty;
            }
        }

        // release a COM object
        private void ReleaseObject(object obj)
        {
            try
            {
                int refs = 0;
                do { refs = System.Runtime.InteropServices.Marshal.ReleaseComObject(obj); }
                while (refs > 0);
            }
            catch { }
            finally
            {
                obj = null;
                GC.Collect();
            }
        }

        // remove data generated by C1 DataEngine
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Initialize -= Workspace_Initialize;
            if (_workspaceInitialized)
                _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear();
            base.OnFormClosed(e);
        }

    }
}
