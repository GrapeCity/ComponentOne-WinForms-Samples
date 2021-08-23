using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomFieldsTest_2010
{
    public partial class Form1 : Form
    {
        private const string ReportFile = "CustomFieldsDemo.xml";
        private readonly List<Button> _buttons = new List<Button>();

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
                button.SetBounds(left, top, width,height);
                button.Text = reportName;
                button.Font = new Font("Arial", 14f);
                Controls.Add(button);
                button.Click += button_Click;

                _buttons.Add(button);
                top += 45;
            }

            if (_buttons.Count > 0)
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

                CorrectConnectionString(report);
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

        private void RenderReport(C1.C1Report.C1Report rep)
        {
            if (rep.IsBusy) return;

            rep.Render();
            _ppv.Document = rep;
        }

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string connectionString = rep.DataSource.ConnectionString;

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
