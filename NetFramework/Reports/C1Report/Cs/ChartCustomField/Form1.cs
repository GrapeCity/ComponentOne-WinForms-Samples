using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ChartCustomField_2010
{
    public partial class Form1 : Form
    {
        private const string ReportFile = "ChartCustomField.xml";
        private readonly List<Button> _buttons=new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var top = labelSelectReport.Bounds.Bottom + 20;
            var left = labelSelectReport.Left;
            const int height = 40;
            const int width = 180;

            var reportNames = C1.C1Report.C1Report.GetReportList(ReportFile);
            foreach (var reportName in reportNames)
            {
                var button = new Button();
                button.SetBounds(left, top, width, height);
                button.Text = reportName;
                button.Font = new Font("Arial", 14f);
                Controls.Add(button);
                button.Click += button_Click;

                _buttons.Add(button);
                top += 45;
            }

            if (_buttons.Count>0)
            {
                _buttons[0].PerformClick();
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            var buttonSelected = sender as Button;
            if (buttonSelected == null) return;

            foreach (var button in _buttons)
            {
                button.BackColor = SystemColors.Control;
            }
            buttonSelected.BackColor = SystemColors.ControlDark;

            _ppv.Document = null;
            _ppv.PreviewPane.StatusText = "Generating report, this could take a few minutes...";
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                var report = new C1.C1Report.C1Report();
                var reportName = buttonSelected.Text;
                report.Load(ReportFile, reportName);

                switch (reportName)
                {
                    case "Scatter":
                    case "Histogram":
                        SetScatterData(report);
                        break;
                    case "Radar":
                        SetRadarData(report);
                        break;
                    case "Polar":
                        SetPolarData(report);
                        break;
                    case "Step":
                        SetStepData(report);
                        break;
                    case "Line":
                        SetLineData(report);
                        break;
                    default:
                        CorrectConnectionString(report);
                        break;
                }

                RenderReport(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error loading or rendering the report:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _ppv.PreviewPane.StatusText = "Ready";
                Cursor = Cursors.Default;
            }

        }

        private void SetScatterData(C1.C1Report.C1Report report)
        {
            var rnd = new Random();
            var table = new DataTable();
            table.Columns.Add("x", typeof (float));
            table.Columns.Add("y", typeof (float));

            for (int i = 0; i < 100; i++)
            {
                var row = table.NewRow();
                row[0] = (float) (100*rnd.NextDouble());
                row[1] = (float) (100*rnd.NextDouble());
                table.Rows.Add(row);
            }
            report.DataSource.Recordset = table;
        }

        private void SetRadarData(C1.C1Report.C1Report report)
        {
            var table = new DataTable();
            table.Columns.Add("x", typeof(string));
            table.Columns.Add("y", typeof(float));
            table.Columns.Add("y1", typeof(float));
            table.Columns.Add("y2", typeof(float));

            var xData = new []
            {"Introduce", "Response", "Travel Time", "Get On/Off", "Comfort", "Social", "Operate"};
            var yData = new [] { 2.8f, 3.5f, 3.3f, 2f, 4f, 3f, 2.9f };
            var y1Data = new [] { 3.2f, 3.3f, 3.5f, 2.4f, 3.8f, 3.4f, 4.2f };
            var y2Data = new [] { 3.6f, 5f, 3.3f, 5f, 3.6f, 4.3f, 3.8f };

            for (int i = 0; i < xData.Length; i++)
            {
                var row = table.NewRow();
                row[0] = xData[i];
                row[1] = yData[i];
                row[2] = y1Data[i];
                row[3] = y2Data[i];
                table.Rows.Add(row);
            }
            report.DataSource.Recordset = table;
        }

        private void SetPolarData(C1.C1Report.C1Report report)
        {
            var table = new DataTable();
            table.Columns.Add("x", typeof(int));
            table.Columns.Add("y", typeof(int));
            table.Columns.Add("y1", typeof(int));

            var xData = new[] { 0, 45, 90, 135, 180, 225, 270, 315 };
            var yData =  new [] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var y1Data = new [] { 8, 7, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < xData.Length; i++)
            {
                var row = table.NewRow();
                row[0] = xData[i];
                row[1] = yData[i];
                row[2] = y1Data[i];
                table.Rows.Add(row);
            }
            report.DataSource.Recordset = table;
        }

        private void SetStepData(C1.C1Report.C1Report report)
        {
            var table = new DataTable();
            table.Columns.Add("x", typeof(int));
            table.Columns.Add("y", typeof(double));

            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                var row = table.NewRow();
                row[0] = i;
                row[1] = 2 * (rnd.NextDouble() - 0.5);
                table.Rows.Add(row);
            }

            report.DataSource.Recordset = table;
        }

        private void SetLineData(C1.C1Report.C1Report report)
        {
            var table = new DataTable();
            table.Columns.Add("x", typeof(int));
            table.Columns.Add("y", typeof(double));

            var rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                var row = table.NewRow();
                row[0] = i;
                row[1] = 2 * (rnd.NextDouble() - 0.5);
                table.Rows.Add(row);
            }

            report.DataSource.Recordset = table;
        }

        private void RenderReport(C1.C1Report.C1Report report)
        {
            if (report.IsBusy) return;

            report.Render();
            _ppv.Document = report;
        }

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string connectionString = rep.DataSource.ConnectionString;
            if (string.IsNullOrEmpty(connectionString)) return;

            int dsIndexStart = connectionString.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (dsIndexStart < 0) return;

            while (dsIndexStart < connectionString.Length && connectionString[dsIndexStart] != '=') dsIndexStart++;
            if (dsIndexStart >= connectionString.Length)
                return;

            int dsIndexEnd = dsIndexStart;
            while (dsIndexEnd < connectionString.Length && connectionString[dsIndexEnd] != ';') dsIndexEnd++;

            string mdbName = connectionString.Substring(dsIndexStart + 1, dsIndexEnd - dsIndexStart - 1).Trim();
            if (mdbName.Length <= 0) return;

            mdbName = Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            connectionString = connectionString.Substring(0, dsIndexStart + 1) +
                               Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                               @"\ComponentOne Samples\Common\" +
                               mdbName +
                               connectionString.Substring(dsIndexEnd);

            rep.DataSource.ConnectionString = connectionString;

            foreach (C1.C1Report.Field field in rep.Fields)
                if (field.Subreport != null) CorrectConnectionString(field.Subreport);
        }
    }
}
